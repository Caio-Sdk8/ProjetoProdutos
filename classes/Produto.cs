using System;
using System.Collections.Generic;

namespace ProjetoProdutos.classes
{
    public class Produto : IProduto
    {
        public int Codigo;

        public string NomeProduto;

        public float Preco;

        public DateTime DataCadastro;

        public string Marca;

        public string CadastradoPor;

        List<Produto> produtos = new List<Produto>();

         public Produto( ){
            DataCadastro = DateTime.Now;
        }

         public void cadastrar(Produto produto)
        {
            produtos.Add(produto);
        }

        public void deletar(Produto produto)
        {
            Console.WriteLine("Qual o código do produto que deseja apagar?");
            int code = int.Parse(Console.ReadLine());

            this.produtos.RemoveAll(item => item.Codigo == code);
        }

        public void listar()
        {
            foreach(Produto item in this.produtos){
            
            Console.WriteLine($@"
            Nome do produto: {item.NomeProduto}
            Código do produto: {item.Codigo}
            Data de cadastro do produto: {item.DataCadastro}
            Cadastrado por: {item.CadastradoPor}
            Preço do produto: {item.Preco:C2}
            Marca do produto: {item.Marca}");
            }
        }
    }
}