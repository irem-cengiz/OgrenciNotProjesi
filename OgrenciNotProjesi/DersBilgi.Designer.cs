namespace OgrenciNotProjesi
{
    partial class DersBilgi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            dgvBilgiListesi = new DataGridView();
            dersBindingSource = new BindingSource(components);
            label2 = new Label();
            label9 = new Label();
            label10 = new Label();
            lbl1GenelOrt = new Label();
            lbl1DonemOrt = new Label();
            lbl2DonemOrt = new Label();
            lbl2GenelOrt = new Label();
            label15 = new Label();
            label16 = new Label();
            groupBox1 = new GroupBox();
            BasariDurumu1 = new Label();
            label4 = new Label();
            groupBox2 = new GroupBox();
            BasariDurumu2 = new Label();
            label5 = new Label();
            btnSil = new Button();
            groupBox3 = new GroupBox();
            cmbDonemsec = new ComboBox();
            label7 = new Label();
            btnHesapla = new Button();
            groupBox4 = new GroupBox();
            txtHarfNotu = new TextBox();
            label3 = new Label();
            cbmDersler = new ComboBox();
            D = new Label();
            cmbOgrenci = new ComboBox();
            label1 = new Label();
            btnComboboxEkle = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvBilgiListesi).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dersBindingSource).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // dgvBilgiListesi
            // 
            dgvBilgiListesi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBilgiListesi.Location = new Point(41, 415);
            dgvBilgiListesi.Name = "dgvBilgiListesi";
            dgvBilgiListesi.RowTemplate.Height = 25;
            dgvBilgiListesi.Size = new Size(743, 147);
            dgvBilgiListesi.TabIndex = 1;
            // 
            // dersBindingSource
            // 
            dersBindingSource.DataSource = typeof(Ders);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(41, 397);
            label2.Name = "label2";
            label2.Size = new Size(46, 15);
            label2.TabIndex = 4;
            label2.Text = "Dersler:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(14, 125);
            label9.Name = "label9";
            label9.Size = new Size(109, 15);
            label9.TabIndex = 11;
            label9.Text = "Dönem Ortalaması:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(14, 101);
            label10.Name = "label10";
            label10.Size = new Size(92, 15);
            label10.TabIndex = 12;
            label10.Text = "Genel Ortalama:";
            // 
            // lbl1GenelOrt
            // 
            lbl1GenelOrt.AutoSize = true;
            lbl1GenelOrt.Location = new Point(145, 101);
            lbl1GenelOrt.Name = "lbl1GenelOrt";
            lbl1GenelOrt.Size = new Size(0, 15);
            lbl1GenelOrt.TabIndex = 13;
            // 
            // lbl1DonemOrt
            // 
            lbl1DonemOrt.AutoSize = true;
            lbl1DonemOrt.Location = new Point(147, 124);
            lbl1DonemOrt.Name = "lbl1DonemOrt";
            lbl1DonemOrt.Size = new Size(44, 15);
            lbl1DonemOrt.TabIndex = 14;
            lbl1DonemOrt.Text = "label12";
            // 
            // lbl2DonemOrt
            // 
            lbl2DonemOrt.AutoSize = true;
            lbl2DonemOrt.Location = new Point(147, 104);
            lbl2DonemOrt.Name = "lbl2DonemOrt";
            lbl2DonemOrt.Size = new Size(44, 15);
            lbl2DonemOrt.TabIndex = 18;
            lbl2DonemOrt.Text = "label13";
            // 
            // lbl2GenelOrt
            // 
            lbl2GenelOrt.AutoSize = true;
            lbl2GenelOrt.Location = new Point(145, 81);
            lbl2GenelOrt.Name = "lbl2GenelOrt";
            lbl2GenelOrt.Size = new Size(44, 15);
            lbl2GenelOrt.TabIndex = 17;
            lbl2GenelOrt.Text = "label14";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(14, 79);
            label15.Name = "label15";
            label15.Size = new Size(92, 15);
            label15.TabIndex = 16;
            label15.Text = "Genel Ortalama:";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(14, 105);
            label16.Name = "label16";
            label16.Size = new Size(109, 15);
            label16.TabIndex = 15;
            label16.Text = "Dönem Ortalaması:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(BasariDurumu1);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(lbl1GenelOrt);
            groupBox1.Controls.Add(lbl1DonemOrt);
            groupBox1.Location = new Point(41, 608);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(327, 171);
            groupBox1.TabIndex = 21;
            groupBox1.TabStop = false;
            groupBox1.Text = "1.Dönem";
            // 
            // BasariDurumu1
            // 
            BasariDurumu1.AutoSize = true;
            BasariDurumu1.Location = new Point(152, 74);
            BasariDurumu1.Name = "BasariDurumu1";
            BasariDurumu1.Size = new Size(38, 15);
            BasariDurumu1.TabIndex = 16;
            BasariDurumu1.Text = "label6";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(14, 73);
            label4.Name = "label4";
            label4.Size = new Size(88, 15);
            label4.TabIndex = 15;
            label4.Text = "Başarı Durumu:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(BasariDurumu2);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(lbl2GenelOrt);
            groupBox2.Controls.Add(label16);
            groupBox2.Controls.Add(label15);
            groupBox2.Controls.Add(lbl2DonemOrt);
            groupBox2.Location = new Point(452, 608);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(332, 171);
            groupBox2.TabIndex = 22;
            groupBox2.TabStop = false;
            groupBox2.Text = "2.Dönem";
            // 
            // BasariDurumu2
            // 
            BasariDurumu2.AutoSize = true;
            BasariDurumu2.Location = new Point(143, 54);
            BasariDurumu2.Name = "BasariDurumu2";
            BasariDurumu2.Size = new Size(38, 15);
            BasariDurumu2.TabIndex = 20;
            BasariDurumu2.Text = "label6";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(14, 54);
            label5.Name = "label5";
            label5.Size = new Size(88, 15);
            label5.TabIndex = 19;
            label5.Text = "Başarı Durumu:";
            // 
            // btnSil
            // 
            btnSil.Location = new Point(654, 287);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(101, 46);
            btnSil.TabIndex = 30;
            btnSil.Text = "SİL";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(cmbDonemsec);
            groupBox3.Location = new Point(41, 258);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(291, 95);
            groupBox3.TabIndex = 31;
            groupBox3.TabStop = false;
            groupBox3.Text = "Dönem Bilgisi";
            // 
            // cmbDonemsec
            // 
            cmbDonemsec.FormattingEnabled = true;
            cmbDonemsec.Items.AddRange(new object[] { "Genel", "Dönem 1", "Dönem 2" });
            cmbDonemsec.Location = new Point(135, 29);
            cmbDonemsec.Name = "cmbDonemsec";
            cmbDonemsec.Size = new Size(121, 23);
            cmbDonemsec.TabIndex = 16;
            cmbDonemsec.SelectedIndexChanged += cmbDonemsec_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(41, 226);
            label7.Name = "label7";
            label7.Size = new Size(87, 15);
            label7.TabIndex = 15;
            label7.Text = "Dönem seçiniz:";
            // 
            // btnHesapla
            // 
            btnHesapla.Location = new Point(709, 568);
            btnHesapla.Name = "btnHesapla";
            btnHesapla.Size = new Size(75, 23);
            btnHesapla.TabIndex = 32;
            btnHesapla.Text = "HESAPLA";
            btnHesapla.UseVisualStyleBackColor = true;
            btnHesapla.Click += btnHesapla_Click;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(txtHarfNotu);
            groupBox4.Controls.Add(label3);
            groupBox4.Controls.Add(cbmDersler);
            groupBox4.Controls.Add(D);
            groupBox4.Controls.Add(cmbOgrenci);
            groupBox4.Controls.Add(label1);
            groupBox4.Location = new Point(34, 25);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(750, 184);
            groupBox4.TabIndex = 33;
            groupBox4.TabStop = false;
            groupBox4.Text = "Hesaplama Verileri";
            // 
            // txtHarfNotu
            // 
            txtHarfNotu.Location = new Point(462, 67);
            txtHarfNotu.Name = "txtHarfNotu";
            txtHarfNotu.Size = new Size(121, 23);
            txtHarfNotu.TabIndex = 36;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(378, 70);
            label3.Name = "label3";
            label3.Size = new Size(63, 15);
            label3.TabIndex = 35;
            label3.Text = "Harf Notu:";
            // 
            // cbmDersler
            // 
            cbmDersler.FormattingEnabled = true;
            cbmDersler.Location = new Point(184, 119);
            cbmDersler.Name = "cbmDersler";
            cbmDersler.Size = new Size(121, 23);
            cbmDersler.TabIndex = 33;
            cbmDersler.SelectedIndexChanged += cbmDersler_SelectedIndexChanged_1;
            // 
            // D
            // 
            D.AutoSize = true;
            D.Location = new Point(51, 122);
            D.Name = "D";
            D.Size = new Size(71, 15);
            D.TabIndex = 32;
            D.Text = "Ders seçiniz:";
            // 
            // cmbOgrenci
            // 
            cmbOgrenci.FormattingEnabled = true;
            cmbOgrenci.Location = new Point(184, 67);
            cmbOgrenci.Name = "cmbOgrenci";
            cmbOgrenci.Size = new Size(121, 23);
            cmbOgrenci.TabIndex = 31;
            cmbOgrenci.SelectedIndexChanged += cmbOgrenci_SelectedIndexChanged_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(51, 65);
            label1.Name = "label1";
            label1.Size = new Size(90, 15);
            label1.TabIndex = 30;
            label1.Text = "Öğrenci seçiniz:";
            // 
            // btnComboboxEkle
            // 
            btnComboboxEkle.Location = new Point(654, 226);
            btnComboboxEkle.Name = "btnComboboxEkle";
            btnComboboxEkle.Size = new Size(101, 48);
            btnComboboxEkle.TabIndex = 34;
            btnComboboxEkle.Text = "BİLGİ EKLE";
            btnComboboxEkle.UseVisualStyleBackColor = true;
            btnComboboxEkle.Click += btnComboboxEkle_Click_1;
            // 
            // DersBilgi
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(833, 847);
            Controls.Add(groupBox4);
            Controls.Add(btnHesapla);
            Controls.Add(btnComboboxEkle);
            Controls.Add(btnSil);
            Controls.Add(groupBox3);
            Controls.Add(label7);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label2);
            Controls.Add(dgvBilgiListesi);
            Name = "DersBilgi";
            Text = "Ders Bilgisi";
            ((System.ComponentModel.ISupportInitialize)dgvBilgiListesi).EndInit();
            ((System.ComponentModel.ISupportInitialize)dersBindingSource).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dgvBilgiListesi;
        private Label label2;
        private Label label9;
        private Label label10;
        private Label lbl1GenelOrt;
        private Label lbl1DonemOrt;
        private Label lbl2DonemOrt;
        private Label lbl2GenelOrt;
        private Label label15;
        private Label label16;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label4;
        private Label label5;
        private Button btnSil;
        private GroupBox groupBox3;
        private ComboBox cmbDonemsec;
        private Label label7;
        private BindingSource dersBindingSource;
        private Button btnHesapla;
        private GroupBox groupBox4;
        private TextBox txtHarfNotu;
        private Label label3;
        private Button btnComboboxEkle;
        private ComboBox cbmDersler;
        private Label D;
        private ComboBox cmbOgrenci;
        private Label label1;
        private Label BasariDurumu1;
        private Label BasariDurumu2;
    }
}