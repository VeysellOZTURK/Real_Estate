using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using DataManager;
using static DataManager.DataManager;

namespace WindowsFormsApp1
{
    public partial class Form6 : Form
    {
        DataManager.DataManager dataManager;
        List<RealState> RealStateList;
        int type;
        public Form6(int type)
        {
            this.type = type;
     
            dataManager = new DataManager.DataManager(@"emlak.db", "emlak");
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            LoadCustom();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow item in dataGridView1.SelectedRows)
                {
                    var data = dataManager.Delete(RealStateList[item.Index]);
                    MessageBox.Show(data.ToString());
                }

            } else
            {
                MessageBox.Show(dataManager.Delete(RealStateList[dataGridView1.CurrentRow.Index]).ToString());
            }

            LoadCustom();
        }

        private void LoadCustom()
        {
            RealStateList = dataManager.Get<RealState>();


            if (this.type == 0)
            {
                this.Text = State.Kirlaik.ToString();
                RealStateList = RealStateList.FindAll(x => x.durum == State.Kirlaik);
            }
            else if (this.type == 1)
            {
                this.Text = State.Satılık.ToString();
                RealStateList = RealStateList.FindAll(x => x.durum == State.Satılık);
            }


            dataGridView1.DataSource = null;
            dataGridView1.DataSource = RealStateList;
        }
    }
}
