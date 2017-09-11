using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace OLYMPICS_DBMS
{
    public partial class addrec : Form
    {
        SqlConnection con = new SqlConnection("Data Source=NARASIMHA_PC;Initial Catalog=OLYMPICS_DB;Integrated Security=True");
        SqlCommand cmd;
        public addrec()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (reid.Text != "" & rwr.Text != "" & rwh.Text != "" & rwy.Text != "" & ror.Text != "" & roh.Text != "" & roy.Text != "")
            {
                con.Open();
                cmd = new SqlCommand("Insert into Records(eid,WR_rec,WR_name,Wyear,OR_rec,OR_name,Oyear) values('" + reid.Text + "','" + rwr.Text + "','" + rwh.Text + "','" + rwy.Text + "','" + ror.Text + "','" + roh.Text + "','" + roy.Text + "')", con);
                cmd.ExecuteNonQuery();
                cmd.Clone();
                this.Hide();
                MessageBox.Show("Insertion Successful!");
                records f46 = new records();
                f46.Show();
                con.Close();
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void addrec_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            records f51 = new records();
            f51.Show();
            this.Hide();
        }
    }
}
