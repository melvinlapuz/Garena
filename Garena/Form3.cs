using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace Garena
{
    public partial class Form3 : Form
    {
       
        public Form3()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel1.Width += 3;
            if (panel1.Width >= 750) 
            {
                timer1.Stop();
                Form4 form4 = new Form4();
                this.Hide();
                form4.Show();

            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
            timer1.Stop();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
