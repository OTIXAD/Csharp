using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mascota_virtual
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Crear una mascota virtual que ejecute las acciones de: comer, domir, jugar y morir
            //Si el usario selecciona morir el programa termina
            string nombre = "";
            int opcion = 0;
            Console.WriteLine("Cual es el nombre de tu mascota");
            nombre=Console.ReadLine();
            Console.WriteLine("Que deseas hacer con {0}", nombre);
            Console.WriteLine("1.-Darle de comer");
            Console.WriteLine("2.-Llevarlo a dormir");
            Console.WriteLine("3.-Jugar con el");
            Console.WriteLine("4.-Matarlo");
            opcion =Convert.ToInt32(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.WriteLine("{0} esta comiendo", nombre);
                    break;
                case 2:
                    Console.WriteLine("{0} fue a dormir un rato", nombre);
                    break;
                case 3:
                    Console.WriteLine("{0} esta feliz porque esta jugando", nombre);
                    break;
                case 4:
                    Console.WriteLine("{0} ha muerto :(", nombre);
                    break;
                default:
                    Console.WriteLine("{0} ha muerto por culpa de tus malos cuidados >:v ", nombre);
                    break;
            }
            Console.ReadKey();
        }
    }
}
