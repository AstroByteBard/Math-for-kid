using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math.kid
{
    internal class Program
    {
        static int Maun()
        {
            Console.WriteLine("Menu \n");
            Console.WriteLine("1. Additio (+)");
            Console.WriteLine("2. Subtraction (-)");
            Console.WriteLine("3. Multiplication (x)");
            Console.WriteLine("4. Division (/)");
            Menu:
            Console.Write("Choose... ");
            int Choose = Convert.ToInt32(Console.ReadLine());
            if (Choose >= 1 && Choose <= 4)
            {
                Console.WriteLine("----------");
                return Choose;
            }
            else
            {
                Console.WriteLine("Erorr, Try Agint");
                goto Menu;
            }
        }
        static char Maun2()
        {
            Console.WriteLine("Difficult \n");
            Console.WriteLine("A) Easy Mode ( 1 - 50 )");
            Console.WriteLine("B) Mediam Mode (50 - 100 )");
            Console.WriteLine("C) Hard Mode (100 - 200 )");
            Menu2:
            Console.Write("Choose... ");
            Char Difficult = Convert.ToChar(Console.ReadLine().ToUpper());
            if (Difficult == 'A' || Difficult == 'B' || Difficult == 'C')
            {
                Console.WriteLine("----------");
                return Difficult;
            }
            else
            {
                Console.WriteLine("Erorr, Try Agint");
                goto Menu2;
            }
        }

        static void Score()
        {
            Console.WriteLine("Score \n");
        }

            static void Main(string[] args)
        {
            Console.WriteLine("Math For Kid");
            Console.WriteLine("-------------");
            int Choose1 = Maun();
            Char Choose2 = Maun2();
            Score();
        }
    }
}
