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
            /*int[] a = { 1, 2, 3, 7 };
            Console.WriteLine("Enter an Integer:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a Decimal:");
            decimal num2 = Convert.ToDecimal(Console.ReadLine());*/

            Priv p1 = new Priv();
            Vriv v1 = new Vriv();
             
            Console.WriteLine(p1.get(333));
            Console.WriteLine(v1.gett());
            Abc a1 = new Abc();

            Console.ReadLine();
        }
    }
    class Priv
    {
        private int value = 12;
        public Priv()
        {

        }
        public int get(int value)
        {
            int v1 = value;
           
            return this.value;
        }
    }
    class Vriv : Priv
    {
        int value = 203;
        public int gett()
        {
            int c1 = value;
            return c1;
        }
    }
    class Abc
    {
         
        public Abc()
        {
            try
            {
                int[] arr=new int[2] { 12, 3 };
                int a = 12, b = 0, c;
                arr[3] = 12;
                c = a / b;
            }
            catch (IndexOutOfRangeException c1)
            {
                Console.WriteLine(c1.ToString());
            }
            catch (Exception e1)
            {
                Console.WriteLine(e1.ToString());
            }
            finally
            {
                Console.WriteLine("Exception has been caught!");
            }
        }
    }
 }

