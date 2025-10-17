using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace desafio_poo.Classes
{
    public class Casa : Imovel
    {
        public override string ObterStatusAluguel()
        {
            return "Placheholder";
        }

        public override decimal calcularAluguel(int dias)
        {
            throw new NotImplementedException();
        }
    }
}