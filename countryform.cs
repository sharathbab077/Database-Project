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
    public partial class countryform : Form
    {
        public countryform()
        {
            InitializeComponent();
        }

        private void home_Click(object sender, EventArgs e)
        {
            F2entity f2 = new F2entity();
            f2.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            countrydata f15 = new countrydata();
            f15.Show();
        }

        private void countryadd_Click(object sender, EventArgs e)
        {
            countryadd f27 = new countryadd();
            f27.Show();
            this.Hide();
        }

        private void countryupdate_Click(object sender, EventArgs e)
        {
            countryupdates f29 = new countryupdates();
            f29.Show();
            this.Hide();
        }
    }
}
