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
        static int[] input = new int[10];
        static int[] answer = new int[10];
        static int[] rand1 = new int[10];
        static int[] rand2 = new int[10];
        static int[] rand3 =  new int[10];
        static int check;
        static int Choose;

        static int Menu()
        {
            Console.WriteLine("-------------");
            Console.WriteLine("Menu\n");
            Console.WriteLine("1. Addition (+)");
            Console.WriteLine("2. Subtraction (-)");
            Console.WriteLine("3. Multiplication (x)");
            Console.WriteLine("4. Division (/)");
        Menu:
            Console.Write("Choose... ");
            Choose = Convert.ToInt32(Console.ReadLine());
            if (Choose >= 1 || Choose <= 4)
            {
                Console.WriteLine("----------");
                Menu2();
                return Choose;
            }
            else
            {
                Console.WriteLine("Error, Try Again");
                goto Menu;
            }
        }

        static void Menu2()
        {
            Console.WriteLine("Difficult \n");
            Console.WriteLine("A) Easy Mode");
            Console.WriteLine("B) Medium Mode");
            Console.WriteLine("C) Hard Mode");
        Menu2:
            Console.Write("Choose... ");
            Char Difficult = Convert.ToChar(Console.ReadLine().ToUpper());
            switch(Difficult) //Switch depend on Difficult mode
            {
                case 'A': //Easy Mode
                    Console.WriteLine("----------");
                    Easy();
                    break;

                case 'B': //Medium Mode
                    Console.WriteLine("----------");
                    Medium();
                    break;
                case 'C': //Hard Mode
                    Console.WriteLine("----------");
                    Hard();
                    break;
                default:
                    Console.WriteLine("Error, Try Again");
                    goto Menu2;
            }
        }

        static void Easy() //EASY MODE
        {
            var rand = new Random(); // var : variable that its type will be like first assignment

            Console.WriteLine("\nEASY MODE\n");
            for (int i = 0; i < input.Length; i++)
            {
                rand1[i] = rand.Next(11); // .Next() : return non-negative integer (firstIndex, LastIndex + 1)
                rand2[i] = rand.Next(11);
                if (Choose.Equals(1)) //Addition
                {
                    answer[i] = rand1[i] + rand2[i];
                    Console.Write(rand1[i] + " + " + rand2[i] + " = "); 
                }
                else if (Choose.Equals(2)) //Subtraction
                {
                    answer[i] = rand1[i] - rand2[i];
                    Console.Write(rand1[i] + " - " + rand2[i] + " = "); 
                }
                else if (Choose.Equals(3)) //Mutiplication
                {
                    answer[i] = rand1[i] * rand2[i];
                    Console.Write(rand1[i] + " * " + rand2[i] + " = ");
                }
                else if (Choose.Equals(4)) //Division
                {
                    answer[i] = (rand1[i] = rand.Next(6,11)) / (rand2[i] = rand.Next(6));
                    Console.Write(rand1[i] + " / " + rand2[i] + " = ");
                }
                input[i] = int.Parse(Console.ReadLine());
                Console.WriteLine("Correct answer : " + answer[i] + "\n");

                if (answer[i].Equals(input[i]))
                {
                    check = check + 1;
                }
            }

            Console.WriteLine("Correct : " + check + "\n");
            BackMenu();
        }

        static void Medium()
        {
            var rand = new Random(); // var : variable that its type will be like first assignment

            Console.WriteLine("\nMEDIUM MODE\n");
            for (int i = 0; i < input.Length; i++)
            {
                rand1[i] = rand.Next(101); // .Next() : return non-negative integer (firstIndex, LastIndex + 1)
                rand2[i] = rand.Next(101);
                if (Choose.Equals(1)) //Addition
                {
                    answer[i] = rand1[i] + rand2[i];
                    Console.Write(rand1[i] + " + " + rand2[i] + " = ");
                }
                else if (Choose.Equals(2)) //Subtraction
                {
                    answer[i] = rand1[i] - rand2[i];
                    Console.Write(rand1[i] + " - " + rand2[i] + " = ");
                }
                else if (Choose.Equals(3)) //Mutiplication
                {
                    answer[i] = rand1[i] * rand2[i];
                    Console.Write(rand1[i] + " * " + rand2[i] + " = ");
                }
                else if (Choose.Equals(4)) //Division
                {
                    answer[i] = (rand1[i] = rand.Next(51,101)) / (rand2[i] = rand.Next(51));
                    Console.Write(rand1[i] + " / " + rand2[i] + " = ");
                }
                input[i] = int.Parse(Console.ReadLine());
                Console.WriteLine("Correct answer : " + answer[i] + "\n");

                if (answer[i].Equals(input[i]))
                {
                    check = check + 1;
                }
            }

            Console.WriteLine("Correct : " + check + "\n");
            BackMenu();
        }
        static void Hard()
        {
            var rand = new Random(); // var : variable that its type will be like first assignment

            Console.WriteLine("\nHARD MODE\n");
            for (int i = 0; i < input.Length; i++)
            {
                rand1[i] = rand.Next(101); // .Next() : return non-negative integer (firstIndex, LastIndex + 1)
                rand2[i] = rand.Next(101);
                rand3[i] = rand.Next(101);
                if (Choose.Equals(1)) //Addition
                {
                    answer[i] = rand1[i] + rand2[i] + rand3[i];
                    Console.Write(rand1[i] + " + " + rand2[i] + " + " + rand3[i] + " = ");
                }
                else if (Choose.Equals(2)) //Subtraction
                {
                    answer[i] = rand1[i] - rand2[i] - rand3[i];
                    Console.Write(rand1[i] + " - " + rand2[i] + " - " + rand3[i] + " = ");
                }
                else if (Choose.Equals(3)) //Mutiplication
                {
                    answer[i] = rand1[i] * rand2[i] * rand3[i];
                    Console.Write(rand1[i] + " * " + rand2[i] + " * " + rand3[i] + " = ");
                }
                else if (Choose.Equals(4)) //Division
                {
                    answer[i] = (rand1[i] = rand.Next(51, 101)) / (rand2[i] = rand.Next(51)) / (rand3[i] = rand.Next(6));
                    Console.Write(rand1[i] + " / " + rand2[i] + " / " + rand3[i] + " = ");
                }
                input[i] = int.Parse(Console.ReadLine());
                Console.WriteLine("Correct answer : " + answer[i] + "\n");

                if (answer[i].Equals(input[i]))
                {
                    check = check + 1;
                }
            }

            Console.WriteLine("Correct : " + check + "\n");
            BackMenu();
        }

        static void BackMenu()
        {
            Console.WriteLine("PRESS ENTER TO BACK TO MENU");
            string userinp = Console.ReadLine();
            if (userinp.Equals(""))
            {
                while (check != 0)
                {
                    check--;
                }
                Menu();
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Math For Kid");
            Menu();
        }
    }
}
