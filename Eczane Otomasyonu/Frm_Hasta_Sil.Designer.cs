namespace Eczane_Otomasyonu
{
    partial class Frm_Hasta_Sil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Hasta_Sil));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.LBL_TC = new System.Windows.Forms.Label();
            this.MTXTB_TC = new System.Windows.Forms.MaskedTextBox();
            this.BTN_ARA = new System.Windows.Forms.Button();
            this.BTN_SİL = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 148);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(798, 303);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.TabStop = false;
            // 
            // LBL_TC
            // 
            this.LBL_TC.AutoSize = true;
            this.LBL_TC.Location = new System.Drawing.Point(27, 31);
            this.LBL_TC.Name = "LBL_TC";
            this.LBL_TC.Size = new System.Drawing.Size(67, 13);
            this.LBL_TC.TabIndex = 2;
            this.LBL_TC.Text = "Numara(T.C)";
            // 
            // MTXTB_TC
            // 
            this.MTXTB_TC.Location = new System.Drawing.Point(100, 28);
            this.MTXTB_TC.Mask = "00000000000";
            this.MTXTB_TC.Name = "MTXTB_TC";
            this.MTXTB_TC.Size = new System.Drawing.Size(79, 20);
            this.MTXTB_TC.TabIndex = 3;
            this.MTXTB_TC.ValidatingType = typeof(int);
            // 
            // BTN_ARA
            // 
            this.BTN_ARA.Location = new System.Drawing.Point(268, 31);
            this.BTN_ARA.Name = "BTN_ARA";
            this.BTN_ARA.Size = new System.Drawing.Size(75, 23);
            this.BTN_ARA.TabIndex = 4;
            this.BTN_ARA.Text = "ARA";
            this.BTN_ARA.UseVisualStyleBackColor = true;
            this.BTN_ARA.Click += new System.EventHandler(this.BTN_ARA_Click);
            // 
            // BTN_SİL
            // 
            this.BTN_SİL.Location = new System.Drawing.Point(387, 31);
            this.BTN_SİL.Name = "BTN_SİL";
            this.BTN_SİL.Size = new System.Drawing.Size(75, 23);
            this.BTN_SİL.TabIndex = 4;
            this.BTN_SİL.Text = "SİL";
            this.BTN_SİL.UseVisualStyleBackColor = true;
            this.BTN_SİL.Click += new System.EventHandler(this.BTN_SİL_Click);
            // 
            // Frm_Hasta_Sil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BTN_SİL);
            this.Controls.Add(this.BTN_ARA);
            this.Controls.Add(this.MTXTB_TC);
            this.Controls.Add(this.LBL_TC);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_Hasta_Sil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HASTA SİL";
            this.Load += new System.EventHandler(this.MTXTB_TC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label LBL_TC;
        private System.Windows.Forms.MaskedTextBox MTXTB_TC;
        private System.Windows.Forms.Button BTN_ARA;
        private System.Windows.Forms.Button BTN_SİL;
    }
}