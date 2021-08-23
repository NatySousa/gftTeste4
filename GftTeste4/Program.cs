using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GftTeste4
{
    class Program
    {
        static void Main(string[] args)
        {
            TabelaDesconto t = new TabelaDesconto();

            t.CalculcarDesconto();

            Console.ReadKey();
        }
    }
}
