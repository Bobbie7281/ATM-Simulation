# ATM-Simulation
This app is a simulation of an ATM where first you have to register and a unique pin number will be generated in order to access your account from the ATM

On start up the app will give you three options which are:
1.Register
2.Update
3.ATM

**1 Register:**

First you have to register a user. In this form you have to insert the general information about the user like Name, Surname, Address Contact Number ecc.... Once you entered all the neccessary data press the Insert data button and all the data will be saved in the database.

The Database consists of three tables which are the following:
client_information
account_information
transactions_records

Upon registering a user, the client_information table will be populated with all the general information, the account_information table will hold the client id, account number and account balance and the transaction_records will hold the first transaction. Once all the information is successfully insterted into the database, a dialog popup will show the client Id and pin number. The latter are to be used to access the ATM. 

**2 Update**
The update button will give you access to update the general information of the user. To get the current data of the user, a valid Id card number must be inserted in order to upload the information. Once a valid Id card number is inserted, all the data which can be edited will show up on the screen. Some of the data will be grayed out as they cannot be edited. These are the id card number and the account number. Once al the necessary edits are done, press the update records button to update the data in the database.

**3 ATM**
The Atm button will give you access to the ATM. Some features in the form will be grayed out until a valid Id together with a pin number are verified with the database. Once a valid Id together with a pin number are verified, the name of the client will be shown on the screen and all buttons will be available. From her you can deposit, withdraw, show the currect balance and get the last five transactions.
