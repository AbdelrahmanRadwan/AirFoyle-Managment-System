namespace Flight_Managment_System
{
    partial class AdvancedConfigurations
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AutoSycn = new System.Windows.Forms.RadioButton();
            this.ManSycn = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SystemID = new System.Windows.Forms.NumericUpDown();
            this.SaveBTN = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SystemID)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "System ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Synchronization Mode";
            // 
            // AutoSycn
            // 
            this.AutoSycn.AutoSize = true;
            this.AutoSycn.Location = new System.Drawing.Point(12, 99);
            this.AutoSycn.Name = "AutoSycn";
            this.AutoSycn.Size = new System.Drawing.Size(51, 19);
            this.AutoSycn.TabIndex = 3;
            this.AutoSycn.TabStop = true;
            this.AutoSycn.Text = "Auto";
            this.AutoSycn.UseVisualStyleBackColor = true;
            // 
            // ManSycn
            // 
            this.ManSycn.AutoSize = true;
            this.ManSycn.Location = new System.Drawing.Point(79, 99);
            this.ManSycn.Name = "ManSycn";
            this.ManSycn.Size = new System.Drawing.Size(65, 19);
            this.ManSycn.TabIndex = 4;
            this.ManSycn.TabStop = true;
            this.ManSycn.Text = "Manual";
            this.ManSycn.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SystemID);
            this.groupBox1.Controls.Add(this.SaveBTN);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.ManSycn);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.AutoSycn);
            this.groupBox1.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(14, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(381, 183);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Options";
            // 
            // SystemID
            // 
            this.SystemID.AllowDrop = true;
            this.SystemID.Location = new System.Drawing.Point(84, 25);
            this.SystemID.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.SystemID.Name = "SystemID";
            this.SystemID.Size = new System.Drawing.Size(70, 21);
            this.SystemID.TabIndex = 6;
            // 
            // SaveBTN
            // 
            this.SaveBTN.Location = new System.Drawing.Point(131, 140);
            this.SaveBTN.Name = "SaveBTN";
            this.SaveBTN.Size = new System.Drawing.Size(117, 27);
            this.SaveBTN.TabIndex = 5;
            this.SaveBTN.Text = "Save";
            this.SaveBTN.UseVisualStyleBackColor = true;
            this.SaveBTN.Click += new System.EventHandler(this.SaveBTN_Click);
            // 
            // AdvancedConfigurations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 211);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "AdvancedConfigurations";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Advanced Configurations";
            this.Load += new System.EventHandler(this.AdvancedConfigurations_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SystemID)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton AutoSycn;
        private System.Windows.Forms.RadioButton ManSycn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button SaveBTN;
        private System.Windows.Forms.NumericUpDown SystemID;
    }
}