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

            if(this.Alugado)
            {
                return $"A casa está alugada";
            }else return $"A casa está disponível";
        }

        public override decimal CalcularAluguel(int dias)
        {
            throw new NotImplementedException();
        }
    }
}