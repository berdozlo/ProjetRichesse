using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fun
{ 
    public partial class Form1 : Form
    {
        string strTimeFormat = "hh:mm:ss";
        int intFormat = 0;
        DateTime time = new DateTime();
        frmMusic Music = new frmMusic();

        public Form1()
        {
            InitializeComponent();
            DateTime time = new DateTime();
            time = DateTime.Now;
            lblName01.Text = time.ToString("hh:mm:ss");
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
             
        }

        private void timeHour_Tick(object sender, EventArgs e)
        {
            time = DateTime.Now;
            lblName01.Text = time.ToString(strTimeFormat);
        }

        private void lblName01_Click(object sender, EventArgs e)
        {
            if (intFormat == 0)
            {
                strTimeFormat = "hh:mm";
                intFormat++;
            }
            else if (intFormat == 1)
            {
                strTimeFormat = "hh:mm:ss";
                intFormat--;
            }
        }

        private void btnMusic_Click(object sender, EventArgs e)
        {
            Music.Show();
        }
    }
}
