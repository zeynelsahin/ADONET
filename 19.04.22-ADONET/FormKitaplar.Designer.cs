namespace _19._04._22_ADONET
{
    partial class FormKitaplar
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
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.dgwKitaplar = new System.Windows.Forms.DataGridView();
            this.tbxKitapId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxKitapAdi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxKategoriId = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxOzet = new System.Windows.Forms.TextBox();
            this.tbxSayfaSayisi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnKategoriler = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.tbxFiltre = new System.Windows.Forms.TextBox();
            this.lblAdet = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgwKitaplar)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(18, 20);
            this.btnEkle.Margin = new System.Windows.Forms.Padding(5);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(81, 41);
            this.btnEkle.TabIndex = 0;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(125, 20);
            this.btnSil.Margin = new System.Windows.Forms.Padding(5);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(81, 41);
            this.btnSil.TabIndex = 0;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(232, 20);
            this.btnGuncelle.Margin = new System.Windows.Forms.Padding(5);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(112, 41);
            this.btnGuncelle.TabIndex = 0;
            this.btnGuncelle.Text = "Guncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // dgwKitaplar
            // 
            this.dgwKitaplar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dgwKitaplar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwKitaplar.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgwKitaplar.BackgroundColor = System.Drawing.Color.White;
            this.dgwKitaplar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwKitaplar.Cursor = System.Windows.Forms.Cursors.No;
            this.dgwKitaplar.Location = new System.Drawing.Point(395, 110);
            this.dgwKitaplar.Margin = new System.Windows.Forms.Padding(0);
            this.dgwKitaplar.Name = "dgwKitaplar";
            this.dgwKitaplar.RowTemplate.Height = 26;
            this.dgwKitaplar.Size = new System.Drawing.Size(726, 358);
            this.dgwKitaplar.TabIndex = 1;
            this.dgwKitaplar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwKitaplar_CellClick);
            this.dgwKitaplar.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgwKitaplar_DataBindingComplete);
            // 
            // tbxKitapId
            // 
            this.tbxKitapId.Location = new System.Drawing.Point(152, 110);
            this.tbxKitapId.Margin = new System.Windows.Forms.Padding(5);
            this.tbxKitapId.Name = "tbxKitapId";
            this.tbxKitapId.Size = new System.Drawing.Size(199, 29);
            this.tbxKitapId.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 110);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "KitapId";
            // 
            // tbxKitapAdi
            // 
            this.tbxKitapAdi.Location = new System.Drawing.Point(152, 177);
            this.tbxKitapAdi.Margin = new System.Windows.Forms.Padding(5);
            this.tbxKitapAdi.Name = "tbxKitapAdi";
            this.tbxKitapAdi.Size = new System.Drawing.Size(199, 29);
            this.tbxKitapAdi.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 177);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Kitap Adı";
            // 
            // cbxKategoriId
            // 
            this.cbxKategoriId.FormattingEnabled = true;
            this.cbxKategoriId.Location = new System.Drawing.Point(152, 241);
            this.cbxKategoriId.Margin = new System.Windows.Forms.Padding(5);
            this.cbxKategoriId.Name = "cbxKategoriId";
            this.cbxKategoriId.Size = new System.Drawing.Size(199, 29);
            this.cbxKategoriId.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(82, 305);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ozet";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 240);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Kategori";
            // 
            // tbxOzet
            // 
            this.tbxOzet.Location = new System.Drawing.Point(152, 299);
            this.tbxOzet.Margin = new System.Windows.Forms.Padding(5);
            this.tbxOzet.Multiline = true;
            this.tbxOzet.Name = "tbxOzet";
            this.tbxOzet.Size = new System.Drawing.Size(199, 113);
            this.tbxOzet.TabIndex = 2;
            // 
            // tbxSayfaSayisi
            // 
            this.tbxSayfaSayisi.Location = new System.Drawing.Point(152, 441);
            this.tbxSayfaSayisi.Margin = new System.Windows.Forms.Padding(5);
            this.tbxSayfaSayisi.Name = "tbxSayfaSayisi";
            this.tbxSayfaSayisi.Size = new System.Drawing.Size(199, 29);
            this.tbxSayfaSayisi.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(2, 447);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 21);
            this.label5.TabIndex = 3;
            this.label5.Text = "Sayfa Sayısı";
            // 
            // btnKategoriler
            // 
            this.btnKategoriler.Location = new System.Drawing.Point(395, 20);
            this.btnKategoriler.Margin = new System.Windows.Forms.Padding(5);
            this.btnKategoriler.Name = "btnKategoriler";
            this.btnKategoriler.Size = new System.Drawing.Size(131, 41);
            this.btnKategoriler.TabIndex = 5;
            this.btnKategoriler.Text = "Kategoriler";
            this.btnKategoriler.UseVisualStyleBackColor = true;
            this.btnKategoriler.Click += new System.EventHandler(this.btnKategoriler_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(822, 65);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 21);
            this.label6.TabIndex = 7;
            this.label6.Text = "Filtrele";
            // 
            // tbxFiltre
            // 
            this.tbxFiltre.Location = new System.Drawing.Point(922, 57);
            this.tbxFiltre.Margin = new System.Windows.Forms.Padding(5);
            this.tbxFiltre.Name = "tbxFiltre";
            this.tbxFiltre.Size = new System.Drawing.Size(199, 29);
            this.tbxFiltre.TabIndex = 6;
            this.tbxFiltre.TextChanged += new System.EventHandler(this.tbxFiltre_TextChanged);
            // 
            // lblAdet
            // 
            this.lblAdet.AutoSize = true;
            this.lblAdet.Location = new System.Drawing.Point(402, 476);
            this.lblAdet.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblAdet.Name = "lblAdet";
            this.lblAdet.Size = new System.Drawing.Size(60, 21);
            this.lblAdet.TabIndex = 3;
            this.lblAdet.Text = "Adet:";
            // 
            // FormKitaplar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1135, 506);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbxFiltre);
            this.Controls.Add(this.btnKategoriler);
            this.Controls.Add(this.cbxKategoriId);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxOzet);
            this.Controls.Add(this.tbxSayfaSayisi);
            this.Controls.Add(this.tbxKitapAdi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblAdet);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxKitapId);
            this.Controls.Add(this.dgwKitaplar);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnEkle);
            this.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FormKitaplar";
            this.Text = "Kitaplar";
            this.Load += new System.EventHandler(this.FormKitaplar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwKitaplar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.DataGridView dgwKitaplar;
        private System.Windows.Forms.TextBox tbxKitapId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxKitapAdi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxKategoriId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxOzet;
        private System.Windows.Forms.TextBox tbxSayfaSayisi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnKategoriler;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbxFiltre;
        private System.Windows.Forms.Label lblAdet;
    }
}

