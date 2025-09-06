
namespace CarService
{
    partial class AracSahipBilgiEkran
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSahipSil = new System.Windows.Forms.Button();
            this.btnSahipDüzenle = new System.Windows.Forms.Button();
            this.btnAracSahipEkleme = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvAracSahipBilgi = new System.Windows.Forms.DataGridView();
            this.rctxtIsAdres = new System.Windows.Forms.RichTextBox();
            this.rctxtAdres = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTelefon = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTcKimlik = new System.Windows.Forms.MaskedTextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAracSahipBilgi)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.groupBox1.Controls.Add(this.btnSahipSil);
            this.groupBox1.Controls.Add(this.btnSahipDüzenle);
            this.groupBox1.Controls.Add(this.btnAracSahipEkleme);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.dgvAracSahipBilgi);
            this.groupBox1.Controls.Add(this.rctxtIsAdres);
            this.groupBox1.Controls.Add(this.rctxtAdres);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtTelefon);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtTcKimlik);
            this.groupBox1.Controls.Add(this.txtSoyad);
            this.groupBox1.Controls.Add(this.txtAd);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1048, 522);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnSahipSil
            // 
            this.btnSahipSil.Location = new System.Drawing.Point(705, 94);
            this.btnSahipSil.Name = "btnSahipSil";
            this.btnSahipSil.Size = new System.Drawing.Size(133, 58);
            this.btnSahipSil.TabIndex = 17;
            this.btnSahipSil.Text = "SİL";
            this.btnSahipSil.UseVisualStyleBackColor = true;
            this.btnSahipSil.Click += new System.EventHandler(this.btnSahipSil_Click);
            // 
            // btnSahipDüzenle
            // 
            this.btnSahipDüzenle.Location = new System.Drawing.Point(859, 28);
            this.btnSahipDüzenle.Name = "btnSahipDüzenle";
            this.btnSahipDüzenle.Size = new System.Drawing.Size(133, 49);
            this.btnSahipDüzenle.TabIndex = 16;
            this.btnSahipDüzenle.Text = "Düzenle";
            this.btnSahipDüzenle.UseVisualStyleBackColor = true;
            this.btnSahipDüzenle.Click += new System.EventHandler(this.btnSahipDüzenle_Click);
            // 
            // btnAracSahipEkleme
            // 
            this.btnAracSahipEkleme.Location = new System.Drawing.Point(705, 26);
            this.btnAracSahipEkleme.Name = "btnAracSahipEkleme";
            this.btnAracSahipEkleme.Size = new System.Drawing.Size(133, 52);
            this.btnAracSahipEkleme.TabIndex = 13;
            this.btnAracSahipEkleme.Text = " Ekleme";
            this.btnAracSahipEkleme.UseVisualStyleBackColor = true;
            this.btnAracSahipEkleme.Click += new System.EventHandler(this.btnAracSahipEkleme_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 269);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(172, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Araç Sahip Bilgileri";
            // 
            // dgvAracSahipBilgi
            // 
            this.dgvAracSahipBilgi.AllowUserToAddRows = false;
            this.dgvAracSahipBilgi.AllowUserToDeleteRows = false;
            this.dgvAracSahipBilgi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAracSahipBilgi.Location = new System.Drawing.Point(6, 290);
            this.dgvAracSahipBilgi.Name = "dgvAracSahipBilgi";
            this.dgvAracSahipBilgi.ReadOnly = true;
            this.dgvAracSahipBilgi.RowHeadersWidth = 51;
            this.dgvAracSahipBilgi.RowTemplate.Height = 24;
            this.dgvAracSahipBilgi.Size = new System.Drawing.Size(850, 217);
            this.dgvAracSahipBilgi.TabIndex = 14;
            this.dgvAracSahipBilgi.SelectionChanged += new System.EventHandler(this.dgvAracSahipBilgi_SelectionChanged);
            // 
            // rctxtIsAdres
            // 
            this.rctxtIsAdres.Location = new System.Drawing.Point(500, 134);
            this.rctxtIsAdres.Name = "rctxtIsAdres";
            this.rctxtIsAdres.Size = new System.Drawing.Size(157, 66);
            this.rctxtIsAdres.TabIndex = 12;
            this.rctxtIsAdres.Text = "";
            // 
            // rctxtAdres
            // 
            this.rctxtAdres.Location = new System.Drawing.Point(148, 131);
            this.rctxtAdres.Name = "rctxtAdres";
            this.rctxtAdres.Size = new System.Drawing.Size(157, 66);
            this.rctxtAdres.TabIndex = 12;
            this.rctxtAdres.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(376, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "İş Adresi:";
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(500, 75);
            this.txtTelefon.Mask = "(999) 000-0000";
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(157, 27);
            this.txtTelefon.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Ev Adresi:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(376, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Telefon:";
            // 
            // txtTcKimlik
            // 
            this.txtTcKimlik.Location = new System.Drawing.Point(148, 23);
            this.txtTcKimlik.Mask = "00000000000";
            this.txtTcKimlik.Name = "txtTcKimlik";
            this.txtTcKimlik.Size = new System.Drawing.Size(157, 27);
            this.txtTcKimlik.TabIndex = 2;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(500, 26);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(157, 27);
            this.txtSoyad.TabIndex = 3;
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(148, 76);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(157, 27);
            this.txtAd.TabIndex = 4;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label14.Location = new System.Drawing.Point(376, 34);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(66, 20);
            this.label14.TabIndex = 5;
            this.label14.Text = "Soyad:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label4.Location = new System.Drawing.Point(24, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Ad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label3.Location = new System.Drawing.Point(24, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "TC Kimlik:";
            // 
            // AracSahipBilgiEkran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1126, 557);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "AracSahipBilgiEkran";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Arac Sahip Ekranı";
            this.Load += new System.EventHandler(this.AracSahipBilgiEkran_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAracSahipBilgi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox txtTcKimlik;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox txtTelefon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAracSahipEkleme;
        private System.Windows.Forms.RichTextBox rctxtIsAdres;
        private System.Windows.Forms.RichTextBox rctxtAdres;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvAracSahipBilgi;
        private System.Windows.Forms.Button btnSahipDüzenle;
        private System.Windows.Forms.Button btnSahipSil;
    }
}