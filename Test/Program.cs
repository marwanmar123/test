using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            //=============================================
            //*************VAR
            //=============================================


            //double calc = 0.19 ;
            //Console.WriteLine("hello tu peut me donné le nom de produit");
            //string pro1 = Console.ReadLine();
            //Console.WriteLine("votre produit est " + pro1);
            //Console.WriteLine("leur prix hors TVA plz");
            //var calcule  = (int.Parse(Console.ReadLine()));
            //var result = calc * calcule;
            //Console.WriteLine($"le prix du produit { pro1} son le prix de TTC est {result}" );
            //var rsFin = result*calc;
            //Console.WriteLine(rsFin);


            //=============================================
            //*************boucle
            //=============================================


           /* var b = 2;
            for(int a = 1; a<30; a *=b)
            {
                Console.WriteLine(a);
            }*/
            //Console.WriteLine("dexiéme boucle");
            //for(int i = 0; i<10; i++)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.WriteLine("troisieme boucle");
            //for(int i = 1; i<16; i++)
            //{
            //    Console.WriteLine(i);
            //    if (i == 15)
            //    {
            //        Console.WriteLine("On y arrive presque...");
            //    }
            //}
            //Console.WriteLine("quatriéme boucle");
            //for(int i = 20; i>=0; i--)
            //{
            //    Console.WriteLine(i);
            //    if (i == 0)
            //    {
            //        Console.WriteLine("C'est presque bon...");
            //    }
            //}
            //Console.WriteLine("cinqiéme boucle");
            //for(int i = 1; i<101; i+=15)
            //{
            //    Console.WriteLine(i);

            //}
            //Console.WriteLine("On tient le bon bout...");
            //Console.WriteLine("sixiéme boucle");
            //for(int i = 200; i>=0; i-=12)
            //{
            //    Console.WriteLine(i);

            //}
            //Console.WriteLine("Enfin...");

            //=============================================
             //*************les fonctions et les Conditions
             //============================================


            //int A = 0;
            //int B = 0;
            //Console.WriteLine("enter your first number");
            //A = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("enter your second number");
            //B = Convert.ToInt32(Console.ReadLine());
            //Console.Write("enter your operator");
            //switch (Console.ReadLine())
            //{
            //    case "a":
            //        Console.WriteLine($"result: {A} + {B} = " + (A + B));
            //        break;
            //    case "b":
            //        Console.WriteLine($"result: {A} - {B} = " + (A - B));
            //        break;
            //    case "c":
            //        Console.WriteLine($"result: {A} * {B} = " + (A * B));
            //        break;
            //    case "d":
            //        Console.WriteLine($"result: {A} / {B} = " + (A / B));
            //        break;
            //}
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
            bool exiting = false;
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
                    //System.Threading.Thread.Sleep(2000);
                    
                    
                    break;
            }

            /*
           //=============================================
            //**************Les collections 
            //============================================



            //string[] mois = new string[] { "jan", "fév", "mar", "avr", "mai", "juin", "juil", "aout", "sep", "oct", "nov", "déc" };
            //Console.WriteLine(mois[2]);
            //Console.WriteLine(mois[5]);
            /*for (int i = 0; i < mois.Length; i++)
            {
                Console.WriteLine(mois[i]);
            }*/
           /* mois[7] = "modif";
            for (int i = 0; i < mois.Length; i++)
            {
                Console.WriteLine(mois[i]);
            }
            var push = mois.ToList();
            push.Insert(0, "aaa");
            mois = push.ToArray();
            foreach(string i in mois)
            {
                Console.WriteLine(i);
            }
            var remove = mois.ToList();
            remove.RemoveAt(0);
            mois = remove.ToArray();
            foreach(string i in mois)
            {
                Console.WriteLine(i);
            }*/

            /*string value = Array.FindAll(mois,  element => element.StartsWith("m", StringComparison.Ordinal));
            Console.Write("Element: \n ");
            Console.WriteLine("{0}", value);


            if (mois.Contains("nov")){
                Console.WriteLine("yes! the array Contain this word");
            }
            else
            {
                Console.WriteLine("No");
            
            }*/
            /*Array.Sort(mois);
            for (int i = 0; i < mois.Length; i++)
            {
                Console.WriteLine(mois[i]);
            }*/
            //string[] copy = new string[] mois;
            //string[] strB = String.Copy(mois);
             //foreach(string i in strB)
            //{
              //  Console.WriteLine(i);
            //}

            

        }
    }
}