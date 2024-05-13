using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrices
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //arrays - matrices
            int[,] matriz = new int[3, 3];

            for(int x=0; x<4; x++)
            {
                for(int y=0; y<3; y++)
                {
                    Console.Write("{0},{1}| ", x, y);
                }
                Console.WriteLine();
                Console.WriteLine("---------------");
            }
            Console.ReadKey();
        }
    }
}
