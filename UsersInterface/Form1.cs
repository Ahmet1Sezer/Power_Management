namespace UsersInterface
{
    public partial class Form1 : Form
    {
        //Fields 
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activateForm;


        //Constructor

        public Form1()
        {

            InitializeComponent();
            random = new Random() ;
        }


        //Methods
        public Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);
            while (tempIndex == index)
            {
                index = random.Next(ThemeColor.ColorList.Count);
            }
            tempIndex = index;
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }

        public void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    panelTitleBar.BackColor = color;
                    panelLogo.BackColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    ThemeColor.PrimaryColor = color;
                    ThemeColor.SecondaryColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                }
            }
        }
        public void DisableButton()
        {
        foreach(Control previousBtn in panelMenu.Controls)
            {
             if(previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    
                }
            }
        }

        private void OpenChildForm(Form childform,object btnSender)
        {
        if (activateForm != null)
            {
                activateForm.Close();
            }
            ActivateButton(btnSender);
            childform.TopLevel = false;
            childform.FormBorderStyle = FormBorderStyle.None;
            childform.Dock = DockStyle.Fill;
            this.panelDesktopPanel.Controls.Add(childform);
            this.panelDesktopPanel.Tag = childform;
            childform.BringToFront();
            childform.Show();
            lblTitle.Text = childform.Text;
        }

        private void btnPower_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormProducts(),sender);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormStatus(), sender);
           
            //Forms.FormStatus f2 = new Forms.FormStatus();       
            //f2.timer1.Enabled = true;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormSettings(), sender);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormAbout(), sender);

        }
    }
}