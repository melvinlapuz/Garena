using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Garena
{
    public partial class Form2 : Form
    {
        string FileName = "Users.json";
        public static List<dynamic> UserInfo = new List<dynamic>();


        void SignUP(string Email, string Username, string Password)
        {
           var JsonFile = File.ReadAllText(FileName);
           UserInfo = JsonConvert.DeserializeObject<List<dynamic>>(JsonFile);

            var info = new
            {
                Email = Email,
                UserName = Username,
                Password = Password,
                LOL = 2399,
                PB = 999,
                HON = 1199,
                Shell = 5000,
            };

            UserInfo.Add(info);

            var UserInfoJson = JsonConvert.SerializeObject(UserInfo);
            File.WriteAllText(FileName, UserInfoJson);
        }


         async void btnRegister()
        {
            if (txtemail.Text == "" || txtusername.Text == "" || txtpassword.Text == "" || txtconfirmpassword.Text == "")
            {
                MessageBox.Show("Invalid Sign Up!\r\n\r\nPlease Try Again!");
            }
            else if (txtpassword.Text != txtconfirmpassword.Text)
            {
                MessageBox.Show("Invalid Sign Up!\r\n\r\nPlease Try Again!");
            }
            else if (label2.Visible == true)
            {
                MessageBox.Show("Invalid Sign Up!\r\n\r\nPlease Try Again!");
            }
            else
            {
                SignUP(txtemail.Text, txtusername.Text, txtpassword.Text);
                MessageBox.Show("Welcome new user \r\nLogin your account");
                txtemail.Text = "";
                txtusername.Text = "";
                txtpassword.Text = "";
                txtconfirmpassword.Text = "";
                var th = Task.Delay(1500);
                await th;
                Form1 form1 = new Form1();
                this.Hide();
                form1.Show();
            }
        }
        public Form2()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            btnRegister();
        }

        private void txtemail_TextChanged(object sender, EventArgs e)
        {
            var JsonFile = File.ReadAllText(FileName);
            UserInfo = JsonConvert.DeserializeObject<List<dynamic>>(JsonFile);

            foreach (var Item in UserInfo)
            {
                string Email = Item["Email"];


                if (Email == txtemail.Text)
                {
                    label2.Visible = true;
                    txtemail.BorderColor = Color.Red;
                    return;
                }

                label2.Visible = false;
                txtemail.BorderColor = Color.FromArgb(213, 218, 223);
            }
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                guna2Button1.Enabled = true;
                guna2Button1.FillColor = Color.FromArgb(233, 28, 35);
            }
            else
            {
                guna2Button1.Enabled = false;
                guna2Button1.FillColor = Color.Gray;
            }


        }
        private void txtconfirmpassword_TextChanged(object sender, EventArgs e)
        {


            if (txtpassword.Text != txtconfirmpassword.Text)
            {
                txtpassword.BorderColor = Color.Red;
                txtconfirmpassword.BorderColor = Color.Red;
            }
            else if (txtpassword.Text == txtconfirmpassword.Text)
            {
                txtpassword.BorderColor = Color.FromArgb(213, 218, 223);
                txtconfirmpassword.BorderColor = Color.FromArgb(213, 218, 223);
            }

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }








        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtpassword_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtusername_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
