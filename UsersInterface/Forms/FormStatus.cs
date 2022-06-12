using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Management;





namespace UsersInterface.Forms

{

    public partial class FormStatus : Form


    {
        PowerStatus pwr = SystemInformation.PowerStatus;
        PowerStatus status = SystemInformation.PowerStatus;
        public FormStatus()

        {

            InitializeComponent();

        }
        Dictionary<UInt16, string> StatusCodes;



        private void Form1_Load(object sender, EventArgs e)
        {
            StatusCodes = new Dictionary<ushort, string>();
            StatusCodes.Add(1, "The battery is discharging");
            StatusCodes.Add(2, "The system has access to AC so no battery is being discharged. However, the battery is not necessarily charging");
            StatusCodes.Add(3, "Fully Charged");
            StatusCodes.Add(4, "Low");
            StatusCodes.Add(5, "Critical");
            StatusCodes.Add(6, "Charging");
            StatusCodes.Add(7, "Charging and High");
            StatusCodes.Add(8, "Charging and Low");
            StatusCodes.Add(9, "Undefined");
            StatusCodes.Add(10, "Partially Charged");

            /* Set progress bar values and Properties */
            progressBar1.Maximum = 100;
            progressBar1.Style = ProgressBarStyle.Continuous;



            lblBatteryName.Text = pwr.BatteryChargeStatus.ToString();


            //ManagementObjectSearcher mos = new ManagementObjectSearcher("select * from Win32_Battery");
            //foreach (ManagementObject mo in mos.Get())
            //{
            //    lblBatteryName.Text = mo["Name"].ToString();
            //    UInt16 statuscode = (UInt16)mo["BatteryStatus"];
            //    string statusString = StatusCodes[statuscode];
            //    lblBatteryStatus.Text = statusString;
            //}
            // ?? what's this ma dude
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Start();
            PowerStatus pwr = SystemInformation.PowerStatus;
            PowerStatus status = SystemInformation.PowerStatus;

            lblBatteryStatus.Text = pwr.BatteryLifePercent.ToString("P0");
            string statuscode = pwr.BatteryChargeStatus.ToString();

         
            try
            {
                int batteryPercentNumber = Int32.Parse(statuscode.Substring(1));
                if (batteryPercentNumber < 100)
                {
                    progressBar1.ForeColor = Color.Red;
                    progressBar1.Value = 5;
                }
                else if (batteryPercentNumber == 100)
                {
                    progressBar1.ForeColor = Color.Green;
                    progressBar1.Value = 100;
                }
                else if (batteryPercentNumber < 50)
                {
                    progressBar1.ForeColor = Color.Red;
                    progressBar1.Value = 1;
                }
                else if (batteryPercentNumber > 80)
                {
                    progressBar1.ForeColor = Color.Blue;
                    progressBar1.Value = 80;
                }
                else if (batteryPercentNumber > 50)
                {
                    progressBar1.ForeColor = Color.Yellow;
                    progressBar1.Value = 50;
                }
            }
            catch (Exception)
            {

            }
            // bool batterynumber = Int32.TryParse (statuscode.Substring(1);
            


        }

        private void FormStatus_Load(object sender, EventArgs e)
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
    }
}
