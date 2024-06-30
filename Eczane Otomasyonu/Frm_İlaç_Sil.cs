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
    public partial class Frm_İlaç_Sil : Form
    {
        public Frm_İlaç_Sil()
        {
            InitializeComponent();
        }

        OleDbConnection con = new OleDbConnection("provider = microsoft.ace.oledb.12.0; data source = EczaneDB.accdb");

        private void Frm_İlaç_Sil_Load(object sender, EventArgs e)
        {
            listele();
        }

        public void listele()
        {
            OleDbDataAdapter da = new OleDbDataAdapter("select * from Ilaclar where durum = true", con);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;

        }


        private void BTN_ARA_Click(object sender, EventArgs e)
        {
            if (MTXTB_BARKOD.Text == "")
            {
                MessageBox.Show("LÜTFEN BARKODNO KISMINI DOLDURUN", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {
                OleDbCommand komut = new OleDbCommand("select * from Ilaclar where BarkodNo=@p1",con);
                komut.Parameters.AddWithValue("@p1",int.Parse(MTXTB_BARKOD.Text));
                con.Open();
                OleDbDataAdapter da = new OleDbDataAdapter(komut);
                DataTable tablo = new DataTable();
                da.Fill(tablo);
                dataGridView1.DataSource = tablo;
                con.Close();
            }
        }

        private void BTN_SİL_Click(object sender, EventArgs e)
        {
            OleDbCommand komut = new OleDbCommand("update Ilaclar set durum=false where BarkodNo=@p1", con);
            con.Open();
            komut.Parameters.AddWithValue("@p1", MTXTB_BARKOD.Text);
            int sonuc = komut.ExecuteNonQuery();
            if (sonuc > 0)
                MessageBox.Show(MTXTB_BARKOD + "numaralı kayıt silindi");
            else
                MessageBox.Show("silme işlemi başarısız", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            con.Close();

            listele();
        }
    }
}
