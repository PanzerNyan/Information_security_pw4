using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Information_security_4
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
            this.ControlBox = false;
        }

        private void Reg_button_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0 && textBox2.Text.Length > 0)
            {
                DBManager.SendUserData(textBox1.Text, textBox2.Text);
                this.Hide();
            }
            else 
            {
                Console.WriteLine("You wrong");
            }
        }

        private void randpass_button_Click(object sender, EventArgs e)
        {
            string pass = "";
            var r = new Random();
            while (pass.Length < 16)
            {
                Char c = (char)r.Next(33, 125);
                if (Char.IsLetterOrDigit(c))
                    pass += c;
            }
            textBox2.Text = pass;
        }
    }
}
