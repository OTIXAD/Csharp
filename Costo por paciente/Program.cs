using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Costo_por_paciente
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Se necesita un sistema para calcular el costo por paciente en un hospital, tomando en cuenta que pod dia,
            //se tiene la enfermedad 1 el cossto es de $1200, enfermedad 2 $1500, enfermedad 3 de $1700 y enfermedad 4 de $2100.
            int enfermedad = 0, dias=0, costo;
            Console.WriteLine("Que tipo de enfermedad tienes: \n1.-Infeccion\n2.-Covid-19\n3.-Anemia\n4.-Tuberculosis");
            enfermedad=Convert.ToInt32(Console.ReadLine());

            switch (enfermedad)
            {
                case 1:
                    Console.WriteLine("Cuantos dias estuviste en el hospital");
                    dias = Convert.ToInt32(Console.ReadLine());
                    costo = dias * 1200;
                    Console.WriteLine("El costo final de tu cuenta por Infeccion, duarante {0} dias, es de ${1}",dias,costo);
                    break;
                case 2:
                    Console.WriteLine("Cuantos dias estuviste en el hospital");
                    dias = Convert.ToInt32(Console.ReadLine());
                    costo = dias * 1500;
                    Console.WriteLine("El costo final de tu cuenta por Covid-19, duarante {0} dias, es de ${1}", dias, costo);
                    break;
                case 3:
                    Console.WriteLine("Cuantos dias estuviste en el hospital");
                    dias = Convert.ToInt32(Console.ReadLine());
                    costo = dias * 1200;
                    Console.WriteLine("El costo final de tu cuenta por Anemia, duarante {0} dias, es de ${1}", dias, costo);
                    break;
                case 4:
                    Console.WriteLine("Cuantos dias estuviste en el hospital");
                    dias = Convert.ToInt32(Console.ReadLine());
                    costo = dias * 1200;
                    Console.WriteLine("El costo final de tu cuenta por Tuberculosis, duarante {0} dias, es de ${1}", dias, costo);
                    break;
                default:
                    Console.WriteLine("Jamas estuviste en el hospital, todo esta en tu mente");
                    break;
            }
            Console.ReadKey();
        }
    }
}
