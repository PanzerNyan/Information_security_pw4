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

            this.ControlBox = false;
            newpass_textBox.Hide();
            Change_button.Hide();

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
            if (File.ReadAllLines(Form1.user.Login + ".txt").Length != 0)
            {
                Encryption.FileEncryption(Form1.user.Login);
            }
                Application.Exit();
        }



        private void OnLoad(object sender, EventArgs e)
        {
            if (File.ReadAllLines(Form1.user.Login + ".txt").Length != 0)
            {
                string line;
                int j = 0;
                using (StreamReader file = new StreamReader(Form1.user.Login + ".txt"))
                {
                    while ((line = file.ReadLine()) != null)
                    {

                        char[] delimiters = new char[] { ';' };
                        string[] parts = line.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
                        listObj[j].Title = parts[0];
                        listObj[j].Password = parts[1];
                        listObj[j].App = parts[2];
                        listObj[j].Descr = parts[3];
                        j++;

                    }
                }
                DataTableFill();
                ObjDetailsFill();
            }
        }

        private void DataTableFill()
        {

            for (int i = 0; i < 100; i++)
            {
                if (listObj[i].Title != null)
                {
                    dataGridView1.Rows.Add(listObj[i].Title, listObj[i].Password, listObj[i].App, listObj[i].Descr);
                }
            }
              
               
            
        }

        private void ObjDetailsFill()
        {
            title_label.Text = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString();
            password_label.Text = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[1].Value.ToString();
            app_label.Text = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[2].Value.ToString();
            description_label.Text = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[3].Value.ToString();
        }

        private void OnActive(object sender, EventArgs e)
        {
            if (File.ReadAllLines(Form1.user.Login + ".txt").Length != 0)
            {
                dataGridView1.Rows.Clear();
                DataTableFill();
                ObjDetailsFill();
            }
            for (int i = 0; i < 100; i++)
            {
                if (listObj[i].Title != null)
                {
                    dataGridView1.Rows.Clear();
                    DataTableFill();
                    ObjDetailsFill();
                    break;
                }
            }
        }

        private void SelectPass(object sender, MouseEventArgs e)
        {
            ObjDetailsFill();
        }

        private void show_button_Click(object sender, EventArgs e)
        {
            UTF8Encoding encoder = new UTF8Encoding();

 

            password_label.Text = Encryption.DecryptPass(password_label.Text);
        }

        private void Copy_button_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(password_label.Text);
        }

        private int PassSearch(string pass_title) 
        {
            for (int i = 0; i < 100; i++)
            {
                if (listObj[i].Title != null && listObj[i].Title == pass_title)
                {
                    return i;
                }
            }
            return 101;
        }

        private void Delete_button_Click(object sender, EventArgs e)
        {
            try
            {
                int i = PassSearch(title_label.Text);
                if (i != 101)
                {
                    listObj[i].Title = null;
                    listObj[i].Password = null;
                    listObj[i].App = null;
                    listObj[i].Descr = null;

                    dataGridView1.Rows.Clear();
                    DataTableFill();
                    ObjDetailsFill();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Update_button_Click(object sender, EventArgs e)
        {
            if (newpass_textBox.Visible == true)
            {
                newpass_textBox.Hide();
                Change_button.Hide();
            }
            else 
            {
                newpass_textBox.Show();
                Change_button.Show();
            }
        }

        private void Change_button_Click(object sender, EventArgs e)
        {
            try
            {
                int i = PassSearch(title_label.Text);
                if (i != 101)
                {
                    listObj[i].Password = Encryption.EncryptPass(newpass_textBox.Text);
                }
                dataGridView1.Rows.Clear();
                DataTableFill();
                ObjDetailsFill();

                newpass_textBox.Hide();
                Change_button.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Searchbutton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= dataGridView1.Rows.Count - 1; i++) 
            {
                for (int j = 0; j <= dataGridView1.ColumnCount - 1; j++) 
                {
                    if (dataGridView1.Rows[i].Cells[j].Value != null && dataGridView1.Rows[i].Cells[j].Value.ToString() == search_textBox.Text)
                    {
                        dataGridView1.Rows[i].Cells[j].Selected = true;
                        ObjDetailsFill();
                    }
                }
                    
                       
            }
 
        }
    }
}

