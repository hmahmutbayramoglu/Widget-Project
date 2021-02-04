namespace Masaüstü_Uygulaması
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_antalya = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btn_ankara = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btn_kocaeli = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btn_izmir = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btn_adana = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btn_istanbul = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuImageButton3 = new Bunifu.Framework.UI.BunifuImageButton();
            this.label6 = new System.Windows.Forms.Label();
            this.bunifuCheckbox1 = new Bunifu.Framework.UI.BunifuCheckbox();
            this.bunifuGradientPanel3 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.bunifuTransition1 = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.bunifuGradientPanel2 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker3 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker4 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker5 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker6 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).BeginInit();
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.bunifuGradientPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 20;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.bunifuImageButton1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(3, 3);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(20, 20);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 1;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // bunifuImageButton2
            // 
            this.bunifuImageButton2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.bunifuImageButton2, BunifuAnimatorNS.DecorationType.None);
            this.bunifuImageButton2.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton2.Image")));
            this.bunifuImageButton2.ImageActive = null;
            this.bunifuImageButton2.Location = new System.Drawing.Point(26, 3);
            this.bunifuImageButton2.Name = "bunifuImageButton2";
            this.bunifuImageButton2.Size = new System.Drawing.Size(20, 20);
            this.bunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton2.TabIndex = 2;
            this.bunifuImageButton2.TabStop = false;
            this.bunifuImageButton2.Zoom = 10;
            this.bunifuImageButton2.Click += new System.EventHandler(this.bunifuImageButton2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(96, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 26);
            this.label1.TabIndex = 3;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.label2, BunifuAnimatorNS.DecorationType.None);
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(85, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.label3, BunifuAnimatorNS.DecorationType.None);
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(135, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.label4, BunifuAnimatorNS.DecorationType.None);
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(183, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 19);
            this.label4.TabIndex = 8;
            this.label4.Text = "label4";
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.bunifuGradientPanel2);
            this.bunifuGradientPanel1.Controls.Add(this.bunifuImageButton3);
            this.bunifuGradientPanel1.Controls.Add(this.label6);
            this.bunifuGradientPanel1.Controls.Add(this.bunifuCheckbox1);
            this.bunifuGradientPanel1.Controls.Add(this.bunifuGradientPanel3);
            this.bunifuGradientPanel1.Controls.Add(this.pictureBox1);
            this.bunifuGradientPanel1.Controls.Add(this.label5);
            this.bunifuGradientPanel1.Controls.Add(this.bunifuImageButton1);
            this.bunifuGradientPanel1.Controls.Add(this.label4);
            this.bunifuGradientPanel1.Controls.Add(this.bunifuImageButton2);
            this.bunifuGradientPanel1.Controls.Add(this.label3);
            this.bunifuGradientPanel1.Controls.Add(this.label1);
            this.bunifuGradientPanel1.Controls.Add(this.label2);
            this.bunifuTransition1.SetDecoration(this.bunifuGradientPanel1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(68)))));
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(-1, -1);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(460, 400);
            this.bunifuGradientPanel1.TabIndex = 9;
            this.bunifuGradientPanel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.bunifuGradientPanel1_MouseDown);
            this.bunifuGradientPanel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.bunifuGradientPanel1_MouseMove);
            this.bunifuGradientPanel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.bunifuGradientPanel1_MouseUp);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.label7, BunifuAnimatorNS.DecorationType.None);
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(13, 91);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 19);
            this.label7.TabIndex = 25;
            this.label7.Text = "label7";
            this.label7.Visible = false;
            // 
            // btn_antalya
            // 
            this.btn_antalya.ActiveBorderThickness = 1;
            this.btn_antalya.ActiveCornerRadius = 20;
            this.btn_antalya.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(35)))), ((int)(((byte)(54)))));
            this.btn_antalya.ActiveForecolor = System.Drawing.Color.White;
            this.btn_antalya.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(35)))), ((int)(((byte)(54)))));
            this.btn_antalya.BackColor = System.Drawing.Color.Transparent;
            this.btn_antalya.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_antalya.BackgroundImage")));
            this.btn_antalya.ButtonText = "Antalya";
            this.btn_antalya.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.btn_antalya, BunifuAnimatorNS.DecorationType.None);
            this.btn_antalya.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_antalya.ForeColor = System.Drawing.Color.DarkGray;
            this.btn_antalya.IdleBorderThickness = 1;
            this.btn_antalya.IdleCornerRadius = 20;
            this.btn_antalya.IdleFillColor = System.Drawing.Color.Transparent;
            this.btn_antalya.IdleForecolor = System.Drawing.Color.White;
            this.btn_antalya.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(53)))), ((int)(((byte)(81)))));
            this.btn_antalya.Location = new System.Drawing.Point(260, 61);
            this.btn_antalya.Margin = new System.Windows.Forms.Padding(5);
            this.btn_antalya.Name = "btn_antalya";
            this.btn_antalya.Size = new System.Drawing.Size(106, 31);
            this.btn_antalya.TabIndex = 24;
            this.btn_antalya.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_antalya.Click += new System.EventHandler(this.btn_antalya_Click);
            // 
            // btn_ankara
            // 
            this.btn_ankara.ActiveBorderThickness = 1;
            this.btn_ankara.ActiveCornerRadius = 20;
            this.btn_ankara.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(35)))), ((int)(((byte)(54)))));
            this.btn_ankara.ActiveForecolor = System.Drawing.Color.White;
            this.btn_ankara.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(35)))), ((int)(((byte)(54)))));
            this.btn_ankara.BackColor = System.Drawing.Color.Transparent;
            this.btn_ankara.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_ankara.BackgroundImage")));
            this.btn_ankara.ButtonText = "Ankara";
            this.btn_ankara.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.btn_ankara, BunifuAnimatorNS.DecorationType.None);
            this.btn_ankara.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ankara.ForeColor = System.Drawing.Color.DarkGray;
            this.btn_ankara.IdleBorderThickness = 1;
            this.btn_ankara.IdleCornerRadius = 20;
            this.btn_ankara.IdleFillColor = System.Drawing.Color.Transparent;
            this.btn_ankara.IdleForecolor = System.Drawing.Color.White;
            this.btn_ankara.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(53)))), ((int)(((byte)(81)))));
            this.btn_ankara.Location = new System.Drawing.Point(260, 26);
            this.btn_ankara.Margin = new System.Windows.Forms.Padding(5);
            this.btn_ankara.Name = "btn_ankara";
            this.btn_ankara.Size = new System.Drawing.Size(106, 31);
            this.btn_ankara.TabIndex = 20;
            this.btn_ankara.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_ankara.Click += new System.EventHandler(this.btn_ankara_Click);
            // 
            // btn_kocaeli
            // 
            this.btn_kocaeli.ActiveBorderThickness = 1;
            this.btn_kocaeli.ActiveCornerRadius = 20;
            this.btn_kocaeli.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(35)))), ((int)(((byte)(54)))));
            this.btn_kocaeli.ActiveForecolor = System.Drawing.Color.White;
            this.btn_kocaeli.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(35)))), ((int)(((byte)(54)))));
            this.btn_kocaeli.BackColor = System.Drawing.Color.Transparent;
            this.btn_kocaeli.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_kocaeli.BackgroundImage")));
            this.btn_kocaeli.ButtonText = "Kocaeli";
            this.btn_kocaeli.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.btn_kocaeli, BunifuAnimatorNS.DecorationType.None);
            this.btn_kocaeli.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_kocaeli.ForeColor = System.Drawing.Color.DarkGray;
            this.btn_kocaeli.IdleBorderThickness = 1;
            this.btn_kocaeli.IdleCornerRadius = 20;
            this.btn_kocaeli.IdleFillColor = System.Drawing.Color.Transparent;
            this.btn_kocaeli.IdleForecolor = System.Drawing.Color.White;
            this.btn_kocaeli.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(53)))), ((int)(((byte)(81)))));
            this.btn_kocaeli.Location = new System.Drawing.Point(146, 61);
            this.btn_kocaeli.Margin = new System.Windows.Forms.Padding(5);
            this.btn_kocaeli.Name = "btn_kocaeli";
            this.btn_kocaeli.Size = new System.Drawing.Size(104, 31);
            this.btn_kocaeli.TabIndex = 23;
            this.btn_kocaeli.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_kocaeli.Click += new System.EventHandler(this.btn_kocaeli_Click);
            // 
            // btn_izmir
            // 
            this.btn_izmir.ActiveBorderThickness = 1;
            this.btn_izmir.ActiveCornerRadius = 20;
            this.btn_izmir.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(35)))), ((int)(((byte)(54)))));
            this.btn_izmir.ActiveForecolor = System.Drawing.Color.White;
            this.btn_izmir.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(35)))), ((int)(((byte)(54)))));
            this.btn_izmir.BackColor = System.Drawing.Color.Transparent;
            this.btn_izmir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_izmir.BackgroundImage")));
            this.btn_izmir.ButtonText = "İzmir";
            this.btn_izmir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.btn_izmir, BunifuAnimatorNS.DecorationType.None);
            this.btn_izmir.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_izmir.ForeColor = System.Drawing.Color.DarkGray;
            this.btn_izmir.IdleBorderThickness = 1;
            this.btn_izmir.IdleCornerRadius = 20;
            this.btn_izmir.IdleFillColor = System.Drawing.Color.Transparent;
            this.btn_izmir.IdleForecolor = System.Drawing.Color.White;
            this.btn_izmir.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(53)))), ((int)(((byte)(81)))));
            this.btn_izmir.Location = new System.Drawing.Point(146, 26);
            this.btn_izmir.Margin = new System.Windows.Forms.Padding(5);
            this.btn_izmir.Name = "btn_izmir";
            this.btn_izmir.Size = new System.Drawing.Size(104, 31);
            this.btn_izmir.TabIndex = 19;
            this.btn_izmir.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_izmir.Click += new System.EventHandler(this.btn_izmir_Click);
            // 
            // btn_adana
            // 
            this.btn_adana.ActiveBorderThickness = 1;
            this.btn_adana.ActiveCornerRadius = 20;
            this.btn_adana.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(35)))), ((int)(((byte)(54)))));
            this.btn_adana.ActiveForecolor = System.Drawing.Color.White;
            this.btn_adana.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(35)))), ((int)(((byte)(54)))));
            this.btn_adana.BackColor = System.Drawing.Color.Transparent;
            this.btn_adana.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_adana.BackgroundImage")));
            this.btn_adana.ButtonText = "Adana";
            this.btn_adana.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.btn_adana, BunifuAnimatorNS.DecorationType.None);
            this.btn_adana.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_adana.ForeColor = System.Drawing.Color.DarkGray;
            this.btn_adana.IdleBorderThickness = 1;
            this.btn_adana.IdleCornerRadius = 20;
            this.btn_adana.IdleFillColor = System.Drawing.Color.Transparent;
            this.btn_adana.IdleForecolor = System.Drawing.Color.White;
            this.btn_adana.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(53)))), ((int)(((byte)(81)))));
            this.btn_adana.Location = new System.Drawing.Point(32, 61);
            this.btn_adana.Margin = new System.Windows.Forms.Padding(5);
            this.btn_adana.Name = "btn_adana";
            this.btn_adana.Size = new System.Drawing.Size(106, 31);
            this.btn_adana.TabIndex = 21;
            this.btn_adana.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_adana.Click += new System.EventHandler(this.btn_adana_Click);
            // 
            // btn_istanbul
            // 
            this.btn_istanbul.ActiveBorderThickness = 1;
            this.btn_istanbul.ActiveCornerRadius = 20;
            this.btn_istanbul.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(35)))), ((int)(((byte)(54)))));
            this.btn_istanbul.ActiveForecolor = System.Drawing.Color.White;
            this.btn_istanbul.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(35)))), ((int)(((byte)(54)))));
            this.btn_istanbul.BackColor = System.Drawing.Color.Transparent;
            this.btn_istanbul.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_istanbul.BackgroundImage")));
            this.btn_istanbul.ButtonText = "İstanbul";
            this.btn_istanbul.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.btn_istanbul, BunifuAnimatorNS.DecorationType.None);
            this.btn_istanbul.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_istanbul.ForeColor = System.Drawing.Color.DarkGray;
            this.btn_istanbul.IdleBorderThickness = 1;
            this.btn_istanbul.IdleCornerRadius = 20;
            this.btn_istanbul.IdleFillColor = System.Drawing.Color.Transparent;
            this.btn_istanbul.IdleForecolor = System.Drawing.Color.White;
            this.btn_istanbul.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(53)))), ((int)(((byte)(81)))));
            this.btn_istanbul.Location = new System.Drawing.Point(30, 26);
            this.btn_istanbul.Margin = new System.Windows.Forms.Padding(5);
            this.btn_istanbul.Name = "btn_istanbul";
            this.btn_istanbul.Size = new System.Drawing.Size(106, 31);
            this.btn_istanbul.TabIndex = 18;
            this.btn_istanbul.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_istanbul.Click += new System.EventHandler(this.btn_istanbul_Click);
            // 
            // bunifuImageButton3
            // 
            this.bunifuImageButton3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.bunifuImageButton3, BunifuAnimatorNS.DecorationType.None);
            this.bunifuImageButton3.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton3.Image")));
            this.bunifuImageButton3.ImageActive = null;
            this.bunifuImageButton3.Location = new System.Drawing.Point(176, 141);
            this.bunifuImageButton3.Name = "bunifuImageButton3";
            this.bunifuImageButton3.Size = new System.Drawing.Size(34, 26);
            this.bunifuImageButton3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton3.TabIndex = 17;
            this.bunifuImageButton3.TabStop = false;
            this.bunifuImageButton3.Zoom = 10;
            this.bunifuImageButton3.Click += new System.EventHandler(this.bunifuImageButton3_Click);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.bunifuTransition1.SetDecoration(this.label6, BunifuAnimatorNS.DecorationType.None);
            this.label6.Location = new System.Drawing.Point(364, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 1);
            this.label6.TabIndex = 15;
            this.label6.Text = "label6";
            // 
            // bunifuCheckbox1
            // 
            this.bunifuCheckbox1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCheckbox1.ChechedOffColor = System.Drawing.Color.Gray;
            this.bunifuCheckbox1.Checked = false;
            this.bunifuCheckbox1.CheckedOnColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.bunifuCheckbox1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCheckbox1.ForeColor = System.Drawing.Color.White;
            this.bunifuCheckbox1.Location = new System.Drawing.Point(364, 3);
            this.bunifuCheckbox1.Name = "bunifuCheckbox1";
            this.bunifuCheckbox1.Size = new System.Drawing.Size(20, 20);
            this.bunifuCheckbox1.TabIndex = 14;
            this.toolTip1.SetToolTip(this.bunifuCheckbox1, "Otomatik Başlat");
            this.bunifuCheckbox1.OnChange += new System.EventHandler(this.bunifuCheckbox1_OnChange);
            // 
            // bunifuGradientPanel3
            // 
            this.bunifuGradientPanel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel3.BackgroundImage")));
            this.bunifuGradientPanel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuTransition1.SetDecoration(this.bunifuGradientPanel3, BunifuAnimatorNS.DecorationType.None);
            this.bunifuGradientPanel3.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(120)))), ((int)(((byte)(206)))));
            this.bunifuGradientPanel3.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(120)))), ((int)(((byte)(206)))));
            this.bunifuGradientPanel3.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.bunifuGradientPanel3.GradientTopRight = System.Drawing.Color.White;
            this.bunifuGradientPanel3.Location = new System.Drawing.Point(101, 113);
            this.bunifuGradientPanel3.Name = "bunifuGradientPanel3";
            this.bunifuGradientPanel3.Quality = 10;
            this.bunifuGradientPanel3.Size = new System.Drawing.Size(200, 1);
            this.bunifuGradientPanel3.TabIndex = 13;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(287, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(43, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.label5, BunifuAnimatorNS.DecorationType.None);
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(83, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "İstanbul";
            // 
            // bunifuTransition1
            // 
            this.bunifuTransition1.AnimationType = BunifuAnimatorNS.AnimationType.Transparent;
            this.bunifuTransition1.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 1F;
            this.bunifuTransition1.DefaultAnimation = animation1;
            // 
            // bunifuGradientPanel2
            // 
            this.bunifuGradientPanel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel2.BackgroundImage")));
            this.bunifuGradientPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel2.Controls.Add(this.textBox1);
            this.bunifuGradientPanel2.Controls.Add(this.btn_izmir);
            this.bunifuGradientPanel2.Controls.Add(this.btn_istanbul);
            this.bunifuGradientPanel2.Controls.Add(this.label7);
            this.bunifuGradientPanel2.Controls.Add(this.btn_antalya);
            this.bunifuGradientPanel2.Controls.Add(this.btn_adana);
            this.bunifuGradientPanel2.Controls.Add(this.btn_ankara);
            this.bunifuGradientPanel2.Controls.Add(this.btn_kocaeli);
            this.bunifuTransition1.SetDecoration(this.bunifuGradientPanel2, BunifuAnimatorNS.DecorationType.None);
            this.bunifuGradientPanel2.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.bunifuGradientPanel2.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.bunifuGradientPanel2.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.bunifuGradientPanel2.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(68)))));
            this.bunifuGradientPanel2.Location = new System.Drawing.Point(0, 171);
            this.bunifuGradientPanel2.Name = "bunifuGradientPanel2";
            this.bunifuGradientPanel2.Quality = 10;
            this.bunifuGradientPanel2.Size = new System.Drawing.Size(586, 226);
            this.bunifuGradientPanel2.TabIndex = 26;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(30)))), ((int)(((byte)(36)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bunifuTransition1.SetDecoration(this.textBox1, BunifuAnimatorNS.DecorationType.None);
            this.textBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(37, 96);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(329, 103);
            this.textBox1.TabIndex = 27;
            this.toolTip1.SetToolTip(this.textBox1, "Tarihte Bugün");
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // backgroundWorker2
            // 
            this.backgroundWorker2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker2_DoWork);
            // 
            // backgroundWorker3
            // 
            this.backgroundWorker3.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker3_DoWork);
            // 
            // backgroundWorker4
            // 
            this.backgroundWorker4.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker4_DoWork);
            // 
            // backgroundWorker5
            // 
            this.backgroundWorker5.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker5_DoWork);
            // 
            // backgroundWorker6
            // 
            this.backgroundWorker6.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker6_DoWork);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(390, 380);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.bunifuTransition1.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Opacity = 0.8D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).EndInit();
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.bunifuGradientPanel2.ResumeLayout(false);
            this.bunifuGradientPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton2;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel3;
        private System.Windows.Forms.Label label6;
        private Bunifu.Framework.UI.BunifuCheckbox bunifuCheckbox1;
        public System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton3;
        public Bunifu.Framework.UI.BunifuThinButton2 btn_antalya;
        public Bunifu.Framework.UI.BunifuThinButton2 btn_ankara;
        public Bunifu.Framework.UI.BunifuThinButton2 btn_kocaeli;
        public Bunifu.Framework.UI.BunifuThinButton2 btn_izmir;
        public Bunifu.Framework.UI.BunifuThinButton2 btn_adana;
        public Bunifu.Framework.UI.BunifuThinButton2 btn_istanbul;
        private BunifuAnimatorNS.BunifuTransition bunifuTransition1;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.ComponentModel.BackgroundWorker backgroundWorker3;
        private System.ComponentModel.BackgroundWorker backgroundWorker4;
        private System.ComponentModel.BackgroundWorker backgroundWorker5;
        private System.ComponentModel.BackgroundWorker backgroundWorker6;
    }
}

