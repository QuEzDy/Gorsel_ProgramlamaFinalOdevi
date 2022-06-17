namespace Final.Formlar
{
    partial class ArabaFormu
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
            this.components = new System.ComponentModel.Container();
            this.İptalButonu = new System.Windows.Forms.Button();
            this.txtaciklama = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtarabamodel = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtarabamarka = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtarabaID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbsehir = new System.Windows.Forms.ComboBox();
            this.nmparabafiyat = new System.Windows.Forms.NumericUpDown();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nmparabafiyat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // İptalButonu
            // 
            this.İptalButonu.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.İptalButonu.Location = new System.Drawing.Point(198, 311);
            this.İptalButonu.Name = "İptalButonu";
            this.İptalButonu.Size = new System.Drawing.Size(70, 41);
            this.İptalButonu.TabIndex = 8;
            this.İptalButonu.Text = "İptal";
            this.İptalButonu.UseVisualStyleBackColor = true;
            this.İptalButonu.Click += new System.EventHandler(this.İptalButonu_Click);
            // 
            // txtaciklama
            // 
            this.txtaciklama.Location = new System.Drawing.Point(75, 184);
            this.txtaciklama.Multiline = true;
            this.txtaciklama.Name = "txtaciklama";
            this.txtaciklama.Size = new System.Drawing.Size(193, 102);
            this.txtaciklama.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 166);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Şehir";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Yil";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Fiyat";
            // 
            // txtarabamodel
            // 
            this.txtarabamodel.Location = new System.Drawing.Point(75, 76);
            this.txtarabamodel.Name = "txtarabamodel";
            this.txtarabamodel.Size = new System.Drawing.Size(193, 20);
            this.txtarabamodel.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Model";
            // 
            // txtarabamarka
            // 
            this.txtarabamarka.Location = new System.Drawing.Point(75, 50);
            this.txtarabamarka.Name = "txtarabamarka";
            this.txtarabamarka.Size = new System.Drawing.Size(193, 20);
            this.txtarabamarka.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Marka";
            // 
            // txtarabaID
            // 
            this.txtarabaID.Location = new System.Drawing.Point(75, 24);
            this.txtarabaID.Name = "txtarabaID";
            this.txtarabaID.ReadOnly = true;
            this.txtarabaID.Size = new System.Drawing.Size(193, 20);
            this.txtarabaID.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "ID";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 206);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "Açıklama";
            // 
            // cbsehir
            // 
            this.cbsehir.FormattingEnabled = true;
            this.cbsehir.Items.AddRange(new object[] {
            "Adana",
            " Adıyaman",
            " Afyonkarahisar",
            " Ağrı",
            " Aksaray",
            " Amasya",
            " Ankara",
            " Antalya",
            " Ardahan",
            " Artvin",
            " Aydın",
            " Balıkesir",
            " Bartın",
            " Batman",
            " Bayburt",
            " Bilecik",
            " Bingöl",
            " Bitlis",
            " Bolu",
            " Burdur",
            " Bursa",
            " Çanakkale",
            " Çankırı",
            " Çorum",
            " Denizli",
            " Diyarbakır",
            " Düzce",
            " Edirne",
            " Elazığ",
            " Erzincan",
            " Erzurum",
            " Eskişehir",
            " Gaziantep",
            " Giresun",
            " Gümüşhane",
            " Hakkâri",
            " Hatay",
            " Iğdır",
            " Isparta",
            " İstanbul",
            " İzmir",
            " Kahramanmaraş",
            " Karabük",
            " Karaman",
            " Kars",
            " Kastamonu",
            " Kayseri",
            " Kilis",
            " Kırıkkale",
            " Kırklareli",
            " Kırşehir",
            " Kocaeli",
            " Konya",
            " Kütahya",
            " Malatya",
            " Manisa",
            " Mardin",
            " Mersin",
            " Muğla",
            " Muş",
            " Nevşehir",
            " Niğde",
            " Ordu",
            " Osmaniye",
            " Rize",
            " Sakarya",
            " Samsun",
            " Şanlıurfa",
            " Siirt",
            " Sinop",
            " Sivas",
            " Şırnak",
            " Tekirdağ",
            " Tokat",
            " Trabzon",
            " Tunceli",
            " Uşak",
            " Van",
            " Yalova",
            " Yozgat",
            " Zonguldak"});
            this.cbsehir.Location = new System.Drawing.Point(75, 157);
            this.cbsehir.Name = "cbsehir";
            this.cbsehir.Size = new System.Drawing.Size(193, 21);
            this.cbsehir.TabIndex = 5;
            // 
            // nmparabafiyat
            // 
            this.nmparabafiyat.Location = new System.Drawing.Point(75, 102);
            this.nmparabafiyat.Maximum = new decimal(new int[] {
            -1530494976,
            232830,
            0,
            0});
            this.nmparabafiyat.Name = "nmparabafiyat";
            this.nmparabafiyat.Size = new System.Drawing.Size(193, 20);
            this.nmparabafiyat.TabIndex = 3;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(75, 131);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(193, 20);
            this.dateTimePicker1.TabIndex = 23;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(123, 311);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(69, 41);
            this.button1.TabIndex = 24;
            this.button1.Text = "Tamam";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ArabaFormu
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.İptalButonu;
            this.ClientSize = new System.Drawing.Size(302, 364);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.nmparabafiyat);
            this.Controls.Add(this.cbsehir);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.İptalButonu);
            this.Controls.Add(this.txtaciklama);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtarabamodel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtarabamarka);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtarabaID);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ArabaFormu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ArabaFormu";
            this.Load += new System.EventHandler(this.ArabaFormu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nmparabafiyat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button İptalButonu;
        private System.Windows.Forms.TextBox txtaciklama;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtarabamodel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtarabamarka;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtarabaID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbsehir;
        private System.Windows.Forms.NumericUpDown nmparabafiyat;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button1;
    }
}