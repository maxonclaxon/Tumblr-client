using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Windows.Forms;
using System.IO;
using Tumblr.API;
using Tumblr.API.info;

namespace Курсовая_работа
{
    public partial class Account_Form : Form
    {

        int page = 0;
        int totalpages;
        bool btnon=false;
        public Account_Form()
        {
            InitializeComponent();
            initaccount();
            
        }

        private void account_Form_Load(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (page != 0)
            {
                page = page - 1;
                getposts(page);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (page != totalpages)
            {
                page = page + 1;
                getposts(page);
            }
        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (listView1.SelectedItems.Count == 1)
            {
                int index = listView1.SelectedItems[0].Index;
                Post_Form post_form = new Post_Form(index + page * 20);
                post_form.Show();
                
            }
        }

        private void getposts(int page)
        {
            listView1.Items.Clear();
            int posts_count = 0;
            int post_counter = page == 0 ? post_counter = 1 : post_counter = 20 * page+1;
            int offset = page==0? 0: page * 20 - 1;
            string postresponse = Requests.GETrequest(Requests.RequestMethod.posts,"offset="+ offset).Result;
            var posts = postresponse.getObject<ResponseBlog>();
            count_of_posts.Text = offset+1 + "-" + posts.response.posts.Count * (page+1) + " / " + posts.response.total_posts.ToString();
            foreach (Post Post in posts.response.posts)
            {
                string a = Post.date;//Дата поста
                string text = Post.summary; //Текст под постом
                ListViewItem item = new ListViewItem((post_counter).ToString());
                if(Post.summary=="")item.SubItems.Add("Без описания");
                else item.SubItems.Add(Post.summary);
                listView1.Items.Add(item);
                post_counter++;
            }
        }

        private void Change_Account_Click(object sender, EventArgs e)
        {
            User.loggedin = false;
            Auth_Form form = new Auth_Form();
            form.ShowDialog();
            if (User.loggedin)
            {
                initaccount();
            }
        }

        private void initaccount()
        {
            string firstresponse = Requests.GETrequest(Requests.RequestMethod.info).Result;//запись в строку ответа от сервера
            var info = firstresponse.getObject<ResponseInfo>();                            // десереализация объекта в var info
            double ttp = info.response.blog.total_posts;
            ttp /= 20;
            totalpages = Convert.ToInt32(Math.Ceiling(ttp));
            Account_Name.Text = info.response.blog.name;                                   //Работа с объектом черерз var info
            Account_Description.Text = info.response.blog.description;
            account_photo.ImageLocation = Requests.RequestLink.url() + "/avatar";
            getposts(page);
        }
    }
}
