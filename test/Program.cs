//Пространсво имен.
using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Threading.Tasks;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using System.Xml;
using Microsoft.Extensions.Hosting;

namespace test
{
    class Program
    {
        //comment from github
        //static void Main(string[] args)
        static async Task Main(string[] args)
        {
            ////////////////////////////////////
            //Console.WriteLine("Hello");
            //Console.WriteLine("Hello1");

            //int a = 5;
            //Console.WriteLine(a);

            //string data;
            //data = Console.ReadLine();
            //Console.WriteLine(data);

            //string str1 = "2.9";
            //string str2 = "1";
            //double a = Convert.ToDouble(str1);
            //double a = double.Parse(str1);
            //int a;
            //bool result = int.TryParse(str2, out a);
            //Console.WriteLine(result);

            //Console.WriteLine("Hello world from test");

            //bool isTrue = true;
            //if (isTrue)
            //{
            //  Console.WriteLine("True");
            //}

            //ConsoleKey consoleKey = Console.ReadKey().Key;

            //do
            //{
            //} while (true);

            //for (; ; ) //безконечный цикл
            //{
            //    Console.WriteLine("for is working");
            //    System.Threading.Thread.Sleep(300);
            //    break; //код выйдет из цикла
            //}

            //int i = 0;
            //for (; i < 3; i++)
            //{
            //    Console.WriteLine("for_1 " + i);
            //}
            //for (; i < 5; i++)
            //{
            //    Console.WriteLine("for_2 " + i);
            //}

            //for (int i = 0, j = 5; i < 10 && j < 12; i++, j++)
            //{
            //    Console.WriteLine("i - " + i);
            //    Console.WriteLine("j - " + j);
            //}

            //int[] arr = Enumerable.Repeat(5, 10).ToArray();
            //Console.ReadLine();

            //int[] arr = { 10, 3, 2, 55 };
            //foreach (int a in arr)
            //{
            //    Console.Write(a + " ");
            //}
            //Console.WriteLine(arr.Where(i => i % 2 == 0).Sum());
            //Console.WriteLine(arr.Where(i => i % 2 != 0).Min());
            //int[] result = arr.OrderByDescending(i => i).ToArray();
            //Console.WriteLine(result);

            //Index myIndex = ^1;
            //Console.WriteLine(arr[myIndex]); //выводим с конца массива первый элемент(особенность C#8).
            //int[] arr2 = arr[0..4]; //диапазон(особенность C#8).
            //int[] arr3 = arr[..4]; //диапазон с начала (особенность C#8).
            //int[] arr4 = arr[5..]; //диапазон с 5ти до конца (особенность C#8).

            //Console.WriteLine("ffff");
            //Console.WriteLine("aaaa");


            /*List<int> list = new List<int>();
            list.Add(5);
            Console.WriteLine(list.Count);*/

            //Безконечный цикл
            //for (;;) { }

            /*var list = new List<int>();
            for (var i = 0; i < 0; i+=2)
            {
                list.Add(i);
            }*/

            ////////////////////////////////////////////////////////////////////////////
            /// Перегрузка операторов(operator)
            ////////////////////////////////////////////////////////////////////////////
            /*
            Apple apple = new Apple("Red apple", 100, 100);
            Apple apple2 = new Apple("Green apple", 90, 110);

            var sumApple = Apple.Add(apple, apple2);
            var sumApple2 = apple + apple2;

            var sumApple3 = apple + 100;

            Console.WriteLine(apple);
            Console.WriteLine(apple2);
            Console.WriteLine(sumApple);
            Console.WriteLine(sumApple2);
            Console.WriteLine(sumApple3);

            Console.WriteLine(apple == apple2);
            Console.WriteLine(sumApple == sumApple2);

            Console.ReadLine();*/
            /////////////////////////////////////////////////////////////////////////////
            /*
            var p = new Product<int>("Apple", 100, 100);
            var list = new List<int>();
            var map = new Dictionary<string, string>();
            map.Add("5", "Five");
            map.Add("6", "Six");*/

            /*var cars = new List<ICar>();
            cars.Add(new Bmw());*/
            //////////////////////////////////////////////////////////////////
            /*
            while (true)
            {
                var input = Console.ReadLine();

                if (int.TryParse(input, out int result))
                {
                    Console.WriteLine($"Integer {result}");
                    //break;
                }
                else
                {
                    Console.WriteLine("Uncorrect input");
                }
            }

            var i = 5;
            try
            {
                throw new MyOwnException();
                //var j = i / 0;
            }
            catch (MyOwnException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (DivideByZeroException ex) when(i == 5)
            {
                Console.WriteLine("Divide by zero");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                //throw;
            }
            finally
            {
                Console.WriteLine("Finish");
                Console.ReadLine();
            }*/
            /////////////////////////////////////////////////////////////////////////

            /*
            User user = new User("Tom", 31);
            //user.name = "Tom";
            //user.age = 22;
            user.Info();

            Console.ReadKey();*/
            //////////////////////////////////////////////////////////////////////////

            //State state1 = new State();
            //Country country1 = new Country();

            //Console.WriteLine(decimal.Round(987654321.129M, 2, MidpointRounding.ToEven));
            //Console.WriteLine(decimal.Round(987654321.129M, 2, MidpointRounding.AwayFromZero));
            //Console.WriteLine(decimal.Round(987654321.129M, 2, MidpointRounding.ToNegativeInfinity));
            //Console.WriteLine(decimal.Round(987654321.129M, 2, MidpointRounding.ToPositiveInfinity));
            //Console.WriteLine(decimal.Round(987654321.129M, 2, MidpointRounding.ToZero));
            //////////////////////////////////////////////////////////////////////////
            //////////////////////////////////////////////////////////////////////////

            //string filepath = @"C:\Users\Fuad\Desktop\MyPkg.docx";

            //AddTable(filepath, new string[,] { 
            //    { "Texas", "TX" },
            //    { "California", "CA" },
            //    { "New York", "NY" },
            //    { "Massachusetts", "MA" }});

            //CreateWordprocessingDocument(filepath);
            //BuildDocument(filepath, new List<string>(new string[] { "Hello", "world" }));
            ///////////////////////////////////////////////////////////////////////////////////////////////////////

            var builder = new HostBuilder();
            await builder.RunConsoleAsync();
        }


    }
}
