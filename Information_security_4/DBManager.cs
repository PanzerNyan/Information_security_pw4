using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SqlConn;
using MySql.Data.MySqlClient;
using System.IO;
using System.Windows.Forms;
using System.Data;
using System.Security.Cryptography;

namespace Information_security_4
{
    class DBManager
    {
        static public void SendUserData(string Login, string Password)
        {
            MySqlConnection conn = DBUtils.GetDBConnection();

            byte[] salt;
            new RNGCryptoServiceProvider().GetBytes(salt = new byte[16]);

            var pbkdf2 = new Rfc2898DeriveBytes(Password, salt, 100000);
            byte[] hash = pbkdf2.GetBytes(20);

            byte[] hashBytes = new byte[36];
            Array.Copy(salt, 0, hashBytes, 0, 16);
            Array.Copy(hash, 0, hashBytes, 16, 20);

            MySqlCommand cmd;
            try
            {
                if (Login != "login" && Password != "qwerty" && Login.Length > 0 && Password.Length > 0)
                {

                    string CmdString = "INSERT INTO users(Login, Password) VALUES(@Login, @Password)";
                    cmd = new MySqlCommand(CmdString, conn);
                    cmd.Parameters.Add("@Login", MySqlDbType.VarChar, 50);
                    cmd.Parameters.Add("@Password", MySqlDbType.VarChar, 500);
                    cmd.Parameters["@Login"].Value = Login;
                    cmd.Parameters["@Password"].Value = Convert.ToBase64String(hashBytes);
                    conn.Open();
                    int RowsAffected = cmd.ExecuteNonQuery();
                    if (RowsAffected > 0)
                    {
                        MessageBox.Show("sucessfully!");
                    }
                    conn.Close();

                }
                else
                {
                    MessageBox.Show("Incomplete data!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                try
                {

                    using (FileStream fs = File.Create(Login + ".txt"));

                }

                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }

        }

        static public bool LogInControl(string textlogin, string textpassword)
        {
            DBConnector conn = new DBConnector();

            string DataPassword = null;

            

            try
            {

                if (textlogin.Length > 0 && textpassword.Length > 0 && textlogin != " " && textpassword != " ")
                {
                    conn.Open();
                    string query = "select * from users WHERE Login ='" + textlogin + "'";
                    MySqlDataReader row;
                    row = conn.ExecuteReader(query);
                    if (row.HasRows)
                    {
                        while (row.Read())
                        {
                            DataPassword = row["Password"].ToString();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid Data!!!", "Information");
                        return false;
                    }
                    conn.Close();
                }
                else
                {
                    MessageBox.Show("Username or Password is empty", "Information");
                    return false;
                }
            
                byte[] hashBytes = Convert.FromBase64String(DataPassword);
                byte[] salt = new byte[16];
                Array.Copy(hashBytes, 0, salt, 0, 16);
                var pbkdf2 = new Rfc2898DeriveBytes(textpassword, salt, 100000);
                byte[] hash = pbkdf2.GetBytes(20);
                for (int i = 0; i < 20; i++)
                {
                    if (hashBytes[i + 16] != hash[i])
                    {
                        return false;
                    }
                }
                MessageBox.Show("Log In successful", "Information");

                Form1.user.Login = textlogin;

                return true;
            }
            catch
            {
                MessageBox.Show("Connection Error", "Information");
                return false;
            }
        }

    }
}
