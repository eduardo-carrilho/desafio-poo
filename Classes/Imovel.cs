using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace desafio_poo.Classes
{
    public abstract class Imovel
    {
        protected string Endereco { get; set; }
        protected int Numero { get; set; }
        protected bool Alugado { get; set; }
        public string Proprietario { get; set; }

        public bool estaAlugado()
        {
            return this.Alugado;
        }

        public string contatoProprietario()
        {
            return $"O nome do proprietário é {this.Proprietario}";
        }

        public int calcularAluguel(int anos)
        {
            return anos;
        }


    }
}