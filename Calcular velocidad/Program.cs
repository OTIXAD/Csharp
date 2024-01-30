using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calcular_velocidad
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //calcular velocidad
            int opcion = 0;
            float v = 0, d = 0, t = 0;
            Console.WriteLine("Elige que desea calcular:");
            Console.WriteLine("1.- Velocidad");
            Console.WriteLine("2.- Distancia");
            Console.WriteLine("3.-Tiempo");
            opcion=Convert.ToInt32(Console.ReadLine());
            if (opcion==1)
            {
                Console.WriteLine("Ingresa la distancia en km:");
                d=Convert.ToSingle(Console.ReadLine());
                Console.WriteLine("Ingresa el tiempo en horas:");
                t = Convert.ToSingle(Console.ReadLine());
                v = d / t;
                Console.WriteLine("La velociadad es de: {0} km/h", v);
            }
            else if (opcion==2)
            {
                Console.WriteLine("Ingresa la velocidad en km/h:");
                v = Convert.ToSingle(Console.ReadLine());
                Console.WriteLine("Ingresa el tiempo en horas:");
                t = Convert.ToSingle(Console.ReadLine());
                d = v*t;
                Console.WriteLine("La distancia es de: {0} km", d);
            }
            else if (opcion==3)
            {
                Console.WriteLine("Ingresa la distancia en km:");
                d = Convert.ToSingle(Console.ReadLine());
                Console.WriteLine("Ingresa la velociadad en km/h:");
                v = Convert.ToSingle(Console.ReadLine());
                t = d / v;
                Console.WriteLine("El tiempo es de: {0} km", t);
            }
            Console.ReadKey();
        }
    }
}
