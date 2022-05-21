using System;
using System.Diagnostics;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace CourseWork
{
    public partial class DepositMenu : Form
    {
        public DepositMenu()
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
            InitializeComponent();
        }

        private void DepositMenu_Load(object sender, EventArgs e)
        {
            Output(LoadInformation());
        }
        private void DepositMenu_FormClosing(object sender, EventArgs e)
        {
            Application.Exit();
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
                else if (passportNumber.ToString().Length != 9 && !ForPassportNumber.IsMatch(passportNumber))
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
        #endregion

        #region InfoAboutDeposits
        private Deposit LoadInformation()
        {
            string path = @"../../../tempdeposit.txt";
            string[] depositFields = File.ReadAllText(path).Split(' ');
            Deposit deposit = new Deposit();

            deposit.SumOfDeposit = Convert.ToDouble(depositFields[0]);
            deposit.Term = Convert.ToInt32(depositFields[1]);
            deposit.InterestRate = Convert.ToDouble(depositFields[2]);
            deposit.FinalSum = Bank.CountFinalSumOfDeposit(deposit);

            Output(deposit);

            return deposit;
        }
        private void Output(Deposit deposit)
        {
            OutputSumOfDeposit.Text = deposit.SumOfDeposit.ToString();
            OutputInterestRate.Text = deposit.InterestRate.ToString();
            OutputFinalSum.Text = deposit.FinalSum.ToString();
            OutputMontlyPayment.Text = deposit.AverageMontlyIncome().ToString();
            OutputTerm.Text = deposit.Term.ToString();
        }
        #endregion

        #region Buttons
        private void ConfirmDepositButton_Click(object sender, EventArgs e)
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
                string path2 = @"../../../deposits.txt";

                Deposit deposit = LoadInformation();
                deposit.Owner = new Person(InputFirstName.Text, InputLastName.Text, Convert.ToInt32(InputAge.Text),
                    InputPassportNumber.Text, InputPhoneNumber.Text);
                deposit.ID = Guid.NewGuid();

                string contents = deposit.ToString();
                Bank.ListOfDeposits.Add(deposit);
                File.AppendAllText(path2, contents);
                MessageBox.Show("Ви успішно отримали депозит в нашому банку!");

                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                var result = MessageBox.Show("Продовжити роботу?", "Залишитися", buttons);
                if (result == DialogResult.Yes)
                    ConfirmDepositButton.Enabled = false;
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
                if (HasCreditOrNot())
                {
                    MessageBox.Show("Ви вже маєте кредит! Ви не можете взяти депозит!");
                    return;
                }
                else
                {
                    if (HasDepositOrNot())
                    {
                        MessageBox.Show("Ви вже маєте депозит! Інформація на екрані!");

                        foreach (var deposit in Bank.ListOfDeposits)
                        {
                            if (deposit.Owner.PassportNumber == InputPassportNumber.Text || deposit.Owner.PhoneNumber ==
                                InputPhoneNumber.Text)
                            {
                                Output(deposit);
                                break;
                            }
                        }
                        ConfirmDepositButton.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("У Вас немає кредиту чи депозиту в нашому банку.");
                        ConfirmDepositButton.Enabled = true;
                        Output(LoadInformation());
                    }
                }
            }


        }
        #endregion


    }
}
