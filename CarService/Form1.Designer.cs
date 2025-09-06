
namespace CarService
{
    partial class Form1
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
            this.btnYoneticiGiris = new System.Windows.Forms.Button();
            this.btnPersonelGiris = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnYoneticiGiris
            // 
            this.btnYoneticiGiris.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnYoneticiGiris.Location = new System.Drawing.Point(12, 148);
            this.btnYoneticiGiris.Name = "btnYoneticiGiris";
            this.btnYoneticiGiris.Size = new System.Drawing.Size(170, 40);
            this.btnYoneticiGiris.TabIndex = 0;
            this.btnYoneticiGiris.Text = "Yönetici Giriş";
            this.btnYoneticiGiris.UseVisualStyleBackColor = false;
            this.btnYoneticiGiris.Click += new System.EventHandler(this.btnYoneticiGiris_Click);
            // 
            // btnPersonelGiris
            // 
            this.btnPersonelGiris.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnPersonelGiris.Location = new System.Drawing.Point(234, 148);
            this.btnPersonelGiris.Name = "btnPersonelGiris";
            this.btnPersonelGiris.Size = new System.Drawing.Size(170, 40);
            this.btnPersonelGiris.TabIndex = 1;
            this.btnPersonelGiris.Text = "Personel Giriş";
            this.btnPersonelGiris.UseVisualStyleBackColor = false;
            this.btnPersonelGiris.Click += new System.EventHandler(this.btnPersonelGiris_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.BackgroundImage = global::CarService.Properties.Resources.araba;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(442, 450);
            this.Controls.Add(this.btnPersonelGiris);
            this.Controls.Add(this.btnYoneticiGiris);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Oto Servis Uygulaması";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnYoneticiGiris;
        private System.Windows.Forms.Button btnPersonelGiris;
    }
}

