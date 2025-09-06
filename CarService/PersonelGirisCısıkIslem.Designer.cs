
namespace CarService
{
    partial class PersonelGirisCısıkIslem
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
            this.dgvPersonelGırısCıkısIslemleri = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGeri = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonelGırısCıkısIslemleri)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPersonelGırısCıkısIslemleri
            // 
            this.dgvPersonelGırısCıkısIslemleri.AllowUserToAddRows = false;
            this.dgvPersonelGırısCıkısIslemleri.AllowUserToDeleteRows = false;
            this.dgvPersonelGırısCıkısIslemleri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersonelGırısCıkısIslemleri.Location = new System.Drawing.Point(59, 70);
            this.dgvPersonelGırısCıkısIslemleri.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvPersonelGırısCıkısIslemleri.Name = "dgvPersonelGırısCıkısIslemleri";
            this.dgvPersonelGırısCıkısIslemleri.ReadOnly = true;
            this.dgvPersonelGırısCıkısIslemleri.RowHeadersWidth = 51;
            this.dgvPersonelGırısCıkısIslemleri.RowTemplate.Height = 24;
            this.dgvPersonelGırısCıkısIslemleri.Size = new System.Drawing.Size(949, 231);
            this.dgvPersonelGırısCıkısIslemleri.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(385, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Personel Giriş Cıkış Saatleri";
            // 
            // btnGeri
            // 
            this.btnGeri.Location = new System.Drawing.Point(12, 12);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(130, 37);
            this.btnGeri.TabIndex = 2;
            this.btnGeri.Text = "Geri Dön";
            this.btnGeri.UseVisualStyleBackColor = true;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // PersonelGirisCısıkIslem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1111, 410);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvPersonelGırısCıkısIslemleri);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "PersonelGirisCısıkIslem";
            this.Text = "PersonelGirisCısıkIslem";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonelGırısCıkısIslemleri)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPersonelGırısCıkısIslemleri;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGeri;
    }
}