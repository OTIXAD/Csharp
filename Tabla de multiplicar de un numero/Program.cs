using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tabla_de_multiplicar_de_un_numero
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Solicitar un numero para mostarr la tabla de multiplicar de ese numero
            //multiplicando hasta 10
            int numero = 0, res = 0, contador=1, cont=0;
            Console.WriteLine("Ingresa un numero:");
            numero=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hasta que numero desea multiplicar:");
            cont=Convert.ToInt32(Console.ReadLine());
            do
            {
                res=numero*contador;
                Console.WriteLine("{0} x {1} = {2}", numero, contador, res);
                contador++;
            }while(contador<=cont);
            Console.ReadKey();
        }
    }
}
