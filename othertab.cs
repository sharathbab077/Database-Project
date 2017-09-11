using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OLYMPICS_DBMS
{
    public partial class othertab : Form
    {
        public othertab()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            F2entity f18 = new F2entity();
            f18.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            olyhistory f19 = new olyhistory();
            f19.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sponsor f20 = new sponsor();
            f20.Show();
        }
    }
}
