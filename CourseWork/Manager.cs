using System;
using System.Collections.Generic;
using System.IO;
namespace CourseWork
{
    /// <summary>
    /// Сутність: "Менеджер"
    /// </summary>
    class Manager : Employee
    {
        // Ключ сутності, як у батьківського класа
        public Manager(string FirstName, string LastName, int Age = 27, string PassportNumber = "000000000", 
            string PhoneNumber="+380683373177", double Salary = 100000, int WorkExperience = 5) 
            : base(FirstName, LastName, Age, PassportNumber, PhoneNumber, Position.Менеджер, Salary, WorkExperience)

        {}
        public Manager() : base()
        {
            Salary = 100000;
        }
        public double Award
        {
            get
            {
                return Salary / 100 * CountOfClients;
            }
        }

        public double CountOfClients
        {
            get
            {
                return Bank.CountClients();
            }
        }

        /// <summary>
        /// Заповнює інформацію, взяту з файлів
        /// </summary>
        static public void FillLists()
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
            string path = @"../../../credits.txt";
            string path1 = @"../../../deposits.txt";
            string path2 = @"../../../employees.txt";

            List<Credit> listOfCredits = new List<Credit>();
            List<Deposit> listOfDeposits = new List<Deposit>();
            List<Employee> listOfEmployees = new List<Employee>();

            string[] creditsInfo = File.ReadAllLines(path);
            for (int i = 1; i < creditsInfo.Length; i++)
            {
                if (creditsInfo[i] == "" || creditsInfo[i] == null)
                    continue;
                string[] fields = creditsInfo[i].Split(' ');
                Person person = new Person(fields[1], fields[2], Convert.ToInt32(fields[3]), fields[4], fields[5]);

                Credit credit = new Credit();
                credit.Owner = person;
                credit.SumOfCredit = Convert.ToDouble(fields[6]);
                credit.Term = Convert.ToInt32(fields[7]);
                credit.InterestRate = Convert.ToDouble(fields[8]);
                credit.FinalSum = Convert.ToDouble(fields[9]);
                credit.ID = Guid.Parse(fields[0]);
                listOfCredits.Add(credit);
            }
            string[] depositsInfo = File.ReadAllLines(path1);
            for (int i = 1; i < depositsInfo.Length; i++)
            {
                if (depositsInfo[i] == "" || depositsInfo[i] == null)
                    continue;
                string[] fields = depositsInfo[i].Split(' ');
                Person person = new Person(fields[1], fields[2], Convert.ToInt32(fields[3]), fields[4], fields[5]);
                Deposit deposit = new Deposit();
                deposit.Owner = person;
                deposit.SumOfDeposit = Convert.ToDouble(fields[6]);
                deposit.Term = Convert.ToInt32(fields[7]);
                deposit.InterestRate = Convert.ToDouble(fields[8]);
                deposit.FinalSum = Convert.ToDouble(fields[9]);
                deposit.ID = Guid.Parse(fields[0]);
                listOfDeposits.Add(deposit);
            }
            
            string[] employeesInfo = File.ReadAllLines(path2);
            for (int i = 1; i < employeesInfo.Length; i++)
            {
                if (employeesInfo[i] == "" || employeesInfo[i] == null)
                    continue;
                string[] fields = employeesInfo[i].Split(' ');
                Position position;
                if (fields[5] == "Касир")
                    position = Position.Касир;
                else if (fields[5] == "Аналітик")
                    position = Position.Аналітик;
                else if (fields[6] == "Експерт")
                    position = Position.Експерт;
                else
                    position = Position.Консультант;
                Employee employee = new Employee(fields[0], fields[1], Convert.ToInt32(fields[2]), fields[3], fields[4], position,
                    Convert.ToDouble(fields[7]), Convert.ToInt32(fields[6]));
                listOfEmployees.Add(employee);
            }

            Bank.ListOfDeposits = listOfDeposits;
            Bank.ListOfCredits = listOfCredits;
            Bank.ListOfEmployees = listOfEmployees;
        }

        /// <summary>
        /// Оновлює інформацію у файлах
        /// </summary>
        static public void UpdateLists()
        {
            string path = @"../../../credits.txt";
            string path1 = @"../../../deposits.txt";
            string path2 = @"../../../employees.txt";

            File.Delete(path);
            File.Delete(path1);
            File.Delete(path2);

            File.AppendAllText(path, "ID | Ім'я | Прізвище | Вік | Номер паспорту | Номер телефону | Сума кредиту | Термін | " +
                            "Процент по кредиту | Сума до виплати\n");
            foreach (var creditInfo in Bank.ListOfCredits)
            {
                File.AppendAllText(path, creditInfo.ToString());
            }

            File.AppendAllText(path1, "ID | Ім'я | Прізвище | Вік | Номер паспорту | Номер телефону | Сума депозиту | Термін | " +
                "Процент по депозиту | Сума виплати\n");
            foreach (var depositInfo in Bank.ListOfDeposits)
            {
                File.AppendAllText(path1, depositInfo.ToString());
            }

            File.AppendAllText(path2, "Ім'я | Прізвище | Вік | Номер паспорту | Номер телефону | Посада в банку | Досвід роботи | Зарплата\n");
            foreach (var employeeInfo in Bank.ListOfEmployees)
            {
                File.AppendAllText(path2, employeeInfo.ToString());
            }
        }
    }
}
