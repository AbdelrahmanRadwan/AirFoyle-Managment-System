namespace Flight_Managment_System
{
    partial class FlightSearch
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
            this.SearchKey = new System.Windows.Forms.TextBox();
            this.SearchBTN = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ArrivalDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PassengerPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Options = new System.Windows.Forms.GroupBox();
            this.DateLBL = new System.Windows.Forms.Label();
            this.Date = new System.Windows.Forms.DateTimePicker();
            this.FlightLBL = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.Options.SuspendLayout();
            this.SuspendLayout();
            // 
            // SearchKey
            // 
            this.SearchKey.Location = new System.Drawing.Point(10, 49);
            this.SearchKey.Name = "SearchKey";
            this.SearchKey.Size = new System.Drawing.Size(117, 20);
            this.SearchKey.TabIndex = 3;
            // 
            // SearchBTN
            // 
            this.SearchBTN.Location = new System.Drawing.Point(249, 47);
            this.SearchBTN.Name = "SearchBTN";
            this.SearchBTN.Size = new System.Drawing.Size(65, 23);
            this.SearchBTN.TabIndex = 2;
            this.SearchBTN.Text = "Search";
            this.SearchBTN.UseVisualStyleBackColor = true;
            this.SearchBTN.Click += new System.EventHandler(this.SearchBTN_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ArrivalDate,
            this.PassengerPhone});
            this.dataGridView1.Location = new System.Drawing.Point(10, 92);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(304, 290);
            this.dataGridView1.TabIndex = 4;
            // 
            // ArrivalDate
            // 
            this.ArrivalDate.HeaderText = "Passenger Name";
            this.ArrivalDate.Name = "ArrivalDate";
            this.ArrivalDate.ReadOnly = true;
            this.ArrivalDate.Width = 130;
            // 
            // PassengerPhone
            // 
            this.PassengerPhone.HeaderText = "Passenger Phone";
            this.PassengerPhone.Name = "PassengerPhone";
            this.PassengerPhone.ReadOnly = true;
            this.PassengerPhone.Width = 130;
            // 
            // Options
            // 
            this.Options.Controls.Add(this.DateLBL);
            this.Options.Controls.Add(this.Date);
            this.Options.Controls.Add(this.FlightLBL);
            this.Options.Controls.Add(this.SearchKey);
            this.Options.Controls.Add(this.SearchBTN);
            this.Options.Controls.Add(this.dataGridView1);
            this.Options.Location = new System.Drawing.Point(12, 12);
            this.Options.Name = "Options";
            this.Options.Size = new System.Drawing.Size(324, 92);
            this.Options.TabIndex = 6;
            this.Options.TabStop = false;
            this.Options.Text = "Options";
            // 
            // DateLBL
            // 
            this.DateLBL.AutoSize = true;
            this.DateLBL.Location = new System.Drawing.Point(132, 33);
            this.DateLBL.Name = "DateLBL";
            this.DateLBL.Size = new System.Drawing.Size(65, 13);
            this.DateLBL.TabIndex = 7;
            this.DateLBL.Text = "Arrival Date:";
            // 
            // Date
            // 
            this.Date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Date.Location = new System.Drawing.Point(133, 49);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(110, 20);
            this.Date.TabIndex = 6;
            // 
            // FlightLBL
            // 
            this.FlightLBL.AutoSize = true;
            this.FlightLBL.Location = new System.Drawing.Point(7, 33);
            this.FlightLBL.Name = "FlightLBL";
            this.FlightLBL.Size = new System.Drawing.Size(103, 13);
            this.FlightLBL.TabIndex = 5;
            this.FlightLBL.Text = "Enter Flight Number:";
            // 
            // FlightSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 118);
            this.Controls.Add(this.Options);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FlightSearch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search by Flight and Arrival Date";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.Options.ResumeLayout(false);
            this.Options.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox SearchKey;
        private System.Windows.Forms.Button SearchBTN;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox Options;
        private System.Windows.Forms.Label FlightLBL;
        private System.Windows.Forms.Label DateLBL;
        private System.Windows.Forms.DateTimePicker Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn ArrivalDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn PassengerPhone;
    }
}