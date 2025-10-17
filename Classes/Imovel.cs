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
        public Proprietario Proprietario { get; set; }

        public abstract bool estaAlugado();

        public string contatoProprietario()
        {
            return $"Se tiver interesse nesse imóvel, pode entrar em contato com o(a) Sr(a) {this.Proprietario.Nome}, portador do CPF {this.Proprietario.CPF} através do telefone ${this.Proprietario.Telefone}";
        }

        public int calcularAluguel(int anos)
        {
            return anos;
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

        public int puxarNumero()
        {
            return this.Numero;
        }

        public void alterarStatusAluguel()
        {
            this.Alugado = !this.Alugado;
        }

    }
}