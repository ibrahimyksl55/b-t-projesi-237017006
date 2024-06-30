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
    public partial class Frm_Hasta_Listesi : Form
    {
        public Frm_Hasta_Listesi()
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

        private void Frm_Hasta_Listesi_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
