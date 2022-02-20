
namespace HastaneOtomasyonu
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
            this.btnKulİslem = new System.Windows.Forms.Button();
            this.btnHastaİslem = new System.Windows.Forms.Button();
            this.btnYonetİslem = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnKulİslem
            // 
            this.btnKulİslem.Location = new System.Drawing.Point(167, 28);
            this.btnKulİslem.Name = "btnKulİslem";
            this.btnKulİslem.Size = new System.Drawing.Size(192, 99);
            this.btnKulİslem.TabIndex = 0;
            this.btnKulİslem.Text = "Kullanıcı İşlemleri";
            this.btnKulİslem.UseVisualStyleBackColor = true;
            this.btnKulİslem.Click += new System.EventHandler(this.btnKulİslem_Click);
            // 
            // btnHastaİslem
            // 
            this.btnHastaİslem.Location = new System.Drawing.Point(167, 169);
            this.btnHastaİslem.Name = "btnHastaİslem";
            this.btnHastaİslem.Size = new System.Drawing.Size(192, 99);
            this.btnHastaİslem.TabIndex = 1;
            this.btnHastaİslem.Text = "Hasta İşlemleri";
            this.btnHastaİslem.UseVisualStyleBackColor = true;
            this.btnHastaİslem.Click += new System.EventHandler(this.btnHastaİslem_Click);
            // 
            // btnYonetİslem
            // 
            this.btnYonetİslem.Location = new System.Drawing.Point(167, 306);
            this.btnYonetİslem.Name = "btnYonetİslem";
            this.btnYonetİslem.Size = new System.Drawing.Size(192, 99);
            this.btnYonetİslem.TabIndex = 2;
            this.btnYonetİslem.Text = "Yönetim İşlemleri";
            this.btnYonetİslem.UseVisualStyleBackColor = true;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(587, 503);
            this.Controls.Add(this.btnYonetİslem);
            this.Controls.Add(this.btnHastaİslem);
            this.Controls.Add(this.btnKulİslem);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnKulİslem;
        private System.Windows.Forms.Button btnHastaİslem;
        private System.Windows.Forms.Button btnYonetİslem;
    }
}