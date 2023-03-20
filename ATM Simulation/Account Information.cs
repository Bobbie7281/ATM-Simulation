using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM_Simulation
{
    public partial class Account_Information : Form
    {
        public Account_Information()
        {
            InitializeComponent();
        }

        public void Account_Information_Load(AtmDataBase obj)
        {
            DataTable dt = obj.GetLastFiveTransactions();
            Dgv_Account_Info.DataSource = dt;
        }

        private void Account_Information_Load(object sender, EventArgs e)
        {

        }
    }
}
