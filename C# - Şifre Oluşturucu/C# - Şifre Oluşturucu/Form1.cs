namespace C____Şifre_Oluşturucu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public int r, r2, buyukharf, kucukharf, rakam;
        public char r3;

        private void cbBuyuk_CheckedChanged(object sender, EventArgs e)
        {
            if (cbBuyuk.Checked == true || cbRakam.Checked == true || cbKucuk.Checked == true)
            { btnOlustur.Enabled = true; }
            else { btnOlustur.Enabled = false; }
        }

        private void cbKucuk_CheckedChanged(object sender, EventArgs e)
        {
            if (cbBuyuk.Checked == true || cbRakam.Checked == true || cbKucuk.Checked == true)
            { btnOlustur.Enabled = true; }
            else { btnOlustur.Enabled = false; }
        }

        private void cbRakam_CheckedChanged(object sender, EventArgs e)
        {
            if (cbBuyuk.Checked == true || cbRakam.Checked == true || cbKucuk.Checked == true)
            { btnOlustur.Enabled = true; }
            else { btnOlustur.Enabled = false; }
        }

        private void btnOlustur_Click(object sender, EventArgs e)
        {
            if (txtHane.Text.Length == 0) { lblUyari.Text = "Lütfen şifrenizin kaç haneli olacağını belirleyiniz."; }
            else
            {
                if (Convert.ToInt32(txtHane.Text) < 5) { lblUyari.Text = "Minimum şifre uzunluğu 5 hanedir."; }
                else
                {
                    if (Convert.ToInt32(txtHane.Text) < 7) { lblUyari.Text = "Güvenliğiniz için en az 7 haneli şifre kullanmanızı öneririz."; }
                    else { lblUyari.Text = null; }
                    btnKaydet.Enabled = true;
                    btnCopy.Enabled = true;
                    int tek = 1;
                    txtSifre.Text = null;
                    Random random = new Random();


                    if (cbBuyuk.Checked && cbRakam.Checked && cbKucuk.Checked)
                    {
                        for (int i = 0; i < Convert.ToInt32(txtHane.Text); i++)
                        {
                            while (tek == 1)                //rastgele değerler atamadan önce mutlaka 1 büyük harf, 1 küçük harf ve 1 rakam olmasını sağlayan döngü.
                            {
                                buyukharf = random.Next(1, Convert.ToInt32(txtHane.Text));
                                kucukharf = random.Next(1, Convert.ToInt32(txtHane.Text));
                                rakam = random.Next(1, Convert.ToInt32(txtHane.Text));
                                if (buyukharf == kucukharf || buyukharf == rakam || kucukharf == rakam)  //değişkenler aynı sayıya denk geldiyse ayrı denk gelene kadar yeniden döndürüyor.
                                { tek = 1; }
                                else { tek++; }
                            }

                            if (i == buyukharf)
                            { r2 = random.Next(65, 91); }
                            else if (i == kucukharf)
                            { r2 = random.Next(97, 123); }
                            else if (i == rakam)
                            { r2 = random.Next(48, 58); }
                            else
                            {
                                r = random.Next(1, 4);
                                if (r == 1) { r2 = random.Next(65, 91); }
                                if (r == 2) { r2 = random.Next(97, 123); }
                                if (r == 3) { r2 = random.Next(48, 58); }
                            }
                            r3 = Convert.ToChar(r2);
                            txtSifre.Text += r3.ToString();
                        }
                    }
                    else if (cbBuyuk.Checked && cbRakam.Checked) //küçük harf olmayan
                    {
                        for (int i = 0; i < Convert.ToInt32(txtHane.Text); i++)
                        {
                            while (tek == 1)
                            {
                                buyukharf = random.Next(1, Convert.ToInt32(txtHane.Text));
                                rakam = random.Next(1, Convert.ToInt32(txtHane.Text));
                                if (buyukharf == rakam)
                                { tek = 1; }
                                else { tek++; }
                            }

                            if (i == buyukharf)
                            { r2 = random.Next(65, 91); }
                            else if (i == rakam)
                            { r2 = random.Next(48, 58); }
                            else
                            {
                                r = random.Next(1, 3);
                                if (r == 1) { r2 = random.Next(65, 91); }
                                if (r == 3) { r2 = random.Next(48, 58); }
                            }
                            r3 = Convert.ToChar(r2);
                            txtSifre.Text += r3.ToString();
                        }
                    }
                    else if (cbBuyuk.Checked && cbKucuk.Checked)  //rakam olmayan
                    {
                        for (int i = 0; i < Convert.ToInt32(txtHane.Text); i++)
                        {
                            while (tek == 1)
                            {
                                buyukharf = random.Next(1, Convert.ToInt32(txtHane.Text));
                                kucukharf = random.Next(1, Convert.ToInt32(txtHane.Text));
                                if (buyukharf == kucukharf)
                                { tek = 1; }
                                else { tek++; }
                            }

                            if (i == buyukharf)
                            { r2 = random.Next(65, 91); }
                            else if (i == kucukharf)
                            { r2 = random.Next(97, 123); }
                            else
                            {
                                r = random.Next(1, 3);
                                if (r == 1) { r2 = random.Next(65, 91); }
                                if (r == 2) { r2 = random.Next(97, 123); }
                            }
                            r3 = Convert.ToChar(r2);
                            txtSifre.Text += r3.ToString();
                        }
                    }
                    else if (cbRakam.Checked && cbKucuk.Checked)  //büyük harf olmayan
                    {
                        for (int i = 0; i < Convert.ToInt32(txtHane.Text); i++)
                        {
                            while (tek == 1)
                            {
                                kucukharf = random.Next(1, Convert.ToInt32(txtHane.Text));
                                rakam = random.Next(1, Convert.ToInt32(txtHane.Text));
                                if (kucukharf == rakam)
                                { tek = 1; }
                                else { tek++; }
                            }

                            if (i == kucukharf)
                            { r2 = random.Next(97, 123); }
                            else if (i == rakam)
                            { r2 = random.Next(48, 58); }
                            else
                            {
                                r = random.Next(1, 3);
                                if (r == 1) { r2 = random.Next(65, 91); }
                                if (r == 2) { r2 = random.Next(97, 123); }
                                if (r == 3) { r2 = random.Next(48, 58); }
                            }
                            r3 = Convert.ToChar(r2);
                            txtSifre.Text += r3.ToString();
                        }
                    }
                    else if (cbBuyuk.Checked)  //sadece büyük harf
                    {
                        for (int i = 0; i < Convert.ToInt32(txtHane.Text); i++)
                        {

                            r = random.Next(1, 2);
                            if (r == 1) { r2 = random.Next(65, 91); }

                            r3 = Convert.ToChar(r2);
                            txtSifre.Text += r3.ToString();
                        }
                    }
                    else if (cbRakam.Checked)   //sadece rakam
                    {
                        for (int i = 0; i < Convert.ToInt32(txtHane.Text); i++)
                        {

                            r = random.Next(1, 2);
                            if (r == 1) { r2 = random.Next(48, 58); }

                            r3 = Convert.ToChar(r2);
                            txtSifre.Text += r3.ToString();
                        }
                    }
                    else if (cbKucuk.Checked)  //sadece küçük harf
                    {
                        for (int i = 0; i < Convert.ToInt32(txtHane.Text); i++)
                        {

                            r = random.Next(1, 2);
                            if (r == 1) { r2 = random.Next(97, 123); }

                            r3 = Convert.ToChar(r2);
                            txtSifre.Text += r3.ToString();
                        }
                    }
                }
            }
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtSifre.Text);
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            lbListe.Items.Add(txtSifre.Text);
            btnKaydet.Enabled = false;
        }

        private void btnSecileniKopyala_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(lbListe.SelectedItem.ToString());
            btnSecileniKopyala.Enabled = false;
        }

        private void txtHane_KeyPress(object sender, KeyPressEventArgs e) //sadece sayı girişi
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void lbListe_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnSecileniKopyala.Enabled = true;
        }
    }
}