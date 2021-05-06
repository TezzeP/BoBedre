
namespace BoBedreVS
{
    partial class SeSletBolig
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
            this.ReadAllMægler = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.BoligIdTextBox = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(22, 12);
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
            this.dataGridView1.Location = new System.Drawing.Point(43, 200);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(554, 204);
            this.dataGridView1.TabIndex = 1;
            // 
            // ReadAllMægler
            // 
            this.ReadAllMægler.Location = new System.Drawing.Point(22, 58);
            this.ReadAllMægler.Name = "ReadAllMægler";
            this.ReadAllMægler.Size = new System.Drawing.Size(112, 23);
            this.ReadAllMægler.TabIndex = 2;
            this.ReadAllMægler.Text = "Læs Alle Mæglere ";
            this.ReadAllMægler.UseVisualStyleBackColor = true;
            this.ReadAllMægler.Click += new System.EventHandler(this.ReadAllMægler_Click);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(22, 88);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(75, 23);
            this.Delete.TabIndex = 3;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // BoligIdTextBox
            // 
            this.BoligIdTextBox.Location = new System.Drawing.Point(184, 87);
            this.BoligIdTextBox.Name = "BoligIdTextBox";
            this.BoligIdTextBox.Size = new System.Drawing.Size(100, 23);
            this.BoligIdTextBox.TabIndex = 4;
            // 
            // SeSletBolig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BoligIdTextBox);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.ReadAllMægler);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Name = "SeSletBolig";
            this.Text = "SeSletBolig";
            this.Load += new System.EventHandler(this.SeSletBolig_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button ReadAllMægler;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.MaskedTextBox BoligIdTextBox;
    }
}