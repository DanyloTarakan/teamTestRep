using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitTeamTestRep
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.FisrtName = "f1";
            person.LastName = "l1";
            Money money = new Money() { money = 1233.44 };
            CreditCard creditCard = new CreditCard() {cardNum = "34561234", password = "dasd" };
        }
    }
}
