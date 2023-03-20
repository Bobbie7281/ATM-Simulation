using MySql.Data.MySqlClient;

namespace ATM_Simulation
{
    public partial class Frm_Registration_Form : Form
    {
        readonly MySqlConnection connection = new();
        readonly MySqlCommand command = new();
        readonly AtmDataBase atmdb = new();
        public Frm_Registration_Form()
        {
            InitializeComponent();
        }

        private void Frm_Registration_Form_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
        private void Frm_Registration_Form_Load(object sender, EventArgs e)
        {

        }
        private void Btn_Insert_Record_Click(object sender, EventArgs e)
        {
            bool checkConnection = atmdb.CheckConnection();
            bool clientInfoError = false;
            bool clientAccountInfoError = false;
            bool transactionRecordError = false;
            bool doubleIdCardNum;

            if (checkConnection)
            {
                doubleIdCardNum = atmdb.NewRegistrationFormDetails
                     (txt_Id_Card_Number.Text + cmb_Idcard_Letter.Text,
                     txt_Name.Text,
                     txt_Surname.Text,
                     txt_Contact_Number.Text,
                     txt_Address.Text,
                     Txt_Email_Address.Text,
                     txt_Account_Number.Text,
                     int.Parse(txt_Account_Balance.Text));

                if (!doubleIdCardNum)
                {
                    if (!atmdb.InsertClientInformation())
                    {
                        MessageBox.Show(atmdb.CustomerInfoException, "Error inserting data in client_information table!");
                        clientInfoError = true;
                    }
                    if (!clientInfoError)
                    {
                        if (!atmdb.InsertClientAccountInformation())
                        {
                            MessageBox.Show(atmdb.CustomerAccountInfoException, "Error inserting data in account_information table!");
                            clientAccountInfoError = true;
                        }
                        if (!atmdb.SaveClientUniqueId())
                        {
                            MessageBox.Show("Transaction will not be registerd due to the following error:-  " +
                                atmdb.GetIdException, "Error in geting client's unique Id!");
                            clientAccountInfoError = true;
                        }
                    }
                    if (!clientAccountInfoError)
                    {
                        if (!atmdb.InsertTransactionRecord(true, false))
                        {
                            MessageBox.Show(atmdb.TransactionRecordException, "Error inserting data in the transaction_records table!");
                            transactionRecordError = true;
                        }
                    }

                    if (!clientInfoError && !clientAccountInfoError && !transactionRecordError)
                    {
                        MessageBox.Show("Database Updated Successfully", "Update Successful!");
                        atmdb.SaveClientUniqueId();

                        MessageBox.Show("Your Id is:- " + atmdb.Id + "\nYour Pin Number is:- " + atmdb.CustomerPinNumber +
                            "\n\nUse these to access the ATM", "Client's Id and Pin.");

                        txt_Id_Card_Number.Clear();
                        cmb_Idcard_Letter.Text = "";
                        txt_Id_Card_Number.BackColor = Color.White;
                        txt_Name.Clear();
                        txt_Surname.Clear();
                        txt_Contact_Number.Clear();
                        txt_Address.Clear();
                        Txt_Email_Address.Clear();
                        txt_Account_Number.Clear();
                        txt_Account_Balance.Clear();
                    }
                }
                else
                {
                    MessageBox.Show("ID Card number is already in use! Data Not Saved!", "ID Card Already in Use!!");
                    txt_Id_Card_Number.BackColor = Color.OrangeRed;
                }
            }
            else
            {
                MessageBox.Show(atmdb.ConnectionException, "Connection Error!!");
            }
        }
        private void Txt_Id_Card_Number_TextChanged(object sender, EventArgs e)
        {
            Field_TextChanged(txt_Id_Card_Number.Text, txt_Id_Card_Number);
        }
        private void Txt_Contact_Number_TextChanged(object sender, EventArgs e)
        {
            Field_TextChanged(txt_Contact_Number.Text, txt_Contact_Number);
        }
        private void Txt_Account_Number_TextChanged(object sender, EventArgs e)
        {
            Field_TextChanged(txt_Account_Number.Text, txt_Account_Number);
        }
        private void Txt_Account_Balance_TextChanged(object sender, EventArgs e)
        {
            Field_TextChanged(txt_Account_Balance.Text, txt_Account_Balance);
        }
        private static void Field_TextChanged(string text, TextBox textBox)
        {
            if (text != "" && text != "0")
            {
                Int64.TryParse(text, out Int64 result);
                if (result == 0)
                {
                    MessageBox.Show("Only numeric characters are accepted in this field.", "Incorrect Input");
                    textBox.Clear();
                }
            }

        }
        private void Btn_Exit_Click(object sender, EventArgs e)
        {
            txt_Id_Card_Number.Text = "";
            cmb_Idcard_Letter.Text = "";
            txt_Name.Text = "";
            txt_Surname.Text = "";
            txt_Contact_Number.Text = "";
            txt_Address.Text = "";
            Txt_Email_Address.Text = "";
            txt_Account_Number.Text = "";
            txt_Account_Balance.Text = "";
            this.DialogResult = DialogResult.Abort;
        }
    }
}
