using System;
using ProdutosProj.classes;
using ProjetoProdutos.classes;

namespace ProdutosProj
{
    class Program
    {
        static void Main(string[] args)
        {
            bool repete1 = false;
            Produto produtos = new Produto();
            Marca marcas = new Marca();

            do
            {
                Console.WriteLine(@"
                _______________________________________________________________________________
                |                          BEM VINDO AO MENU PRINCIPAL                        |
                |                             SELECIONE UMA OPÇÃO                             |
                |                        1 - Ir para a tela de Marcas                         |
                |                        2 - Ir para a tela de produtos                       |
                |                        3 - Ir a tela de usuarios                            |
                |                        0 - Fazer login                                      |
                |_____________________________________________________________________________|");
                int resposta1 = int.Parse(Console.ReadLine());

                switch (resposta1)
                {
                    case 1:
                        bool repete = false;
                        do
                        {
                            Console.WriteLine(@"
                _______________________________________________________________________________
                |                           BEM VINDO AO MENU MARCAS                          |
                |                             SELECIONE UMA OPÇÃO                             |
                |                        1 - Cadastrar uma marca                              |
                |                        2 - Listar marcas cadastradas                        |
                |                        3 - Deletar marca                                    |
                |                        0 - Voltar ao menu principal                         |
                |_____________________________________________________________________________|");
                            int resposta = int.Parse(Console.ReadLine());

                            switch (resposta)
                            {
                                case 1:
                                    Marca marquinha = new Marca();
                                    Console.WriteLine("Qual o código da marca?");
                                    marquinha.Codigo = int.Parse(Console.ReadLine());
                                    Console.WriteLine("Qual o nome da marca?");
                                    marquinha.NomeMarca = Console.ReadLine();

                                    marcas.Cadastrar(marquinha);
                                    repete = true;
                                    break;
                                case 2:
                                    marcas.Listar();
                                    repete = true;
                                    break;
                                case 3:
                                    marcas.Deletar(marcas);
                                    repete = true;
                                    break;
                                case 0:
                                    repete = false;
                                    break;
                                default:
                                    break;
                            }
                        } while (repete);
                        repete1 = true;
                        break;
                    case 2:
                        bool repete2 = false;
                        do
                        {
                            Console.WriteLine(@"
                _______________________________________________________________________________
                |                         BEM VINDO AO MENU PRODUTOS                          |
                |                             SELECIONE UMA OPÇÃO                             |
                |                        1 - Cadastrar um produto                             |
                |                        2 - Listar produtos                                  |
                |                        3 - Deletar um produto                               |
                |                        0 - Voltar ao menu principal                         |
                |_____________________________________________________________________________|");
                            int resposta = int.Parse(Console.ReadLine());

                            switch (resposta)
                            {
                                case 1:
                                bool crburro = false;
                                    Produto produtinho = new Produto();
                                    Console.WriteLine("Qual o código do produto?");
                                    produtinho.Codigo = int.Parse(Console.ReadLine());
                                    Console.WriteLine("Qual o nome do produto?");
                                    produtinho.NomeProduto = Console.ReadLine();
                                    Console.WriteLine("Qual o preço do produto?");
                                    produtinho.Preco = float.Parse(Console.ReadLine());
                                    do
                                    {
                                        
                                        Console.WriteLine("Escolha uma das marcas cadastradas");
                                        foreach (Marca item in marcas.marcas)
                                        {
                                            Console.WriteLine($@"{item.NomeMarca}");
                                        }
                                        string marca = Console.ReadLine();

                                        Marca marcoso = marcas.marcas.Find(item => item.NomeMarca == marca);

                                        if (marcoso != null)
                                        {
                                            produtinho.Marca = marcoso.NomeMarca;
                                            crburro = false;
                                        }
                                        else
                                        {
                                            Console.WriteLine("A marca escolhida não existe, digite uma existente.");
                                            crburro = true;
                                        }

                                    } while (crburro);

                                    produtos.cadastrar(produtinho);
                                    repete2 = true;
                                    break;
                                case 2:
                                    produtos.listar();
                                    repete2 = true;
                                    break;
                                case 3:
                                    produtos.deletar(produtos);
                                    repete2 = true;
                                    break;
                                case 0:
                                    repete2 = false;
                                    break;
                                default:
                                    break;
                            }
                            repete1 = true;

                        } while (repete2);
                        break;
                    case 0:
                        repete1 = false;
                        break;
                    default:
                        break;
                }

            } while (repete1);






        }
    }
}
