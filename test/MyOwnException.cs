using System;

namespace test
{
    public class MyOwnException : Exception
    {
        public MyOwnException() : base("It is my exception")
        {
        }

        public MyOwnException(string message) : base(message)
        {
        }
    }
}