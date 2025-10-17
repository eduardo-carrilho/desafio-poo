using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace desafio_poo.Classes
{
    public class Apartamento : Imovel
    {

        protected int NumeroApartamento { get; set; }
        public Apartamento(int id, string endereco, int numero, Proprietario proprietario, int numeroApartamento) : base(id, endereco, numero, proprietario)
        {
            this.NumeroApartamento = numeroApartamento;
        }

        public override string ObterStatusAluguel()
        {
            if(this.estaAlugado())
            {
                return $"O apartamento nº {this.NumeroApartamento} está alugado";
            }
            return $"O apartamento nº {this.NumeroApartamento} está disponível";
        }

        public override decimal CalcularAluguel(int dias)
        {
            decimal valorDiario = 100m;
            if (dias <= 0) return 0;
            return valorDiario * dias;
        }      
    }
}
