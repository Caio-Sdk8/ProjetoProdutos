using System;

namespace ProdutosProj.classes
{
    public class Marca : IMarca
    {
        private int Codigo;

        private string NomeMarca;

        private string DataCadastro = DateTime.Now.ToString();
        public void Cadastrar(Marca Marca)
        {
            throw new System.NotImplementedException();
        }

        public void Deletar()
        {
            throw new System.NotImplementedException();
        }

        public void Listar()
        {
            throw new System.NotImplementedException();
        }
    }
}