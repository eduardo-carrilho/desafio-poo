using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace desafio_poo.Classes
{
    public class Apartamento : Imovel
    {
        public override decimal CalcularAluguel(int dias)
        {
            throw new NotImplementedException();
        }

        public override string ObterStatusAluguel()
        {
            return "Placeholder";
        }

        
    }
}