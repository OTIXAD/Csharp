using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tipo_de_empleado
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Solicitar el tipo de empleado entre: asistente, administrativo, chofer y gerente, solictar horas laboradas
            //asistente= 45 la hora, administrativo=60, chofer=50, gerente=75.
            float horas = 0, paga=0;
            string tipo;
            Console.WriteLine("Bienvenido, que tipo de empleado eres? (asistente, administrativo, chofer, gerente)");
            tipo = Console.ReadLine();
            Console.WriteLine("Ingresa tus horas laboradas el dia de hoy:");
            horas = Convert.ToSingle(Console.ReadLine());
            switch (tipo)
            {
                case "asistente":
                    paga = horas * 45;
                    Console.WriteLine("Su paga el dia de hoy es de {0}", paga);
                    break;
                case "administrativo":
                    paga = horas * 60;
                    Console.WriteLine("Su paga el dia de hoy es de {0}", paga);
                    break;
                case "chofer":
                    paga = horas * 50;
                    Console.WriteLine("Su paga el dia de hoy es de {0}", paga);
                    break;
                case "gerente":
                    paga = horas * 75;
                    Console.WriteLine("Su paga el dia de hoy es de {0}", paga);
                    break;
                default:
                    Console.WriteLine("Favor de ingresar uno de los tipos");
                    break;
            }
            Console.ReadKey();
        }
    }
}
