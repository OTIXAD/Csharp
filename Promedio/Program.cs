using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Promedio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Obtener el promedio de un alumno que cursa 5 materias, si el promedio es menor a 70, reprobado, si es mayor igual a 80, regular
            //menor igual a 90, bien, mayor de 90 y menor de 100, muy bien, igual a 100, excelente
            int m1 = 0, m2 = 0, m3 = 0, m4 = 0, m5 = 0;
            float promedio = 0;
            Console.WriteLine("Bienvenido al programa para calcular tu promedio escolar");
            Console.WriteLine("Ingresa tu calificacion de la materia 1:");
            m1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingresa tu calificacion de la materia 2:");
            m2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingresa tu calificacion de la materia 3:");
            m3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingresa tu calificacion de la materia 4:");
            m4 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingresa tu calificacion de la materia 5:");
            m5 = Convert.ToInt32(Console.ReadLine());
            promedio=(m1+m2+m3+m4+m5)/5;
            Console.WriteLine("Tu promedio general es de: {0}", promedio);
            if (promedio < 70)
            {
                Console.WriteLine("REPROBADO");
            }
            else if (promedio >= 70 && promedio <= 80)
            {
                Console.WriteLine("REGULAR");
            }
            else if (promedio > 80 && promedio <= 90)
            {
                Console.WriteLine("BIEN");
            }
            else if (promedio > 90 && promedio < 100)
            {
                Console.WriteLine("MUY BIEN");
            }
            else if (promedio == 100)
            {
                Console.WriteLine("EXCELENTE");
            }
            Console.ReadKey();
        }
    }
}
