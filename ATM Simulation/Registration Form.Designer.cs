namespace ATM_Simulation
{
    partial class Frm_Registration_Form
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
            this.lbl_Welcome_Message = new System.Windows.Forms.Label();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.txt_Surname = new System.Windows.Forms.TextBox();
            this.txt_Contact_Number = new System.Windows.Forms.TextBox();
            this.txt_Address = new System.Windows.Forms.TextBox();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.lbl_Surname = new System.Windows.Forms.Label();
            this.lb_Address = new System.Windows.Forms.Label();
            this.lbl_Contact_Number = new System.Windows.Forms.Label();
            this.Btn_Insert_Record = new System.Windows.Forms.Button();
            this.lbl_IdCardNum = new System.Windows.Forms.Label();
            this.txt_Id_Card_Number = new System.Windows.Forms.TextBox();
            this.txt_Account_Number = new System.Windows.Forms.TextBox();
            this.lbl_Account_Number = new System.Windows.Forms.Label();
            this.lbl_Initial_Balance = new System.Windows.Forms.Label();
            this.txt_Account_Balance = new System.Windows.Forms.TextBox();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.cmb_Idcard_Letter = new System.Windows.Forms.ComboBox();
            this.Lbl_Email_Address = new System.Windows.Forms.Label();
            this.Txt_Email_Address = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl_Welcome_Message
            // 
            this.lbl_Welcome_Message.AutoSize = true;
            this.lbl_Welcome_Message.Font = new System.Drawing.Font("Segoe UI", 25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbl_Welcome_Message.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbl_Welcome_Message.Location = new System.Drawing.Point(17, 15);
            this.lbl_Welcome_Message.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Welcome_Message.Name = "lbl_Welcome_Message";
            this.lbl_Welcome_Message.Size = new System.Drawing.Size(453, 67);
            this.lbl_Welcome_Message.TabIndex = 6;
            this.lbl_Welcome_Message.Text = "Registartion Form";
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(323, 186);
            this.txt_Name.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(371, 31);
            this.txt_Name.TabIndex = 3;
            // 
            // txt_Surname
            // 
            this.txt_Surname.Location = new System.Drawing.Point(323, 257);
            this.txt_Surname.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Surname.Name = "txt_Surname";
            this.txt_Surname.Size = new System.Drawing.Size(371, 31);
            this.txt_Surname.TabIndex = 4;
            // 
            // txt_Contact_Number
            // 
            this.txt_Contact_Number.Location = new System.Drawing.Point(320, 329);
            this.txt_Contact_Number.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Contact_Number.Name = "txt_Contact_Number";
            this.txt_Contact_Number.Size = new System.Drawing.Size(371, 31);
            this.txt_Contact_Number.TabIndex = 5;
            this.txt_Contact_Number.TextChanged += new System.EventHandler(this.Txt_Contact_Number_TextChanged);
            // 
            // txt_Address
            // 
            this.txt_Address.Location = new System.Drawing.Point(320, 392);
            this.txt_Address.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Address.Multiline = true;
            this.txt_Address.Name = "txt_Address";
            this.txt_Address.Size = new System.Drawing.Size(371, 127);
            this.txt_Address.TabIndex = 6;
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Name.Location = new System.Drawing.Point(220, 186);
            this.lbl_Name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(95, 32);
            this.lbl_Name.TabIndex = 12;
            this.lbl_Name.Text = "Name -";
            // 
            // lbl_Surname
            // 
            this.lbl_Surname.AutoSize = true;
            this.lbl_Surname.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Surname.Location = new System.Drawing.Point(189, 257);
            this.lbl_Surname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Surname.Name = "lbl_Surname";
            this.lbl_Surname.Size = new System.Drawing.Size(126, 32);
            this.lbl_Surname.TabIndex = 13;
            this.lbl_Surname.Text = "Surname -";
            // 
            // lb_Address
            // 
            this.lb_Address.AutoSize = true;
            this.lb_Address.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_Address.Location = new System.Drawing.Point(197, 437);
            this.lb_Address.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_Address.Name = "lb_Address";
            this.lb_Address.Size = new System.Drawing.Size(115, 32);
            this.lb_Address.TabIndex = 15;
            this.lb_Address.Text = "Address -";
            // 
            // lbl_Contact_Number
            // 
            this.lbl_Contact_Number.AutoSize = true;
            this.lbl_Contact_Number.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Contact_Number.Location = new System.Drawing.Point(104, 329);
            this.lbl_Contact_Number.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Contact_Number.Name = "lbl_Contact_Number";
            this.lbl_Contact_Number.Size = new System.Drawing.Size(208, 32);
            this.lbl_Contact_Number.TabIndex = 16;
            this.lbl_Contact_Number.Text = "Contact Number -";
            // 
            // Btn_Insert_Record
            // 
            this.Btn_Insert_Record.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Btn_Insert_Record.Location = new System.Drawing.Point(745, 554);
            this.Btn_Insert_Record.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Btn_Insert_Record.Name = "Btn_Insert_Record";
            this.Btn_Insert_Record.Size = new System.Drawing.Size(193, 68);
            this.Btn_Insert_Record.TabIndex = 10;
            this.Btn_Insert_Record.Text = "Insert Record";
            this.Btn_Insert_Record.UseVisualStyleBackColor = true;
            this.Btn_Insert_Record.Click += new System.EventHandler(this.Btn_Insert_Record_Click);
            // 
            // lbl_IdCardNum
            // 
            this.lbl_IdCardNum.AutoSize = true;
            this.lbl_IdCardNum.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_IdCardNum.Location = new System.Drawing.Point(107, 119);
            this.lbl_IdCardNum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_IdCardNum.Name = "lbl_IdCardNum";
            this.lbl_IdCardNum.Size = new System.Drawing.Size(205, 32);
            this.lbl_IdCardNum.TabIndex = 18;
            this.lbl_IdCardNum.Text = "ID Card Number -";
            // 
            // txt_Id_Card_Number
            // 
            this.txt_Id_Card_Number.Location = new System.Drawing.Point(320, 119);
            this.txt_Id_Card_Number.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Id_Card_Number.Name = "txt_Id_Card_Number";
            this.txt_Id_Card_Number.Size = new System.Drawing.Size(203, 31);
            this.txt_Id_Card_Number.TabIndex = 1;
            this.txt_Id_Card_Number.TextChanged += new System.EventHandler(this.Txt_Id_Card_Number_TextChanged);
            // 
            // txt_Account_Number
            // 
            this.txt_Account_Number.Location = new System.Drawing.Point(320, 604);
            this.txt_Account_Number.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Account_Number.Name = "txt_Account_Number";
            this.txt_Account_Number.Size = new System.Drawing.Size(371, 31);
            this.txt_Account_Number.TabIndex = 8;
            this.txt_Account_Number.TextChanged += new System.EventHandler(this.Txt_Account_Number_TextChanged);
            // 
            // lbl_Account_Number
            // 
            this.lbl_Account_Number.AutoSize = true;
            this.lbl_Account_Number.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Account_Number.Location = new System.Drawing.Point(99, 604);
            this.lbl_Account_Number.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Account_Number.Name = "lbl_Account_Number";
            this.lbl_Account_Number.Size = new System.Drawing.Size(213, 32);
            this.lbl_Account_Number.TabIndex = 20;
            this.lbl_Account_Number.Text = "Account Number -";
            // 
            // lbl_Initial_Balance
            // 
            this.lbl_Initial_Balance.AutoSize = true;
            this.lbl_Initial_Balance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Initial_Balance.Location = new System.Drawing.Point(134, 668);
            this.lbl_Initial_Balance.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Initial_Balance.Name = "lbl_Initial_Balance";
            this.lbl_Initial_Balance.Size = new System.Drawing.Size(178, 32);
            this.lbl_Initial_Balance.TabIndex = 22;
            this.lbl_Initial_Balance.Text = "Initial Balance -";
            // 
            // txt_Account_Balance
            // 
            this.txt_Account_Balance.Location = new System.Drawing.Point(320, 669);
            this.txt_Account_Balance.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Account_Balance.Name = "txt_Account_Balance";
            this.txt_Account_Balance.Size = new System.Drawing.Size(371, 31);
            this.txt_Account_Balance.TabIndex = 9;
            this.txt_Account_Balance.TextChanged += new System.EventHandler(this.Txt_Account_Balance_TextChanged);
            // 
            // btn_Exit
            // 
            this.btn_Exit.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Exit.Location = new System.Drawing.Point(745, 632);
            this.btn_Exit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(193, 68);
            this.btn_Exit.TabIndex = 11;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.Btn_Exit_Click);
            // 
            // cmb_Idcard_Letter
            // 
            this.cmb_Idcard_Letter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Idcard_Letter.FormattingEnabled = true;
            this.cmb_Idcard_Letter.Items.AddRange(new object[] {
            "",
            "(A)",
            "(B)",
            "(C)",
            "(D)",
            "(E)",
            "(F)",
            "(G)",
            "(H)",
            "(I)",
            "(J)",
            "(K)",
            "(L)",
            "(M)",
            "(N)",
            "(O)",
            "(P)",
            "(Q)",
            "(R)",
            "(S)",
            "(T)",
            "(U)",
            "(V)",
            "(W)",
            "(X)",
            "(Y)",
            "(Z)"});
            this.cmb_Idcard_Letter.Location = new System.Drawing.Point(539, 117);
            this.cmb_Idcard_Letter.Name = "cmb_Idcard_Letter";
            this.cmb_Idcard_Letter.Size = new System.Drawing.Size(60, 33);
            this.cmb_Idcard_Letter.TabIndex = 2;
            // 
            // Lbl_Email_Address
            // 
            this.Lbl_Email_Address.AutoSize = true;
            this.Lbl_Email_Address.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Lbl_Email_Address.Location = new System.Drawing.Point(131, 543);
            this.Lbl_Email_Address.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Email_Address.Name = "Lbl_Email_Address";
            this.Lbl_Email_Address.Size = new System.Drawing.Size(179, 32);
            this.Lbl_Email_Address.TabIndex = 27;
            this.Lbl_Email_Address.Text = "Email Address -";
            // 
            // Txt_Email_Address
            // 
            this.Txt_Email_Address.Location = new System.Drawing.Point(318, 540);
            this.Txt_Email_Address.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Txt_Email_Address.Name = "Txt_Email_Address";
            this.Txt_Email_Address.Size = new System.Drawing.Size(371, 31);
            this.Txt_Email_Address.TabIndex = 7;
            // 
            // Frm_Registration_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(997, 746);
            this.ControlBox = false;
            this.Controls.Add(this.Lbl_Email_Address);
            this.Controls.Add(this.Txt_Email_Address);
            this.Controls.Add(this.cmb_Idcard_Letter);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.lbl_Initial_Balance);
            this.Controls.Add(this.txt_Account_Balance);
            this.Controls.Add(this.lbl_Account_Number);
            this.Controls.Add(this.txt_Account_Number);
            this.Controls.Add(this.lbl_IdCardNum);
            this.Controls.Add(this.txt_Id_Card_Number);
            this.Controls.Add(this.Btn_Insert_Record);
            this.Controls.Add(this.lbl_Contact_Number);
            this.Controls.Add(this.lb_Address);
            this.Controls.Add(this.lbl_Surname);
            this.Controls.Add(this.lbl_Name);
            this.Controls.Add(this.txt_Address);
            this.Controls.Add(this.txt_Contact_Number);
            this.Controls.Add(this.txt_Surname);
            this.Controls.Add(this.txt_Name);
            this.Controls.Add(this.lbl_Welcome_Message);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Frm_Registration_Form";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registration_Form";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm_Registration_Form_FormClosing);
            this.Load += new System.EventHandler(this.Frm_Registration_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbl_Welcome_Message;
        private TextBox txt_Name;
        private TextBox txt_Surname;
        private TextBox txt_Contact_Number;
        private TextBox txt_Address;
        private Label lbl_Name;
        private Label lbl_Surname;
        private Label lb_Address;
        private Label lbl_Contact_Number;
        private Button Btn_Insert_Record;
        private Label lbl_IdCardNum;
        private TextBox txt_Id_Card_Number;
        private TextBox txt_Account_Number;
        private Label lbl_Account_Number;
        private Label lbl_Initial_Balance;
        private TextBox txt_Account_Balance;
        private Button btn_Exit;
        private ComboBox cmb_Idcard_Letter;
        private Label Lbl_Email_Address;
        private TextBox Txt_Email_Address;
    }
}