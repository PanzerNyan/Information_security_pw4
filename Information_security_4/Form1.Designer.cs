
namespace Information_security_4
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.LoginTextbox = new System.Windows.Forms.TextBox();
            this.LogiIn_label = new System.Windows.Forms.Label();
            this.Login_label = new System.Windows.Forms.Label();
            this.Password_label = new System.Windows.Forms.Label();
            this.LogIn_button = new System.Windows.Forms.Button();
            this.Reg_button = new System.Windows.Forms.Button();
            this.PasswordTextbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LoginTextbox
            // 
            this.LoginTextbox.Location = new System.Drawing.Point(12, 77);
            this.LoginTextbox.Name = "LoginTextbox";
            this.LoginTextbox.Size = new System.Drawing.Size(295, 20);
            this.LoginTextbox.TabIndex = 0;
            // 
            // LogiIn_label
            // 
            this.LogiIn_label.AutoSize = true;
            this.LogiIn_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LogiIn_label.Location = new System.Drawing.Point(98, 9);
            this.LogiIn_label.Name = "LogiIn_label";
            this.LogiIn_label.Size = new System.Drawing.Size(111, 39);
            this.LogiIn_label.TabIndex = 2;
            this.LogiIn_label.Text = "Log In";
            // 
            // Login_label
            // 
            this.Login_label.AutoSize = true;
            this.Login_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Login_label.Location = new System.Drawing.Point(12, 54);
            this.Login_label.Name = "Login_label";
            this.Login_label.Size = new System.Drawing.Size(48, 20);
            this.Login_label.TabIndex = 3;
            this.Login_label.Text = "Login";
            // 
            // Password_label
            // 
            this.Password_label.AutoSize = true;
            this.Password_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Password_label.Location = new System.Drawing.Point(12, 100);
            this.Password_label.Name = "Password_label";
            this.Password_label.Size = new System.Drawing.Size(78, 20);
            this.Password_label.TabIndex = 4;
            this.Password_label.Text = "Password";
            // 
            // LogIn_button
            // 
            this.LogIn_button.Location = new System.Drawing.Point(12, 149);
            this.LogIn_button.Name = "LogIn_button";
            this.LogIn_button.Size = new System.Drawing.Size(295, 23);
            this.LogIn_button.TabIndex = 5;
            this.LogIn_button.Text = "Log In";
            this.LogIn_button.UseVisualStyleBackColor = true;
            this.LogIn_button.Click += new System.EventHandler(this.LogIn_button_Click);
            // 
            // Reg_button
            // 
            this.Reg_button.Location = new System.Drawing.Point(12, 178);
            this.Reg_button.Name = "Reg_button";
            this.Reg_button.Size = new System.Drawing.Size(295, 23);
            this.Reg_button.TabIndex = 6;
            this.Reg_button.Text = "Registration";
            this.Reg_button.UseVisualStyleBackColor = true;
            this.Reg_button.Click += new System.EventHandler(this.Reg_button_Click);
            // 
            // PasswordTextbox
            // 
            this.PasswordTextbox.Location = new System.Drawing.Point(12, 123);
            this.PasswordTextbox.Name = "PasswordTextbox";
            this.PasswordTextbox.Size = new System.Drawing.Size(295, 20);
            this.PasswordTextbox.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 234);
            this.Controls.Add(this.PasswordTextbox);
            this.Controls.Add(this.Reg_button);
            this.Controls.Add(this.LogIn_button);
            this.Controls.Add(this.Password_label);
            this.Controls.Add(this.Login_label);
            this.Controls.Add(this.LogiIn_label);
            this.Controls.Add(this.LoginTextbox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox LoginTextbox;
        private System.Windows.Forms.Label LogiIn_label;
        private System.Windows.Forms.Label Login_label;
        private System.Windows.Forms.Label Password_label;
        private System.Windows.Forms.Button LogIn_button;
        private System.Windows.Forms.Button Reg_button;
        private System.Windows.Forms.TextBox PasswordTextbox;
    }
}

