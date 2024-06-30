namespace Eczane_Otomasyonu
{
    partial class Frm_Hasta_Kaydı
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Hasta_Kaydı));
            this.LBL_TC = new System.Windows.Forms.Label();
            this.LBL_ADSOYAD = new System.Windows.Forms.Label();
            this.LBL_ADRES = new System.Windows.Forms.Label();
            this.LBL_TELEFON = new System.Windows.Forms.Label();
            this.LBL_GÜVENCE = new System.Windows.Forms.Label();
            this.MTXTB_TC = new System.Windows.Forms.MaskedTextBox();
            this.MTXTB_TEL = new System.Windows.Forms.MaskedTextBox();
            this.CMB_GUV = new System.Windows.Forms.ComboBox();
            this.TXTB_AS = new System.Windows.Forms.TextBox();
            this.TXTB_AD = new System.Windows.Forms.TextBox();
            this.BTN_KAYDET = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LBL_TC
            // 
            this.LBL_TC.AutoSize = true;
            this.LBL_TC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LBL_TC.Location = new System.Drawing.Point(22, 47);
            this.LBL_TC.Name = "LBL_TC";
            this.LBL_TC.Size = new System.Drawing.Size(106, 20);
            this.LBL_TC.TabIndex = 0;
            this.LBL_TC.Text = "HastaNo(T.C)";
            // 
            // LBL_ADSOYAD
            // 
            this.LBL_ADSOYAD.AutoSize = true;
            this.LBL_ADSOYAD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LBL_ADSOYAD.Location = new System.Drawing.Point(58, 82);
            this.LBL_ADSOYAD.Name = "LBL_ADSOYAD";
            this.LBL_ADSOYAD.Size = new System.Drawing.Size(79, 20);
            this.LBL_ADSOYAD.TabIndex = 0;
            this.LBL_ADSOYAD.Text = "Ad-Soyad";
            // 
            // LBL_ADRES
            // 
            this.LBL_ADRES.AutoSize = true;
            this.LBL_ADRES.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LBL_ADRES.Location = new System.Drawing.Point(86, 114);
            this.LBL_ADRES.Name = "LBL_ADRES";
            this.LBL_ADRES.Size = new System.Drawing.Size(51, 20);
            this.LBL_ADRES.TabIndex = 0;
            this.LBL_ADRES.Text = "Adres";
            // 
            // LBL_TELEFON
            // 
            this.LBL_TELEFON.AutoSize = true;
            this.LBL_TELEFON.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LBL_TELEFON.Location = new System.Drawing.Point(75, 146);
            this.LBL_TELEFON.Name = "LBL_TELEFON";
            this.LBL_TELEFON.Size = new System.Drawing.Size(62, 20);
            this.LBL_TELEFON.TabIndex = 0;
            this.LBL_TELEFON.Text = "Telefon";
            // 
            // LBL_GÜVENCE
            // 
            this.LBL_GÜVENCE.AutoSize = true;
            this.LBL_GÜVENCE.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LBL_GÜVENCE.Location = new System.Drawing.Point(64, 178);
            this.LBL_GÜVENCE.Name = "LBL_GÜVENCE";
            this.LBL_GÜVENCE.Size = new System.Drawing.Size(73, 20);
            this.LBL_GÜVENCE.TabIndex = 0;
            this.LBL_GÜVENCE.Text = "Güvence";
            // 
            // MTXTB_TC
            // 
            this.MTXTB_TC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MTXTB_TC.Location = new System.Drawing.Point(143, 42);
            this.MTXTB_TC.Mask = "00000000000";
            this.MTXTB_TC.Name = "MTXTB_TC";
            this.MTXTB_TC.Size = new System.Drawing.Size(137, 26);
            this.MTXTB_TC.TabIndex = 1;
            this.MTXTB_TC.ValidatingType = typeof(int);
            // 
            // MTXTB_TEL
            // 
            this.MTXTB_TEL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MTXTB_TEL.Location = new System.Drawing.Point(143, 146);
            this.MTXTB_TEL.Mask = "(999) 000-0000";
            this.MTXTB_TEL.Name = "MTXTB_TEL";
            this.MTXTB_TEL.Size = new System.Drawing.Size(137, 26);
            this.MTXTB_TEL.TabIndex = 2;
            // 
            // CMB_GUV
            // 
            this.CMB_GUV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CMB_GUV.FormattingEnabled = true;
            this.CMB_GUV.Location = new System.Drawing.Point(143, 180);
            this.CMB_GUV.Name = "CMB_GUV";
            this.CMB_GUV.Size = new System.Drawing.Size(137, 28);
            this.CMB_GUV.TabIndex = 3;
            this.CMB_GUV.SelectedIndexChanged += new System.EventHandler(this.CMB_GUV_SelectedIndexChanged);
            // 
            // TXTB_AS
            // 
            this.TXTB_AS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TXTB_AS.Location = new System.Drawing.Point(143, 82);
            this.TXTB_AS.Name = "TXTB_AS";
            this.TXTB_AS.Size = new System.Drawing.Size(137, 26);
            this.TXTB_AS.TabIndex = 4;
            // 
            // TXTB_AD
            // 
            this.TXTB_AD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TXTB_AD.Location = new System.Drawing.Point(143, 114);
            this.TXTB_AD.Name = "TXTB_AD";
            this.TXTB_AD.Size = new System.Drawing.Size(137, 26);
            this.TXTB_AD.TabIndex = 4;
            // 
            // BTN_KAYDET
            // 
            this.BTN_KAYDET.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BTN_KAYDET.Location = new System.Drawing.Point(143, 238);
            this.BTN_KAYDET.Name = "BTN_KAYDET";
            this.BTN_KAYDET.Size = new System.Drawing.Size(104, 35);
            this.BTN_KAYDET.TabIndex = 5;
            this.BTN_KAYDET.Text = "KAYDET";
            this.BTN_KAYDET.UseVisualStyleBackColor = true;
            this.BTN_KAYDET.Click += new System.EventHandler(this.BTN_KAYDET_Click);
            // 
            // Frm_Hasta_Kaydı
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 309);
            this.Controls.Add(this.BTN_KAYDET);
            this.Controls.Add(this.TXTB_AD);
            this.Controls.Add(this.TXTB_AS);
            this.Controls.Add(this.CMB_GUV);
            this.Controls.Add(this.MTXTB_TEL);
            this.Controls.Add(this.MTXTB_TC);
            this.Controls.Add(this.LBL_GÜVENCE);
            this.Controls.Add(this.LBL_TELEFON);
            this.Controls.Add(this.LBL_ADRES);
            this.Controls.Add(this.LBL_ADSOYAD);
            this.Controls.Add(this.LBL_TC);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_Hasta_Kaydı";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HASTA KAYIT";
            this.Load += new System.EventHandler(this.Frm_Hasta_Kaydı_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBL_TC;
        private System.Windows.Forms.Label LBL_ADSOYAD;
        private System.Windows.Forms.Label LBL_ADRES;
        private System.Windows.Forms.Label LBL_TELEFON;
        private System.Windows.Forms.Label LBL_GÜVENCE;
        private System.Windows.Forms.MaskedTextBox MTXTB_TC;
        private System.Windows.Forms.MaskedTextBox MTXTB_TEL;
        private System.Windows.Forms.ComboBox CMB_GUV;
        private System.Windows.Forms.TextBox TXTB_AS;
        private System.Windows.Forms.TextBox TXTB_AD;
        private System.Windows.Forms.Button BTN_KAYDET;
    }
}