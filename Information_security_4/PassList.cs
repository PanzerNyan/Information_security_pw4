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
    public partial class PassList : Form
    {
        static public ListObj[] listObj = new ListObj[100];

        AddNewObject addNewObject = new AddNewObject();

        public PassList()
        {

            for (int i = 0; i < 100; i++)
            {
                listObj[i] = new ListObj();
                listObj[i].Title = null;
                listObj[i].Password = null;
                listObj[i].App = null;
                listObj[i].Descr = null;

            }
                InitializeComponent();

            
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            addNewObject.Show();
        }

        private void exit_label_Click(object sender, EventArgs e)
        {
            try
            {
                File.WriteAllText(Form1.user.Login + ".txt", String.Empty);
                for (int i = 0; i < 100; i++)
                {
                    if (listObj[i].Title != null)
                    {
                        using (StreamWriter sw = new StreamWriter(Form1.user.Login + ".txt", true, System.Text.Encoding.Default))
                        {
                            sw.WriteLine(listObj[i].Title + ";" + listObj[i].Password + ";" + listObj[i].App + ";" + listObj[i].Descr);
                        }
                    }
                    else 
                    {
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

  

        private void OnLoad(object sender, EventArgs e)
        {
            if (File.ReadAllBytes(Form1.user.Login + ".txt") != null)
            {

            }
        }
    }
}
