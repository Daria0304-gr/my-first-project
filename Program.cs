using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = GetHello();
            int sum = GetSum();

            Console.WriteLine(message);  
            Console.WriteLine(sum);     

            Console.ReadKey();
        }
        static string GetHello()
        {  
            return "Hello"; 
        }
        static int GetSum()
        {
            int a = 3 ;
            int b = 7;
            return a + b;
        }
    }
    
}
