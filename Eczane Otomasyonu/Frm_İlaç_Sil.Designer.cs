namespace Eczane_Otomasyonu
{
    partial class Frm_İlaç_Sil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_İlaç_Sil));
            this.BTN_SİL = new System.Windows.Forms.Button();
            this.BTN_ARA = new System.Windows.Forms.Button();
            this.MTXTB_BARKOD = new System.Windows.Forms.MaskedTextBox();
            this.LBL_BARKODNO = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // BTN_SİL
            // 
            this.BTN_SİL.Location = new System.Drawing.Point(480, 46);
            this.BTN_SİL.Name = "BTN_SİL";
            this.BTN_SİL.Size = new System.Drawing.Size(75, 23);
            this.BTN_SİL.TabIndex = 8;
            this.BTN_SİL.Text = "SİL";
            this.BTN_SİL.UseVisualStyleBackColor = true;
            this.BTN_SİL.Click += new System.EventHandler(this.BTN_SİL_Click);
            // 
            // BTN_ARA
            // 
            this.BTN_ARA.Location = new System.Drawing.Point(312, 46);
            this.BTN_ARA.Name = "BTN_ARA";
            this.BTN_ARA.Size = new System.Drawing.Size(75, 23);
            this.BTN_ARA.TabIndex = 9;
            this.BTN_ARA.Text = "ARA";
            this.BTN_ARA.UseVisualStyleBackColor = true;
            this.BTN_ARA.Click += new System.EventHandler(this.BTN_ARA_Click);
            // 
            // MTXTB_BARKOD
            // 
            this.MTXTB_BARKOD.Location = new System.Drawing.Point(118, 49);
            this.MTXTB_BARKOD.Mask = "00000";
            this.MTXTB_BARKOD.Name = "MTXTB_BARKOD";
            this.MTXTB_BARKOD.Size = new System.Drawing.Size(79, 20);
            this.MTXTB_BARKOD.TabIndex = 7;
            this.MTXTB_BARKOD.ValidatingType = typeof(int);
            // 
            // LBL_BARKODNO
            // 
            this.LBL_BARKODNO.AutoSize = true;
            this.LBL_BARKODNO.Location = new System.Drawing.Point(45, 52);
            this.LBL_BARKODNO.Name = "LBL_BARKODNO";
            this.LBL_BARKODNO.Size = new System.Drawing.Size(55, 13);
            this.LBL_BARKODNO.TabIndex = 6;
            this.LBL_BARKODNO.Text = "BarkodNo";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 135);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(798, 303);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.TabStop = false;
            // 
            // Frm_İlaç_Sil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BTN_SİL);
            this.Controls.Add(this.BTN_ARA);
            this.Controls.Add(this.MTXTB_BARKOD);
            this.Controls.Add(this.LBL_BARKODNO);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_İlaç_Sil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "İlaç Sil";
            this.Load += new System.EventHandler(this.Frm_İlaç_Sil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTN_SİL;
        private System.Windows.Forms.Button BTN_ARA;
        private System.Windows.Forms.MaskedTextBox MTXTB_BARKOD;
        private System.Windows.Forms.Label LBL_BARKODNO;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}