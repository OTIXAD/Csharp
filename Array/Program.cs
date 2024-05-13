using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //arrays
            int longi = 0;
            Console.WriteLine("Cuantas espacios se registraran?");
            longi=Convert.ToInt32(Console.ReadLine());
            int[] edades = new int[longi];//array dinamico
            for(int posi=0; posi<edades.Length; posi++)
            {
                Console.WriteLine("Ingresa tu edad de la persona {0}", posi+1);
                edades[posi] = Convert.ToInt32(Console.ReadLine());
            }
            for (int posi = 0; posi < edades.Length; posi++)
            {
                Console.Write(edades[posi]+", ");
            }

            Console.ReadKey();
        }
    }
}
