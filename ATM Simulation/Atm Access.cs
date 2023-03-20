using MySql.Data.MySqlClient;
using System.Data;

namespace ATM_Simulation
{
    public partial class Frm_Atm : Form
    {
        readonly AtmDataBase atmdb = new();
        
        public Frm_Atm()
        {
            InitializeComponent();
        }

        private void Btn_Atm_Access_Click(object sender, EventArgs e)
        {
            if (Btn_Atm_Access.Text == "Id Verification" && Txt_Id_And_Pin.Text != "")
            {
                Btn_Atm_Access.Text = "Pin Verification";
                LblIdAndPin.Text = "Please insert your Pin: -";
                atmdb.Id = int.Parse(Txt_Id_And_Pin.Text);
                Txt_Id_And_Pin.Clear();
                Txt_Id_And_Pin.UseSystemPasswordChar = true;
            }
            else if (Btn_Atm_Access.Text == "Pin Verification" && Txt_Id_And_Pin.Text != "")
            {
                bool connection = atmdb.CheckConnection();
                bool verification;
                atmdb.PinNumber = int.Parse(Txt_Id_And_Pin.Text);

                if (connection)
                {
                    verification = atmdb.VerifyIdWithPinNumber(atmdb.Id, atmdb.PinNumber);
                    if (verification)
                    {
                        Lbl_Welcome_Message.Text += "- " + atmdb.CustomerName;
                        LblIdAndPin.Visible = false;
                        Btn_Atm_Access.Visible = false;
                        Btn_Current_Balance.Enabled = true;
                        Btn_Current_Balance.BackColor = Color.PaleGoldenrod;
                        Btn_Deposit.Enabled = true;
                        Btn_Deposit.BackColor = Color.PaleGoldenrod;
                        Btn_Last_Five_Transactions.Enabled = true;
                        Btn_Last_Five_Transactions.BackColor= Color.PaleGoldenrod;
                        Btn_Withdraw.Enabled = true;
                        Btn_Withdraw.BackColor = Color.PaleGoldenrod;
                        Txt_Id_And_Pin.Clear();
                        Txt_Id_And_Pin.UseSystemPasswordChar = false;
                    }
                    else
                    {
                        MessageBox.Show("Access Denied!! UserId or Pin Number is invalid!!", "Verification Result");
                        Txt_Id_And_Pin.Clear();
                        Btn_Atm_Access.Text = "Id Verification";
                        LblIdAndPin.Text = "Please Insert Your User ID: -";
                    }
                }
                else
                {
                    MessageBox.Show(atmdb.ConnectionException, "Connection Error!!");
                }

            }
        }
        private void Keypad_Click(object sender, EventArgs e)
        {
            Button btn = new();
            btn = (Button)sender;

            Txt_Id_And_Pin.Text += btn.Text;
        }
        private void Btn_exit_Click(object sender, EventArgs e)
        {
            atmdb.Id= 0;
            atmdb.PinNumber= 0;
            Btn_Atm_Access.Visible = true;
            Btn_Atm_Access.Text = "Id Verification";
            LblIdAndPin.Visible= true;
            LblIdAndPin.Text = "Please Insert Your User ID: -";
            Lbl_Welcome_Message.Text = "Welcome to FFB \r\nFuture First Bank\r\n";
            Btn_Deposit.Enabled = false;
            Btn_Deposit.BackColor = Color.LightGray;
            Btn_Withdraw.Enabled = false;
            Btn_Withdraw.BackColor = Color.LightGray;
            Btn_Last_Five_Transactions.Enabled = false;
            Btn_Last_Five_Transactions.BackColor= Color.LightGray;
            Btn_Current_Balance.Enabled = false;
            Btn_Current_Balance.BackColor= Color.LightGray;
            this.DialogResult = DialogResult.Abort;
            //this.Dispose();
        }
        private void Btn_Withdraw_Click(object sender, EventArgs e)
        {
            if (Txt_Id_And_Pin.Text == "")
            {
                MessageBox.Show("Please key in the amount of money you would like to withdraw.", "Amount of money not inserted");
                Txt_Id_And_Pin.Text = "";
            }
            else
            {
                if (Txt_Id_And_Pin.Text != "" && int.TryParse(Txt_Id_And_Pin.Text, out int result))
                {
                    if (atmdb.Withdrawal(int.Parse(Txt_Id_And_Pin.Text)))
                    {
                        MessageBox.Show("Withdrawal Successfull! You may collect your money.", "Withdrawal Success!");
                        Txt_Id_And_Pin.Text = "";

                        if (!atmdb.InsertTransactionRecord(false, true))
                        {
                            MessageBox.Show(atmdb.TransactionRecordException, "Transaction Record Error!!");
                            Txt_Id_And_Pin.Text = "";
                        }
                    }
                    else
                    {
                        MessageBox.Show(atmdb.WithdrawalException, "Withdrawal Error!!");
                        Txt_Id_And_Pin.Text = "";
                    }
                }
                else
                {
                    MessageBox.Show("Input not Correct. Please make sure you only input numbers.", "Wrong Input");
                    Txt_Id_And_Pin.Text = "";
                }
            }
        }
        private void Btn_Deposit_Click(object sender, EventArgs e)
        {
            if (Txt_Id_And_Pin.Text == "")
            {
                MessageBox.Show("Please key in the amount of money you would like to deposit.", "Amount of money not inserted");
                Txt_Id_And_Pin.Text = "";
            }
            else
            {
                if (Txt_Id_And_Pin.Text != "" && int.TryParse(Txt_Id_And_Pin.Text, out int result))
                {
                    if (atmdb.Deposit(int.Parse(Txt_Id_And_Pin.Text)))
                    {
                        MessageBox.Show("The amount of EUR " + atmdb.AmountDeposited + " was successfully deposited to your account.", "Deposit Successful.");
                        if (!atmdb.InsertTransactionRecord(true, false))
                        {
                            MessageBox.Show(atmdb.TransactionRecordException, "Transaction Record Error!!");
                            Txt_Id_And_Pin.Text = "";
                        }
                    }
                    else
                    {
                        MessageBox.Show(atmdb.DepositException, "Deposit Error!!");
                        Txt_Id_And_Pin.Text = "";
                    }
                }
                else
                {
                    MessageBox.Show("Input not Correct. Please make sure you only input numbers.", "Wrong Input");
                    Txt_Id_And_Pin.Text = "";
                }
            }
        }
        private void Txt_Id_And_Pin_TextChanged(object sender, EventArgs e)
        {
        }
        private void Frm_Atm_Click(object sender, EventArgs e)
        {

        }
        private void LblIdAndPin_Click(object sender, EventArgs e)
        {

        }
        private void Frm_Atm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                this.DialogResult = DialogResult.Cancel;
            }
        }
        private void Btn_Last_Five_Transactions_Click(object sender, EventArgs e)
        {
            Txt_Id_And_Pin.Text = "";
            Account_Information accInfo = new();

            accInfo.Account_Information_Load(atmdb);
            accInfo.ShowDialog();
        }
        private void Btn_Current_Balance_Click(object sender, EventArgs e)
        {
            if(atmdb.GetCurrentBalance())
            {
                MessageBox.Show("You current balance = EUR " + atmdb.CustomerAccountBalace, "Current Balance");
            }
            else 
            {
                MessageBox.Show("Account balance is unavailable due to the following error:\n" + atmdb.BalanceException, "Balance enquiry Error!!");
            }
        }
    }
}
