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
    public partial class Frm_İlaç_Güncelle : Form
    {
        public Frm_İlaç_Güncelle()
        {
            InitializeComponent();
        }

        OleDbConnection con = new OleDbConnection("provider = microsoft.ace.oledb.12.0; data source = EczaneDB.accdb");

        private void BTN_ARA_Click(object sender, EventArgs e)
        {
            if (MTXTB_BARKODARA.Text=="")
            {
                MessageBox.Show("LÜTFEN ARADIĞINIZ İLACIN BARKOD NUMARASINI GİRİNİZ","HATA",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }

            else
            {
                OleDbCommand komut = new OleDbCommand("select * from Ilaclar where BarkodNo= @p1", con);
                komut.Parameters.AddWithValue("@p1", int.Parse(MTXTB_BARKODARA.Text));
                con.Open();
                OleDbDataReader dr = komut.ExecuteReader();
                if (dr.Read())
                {
                    TXTB_İLAÇADI.Text = dr[1].ToString();
                    TXTB_FİRMAADI.Text = dr[2].ToString();
                    TXTB_FİYAT.Text = dr[3].ToString();
                    TXTB_ADET.Text = dr[4].ToString();
                    CB_DURUM.Checked = bool.Parse(dr[5].ToString()) ? true : false;

                }

                else
                {
                    MessageBox.Show("aradığınız kayıt bulunamadı", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                con.Close();
            }
        
            
        }

        private void BTN_GÜNCELLE_Click(object sender, EventArgs e)
        {
            if (TXTB_ADET.Text == "" || TXTB_İLAÇADI.Text == "" || TXTB_FİRMAADI.Text == "" || TXTB_FİYAT.Text == "")
            {
                MessageBox.Show("LÜTFEN TÜM ALANLARI DOLDURUN", "EKSİK GİRİŞ HATASI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {

                OleDbCommand komut = new OleDbCommand("update Ilaclar set IlacAdi=@p1, FirmaAdi=@p2, Fiyat=@p3, Durum=@p4 where BarkodNo=@p5", con);
                con.Open();
                komut.Parameters.AddWithValue("@p1", TXTB_İLAÇADI.Text);
                komut.Parameters.AddWithValue("@p2", TXTB_FİRMAADI.Text);
                komut.Parameters.AddWithValue("@p3", TXTB_FİYAT.Text);
                komut.Parameters.AddWithValue("@p4", CB_DURUM.Checked ? true : false);
                komut.Parameters.AddWithValue("@p5", MTXTB_BARKODARA.Text);
                int sonuc = komut.ExecuteNonQuery();
                if (sonuc > 0)
                    MessageBox.Show(MTXTB_BARKODARA + "NUMARALI KAYIT GÜNCELLENDİ");
                else
                    MessageBox.Show("GÜNCELLEME HATASI", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                con.Close();

                TXTB_ADET.Text = "";
                MTXTB_BARKODARA.Text = "";
                TXTB_İLAÇADI.Text = "";
                TXTB_FİRMAADI.Text = "";
                TXTB_FİYAT.Text = "";
 
            }
        }

        private void Frm_İlaç_Güncelle_Load(object sender, EventArgs e)
        {

        }
    }
}
