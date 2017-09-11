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
    public partial class recordview : Form
    {
        public recordview()
        {
            InitializeComponent();
        }

        private void recordview_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'oLYMPICS_DBDataSet3.Records' table. You can move, or remove it, as needed.
            this.recordsTableAdapter.Fill(this.oLYMPICS_DBDataSet3.Records);

        }
    }
}
