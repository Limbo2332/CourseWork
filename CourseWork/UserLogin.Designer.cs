
namespace CourseWork
{
    partial class UserLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserLogin));
            this.label1 = new System.Windows.Forms.Label();
            this.TakeCreditButton = new System.Windows.Forms.Button();
            this.TakeDepositButton = new System.Windows.Forms.Button();
            this.InputSumOfCredit = new System.Windows.Forms.TextBox();
            this.LabelInputCreditSum = new System.Windows.Forms.Label();
            this.LabelInputCreditTerm = new System.Windows.Forms.Label();
            this.InputTermOfCredit = new System.Windows.Forms.TextBox();
            this.CreditOutputPercent = new System.Windows.Forms.TextBox();
            this.CreditCountPercentButton = new System.Windows.Forms.Button();
            this.ConfirmCreditButton = new System.Windows.Forms.Button();
            this.LabelInputDeposit = new System.Windows.Forms.Label();
            this.InputSumOfDeposit = new System.Windows.Forms.TextBox();
            this.LabelInputDepositTerm = new System.Windows.Forms.Label();
            this.InputTermOfDeposit = new System.Windows.Forms.TextBox();
            this.DepositCountPercentButton = new System.Windows.Forms.Button();
            this.DepositOutputPercent = new System.Windows.Forms.TextBox();
            this.ConfirmDepositButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Info;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(592, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(294, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "Виберіть одну із \r\nзапропонованих нижче послуг";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TakeCreditButton
            // 
            this.TakeCreditButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TakeCreditButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TakeCreditButton.Location = new System.Drawing.Point(254, 197);
            this.TakeCreditButton.Name = "TakeCreditButton";
            this.TakeCreditButton.Size = new System.Drawing.Size(287, 78);
            this.TakeCreditButton.TabIndex = 1;
            this.TakeCreditButton.Text = "Взяти кредит";
            this.TakeCreditButton.UseVisualStyleBackColor = false;
            this.TakeCreditButton.Click += new System.EventHandler(this.TakeCreditButton_Click);
            // 
            // TakeDepositButton
            // 
            this.TakeDepositButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TakeDepositButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TakeDepositButton.Location = new System.Drawing.Point(895, 197);
            this.TakeDepositButton.Name = "TakeDepositButton";
            this.TakeDepositButton.Size = new System.Drawing.Size(287, 78);
            this.TakeDepositButton.TabIndex = 2;
            this.TakeDepositButton.Text = "Відкрити депозит";
            this.TakeDepositButton.UseVisualStyleBackColor = false;
            this.TakeDepositButton.Click += new System.EventHandler(this.TakeDepositButton_Click);
            // 
            // InputSumOfCredit
            // 
            this.InputSumOfCredit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InputSumOfCredit.Location = new System.Drawing.Point(419, 322);
            this.InputSumOfCredit.Name = "InputSumOfCredit";
            this.InputSumOfCredit.Size = new System.Drawing.Size(188, 30);
            this.InputSumOfCredit.TabIndex = 3;
            this.InputSumOfCredit.Text = "10000";
            this.InputSumOfCredit.Visible = false;
            // 
            // LabelInputCreditSum
            // 
            this.LabelInputCreditSum.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.LabelInputCreditSum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LabelInputCreditSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelInputCreditSum.Location = new System.Drawing.Point(168, 305);
            this.LabelInputCreditSum.Name = "LabelInputCreditSum";
            this.LabelInputCreditSum.Size = new System.Drawing.Size(229, 65);
            this.LabelInputCreditSum.TabIndex = 4;
            this.LabelInputCreditSum.Text = "Введіть бажану \r\nсуму:";
            this.LabelInputCreditSum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LabelInputCreditSum.Visible = false;
            // 
            // LabelInputCreditTerm
            // 
            this.LabelInputCreditTerm.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.LabelInputCreditTerm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LabelInputCreditTerm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelInputCreditTerm.Location = new System.Drawing.Point(168, 398);
            this.LabelInputCreditTerm.Name = "LabelInputCreditTerm";
            this.LabelInputCreditTerm.Size = new System.Drawing.Size(229, 82);
            this.LabelInputCreditTerm.TabIndex = 5;
            this.LabelInputCreditTerm.Text = "Введіть термін\r\n(кількість місяців для виплати)";
            this.LabelInputCreditTerm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LabelInputCreditTerm.Visible = false;
            // 
            // InputTermOfCredit
            // 
            this.InputTermOfCredit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InputTermOfCredit.Location = new System.Drawing.Point(419, 424);
            this.InputTermOfCredit.Name = "InputTermOfCredit";
            this.InputTermOfCredit.Size = new System.Drawing.Size(188, 30);
            this.InputTermOfCredit.TabIndex = 6;
            this.InputTermOfCredit.Text = "5";
            this.InputTermOfCredit.Visible = false;
            // 
            // CreditOutputPercent
            // 
            this.CreditOutputPercent.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CreditOutputPercent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CreditOutputPercent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CreditOutputPercent.Location = new System.Drawing.Point(344, 618);
            this.CreditOutputPercent.Name = "CreditOutputPercent";
            this.CreditOutputPercent.ReadOnly = true;
            this.CreditOutputPercent.Size = new System.Drawing.Size(114, 30);
            this.CreditOutputPercent.TabIndex = 8;
            this.CreditOutputPercent.Text = "0";
            this.CreditOutputPercent.Visible = false;
            // 
            // CreditCountPercentButton
            // 
            this.CreditCountPercentButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.CreditCountPercentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CreditCountPercentButton.Location = new System.Drawing.Point(226, 514);
            this.CreditCountPercentButton.Name = "CreditCountPercentButton";
            this.CreditCountPercentButton.Size = new System.Drawing.Size(343, 73);
            this.CreditCountPercentButton.TabIndex = 9;
            this.CreditCountPercentButton.Text = "Розрахувати процент, за яким банк готовий видати кредит";
            this.CreditCountPercentButton.UseVisualStyleBackColor = false;
            this.CreditCountPercentButton.Visible = false;
            this.CreditCountPercentButton.Click += new System.EventHandler(this.CreditCountPercentButton_Click);
            // 
            // ConfirmCreditButton
            // 
            this.ConfirmCreditButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ConfirmCreditButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ConfirmCreditButton.Location = new System.Drawing.Point(254, 678);
            this.ConfirmCreditButton.Name = "ConfirmCreditButton";
            this.ConfirmCreditButton.Size = new System.Drawing.Size(287, 78);
            this.ConfirmCreditButton.TabIndex = 10;
            this.ConfirmCreditButton.Text = "Підтвердити отримання кредиту";
            this.ConfirmCreditButton.UseVisualStyleBackColor = false;
            this.ConfirmCreditButton.Visible = false;
            this.ConfirmCreditButton.Click += new System.EventHandler(this.ConfirmCreditButton_Click);
            // 
            // LabelInputDeposit
            // 
            this.LabelInputDeposit.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.LabelInputDeposit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LabelInputDeposit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelInputDeposit.Location = new System.Drawing.Point(774, 305);
            this.LabelInputDeposit.Name = "LabelInputDeposit";
            this.LabelInputDeposit.Size = new System.Drawing.Size(224, 65);
            this.LabelInputDeposit.TabIndex = 11;
            this.LabelInputDeposit.Text = "Введіть бажану\r\nсуму:";
            this.LabelInputDeposit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LabelInputDeposit.Visible = false;
            // 
            // InputSumOfDeposit
            // 
            this.InputSumOfDeposit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InputSumOfDeposit.Location = new System.Drawing.Point(1049, 322);
            this.InputSumOfDeposit.Name = "InputSumOfDeposit";
            this.InputSumOfDeposit.Size = new System.Drawing.Size(163, 30);
            this.InputSumOfDeposit.TabIndex = 12;
            this.InputSumOfDeposit.Text = "10000";
            this.InputSumOfDeposit.Visible = false;
            // 
            // LabelInputDepositTerm
            // 
            this.LabelInputDepositTerm.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.LabelInputDepositTerm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LabelInputDepositTerm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelInputDepositTerm.Location = new System.Drawing.Point(774, 398);
            this.LabelInputDepositTerm.Name = "LabelInputDepositTerm";
            this.LabelInputDepositTerm.Size = new System.Drawing.Size(224, 82);
            this.LabelInputDepositTerm.TabIndex = 13;
            this.LabelInputDepositTerm.Text = "Введіть термін\r\n(кількість місяців для виплати)";
            this.LabelInputDepositTerm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LabelInputDepositTerm.Visible = false;
            // 
            // InputTermOfDeposit
            // 
            this.InputTermOfDeposit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InputTermOfDeposit.Location = new System.Drawing.Point(1049, 424);
            this.InputTermOfDeposit.Name = "InputTermOfDeposit";
            this.InputTermOfDeposit.Size = new System.Drawing.Size(163, 30);
            this.InputTermOfDeposit.TabIndex = 14;
            this.InputTermOfDeposit.Text = "5";
            this.InputTermOfDeposit.Visible = false;
            // 
            // DepositCountPercentButton
            // 
            this.DepositCountPercentButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.DepositCountPercentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DepositCountPercentButton.Location = new System.Drawing.Point(857, 514);
            this.DepositCountPercentButton.Name = "DepositCountPercentButton";
            this.DepositCountPercentButton.Size = new System.Drawing.Size(343, 73);
            this.DepositCountPercentButton.TabIndex = 15;
            this.DepositCountPercentButton.Text = "Розрахувати процент, за яким банк готовий надати депозит\r\n";
            this.DepositCountPercentButton.UseVisualStyleBackColor = false;
            this.DepositCountPercentButton.Visible = false;
            this.DepositCountPercentButton.Click += new System.EventHandler(this.DepositCountPercentButton_Click);
            // 
            // DepositOutputPercent
            // 
            this.DepositOutputPercent.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DepositOutputPercent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DepositOutputPercent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DepositOutputPercent.Location = new System.Drawing.Point(986, 617);
            this.DepositOutputPercent.Name = "DepositOutputPercent";
            this.DepositOutputPercent.ReadOnly = true;
            this.DepositOutputPercent.Size = new System.Drawing.Size(114, 30);
            this.DepositOutputPercent.TabIndex = 16;
            this.DepositOutputPercent.Text = "0";
            this.DepositOutputPercent.Visible = false;
            // 
            // ConfirmDepositButton
            // 
            this.ConfirmDepositButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ConfirmDepositButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ConfirmDepositButton.Location = new System.Drawing.Point(895, 678);
            this.ConfirmDepositButton.Name = "ConfirmDepositButton";
            this.ConfirmDepositButton.Size = new System.Drawing.Size(287, 78);
            this.ConfirmDepositButton.TabIndex = 17;
            this.ConfirmDepositButton.Text = "Підтвердити видачу депозиту\r\n";
            this.ConfirmDepositButton.UseVisualStyleBackColor = false;
            this.ConfirmDepositButton.Visible = false;
            this.ConfirmDepositButton.Click += new System.EventHandler(this.ConfirmDepositButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.Color.Red;
            this.CloseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CloseButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CloseButton.Location = new System.Drawing.Point(1248, 129);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(52, 50);
            this.CloseButton.TabIndex = 18;
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
            this.BackButton.Location = new System.Drawing.Point(1181, 129);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(52, 50);
            this.BackButton.TabIndex = 21;
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // UserLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1482, 953);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.ConfirmDepositButton);
            this.Controls.Add(this.DepositOutputPercent);
            this.Controls.Add(this.DepositCountPercentButton);
            this.Controls.Add(this.InputTermOfDeposit);
            this.Controls.Add(this.LabelInputDepositTerm);
            this.Controls.Add(this.InputSumOfDeposit);
            this.Controls.Add(this.LabelInputDeposit);
            this.Controls.Add(this.ConfirmCreditButton);
            this.Controls.Add(this.CreditCountPercentButton);
            this.Controls.Add(this.CreditOutputPercent);
            this.Controls.Add(this.InputTermOfCredit);
            this.Controls.Add(this.LabelInputCreditTerm);
            this.Controls.Add(this.LabelInputCreditSum);
            this.Controls.Add(this.InputSumOfCredit);
            this.Controls.Add(this.TakeDepositButton);
            this.Controls.Add(this.TakeCreditButton);
            this.Controls.Add(this.label1);
            this.Name = "UserLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserLogin";
            this.Load += new System.EventHandler(this.UserLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button TakeCreditButton;
        private System.Windows.Forms.Button TakeDepositButton;
        private System.Windows.Forms.TextBox InputSumOfCredit;
        private System.Windows.Forms.Label LabelInputCreditSum;
        private System.Windows.Forms.Label LabelInputCreditTerm;
        private System.Windows.Forms.TextBox InputTermOfCredit;
        private System.Windows.Forms.TextBox CreditOutputPercent;
        private System.Windows.Forms.Button CreditCountPercentButton;
        private System.Windows.Forms.Button ConfirmCreditButton;
        private System.Windows.Forms.Label LabelInputDeposit;
        private System.Windows.Forms.TextBox InputSumOfDeposit;
        private System.Windows.Forms.Label LabelInputDepositTerm;
        private System.Windows.Forms.TextBox InputTermOfDeposit;
        private System.Windows.Forms.Button DepositCountPercentButton;
        private System.Windows.Forms.TextBox DepositOutputPercent;
        private System.Windows.Forms.Button ConfirmDepositButton;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button BackButton;
    }
}