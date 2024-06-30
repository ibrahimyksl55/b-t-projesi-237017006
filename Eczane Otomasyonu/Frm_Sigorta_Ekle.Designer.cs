namespace Eczane_Otomasyonu
{
    partial class Frm_Sigorta_Ekle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Sigorta_Ekle));
            this.BTN_Kaydet = new System.Windows.Forms.Button();
            this.TXTB_SigortaAdı = new System.Windows.Forms.TextBox();
            this.LBL_SİGORTAADI = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BTN_Kaydet
            // 
            this.BTN_Kaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BTN_Kaydet.Location = new System.Drawing.Point(162, 92);
            this.BTN_Kaydet.Name = "BTN_Kaydet";
            this.BTN_Kaydet.Size = new System.Drawing.Size(137, 26);
            this.BTN_Kaydet.TabIndex = 25;
            this.BTN_Kaydet.Text = "KAYDET";
            this.BTN_Kaydet.UseVisualStyleBackColor = true;
            this.BTN_Kaydet.Click += new System.EventHandler(this.BTN_Kaydet_Click);
            // 
            // TXTB_SigortaAdı
            // 
            this.TXTB_SigortaAdı.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TXTB_SigortaAdı.Location = new System.Drawing.Point(162, 60);
            this.TXTB_SigortaAdı.Name = "TXTB_SigortaAdı";
            this.TXTB_SigortaAdı.Size = new System.Drawing.Size(137, 26);
            this.TXTB_SigortaAdı.TabIndex = 24;
            // 
            // LBL_SİGORTAADI
            // 
            this.LBL_SİGORTAADI.AutoSize = true;
            this.LBL_SİGORTAADI.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LBL_SİGORTAADI.Location = new System.Drawing.Point(15, 63);
            this.LBL_SİGORTAADI.Name = "LBL_SİGORTAADI";
            this.LBL_SİGORTAADI.Size = new System.Drawing.Size(114, 20);
            this.LBL_SİGORTAADI.TabIndex = 20;
            this.LBL_SİGORTAADI.Text = "SİGORTA ADI";
            // 
            // Frm_Sigorta_Ekle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 191);
            this.Controls.Add(this.BTN_Kaydet);
            this.Controls.Add(this.TXTB_SigortaAdı);
            this.Controls.Add(this.LBL_SİGORTAADI);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_Sigorta_Ekle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sigorta Ekle";
            this.Load += new System.EventHandler(this.Frm_Sigorta_Ekle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTN_Kaydet;
        private System.Windows.Forms.TextBox TXTB_SigortaAdı;
        private System.Windows.Forms.Label LBL_SİGORTAADI;
    }
}