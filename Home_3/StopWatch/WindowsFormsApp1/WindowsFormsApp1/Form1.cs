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
            new WorkClass(this);
        }

        public event EventHandler Start;
        public event EventHandler Stop;
        public event EventHandler Reset;
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Start(sender, e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Stop(sender, e);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Reset(sender, e);
        }
    }
}
