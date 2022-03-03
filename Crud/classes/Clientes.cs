using System;

namespace Crud
{
    public class Clientes : EntidadeBase
    {
        //Atributos

        public Clientes(string nome, int cPF, string endereco, Genero genero)
        {
            this.Nome = nome;
            this.CPF = cPF;
            this.Endereco = endereco;
            this.Genero = genero;
            this.Excluido = false;

        }
        private string Nome { get; set; }
        private int CPF { get; set; }
        private string Endereco { get; set; }
        private Genero Genero { get; set; }
        public bool Excluido { get; set; }

        //Metodos


        public override string ToString()
        {
            string retorno = "";
            retorno += "Nome" + this.Nome + Environment.NewLine;
            retorno += "CPF" + this.CPF + Environment.NewLine;
            retorno += "Endereco" + this.Endereco + Environment.NewLine;
            retorno += "Genero" + this.Genero;

            return retorno;
        }

        public string retornaNome()
        {
            return this.Nome;
        }

        public int retornaId()
        {
            return this.Id;
        }
        public void Excluir()
        {
            this.Excluido = true;
        }
    }
}
