using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Figura f;
            f = new Circulo(10);
            Console.WriteLine(f.Area());
            f = new Triangulo(8, 4);
            Console.WriteLine(f.Area());
            
            f = new Cuadrado(6, 5);
            Console.WriteLine(f.Area());
            Console.ReadKey();

           
        }
    }
}
