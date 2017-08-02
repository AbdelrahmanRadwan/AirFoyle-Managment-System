namespace Flight_Managment_System
{
    partial class AddingPasseenger
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
            this.AddingDataSubmit = new System.Windows.Forms.Button();
            this.PassengerName = new System.Windows.Forms.TextBox();
            this.Phone = new System.Windows.Forms.TextBox();
            this.ClearFields = new System.Windows.Forms.Button();
            this.NameLeftChars = new System.Windows.Forms.Label();
            this.PhoneLeftCharsLabel = new System.Windows.Forms.Label();
            this.AvailableFlights = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // AddingDataSubmit
            // 
            this.AddingDataSubmit.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddingDataSubmit.Location = new System.Drawing.Point(660, 279);
            this.AddingDataSubmit.Name = "AddingDataSubmit";
            this.AddingDataSubmit.Size = new System.Drawing.Size(171, 37);
            this.AddingDataSubmit.TabIndex = 4;
            this.AddingDataSubmit.Text = "Submit";
            this.AddingDataSubmit.UseMnemonic = false;
            this.AddingDataSubmit.UseVisualStyleBackColor = true;
            this.AddingDataSubmit.Click += new System.EventHandler(this.AddingDataSubmit_Click);
            // 
            // PassengerName
            // 
            this.PassengerName.Location = new System.Drawing.Point(114, 126);
            this.PassengerName.Name = "PassengerName";
            this.PassengerName.Size = new System.Drawing.Size(162, 20);
            this.PassengerName.TabIndex = 0;
            this.PassengerName.TextChanged += new System.EventHandler(this.PassengerName_TextChanged);
            // 
            // Phone
            // 
            this.Phone.Location = new System.Drawing.Point(114, 169);
            this.Phone.Name = "Phone";
            this.Phone.Size = new System.Drawing.Size(162, 20);
            this.Phone.TabIndex = 1;
            this.Phone.TextChanged += new System.EventHandler(this.Phone_TextChanged);
            // 
            // ClearFields
            // 
            this.ClearFields.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearFields.Location = new System.Drawing.Point(473, 279);
            this.ClearFields.Name = "ClearFields";
            this.ClearFields.Size = new System.Drawing.Size(171, 37);
            this.ClearFields.TabIndex = 3;
            this.ClearFields.Text = "Clear All Fields";
            this.ClearFields.UseVisualStyleBackColor = true;
            this.ClearFields.Click += new System.EventHandler(this.ClearFields_Click);
            // 
            // NameLeftChars
            // 
            this.NameLeftChars.AutoSize = true;
            this.NameLeftChars.BackColor = System.Drawing.Color.Transparent;
            this.NameLeftChars.Location = new System.Drawing.Point(269, 124);
            this.NameLeftChars.Name = "NameLeftChars";
            this.NameLeftChars.Size = new System.Drawing.Size(0, 13);
            this.NameLeftChars.TabIndex = 7;
            // 
            // PhoneLeftCharsLabel
            // 
            this.PhoneLeftCharsLabel.AutoSize = true;
            this.PhoneLeftCharsLabel.BackColor = System.Drawing.Color.Transparent;
            this.PhoneLeftCharsLabel.Location = new System.Drawing.Point(269, 174);
            this.PhoneLeftCharsLabel.Name = "PhoneLeftCharsLabel";
            this.PhoneLeftCharsLabel.Size = new System.Drawing.Size(0, 13);
            this.PhoneLeftCharsLabel.TabIndex = 13;
            // 
            // AvailableFlights
            // 
            this.AvailableFlights.FormattingEnabled = true;
            this.AvailableFlights.Location = new System.Drawing.Point(114, 213);
            this.AvailableFlights.Name = "AvailableFlights";
            this.AvailableFlights.Size = new System.Drawing.Size(162, 21);
            this.AvailableFlights.TabIndex = 2;
            this.AvailableFlights.Text = "Available Flights";
            // 
            // AddingPasseenger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Flight_Managment_System.Properties.Resources.Passenger2;
            this.ClientSize = new System.Drawing.Size(850, 331);
            this.Controls.Add(this.AvailableFlights);
            this.Controls.Add(this.PhoneLeftCharsLabel);
            this.Controls.Add(this.NameLeftChars);
            this.Controls.Add(this.ClearFields);
            this.Controls.Add(this.Phone);
            this.Controls.Add(this.PassengerName);
            this.Controls.Add(this.AddingDataSubmit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "AddingPasseenger";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adding A Passenger";
            this.Load += new System.EventHandler(this.AddingData_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddingDataSubmit;
        private System.Windows.Forms.TextBox PassengerName;
        private System.Windows.Forms.TextBox Phone;
        private System.Windows.Forms.Button ClearFields;
        private System.Windows.Forms.Label NameLeftChars;
        private System.Windows.Forms.Label PhoneLeftCharsLabel;
        private System.Windows.Forms.ComboBox AvailableFlights;
    }
}