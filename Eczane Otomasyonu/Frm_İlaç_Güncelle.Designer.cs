namespace Eczane_Otomasyonu
{
    partial class Frm_İlaç_Güncelle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_İlaç_Güncelle));
            this.CB_DURUM = new System.Windows.Forms.CheckBox();
            this.BTN_GÜNCELLE = new System.Windows.Forms.Button();
            this.TXTB_İLAÇADI = new System.Windows.Forms.TextBox();
            this.TXTB_ADET = new System.Windows.Forms.TextBox();
            this.LBL_FİYAT = new System.Windows.Forms.Label();
            this.LBL_FİRMAADI = new System.Windows.Forms.Label();
            this.LBL_İLAÇADI = new System.Windows.Forms.Label();
            this.LBL_ADET = new System.Windows.Forms.Label();
            this.TXTB_FİRMAADI = new System.Windows.Forms.TextBox();
            this.TXTB_FİYAT = new System.Windows.Forms.TextBox();
            this.LBL_BARKODARA = new System.Windows.Forms.Label();
            this.BTN_ARA = new System.Windows.Forms.Button();
            this.MTXTB_BARKODARA = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // CB_DURUM
            // 
            this.CB_DURUM.AutoSize = true;
            this.CB_DURUM.Checked = true;
            this.CB_DURUM.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CB_DURUM.Location = new System.Drawing.Point(124, 226);
            this.CB_DURUM.Name = "CB_DURUM";
            this.CB_DURUM.Size = new System.Drawing.Size(55, 17);
            this.CB_DURUM.TabIndex = 28;
            this.CB_DURUM.Text = "durum";
            this.CB_DURUM.UseVisualStyleBackColor = true;
            // 
            // BTN_GÜNCELLE
            // 
            this.BTN_GÜNCELLE.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BTN_GÜNCELLE.Location = new System.Drawing.Point(222, 215);
            this.BTN_GÜNCELLE.Name = "BTN_GÜNCELLE";
            this.BTN_GÜNCELLE.Size = new System.Drawing.Size(107, 35);
            this.BTN_GÜNCELLE.TabIndex = 27;
            this.BTN_GÜNCELLE.Text = "GÜNCELLE";
            this.BTN_GÜNCELLE.UseVisualStyleBackColor = true;
            this.BTN_GÜNCELLE.Click += new System.EventHandler(this.BTN_GÜNCELLE_Click);
            // 
            // TXTB_İLAÇADI
            // 
            this.TXTB_İLAÇADI.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TXTB_İLAÇADI.Location = new System.Drawing.Point(192, 70);
            this.TXTB_İLAÇADI.Name = "TXTB_İLAÇADI";
            this.TXTB_İLAÇADI.Size = new System.Drawing.Size(137, 26);
            this.TXTB_İLAÇADI.TabIndex = 25;
            // 
            // TXTB_ADET
            // 
            this.TXTB_ADET.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TXTB_ADET.Location = new System.Drawing.Point(192, 166);
            this.TXTB_ADET.Name = "TXTB_ADET";
            this.TXTB_ADET.Size = new System.Drawing.Size(137, 26);
            this.TXTB_ADET.TabIndex = 26;
            // 
            // LBL_FİYAT
            // 
            this.LBL_FİYAT.AutoSize = true;
            this.LBL_FİYAT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LBL_FİYAT.Location = new System.Drawing.Point(136, 132);
            this.LBL_FİYAT.Name = "LBL_FİYAT";
            this.LBL_FİYAT.Size = new System.Drawing.Size(43, 20);
            this.LBL_FİYAT.TabIndex = 19;
            this.LBL_FİYAT.Text = "Fiyat";
            // 
            // LBL_FİRMAADI
            // 
            this.LBL_FİRMAADI.AutoSize = true;
            this.LBL_FİRMAADI.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LBL_FİRMAADI.Location = new System.Drawing.Point(103, 102);
            this.LBL_FİRMAADI.Name = "LBL_FİRMAADI";
            this.LBL_FİRMAADI.Size = new System.Drawing.Size(76, 20);
            this.LBL_FİRMAADI.TabIndex = 20;
            this.LBL_FİRMAADI.Text = "Firma Adı";
            // 
            // LBL_İLAÇADI
            // 
            this.LBL_İLAÇADI.AutoSize = true;
            this.LBL_İLAÇADI.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LBL_İLAÇADI.Location = new System.Drawing.Point(118, 70);
            this.LBL_İLAÇADI.Name = "LBL_İLAÇADI";
            this.LBL_İLAÇADI.Size = new System.Drawing.Size(61, 20);
            this.LBL_İLAÇADI.TabIndex = 21;
            this.LBL_İLAÇADI.Text = "İlaç Adı";
            // 
            // LBL_ADET
            // 
            this.LBL_ADET.AutoSize = true;
            this.LBL_ADET.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LBL_ADET.Location = new System.Drawing.Point(136, 166);
            this.LBL_ADET.Name = "LBL_ADET";
            this.LBL_ADET.Size = new System.Drawing.Size(43, 20);
            this.LBL_ADET.TabIndex = 22;
            this.LBL_ADET.Text = "Adet";
            // 
            // TXTB_FİRMAADI
            // 
            this.TXTB_FİRMAADI.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TXTB_FİRMAADI.Location = new System.Drawing.Point(192, 102);
            this.TXTB_FİRMAADI.Name = "TXTB_FİRMAADI";
            this.TXTB_FİRMAADI.Size = new System.Drawing.Size(137, 26);
            this.TXTB_FİRMAADI.TabIndex = 25;
            // 
            // TXTB_FİYAT
            // 
            this.TXTB_FİYAT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TXTB_FİYAT.Location = new System.Drawing.Point(192, 134);
            this.TXTB_FİYAT.Name = "TXTB_FİYAT";
            this.TXTB_FİYAT.Size = new System.Drawing.Size(137, 26);
            this.TXTB_FİYAT.TabIndex = 25;
            // 
            // LBL_BARKODARA
            // 
            this.LBL_BARKODARA.AutoSize = true;
            this.LBL_BARKODARA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LBL_BARKODARA.Location = new System.Drawing.Point(19, 34);
            this.LBL_BARKODARA.Name = "LBL_BARKODARA";
            this.LBL_BARKODARA.Size = new System.Drawing.Size(160, 20);
            this.LBL_BARKODARA.TabIndex = 29;
            this.LBL_BARKODARA.Text = "Barkod Numarası Ara";
            // 
            // BTN_ARA
            // 
            this.BTN_ARA.Location = new System.Drawing.Point(269, 27);
            this.BTN_ARA.Name = "BTN_ARA";
            this.BTN_ARA.Size = new System.Drawing.Size(60, 37);
            this.BTN_ARA.TabIndex = 31;
            this.BTN_ARA.Text = "ARA";
            this.BTN_ARA.UseVisualStyleBackColor = true;
            this.BTN_ARA.Click += new System.EventHandler(this.BTN_ARA_Click);
            // 
            // MTXTB_BARKODARA
            // 
            this.MTXTB_BARKODARA.Location = new System.Drawing.Point(192, 36);
            this.MTXTB_BARKODARA.Mask = "00000";
            this.MTXTB_BARKODARA.Name = "MTXTB_BARKODARA";
            this.MTXTB_BARKODARA.Size = new System.Drawing.Size(71, 20);
            this.MTXTB_BARKODARA.TabIndex = 32;
            this.MTXTB_BARKODARA.ValidatingType = typeof(int);
            // 
            // Frm_İlaç_Güncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 278);
            this.Controls.Add(this.MTXTB_BARKODARA);
            this.Controls.Add(this.BTN_ARA);
            this.Controls.Add(this.LBL_BARKODARA);
            this.Controls.Add(this.CB_DURUM);
            this.Controls.Add(this.BTN_GÜNCELLE);
            this.Controls.Add(this.TXTB_FİYAT);
            this.Controls.Add(this.TXTB_FİRMAADI);
            this.Controls.Add(this.TXTB_İLAÇADI);
            this.Controls.Add(this.TXTB_ADET);
            this.Controls.Add(this.LBL_FİYAT);
            this.Controls.Add(this.LBL_FİRMAADI);
            this.Controls.Add(this.LBL_İLAÇADI);
            this.Controls.Add(this.LBL_ADET);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_İlaç_Güncelle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "İlaç Güncelle";
            this.Load += new System.EventHandler(this.Frm_İlaç_Güncelle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox CB_DURUM;
        private System.Windows.Forms.Button BTN_GÜNCELLE;
        private System.Windows.Forms.TextBox TXTB_İLAÇADI;
        private System.Windows.Forms.TextBox TXTB_ADET;
        private System.Windows.Forms.Label LBL_FİYAT;
        private System.Windows.Forms.Label LBL_FİRMAADI;
        private System.Windows.Forms.Label LBL_İLAÇADI;
        private System.Windows.Forms.Label LBL_ADET;
        private System.Windows.Forms.TextBox TXTB_FİRMAADI;
        private System.Windows.Forms.TextBox TXTB_FİYAT;
        private System.Windows.Forms.Label LBL_BARKODARA;
        private System.Windows.Forms.Button BTN_ARA;
        private System.Windows.Forms.MaskedTextBox MTXTB_BARKODARA;
    }
}