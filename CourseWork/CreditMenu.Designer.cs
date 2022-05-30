
namespace CourseWork
{
    partial class CreditMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreditMenu));
            this.CloseButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.MainLabel = new System.Windows.Forms.Label();
            this.LabelFirstName = new System.Windows.Forms.Label();
            this.LabelLastName = new System.Windows.Forms.Label();
            this.LabelAge = new System.Windows.Forms.Label();
            this.LabelPassportNumber = new System.Windows.Forms.Label();
            this.LabelPhoneNumber = new System.Windows.Forms.Label();
            this.InputFirstName = new System.Windows.Forms.TextBox();
            this.InputLastName = new System.Windows.Forms.TextBox();
            this.InputPassportNumber = new System.Windows.Forms.TextBox();
            this.InputPhoneNumber = new System.Windows.Forms.TextBox();
            this.CheckCreditOrDepositButton = new System.Windows.Forms.Button();
            this.ConfirmCreditButton = new System.Windows.Forms.Button();
            this.GetConsultationButton = new System.Windows.Forms.Button();
            this.TermsCheckBox = new System.Windows.Forms.CheckBox();
            this.TermsLabel = new System.Windows.Forms.LinkLabel();
            this.LabelInfoCredit = new System.Windows.Forms.Label();
            this.LabelSumOfCredit = new System.Windows.Forms.Label();
            this.LabelInterestRate = new System.Windows.Forms.Label();
            this.LabelMonthlyPayment = new System.Windows.Forms.Label();
            this.LabelFinalSum = new System.Windows.Forms.Label();
            this.OutputSumOfCredit = new System.Windows.Forms.TextBox();
            this.OutputInterestRate = new System.Windows.Forms.TextBox();
            this.OutputMontlyPayment = new System.Windows.Forms.TextBox();
            this.OutputFinalSum = new System.Windows.Forms.TextBox();
            this.LabelTerm = new System.Windows.Forms.Label();
            this.OutputTerm = new System.Windows.Forms.TextBox();
            this.InputAge = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.Color.Red;
            this.CloseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CloseButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CloseButton.Location = new System.Drawing.Point(1270, 91);
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
            this.BackButton.Location = new System.Drawing.Point(1189, 91);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(52, 50);
            this.BackButton.TabIndex = 20;
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // MainLabel
            // 
            this.MainLabel.AutoSize = true;
            this.MainLabel.BackColor = System.Drawing.SystemColors.Info;
            this.MainLabel.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainLabel.Location = new System.Drawing.Point(570, 72);
            this.MainLabel.Name = "MainLabel";
            this.MainLabel.Size = new System.Drawing.Size(428, 87);
            this.MainLabel.TabIndex = 21;
            this.MainLabel.Text = "Заповніть усі необхідні для банку дані\r\nдля того, щоб оформити кредит \r\nв нашому " +
    "банку.\r\n";
            this.MainLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelFirstName
            // 
            this.LabelFirstName.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.LabelFirstName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LabelFirstName.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelFirstName.Location = new System.Drawing.Point(294, 195);
            this.LabelFirstName.Name = "LabelFirstName";
            this.LabelFirstName.Size = new System.Drawing.Size(169, 36);
            this.LabelFirstName.TabIndex = 22;
            this.LabelFirstName.Text = "Ім\'я:";
            this.LabelFirstName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelLastName
            // 
            this.LabelLastName.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.LabelLastName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LabelLastName.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelLastName.Location = new System.Drawing.Point(294, 267);
            this.LabelLastName.Name = "LabelLastName";
            this.LabelLastName.Size = new System.Drawing.Size(169, 36);
            this.LabelLastName.TabIndex = 23;
            this.LabelLastName.Text = "Прізвище:";
            this.LabelLastName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelAge
            // 
            this.LabelAge.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.LabelAge.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LabelAge.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelAge.Location = new System.Drawing.Point(294, 338);
            this.LabelAge.Name = "LabelAge";
            this.LabelAge.Size = new System.Drawing.Size(169, 41);
            this.LabelAge.TabIndex = 24;
            this.LabelAge.Text = "Вік:";
            this.LabelAge.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelPassportNumber
            // 
            this.LabelPassportNumber.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.LabelPassportNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LabelPassportNumber.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelPassportNumber.Location = new System.Drawing.Point(294, 416);
            this.LabelPassportNumber.Name = "LabelPassportNumber";
            this.LabelPassportNumber.Size = new System.Drawing.Size(169, 72);
            this.LabelPassportNumber.TabIndex = 25;
            this.LabelPassportNumber.Text = "Номер паспорту(ID): ";
            this.LabelPassportNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelPhoneNumber
            // 
            this.LabelPhoneNumber.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.LabelPhoneNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LabelPhoneNumber.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelPhoneNumber.Location = new System.Drawing.Point(294, 524);
            this.LabelPhoneNumber.Name = "LabelPhoneNumber";
            this.LabelPhoneNumber.Size = new System.Drawing.Size(169, 68);
            this.LabelPhoneNumber.TabIndex = 26;
            this.LabelPhoneNumber.Text = "Номер телефону";
            this.LabelPhoneNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // InputFirstName
            // 
            this.InputFirstName.BackColor = System.Drawing.Color.Cornsilk;
            this.InputFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InputFirstName.Location = new System.Drawing.Point(500, 201);
            this.InputFirstName.Name = "InputFirstName";
            this.InputFirstName.Size = new System.Drawing.Size(265, 30);
            this.InputFirstName.TabIndex = 27;
            // 
            // InputLastName
            // 
            this.InputLastName.BackColor = System.Drawing.Color.Cornsilk;
            this.InputLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InputLastName.Location = new System.Drawing.Point(500, 273);
            this.InputLastName.Name = "InputLastName";
            this.InputLastName.Size = new System.Drawing.Size(265, 30);
            this.InputLastName.TabIndex = 28;
            // 
            // InputPassportNumber
            // 
            this.InputPassportNumber.BackColor = System.Drawing.Color.Cornsilk;
            this.InputPassportNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InputPassportNumber.Location = new System.Drawing.Point(500, 438);
            this.InputPassportNumber.Name = "InputPassportNumber";
            this.InputPassportNumber.Size = new System.Drawing.Size(265, 30);
            this.InputPassportNumber.TabIndex = 30;
            // 
            // InputPhoneNumber
            // 
            this.InputPhoneNumber.BackColor = System.Drawing.Color.Cornsilk;
            this.InputPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InputPhoneNumber.Location = new System.Drawing.Point(500, 544);
            this.InputPhoneNumber.Name = "InputPhoneNumber";
            this.InputPhoneNumber.Size = new System.Drawing.Size(265, 30);
            this.InputPhoneNumber.TabIndex = 31;
            this.InputPhoneNumber.Text = "+380";
            // 
            // CheckCreditOrDepositButton
            // 
            this.CheckCreditOrDepositButton.BackColor = System.Drawing.Color.Chartreuse;
            this.CheckCreditOrDepositButton.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CheckCreditOrDepositButton.Location = new System.Drawing.Point(246, 700);
            this.CheckCreditOrDepositButton.Name = "CheckCreditOrDepositButton";
            this.CheckCreditOrDepositButton.Size = new System.Drawing.Size(287, 99);
            this.CheckCreditOrDepositButton.TabIndex = 32;
            this.CheckCreditOrDepositButton.Text = "Переглянути наявність кредиту чи депозиту\r\n";
            this.CheckCreditOrDepositButton.UseVisualStyleBackColor = false;
            this.CheckCreditOrDepositButton.Click += new System.EventHandler(this.CheckCreditOrDepositButton_Click);
            // 
            // ConfirmCreditButton
            // 
            this.ConfirmCreditButton.BackColor = System.Drawing.Color.Chartreuse;
            this.ConfirmCreditButton.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ConfirmCreditButton.Location = new System.Drawing.Point(607, 700);
            this.ConfirmCreditButton.Name = "ConfirmCreditButton";
            this.ConfirmCreditButton.Size = new System.Drawing.Size(287, 99);
            this.ConfirmCreditButton.TabIndex = 33;
            this.ConfirmCreditButton.Text = "Підтвердити оформлення кредиту\r\n";
            this.ConfirmCreditButton.UseVisualStyleBackColor = false;
            this.ConfirmCreditButton.Click += new System.EventHandler(this.ConfirmCreditButton_Click);
            // 
            // GetConsultationButton
            // 
            this.GetConsultationButton.BackColor = System.Drawing.Color.Chartreuse;
            this.GetConsultationButton.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GetConsultationButton.Location = new System.Drawing.Point(970, 700);
            this.GetConsultationButton.Name = "GetConsultationButton";
            this.GetConsultationButton.Size = new System.Drawing.Size(287, 99);
            this.GetConsultationButton.TabIndex = 34;
            this.GetConsultationButton.Text = "Отримати консультацію спеціаліста";
            this.GetConsultationButton.UseVisualStyleBackColor = false;
            this.GetConsultationButton.Click += new System.EventHandler(this.GetConsultationButton_Click);
            // 
            // TermsCheckBox
            // 
            this.TermsCheckBox.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.TermsCheckBox.Font = new System.Drawing.Font("Sitka Small", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TermsCheckBox.Location = new System.Drawing.Point(246, 621);
            this.TermsCheckBox.Name = "TermsCheckBox";
            this.TermsCheckBox.Size = new System.Drawing.Size(537, 46);
            this.TermsCheckBox.TabIndex = 35;
            this.TermsCheckBox.Text = "Я погоджуюсь з\r\n";
            this.TermsCheckBox.UseVisualStyleBackColor = false;
            // 
            // TermsLabel
            // 
            this.TermsLabel.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.TermsLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TermsLabel.Font = new System.Drawing.Font("Sitka Small", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TermsLabel.Location = new System.Drawing.Point(452, 629);
            this.TermsLabel.Name = "TermsLabel";
            this.TermsLabel.Size = new System.Drawing.Size(304, 28);
            this.TermsLabel.TabIndex = 36;
            this.TermsLabel.TabStop = true;
            this.TermsLabel.Text = "умовами надання кредиту";
            this.TermsLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.TermsLabel_LinkClicked);
            // 
            // LabelInfoCredit
            // 
            this.LabelInfoCredit.BackColor = System.Drawing.Color.Moccasin;
            this.LabelInfoCredit.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelInfoCredit.Location = new System.Drawing.Point(841, 184);
            this.LabelInfoCredit.Name = "LabelInfoCredit";
            this.LabelInfoCredit.Size = new System.Drawing.Size(350, 59);
            this.LabelInfoCredit.TabIndex = 37;
            this.LabelInfoCredit.Text = "Інформація про кредит:";
            this.LabelInfoCredit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelSumOfCredit
            // 
            this.LabelSumOfCredit.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.LabelSumOfCredit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LabelSumOfCredit.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelSumOfCredit.Location = new System.Drawing.Point(805, 273);
            this.LabelSumOfCredit.Name = "LabelSumOfCredit";
            this.LabelSumOfCredit.Size = new System.Drawing.Size(193, 58);
            this.LabelSumOfCredit.TabIndex = 38;
            this.LabelSumOfCredit.Text = "Сума кредиту:";
            this.LabelSumOfCredit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelInterestRate
            // 
            this.LabelInterestRate.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.LabelInterestRate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LabelInterestRate.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelInterestRate.Location = new System.Drawing.Point(805, 344);
            this.LabelInterestRate.Name = "LabelInterestRate";
            this.LabelInterestRate.Size = new System.Drawing.Size(193, 65);
            this.LabelInterestRate.TabIndex = 39;
            this.LabelInterestRate.Text = "Відсоток по кредиту:";
            this.LabelInterestRate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelMonthlyPayment
            // 
            this.LabelMonthlyPayment.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.LabelMonthlyPayment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LabelMonthlyPayment.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelMonthlyPayment.Location = new System.Drawing.Point(805, 504);
            this.LabelMonthlyPayment.Name = "LabelMonthlyPayment";
            this.LabelMonthlyPayment.Size = new System.Drawing.Size(193, 63);
            this.LabelMonthlyPayment.TabIndex = 40;
            this.LabelMonthlyPayment.Text = "Щомісячний платіж";
            this.LabelMonthlyPayment.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelFinalSum
            // 
            this.LabelFinalSum.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.LabelFinalSum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LabelFinalSum.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelFinalSum.Location = new System.Drawing.Point(805, 582);
            this.LabelFinalSum.Name = "LabelFinalSum";
            this.LabelFinalSum.Size = new System.Drawing.Size(193, 69);
            this.LabelFinalSum.TabIndex = 41;
            this.LabelFinalSum.Text = "Сума до виплати:";
            this.LabelFinalSum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OutputSumOfCredit
            // 
            this.OutputSumOfCredit.BackColor = System.Drawing.Color.Cornsilk;
            this.OutputSumOfCredit.Enabled = false;
            this.OutputSumOfCredit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OutputSumOfCredit.Location = new System.Drawing.Point(1021, 288);
            this.OutputSumOfCredit.Name = "OutputSumOfCredit";
            this.OutputSumOfCredit.Size = new System.Drawing.Size(185, 30);
            this.OutputSumOfCredit.TabIndex = 42;
            // 
            // OutputInterestRate
            // 
            this.OutputInterestRate.BackColor = System.Drawing.Color.Cornsilk;
            this.OutputInterestRate.Enabled = false;
            this.OutputInterestRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OutputInterestRate.Location = new System.Drawing.Point(1021, 362);
            this.OutputInterestRate.Name = "OutputInterestRate";
            this.OutputInterestRate.Size = new System.Drawing.Size(185, 30);
            this.OutputInterestRate.TabIndex = 43;
            // 
            // OutputMontlyPayment
            // 
            this.OutputMontlyPayment.BackColor = System.Drawing.Color.Cornsilk;
            this.OutputMontlyPayment.Enabled = false;
            this.OutputMontlyPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OutputMontlyPayment.Location = new System.Drawing.Point(1021, 521);
            this.OutputMontlyPayment.Name = "OutputMontlyPayment";
            this.OutputMontlyPayment.Size = new System.Drawing.Size(185, 30);
            this.OutputMontlyPayment.TabIndex = 44;
            // 
            // OutputFinalSum
            // 
            this.OutputFinalSum.BackColor = System.Drawing.Color.Cornsilk;
            this.OutputFinalSum.Enabled = false;
            this.OutputFinalSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OutputFinalSum.Location = new System.Drawing.Point(1021, 598);
            this.OutputFinalSum.Name = "OutputFinalSum";
            this.OutputFinalSum.Size = new System.Drawing.Size(185, 30);
            this.OutputFinalSum.TabIndex = 45;
            // 
            // LabelTerm
            // 
            this.LabelTerm.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.LabelTerm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LabelTerm.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelTerm.Location = new System.Drawing.Point(805, 438);
            this.LabelTerm.Name = "LabelTerm";
            this.LabelTerm.Size = new System.Drawing.Size(193, 44);
            this.LabelTerm.TabIndex = 46;
            this.LabelTerm.Text = "Термін(місяців)";
            this.LabelTerm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OutputTerm
            // 
            this.OutputTerm.BackColor = System.Drawing.Color.Cornsilk;
            this.OutputTerm.Enabled = false;
            this.OutputTerm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OutputTerm.Location = new System.Drawing.Point(1021, 452);
            this.OutputTerm.Name = "OutputTerm";
            this.OutputTerm.Size = new System.Drawing.Size(185, 30);
            this.OutputTerm.TabIndex = 47;
            // 
            // InputAge
            // 
            this.InputAge.BackColor = System.Drawing.Color.Cornsilk;
            this.InputAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InputAge.Location = new System.Drawing.Point(500, 344);
            this.InputAge.Name = "InputAge";
            this.InputAge.Size = new System.Drawing.Size(265, 30);
            this.InputAge.TabIndex = 48;
            // 
            // CreditMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1482, 953);
            this.Controls.Add(this.InputAge);
            this.Controls.Add(this.OutputTerm);
            this.Controls.Add(this.LabelTerm);
            this.Controls.Add(this.OutputFinalSum);
            this.Controls.Add(this.OutputMontlyPayment);
            this.Controls.Add(this.OutputInterestRate);
            this.Controls.Add(this.OutputSumOfCredit);
            this.Controls.Add(this.LabelFinalSum);
            this.Controls.Add(this.LabelMonthlyPayment);
            this.Controls.Add(this.LabelInterestRate);
            this.Controls.Add(this.LabelSumOfCredit);
            this.Controls.Add(this.LabelInfoCredit);
            this.Controls.Add(this.TermsLabel);
            this.Controls.Add(this.TermsCheckBox);
            this.Controls.Add(this.GetConsultationButton);
            this.Controls.Add(this.ConfirmCreditButton);
            this.Controls.Add(this.CheckCreditOrDepositButton);
            this.Controls.Add(this.InputPhoneNumber);
            this.Controls.Add(this.InputPassportNumber);
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
            this.Name = "CreditMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CreditMenu";
            this.Load += new System.EventHandler(this.CreditMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Label MainLabel;
        private System.Windows.Forms.Label LabelFirstName;
        private System.Windows.Forms.Label LabelLastName;
        private System.Windows.Forms.Label LabelAge;
        private System.Windows.Forms.Label LabelPassportNumber;
        private System.Windows.Forms.Label LabelPhoneNumber;
        private System.Windows.Forms.TextBox InputFirstName;
        private System.Windows.Forms.TextBox InputLastName;
        private System.Windows.Forms.TextBox InputPassportNumber;
        private System.Windows.Forms.TextBox InputPhoneNumber;
        private System.Windows.Forms.Button CheckCreditOrDepositButton;
        private System.Windows.Forms.Button ConfirmCreditButton;
        private System.Windows.Forms.Button GetConsultationButton;
        private System.Windows.Forms.CheckBox TermsCheckBox;
        private System.Windows.Forms.LinkLabel TermsLabel;
        private System.Windows.Forms.Label LabelInfoCredit;
        private System.Windows.Forms.Label LabelSumOfCredit;
        private System.Windows.Forms.Label LabelInterestRate;
        private System.Windows.Forms.Label LabelMonthlyPayment;
        private System.Windows.Forms.Label LabelFinalSum;
        private System.Windows.Forms.Label LabelTerm;
        public System.Windows.Forms.TextBox OutputSumOfCredit;
        public System.Windows.Forms.TextBox OutputInterestRate;
        public System.Windows.Forms.TextBox OutputMontlyPayment;
        public System.Windows.Forms.TextBox OutputFinalSum;
        public System.Windows.Forms.TextBox OutputTerm;
        private System.Windows.Forms.TextBox InputAge;
    }
}