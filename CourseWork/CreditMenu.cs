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

        }
        private void CreditMenu_FormClosing(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void CloseButton_Click(object sender, EventArgs e)
        {
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            var result = MessageBox.Show("Ви точно хочете завершити роботу програми?", "Завершення програми", buttons);
            if (result == DialogResult.Yes)
                Application.Exit();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            var result = MessageBox.Show("Ви дійсно хочете повернутися назад?", "Повернутися назад", buttons);
            if (result == DialogResult.Yes)
            {
                Owner.Visible = true;
                Visible = false;
            }
        }

        #region Terms
        private void TermsLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://privatbank.ua/terms");
        }
        #endregion

        #region Checking that the input is correct and availability of deposit/credit
        private bool CheckCorrectness()
        {
            try
            {
                string firstName = InputFirstName.Text;
                string lastName = InputLastName.Text;
                int age = Convert.ToInt32(InputAge.Text);
                string passportNumber = InputPassportNumber.Text;
                string phoneNumber = InputPhoneNumber.Text;

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
                else if (TermsCheckBox.Checked == false)
                    throw new Exception("Ви повинні бути згодними з умовами надання кредиту!");

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
        private bool HasDeposit()
        {
            foreach (var deposit in Bank.ListOfDeposits)
                if (deposit.Owner.PassportNumber == InputPassportNumber.Text || deposit.Owner.PhoneNumber == InputPhoneNumber.Text)
                    return true;
            return false;
        }
        private bool HasCredit()
        {
            foreach (var credit in Bank.ListOfCredits)
                if (credit.Owner.PassportNumber == InputPassportNumber.Text || credit.Owner.PhoneNumber == InputPhoneNumber.Text)
                    return true;
            return false;
        }
        private bool IsEmployee()
        {
            foreach (var employee in Bank.ListOfEmployees)
                if (employee.PassportNumber == InputPassportNumber.Text || employee.PhoneNumber == InputPhoneNumber.Text)
                    return true;
            return false;
        }
        #endregion

        #region InfoAboutCredits
        private void OutPut(Credit credit)
        {
            OutputSumOfCredit.Text = credit.SumOfCredit.ToString();
            OutputInterestRate.Text = credit.InterestRate.ToString();
            OutputFinalSum.Text = credit.FinalSum.ToString();
            OutputMontlyPayment.Text = credit.MonthlyPayment().ToString();
            OutputTerm.Text = credit.Term.ToString();
        }
        #endregion

        #region Buttons
        private void ConfirmCreditButton_Click(object sender, EventArgs e)
        {

            if (CheckCorrectness())
            {
                if (HasDeposit())
                {
                    MessageBox.Show("Ви вже маєте депозит!");
                    return;
                }
                else if (HasCredit())
                {
                    MessageBox.Show("Ви вже маєте кредит!");
                    return;
                }else if (IsEmployee())
                {
                    MessageBox.Show("Ви вже працюєте в нашому банку!");
                    return;
                }
                Client client = new Client(InputFirstName.Text, InputLastName.Text, Convert.ToInt32(InputAge.Text),
                    InputPassportNumber.Text, InputPhoneNumber.Text);
                Credit credit = new Credit(client, Convert.ToDouble(OutputSumOfCredit.Text), Convert.ToInt32(OutputTerm.Text),
                    Convert.ToDouble(OutputInterestRate.Text), Convert.ToDouble(OutputFinalSum.Text));

                credit.ID = Guid.NewGuid();

                string path2 = @"../../../credits.txt";
                string contents = credit.ToString();

                Bank.ListOfCredits.Add(credit);
                File.AppendAllText(path2, contents);

                MessageBox.Show("Ви успішно взяли кредит в нашому банку!");
                ContinueWork();
            }
        }

        private void ContinueWork()
        {
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            var result = MessageBox.Show("Продовжити роботу?", "Залишитися", buttons);
            if (result == DialogResult.Yes)
                ConfirmCreditButton.Enabled = false;
            else
                Application.Exit();
        }

        private void GetConsultationButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Гаряча лінія: 0800 500 003" + "\n" + new string(' ', 24) + "3700" + "\n" + "Також ви можете скачати " +
                "наш додаток в Google Play або AppStore, де ви теж зможете проконсольтуватися.");
        }

        private void CheckCreditOrDepositButton_Click(object sender, EventArgs e)
        {
            if (CheckCorrectness())
            {
                if (HasDeposit())
                {
                    MessageBox.Show("Ви вже маєте депозит! Ви не можете взяти кредит!");
                    return;
                }
                else
                {

                    if (HasCredit())
                    {
                        MessageBox.Show("Ви вже маєте кредит! Інформація на екрані!");

                        foreach (var credit in Bank.ListOfCredits)
                        {
                            if (credit.Owner.PassportNumber == InputPassportNumber.Text || credit.Owner.PhoneNumber == InputPhoneNumber.Text)
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
                    }
                }
            }

        }
        #endregion

    }
}
