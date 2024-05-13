using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Try_catch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //try catch
            int n1 =0, n2 =0, res=0;
            try
            {
                Console.WriteLine("Escriba el primer numero");
                n1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Escriba el segundo numero");
                n2 = Convert.ToInt32(Console.ReadLine());
                res = n1 + n2;
                Console.WriteLine("La suma de {0} y {1} es de {2}", n1, n2, res);
            }
            catch(Exception problema) 
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Hubo un error, el error fue "+ problema.Message);
            }
            Console.ReadKey();
        }
    }
}
