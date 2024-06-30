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
    public partial class Frm_Hasta_Güncelle : Form
    {
        public Frm_Hasta_Güncelle()
        {
            InitializeComponent();
        }

        OleDbConnection con = new OleDbConnection("provider = microsoft.ace.oledb.12.0; data source = EczaneDB.accdb");

        public void guvenceGetir()
        {
            OleDbDataAdapter da = new OleDbDataAdapter("select * from Guvenceler", con);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            CMB_GUV.ValueMember = "GuvenceNo";
            CMB_GUV.DisplayMember = "GuvenceAdi";
            CMB_GUV.DataSource = tablo;
        }

        private void BTN_ARA_Click(object sender, EventArgs e)
        {
            
            OleDbCommand komut = new OleDbCommand("select * from Hastalar where TcNo='" + MTXTB_TC.Text + "'", con);
            con.Open();
            OleDbDataReader dr = komut.ExecuteReader();
            if(dr.Read())
            {
                TXTB_AS.Text = dr[1].ToString();
                TXTB_AD.Text = dr[2].ToString();
                MTXTB_TEL.Text = dr[3].ToString();
                CMB_GUV.SelectedValue = dr[4].ToString();
                CB_DURUM.Checked = bool.Parse(dr[5].ToString()) ? true : false;

            }

            else
            {
                MessageBox.Show("aradığınız kayıt bulunamadı","HATA",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            con.Close();

        }

        private void Frm_Hasta_Güncelle_Load(object sender, EventArgs e)
        {
            guvenceGetir();
        }

        private void BTN_GÜNCELLE_Click(object sender, EventArgs e)
        {
            if (TXTB_AS.Text == "" || MTXTB_TC.Text == "" || TXTB_AD.Text == "" || MTXTB_TEL.Text == "")
            {
                MessageBox.Show("LÜTFEN TÜM ALANLARI DOLDURUN", "EKSİK GİRİŞ HATASI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {

                OleDbCommand komut = new OleDbCommand("update Hastalar set AdSoyad=@p1, Adres=@p2, Telefon=@p3, Güvence=@p4, Durum=@p5 where TcNo=@p6", con);
                con.Open();
                komut.Parameters.AddWithValue("@p1", TXTB_AS.Text);
                komut.Parameters.AddWithValue("@p2", TXTB_AD.Text);
                komut.Parameters.AddWithValue("@p3", MTXTB_TEL.Text);
                komut.Parameters.AddWithValue("@p4", CMB_GUV.SelectedValue);
                komut.Parameters.AddWithValue("@p5", CB_DURUM.Checked ? true : false);
                komut.Parameters.AddWithValue("@p6", MTXTB_TC.Text);
                int sonuc = komut.ExecuteNonQuery();
                if (sonuc > 0)
                    MessageBox.Show(MTXTB_TC+"NUMARALI KAYIT GÜNCELLENDİ");
                else
                    MessageBox.Show("GÜNCELLEME HATASI", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                con.Close();

                MTXTB_TC.Text = "";
                MTXTB_TEL.Text ="";
                TXTB_AD.Text = "";
                TXTB_AS.Text = "";

            }
        }
    }
}
