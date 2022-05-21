
namespace CourseWork
{
    partial class DepositMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DepositMenu));
            this.CloseButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.MainLabel = new System.Windows.Forms.Label();
            this.OutputTerm = new System.Windows.Forms.TextBox();
            this.LabelTerm = new System.Windows.Forms.Label();
            this.OutputFinalSum = new System.Windows.Forms.TextBox();
            this.OutputMontlyPayment = new System.Windows.Forms.TextBox();
            this.OutputInterestRate = new System.Windows.Forms.TextBox();
            this.OutputSumOfDeposit = new System.Windows.Forms.TextBox();
            this.LabelFinalSum = new System.Windows.Forms.Label();
            this.LabelAverageMonthlyIncome = new System.Windows.Forms.Label();
            this.LabelInterestRate = new System.Windows.Forms.Label();
            this.LabelSumOfDeposit = new System.Windows.Forms.Label();
            this.LabelInfoDeposit = new System.Windows.Forms.Label();
            this.TermsLabel = new System.Windows.Forms.LinkLabel();
            this.TermsCheckBox = new System.Windows.Forms.CheckBox();
            this.GetConsultationButton = new System.Windows.Forms.Button();
            this.ConfirmDepositButton = new System.Windows.Forms.Button();
            this.CheckCreditOrDepositButton = new System.Windows.Forms.Button();
            this.InputPhoneNumber = new System.Windows.Forms.TextBox();
            this.InputPassportNumber = new System.Windows.Forms.TextBox();
            this.InputAge = new System.Windows.Forms.TextBox();
            this.InputLastName = new System.Windows.Forms.TextBox();
            this.InputFirstName = new System.Windows.Forms.TextBox();
            this.LabelPhoneNumber = new System.Windows.Forms.Label();
            this.LabelPassportNumber = new System.Windows.Forms.Label();
            this.LabelAge = new System.Windows.Forms.Label();
            this.LabelLastName = new System.Windows.Forms.Label();
            this.LabelFirstName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.Color.Red;
            this.CloseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CloseButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CloseButton.Location = new System.Drawing.Point(1271, 94);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(52, 50);
            this.CloseButton.TabIndex = 19;
            this.CloseButton.Text = "X";
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.Color.DimGray;
            this.BackButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BackButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackButton.Image = ((System.Drawing.Image)(resources.GetObject("BackButton.Image")));
            this.BackButton.Location = new System.Drawing.Point(1186, 94);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(52, 50);
            this.BackButton.TabIndex = 21;
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // MainLabel
            // 
            this.MainLabel.AutoSize = true;
            this.MainLabel.BackColor = System.Drawing.SystemColors.Info;
            this.MainLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainLabel.Location = new System.Drawing.Point(569, 106);
            this.MainLabel.Name = "MainLabel";
            this.MainLabel.Size = new System.Drawing.Size(360, 75);
            this.MainLabel.TabIndex = 22;
            this.MainLabel.Text = "Заповніть усі необхідні для банку дані\r\nдля того, щоб отримати депозит\r\nв нашому " +
    "банку.\r\n";
            this.MainLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OutputTerm
            // 
            this.OutputTerm.BackColor = System.Drawing.Color.Cornsilk;
            this.OutputTerm.Enabled = false;
            this.OutputTerm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OutputTerm.Location = new System.Drawing.Point(1043, 439);
            this.OutputTerm.Name = "OutputTerm";
            this.OutputTerm.Size = new System.Drawing.Size(185, 30);
            this.OutputTerm.TabIndex = 73;
            // 
            // LabelTerm
            // 
            this.LabelTerm.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.LabelTerm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LabelTerm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelTerm.Location = new System.Drawing.Point(811, 421);
            this.LabelTerm.Name = "LabelTerm";
            this.LabelTerm.Size = new System.Drawing.Size(200, 48);
            this.LabelTerm.TabIndex = 72;
            this.LabelTerm.Text = "Термін(місяців)";
            this.LabelTerm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OutputFinalSum
            // 
            this.OutputFinalSum.BackColor = System.Drawing.Color.Cornsilk;
            this.OutputFinalSum.Enabled = false;
            this.OutputFinalSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OutputFinalSum.Location = new System.Drawing.Point(1043, 594);
            this.OutputFinalSum.Name = "OutputFinalSum";
            this.OutputFinalSum.Size = new System.Drawing.Size(185, 30);
            this.OutputFinalSum.TabIndex = 71;
            // 
            // OutputMontlyPayment
            // 
            this.OutputMontlyPayment.BackColor = System.Drawing.Color.Cornsilk;
            this.OutputMontlyPayment.Enabled = false;
            this.OutputMontlyPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OutputMontlyPayment.Location = new System.Drawing.Point(1043, 511);
            this.OutputMontlyPayment.Name = "OutputMontlyPayment";
            this.OutputMontlyPayment.Size = new System.Drawing.Size(185, 30);
            this.OutputMontlyPayment.TabIndex = 70;
            // 
            // OutputInterestRate
            // 
            this.OutputInterestRate.BackColor = System.Drawing.Color.Cornsilk;
            this.OutputInterestRate.Enabled = false;
            this.OutputInterestRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OutputInterestRate.Location = new System.Drawing.Point(1043, 368);
            this.OutputInterestRate.Name = "OutputInterestRate";
            this.OutputInterestRate.Size = new System.Drawing.Size(185, 30);
            this.OutputInterestRate.TabIndex = 69;
            // 
            // OutputSumOfDeposit
            // 
            this.OutputSumOfDeposit.BackColor = System.Drawing.Color.Cornsilk;
            this.OutputSumOfDeposit.Enabled = false;
            this.OutputSumOfDeposit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OutputSumOfDeposit.Location = new System.Drawing.Point(1043, 290);
            this.OutputSumOfDeposit.Name = "OutputSumOfDeposit";
            this.OutputSumOfDeposit.Size = new System.Drawing.Size(185, 30);
            this.OutputSumOfDeposit.TabIndex = 68;
            // 
            // LabelFinalSum
            // 
            this.LabelFinalSum.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.LabelFinalSum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LabelFinalSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelFinalSum.Location = new System.Drawing.Point(811, 582);
            this.LabelFinalSum.Name = "LabelFinalSum";
            this.LabelFinalSum.Size = new System.Drawing.Size(200, 55);
            this.LabelFinalSum.TabIndex = 67;
            this.LabelFinalSum.Text = "Сума виплати:";
            this.LabelFinalSum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelAverageMonthlyIncome
            // 
            this.LabelAverageMonthlyIncome.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.LabelAverageMonthlyIncome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LabelAverageMonthlyIncome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelAverageMonthlyIncome.Location = new System.Drawing.Point(811, 487);
            this.LabelAverageMonthlyIncome.Name = "LabelAverageMonthlyIncome";
            this.LabelAverageMonthlyIncome.Size = new System.Drawing.Size(200, 79);
            this.LabelAverageMonthlyIncome.TabIndex = 66;
            this.LabelAverageMonthlyIncome.Text = "Середній місячний\r\nдохід:";
            this.LabelAverageMonthlyIncome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelInterestRate
            // 
            this.LabelInterestRate.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.LabelInterestRate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LabelInterestRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelInterestRate.Location = new System.Drawing.Point(811, 356);
            this.LabelInterestRate.Name = "LabelInterestRate";
            this.LabelInterestRate.Size = new System.Drawing.Size(200, 55);
            this.LabelInterestRate.TabIndex = 65;
            this.LabelInterestRate.Text = "Відсоток по депозиту:";
            this.LabelInterestRate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelSumOfDeposit
            // 
            this.LabelSumOfDeposit.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.LabelSumOfDeposit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LabelSumOfDeposit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelSumOfDeposit.Location = new System.Drawing.Point(811, 279);
            this.LabelSumOfDeposit.Name = "LabelSumOfDeposit";
            this.LabelSumOfDeposit.Size = new System.Drawing.Size(200, 51);
            this.LabelSumOfDeposit.TabIndex = 64;
            this.LabelSumOfDeposit.Text = "Сума вкладу:";
            this.LabelSumOfDeposit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelInfoDeposit
            // 
            this.LabelInfoDeposit.BackColor = System.Drawing.SystemColors.Info;
            this.LabelInfoDeposit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelInfoDeposit.Location = new System.Drawing.Point(888, 195);
            this.LabelInfoDeposit.Name = "LabelInfoDeposit";
            this.LabelInfoDeposit.Size = new System.Drawing.Size(350, 59);
            this.LabelInfoDeposit.TabIndex = 63;
            this.LabelInfoDeposit.Text = "Інформація про депозит:";
            this.LabelInfoDeposit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TermsLabel
            // 
            this.TermsLabel.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.TermsLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TermsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TermsLabel.Location = new System.Drawing.Point(450, 594);
            this.TermsLabel.Name = "TermsLabel";
            this.TermsLabel.Size = new System.Drawing.Size(333, 28);
            this.TermsLabel.TabIndex = 62;
            this.TermsLabel.TabStop = true;
            this.TermsLabel.Text = "умовами отримання депозиту";
            this.TermsLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.TermsLabel_LinkClicked);
            // 
            // TermsCheckBox
            // 
            this.TermsCheckBox.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.TermsCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TermsCheckBox.Location = new System.Drawing.Point(265, 595);
            this.TermsCheckBox.Name = "TermsCheckBox";
            this.TermsCheckBox.Size = new System.Drawing.Size(518, 30);
            this.TermsCheckBox.TabIndex = 61;
            this.TermsCheckBox.Text = "Я погоджуюсь з\r\n";
            this.TermsCheckBox.UseVisualStyleBackColor = false;
            // 
            // GetConsultationButton
            // 
            this.GetConsultationButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.GetConsultationButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GetConsultationButton.Location = new System.Drawing.Point(941, 674);
            this.GetConsultationButton.Name = "GetConsultationButton";
            this.GetConsultationButton.Size = new System.Drawing.Size(287, 78);
            this.GetConsultationButton.TabIndex = 60;
            this.GetConsultationButton.Text = "Отримати консультацію спеціаліста";
            this.GetConsultationButton.UseVisualStyleBackColor = false;
            this.GetConsultationButton.Click += new System.EventHandler(this.GetConsultationButton_Click);
            // 
            // ConfirmDepositButton
            // 
            this.ConfirmDepositButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ConfirmDepositButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ConfirmDepositButton.Location = new System.Drawing.Point(578, 674);
            this.ConfirmDepositButton.Name = "ConfirmDepositButton";
            this.ConfirmDepositButton.Size = new System.Drawing.Size(287, 78);
            this.ConfirmDepositButton.TabIndex = 59;
            this.ConfirmDepositButton.Text = "Підтвердити отримання депозиту\r\n";
            this.ConfirmDepositButton.UseVisualStyleBackColor = false;
            this.ConfirmDepositButton.Click += new System.EventHandler(this.ConfirmDepositButton_Click);
            // 
            // CheckCreditOrDepositButton
            // 
            this.CheckCreditOrDepositButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CheckCreditOrDepositButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CheckCreditOrDepositButton.Location = new System.Drawing.Point(217, 674);
            this.CheckCreditOrDepositButton.Name = "CheckCreditOrDepositButton";
            this.CheckCreditOrDepositButton.Size = new System.Drawing.Size(287, 78);
            this.CheckCreditOrDepositButton.TabIndex = 58;
            this.CheckCreditOrDepositButton.Text = "Переглянути наявність кредиту чи депозиту\r\n";
            this.CheckCreditOrDepositButton.UseVisualStyleBackColor = false;
            this.CheckCreditOrDepositButton.Click += new System.EventHandler(this.CheckCreditOrDepositButton_Click);
            // 
            // InputPhoneNumber
            // 
            this.InputPhoneNumber.BackColor = System.Drawing.Color.Cornsilk;
            this.InputPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InputPhoneNumber.Location = new System.Drawing.Point(471, 524);
            this.InputPhoneNumber.Name = "InputPhoneNumber";
            this.InputPhoneNumber.Size = new System.Drawing.Size(265, 30);
            this.InputPhoneNumber.TabIndex = 57;
            this.InputPhoneNumber.Text = "+380";
            // 
            // InputPassportNumber
            // 
            this.InputPassportNumber.BackColor = System.Drawing.Color.Cornsilk;
            this.InputPassportNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InputPassportNumber.Location = new System.Drawing.Point(471, 432);
            this.InputPassportNumber.Name = "InputPassportNumber";
            this.InputPassportNumber.Size = new System.Drawing.Size(265, 30);
            this.InputPassportNumber.TabIndex = 56;
            // 
            // InputAge
            // 
            this.InputAge.BackColor = System.Drawing.Color.Cornsilk;
            this.InputAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InputAge.Location = new System.Drawing.Point(471, 356);
            this.InputAge.Name = "InputAge";
            this.InputAge.Size = new System.Drawing.Size(265, 30);
            this.InputAge.TabIndex = 55;
            // 
            // InputLastName
            // 
            this.InputLastName.BackColor = System.Drawing.Color.Cornsilk;
            this.InputLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InputLastName.Location = new System.Drawing.Point(471, 291);
            this.InputLastName.Name = "InputLastName";
            this.InputLastName.Size = new System.Drawing.Size(265, 30);
            this.InputLastName.TabIndex = 54;
            // 
            // InputFirstName
            // 
            this.InputFirstName.BackColor = System.Drawing.Color.Cornsilk;
            this.InputFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InputFirstName.Location = new System.Drawing.Point(471, 224);
            this.InputFirstName.Name = "InputFirstName";
            this.InputFirstName.Size = new System.Drawing.Size(265, 30);
            this.InputFirstName.TabIndex = 53;
            // 
            // LabelPhoneNumber
            // 
            this.LabelPhoneNumber.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.LabelPhoneNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LabelPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelPhoneNumber.Location = new System.Drawing.Point(283, 512);
            this.LabelPhoneNumber.Name = "LabelPhoneNumber";
            this.LabelPhoneNumber.Size = new System.Drawing.Size(151, 54);
            this.LabelPhoneNumber.TabIndex = 52;
            this.LabelPhoneNumber.Text = "Номер телефону";
            this.LabelPhoneNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelPassportNumber
            // 
            this.LabelPassportNumber.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.LabelPassportNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LabelPassportNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelPassportNumber.Location = new System.Drawing.Point(283, 421);
            this.LabelPassportNumber.Name = "LabelPassportNumber";
            this.LabelPassportNumber.Size = new System.Drawing.Size(151, 53);
            this.LabelPassportNumber.TabIndex = 51;
            this.LabelPassportNumber.Text = "Номер паспорту(ID): ";
            this.LabelPassportNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelAge
            // 
            this.LabelAge.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.LabelAge.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LabelAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelAge.Location = new System.Drawing.Point(283, 357);
            this.LabelAge.Name = "LabelAge";
            this.LabelAge.Size = new System.Drawing.Size(151, 29);
            this.LabelAge.TabIndex = 50;
            this.LabelAge.Text = "Вік:";
            this.LabelAge.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelLastName
            // 
            this.LabelLastName.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.LabelLastName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LabelLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelLastName.Location = new System.Drawing.Point(283, 291);
            this.LabelLastName.Name = "LabelLastName";
            this.LabelLastName.Size = new System.Drawing.Size(151, 29);
            this.LabelLastName.TabIndex = 49;
            this.LabelLastName.Text = "Прізвище:";
            this.LabelLastName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelFirstName
            // 
            this.LabelFirstName.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.LabelFirstName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LabelFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelFirstName.Location = new System.Drawing.Point(283, 224);
            this.LabelFirstName.Name = "LabelFirstName";
            this.LabelFirstName.Size = new System.Drawing.Size(151, 29);
            this.LabelFirstName.TabIndex = 48;
            this.LabelFirstName.Text = "Ім\'я:";
            this.LabelFirstName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DepositMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1482, 953);
            this.Controls.Add(this.OutputTerm);
            this.Controls.Add(this.LabelTerm);
            this.Controls.Add(this.OutputFinalSum);
            this.Controls.Add(this.OutputMontlyPayment);
            this.Controls.Add(this.OutputInterestRate);
            this.Controls.Add(this.OutputSumOfDeposit);
            this.Controls.Add(this.LabelFinalSum);
            this.Controls.Add(this.LabelAverageMonthlyIncome);
            this.Controls.Add(this.LabelInterestRate);
            this.Controls.Add(this.LabelSumOfDeposit);
            this.Controls.Add(this.LabelInfoDeposit);
            this.Controls.Add(this.TermsLabel);
            this.Controls.Add(this.TermsCheckBox);
            this.Controls.Add(this.GetConsultationButton);
            this.Controls.Add(this.ConfirmDepositButton);
            this.Controls.Add(this.CheckCreditOrDepositButton);
            this.Controls.Add(this.InputPhoneNumber);
            this.Controls.Add(this.InputPassportNumber);
            this.Controls.Add(this.InputAge);
            this.Controls.Add(this.InputLastName);
            this.Controls.Add(this.InputFirstName);
            this.Controls.Add(this.LabelPhoneNumber);
            this.Controls.Add(this.LabelPassportNumber);
            this.Controls.Add(this.LabelAge);
            this.Controls.Add(this.LabelLastName);
            this.Controls.Add(this.LabelFirstName);
            this.Controls.Add(this.MainLabel);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.CloseButton);
            this.Name = "DepositMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DepositMenu";
            this.Load += new System.EventHandler(this.DepositMenu_Load);
            this.FormClosing += this.DepositMenu_FormClosing;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Label MainLabel;
        private System.Windows.Forms.TextBox OutputTerm;
        private System.Windows.Forms.Label LabelTerm;
        private System.Windows.Forms.TextBox OutputFinalSum;
        private System.Windows.Forms.TextBox OutputMontlyPayment;
        private System.Windows.Forms.TextBox OutputInterestRate;
        private System.Windows.Forms.TextBox OutputSumOfDeposit;
        private System.Windows.Forms.Label LabelFinalSum;
        private System.Windows.Forms.Label LabelAverageMonthlyIncome;
        private System.Windows.Forms.Label LabelInterestRate;
        private System.Windows.Forms.Label LabelSumOfDeposit;
        private System.Windows.Forms.Label LabelInfoDeposit;
        private System.Windows.Forms.LinkLabel TermsLabel;
        private System.Windows.Forms.CheckBox TermsCheckBox;
        private System.Windows.Forms.Button GetConsultationButton;
        private System.Windows.Forms.Button ConfirmDepositButton;
        private System.Windows.Forms.Button CheckCreditOrDepositButton;
        private System.Windows.Forms.TextBox InputPhoneNumber;
        private System.Windows.Forms.TextBox InputPassportNumber;
        private System.Windows.Forms.TextBox InputAge;
        private System.Windows.Forms.TextBox InputLastName;
        private System.Windows.Forms.TextBox InputFirstName;
        private System.Windows.Forms.Label LabelPhoneNumber;
        private System.Windows.Forms.Label LabelPassportNumber;
        private System.Windows.Forms.Label LabelAge;
        private System.Windows.Forms.Label LabelLastName;
        private System.Windows.Forms.Label LabelFirstName;
    }
}