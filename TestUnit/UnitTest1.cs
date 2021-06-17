using System;
using Xunit;
using Test;

namespace TestUnit
{
    public class UnitTest1
    {
        [Fact]
        public void TestAddition()
        {
            int a = 2;
            int b = 3;
            int s = a + b;
            Calcul p = new Calcul(a, b);

            Assert.Equal(s, p.Add());

        }
        [Fact]
        public void TestSub()
        {
            int a = 10;
            int b = 3;
            int s = a - b;
            Calcul p = new Calcul(a, b);

            Assert.Equal(s, p.Sub());

        }
        [Fact]
        public void TestMul()
        {
            int a = 10;
            int b = 5;
            int s = a * b;
            Calcul p = new Calcul(a, b);

            Assert.Equal(s, p.Mul());

        }
        [Fact]
        public void TestDiv()
        {
            int a = 2;
            int b = 3;
            int s = a / b;
            Calcul p = new Calcul(a, b);

            Assert.Equal(s, p.Div());

        }
    }
}
