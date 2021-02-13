using System;

namespace SchOolCsHaRp
{
    class Program
    {
        delegate int MyDelegate(int p, int q);
        delegate void MyMulticastDelegate(int p, int q);
        static void Main(string[] args)
        {
            //MyDelegate arithMethod = new MyDelegate(Add);
            MyMulticastDelegate arMethods = null;
            arMethods = new MyMulticastDelegate(Add);
            arMethods += new MyMulticastDelegate(Substract);
            arMethods += new MyMulticastDelegate(Max);

            arMethods(3, 4);

            //PerformArithOperation(3, 4, arithMethod);
            /*
            Console.WriteLine("Choose");
            Console.WriteLine("Press + for Add");
            Console.WriteLine("Press - for Substract");
            Console.WriteLine("Press m for Maximum Number");
            char choice = (char)Console.Read();

            switch(choice)
            {
                case '+':
                    arithMethod = new MyDelegate(Add);
                    break;
                case '-':
                    arithMethod = new MyDelegate(Substract);
                    break;
                case 'm':
                    arithMethod = new MyDelegate(Max);
                    break;
            }
            int r = arithMethod(3, 4);
            Console.WriteLine("Result is {0}.", r);
            */
           
        }
        static void Add(int a, int b)
        {
            Console.WriteLine("The sum of 3 and 4 is {0}.", (a + b));
        }

        static void Substract(int a, int b)
        {
            Console.WriteLine("The substraction of 3 and 4 is {0}.", (a - b));
        }

        static void Max(int a, int b)
        {
            if (a > b)
                Console.WriteLine("The larger number is {0}.", a);
            else
                Console.WriteLine("The larger number is {0}.", b);
        }

        static void PerformArithOperation(int a, int b, MyDelegate arithOperation)
        {
            int r = arithOperation(a, b);
            Console.WriteLine("The result on arithmetic operation od 3 and 4 is {0}.", r);
        }


    }
}
