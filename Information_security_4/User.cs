using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Information_security_4
{
    class User
    {
        static private string Login;
        static private string Pkey;
        static private string UserIV;

        static public string GetLogin() 
        {
            return Login;
        }

        static public string GetKey()
        {
            return Pkey;
        }

        static public string GetIV()
        {
            return UserIV;
        }

        static public void SetLogin(string login2)
        {
            Login = login2;
        }

        static public void SetKey(string key2) 
        {
            Pkey = key2;
        }

        static public void SetIV(string IV2)
        {
            UserIV = IV2;
        }
    }
}
