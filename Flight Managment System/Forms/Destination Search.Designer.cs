namespace Flight_Managment_System
{
    partial class Search_By_Destination
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
            this.SearchBTN = new System.Windows.Forms.Button();
            this.Destination = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.FlightNUMBER = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ArrivalDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GRB = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.GRB.SuspendLayout();
            this.SuspendLayout();
            // 
            // SearchBTN
            // 
            this.SearchBTN.Location = new System.Drawing.Point(183, 47);
            this.SearchBTN.Name = "SearchBTN";
            this.SearchBTN.Size = new System.Drawing.Size(72, 23);
            this.SearchBTN.TabIndex = 2;
            this.SearchBTN.Text = "Search";
            this.SearchBTN.UseVisualStyleBackColor = true;
            this.SearchBTN.Click += new System.EventHandler(this.button1_Click);
            // 
            // Destination
            // 
            this.Destination.Location = new System.Drawing.Point(10, 49);
            this.Destination.Name = "Destination";
            this.Destination.Size = new System.Drawing.Size(167, 20);
            this.Destination.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FlightNUMBER,
            this.ArrivalDate});
            this.dataGridView1.Location = new System.Drawing.Point(10, 94);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(245, 273);
            this.dataGridView1.TabIndex = 4;
            // 
            // FlightNUMBER
            // 
            this.FlightNUMBER.HeaderText = "Flight Number";
            this.FlightNUMBER.Name = "FlightNUMBER";
            this.FlightNUMBER.ReadOnly = true;
            // 
            // ArrivalDate
            // 
            this.ArrivalDate.HeaderText = "Arrival Date";
            this.ArrivalDate.Name = "ArrivalDate";
            this.ArrivalDate.ReadOnly = true;
            // 
            // GRB
            // 
            this.GRB.Controls.Add(this.label1);
            this.GRB.Controls.Add(this.Destination);
            this.GRB.Controls.Add(this.SearchBTN);
            this.GRB.Controls.Add(this.dataGridView1);
            this.GRB.Location = new System.Drawing.Point(12, 12);
            this.GRB.Name = "GRB";
            this.GRB.Size = new System.Drawing.Size(267, 91);
            this.GRB.TabIndex = 5;
            this.GRB.TabStop = false;
            this.GRB.Text = "Options";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Enter Destination:";
            // 
            // Search_By_Destination
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 115);
            this.Controls.Add(this.GRB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Search_By_Destination";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search By Destination";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.GRB.ResumeLayout(false);
            this.GRB.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SearchBTN;
        private System.Windows.Forms.TextBox Destination;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn FlightNUMBER;
        private System.Windows.Forms.DataGridViewTextBoxColumn ArrivalDate;
        private System.Windows.Forms.GroupBox GRB;
        private System.Windows.Forms.Label label1;

    }
}