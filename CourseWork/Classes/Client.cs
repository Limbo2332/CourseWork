using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork
{
    class Client : Person
    {
        // Ключ сутності як у базового класу
        public Client() : base()
        {

        }
        public Client(string FirstName, string LastName, int Age, string PassportNumber, string PhoneNumber) : 
            base(FirstName, LastName, Age, PassportNumber, PhoneNumber)
        {

        }
        public Credit credit { get; set; }
        public Deposit deposit { get; set; }
    }
}
