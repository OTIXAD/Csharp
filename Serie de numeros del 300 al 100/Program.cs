using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serie_de_numeros_del_300_al_100
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crear una serie de numeros del 300 al 100 con un decremento de 4 en 4
            int numero = 0, nf=0,decremento=0;
            string opcion;
            Console.WriteLine("Ingresa el numero inicial");
            numero=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Que desea incremento o decremento");
            opcion=Console.ReadLine();
            Console.WriteLine("Ingresa el numero con el que termina:");
            nf = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingresa el decremento o incremento:");
            decremento=Convert.ToInt32(Console.ReadLine());
            switch (opcion)
            { 
                case "decremento":
             do
             {
                Console.WriteLine(numero);
                numero = numero - decremento;
             }while (numero >=nf);
                break;
            }
            switch (opcion)
            {
                case "incremento":
                    do
                    {
                        Console.WriteLine(numero);
                        numero = numero + decremento;
                    } while (numero <= nf);
                    break;
            }
            Console.ReadKey();
        }
    }
}
