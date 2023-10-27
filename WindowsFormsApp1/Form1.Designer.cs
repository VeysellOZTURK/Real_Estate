namespace WindowsFormsApp1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.kullanıcıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.satılıkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ilanlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.satılıkToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.kiralıkToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sahibindenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yapımcılarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kullanıcıToolStripMenuItem,
            this.satılıkToolStripMenuItem,
            this.ilanlarToolStripMenuItem,
            this.sahibindenToolStripMenuItem,
            this.yapımcılarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(673, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // kullanıcıToolStripMenuItem
            // 
            this.kullanıcıToolStripMenuItem.Name = "kullanıcıToolStripMenuItem";
            this.kullanıcıToolStripMenuItem.Size = new System.Drawing.Size(113, 20);
            this.kullanıcıToolStripMenuItem.Text = "Kullanıcıları Yönet";
            this.kullanıcıToolStripMenuItem.Click += new System.EventHandler(this.kullanıcıToolStripMenuItem_Click);
            // 
            // satılıkToolStripMenuItem
            // 
            this.satılıkToolStripMenuItem.Name = "satılıkToolStripMenuItem";
            this.satılıkToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.satılıkToolStripMenuItem.Text = "Ekle";
            this.satılıkToolStripMenuItem.Click += new System.EventHandler(this.satılıkToolStripMenuItem_Click);
            // 
            // ilanlarToolStripMenuItem
            // 
            this.ilanlarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.satılıkToolStripMenuItem2,
            this.kiralıkToolStripMenuItem1});
            this.ilanlarToolStripMenuItem.Name = "ilanlarToolStripMenuItem";
            this.ilanlarToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.ilanlarToolStripMenuItem.Text = "İlanlar";
            // 
            // satılıkToolStripMenuItem2
            // 
            this.satılıkToolStripMenuItem2.Name = "satılıkToolStripMenuItem2";
            this.satılıkToolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.satılıkToolStripMenuItem2.Text = "Satılık";
            this.satılıkToolStripMenuItem2.Click += new System.EventHandler(this.satılıkToolStripMenuItem2_Click);
            // 
            // kiralıkToolStripMenuItem1
            // 
            this.kiralıkToolStripMenuItem1.Name = "kiralıkToolStripMenuItem1";
            this.kiralıkToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.kiralıkToolStripMenuItem1.Text = "Kiralık";
            this.kiralıkToolStripMenuItem1.Click += new System.EventHandler(this.kiralıkToolStripMenuItem1_Click);
            // 
            // sahibindenToolStripMenuItem
            // 
            this.sahibindenToolStripMenuItem.Name = "sahibindenToolStripMenuItem";
            this.sahibindenToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.sahibindenToolStripMenuItem.Text = "Sahibinden";
            this.sahibindenToolStripMenuItem.Click += new System.EventHandler(this.sahibindenToolStripMenuItem_Click);
            // 
            // yapımcılarToolStripMenuItem
            // 
            this.yapımcılarToolStripMenuItem.Name = "yapımcılarToolStripMenuItem";
            this.yapımcılarToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.yapımcılarToolStripMenuItem.Text = "Yapımcılar";
            this.yapımcılarToolStripMenuItem.Click += new System.EventHandler(this.yapımcılarToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 344);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 10, 0);
            this.statusStrip1.Size = new System.Drawing.Size(673, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(214, 17);
            this.toolStripStatusLabel1.Text = "Copyright © 2022-2023 OzTuzun Emlak";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(0, 17);
            this.toolStripStatusLabel2.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.AutoSize = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(114, 168);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(438, 61);
            this.panel1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe Script", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(165, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(270, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "tesciline yardım edelim!";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(297, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bir yaşam alanı hayal edin, ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe Script", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(507, 308);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 27);
            this.label3.TabIndex = 3;
            this.label3.Text = "HOŞ GELDİNİZ...";
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.FDSFDSF7a;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(12, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(173, 104);
            this.button1.TabIndex = 4;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources._1802071;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(673, 366);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Emlak Takip Programı";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem kullanıcıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem satılıkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ilanlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem satılıkToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem kiralıkToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem yapımcılarToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripMenuItem sahibindenToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}

