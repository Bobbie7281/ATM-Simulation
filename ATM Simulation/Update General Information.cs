namespace ATM_Simulation
{
    public partial class Update_Information : Form
    {
        AtmDataBase atmdb = new();
        public Update_Information()
        {
            InitializeComponent();
        }

        private void Btn_Get_Information_Click(object sender, EventArgs e)
        {
            atmdb.CustomerId = Txt_Id_Card_Number.Text;
            bool connection = atmdb.CheckConnection();
            List<string> columnNames = new() { "Name", "Surname", "ContactNumber", "Address" , "EmailAddress", "AccountNumber" };
            List<TextBox> formFields = new() { Txt_Name, Txt_Surname, Txt_Contact_Number, Txt_Address , Txt_Email_Address, Txt_Account_Number };

            if (Txt_Id_Card_Number.Text != "")
            {
                if (connection)
                {
                    if (atmdb.SaveClientUniqueId())
                    {
                        Btn_Upload_Information.Enabled = false;
                        Btn_Upload_Information.BackColor = Color.LightGray;
                        Btn_Update_Records.Enabled = true;
                        Btn_Update_Records.BackColor= Color.White;
                        Txt_Id_Card_Number.Enabled = false;

                        for (int i = 0; i < columnNames.Count; i++)
                        {
                            formFields[i].Text = atmdb.GetColumnData(columnNames[i]);
                        }
                        Txt_Name.Enabled = true;
                        Txt_Surname.Enabled = true;
                        Txt_Contact_Number.Enabled = true;
                        Txt_Address.Enabled = true;
                        Txt_Email_Address.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("A problem encountered while searching for Id card number " + "\"" + Txt_Id_Card_Number.Text + "\""+
                            ". Please check that the data provided is correct.", "Search Unsuccessfull!!");
                    }
                }
                else
                {
                    MessageBox.Show(atmdb.ConnectionException, "Connection Error!");
                }
            }
            else
            {
                MessageBox.Show("Please insert a valid Id card Number", "Error Blank Field!");
            }
        }
        private void Btn_Update_Records_Click(object sender, EventArgs e)
        {
            Btn_Upload_Information.Enabled = true;
            Btn_Update_Records.Enabled = false;
            atmdb.CustomerName=Txt_Name.Text;
            atmdb.CustomerSurname=Txt_Surname.Text;
            atmdb.CustomerContactNumber=Txt_Contact_Number.Text;
            atmdb.CustomerAddress=Txt_Address.Text;
            atmdb.CustomerEmail=Txt_Email_Address.Text;

            if(!atmdb.UpdateGeneralInformation())
            {
                MessageBox.Show("Information Update cannot be completed due to the following error! " + atmdb.GeneralUpadteException, "Update not sucessfull!!");
            }
            else
            {
                MessageBox.Show("Records Updated Successfully!", "Update successfull");
            }

            Txt_Id_Card_Number.Enabled = true;
            Txt_Id_Card_Number.Text = "";
            Txt_Name.Enabled = false;
            Txt_Name.Text = "";
            Txt_Surname.Enabled = false;
            Txt_Surname.Text = "";
            Txt_Contact_Number.Enabled = false;
            Txt_Contact_Number.Text = "";
            Txt_Address.Enabled = false;
            Txt_Address.Text = "";
            Txt_Email_Address.Enabled = false;
            Txt_Email_Address.Text = "";
            Txt_Account_Number.Text = "";
            Btn_Upload_Information.Enabled = true;
            Btn_Upload_Information.BackColor = Color.White;
            Btn_Update_Records.Enabled = false;
            Btn_Update_Records.BackColor = Color.LightGray;
        }
        private void Btn_Exit_Click(object sender, EventArgs e)
        {
            Txt_Id_Card_Number.Enabled = true;
            Txt_Id_Card_Number.Text = "";
            Txt_Name.Enabled = false;
            Txt_Name.Text = "";
            Txt_Surname.Enabled = false;
            Txt_Surname.Text = "";
            Txt_Contact_Number.Enabled = false;
            Txt_Contact_Number.Text = "";
            Txt_Address.Enabled = false;
            Txt_Address.Text = "";
            Txt_Email_Address.Enabled=false;
            Txt_Email_Address.Text = "";
            Txt_Account_Number.Text = "";

            Btn_Upload_Information.Enabled = true;
            Btn_Upload_Information.BackColor = Color.White;
            Btn_Update_Records.Enabled = false;
            Btn_Update_Records.BackColor = Color.LightGray;

            this.DialogResult = DialogResult.Abort;
            this.Close();
        }
    }
}
