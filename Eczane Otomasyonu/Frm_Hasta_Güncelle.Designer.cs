namespace Eczane_Otomasyonu
{
    partial class Frm_Hasta_Güncelle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Hasta_Güncelle));
            this.BTN_ARA = new System.Windows.Forms.Button();
            this.MTXTB_TC = new System.Windows.Forms.MaskedTextBox();
            this.LBL_TC = new System.Windows.Forms.Label();
            this.BTN_GÜNCELLE = new System.Windows.Forms.Button();
            this.TXTB_AD = new System.Windows.Forms.TextBox();
            this.TXTB_AS = new System.Windows.Forms.TextBox();
            this.CMB_GUV = new System.Windows.Forms.ComboBox();
            this.MTXTB_TEL = new System.Windows.Forms.MaskedTextBox();
            this.LBL_GÜVENCE = new System.Windows.Forms.Label();
            this.LBL_TELEFON = new System.Windows.Forms.Label();
            this.LBL_ADRES = new System.Windows.Forms.Label();
            this.LBL_ADSOYAD = new System.Windows.Forms.Label();
            this.CB_DURUM = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // BTN_ARA
            // 
            this.BTN_ARA.Location = new System.Drawing.Point(101, 110);
            this.BTN_ARA.Name = "BTN_ARA";
            this.BTN_ARA.Size = new System.Drawing.Size(75, 23);
            this.BTN_ARA.TabIndex = 8;
            this.BTN_ARA.Text = "ARA";
            this.BTN_ARA.UseVisualStyleBackColor = true;
            this.BTN_ARA.Click += new System.EventHandler(this.BTN_ARA_Click);
            // 
            // MTXTB_TC
            // 
            this.MTXTB_TC.Location = new System.Drawing.Point(97, 84);
            this.MTXTB_TC.Mask = "00000000000";
            this.MTXTB_TC.Name = "MTXTB_TC";
            this.MTXTB_TC.Size = new System.Drawing.Size(79, 20);
            this.MTXTB_TC.TabIndex = 6;
            this.MTXTB_TC.ValidatingType = typeof(int);
            // 
            // LBL_TC
            // 
            this.LBL_TC.AutoSize = true;
            this.LBL_TC.Location = new System.Drawing.Point(24, 87);
            this.LBL_TC.Name = "LBL_TC";
            this.LBL_TC.Size = new System.Drawing.Size(67, 13);
            this.LBL_TC.TabIndex = 5;
            this.LBL_TC.Text = "Numara(T.C)";
            // 
            // BTN_GÜNCELLE
            // 
            this.BTN_GÜNCELLE.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BTN_GÜNCELLE.Location = new System.Drawing.Point(250, 204);
            this.BTN_GÜNCELLE.Name = "BTN_GÜNCELLE";
            this.BTN_GÜNCELLE.Size = new System.Drawing.Size(107, 35);
            this.BTN_GÜNCELLE.TabIndex = 17;
            this.BTN_GÜNCELLE.Text = "GÜNCELLE";
            this.BTN_GÜNCELLE.UseVisualStyleBackColor = true;
            this.BTN_GÜNCELLE.Click += new System.EventHandler(this.BTN_GÜNCELLE_Click);
            // 
            // TXTB_AD
            // 
            this.TXTB_AD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TXTB_AD.Location = new System.Drawing.Point(331, 91);
            this.TXTB_AD.Name = "TXTB_AD";
            this.TXTB_AD.Size = new System.Drawing.Size(137, 26);
            this.TXTB_AD.TabIndex = 15;
            // 
            // TXTB_AS
            // 
            this.TXTB_AS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TXTB_AS.Location = new System.Drawing.Point(331, 59);
            this.TXTB_AS.Name = "TXTB_AS";
            this.TXTB_AS.Size = new System.Drawing.Size(137, 26);
            this.TXTB_AS.TabIndex = 16;
            // 
            // CMB_GUV
            // 
            this.CMB_GUV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CMB_GUV.FormattingEnabled = true;
            this.CMB_GUV.Location = new System.Drawing.Point(331, 157);
            this.CMB_GUV.Name = "CMB_GUV";
            this.CMB_GUV.Size = new System.Drawing.Size(137, 28);
            this.CMB_GUV.TabIndex = 14;
            // 
            // MTXTB_TEL
            // 
            this.MTXTB_TEL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MTXTB_TEL.Location = new System.Drawing.Point(331, 123);
            this.MTXTB_TEL.Mask = "(999) 000-0000";
            this.MTXTB_TEL.Name = "MTXTB_TEL";
            this.MTXTB_TEL.Size = new System.Drawing.Size(137, 26);
            this.MTXTB_TEL.TabIndex = 13;
            // 
            // LBL_GÜVENCE
            // 
            this.LBL_GÜVENCE.AutoSize = true;
            this.LBL_GÜVENCE.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LBL_GÜVENCE.Location = new System.Drawing.Point(252, 155);
            this.LBL_GÜVENCE.Name = "LBL_GÜVENCE";
            this.LBL_GÜVENCE.Size = new System.Drawing.Size(73, 20);
            this.LBL_GÜVENCE.TabIndex = 9;
            this.LBL_GÜVENCE.Text = "Güvence";
            // 
            // LBL_TELEFON
            // 
            this.LBL_TELEFON.AutoSize = true;
            this.LBL_TELEFON.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LBL_TELEFON.Location = new System.Drawing.Point(263, 123);
            this.LBL_TELEFON.Name = "LBL_TELEFON";
            this.LBL_TELEFON.Size = new System.Drawing.Size(62, 20);
            this.LBL_TELEFON.TabIndex = 10;
            this.LBL_TELEFON.Text = "Telefon";
            // 
            // LBL_ADRES
            // 
            this.LBL_ADRES.AutoSize = true;
            this.LBL_ADRES.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LBL_ADRES.Location = new System.Drawing.Point(274, 91);
            this.LBL_ADRES.Name = "LBL_ADRES";
            this.LBL_ADRES.Size = new System.Drawing.Size(51, 20);
            this.LBL_ADRES.TabIndex = 11;
            this.LBL_ADRES.Text = "Adres";
            // 
            // LBL_ADSOYAD
            // 
            this.LBL_ADSOYAD.AutoSize = true;
            this.LBL_ADSOYAD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LBL_ADSOYAD.Location = new System.Drawing.Point(246, 59);
            this.LBL_ADSOYAD.Name = "LBL_ADSOYAD";
            this.LBL_ADSOYAD.Size = new System.Drawing.Size(79, 20);
            this.LBL_ADSOYAD.TabIndex = 12;
            this.LBL_ADSOYAD.Text = "Ad-Soyad";
            // 
            // CB_DURUM
            // 
            this.CB_DURUM.AutoSize = true;
            this.CB_DURUM.Checked = true;
            this.CB_DURUM.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CB_DURUM.Location = new System.Drawing.Point(388, 215);
            this.CB_DURUM.Name = "CB_DURUM";
            this.CB_DURUM.Size = new System.Drawing.Size(55, 17);
            this.CB_DURUM.TabIndex = 18;
            this.CB_DURUM.Text = "durum";
            this.CB_DURUM.UseVisualStyleBackColor = true;
            // 
            // Frm_Hasta_Güncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 309);
            this.Controls.Add(this.CB_DURUM);
            this.Controls.Add(this.BTN_GÜNCELLE);
            this.Controls.Add(this.TXTB_AD);
            this.Controls.Add(this.TXTB_AS);
            this.Controls.Add(this.CMB_GUV);
            this.Controls.Add(this.MTXTB_TEL);
            this.Controls.Add(this.LBL_GÜVENCE);
            this.Controls.Add(this.LBL_TELEFON);
            this.Controls.Add(this.LBL_ADRES);
            this.Controls.Add(this.LBL_ADSOYAD);
            this.Controls.Add(this.BTN_ARA);
            this.Controls.Add(this.MTXTB_TC);
            this.Controls.Add(this.LBL_TC);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_Hasta_Güncelle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HASTA GÜNCELLE";
            this.Load += new System.EventHandler(this.Frm_Hasta_Güncelle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BTN_ARA;
        private System.Windows.Forms.MaskedTextBox MTXTB_TC;
        private System.Windows.Forms.Label LBL_TC;
        private System.Windows.Forms.Button BTN_GÜNCELLE;
        private System.Windows.Forms.TextBox TXTB_AD;
        private System.Windows.Forms.TextBox TXTB_AS;
        private System.Windows.Forms.ComboBox CMB_GUV;
        private System.Windows.Forms.MaskedTextBox MTXTB_TEL;
        private System.Windows.Forms.Label LBL_GÜVENCE;
        private System.Windows.Forms.Label LBL_TELEFON;
        private System.Windows.Forms.Label LBL_ADRES;
        private System.Windows.Forms.Label LBL_ADSOYAD;
        private System.Windows.Forms.CheckBox CB_DURUM;
    }
}