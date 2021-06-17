using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public class Program
    {
        static void Main(string[] args)
        {

            int One;
            int Seconde;

            Console.WriteLine("enter your first number");
            Console.WriteLine("==========================");
            Console.WriteLine("==========================");
            One = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter your second number");
            Console.WriteLine("==========================");
            Console.WriteLine("==========================");
            Seconde = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("==========================");
            Console.WriteLine("==========================");
            Console.Write("enter your operator");

            Calcul Rslt = new Calcul(One, Seconde);

            switch (Console.ReadLine())
            {
                case "a":
                    Rslt.PrintAdd();
                    break;

                case "b":
                    Rslt.PrintSub();
                    break;

                case "c":
                    Rslt.PrintMul();
                    break;

                case "d":
                    if (Seconde == 0)
                    {
                        Console.WriteLine("enter A nother number without 0");
                    }
                    else
                    {
                        Rslt.PrintDiv();
                    }
                    break;

                case "q":
                    Console.WriteLine("thla!!");
                    Environment.Exit(0);


                    break;
            }





        }
    }
}