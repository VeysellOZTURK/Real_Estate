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
    public partial class Form2 : Form
    {
        DataManager.DataManager dataManager;
        public Form2()
        {
            InitializeComponent();
            dataManager = new DataManager.DataManager(@"user.db", "user");
            LoadUsers();
        }

        private void LoadUsers()
        {
            List<DataManager.DataManager.User> ham = dataManager.Get<DataManager.DataManager.User>();
            dataGridView1.DataSource = ham;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var user = new DataManager.DataManager.User(username.Text, password.Text);
            dataManager.Set(user);
            LoadUsers();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var user = new DataManager.DataManager.User(username.Text, password.Text);
            dataManager.Delete(user);
            LoadUsers();
        }
    }
}
