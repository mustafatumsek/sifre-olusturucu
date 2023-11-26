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
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox3 = new CheckBox();
            button1 = new Button();
            sifre = new TextBox();
            listBox1 = new ListBox();
            button2 = new Button();
            label3 = new Label();
            button3 = new Button();
            secilenikopyala = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Montserrat Light", 27.7499962F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(-1, 47);
            label1.Name = "label1";
            label1.Size = new Size(436, 86);
            label1.TabIndex = 0;
            label1.Text = "Şifre Oluşturucu";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Montserrat", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(113, 153);
            label2.Name = "label2";
            label2.Size = new Size(123, 26);
            label2.TabIndex = 1;
            label2.Text = "Hane Sayısı:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(242, 156);
            textBox1.MaxLength = 2;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(56, 23);
            textBox1.TabIndex = 2;
            textBox1.KeyPress += textBox1_KeyPress;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Montserrat", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox1.Location = new Point(27, 243);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(132, 25);
            checkBox1.TabIndex = 3;
            checkBox1.Text = "Büyük Harfler";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Font = new Font("Montserrat", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox2.Location = new Point(303, 243);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(102, 25);
            checkBox2.TabIndex = 4;
            checkBox2.Text = "Rakamlar";
            checkBox2.UseVisualStyleBackColor = true;
            checkBox2.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Font = new Font("Montserrat", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox3.Location = new Point(165, 243);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(132, 25);
            checkBox3.TabIndex = 5;
            checkBox3.Text = "Küçük Harfler";
            checkBox3.UseVisualStyleBackColor = true;
            checkBox3.CheckedChanged += checkBox3_CheckedChanged;
            // 
            // button1
            // 
            button1.Enabled = false;
            button1.Location = new Point(39, 329);
            button1.Name = "button1";
            button1.Size = new Size(110, 50);
            button1.TabIndex = 6;
            button1.Text = "Oluştur";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // sifre
            // 
            sifre.Location = new Point(177, 329);
            sifre.MaxLength = 99;
            sifre.Name = "sifre";
            sifre.ReadOnly = true;
            sifre.Size = new Size(210, 23);
            sifre.TabIndex = 7;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(177, 365);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(210, 184);
            listBox1.TabIndex = 8;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // button2
            // 
            button2.Enabled = false;
            button2.Location = new Point(39, 445);
            button2.Name = "button2";
            button2.Size = new Size(110, 50);
            button2.TabIndex = 9;
            button2.Text = "Kaydet";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label3
            // 
            label3.ForeColor = Color.DarkRed;
            label3.Location = new Point(-1, 203);
            label3.Name = "label3";
            label3.Size = new Size(436, 23);
            label3.TabIndex = 10;
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // button3
            // 
            button3.Enabled = false;
            button3.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(39, 385);
            button3.Name = "button3";
            button3.Size = new Size(110, 48);
            button3.TabIndex = 11;
            button3.Text = "Kopyala";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // secilenikopyala
            // 
            secilenikopyala.Enabled = false;
            secilenikopyala.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            secilenikopyala.Location = new Point(39, 501);
            secilenikopyala.Name = "secilenikopyala";
            secilenikopyala.Size = new Size(110, 48);
            secilenikopyala.TabIndex = 12;
            secilenikopyala.Text = "Seçileni Kopyala";
            secilenikopyala.UseVisualStyleBackColor = true;
            secilenikopyala.Click += secilenikopyala_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(434, 573);
            Controls.Add(secilenikopyala);
            Controls.Add(button3);
            Controls.Add(label3);
            Controls.Add(button2);
            Controls.Add(listBox1);
            Controls.Add(sifre);
            Controls.Add(button1);
            Controls.Add(checkBox3);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
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
        private Button button1;
        private TextBox sifre;
        private ListBox listBox1;
        private Button button2;
        private Label label3;
        private Button button3;
        private Button secilenikopyala;
    }
}