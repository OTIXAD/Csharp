using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace area_de_figura
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //pregunta al usario de cual de las siguientes figuras
            //obtener el area: triangulo, cubo, circulo, rectangulo.
            int figura=0;
            Console.WriteLine("Escribe el numero de la figura a sacar el area o volumen: 1=triangulo, 2=cubo, 3=circulo y 4=rectangulo");
            figura =Convert.ToInt32(Console.ReadLine());

            switch (figura)
            {
                case 1: //triangulo
                    float b, altura, area;
                    Console.WriteLine("Elegiste el triangulo");
                    Console.WriteLine("Ingresa la base del triangulo:");
                    b = Convert.ToSingle(Console.ReadLine());
                    Console.WriteLine("Ingresa la alturta de triangulo:");
                    altura = Convert.ToSingle(Console.ReadLine());
                    area = (b * altura) / 2;
                    Console.WriteLine("El area del triangulo es de {0}cm2", area);
                    break;
                case 2: //cubo
                    double l, volumen;
                    Console.WriteLine("Elegiste el cubo");
                    l = Convert.ToSingle(Console.ReadLine());
                    volumen = System.Math.Pow(l,3);
                    Console.WriteLine("El volumen del cubo es de {0}cm3", volumen);
                    break;
                case 3: //circulo
                    double radio, a;
                    Console.WriteLine("Elegiste el circulo");
                    Console.WriteLine("Ingresa el radio del circulo:");
                    radio = Convert.ToDouble(Console.ReadLine());
                    a = 3.1416 * (System.Math.Pow(radio, 2));
                    Console.WriteLine("El area del circulo es de {0}cm2", a);
                    break;
                case 4: //rectangulo
                    float Base, Area, Altura;
                    Console.WriteLine("Elegiste el rectangulo");
                    Console.WriteLine("Ingresa la base del rectangulo:");
                    Base = Convert.ToSingle(Console.ReadLine());
                    Console.WriteLine("Ingresa la alturta del rectangulo:");
                    Altura = Convert.ToSingle(Console.ReadLine());
                    Area = (Base * Altura);
                    Console.WriteLine("El area del rectangulo es de {0}cm2", Area);
                    break;
                default:
                    Console.WriteLine("Solo tenemos estas figuras");
                    break;
            }
            Console.ReadKey();
        }
    }
}
