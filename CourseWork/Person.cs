using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseWork
{
    /// <summary>
    /// Сутнiсть: "Людина"
    /// </summary>
    class Person
    {
        public Person()
        {

        }
        public Person(string FirstName, string LastName, int Age, string PassportNumber, string PhoneNumber)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Age = Age;
            this.PassportNumber = PassportNumber;
            this.PhoneNumber = PhoneNumber;
        }
        public string PassportNumber { get; set; } // Ключ сутності
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string PhoneNumber { get; set; }
        public override string ToString()
        {
            return FirstName + " " + LastName + " " + Age.ToString() + " " + PassportNumber + " " + PhoneNumber;
        }
    }
}
