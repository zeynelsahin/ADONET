using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _19._04._22_ADONET.Data;
using _19._04._22_ADONET.Model;

namespace _19._04._22_ADONET
{
    public partial class FormKategoriler : Form
    {
        public FormKategoriler()
        {
            InitializeComponent();
        }

        private Kategoriler _kategoriler = new Kategoriler();
        private void Kategoriler_Load(object sender, EventArgs e)
        {
            KategoriListesi();
        }

        private void KategoriListesi()
        {
            dgwKategoriler.DataSource = _kategoriler.GetList();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Kategori kategori = new Kategori() {KategoriAdi = tbxKategoriAdi.Text };
            _kategoriler.Add(kategori);
            KategoriListesi();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            
            _kategoriler.Delete(Convert.ToInt32(tbxKategoriId.Text));
            KategoriListesi();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Kategori kategori = new Kategori() { KategoriId = Convert.ToInt32(tbxKategoriId.Text), KategoriAdi = tbxKategoriAdi.Text };
            _kategoriler.Update(kategori);
            KategoriListesi();
        }

        private void dgwKategoriler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxKategoriId.Text = dgwKategoriler.CurrentRow.Cells[0].Value.ToString();
            tbxKategoriAdi.Text = dgwKategoriler.CurrentRow.Cells[1].Value.ToString();
        }
    }
}
