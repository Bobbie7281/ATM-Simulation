using MySql.Data.MySqlClient;
using System.Data;

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

        /// <summary>
        /// This method checks the connection with the database.
        /// </summary>
        /// <returns>returns true if connection is successful returns false if otherwise</returns>
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

        /// <summary>
        /// This method will set the properties of the class with the new data passed as parameters only if the Id card number is not already in use .
        /// </summary>
        /// <param name="idCard">Id card number must be unique</param>
        /// <param name="name"></param>
        /// <param name="surname"></param>
        /// <param name="contactNumber"></param>
        /// <param name="address"></param>
        /// <param name="emailAddress"></param>
        /// <param name="accountNumber"></param>
        /// <param name="accountBalance"></param>
        /// <returns>It returns true if same id card is encountered or returns false if the Id card doesn't exist.</returns>
        public bool NewRegistrationFormDetails(string idCard, string name, string surname, string contactNumber, string address, string emailAddress, string accountNumber, int accountBalance)
        {
            Int64 duplicateData = 0;
            bool doubleData;
            //This sql command will check if the id card for the new registration already exists in the database
            command = new MySqlCommand("check_for_duplicate_id", connection);
            command.Parameters.AddWithValue("@idCard", idCard);
            command.CommandType = CommandType.StoredProcedure;

            try
            {
                //duplicateData will hold the number returned from the query. The number represents the amount of Id card numbers found with the same number
                duplicateData = (Int64)command.ExecuteScalar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            //if duplicateData is 0 it means that the Id card number for the new registration doesn't exist in the database,
            //so the program can proceed with the rest of the code.
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
        /// <summary>
        /// This method will insert all the new data in the client_information table.
        /// </summary>
        /// <returns>Returns true if successfull or returns false if an error is encountered.</returns>
        public bool InsertClientInformation()
        {
            bool executionResult;
            bool matchingData;

            do
            {
                //a pin number from 1000 to 9999 is randomly generated 
                int pinNumber = pin.Next(1000, 9999);

                //the pin number is passed to the following sql command to check if it already exists
                command = new MySqlCommand("check_for_duplicate_pins", connection);
                command.Parameters.AddWithValue("@pinNum", pinNumber);
                command.CommandType = CommandType.StoredProcedure;

                //if the result of the query is bigger than 0, it means that the pin number already exist and matchingData is set to true,
                //else the pin number is saved
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
            while (matchingData);//The do while loop will keep on looping until a unique pin number is generated.

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

        /// <summary>
        /// This method will insert the data in the account_information table.
        /// </summary>
        /// <returns>Returns true if successfull or returns false if an error is encountered.</returns>
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

        /// <summary>
        /// This method will insert all the transaction records in the transaction_records table.
        /// </summary>
        /// <param name="deposit">Set to true if its a deposit,set false if otherwise</param>
        /// <param name="withraw">Set to true if its a withdraw,set false if otherwise</param>
        /// <returns>Returns true if successfull or returns false if an error is encountered</returns>
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

        /// <summary>
        /// This method will get the client id from the client_information table and sets the Id property of the class.
        /// </summary>
        /// <returns>Returns true if successfull or returns false if an error is encountered</returns>
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

        /// <summary>
        /// Checks whether the id and pinNumber belongs to one user
        /// </summary>
        /// <param name="id"></param>
        /// <param name="pinNumber"></param>
        /// <returns>true if successfull</returns>
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

        /// <summary>
        /// This method withdraws money from the account.
        /// </summary>
        /// <param name="amount">Amount of money to withdraw</param>
        /// <returns>Returns true if withdrawal is successful. Returns false if no funds are availabe or an error was encountered</returns>
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

        /// <summary>
        /// This method deposits money in the account.
        /// </summary>
        /// <param name="amount">Amount of money to be deposited</param>
        /// <returns>Returns true if deposit is successful. Returns false if an error was encountered</returns>
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

        /// <summary>
        /// This method displays the last five transactions 
        /// </summary>
        /// <returns>returns a dataTable</returns>
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
        /// <summary>
        /// This method displays the total account balance
        /// </summary>
        /// <returns>Returns true if successful and returns false if otherwise</returns>
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

        /// <summary>
        /// Gets the data of a particular column. The property Id needs to be set by calling SaveClientUniqueId method before this method is called 
        /// </summary>
        /// <param name="columnName"></param>
        /// <returns>returns the column data</returns>
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
        /// <summary>
        /// This method updates the information of a client in the client_information table 
        /// </summary>
        /// <returns>Returns true if successful or returns false if otherwise</returns>
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
