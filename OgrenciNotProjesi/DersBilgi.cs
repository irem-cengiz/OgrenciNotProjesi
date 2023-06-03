using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OgrenciNotProjesi
{

    public partial class DersBilgi : Form
    {
        public static List<Ogrenci> ogrenciler = new List<Ogrenci>();
        public static List<Ders> donem1Dersler = new List<Ders>();
        public static List<Ders> donem2Dersler = new List<Ders>();
        public static List<Donem> donemler = new List<Donem>();

        public DersBilgi()
        {
            InitializeComponent();
            dgvBilgiListesi.Columns.Add("Ogrenci", "Öğrenci");
            dgvBilgiListesi.Columns.Add("Ders", "Ders");
            dgvBilgiListesi.Columns.Add("HarfNotu", "Harf Notu");
            dgvBilgiListesi.Columns.Add("DonemBilgisi", "Dönem Bilgisi");
        }

        public void EkleComboboxItem(List<Ogrenci> item)
        {
            cmbOgrenci.Items.Clear();
            cmbOgrenci.Items.AddRange(item.ToArray());
        }


        public void EkleComboboxItem2(List<Ders> item2)
        {
            cbmDersler.Items.Clear();
            cbmDersler.Items.AddRange(item2.ToArray());
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {

            double donem1Ortalama = Hesapla(donem1Dersler, "Dönem 1");
            lbl1DonemOrt.Text = donem1Ortalama.ToString();
            lbl1GenelOrt.Text = donem1Ortalama.ToString();

            double donem2Ortalama = Hesapla(donem2Dersler, "Dönem 2");
            lbl2DonemOrt.Text = donem2Ortalama.ToString();

            double genelort = (donem1Ortalama + donem2Ortalama) / 2;

            lbl2GenelOrt.Text = genelort.ToString();

            if (donem1Ortalama < 2.00)
            {
                BasariDurumu1.Text = "Başarısızdır.";
            }
            else BasariDurumu1.Text = "Başarıldır.";
            if (donem2Ortalama > 2.00)
            {
                BasariDurumu2.Text = "Başarılıdır.";
            }
            else BasariDurumu2.Text = "Başarısızdır.";
        }

        public double Hesapla(List<Ders> dersler, string donem)
        {
            double toplamKredi = 0;
            double toplamNot = 0;

            foreach (Ders ders in dersler)
            {

                //txtHarfNotu.Text = ders.HarfNotu;
                double katsayi;
                if (ders.HarfNotu == "AA")
                    katsayi = 4.0;
                else if (ders.HarfNotu == "BA")
                    katsayi = 3.5;
                else if (ders.HarfNotu == "BB")
                    katsayi = 3.0;
                else if (ders.HarfNotu == "BB")
                    katsayi = 2.5;
                else if (ders.HarfNotu == "CC")
                    katsayi = 2.0;
                else if (ders.HarfNotu == "DC")
                    katsayi = 1.5;
                else if (ders.HarfNotu == "DD")
                    katsayi = 1;
                else
                    katsayi = 0.0;

                toplamKredi += ders.DersKredisi;
                toplamNot += ders.DersKredisi * katsayi;
            }
            if (toplamKredi != 0)
            {

                return toplamNot / toplamKredi;

            }
            else return 0;
        }

        private void btnComboboxEkle_Click_1(object sender, EventArgs e)
        {
            Ders ders = (Ders)cbmDersler.SelectedItem;
            ders.HarfNotu = txtHarfNotu.Text;

            string secilenOgrenci = cmbOgrenci.SelectedItem?.ToString();
            string secilenDers = cbmDersler.SelectedItem?.ToString();
            string harfNotu = txtHarfNotu.Text;
            string donemBilgisi = cmbDonemsec.SelectedItem?.ToString();

            dgvBilgiListesi.Rows.Add(secilenOgrenci, secilenDers, harfNotu, donemBilgisi);

            if (ders.DersDonemi == "Dönem1")
                donem1Dersler.Add((Ders)cbmDersler.SelectedItem);
            else if (ders.DersDonemi == "Dönem2")
                donem2Dersler.Add((Ders)cbmDersler.SelectedItem);

        }

        private void cmbOgrenci_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cbmDersler.SelectedItem != null)
            {
                string secilenOgrenci = cmbOgrenci.SelectedItem.ToString();
                string secilenDers = cbmDersler.SelectedItem.ToString();
                string harfNotu = txtHarfNotu.Text;
                string donemBilgisi = cmbDonemsec.SelectedItem.ToString();

                dgvBilgiListesi.Rows.Clear();
                dgvBilgiListesi.Rows.Add(secilenOgrenci, secilenDers, harfNotu, donemBilgisi);
            }
        }

        private void cbmDersler_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cmbOgrenci.SelectedItem != null && cmbDonemsec.SelectedItem != null)
            {
                string secilenOgrenci = cmbOgrenci.SelectedItem.ToString();
                string secilenDers = cbmDersler.SelectedItem.ToString();
                string harfNotu = txtHarfNotu.Text;
                string donemBilgisi = cmbDonemsec.SelectedItem.ToString();

                dgvBilgiListesi.Rows.Clear();
                dgvBilgiListesi.Rows.Add(secilenOgrenci, secilenDers, harfNotu, donemBilgisi);
            }
        }

        private void cmbDonemsec_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvBilgiListesi.Rows.Clear();
            if (cmbDonemsec.SelectedIndex == 0)
            {
                foreach (Ders ders in donem1Dersler)
                {
                    dgvBilgiListesi.Rows.Add(cmbOgrenci.SelectedItem.ToString(), ders.DersAdi, ders.HarfNotu, "Dönem 1");
                }
                foreach (Ders ders in donem2Dersler)
                {
                    dgvBilgiListesi.Rows.Add(cmbOgrenci.SelectedItem.ToString(), ders.DersAdi, ders.HarfNotu, "Dönem 2");
                }
            }
            else if (cmbDonemsec.SelectedIndex == 1)
            {
                foreach (Ders ders in donem1Dersler)
                {
                    dgvBilgiListesi.Rows.Add(cmbOgrenci.SelectedItem.ToString(), ders.DersAdi, ders.HarfNotu, "Dönem 1");
                }
            }
            else if (cmbDonemsec.SelectedIndex == 2)
            {
                foreach (Ders ders in donem2Dersler)
                {
                    dgvBilgiListesi.Rows.Add(cmbOgrenci.SelectedItem.ToString(), ders.DersAdi, ders.HarfNotu, "Dönem 2");
                }
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (dgvBilgiListesi.SelectedRows.Count > 0)
            {
                // Seçili satırı alın
                DataGridViewRow selectedRow = dgvBilgiListesi.SelectedRows[0];
                // Satırı DataGridView'dan kaldırın
                dgvBilgiListesi.Rows.Remove(selectedRow);
            }
            else 
                MessageBox.Show("Lütfen silmek için seçim yapınız.");
        }
    }
}
