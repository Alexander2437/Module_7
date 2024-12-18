using System;

namespace Module_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Obj obj1 = new Obj() { Value = 54 };
            Obj obj2 = new Obj() { Value = 47 };

            Obj obj3 = obj1 - obj2;
            Console.WriteLine(obj3.Value);

            Obj obj4 = obj1 + obj2;
            Console.WriteLine(obj4.Value);
        }
    }

    class Obj
    {
        public int Value;

        public static Obj operator + (Obj obj1, Obj obj2)
        {
            return new Obj { Value = obj1.Value + obj2.Value };
        }

        public static Obj operator - (Obj obj1, Obj obj2)
        {
            return new Obj { Value = obj1.Value - obj2.Value };
        }
    }
}

