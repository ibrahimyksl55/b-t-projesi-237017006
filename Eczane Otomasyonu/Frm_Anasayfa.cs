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
    public partial class Frm_Anasayfa : Form
    {
        public Frm_Anasayfa()
        {
            InitializeComponent();
        }

       
        OleDbConnection con = new OleDbConnection("provider = microsoft.ace.oledb.12.0; data source = EczaneDB.accdb");

        private void listele()
        {
            
            OleDbCommand komut = new OleDbCommand("select * from Satislar", con);
            OleDbDataAdapter da = new OleDbDataAdapter(komut);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void BTN_SATIS_Click(object sender, EventArgs e)
        {
            if (MXTX_TC.Text == "" || MTXT_BARKODNO.Text == "")
                MessageBox.Show("LÜTFEN TÜM ALANLARI EKSİKSİZ GİRİNİZ.", "EKSİK GİRİŞ HATASI", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            else
            {
                bool sonuc1 = false;
                bool sonuc2 = false ;
                int ToplamFiyat = 0, fyt = 0;


                OleDbCommand komut1 = new OleDbCommand("select *  from Hastalar where TcNo = @p1", con);
                con.Open();
                komut1.Parameters.AddWithValue("@p1", MXTX_TC.Text);
                OleDbDataReader dr = komut1.ExecuteReader();
                if (dr.Read())
                    sonuc1 = true;
                con.Close();


                OleDbCommand komut2 = new OleDbCommand("select *  from Ilaclar where BarkodNo = @p1", con);
                con.Open();
                komut2.Parameters.AddWithValue("@p1", MTXT_BARKODNO.Text);
                OleDbDataReader dr2 = komut2.ExecuteReader();
                if (dr2.Read())
                {
                    fyt =int.Parse(dr2["fiyat"].ToString());
                    sonuc2 = true;
                }
                con.Close();


                if(!sonuc1)
                    MessageBox.Show("lütfen hasta kaydını yapınız","HATALI KAYIT", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else if (!sonuc2)
                    MessageBox.Show("lütfen önce ilaç kaydını yazpınız", "HATALI KAYIT", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    OleDbCommand komut = new OleDbCommand("insert into Satislar (HastaNo, IlacNo, Adet, ToplamFiyat, Tarih, Durum) values(@p1, @p2, @p3, @p4, @5, @p6)", con);
                    con.Open();
                    ToplamFiyat = fyt *int.Parse( NUD_ADET.Value.ToString());
                    komut.Parameters.AddWithValue("@p1", MXTX_TC.Text);
                    komut.Parameters.AddWithValue("@p2", MTXT_BARKODNO.Text);
                    komut.Parameters.AddWithValue("@p3", NUD_ADET.Value);
                    komut.Parameters.AddWithValue("@p4", ToplamFiyat);
                    komut.Parameters.AddWithValue("@p5", DateTime.Today);
                    komut.Parameters.AddWithValue("@p6", true);


                    int sonuc = komut.ExecuteNonQuery();
                    if (sonuc > 0)
                    {
                        MessageBox.Show("Toplam Fiyat =" + ToplamFiyat);
                        MessageBox.Show("Satış Yapıldı", "SATIŞ");
                    }
                    else
                    
                        MessageBox.Show("Satış İşleminde Hata Oluştu", "SATIŞ HATASI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        con.Close();
                }
                listele();
            }

            
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void hastaKaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Hasta_Kaydı fr = new Frm_Hasta_Kaydı();
            fr.Show();
        }

        private void hastaListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Hasta_Listesi fr = new Frm_Hasta_Listesi();
            fr.Show();
        }

        private void hastaSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Hasta_Sil fr = new Frm_Hasta_Sil();
            fr.Show();
        }

        private void hastaGüncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Hasta_Güncelle fr = new Frm_Hasta_Güncelle();
            fr.Show();
        }

        private void ilaçlarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ilaçKaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_İlaç_Kaydı fr = new Frm_İlaç_Kaydı();
            fr.Show();
        }

        private void ilaçListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_İlaç_Listele fr = new Frm_İlaç_Listele();
            fr.Show();
        }

        private void ilaçSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_İlaç_Sil fr = new Frm_İlaç_Sil();
            fr.Show();
        }

        private void ilaçGüncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_İlaç_Güncelle fr = new Frm_İlaç_Güncelle();
            fr.Show();
        }

        private void sigortaEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Sigorta_Ekle fr = new Frm_Sigorta_Ekle();
            fr.Show();
        }
    }
}
