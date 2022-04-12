using System;
using System.Collections.Generic;
using System.Text;

namespace Compony2
{
    class Compony
    {
        public string name;
        public int okpo;
        public DateTime dateOFRegister;
        public string DateRam;
        public string OKPO;
        public string namenull;

        public Compony(string name, int okpo, DateTime data)
        {
            this.name = name;
            if (String.IsNullOrEmpty(name))
                Console.WriteLine("Название компании не блыо указано");
            this.okpo = okpo;
            if (okpo < 9999999)
                OKPO = @"ОКП Введено неверно";
            else if (okpo >= 100000000)
                OKPO = @"ОКП Введено неверно";
            Console.WriteLine(OKPO);
            this.dateOFRegister = data;



            if (data >= new DateTime(1990, 1, 1) && data <= new DateTime(2022, 1, 1))
                dateOFRegister = data;
            else DateRam = @"Временые рамки не верны";
        }

        public void GetCompanyInfoo()
        {
            Console.WriteLine($"Организация {name}, под номером OKPO {okpo} была создана {dateOFRegister}");
            Console.WriteLine(DateRam);

        }


    }
}