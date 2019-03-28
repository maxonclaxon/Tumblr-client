using System;
using System.Windows.Forms;

namespace Курсовая_работа
{
    public partial class Auth_Form : Form
    {
        
        public Auth_Form()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        /// <summary>
        /// Аутентификация пользователя по логину
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void auth_button_Click(object sender, EventArgs e)
        {
            string uri = Api_Tools.url + auth_textBox.Text + Api_Tools.lastuser;
            string data =  Api_Tools.api_key;
            User.Username = auth_textBox.Text;
            string check = Requests.GETrequest(Requests.RequestMethod.info).Result;
            if (check!="Неверный логин!")
            {
                User.loggedin = true;
                this.Close();
                return;
            }
            else
            {
                MessageBox.Show("Неверный логин!");
                auth_textBox.Text = "";
            }
        }
        
        
    }
}
