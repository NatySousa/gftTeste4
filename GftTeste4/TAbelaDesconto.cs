using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GftTeste4
{
    public class TabelaDesconto
    {
        private double _valorCompra;

        public double ValorCompra
        {
            get { return _valorCompra; }
            set { _valorCompra = value; }
        }


        private double __desconto;

        public double Desconto
        {
            get { return __desconto; }
            set { __desconto = value; }
        }

        public void CalculcarDesconto()
        {
            int valor = 300;
            for (int i = 1; i <= 20; i++)
            {
                Console.WriteLine("Para compras a partir de " + valor + " desconto de " + i + "%");
                valor = valor + 100;
            }
        }
    }
}
