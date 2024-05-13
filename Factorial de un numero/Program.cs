using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial_de_un_numero
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Factorial de un numero
            long num = 0, factorial=0;
            Console.WriteLine("A que numero deseas sacar su factorial?");
            num= Convert.ToInt64(Console.ReadLine());

            for(long x=num-1; x>0; x--)
            {
                factorial = num * x;
                num= factorial;
            }
            Console.WriteLine(factorial);
            Console.ReadKey();
        }
    }
}
