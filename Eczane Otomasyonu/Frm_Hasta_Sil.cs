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
    public partial class Frm_Hasta_Sil : Form
    {
        public Frm_Hasta_Sil()
        {
            InitializeComponent();
        }

        OleDbConnection con = new OleDbConnection("provider = microsoft.ace.oledb.12.0; data source = EczaneDB.accdb");

        public void listele()
        {
            OleDbDataAdapter da = new OleDbDataAdapter("select * from Hastalar where durum = true", con);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;

        }

        private void MTXTB_TC_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void BTN_ARA_Click(object sender, EventArgs e)
        {
            if (BTN_ARA.Text=="")
            {
                MessageBox.Show("LÜTFEN ARAMA KISMINI DOLDURUN","HATA",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }

            else
            {
                OleDbDataAdapter da = new OleDbDataAdapter("select * from Hastalar where durum = true and TcNo='" + MTXTB_TC.Text + "'", con);
                DataTable tablo = new DataTable();
                da.Fill(tablo);
                dataGridView1.DataSource = tablo;
            }
            
        }

        private void BTN_SİL_Click(object sender, EventArgs e)
        {
            OleDbCommand komut = new OleDbCommand("update Hastalar set durum=false where TcNo=@p1", con);
            con.Open();
            komut.Parameters.AddWithValue("@p1", MTXTB_TC.Text);
            int sonuc = komut.ExecuteNonQuery();
            if (sonuc>0)
                MessageBox.Show(MTXTB_TC+"numaralı kayıt silindi");
            else
                MessageBox.Show("silme işlemi başarısız","HATA",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            con.Close();

            listele();
        }
    }
}
