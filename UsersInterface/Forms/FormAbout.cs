using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace UsersInterface.Forms
{
    public partial class FormAbout : Form
    {

      
        public FormAbout()
        {
            InitializeComponent();
        }
     
        

           

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(new ProcessStartInfo { FileName = @"https://github.com/Ahmet1Sezer", UseShellExecute = true });
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(new ProcessStartInfo { FileName = @"https://www.linkedin.com/in/ahmet-sezer-1b252a203/", UseShellExecute = true });

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(label4.Text);
            MessageBox.Show("Kopyalandı");
        }

        private void FormAbout_Load(object sender, EventArgs e)
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

            label1.ForeColor = ThemeColor.PrimaryColor;
            label2.ForeColor = ThemeColor.PrimaryColor;
            label3.ForeColor = ThemeColor.PrimaryColor;
            linkLabel1.LinkColor = ThemeColor.SecondaryColor;
            linkLabel2.LinkColor = ThemeColor.SecondaryColor;
            linkLabel3.LinkColor = ThemeColor.SecondaryColor;
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(new ProcessStartInfo { FileName = @"mailto:ahmtcnszr1@gmail.com", UseShellExecute = true });
        }
    }
}


