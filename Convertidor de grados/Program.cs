using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convertidor_de_grados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Grados centigrados a grados Fahrenheit o al reves
            int opcion = 0;
            Console.WriteLine("Ingresa que deseas convertir:");
            Console.WriteLine("1=Grados celsius a Fahrenheit, 2= grados Fahrenheit a celsius");
            opcion=Convert.ToInt32(Console.ReadLine());
            switch(opcion)
            {
                case 1:
                    float gc = 0, resultado=0;
                    Console.WriteLine("Has elegido convertir de grados celsius a grados Fahrenheit");
                    Console.WriteLine("Ingresa los grados celsius a convertir:");
                    gc=Convert.ToSingle(Console.ReadLine());
                    resultado = (gc * 9 / 5) + 32;
                    Console.WriteLine("{0} grados celsius, son {1} grados Fahrenheit",gc, resultado);
                    break;

                case 2:
                    float gf = 0, res = 0;
                    Console.WriteLine("Has elegido convertir de grados Fahrenheit a Celsius");
                    Console.WriteLine("Ingresa los grados Fahrenheit a convertir:");
                    gf = Convert.ToSingle(Console.ReadLine());
                    res = (gf - 32) * 5 / 9;
                    Console.WriteLine("{0} grados Fahrenheit, son {1} grados Celsius", gf, res);
                    break;
            }
            Console.ReadKey();

        }
    }
}
