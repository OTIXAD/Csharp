using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace serie_de_numeros
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crear una serie de nuemros del 1 al 100.
            int x = 1;
            do
            {
                Console.WriteLine(x);
                x++;
            } while (x <=100);
            Console.ReadKey();
        }
    }
}
