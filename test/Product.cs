using System;
using System.Collections.Generic;
using System.Text;

namespace test
{
    //public abstract class Product
    public class Product<T>
    {
        public string Name { get; set; }

        //public int Calorie { get; set; }

        public T Volume { get; set; }

        //public double Energy
        //{
        //    get
        //    {
        //        return Volume * Calorie / 100.0;
        //    }
        //}

        public T Energy { get; set; }

        //public Product(string name, int calorie, int volume)
        //{
        //    if (string.IsNullOrWhiteSpace(name))
        //    {
        //        throw new ArgumentNullException(nameof(name));
        //    }
        //    if (calorie < 0)
        //    {
        //        throw new ArgumentException(nameof(calorie));
        //    }
        //    if (volume <= 0)
        //    {
        //        throw new ArgumentException(nameof(volume));
        //    }

        //    Name = name;
        //    Calorie = calorie;
        //    Volume = volume;
        //}

        public Product(string name, T volume, T energy)
        {
            //TODO
            Name = name;
            Volume = volume;
            Energy = energy;
        }

        public override string ToString()
        {
            //return $"{Name}. Calorie: {Calorie}, Volume: {Volume}";
            return $"{Name}. Energy: {Energy}, Volume: {Volume}";
        }
    }
}
