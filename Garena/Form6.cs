using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Garena
{
    public partial class Form6 : Form
    {
        string email = Form1.email;
        double gameamount = Form1.pb;
        double shellamount = Form1.shell;
        List<dynamic> user = Form2.UserInfo;

        void purchase()
        {
            if (shellamount >= gameamount)
            {
                MessageBox.Show("Purchase Successfully!");
                shellamount = shellamount - gameamount;
                var jsonfile = File.ReadAllText("Users.json");
                user = JsonConvert.DeserializeObject<List<dynamic>>(jsonfile);

                foreach (var Info in user)
                {
                    string username = Info["Email"];
                    if (email == username)
                    {
                        Info["Shell"] = shellamount;
                        Info["PB"] = 0;
                    }
                }

                var newdata = JsonConvert.SerializeObject(user);
                File.WriteAllText("Users.json", newdata);
                install();
            }
            else
            {
                MessageBox.Show("Transaction Failed");
            }
        }

        void install()
        {
            var jsonfile = File.ReadAllText("Users.json");
            user = JsonConvert.DeserializeObject<List<dynamic>>(jsonfile);

            foreach (var Info in user)
            {
                string username = Info["Email"];
                if (email == username)
                {
                    if (Info["PB"] == 0)
                    {
                        btnpurchase.Visible = false;
                        btninstall.Visible = true;
                    }
                }
            }
        }
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            install();
            btnpurchase.Text = "₱" + gameamount.ToString();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnpurchase_Click(object sender, EventArgs e)
        {
            purchase();
        }
        private async void guna2Button2_Click(object sender, EventArgs e)
        {
            var th = Task.Delay(1500);
            await th;
            Form4 form4 = new Form4();
            this.Hide();
            form4.Show();
        }

        private async void guna2Button1_Click(object sender, EventArgs e)
        {
            var th = Task.Delay(1500);
            await th;
            Form4 form4 = new Form4();
            this.Hide();
            form4.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pnlinstalling.Width += 3;
            if (pnlinstalling.Width >= 260)
            {
                timer1.Stop();
                panel4.Visible = false;
                btnPlay.Visible = true;
            }
        }
        private void btninstall_Click(object sender, EventArgs e)
        {
            btninstall.Visible = false;
            panel4.Visible = true;
            timer1.Start();
        }
        private void guna2Button6_Click(object sender, EventArgs e)
        {
            pictureBox1.BackgroundImage = new Bitmap("C:\\Users\\CC\\Documents\\Garena\\pb2.jpg");
        }
        private void guna2Button5_Click(object sender, EventArgs e)
        {
            pictureBox1.BackgroundImage = new Bitmap("C:\\Users\\CC\\Documents\\Garena\\pb1.jpg");
        }

       
    }
}
