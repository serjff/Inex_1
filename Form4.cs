using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Inex_1
{
    public partial class reg_log : Form
    {
        public reg_log()
        {
            InitializeComponent();
        }

        private void reg_log_Load(object sender, EventArgs e)
        {
            // connection object
            SQLiteConnection con = new SQLiteConnection(@"data source=D:\SQLite_base\enex_1.db");
            con.Open();
            // command object
            string query1 = "SELECT * FROM exp_operation";
            SQLiteCommand cmd1 = new SQLiteCommand(query1, con);
            // adapter
            // datatable
            DataTable dt1 = new DataTable();
            SQLiteDataAdapter adapter1 = new SQLiteDataAdapter(cmd1);
            adapter1.Fill(dt1);
            dataGridView1.DataSource = dt1;
            //----------------------------------------
            // command object
            string query2 = "SELECT * FROM inc_operation";
            SQLiteCommand cmd2 = new SQLiteCommand(query2, con);
            // adapter
            // datatable
            DataTable dt2 = new DataTable();
            SQLiteDataAdapter adapter2 = new SQLiteDataAdapter(cmd2);
            adapter2.Fill(dt2);
            dataGridView2.DataSource = dt2;

        }
    }
}
