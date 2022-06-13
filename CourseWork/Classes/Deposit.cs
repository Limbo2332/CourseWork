using System;

namespace CourseWork
{
    /// <summary>
    /// Сутність: "Депозит"
    /// </summary>
    class Deposit
    {
        private double interestRate;
        private double finalSum;
        public Deposit()
        {

        }
        public Deposit(Client Owner, double SumOfDeposit, int Term, double InterestRate, double FinalSum)
        {
            this.Owner = Owner;
            this.SumOfDeposit = SumOfDeposit;
            this.Term = Term;
            this.InterestRate = InterestRate;
            this.FinalSum = FinalSum;
        }
        public Guid ID { get; set; } // Ключ сутності
        public double SumOfDeposit { get; set; }
        public double InterestRate
        {
            get
            {
                return interestRate;
            }
            set
            {
                interestRate = value;
            }
        }
        public double FinalSum {
            get
            {
                return finalSum;
            }
            set
            {
                finalSum = value;
            }
        }
        public int Term { get; set; }
        public Client Owner { get; set; }

        /// <summary>
        /// Розраховує середній місячний дохід
        /// </summary>
        public double AverageMontlyIncome()
        {
            return Math.Round((FinalSum - SumOfDeposit) / Term, 2);
        }
        public override string ToString()
        {
            return ID.ToString() + " " + Owner.ToString() + " "
                    + SumOfDeposit.ToString() + " " + Term.ToString() + " " + InterestRate.ToString() + " " + FinalSum.ToString() + "\n";
        }
    }
}
