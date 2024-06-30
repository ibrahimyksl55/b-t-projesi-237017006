using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Eczane_Otomasyonu
{
    public partial class Frm_İlaç_Kaydı : Form
    {
        public Frm_İlaç_Kaydı()
        {
            InitializeComponent();
        }

        OleDbConnection con = new OleDbConnection("provider = microsoft.ace.oledb.12.0; data source = EczaneDB.accdb");

        private void Frm_İlaç_Kaydı_Load(object sender, EventArgs e)
        {

        }

        private void BTN_İlaçKaydet_Click(object sender, EventArgs e)
        {
            if (TXTB_İlaçAdı.Text == "" ||  TXTB_FirmaAdı.Text == "" || MTXTB_Adet.Text == "")
            {
                MessageBox.Show("LÜTFEN TÜM ALANLARI DOLDURUN", "EKSİK GİRİŞ HATASI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {
                
                
                    OleDbCommand komut = new OleDbCommand("insert into Ilaclar (IlacAdi, FirmaAdi, Fiyat, Adet, Durum) values(@p1, @p2, @p3, @p4, @p5)", con);
                    con.Open();
                    komut.Parameters.AddWithValue("@p2", TXTB_İlaçAdı.Text);
                    komut.Parameters.AddWithValue("@p3", TXTB_FirmaAdı.Text);
                    komut.Parameters.AddWithValue("@p4", MTXTB_Fiyat.Text);
                    komut.Parameters.AddWithValue("@p5", MTXTB_Adet);
                    komut.Parameters.AddWithValue("@p6", true);
                    int sonuc = komut.ExecuteNonQuery();
                    if (sonuc > 0)
                        MessageBox.Show("KAYIT TAMAMLANDI");
                    else
                        MessageBox.Show("KAYIT HATASI", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    con.Close();
                
            }

            TXTB_İlaçAdı.Text = "";
            TXTB_FirmaAdı.Text = "";
            MTXTB_Fiyat.Text = "";
            MTXTB_Adet.Text = "";
        }

        private void TXTB_FirmaAdı_TextChanged(object sender, EventArgs e)
        {

        }

        private void TXTB_İlaçAdı_TextChanged(object sender, EventArgs e)
        {

        }

        private void MTXTB_Adet_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void MTXTB_Fiyat_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void LBL_ADET_Click(object sender, EventArgs e)
        {

        }

        private void LBL_FİYAT_Click(object sender, EventArgs e)
        {

        }

        private void LBL_FİRMA_Click(object sender, EventArgs e)
        {

        }

        private void LBL_İLAÇADI_Click(object sender, EventArgs e)
        {

        }
    }
}
