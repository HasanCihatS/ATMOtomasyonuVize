namespace ATMOtomasyonuVize
{
    partial class frmMain
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabMusteriOlusturma = new System.Windows.Forms.TabPage();
            this.dataGridMusteriler = new System.Windows.Forms.DataGridView();
            this.buttonMusteriOlustur = new System.Windows.Forms.Button();
            this.labelMusteriAdi = new System.Windows.Forms.Label();
            this.textMusteriAdi = new System.Windows.Forms.TextBox();
            this.tabATMOperasyonlari = new System.Windows.Forms.TabPage();
            this.btnAtmOnayla = new System.Windows.Forms.Button();
            this.textMiktar = new System.Windows.Forms.TextBox();
            this.labelMiktar = new System.Windows.Forms.Label();
            this.labelIslemTipi = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.labelMusteriAdiATM = new System.Windows.Forms.Label();
            this.textMusteriAdiATM = new System.Windows.Forms.TextBox();
            this.tabKullaniciLoglari = new System.Windows.Forms.TabPage();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.labelMusteriler = new System.Windows.Forms.Label();
            this.comboMusteriler = new System.Windows.Forms.ComboBox();
            this.tabControl.SuspendLayout();
            this.tabMusteriOlusturma.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMusteriler)).BeginInit();
            this.tabATMOperasyonlari.SuspendLayout();
            this.tabKullaniciLoglari.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabMusteriOlusturma);
            this.tabControl.Controls.Add(this.tabATMOperasyonlari);
            this.tabControl.Controls.Add(this.tabKullaniciLoglari);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(912, 556);
            this.tabControl.TabIndex = 0;
            // 
            // tabMusteriOlusturma
            // 
            this.tabMusteriOlusturma.Controls.Add(this.dataGridMusteriler);
            this.tabMusteriOlusturma.Controls.Add(this.buttonMusteriOlustur);
            this.tabMusteriOlusturma.Controls.Add(this.labelMusteriAdi);
            this.tabMusteriOlusturma.Controls.Add(this.textMusteriAdi);
            this.tabMusteriOlusturma.Location = new System.Drawing.Point(4, 24);
            this.tabMusteriOlusturma.Name = "tabMusteriOlusturma";
            this.tabMusteriOlusturma.Padding = new System.Windows.Forms.Padding(3);
            this.tabMusteriOlusturma.Size = new System.Drawing.Size(904, 528);
            this.tabMusteriOlusturma.TabIndex = 0;
            this.tabMusteriOlusturma.Text = "Müşteri Oluşturma";
            this.tabMusteriOlusturma.UseVisualStyleBackColor = true;
            // 
            // dataGridMusteriler
            // 
            this.dataGridMusteriler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridMusteriler.Location = new System.Drawing.Point(18, 79);
            this.dataGridMusteriler.Name = "dataGridMusteriler";
            this.dataGridMusteriler.RowTemplate.Height = 25;
            this.dataGridMusteriler.Size = new System.Drawing.Size(865, 431);
            this.dataGridMusteriler.TabIndex = 3;
            // 
            // buttonMusteriOlustur
            // 
            this.buttonMusteriOlustur.Location = new System.Drawing.Point(195, 34);
            this.buttonMusteriOlustur.Name = "buttonMusteriOlustur";
            this.buttonMusteriOlustur.Size = new System.Drawing.Size(135, 23);
            this.buttonMusteriOlustur.TabIndex = 2;
            this.buttonMusteriOlustur.Text = "Müşteri Oluştur";
            this.buttonMusteriOlustur.UseVisualStyleBackColor = true;
            this.buttonMusteriOlustur.Click += new System.EventHandler(this.buttonMusteriOlustur_Click);
            // 
            // labelMusteriAdi
            // 
            this.labelMusteriAdi.AutoSize = true;
            this.labelMusteriAdi.Location = new System.Drawing.Point(18, 16);
            this.labelMusteriAdi.Name = "labelMusteriAdi";
            this.labelMusteriAdi.Size = new System.Drawing.Size(68, 15);
            this.labelMusteriAdi.TabIndex = 1;
            this.labelMusteriAdi.Text = "Müşteri Adı";
            // 
            // textMusteriAdi
            // 
            this.textMusteriAdi.Location = new System.Drawing.Point(18, 34);
            this.textMusteriAdi.Name = "textMusteriAdi";
            this.textMusteriAdi.Size = new System.Drawing.Size(158, 23);
            this.textMusteriAdi.TabIndex = 0;
            // 
            // tabATMOperasyonlari
            // 
            this.tabATMOperasyonlari.Controls.Add(this.btnAtmOnayla);
            this.tabATMOperasyonlari.Controls.Add(this.textMiktar);
            this.tabATMOperasyonlari.Controls.Add(this.labelMiktar);
            this.tabATMOperasyonlari.Controls.Add(this.labelIslemTipi);
            this.tabATMOperasyonlari.Controls.Add(this.comboBox1);
            this.tabATMOperasyonlari.Controls.Add(this.labelMusteriAdiATM);
            this.tabATMOperasyonlari.Controls.Add(this.textMusteriAdiATM);
            this.tabATMOperasyonlari.Location = new System.Drawing.Point(4, 24);
            this.tabATMOperasyonlari.Name = "tabATMOperasyonlari";
            this.tabATMOperasyonlari.Padding = new System.Windows.Forms.Padding(3);
            this.tabATMOperasyonlari.Size = new System.Drawing.Size(904, 528);
            this.tabATMOperasyonlari.TabIndex = 1;
            this.tabATMOperasyonlari.Text = "ATM Operasyonları";
            this.tabATMOperasyonlari.UseVisualStyleBackColor = true;
            // 
            // btnAtmOnayla
            // 
            this.btnAtmOnayla.Location = new System.Drawing.Point(449, 25);
            this.btnAtmOnayla.Name = "btnAtmOnayla";
            this.btnAtmOnayla.Size = new System.Drawing.Size(78, 23);
            this.btnAtmOnayla.TabIndex = 7;
            this.btnAtmOnayla.Text = "Onayla";
            this.btnAtmOnayla.UseVisualStyleBackColor = true;
            this.btnAtmOnayla.Click += new System.EventHandler(this.btnAtmOnayla_Click);
            // 
            // textMiktar
            // 
            this.textMiktar.Location = new System.Drawing.Point(184, 25);
            this.textMiktar.Name = "textMiktar";
            this.textMiktar.Size = new System.Drawing.Size(132, 23);
            this.textMiktar.TabIndex = 6;
            // 
            // labelMiktar
            // 
            this.labelMiktar.AutoSize = true;
            this.labelMiktar.Location = new System.Drawing.Point(184, 7);
            this.labelMiktar.Name = "labelMiktar";
            this.labelMiktar.Size = new System.Drawing.Size(41, 15);
            this.labelMiktar.TabIndex = 5;
            this.labelMiktar.Text = "Miktar";
            // 
            // labelIslemTipi
            // 
            this.labelIslemTipi.AutoSize = true;
            this.labelIslemTipi.Location = new System.Drawing.Point(322, 7);
            this.labelIslemTipi.Name = "labelIslemTipi";
            this.labelIslemTipi.Size = new System.Drawing.Size(57, 15);
            this.labelIslemTipi.TabIndex = 3;
            this.labelIslemTipi.Text = "İşlem Tipi";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Para Çek",
            "Para Ekle",
            "Bakiye Sorgula"});
            this.comboBox1.Location = new System.Drawing.Point(322, 25);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 2;
            // 
            // labelMusteriAdiATM
            // 
            this.labelMusteriAdiATM.AutoSize = true;
            this.labelMusteriAdiATM.Location = new System.Drawing.Point(17, 7);
            this.labelMusteriAdiATM.Name = "labelMusteriAdiATM";
            this.labelMusteriAdiATM.Size = new System.Drawing.Size(68, 15);
            this.labelMusteriAdiATM.TabIndex = 1;
            this.labelMusteriAdiATM.Text = "Müşteri Adı";
            // 
            // textMusteriAdiATM
            // 
            this.textMusteriAdiATM.Location = new System.Drawing.Point(6, 25);
            this.textMusteriAdiATM.Name = "textMusteriAdiATM";
            this.textMusteriAdiATM.Size = new System.Drawing.Size(161, 23);
            this.textMusteriAdiATM.TabIndex = 0;
            // 
            // tabKullaniciLoglari
            // 
            this.tabKullaniciLoglari.Controls.Add(this.richTextBox1);
            this.tabKullaniciLoglari.Controls.Add(this.labelMusteriler);
            this.tabKullaniciLoglari.Controls.Add(this.comboMusteriler);
            this.tabKullaniciLoglari.Location = new System.Drawing.Point(4, 24);
            this.tabKullaniciLoglari.Name = "tabKullaniciLoglari";
            this.tabKullaniciLoglari.Size = new System.Drawing.Size(904, 528);
            this.tabKullaniciLoglari.TabIndex = 2;
            this.tabKullaniciLoglari.Text = "Kullanıcı Logları";
            this.tabKullaniciLoglari.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(17, 74);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(865, 435);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // labelMusteriler
            // 
            this.labelMusteriler.AutoSize = true;
            this.labelMusteriler.Location = new System.Drawing.Point(17, 10);
            this.labelMusteriler.Name = "labelMusteriler";
            this.labelMusteriler.Size = new System.Drawing.Size(47, 15);
            this.labelMusteriler.TabIndex = 1;
            this.labelMusteriler.Text = "Müşteri";
            // 
            // comboMusteriler
            // 
            this.comboMusteriler.FormattingEnabled = true;
            this.comboMusteriler.Location = new System.Drawing.Point(17, 28);
            this.comboMusteriler.Name = "comboMusteriler";
            this.comboMusteriler.Size = new System.Drawing.Size(268, 23);
            this.comboMusteriler.TabIndex = 0;
            this.comboMusteriler.SelectedIndexChanged += new System.EventHandler(this.comboMusteriler_SelectedIndexChanged);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 556);
            this.Controls.Add(this.tabControl);
            this.Name = "frmMain";
            this.Text = "Banka Otomasyonu";
            this.tabControl.ResumeLayout(false);
            this.tabMusteriOlusturma.ResumeLayout(false);
            this.tabMusteriOlusturma.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMusteriler)).EndInit();
            this.tabATMOperasyonlari.ResumeLayout(false);
            this.tabATMOperasyonlari.PerformLayout();
            this.tabKullaniciLoglari.ResumeLayout(false);
            this.tabKullaniciLoglari.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl;
        private TabPage tabMusteriOlusturma;
        private TabPage tabATMOperasyonlari;
        private TabPage tabKullaniciLoglari;
        private Label labelMusteriAdi;
        private TextBox textMusteriAdi;
        private Button buttonMusteriOlustur;
        private DataGridView dataGridMusteriler;
        private ComboBox comboMusteriler;
        private Label labelMusteriler;
        private RichTextBox richTextBox1;
        private Label labelIslemTipi;
        private ComboBox comboBox1;
        private Label labelMusteriAdiATM;
        private TextBox textMusteriAdiATM;
        private TextBox textMiktar;
        private Label labelMiktar;
        private Button btnAtmOnayla;
    }
}