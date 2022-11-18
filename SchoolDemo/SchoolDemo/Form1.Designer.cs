namespace SchoolDemo
{
    partial class Form1
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxSinifNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxBolum = new System.Windows.Forms.ComboBox();
            this.comboBoxSube = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonSinifOlustur = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxEgitmenAdi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxEgitmenSoyadi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxEgitmenBransi = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonEgitmenAta = new System.Windows.Forms.Button();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.listViewSiniflar = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.textBoxOgrenciSoyadi = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxOgrenciAdi = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxOgrenciAdresi = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.buttonOgrenciEkle = new System.Windows.Forms.Button();
            this.listBoxOgrenciler = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox2);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1125, 690);
            this.splitContainer1.SplitterDistance = 375;
            this.splitContainer1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonSinifOlustur);
            this.groupBox1.Controls.Add(this.comboBoxSube);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.comboBoxBolum);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxSinifNo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(19, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(315, 197);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sınıf ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sınıf No";
            // 
            // textBoxSinifNo
            // 
            this.textBoxSinifNo.Location = new System.Drawing.Point(74, 25);
            this.textBoxSinifNo.Name = "textBoxSinifNo";
            this.textBoxSinifNo.Size = new System.Drawing.Size(100, 23);
            this.textBoxSinifNo.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Bölüm";
            // 
            // comboBoxBolum
            // 
            this.comboBoxBolum.FormattingEnabled = true;
            this.comboBoxBolum.Location = new System.Drawing.Point(73, 56);
            this.comboBoxBolum.Name = "comboBoxBolum";
            this.comboBoxBolum.Size = new System.Drawing.Size(121, 23);
            this.comboBoxBolum.TabIndex = 3;
            // 
            // comboBoxSube
            // 
            this.comboBoxSube.FormattingEnabled = true;
            this.comboBoxSube.Location = new System.Drawing.Point(73, 85);
            this.comboBoxSube.Name = "comboBoxSube";
            this.comboBoxSube.Size = new System.Drawing.Size(121, 23);
            this.comboBoxSube.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Şube";
            // 
            // buttonSinifOlustur
            // 
            this.buttonSinifOlustur.Location = new System.Drawing.Point(176, 155);
            this.buttonSinifOlustur.Name = "buttonSinifOlustur";
            this.buttonSinifOlustur.Size = new System.Drawing.Size(133, 23);
            this.buttonSinifOlustur.TabIndex = 6;
            this.buttonSinifOlustur.Text = "Sınıf Oluştur";
            this.buttonSinifOlustur.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonEgitmenAta);
            this.groupBox2.Controls.Add(this.comboBoxEgitmenBransi);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.textBoxEgitmenSoyadi);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.textBoxEgitmenAdi);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(28, 500);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(315, 161);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sınıf Eğitmeni Ata";
            // 
            // textBoxEgitmenAdi
            // 
            this.textBoxEgitmenAdi.Location = new System.Drawing.Point(74, 28);
            this.textBoxEgitmenAdi.Name = "textBoxEgitmenAdi";
            this.textBoxEgitmenAdi.Size = new System.Drawing.Size(100, 23);
            this.textBoxEgitmenAdi.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Ad";
            // 
            // textBoxEgitmenSoyadi
            // 
            this.textBoxEgitmenSoyadi.Location = new System.Drawing.Point(74, 57);
            this.textBoxEgitmenSoyadi.Name = "textBoxEgitmenSoyadi";
            this.textBoxEgitmenSoyadi.Size = new System.Drawing.Size(100, 23);
            this.textBoxEgitmenSoyadi.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Soyad";
            // 
            // comboBoxEgitmenBransi
            // 
            this.comboBoxEgitmenBransi.FormattingEnabled = true;
            this.comboBoxEgitmenBransi.Location = new System.Drawing.Point(74, 86);
            this.comboBoxEgitmenBransi.Name = "comboBoxEgitmenBransi";
            this.comboBoxEgitmenBransi.Size = new System.Drawing.Size(121, 23);
            this.comboBoxEgitmenBransi.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 15);
            this.label6.TabIndex = 7;
            this.label6.Text = "Branş";
            // 
            // buttonEgitmenAta
            // 
            this.buttonEgitmenAta.Location = new System.Drawing.Point(176, 132);
            this.buttonEgitmenAta.Name = "buttonEgitmenAta";
            this.buttonEgitmenAta.Size = new System.Drawing.Size(133, 23);
            this.buttonEgitmenAta.TabIndex = 7;
            this.buttonEgitmenAta.Text = "Sınıf Eğitmeni Ata";
            this.buttonEgitmenAta.UseVisualStyleBackColor = true;
            // 
            // splitContainer2
            // 
            this.splitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.listViewSiniflar);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.listBoxOgrenciler);
            this.splitContainer2.Panel2.Controls.Add(this.buttonOgrenciEkle);
            this.splitContainer2.Panel2.Controls.Add(this.textBoxOgrenciAdresi);
            this.splitContainer2.Panel2.Controls.Add(this.label9);
            this.splitContainer2.Panel2.Controls.Add(this.textBoxOgrenciSoyadi);
            this.splitContainer2.Panel2.Controls.Add(this.textBoxOgrenciAdi);
            this.splitContainer2.Panel2.Controls.Add(this.label7);
            this.splitContainer2.Panel2.Controls.Add(this.label8);
            this.splitContainer2.Size = new System.Drawing.Size(746, 690);
            this.splitContainer2.SplitterDistance = 409;
            this.splitContainer2.TabIndex = 0;
            // 
            // listViewSiniflar
            // 
            this.listViewSiniflar.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listViewSiniflar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewSiniflar.GridLines = true;
            this.listViewSiniflar.Location = new System.Drawing.Point(0, 0);
            this.listViewSiniflar.Name = "listViewSiniflar";
            this.listViewSiniflar.Size = new System.Drawing.Size(742, 405);
            this.listViewSiniflar.TabIndex = 0;
            this.listViewSiniflar.UseCompatibleStateImageBehavior = false;
            this.listViewSiniflar.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Sınıf Adı";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Öğrenci Sayısı";
            this.columnHeader2.Width = 120;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Sınıf Eğitmeni";
            this.columnHeader3.Width = 200;
            // 
            // textBoxOgrenciSoyadi
            // 
            this.textBoxOgrenciSoyadi.Location = new System.Drawing.Point(137, 86);
            this.textBoxOgrenciSoyadi.Name = "textBoxOgrenciSoyadi";
            this.textBoxOgrenciSoyadi.Size = new System.Drawing.Size(156, 23);
            this.textBoxOgrenciSoyadi.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(83, 89);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 15);
            this.label7.TabIndex = 13;
            this.label7.Text = "Soyad";
            // 
            // textBoxOgrenciAdi
            // 
            this.textBoxOgrenciAdi.Location = new System.Drawing.Point(137, 57);
            this.textBoxOgrenciAdi.Name = "textBoxOgrenciAdi";
            this.textBoxOgrenciAdi.Size = new System.Drawing.Size(156, 23);
            this.textBoxOgrenciAdi.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(83, 60);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(22, 15);
            this.label8.TabIndex = 11;
            this.label8.Text = "Ad";
            // 
            // textBoxOgrenciAdresi
            // 
            this.textBoxOgrenciAdresi.Location = new System.Drawing.Point(137, 120);
            this.textBoxOgrenciAdresi.Name = "textBoxOgrenciAdresi";
            this.textBoxOgrenciAdresi.Size = new System.Drawing.Size(156, 23);
            this.textBoxOgrenciAdresi.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(83, 123);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 15);
            this.label9.TabIndex = 15;
            this.label9.Text = "Adres";
            // 
            // buttonOgrenciEkle
            // 
            this.buttonOgrenciEkle.Location = new System.Drawing.Point(189, 168);
            this.buttonOgrenciEkle.Name = "buttonOgrenciEkle";
            this.buttonOgrenciEkle.Size = new System.Drawing.Size(104, 23);
            this.buttonOgrenciEkle.TabIndex = 17;
            this.buttonOgrenciEkle.Text = "Öğrenci Ekle";
            this.buttonOgrenciEkle.UseVisualStyleBackColor = true;
            // 
            // listBoxOgrenciler
            // 
            this.listBoxOgrenciler.FormattingEnabled = true;
            this.listBoxOgrenciler.ItemHeight = 15;
            this.listBoxOgrenciler.Location = new System.Drawing.Point(425, 13);
            this.listBoxOgrenciler.Name = "listBoxOgrenciler";
            this.listBoxOgrenciler.Size = new System.Drawing.Size(307, 229);
            this.listBoxOgrenciler.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1125, 690);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private SplitContainer splitContainer1;
        private GroupBox groupBox2;
        private Button buttonEgitmenAta;
        private ComboBox comboBoxEgitmenBransi;
        private Label label6;
        private TextBox textBoxEgitmenSoyadi;
        private Label label5;
        private TextBox textBoxEgitmenAdi;
        private Label label4;
        private GroupBox groupBox1;
        private Button buttonSinifOlustur;
        private ComboBox comboBoxSube;
        private Label label3;
        private ComboBox comboBoxBolum;
        private Label label2;
        private TextBox textBoxSinifNo;
        private Label label1;
        private SplitContainer splitContainer2;
        private ListView listViewSiniflar;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ListBox listBoxOgrenciler;
        private Button buttonOgrenciEkle;
        private TextBox textBoxOgrenciAdresi;
        private Label label9;
        private TextBox textBoxOgrenciSoyadi;
        private TextBox textBoxOgrenciAdi;
        private Label label7;
        private Label label8;
    }
}