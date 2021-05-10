
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
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
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.BadAlderTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.KøkkenAlderTextBox = new System.Windows.Forms.MaskedTextBox();
            this.EtagerTextBox = new System.Windows.Forms.MaskedTextBox();
            this.AlderTextBox = new System.Windows.Forms.MaskedTextBox();
            this.HaveTextBox = new System.Windows.Forms.MaskedTextBox();
            this.EjendomsTypeTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.OmbygningsÅrTextBox = new System.Windows.Forms.MaskedTextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(192, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Update
            // 
            this.Update.Cursor = System.Windows.Forms.Cursors.Default;
            this.Update.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Update.Location = new System.Drawing.Point(749, 15);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(77, 33);
            this.Update.TabIndex = 1;
            this.Update.Text = "Update";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // BoligIdTextBox
            // 
            this.BoligIdTextBox.Location = new System.Drawing.Point(470, 15);
            this.BoligIdTextBox.Mask = "00000";
            this.BoligIdTextBox.Name = "BoligIdTextBox";
            this.BoligIdTextBox.Size = new System.Drawing.Size(125, 23);
            this.BoligIdTextBox.TabIndex = 2;
            this.BoligIdTextBox.ValidatingType = typeof(int);
            // 
            // BoligAdresseTextBox
            // 
            this.BoligAdresseTextBox.Location = new System.Drawing.Point(339, 80);
            this.BoligAdresseTextBox.Mask = "LLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLL";
            this.BoligAdresseTextBox.Name = "BoligAdresseTextBox";
            this.BoligAdresseTextBox.Size = new System.Drawing.Size(125, 23);
            this.BoligAdresseTextBox.TabIndex = 3;
            // 
            // BoligPostNrTextBox
            // 
            this.BoligPostNrTextBox.Location = new System.Drawing.Point(339, 125);
            this.BoligPostNrTextBox.Mask = "0000";
            this.BoligPostNrTextBox.Name = "BoligPostNrTextBox";
            this.BoligPostNrTextBox.Size = new System.Drawing.Size(125, 23);
            this.BoligPostNrTextBox.TabIndex = 4;
            // 
            // KundeIdFKTextBox
            // 
            this.KundeIdFKTextBox.Location = new System.Drawing.Point(701, 379);
            this.KundeIdFKTextBox.Mask = "00000";
            this.KundeIdFKTextBox.Name = "KundeIdFKTextBox";
            this.KundeIdFKTextBox.Size = new System.Drawing.Size(125, 23);
            this.KundeIdFKTextBox.TabIndex = 5;
            // 
            // BoligGrundM2TextBox
            // 
            this.BoligGrundM2TextBox.Location = new System.Drawing.Point(339, 167);
            this.BoligGrundM2TextBox.Mask = "00000";
            this.BoligGrundM2TextBox.Name = "BoligGrundM2TextBox";
            this.BoligGrundM2TextBox.Size = new System.Drawing.Size(125, 23);
            this.BoligGrundM2TextBox.TabIndex = 6;
            // 
            // BoigHusM2TextBox
            // 
            this.BoigHusM2TextBox.Location = new System.Drawing.Point(339, 210);
            this.BoigHusM2TextBox.Mask = "00000";
            this.BoigHusM2TextBox.Name = "BoigHusM2TextBox";
            this.BoigHusM2TextBox.Size = new System.Drawing.Size(125, 23);
            this.BoigHusM2TextBox.TabIndex = 7;
            // 
            // BoligPrisTextBox
            // 
            this.BoligPrisTextBox.Location = new System.Drawing.Point(339, 254);
            this.BoligPrisTextBox.Mask = "000000000";
            this.BoligPrisTextBox.Name = "BoligPrisTextBox";
            this.BoligPrisTextBox.Size = new System.Drawing.Size(125, 23);
            this.BoligPrisTextBox.TabIndex = 8;
            this.BoligPrisTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // BoligSalgsdatoTextBox
            // 
            this.BoligSalgsdatoTextBox.Location = new System.Drawing.Point(701, 201);
            this.BoligSalgsdatoTextBox.Mask = "00/00/0000";
            this.BoligSalgsdatoTextBox.Name = "BoligSalgsdatoTextBox";
            this.BoligSalgsdatoTextBox.Size = new System.Drawing.Size(125, 23);
            this.BoligSalgsdatoTextBox.TabIndex = 9;
            // 
            // BoligOprettelsesTextBox
            // 
            this.BoligOprettelsesTextBox.Location = new System.Drawing.Point(701, 246);
            this.BoligOprettelsesTextBox.Mask = "00/00/0000";
            this.BoligOprettelsesTextBox.Name = "BoligOprettelsesTextBox";
            this.BoligOprettelsesTextBox.Size = new System.Drawing.Size(125, 23);
            this.BoligOprettelsesTextBox.TabIndex = 10;
            this.BoligOprettelsesTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // StandSkalaTextBox
            // 
            this.StandSkalaTextBox.Location = new System.Drawing.Point(701, 336);
            this.StandSkalaTextBox.Mask = "000000000";
            this.StandSkalaTextBox.Name = "StandSkalaTextBox";
            this.StandSkalaTextBox.Size = new System.Drawing.Size(125, 23);
            this.StandSkalaTextBox.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(240)))));
            this.label1.Location = new System.Drawing.Point(313, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 15);
            this.label1.TabIndex = 12;
            this.label1.Text = "Choose BoligId too update ";
            // 
            // LæsBoligData
            // 
            this.LæsBoligData.Location = new System.Drawing.Point(616, 15);
            this.LæsBoligData.Name = "LæsBoligData";
            this.LæsBoligData.Size = new System.Drawing.Size(96, 23);
            this.LæsBoligData.TabIndex = 13;
            this.LæsBoligData.Text = "Læs BoligData";
            this.LæsBoligData.UseVisualStyleBackColor = true;
            this.LæsBoligData.Click += new System.EventHandler(this.LæsBoligData_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(240)))));
            this.label2.Location = new System.Drawing.Point(203, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 15);
            this.label2.TabIndex = 14;
            this.label2.Text = "Adresse";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(240)))));
            this.label3.Location = new System.Drawing.Point(203, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 15);
            this.label3.TabIndex = 15;
            this.label3.Text = "PostNr";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(240)))));
            this.label4.Location = new System.Drawing.Point(203, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 15);
            this.label4.TabIndex = 16;
            this.label4.Text = "GrundM2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(240)))));
            this.label5.Location = new System.Drawing.Point(208, 214);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 15);
            this.label5.TabIndex = 17;
            this.label5.Text = "HusM2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(240)))));
            this.label6.Location = new System.Drawing.Point(208, 257);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 15);
            this.label6.TabIndex = 18;
            this.label6.Text = "Pris";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(240)))));
            this.label7.Location = new System.Drawing.Point(544, 204);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 15);
            this.label7.TabIndex = 19;
            this.label7.Text = "SalgsDato";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(240)))));
            this.label8.Location = new System.Drawing.Point(544, 249);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 15);
            this.label8.TabIndex = 20;
            this.label8.Text = "OprettelsesDato";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(240)))));
            this.label9.Location = new System.Drawing.Point(544, 339);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 15);
            this.label9.TabIndex = 21;
            this.label9.Text = "Stand Skala 1-10";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(240)))));
            this.label10.Location = new System.Drawing.Point(544, 383);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 15);
            this.label10.TabIndex = 22;
            this.label10.Text = "KundeId FK ";
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
            this.panel1.Size = new System.Drawing.Size(186, 437);
            this.panel1.TabIndex = 23;
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
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(240)))));
            this.label13.Location = new System.Drawing.Point(208, 378);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(35, 15);
            this.label13.TabIndex = 24;
            this.label13.Text = "Alder";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(240)))));
            this.label14.Location = new System.Drawing.Point(544, 128);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(77, 15);
            this.label14.TabIndex = 25;
            this.label14.Text = "Køkken Alder";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(240)))));
            this.label15.Location = new System.Drawing.Point(544, 166);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(106, 15);
            this.label15.TabIndex = 26;
            this.label15.Text = "BadeværelsesAlder";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(240)))));
            this.label16.Location = new System.Drawing.Point(544, 83);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(40, 15);
            this.label16.TabIndex = 27;
            this.label16.Text = "Etager";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(240)))));
            this.label17.Location = new System.Drawing.Point(208, 337);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(34, 15);
            this.label17.TabIndex = 28;
            this.label17.Text = "Have";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(240)))));
            this.label18.Location = new System.Drawing.Point(208, 296);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(83, 15);
            this.label18.TabIndex = 29;
            this.label18.Text = "EjendomsType";
            // 
            // BadAlderTextBox1
            // 
            this.BadAlderTextBox1.Location = new System.Drawing.Point(701, 163);
            this.BadAlderTextBox1.Mask = "00/00/0000";
            this.BadAlderTextBox1.Name = "BadAlderTextBox1";
            this.BadAlderTextBox1.Size = new System.Drawing.Size(125, 23);
            this.BadAlderTextBox1.TabIndex = 30;
            this.BadAlderTextBox1.ValidatingType = typeof(System.DateTime);
            // 
            // KøkkenAlderTextBox
            // 
            this.KøkkenAlderTextBox.Location = new System.Drawing.Point(701, 125);
            this.KøkkenAlderTextBox.Mask = "00/00/0000";
            this.KøkkenAlderTextBox.Name = "KøkkenAlderTextBox";
            this.KøkkenAlderTextBox.Size = new System.Drawing.Size(125, 23);
            this.KøkkenAlderTextBox.TabIndex = 31;
            this.KøkkenAlderTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // EtagerTextBox
            // 
            this.EtagerTextBox.Location = new System.Drawing.Point(701, 80);
            this.EtagerTextBox.Mask = "00000";
            this.EtagerTextBox.Name = "EtagerTextBox";
            this.EtagerTextBox.Size = new System.Drawing.Size(125, 23);
            this.EtagerTextBox.TabIndex = 32;
            // 
            // AlderTextBox
            // 
            this.AlderTextBox.Location = new System.Drawing.Point(339, 375);
            this.AlderTextBox.Mask = "00000";
            this.AlderTextBox.Name = "AlderTextBox";
            this.AlderTextBox.Size = new System.Drawing.Size(125, 23);
            this.AlderTextBox.TabIndex = 33;
            // 
            // HaveTextBox
            // 
            this.HaveTextBox.Location = new System.Drawing.Point(339, 334);
            this.HaveTextBox.Mask = "0000";
            this.HaveTextBox.Name = "HaveTextBox";
            this.HaveTextBox.Size = new System.Drawing.Size(125, 23);
            this.HaveTextBox.TabIndex = 34;
            // 
            // EjendomsTypeTextBox
            // 
            this.EjendomsTypeTextBox.Location = new System.Drawing.Point(339, 293);
            this.EjendomsTypeTextBox.Mask = "LLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLL";
            this.EjendomsTypeTextBox.Name = "EjendomsTypeTextBox";
            this.EjendomsTypeTextBox.Size = new System.Drawing.Size(125, 23);
            this.EjendomsTypeTextBox.TabIndex = 35;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(240)))));
            this.label19.Location = new System.Drawing.Point(544, 293);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(91, 15);
            this.label19.TabIndex = 36;
            this.label19.Text = "Ombygnings År";
            // 
            // OmbygningsÅrTextBox
            // 
            this.OmbygningsÅrTextBox.Location = new System.Drawing.Point(701, 290);
            this.OmbygningsÅrTextBox.Mask = "00/00/0000";
            this.OmbygningsÅrTextBox.Name = "OmbygningsÅrTextBox";
            this.OmbygningsÅrTextBox.Size = new System.Drawing.Size(125, 23);
            this.OmbygningsÅrTextBox.TabIndex = 37;
            this.OmbygningsÅrTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // OpdaterBolig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(859, 437);
            this.Controls.Add(this.OmbygningsÅrTextBox);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.EjendomsTypeTextBox);
            this.Controls.Add(this.HaveTextBox);
            this.Controls.Add(this.AlderTextBox);
            this.Controls.Add(this.EtagerTextBox);
            this.Controls.Add(this.KøkkenAlderTextBox);
            this.Controls.Add(this.BadAlderTextBox1);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
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
            this.Text = "OpdaterBolig";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
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
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.MaskedTextBox BadAlderTextBox1;
        private System.Windows.Forms.MaskedTextBox KøkkenAlderTextBox;
        private System.Windows.Forms.MaskedTextBox EtagerTextBox;
        private System.Windows.Forms.MaskedTextBox AlderTextBox;
        private System.Windows.Forms.MaskedTextBox HaveTextBox;
        private System.Windows.Forms.MaskedTextBox EjendomsTypeTextBox;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.MaskedTextBox OmbygningsÅrTextBox;
    }
}