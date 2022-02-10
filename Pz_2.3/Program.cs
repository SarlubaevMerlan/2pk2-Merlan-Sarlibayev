using System;
using Companys;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Company comp = new Company("VLP");
            comp.GetCompanyInfo();
            Company comp2 = new Company("LGA", 12328138);
            comp2.GetCompanyInfo();
        }
    }
}

