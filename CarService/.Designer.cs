
namespace CarService
{
    partial class PersonelPasifAlma
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnPasif = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkTümKayıtlar = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.radAdSoyad = new System.Windows.Forms.RadioButton();
            this.cmbAramaTuru = new System.Windows.Forms.ComboBox();
            this.lblArananAlan = new System.Windows.Forms.Label();
            this.txtHizliAra = new System.Windows.Forms.TextBox();
            this.btnAktf = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabAktifPersoneller = new System.Windows.Forms.TabPage();
            this.dtvAktifPersonel = new System.Windows.Forms.DataGridView();
            this.tabPasifPersoneller = new System.Windows.Forms.TabPage();
            this.dtvPasifPersonel = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabAktifPersoneller.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtvAktifPersonel)).BeginInit();
            this.tabPasifPersoneller.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtvPasifPersonel)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(436, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Personel Pasife Alma";
            // 
            // btnPasif
            // 
            this.btnPasif.Location = new System.Drawing.Point(876, 425);
            this.btnPasif.Name = "btnPasif";
            this.btnPasif.Size = new System.Drawing.Size(155, 38);
            this.btnPasif.TabIndex = 3;
            this.btnPasif.Text = "Pasife Al";
            this.btnPasif.UseVisualStyleBackColor = true;
            this.btnPasif.Click += new System.EventHandler(this.btnPasif_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.lblArananAlan);
            this.groupBox1.Controls.Add(this.txtHizliAra);
            this.groupBox1.Location = new System.Drawing.Point(12, 385);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(602, 176);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hızlı Arama";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.groupBox2.Controls.Add(this.chkTümKayıtlar);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.radAdSoyad);
            this.groupBox2.Controls.Add(this.cmbAramaTuru);
            this.groupBox2.Location = new System.Drawing.Point(6, 31);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(294, 139);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            // 
            // chkTümKayıtlar
            // 
            this.chkTümKayıtlar.AutoSize = true;
            this.chkTümKayıtlar.Location = new System.Drawing.Point(12, 62);
            this.chkTümKayıtlar.Name = "chkTümKayıtlar";
            this.chkTümKayıtlar.Size = new System.Drawing.Size(156, 29);
            this.chkTümKayıtlar.TabIndex = 3;
            this.chkTümKayıtlar.Text = "Tüm Kayıtlar";
            this.chkTümKayıtlar.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Arama Türü:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 25);
            this.label3.TabIndex = 1;
            // 
            // radAdSoyad
            // 
            this.radAdSoyad.AutoSize = true;
            this.radAdSoyad.Location = new System.Drawing.Point(11, 101);
            this.radAdSoyad.Name = "radAdSoyad";
            this.radAdSoyad.Size = new System.Drawing.Size(128, 29);
            this.radAdSoyad.TabIndex = 2;
            this.radAdSoyad.TabStop = true;
            this.radAdSoyad.Text = "Ad Soyad";
            this.radAdSoyad.UseVisualStyleBackColor = true;
            // 
            // cmbAramaTuru
            // 
            this.cmbAramaTuru.FormattingEnabled = true;
            this.cmbAramaTuru.Items.AddRange(new object[] {
            "İle Başlayan",
            "İle Biten",
            "İçeren"});
            this.cmbAramaTuru.Location = new System.Drawing.Point(145, 26);
            this.cmbAramaTuru.Name = "cmbAramaTuru";
            this.cmbAramaTuru.Size = new System.Drawing.Size(119, 33);
            this.cmbAramaTuru.TabIndex = 2;
            this.cmbAramaTuru.Text = "Seçiniz";
            // 
            // lblArananAlan
            // 
            this.lblArananAlan.AutoSize = true;
            this.lblArananAlan.Location = new System.Drawing.Point(306, 47);
            this.lblArananAlan.Name = "lblArananAlan";
            this.lblArananAlan.Size = new System.Drawing.Size(134, 25);
            this.lblArananAlan.TabIndex = 6;
            this.lblArananAlan.Text = "Tüm Kayıtlar";
            // 
            // txtHizliAra
            // 
            this.txtHizliAra.Location = new System.Drawing.Point(446, 44);
            this.txtHizliAra.Name = "txtHizliAra";
            this.txtHizliAra.Size = new System.Drawing.Size(140, 30);
            this.txtHizliAra.TabIndex = 5;
            // 
            // btnAktf
            // 
            this.btnAktf.Location = new System.Drawing.Point(689, 425);
            this.btnAktf.Name = "btnAktf";
            this.btnAktf.Size = new System.Drawing.Size(155, 38);
            this.btnAktf.TabIndex = 5;
            this.btnAktf.Text = "Aktife AL";
            this.btnAktf.UseVisualStyleBackColor = true;
            this.btnAktf.Click += new System.EventHandler(this.btnAktf_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabAktifPersoneller);
            this.tabControl1.Controls.Add(this.tabPasifPersoneller);
            this.tabControl1.Location = new System.Drawing.Point(12, 58);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1117, 321);
            this.tabControl1.TabIndex = 6;
            // 
            // tabAktifPersoneller
            // 
            this.tabAktifPersoneller.Controls.Add(this.dtvAktifPersonel);
            this.tabAktifPersoneller.Location = new System.Drawing.Point(4, 34);
            this.tabAktifPersoneller.Name = "tabAktifPersoneller";
            this.tabAktifPersoneller.Padding = new System.Windows.Forms.Padding(3);
            this.tabAktifPersoneller.Size = new System.Drawing.Size(1109, 283);
            this.tabAktifPersoneller.TabIndex = 0;
            this.tabAktifPersoneller.Text = "Aktif Personeller";
            this.tabAktifPersoneller.UseVisualStyleBackColor = true;
            // 
            // dtvAktifPersonel
            // 
            this.dtvAktifPersonel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvAktifPersonel.Location = new System.Drawing.Point(2, 3);
            this.dtvAktifPersonel.Name = "dtvAktifPersonel";
            this.dtvAktifPersonel.RowHeadersWidth = 51;
            this.dtvAktifPersonel.RowTemplate.Height = 24;
            this.dtvAktifPersonel.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtvAktifPersonel.Size = new System.Drawing.Size(1106, 277);
            this.dtvAktifPersonel.TabIndex = 0;
            // 
            // tabPasifPersoneller
            // 
            this.tabPasifPersoneller.Controls.Add(this.dtvPasifPersonel);
            this.tabPasifPersoneller.Location = new System.Drawing.Point(4, 34);
            this.tabPasifPersoneller.Name = "tabPasifPersoneller";
            this.tabPasifPersoneller.Padding = new System.Windows.Forms.Padding(3);
            this.tabPasifPersoneller.Size = new System.Drawing.Size(1109, 283);
            this.tabPasifPersoneller.TabIndex = 1;
            this.tabPasifPersoneller.Text = "Pasif Personeller";
            this.tabPasifPersoneller.UseVisualStyleBackColor = true;
            // 
            // dtvPasifPersonel
            // 
            this.dtvPasifPersonel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvPasifPersonel.Location = new System.Drawing.Point(2, 0);
            this.dtvPasifPersonel.Name = "dtvPasifPersonel";
            this.dtvPasifPersonel.RowHeadersWidth = 51;
            this.dtvPasifPersonel.RowTemplate.Height = 24;
            this.dtvPasifPersonel.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtvPasifPersonel.Size = new System.Drawing.Size(1100, 274);
            this.dtvPasifPersonel.TabIndex = 0;
            // 
            // PersonelPasifAlma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1151, 602);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnAktf);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnPasif);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "PersonelPasifAlma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personel Pasife Alma";
            this.Load += new System.EventHandler(this.PersonelPasifAlma_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabAktifPersoneller.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtvAktifPersonel)).EndInit();
            this.tabPasifPersoneller.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtvPasifPersonel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPasif;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbAramaTuru;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblArananAlan;
        private System.Windows.Forms.TextBox txtHizliAra;
        private System.Windows.Forms.RadioButton radAdSoyad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnAktf;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabAktifPersoneller;
        private System.Windows.Forms.TabPage tabPasifPersoneller;
        private System.Windows.Forms.DataGridView dtvPasifPersonel;
        private System.Windows.Forms.DataGridView dtvAktifPersonel;
        private System.Windows.Forms.CheckBox chkTümKayıtlar;
    }
}