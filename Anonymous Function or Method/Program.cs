using System;

namespace Anonymous_Function_or_Method
{
    public delegate void calculation(int a);

    class Program
    {
        public static void addition(int a)
        {
            a += 10;
            Console.WriteLine(a);
        }
        public static void addition(calculation del, int a)
        {
            a += 10;
            del.Invoke(a);
        }

        static void Main(string[] args)
        {
            calculation obj = delegate (int a)
            {
                a += 10;
                Console.WriteLine(a);
            };
            obj.Invoke(5);
            calculation obj1 = new calculation(Program.addition);
            obj1(123);
            Program.addition(delegate (int a)
            {
                a += 10;
                Console.WriteLine(a);
            }, 12);
            Console.ReadLine();
        }
    }
}
