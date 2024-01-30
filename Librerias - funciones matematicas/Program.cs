using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Librerias___funciones_matematicas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Librerias - operaciones matematicas que se pueden hacer
            // suma, resta, multiplicacion, division, raiz, sin, cos, tan
            double  n1 = 0, n2 = 0, res=0;
            char opcion;
            Console.WriteLine("Bienvenido a la calculadora, seleccione una opcion");
            Console.WriteLine("a.- suma");
            Console.WriteLine("b.- restar");
            Console.WriteLine("c.- multiplicar");
            Console.WriteLine("d.- dividir");
            Console.WriteLine("e.- raiz");
            Console.WriteLine("f.- potencia");
            Console.WriteLine("g.- senos");
            Console.WriteLine("h.-cosenos");
            Console.WriteLine("i.- tangentes");
            
            opcion=Convert.ToChar(Console.ReadLine());
            if (opcion =='a')
            {
                Console.WriteLine("Ingresa el primer valor a sumar:");
                n1=Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Ingresa el segundo valor a sumar:");
                n2 = Convert.ToDouble(Console.ReadLine());
                res = n1 + n2;
                Console.WriteLine("El resultado de la suma de los dos numeros es: {0}", res);
            }
            if (opcion == 'b')
            {
                Console.WriteLine("Ingresa el primer valor a restar:");
                n1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Ingresa el segundo valor a restar:");
                n2 = Convert.ToDouble(Console.ReadLine());
                res = n1 - n2;
                Console.WriteLine("El resultado de la resta de los dos numeros es: {0}", res);
            }
            if (opcion == 'c')
            {
                Console.WriteLine("Ingresa el primer valor a multiplicar:");
                n1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Ingresa el segundo valor a multiplicar:");
                n2 = Convert.ToDouble(Console.ReadLine());
                res = n1 * n2;
                Console.WriteLine("El resultado de la multiplicacion de los dos numeros es: {0}", res);
            }
            if (opcion == 'd')
            {
                Console.WriteLine("Ingresa el primer valor a dividir:");
                n1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Ingresa el segundo valor a dividir:");
                n2 = Convert.ToDouble(Console.ReadLine());
                res = n1 / n2;
                Console.WriteLine("El resultado de la division de los dos numeros es: {0}", res);
            }
            if (opcion=='e')
            {
                Console.WriteLine("Ingresa el valor para sacar su raiz:");
                n1= Convert.ToDouble(Console.ReadLine());
                res=System.Math.Sqrt(n1); //square root
                Console.WriteLine("la raiz cuadrada de {0} es {1}",n1, res);
            }
            if (opcion == 'f')
            {
                Console.WriteLine("Escriba un numero a potenciar");
                n1=Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("A que potencia deseas elevar");
                n2=Convert.ToDouble(Console.ReadLine());    
                res=System.Math.Pow(n1,n2);
                Console.WriteLine("{0} elevado a la {1} es: {2}", n1, n2, res);
            }
            if (opcion=='g')
            {
                Console.WriteLine("Ingresa el valor a sacar el seno");
                n1=Convert.ToDouble(Console.ReadLine());
                res=System.Math.Sign(n1);
                Console.WriteLine("El valor del seno de {0} es {1}",n1, res);
            }
            if (opcion =='h')
            {
                Console.WriteLine("Ingresa el valor a sacar el coseno");
                n1=Convert.ToDouble(Console.ReadLine());
                res=System.Math.Cos(n1);
                Console.WriteLine("El valor del coseno de {0} es de {1}",n1, res);
            }
            if (opcion=='i')
            {
                Console.WriteLine("Ingresa el valor a sacar la tangente");
                n1=Convert.ToDouble(Console.ReadLine());    
                res=System.Math.Tan(n1);
                Console.WriteLine("El valor de la tangente de {0} es de: {1}", n1 , res);
            }
            Console.ReadKey();
        }
    }
}
