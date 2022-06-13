namespace CourseWork
{
    /// <summary>
    /// Посада в банку
    /// </summary>
    public enum Position
    {
        Касир = 0,
        Аналітик,
        Експерт,
        Консультант,
        Менеджер
    }
    /// <summary>
    /// Сутність: "Робітник"
    /// </summary>
    class Employee : Person
    {
        // Ключ сутності, як у батьківського класа
        public Employee() : base()
        {

        }
        public Employee(string FirstName, string LastName, int Age = 25, string PassportNumber = "000000000", string PhoneNumber =
            "+380683373177", Position PositionName = 0, 
            double Salary = 10000, int WorkExperience = 0) :
            base(FirstName, LastName, Age, PassportNumber, PhoneNumber)
        {
            this.PositionName = PositionName;
            this.Salary = Salary;
            this.WorkExperience = WorkExperience;
        }
        public Position PositionName { get; set; }
        public double Salary { get; set; }
        public int WorkExperience { get; set; }
        public override string ToString()
        {
            return base.ToString() + " " + PositionName.ToString() + " " + WorkExperience.ToString() + " " + Salary.ToString() + "\n";
        }
    }
}