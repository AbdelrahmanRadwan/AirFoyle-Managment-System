namespace Flight_Managment_System
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.AddPassengerBTN = new System.Windows.Forms.Button();
            this.SycnBTN = new System.Windows.Forms.Button();
            this.ServerLoggingBTN = new System.Windows.Forms.Button();
            this.ConfigBTN = new System.Windows.Forms.Button();
            this.RefreshBTN = new System.Windows.Forms.Button();
            this.AddFlightBTN = new System.Windows.Forms.Button();
            this.RegistredPassengers = new System.Windows.Forms.DataGridView();
            this.FlightNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PassengerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PassengerPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeleteFlightBTN = new System.Windows.Forms.Button();
            this.SearchBTN = new System.Windows.Forms.Button();
            this.SearchByDropDown = new System.Windows.Forms.ComboBox();
            this.PassengersLBL = new System.Windows.Forms.Label();
            this.SearchLBL = new System.Windows.Forms.Label();
            this.FlightsLBL = new System.Windows.Forms.Label();
            this.RegistredFlights = new System.Windows.Forms.DataGridView();
            this.FlightNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Destination = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.RegistredPassengers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RegistredFlights)).BeginInit();
            this.SuspendLayout();
            // 
            // AddPassengerBTN
            // 
            this.AddPassengerBTN.BackgroundImage = global::Flight_Managment_System.Properties.Resources.add_user;
            this.AddPassengerBTN.Location = new System.Drawing.Point(600, 188);
            this.AddPassengerBTN.Name = "AddPassengerBTN";
            this.AddPassengerBTN.Size = new System.Drawing.Size(50, 50);
            this.AddPassengerBTN.TabIndex = 0;
            this.AddPassengerBTN.UseVisualStyleBackColor = true;
            this.AddPassengerBTN.Click += new System.EventHandler(this.AddPassengerBTN_Click);
            // 
            // SycnBTN
            // 
            this.SycnBTN.BackgroundImage = global::Flight_Managment_System.Properties.Resources.Cloud_syncoff;
            this.SycnBTN.Location = new System.Drawing.Point(545, 189);
            this.SycnBTN.Name = "SycnBTN";
            this.SycnBTN.Size = new System.Drawing.Size(50, 50);
            this.SycnBTN.TabIndex = 1;
            this.SycnBTN.UseVisualStyleBackColor = true;
            this.SycnBTN.Click += new System.EventHandler(this.SycnBTN_Click);
            // 
            // ServerLoggingBTN
            // 
            this.ServerLoggingBTN.BackgroundImage = global::Flight_Managment_System.Properties.Resources.server;
            this.ServerLoggingBTN.Location = new System.Drawing.Point(768, 188);
            this.ServerLoggingBTN.Name = "ServerLoggingBTN";
            this.ServerLoggingBTN.Size = new System.Drawing.Size(50, 50);
            this.ServerLoggingBTN.TabIndex = 4;
            this.ServerLoggingBTN.UseVisualStyleBackColor = true;
            this.ServerLoggingBTN.Click += new System.EventHandler(this.ServerDataBTN_Click);
            // 
            // ConfigBTN
            // 
            this.ConfigBTN.BackgroundImage = global::Flight_Managment_System.Properties.Resources.preferences_settings_tools_128;
            this.ConfigBTN.Location = new System.Drawing.Point(824, 188);
            this.ConfigBTN.Name = "ConfigBTN";
            this.ConfigBTN.Size = new System.Drawing.Size(50, 50);
            this.ConfigBTN.TabIndex = 6;
            this.ConfigBTN.UseVisualStyleBackColor = true;
            this.ConfigBTN.Click += new System.EventHandler(this.SystemConfigBTN_Click);
            // 
            // RefreshBTN
            // 
            this.RefreshBTN.BackgroundImage = global::Flight_Managment_System.Properties.Resources.refresh_icon1;
            this.RefreshBTN.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.RefreshBTN.Location = new System.Drawing.Point(490, 188);
            this.RefreshBTN.Name = "RefreshBTN";
            this.RefreshBTN.Size = new System.Drawing.Size(50, 50);
            this.RefreshBTN.TabIndex = 8;
            this.RefreshBTN.UseVisualStyleBackColor = true;
            this.RefreshBTN.Click += new System.EventHandler(this.RefreshBTN_Click);
            // 
            // AddFlightBTN
            // 
            this.AddFlightBTN.BackgroundImage = global::Flight_Managment_System.Properties.Resources.Flght1;
            this.AddFlightBTN.Location = new System.Drawing.Point(656, 188);
            this.AddFlightBTN.Name = "AddFlightBTN";
            this.AddFlightBTN.Size = new System.Drawing.Size(50, 50);
            this.AddFlightBTN.TabIndex = 9;
            this.AddFlightBTN.UseVisualStyleBackColor = true;
            this.AddFlightBTN.Click += new System.EventHandler(this.AddFlightBTN_Click);
            // 
            // RegistredPassengers
            // 
            this.RegistredPassengers.AllowUserToAddRows = false;
            this.RegistredPassengers.AllowUserToDeleteRows = false;
            this.RegistredPassengers.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.RegistredPassengers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RegistredPassengers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FlightNO,
            this.PassengerName,
            this.PassengerPhone});
            this.RegistredPassengers.Location = new System.Drawing.Point(52, 208);
            this.RegistredPassengers.Name = "RegistredPassengers";
            this.RegistredPassengers.ReadOnly = true;
            this.RegistredPassengers.Size = new System.Drawing.Size(361, 361);
            this.RegistredPassengers.TabIndex = 10;
            // 
            // FlightNO
            // 
            this.FlightNO.HeaderText = "Passenger Name";
            this.FlightNO.Name = "FlightNO";
            this.FlightNO.ReadOnly = true;
            // 
            // PassengerName
            // 
            this.PassengerName.HeaderText = "Passenger Phone";
            this.PassengerName.Name = "PassengerName";
            this.PassengerName.ReadOnly = true;
            // 
            // PassengerPhone
            // 
            this.PassengerPhone.HeaderText = "Flight No";
            this.PassengerPhone.Name = "PassengerPhone";
            this.PassengerPhone.ReadOnly = true;
            // 
            // DeleteFlightBTN
            // 
            this.DeleteFlightBTN.BackgroundImage = global::Flight_Managment_System.Properties.Resources.Delete;
            this.DeleteFlightBTN.Location = new System.Drawing.Point(712, 188);
            this.DeleteFlightBTN.Name = "DeleteFlightBTN";
            this.DeleteFlightBTN.Size = new System.Drawing.Size(50, 50);
            this.DeleteFlightBTN.TabIndex = 13;
            this.DeleteFlightBTN.UseVisualStyleBackColor = true;
            this.DeleteFlightBTN.Click += new System.EventHandler(this.DeleteFlightBTN_Click);
            // 
            // SearchBTN
            // 
            this.SearchBTN.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBTN.Location = new System.Drawing.Point(546, 117);
            this.SearchBTN.Name = "SearchBTN";
            this.SearchBTN.Size = new System.Drawing.Size(169, 23);
            this.SearchBTN.TabIndex = 14;
            this.SearchBTN.Text = "Search ";
            this.SearchBTN.UseVisualStyleBackColor = true;
            this.SearchBTN.Click += new System.EventHandler(this.SearchBTN_Click);
            // 
            // SearchByDropDown
            // 
            this.SearchByDropDown.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchByDropDown.FormattingEnabled = true;
            this.SearchByDropDown.Items.AddRange(new object[] {
            "Destination",
            "Flight and Arrival Date"});
            this.SearchByDropDown.Location = new System.Drawing.Point(228, 117);
            this.SearchByDropDown.Name = "SearchByDropDown";
            this.SearchByDropDown.Size = new System.Drawing.Size(312, 23);
            this.SearchByDropDown.TabIndex = 15;
            this.SearchByDropDown.Text = "Search By ..";
            // 
            // PassengersLBL
            // 
            this.PassengersLBL.AutoSize = true;
            this.PassengersLBL.BackColor = System.Drawing.Color.Transparent;
            this.PassengersLBL.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PassengersLBL.Location = new System.Drawing.Point(155, 189);
            this.PassengersLBL.Name = "PassengersLBL";
            this.PassengersLBL.Size = new System.Drawing.Size(150, 15);
            this.PassengersLBL.TabIndex = 16;
            this.PassengersLBL.Text = "Registred Passengers";
            // 
            // SearchLBL
            // 
            this.SearchLBL.AutoSize = true;
            this.SearchLBL.BackColor = System.Drawing.Color.Transparent;
            this.SearchLBL.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchLBL.Location = new System.Drawing.Point(432, 95);
            this.SearchLBL.Name = "SearchLBL";
            this.SearchLBL.Size = new System.Drawing.Size(53, 15);
            this.SearchLBL.TabIndex = 17;
            this.SearchLBL.Text = "Search";
            // 
            // FlightsLBL
            // 
            this.FlightsLBL.AutoSize = true;
            this.FlightsLBL.BackColor = System.Drawing.Color.Transparent;
            this.FlightsLBL.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FlightsLBL.Location = new System.Drawing.Point(618, 271);
            this.FlightsLBL.Name = "FlightsLBL";
            this.FlightsLBL.Size = new System.Drawing.Size(118, 15);
            this.FlightsLBL.TabIndex = 18;
            this.FlightsLBL.Text = "Registred Flights";
            // 
            // RegistredFlights
            // 
            this.RegistredFlights.AllowUserToAddRows = false;
            this.RegistredFlights.AllowUserToDeleteRows = false;
            this.RegistredFlights.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.RegistredFlights.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RegistredFlights.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FlightNumber,
            this.Destination,
            this.Date});
            this.RegistredFlights.Location = new System.Drawing.Point(456, 290);
            this.RegistredFlights.Name = "RegistredFlights";
            this.RegistredFlights.ReadOnly = true;
            this.RegistredFlights.Size = new System.Drawing.Size(453, 270);
            this.RegistredFlights.TabIndex = 0;
            this.RegistredFlights.TabStop = false;
            // 
            // FlightNumber
            // 
            this.FlightNumber.HeaderText = "Flight Number";
            this.FlightNumber.Name = "FlightNumber";
            this.FlightNumber.ReadOnly = true;
            this.FlightNumber.Width = 180;
            // 
            // Destination
            // 
            this.Destination.HeaderText = "Destination";
            this.Destination.Name = "Destination";
            this.Destination.ReadOnly = true;
            this.Destination.Width = 112;
            // 
            // Date
            // 
            this.Date.HeaderText = "Arrival Date";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(956, 619);
            this.Controls.Add(this.RegistredFlights);
            this.Controls.Add(this.FlightsLBL);
            this.Controls.Add(this.SearchLBL);
            this.Controls.Add(this.PassengersLBL);
            this.Controls.Add(this.SearchByDropDown);
            this.Controls.Add(this.SearchBTN);
            this.Controls.Add(this.DeleteFlightBTN);
            this.Controls.Add(this.RegistredPassengers);
            this.Controls.Add(this.AddFlightBTN);
            this.Controls.Add(this.RefreshBTN);
            this.Controls.Add(this.ConfigBTN);
            this.Controls.Add(this.ServerLoggingBTN);
            this.Controls.Add(this.SycnBTN);
            this.Controls.Add(this.AddPassengerBTN);
            this.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AirFoyle Managment System";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RegistredPassengers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RegistredFlights)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddPassengerBTN;
        private System.Windows.Forms.Button SycnBTN;
        private System.Windows.Forms.Button ServerLoggingBTN;
        private System.Windows.Forms.Button ConfigBTN;
        private System.Windows.Forms.Button RefreshBTN;
        private System.Windows.Forms.Button AddFlightBTN;
        private System.Windows.Forms.DataGridView RegistredPassengers;
        private System.Windows.Forms.Button DeleteFlightBTN;
        private System.Windows.Forms.Button SearchBTN;
        private System.Windows.Forms.ComboBox SearchByDropDown;
        private System.Windows.Forms.Label PassengersLBL;
        private System.Windows.Forms.Label SearchLBL;
        private System.Windows.Forms.Label FlightsLBL;
        private System.Windows.Forms.DataGridView RegistredFlights;
        private System.Windows.Forms.DataGridViewTextBoxColumn FlightNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Destination;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn FlightNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn PassengerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PassengerPhone;
    }
}

