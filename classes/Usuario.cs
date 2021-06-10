using System;
using System.Collections.Generic;

namespace ProjetoProdutos.classes
{
    public class Usuario
    {
        private int Codigo { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        private DateTime DataCadastro = DateTime.Now;

        public List<Usuario> ListaUsuario = new List<Usuario>();

        public string Cadastrar(){

            Usuario usuario2 = new Usuario();

            Console.WriteLine("Digite seu nome:");
            usuario2.Nome = Console.ReadLine();

            Console.WriteLine("Digite seu email:");
            usuario2.Email = Console.ReadLine();

            Console.WriteLine("Digite sua senha:");
            usuario2.Senha = Console.ReadLine();

            ListaUsuario.Add(usuario2);

            Console.WriteLine("Cadastrado com sucesso!");

            return "Cadastrado";
        }

        public void Deletar(){         
            
            Nome = null;
            Email = null;
            Senha = null;

            // return "Deletado";
        }
    }
}