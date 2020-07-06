using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            // создаем нового программиста, он работает с с++
            Programmer freelancer = new FreelanceProgrammer(new CPPLanguage());
            freelancer.DoWork();
            freelancer.EarnMoney();
            // пришел новый заказ, но теперь нужен c#
            freelancer.Language = new CSharpLanguage();
            freelancer.DoWork();
            freelancer.EarnMoney();

            Programmer CorporateProgrammer = new CorporateProgrammer(new CSharpLanguage());
            CorporateProgrammer.DoWork();
            CorporateProgrammer.EarnMoney();


            Console.Read();
        }
    }
}
