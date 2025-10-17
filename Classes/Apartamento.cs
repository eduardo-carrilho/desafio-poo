using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace desafio_poo.Classes
{
    public class Apartamento : Imovel
    {

        public override string ObterStatusAluguel()
        {
            if(this.Alugado)
            {
                return $"O apartamento nº {this.Numero} está alugado";
            }
            return $"O apartamento nº {this.Numero} está disponível";
        }

        public override decimal CalcularAluguel(int dias)
        {
            throw new NotImplementedException();
        }

        
        
    }
}