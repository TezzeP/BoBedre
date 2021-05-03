
namespace BoBedreVS
{
    partial class OpretMægler
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
            this.NavnTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TelefonNrTextBox = new System.Windows.Forms.MaskedTextBox();
            this.MailTextBox = new System.Windows.Forms.MaskedTextBox();
            this.StillingTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.OpretMæglerKnap = new System.Windows.Forms.Button();
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
            // NavnTextBox
            // 
            this.NavnTextBox.Location = new System.Drawing.Point(257, 61);
            this.NavnTextBox.Name = "NavnTextBox";
            this.NavnTextBox.Size = new System.Drawing.Size(100, 23);
            this.NavnTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(178, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Navn";
            // 
            // TelefonNrTextBox
            // 
            this.TelefonNrTextBox.Location = new System.Drawing.Point(257, 122);
            this.TelefonNrTextBox.Name = "TelefonNrTextBox";
            this.TelefonNrTextBox.Size = new System.Drawing.Size(100, 23);
            this.TelefonNrTextBox.TabIndex = 3;
            // 
            // MailTextBox
            // 
            this.MailTextBox.Location = new System.Drawing.Point(257, 185);
            this.MailTextBox.Name = "MailTextBox";
            this.MailTextBox.Size = new System.Drawing.Size(100, 23);
            this.MailTextBox.TabIndex = 4;
            // 
            // StillingTextBox
            // 
            this.StillingTextBox.Location = new System.Drawing.Point(257, 258);
            this.StillingTextBox.Name = "StillingTextBox";
            this.StillingTextBox.Size = new System.Drawing.Size(100, 23);
            this.StillingTextBox.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(178, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Telefon Nr";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(178, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Mail";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(178, 258);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Stilling";
            // 
            // OpretMæglerKnap
            // 
            this.OpretMæglerKnap.Location = new System.Drawing.Point(178, 322);
            this.OpretMæglerKnap.Name = "OpretMæglerKnap";
            this.OpretMæglerKnap.Size = new System.Drawing.Size(92, 23);
            this.OpretMæglerKnap.TabIndex = 9;
            this.OpretMæglerKnap.Text = "Opret mægler";
            this.OpretMæglerKnap.UseVisualStyleBackColor = true;
            this.OpretMæglerKnap.Click += new System.EventHandler(this.OpretMæglerKnap_Click);
            // 
            // OpretMægler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.OpretMæglerKnap);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.StillingTextBox);
            this.Controls.Add(this.MailTextBox);
            this.Controls.Add(this.TelefonNrTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NavnTextBox);
            this.Controls.Add(this.button1);
            this.Name = "OpretMægler";
            this.Text = "OpretMægler";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MaskedTextBox NavnTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox TelefonNrTextBox;
        private System.Windows.Forms.MaskedTextBox MailTextBox;
        private System.Windows.Forms.MaskedTextBox StillingTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button OpretMæglerKnap;
    }
}