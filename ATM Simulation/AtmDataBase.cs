using MySql.Data.MySqlClient;
using System.Data;
using System.Net;
using System.Net.Mail;

namespace ATM_Simulation
{
    public class AtmDataBase
    {
        MySqlConnection connection = new();
        MySqlCommand command = new();
        readonly MySqlDataAdapter adapter = new();
        readonly Random pin = new();
        readonly string connectionString = "Server=localhost;Database=atmdb;Uid=root;Pwd=MyData7777!!";

        string customerId = "";
        string customerName = "";
        string customerSurname = "";
        string customerContactNumber = "";
        string customerAddress = "";
        string customerEmail = "";
        string customerAccountNumber = "";
        int accountBalance = 0;
        string customerInfoException = "";
        string customerAccountInfoException = "";
        string idAndPinVerificationException = "";
        string transactionRecordException = "";
        string getIdException = "";
        string withdrawalException = "";
        string depositException = "";
        string balanceException = "";
        string connectionException = "";
        string generalUpdateException = "";
        int id = 0;
        int pinNumber = 0;
        int customerPinNumber = 0;
        int amountDeposited = 0;
        int amountWithdrawn = 0;

        public string CustomerId
        {
            set { customerId = value; }
            get { return customerId; }
        }
        public string CustomerName
        {
            set { customerName = value; }
            get { return customerName; }
        }
        public string CustomerSurname
        {
            set { customerSurname = value; }
            get { return customerSurname; }
        }
        public string CustomerContactNumber
        {
            set { customerContactNumber = value; }
            get { return customerContactNumber; }
        }
        public string CustomerAddress
        {
            set { customerAddress = value; }
            get { return customerAddress; }
        }
        public string CustomerEmail
        {
            set { customerEmail = value; }
            get { return customerEmail; }
        }
        public string CustomerAccountNumber
        {
            set { customerAccountNumber = value; }
            get { return customerAccountNumber; }
        }
        public int CustomerAccountBalace
        {
            set { accountBalance = value; }
            get { return accountBalance; }
        }
        public string CustomerInfoException
        {
            set { customerInfoException = value; }
            get { return customerInfoException; }
        }
        public string CustomerAccountInfoException
        {
            set { customerAccountInfoException = value; }
            get { return customerAccountInfoException; }
        }
        public int CustomerPinNumber
        {
            set { customerPinNumber = value; }
            get { return customerPinNumber; }
        }
        public string IdAndPinVerificationException
        {
            set { idAndPinVerificationException = value; }
            get { return idAndPinVerificationException; }
        }
        public string TransactionRecordException
        {
            set { transactionRecordException = value; }
            get { return transactionRecordException; }
        }
        public string GetIdException
        {
            set { getIdException = value; }
            get { return getIdException; }
        }
        public string WithdrawalException
        {
            set { withdrawalException = value; }
            get { return withdrawalException; }
        }
        public string DepositException
        {
            set { depositException = value; }
            get { return depositException; }
        }
        public string BalanceException
        {
            set { balanceException = value; }
            get { return balanceException; }
        }
        public string ConnectionException
        {
            set { connectionException = value; }
            get { return connectionException; }
        }
        public string GeneralUpadteException
        {
            set { generalUpdateException = value; }
            get { return generalUpdateException; }
        }

        public int Id
        {
            set { id = value; }
            get { return id; }
        }
        public int PinNumber
        {
            set { pinNumber = value; }
            get { return pinNumber; }
        }
        public int AmountDeposited
        {
            set { amountDeposited = value; }
            get { return amountDeposited; }
        }
        public int AmountWithdrawn
        {
            set { amountWithdrawn = value; }
            get { return amountWithdrawn; }
        }

