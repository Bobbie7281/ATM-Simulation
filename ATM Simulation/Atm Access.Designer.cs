namespace ATM_Simulation
{
    partial class Frm_Atm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Txt_Id_And_Pin = new System.Windows.Forms.TextBox();
            this.LblIdAndPin = new System.Windows.Forms.Label();
            this.Btn_Atm_Access = new System.Windows.Forms.Button();
            this.Lbl_Welcome_Message = new System.Windows.Forms.Label();
            this.pnl_keypad = new System.Windows.Forms.Panel();
            this.Btn_num_five = new System.Windows.Forms.Button();
            this.Btn_num_four = new System.Windows.Forms.Button();
            this.Btn_num_three = new System.Windows.Forms.Button();
            this.Btn_num_two = new System.Windows.Forms.Button();
            this.Btn_num_one = new System.Windows.Forms.Button();
            this.Btn_num_zero = new System.Windows.Forms.Button();
            this.Btn_num_nine = new System.Windows.Forms.Button();
            this.Btn_num_six = new System.Windows.Forms.Button();
            this.Btn_num_eight = new System.Windows.Forms.Button();
            this.Btn_num_seven = new System.Windows.Forms.Button();
            this.Btn_Withdraw = new System.Windows.Forms.Button();
            this.Btn_Deposit = new System.Windows.Forms.Button();
            this.Btn_Last_Five_Transactions = new System.Windows.Forms.Button();
            this.Btn_Current_Balance = new System.Windows.Forms.Button();
            this.Btn_Exit = new System.Windows.Forms.Button();
            this.pnl_keypad.SuspendLayout();
            this.SuspendLayout();
            // 
            // Txt_Id_And_Pin
            // 
            this.Txt_Id_And_Pin.Location = new System.Drawing.Point(277, 192);
            this.Txt_Id_And_Pin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Txt_Id_And_Pin.Name = "Txt_Id_And_Pin";
            this.Txt_Id_And_Pin.Size = new System.Drawing.Size(168, 31);
            this.Txt_Id_And_Pin.TabIndex = 0;
            this.Txt_Id_And_Pin.Tag = "";
            this.Txt_Id_And_Pin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Txt_Id_And_Pin.TextChanged += new System.EventHandler(this.Txt_Id_And_Pin_TextChanged);
            // 
            // LblIdAndPin
            // 
            this.LblIdAndPin.AutoSize = true;
            this.LblIdAndPin.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblIdAndPin.Location = new System.Drawing.Point(11, 193);
            this.LblIdAndPin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblIdAndPin.Name = "LblIdAndPin";
            this.LblIdAndPin.Size = new System.Drawing.Size(248, 28);
            this.LblIdAndPin.TabIndex = 2;
            this.LblIdAndPin.Text = "Please Insert Your User ID: -";
            this.LblIdAndPin.Click += new System.EventHandler(this.LblIdAndPin_Click);
            // 
            // Btn_Atm_Access
            // 
            this.Btn_Atm_Access.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.Btn_Atm_Access.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_Atm_Access.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Btn_Atm_Access.Location = new System.Drawing.Point(277, 557);
            this.Btn_Atm_Access.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Btn_Atm_Access.Name = "Btn_Atm_Access";
            this.Btn_Atm_Access.Size = new System.Drawing.Size(171, 77);
            this.Btn_Atm_Access.TabIndex = 3;
            this.Btn_Atm_Access.Text = "Id Verification";
            this.Btn_Atm_Access.UseVisualStyleBackColor = false;
            this.Btn_Atm_Access.Click += new System.EventHandler(this.Btn_Atm_Access_Click);
            // 
            // Lbl_Welcome_Message
            // 
            this.Lbl_Welcome_Message.AutoSize = true;
            this.Lbl_Welcome_Message.Font = new System.Drawing.Font("Segoe UI", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.Lbl_Welcome_Message.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Lbl_Welcome_Message.Location = new System.Drawing.Point(29, 8);
            this.Lbl_Welcome_Message.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Welcome_Message.Name = "Lbl_Welcome_Message";
            this.Lbl_Welcome_Message.Size = new System.Drawing.Size(310, 96);
            this.Lbl_Welcome_Message.TabIndex = 5;
            this.Lbl_Welcome_Message.Text = "Welcome to FFB \r\nFuture First Bank\r\n";
            // 
            // pnl_keypad
            // 
            this.pnl_keypad.BackColor = System.Drawing.Color.DarkGray;
            this.pnl_keypad.Controls.Add(this.Btn_num_five);
            this.pnl_keypad.Controls.Add(this.Btn_num_four);
            this.pnl_keypad.Controls.Add(this.Btn_num_three);
            this.pnl_keypad.Controls.Add(this.Btn_num_two);
            this.pnl_keypad.Controls.Add(this.Btn_num_one);
            this.pnl_keypad.Controls.Add(this.Btn_num_zero);
            this.pnl_keypad.Controls.Add(this.Btn_num_nine);
            this.pnl_keypad.Controls.Add(this.Btn_num_six);
            this.pnl_keypad.Controls.Add(this.Btn_num_eight);
            this.pnl_keypad.Controls.Add(this.Btn_num_seven);
            this.pnl_keypad.Location = new System.Drawing.Point(277, 257);
            this.pnl_keypad.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnl_keypad.Name = "pnl_keypad";
            this.pnl_keypad.Size = new System.Drawing.Size(171, 267);
            this.pnl_keypad.TabIndex = 6;
            // 
            // Btn_num_five
            // 
            this.Btn_num_five.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.Btn_num_five.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.Btn_num_five.Font = new System.Drawing.Font("Castellar", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Btn_num_five.Location = new System.Drawing.Point(57, 67);
            this.Btn_num_five.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Btn_num_five.Name = "Btn_num_five";
            this.Btn_num_five.Size = new System.Drawing.Size(59, 67);
            this.Btn_num_five.TabIndex = 14;
            this.Btn_num_five.Text = "5";
            this.Btn_num_five.UseVisualStyleBackColor = false;
            this.Btn_num_five.Click += new System.EventHandler(this.Keypad_Click);
            // 
            // Btn_num_four
            // 
            this.Btn_num_four.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.Btn_num_four.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.Btn_num_four.Font = new System.Drawing.Font("Castellar", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Btn_num_four.Location = new System.Drawing.Point(1, 67);
            this.Btn_num_four.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Btn_num_four.Name = "Btn_num_four";
            this.Btn_num_four.Size = new System.Drawing.Size(57, 67);
            this.Btn_num_four.TabIndex = 12;
            this.Btn_num_four.Text = "4";
            this.Btn_num_four.UseVisualStyleBackColor = false;
            this.Btn_num_four.Click += new System.EventHandler(this.Keypad_Click);
            // 
            // Btn_num_three
            // 
            this.Btn_num_three.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.Btn_num_three.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.Btn_num_three.Font = new System.Drawing.Font("Castellar", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Btn_num_three.Location = new System.Drawing.Point(114, 2);
            this.Btn_num_three.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Btn_num_three.Name = "Btn_num_three";
            this.Btn_num_three.Size = new System.Drawing.Size(57, 67);
            this.Btn_num_three.TabIndex = 13;
            this.Btn_num_three.Text = "3";
            this.Btn_num_three.UseVisualStyleBackColor = false;
            this.Btn_num_three.Click += new System.EventHandler(this.Keypad_Click);
            // 
            // Btn_num_two
            // 
            this.Btn_num_two.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.Btn_num_two.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.Btn_num_two.Font = new System.Drawing.Font("Castellar", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Btn_num_two.Location = new System.Drawing.Point(59, 2);
            this.Btn_num_two.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Btn_num_two.Name = "Btn_num_two";
            this.Btn_num_two.Size = new System.Drawing.Size(57, 67);
            this.Btn_num_two.TabIndex = 12;
            this.Btn_num_two.Text = "2";
            this.Btn_num_two.UseVisualStyleBackColor = false;
            this.Btn_num_two.Click += new System.EventHandler(this.Keypad_Click);
            // 
            // Btn_num_one
            // 
            this.Btn_num_one.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.Btn_num_one.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.Btn_num_one.Font = new System.Drawing.Font("Castellar", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Btn_num_one.Location = new System.Drawing.Point(1, 2);
            this.Btn_num_one.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Btn_num_one.Name = "Btn_num_one";
            this.Btn_num_one.Size = new System.Drawing.Size(57, 67);
            this.Btn_num_one.TabIndex = 11;
            this.Btn_num_one.Text = "1";
            this.Btn_num_one.UseVisualStyleBackColor = false;
            this.Btn_num_one.Click += new System.EventHandler(this.Keypad_Click);
            // 
            // Btn_num_zero
            // 
            this.Btn_num_zero.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.Btn_num_zero.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.Btn_num_zero.Font = new System.Drawing.Font("Castellar", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Btn_num_zero.Location = new System.Drawing.Point(57, 200);
            this.Btn_num_zero.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Btn_num_zero.Name = "Btn_num_zero";
            this.Btn_num_zero.Size = new System.Drawing.Size(57, 67);
            this.Btn_num_zero.TabIndex = 10;
            this.Btn_num_zero.Text = "0";
            this.Btn_num_zero.UseVisualStyleBackColor = false;
            this.Btn_num_zero.Click += new System.EventHandler(this.Keypad_Click);
            // 
            // Btn_num_nine
            // 
            this.Btn_num_nine.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.Btn_num_nine.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.Btn_num_nine.Font = new System.Drawing.Font("Castellar", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Btn_num_nine.Location = new System.Drawing.Point(114, 133);
            this.Btn_num_nine.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Btn_num_nine.Name = "Btn_num_nine";
            this.Btn_num_nine.Size = new System.Drawing.Size(57, 67);
            this.Btn_num_nine.TabIndex = 9;
            this.Btn_num_nine.Text = "9";
            this.Btn_num_nine.UseVisualStyleBackColor = false;
            this.Btn_num_nine.Click += new System.EventHandler(this.Keypad_Click);
            // 
            // Btn_num_six
            // 
            this.Btn_num_six.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.Btn_num_six.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.Btn_num_six.Font = new System.Drawing.Font("Castellar", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Btn_num_six.Location = new System.Drawing.Point(114, 67);
            this.Btn_num_six.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Btn_num_six.Name = "Btn_num_six";
            this.Btn_num_six.Size = new System.Drawing.Size(57, 67);
            this.Btn_num_six.TabIndex = 5;
            this.Btn_num_six.Text = "6";
            this.Btn_num_six.UseVisualStyleBackColor = false;
            this.Btn_num_six.Click += new System.EventHandler(this.Keypad_Click);
            // 
            // Btn_num_eight
            // 
            this.Btn_num_eight.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.Btn_num_eight.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.Btn_num_eight.Font = new System.Drawing.Font("Castellar", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Btn_num_eight.Location = new System.Drawing.Point(57, 133);
            this.Btn_num_eight.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Btn_num_eight.Name = "Btn_num_eight";
            this.Btn_num_eight.Size = new System.Drawing.Size(59, 67);
            this.Btn_num_eight.TabIndex = 8;
            this.Btn_num_eight.Text = "8";
            this.Btn_num_eight.UseVisualStyleBackColor = false;
            this.Btn_num_eight.Click += new System.EventHandler(this.Keypad_Click);
            // 
            // Btn_num_seven
            // 
            this.Btn_num_seven.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.Btn_num_seven.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.Btn_num_seven.Font = new System.Drawing.Font("Castellar", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Btn_num_seven.Location = new System.Drawing.Point(1, 133);
            this.Btn_num_seven.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Btn_num_seven.Name = "Btn_num_seven";
            this.Btn_num_seven.Size = new System.Drawing.Size(57, 67);
            this.Btn_num_seven.TabIndex = 7;
            this.Btn_num_seven.Text = "7";
            this.Btn_num_seven.UseVisualStyleBackColor = false;
            this.Btn_num_seven.Click += new System.EventHandler(this.Keypad_Click);
            // 
            // Btn_Withdraw
            // 
            this.Btn_Withdraw.BackColor = System.Drawing.Color.LightGray;
            this.Btn_Withdraw.Enabled = false;
            this.Btn_Withdraw.Font = new System.Drawing.Font("Castellar", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Btn_Withdraw.ForeColor = System.Drawing.Color.Black;
            this.Btn_Withdraw.Location = new System.Drawing.Point(30, 233);
            this.Btn_Withdraw.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Btn_Withdraw.Name = "Btn_Withdraw";
            this.Btn_Withdraw.Size = new System.Drawing.Size(193, 68);
            this.Btn_Withdraw.TabIndex = 7;
            this.Btn_Withdraw.Text = "Withdrawal";
            this.Btn_Withdraw.UseVisualStyleBackColor = false;
            this.Btn_Withdraw.Click += new System.EventHandler(this.Btn_Withdraw_Click);
            // 
            // Btn_Deposit
            // 
            this.Btn_Deposit.BackColor = System.Drawing.Color.LightGray;
            this.Btn_Deposit.Enabled = false;
            this.Btn_Deposit.Font = new System.Drawing.Font("Castellar", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Btn_Deposit.ForeColor = System.Drawing.Color.Black;
            this.Btn_Deposit.Location = new System.Drawing.Point(30, 312);
            this.Btn_Deposit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Btn_Deposit.Name = "Btn_Deposit";
            this.Btn_Deposit.Size = new System.Drawing.Size(193, 68);
            this.Btn_Deposit.TabIndex = 8;
            this.Btn_Deposit.Text = "Deposit";
            this.Btn_Deposit.UseVisualStyleBackColor = false;
            this.Btn_Deposit.Click += new System.EventHandler(this.Btn_Deposit_Click);
            // 
            // Btn_Last_Five_Transactions
            // 
            this.Btn_Last_Five_Transactions.BackColor = System.Drawing.Color.LightGray;
            this.Btn_Last_Five_Transactions.Enabled = false;
            this.Btn_Last_Five_Transactions.Font = new System.Drawing.Font("Castellar", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Btn_Last_Five_Transactions.ForeColor = System.Drawing.Color.Black;
            this.Btn_Last_Five_Transactions.Location = new System.Drawing.Point(30, 468);
            this.Btn_Last_Five_Transactions.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Btn_Last_Five_Transactions.Name = "Btn_Last_Five_Transactions";
            this.Btn_Last_Five_Transactions.Size = new System.Drawing.Size(193, 92);
            this.Btn_Last_Five_Transactions.TabIndex = 10;
            this.Btn_Last_Five_Transactions.Text = "View Last Five Transactions";
            this.Btn_Last_Five_Transactions.UseVisualStyleBackColor = false;
            this.Btn_Last_Five_Transactions.Click += new System.EventHandler(this.Btn_Last_Five_Transactions_Click);
            // 
            // Btn_Current_Balance
            // 
            this.Btn_Current_Balance.BackColor = System.Drawing.Color.LightGray;
            this.Btn_Current_Balance.Enabled = false;
            this.Btn_Current_Balance.Font = new System.Drawing.Font("Castellar", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Btn_Current_Balance.ForeColor = System.Drawing.Color.Black;
            this.Btn_Current_Balance.Location = new System.Drawing.Point(30, 390);
            this.Btn_Current_Balance.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Btn_Current_Balance.Name = "Btn_Current_Balance";
            this.Btn_Current_Balance.Size = new System.Drawing.Size(193, 68);
            this.Btn_Current_Balance.TabIndex = 9;
            this.Btn_Current_Balance.Text = "Current Balance";
            this.Btn_Current_Balance.UseVisualStyleBackColor = false;
            this.Btn_Current_Balance.Click += new System.EventHandler(this.Btn_Current_Balance_Click);
            // 
            // Btn_Exit
            // 
            this.Btn_Exit.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.Btn_Exit.Font = new System.Drawing.Font("Castellar", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Btn_Exit.Location = new System.Drawing.Point(30, 570);
            this.Btn_Exit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Btn_Exit.Name = "Btn_Exit";
            this.Btn_Exit.Size = new System.Drawing.Size(193, 68);
            this.Btn_Exit.TabIndex = 11;
            this.Btn_Exit.Text = "Exit";
            this.Btn_Exit.UseVisualStyleBackColor = false;
            this.Btn_Exit.Click += new System.EventHandler(this.Btn_exit_Click);
            // 
            // Frm_Atm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(481, 647);
            this.ControlBox = false;
            this.Controls.Add(this.Btn_Exit);
            this.Controls.Add(this.Btn_Last_Five_Transactions);
            this.Controls.Add(this.Btn_Current_Balance);
            this.Controls.Add(this.Btn_Deposit);
            this.Controls.Add(this.Btn_Withdraw);
            this.Controls.Add(this.Btn_Atm_Access);
            this.Controls.Add(this.pnl_keypad);
            this.Controls.Add(this.Lbl_Welcome_Message);
            this.Controls.Add(this.LblIdAndPin);
            this.Controls.Add(this.Txt_Id_And_Pin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Frm_Atm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ATM";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm_Atm_FormClosing);
            this.Click += new System.EventHandler(this.Frm_Atm_Click);
            this.pnl_keypad.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox Txt_Id_And_Pin;
        private Label LblIdAndPin;
        private Button Btn_Atm_Access;
        private Label Lbl_Welcome_Message;
        private Panel pnl_keypad;
        private Button Btn_num_zero;
        private Button Btn_num_nine;
        private Button Btn_num_six;
        private Button Btn_num_eight;
        private Button Btn_num_seven;
        private Button Btn_num_one;
        private Button Btn_num_five;
        private Button Btn_num_four;
        private Button Btn_num_three;
        private Button Btn_num_two;
        private Button Btn_Withdraw;
        private Button Btn_Deposit;
        private Button Btn_Last_Five_Transactions;
        private Button Btn_Current_Balance;
        private Button Btn_Exit;
    }
}