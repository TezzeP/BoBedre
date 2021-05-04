
namespace BoBedreVS
{
    partial class OpdaterKunde
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
            this.KundeNavnTextBox = new System.Windows.Forms.MaskedTextBox();
            this.KundeTelnrTextBox = new System.Windows.Forms.MaskedTextBox();
            this.KundeMailTextBox = new System.Windows.Forms.MaskedTextBox();
            this.KundeAdresseTextBox = new System.Windows.Forms.MaskedTextBox();
            this.KøberCB = new System.Windows.Forms.CheckBox();
            this.SælgerCB = new System.Windows.Forms.CheckBox();
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
            this.Update.Location = new System.Drawing.Point(13, 43);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(75, 23);
            this.Update.TabIndex = 1;
            this.Update.Text = "Update";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // KundeNavnTextBox
            // 
            this.KundeNavnTextBox.Location = new System.Drawing.Point(138, 44);
            this.KundeNavnTextBox.Name = "KundeNavnTextBox";
            this.KundeNavnTextBox.Size = new System.Drawing.Size(125, 23);
            this.KundeNavnTextBox.TabIndex = 2;
            // 
            // KundeTelnrTextBox
            // 
            this.KundeTelnrTextBox.Location = new System.Drawing.Point(138, 73);
            this.KundeTelnrTextBox.Name = "KundeTelnrTextBox";
            this.KundeTelnrTextBox.Size = new System.Drawing.Size(125, 23);
            this.KundeTelnrTextBox.TabIndex = 3;
            // 
            // KundeMailTextBox
            // 
            this.KundeMailTextBox.Location = new System.Drawing.Point(138, 102);
            this.KundeMailTextBox.Name = "KundeMailTextBox";
            this.KundeMailTextBox.Size = new System.Drawing.Size(125, 23);
            this.KundeMailTextBox.TabIndex = 4;
            // 
            // KundeAdresseTextBox
            // 
            this.KundeAdresseTextBox.Location = new System.Drawing.Point(138, 131);
            this.KundeAdresseTextBox.Name = "KundeAdresseTextBox";
            this.KundeAdresseTextBox.Size = new System.Drawing.Size(125, 23);
            this.KundeAdresseTextBox.TabIndex = 5;
            // 
            // KøberCB
            // 
            this.KøberCB.AutoSize = true;
            this.KøberCB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(240)))));
            this.KøberCB.Location = new System.Drawing.Point(138, 174);
            this.KøberCB.Name = "KøberCB";
            this.KøberCB.Size = new System.Drawing.Size(57, 19);
            this.KøberCB.TabIndex = 6;
            this.KøberCB.Text = "Køber";
            this.KøberCB.UseVisualStyleBackColor = true;
            // 
            // SælgerCB
            // 
            this.SælgerCB.AutoSize = true;
            this.SælgerCB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(240)))));
            this.SælgerCB.Location = new System.Drawing.Point(138, 215);
            this.SælgerCB.Name = "SælgerCB";
            this.SælgerCB.Size = new System.Drawing.Size(62, 19);
            this.SælgerCB.TabIndex = 7;
            this.SælgerCB.Text = "Sælger";
            this.SælgerCB.UseVisualStyleBackColor = true;
            // 
            // OpdaterKunde
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SælgerCB);
            this.Controls.Add(this.KøberCB);
            this.Controls.Add(this.KundeAdresseTextBox);
            this.Controls.Add(this.KundeMailTextBox);
            this.Controls.Add(this.KundeTelnrTextBox);
            this.Controls.Add(this.KundeNavnTextBox);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.button1);
            this.Name = "OpdaterKunde";
            this.Text = "Update";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.MaskedTextBox KundeNavnTextBox;
        private System.Windows.Forms.MaskedTextBox KundeTelnrTextBox;
        private System.Windows.Forms.MaskedTextBox KundeMailTextBox;
        private System.Windows.Forms.MaskedTextBox KundeAdresseTextBox;
        private System.Windows.Forms.CheckBox KøberCB;
        private System.Windows.Forms.CheckBox SælgerCB;
    }
}