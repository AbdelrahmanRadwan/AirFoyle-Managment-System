namespace Flight_Managment_System
{
    partial class AddingFlight
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
            this.MainTimePicker = new System.Windows.Forms.DateTimePicker();
            this.DestinationLeftCharsLabel = new System.Windows.Forms.Label();
            this.FlightNoLeftCharsLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Destination = new System.Windows.Forms.TextBox();
            this.FlightNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ClearFields = new System.Windows.Forms.Button();
            this.AddingDataSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MainTimePicker
            // 
            this.MainTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.MainTimePicker.Location = new System.Drawing.Point(137, 234);
            this.MainTimePicker.Name = "MainTimePicker";
            this.MainTimePicker.Size = new System.Drawing.Size(161, 20);
            this.MainTimePicker.TabIndex = 19;
            // 
            // DestinationLeftCharsLabel
            // 
            this.DestinationLeftCharsLabel.AutoSize = true;
            this.DestinationLeftCharsLabel.BackColor = System.Drawing.Color.Transparent;
            this.DestinationLeftCharsLabel.Location = new System.Drawing.Point(305, 187);
            this.DestinationLeftCharsLabel.Name = "DestinationLeftCharsLabel";
            this.DestinationLeftCharsLabel.Size = new System.Drawing.Size(0, 13);
            this.DestinationLeftCharsLabel.TabIndex = 24;
            // 
            // FlightNoLeftCharsLabel
            // 
            this.FlightNoLeftCharsLabel.AutoSize = true;
            this.FlightNoLeftCharsLabel.BackColor = System.Drawing.Color.Transparent;
            this.FlightNoLeftCharsLabel.Location = new System.Drawing.Point(305, 139);
            this.FlightNoLeftCharsLabel.Name = "FlightNoLeftCharsLabel";
            this.FlightNoLeftCharsLabel.Size = new System.Drawing.Size(0, 13);
            this.FlightNoLeftCharsLabel.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(321, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 15);
            this.label4.TabIndex = 22;
            this.label4.Text = "Characters Left";
            // 
            // Destination
            // 
            this.Destination.Location = new System.Drawing.Point(136, 184);
            this.Destination.Name = "Destination";
            this.Destination.Size = new System.Drawing.Size(162, 20);
            this.Destination.TabIndex = 18;
            this.Destination.TextChanged += new System.EventHandler(this.Destination_TextChanged);
            // 
            // FlightNumber
            // 
            this.FlightNumber.Location = new System.Drawing.Point(136, 135);
            this.FlightNumber.Name = "FlightNumber";
            this.FlightNumber.Size = new System.Drawing.Size(162, 20);
            this.FlightNumber.TabIndex = 17;
            this.FlightNumber.TextChanged += new System.EventHandler(this.FlightNumber_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(321, 187);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 15);
            this.label1.TabIndex = 20;
            this.label1.Text = "Characters Left";
            // 
            // ClearFields
            // 
            this.ClearFields.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearFields.Location = new System.Drawing.Point(470, 292);
            this.ClearFields.Name = "ClearFields";
            this.ClearFields.Size = new System.Drawing.Size(171, 37);
            this.ClearFields.TabIndex = 26;
            this.ClearFields.Text = "Clear All Fields";
            this.ClearFields.UseVisualStyleBackColor = true;
            this.ClearFields.Click += new System.EventHandler(this.ClearFields_Click);
            // 
            // AddingDataSubmit
            // 
            this.AddingDataSubmit.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddingDataSubmit.Location = new System.Drawing.Point(660, 292);
            this.AddingDataSubmit.Name = "AddingDataSubmit";
            this.AddingDataSubmit.Size = new System.Drawing.Size(171, 37);
            this.AddingDataSubmit.TabIndex = 27;
            this.AddingDataSubmit.Text = "Submit";
            this.AddingDataSubmit.UseMnemonic = false;
            this.AddingDataSubmit.UseVisualStyleBackColor = true;
            this.AddingDataSubmit.Click += new System.EventHandler(this.AddingDataSubmit_Click);
            // 
            // AddingFlight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Flight_Managment_System.Properties.Resources.Flght;
            this.ClientSize = new System.Drawing.Size(848, 351);
            this.Controls.Add(this.ClearFields);
            this.Controls.Add(this.AddingDataSubmit);
            this.Controls.Add(this.MainTimePicker);
            this.Controls.Add(this.DestinationLeftCharsLabel);
            this.Controls.Add(this.FlightNoLeftCharsLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Destination);
            this.Controls.Add(this.FlightNumber);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "AddingFlight";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adding A Flight";
            this.Load += new System.EventHandler(this.Addingflight_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker MainTimePicker;
        private System.Windows.Forms.Label DestinationLeftCharsLabel;
        private System.Windows.Forms.Label FlightNoLeftCharsLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Destination;
        private System.Windows.Forms.TextBox FlightNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ClearFields;
        private System.Windows.Forms.Button AddingDataSubmit;
    }
}