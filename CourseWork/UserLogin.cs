using System;
using System.IO;
using System.Windows.Forms;
namespace CourseWork
{
    public partial class UserLogin : Form
    {
        Credit credit = new Credit();
        Deposit deposit = new Deposit();
        public UserLogin()
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
            InitializeComponent();
        }
        private void UserLogin_Load(object sender, EventArgs e)
        {
            
        }
        private void UserLogin_FormClosing(object sender, EventArgs e)
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

        #region CreditCode

        private void TakeCreditButton_Click(object sender, EventArgs e)
        {
            LabelInputDeposit.Visible = false;
            InputSumOfDeposit.Visible = false;
            LabelInputDepositTerm.Visible = false;
            InputTermOfDeposit.Visible = false;
            DepositCountPercentButton.Visible = false;
            DepositOutputPercent.Visible = false;
            ConfirmDepositButton.Visible = false;

            LabelInputCreditSum.Visible = true;
            InputSumOfCredit.Visible = true;
            LabelInputCreditTerm.Visible = true;
            InputTermOfCredit.Visible = true;
            CreditCountPercentButton.Visible = true;
            CreditOutputPercent.Visible = true;
            ConfirmCreditButton.Visible = true;
        }

        private void CreditCountPercentButton_Click(object sender, EventArgs e)
        {
            try
            {
                double sumOfCredit = Convert.ToDouble(InputSumOfCredit.Text);
                int term = Convert.ToInt32(InputTermOfCredit.Text);

                if (sumOfCredit < 10000 || sumOfCredit > 1000000 || term <= 0
                    || term > 120)
                    throw new Exception();
                double interestRate = Bank.CountCreditProcent(credit);

                CreditOutputPercent.Text = interestRate.ToString();
                credit.SumOfCredit = sumOfCredit;
                credit.Term = term;
                credit.InterestRate = interestRate;
            }
            catch (Exception)
            {
                CreditOutputPercent.Text = "0";
                MessageBox.Show("Ви ввели недопустимі значення! Сума кредиту не може бути більшою, " +
                    "ніж 1 мільйон гривень, або меншою, ніж 10000 грн" +
                    ", а термін кредиту - 10 років.");
            }
        }

        private void ConfirmCreditButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (CreditOutputPercent.Text == "0" || credit.SumOfCredit.ToString() != InputSumOfCredit.Text || credit.Term.ToString() !=
                    InputTermOfCredit.Text)
                    throw new Exception();
                string path = @"../../../tempcredit.txt";
                string contents = credit.SumOfCredit + " " + credit.Term + " " + credit.InterestRate;
                File.AppendAllText(path, contents);

                CreditMenu creditMenu = new CreditMenu();
                creditMenu.Owner = this;
                creditMenu.Show();
                Visible = false;
            }
            catch (Exception)
            {
                MessageBox.Show("Ви не розрахували процент! Натисність на кнопку " +
                    "\"Розрахувати процент кредиту\"");
            }
        }


        #endregion

        #region DepositCode

        private void TakeDepositButton_Click(object sender, EventArgs e)
        {
            LabelInputCreditSum.Visible = false;
            InputSumOfCredit.Visible = false;
            LabelInputCreditTerm.Visible = false;
            InputTermOfCredit.Visible = false;
            CreditCountPercentButton.Visible = false;
            CreditOutputPercent.Visible = false;
            ConfirmCreditButton.Visible = false;

            LabelInputDeposit.Visible = true;
            InputSumOfDeposit.Visible = true;
            LabelInputDepositTerm.Visible = true;
            InputTermOfDeposit.Visible = true;
            DepositCountPercentButton.Visible = true;
            DepositOutputPercent.Visible = true;
            ConfirmDepositButton.Visible = true;
        }

        private void DepositCountPercentButton_Click(object sender, EventArgs e)
        {
            try
            {
                double sumOfDeposit = Convert.ToDouble(InputSumOfDeposit.Text);
                int term = Convert.ToInt32(InputTermOfDeposit.Text);

                deposit.SumOfDeposit = sumOfDeposit;
                deposit.Term = term;

                if (deposit.SumOfDeposit < 1000 || deposit.SumOfDeposit > 1000000 || deposit.Term <= 0
                    || deposit.Term > 60)
                    throw new Exception();
                double interestRate = Bank.CountDepositProcent(deposit);
                DepositOutputPercent.Text = interestRate.ToString();

                deposit.InterestRate = interestRate;
            }
            catch (Exception)
            {
                DepositOutputPercent.Text = "0";
                MessageBox.Show("Ви ввели недопустимі значення! Сума депозиту не може бути більшою, " +
                    "ніж 1 мільйон гривень, або меншою, ніж 1000 грн" +
                    ", а термін депозиту - 5 років.");
            }
        }

        private void ConfirmDepositButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (DepositOutputPercent.Text == "0" || deposit.SumOfDeposit.ToString() != InputSumOfDeposit.Text || 
                    deposit.Term.ToString() != InputTermOfDeposit.Text)
                    throw new Exception();
                string path = @"../../../tempdeposit.txt";
                string contents = deposit.SumOfDeposit + " " + deposit.Term + " " + deposit.InterestRate;
                File.AppendAllText(path, contents);
                DepositMenu depositMenu = new DepositMenu();
                depositMenu.Owner = this;
                depositMenu.Show();
                Visible = false;
            }
            catch (Exception)
            {
                MessageBox.Show("Ви не розрахували процент! Натисність на кнопку " +
                    "\"Розрахувати процент депозиту\"");
            }
        }
        #endregion

    }
}