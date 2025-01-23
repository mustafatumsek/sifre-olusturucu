namespace C____Şifre_Oluşturucu
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
            lblBaslik = new Label();
            lblHaneSayisi = new Label();
            txtHane = new TextBox();
            cbBuyuk = new CheckBox();
            cbRakam = new CheckBox();
            cbKucuk = new CheckBox();
            btnOlustur = new Button();
            txtSifre = new TextBox();
            lbListe = new ListBox();
            btnKaydet = new Button();
            lblUyari = new Label();
            btnCopy = new Button();
            btnSecileniKopyala = new Button();
            SuspendLayout();
            // 
            // lblBaslik
            // 
            lblBaslik.Font = new Font("Microsoft Sans Serif", 27.7499962F, FontStyle.Regular, GraphicsUnit.Point);
            lblBaslik.Location = new Point(-1, 63);
            lblBaslik.Name = "lblBaslik";
            lblBaslik.Size = new Size(498, 115);
            lblBaslik.TabIndex = 0;
            lblBaslik.Text = "Şifre Oluşturucu";
            lblBaslik.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblHaneSayisi
            // 
            lblHaneSayisi.AutoSize = true;
            lblHaneSayisi.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblHaneSayisi.Location = new Point(129, 204);
            lblHaneSayisi.Name = "lblHaneSayisi";
            lblHaneSayisi.Size = new Size(140, 29);
            lblHaneSayisi.TabIndex = 1;
            lblHaneSayisi.Text = "Hane Sayısı";
            // 
            // txtHane
            // 
            txtHane.Location = new Point(277, 208);
            txtHane.Margin = new Padding(3, 4, 3, 4);
            txtHane.MaxLength = 2;
            txtHane.Name = "txtHane";
            txtHane.Size = new Size(63, 27);
            txtHane.TabIndex = 2;
            txtHane.KeyPress += txtHane_KeyPress;
            // 
            // cbBuyuk
            // 
            cbBuyuk.AutoSize = true;
            cbBuyuk.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            cbBuyuk.Location = new Point(31, 324);
            cbBuyuk.Margin = new Padding(3, 4, 3, 4);
            cbBuyuk.Name = "cbBuyuk";
            cbBuyuk.Size = new Size(144, 28);
            cbBuyuk.TabIndex = 3;
            cbBuyuk.Text = "Büyük Harfler";
            cbBuyuk.UseVisualStyleBackColor = true;
            cbBuyuk.CheckedChanged += cbBuyuk_CheckedChanged;
            // 
            // cbRakam
            // 
            cbRakam.AutoSize = true;
            cbRakam.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            cbRakam.Location = new Point(346, 324);
            cbRakam.Margin = new Padding(3, 4, 3, 4);
            cbRakam.Name = "cbRakam";
            cbRakam.Size = new Size(110, 28);
            cbRakam.TabIndex = 4;
            cbRakam.Text = "Rakamlar";
            cbRakam.UseVisualStyleBackColor = true;
            cbRakam.CheckedChanged += cbRakam_CheckedChanged;
            // 
            // cbKucuk
            // 
            cbKucuk.AutoSize = true;
            cbKucuk.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            cbKucuk.Location = new Point(189, 324);
            cbKucuk.Margin = new Padding(3, 4, 3, 4);
            cbKucuk.Name = "cbKucuk";
            cbKucuk.Size = new Size(145, 28);
            cbKucuk.TabIndex = 5;
            cbKucuk.Text = "Küçük Harfler";
            cbKucuk.UseVisualStyleBackColor = true;
            cbKucuk.CheckedChanged += cbKucuk_CheckedChanged;
            // 
            // btnOlustur
            // 
            btnOlustur.Enabled = false;
            btnOlustur.Location = new Point(45, 439);
            btnOlustur.Margin = new Padding(3, 4, 3, 4);
            btnOlustur.Name = "btnOlustur";
            btnOlustur.Size = new Size(126, 67);
            btnOlustur.TabIndex = 6;
            btnOlustur.Text = "Oluştur";
            btnOlustur.UseVisualStyleBackColor = true;
            btnOlustur.Click += btnOlustur_Click;
            // 
            // txtSifre
            // 
            txtSifre.Location = new Point(202, 439);
            txtSifre.Margin = new Padding(3, 4, 3, 4);
            txtSifre.MaxLength = 99;
            txtSifre.Name = "txtSifre";
            txtSifre.ReadOnly = true;
            txtSifre.Size = new Size(239, 27);
            txtSifre.TabIndex = 7;
            // 
            // lbListe
            // 
            lbListe.FormattingEnabled = true;
            lbListe.ItemHeight = 20;
            lbListe.Location = new Point(202, 487);
            lbListe.Margin = new Padding(3, 4, 3, 4);
            lbListe.Name = "lbListe";
            lbListe.Size = new Size(239, 244);
            lbListe.TabIndex = 8;
            lbListe.SelectedIndexChanged += lbListe_SelectedIndexChanged;
            // 
            // btnKaydet
            // 
            btnKaydet.Enabled = false;
            btnKaydet.Location = new Point(45, 593);
            btnKaydet.Margin = new Padding(3, 4, 3, 4);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(126, 67);
            btnKaydet.TabIndex = 9;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // lblUyari
            // 
            lblUyari.ForeColor = Color.DarkRed;
            lblUyari.Location = new Point(-1, 271);
            lblUyari.Name = "lblUyari";
            lblUyari.Size = new Size(498, 31);
            lblUyari.TabIndex = 10;
            lblUyari.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnCopy
            // 
            btnCopy.Enabled = false;
            btnCopy.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnCopy.Location = new Point(45, 513);
            btnCopy.Margin = new Padding(3, 4, 3, 4);
            btnCopy.Name = "btnCopy";
            btnCopy.Size = new Size(126, 64);
            btnCopy.TabIndex = 11;
            btnCopy.Text = "Kopyala";
            btnCopy.UseVisualStyleBackColor = true;
            btnCopy.Click += btnCopy_Click;
            // 
            // btnSecileniKopyala
            // 
            btnSecileniKopyala.Enabled = false;
            btnSecileniKopyala.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnSecileniKopyala.Location = new Point(45, 668);
            btnSecileniKopyala.Margin = new Padding(3, 4, 3, 4);
            btnSecileniKopyala.Name = "btnSecileniKopyala";
            btnSecileniKopyala.Size = new Size(126, 64);
            btnSecileniKopyala.TabIndex = 12;
            btnSecileniKopyala.Text = "Seçileni Kopyala";
            btnSecileniKopyala.UseVisualStyleBackColor = true;
            btnSecileniKopyala.Click += btnSecileniKopyala_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(496, 764);
            Controls.Add(btnSecileniKopyala);
            Controls.Add(btnCopy);
            Controls.Add(lblUyari);
            Controls.Add(btnKaydet);
            Controls.Add(lbListe);
            Controls.Add(txtSifre);
            Controls.Add(btnOlustur);
            Controls.Add(cbKucuk);
            Controls.Add(cbRakam);
            Controls.Add(cbBuyuk);
            Controls.Add(txtHane);
            Controls.Add(lblHaneSayisi);
            Controls.Add(lblBaslik);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Şifre Oluşturucu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private Button btnOlustur;
        private TextBox txtSifre;
        private ListBox lbListe;
        private Button btnKaydet;
        private Label label3;
        private Button btnCopy;
        private Button btnSecileniKopyala;
        private Label lblBaslik;
        private Label lblHaneSayisi;
        private TextBox txtHane;
        private CheckBox cbBuyuk;
        private CheckBox cbRakam;
        private CheckBox cbKucuk;
        private Label lblUyari;
    }
}