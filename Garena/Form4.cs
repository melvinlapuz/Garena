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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Garena
{
    public partial class Form4 : Form
    {
        string email = Form1.email;
        List<dynamic> UserInfo = Form2.UserInfo;

        public Form4()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Opacity += .2;
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            timer1.Start();
            var JsonFile = File.ReadAllText("Users.json");
            UserInfo = JsonConvert.DeserializeObject<List<dynamic>>(JsonFile);

            foreach (var Item in UserInfo)
            {
                string email1 = Item["Email"];
                if (email == email1)
                {
                    label1.Text = Item["UserName"];
                    label5.Text = Item["Shell"];
                }
            }

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private async void guna2Button3_Click(object sender, EventArgs e)
        {
            var th = Task.Delay(1500);
            await th;
            Form5 form5 = new Form5();
            this.Hide();
            form5.Show();
           
            
        }

        private async void guna2Button4_Click(object sender, EventArgs e)
        {
            var th = Task.Delay(1500);
            await th;
            Form6 form6 = new Form6();
            this.Hide();
            form6.Show();
        }

        private async  void guna2Button5_Click(object sender, EventArgs e)
        {
            var th = Task.Delay(1500);
            await th;
            Form7 form7 = new Form7();
            this.Hide();
            form7.Show();
        }
        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
