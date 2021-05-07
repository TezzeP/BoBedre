
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.MedarbejderPortal = new System.Windows.Forms.Button();
            this.PrisVudering = new System.Windows.Forms.Button();
            this.AabentHus = new System.Windows.Forms.Button();
            this.CRUD = new System.Windows.Forms.Button();
            this.Statistik = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(192, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(192, 191);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(596, 247);
            this.dataGridView1.TabIndex = 1;
            // 
            // ReadAndShowKunde
            // 
            this.ReadAndShowKunde.Location = new System.Drawing.Point(192, 52);
            this.ReadAndShowKunde.Name = "ReadAndShowKunde";
            this.ReadAndShowKunde.Size = new System.Drawing.Size(75, 23);
            this.ReadAndShowKunde.TabIndex = 2;
            this.ReadAndShowKunde.Text = "Læs";
            this.ReadAndShowKunde.UseVisualStyleBackColor = true;
            this.ReadAndShowKunde.Click += new System.EventHandler(this.ReadAndShowKunde_Click);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(192, 97);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(75, 23);
            this.Delete.TabIndex = 3;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // KundeIdTextBox
            // 
            this.KundeIdTextBox.Location = new System.Drawing.Point(289, 97);
            this.KundeIdTextBox.Name = "KundeIdTextBox";
            this.KundeIdTextBox.Size = new System.Drawing.Size(100, 23);
            this.KundeIdTextBox.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel1.Controls.Add(this.MedarbejderPortal);
            this.panel1.Controls.Add(this.PrisVudering);
            this.panel1.Controls.Add(this.AabentHus);
            this.panel1.Controls.Add(this.CRUD);
            this.panel1.Controls.Add(this.Statistik);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(186, 450);
            this.panel1.TabIndex = 28;
            // 
            // MedarbejderPortal
            // 
            this.MedarbejderPortal.FlatAppearance.BorderSize = 0;
            this.MedarbejderPortal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MedarbejderPortal.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MedarbejderPortal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(240)))));
            this.MedarbejderPortal.Location = new System.Drawing.Point(0, 225);
            this.MedarbejderPortal.Name = "MedarbejderPortal";
            this.MedarbejderPortal.Size = new System.Drawing.Size(186, 30);
            this.MedarbejderPortal.TabIndex = 3;
            this.MedarbejderPortal.Text = "Medarbejder Portal";
            this.MedarbejderPortal.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.MedarbejderPortal.UseVisualStyleBackColor = true;
            this.MedarbejderPortal.Click += new System.EventHandler(this.MedarbejderPortal_Click);
            // 
            // PrisVudering
            // 
            this.PrisVudering.FlatAppearance.BorderSize = 0;
            this.PrisVudering.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PrisVudering.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PrisVudering.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(240)))));
            this.PrisVudering.Location = new System.Drawing.Point(0, 201);
            this.PrisVudering.Name = "PrisVudering";
            this.PrisVudering.Size = new System.Drawing.Size(186, 30);
            this.PrisVudering.TabIndex = 3;
            this.PrisVudering.Text = "Prisvurdering";
            this.PrisVudering.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.PrisVudering.UseVisualStyleBackColor = true;
            this.PrisVudering.Click += new System.EventHandler(this.PrisVudering_Click);
            // 
            // AabentHus
            // 
            this.AabentHus.FlatAppearance.BorderSize = 0;
            this.AabentHus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AabentHus.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AabentHus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(240)))));
            this.AabentHus.Location = new System.Drawing.Point(0, 255);
            this.AabentHus.Name = "AabentHus";
            this.AabentHus.Size = new System.Drawing.Size(186, 30);
            this.AabentHus.TabIndex = 3;
            this.AabentHus.Text = "Åbent Hus";
            this.AabentHus.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.AabentHus.UseVisualStyleBackColor = true;
            this.AabentHus.Click += new System.EventHandler(this.AabentHus_Click);
            // 
            // CRUD
            // 
            this.CRUD.FlatAppearance.BorderSize = 0;
            this.CRUD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CRUD.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CRUD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(240)))));
            this.CRUD.Location = new System.Drawing.Point(0, 143);
            this.CRUD.Name = "CRUD";
            this.CRUD.Size = new System.Drawing.Size(186, 30);
            this.CRUD.TabIndex = 3;
            this.CRUD.Text = "CRUD";
            this.CRUD.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.CRUD.UseVisualStyleBackColor = true;
            this.CRUD.Click += new System.EventHandler(this.CRUD_Click);
            // 
            // Statistik
            // 
            this.Statistik.FlatAppearance.BorderSize = 0;
            this.Statistik.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Statistik.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Statistik.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(240)))));
            this.Statistik.Location = new System.Drawing.Point(0, 171);
            this.Statistik.Name = "Statistik";
            this.Statistik.Size = new System.Drawing.Size(186, 30);
            this.Statistik.TabIndex = 3;
            this.Statistik.Text = "Statistik";
            this.Statistik.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.Statistik.UseVisualStyleBackColor = true;
            this.Statistik.Click += new System.EventHandler(this.Statistik_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(186, 144);
            this.panel2.TabIndex = 0;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.label11.Location = new System.Drawing.Point(33, 119);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(106, 15);
            this.label11.TabIndex = 2;
            this.label11.Text = "Some usewr text ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BoBedreVS.Properties.Resources.cool_csgo_profile_pictures_2c3d8442_7fef_446e_9315_e9f8a46ece47;
            this.pictureBox1.Location = new System.Drawing.Point(50, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(66, 63);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label12.Location = new System.Drawing.Point(63, 88);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(36, 15);
            this.label12.TabIndex = 1;
            this.label12.Text = "Guffe";
            // 
            // SeSletKunde
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.KundeIdTextBox);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.ReadAndShowKunde);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Name = "SeSletKunde";
            this.Text = "Læs & Slet KundeData";
            this.Load += new System.EventHandler(this.SeSletKunde_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button ReadAndShowKunde;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.MaskedTextBox KundeIdTextBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button MedarbejderPortal;
        private System.Windows.Forms.Button PrisVudering;
        private System.Windows.Forms.Button AabentHus;
        private System.Windows.Forms.Button CRUD;
        private System.Windows.Forms.Button Statistik;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label12;
    }
}