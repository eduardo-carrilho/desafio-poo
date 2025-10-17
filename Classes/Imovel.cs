using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace desafio_poo.Classes
{
    public abstract class Imovel
    {
        protected int ind { get; set; }
        protected string Endereco { get; set; }
        protected int Numero { get; set; }
        protected bool Alugado { get; set; }
        protected Proprietario Proprietario { get; set; }

        public virtual string ObterStatusAluguel()
        {
            if(this.Alugado)
            {
                return $"Esse imóvel está alugado";
            }
            else
            {
                return "Esse imovél não está alugado";
            }
        }

        public string contatoProprietario()
        {
            return $"Se tiver interesse nesse imóvel, pode entrar em contato com o(a) Sr(a) {this.Proprietario.Nome}, portador do CPF {this.Proprietario.CPF} através do telefone ${this.Proprietario.Telefone}";
        }

        public abstract int calcularAluguel(int dias);

        public void Alugar()
        {

        }

        public void Disponibilizar()
        {
            
        }

        public void alterarEndereco(string novoEndereco)
        {
            this.Endereco = novoEndereco;
        }

        public string puxarEndereco()
        {
            return this.Endereco;
        }

        public void alterarNumero(int novoNumero)
        {
            this.Numero = novoNumero;
        }

    }
}