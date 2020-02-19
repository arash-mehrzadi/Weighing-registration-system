namespace baskol_project
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtshowdata = new System.Windows.Forms.TextBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.btnoffon = new ns1.BunifuThinButton2();
            this.btnset = new ns1.BunifuThinButton2();
            this.txtsetwiegh = new System.Windows.Forms.TextBox();
            this.btnadd = new ns1.BunifuThinButton2();
            this.label1 = new System.Windows.Forms.Label();
            this.txttitle = new System.Windows.Forms.TextBox();
            this.txtyear = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtorigin = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtdestination = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtcode = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtmonth = new System.Windows.Forms.TextBox();
            this.txtday = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btntare = new ns1.BunifuThinButton2();
            this.btnzero = new ns1.BunifuThinButton2();
            this.btnsetoption = new ns1.BunifuThinButton2();
            this.btnconnection = new ns1.BunifuThinButton2();
            this.btnexit = new ns1.BunifuThinButton2();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtshowdata
            // 
            this.txtshowdata.BackColor = System.Drawing.Color.LightCoral;
            this.txtshowdata.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtshowdata.ForeColor = System.Drawing.Color.ForestGreen;
            this.txtshowdata.Location = new System.Drawing.Point(199, 28);
            this.txtshowdata.Name = "txtshowdata";
            this.txtshowdata.ReadOnly = true;
            this.txtshowdata.Size = new System.Drawing.Size(161, 26);
            this.txtshowdata.TabIndex = 1;
            // 
            // btnoffon
            // 
            this.btnoffon.ActiveBorderThickness = 1;
            this.btnoffon.ActiveCornerRadius = 20;
            this.btnoffon.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnoffon.ActiveForecolor = System.Drawing.Color.White;
            this.btnoffon.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnoffon.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnoffon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnoffon.BackgroundImage")));
            this.btnoffon.ButtonText = "OFF";
            this.btnoffon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnoffon.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnoffon.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnoffon.IdleBorderThickness = 1;
            this.btnoffon.IdleCornerRadius = 20;
            this.btnoffon.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnoffon.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnoffon.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnoffon.Location = new System.Drawing.Point(13, 11);
            this.btnoffon.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnoffon.Name = "btnoffon";
            this.btnoffon.Size = new System.Drawing.Size(156, 59);
            this.btnoffon.TabIndex = 3;
            this.btnoffon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnoffon.Click += new System.EventHandler(this.btnoffon_Click);
            // 
            // btnset
            // 
            this.btnset.ActiveBorderThickness = 1;
            this.btnset.ActiveCornerRadius = 20;
            this.btnset.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnset.ActiveForecolor = System.Drawing.Color.White;
            this.btnset.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnset.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnset.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnset.BackgroundImage")));
            this.btnset.ButtonText = "SET";
            this.btnset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnset.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnset.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnset.IdleBorderThickness = 1;
            this.btnset.IdleCornerRadius = 20;
            this.btnset.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnset.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnset.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnset.Location = new System.Drawing.Point(13, 80);
            this.btnset.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnset.Name = "btnset";
            this.btnset.Size = new System.Drawing.Size(156, 59);
            this.btnset.TabIndex = 4;
            this.btnset.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnset.Click += new System.EventHandler(this.btnrefresh_Click_1);
            // 
            // txtsetwiegh
            // 
            this.txtsetwiegh.BackColor = System.Drawing.Color.LightCoral;
            this.txtsetwiegh.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsetwiegh.ForeColor = System.Drawing.Color.ForestGreen;
            this.txtsetwiegh.Location = new System.Drawing.Point(199, 93);
            this.txtsetwiegh.Name = "txtsetwiegh";
            this.txtsetwiegh.ReadOnly = true;
            this.txtsetwiegh.Size = new System.Drawing.Size(161, 26);
            this.txtsetwiegh.TabIndex = 5;
            this.txtsetwiegh.TextChanged += new System.EventHandler(this.txtsetwiegh_TextChanged);
            // 
            // btnadd
            // 
            this.btnadd.ActiveBorderThickness = 1;
            this.btnadd.ActiveCornerRadius = 20;
            this.btnadd.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnadd.ActiveForecolor = System.Drawing.Color.White;
            this.btnadd.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnadd.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnadd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnadd.BackgroundImage")));
            this.btnadd.ButtonText = "ADD";
            this.btnadd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnadd.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnadd.IdleBorderThickness = 1;
            this.btnadd.IdleCornerRadius = 20;
            this.btnadd.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnadd.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnadd.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnadd.Location = new System.Drawing.Point(199, 382);
            this.btnadd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(156, 59);
            this.btnadd.TabIndex = 6;
            this.btnadd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label1.Location = new System.Drawing.Point(21, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "title :";
            // 
            // txttitle
            // 
            this.txttitle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txttitle.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttitle.ForeColor = System.Drawing.Color.ForestGreen;
            this.txttitle.Location = new System.Drawing.Point(199, 165);
            this.txttitle.Name = "txttitle";
            this.txttitle.Size = new System.Drawing.Size(161, 26);
            this.txttitle.TabIndex = 8;
            // 
            // txtyear
            // 
            this.txtyear.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtyear.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtyear.ForeColor = System.Drawing.Color.ForestGreen;
            this.txtyear.Location = new System.Drawing.Point(199, 212);
            this.txtyear.Name = "txtyear";
            this.txtyear.Size = new System.Drawing.Size(59, 26);
            this.txtyear.TabIndex = 10;
            this.txtyear.Text = "yy";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label2.Location = new System.Drawing.Point(21, 212);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 24);
            this.label2.TabIndex = 9;
            this.label2.Text = "Date :";
            // 
            // txtorigin
            // 
            this.txtorigin.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtorigin.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtorigin.ForeColor = System.Drawing.Color.ForestGreen;
            this.txtorigin.Location = new System.Drawing.Point(199, 255);
            this.txtorigin.Name = "txtorigin";
            this.txtorigin.Size = new System.Drawing.Size(161, 26);
            this.txtorigin.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label3.Location = new System.Drawing.Point(21, 257);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 24);
            this.label3.TabIndex = 11;
            this.label3.Text = "Origin :";
            // 
            // txtdestination
            // 
            this.txtdestination.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtdestination.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdestination.ForeColor = System.Drawing.Color.ForestGreen;
            this.txtdestination.Location = new System.Drawing.Point(199, 300);
            this.txtdestination.Name = "txtdestination";
            this.txtdestination.Size = new System.Drawing.Size(161, 26);
            this.txtdestination.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label4.Location = new System.Drawing.Point(21, 302);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 24);
            this.label4.TabIndex = 13;
            this.label4.Text = "Destination :";
            // 
            // txtcode
            // 
            this.txtcode.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtcode.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcode.ForeColor = System.Drawing.Color.ForestGreen;
            this.txtcode.Location = new System.Drawing.Point(199, 345);
            this.txtcode.Name = "txtcode";
            this.txtcode.Size = new System.Drawing.Size(161, 26);
            this.txtcode.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label5.Location = new System.Drawing.Point(21, 347);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 24);
            this.label5.TabIndex = 15;
            this.label5.Text = "code :";
            // 
            // txtmonth
            // 
            this.txtmonth.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtmonth.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmonth.ForeColor = System.Drawing.Color.ForestGreen;
            this.txtmonth.Location = new System.Drawing.Point(275, 212);
            this.txtmonth.Name = "txtmonth";
            this.txtmonth.Size = new System.Drawing.Size(34, 26);
            this.txtmonth.TabIndex = 17;
            this.txtmonth.Text = "mm";
            // 
            // txtday
            // 
            this.txtday.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtday.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtday.ForeColor = System.Drawing.Color.ForestGreen;
            this.txtday.Location = new System.Drawing.Point(326, 212);
            this.txtday.Name = "txtday";
            this.txtday.Size = new System.Drawing.Size(34, 26);
            this.txtday.TabIndex = 18;
            this.txtday.Text = "dd";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label7.Location = new System.Drawing.Point(259, 214);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(16, 24);
            this.label7.TabIndex = 20;
            this.label7.Text = "/";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label8.Location = new System.Drawing.Point(310, 213);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(16, 24);
            this.label8.TabIndex = 21;
            this.label8.Text = "/";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(400, 80);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(824, 291);
            this.dataGridView1.TabIndex = 22;
            // 
            // btntare
            // 
            this.btntare.ActiveBorderThickness = 1;
            this.btntare.ActiveCornerRadius = 20;
            this.btntare.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btntare.ActiveForecolor = System.Drawing.Color.White;
            this.btntare.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btntare.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btntare.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btntare.BackgroundImage")));
            this.btntare.ButtonText = "Tare";
            this.btntare.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btntare.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntare.ForeColor = System.Drawing.Color.SeaGreen;
            this.btntare.IdleBorderThickness = 1;
            this.btntare.IdleCornerRadius = 20;
            this.btntare.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btntare.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btntare.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btntare.Location = new System.Drawing.Point(400, 382);
            this.btntare.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btntare.Name = "btntare";
            this.btntare.Size = new System.Drawing.Size(156, 59);
            this.btntare.TabIndex = 23;
            this.btntare.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btntare.Click += new System.EventHandler(this.btntare_Click);
            // 
            // btnzero
            // 
            this.btnzero.ActiveBorderThickness = 1;
            this.btnzero.ActiveCornerRadius = 20;
            this.btnzero.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnzero.ActiveForecolor = System.Drawing.Color.White;
            this.btnzero.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnzero.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnzero.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnzero.BackgroundImage")));
            this.btnzero.ButtonText = "Zero";
            this.btnzero.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnzero.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnzero.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnzero.IdleBorderThickness = 1;
            this.btnzero.IdleCornerRadius = 20;
            this.btnzero.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnzero.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnzero.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnzero.Location = new System.Drawing.Point(564, 382);
            this.btnzero.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnzero.Name = "btnzero";
            this.btnzero.Size = new System.Drawing.Size(156, 59);
            this.btnzero.TabIndex = 24;
            this.btnzero.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnzero.Click += new System.EventHandler(this.btnzero_Click);
            // 
            // btnsetoption
            // 
            this.btnsetoption.ActiveBorderThickness = 1;
            this.btnsetoption.ActiveCornerRadius = 20;
            this.btnsetoption.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnsetoption.ActiveForecolor = System.Drawing.Color.White;
            this.btnsetoption.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnsetoption.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnsetoption.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnsetoption.BackgroundImage")));
            this.btnsetoption.ButtonText = "option";
            this.btnsetoption.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsetoption.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsetoption.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnsetoption.IdleBorderThickness = 1;
            this.btnsetoption.IdleCornerRadius = 20;
            this.btnsetoption.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnsetoption.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnsetoption.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnsetoption.Location = new System.Drawing.Point(728, 382);
            this.btnsetoption.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnsetoption.Name = "btnsetoption";
            this.btnsetoption.Size = new System.Drawing.Size(156, 59);
            this.btnsetoption.TabIndex = 25;
            this.btnsetoption.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnsetoption.Click += new System.EventHandler(this.btnsetoption_Click);
            // 
            // btnconnection
            // 
            this.btnconnection.ActiveBorderThickness = 1;
            this.btnconnection.ActiveCornerRadius = 20;
            this.btnconnection.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnconnection.ActiveForecolor = System.Drawing.Color.White;
            this.btnconnection.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnconnection.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnconnection.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnconnection.BackgroundImage")));
            this.btnconnection.ButtonText = "connected";
            this.btnconnection.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnconnection.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnconnection.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnconnection.IdleBorderThickness = 1;
            this.btnconnection.IdleCornerRadius = 20;
            this.btnconnection.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnconnection.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnconnection.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnconnection.Location = new System.Drawing.Point(400, 11);
            this.btnconnection.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnconnection.Name = "btnconnection";
            this.btnconnection.Size = new System.Drawing.Size(824, 59);
            this.btnconnection.TabIndex = 26;
            this.btnconnection.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnconnection.Click += new System.EventHandler(this.btnconnection_Click);
            // 
            // btnexit
            // 
            this.btnexit.ActiveBorderThickness = 1;
            this.btnexit.ActiveCornerRadius = 20;
            this.btnexit.ActiveFillColor = System.Drawing.Color.Pink;
            this.btnexit.ActiveForecolor = System.Drawing.Color.White;
            this.btnexit.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnexit.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnexit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnexit.BackgroundImage")));
            this.btnexit.ButtonText = "e&xit";
            this.btnexit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnexit.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexit.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnexit.IdleBorderThickness = 1;
            this.btnexit.IdleCornerRadius = 20;
            this.btnexit.IdleFillColor = System.Drawing.Color.Red;
            this.btnexit.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnexit.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnexit.Location = new System.Drawing.Point(1138, 379);
            this.btnexit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(81, 59);
            this.btnexit.TabIndex = 27;
            this.btnexit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Gill Sans Ultra Bold Condensed", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(16, 392);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 49);
            this.label6.TabIndex = 28;
            this.label6.Text = "cadino";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1232, 455);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnconnection);
            this.Controls.Add(this.btnsetoption);
            this.Controls.Add(this.btnzero);
            this.Controls.Add(this.btntare);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtday);
            this.Controls.Add(this.txtmonth);
            this.Controls.Add(this.txtcode);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtdestination);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtorigin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtyear);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txttitle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.txtsetwiegh);
            this.Controls.Add(this.btnset);
            this.Controls.Add(this.btnoffon);
            this.Controls.Add(this.txtshowdata);
            this.ForeColor = System.Drawing.SystemColors.MenuText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtshowdata;
        private System.IO.Ports.SerialPort serialPort1;
        private ns1.BunifuThinButton2 btnoffon;
        private ns1.BunifuThinButton2 btnset;
        private System.Windows.Forms.TextBox txtsetwiegh;
        private ns1.BunifuThinButton2 btnadd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txttitle;
        private System.Windows.Forms.TextBox txtyear;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtorigin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtdestination;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtcode;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtmonth;
        private System.Windows.Forms.TextBox txtday;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataGridView1;
        private ns1.BunifuThinButton2 btntare;
        private ns1.BunifuThinButton2 btnzero;
        private ns1.BunifuThinButton2 btnsetoption;
        private ns1.BunifuThinButton2 btnconnection;
        private ns1.BunifuThinButton2 btnexit;
        private System.Windows.Forms.Label label6;
    }
}

