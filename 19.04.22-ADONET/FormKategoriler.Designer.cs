namespace _19._04._22_ADONET
{
    partial class FormKategoriler
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
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.tbxKategoriAdi = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbxKategoriId = new System.Windows.Forms.TextBox();
            this.dgwKategoriler = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgwKategoriler)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(640, 105);
            this.btnGuncelle.Margin = new System.Windows.Forms.Padding(5);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(112, 41);
            this.btnGuncelle.TabIndex = 12;
            this.btnGuncelle.Text = "Guncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(533, 105);
            this.btnSil.Margin = new System.Windows.Forms.Padding(5);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(81, 41);
            this.btnSil.TabIndex = 13;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(426, 105);
            this.btnEkle.Margin = new System.Windows.Forms.Padding(5);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(81, 41);
            this.btnEkle.TabIndex = 14;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 118);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(144, 25);
            this.label7.TabIndex = 10;
            this.label7.Text = "Kategori Adı";
            // 
            // tbxKategoriAdi
            // 
            this.tbxKategoriAdi.Location = new System.Drawing.Point(183, 115);
            this.tbxKategoriAdi.Margin = new System.Windows.Forms.Padding(5);
            this.tbxKategoriAdi.Name = "tbxKategoriAdi";
            this.tbxKategoriAdi.Size = new System.Drawing.Size(199, 33);
            this.tbxKategoriAdi.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(44, 51);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 25);
            this.label6.TabIndex = 11;
            this.label6.Text = "Kategori Id";
            // 
            // tbxKategoriId
            // 
            this.tbxKategoriId.Location = new System.Drawing.Point(183, 48);
            this.tbxKategoriId.Margin = new System.Windows.Forms.Padding(5);
            this.tbxKategoriId.Name = "tbxKategoriId";
            this.tbxKategoriId.Size = new System.Drawing.Size(199, 33);
            this.tbxKategoriId.TabIndex = 9;
            // 
            // dgwKategoriler
            // 
            this.dgwKategoriler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwKategoriler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwKategoriler.Cursor = System.Windows.Forms.Cursors.No;
            this.dgwKategoriler.Location = new System.Drawing.Point(29, 170);
            this.dgwKategoriler.Margin = new System.Windows.Forms.Padding(5);
            this.dgwKategoriler.Name = "dgwKategoriler";
            this.dgwKategoriler.Size = new System.Drawing.Size(726, 194);
            this.dgwKategoriler.TabIndex = 15;
            this.dgwKategoriler.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwKategoriler_CellClick);
            // 
            // FormKategoriler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 415);
            this.Controls.Add(this.dgwKategoriler);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbxKategoriAdi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbxKategoriId);
            this.Font = new System.Drawing.Font("JetBrains Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FormKategoriler";
            this.Text = "Kategoriler";
            this.Load += new System.EventHandler(this.Kategoriler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwKategoriler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbxKategoriAdi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbxKategoriId;
        private System.Windows.Forms.DataGridView dgwKategoriler;
    }
}