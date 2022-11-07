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
            this.tabKullaniciLoglari = new System.Windows.Forms.TabPage();
            this.tabControl.SuspendLayout();
            this.tabMusteriOlusturma.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMusteriler)).BeginInit();
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
            this.tabATMOperasyonlari.Location = new System.Drawing.Point(4, 24);
            this.tabATMOperasyonlari.Name = "tabATMOperasyonlari";
            this.tabATMOperasyonlari.Padding = new System.Windows.Forms.Padding(3);
            this.tabATMOperasyonlari.Size = new System.Drawing.Size(904, 528);
            this.tabATMOperasyonlari.TabIndex = 1;
            this.tabATMOperasyonlari.Text = "ATM Operasyonları";
            this.tabATMOperasyonlari.UseVisualStyleBackColor = true;
            // 
            // tabKullaniciLoglari
            // 
            this.tabKullaniciLoglari.Location = new System.Drawing.Point(4, 24);
            this.tabKullaniciLoglari.Name = "tabKullaniciLoglari";
            this.tabKullaniciLoglari.Size = new System.Drawing.Size(904, 528);
            this.tabKullaniciLoglari.TabIndex = 2;
            this.tabKullaniciLoglari.Text = "Kullanıcı Logları";
            this.tabKullaniciLoglari.UseVisualStyleBackColor = true;
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
    }
}