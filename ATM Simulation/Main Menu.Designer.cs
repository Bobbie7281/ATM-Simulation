namespace ATM_Simulation
{
    partial class Frm_Main_Menu
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
            this.Btn_Register = new System.Windows.Forms.Button();
            this.Btn_Atm = new System.Windows.Forms.Button();
            this.lbl_Register_Customer = new System.Windows.Forms.Label();
            this.lbl_Proceed_To_Atm = new System.Windows.Forms.Label();
            this.lbl_Welcome_Message = new System.Windows.Forms.Label();
            this.Btn_Update = new System.Windows.Forms.Button();
            this.Lbl_Update_Customer_Info = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Btn_Register
            // 
            this.Btn_Register.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Btn_Register.Location = new System.Drawing.Point(371, 176);
            this.Btn_Register.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Btn_Register.Name = "Btn_Register";
            this.Btn_Register.Size = new System.Drawing.Size(193, 68);
            this.Btn_Register.TabIndex = 0;
            this.Btn_Register.Text = "Register";
            this.Btn_Register.UseVisualStyleBackColor = true;
            this.Btn_Register.Click += new System.EventHandler(this.Btn_Register_Click);
            // 
            // Btn_Atm
            // 
            this.Btn_Atm.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Btn_Atm.Location = new System.Drawing.Point(371, 332);
            this.Btn_Atm.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Btn_Atm.Name = "Btn_Atm";
            this.Btn_Atm.Size = new System.Drawing.Size(193, 68);
            this.Btn_Atm.TabIndex = 2;
            this.Btn_Atm.Text = "ATM";
            this.Btn_Atm.UseVisualStyleBackColor = true;
            this.Btn_Atm.Click += new System.EventHandler(this.Btn_Atm_Click);
            // 
            // lbl_Register_Customer
            // 
            this.lbl_Register_Customer.AutoSize = true;
            this.lbl_Register_Customer.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Register_Customer.Location = new System.Drawing.Point(67, 197);
            this.lbl_Register_Customer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Register_Customer.Name = "lbl_Register_Customer";
            this.lbl_Register_Customer.Size = new System.Drawing.Size(296, 32);
            this.lbl_Register_Customer.TabIndex = 2;
            this.lbl_Register_Customer.Text = "Register a new Customer -";
            // 
            // lbl_Proceed_To_Atm
            // 
            this.lbl_Proceed_To_Atm.AutoSize = true;
            this.lbl_Proceed_To_Atm.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Proceed_To_Atm.Location = new System.Drawing.Point(161, 352);
            this.lbl_Proceed_To_Atm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Proceed_To_Atm.Name = "lbl_Proceed_To_Atm";
            this.lbl_Proceed_To_Atm.Size = new System.Drawing.Size(201, 32);
            this.lbl_Proceed_To_Atm.TabIndex = 3;
            this.lbl_Proceed_To_Atm.Text = "Proceed to ATM -";
            // 
            // lbl_Welcome_Message
            // 
            this.lbl_Welcome_Message.AutoSize = true;
            this.lbl_Welcome_Message.Font = new System.Drawing.Font("Segoe UI", 25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbl_Welcome_Message.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbl_Welcome_Message.Location = new System.Drawing.Point(146, 15);
            this.lbl_Welcome_Message.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Welcome_Message.Name = "lbl_Welcome_Message";
            this.lbl_Welcome_Message.Size = new System.Drawing.Size(431, 134);
            this.lbl_Welcome_Message.TabIndex = 4;
            this.lbl_Welcome_Message.Text = "Welcome to FFB \r\nFuture First Bank\r\n";
            // 
            // Btn_Update
            // 
            this.Btn_Update.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Btn_Update.Location = new System.Drawing.Point(371, 254);
            this.Btn_Update.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Btn_Update.Name = "Btn_Update";
            this.Btn_Update.Size = new System.Drawing.Size(193, 68);
            this.Btn_Update.TabIndex = 1;
            this.Btn_Update.Text = "Update";
            this.Btn_Update.UseVisualStyleBackColor = true;
            this.Btn_Update.Click += new System.EventHandler(this.Btn_Update_Click);
            // 
            // Lbl_Update_Customer_Info
            // 
            this.Lbl_Update_Customer_Info.AutoSize = true;
            this.Lbl_Update_Customer_Info.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Lbl_Update_Customer_Info.Location = new System.Drawing.Point(12, 275);
            this.Lbl_Update_Customer_Info.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Update_Customer_Info.Name = "Lbl_Update_Customer_Info";
            this.Lbl_Update_Customer_Info.Size = new System.Drawing.Size(350, 32);
            this.Lbl_Update_Customer_Info.TabIndex = 6;
            this.Lbl_Update_Customer_Info.Text = "Update Customer Information -";
            // 
            // Frm_Main_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(754, 503);
            this.Controls.Add(this.Lbl_Update_Customer_Info);
            this.Controls.Add(this.Btn_Update);
            this.Controls.Add(this.lbl_Welcome_Message);
            this.Controls.Add(this.lbl_Proceed_To_Atm);
            this.Controls.Add(this.lbl_Register_Customer);
            this.Controls.Add(this.Btn_Atm);
            this.Controls.Add(this.Btn_Register);
            this.ForeColor = System.Drawing.SystemColors.WindowText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Frm_Main_Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button Btn_Register;
        private Button Btn_Atm;
        private Label lbl_Register_Customer;
        private Label lbl_Proceed_To_Atm;
        private Label lbl_Welcome_Message;
        private Button Btn_Update;
        private Label Lbl_Update_Customer_Info;
    }
}