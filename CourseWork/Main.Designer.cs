
namespace CourseWork
{
    partial class Main
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
            this.UserLogin = new System.Windows.Forms.Button();
            this.ManagerLogin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.CloseButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UserLogin
            // 
            this.UserLogin.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.UserLogin.Location = new System.Drawing.Point(287, 443);
            this.UserLogin.Name = "UserLogin";
            this.UserLogin.Size = new System.Drawing.Size(328, 88);
            this.UserLogin.TabIndex = 0;
            this.UserLogin.Text = "Увійти як користувач";
            this.UserLogin.UseVisualStyleBackColor = false;
            this.UserLogin.Click += new System.EventHandler(this.UserLogin_Click);
            // 
            // ManagerLogin
            // 
            this.ManagerLogin.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ManagerLogin.Location = new System.Drawing.Point(847, 446);
            this.ManagerLogin.Name = "ManagerLogin";
            this.ManagerLogin.Size = new System.Drawing.Size(335, 85);
            this.ManagerLogin.TabIndex = 1;
            this.ManagerLogin.Text = "Увійти як менеджер";
            this.ManagerLogin.UseVisualStyleBackColor = false;
            this.ManagerLogin.Click += new System.EventHandler(this.ManagerLogin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Info;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(534, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(410, 50);
            this.label1.TabIndex = 2;
            this.label1.Text = "Вітаємо Вас у нашому банку, користуваче. \r\nНатисніть на одну з кнопок нижче.\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.Color.Red;
            this.CloseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CloseButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CloseButton.Location = new System.Drawing.Point(1236, 135);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(52, 50);
            this.CloseButton.TabIndex = 19;
            this.CloseButton.Text = "X";
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1482, 953);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ManagerLogin);
            this.Controls.Add(this.UserLogin);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.FormClosing += this.Main_FormClosing;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button UserLogin;
        private System.Windows.Forms.Button ManagerLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CloseButton;
    }
}

