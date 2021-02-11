using System;

namespace DelegatesUdm
{
    class Program
    {
        public delegate string GetTextDelegate(string name);
        

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

            Console.WriteLine(getGoodbuyText("Mara"));
        }
    }
}
