using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Model_First
{
    public partial class Form1 : Form
    {
        private Model1Container db;
        public Form1()
        {
            InitializeComponent();
            db = new Model1Container();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            db.Entity1Set.Load();
            dataGridView1.DataSource = db.Entity1Set.Local.ToBindingList();
           
        }
    }
}
