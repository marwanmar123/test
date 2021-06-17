using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public class Calcul
    {

        int A;
        int B;

        public Calcul(int A, int B)
        {
            this.A = A;
            this.B = B;


        }

        public int Add()
        {
            return A + B;
        }
        public void PrintAdd()
        {
            Console.WriteLine(Add());
        }
        public int Sub()
        {
            return A - B;
        }
        public void PrintSub()
        {
            Console.WriteLine(Sub());
        }
        public int Mul()
        {
            return A * B;
        }
        public void PrintMul()
        {
            Console.WriteLine(Mul());
        }
        public int Div()
        {


            return A / B;
        }
        public void PrintDiv()
        {
            Console.WriteLine(Div());
        }

    }
}
