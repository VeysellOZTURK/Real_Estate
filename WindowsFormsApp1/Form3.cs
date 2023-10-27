using System;
using System.Drawing;
using System.Windows.Forms;
using static DataManager.DataManager;


namespace WindowsFormsApp1
{
    public partial class Form3 : Form
    {
        DataManager.DataManager DataManager { get; set; }   
        public Form3()
        {
            DataManager = new DataManager.DataManager(@"emlak.db", "emlak");
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.Items.Add("Mülk Sahibi İletişim Bilgileri:");
            listBox1.Items.Add("Adı Soyadı: "+isim_soyisim.Text);
            listBox1.Items.Add("Cep Telefonu: " + cep_tel.Text);
            listBox1.Items.Add("----------------------------------------------");
            listBox1.Items.Add("İlan Bilgileri:");
            listBox1.Items.Add("İlan No: " + ilan_no.Text);
            listBox1.Items.Add("Kategori: " + kategori.Text);
            if (satilik.Checked == true)
            {
               listBox1.Items.Add("Emlak Tipi: Satılık");
                
            }
            else if (kiralik.Checked == true)
            {
                listBox1.Items.Add("Emlak Tipi: Kiralık");
            }
            listBox1.Items.Add("m2: " + m2.Text);
            listBox1.Items.Add("Bina Yaşı: " + bina_yasi.Text);
            listBox1.Items.Add("Oda Sayısı: " + oda_sayisi.Text);
            if(isitma.SelectedIndex == 0) 
            {
                listBox1.Items.Add("Isıtma: Yok");
            }
            else if (isitma.SelectedIndex == 1)
            {
                listBox1.Items.Add("Isıtma: Doğalgaz");
            }
            else if (isitma.SelectedIndex == 2)
            {
                listBox1.Items.Add("Isıtma: Sobalı");
            }
            listBox1.Items.Add("Balkon: " + balkon.Text);
            if (esyali.SelectedIndex == 0)
            {
                listBox1.Items.Add("Eşya Durumu: Eşyalı");
            }
            else if (esyali.SelectedIndex == 1)
            {
                listBox1.Items.Add("Eşya Durumu: Eşyasız");
            }
            listBox1.Items.Add("Aidat: " + aidat.Text);
            listBox1.Items.Add("Adres: " + adres.Text);
            listBox1.Items.Add("Fiyat:" + fiyat.Text);


        }

        private void button7_Click(object sender, EventArgs e)
        {

            isim_soyisim.Text = "";
            cep_tel.Text = "";
            ilan_no.Text = "";
            kategori.Text = "";
            m2.Text = "";
            bina_yasi.Text = "";
            oda_sayisi.Text = "";
            balkon.Text = "";
            aidat.Text = "";
            adres.Text = "";
            satilik.Checked = false;
            kiralik.Checked = false;
            isitma.SelectedIndex = -1;
            esyali.SelectedIndex = -1;
            listBox1.Items.Clear();
        }

        private void button6_Click(object sender, EventArgs e)
        {

            State durum = new State();
            if (satilik.Checked)
            {
                durum = State.Satılık;
            } else if (kiralik.Checked)
            {
                durum = State.Kirlaik;
            }

            try
            {
                RealState state = new RealState(ilan_no.Text, isim_soyisim.Text, kategori.Text, m2.Text, bina_yasi.Text, oda_sayisi.Text, balkon.Text, esyali.Text, aidat.Text, adres.Text, durum, isitma.Text, cep_tel.Text  );
                DataManager.Set(state);

                MessageBox.Show("İlan Başarıyla Eklendi.");
                this.Close();
            } catch(Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }

   
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // open file dialog   
            OpenFileDialog open = new OpenFileDialog();
            // image filters  
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                // display image in picture box  
                pictureBox1.Image = new Bitmap(open.FileName);
                
            }
        }
    }
}




