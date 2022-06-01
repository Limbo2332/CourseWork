using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork
{
    class Client : Person
    {
        public Client() : base()
        {

        }
        public Client(string FirstName, string LastName, int Age, string PassportNumber, string PhoneNumber) : 
            base(FirstName, LastName, Age, PassportNumber, PhoneNumber)
        {

        }
        public Guid CreditId { get; set; }
        public Guid DepositId { get; set; }
    }
}
