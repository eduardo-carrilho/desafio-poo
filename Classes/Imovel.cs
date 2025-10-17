using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace desafio_poo.Classes
{
    public abstract class Imovel
    {
        protected int Id { get; set; }
        protected string Endereco { get; set; }
        protected int Numero { get; set; }
        protected bool Alugado { get; set; }
        protected Proprietario Proprietario { get; set; }

        public Imovel(int id, string endereco, int numero, Proprietario proprietario){
            this.Id = id;
            this.Endereco = endereco;
            this.Numero = numero;
            this.Proprietario = proprietario;
            this.Alugado = false;
        }

        public abstract decimal CalcularAluguel(int dias);

        public virtual string ObterStatusAluguel()
        {
            if (this.Alugado)
            {
                return $"Esse imóvel está alugado";
            }
            else
            {
                return $"Esse imóvel não está alugado";
            }
        }


        public void Alugar()
        {
            if(this.Alugado)
            {
                Console.WriteLine("Impossível alugar esse imóvel pois ele já está alugado.");
            }
            else
            {
                this.Alugado = true;
            }
        }

        public void Disponibilizar()
        {
            if(!this.Alugado)
            {
                Console.WriteLine("Impossível disponibilizar esse imóvel pois ele não está alugado.");
            }
            else
            {
                this.Alugado = false;
            }
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

        public int puxarId()
        {
            return this.Id;
        }

        public bool estaAlugado()
        {
            return this.Alugado;
        }
        public Proprietario puxarProprietario()
        {
            return this.Proprietario;
        }
    }
}
