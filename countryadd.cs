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
    public partial class countryadd : Form
    {
        SqlConnection con = new SqlConnection("Data Source=NARASIMHA_PC;Initial Catalog=OLYMPICS_DB;Integrated Security=True");
        SqlCommand cmd;
        public countryadd()
        {
            InitializeComponent();
        }

        private void countryadd_Load(object sender, EventArgs e)
        {

        }

        private void cdbadd_Click(object sender, EventArgs e)
        {
           
    
                if (textcid.Text != "" & textcname.Text != "" & textcplayer.Text != "" & textcpos.Text != "" & textcevents.Text != "")
                {
                    try
                    {
                        con.Open();
                        cmd = new SqlCommand("Insert into Country(c_id,c_name,no_of_players,c_position,no_of_events) values('" + textcid.Text + "','" + textcname.Text + "','" + textcplayer.Text + "','" + textcpos.Text + "','" + textcevents.Text + "')", con);
                        cmd.ExecuteNonQuery();
                        cmd.Clone();
                        this.Hide();
                        MessageBox.Show("Insertion Successful!");
                        countryform f26 = new countryform();
                        f26.Show();
                        con.Close();
                    }
                    catch
                    {
                        MessageBox.Show("Insertion Unsuccessful");
                    }
                }


     
              
        }

        private void button1_Click(object sender, EventArgs e)
        {
            countryform f57 = new countryform();
            f57.Show();
            this.Hide();
        }
    }
}
