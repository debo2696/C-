using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string str="debo2696",myStr;
            char grade = 'A';
            int a=432;
            bool male = true;
            Console.WriteLine("Enter the String:");
            myStr = Console.ReadLine();
            for (int i = 0; i <= 5; i++)
            {
                for (int j = 5; j >= i; j--)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }
            Console.Read();
        }
    }
}
