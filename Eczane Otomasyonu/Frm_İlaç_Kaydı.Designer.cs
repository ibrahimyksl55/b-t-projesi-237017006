namespace Eczane_Otomasyonu
{
    partial class Frm_İlaç_Kaydı
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_İlaç_Kaydı));
            this.BTN_İlaçKaydet = new System.Windows.Forms.Button();
            this.TXTB_FirmaAdı = new System.Windows.Forms.TextBox();
            this.TXTB_İlaçAdı = new System.Windows.Forms.TextBox();
            this.MTXTB_Fiyat = new System.Windows.Forms.MaskedTextBox();
            this.LBL_ADET = new System.Windows.Forms.Label();
            this.LBL_FİYAT = new System.Windows.Forms.Label();
            this.LBL_FİRMA = new System.Windows.Forms.Label();
            this.LBL_İLAÇADI = new System.Windows.Forms.Label();
            this.MTXTB_Adet = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // BTN_İlaçKaydet
            // 
            this.BTN_İlaçKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BTN_İlaçKaydet.Location = new System.Drawing.Point(189, 198);
            this.BTN_İlaçKaydet.Name = "BTN_İlaçKaydet";
            this.BTN_İlaçKaydet.Size = new System.Drawing.Size(104, 35);
            this.BTN_İlaçKaydet.TabIndex = 16;
            this.BTN_İlaçKaydet.Text = "KAYDET";
            this.BTN_İlaçKaydet.UseVisualStyleBackColor = true;
            this.BTN_İlaçKaydet.Click += new System.EventHandler(this.BTN_İlaçKaydet_Click);
            // 
            // TXTB_FirmaAdı
            // 
            this.TXTB_FirmaAdı.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TXTB_FirmaAdı.Location = new System.Drawing.Point(189, 74);
            this.TXTB_FirmaAdı.Name = "TXTB_FirmaAdı";
            this.TXTB_FirmaAdı.Size = new System.Drawing.Size(137, 26);
            this.TXTB_FirmaAdı.TabIndex = 14;
            this.TXTB_FirmaAdı.TextChanged += new System.EventHandler(this.TXTB_FirmaAdı_TextChanged);
            // 
            // TXTB_İlaçAdı
            // 
            this.TXTB_İlaçAdı.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TXTB_İlaçAdı.Location = new System.Drawing.Point(189, 39);
            this.TXTB_İlaçAdı.Name = "TXTB_İlaçAdı";
            this.TXTB_İlaçAdı.Size = new System.Drawing.Size(137, 26);
            this.TXTB_İlaçAdı.TabIndex = 15;
            this.TXTB_İlaçAdı.TextChanged += new System.EventHandler(this.TXTB_İlaçAdı_TextChanged);
            // 
            // MTXTB_Fiyat
            // 
            this.MTXTB_Fiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MTXTB_Fiyat.Location = new System.Drawing.Point(189, 106);
            this.MTXTB_Fiyat.Mask = "00000";
            this.MTXTB_Fiyat.Name = "MTXTB_Fiyat";
            this.MTXTB_Fiyat.Size = new System.Drawing.Size(137, 26);
            this.MTXTB_Fiyat.TabIndex = 12;
            this.MTXTB_Fiyat.ValidatingType = typeof(int);
            this.MTXTB_Fiyat.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.MTXTB_Fiyat_MaskInputRejected);
            // 
            // LBL_ADET
            // 
            this.LBL_ADET.AutoSize = true;
            this.LBL_ADET.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LBL_ADET.Location = new System.Drawing.Point(110, 138);
            this.LBL_ADET.Name = "LBL_ADET";
            this.LBL_ADET.Size = new System.Drawing.Size(47, 20);
            this.LBL_ADET.TabIndex = 6;
            this.LBL_ADET.Text = "Adet:";
            this.LBL_ADET.Click += new System.EventHandler(this.LBL_ADET_Click);
            // 
            // LBL_FİYAT
            // 
            this.LBL_FİYAT.AutoSize = true;
            this.LBL_FİYAT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LBL_FİYAT.Location = new System.Drawing.Point(121, 106);
            this.LBL_FİYAT.Name = "LBL_FİYAT";
            this.LBL_FİYAT.Size = new System.Drawing.Size(43, 20);
            this.LBL_FİYAT.TabIndex = 7;
            this.LBL_FİYAT.Text = "Fiyat";
            this.LBL_FİYAT.Click += new System.EventHandler(this.LBL_FİYAT_Click);
            // 
            // LBL_FİRMA
            // 
            this.LBL_FİRMA.AutoSize = true;
            this.LBL_FİRMA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LBL_FİRMA.Location = new System.Drawing.Point(93, 74);
            this.LBL_FİRMA.Name = "LBL_FİRMA";
            this.LBL_FİRMA.Size = new System.Drawing.Size(80, 20);
            this.LBL_FİRMA.TabIndex = 8;
            this.LBL_FİRMA.Text = "Firma Adı:";
            this.LBL_FİRMA.Click += new System.EventHandler(this.LBL_FİRMA_Click);
            // 
            // LBL_İLAÇADI
            // 
            this.LBL_İLAÇADI.AutoSize = true;
            this.LBL_İLAÇADI.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LBL_İLAÇADI.Location = new System.Drawing.Point(104, 42);
            this.LBL_İLAÇADI.Name = "LBL_İLAÇADI";
            this.LBL_İLAÇADI.Size = new System.Drawing.Size(65, 20);
            this.LBL_İLAÇADI.TabIndex = 9;
            this.LBL_İLAÇADI.Text = "İlaç Adı:";
            this.LBL_İLAÇADI.Click += new System.EventHandler(this.LBL_İLAÇADI_Click);
            // 
            // MTXTB_Adet
            // 
            this.MTXTB_Adet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MTXTB_Adet.Location = new System.Drawing.Point(189, 138);
            this.MTXTB_Adet.Mask = "00000";
            this.MTXTB_Adet.Name = "MTXTB_Adet";
            this.MTXTB_Adet.Size = new System.Drawing.Size(137, 26);
            this.MTXTB_Adet.TabIndex = 12;
            this.MTXTB_Adet.ValidatingType = typeof(int);
            this.MTXTB_Adet.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.MTXTB_Adet_MaskInputRejected);
            // 
            // Frm_İlaç_Kaydı
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 282);
            this.Controls.Add(this.BTN_İlaçKaydet);
            this.Controls.Add(this.TXTB_FirmaAdı);
            this.Controls.Add(this.TXTB_İlaçAdı);
            this.Controls.Add(this.MTXTB_Adet);
            this.Controls.Add(this.MTXTB_Fiyat);
            this.Controls.Add(this.LBL_ADET);
            this.Controls.Add(this.LBL_FİYAT);
            this.Controls.Add(this.LBL_FİRMA);
            this.Controls.Add(this.LBL_İLAÇADI);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_İlaç_Kaydı";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "İLAÇ KAYIT";
            this.Load += new System.EventHandler(this.Frm_İlaç_Kaydı_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTN_İlaçKaydet;
        private System.Windows.Forms.TextBox TXTB_FirmaAdı;
        private System.Windows.Forms.TextBox TXTB_İlaçAdı;
        private System.Windows.Forms.MaskedTextBox MTXTB_Fiyat;
        private System.Windows.Forms.Label LBL_ADET;
        private System.Windows.Forms.Label LBL_FİYAT;
        private System.Windows.Forms.Label LBL_FİRMA;
        private System.Windows.Forms.Label LBL_İLAÇADI;
        private System.Windows.Forms.MaskedTextBox MTXTB_Adet;
    }
}