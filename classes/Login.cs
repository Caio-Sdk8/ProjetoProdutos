using System;

namespace ProjetoProdutos.classes
{
    public class Login
    {
        private bool Logado = false;
        private string Nome { get; set; }
        public string Email { get; set; }
        private string Senha { get; set; }

        public Login()
        {
            //     Console.WriteLine(@"
            // ____________________________
            //         1 - Login
            //         2 - Cadastro
            //         3 - Desligar
            // _____________________________
            //     ");
        }

        public Login()
        {
            
        }


        public string Logar(Usuario usuario)
        {

            Console.WriteLine("Insira seu email:");
            string EmailLog = Console.ReadLine();



            Usuario usuario1 = usuario.ListaUsuario.Find(item => item.Email == EmailLog);

 
            if (EmailLog == usuario1.Email)
            {
                Console.WriteLine("Insira sua senha");
                string SenhaLog = Console.ReadLine();
                Usuario usuario2 = usuario.ListaUsuario.Find(item => item.Senha == SenhaLog);

                if (SenhaLog == usuario2.Senha)
                {
                    Console.WriteLine();
                }else
                {
                    Console.WriteLine("Senha errada.");
                }
            }else
            {
                Console.WriteLine("Email Inválido");
            }

            return "";
        }

        public void Deslogar()
        {
            if (Logado == true)
            {
                Console.WriteLine("Deseja deslogar? (s/n)");
                string opcaoDslg = Console.ReadLine().ToLower();
                if (opcaoDslg == "s")
                {
                    Console.WriteLine("Deslogado.");
                }
            }
            else
            {
                Console.WriteLine("Impossível deslogar.");
            }
        }
    }
}