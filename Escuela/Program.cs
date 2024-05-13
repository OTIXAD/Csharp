using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escuela
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //crear un programa que solicite numero de alumnos, materias, nombre de alumno, promedio de alumno, promedio de grupo
            int numalumnos = 0, nummaterias = 0;
            float promediogrupal = 0, promedioalumno = 0;

            Console.WriteLine("Ingresa la cantidad de alumnos:");
            numalumnos=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingresa la cantidad de materias:");
            nummaterias=Convert.ToInt32(Console.ReadLine());

            string[] nombres = new string[numalumnos];
            float[] calmaterias = new float[numalumnos];
            for(int posicion=0; posicion<numalumnos; posicion++)
            {
                promedioalumno = 0;
                Console.WriteLine("Ingresa el nombre del alumno {0}", posicion+1);
                nombres[posicion]=Console.ReadLine();
                for(int x=0; x<nummaterias;  x++)
                {
                    Console.WriteLine("Ingresa la calificacion de {0} en la materia {1}", nombres[posicion], x+1);
                    calmaterias[x]=Convert.ToSingle(Console.ReadLine());
                    promedioalumno = promedioalumno + calmaterias[x];
                }
                promedioalumno = promedioalumno / nummaterias;
                Console.WriteLine("El promedio del alumno {0} es de {1}", nombres[posicion], promedioalumno); 
                promediogrupal=promediogrupal + promedioalumno;
            }
            promediogrupal = promediogrupal / numalumnos;
            Console.WriteLine("El promedio del grupo es de {0}", promediogrupal);
            Console.ReadKey();
        }
    }
}
