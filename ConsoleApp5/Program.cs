using System;

namespace pz_8
{
    class Program
    {
        delegate int Operation(char x, string y);
        delegate void Symbol(char x);

        static void Main(string[] args)
        {

            char x = 'f';
            string y = "I left home";
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
        private static int Value(char x, string y)
        {
            return y.IndexOf(x);
        }
    }
}