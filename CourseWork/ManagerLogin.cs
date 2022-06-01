using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace CourseWork
{
    public partial class ManagerLogin : Form
    {
        public ManagerLogin()
        {
            InitializeComponent();

            InputEmployeePosition.Items.AddRange(new string[] { Position.Касир.ToString(), Position.Аналітик.ToString(),
            Position.Експерт.ToString(), Position.Консультант.ToString()});

            AddChoise.Items.AddRange(new string[] { "Співробітника", "Кредит", "Депозит" });
            EditChoise.Items.AddRange(new string[] { "Інформацію про співробітника", "Інформацію про кредит", "Інформацію про депозит" });

            EditEmployeePosition.Items.AddRange(new string[] { Position.Касир.ToString(), Position.Аналітик.ToString(),
            Position.Експерт.ToString(), Position.Консультант.ToString()});
        }

        private void ManagerLogin_Load(object sender, EventArgs e)
        {
            Manager.FillLists();
            Size = new Size(620, 493);
            ListBoxInfoChoise.Items.AddRange(new string[] { "Кредити", "Депозити", "Співробітники", "Кількість клієнтів", "Загальна виручка" });
        }

        private void ManagerLogin_FormClosing(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #region MenuStrip
        private void додатиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Size = new Size(620, 493);
            Add.Location = new Point(7, 30);
            Add.Visible = true;
            Remove.Visible = false;
            Edit.Visible = false;
            Info.Visible = false;
        }
        private void видалитиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Size = new Size(620, 375);
            Remove.Location = new Point(7, 30);
            Add.Visible = false;
            Remove.Visible = true;
            Edit.Visible = false;
            Info.Visible = false;
        }
        private void редагуватиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Size = new Size(620, 515);
            Edit.Location = new Point(7, 30);
            Add.Visible = false;
            Remove.Visible = false;
            Edit.Visible = true;
            Info.Visible = false;
        }
        private void інформаціяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Size = new Size(620, 465);
            Info.Location = new Point(7, 30);
            Add.Visible = false;
            Remove.Visible = false;
            Edit.Visible = false;
            Info.Visible = true;
        }
        private void повернутисяНазадToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            var result = MessageBox.Show("Ви дійсно хочете повернутися назад?", "Повернутися назад", buttons);
            if (result == DialogResult.Yes)
            {
                Owner.Visible = true;
                Visible = false;
            }
        }

        private void завершитиРоботуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            var result = MessageBox.Show("Ви точно хочете завершити роботу програми?", "Завершення програми", buttons);
            if (result == DialogResult.Yes)
                Application.Exit();
        }
        #endregion

        #region Checking that the input is correct and availability of deposit/credit/employee
        private bool CheckCorrectness(TextBox inputFirstName, TextBox inputLastName, TextBox inputAge, TextBox inputPassport,
    TextBox inputPhonenumber)
        {
            try
            {
                string firstName = inputFirstName.Text;
                string lastName = inputLastName.Text;
                int age = Convert.ToInt32(inputAge.Text);
                string passportNumber = inputPassport.Text;
                string phoneNumber = inputPhonenumber.Text;

                // регулярні вирази

                Regex Name = new Regex(@"\w");
                Regex ForPassportNumber = new Regex(@"^\d{9}$");
                Regex ForPhoneNumber = new Regex(@"\+380\d{9}$");

                const int AGE_OF_MAJORITY = 18;
                const int RETIREMENT_AGE = 65;

                if (firstName.Length < 2 || !Name.IsMatch(firstName))
                    throw new Exception("Ви ввели недопустиме значення для імені.");
                else if (lastName.Length < 2 || !Name.IsMatch(lastName))
                    throw new Exception("Ви ввели недопустиме значення для прізвища.");
                else if (age < AGE_OF_MAJORITY || age > RETIREMENT_AGE)
                    throw new Exception("Ви повинні бути повнолітнім або не бути пенсіонером.");
                else if (passportNumber.Length != 9 && !ForPassportNumber.IsMatch(passportNumber))
                    throw new Exception("Номер паспорту повинен містити 9 цифр. Перевірте правильність вводу.");
                else if (!ForPhoneNumber.IsMatch(phoneNumber))
                    throw new Exception("Перевірте правильність вводу мобільного телефону.");
                return true;
            }
            catch (FormatException)
            {
                MessageBox.Show("Ви ввели недопустимі значення для деяких полей!");
            }
            catch (OverflowException)
            {
                MessageBox.Show("Ви ввели недопустимі значення для деяких полей!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return false;
        }
        private bool HasDeposit(TextBox inputPassportNumber, TextBox inputPhoneNumber)
        {
            foreach (var deposit in Bank.ListOfDeposits)
                if (deposit.Owner.PassportNumber == inputPassportNumber.Text || deposit.Owner.PhoneNumber == inputPhoneNumber.Text)
                    return true;
            return false;
        }
        private bool HasCredit(TextBox inputPassportNumber, TextBox inputPhoneNumber)
        {
            foreach (var credit in Bank.ListOfCredits)
                if (credit.Owner.PassportNumber == inputPassportNumber.Text || credit.Owner.PhoneNumber == inputPhoneNumber.Text)
                    return true;
            return false;
        }
        private bool IsEmployee(TextBox inputPassportNumber, TextBox inputPhoneNumber)
        {
            foreach (var employee in Bank.ListOfEmployees)
                if (employee.PassportNumber == inputPassportNumber.Text || employee.PhoneNumber == inputPhoneNumber.Text)
                    return true;
            return false;
        }
        #endregion

        #region Add credit/deposit/employee
        private void ConfirmAddButton_Click(object sender, EventArgs e)
        {
            if (CheckCorrectness(InputAddFirstName, InputAddLastName, InputAddAge, InputAddPassport, InputAddPhoneNumber))
            {

                Person person = new Client(InputAddFirstName.Text, InputAddLastName.Text, Convert.ToInt32(InputAddAge.Text),
                    InputAddPassport.Text, InputAddPhoneNumber.Text);

                Person employee = new Employee(InputAddFirstName.Text, InputAddLastName.Text, Convert.ToInt32(InputAddAge.Text),
                    InputAddPassport.Text, InputAddPhoneNumber.Text);

                if (HasCredit(InputAddPassport, InputAddPhoneNumber))
                {
                    MessageBox.Show("Ця людина вже має кредит в нашому банку! Ми не можемо дати їй ще один кредит!");
                    return;
                }
                if (HasDeposit(InputAddPassport, InputAddPhoneNumber))
                {
                    MessageBox.Show("Ця людина вже має депозит в нашому банку! Ми не можемо дати їй ще один депозит!");
                    return;
                }
                if (IsEmployee(InputAddPassport, InputAddPhoneNumber))
                {
                    MessageBox.Show("Ця людина вже працює в нашому банку! Ми не можемо взяти її на роботу!");
                    return;
                }

                if ((string)AddChoise.SelectedItem == "Співробітника")
                {
                    Employee finalEmployee = (Employee)employee;
                    finalEmployee.PositionName = (Position)InputEmployeePosition.SelectedIndex;
                    finalEmployee.WorkExperience = 0;
                    try
                    {
                        finalEmployee.Salary = Convert.ToInt32(InputEmployeeSalary.Text);
                        if (finalEmployee.Salary < 6500 || finalEmployee.Salary > 100000)
                            throw new Exception("Зарплата не може бути більшою за 100000 грн і меншою за 6500 грн!");

                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("Ви ввели недопустиме значення для зарплати!");
                        return;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        return;
                    }
                    string path = @"../../../employees.txt";
                    string contents = employee.ToString();

                    File.AppendAllText(path, contents);
                    Bank.ListOfEmployees.Add(finalEmployee);

                    MessageBox.Show("Робітник успішно взятий на роботу!");
                }
                else if ((string)AddChoise.SelectedItem == "Кредит")
                {
                    Credit credit = new Credit();
                    try
                    {
                        credit.SumOfCredit = Convert.ToDouble(InputSum.Text);
                        credit.Term = Convert.ToInt32(InputTerm.Text);
                        credit.InterestRate = Bank.CountCreditProcent(credit);
                        credit.FinalSum = Bank.CountFinalSumOfCredit(credit);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Ви ввели недопустиме значення полей!(Інформація про кредит)");
                        return;
                    }

                    credit.ID = Guid.NewGuid();

                    Client client = (Client)person;
                    credit.Owner = client;

                    string path = @"../../../credits.txt";
                    string contents = credit.ToString();

                    File.AppendAllText(path, contents);
                    Bank.ListOfCredits.Add(credit);

                    MessageBox.Show("Ви успішно взяли кредит в нашому банку!");
                }
                else if ((string)AddChoise.SelectedItem == "Депозит")
                {
                    Deposit deposit = new Deposit();
                    try
                    {
                        deposit.SumOfDeposit = Convert.ToDouble(InputSum.Text);
                        deposit.Term = Convert.ToInt32(InputTerm.Text);
                        deposit.InterestRate = Bank.CountDepositProcent(deposit);
                        deposit.FinalSum = Bank.CountFinalSumOfDeposit(deposit);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Ви ввели недопустиме значення полей!(Інформація про депозит)");
                        return;
                    }
                    deposit.ID = Guid.NewGuid();

                    Client client = (Client)person;
                    deposit.Owner = client;

                    string path = @"../../../deposits.txt";
                    string contents = deposit.ToString();

                    File.AppendAllText(path, contents);
                    Bank.ListOfDeposits.Add(deposit);

                    MessageBox.Show("Ви успішно отримали депозит в нашому банку!");
                }
                else
                {
                    MessageBox.Show("Ви не обрали, кого добавити!");
                    return;
                }
            }

        }

        private void AddChoise_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((string)AddChoise.SelectedItem == "Співробітника")
            {
                LabelAddEmployeePosition.Visible = true;
                LabelAddEmployeeSalary.Visible = true;
                LabelAddSumOfCredit.Visible = false;
                LabelAddSumOfDeposit.Visible = false;
                LabelTerm.Visible = false;

                InputEmployeePosition.Visible = true;
                InputEmployeeSalary.Visible = true;
                InputSum.Visible = false;
                InputTerm.Visible = false;
            }
            if ((string)AddChoise.SelectedItem == "Кредит")
            {
                LabelAddSumOfCredit.Location = new Point(157, 278);
                LabelTerm.Location = new Point(157, 318);
                InputSum.Location = new Point(265, 288);
                InputTerm.Location = new Point(265, 328);

                LabelAddEmployeePosition.Visible = false;
                LabelAddEmployeeSalary.Visible = false;
                LabelAddSumOfCredit.Visible = true;
                LabelAddSumOfDeposit.Visible = false;
                LabelTerm.Visible = true;

                InputEmployeePosition.Visible = false;
                InputEmployeeSalary.Visible = false;
                InputSum.Visible = true;
                InputTerm.Visible = true;
            }
            if ((string)AddChoise.SelectedItem == "Депозит")
            {
                LabelAddSumOfDeposit.Location = new Point(157, 278);
                LabelTerm.Location = new Point(157, 318);
                InputSum.Location = new Point(265, 288);
                InputTerm.Location = new Point(265, 328);

                LabelAddEmployeePosition.Visible = false;
                LabelAddEmployeeSalary.Visible = false;
                LabelAddSumOfCredit.Visible = false;
                LabelAddSumOfDeposit.Visible = true;
                LabelTerm.Visible = true;

                InputEmployeePosition.Visible = false;
                InputEmployeeSalary.Visible = false;
                InputSum.Visible = true;
                InputTerm.Visible = true;
            }
        }
        #endregion

        #region Remove credit/deposit/employee
        private void ButtonRemoveConfirm_Click(object sender, EventArgs e)
        {
            string passportNumber = InputRemovePassport.Text;
            string phoneNumber = InputRemovePhone.Text;

            Regex ForPassportNumber = new Regex(@"^\d{9}$");
            Regex ForPhoneNumber = new Regex(@"\+380\d{9}$");

            try
            {
                if (passportNumber.Length != 9 && !ForPassportNumber.IsMatch(passportNumber))
                    throw new Exception("Номер паспорту повинен містити 9 цифр. Перевірте правильність вводу.");
                else if (!ForPhoneNumber.IsMatch(phoneNumber))
                    throw new Exception("Перевірте правильність вводу мобільного телефону.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            foreach (var credit in Bank.ListOfCredits)
            {
                if (credit.Owner.PassportNumber == passportNumber && credit.Owner.PhoneNumber != phoneNumber)
                {
                    MessageBox.Show("Перевірте правильність вводу мобільного телефону.");
                    return;
                }
                else if (credit.Owner.PassportNumber != passportNumber && credit.Owner.PhoneNumber == phoneNumber)
                {
                    MessageBox.Show("Перевірте правильність вводу номеру паспорту!");
                    return;
                }
                else if (credit.Owner.PassportNumber == passportNumber && credit.Owner.PhoneNumber == phoneNumber)
                {
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    var result = MessageBox.Show("В даного користувача знайдено кредит! Ви впевнені, що хочете видалити " +
                        "інформацію про кредит?", "Підтвердити видалення", buttons);
                    if (result == DialogResult.Yes)
                    {
                        Bank.ListOfCredits.Remove(credit);
                        MessageBox.Show("Успішно видалено!");
                        Manager.UpdateLists();
                        return;
                    }
                }
            }
            foreach (var deposit in Bank.ListOfDeposits)
            {
                if (deposit.Owner.PassportNumber == passportNumber && deposit.Owner.PhoneNumber != phoneNumber)
                {
                    MessageBox.Show("Перевірте правильність вводу мобільного телефону.");
                    return;
                }
                else if (deposit.Owner.PassportNumber != passportNumber && deposit.Owner.PhoneNumber == phoneNumber)
                {
                    MessageBox.Show("Перевірте правильність вводу номеру паспорту!");
                    return;
                }
                else if (deposit.Owner.PassportNumber == passportNumber && deposit.Owner.PhoneNumber == phoneNumber)
                {
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    var result = MessageBox.Show("В даного користувача знайдено депозит! Ви впевнені, що хочете видалити " +
                        "інформацію про депозит?", "Підтвердити видалення", buttons);
                    if (result == DialogResult.Yes)
                    {
                        Bank.ListOfDeposits.Remove(deposit);
                        MessageBox.Show("Успішно видалено!");
                        Manager.UpdateLists();
                        return;
                    }
                }
            }
            foreach (var employee in Bank.ListOfEmployees)
            {
                if (employee.PassportNumber == passportNumber && employee.PhoneNumber != phoneNumber)
                {
                    MessageBox.Show("Перевірте правильність вводу мобільного телефону.");
                    return;
                }
                else if (employee.PassportNumber != passportNumber && employee.PhoneNumber == phoneNumber)
                {
                    MessageBox.Show("Перевірте правильність вводу номеру паспорту!");
                    return;
                }
                else if (employee.PassportNumber == passportNumber && employee.PhoneNumber == phoneNumber)
                {
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    var result = MessageBox.Show("Цей користувач працює у нас в банку! Ви впевнені, що хочете звільнити " +
                        "його?", "Підтвердити звільнення", buttons);
                    if (result == DialogResult.Yes)
                    {
                        Bank.ListOfEmployees.Remove(employee);
                        MessageBox.Show("Успішно видалено!");
                        Manager.UpdateLists();
                        return;
                    }
                }
            }
            MessageBox.Show("Даний користувач не працює в нашому банку, немає депозиту чи кредиту.");
        }
        #endregion

        #region Edit Info about credit/deposit/employee
        private bool EditPersonValues(ref Person person)
        {
            EditEmployeePosition.Visible = false;

            Regex Name = new Regex(@"[а-я]");
            Regex ForPassportNumber = new Regex(@"^\d{9}$");
            Regex ForPhoneNumber = new Regex(@"\+380\d{9}$");

            const int AGE_OF_MAJORITY = 18;
            const int RETIREMENT_AGE = 65;

            if ((string)EditChoiseParameter.SelectedItem == "Ім'я")
            {
                if (Name.IsMatch(InputEditParameter.Text))
                {
                    person.FirstName = InputEditParameter.Text;
                    MessageBox.Show("Ім'я успішно змінено!");
                    return true;
                }
                else
                {
                    MessageBox.Show("Перевірте правильність вводу імені!");
                    return false;
                }
            }
            else if ((string)EditChoiseParameter.SelectedItem == "Прізвище")
            {
                if (Name.IsMatch(InputEditParameter.Text))
                {
                    person.LastName = InputEditParameter.Text;
                    MessageBox.Show("Прізвище успішно змінено!");
                    return true;
                }
                else
                {
                    MessageBox.Show("Перевірте правильність вводу прізвища!");
                    return false;
                }
            }
            else if ((string)EditChoiseParameter.SelectedItem == "Вік")
            {
                try
                {
                    int age = Convert.ToInt32(InputEditParameter.Text);
                    if (age < AGE_OF_MAJORITY || age > RETIREMENT_AGE)
                        throw new Exception("Ви повинні бути повнолітнім або не бути пенсіонером.");
                    person.Age = age;
                    MessageBox.Show("Вік успішно змінено!");
                    return true;
                }
                catch (FormatException)
                {
                    MessageBox.Show("Перевірте правильність вводу!");
                }
                catch (OverflowException)
                {
                    MessageBox.Show("Перевірте правильність вводу!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                return false;
            }
            else if ((string)EditChoiseParameter.SelectedItem == "Номер паспорту")
            {
                try
                {
                    string passportNumber = InputEditParameter.Text;
                    foreach (var credit in Bank.ListOfCredits)
                        if (credit.Owner.PassportNumber == passportNumber)
                            throw new Exception("Користувач з цим номером паспорту вже має кредит! Операцію відмінено!");

                    foreach (var deposit in Bank.ListOfDeposits)
                        if (deposit.Owner.PassportNumber == passportNumber)
                            throw new Exception("Користувач з цим номером паспорту вже має депозит! Операцію відмінено!");

                    foreach (var employee in Bank.ListOfEmployees)
                        if (employee.PassportNumber == passportNumber)
                            throw new Exception("Користувач з цим номером паспорту вже працює в нашому банку! Операцію відмінено!");

                    if (passportNumber.Length != 9 && !ForPassportNumber.IsMatch(passportNumber))
                        throw new Exception("Номер паспорту повинен містити 9 цифр. Перевірте правильність вводу.");

                    person.PassportNumber = passportNumber;
                    MessageBox.Show("Номер паспорту успішно змінено!");
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                return false;
            }
            else if ((string)EditChoiseParameter.SelectedItem == "Номер телефону")
            {
                try
                {
                    string phoneNumber = InputEditParameter.Text;
                    foreach (var credit in Bank.ListOfCredits)
                        if (credit.Owner.PhoneNumber == phoneNumber)
                            throw new Exception("Користувач з цим номером телефону вже має кредит! Операцію відмінено!");

                    foreach (var deposit in Bank.ListOfDeposits)
                        if (deposit.Owner.PhoneNumber == phoneNumber)
                            throw new Exception("Користувач з цим номером телефону вже має депозит! Операцію відмінено!");

                    foreach (var employee in Bank.ListOfEmployees)
                        if (employee.PhoneNumber == phoneNumber)
                            throw new Exception("Користувач з цим номером телефону вже працює в нашому банку! Операцію відмінено!");

                    if (!ForPhoneNumber.IsMatch(phoneNumber))
                        throw new Exception("Перевірте правильність вводу мобільного телефону.");

                    person.PhoneNumber = phoneNumber;
                    MessageBox.Show("Номер телефону успішно змінено!");
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                return false;
            }
            return false;
        }

        private void EditChoise_SelectedIndexChanged(object sender, EventArgs e)
        {
            EditEmployeePosition.Visible = false;

            LabelEditChoise.Visible = true;
            EditChoiseParameter.Visible = true;
            LabelEditInfo.Visible = true;
            LabelEditPassport.Visible = true;
            LabelEditPhone.Visible = true;
            InputEditPassport.Visible = true;
            InputEditPhone.Visible = true;

            EditChoiseParameter.Items.Clear();

            if ((string)EditChoise.SelectedItem == "Інформацію про співробітника")
                EditChoiseParameter.Items.AddRange(new string[]{"Ім'я", "Прізвище", "Вік", "Номер паспорту", "Номер телефону",
                "Посаду в банку", "Досвід роботи", "Зарплату" });

            else if ((string)EditChoise.SelectedItem == "Інформацію про кредит")
                EditChoiseParameter.Items.AddRange(new string[]{"Ім'я", "Прізвище", "Вік", "Номер паспорту", "Номер телефону",
                "Суму кредиту", "Термін", "Процент по кредиту", "Суму до виплати" });

            else if ((string)EditChoise.SelectedItem == "Інформацію про депозит")
                EditChoiseParameter.Items.AddRange(new string[]{"Ім'я", "Прізвище", "Вік", "Номер паспорту", "Номер телефону",
                "Суму депозиту", "Термін", "Процент по депозиту", "Суму виплати" });

        }

        private void EditChoiseParameter_SelectedIndexChanged(object sender, EventArgs e)
        {
            EditEmployeePosition.Visible = false;

            LabelEditParameter.Visible = true;
            InputEditParameter.Visible = true;
            EditConfirmButton.Visible = true;

            if ((string)EditChoiseParameter.SelectedItem == "Ім'я")
                LabelEditParameter.Text = "Нове значення для імені:";
            else if ((string)EditChoiseParameter.SelectedItem == "Прізвище")
                LabelEditParameter.Text = "Нове значення для прізвища:";
            else if ((string)EditChoiseParameter.SelectedItem == "Вік")
                LabelEditParameter.Text = "Нове значення для віку:";
            else if ((string)EditChoiseParameter.SelectedItem == "Номер паспорту")
                LabelEditParameter.Text = "Нове значення для номера паспорту:";
            else if ((string)EditChoiseParameter.SelectedItem == "Номер телефону")
                LabelEditParameter.Text = "Нове значення для номера телефону:";

            if ((string)EditChoiseParameter.SelectedItem == "Посаду в банку" &&
                (string)EditChoise.SelectedItem == "Інформацію про співробітника")
            {
                LabelEditParameter.Text = "Нове значення посади в банку:";
                InputEditParameter.Visible = false;
                EditEmployeePosition.Visible = true;
                EditEmployeePosition.Location = InputEditParameter.Location;

            }

            else if ((string)EditChoiseParameter.SelectedItem == "Досвід роботи" &&
                (string)EditChoise.SelectedItem == "Інформацію про співробітника")
                LabelEditParameter.Text = "Нове значення досвіду роботи:";
            else if ((string)EditChoiseParameter.SelectedItem == "Зарплату" &&
                (string)EditChoise.SelectedItem == "Інформацію про співробітника")
                LabelEditParameter.Text = "Нове значення зарплати:";

            if ((string)EditChoiseParameter.SelectedItem == "Суму кредиту" &&
                (string)EditChoise.SelectedItem == "Інформацію про кредит")
                LabelEditParameter.Text = "Нове значення суми кредиту:";
            else if ((string)EditChoiseParameter.SelectedItem == "Термін" &&
                (string)EditChoise.SelectedItem == "Інформацію про кредит")
                LabelEditParameter.Text = "Нове значення терміну кредиту:";
            else if ((string)EditChoiseParameter.SelectedItem == "Процент по кредиту" &&
                (string)EditChoise.SelectedItem == "Інформацію про кредит")
                LabelEditParameter.Text = "Нове значення проценту по кредиту:";
            else if ((string)EditChoiseParameter.SelectedItem == "Суму до виплати" &&
                (string)EditChoise.SelectedItem == "Інформацію про кредит")
                LabelEditParameter.Text = "Нове значення суми до виплати:";

            if ((string)EditChoiseParameter.SelectedItem == "Суму депозиту" &&
                (string)EditChoise.SelectedItem == "Інформацію про депозит")
                LabelEditParameter.Text = "Нове значення суми депозиту:";
            else if ((string)EditChoiseParameter.SelectedItem == "Термін" &&
                (string)EditChoise.SelectedItem == "Інформацію про депозит")
                LabelEditParameter.Text = "Нове значення терміну депозиту:";
            else if ((string)EditChoiseParameter.SelectedItem == "Процент по депозиту" &&
                (string)EditChoise.SelectedItem == "Інформацію про депозит")
                LabelEditParameter.Text = "Нове значення проценту по депозиту:";
            else if ((string)EditChoiseParameter.SelectedItem == "Суму виплати" &&
                (string)EditChoise.SelectedItem == "Інформацію про депозит")
                LabelEditParameter.Text = "Нове значення суми виплати:";
        }

        private void EditConfirmButton_Click(object sender, EventArgs e)
        {
            string passportNumber = InputEditPassport.Text;
            string phoneNumber = InputEditPhone.Text;

            Regex ForPassportNumber = new Regex(@"^\d{9}$");
            Regex ForPhoneNumber = new Regex(@"\+380\d{9}$");

            try
            {
                if (passportNumber.Length != 9 && !ForPassportNumber.IsMatch(passportNumber))
                    throw new Exception("Номер паспорту повинен містити 9 цифр. Перевірте правильність вводу.");
                else if (!ForPhoneNumber.IsMatch(phoneNumber))
                    throw new Exception("Перевірте правильність вводу мобільного телефону.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            if ((string)EditChoise.SelectedItem == "Інформацію про кредит")
            {
                bool hasCredit = false;
                foreach (var credit in Bank.ListOfCredits)
                {
                    if (credit.Owner.PassportNumber == passportNumber && credit.Owner.PhoneNumber != phoneNumber)
                    {
                        MessageBox.Show("Перевірте правильність вводу мобільного телефону.");
                        return;
                    }
                    else if (credit.Owner.PassportNumber != passportNumber && credit.Owner.PhoneNumber == phoneNumber)
                    {
                        MessageBox.Show("Перевірте правильність вводу номеру паспорту!");
                        return;
                    }
                    else if (credit.Owner.PassportNumber == passportNumber && credit.Owner.PhoneNumber == phoneNumber)
                    {
                        hasCredit = true;

                        Person person = credit.Owner;

                        if (EditPersonValues(ref person))
                        {
                            credit.Owner = (Client)person;
                            return;
                        }
                        if ((string)EditChoiseParameter.SelectedItem == "Суму кредиту")
                        {
                            try
                            {
                                const double MIN_SUM_OF_CREDIT = 10000;
                                const double MAX_SUM_OF_CREDIT = 1000000;

                                double sumOfCredit = Convert.ToDouble(InputEditParameter.Text);
                                if (sumOfCredit < MIN_SUM_OF_CREDIT || sumOfCredit > MAX_SUM_OF_CREDIT)
                                    throw (new Exception("Сума кредиту не може бути більшою, " +
                                    "ніж 1 мільйон гривень, або меншою, ніж 10000 грн"));
                                credit.SumOfCredit = sumOfCredit;
                                credit.FinalSum = Bank.CountFinalSumOfCredit(credit);
                                MessageBox.Show("Сума кредиту успішно змінена! Попередження: оскільки Ви змінили суму кредиту, то і інші " +
                                    "характеристики автоматично змінені!");
                            }
                            catch (FormatException)
                            {
                                MessageBox.Show("Ви ввели недопустиме значення!");
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                            Manager.UpdateLists();
                            return;
                        }
                        else if ((string)EditChoiseParameter.SelectedItem == "Термін")
                        {
                            try
                            {
                                const int MAX_TERM_CREDIT = 120;
                                
                                int term = Convert.ToInt32(InputEditParameter.Text);

                                if (term <= 0 || term > MAX_TERM_CREDIT)
                                    throw (new Exception("Термін кредиту не може бути більшим, ніж 10 років!"));

                                credit.Term = term;
                                credit.InterestRate = Bank.CountCreditProcent(credit);
                                credit.FinalSum = Bank.CountFinalSumOfCredit(credit);

                                MessageBox.Show("Термін успішно змінена! Попередження: оскільки Ви змінили термін, то і інші " +
                                    "характеристики автоматично змінені!");
                            }
                            catch (FormatException)
                            {
                                MessageBox.Show("Ви ввели недопустиме значення!");
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                            Manager.UpdateLists();
                            return;
                        }
                        else if ((string)EditChoiseParameter.SelectedItem == "Процент по кредиту")
                        {
                            try
                            {
                                const double MAX_INTERESTRATE_FOR_CREDIT = 10;

                                double interestRate = Convert.ToDouble(InputEditParameter.Text);

                                if (interestRate <= 0 || interestRate > MAX_INTERESTRATE_FOR_CREDIT)
                                    throw (new Exception("Процент по кредиту не може бути більшим, ніж 10%!"));

                                credit.InterestRate = interestRate;
                                credit.FinalSum = Bank.CountFinalSumOfCredit(credit);
                                MessageBox.Show("Процент по кредиту успішно змінено! Попередження: оскільки Ви змінили процент, то і інші " +
                                    "характеристики автоматично змінені!");
                            }
                            catch (FormatException)
                            {
                                MessageBox.Show("Ви ввели недопустиме значення!");
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                            Manager.UpdateLists();
                            return;
                        }
                        else if ((string)EditChoiseParameter.SelectedItem == "Суму до виплати")
                        {
                            try
                            {
                                const double MIN_SUM_OF_CREDIT = 10000;
                                const double MAX_SUM_OF_CREDIT = 1000000;

                                double finalSum = Convert.ToDouble(InputEditParameter.Text);
                                if (finalSum <= MIN_SUM_OF_CREDIT + 1 || finalSum > MAX_SUM_OF_CREDIT * 1.1)
                                    throw (new Exception("Сума до виплати не може бути більшою, за 1,1 млн гривень " +
                                        "і меншою за 10001 гривню!"));

                                credit.FinalSum = finalSum;

                                double p = credit.InterestRate / 1200;
                                double help = p + p / (Math.Pow(1 + p, credit.Term) - 1);
                                credit.SumOfCredit = Math.Round(finalSum / (double)(help * credit.Term), 2);

                                MessageBox.Show("Сума до виплати успішно змінено! Попередження: оскільки Ви змінили суму до виплати, то і інші " +
                                    "характеристики автоматично змінені!");
                            }
                            catch (FormatException)
                            {
                                MessageBox.Show("Ви ввели недопустиме значення!");
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                            Manager.UpdateLists();
                            return;
                        }
                    }
                }
                if (!hasCredit)
                    MessageBox.Show("Даний користувач немає кредиту!");
            }
            else if ((string)EditChoise.SelectedItem == "Інформацію про депозит")
            {
                bool hasDeposit = false;
                foreach (var deposit in Bank.ListOfDeposits)
                {
                    if (deposit.Owner.PassportNumber == passportNumber && deposit.Owner.PhoneNumber != phoneNumber)
                    {
                        MessageBox.Show("Перевірте правильність вводу мобільного телефону.");
                        return;
                    }
                    else if (deposit.Owner.PassportNumber != passportNumber && deposit.Owner.PhoneNumber == phoneNumber)
                    {
                        MessageBox.Show("Перевірте правильність вводу номеру паспорту!");
                        return;
                    }
                    else if (deposit.Owner.PassportNumber == passportNumber && deposit.Owner.PhoneNumber == phoneNumber)
                    {
                        hasDeposit = true;
                        Person person = deposit.Owner;

                        if (EditPersonValues(ref person))
                        {
                            deposit.Owner = (Client)person;
                            return;
                        }

                        if ((string)EditChoiseParameter.SelectedItem == "Суму депозиту")
                        {
                            try
                            {
                                const double MIN_SUM_OF_DEPOSIT = 1000;
                                const double MAX_SUM_OF_DEPOSIT = 1000000;

                                double sumOfDeposit = Convert.ToDouble(InputEditParameter.Text);
                                if (sumOfDeposit < MIN_SUM_OF_DEPOSIT || sumOfDeposit > MAX_SUM_OF_DEPOSIT)
                                    throw (new Exception("Сума депозиту не може бути більшою, " +
                                    "ніж 1 мільйон гривень, або меншою, ніж 1000 грн"));

                                deposit.SumOfDeposit = sumOfDeposit;
                                deposit.FinalSum = Bank.CountFinalSumOfDeposit(deposit);

                                MessageBox.Show("Сума депозиту успішно змінена! Попередження: оскільки Ви змінили суму депозиту, " +
                                    "то і інші характеристики автоматично змінені!");
                            }
                            catch (FormatException)
                            {
                                MessageBox.Show("Ви ввели недопустиме значення!");
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                            Manager.UpdateLists();
                            return;
                        }
                        else if ((string)EditChoiseParameter.SelectedItem == "Термін")
                        {
                            try
                            {
                                const int MAX_TERM_DEPOSIT = 60;

                                int term = Convert.ToInt32(InputEditParameter.Text);
                                if (term <= 0 || term > MAX_TERM_DEPOSIT)
                                    throw (new Exception("Термін депозиту не може бути більшим, ніж 5 років!"));
                                deposit.Term = term;

                                deposit.FinalSum = Bank.CountFinalSumOfDeposit(deposit);
                                MessageBox.Show("Термін успішно змінена! Попередження: оскільки Ви змінили термін, то і інші " +
                                    "характеристики автоматично змінені!");
                            }
                            catch (FormatException)
                            {
                                MessageBox.Show("Ви ввели недопустиме значення!");
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                            Manager.UpdateLists();
                            return;
                        }
                        else if ((string)EditChoiseParameter.SelectedItem == "Процент по депозиту")
                        {
                            try
                            {
                                const double MAX_INTEREST_RATE_FOR_DEPOSIT = 5;

                                double interestRate = Convert.ToDouble(InputEditParameter.Text);
                                if (interestRate <= 0 || interestRate > MAX_INTEREST_RATE_FOR_DEPOSIT)
                                    throw (new Exception("Процент по депозиту не може бути більшим, ніж 5%!"));

                                deposit.InterestRate = interestRate;
                                deposit.FinalSum = Bank.CountFinalSumOfDeposit(deposit);

                                MessageBox.Show("Процент по депозиту успішно змінено! Попередження: оскільки Ви змінили процент, то і інші " +
                                    "характеристики автоматично змінені!");
                            }
                            catch (FormatException)
                            {
                                MessageBox.Show("Ви ввели недопустиме значення!");
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                            Manager.UpdateLists();
                            return;
                        }
                        else if ((string)EditChoiseParameter.SelectedItem == "Суму виплати")
                        {

                            const double MIN_SUM_OF_DEPOSIT = 1000;
                            const double MAX_SUM_OF_DEPOSIT = 1000000;

                            try
                            {
                                double finalSum = Convert.ToDouble(InputEditParameter.Text);
                                if (finalSum <= MIN_SUM_OF_DEPOSIT + 1 || finalSum > MAX_SUM_OF_DEPOSIT * 1.05)
                                    throw (new Exception("Сума до виплати не може бути більшою, за 1,05 млн гривень і " +
                                        "меншою за 10001 гривню!"));
                                deposit.FinalSum = finalSum;
                                deposit.InterestRate = Bank.CountDepositProcent(deposit);
                                deposit.SumOfDeposit = Math.Round(finalSum / Math.Pow(1 + deposit.InterestRate / 100, deposit.Term / 12), 2);
                                MessageBox.Show("Сума виплати успішно змінено! Попередження: оскільки Ви змінили суму виплати, то і інші " +
                                    "характеристики автоматично змінені!");
                            }
                            catch (FormatException)
                            {
                                MessageBox.Show("Ви ввели недопустиме значення!");
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                            Manager.UpdateLists();
                            return;
                        }
                    }
                }
                if(!hasDeposit)
                    MessageBox.Show("Даний користувач немає депозиту!");
            }
            else if ((string)EditChoise.SelectedItem == "Інформацію про співробітника")
            {
                bool isEmployee = false;
                foreach (var employee in Bank.ListOfEmployees)
                {
                    if (employee.PassportNumber == passportNumber && employee.PhoneNumber != phoneNumber)
                    {
                        MessageBox.Show("Перевірте правильність вводу мобільного телефону.");
                        return;
                    }
                    else if (employee.PassportNumber != passportNumber && employee.PhoneNumber == phoneNumber)
                    {
                        MessageBox.Show("Перевірте правильність вводу номеру паспорту!");
                        return;
                    }
                    else if (employee.PassportNumber == passportNumber && employee.PhoneNumber == phoneNumber)
                    {
                        isEmployee = true;
                        Person person = employee;

                        if (EditPersonValues(ref person))
                        {
                            employee.FirstName = person.FirstName;
                            employee.LastName = person.LastName;
                            employee.Age = person.Age;
                            employee.PassportNumber = person.PassportNumber;
                            employee.PhoneNumber = person.PhoneNumber;
                            Manager.UpdateLists();
                            return;
                        }


                        if ((string)EditChoiseParameter.SelectedItem == "Посаду в банку")
                        {
                            try
                            {
                                Position position = (Position)Convert.ToInt32(EditEmployeePosition.SelectedIndex);
                                employee.PositionName = position;
                                MessageBox.Show("Посада співробітника успішно змінена!");
                            }
                            catch (FormatException)
                            {
                                MessageBox.Show("Ви ввели недопустиме значення!");
                            }
                            Manager.UpdateLists();
                            return;
                        }
                        else if ((string)EditChoiseParameter.SelectedItem == "Досвід роботи")
                        {
                            try
                            {
                                int workExperience = Convert.ToInt32(InputEditParameter.Text);
                                employee.WorkExperience = workExperience;
                                MessageBox.Show("Досвід співробітника успішно змінено!");
                            }
                            catch (FormatException)
                            {
                                MessageBox.Show("Ви ввели недопустиме значення!");
                            }
                            Manager.UpdateLists();
                            return;
                        }
                        else if ((string)EditChoiseParameter.SelectedItem == "Зарплату")
                        {
                            const double MIN_SALARY = 6500;
                            const double MAX_SALARY = 100000;

                            try
                            {
                                double salary = Convert.ToDouble(InputEditParameter.Text);
                                if (salary < MIN_SALARY || salary > MAX_SALARY)
                                    throw new Exception("Зарплата не може бути більшою, ніж 100 тисяч грн і меншою, ніж 6500 грн.");

                                employee.Salary = salary;
                                MessageBox.Show("Зарплату співробітника успішно змінено!");
                            }
                            catch (FormatException)
                            {
                                MessageBox.Show("Ви ввели недопустиме значення!");
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                            Manager.UpdateLists();
                            return;
                        }
                    }
                }
                if(!isEmployee)
                    MessageBox.Show("Даний користувач не працює в нашому банку!");
            }
        }
        #endregion

        #region Show info
        private void ListBoxInfoChoise_SelectedIndexChanged(object sender, EventArgs e)
        {
            TableView.AllowUserToAddRows = false;
            TableView.Visible = true;
            if ((string)ListBoxInfoChoise.SelectedItem == "Кредити")
            {
                DataTable credits = new DataTable();

                credits.Columns.Add("Ім'я");
                credits.Columns.Add("Прізвище");
                credits.Columns.Add("Вік", typeof(int));
                credits.Columns.Add("Номер паспорту");
                credits.Columns.Add("Номер телефону");
                credits.Columns.Add("Сума кредиту", typeof(double));
                credits.Columns.Add("Термін", typeof(int));
                credits.Columns.Add("Процент по кредиту", typeof(double));
                credits.Columns.Add("Сума до виплати", typeof(double));

                foreach (var credit in Bank.ListOfCredits)
                    credits.Rows.Add(credit.Owner.FirstName, credit.Owner.LastName, credit.Owner.Age, credit.Owner.PassportNumber,
                        credit.Owner.PhoneNumber, credit.SumOfCredit, credit.Term, credit.InterestRate, credit.FinalSum);

                TableView.DataSource = credits;
            }
            else if ((string)ListBoxInfoChoise.SelectedItem == "Депозити")
            {
                DataTable deposits = new DataTable();

                deposits.Columns.Add("Ім'я");
                deposits.Columns.Add("Прізвище");
                deposits.Columns.Add("Вік", typeof(int));
                deposits.Columns.Add("Номер паспорту");
                deposits.Columns.Add("Номер телефону");
                deposits.Columns.Add("Сума депозиту", typeof(double));
                deposits.Columns.Add("Термін", typeof(int));
                deposits.Columns.Add("Процент по депозиту", typeof(double));
                deposits.Columns.Add("Сума виплати", typeof(double));

                foreach (var deposit in Bank.ListOfDeposits)
                    deposits.Rows.Add(deposit.Owner.FirstName, deposit.Owner.LastName, deposit.Owner.Age, deposit.Owner.PassportNumber,
                        deposit.Owner.PhoneNumber, deposit.SumOfDeposit, deposit.Term, deposit.InterestRate, deposit.FinalSum);

                TableView.DataSource = deposits;
            }
            else if ((string)ListBoxInfoChoise.SelectedItem == "Співробітники")
            {
                DataTable employees = new DataTable();

                employees.Columns.Add("Ім'я");
                employees.Columns.Add("Прізвище");
                employees.Columns.Add("Вік", typeof(int));
                employees.Columns.Add("Номер паспорту");
                employees.Columns.Add("Номер телефону");
                employees.Columns.Add("Посада в банку", typeof(Position));
                employees.Columns.Add("Досвід роботи", typeof(int));
                employees.Columns.Add("Зарплата", typeof(double));

                foreach (var employee in Bank.ListOfEmployees)
                    employees.Rows.Add(employee.FirstName, employee.LastName, employee.Age, employee.PassportNumber,
                        employee.PhoneNumber, employee.PositionName, employee.WorkExperience, employee.Salary);

                TableView.DataSource = employees;
            }
            else if ((string)ListBoxInfoChoise.SelectedItem == "Кількість клієнтів")
            {
                DataTable countOfClients = new DataTable();
                Manager manager = new Manager();

                countOfClients.Columns.Add("Кількість клієнтів", typeof(int));
                countOfClients.Columns.Add("Середній вік клієнтів", typeof(double));
                countOfClients.Columns.Add("Середня сума кредиту", typeof(double));
                countOfClients.Columns.Add("Середня сума депозиту", typeof(double));
                countOfClients.Columns.Add("Середній термін", typeof(double));
                countOfClients.Columns.Add("Премія", typeof(double));

                countOfClients.Rows.Add(manager.CountOfClients, Bank.AverageAgeOfClients(), Bank.AverageSumOfCredits(),
                    Bank.AverageSumOfDeposits(), Bank.AverageTerms(), manager.Award);

                TableView.DataSource = countOfClients;
            }
            else if ((string)ListBoxInfoChoise.SelectedItem == "Загальна виручка")
            {
                DataTable income = new DataTable();

                income.Columns.Add("Загальна сума взятих кредитів", typeof(double));
                income.Columns.Add("Загальна сума взятих депозитів", typeof(double));
                income.Columns.Add("Прибуток банку", typeof(double));
                income.Columns.Add("Витрати на зарплати співробітникам", typeof(double));

                income.Rows.Add(Math.Round(Bank.AverageSumOfCredits() * Bank.MainManager.CountOfClients, 2), Math.Round(Bank.AverageSumOfDeposits() *
                    Bank.MainManager.CountOfClients, 2), Bank.CountIncome(), Bank.SalaryExpense());

                TableView.DataSource = income;
            }
        }
        #endregion

    }
}
