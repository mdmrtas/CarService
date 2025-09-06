
namespace CarService
{
    partial class PersonelEkranı
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.aracSahipBilgiKayıtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSasiNumarası = new System.Windows.Forms.MaskedTextBox();
            this.cmbBakimTuru = new System.Windows.Forms.ComboBox();
            this.cmbGaranti = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dateTeslimTarihi = new System.Windows.Forms.DateTimePicker();
            this.dateBakımTarihi = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.btnBakımSil = new System.Windows.Forms.Button();
            this.btnIslemiTamamla = new System.Windows.Forms.Button();
            this.btnBakımGuncelle = new System.Windows.Forms.Button();
            this.btnBakımEkle = new System.Windows.Forms.Button();
            this.cmbAracSahip = new System.Windows.Forms.ComboBox();
            this.cmbIlgilenenPersonel = new System.Windows.Forms.ComboBox();
            this.cmbMarka = new System.Windows.Forms.ComboBox();
            this.txtKilometre = new System.Windows.Forms.TextBox();
            this.txtPlaka = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtPlakaAra = new System.Windows.Forms.TextBox();
            this.btnFiltrele = new System.Windows.Forms.Button();
            this.btnAra = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbMarkaAra = new System.Windows.Forms.ComboBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgvBekleyenIsler = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvBitenIsler = new System.Windows.Forms.DataGridView();
            this.raporlamaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBekleyenIsler)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBitenIsler)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Silver;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem5,
            this.aracSahipBilgiKayıtToolStripMenuItem,
            this.raporlamaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1245, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem3});
            this.toolStripMenuItem1.Image = global::CarService.Properties.Resources.menü;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(80, 24);
            this.toolStripMenuItem1.Text = "Menü";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(158, 26);
            this.toolStripMenuItem2.Text = "Ana Sayfa";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(158, 26);
            this.toolStripMenuItem3.Text = "Çıkış";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Image = global::CarService.Properties.Resources.Günceller;
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(133, 24);
            this.toolStripMenuItem5.Text = "Sayfayı Yenile";
            this.toolStripMenuItem5.Click += new System.EventHandler(this.toolStripMenuItem5_Click);
            // 
            // aracSahipBilgiKayıtToolStripMenuItem
            // 
            this.aracSahipBilgiKayıtToolStripMenuItem.Name = "aracSahipBilgiKayıtToolStripMenuItem";
            this.aracSahipBilgiKayıtToolStripMenuItem.Size = new System.Drawing.Size(165, 24);
            this.aracSahipBilgiKayıtToolStripMenuItem.Text = "Arac Sahip Bilgi Kayıt";
            this.aracSahipBilgiKayıtToolStripMenuItem.Click += new System.EventHandler(this.aracSahipBilgiKayıtToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtSasiNumarası);
            this.groupBox1.Controls.Add(this.cmbBakimTuru);
            this.groupBox1.Controls.Add(this.cmbGaranti);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.dateTeslimTarihi);
            this.groupBox1.Controls.Add(this.dateBakımTarihi);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btnTemizle);
            this.groupBox1.Controls.Add(this.btnBakımSil);
            this.groupBox1.Controls.Add(this.btnIslemiTamamla);
            this.groupBox1.Controls.Add(this.btnBakımGuncelle);
            this.groupBox1.Controls.Add(this.btnBakımEkle);
            this.groupBox1.Controls.Add(this.cmbAracSahip);
            this.groupBox1.Controls.Add(this.cmbIlgilenenPersonel);
            this.groupBox1.Controls.Add(this.cmbMarka);
            this.groupBox1.Controls.Add(this.txtKilometre);
            this.groupBox1.Controls.Add(this.txtPlaka);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(653, 378);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Araç Bakım Kaydı";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtSasiNumarası
            // 
            this.txtSasiNumarası.Location = new System.Drawing.Point(161, 125);
            this.txtSasiNumarası.Mask = "000000000000000000";
            this.txtSasiNumarası.Name = "txtSasiNumarası";
            this.txtSasiNumarası.Size = new System.Drawing.Size(191, 27);
            this.txtSasiNumarası.TabIndex = 2;
            // 
            // cmbBakimTuru
            // 
            this.cmbBakimTuru.FormattingEnabled = true;
            this.cmbBakimTuru.Items.AddRange(new object[] {
            "Yıllık Bakım\t",
            "Yağ Bakım ",
            "Motor Yenileme",
            "Boya",
            "Kaporta"});
            this.cmbBakimTuru.Location = new System.Drawing.Point(161, 223);
            this.cmbBakimTuru.Name = "cmbBakimTuru";
            this.cmbBakimTuru.Size = new System.Drawing.Size(187, 28);
            this.cmbBakimTuru.TabIndex = 4;
            // 
            // cmbGaranti
            // 
            this.cmbGaranti.FormattingEnabled = true;
            this.cmbGaranti.Items.AddRange(new object[] {
            "Garanti Devam Ediyor",
            "Garantisi Bitmiş"});
            this.cmbGaranti.Location = new System.Drawing.Point(161, 310);
            this.cmbGaranti.Name = "cmbGaranti";
            this.cmbGaranti.Size = new System.Drawing.Size(151, 28);
            this.cmbGaranti.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(354, 89);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 20);
            this.label9.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(0, 313);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(143, 20);
            this.label8.TabIndex = 8;
            this.label8.Text = "Garanti Durumu";
            // 
            // dateTeslimTarihi
            // 
            this.dateTeslimTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTeslimTarihi.Location = new System.Drawing.Point(470, 268);
            this.dateTeslimTarihi.Name = "dateTeslimTarihi";
            this.dateTeslimTarihi.Size = new System.Drawing.Size(168, 27);
            this.dateTeslimTarihi.TabIndex = 6;
            // 
            // dateBakımTarihi
            // 
            this.dateBakımTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateBakımTarihi.Location = new System.Drawing.Point(161, 268);
            this.dateBakımTarihi.Name = "dateBakımTarihi";
            this.dateBakımTarihi.Size = new System.Drawing.Size(169, 27);
            this.dateBakımTarihi.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(336, 271);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 20);
            this.label7.TabIndex = 5;
            this.label7.Text = "Teslim Tarihi";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 271);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Bakım Tarihi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 223);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Bakım Türü";
            // 
            // btnTemizle
            // 
            this.btnTemizle.Location = new System.Drawing.Point(516, 27);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(104, 35);
            this.btnTemizle.TabIndex = 3;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // btnBakımSil
            // 
            this.btnBakımSil.Location = new System.Drawing.Point(516, 82);
            this.btnBakımSil.Name = "btnBakımSil";
            this.btnBakımSil.Size = new System.Drawing.Size(122, 35);
            this.btnBakımSil.TabIndex = 3;
            this.btnBakımSil.Text = "Bakım Sİl";
            this.btnBakımSil.UseVisualStyleBackColor = true;
            this.btnBakımSil.Click += new System.EventHandler(this.btnBakımSil_Click);
            // 
            // btnIslemiTamamla
            // 
            this.btnIslemiTamamla.Location = new System.Drawing.Point(358, 132);
            this.btnIslemiTamamla.Name = "btnIslemiTamamla";
            this.btnIslemiTamamla.Size = new System.Drawing.Size(151, 35);
            this.btnIslemiTamamla.TabIndex = 3;
            this.btnIslemiTamamla.Text = "İşlem Tamamla";
            this.btnIslemiTamamla.UseVisualStyleBackColor = true;
            this.btnIslemiTamamla.Click += new System.EventHandler(this.btnIslemiTamamla_Click);
            // 
            // btnBakımGuncelle
            // 
            this.btnBakımGuncelle.Location = new System.Drawing.Point(358, 82);
            this.btnBakımGuncelle.Name = "btnBakımGuncelle";
            this.btnBakımGuncelle.Size = new System.Drawing.Size(151, 35);
            this.btnBakımGuncelle.TabIndex = 3;
            this.btnBakımGuncelle.Text = "Bakım Güncelle";
            this.btnBakımGuncelle.UseVisualStyleBackColor = true;
            this.btnBakımGuncelle.Click += new System.EventHandler(this.btnBakımGuncelle_Click);
            // 
            // btnBakımEkle
            // 
            this.btnBakımEkle.Location = new System.Drawing.Point(358, 27);
            this.btnBakımEkle.Name = "btnBakımEkle";
            this.btnBakımEkle.Size = new System.Drawing.Size(126, 35);
            this.btnBakımEkle.TabIndex = 3;
            this.btnBakımEkle.Text = "Bakım Ekle";
            this.btnBakımEkle.UseVisualStyleBackColor = true;
            this.btnBakımEkle.Click += new System.EventHandler(this.btnBakımEkle_Click);
            // 
            // cmbAracSahip
            // 
            this.cmbAracSahip.FormattingEnabled = true;
            this.cmbAracSahip.Items.AddRange(new object[] {
            "mehmed\t",
            "serhat",
            "muhammed",
            "elif",
            "deniz"});
            this.cmbAracSahip.Location = new System.Drawing.Point(470, 228);
            this.cmbAracSahip.Name = "cmbAracSahip";
            this.cmbAracSahip.Size = new System.Drawing.Size(168, 28);
            this.cmbAracSahip.TabIndex = 8;
            // 
            // cmbIlgilenenPersonel
            // 
            this.cmbIlgilenenPersonel.FormattingEnabled = true;
            this.cmbIlgilenenPersonel.Items.AddRange(new object[] {
            "mehmed\t",
            "serhat",
            "muhammed",
            "elif",
            "deniz"});
            this.cmbIlgilenenPersonel.Location = new System.Drawing.Point(470, 185);
            this.cmbIlgilenenPersonel.Name = "cmbIlgilenenPersonel";
            this.cmbIlgilenenPersonel.Size = new System.Drawing.Size(168, 28);
            this.cmbIlgilenenPersonel.TabIndex = 8;
            // 
            // cmbMarka
            // 
            this.cmbMarka.FormattingEnabled = true;
            this.cmbMarka.Items.AddRange(new object[] {
            "Porsche",
            "Ferrari",
            "Lamborghini",
            "Bugatti",
            "Rolls-Royce"});
            this.cmbMarka.Location = new System.Drawing.Point(161, 81);
            this.cmbMarka.Name = "cmbMarka";
            this.cmbMarka.Size = new System.Drawing.Size(187, 28);
            this.cmbMarka.TabIndex = 1;
            // 
            // txtKilometre
            // 
            this.txtKilometre.Location = new System.Drawing.Point(161, 169);
            this.txtKilometre.Name = "txtKilometre";
            this.txtKilometre.Size = new System.Drawing.Size(187, 27);
            this.txtKilometre.TabIndex = 3;
            // 
            // txtPlaka
            // 
            this.txtPlaka.Location = new System.Drawing.Point(161, 39);
            this.txtPlaka.Name = "txtPlaka";
            this.txtPlaka.Size = new System.Drawing.Size(187, 27);
            this.txtPlaka.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Kilometre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Şasi Numarası";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Marka";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(354, 231);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(101, 20);
            this.label13.TabIndex = 0;
            this.label13.Text = "Arac Sahip";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(354, 193);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(83, 20);
            this.label12.TabIndex = 0;
            this.label12.Text = "Personel";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Plaka";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtPlakaAra);
            this.groupBox2.Controls.Add(this.btnFiltrele);
            this.groupBox2.Controls.Add(this.btnAra);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.cmbMarkaAra);
            this.groupBox2.Location = new System.Drawing.Point(671, 55);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(237, 143);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Arama / Filtreme";
            // 
            // txtPlakaAra
            // 
            this.txtPlakaAra.Location = new System.Drawing.Point(89, 30);
            this.txtPlakaAra.Name = "txtPlakaAra";
            this.txtPlakaAra.Size = new System.Drawing.Size(142, 27);
            this.txtPlakaAra.TabIndex = 2;
            // 
            // btnFiltrele
            // 
            this.btnFiltrele.Location = new System.Drawing.Point(128, 105);
            this.btnFiltrele.Name = "btnFiltrele";
            this.btnFiltrele.Size = new System.Drawing.Size(82, 32);
            this.btnFiltrele.TabIndex = 1;
            this.btnFiltrele.Text = "Filtrele";
            this.btnFiltrele.UseVisualStyleBackColor = true;
            // 
            // btnAra
            // 
            this.btnAra.Location = new System.Drawing.Point(10, 105);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(86, 32);
            this.btnAra.TabIndex = 1;
            this.btnAra.Text = "Ara";
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 73);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 20);
            this.label11.TabIndex = 0;
            this.label11.Text = "Marka";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 33);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 20);
            this.label10.TabIndex = 0;
            this.label10.Text = "Plaka";
            // 
            // cmbMarkaAra
            // 
            this.cmbMarkaAra.FormattingEnabled = true;
            this.cmbMarkaAra.Location = new System.Drawing.Point(89, 65);
            this.cmbMarkaAra.Name = "cmbMarkaAra";
            this.cmbMarkaAra.Size = new System.Drawing.Size(142, 28);
            this.cmbMarkaAra.TabIndex = 2;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 430);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1221, 236);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvBekleyenIsler);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1213, 203);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Bekleyen İşler";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvBekleyenIsler
            // 
            this.dgvBekleyenIsler.AllowUserToAddRows = false;
            this.dgvBekleyenIsler.AllowUserToDeleteRows = false;
            this.dgvBekleyenIsler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBekleyenIsler.Location = new System.Drawing.Point(0, 3);
            this.dgvBekleyenIsler.Name = "dgvBekleyenIsler";
            this.dgvBekleyenIsler.ReadOnly = true;
            this.dgvBekleyenIsler.RowHeadersWidth = 51;
            this.dgvBekleyenIsler.RowTemplate.Height = 24;
            this.dgvBekleyenIsler.Size = new System.Drawing.Size(1210, 197);
            this.dgvBekleyenIsler.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgvBitenIsler);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1213, 203);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Biten İşler";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvBitenIsler
            // 
            this.dgvBitenIsler.AllowUserToAddRows = false;
            this.dgvBitenIsler.AllowUserToDeleteRows = false;
            this.dgvBitenIsler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBitenIsler.Location = new System.Drawing.Point(3, 0);
            this.dgvBitenIsler.Name = "dgvBitenIsler";
            this.dgvBitenIsler.ReadOnly = true;
            this.dgvBitenIsler.RowHeadersWidth = 51;
            this.dgvBitenIsler.RowTemplate.Height = 24;
            this.dgvBitenIsler.Size = new System.Drawing.Size(1207, 194);
            this.dgvBitenIsler.TabIndex = 0;
            // 
            // raporlamaToolStripMenuItem
            // 
            this.raporlamaToolStripMenuItem.Name = "raporlamaToolStripMenuItem";
            this.raporlamaToolStripMenuItem.Size = new System.Drawing.Size(96, 24);
            this.raporlamaToolStripMenuItem.Text = "Raporlama";
            this.raporlamaToolStripMenuItem.Click += new System.EventHandler(this.raporlamaToolStripMenuItem_Click);
            // 
            // PersonelEkranı
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1245, 671);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PersonelEkranı";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personel Ekranı";
            this.Load += new System.EventHandler(this.PersonelEkranı_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBekleyenIsler)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBitenIsler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateBakımTarihi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Button btnBakımSil;
        private System.Windows.Forms.Button btnBakımGuncelle;
        private System.Windows.Forms.Button btnBakımEkle;
        private System.Windows.Forms.ComboBox cmbMarka;
        private System.Windows.Forms.TextBox txtKilometre;
        private System.Windows.Forms.TextBox txtPlaka;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbGaranti;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateTeslimTarihi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtPlakaAra;
        private System.Windows.Forms.Button btnFiltrele;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbMarkaAra;
        private System.Windows.Forms.ComboBox cmbIlgilenenPersonel;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cmbBakimTuru;
        private System.Windows.Forms.Button btnIslemiTamamla;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.MaskedTextBox txtSasiNumarası;
        private System.Windows.Forms.ToolStripMenuItem aracSahipBilgiKayıtToolStripMenuItem;
        private System.Windows.Forms.ComboBox cmbAracSahip;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dgvBekleyenIsler;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgvBitenIsler;
        private System.Windows.Forms.ToolStripMenuItem raporlamaToolStripMenuItem;
    }
}