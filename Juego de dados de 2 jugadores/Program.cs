using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Juego_de_dados_de_2_jugadores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Juego de dados entre 2 jugadores

            int puntaje1=0, puntaje2=0, turno=1, res=0;
            string nombre1 = "", nombre2 = "";
            Console.WriteLine("Escriba el nombre del jugador 1:");
            nombre1= Console.ReadLine();
            Console.WriteLine("Escriba el nombre del jugador 2:");
            nombre2= Console.ReadLine();
            do
            {
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("Es el turno {0} de jugador {1}", turno, nombre1);
                Console.WriteLine("Presione ENTER para tirar el dado");
                Console.ReadLine();

                Random dado = new Random();
                res = dado.Next(1, 6);
                puntaje1 = puntaje1 + res;
                Console.WriteLine("El dado saco {0}", res);
                Console.WriteLine("El jugador {0} lleva {1} puntos", nombre1, puntaje1);

                //Jugador 2
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Es el turno {0} de jugador {1}", turno, nombre2);
                Console.WriteLine("Presione ENTER para tirar el dado");
                Console.ReadLine();
                res = dado.Next(1, 6);
                puntaje2 = puntaje2 + res;
                Console.WriteLine("El dado saco {0}", res);
                Console.WriteLine("El jugador {0} lleva {1} puntos", nombre2, puntaje2);
                turno++;
            } while (turno <= 3);
            if (puntaje1 > puntaje2)
            {
                Console.ForegroundColor=ConsoleColor.Green;
                Console.WriteLine("El ganador es {0}", nombre1);
            }
            
            if (puntaje2 > puntaje1)
            {
                Console.ForegroundColor=ConsoleColor.Green;
                Console.WriteLine("El ganador es {0}", nombre2);
            }
            else
            {
                Console.ForegroundColor=ConsoleColor.Red;
                Console.WriteLine("EMPATE");
            }
            Console.WriteLine("El puntaje final es de {0} VS {1}", puntaje1, puntaje2);
            Console.ReadKey();

        }
    }
}
