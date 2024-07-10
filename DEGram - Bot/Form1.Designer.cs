namespace DEGram___Bot
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
            this.hesapeklebtn = new System.Windows.Forms.Button();
            this.sifrekayitTxtBox = new System.Windows.Forms.TextBox();
            this.kullaniciadikayitTxtBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cooldownNumUpDown = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.previewPhotoPictureBox = new System.Windows.Forms.PictureBox();
            this.button9 = new System.Windows.Forms.Button();
            this.startSharePostBtn = new System.Windows.Forms.Button();
            this.startProfileBtn = new System.Windows.Forms.Button();
            this.startHashtagBtn = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.postCountNumUpDown = new System.Windows.Forms.NumericUpDown();
            this.selectPictureBtn = new System.Windows.Forms.Button();
            this.selectPictureCombobox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.adTextSaveBtn = new System.Windows.Forms.Button();
            this.adTextCombobox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.usernameSaveBtn = new System.Windows.Forms.Button();
            this.hashtagSaveBtn = new System.Windows.Forms.Button();
            this.profileCombobox = new System.Windows.Forms.ComboBox();
            this.hashtagCombobox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.loginBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.accountsComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cooldownNumUpDown)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.previewPhotoPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.postCountNumUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.hesapeklebtn);
            this.groupBox1.Controls.Add(this.sifrekayitTxtBox);
            this.groupBox1.Controls.Add(this.kullaniciadikayitTxtBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(400, 128);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hesap Ekle";
            // 
            // hesapeklebtn
            // 
            this.hesapeklebtn.Location = new System.Drawing.Point(6, 92);
            this.hesapeklebtn.Name = "hesapeklebtn";
            this.hesapeklebtn.Size = new System.Drawing.Size(383, 32);
            this.hesapeklebtn.TabIndex = 1;
            this.hesapeklebtn.Text = "Hesap ekle";
            this.hesapeklebtn.UseVisualStyleBackColor = true;
            this.hesapeklebtn.Click += new System.EventHandler(this.hesapeklebtn_Click);
            // 
            // sifrekayitTxtBox
            // 
            this.sifrekayitTxtBox.Location = new System.Drawing.Point(91, 64);
            this.sifrekayitTxtBox.Name = "sifrekayitTxtBox";
            this.sifrekayitTxtBox.PasswordChar = '*';
            this.sifrekayitTxtBox.Size = new System.Drawing.Size(298, 22);
            this.sifrekayitTxtBox.TabIndex = 2;
            // 
            // kullaniciadikayitTxtBox
            // 
            this.kullaniciadikayitTxtBox.Location = new System.Drawing.Point(91, 36);
            this.kullaniciadikayitTxtBox.Name = "kullaniciadikayitTxtBox";
            this.kullaniciadikayitTxtBox.Size = new System.Drawing.Size(298, 22);
            this.kullaniciadikayitTxtBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Şifre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kullanıcı Adı";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cooldownNumUpDown);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.button9);
            this.groupBox2.Controls.Add(this.startSharePostBtn);
            this.groupBox2.Controls.Add(this.startProfileBtn);
            this.groupBox2.Controls.Add(this.startHashtagBtn);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.postCountNumUpDown);
            this.groupBox2.Controls.Add(this.selectPictureBtn);
            this.groupBox2.Controls.Add(this.selectPictureCombobox);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.adTextSaveBtn);
            this.groupBox2.Controls.Add(this.adTextCombobox);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.usernameSaveBtn);
            this.groupBox2.Controls.Add(this.hashtagSaveBtn);
            this.groupBox2.Controls.Add(this.profileCombobox);
            this.groupBox2.Controls.Add(this.hashtagCombobox);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.loginBtn);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.accountsComboBox);
            this.groupBox2.Location = new System.Drawing.Point(12, 146);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(400, 611);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Bot";
            // 
            // cooldownNumUpDown
            // 
            this.cooldownNumUpDown.Location = new System.Drawing.Point(204, 207);
            this.cooldownNumUpDown.Name = "cooldownNumUpDown";
            this.cooldownNumUpDown.Size = new System.Drawing.Size(190, 22);
            this.cooldownNumUpDown.TabIndex = 21;
            this.cooldownNumUpDown.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 210);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(180, 16);
            this.label9.TabIndex = 20;
            this.label9.Text = "Cooldown (Saniye cinsinden)";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.previewPhotoPictureBox);
            this.groupBox3.Location = new System.Drawing.Point(6, 364);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(388, 238);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Fotoğraf önizleme";
            // 
            // previewPhotoPictureBox
            // 
            this.previewPhotoPictureBox.Location = new System.Drawing.Point(6, 22);
            this.previewPhotoPictureBox.Name = "previewPhotoPictureBox";
            this.previewPhotoPictureBox.Size = new System.Drawing.Size(376, 210);
            this.previewPhotoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.previewPhotoPictureBox.TabIndex = 0;
            this.previewPhotoPictureBox.TabStop = false;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(300, 268);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(90, 90);
            this.button9.TabIndex = 17;
            this.button9.UseVisualStyleBackColor = true;
            // 
            // startSharePostBtn
            // 
            this.startSharePostBtn.Location = new System.Drawing.Point(204, 268);
            this.startSharePostBtn.Name = "startSharePostBtn";
            this.startSharePostBtn.Size = new System.Drawing.Size(90, 90);
            this.startSharePostBtn.TabIndex = 16;
            this.startSharePostBtn.Text = "Resim Paylaş";
            this.startSharePostBtn.UseVisualStyleBackColor = true;
            this.startSharePostBtn.Click += new System.EventHandler(this.startSharePostBtn_Click);
            // 
            // startProfileBtn
            // 
            this.startProfileBtn.Location = new System.Drawing.Point(108, 268);
            this.startProfileBtn.Name = "startProfileBtn";
            this.startProfileBtn.Size = new System.Drawing.Size(90, 90);
            this.startProfileBtn.TabIndex = 15;
            this.startProfileBtn.Text = "Profil Reklam";
            this.startProfileBtn.UseVisualStyleBackColor = true;
            this.startProfileBtn.Click += new System.EventHandler(this.startProfileBtn_Click);
            // 
            // startHashtagBtn
            // 
            this.startHashtagBtn.Location = new System.Drawing.Point(12, 268);
            this.startHashtagBtn.Name = "startHashtagBtn";
            this.startHashtagBtn.Size = new System.Drawing.Size(90, 90);
            this.startHashtagBtn.TabIndex = 2;
            this.startHashtagBtn.Text = "Hashtag Reklam";
            this.startHashtagBtn.UseVisualStyleBackColor = true;
            this.startHashtagBtn.Click += new System.EventHandler(this.startHashtagBtn_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 181);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 16);
            this.label8.TabIndex = 14;
            this.label8.Text = "Post Sayısı";
            // 
            // postCountNumUpDown
            // 
            this.postCountNumUpDown.Location = new System.Drawing.Point(89, 179);
            this.postCountNumUpDown.Name = "postCountNumUpDown";
            this.postCountNumUpDown.Size = new System.Drawing.Size(305, 22);
            this.postCountNumUpDown.TabIndex = 13;
            this.postCountNumUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // selectPictureBtn
            // 
            this.selectPictureBtn.Location = new System.Drawing.Point(317, 148);
            this.selectPictureBtn.Name = "selectPictureBtn";
            this.selectPictureBtn.Size = new System.Drawing.Size(78, 24);
            this.selectPictureBtn.TabIndex = 12;
            this.selectPictureBtn.Text = "Seç";
            this.selectPictureBtn.UseVisualStyleBackColor = true;
            this.selectPictureBtn.Click += new System.EventHandler(this.selectPictureBtn_Click);
            // 
            // selectPictureCombobox
            // 
            this.selectPictureCombobox.FormattingEnabled = true;
            this.selectPictureCombobox.Location = new System.Drawing.Point(70, 149);
            this.selectPictureCombobox.Name = "selectPictureCombobox";
            this.selectPictureCombobox.Size = new System.Drawing.Size(241, 24);
            this.selectPictureCombobox.TabIndex = 11;
            this.selectPictureCombobox.SelectedIndexChanged += new System.EventHandler(this.selectPictureCombobox_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 152);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 16);
            this.label7.TabIndex = 10;
            this.label7.Text = "Fotoğraf";
            // 
            // adTextSaveBtn
            // 
            this.adTextSaveBtn.Location = new System.Drawing.Point(317, 119);
            this.adTextSaveBtn.Name = "adTextSaveBtn";
            this.adTextSaveBtn.Size = new System.Drawing.Size(78, 24);
            this.adTextSaveBtn.TabIndex = 9;
            this.adTextSaveBtn.Text = "Kaydet";
            this.adTextSaveBtn.UseVisualStyleBackColor = true;
            this.adTextSaveBtn.Click += new System.EventHandler(this.adTextSaveBtn_Click);
            // 
            // adTextCombobox
            // 
            this.adTextCombobox.FormattingEnabled = true;
            this.adTextCombobox.Location = new System.Drawing.Point(97, 119);
            this.adTextCombobox.Name = "adTextCombobox";
            this.adTextCombobox.Size = new System.Drawing.Size(214, 24);
            this.adTextCombobox.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 16);
            this.label6.TabIndex = 7;
            this.label6.Text = "Tanıtım yazısı";
            // 
            // usernameSaveBtn
            // 
            this.usernameSaveBtn.Location = new System.Drawing.Point(317, 90);
            this.usernameSaveBtn.Name = "usernameSaveBtn";
            this.usernameSaveBtn.Size = new System.Drawing.Size(78, 24);
            this.usernameSaveBtn.TabIndex = 6;
            this.usernameSaveBtn.Text = "Kaydet";
            this.usernameSaveBtn.UseVisualStyleBackColor = true;
            this.usernameSaveBtn.Click += new System.EventHandler(this.usernameSaveBtn_Click);
            // 
            // hashtagSaveBtn
            // 
            this.hashtagSaveBtn.Location = new System.Drawing.Point(317, 63);
            this.hashtagSaveBtn.Name = "hashtagSaveBtn";
            this.hashtagSaveBtn.Size = new System.Drawing.Size(78, 24);
            this.hashtagSaveBtn.TabIndex = 5;
            this.hashtagSaveBtn.Text = "Kaydet";
            this.hashtagSaveBtn.UseVisualStyleBackColor = true;
            this.hashtagSaveBtn.Click += new System.EventHandler(this.hashtagSaveBtn_Click);
            // 
            // profileCombobox
            // 
            this.profileCombobox.FormattingEnabled = true;
            this.profileCombobox.Location = new System.Drawing.Point(127, 90);
            this.profileCombobox.Name = "profileCombobox";
            this.profileCombobox.Size = new System.Drawing.Size(184, 24);
            this.profileCombobox.TabIndex = 4;
            // 
            // hashtagCombobox
            // 
            this.hashtagCombobox.FormattingEnabled = true;
            this.hashtagCombobox.Location = new System.Drawing.Point(141, 63);
            this.hashtagCombobox.Name = "hashtagCombobox";
            this.hashtagCombobox.Size = new System.Drawing.Size(170, 24);
            this.hashtagCombobox.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "Profil (@ olmadan)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Hashtag (# olmadan)";
            // 
            // loginBtn
            // 
            this.loginBtn.Enabled = false;
            this.loginBtn.Location = new System.Drawing.Point(6, 235);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(388, 27);
            this.loginBtn.TabIndex = 2;
            this.loginBtn.Text = "Login";
            this.loginBtn.UseVisualStyleBackColor = true;
            this.loginBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Hesaplar";
            // 
            // accountsComboBox
            // 
            this.accountsComboBox.FormattingEnabled = true;
            this.accountsComboBox.Location = new System.Drawing.Point(72, 33);
            this.accountsComboBox.Name = "accountsComboBox";
            this.accountsComboBox.Size = new System.Drawing.Size(239, 24);
            this.accountsComboBox.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 769);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Text = "DEGram - Bot";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cooldownNumUpDown)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.previewPhotoPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.postCountNumUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button hesapeklebtn;
        private System.Windows.Forms.TextBox sifrekayitTxtBox;
        private System.Windows.Forms.TextBox kullaniciadikayitTxtBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox accountsComboBox;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button selectPictureBtn;
        private System.Windows.Forms.ComboBox selectPictureCombobox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button adTextSaveBtn;
        private System.Windows.Forms.ComboBox adTextCombobox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button usernameSaveBtn;
        private System.Windows.Forms.Button hashtagSaveBtn;
        private System.Windows.Forms.ComboBox profileCombobox;
        private System.Windows.Forms.ComboBox hashtagCombobox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown postCountNumUpDown;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button startSharePostBtn;
        private System.Windows.Forms.Button startProfileBtn;
        private System.Windows.Forms.Button startHashtagBtn;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.PictureBox previewPhotoPictureBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown cooldownNumUpDown;
    }
}

