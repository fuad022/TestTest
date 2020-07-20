using System;

namespace MyProject
{
    class Program
    {
        public delegate int ValueDelegate(int i);

        public delegate void MyDelegate();

        static void Main(string[] args)
        {
            MyDelegate myDelegate = Method1;
            myDelegate += Method4;
            myDelegate(); // вызывает Method1

            MyDelegate myDelegate2 = new MyDelegate(Method4);
            myDelegate2 += Method4;
            myDelegate2 -= Method4;
            myDelegate2.Invoke();

            MyDelegate myDelegate3 = myDelegate + myDelegate2;
            myDelegate3.Invoke();

            var valueDelegate = new ValueDelegate(MethodValue);
            valueDelegate += MethodValue;
            valueDelegate += MethodValue;
            valueDelegate += MethodValue;
            valueDelegate += MethodValue;
            valueDelegate((new Random()).Next(10, 50));

            Action action = Method1; //Делегат, который не возвращает значения.
            action();

            Predicate<int> predicate;

            Func<int, string> func;
            
            Console.ReadLine();
        }

        public static int MethodValue(int i)
        {
            Console.WriteLine(i);
            return i;
        }

        public static void Method1()
        {
            Console.WriteLine("Method1");
        }

        public static int Method2()
        {
            Console.WriteLine("Method2");
            return 0;
        }

        public static void Method3()
        {
            Console.WriteLine("Method3");
        }

        public static void Method4()
        {
            Console.WriteLine("Method4");
        }
    }
}
