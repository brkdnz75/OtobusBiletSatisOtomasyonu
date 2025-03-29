
namespace WindowsFormsApp11
{
    partial class Form3
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
            this.components = new System.ComponentModel.Container();
            this.cmbOtobüsAdi = new System.Windows.Forms.ComboBox();
            this.cmbVaris = new System.Windows.Forms.ComboBox();
            this.cmbKalkis = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtKullanıcıID = new System.Windows.Forms.TextBox();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBiletID = new System.Windows.Forms.TextBox();
            this.txtVarisTarihi = new System.Windows.Forms.MaskedTextBox();
            this.txtKalkisTarihi = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFiyat = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.biletIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kullaniciIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.otobusAdiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kalkisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.varisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kalkisTarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.varisTarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fiyatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.biletlerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.otobusBiletOtomasyonuDataSet1 = new WindowsFormsApp11.OtobusBiletOtomasyonuDataSet1();
            this.biletlerTableAdapter = new WindowsFormsApp11.OtobusBiletOtomasyonuDataSet1TableAdapters.BiletlerTableAdapter();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.biletlerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.otobusBiletOtomasyonuDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbOtobüsAdi
            // 
            this.cmbOtobüsAdi.FormattingEnabled = true;
            this.cmbOtobüsAdi.Items.AddRange(new object[] {
            "Pamukkale",
            "KamilKoç",
            "Nilüfer",
            "Metro",
            "BerTur"});
            this.cmbOtobüsAdi.Location = new System.Drawing.Point(236, 180);
            this.cmbOtobüsAdi.Name = "cmbOtobüsAdi";
            this.cmbOtobüsAdi.Size = new System.Drawing.Size(100, 21);
            this.cmbOtobüsAdi.TabIndex = 25;
            // 
            // cmbVaris
            // 
            this.cmbVaris.FormattingEnabled = true;
            this.cmbVaris.Items.AddRange(new object[] {
            "İzmir",
            "İstanbul",
            "Ankara",
            "Bursa",
            "Afyon",
            "Ardahan"});
            this.cmbVaris.Location = new System.Drawing.Point(235, 253);
            this.cmbVaris.Name = "cmbVaris";
            this.cmbVaris.Size = new System.Drawing.Size(101, 21);
            this.cmbVaris.TabIndex = 27;
            // 
            // cmbKalkis
            // 
            this.cmbKalkis.FormattingEnabled = true;
            this.cmbKalkis.Items.AddRange(new object[] {
            "İzmir",
            "İstanbul",
            "Ankara",
            "Bursa",
            "Afyon",
            "Ardahan"});
            this.cmbKalkis.Location = new System.Drawing.Point(235, 216);
            this.cmbKalkis.Name = "cmbKalkis";
            this.cmbKalkis.Size = new System.Drawing.Size(101, 21);
            this.cmbKalkis.TabIndex = 26;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label8.Location = new System.Drawing.Point(110, 143);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 14);
            this.label8.TabIndex = 43;
            this.label8.Text = "Kullanıcı Id";
            // 
            // txtKullanıcıID
            // 
            this.txtKullanıcıID.Location = new System.Drawing.Point(235, 137);
            this.txtKullanıcıID.Name = "txtKullanıcıID";
            this.txtKullanıcıID.Size = new System.Drawing.Size(100, 20);
            this.txtKullanıcıID.TabIndex = 42;
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(261, 429);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(88, 31);
            this.btnGuncelle.TabIndex = 41;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(167, 429);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(88, 31);
            this.btnSil.TabIndex = 40;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(73, 429);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(88, 31);
            this.btnEkle.TabIndex = 39;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label3.Location = new System.Drawing.Point(140, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 14);
            this.label3.TabIndex = 38;
            this.label3.Text = "Bilet Id";
            // 
            // txtBiletID
            // 
            this.txtBiletID.Location = new System.Drawing.Point(235, 94);
            this.txtBiletID.Name = "txtBiletID";
            this.txtBiletID.Size = new System.Drawing.Size(100, 20);
            this.txtBiletID.TabIndex = 37;
            // 
            // txtVarisTarihi
            // 
            this.txtVarisTarihi.Location = new System.Drawing.Point(236, 344);
            this.txtVarisTarihi.Mask = "00/00/0000 90:00";
            this.txtVarisTarihi.Name = "txtVarisTarihi";
            this.txtVarisTarihi.Size = new System.Drawing.Size(100, 20);
            this.txtVarisTarihi.TabIndex = 29;
            this.txtVarisTarihi.ValidatingType = typeof(System.DateTime);
            // 
            // txtKalkisTarihi
            // 
            this.txtKalkisTarihi.Location = new System.Drawing.Point(236, 299);
            this.txtKalkisTarihi.Mask = "00/00/0000 90:00";
            this.txtKalkisTarihi.Name = "txtKalkisTarihi";
            this.txtKalkisTarihi.Size = new System.Drawing.Size(100, 20);
            this.txtKalkisTarihi.TabIndex = 28;
            this.txtKalkisTarihi.ValidatingType = typeof(System.DateTime);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label7.Location = new System.Drawing.Point(153, 387);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 14);
            this.label7.TabIndex = 36;
            this.label7.Text = "Fiyat";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label6.Location = new System.Drawing.Point(106, 347);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 14);
            this.label6.TabIndex = 35;
            this.label6.Text = "Varış Tarihi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label5.Location = new System.Drawing.Point(101, 299);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 14);
            this.label5.TabIndex = 34;
            this.label5.Text = "Kalkış Tarihi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label4.Location = new System.Drawing.Point(121, 253);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 14);
            this.label4.TabIndex = 33;
            this.label4.Text = "Varış Yeri";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label2.Location = new System.Drawing.Point(115, 216);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 14);
            this.label2.TabIndex = 32;
            this.label2.Text = "Kalkış Yeri";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label1.Location = new System.Drawing.Point(116, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 14);
            this.label1.TabIndex = 31;
            this.label1.Text = "Otobüs Adı";
            // 
            // txtFiyat
            // 
            this.txtFiyat.Location = new System.Drawing.Point(236, 381);
            this.txtFiyat.Name = "txtFiyat";
            this.txtFiyat.Size = new System.Drawing.Size(100, 20);
            this.txtFiyat.TabIndex = 30;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.biletIDDataGridViewTextBoxColumn,
            this.kullaniciIDDataGridViewTextBoxColumn,
            this.otobusAdiDataGridViewTextBoxColumn,
            this.kalkisDataGridViewTextBoxColumn,
            this.varisDataGridViewTextBoxColumn,
            this.kalkisTarihiDataGridViewTextBoxColumn,
            this.varisTarihiDataGridViewTextBoxColumn,
            this.fiyatDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.biletlerBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(359, 91);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(825, 150);
            this.dataGridView1.TabIndex = 44;
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // biletIDDataGridViewTextBoxColumn
            // 
            this.biletIDDataGridViewTextBoxColumn.DataPropertyName = "BiletID";
            this.biletIDDataGridViewTextBoxColumn.HeaderText = "BiletID";
            this.biletIDDataGridViewTextBoxColumn.Name = "biletIDDataGridViewTextBoxColumn";
            this.biletIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kullaniciIDDataGridViewTextBoxColumn
            // 
            this.kullaniciIDDataGridViewTextBoxColumn.DataPropertyName = "KullaniciID";
            this.kullaniciIDDataGridViewTextBoxColumn.HeaderText = "KullaniciID";
            this.kullaniciIDDataGridViewTextBoxColumn.Name = "kullaniciIDDataGridViewTextBoxColumn";
            this.kullaniciIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // otobusAdiDataGridViewTextBoxColumn
            // 
            this.otobusAdiDataGridViewTextBoxColumn.DataPropertyName = "OtobusAdi";
            this.otobusAdiDataGridViewTextBoxColumn.HeaderText = "OtobusAdi";
            this.otobusAdiDataGridViewTextBoxColumn.Name = "otobusAdiDataGridViewTextBoxColumn";
            this.otobusAdiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kalkisDataGridViewTextBoxColumn
            // 
            this.kalkisDataGridViewTextBoxColumn.DataPropertyName = "Kalkis";
            this.kalkisDataGridViewTextBoxColumn.HeaderText = "Kalkis";
            this.kalkisDataGridViewTextBoxColumn.Name = "kalkisDataGridViewTextBoxColumn";
            this.kalkisDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // varisDataGridViewTextBoxColumn
            // 
            this.varisDataGridViewTextBoxColumn.DataPropertyName = "Varis";
            this.varisDataGridViewTextBoxColumn.HeaderText = "Varis";
            this.varisDataGridViewTextBoxColumn.Name = "varisDataGridViewTextBoxColumn";
            this.varisDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kalkisTarihiDataGridViewTextBoxColumn
            // 
            this.kalkisTarihiDataGridViewTextBoxColumn.DataPropertyName = "KalkisTarihi";
            this.kalkisTarihiDataGridViewTextBoxColumn.HeaderText = "KalkisTarihi";
            this.kalkisTarihiDataGridViewTextBoxColumn.Name = "kalkisTarihiDataGridViewTextBoxColumn";
            this.kalkisTarihiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // varisTarihiDataGridViewTextBoxColumn
            // 
            this.varisTarihiDataGridViewTextBoxColumn.DataPropertyName = "VarisTarihi";
            this.varisTarihiDataGridViewTextBoxColumn.HeaderText = "VarisTarihi";
            this.varisTarihiDataGridViewTextBoxColumn.Name = "varisTarihiDataGridViewTextBoxColumn";
            this.varisTarihiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fiyatDataGridViewTextBoxColumn
            // 
            this.fiyatDataGridViewTextBoxColumn.DataPropertyName = "Fiyat";
            this.fiyatDataGridViewTextBoxColumn.HeaderText = "Fiyat";
            this.fiyatDataGridViewTextBoxColumn.Name = "fiyatDataGridViewTextBoxColumn";
            this.fiyatDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // biletlerBindingSource
            // 
            this.biletlerBindingSource.DataMember = "Biletler";
            this.biletlerBindingSource.DataSource = this.otobusBiletOtomasyonuDataSet1;
            // 
            // otobusBiletOtomasyonuDataSet1
            // 
            this.otobusBiletOtomasyonuDataSet1.DataSetName = "OtobusBiletOtomasyonuDataSet1";
            this.otobusBiletOtomasyonuDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // biletlerTableAdapter
            // 
            this.biletlerTableAdapter.ClearBeforeFill = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("MV Boli", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(0, 91);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(120, 41);
            this.label9.TabIndex = 46;
            this.label9.Text = "BerTur";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::WindowsFormsApp11.Properties.Resources.cd502ca638c39013254c7eac3b4a5208_Photoroom_png_Photoroom;
            this.pictureBox1.Location = new System.Drawing.Point(-6, -15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(140, 129);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 45;
            this.pictureBox1.TabStop = false;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.BackgroundImage = global::WindowsFormsApp11.Properties.Resources.way_3594614_1280__1___1_;
            this.ClientSize = new System.Drawing.Size(1185, 532);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cmbOtobüsAdi);
            this.Controls.Add(this.cmbVaris);
            this.Controls.Add(this.cmbKalkis);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtKullanıcıID);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBiletID);
            this.Controls.Add(this.txtVarisTarihi);
            this.Controls.Add(this.txtKalkisTarihi);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFiyat);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.biletlerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.otobusBiletOtomasyonuDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbOtobüsAdi;
        private System.Windows.Forms.ComboBox cmbVaris;
        private System.Windows.Forms.ComboBox cmbKalkis;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtKullanıcıID;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBiletID;
        private System.Windows.Forms.MaskedTextBox txtVarisTarihi;
        private System.Windows.Forms.MaskedTextBox txtKalkisTarihi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFiyat;
        private System.Windows.Forms.DataGridView dataGridView1;
        private OtobusBiletOtomasyonuDataSet1 otobusBiletOtomasyonuDataSet1;
        private System.Windows.Forms.BindingSource biletlerBindingSource;
        private OtobusBiletOtomasyonuDataSet1TableAdapters.BiletlerTableAdapter biletlerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn biletIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kullaniciIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn otobusAdiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kalkisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn varisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kalkisTarihiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn varisTarihiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fiyatDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}