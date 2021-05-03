using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Security.AccessControl;
using System.Security.Cryptography;

namespace Information_security_4
{
    public partial class Form1 : Form
    {
        public Registration registration = new Registration();
        public PassList passlist = new PassList();

        static public User user = new User();

        public Form1()
        {
            InitializeComponent();

        }

        private void Reg_button_Click(object sender, EventArgs e)
        {
            registration.Show();
        }

        private void LogIn_button_Click(object sender, EventArgs e)
        {
            if (DBManager.LogInControl(LoginTextbox.Text, PasswordTextbox.Text) == true)
            {
                /*if (File.ReadAllBytes(user.Login + ".txt") != null) 
                {
                    Encryption.FileDecryption(user.Login);
                }*/

                this.Hide();
                passlist.Show();
            }
            else 
            {
                MessageBox.Show("Login invalid data");
            }

        }
    }
}
