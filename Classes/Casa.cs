using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace desafio_poo.Classes
{
    public class Casa : Imovel
    {
        public Casa(int id, string endereco, int numero, Proprietario proprietario) : base(id, endereco, numero, proprietario)
        {
        }

        public override string ObterStatusAluguel()
        {

            if(this.estaAlugado())
            {
                return $"A casa está alugada";
            }else return $"A casa está disponível";
        }

        public override decimal CalcularAluguel(int dias)
        {
            decimal valorDiario = 150m; 
            if (dias <= 0) return 0;
            return valorDiario * dias;
        }
    }
}
