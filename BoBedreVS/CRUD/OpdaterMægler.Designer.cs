
namespace BoBedreVS
{
    partial class OpdaterMægler
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
            this.button1 = new System.Windows.Forms.Button();
            this.LæsMælgerData = new System.Windows.Forms.Button();
            this.MedarbejderIdTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.MælgerNavnTextBox = new System.Windows.Forms.MaskedTextBox();
            this.MæglerTlfTextBox3 = new System.Windows.Forms.MaskedTextBox();
            this.MæglerMailTextBox4 = new System.Windows.Forms.MaskedTextBox();
            this.MæglerStillingTextBox5 = new System.Windows.Forms.MaskedTextBox();
            this.UpdateMælger = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LæsMælgerData
            // 
            this.LæsMælgerData.Location = new System.Drawing.Point(12, 42);
            this.LæsMælgerData.Name = "LæsMælgerData";
            this.LæsMælgerData.Size = new System.Drawing.Size(108, 23);
            this.LæsMælgerData.TabIndex = 1;
            this.LæsMælgerData.Text = "Læs Mælger Data";
            this.LæsMælgerData.UseVisualStyleBackColor = true;
            this.LæsMælgerData.Click += new System.EventHandler(this.LæsMælgerData_Click);
            // 
            // MedarbejderIdTextBox1
            // 
            this.MedarbejderIdTextBox1.Location = new System.Drawing.Point(173, 41);
            this.MedarbejderIdTextBox1.Mask = "000000";
            this.MedarbejderIdTextBox1.Name = "MedarbejderIdTextBox1";
            this.MedarbejderIdTextBox1.Size = new System.Drawing.Size(100, 23);
            this.MedarbejderIdTextBox1.TabIndex = 2;
            // 
            // MælgerNavnTextBox
            // 
            this.MælgerNavnTextBox.Location = new System.Drawing.Point(173, 71);
            this.MælgerNavnTextBox.Mask = "LLLLLLLLLLLLLLLLLLLLLLLLLLLLLL";
            this.MælgerNavnTextBox.Name = "MælgerNavnTextBox";
            this.MælgerNavnTextBox.Size = new System.Drawing.Size(100, 23);
            this.MælgerNavnTextBox.TabIndex = 3;
            // 
            // MæglerTlfTextBox3
            // 
            this.MæglerTlfTextBox3.Location = new System.Drawing.Point(173, 101);
            this.MæglerTlfTextBox3.Mask = "0000000000";
            this.MæglerTlfTextBox3.Name = "MæglerTlfTextBox3";
            this.MæglerTlfTextBox3.Size = new System.Drawing.Size(100, 23);
            this.MæglerTlfTextBox3.TabIndex = 4;
            // 
            // MæglerMailTextBox4
            // 
            this.MæglerMailTextBox4.Location = new System.Drawing.Point(173, 131);
            this.MæglerMailTextBox4.Mask = "LLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLL";
            this.MæglerMailTextBox4.Name = "MæglerMailTextBox4";
            this.MæglerMailTextBox4.Size = new System.Drawing.Size(100, 23);
            this.MæglerMailTextBox4.TabIndex = 5;
            // 
            // MæglerStillingTextBox5
            // 
            this.MæglerStillingTextBox5.Location = new System.Drawing.Point(173, 161);
            this.MæglerStillingTextBox5.Mask = "LLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLL";
            this.MæglerStillingTextBox5.Name = "MæglerStillingTextBox5";
            this.MæglerStillingTextBox5.Size = new System.Drawing.Size(100, 23);
            this.MæglerStillingTextBox5.TabIndex = 6;
            // 
            // UpdateMælger
            // 
            this.UpdateMælger.Location = new System.Drawing.Point(12, 70);
            this.UpdateMælger.Name = "UpdateMælger";
            this.UpdateMælger.Size = new System.Drawing.Size(75, 23);
            this.UpdateMælger.TabIndex = 7;
            this.UpdateMælger.Text = "Update";
            this.UpdateMælger.UseVisualStyleBackColor = true;
            this.UpdateMælger.Click += new System.EventHandler(this.UpdateMælger_Click);
            // 
            // OpdaterMægler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.UpdateMælger);
            this.Controls.Add(this.MæglerStillingTextBox5);
            this.Controls.Add(this.MæglerMailTextBox4);
            this.Controls.Add(this.MæglerTlfTextBox3);
            this.Controls.Add(this.MælgerNavnTextBox);
            this.Controls.Add(this.MedarbejderIdTextBox1);
            this.Controls.Add(this.LæsMælgerData);
            this.Controls.Add(this.button1);
            this.Name = "OpdaterMægler";
            this.Text = "OpdaterMægler";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button LæsMælgerData;
        private System.Windows.Forms.MaskedTextBox MedarbejderIdTextBox1;
        private System.Windows.Forms.MaskedTextBox MælgerNavnTextBox;
        private System.Windows.Forms.MaskedTextBox MæglerTlfTextBox3;
        private System.Windows.Forms.MaskedTextBox MæglerMailTextBox4;
        private System.Windows.Forms.MaskedTextBox MæglerStillingTextBox5;
        private System.Windows.Forms.Button UpdateMælger;
    }
}