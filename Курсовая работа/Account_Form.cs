using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tumblr.API;
using Tumblr.API.info;

namespace Курсовая_работа
{
    public partial class Account_Form : Form
    {
        public Account_Form()
        {
            InitializeComponent();
            string firstresponse = Requests.GETrequest(Requests.RequestMethod.info).Result;//запись в строку ответа от сервера
            var info = firstresponse.getObject<ResponseInfo>();                            // десереализация объекта в var info
            Account_Name.Text = info.response.blog.name;                                   //Работа с объектом черерз var info
            Account_Description.Text = info.response.blog.description;
            string secondresponse = Requests.GETrequest(Requests.RequestMethod.posts).Result;
            var posts = secondresponse.getObject<ResponseBlog>();
            account_photo.ImageLocation = Requests.RequestLink.url + "/avatar";
            int posts_count = posts.response.posts.Count;
            foreach (Post Post in posts.response.posts)
            {
                string a = Post.date;//Дата поста
                string b =Post.photos[0].original_size.url;// URL изображения [0]
                string text = Post.summary; //Текст под постом
            }
        }

        private void account_Form_Load(object sender, EventArgs e)
        {

        }

    }
}
