using System;

namespace test
{
    public class User
    {
        public string name;
        public int age;

        public User()
        {
        }

        public User(string name)
        {
            this.name = name;
        }

        //3й конструктор вызывает 2й конструктор, т.к. в нем содержится name = n (чтобы код не дублировался)
        public User(string n, int a) : this(n)
        {
            age = a;
        }

        public void Info()
        {
            Console.WriteLine($"{name} - {age}");
        }
    }
}
