namespace Final.Formlar
{
    partial class OdemeFormu
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
            this.nmpfiyat = new System.Windows.Forms.NumericUpDown();
            this.İptalButonu = new System.Windows.Forms.Button();
            this.Tamambutonu = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMusteri = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtptarih = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.txtaciklama = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbtur = new System.Windows.Forms.ComboBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.musterisec = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nmpfiyat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // nmpfiyat
            // 
            this.nmpfiyat.Location = new System.Drawing.Point(100, 87);
            this.nmpfiyat.Maximum = new decimal(new int[] {
            -1530494976,
            232830,
            0,
            0});
            this.nmpfiyat.Name = "nmpfiyat";
            this.nmpfiyat.Size = new System.Drawing.Size(193, 20);
            this.nmpfiyat.TabIndex = 2;
            // 
            // İptalButonu
            // 
            this.İptalButonu.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.İptalButonu.Location = new System.Drawing.Point(223, 298);
            this.İptalButonu.Name = "İptalButonu";
            this.İptalButonu.Size = new System.Drawing.Size(70, 41);
            this.İptalButonu.TabIndex = 7;
            this.İptalButonu.Text = "İptal";
            this.İptalButonu.UseVisualStyleBackColor = true;
            this.İptalButonu.Click += new System.EventHandler(this.İptalButonu_Click);
            // 
            // Tamambutonu
            // 
            this.Tamambutonu.Location = new System.Drawing.Point(100, 298);
            this.Tamambutonu.Name = "Tamambutonu";
            this.Tamambutonu.Size = new System.Drawing.Size(68, 41);
            this.Tamambutonu.TabIndex = 6;
            this.Tamambutonu.Text = "Tamam";
            this.Tamambutonu.UseVisualStyleBackColor = true;
            this.Tamambutonu.Click += new System.EventHandler(this.Tamambutonu_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(69, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 13);
            this.label5.TabIndex = 45;
            this.label5.Text = "Yil";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 46;
            this.label4.Text = "Fiyat";
            // 
            // txtMusteri
            // 
            this.txtMusteri.Location = new System.Drawing.Point(100, 54);
            this.txtMusteri.Name = "txtMusteri";
            this.txtMusteri.Size = new System.Drawing.Size(193, 20);
            this.txtMusteri.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 48;
            this.label2.Text = "Müşteri";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(100, 28);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(193, 20);
            this.txtID.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 49;
            this.label1.Text = "ID";
            // 
            // dtptarih
            // 
            this.dtptarih.Location = new System.Drawing.Point(100, 120);
            this.dtptarih.Name = "dtptarih";
            this.dtptarih.Size = new System.Drawing.Size(193, 20);
            this.dtptarih.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(37, 199);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 52;
            this.label7.Text = "Açıklama";
            // 
            // txtaciklama
            // 
            this.txtaciklama.Location = new System.Drawing.Point(100, 179);
            this.txtaciklama.Multiline = true;
            this.txtaciklama.Name = "txtaciklama";
            this.txtaciklama.Size = new System.Drawing.Size(193, 102);
            this.txtaciklama.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 53;
            this.label3.Text = "Ödeme Türü";
            // 
            // cbtur
            // 
            this.cbtur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbtur.FormattingEnabled = true;
            this.cbtur.Items.AddRange(new object[] {
            "Nakit",
            "Kredi Kartı",
            "Banka Kartı"});
            this.cbtur.Location = new System.Drawing.Point(100, 153);
            this.cbtur.Name = "cbtur";
            this.cbtur.Size = new System.Drawing.Size(193, 21);
            this.cbtur.TabIndex = 4;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // musterisec
            // 
            this.musterisec.Location = new System.Drawing.Point(310, 55);
            this.musterisec.Name = "musterisec";
            this.musterisec.Size = new System.Drawing.Size(73, 20);
            this.musterisec.TabIndex = 54;
            this.musterisec.Text = "Musteri Seç";
            this.musterisec.UseVisualStyleBackColor = true;
            this.musterisec.Click += new System.EventHandler(this.musterisec_Click);
            // 
            // OdemeFormu
            // 
            this.AcceptButton = this.Tamambutonu;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.İptalButonu;
            this.ClientSize = new System.Drawing.Size(409, 354);
            this.Controls.Add(this.musterisec);
            this.Controls.Add(this.cbtur);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtaciklama);
            this.Controls.Add(this.dtptarih);
            this.Controls.Add(this.nmpfiyat);
            this.Controls.Add(this.İptalButonu);
            this.Controls.Add(this.Tamambutonu);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMusteri);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "OdemeFormu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "OdemeFormu";
            this.Load += new System.EventHandler(this.OdemeFormu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nmpfiyat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nmpfiyat;
        private System.Windows.Forms.Button İptalButonu;
        private System.Windows.Forms.Button Tamambutonu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMusteri;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtptarih;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtaciklama;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbtur;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button musterisec;
    }
}