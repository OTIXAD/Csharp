using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juego_de_apuestas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Programa de juesgos de apuestas, en el cual hay que seleccionar un numero entre 1 y 10 usando una funcion random,
            //por cada turno jugado y perdido aumentar en 1 el premio
            int numhumano = 0, nummaquina = 0, premio = 1;
            char r;
            do
            {
                Console.Clear(); //limpiar pantalla
                Console.WriteLine("A que numero deseas apostar?");
                numhumano = Convert.ToInt32(Console.ReadLine());
                Random x = new Random();
                nummaquina = x.Next(1, 10); //rango de valores en que se genera 
                if (numhumano == nummaquina)
                {
                    Console.WriteLine("You Win, te llevas ${0}", premio);
                    premio = 1;
                }
                else
                {
                    Console.WriteLine("You Lose, ha salido {0}", nummaquina);
                    premio++;
                }
                Console.WriteLine("Quieres volver a jugar? (s/n)");
                r = Convert.ToChar(Console.ReadLine());
            } while (r == 's' || r == 'n');
            Console.ReadKey();
        }
    }
}
