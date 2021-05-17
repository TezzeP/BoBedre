
namespace BoBedreVS
{
    partial class Statistik
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.MedarbejderPortal = new System.Windows.Forms.Button();
            this.PrisVudering = new System.Windows.Forms.Button();
            this.AabentHus = new System.Windows.Forms.Button();
            this.CRUD = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.StatVejnavnBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.StatStartDatoBox = new System.Windows.Forms.MaskedTextBox();
            this.StatSlutDatoBox = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.StatSøgButton = new System.Windows.Forms.Button();
            this.FileReadButton = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.StatFileBox = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel1.Controls.Add(this.MedarbejderPortal);
            this.panel1.Controls.Add(this.PrisVudering);
            this.panel1.Controls.Add(this.AabentHus);
            this.panel1.Controls.Add(this.CRUD);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(186, 450);
            this.panel1.TabIndex = 6;
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
            this.PrisVudering.Text = "Prisvudering";
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
            this.CRUD.Location = new System.Drawing.Point(0, 144);
            this.CRUD.Name = "CRUD";
            this.CRUD.Size = new System.Drawing.Size(186, 30);
            this.CRUD.TabIndex = 3;
            this.CRUD.Text = "CRUD";
            this.CRUD.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.CRUD.UseVisualStyleBackColor = true;
            this.CRUD.Click += new System.EventHandler(this.CRUD_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(240)))));
            this.button1.Location = new System.Drawing.Point(0, 171);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(186, 30);
            this.button1.TabIndex = 3;
            this.button1.Text = "Statistik ";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(186, 144);
            this.panel2.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.label2.Location = new System.Drawing.Point(33, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Some usewr text ";
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label1.Location = new System.Drawing.Point(50, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "User Name";
            // 
            // StatVejnavnBox
            // 
            this.StatVejnavnBox.Location = new System.Drawing.Point(227, 150);
            this.StatVejnavnBox.Name = "StatVejnavnBox";
            this.StatVejnavnBox.Size = new System.Drawing.Size(100, 23);
            this.StatVejnavnBox.TabIndex = 7;
            this.StatVejnavnBox.TextChanged += new System.EventHandler(this.StatVejnavnBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(240)))));
            this.label3.Location = new System.Drawing.Point(252, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Vejnavn";
            // 
            // StatStartDatoBox
            // 
            this.StatStartDatoBox.Location = new System.Drawing.Point(349, 151);
            this.StatStartDatoBox.Mask = "00/00/0000";
            this.StatStartDatoBox.Name = "StatStartDatoBox";
            this.StatStartDatoBox.Size = new System.Drawing.Size(100, 23);
            this.StatStartDatoBox.TabIndex = 10;
            this.StatStartDatoBox.ValidatingType = typeof(System.DateTime);
            // 
            // StatSlutDatoBox
            // 
            this.StatSlutDatoBox.Location = new System.Drawing.Point(476, 151);
            this.StatSlutDatoBox.Mask = "00/00/0000";
            this.StatSlutDatoBox.Name = "StatSlutDatoBox";
            this.StatSlutDatoBox.Size = new System.Drawing.Size(100, 23);
            this.StatSlutDatoBox.TabIndex = 11;
            this.StatSlutDatoBox.ValidatingType = typeof(System.DateTime);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(240)))));
            this.label4.Location = new System.Drawing.Point(367, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "Start Dato";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(240)))));
            this.label5.Location = new System.Drawing.Point(498, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "Slut Dato";
            // 
            // StatSøgButton
            // 
            this.StatSøgButton.Location = new System.Drawing.Point(625, 151);
            this.StatSøgButton.Name = "StatSøgButton";
            this.StatSøgButton.Size = new System.Drawing.Size(75, 23);
            this.StatSøgButton.TabIndex = 18;
            this.StatSøgButton.Text = "Søg";
            this.StatSøgButton.UseVisualStyleBackColor = true;
            this.StatSøgButton.Click += new System.EventHandler(this.StatSøgButton_Click);
            // 
            // FileReadButton
            // 
            this.FileReadButton.Location = new System.Drawing.Point(252, 65);
            this.FileReadButton.Name = "FileReadButton";
            this.FileReadButton.Size = new System.Drawing.Size(75, 23);
            this.FileReadButton.TabIndex = 19;
            this.FileReadButton.Text = "Vælg Fil";
            this.FileReadButton.UseVisualStyleBackColor = true;
            this.FileReadButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // StatFileBox
            // 
            this.StatFileBox.Location = new System.Drawing.Point(367, 66);
            this.StatFileBox.Name = "StatFileBox";
            this.StatFileBox.ReadOnly = true;
            this.StatFileBox.Size = new System.Drawing.Size(196, 23);
            this.StatFileBox.TabIndex = 20;
            // 
            // Statistik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.StatFileBox);
            this.Controls.Add(this.FileReadButton);
            this.Controls.Add(this.StatSøgButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.StatSlutDatoBox);
            this.Controls.Add(this.StatStartDatoBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.StatVejnavnBox);
            this.Controls.Add(this.panel1);
            this.Name = "Statistik";
            this.Text = "Statistik";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button MedarbejderPortal;
        private System.Windows.Forms.Button PrisVudering;
        private System.Windows.Forms.Button AabentHus;
        private System.Windows.Forms.Button CRUD;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox StatVejnavnBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox StatStartDatoBox;
        private System.Windows.Forms.MaskedTextBox StatSlutDatoBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button StatSøgButton;
        private System.Windows.Forms.Button FileReadButton;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TextBox StatFileBox;
    }
}