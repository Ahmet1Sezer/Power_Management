using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace UsersInterface.Forms
{

    public partial class FormProducts : Form
    {
        
        


        public FormProducts()
        {
            InitializeComponent();
            checkBox2.Hide();
            checkBox3.Hide();
            checkBox4.Hide();
        }


        private void slpbtn_Click(object sender, EventArgs e)
        {
            Application.SetSuspendState(PowerState.Suspend, false, false);
        }

        private void pwrbtn_Click(object sender, EventArgs e)
        {
            
           

            System.Diagnostics.Process.Start("shutdown", "-f -s -t 1");
        }

        private void rstbtn_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("ShutDown", "/r -f -t 1");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("shutdown", "-l -f");

        }

        private void FormProducts_Load(object sender, EventArgs e)
        {
            LoadTheme();
        }
        private void LoadTheme()
        {
            foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;

                    btn.BackColor = ThemeColor.PrimaryColor;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
                }
            }

          
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                checkBox2.Show();
                checkBox3.Show();
                checkBox4.Show();
            }
           else
            {
                checkBox2.Hide();
                checkBox3.Hide();
                checkBox4.Hide();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                timer1.Start();
                

            }
            
            
        }
    }
}
