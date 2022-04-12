using System;

namespace ConsoleApp4
{
    class Program
    {
        delegate int Operation(char c, string s);
        delegate void Symbol(char c);

        static void Main(string[] args)
        {

            char x = 'o';
            string y = "a z x d o o a z ";
            Operation del = Point;
            int res = del(x, y);
            Console.WriteLine(res);
            del = Value;
            res = del(x, y);
            Console.WriteLine(res);
            Console.Read();
        }
        private static int Point(char x, string y)
        {
            int num = 0;
            for (int i = 0; i < y.Length; i++)
            {
                if (x == y[i])
                    num++;
            }
            if (num == 0)
                return -1;
            return num;
        }
        private static int Value(char c, string s)
        {
            return s.IndexOf(c);
        }
    }
}