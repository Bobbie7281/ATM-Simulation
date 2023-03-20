# ATM-Simulation
This app is a simulation of an ATM where first you have to register and a unique pin number will be generated in order to access your account from the ATM

On start up the app will give you three options which are:
Register
Update
ATM

**1 Register:**
First you have to register a user. In this form you have to insert the general information about the user like Name, Surname, Address Contact Number ecc.... Once you entered all the neccessary data press the Insert data button and all the data will be saved in the database.

The Database consists of three tables which are the following:
client_information
account_information
transactions_records

Upon registering a user, the client_information table will be populated with all the general information, the account_information table will hold the client id, account number and account balance and the transaction_records will hold the first transaction. Once all the information is successfully insterted into the database, a dialog popup will show the client Id and pin number. The latter are to be used to access the ATM. 

**2 Update**
