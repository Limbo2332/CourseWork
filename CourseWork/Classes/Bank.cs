using System;
using System.Collections.Generic;

namespace CourseWork
{
    /// <summary>
    /// Сутність: "Банк"
    /// </summary>
    static class Bank
    {
        static public string Name { get; } // Ключ сутності
        static public List<Deposit> ListOfDeposits { get; set; }
        static public List<Credit> ListOfCredits { get; set; }
        static public List<Employee> ListOfEmployees { get; set; }
        static public Manager MainManager
        {
            get { return new Manager(); }
        }

        /// <summary>
        /// Розраховує процент для кредиту в банку
        /// </summary>
        static public double CountCreditPercent(Credit credit)
        {

            if (credit.Term < 12)
                return 1.5;
            else if (credit.Term < 36)
                return 2.5;
            else if (credit.Term < 60)
                return 3.5;
            else if (credit.Term < 96)
                return 4.5;
            else
                return 5;
        }

        /// <summary>
        /// Розраховує суму для повної виплати кредиту
        /// </summary>  
        static public double CountFinalSumOfCredit(Credit credit)
        {
            return Math.Round(credit.MonthlyPayment() * credit.Term, 2);
        }

        /// <summary>
        /// Розраховує процент для депозиту в банку.
        /// </summary>
        static public double CountDepositPercent(Deposit deposit)
        {

            if (deposit.Term < 6)
                return 1.5;
            else if (deposit.Term < 12)
                return 2;
            else if (deposit.Term < 24)
                return 2.5;
            else if (deposit.Term < 36)
                return 3;
            else
                return 3.5;
        }

        /// <summary>
        /// Розраховує кінцеву суму депозиту
        /// </summary>
        static public double CountFinalSumOfDeposit(Deposit deposit)
        {
            return Math.Round(deposit.SumOfDeposit * Math.Pow((1 + deposit.InterestRate / 100), ((double)deposit.Term / 12)), 2);
        }

        /// <summary>
        /// Розраховує кількість клієнтів
        /// </summary>
        static public int CountClients()
        {
            return ListOfCredits.Count + ListOfDeposits.Count;
        }

        /// <summary>
        /// Розраховує середній вік клієнтів
        /// </summary>
        static public double AverageAgeOfClients()
        {
            double sum = 0;
            foreach (var credit in ListOfCredits)
                sum += credit.Owner.Age;
            foreach (var deposit in ListOfDeposits)
                sum += deposit.Owner.Age;
            double countClients = CountClients();
            if (countClients == 0)
                return 0;
            return Math.Round(sum / countClients, 2);
        }

        /// <summary>
        /// Розраховує середню суму взятих кредитів
        /// </summary>
        static public double AverageSumOfCredits()
        {
            double sum = 0;
            foreach (var credit in ListOfCredits)
                sum += credit.SumOfCredit;
            if (ListOfCredits.Count == 0)
                return 0;
            return Math.Round(sum / ListOfCredits.Count, 2);
        }

        /// <summary>
        /// Розраховує середню суму взятих депозитів
        /// </summary>
        static public double AverageSumOfDeposits()
        {
            double sum = 0;
            foreach (var deposit in ListOfDeposits)
                sum += deposit.SumOfDeposit;
            if (ListOfDeposits.Count == 0)
                return 0;
            return Math.Round(sum / ListOfDeposits.Count, 2);
        }

        /// <summary>
        /// Розраховує середній термін взятих кредитів/депозитів
        /// </summary>
        static public double AverageTerms()
        {
            int sum = 0;
            foreach (var credit in ListOfCredits)
                sum += credit.Term;
            foreach (var deposit in ListOfDeposits)
                sum += deposit.Term;
            double countClients = CountClients();
            if (countClients == 0)
                return 0;
            return Math.Round((double)sum / countClients, 2);
        }

        /// <summary>
        /// Розраховує прибуток банку
        /// </summary>
        static public double CountIncome()
        {
            double sum = 0;
            foreach (var credit in ListOfCredits)
                sum += credit.FinalSum - credit.SumOfCredit;
            foreach (var deposit in ListOfDeposits)
                sum -= (deposit.FinalSum - deposit.SumOfDeposit);
            return Math.Round(sum, 2);
        }

        /// <summary>
        /// Розраховує витрати на зарплати свіпробітників
        /// </summary>
        static public double SalaryExpense()
        {
            double sum = 0;
            foreach (var employee in ListOfEmployees)
                sum += employee.Salary;
            return sum + MainManager.Salary;
        }
    }
}
