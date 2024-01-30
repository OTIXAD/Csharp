using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Tipo_de_traingulo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Solicitar medidas de los lados de un triangulo y mostrar que tipo de traingulo es
            float l1=0, l2=0, l3=0;
            Console.WriteLine("Ingresa la medida del primer lado:");
            l1=Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Ingresa la medida del segundo lado:");
            l2 = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Ingresa la medida del tercer lado:");
            l3 = Convert.ToSingle(Console.ReadLine());
            if (l1 ==l2 && l1==l3 && l2==l3)
            {
                Console.WriteLine("EL triangulo es de tipo Equilatero");
            }
            else if (l1==l2 && l1!=l3 || l1==l3 && l1!=l2 ||  l2==l3 && l2!=l1)
            {
                Console.WriteLine("El triangulo es de tipo Isoceles");
            }
            else if (l1!=l2 && l1!=l3 && l2!=l3)
            {
                Console.WriteLine("El triangulo es de tipo Escaleno");
            }
            else if (l1==0 ||  l2==0 || l3==0)
            {
                Console.WriteLine("No se puede procesar el numero 0");
            }
            Console.ReadKey();
        }
    }
}
