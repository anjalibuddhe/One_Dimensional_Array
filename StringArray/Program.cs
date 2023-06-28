using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] str =new string []{ "Sana", "Anjali", "Sara", "Hari","Sita","Gita" };
            string[] str2 =new string[] { "Pune", "Nagpur","Bombey" };

            Console.WriteLine("-----copy array-----");
            Array.Copy(str, str2, 3);
            foreach (string city in str2)
            {
                Console.WriteLine(city);
            }
            Console.WriteLine("******************");
            Array.Copy(str, 4, str2, 0, 2);
           
            foreach (string city in str2)
            {
                Console.WriteLine(city);
            }

            foreach (string name in str)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine("-----sorting array-----");
            Array.Sort(str);
            foreach (string city in str)
            {
                Console.WriteLine(city);
            }

            Console.WriteLine("-----Reverse array-----");
            Array.Reverse(str);
            foreach (string city in str)
            {
                Console.WriteLine(city);
            }
            Console.WriteLine( "----------------------------------------------------");
            Console.WriteLine("Interger Array");

            int[] num = new int[] {1,2,3,4,5,6,78,45,4,3,87 };
            int[] num1 = new int[10] { 1, 2, 3, 4, 5, 6, 7, 89, 9, 0 };


            Array.Sort(num);
            foreach(var n in num)
            {
                Console.WriteLine(n);
            }
            Console.WriteLine("**************");
            Array.Reverse(num);
            foreach(var n in num){
                Console.WriteLine(n);
            }

            Array.Copy(num, 3, num1, 5, 3);
            Console.WriteLine("------------------");
            foreach (var n in num1)
            {
                Console.WriteLine(n);
            }






        }
    }
}
