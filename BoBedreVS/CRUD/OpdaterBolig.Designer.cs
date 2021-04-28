
namespace BoBedreVS
{
    partial class OpdaterBolig
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
            this.AdresseTextBox = new System.Windows.Forms.TextBox();
            this.PostNrTextBox = new System.Windows.Forms.MaskedTextBox();
            this.GrundM2TextBox = new System.Windows.Forms.MaskedTextBox();
            this.HusM2TextBox = new System.Windows.Forms.MaskedTextBox();
            this.PrisTextBox = new System.Windows.Forms.MaskedTextBox();
            this.SalgsDatoTextBox = new System.Windows.Forms.TextBox();
            this.OprettelsesDatoTextBox = new System.Windows.Forms.TextBox();
            this.StandSkalaTextBox = new System.Windows.Forms.MaskedTextBox();
            this.KundeIdTextBox = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(36, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AdresseTextBox
            // 
            this.AdresseTextBox.Location = new System.Drawing.Point(275, 51);
            this.AdresseTextBox.Name = "AdresseTextBox";
            this.AdresseTextBox.Size = new System.Drawing.Size(100, 23);
            this.AdresseTextBox.TabIndex = 1;
            // 
            // PostNrTextBox
            // 
            this.PostNrTextBox.Location = new System.Drawing.Point(275, 91);
            this.PostNrTextBox.Name = "PostNrTextBox";
            this.PostNrTextBox.Size = new System.Drawing.Size(100, 23);
            this.PostNrTextBox.TabIndex = 2;
            // 
            // GrundM2TextBox
            // 
            this.GrundM2TextBox.Location = new System.Drawing.Point(275, 132);
            this.GrundM2TextBox.Name = "GrundM2TextBox";
            this.GrundM2TextBox.Size = new System.Drawing.Size(100, 23);
            this.GrundM2TextBox.TabIndex = 3;
            // 
            // HusM2TextBox
            // 
            this.HusM2TextBox.Location = new System.Drawing.Point(275, 175);
            this.HusM2TextBox.Name = "HusM2TextBox";
            this.HusM2TextBox.Size = new System.Drawing.Size(100, 23);
            this.HusM2TextBox.TabIndex = 4;
            // 
            // PrisTextBox
            // 
            this.PrisTextBox.Location = new System.Drawing.Point(275, 217);
            this.PrisTextBox.Name = "PrisTextBox";
            this.PrisTextBox.Size = new System.Drawing.Size(100, 23);
            this.PrisTextBox.TabIndex = 5;
            // 
            // SalgsDatoTextBox
            // 
            this.SalgsDatoTextBox.Location = new System.Drawing.Point(275, 261);
            this.SalgsDatoTextBox.Name = "SalgsDatoTextBox";
            this.SalgsDatoTextBox.Size = new System.Drawing.Size(100, 23);
            this.SalgsDatoTextBox.TabIndex = 6;
            // 
            // OprettelsesDatoTextBox
            // 
            this.OprettelsesDatoTextBox.Location = new System.Drawing.Point(275, 304);
            this.OprettelsesDatoTextBox.Name = "OprettelsesDatoTextBox";
            this.OprettelsesDatoTextBox.Size = new System.Drawing.Size(100, 23);
            this.OprettelsesDatoTextBox.TabIndex = 7;
            // 
            // StandSkalaTextBox
            // 
            this.StandSkalaTextBox.Location = new System.Drawing.Point(275, 348);
            this.StandSkalaTextBox.Name = "StandSkalaTextBox";
            this.StandSkalaTextBox.Size = new System.Drawing.Size(100, 23);
            this.StandSkalaTextBox.TabIndex = 8;
            // 
            // KundeIdTextBox
            // 
            this.KundeIdTextBox.Location = new System.Drawing.Point(275, 391);
            this.KundeIdTextBox.Name = "KundeIdTextBox";
            this.KundeIdTextBox.Size = new System.Drawing.Size(100, 23);
            this.KundeIdTextBox.TabIndex = 9;
            // 
            // OpdaterBolig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.KundeIdTextBox);
            this.Controls.Add(this.StandSkalaTextBox);
            this.Controls.Add(this.OprettelsesDatoTextBox);
            this.Controls.Add(this.SalgsDatoTextBox);
            this.Controls.Add(this.PrisTextBox);
            this.Controls.Add(this.HusM2TextBox);
            this.Controls.Add(this.GrundM2TextBox);
            this.Controls.Add(this.PostNrTextBox);
            this.Controls.Add(this.AdresseTextBox);
            this.Controls.Add(this.button1);
            this.Name = "OpdaterBolig";
            this.Text = "OpdaterBolig";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox AdresseTextBox;
        private System.Windows.Forms.MaskedTextBox PostNrTextBox;
        private System.Windows.Forms.MaskedTextBox GrundM2TextBox;
        private System.Windows.Forms.MaskedTextBox HusM2TextBox;
        private System.Windows.Forms.MaskedTextBox PrisTextBox;
        private System.Windows.Forms.TextBox SalgsDatoTextBox;
        private System.Windows.Forms.TextBox OprettelsesDatoTextBox;
        private System.Windows.Forms.MaskedTextBox StandSkalaTextBox;
        private System.Windows.Forms.MaskedTextBox KundeIdTextBox;
    }
}