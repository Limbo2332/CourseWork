using System;

namespace CourseWork
{
    /// <summary>
    /// Сутнiсть: "Кредит"
    /// </summary>
    class Credit
    {
        private double finalSum;
        private double interestRate;
        public Credit()
        {

        }
        public Credit(Person Owner, double SumOfCredit, int Term, double InterestRate, double FinalSum)
        {
            this.Owner = Owner;
            this.SumOfCredit = SumOfCredit;
            this.Term = Term;
            this.InterestRate = InterestRate;
            this.FinalSum = FinalSum;
        }
        public Guid ID { get; set; } // Ключ сутності
        public double SumOfCredit { get; set; }
        public double FinalSum
        {
            get { return finalSum; }
            set { finalSum = value; }
        }
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
        public int Term { get; set; }
        public Person Owner { get; set; }
        /// <summary>
        /// Розраховує щомісячний платіж
        /// </summary>
        public double MonthlyPayment()
        {
            double p = InterestRate / 1200;
            double montlyPayment = SumOfCredit * (p + p / (Math.Pow(1 + p, Term) - 1));
            return Math.Round(montlyPayment, 2);
        }
        public override string ToString()
        {
            return ID.ToString() + " " + Owner.ToString() + " " + SumOfCredit.ToString() + " " + Term.ToString() + " " + InterestRate.ToString() + " " +
                FinalSum.ToString() + "\n";
        }
        public override bool Equals(object other)
        {
            Credit credit = (Credit)other;
            return ID.ToString() == credit.ID.ToString();
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();  
        }
    }
}