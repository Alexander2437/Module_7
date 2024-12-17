using System;

namespace Module_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }
    }

    class BaseClass
    {
        public virtual int Counter
        {
            get;
            set;
        }
    }

    class DerivedClass : BaseClass
    {
        private int counter;
        public override int Counter
        {
            get 
            {
                return Counter;
            }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Value must be greater than zwro.");
                }
                else
                {
                    Counter = value;
                }
            };
        }
    }
}

