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

namespace Курсовая_работа
{
    public partial class Post_Form : Form
    {
        string post_url;
        public Post_Form(int index)
        {
            InitializeComponent();
            Text = Text + " №" + (index+1);
            getpostbyindex(index);
            Post_Picture.MouseMove += (s, e) => { Cursor.Current = Cursors.Hand; };
        }

        private void Post_Form_Load(object sender, EventArgs e)
        {

        }
        private void getpostbyindex(int index)
        {

            string postresponse = Requests.GETrequest(Requests.RequestMethod.posts, "offset=" + index).Result;
            var posts = postresponse.getObject<ResponseBlog>();
            post_url = posts.response.posts[0].post_url;
            Post_Summary.Text = posts.response.posts[0].summary;
            Post_Date.Text = posts.response.posts[0].date;
            Post_Picture.ImageLocation = posts.response.posts[0].photos[0].original_size.url;
            Post_Picture.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void Post_Picture_DoubleClick(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(post_url);
            

        }
    }
}
