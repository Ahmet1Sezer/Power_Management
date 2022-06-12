namespace UsersInterface.Forms
{
    partial class FormProducts
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pwrbtn = new System.Windows.Forms.Button();
            this.rstbtn = new System.Windows.Forms.Button();
            this.slpbtn = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // pwrbtn
            // 
            this.pwrbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pwrbtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pwrbtn.ForeColor = System.Drawing.Color.White;
            this.pwrbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pwrbtn.Location = new System.Drawing.Point(83, 371);
            this.pwrbtn.Name = "pwrbtn";
            this.pwrbtn.Size = new System.Drawing.Size(120, 36);
            this.pwrbtn.TabIndex = 0;
            this.pwrbtn.Text = "Bilgisayarı Kapat";
            this.pwrbtn.UseVisualStyleBackColor = true;
            this.pwrbtn.Click += new System.EventHandler(this.pwrbtn_Click);
            // 
            // rstbtn
            // 
            this.rstbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rstbtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rstbtn.ForeColor = System.Drawing.Color.White;
            this.rstbtn.Location = new System.Drawing.Point(401, 371);
            this.rstbtn.Name = "rstbtn";
            this.rstbtn.Size = new System.Drawing.Size(126, 36);
            this.rstbtn.TabIndex = 1;
            this.rstbtn.Text = "Yeniden Başlat";
            this.rstbtn.UseVisualStyleBackColor = true;
            this.rstbtn.Click += new System.EventHandler(this.rstbtn_Click);
            // 
            // slpbtn
            // 
            this.slpbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.slpbtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.slpbtn.ForeColor = System.Drawing.Color.White;
            this.slpbtn.Location = new System.Drawing.Point(238, 371);
            this.slpbtn.Name = "slpbtn";
            this.slpbtn.Size = new System.Drawing.Size(126, 36);
            this.slpbtn.TabIndex = 2;
            this.slpbtn.Text = "Uyku";
            this.slpbtn.UseVisualStyleBackColor = true;
            this.slpbtn.Click += new System.EventHandler(this.slpbtn_Click);
            // 
            // button4
            // 
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(557, 371);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(126, 36);
            this.button4.TabIndex = 3;
            this.button4.Text = "Oturumu Kapat";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(293, 83);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(126, 19);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "Zamanlayıcı Ayarla";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(293, 120);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(54, 19);
            this.checkBox2.TabIndex = 5;
            this.checkBox2.Text = "45 dk";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox3.Location = new System.Drawing.Point(293, 158);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(38, 19);
            this.checkBox3.TabIndex = 6;
            this.checkBox3.Text = "1 S";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox4.Location = new System.Drawing.Point(293, 197);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(38, 19);
            this.checkBox4.TabIndex = 7;
            this.checkBox4.Text = "2 S";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(344, 223);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Başlat";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(491, 69);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(192, 23);
            this.dateTimePicker1.TabIndex = 9;
            // 
            // FormProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(91)))), ((int)(((byte)(116)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkBox4);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.slpbtn);
            this.Controls.Add(this.rstbtn);
            this.Controls.Add(this.pwrbtn);
            this.Name = "FormProducts";
            this.Text = "cv";
            this.Load += new System.EventHandler(this.FormProducts_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button pwrbtn;
        private Button rstbtn;
        private Button slpbtn;
        private Button button4;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private CheckBox checkBox4;
        private Button button1;
        private System.Windows.Forms.Timer timer1;
        private DateTimePicker dateTimePicker1;
    }
}