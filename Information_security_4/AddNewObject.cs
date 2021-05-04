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
    public partial class AddNewObject : Form
    {
        public AddNewObject()
        {
            InitializeComponent();
        }

        private void Addbutton_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < 100; i++)
                {
                    if (PassList.listObj[i].Title == null)
                    {
                        PassList.listObj[i].Title = TitletextBox.Text;
                        PassList.listObj[i].Password = Encryption.EncryptPass(PasstextBox.Text);
                        PassList.listObj[i].App = ApptextBox.Text;
                        PassList.listObj[i].Descr = DestextBox.Text;
                        break;
                    }
                }
                MessageBox.Show("Added");
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
