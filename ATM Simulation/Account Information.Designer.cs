namespace ATM_Simulation
{
    partial class Account_Information
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
            this.Dgv_Account_Info = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Account_Info)).BeginInit();
            this.SuspendLayout();
            // 
            // Dgv_Account_Info
            // 
            this.Dgv_Account_Info.AllowUserToAddRows = false;
            this.Dgv_Account_Info.AllowUserToDeleteRows = false;
            this.Dgv_Account_Info.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Dgv_Account_Info.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dgv_Account_Info.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Account_Info.Location = new System.Drawing.Point(0, 0);
            this.Dgv_Account_Info.Name = "Dgv_Account_Info";
            this.Dgv_Account_Info.ReadOnly = true;
            this.Dgv_Account_Info.RowHeadersWidth = 62;
            this.Dgv_Account_Info.RowTemplate.Height = 33;
            this.Dgv_Account_Info.Size = new System.Drawing.Size(799, 451);
            this.Dgv_Account_Info.TabIndex = 0;
            // 
            // Account_Information
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Dgv_Account_Info);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Account_Information";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Account Information";
            this.Load += new System.EventHandler(this.Account_Information_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Account_Info)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView Dgv_Account_Info;
    }
}