
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
            this.Update = new System.Windows.Forms.Button();
            this.BoligIdTextBox = new System.Windows.Forms.MaskedTextBox();
            this.BoligAdresseTextBox = new System.Windows.Forms.MaskedTextBox();
            this.BoligPostNrTextBox = new System.Windows.Forms.MaskedTextBox();
            this.KundeIdFKTextBox = new System.Windows.Forms.MaskedTextBox();
            this.BoligGrundM2TextBox = new System.Windows.Forms.MaskedTextBox();
            this.BoigHusM2TextBox = new System.Windows.Forms.MaskedTextBox();
            this.BoligPrisTextBox = new System.Windows.Forms.MaskedTextBox();
            this.BoligSalgsdatoTextBox = new System.Windows.Forms.MaskedTextBox();
            this.BoligOprettelsesTextBox = new System.Windows.Forms.MaskedTextBox();
            this.StandSkalaTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LæsBoligData = new System.Windows.Forms.Button();
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
            // Update
            // 
            this.Update.Location = new System.Drawing.Point(13, 66);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(75, 23);
            this.Update.TabIndex = 1;
            this.Update.Text = "Update";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // BoligIdTextBox
            // 
            this.BoligIdTextBox.Location = new System.Drawing.Point(261, 13);
            this.BoligIdTextBox.Mask = "00000";
            this.BoligIdTextBox.Name = "BoligIdTextBox";
            this.BoligIdTextBox.Size = new System.Drawing.Size(125, 23);
            this.BoligIdTextBox.TabIndex = 2;
            this.BoligIdTextBox.ValidatingType = typeof(int);
            // 
            // BoligAdresseTextBox
            // 
            this.BoligAdresseTextBox.Location = new System.Drawing.Point(120, 66);
            this.BoligAdresseTextBox.Mask = "LLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLL";
            this.BoligAdresseTextBox.Name = "BoligAdresseTextBox";
            this.BoligAdresseTextBox.Size = new System.Drawing.Size(125, 23);
            this.BoligAdresseTextBox.TabIndex = 3;
            // 
            // BoligPostNrTextBox
            // 
            this.BoligPostNrTextBox.Location = new System.Drawing.Point(120, 97);
            this.BoligPostNrTextBox.Mask = "0000";
            this.BoligPostNrTextBox.Name = "BoligPostNrTextBox";
            this.BoligPostNrTextBox.Size = new System.Drawing.Size(125, 23);
            this.BoligPostNrTextBox.TabIndex = 4;
            // 
            // KundeIdFKTextBox
            // 
            this.KundeIdFKTextBox.Location = new System.Drawing.Point(120, 304);
            this.KundeIdFKTextBox.Mask = "00000";
            this.KundeIdFKTextBox.Name = "KundeIdFKTextBox";
            this.KundeIdFKTextBox.Size = new System.Drawing.Size(125, 23);
            this.KundeIdFKTextBox.TabIndex = 5;
            // 
            // BoligGrundM2TextBox
            // 
            this.BoligGrundM2TextBox.Location = new System.Drawing.Point(120, 126);
            this.BoligGrundM2TextBox.Mask = "00000";
            this.BoligGrundM2TextBox.Name = "BoligGrundM2TextBox";
            this.BoligGrundM2TextBox.Size = new System.Drawing.Size(125, 23);
            this.BoligGrundM2TextBox.TabIndex = 6;
            // 
            // BoigHusM2TextBox
            // 
            this.BoigHusM2TextBox.Location = new System.Drawing.Point(120, 159);
            this.BoigHusM2TextBox.Mask = "00000";
            this.BoigHusM2TextBox.Name = "BoigHusM2TextBox";
            this.BoigHusM2TextBox.Size = new System.Drawing.Size(125, 23);
            this.BoigHusM2TextBox.TabIndex = 7;
            // 
            // BoligPrisTextBox
            // 
            this.BoligPrisTextBox.Location = new System.Drawing.Point(120, 188);
            this.BoligPrisTextBox.Mask = "000000000";
            this.BoligPrisTextBox.Name = "BoligPrisTextBox";
            this.BoligPrisTextBox.Size = new System.Drawing.Size(125, 23);
            this.BoligPrisTextBox.TabIndex = 8;
            this.BoligPrisTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // BoligSalgsdatoTextBox
            // 
            this.BoligSalgsdatoTextBox.Location = new System.Drawing.Point(120, 217);
            this.BoligSalgsdatoTextBox.Mask = "00/00/0000";
            this.BoligSalgsdatoTextBox.Name = "BoligSalgsdatoTextBox";
            this.BoligSalgsdatoTextBox.Size = new System.Drawing.Size(125, 23);
            this.BoligSalgsdatoTextBox.TabIndex = 9;
            // 
            // BoligOprettelsesTextBox
            // 
            this.BoligOprettelsesTextBox.Location = new System.Drawing.Point(120, 246);
            this.BoligOprettelsesTextBox.Mask = "00/00/0000";
            this.BoligOprettelsesTextBox.Name = "BoligOprettelsesTextBox";
            this.BoligOprettelsesTextBox.Size = new System.Drawing.Size(125, 23);
            this.BoligOprettelsesTextBox.TabIndex = 10;
            this.BoligOprettelsesTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // StandSkalaTextBox
            // 
            this.StandSkalaTextBox.Location = new System.Drawing.Point(120, 275);
            this.StandSkalaTextBox.Mask = "000000000";
            this.StandSkalaTextBox.Name = "StandSkalaTextBox";
            this.StandSkalaTextBox.Size = new System.Drawing.Size(125, 23);
            this.StandSkalaTextBox.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(240)))));
            this.label1.Location = new System.Drawing.Point(104, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 15);
            this.label1.TabIndex = 12;
            this.label1.Text = "Choose BoligId too update ";
            // 
            // LæsBoligData
            // 
            this.LæsBoligData.Location = new System.Drawing.Point(13, 96);
            this.LæsBoligData.Name = "LæsBoligData";
            this.LæsBoligData.Size = new System.Drawing.Size(96, 23);
            this.LæsBoligData.TabIndex = 13;
            this.LæsBoligData.Text = "Læs BoligData";
            this.LæsBoligData.UseVisualStyleBackColor = true;
            this.LæsBoligData.Click += new System.EventHandler(this.LæsBoligData_Click);
            // 
            // OpdaterBolig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(821, 450);
            this.Controls.Add(this.LæsBoligData);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.StandSkalaTextBox);
            this.Controls.Add(this.BoligOprettelsesTextBox);
            this.Controls.Add(this.BoligSalgsdatoTextBox);
            this.Controls.Add(this.BoligPrisTextBox);
            this.Controls.Add(this.BoigHusM2TextBox);
            this.Controls.Add(this.BoligGrundM2TextBox);
            this.Controls.Add(this.KundeIdFKTextBox);
            this.Controls.Add(this.BoligPostNrTextBox);
            this.Controls.Add(this.BoligAdresseTextBox);
            this.Controls.Add(this.BoligIdTextBox);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.button1);
            this.Name = "OpdaterBolig";
            this.Text = "Delete";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.MaskedTextBox BoligIdTextBox;
        private System.Windows.Forms.MaskedTextBox BoligAdresseTextBox;
        private System.Windows.Forms.MaskedTextBox BoligPostNrTextBox;
        private System.Windows.Forms.MaskedTextBox KundeIdFKTextBox;
        private System.Windows.Forms.MaskedTextBox BoligGrundM2TextBox;
        private System.Windows.Forms.MaskedTextBox BoigHusM2TextBox;
        private System.Windows.Forms.MaskedTextBox BoligPrisTextBox;
        private System.Windows.Forms.MaskedTextBox BoligSalgsdatoTextBox;
        private System.Windows.Forms.MaskedTextBox BoligOprettelsesTextBox;
        private System.Windows.Forms.MaskedTextBox StandSkalaTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button LæsBoligData;
    }
}