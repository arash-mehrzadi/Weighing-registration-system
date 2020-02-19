namespace Smart_House_App
{
    partial class frmsystemcontrol
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmsystemcontrol));
            this.controlpanel = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnlight2 = new System.Windows.Forms.Button();
            this.btnlight3 = new System.Windows.Forms.Button();
            this.btnlight4 = new System.Windows.Forms.Button();
            this.btnlight5 = new System.Windows.Forms.Button();
            this.btnlight1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnstart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnexit = new System.Windows.Forms.Button();
            this.btnconnecting = new System.Windows.Forms.Button();
            this.lblconnecting = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.controlpanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // controlpanel
            // 
            this.controlpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.controlpanel.Controls.Add(this.label8);
            this.controlpanel.Controls.Add(this.label7);
            this.controlpanel.Controls.Add(this.label6);
            this.controlpanel.Controls.Add(this.label5);
            this.controlpanel.Controls.Add(this.label4);
            this.controlpanel.Controls.Add(this.btnlight2);
            this.controlpanel.Controls.Add(this.btnlight3);
            this.controlpanel.Controls.Add(this.btnlight4);
            this.controlpanel.Controls.Add(this.btnlight5);
            this.controlpanel.Controls.Add(this.btnlight1);
            this.controlpanel.Controls.Add(this.label3);
            this.controlpanel.Location = new System.Drawing.Point(269, 199);
            this.controlpanel.Name = "controlpanel";
            this.controlpanel.Size = new System.Drawing.Size(540, 272);
            this.controlpanel.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 60);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 19);
            this.label8.TabIndex = 10;
            this.label8.Text = "Room 1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 243);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 19);
            this.label7.TabIndex = 9;
            this.label7.Text = "Room 5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 195);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 19);
            this.label6.TabIndex = 8;
            this.label6.Text = "Room 4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 19);
            this.label5.TabIndex = 7;
            this.label5.Text = "Room 3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "Room 2";
            // 
            // btnlight2
            // 
            this.btnlight2.BackColor = System.Drawing.SystemColors.GrayText;
            this.btnlight2.Location = new System.Drawing.Point(126, 95);
            this.btnlight2.Name = "btnlight2";
            this.btnlight2.Size = new System.Drawing.Size(116, 39);
            this.btnlight2.TabIndex = 5;
            this.btnlight2.Text = "off";
            this.btnlight2.UseVisualStyleBackColor = false;
            this.btnlight2.Click += new System.EventHandler(this.clickonoff);
            // 
            // btnlight3
            // 
            this.btnlight3.BackColor = System.Drawing.SystemColors.GrayText;
            this.btnlight3.Location = new System.Drawing.Point(126, 140);
            this.btnlight3.Name = "btnlight3";
            this.btnlight3.Size = new System.Drawing.Size(116, 39);
            this.btnlight3.TabIndex = 4;
            this.btnlight3.Text = "off";
            this.btnlight3.UseVisualStyleBackColor = false;
            this.btnlight3.Click += new System.EventHandler(this.clickonoff);
            // 
            // btnlight4
            // 
            this.btnlight4.BackColor = System.Drawing.SystemColors.GrayText;
            this.btnlight4.Location = new System.Drawing.Point(126, 185);
            this.btnlight4.Name = "btnlight4";
            this.btnlight4.Size = new System.Drawing.Size(116, 39);
            this.btnlight4.TabIndex = 3;
            this.btnlight4.Text = "off";
            this.btnlight4.UseVisualStyleBackColor = false;
            this.btnlight4.Click += new System.EventHandler(this.clickonoff);
            // 
            // btnlight5
            // 
            this.btnlight5.BackColor = System.Drawing.SystemColors.GrayText;
            this.btnlight5.Location = new System.Drawing.Point(126, 233);
            this.btnlight5.Name = "btnlight5";
            this.btnlight5.Size = new System.Drawing.Size(116, 39);
            this.btnlight5.TabIndex = 2;
            this.btnlight5.Text = "off";
            this.btnlight5.UseVisualStyleBackColor = false;
            this.btnlight5.Click += new System.EventHandler(this.clickonoff);
            // 
            // btnlight1
            // 
            this.btnlight1.BackColor = System.Drawing.SystemColors.GrayText;
            this.btnlight1.Location = new System.Drawing.Point(126, 50);
            this.btnlight1.Name = "btnlight1";
            this.btnlight1.Size = new System.Drawing.Size(116, 39);
            this.btnlight1.TabIndex = 1;
            this.btnlight1.Text = "off";
            this.btnlight1.UseVisualStyleBackColor = false;
            this.btnlight1.Click += new System.EventHandler(this.clickonoff);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "lights";
            // 
            // btnstart
            // 
            this.btnstart.Font = new System.Drawing.Font("American Captain", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnstart.Location = new System.Drawing.Point(3, 3);
            this.btnstart.Name = "btnstart";
            this.btnstart.Size = new System.Drawing.Size(245, 74);
            this.btnstart.TabIndex = 1;
            this.btnstart.Text = "START";
            this.btnstart.UseVisualStyleBackColor = true;
            this.btnstart.Click += new System.EventHandler(this.btnstart_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("American Captain", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 35);
            this.label1.TabIndex = 2;
            this.label1.Text = "USER NAME :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("American Captain", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 233);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 35);
            this.label2.TabIndex = 3;
            this.label2.Text = "PASSWORD :";
            // 
            // txtusername
            // 
            this.txtusername.Location = new System.Drawing.Point(3, 203);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(229, 27);
            this.txtusername.TabIndex = 4;
            // 
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(3, 271);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(229, 27);
            this.txtpassword.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RosyBrown;
            this.panel1.Controls.Add(this.btnexit);
            this.panel1.Controls.Add(this.btnconnecting);
            this.panel1.Controls.Add(this.btnstart);
            this.panel1.Controls.Add(this.txtpassword);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtusername);
            this.panel1.Location = new System.Drawing.Point(12, 70);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(251, 401);
            this.panel1.TabIndex = 6;
            // 
            // btnexit
            // 
            this.btnexit.BackColor = System.Drawing.Color.MistyRose;
            this.btnexit.Font = new System.Drawing.Font("American Captain", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexit.Location = new System.Drawing.Point(3, 311);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(245, 87);
            this.btnexit.TabIndex = 7;
            this.btnexit.Text = "E&XIT";
            this.btnexit.UseVisualStyleBackColor = false;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // btnconnecting
            // 
            this.btnconnecting.Font = new System.Drawing.Font("American Captain", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnconnecting.Location = new System.Drawing.Point(4, 83);
            this.btnconnecting.Name = "btnconnecting";
            this.btnconnecting.Size = new System.Drawing.Size(244, 79);
            this.btnconnecting.TabIndex = 6;
            this.btnconnecting.Text = "Connect";
            this.btnconnecting.UseVisualStyleBackColor = true;
            this.btnconnecting.Click += new System.EventHandler(this.btnconnecting_Click);
            // 
            // lblconnecting
            // 
            this.lblconnecting.BackColor = System.Drawing.Color.Red;
            this.lblconnecting.Location = new System.Drawing.Point(12, 9);
            this.lblconnecting.Name = "lblconnecting";
            this.lblconnecting.Size = new System.Drawing.Size(251, 58);
            this.lblconnecting.TabIndex = 7;
            this.lblconnecting.Text = "DISCONNECT";
            this.lblconnecting.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(269, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(540, 184);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // serialPort1
            // 
            this.serialPort1.PortName = "COM3";
            // 
            // frmsystemcontrol
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(821, 483);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblconnecting);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.controlpanel);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmsystemcontrol";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Smart House";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.controlpanel.ResumeLayout(false);
            this.controlpanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel controlpanel;
        private System.Windows.Forms.Button btnlight2;
        private System.Windows.Forms.Button btnlight3;
        private System.Windows.Forms.Button btnlight4;
        private System.Windows.Forms.Button btnlight5;
        private System.Windows.Forms.Button btnlight1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnstart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Button btnconnecting;
        private System.Windows.Forms.Label lblconnecting;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.IO.Ports.SerialPort serialPort1;
    }
}

