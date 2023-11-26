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

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true || checkBox2.Checked == true || checkBox3.Checked == true)
            { button1.Enabled = true; }
            else { button1.Enabled = false; }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true || checkBox2.Checked == true || checkBox3.Checked == true)
            { button1.Enabled = true; }
            else { button1.Enabled = false; }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true || checkBox2.Checked == true || checkBox3.Checked == true)
            { button1.Enabled = true; }
            else { button1.Enabled = false; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 0) { label3.Text = "Lütfen şifrenizin kaç haneli olacağını belirleyiniz."; }
            else
            {
                if (Convert.ToInt32(textBox1.Text) < 5) { label3.Text = "Minimum şifre uzunluğu 5 hanedir."; }
                else
                {
                    if (Convert.ToInt32(textBox1.Text) < 7) { label3.Text = "Güvenliğiniz için en az 7 haneli şifre kullanmanızı öneririz."; }
                    else { label3.Text = null; }
                    button2.Enabled = true;
                    button3.Enabled = true;
                    int tek = 1;
                    sifre.Text = null;
                    Random random = new Random();


                    if (checkBox1.Checked && checkBox2.Checked && checkBox3.Checked)
                    {
                        for (int i = 0; i < Convert.ToInt32(textBox1.Text); i++)
                        {
                            while (tek == 1)                //rastgele değerler atamadan önce mutlaka 1 büyük harf, 1 küçük harf ve 1 rakam olmasını sağlayan döngü.
                            {
                                buyukharf = random.Next(1, Convert.ToInt32(textBox1.Text));
                                kucukharf = random.Next(1, Convert.ToInt32(textBox1.Text));
                                rakam = random.Next(1, Convert.ToInt32(textBox1.Text));
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
                            sifre.Text += r3.ToString();
                        }
                    }
                    else if (checkBox1.Checked && checkBox2.Checked) //küçük harf olmayan
                    {
                        for (int i = 0; i < Convert.ToInt32(textBox1.Text); i++)
                        {
                            while (tek == 1)
                            {
                                buyukharf = random.Next(1, Convert.ToInt32(textBox1.Text));
                                rakam = random.Next(1, Convert.ToInt32(textBox1.Text));
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
                            sifre.Text += r3.ToString();
                        }
                    }
                    else if (checkBox1.Checked && checkBox3.Checked)  //rakam olmayan
                    {
                        for (int i = 0; i < Convert.ToInt32(textBox1.Text); i++)
                        {
                            while (tek == 1)
                            {
                                buyukharf = random.Next(1, Convert.ToInt32(textBox1.Text));
                                kucukharf = random.Next(1, Convert.ToInt32(textBox1.Text));
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
                            sifre.Text += r3.ToString();
                        }
                    }
                    else if (checkBox2.Checked && checkBox3.Checked)  //büyük harf olmayan
                    {
                        for (int i = 0; i < Convert.ToInt32(textBox1.Text); i++)
                        {
                            while (tek == 1)
                            {
                                kucukharf = random.Next(1, Convert.ToInt32(textBox1.Text));
                                rakam = random.Next(1, Convert.ToInt32(textBox1.Text));
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
                            sifre.Text += r3.ToString();
                        }
                    }
                    else if (checkBox1.Checked)  //sadece büyük harf
                    {
                        for (int i = 0; i < Convert.ToInt32(textBox1.Text); i++)
                        {

                            r = random.Next(1, 2);
                            if (r == 1) { r2 = random.Next(65, 91); }

                            r3 = Convert.ToChar(r2);
                            sifre.Text += r3.ToString();
                        }
                    }
                    else if (checkBox2.Checked)   //sadece rakam
                    {
                        for (int i = 0; i < Convert.ToInt32(textBox1.Text); i++)
                        {

                            r = random.Next(1, 2);
                            if (r == 1) { r2 = random.Next(48, 58); }

                            r3 = Convert.ToChar(r2);
                            sifre.Text += r3.ToString();
                        }
                    }
                    else if (checkBox3.Checked)  //sadece küçük harf
                    {
                        for (int i = 0; i < Convert.ToInt32(textBox1.Text); i++)
                        {

                            r = random.Next(1, 2);
                            if (r == 1) { r2 = random.Next(97, 123); }

                            r3 = Convert.ToChar(r2);
                            sifre.Text += r3.ToString();
                        }
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(sifre.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(sifre.Text);
            button2.Enabled = false;
        }

        private void secilenikopyala_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(listBox1.SelectedItem.ToString());
            secilenikopyala.Enabled = false;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e) //sadece sayı girişi
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            secilenikopyala.Enabled = true;
        }
    }
}