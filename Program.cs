using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace try_catch_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int age;
            try
            {
                    Console.WriteLine("geben sie ihr alter ein ");
                    age = Convert.ToInt32(Console.ReadLine());
            }
            catch(FormatException ex) 
            {

                Console.WriteLine(ex.Message);
                Console.WriteLine("DU HAST EIN FALSCHES FORMAT!");
                Console.ReadLine();
                Console.Clear();
                
            }
            //catch(OverflowException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //    Console.WriteLine("ZAHL ZU GROß ODER ZU KLEIN");
            //    Console.ReadLine();
            //    Console.Clear();
            //}

            if (age >= 18)
            {
                Console.WriteLine("VOLLJARIGE");
            }
            Console.ReadLine();


        }
    }
}
