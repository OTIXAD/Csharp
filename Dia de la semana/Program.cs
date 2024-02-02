using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dia_de_la_semana
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Obtener un numero entre el 1 y 7 y mostrar el dia de la semana que corresponde
            int dia = 0;
            Console.WriteLine("Escribe un numero entre 1 y 7");
            dia=Convert.ToInt32(Console.ReadLine());
            switch (dia)
            {
                case 1:
                    Console.WriteLine("Es Lunes");
                    break;
                case 2:
                    Console.WriteLine("Es Martes");
                    break;
                case 3:
                    Console.WriteLine("Es Miercoles");
                    break;
                case 4:
                    Console.WriteLine("Es Jueves");
                    break;
                case 5:
                    Console.WriteLine("Es Viernes");
                    break;
                case 6:
                    Console.WriteLine("Es Sabado");
                    break;
                case 7:
                    Console.WriteLine("Es Domingo");
                    break;
                default:
                    Console.WriteLine("Tiene que ser del 1 al 7");
                    break;
            }
            Console.ReadKey();
        }
    }
}
