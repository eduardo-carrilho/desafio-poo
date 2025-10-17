using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace desafio_poo.Classes
{
    public class Proprietario
    {
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string CPF { get; set; }

        public Proprietario(string nome, string telefone, string cpf)
        {
            this.Nome = nome;
            this.Telefone = telefone;
            this.CPF = cpf;
        }

        public string contatoProprietario()
        {
            return $"Se tiver interesse nesse imóvel, pode entrar em contato com o(a) Sr(a) {this.Nome}, portador do CPF {this.CPF} através do telefone {this.Telefone}";
        }
    }
}
