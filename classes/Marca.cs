using System;
using System.Collections.Generic;

namespace ProdutosProj.classes
{
    public class Marca : IMarca
    {
        public int Codigo;

        public string NomeMarca;

        private DateTime DataCadastro;

        public List<Marca> marcas = new List<Marca>();

        public Marca(){
            DataCadastro = DateTime.Now;
        }

         public void Cadastrar(Marca Marca)
        {
            marcas.Add(Marca);
        }
         
        public void Deletar(Marca marca)
        {
            Console.WriteLine("Qual o código da marca que deseja apagar?");
            int code = int.Parse(Console.ReadLine());

            marcas.RemoveAll(item => item.Codigo == code);
        }

        public void Listar()
        {
            foreach(Marca item in this.marcas){
            
            Console.WriteLine($@"
            Nome da marca: {item.NomeMarca}
            Código da marca: {item.Codigo}
            Data de cadastro da marca: {item.DataCadastro}");
            }
        }
    }
}