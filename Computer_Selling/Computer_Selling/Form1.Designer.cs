namespace Computer_Selling
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbCpuR3 = new System.Windows.Forms.RadioButton();
            this.rbCpuR5 = new System.Windows.Forms.RadioButton();
            this.rbCpui3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.rbCpui5 = new System.Windows.Forms.RadioButton();
            this.rbCpui7 = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbGtx1060 = new System.Windows.Forms.RadioButton();
            this.rbRx6600 = new System.Windows.Forms.RadioButton();
            this.rbRtx3050 = new System.Windows.Forms.RadioButton();
            this.rbRtx3070 = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rbB550 = new System.Windows.Forms.RadioButton();
            this.rbA320 = new System.Windows.Forms.RadioButton();
            this.rbB450 = new System.Windows.Forms.RadioButton();
            this.rbA520m = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rb8gb = new System.Windows.Forms.RadioButton();
            this.rb32gb = new System.Windows.Forms.RadioButton();
            this.rb16gb = new System.Windows.Forms.RadioButton();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.rb320gb = new System.Windows.Forms.RadioButton();
            this.rb500gb = new System.Windows.Forms.RadioButton();
            this.rb1tb = new System.Windows.Forms.RadioButton();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbCpuR3);
            this.groupBox1.Controls.Add(this.rbCpuR5);
            this.groupBox1.Controls.Add(this.rbCpui3);
            this.groupBox1.Controls.Add(this.radioButton4);
            this.groupBox1.Controls.Add(this.rbCpui5);
            this.groupBox1.Controls.Add(this.rbCpui7);
            this.groupBox1.Location = new System.Drawing.Point(31, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 140);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "İşlemci";
            // 
            // rbCpuR3
            // 
            this.rbCpuR3.AutoSize = true;
            this.rbCpuR3.Location = new System.Drawing.Point(7, 112);
            this.rbCpuR3.Name = "rbCpuR3";
            this.rbCpuR3.Size = new System.Drawing.Size(64, 17);
            this.rbCpuR3.TabIndex = 0;
            this.rbCpuR3.TabStop = true;
            this.rbCpuR3.Text = "Ryzen 3";
            this.rbCpuR3.UseVisualStyleBackColor = true;
            // 
            // rbCpuR5
            // 
            this.rbCpuR5.AutoSize = true;
            this.rbCpuR5.Location = new System.Drawing.Point(7, 89);
            this.rbCpuR5.Name = "rbCpuR5";
            this.rbCpuR5.Size = new System.Drawing.Size(67, 17);
            this.rbCpuR5.TabIndex = 0;
            this.rbCpuR5.TabStop = true;
            this.rbCpuR5.Text = "Ryzen 5 ";
            this.rbCpuR5.UseVisualStyleBackColor = true;
            // 
            // rbCpui3
            // 
            this.rbCpui3.AutoSize = true;
            this.rbCpui3.Location = new System.Drawing.Point(7, 66);
            this.rbCpui3.Name = "rbCpui3";
            this.rbCpui3.Size = new System.Drawing.Size(81, 17);
            this.rbCpui3.TabIndex = 0;
            this.rbCpui3.TabStop = true;
            this.rbCpui3.Text = "İntel Core i3";
            this.rbCpui3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(7, 66);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(85, 17);
            this.radioButton4.TabIndex = 0;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "radioButton1";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // rbCpui5
            // 
            this.rbCpui5.AutoSize = true;
            this.rbCpui5.Location = new System.Drawing.Point(7, 43);
            this.rbCpui5.Name = "rbCpui5";
            this.rbCpui5.Size = new System.Drawing.Size(81, 17);
            this.rbCpui5.TabIndex = 0;
            this.rbCpui5.TabStop = true;
            this.rbCpui5.Text = "İntel Core i5";
            this.rbCpui5.UseVisualStyleBackColor = true;
            // 
            // rbCpui7
            // 
            this.rbCpui7.AutoSize = true;
            this.rbCpui7.Location = new System.Drawing.Point(7, 20);
            this.rbCpui7.Name = "rbCpui7";
            this.rbCpui7.Size = new System.Drawing.Size(81, 17);
            this.rbCpui7.TabIndex = 0;
            this.rbCpui7.TabStop = true;
            this.rbCpui7.Text = "İntel Core i7";
            this.rbCpui7.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbGtx1060);
            this.groupBox2.Controls.Add(this.rbRx6600);
            this.groupBox2.Controls.Add(this.rbRtx3050);
            this.groupBox2.Controls.Add(this.rbRtx3070);
            this.groupBox2.Location = new System.Drawing.Point(261, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(187, 129);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ekran Kartı";
            // 
            // rbGtx1060
            // 
            this.rbGtx1060.AutoSize = true;
            this.rbGtx1060.Location = new System.Drawing.Point(6, 89);
            this.rbGtx1060.Name = "rbGtx1060";
            this.rbGtx1060.Size = new System.Drawing.Size(68, 17);
            this.rbGtx1060.TabIndex = 0;
            this.rbGtx1060.TabStop = true;
            this.rbGtx1060.Text = "Gtx 1060";
            this.rbGtx1060.UseVisualStyleBackColor = true;
            // 
            // rbRx6600
            // 
            this.rbRx6600.AutoSize = true;
            this.rbRx6600.Location = new System.Drawing.Point(6, 66);
            this.rbRx6600.Name = "rbRx6600";
            this.rbRx6600.Size = new System.Drawing.Size(65, 17);
            this.rbRx6600.TabIndex = 0;
            this.rbRx6600.TabStop = true;
            this.rbRx6600.Text = "Rx 6600";
            this.rbRx6600.UseVisualStyleBackColor = true;
            // 
            // rbRtx3050
            // 
            this.rbRtx3050.AutoSize = true;
            this.rbRtx3050.Location = new System.Drawing.Point(6, 43);
            this.rbRtx3050.Name = "rbRtx3050";
            this.rbRtx3050.Size = new System.Drawing.Size(68, 17);
            this.rbRtx3050.TabIndex = 0;
            this.rbRtx3050.TabStop = true;
            this.rbRtx3050.Text = "Rtx 3050";
            this.rbRtx3050.UseVisualStyleBackColor = true;
            // 
            // rbRtx3070
            // 
            this.rbRtx3070.AutoSize = true;
            this.rbRtx3070.Location = new System.Drawing.Point(6, 20);
            this.rbRtx3070.Name = "rbRtx3070";
            this.rbRtx3070.Size = new System.Drawing.Size(68, 17);
            this.rbRtx3070.TabIndex = 0;
            this.rbRtx3070.TabStop = true;
            this.rbRtx3070.Text = "Rtx 3070";
            this.rbRtx3070.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rbB550);
            this.groupBox3.Controls.Add(this.rbA320);
            this.groupBox3.Controls.Add(this.rbB450);
            this.groupBox3.Controls.Add(this.rbA520m);
            this.groupBox3.Location = new System.Drawing.Point(485, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(98, 123);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Anakart";
            // 
            // rbB550
            // 
            this.rbB550.AutoSize = true;
            this.rbB550.Location = new System.Drawing.Point(6, 19);
            this.rbB550.Name = "rbB550";
            this.rbB550.Size = new System.Drawing.Size(50, 17);
            this.rbB550.TabIndex = 0;
            this.rbB550.TabStop = true;
            this.rbB550.Text = "B550";
            this.rbB550.UseVisualStyleBackColor = true;
            // 
            // rbA320
            // 
            this.rbA320.AutoSize = true;
            this.rbA320.Location = new System.Drawing.Point(6, 65);
            this.rbA320.Name = "rbA320";
            this.rbA320.Size = new System.Drawing.Size(50, 17);
            this.rbA320.TabIndex = 0;
            this.rbA320.TabStop = true;
            this.rbA320.Text = "A320";
            this.rbA320.UseVisualStyleBackColor = true;
            // 
            // rbB450
            // 
            this.rbB450.AutoSize = true;
            this.rbB450.Location = new System.Drawing.Point(6, 42);
            this.rbB450.Name = "rbB450";
            this.rbB450.Size = new System.Drawing.Size(50, 17);
            this.rbB450.TabIndex = 0;
            this.rbB450.TabStop = true;
            this.rbB450.Text = "B450";
            this.rbB450.UseVisualStyleBackColor = true;
            // 
            // rbA520m
            // 
            this.rbA520m.AutoSize = true;
            this.rbA520m.Location = new System.Drawing.Point(6, 88);
            this.rbA520m.Name = "rbA520m";
            this.rbA520m.Size = new System.Drawing.Size(59, 17);
            this.rbA520m.TabIndex = 0;
            this.rbA520m.TabStop = true;
            this.rbA520m.Text = "A520M";
            this.rbA520m.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rb8gb);
            this.groupBox4.Controls.Add(this.rb32gb);
            this.groupBox4.Controls.Add(this.rb16gb);
            this.groupBox4.Location = new System.Drawing.Point(31, 162);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(158, 100);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Ram Bellek";
            // 
            // rb8gb
            // 
            this.rb8gb.AutoSize = true;
            this.rb8gb.Location = new System.Drawing.Point(6, 65);
            this.rb8gb.Name = "rb8gb";
            this.rb8gb.Size = new System.Drawing.Size(49, 17);
            this.rb8gb.TabIndex = 0;
            this.rb8gb.TabStop = true;
            this.rb8gb.Text = "8 GB";
            this.rb8gb.UseVisualStyleBackColor = true;
            // 
            // rb32gb
            // 
            this.rb32gb.AutoSize = true;
            this.rb32gb.Location = new System.Drawing.Point(6, 19);
            this.rb32gb.Name = "rb32gb";
            this.rb32gb.Size = new System.Drawing.Size(55, 17);
            this.rb32gb.TabIndex = 0;
            this.rb32gb.TabStop = true;
            this.rb32gb.Text = "32 GB";
            this.rb32gb.UseVisualStyleBackColor = true;
            // 
            // rb16gb
            // 
            this.rb16gb.AutoSize = true;
            this.rb16gb.Location = new System.Drawing.Point(6, 42);
            this.rb16gb.Name = "rb16gb";
            this.rb16gb.Size = new System.Drawing.Size(55, 17);
            this.rb16gb.TabIndex = 0;
            this.rb16gb.TabStop = true;
            this.rb16gb.Text = "16 GB";
            this.rb16gb.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.rb320gb);
            this.groupBox5.Controls.Add(this.rb500gb);
            this.groupBox5.Controls.Add(this.rb1tb);
            this.groupBox5.Location = new System.Drawing.Point(227, 162);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(162, 100);
            this.groupBox5.TabIndex = 0;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Sabit Disk";
            // 
            // rb320gb
            // 
            this.rb320gb.AutoSize = true;
            this.rb320gb.Location = new System.Drawing.Point(6, 65);
            this.rb320gb.Name = "rb320gb";
            this.rb320gb.Size = new System.Drawing.Size(61, 17);
            this.rb320gb.TabIndex = 0;
            this.rb320gb.TabStop = true;
            this.rb320gb.Text = "320 GB";
            this.rb320gb.UseVisualStyleBackColor = true;
            // 
            // rb500gb
            // 
            this.rb500gb.AutoSize = true;
            this.rb500gb.Location = new System.Drawing.Point(6, 42);
            this.rb500gb.Name = "rb500gb";
            this.rb500gb.Size = new System.Drawing.Size(61, 17);
            this.rb500gb.TabIndex = 0;
            this.rb500gb.TabStop = true;
            this.rb500gb.Text = "500 GB";
            this.rb500gb.UseVisualStyleBackColor = true;
            // 
            // rb1tb
            // 
            this.rb1tb.AutoSize = true;
            this.rb1tb.Location = new System.Drawing.Point(6, 19);
            this.rb1tb.Name = "rb1tb";
            this.rb1tb.Size = new System.Drawing.Size(48, 17);
            this.rb1tb.TabIndex = 0;
            this.rb1tb.TabStop = true;
            this.rb1tb.Text = "1 TB";
            this.rb1tb.UseVisualStyleBackColor = true;
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(415, 185);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(181, 84);
            this.btnHesapla.TabIndex = 1;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(488, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(589, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Geri";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 293);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Parça Toplama";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbCpui7;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.RadioButton rbCpuR5;
        private System.Windows.Forms.RadioButton rbCpui3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton rbCpui5;
        private System.Windows.Forms.RadioButton rbCpuR3;
        private System.Windows.Forms.RadioButton rbRtx3050;
        private System.Windows.Forms.RadioButton rbRtx3070;
        private System.Windows.Forms.RadioButton rbGtx1060;
        private System.Windows.Forms.RadioButton rbRx6600;
        private System.Windows.Forms.RadioButton rbB550;
        private System.Windows.Forms.RadioButton rbA320;
        private System.Windows.Forms.RadioButton rbB450;
        private System.Windows.Forms.RadioButton rbA520m;
        private System.Windows.Forms.RadioButton rb8gb;
        private System.Windows.Forms.RadioButton rb32gb;
        private System.Windows.Forms.RadioButton rb16gb;
        private System.Windows.Forms.RadioButton rb320gb;
        private System.Windows.Forms.RadioButton rb500gb;
        private System.Windows.Forms.RadioButton rb1tb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}

