namespace OgrenciNotProjesi
{
    partial class OgrenciTranscript
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtOgrenciAd = new TextBox();
            txtOgrenciSoyad = new TextBox();
            txtOgrenciNo = new TextBox();
            btnOgrenciEkle = new Button();
            btnBilgileriAc = new Button();
            groupBox2 = new GroupBox();
            cmbDonemsec1 = new ComboBox();
            label8 = new Label();
            btn1DersEkle = new Button();
            txtKredisi = new TextBox();
            txtDersAdi = new TextBox();
            txtDersKodu = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            dersBindingSource = new BindingSource(components);
            groupBox1 = new GroupBox();
            dersBindingSource1 = new BindingSource(components);
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dersBindingSource).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dersBindingSource1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 105);
            label1.Name = "label1";
            label1.Size = new Size(25, 15);
            label1.TabIndex = 0;
            label1.Text = "Ad:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(37, 150);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 1;
            label2.Text = "Soyad:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(35, 203);
            label3.Name = "label3";
            label3.Size = new Size(71, 15);
            label3.TabIndex = 2;
            label3.Text = "Öğrenci No:";
            // 
            // txtOgrenciAd
            // 
            txtOgrenciAd.Location = new Point(142, 102);
            txtOgrenciAd.Name = "txtOgrenciAd";
            txtOgrenciAd.Size = new Size(100, 23);
            txtOgrenciAd.TabIndex = 3;
            // 
            // txtOgrenciSoyad
            // 
            txtOgrenciSoyad.Location = new Point(143, 149);
            txtOgrenciSoyad.Name = "txtOgrenciSoyad";
            txtOgrenciSoyad.Size = new Size(100, 23);
            txtOgrenciSoyad.TabIndex = 4;
            // 
            // txtOgrenciNo
            // 
            txtOgrenciNo.Location = new Point(148, 200);
            txtOgrenciNo.Name = "txtOgrenciNo";
            txtOgrenciNo.Size = new Size(100, 23);
            txtOgrenciNo.TabIndex = 5;
            // 
            // btnOgrenciEkle
            // 
            btnOgrenciEkle.Location = new Point(142, 291);
            btnOgrenciEkle.Name = "btnOgrenciEkle";
            btnOgrenciEkle.Size = new Size(138, 23);
            btnOgrenciEkle.TabIndex = 6;
            btnOgrenciEkle.Text = "ÖĞRENCİ EKLE";
            btnOgrenciEkle.UseVisualStyleBackColor = true;
            btnOgrenciEkle.Click += btnOgrenciEkle_Click_1;
            // 
            // btnBilgileriAc
            // 
            btnBilgileriAc.Location = new Point(566, 500);
            btnBilgileriAc.Name = "btnBilgileriAc";
            btnBilgileriAc.Size = new Size(138, 49);
            btnBilgileriAc.TabIndex = 7;
            btnBilgileriAc.Text = "BİLGİLERİ AÇ";
            btnBilgileriAc.UseVisualStyleBackColor = true;
            btnBilgileriAc.Click += btnBilgileriAc_Click_1;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(cmbDonemsec1);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(btn1DersEkle);
            groupBox2.Controls.Add(txtKredisi);
            groupBox2.Controls.Add(txtDersAdi);
            groupBox2.Controls.Add(txtDersKodu);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Location = new Point(373, 78);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(331, 375);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Ders Bilgileri";
            // 
            // cmbDonemsec1
            // 
            cmbDonemsec1.FormattingEnabled = true;
            cmbDonemsec1.Items.AddRange(new object[] { "Dönem1", "Dönem2" });
            cmbDonemsec1.Location = new Point(147, 222);
            cmbDonemsec1.Name = "cmbDonemsec1";
            cmbDonemsec1.Size = new Size(121, 23);
            cmbDonemsec1.TabIndex = 18;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(27, 220);
            label8.Name = "label8";
            label8.Size = new Size(87, 15);
            label8.TabIndex = 17;
            label8.Text = "Dönem seçiniz:";
            // 
            // btn1DersEkle
            // 
            btn1DersEkle.Location = new Point(190, 332);
            btn1DersEkle.Name = "btn1DersEkle";
            btn1DersEkle.Size = new Size(113, 23);
            btn1DersEkle.TabIndex = 8;
            btn1DersEkle.Text = "DERS EKLE";
            btn1DersEkle.UseVisualStyleBackColor = true;
            btn1DersEkle.Click += btn1DersEkle_Click;
            // 
            // txtKredisi
            // 
            txtKredisi.Location = new Point(135, 155);
            txtKredisi.Name = "txtKredisi";
            txtKredisi.Size = new Size(100, 23);
            txtKredisi.TabIndex = 6;
            // 
            // txtDersAdi
            // 
            txtDersAdi.Location = new Point(135, 107);
            txtDersAdi.Name = "txtDersAdi";
            txtDersAdi.Size = new Size(100, 23);
            txtDersAdi.TabIndex = 5;
            // 
            // txtDersKodu
            // 
            txtDersKodu.Location = new Point(135, 56);
            txtDersKodu.Name = "txtDersKodu";
            txtDersKodu.Size = new Size(100, 23);
            txtDersKodu.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(25, 158);
            label6.Name = "label6";
            label6.Size = new Size(45, 15);
            label6.TabIndex = 2;
            label6.Text = "Kredisi:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(24, 109);
            label5.Name = "label5";
            label5.Size = new Size(54, 15);
            label5.TabIndex = 1;
            label5.Text = "Ders Adı:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(18, 64);
            label4.Name = "label4";
            label4.Size = new Size(64, 15);
            label4.TabIndex = 0;
            label4.Text = "Ders Kodu:";
            // 
            // dersBindingSource
            // 
            dersBindingSource.DataSource = typeof(Ders);
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnOgrenciEkle);
            groupBox1.Controls.Add(txtOgrenciNo);
            groupBox1.Controls.Add(txtOgrenciSoyad);
            groupBox1.Controls.Add(txtOgrenciAd);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(21, 72);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(319, 381);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Öğrenci Bilgileri";
            // 
            // dersBindingSource1
            // 
            dersBindingSource1.DataSource = typeof(Ders);
            // 
            // OgrenciTranscript
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(747, 618);
            Controls.Add(btnBilgileriAc);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "OgrenciTranscript";
            Text = "Öğrenci Not Hesaplama Sistemi";
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dersBindingSource).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dersBindingSource1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnBilgileriAc;
        private Button btnOgrenciEkle;
        private TextBox txtOgrenciNo;
        private TextBox txtOgrenciSoyad;
        private TextBox txtOgrenciAd;
        private GroupBox groupBox2;
        private Button btn1DersEkle;
        private TextBox txtKredisi;
        private TextBox txtDersAdi;
        private TextBox txtDersKodu;
        private Label label6;
        private Label label5;
        private Label label4;
        private GroupBox groupBox1;
        private Label label8;
        private ComboBox cmbDonemsec1;
        private BindingSource dersBindingSource;
        private BindingSource dersBindingSource1;
    }
}