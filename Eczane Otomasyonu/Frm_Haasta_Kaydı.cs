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
    public partial class Frm_Hasta_Kaydı : Form
    {
        public Frm_Hasta_Kaydı()
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

        private void Frm_Hasta_Kaydı_Load(object sender, EventArgs e)
        {
            guvenceGetir();
        }
        public int tcVarmi(string tc)
        {
            int sonuc = 1;
            OleDbCommand komut1 = new OleDbCommand("select *  from Hastalar where TcNo = @p1", con);
            con.Open();
            komut1.Parameters.AddWithValue("@p1", tc);
            OleDbDataReader dr = komut1.ExecuteReader();
            if (dr.Read())
                sonuc = 0;
            con.Close();

            return sonuc;
        }

        private void BTN_KAYDET_Click(object sender, EventArgs e)
        {
            if (TXTB_AS.Text=="" || MTXTB_TC.Text=="" || TXTB_AD.Text=="" || MTXTB_TEL.Text=="")
            {
                MessageBox.Show("LÜTFEN TÜM ALANLARI DOLDURUN", "EKSİK GİRİŞ HATASI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {
                int tcsonuc = tcVarmi(MTXTB_TC.Text);
                if(tcsonuc==0)
                    MessageBox.Show(MTXTB_TC + "NUMARALI KAYIT ZATEN VAR","KAYIT HATASI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    OleDbCommand komut = new OleDbCommand("insert into Hastalar values(@p1, @p2, @p3, @p4, @p5, @p6)", con);
                    con.Open();
                    komut.Parameters.AddWithValue("@p1", MTXTB_TC.Text);
                    komut.Parameters.AddWithValue("@p2", TXTB_AS.Text);
                    komut.Parameters.AddWithValue("@p3", TXTB_AD.Text);
                    komut.Parameters.AddWithValue("@p4", MTXTB_TEL.Text);
                    komut.Parameters.AddWithValue("@p5", CMB_GUV.SelectedValue);
                    komut.Parameters.AddWithValue("@p6", true);
                    int sonuc = komut.ExecuteNonQuery();
                    if (sonuc > 0)
                        MessageBox.Show("KAYIT TAMAMLANDI");
                    else
                        MessageBox.Show("KAYIT HATASI", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    con.Close();
                } 
            }

            TXTB_AS.Text ="";
            MTXTB_TC.Text ="";
            TXTB_AD.Text ="";
            MTXTB_TEL.Text ="";
        }

        private void CMB_GUV_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
