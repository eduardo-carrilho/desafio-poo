using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace desafio_poo.Classes
{
    public class Imobiliaria
    {
        public string Nome { get; set; }

        public List<Imovel> ListaImoveis { get; set; }


        public Imobiliaria(string nome)
        {
            this.Nome = nome;
            this.ListaImoveis = [];
        }
    }
}