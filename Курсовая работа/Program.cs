using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tumblr.API;
namespace Курсовая_работа
{

    static class Program
    {
        
        
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            string login;
            Auth_Form authform = new Auth_Form();
            authform.ShowDialog();
            if (User.loggedin == false) return;
            Account_Form account = new Account_Form();
            account.ShowDialog();
        }
    }
}
