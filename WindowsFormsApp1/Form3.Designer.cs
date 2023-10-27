namespace WindowsFormsApp1
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.isim_soyisim = new System.Windows.Forms.TextBox();
            this.cep_tel = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.fiyat = new System.Windows.Forms.TextBox();
            this.isitma = new System.Windows.Forms.ComboBox();
            this.adres = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.kiralik = new System.Windows.Forms.RadioButton();
            this.label21 = new System.Windows.Forms.Label();
            this.satilik = new System.Windows.Forms.RadioButton();
            this.label22 = new System.Windows.Forms.Label();
            this.esyali = new System.Windows.Forms.ComboBox();
            this.label23 = new System.Windows.Forms.Label();
            this.aidat = new System.Windows.Forms.TextBox();
            this.ilan_no = new System.Windows.Forms.TextBox();
            this.balkon = new System.Windows.Forms.TextBox();
            this.kategori = new System.Windows.Forms.TextBox();
            this.m2 = new System.Windows.Forms.TextBox();
            this.oda_sayisi = new System.Windows.Forms.TextBox();
            this.bina_yasi = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pictureBox1.Location = new System.Drawing.Point(9, 11);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(226, 175);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button1.Location = new System.Drawing.Point(12, 195);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(222, 22);
            this.button1.TabIndex = 2;
            this.button1.Text = "Resim Seç";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Segoe UI Symbol", 8.5F);
            this.label13.Location = new System.Drawing.Point(5, 54);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(60, 15);
            this.label13.TabIndex = 32;
            this.label13.Text = "Ad Soyad:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Segoe UI Symbol", 8.5F);
            this.label14.Location = new System.Drawing.Point(5, 90);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(81, 15);
            this.label14.TabIndex = 33;
            this.label14.Text = "Cep Telefonu:";
            // 
            // isim_soyisim
            // 
            this.isim_soyisim.Location = new System.Drawing.Point(97, 49);
            this.isim_soyisim.Margin = new System.Windows.Forms.Padding(2);
            this.isim_soyisim.Name = "isim_soyisim";
            this.isim_soyisim.Size = new System.Drawing.Size(106, 25);
            this.isim_soyisim.TabIndex = 34;
            // 
            // cep_tel
            // 
            this.cep_tel.Location = new System.Drawing.Point(97, 84);
            this.cep_tel.Margin = new System.Windows.Forms.Padding(2);
            this.cep_tel.Name = "cep_tel";
            this.cep_tel.Size = new System.Drawing.Size(106, 25);
            this.cep_tel.TabIndex = 35;
            this.cep_tel.Text = "+90 (5xx) xxx xx xx";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button2.Location = new System.Drawing.Point(12, 221);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(60, 34);
            this.button2.TabIndex = 37;
            this.button2.Text = "Ekle";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button3.Location = new System.Drawing.Point(176, 221);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(58, 34);
            this.button3.TabIndex = 38;
            this.button3.Text = "Kaldır";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.cep_tel);
            this.groupBox1.Controls.Add(this.isim_soyisim);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(12, 277);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(222, 152);
            this.groupBox1.TabIndex = 41;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mülk Sahibi İletişim Bilgileri:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox2.Image = global::WindowsFormsApp1.Properties.Resources.white_phone_icon_png__clipart_best_30;
            this.pictureBox2.Location = new System.Drawing.Point(185, 120);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(31, 26);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 31;
            this.pictureBox2.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.DarkGray;
            this.groupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.fiyat);
            this.groupBox2.Controls.Add(this.isitma);
            this.groupBox2.Controls.Add(this.adres);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.label24);
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Controls.Add(this.kiralik);
            this.groupBox2.Controls.Add(this.label21);
            this.groupBox2.Controls.Add(this.satilik);
            this.groupBox2.Controls.Add(this.label22);
            this.groupBox2.Controls.Add(this.esyali);
            this.groupBox2.Controls.Add(this.label23);
            this.groupBox2.Controls.Add(this.aidat);
            this.groupBox2.Controls.Add(this.ilan_no);
            this.groupBox2.Controls.Add(this.balkon);
            this.groupBox2.Controls.Add(this.kategori);
            this.groupBox2.Controls.Add(this.m2);
            this.groupBox2.Controls.Add(this.oda_sayisi);
            this.groupBox2.Controls.Add(this.bina_yasi);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(240, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(275, 465);
            this.groupBox2.TabIndex = 36;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "İlan Bilgileri";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 419);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 17);
            this.label1.TabIndex = 33;
            this.label1.Text = "Fiyat:";
            // 
            // fiyat
            // 
            this.fiyat.Location = new System.Drawing.Point(86, 416);
            this.fiyat.Name = "fiyat";
            this.fiyat.Size = new System.Drawing.Size(175, 25);
            this.fiyat.TabIndex = 32;
            // 
            // isitma
            // 
            this.isitma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.isitma.FormattingEnabled = true;
            this.isitma.Items.AddRange(new object[] {
            "Yok",
            "Doğalgaz",
            "Sobalı"});
            this.isitma.Location = new System.Drawing.Point(86, 202);
            this.isitma.Name = "isitma";
            this.isitma.Size = new System.Drawing.Size(93, 25);
            this.isitma.TabIndex = 31;
            // 
            // adres
            // 
            this.adres.Location = new System.Drawing.Point(86, 318);
            this.adres.Margin = new System.Windows.Forms.Padding(2);
            this.adres.Multiline = true;
            this.adres.Name = "adres";
            this.adres.Size = new System.Drawing.Size(175, 93);
            this.adres.TabIndex = 30;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(11, 21);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 17);
            this.label12.TabIndex = 3;
            this.label12.Text = "İlan No:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(11, 55);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(61, 17);
            this.label15.TabIndex = 4;
            this.label15.Text = "Kategori:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(11, 93);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(70, 17);
            this.label16.TabIndex = 5;
            this.label16.Text = "Emlak Tipi:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(11, 119);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(29, 17);
            this.label17.TabIndex = 6;
            this.label17.Text = "m2:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(11, 148);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(61, 17);
            this.label18.TabIndex = 7;
            this.label18.Text = "Bina Yaşı:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(11, 177);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(72, 17);
            this.label19.TabIndex = 8;
            this.label19.Text = "Oda Sayısı:";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(11, 321);
            this.label24.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(45, 17);
            this.label24.TabIndex = 29;
            this.label24.Text = "Adres:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(11, 205);
            this.label20.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(45, 17);
            this.label20.TabIndex = 11;
            this.label20.Text = "Isıtma:";
            // 
            // kiralik
            // 
            this.kiralik.AutoSize = true;
            this.kiralik.Location = new System.Drawing.Point(160, 91);
            this.kiralik.Margin = new System.Windows.Forms.Padding(2);
            this.kiralik.Name = "kiralik";
            this.kiralik.Size = new System.Drawing.Size(61, 21);
            this.kiralik.TabIndex = 28;
            this.kiralik.TabStop = true;
            this.kiralik.Text = "Kiralık";
            this.kiralik.UseVisualStyleBackColor = true;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(11, 234);
            this.label21.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(49, 17);
            this.label21.TabIndex = 12;
            this.label21.Text = "Balkon:";
            this.label21.Click += new System.EventHandler(this.label8_Click);
            // 
            // satilik
            // 
            this.satilik.AutoSize = true;
            this.satilik.Location = new System.Drawing.Point(87, 91);
            this.satilik.Margin = new System.Windows.Forms.Padding(2);
            this.satilik.Name = "satilik";
            this.satilik.Size = new System.Drawing.Size(59, 21);
            this.satilik.TabIndex = 27;
            this.satilik.TabStop = true;
            this.satilik.Text = "Satılık";
            this.satilik.UseVisualStyleBackColor = true;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(11, 263);
            this.label22.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(43, 17);
            this.label22.TabIndex = 13;
            this.label22.Text = "Eşyalı:";
            // 
            // esyali
            // 
            this.esyali.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.esyali.FormattingEnabled = true;
            this.esyali.Items.AddRange(new object[] {
            "Evet",
            "Hayır"});
            this.esyali.Location = new System.Drawing.Point(87, 260);
            this.esyali.Margin = new System.Windows.Forms.Padding(2);
            this.esyali.Name = "esyali";
            this.esyali.Size = new System.Drawing.Size(92, 25);
            this.esyali.TabIndex = 26;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(11, 292);
            this.label23.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(41, 17);
            this.label23.TabIndex = 14;
            this.label23.Text = "Aidat:";
            // 
            // aidat
            // 
            this.aidat.Location = new System.Drawing.Point(87, 289);
            this.aidat.Margin = new System.Windows.Forms.Padding(2);
            this.aidat.Name = "aidat";
            this.aidat.Size = new System.Drawing.Size(92, 25);
            this.aidat.TabIndex = 23;
            // 
            // ilan_no
            // 
            this.ilan_no.Location = new System.Drawing.Point(87, 18);
            this.ilan_no.Margin = new System.Windows.Forms.Padding(2);
            this.ilan_no.Name = "ilan_no";
            this.ilan_no.Size = new System.Drawing.Size(92, 25);
            this.ilan_no.TabIndex = 15;
            // 
            // balkon
            // 
            this.balkon.Location = new System.Drawing.Point(87, 231);
            this.balkon.Margin = new System.Windows.Forms.Padding(2);
            this.balkon.Name = "balkon";
            this.balkon.Size = new System.Drawing.Size(92, 25);
            this.balkon.TabIndex = 21;
            // 
            // kategori
            // 
            this.kategori.Location = new System.Drawing.Point(87, 52);
            this.kategori.Margin = new System.Windows.Forms.Padding(2);
            this.kategori.Name = "kategori";
            this.kategori.Size = new System.Drawing.Size(92, 25);
            this.kategori.TabIndex = 16;
            // 
            // m2
            // 
            this.m2.Location = new System.Drawing.Point(87, 116);
            this.m2.Margin = new System.Windows.Forms.Padding(2);
            this.m2.Name = "m2";
            this.m2.Size = new System.Drawing.Size(92, 25);
            this.m2.TabIndex = 17;
            // 
            // oda_sayisi
            // 
            this.oda_sayisi.Location = new System.Drawing.Point(87, 174);
            this.oda_sayisi.Margin = new System.Windows.Forms.Padding(2);
            this.oda_sayisi.Name = "oda_sayisi";
            this.oda_sayisi.Size = new System.Drawing.Size(92, 25);
            this.oda_sayisi.TabIndex = 19;
            // 
            // bina_yasi
            // 
            this.bina_yasi.Location = new System.Drawing.Point(87, 145);
            this.bina_yasi.Margin = new System.Windows.Forms.Padding(2);
            this.bina_yasi.Name = "bina_yasi";
            this.bina_yasi.Size = new System.Drawing.Size(92, 25);
            this.bina_yasi.TabIndex = 18;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button6.Location = new System.Drawing.Point(910, 526);
            this.button6.Margin = new System.Windows.Forms.Padding(2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(67, 33);
            this.button6.TabIndex = 39;
            this.button6.Text = "Kaydet";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button7.Location = new System.Drawing.Point(981, 526);
            this.button7.Margin = new System.Windows.Forms.Padding(2);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(65, 33);
            this.button7.TabIndex = 40;
            this.button7.Text = "Kaldır";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Sitka Text", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 21;
            this.listBox1.Location = new System.Drawing.Point(521, 11);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(524, 466);
            this.listBox1.TabIndex = 31;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(749, 483);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 42;
            this.button4.Text = "Önizleme";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources._245;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1057, 570);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form3";
            this.Text = "Yeni İlan Ekle";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox isim_soyisim;
        private System.Windows.Forms.TextBox cep_tel;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox adres;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.RadioButton kiralik;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.RadioButton satilik;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.ComboBox esyali;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox aidat;
        private System.Windows.Forms.TextBox ilan_no;
        private System.Windows.Forms.TextBox balkon;
        private System.Windows.Forms.TextBox kategori;
        private System.Windows.Forms.TextBox m2;
        private System.Windows.Forms.TextBox oda_sayisi;
        private System.Windows.Forms.TextBox bina_yasi;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ComboBox isitma;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox fiyat;
    }
}