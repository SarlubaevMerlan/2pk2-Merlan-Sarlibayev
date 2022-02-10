using System;
using System.Collections.Generic;
using System.Text;

namespace Companys
{
    class Company
    {
        private string name;
        private int okpo;
        private string dateOfRegistry;
        private Random rnd = new Random();

        public Company(string nname, int okp)
        {
            if ((int)Math.Pow(10, 7) <= okp && (int)Math.Pow(10, 8) > okp)
                okpo = okp;
            else
                okpo = rnd.Next((int)Math.Pow(10, 7), (int)Math.Pow(10, 8));

            name = nname;
            dateOfRegistry = DateTime.Now.ToString();
        }

        public Company(string nname)
        {
            name = nname;
            okpo = rnd.Next((int)Math.Pow(10, 7), (int)Math.Pow(10, 8));
            dateOfRegistry = DateTime.Now.ToString();
        }

        public void GetCompanyInfo()
        {
            Console.WriteLine("Компания: " + name +
                              " владеет okpo: " + okpo +
                              "\n Зарегистрированна в " + dateOfRegistry);
        }
    }
}

