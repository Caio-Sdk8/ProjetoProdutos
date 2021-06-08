using System;
using System.Collections.Generic;

namespace ProdutosProj.classes
{
    public class Marca : IMarca
    {
        public int Codigo;

        public string NomeMarca;

        private DateTime DataCadastro;

        List<Marca> marcas = new List<Marca>();

        public Marca( ){
            DataCadastro = DateTime.Now;
        }

         public void Cadastrar(Marca Marca)
        {
            this.marcas.Add(Marca);
        }

        public void Deletar(Marca marcas)
        {
            Console.WriteLine("Qual o código da marca que deseja apagar?");
            int code = int.Parse(Console.ReadLine());

            this.marcas.RemoveAll(item => item.Codigo == code);
        }

        public void Listar()
        {
            foreach(Marca item in this.marcas){
            
            Console.WriteLine($@"
            Nome da marca: {NomeMarca}
            Código da marca: {Codigo}
            Data de cadastro da marca: {DataCadastro}");
            }
        }
    }
}