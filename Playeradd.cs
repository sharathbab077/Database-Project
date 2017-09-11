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
    public partial class Playeradd : Form
    {
        SqlConnection con = new SqlConnection("Data Source=NARASIMHA_PC;Initial Catalog=OLYMPICS_DB;Integrated Security=True");
        SqlCommand cmd;
        public Playeradd()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textpid.Text != "" & textpname.Text != "" & textpc.Text != "" & textpmed.Text != "" & textpeid.Text != "" & textpdob.Text != "" & textpage.Text != "")
            {
                con.Open();
                cmd = new SqlCommand("Insert into Players(p_id,p_name,p_country,p_medals,event_id,p_dob,age) values('" + textpid.Text + "','" + textpname.Text + "','" + textpc.Text + "','" + textpmed.Text + "','" + textpeid.Text + "','" + textpdob.Text + "','" + textpage.Text + "')", con);
               cmd.ExecuteNonQuery();
                cmd.Clone();
               this.Hide();
                MessageBox.Show("Insertion Successful!");
              playeroption f25 = new playeroption();
              f25.Show();
                con.Close();
            }
        }
        private void Playeradd_Load(object sender, EventArgs e)
        {
           // cmd.Connection = con;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            playeroption f59 = new playeroption();
            f59.Show();
            this.Hide();
        }

        private void textpid_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

       // private void pictureBox1_Click(object sender, EventArgs e)
        //{

        //}
    }
}
