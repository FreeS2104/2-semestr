using System;


namespace Programm
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime data = new DateTime(2002, 2, 2);
            Console.WriteLine("Введите название вашей организации");
            string name = Console.ReadLine();
            Console.WriteLine("Введите ОКПО вашей организации");

            int okpo = Convert.ToInt32(Console.ReadLine());
            Compony2 new1 = new Compony2(name, okpo, data);
            new1.GetCompanyInfoo();
        }
    }
}