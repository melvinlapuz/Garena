using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls.WebParts;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Garena
{
    public partial class Form1 : Form
    {
        public static string email;
        public static string pass;
        public static string user;
        public static double shell;
        public static double lol;
        public static double pb;
        public static double hon;
        List<dynamic> UserInfo = Form2.UserInfo; 

        public Form1()
        {
            
            InitializeComponent();
        }
        
        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private async void guna2Button1_Click(object sender, EventArgs e)
        {
            try
            {
                var JsonFile = File.ReadAllText("Users.json");
                UserInfo = JsonConvert.DeserializeObject<List<dynamic>>(JsonFile);

                foreach (var Item in UserInfo)
                {
                    email = Item["Email"];
                    pass = Item["Password"];
                    user = Item["UserName"];
                    shell = Item["Shell"];
                    lol = Item["LOL"];
                    pb = Item["PB"];
                    hon = Item["HON"];

                    if (email == txtemail.Text && pass == txtpassword.Text)
                    {
                        var th = Task.Delay(700);
                        await th;

                        Form3 form3 = new Form3();
                        this.Hide();
                        form3.Show();
                        return;
                    }

                }
                MessageBox.Show("Invalid Login");
            }
            catch
            {
                MessageBox.Show("Invalid Login");
            }
        }

        private async void guna2Button3_Click(object sender, EventArgs e)
        {
            var th = Task.Delay(1500);
            await th;
            Form2 form2 = new Form2();
            this.Hide();
            form2.Show();
        }




        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {

        }

    }
}
