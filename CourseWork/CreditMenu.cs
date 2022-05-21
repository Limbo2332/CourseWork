using System;
using System.Windows.Forms;
using System.Diagnostics;
using System.Text.RegularExpressions;
using System.IO;

namespace CourseWork
{
    public partial class CreditMenu : Form
    {
        public CreditMenu()
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
            InitializeComponent();
        }

        private void CreditMenu_Load(object sender, EventArgs e)
        {
            OutPut(LoadInformation());

        }
        private void CloseButton_Click(object sender, EventArgs e)
        {
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            var result = MessageBox.Show("Ви точно хочете завершити роботу програми?", "Завершення програми", buttons);
            if (result == DialogResult.Yes)
            {
                string path = @"../../../tempcredit.txt";
                string path1 = @"../../../tempdeposit.txt";
                if (File.Exists(path))
                    File.Delete(path);
                if (File.Exists(path1))
                    File.Delete(path1);
                Application.Exit();
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            var result = MessageBox.Show("Ви дійсно хочете повернутися назад?", "Повернутися назад", buttons);
            if (result == DialogResult.Yes)
            {
                string path = @"../../../tempcredit.txt";
                string path1 = @"../../../tempdeposit.txt";
                if (File.Exists(path))
                    File.Delete(path);
                if (File.Exists(path1))
                    File.Delete(path1);
                Owner.Visible = true;
                Close();
            }
        }

        private void TermsLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://privatbank.ua/terms");
        }

        private bool CheckCorrectOrNot()
        {
            try
            {
                string firstName = InputFirstName.Text;
                string lastName = InputLastName.Text;
                int age = Convert.ToInt32(InputAge.Text);
                string passportNumber = InputPassportNumber.Text;
                string phoneNumber = InputPhoneNumber.Text;

                // регулярні вирази

                Regex Name = new Regex(@"[а-я]");
                Regex ForPassportNumber = new Regex(@"^\d{9}$");
                Regex ForPhoneNumber = new Regex(@"\+380\d{9}$");

                if (firstName.Length < 2 || !Name.IsMatch(firstName))
                    throw new Exception("Ви ввели недопустиме значення для імені.");
                else if (lastName.Length < 2 || !Name.IsMatch(lastName))
                    throw new Exception("Ви ввели недопустиме значення для прізвища.");
                else if (age < 18 || age > 65)
                    throw new Exception("Ви повинні бути повнолітнім або не бути пенсіонером.");
                else if (passportNumber.Length != 9 && !ForPassportNumber.IsMatch(passportNumber))
                    throw new Exception("Номер паспорту повинен містити 9 цифр. Перевірте правильність вводу.");
                else if (!ForPhoneNumber.IsMatch(phoneNumber))
                    throw new Exception("Перевірте правильність вводу мобільного телефону.");
                else if (TermsCheckBox.Checked == false)
                    throw new Exception("Ви повинні бути згодними з умовами надання кредиту!");

                return true;
            }
            catch (FormatException)
            {
                MessageBox.Show("Ви ввели недопустимі значення для деяких полей!");
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        private bool HasDepositOrNot()
        {
            foreach (var deposit in Bank.ListOfDeposits)
            {
                if (deposit.Owner.PassportNumber == InputPassportNumber.Text || deposit.Owner.PhoneNumber == InputPhoneNumber.Text)
                    return true;
            }
            return false;
        }
        private bool HasCreditOrNot()
        {
            foreach (var credit in Bank.ListOfCredits)
            {
                if (credit.Owner.PassportNumber == InputPassportNumber.Text || credit.Owner.PhoneNumber == InputPhoneNumber.Text)
                    return true;
            }
            return false;
        }
        private Credit LoadInformation()
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
            string path = @"../../../tempcredit.txt";
            string[] creditFields = File.ReadAllText(path).Split(' ');
            Credit credit = new Credit();
            credit.ID = Guid.NewGuid();
            credit.SumOfCredit = Convert.ToDouble(creditFields[0]);
            credit.Term = Convert.ToInt32(creditFields[1]);
            credit.InterestRate = Convert.ToDouble(creditFields[2]);
            credit.FinalSum = Bank.CountFinalSumOfCredit(credit);
            OutPut(credit);

            return credit;
        }
        private void OutPut(Credit credit)
        {
            OutputSumOfCredit.Text = credit.SumOfCredit.ToString();
            OutputInterestRate.Text = credit.InterestRate.ToString();
            OutputFinalSum.Text = credit.FinalSum.ToString();
            OutputMontlyPayment.Text = credit.MonthlyPayment().ToString();
            OutputTerm.Text = credit.Term.ToString();
        }
        private void ConfirmCreditButton_Click(object sender, EventArgs e)
        {

            if (CheckCorrectOrNot())
            {
                if (HasDepositOrNot())
                {
                    MessageBox.Show("Ви вже маєте депозит!");
                    return;
                }
                else if (HasCreditOrNot())
                {
                    MessageBox.Show("Ви вже маєте кредит!");
                    return;
                }
                Credit credit = LoadInformation();
                Person person = new Person(InputFirstName.Text, InputLastName.Text, Convert.ToInt32(InputAge.Text),
                    InputPassportNumber.Text, InputPhoneNumber.Text);
                credit.Owner = person;
                string path2 = @"../../../credits.txt";
                string contents = credit.ToString();
                Bank.ListOfCredits.Add(credit);
                File.AppendAllText(path2, contents);

                MessageBox.Show("Ви успішно взяли кредит в нашому банку!");

                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                var result = MessageBox.Show("Продовжити роботу?", "Залишитися", buttons);
                if (result == DialogResult.Yes)
                    ConfirmCreditButton.Enabled = false;
                else
                {
                    string path = @"../../../tempcredit.txt";
                    string path0 = @"../../../tempdeposit.txt";
                    if (File.Exists(path))
                        File.Delete(path);
                    if (File.Exists(path0))
                        File.Delete(path0);
                    Application.Exit();
                }
            }
        }
        private void GetConsultationButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Гаряча лінія: 0800 500 003" + "\n" + new string(' ', 24) + "3700" + "\n" + "Також ви можете скачати " +
                "наш додаток в Google Play або AppStore, де ви теж зможете проконсольтуватися.");
        }

        private void CheckCreditOrDepositButton_Click(object sender, EventArgs e)
        {
            if (CheckCorrectOrNot())
            {
                if (HasDepositOrNot())
                {
                    MessageBox.Show("Ви вже маєте депозит! Ви не можете взяти кредит!");
                    return;
                }
                else
                {

                    if (HasCreditOrNot())
                    {
                        MessageBox.Show("Ви вже маєте кредит! Інформація на екрані!");

                        foreach (var credit in Bank.ListOfCredits)
                        {
                            if(credit.Owner.PassportNumber == InputPassportNumber.Text || credit.Owner.PhoneNumber == InputPhoneNumber.Text)
                            {
                                OutPut(credit);
                                break;
                            }

                        }
                        ConfirmCreditButton.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("У Вас немає кредиту чи депозиту в нашому банку.");
                        ConfirmCreditButton.Enabled = true;
                        OutPut(LoadInformation());
                    }
                }
            }

        }
    }
}
