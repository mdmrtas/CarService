
namespace CarService
{
    partial class YöneticiPanel
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
            this.bilgileriGüncelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pesonelEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personelSilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeyiYenileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personelGirisSaatleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dt = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgvPersonelListesi = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvBekleyenIslemler = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dgvBitenIslemler = new System.Windows.Forms.DataGridView();
            this.raporlamaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.dt.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonelListesi)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBekleyenIslemler)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBitenIslemler)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.bilgileriGüncelleToolStripMenuItem,
            this.pesonelEkleToolStripMenuItem,
            this.personelSilToolStripMenuItem,
            this.listeyiYenileToolStripMenuItem,
            this.personelGirisSaatleriToolStripMenuItem,
            this.raporlamaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1774, 48);
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
            this.toolStripMenuItem1.Size = new System.Drawing.Size(80, 44);
            this.toolStripMenuItem1.Text = "Menü";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(154, 26);
            this.toolStripMenuItem2.Text = "Hakkında";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Image = global::CarService.Properties.Resources.çıkış;
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(154, 26);
            this.toolStripMenuItem3.Text = "Çıkış";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // bilgileriGüncelleToolStripMenuItem
            // 
            this.bilgileriGüncelleToolStripMenuItem.Image = global::CarService.Properties.Resources.personalbilgigüncelle;
            this.bilgileriGüncelleToolStripMenuItem.Name = "bilgileriGüncelleToolStripMenuItem";
            this.bilgileriGüncelleToolStripMenuItem.Size = new System.Drawing.Size(135, 44);
            this.bilgileriGüncelleToolStripMenuItem.Text = "Bilgileri Güncelle";
            this.bilgileriGüncelleToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.bilgileriGüncelleToolStripMenuItem.Click += new System.EventHandler(this.bilgileriGüncelleToolStripMenuItem_Click);
            // 
            // pesonelEkleToolStripMenuItem
            // 
            this.pesonelEkleToolStripMenuItem.Image = global::CarService.Properties.Resources.personalekle;
            this.pesonelEkleToolStripMenuItem.Name = "pesonelEkleToolStripMenuItem";
            this.pesonelEkleToolStripMenuItem.Size = new System.Drawing.Size(104, 44);
            this.pesonelEkleToolStripMenuItem.Text = "Pesonel Ekle";
            this.pesonelEkleToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.pesonelEkleToolStripMenuItem.Click += new System.EventHandler(this.pesonelEkleToolStripMenuItem_Click);
            // 
            // personelSilToolStripMenuItem
            // 
            this.personelSilToolStripMenuItem.Image = global::CarService.Properties.Resources.personalsil;
            this.personelSilToolStripMenuItem.Name = "personelSilToolStripMenuItem";
            this.personelSilToolStripMenuItem.Size = new System.Drawing.Size(159, 44);
            this.personelSilToolStripMenuItem.Text = "Personel Pasife Alma";
            this.personelSilToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.personelSilToolStripMenuItem.Click += new System.EventHandler(this.PersonelPasifAlmalToolStripMenuItem_Click);
            // 
            // listeyiYenileToolStripMenuItem
            // 
            this.listeyiYenileToolStripMenuItem.Image = global::CarService.Properties.Resources.Günceller;
            this.listeyiYenileToolStripMenuItem.Name = "listeyiYenileToolStripMenuItem";
            this.listeyiYenileToolStripMenuItem.Size = new System.Drawing.Size(107, 44);
            this.listeyiYenileToolStripMenuItem.Text = "Listeyi Yenile";
            this.listeyiYenileToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.listeyiYenileToolStripMenuItem.Click += new System.EventHandler(this.listeyiYenileToolStripMenuItem_Click);
            // 
            // personelGirisSaatleriToolStripMenuItem
            // 
            this.personelGirisSaatleriToolStripMenuItem.Name = "personelGirisSaatleriToolStripMenuItem";
            this.personelGirisSaatleriToolStripMenuItem.Size = new System.Drawing.Size(165, 44);
            this.personelGirisSaatleriToolStripMenuItem.Text = "Personel Giris Saatleri";
            this.personelGirisSaatleriToolStripMenuItem.Click += new System.EventHandler(this.personelGirisSaatleriToolStripMenuItem_Click);
            // 
            // dt
            // 
            this.dt.Controls.Add(this.tabPage1);
            this.dt.Controls.Add(this.tabPage2);
            this.dt.Controls.Add(this.tabPage3);
            this.dt.Location = new System.Drawing.Point(12, 96);
            this.dt.Name = "dt";
            this.dt.SelectedIndex = 0;
            this.dt.Size = new System.Drawing.Size(1733, 358);
            this.dt.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvPersonelListesi);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1725, 329);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Personel Lİstesi";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvPersonelListesi
            // 
            this.dgvPersonelListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersonelListesi.Location = new System.Drawing.Point(6, 3);
            this.dgvPersonelListesi.Name = "dgvPersonelListesi";
            this.dgvPersonelListesi.RowHeadersWidth = 51;
            this.dgvPersonelListesi.RowTemplate.Height = 24;
            this.dgvPersonelListesi.Size = new System.Drawing.Size(1740, 384);
            this.dgvPersonelListesi.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgvBekleyenIslemler);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1725, 329);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Bekleyen İşlemler";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvBekleyenIslemler
            // 
            this.dgvBekleyenIslemler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBekleyenIslemler.Location = new System.Drawing.Point(3, 0);
            this.dgvBekleyenIslemler.Name = "dgvBekleyenIslemler";
            this.dgvBekleyenIslemler.RowHeadersWidth = 51;
            this.dgvBekleyenIslemler.RowTemplate.Height = 24;
            this.dgvBekleyenIslemler.Size = new System.Drawing.Size(1716, 329);
            this.dgvBekleyenIslemler.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dgvBitenIslemler);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1725, 329);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Biten İşlemler";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dgvBitenIslemler
            // 
            this.dgvBitenIslemler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBitenIslemler.Location = new System.Drawing.Point(3, 3);
            this.dgvBitenIslemler.Name = "dgvBitenIslemler";
            this.dgvBitenIslemler.RowHeadersWidth = 51;
            this.dgvBitenIslemler.RowTemplate.Height = 24;
            this.dgvBitenIslemler.Size = new System.Drawing.Size(1716, 320);
            this.dgvBitenIslemler.TabIndex = 0;
            // 
            // raporlamaToolStripMenuItem
            // 
            this.raporlamaToolStripMenuItem.Name = "raporlamaToolStripMenuItem";
            this.raporlamaToolStripMenuItem.Size = new System.Drawing.Size(96, 44);
            this.raporlamaToolStripMenuItem.Text = "Raporlama";
            this.raporlamaToolStripMenuItem.Click += new System.EventHandler(this.raporlamaToolStripMenuItem_Click);
            // 
            // YöneticiPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1774, 518);
            this.Controls.Add(this.dt);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "YöneticiPanel";
            this.Text = "YöneticiPanel";
            this.Load += new System.EventHandler(this.YöneticiPanel_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.dt.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonelListesi)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBekleyenIslemler)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBitenIslemler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem bilgileriGüncelleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pesonelEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personelSilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listeyiYenileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgvPersonelListesi;
        private System.Windows.Forms.TabPage tabPage3;
        public System.Windows.Forms.TabControl dt;
        public System.Windows.Forms.DataGridView dgvBekleyenIslemler;
        public System.Windows.Forms.DataGridView dgvBitenIslemler;
        private System.Windows.Forms.ToolStripMenuItem personelGirisSaatleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem raporlamaToolStripMenuItem;
    }
}