namespace Eczane_Otomasyonu
{
    partial class Frm_Anasayfa
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Anasayfa));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hastalarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hastaKaydetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hastaListeleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hastaSilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hastaGüncelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ilaçlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ilaçKaydetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ilaçListeleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ilaçSilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ilaçGüncelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sİgortalarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sigortaEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.LBL_TC = new System.Windows.Forms.Label();
            this.MXTX_TC = new System.Windows.Forms.MaskedTextBox();
            this.MTXT_BARKODNO = new System.Windows.Forms.MaskedTextBox();
            this.LBL_BARKODNO = new System.Windows.Forms.Label();
            this.LBL_ADET = new System.Windows.Forms.Label();
            this.NUD_ADET = new System.Windows.Forms.NumericUpDown();
            this.BTN_SATIS = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_ADET)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hastalarToolStripMenuItem,
            this.ilaçlarToolStripMenuItem,
            this.sİgortalarToolStripMenuItem,
            this.çıkışToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hastalarToolStripMenuItem
            // 
            this.hastalarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hastaKaydetToolStripMenuItem,
            this.hastaListeleToolStripMenuItem,
            this.hastaSilToolStripMenuItem,
            this.hastaGüncelleToolStripMenuItem});
            this.hastalarToolStripMenuItem.Name = "hastalarToolStripMenuItem";
            this.hastalarToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.hastalarToolStripMenuItem.Text = "Hastalar";
            // 
            // hastaKaydetToolStripMenuItem
            // 
            this.hastaKaydetToolStripMenuItem.Name = "hastaKaydetToolStripMenuItem";
            this.hastaKaydetToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.hastaKaydetToolStripMenuItem.Text = "Hasta Ekle";
            this.hastaKaydetToolStripMenuItem.Click += new System.EventHandler(this.hastaKaydetToolStripMenuItem_Click);
            // 
            // hastaListeleToolStripMenuItem
            // 
            this.hastaListeleToolStripMenuItem.Name = "hastaListeleToolStripMenuItem";
            this.hastaListeleToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.hastaListeleToolStripMenuItem.Text = "Hasta Listele";
            this.hastaListeleToolStripMenuItem.Click += new System.EventHandler(this.hastaListeleToolStripMenuItem_Click);
            // 
            // hastaSilToolStripMenuItem
            // 
            this.hastaSilToolStripMenuItem.Name = "hastaSilToolStripMenuItem";
            this.hastaSilToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.hastaSilToolStripMenuItem.Text = "Hasta Sil";
            this.hastaSilToolStripMenuItem.Click += new System.EventHandler(this.hastaSilToolStripMenuItem_Click);
            // 
            // hastaGüncelleToolStripMenuItem
            // 
            this.hastaGüncelleToolStripMenuItem.Name = "hastaGüncelleToolStripMenuItem";
            this.hastaGüncelleToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.hastaGüncelleToolStripMenuItem.Text = "Hasta Güncelle";
            this.hastaGüncelleToolStripMenuItem.Click += new System.EventHandler(this.hastaGüncelleToolStripMenuItem_Click);
            // 
            // ilaçlarToolStripMenuItem
            // 
            this.ilaçlarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ilaçKaydetToolStripMenuItem,
            this.ilaçListeleToolStripMenuItem,
            this.ilaçSilToolStripMenuItem,
            this.ilaçGüncelleToolStripMenuItem});
            this.ilaçlarToolStripMenuItem.Name = "ilaçlarToolStripMenuItem";
            this.ilaçlarToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.ilaçlarToolStripMenuItem.Text = "İlaçlar";
            this.ilaçlarToolStripMenuItem.Click += new System.EventHandler(this.ilaçlarToolStripMenuItem_Click);
            // 
            // ilaçKaydetToolStripMenuItem
            // 
            this.ilaçKaydetToolStripMenuItem.Name = "ilaçKaydetToolStripMenuItem";
            this.ilaçKaydetToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.ilaçKaydetToolStripMenuItem.Text = "İlaç Kaydet";
            this.ilaçKaydetToolStripMenuItem.Click += new System.EventHandler(this.ilaçKaydetToolStripMenuItem_Click);
            // 
            // ilaçListeleToolStripMenuItem
            // 
            this.ilaçListeleToolStripMenuItem.Name = "ilaçListeleToolStripMenuItem";
            this.ilaçListeleToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.ilaçListeleToolStripMenuItem.Text = "İlaç Listele";
            this.ilaçListeleToolStripMenuItem.Click += new System.EventHandler(this.ilaçListeleToolStripMenuItem_Click);
            // 
            // ilaçSilToolStripMenuItem
            // 
            this.ilaçSilToolStripMenuItem.Name = "ilaçSilToolStripMenuItem";
            this.ilaçSilToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.ilaçSilToolStripMenuItem.Text = "İlaç Sil";
            this.ilaçSilToolStripMenuItem.Click += new System.EventHandler(this.ilaçSilToolStripMenuItem_Click);
            // 
            // ilaçGüncelleToolStripMenuItem
            // 
            this.ilaçGüncelleToolStripMenuItem.Name = "ilaçGüncelleToolStripMenuItem";
            this.ilaçGüncelleToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.ilaçGüncelleToolStripMenuItem.Text = "İlaç Güncelle";
            this.ilaçGüncelleToolStripMenuItem.Click += new System.EventHandler(this.ilaçGüncelleToolStripMenuItem_Click);
            // 
            // sİgortalarToolStripMenuItem
            // 
            this.sİgortalarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sigortaEkleToolStripMenuItem});
            this.sİgortalarToolStripMenuItem.Name = "sİgortalarToolStripMenuItem";
            this.sİgortalarToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.sİgortalarToolStripMenuItem.Text = "Sigortalar";
            // 
            // sigortaEkleToolStripMenuItem
            // 
            this.sigortaEkleToolStripMenuItem.Name = "sigortaEkleToolStripMenuItem";
            this.sigortaEkleToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.sigortaEkleToolStripMenuItem.Text = "Sigorta Ekle";
            this.sigortaEkleToolStripMenuItem.Click += new System.EventHandler(this.sigortaEkleToolStripMenuItem_Click);
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.çıkışToolStripMenuItem.Text = "Çıkış";
            this.çıkışToolStripMenuItem.Click += new System.EventHandler(this.çıkışToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 268);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(799, 183);
            this.dataGridView1.TabIndex = 1;
            // 
            // LBL_TC
            // 
            this.LBL_TC.AutoSize = true;
            this.LBL_TC.Location = new System.Drawing.Point(12, 121);
            this.LBL_TC.Name = "LBL_TC";
            this.LBL_TC.Size = new System.Drawing.Size(91, 13);
            this.LBL_TC.TabIndex = 2;
            this.LBL_TC.Text = "Hasta No(TC.NO)";
            // 
            // MXTX_TC
            // 
            this.MXTX_TC.Location = new System.Drawing.Point(109, 114);
            this.MXTX_TC.Mask = "00000000000";
            this.MXTX_TC.Name = "MXTX_TC";
            this.MXTX_TC.Size = new System.Drawing.Size(103, 20);
            this.MXTX_TC.TabIndex = 3;
            this.MXTX_TC.ValidatingType = typeof(int);
            // 
            // MTXT_BARKODNO
            // 
            this.MTXT_BARKODNO.Location = new System.Drawing.Point(328, 114);
            this.MTXT_BARKODNO.Mask = "00000";
            this.MTXT_BARKODNO.Name = "MTXT_BARKODNO";
            this.MTXT_BARKODNO.Size = new System.Drawing.Size(84, 20);
            this.MTXT_BARKODNO.TabIndex = 4;
            this.MTXT_BARKODNO.ValidatingType = typeof(int);
            // 
            // LBL_BARKODNO
            // 
            this.LBL_BARKODNO.AutoSize = true;
            this.LBL_BARKODNO.Location = new System.Drawing.Point(243, 121);
            this.LBL_BARKODNO.Name = "LBL_BARKODNO";
            this.LBL_BARKODNO.Size = new System.Drawing.Size(58, 13);
            this.LBL_BARKODNO.TabIndex = 5;
            this.LBL_BARKODNO.Text = "Barkod No";
            // 
            // LBL_ADET
            // 
            this.LBL_ADET.AutoSize = true;
            this.LBL_ADET.Location = new System.Drawing.Point(475, 121);
            this.LBL_ADET.Name = "LBL_ADET";
            this.LBL_ADET.Size = new System.Drawing.Size(29, 13);
            this.LBL_ADET.TabIndex = 6;
            this.LBL_ADET.Text = "Adet";
            // 
            // NUD_ADET
            // 
            this.NUD_ADET.Location = new System.Drawing.Point(527, 114);
            this.NUD_ADET.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NUD_ADET.Name = "NUD_ADET";
            this.NUD_ADET.Size = new System.Drawing.Size(54, 20);
            this.NUD_ADET.TabIndex = 7;
            this.NUD_ADET.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NUD_ADET.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // BTN_SATIS
            // 
            this.BTN_SATIS.Location = new System.Drawing.Point(648, 116);
            this.BTN_SATIS.Name = "BTN_SATIS";
            this.BTN_SATIS.Size = new System.Drawing.Size(75, 23);
            this.BTN_SATIS.TabIndex = 8;
            this.BTN_SATIS.Text = "SATIŞ YAP";
            this.BTN_SATIS.UseVisualStyleBackColor = true;
            this.BTN_SATIS.Click += new System.EventHandler(this.BTN_SATIS_Click);
            // 
            // Frm_Anasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BTN_SATIS);
            this.Controls.Add(this.NUD_ADET);
            this.Controls.Add(this.LBL_ADET);
            this.Controls.Add(this.LBL_BARKODNO);
            this.Controls.Add(this.MTXT_BARKODNO);
            this.Controls.Add(this.MXTX_TC);
            this.Controls.Add(this.LBL_TC);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Frm_Anasayfa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ECZANE OTOMASYONU";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_ADET)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hastalarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hastaKaydetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hastaListeleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hastaSilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hastaGüncelleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ilaçlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ilaçKaydetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ilaçListeleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ilaçSilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ilaçGüncelleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sİgortalarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sigortaEkleToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label LBL_TC;
        private System.Windows.Forms.MaskedTextBox MXTX_TC;
        private System.Windows.Forms.MaskedTextBox MTXT_BARKODNO;
        private System.Windows.Forms.Label LBL_BARKODNO;
        private System.Windows.Forms.Label LBL_ADET;
        private System.Windows.Forms.NumericUpDown NUD_ADET;
        private System.Windows.Forms.Button BTN_SATIS;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
    }
}

