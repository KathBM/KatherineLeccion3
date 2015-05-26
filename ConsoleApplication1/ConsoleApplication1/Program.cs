using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {

        static void Main(string[] args)

        {
            Fibonacci fibo = new Fibonacci();
            fibo.operacion(2);
            Console.WriteLine(fibo.operacion(4));
            Console.WriteLine(fibo.operacion(6));
            Console.WriteLine(fibo.operacion(20));
            Console.WriteLine(fibo.operacion(1));
            Console.WriteLine(fibo.operacion(11));
            Console.WriteLine(fibo.operacion(25));
          

            System.Console.ReadLine();


           
        }
    }
}
   