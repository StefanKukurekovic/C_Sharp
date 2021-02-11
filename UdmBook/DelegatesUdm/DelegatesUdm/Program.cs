using System;

namespace DelegatesUdm
{
    class Program
    {
        public delegate string GetTextDelegate(string name);
        public delegate double GetResultDelegate(double a, double b);
        public delegate int GetProduct(int a, int b);
        

        static void Main(string[] args)
        {
            //creating an anonymus method
            GetTextDelegate getTextDelegate = delegate (string name)
            {
                return "Hello, " + name;
            };

            //Lambda expression
            GetTextDelegate getHelloText = (string name) => { return "Hello, " + name; };

            // Statement lambda
            GetTextDelegate getGoodbuyText = (string name) =>
            {
                Console.WriteLine("I'm inside of an statement lambda");
                return "Goodbye, " + name;
            };

            GetTextDelegate getWelcomeText = name => "Welcome, " + name;
            GetResultDelegate calculateNumbers = (a, b) => a + b;
            GetProduct getProduct = (a, b) => a * b;

            Console.WriteLine(getProduct(5,8));
        }
    }
}
