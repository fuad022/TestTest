using System;
using System.Collections.Generic;
using System.Text;

namespace test
{
    public class Person
    {
        //some comment
        private string _name;

        public void SetName(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentNullException("Nulls");
            }
            _name = name;
        }
    }
}
