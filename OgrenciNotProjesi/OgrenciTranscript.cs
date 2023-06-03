using System.Windows.Forms;

namespace OgrenciNotProjesi
{
    public partial class OgrenciTranscript : Form
    {
        DersBilgi dersbilgiForm;
        private List<Ders> dersler;// Dersleri tutacak liste
        private List<Ogrenci> ogrenciler = new List<Ogrenci>();

        public OgrenciTranscript()
        {
            InitializeComponent();
            dersler = new List<Ders>();
            dersbilgiForm = new DersBilgi();
        }
        private void btnOgrenciEkle_Click_1(object sender, EventArgs e)

        {
            Ogrenci ogrenci = new Ogrenci();
            ogrenci.Adi = txtOgrenciAd.Text.Trim();
            ogrenci.Soyadi = txtOgrenciSoyad.Text.Trim();
            ogrenci.OgrenciNumarasi = Convert.ToInt32(txtOgrenciNo.Text);
            ogrenciler.Add(ogrenci);
            dersbilgiForm.EkleComboboxItem(ogrenciler);
        }

        private void btnBilgileriAc_Click_1(object sender, EventArgs e)
        {
            dersbilgiForm.Show();
        }

        private void btn1DersEkle_Click(object sender, EventArgs e)
        {

            Ders ders = new Ders();

            ders.DersKodu = txtDersKodu.Text.Trim();
            ders.DersAdi = txtDersAdi.Text.Trim();
            ders.DersKredisi = Convert.ToInt32(txtKredisi.Text);
            ders.DersDonemi = cmbDonemsec1.Text.Trim();
           
            dersler.Add(ders);
           
            dersbilgiForm = dersbilgiForm ?? new DersBilgi();
            dersbilgiForm.EkleComboboxItem2(dersler);     
        }       
    }
}
