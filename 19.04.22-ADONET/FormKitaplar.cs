using _19._04._22_ADONET.Data;
using _19._04._22_ADONET.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace _19._04._22_ADONET
{
    public partial class FormKitaplar : Form
    {
        public FormKitaplar()
        {
            InitializeComponent();
        }

        private Kitaplar _kitaplar = new Kitaplar();

        private void btnEkle_Click(object sender, EventArgs e)
        {
            var kitap = new Kitap()
            {
                KitapAdi = tbxKitapAdi.Text,
                KategoriId = Convert.ToInt32(cbxKategoriId.SelectedValue), Ozet = tbxOzet.Text,
                SayfaSayisi = Convert.ToInt32(tbxSayfaSayisi.Text)
            };
            _kitaplar.Add(kitap);
            MessageBox.Show("Eklendi");

            KitapListesi();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            _kitaplar.Delete(Convert.ToInt32(tbxKitapId.Text));
            MessageBox.Show("Silindi");

            KitapListesi();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            var kitap = new Kitap()
            {
                KitapId = Convert.ToInt32(tbxKitapId.Text), KategoriId = Convert.ToInt32(cbxKategoriId.SelectedValue),
                KitapAdi = tbxKitapAdi.Text, Ozet = tbxOzet.Text, SayfaSayisi = Convert.ToInt32(tbxSayfaSayisi.Text)
            };
            _kitaplar.Update(kitap);
            MessageBox.Show("Güncellendi");

            KitapListesi();
        }

        private void dgwKitaplar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxKitapId.Text = dgwKitaplar.CurrentRow.Cells[0].Value.ToString();
            tbxKitapAdi.Text = dgwKitaplar.CurrentRow.Cells[1].Value.ToString();

            cbxKategoriId.SelectedValue = dgwKitaplar.CurrentRow.Cells[2].Value;

            tbxSayfaSayisi.Text = dgwKitaplar.CurrentRow.Cells[3].Value.ToString();
            tbxOzet.Text = dgwKitaplar.CurrentRow.Cells[4].Value.ToString();
        }

        private void FormKitaplar_Load(object sender, EventArgs e)
        {
            KategoriListesi();

            KitapListesi();
        }

        private void KategoriListesi()
        {
            var kategoriler = new Kategoriler();
            cbxKategoriId.DataSource = kategoriler.GetList();
            cbxKategoriId.DisplayMember = "KategoriAdi";
            cbxKategoriId.ValueMember = "KategoriId";
        }

        private void KitapListesi()
        {
            dgwKitaplar.DataSource = _kitaplar.GetList();
            lblAdet.Text="Adet : "+_kitaplar.GetCount();
        }

        private void btnKategoriler_Click(object sender, EventArgs e)
        {
            var kategoriler = new FormKategoriler();
            kategoriler.Show();
        }

        private void dgwKitaplar_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            var count = dgwKitaplar.RowCount;
            var toplam = count * 26 + dgwKitaplar.ColumnHeadersHeight;
            if (Height - 184 >= toplam) dgwKitaplar.Height = toplam;
        }

        private void tbxFiltre_TextChanged(object sender, EventArgs e)
        {
            if (tbxFiltre.Text != "" )
            {
                var list = new List<Kitap>();
                var kitap = _kitaplar.Get(Convert.ToInt32(tbxFiltre.Text));
                if (kitap != null)
                {   
                    list.Add(kitap);
                    dgwKitaplar.DataSource = list;
                }
            }
            else
            {
                KitapListesi();
            }
        }
    }
}