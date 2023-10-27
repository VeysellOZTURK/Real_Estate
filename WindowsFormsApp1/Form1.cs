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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void ekleToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void satılıkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.ShowDialog();
        }

        private void yapımcılarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.ShowDialog();
        }

        private void sahibindenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.ShowDialog();
        }

        private void kullanıcıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com/search?q=mina+emlak+izmit&sxsrf=APwXEddzJ-0IctaX8CuyXH70-wLwbs_vpg%3A1681663491979&ei=AyY8ZLq0O7-Exc8PyJiTqAU&ved=0ahUKEwj6wcjY7K7-AhU_QvEDHUjMBFUQ4dUDCA8&uact=5&oq=mina+emlak+izmit&gs_lcp=Cgxnd3Mtd2l6LXNlcnAQAzICCCY6CggAEEcQ1gQQsAM6DgguEIAEEMcBEK8BEOoEOgUIABCABDoLCC4QgAQQxwEQrwE6BggAEBYQHjoICAAQFhAeEA86GQguEIAEEMcBEK8BEOoEENwEEN4EEOAEGAE6EAguEA0QgAQQxwEQrwEQ6gQ6GwguEA0QgAQQxwEQrwEQ6gQQ3AQQ3gQQ4AQYAUoECEEYAFDRBFj1EmDZFGgCcAF4AIABe4gBsAaSAQMwLjeYAQCgAQHIAQLAAQHaAQYIARABGBQ&sclient=gws-wiz-serp");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void satılıkToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6(1);
            form6.ShowDialog();
        }

        private void kiralıkToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6(0);
            form6.ShowDialog();
        }
    }
}
