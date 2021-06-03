
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.MedarbejderPortal = new System.Windows.Forms.Button();
            this.PrisVudering = new System.Windows.Forms.Button();
            this.AabentHus = new System.Windows.Forms.Button();
            this.CRUD = new System.Windows.Forms.Button();
            this.Statistik = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.MedarbejderId = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
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
            this.button1.TabIndex = 8;
            this.button1.Text = "Tilbage";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LæsMælgerData
            // 
            this.LæsMælgerData.Location = new System.Drawing.Point(320, 121);
            this.LæsMælgerData.Name = "LæsMælgerData";
            this.LæsMælgerData.Size = new System.Drawing.Size(133, 23);
            this.LæsMælgerData.TabIndex = 2;
            this.LæsMælgerData.Text = "Indlæs Mægler Data";
            this.LæsMælgerData.UseVisualStyleBackColor = true;
            this.LæsMælgerData.Click += new System.EventHandler(this.LæsMælgerData_Click);
            // 
            // MedarbejderIdTextBox1
            // 
            this.MedarbejderIdTextBox1.Location = new System.Drawing.Point(205, 121);
            this.MedarbejderIdTextBox1.Mask = "000000";
            this.MedarbejderIdTextBox1.Name = "MedarbejderIdTextBox1";
            this.MedarbejderIdTextBox1.Size = new System.Drawing.Size(100, 23);
            this.MedarbejderIdTextBox1.TabIndex = 1;
            // 
            // MælgerNavnTextBox
            // 
            this.MælgerNavnTextBox.Location = new System.Drawing.Point(320, 183);
            this.MælgerNavnTextBox.Mask = "LLLLLLLLLLLLLLLLLLLLLLLLLLLLLL";
            this.MælgerNavnTextBox.Name = "MælgerNavnTextBox";
            this.MælgerNavnTextBox.Size = new System.Drawing.Size(100, 23);
            this.MælgerNavnTextBox.TabIndex = 3;
            // 
            // MæglerTlfTextBox3
            // 
            this.MæglerTlfTextBox3.Location = new System.Drawing.Point(320, 213);
            this.MæglerTlfTextBox3.Mask = "0000000000";
            this.MæglerTlfTextBox3.Name = "MæglerTlfTextBox3";
            this.MæglerTlfTextBox3.Size = new System.Drawing.Size(100, 23);
            this.MæglerTlfTextBox3.TabIndex = 4;
            // 
            // MæglerMailTextBox4
            // 
            this.MæglerMailTextBox4.Location = new System.Drawing.Point(320, 243);
            this.MæglerMailTextBox4.Mask = "CCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCC";
            this.MæglerMailTextBox4.Name = "MæglerMailTextBox4";
            this.MæglerMailTextBox4.Size = new System.Drawing.Size(100, 23);
            this.MæglerMailTextBox4.TabIndex = 5;
            // 
            // MæglerStillingTextBox5
            // 
            this.MæglerStillingTextBox5.Location = new System.Drawing.Point(320, 273);
            this.MæglerStillingTextBox5.Mask = "LLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLL";
            this.MæglerStillingTextBox5.Name = "MæglerStillingTextBox5";
            this.MæglerStillingTextBox5.Size = new System.Drawing.Size(100, 23);
            this.MæglerStillingTextBox5.TabIndex = 6;
            // 
            // UpdateMælger
            // 
            this.UpdateMælger.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UpdateMælger.Location = new System.Drawing.Point(255, 312);
            this.UpdateMælger.Name = "UpdateMælger";
            this.UpdateMælger.Size = new System.Drawing.Size(165, 62);
            this.UpdateMælger.TabIndex = 7;
            this.UpdateMælger.Text = "Opdater";
            this.UpdateMælger.UseVisualStyleBackColor = true;
            this.UpdateMælger.Click += new System.EventHandler(this.UpdateMælger_Click);
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
            this.panel1.Size = new System.Drawing.Size(186, 460);
            this.panel1.TabIndex = 25;
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
            this.MedarbejderPortal.TabIndex = 12;
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
            this.PrisVudering.TabIndex = 11;
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
            this.AabentHus.TabIndex = 13;
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
            this.CRUD.TabIndex = 9;
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
            this.Statistik.TabIndex = 10;
            this.Statistik.Text = "Statistik";
            this.Statistik.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.Statistik.UseVisualStyleBackColor = true;
            this.Statistik.Click += new System.EventHandler(this.Statistik_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(186, 144);
            this.panel2.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(50, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(66, 63);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // MedarbejderId
            // 
            this.MedarbejderId.AutoSize = true;
            this.MedarbejderId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(240)))));
            this.MedarbejderId.Location = new System.Drawing.Point(205, 88);
            this.MedarbejderId.Name = "MedarbejderId";
            this.MedarbejderId.Size = new System.Drawing.Size(187, 15);
            this.MedarbejderId.TabIndex = 26;
            this.MedarbejderId.Text = "Vælg MedarbejderId til opdatering";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(240)))));
            this.label1.Location = new System.Drawing.Point(205, 186);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 15);
            this.label1.TabIndex = 27;
            this.label1.Text = "Navn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(240)))));
            this.label2.Location = new System.Drawing.Point(205, 216);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 15);
            this.label2.TabIndex = 28;
            this.label2.Text = "TlfNr";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(240)))));
            this.label3.Location = new System.Drawing.Point(205, 246);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 15);
            this.label3.TabIndex = 29;
            this.label3.Text = "Mail";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(240)))));
            this.label4.Location = new System.Drawing.Point(205, 276);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 15);
            this.label4.TabIndex = 30;
            this.label4.Text = "Stilling";
            // 
            // OpdaterMægler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(537, 460);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MedarbejderId);
            this.Controls.Add(this.panel1);
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
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button MedarbejderPortal;
        private System.Windows.Forms.Button PrisVudering;
        private System.Windows.Forms.Button AabentHus;
        private System.Windows.Forms.Button CRUD;
        private System.Windows.Forms.Button Statistik;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label MedarbejderId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}