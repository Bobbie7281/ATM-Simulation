using MySql.Data.MySqlClient;

namespace ATM_Simulation
{
    public partial class Frm_Main_Menu : Form
    {
        readonly Frm_Registration_Form registrationForm = new();
        readonly Frm_Atm atmForm = new();
        readonly Update_Information updateForm= new();
        public Frm_Main_Menu()
        {
            InitializeComponent();
        }
        private void Btn_Register_Click(object sender, EventArgs e)
        {
            registrationForm.ShowDialog();
        }

        private void Btn_Atm_Click(object sender, EventArgs e)
        {
            atmForm.ShowDialog();
        }

        private void Btn_Update_Click(object sender, EventArgs e)
        {
            updateForm.ShowDialog();
        }
    }
}
