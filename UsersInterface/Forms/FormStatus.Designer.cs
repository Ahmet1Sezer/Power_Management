namespace UsersInterface.Forms
{
    partial class FormStatus
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.lblBatteryName = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lblBatteryStatus = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Battery Name:";
            // 
            // lblBatteryName
            // 
            this.lblBatteryName.AccessibleName = "BatteryNameLabel";
            this.lblBatteryName.AutoSize = true;
            this.lblBatteryName.Location = new System.Drawing.Point(113, 31);
            this.lblBatteryName.Name = "lblBatteryName";
            this.lblBatteryName.Size = new System.Drawing.Size(36, 15);
            this.lblBatteryName.TabIndex = 8;
            this.lblBatteryName.Text = "None";
            // 
            // progressBar1
            // 
            this.progressBar1.ForeColor = System.Drawing.Color.HotPink;
            this.progressBar1.Location = new System.Drawing.Point(25, 93);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(368, 23);
            this.progressBar1.TabIndex = 9;
            // 
            // lblBatteryStatus
            // 
            this.lblBatteryStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(91)))), ((int)(((byte)(116)))));
            this.lblBatteryStatus.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblBatteryStatus.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblBatteryStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblBatteryStatus.Location = new System.Drawing.Point(25, 122);
            this.lblBatteryStatus.Multiline = true;
            this.lblBatteryStatus.Name = "lblBatteryStatus";
            this.lblBatteryStatus.Size = new System.Drawing.Size(368, 40);
            this.lblBatteryStatus.TabIndex = 10;
            // 
            // FormStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(91)))), ((int)(((byte)(116)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblBatteryStatus);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.lblBatteryName);
            this.Controls.Add(this.label1);
            this.Name = "FormStatus";
            this.Text = "FormStatus";
            this.Load += new System.EventHandler(this.FormStatus_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer2;
        private ContextMenuStrip contextMenuStrip1;
        private Label label1;
        private Label lblBatteryName;
        private ProgressBar progressBar1;
        private TextBox lblBatteryStatus;
        internal System.Windows.Forms.Timer timer1;
    }
}