        public bool CheckConnection()
        {
            bool connectionStatus;

            try
            {
                connection = new MySqlConnection(connectionString);
                connection.Open();
                connectionStatus = true;
            }
            catch (Exception ex)
            {
                ConnectionException = ex.Message;
                connectionStatus = false;
            }
            return connectionStatus;
        }
        public bool NewRegistrationFormDetails(string idCard, string name, string surname, string contactNumber, string address, string emailAddress, string accountNumber, int accountBalance)
        {
            Int64 duplicateData = 0;
            bool doubleData;

            command = new MySqlCommand("check_for_duplicate_id", connection);
            command.Parameters.AddWithValue("@idCard", idCard);
            command.CommandType = CommandType.StoredProcedure;

            try
            {
                duplicateData = (Int64)command.ExecuteScalar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            if (duplicateData == 0)
            {
                doubleData = false;

                CustomerId = idCard;
                CustomerName = name;
                CustomerSurname = surname;
                CustomerContactNumber = contactNumber;
                CustomerAddress = address;
                CustomerEmail = emailAddress;
                CustomerAccountNumber = accountNumber;
                CustomerAccountBalace = accountBalance;
                AmountDeposited = accountBalance;
            }
            else
            {
                doubleData = true;
            }
            return doubleData;
        }
        public bool InsertClientInformation()
        {
            bool executionResult;
            bool matchingData;

            do
            {
                int pinNumber = pin.Next(1000, 9999);

                command = new MySqlCommand("check_for_duplicate_pins", connection);
                command.Parameters.AddWithValue("@pinNum", pinNumber);
                command.CommandType = CommandType.StoredProcedure;

                if ((Int64)command.ExecuteScalar() > 0)
                {
                    matchingData = true;
                }
                else
                {
                    matchingData = false;
                    CustomerPinNumber = pinNumber;
                }
            }
            while (matchingData);

            command = new MySqlCommand("insert_client_info", connection);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@cardNum", CustomerId);
            command.Parameters.AddWithValue("@firstName", CustomerName);
            command.Parameters.AddWithValue("@surname", CustomerSurname);
            command.Parameters.AddWithValue("@contact", CustomerContactNumber);
            command.Parameters.AddWithValue("@address", CustomerAddress);
            command.Parameters.AddWithValue("@email", CustomerEmail);
            command.Parameters.AddWithValue("@pin", CustomerPinNumber);

            try
            {
                command.ExecuteNonQuery();
                executionResult = true;
            }
            catch (Exception ex)
            {
                executionResult = false;
                CustomerInfoException = ex.Message;
            }
            return executionResult;
        }
        public bool InsertClientAccountInformation()
        {
            bool executionResult;
            command = new MySqlCommand("insert_client_account_info", connection);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@accNum", CustomerAccountNumber);
            command.Parameters.AddWithValue("@accBal", CustomerAccountBalace);
            command.Parameters.AddWithValue("@idCard", CustomerId);

            try
            {
                command.ExecuteNonQuery();
                executionResult = true;
            }
            catch (Exception ex)
            {
                executionResult = false;
                CustomerAccountInfoException = ex.Message;
            }
            return executionResult;
        }
        public bool InsertTransactionRecord(bool deposit, bool withraw)
        {
            bool executionResult;
            command = new MySqlCommand("insert_transaction_record", connection);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@clientId", Id);
            if (deposit)
            {
                command.Parameters.AddWithValue("@deposit", AmountDeposited);
                command.Parameters.AddWithValue("@withdraw", 0);
            }
            else if (withraw)
            {
                command.Parameters.AddWithValue("@deposit", 0);
                command.Parameters.AddWithValue("@withdraw", AmountWithdrawn);
            }

            try
            {
                command.ExecuteNonQuery();
                executionResult = true;
            }
            catch (Exception ex)
            {
                TransactionRecordException = ex.Message;
                executionResult = false;
            }
            return executionResult;
        }
        public bool SaveClientUniqueId()
        {
            bool executionResult;
            command = new MySqlCommand("get_client_unique_id", connection);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@idCardNum", CustomerId);

            try
            {
                Id = (int)command.ExecuteScalar();
                executionResult = true;
            }
            catch (Exception ex)
            {
                GetIdException = ex.Message;
                executionResult = false;
            }
            return executionResult;
        }
        public bool VerifyIdWithPinNumber(int id, int pinNumber)
        {
            bool verification;
            command = new MySqlCommand("verify_id_with_pin", connection);
            command.Parameters.AddWithValue("@id", id);
            command.Parameters.AddWithValue("@pinNum", pinNumber);
            command.CommandType = CommandType.StoredProcedure;

            try
            {
                Int64 count = (Int64)command.ExecuteScalar();
                if (count == 1)
                {
                    verification = true;
                    command = new MySqlCommand("get_name_of_atm_user", connection);
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@id", Id);

                    CustomerName = (string)command.ExecuteScalar();

                }
                else
                {
                    verification = false;
                }
            }
            catch (Exception ex)
            {
                IdAndPinVerificationException = ex.Message;
                verification = false;
            }
            return verification;
        }
        public bool Withdrawal(int amount)
        {
            bool executionResult;
            AmountWithdrawn = amount;

            command = new MySqlCommand("get_account_balance", connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@id", Id);

            int totalBalace = (int)command.ExecuteScalar();

            if (totalBalace >= amount)
            {
                command = new MySqlCommand("withdraw_from_account", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@amount", AmountWithdrawn);
                command.Parameters.AddWithValue("@id", Id);

                try
                {
                    command.ExecuteNonQuery();
                    executionResult = true;
                }
                catch (Exception ex)
                {
                    WithdrawalException = ex.Message;
                    executionResult = false;
                }
            }
            else
            {
                WithdrawalException = "You do not have enough funds to withdraw the amount rquested!!";
                executionResult = false;
            }
            return executionResult;
        }
        public bool Deposit(int amount)
        {
            bool executionResult;
            AmountDeposited = amount;

            command = new MySqlCommand("deposit_in_account", connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@deposit", AmountDeposited);
            command.Parameters.AddWithValue("@id", Id);

            try
            {
                command.ExecuteNonQuery();
                executionResult = true;
            }
            catch (Exception ex)
            {
                DepositException = ex.Message;
                executionResult = false;
            }
            return executionResult;
        }
        public DataTable GetLastFiveTransactions()
        {
            DataTable dt = new();

            command = new MySqlCommand("get_last_five_records", connection);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@id", Id);

            adapter.SelectCommand = command;
            adapter.Fill(dt);

            return dt;
        }
        public bool GetCurrentBalance()
        {
            bool executionResult;
            command = new MySqlCommand("get_account_balance", connection);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@id", Id);

            try
            {
                CustomerAccountBalace = (int)command.ExecuteScalar();
                executionResult = true;
            }
            catch (Exception ex)
            {
                balanceException = ex.Message;
                executionResult = false;
            }

            return executionResult;
        }
        public string GetColumnData(string columnName)
        {
            string? columnData;
            command = new MySqlCommand("get_column_data", connection);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@id", Id);
            command.Parameters.AddWithValue("@column_name", columnName);

            columnData = command.ExecuteScalar().ToString();

            columnData ??= "";// means if columnData is null set columndata to ""

            return columnData;
        }
        public bool UpdateGeneralInformation()
        {
            bool executionResult;

            command = new MySqlCommand("update_general_informartion", connection);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@id", Id);
            command.Parameters.AddWithValue("@name", CustomerName);
            command.Parameters.AddWithValue("@surname", CustomerSurname);
            command.Parameters.AddWithValue("@contactNumber", CustomerContactNumber);
            command.Parameters.AddWithValue("@address", CustomerAddress);
            command.Parameters.AddWithValue("@email", CustomerEmail);

            try
            {
                command.ExecuteNonQuery();
                executionResult = true;
            }
            catch (Exception ex)
            {
                generalUpdateException = ex.Message;
                executionResult = false;
            }
            return executionResult;
        }
    }
}
