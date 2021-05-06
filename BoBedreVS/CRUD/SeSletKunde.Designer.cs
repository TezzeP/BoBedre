
namespace BoBedreVS
{
    partial class SeSletKunde
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ReadAndShowKunde = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.KundeIdTextBox = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(22, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(129, 223);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 1;
            // 
            // ReadAndShowKunde
            // 
            this.ReadAndShowKunde.Location = new System.Drawing.Point(22, 52);
            this.ReadAndShowKunde.Name = "ReadAndShowKunde";
            this.ReadAndShowKunde.Size = new System.Drawing.Size(75, 23);
            this.ReadAndShowKunde.TabIndex = 2;
            this.ReadAndShowKunde.Text = "LÆs";
            this.ReadAndShowKunde.UseVisualStyleBackColor = true;
            this.ReadAndShowKunde.Click += new System.EventHandler(this.ReadAndShowKunde_Click);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(22, 97);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(75, 23);
            this.Delete.TabIndex = 3;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // KundeIdTextBox
            // 
            this.KundeIdTextBox.Location = new System.Drawing.Point(179, 97);
            this.KundeIdTextBox.Name = "KundeIdTextBox";
            this.KundeIdTextBox.Size = new System.Drawing.Size(100, 23);
            this.KundeIdTextBox.TabIndex = 4;
            // 
            // SeSletKunde
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.KundeIdTextBox);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.ReadAndShowKunde);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Name = "SeSletKunde";
            this.Text = "Delete";
            this.Load += new System.EventHandler(this.SeSletKunde_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button ReadAndShowKunde;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.MaskedTextBox KundeIdTextBox;
    }
}