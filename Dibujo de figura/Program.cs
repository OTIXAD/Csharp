using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dibujo_de_figura
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //figuras (cuadrado)
            /*int lineas = 5;
            for(int x=1; x<=lineas; x++)
            {
                Console.WriteLine("+++++");
            }
            Console.ReadKey();
            */
            //Triangulo
            /*
            int lineas = 7;
            string cruz = "+";
            for (int x = 1; x <= lineas; x++)
            {
                Console.WriteLine(cruz);
                cruz = cruz + "+";
            }
            Console.ReadKey();
            */
            //Triangulo invertido
            /*
            int lineas = 7;
            string cruz = "+++++++";
            for (int x = 1; x <= lineas; x++)
            {
                Console.WriteLine(cruz);
                cruz = cruz.Remove(0, 1);
            }
            Console.ReadKey();
            */
            //Triangulo Ultimate
            int lineas = 7;
            string cruz = "+";
            for (int x = 1; x <= lineas; x++)
            {
                Console.WriteLine(cruz);
                cruz = cruz + "+";
            }
            string cruze = "+++++++";
            for (int x = 1; x <= lineas; x++)
            {
                Console.WriteLine(cruze);
                cruze = cruze.Remove(0, 1);
            }
            Console.ReadKey();
        }
    }
}
