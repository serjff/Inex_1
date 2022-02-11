using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inex_1
{
    public partial class Main_form : Form
    {
        public Main_form()
        {
            InitializeComponent();
        }

        private void expens_Click(object sender, EventArgs e)
        {
            expense_form newForm = new expense_form();
            newForm.Show();
        }

        private void income_Click(object sender, EventArgs e)
        {
            income_form newForm = new income_form();
            newForm.Show();
        }

        private void reports_Click(object sender, EventArgs e)
        {
            reg_log newForm = new reg_log();
            newForm.Show();
        }
    }
}
