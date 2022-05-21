using System;
using System.IO;
using System.Windows.Forms;

// Банк (кредит, людина, депозит, менеджер)

namespace CourseWork
{
    public partial class Main : Form
    {
        public Main()
        {
            string path = @"../../../credits.txt";
            string path1 = @"../../../deposits.txt";
            string path2 = @"../../../employees.txt";
            if (!File.Exists(path) || !File.Exists(path1) || !File.Exists(path2))
            {
                File.Delete(path);
                File.Delete(path1);
                File.Delete(path2);

                File.AppendAllText(path, "ID | Ім'я | Прізвище | Вік | Номер паспорту | Номер телефону | Сума кредиту | Термін | " +
                            "Процент по кредиту | Сума до виплати\n");
                File.AppendAllText(path1, "ID | Ім'я | Прізвище | Вік | Номер паспорту | Номер телефону | Сума депозиту | Термін | " +
                "Процент по депозиту | Сума виплати\n");
                File.AppendAllText(path2, "Ім'я | Прізвище | Вік | Номер паспорту | Номер телефону | Посада в банку | Досвід роботи | Зарплата\n");
            }
            InitializeComponent();
            Manager.FillLists();
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
        }

        private void Main_Load(object sender, EventArgs e)
        {
            

        }
        private void UserLogin_Click(object sender, EventArgs e)
        {
            UserLogin userLogin = new UserLogin();
            userLogin.Owner = this;
            userLogin.Show();
            Visible = false;
        }

        private void ManagerLogin_Click(object sender, EventArgs e)
        {
            ManagerLogin managerLogin = new ManagerLogin();
            managerLogin.Owner = this;
            managerLogin.Show();
            Visible = false;
        }

        private void CloseButton_Click_1(object sender, EventArgs e)
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
    }
}
