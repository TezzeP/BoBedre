
namespace BoBedreVS
{
    partial class SeSletMægler
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
            this.ReadAndShowMægler = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.DeleteMægler = new System.Windows.Forms.Button();
            this.MedarbejderIdTextBox = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            // ReadAndShowMægler
            // 
            this.ReadAndShowMægler.Location = new System.Drawing.Point(13, 43);
            this.ReadAndShowMægler.Name = "ReadAndShowMægler";
            this.ReadAndShowMægler.Size = new System.Drawing.Size(75, 23);
            this.ReadAndShowMægler.TabIndex = 1;
            this.ReadAndShowMægler.Text = "Read";
            this.ReadAndShowMægler.UseVisualStyleBackColor = true;
            this.ReadAndShowMægler.Click += new System.EventHandler(this.ReadAndShowMægler_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(28, 148);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(559, 252);
            this.dataGridView1.TabIndex = 2;
            // 
            // DeleteMægler
            // 
            this.DeleteMægler.Location = new System.Drawing.Point(13, 73);
            this.DeleteMægler.Name = "DeleteMægler";
            this.DeleteMægler.Size = new System.Drawing.Size(75, 23);
            this.DeleteMægler.TabIndex = 3;
            this.DeleteMægler.Text = "Delete";
            this.DeleteMægler.UseVisualStyleBackColor = true;
            this.DeleteMægler.Click += new System.EventHandler(this.DeleteMægler_Click);
            // 
            // MedarbejderIdTextBox
            // 
            this.MedarbejderIdTextBox.Location = new System.Drawing.Point(122, 72);
            this.MedarbejderIdTextBox.Name = "MedarbejderIdTextBox";
            this.MedarbejderIdTextBox.Size = new System.Drawing.Size(100, 23);
            this.MedarbejderIdTextBox.TabIndex = 4;
            // 
            // SeSletMægler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MedarbejderIdTextBox);
            this.Controls.Add(this.DeleteMægler);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ReadAndShowMægler);
            this.Controls.Add(this.button1);
            this.Name = "SeSletMægler";
            this.Text = "SeSletMægler";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button ReadAndShowMægler;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button DeleteMægler;
        private System.Windows.Forms.MaskedTextBox MedarbejderIdTextBox;
    }
}