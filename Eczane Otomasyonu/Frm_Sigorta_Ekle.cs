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
    public partial class Frm_Sigorta_Ekle : Form
    {
        public Frm_Sigorta_Ekle()
        {
            InitializeComponent();
        }

        OleDbConnection con = new OleDbConnection("provider = microsoft.ace.oledb.12.0; data source = EczaneDB.accdb");

        private void BTN_Kaydet_Click(object sender, EventArgs e)
        {
            if (TXTB_SigortaAdı.Text == "" )
            {
                MessageBox.Show("LÜTFEN SİGORTA ADINI GİRİNİZ", "EKSİK GİRİŞ HATASI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {
                OleDbCommand komut = new OleDbCommand("insert into Guvenceler (GuvenceAdi, Durum) values(@p1, @p2)", con);
                con.Open();
                komut.Parameters.AddWithValue("@p1", TXTB_SigortaAdı.Text);
                komut.Parameters.AddWithValue("@p2", true);
                int sonuc = komut.ExecuteNonQuery();
                if (sonuc > 0)
                    MessageBox.Show("KAYIT TAMAMLANDI");
                else
                    MessageBox.Show("KAYIT HATASI", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                con.Close();
            }
        }

        private void Frm_Sigorta_Ekle_Load(object sender, EventArgs e)
        {

        }
    }
}
