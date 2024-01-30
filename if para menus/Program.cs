using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace if_para_menus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //if para menus
            //crear un progarma que resuelva la ley de Ohm v=i*r 
            int opcion = 0;
            float v = 0, i = 0, r = 0;
            Console.WriteLine("Bienvenido al sistema, seleccione una opcion");
            Console.WriteLine("1.- Calcular voltaje");
            Console.WriteLine("2.- Calcular corriente");
            Console.WriteLine("3.- resistencia");
            opcion=Convert.ToInt32(Console.ReadLine());
            if (opcion == 1)
            {
                Console.WriteLine("Ingresa el valor de la corriente"); //calcular voltaje
                i = Convert.ToSingle(Console.ReadLine());
                Console.WriteLine("Ingresa el valor de la resistencia");
                r = Convert.ToSingle(Console.ReadLine());
                v = i * r;
                Console.WriteLine("El voltaje es igual a {0}", v);
            }
            else if (opcion == 2)
            {
                Console.WriteLine("Ingresa el valor de el voltaje"); //calcular corriente
                v = Convert.ToSingle(Console.ReadLine());
                Console.WriteLine("Ingresa el valor de la resistencia");
                r = Convert.ToSingle(Console.ReadLine());
                i = v/r;
                Console.WriteLine("El valor de la corriente es igual a {0}", i);
            }
            else if (opcion == 3) 
            {
                Console.WriteLine("Ingresa el valor de el voltaje"); //calcular resistencia
                v = Convert.ToSingle(Console.ReadLine());
                Console.WriteLine("Ingresa el valor de la corriente");
                i = Convert.ToSingle(Console.ReadLine());
                r = v / i;
                Console.WriteLine("El valor de la resistencia es igual a {0}", r);
            }
            Console.ReadKey();

        }
    }
}
