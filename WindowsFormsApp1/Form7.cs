using DataManager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form7 : Form
    {
        DataManager.DataManager dataManager;
        List<DataManager.DataManager.User> users = new List<DataManager.DataManager.User>();
        public Form7()
        {
            dataManager = new DataManager.DataManager(@"user.db", "user");
            users = dataManager.Get<DataManager.DataManager.User>();
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (textBox1.Text.ToUpper() == "ADMIN" && textBox2.Text.ToUpper() == "ADMIN")
            {
                Form1 form1 = new Form1();
                form1.ShowDialog();
                Dispose();
            }
            else
            {
                if (users.Exists(x => x.username == textBox1.Text && x.password == textBox2.Text))
                {
                    Form1 form1 = new Form1();
                    form1.ShowDialog();
                    Dispose();
                }
                MessageBox.Show(textBox1.Text.ToUpper());
                //MessageBox.Show("Kullanıcı Adı veya Şifre hatalı,\nLütfen Tekrar Deneyiniz...");
            }
        }
    }
}
