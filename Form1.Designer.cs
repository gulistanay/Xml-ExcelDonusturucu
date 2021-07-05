namespace FormXmlKullanimi
{
    partial class Form1
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
            this.groupBoxIsDetay = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.IsSiraNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Detay1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Detay2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxIsDetayEkleDuzenle = new System.Windows.Forms.GroupBox();
            this.textBoxDetay3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSil = new System.Windows.Forms.Button();
            this.buttonDuzenle = new System.Windows.Forms.Button();
            this.buttonEkle = new System.Windows.Forms.Button();
            this.textBoxDetay2 = new System.Windows.Forms.TextBox();
            this.textBoxDetay1 = new System.Windows.Forms.TextBox();
            this.textBoxSiraNo = new System.Windows.Forms.TextBox();
            this.labelDetay2 = new System.Windows.Forms.Label();
            this.labelDetay1 = new System.Windows.Forms.Label();
            this.labelIsSiraNo = new System.Windows.Forms.Label();
            this.buttonExcelFormu = new System.Windows.Forms.Button();
            this.buttonXMLKaydet = new System.Windows.Forms.Button();
            this.buttonXMLAl = new System.Windows.Forms.Button();
            this.buttonXmlFormu = new System.Windows.Forms.Button();
            this.groupBoxIsDetay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBoxIsDetayEkleDuzenle.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxIsDetay
            // 
            this.groupBoxIsDetay.Controls.Add(this.dataGridView1);
            this.groupBoxIsDetay.Controls.Add(this.groupBoxIsDetayEkleDuzenle);
            this.groupBoxIsDetay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBoxIsDetay.Location = new System.Drawing.Point(16, 17);
            this.groupBoxIsDetay.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxIsDetay.Name = "groupBoxIsDetay";
            this.groupBoxIsDetay.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxIsDetay.Size = new System.Drawing.Size(723, 399);
            this.groupBoxIsDetay.TabIndex = 9;
            this.groupBoxIsDetay.TabStop = false;
            this.groupBoxIsDetay.Text = "Detaylar";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IsSiraNo,
            this.Detay1,
            this.Detay2});
            this.dataGridView1.Location = new System.Drawing.Point(24, 222);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(671, 155);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseClick);
            // 
            // IsSiraNo
            // 
            this.IsSiraNo.HeaderText = "İş Sıra No";
            this.IsSiraNo.MinimumWidth = 6;
            this.IsSiraNo.Name = "IsSiraNo";
            this.IsSiraNo.ReadOnly = true;
            this.IsSiraNo.Width = 125;
            // 
            // Detay1
            // 
            this.Detay1.HeaderText = "Detay 1";
            this.Detay1.MinimumWidth = 6;
            this.Detay1.Name = "Detay1";
            this.Detay1.ReadOnly = true;
            this.Detay1.Width = 180;
            // 
            // Detay2
            // 
            this.Detay2.HeaderText = "Detay 2";
            this.Detay2.MinimumWidth = 6;
            this.Detay2.Name = "Detay2";
            this.Detay2.ReadOnly = true;
            this.Detay2.Width = 180;
            // 
            // groupBoxIsDetayEkleDuzenle
            // 
            this.groupBoxIsDetayEkleDuzenle.Controls.Add(this.textBoxDetay3);
            this.groupBoxIsDetayEkleDuzenle.Controls.Add(this.label1);
            this.groupBoxIsDetayEkleDuzenle.Controls.Add(this.buttonSil);
            this.groupBoxIsDetayEkleDuzenle.Controls.Add(this.buttonDuzenle);
            this.groupBoxIsDetayEkleDuzenle.Controls.Add(this.buttonEkle);
            this.groupBoxIsDetayEkleDuzenle.Controls.Add(this.textBoxDetay2);
            this.groupBoxIsDetayEkleDuzenle.Controls.Add(this.textBoxDetay1);
            this.groupBoxIsDetayEkleDuzenle.Controls.Add(this.textBoxSiraNo);
            this.groupBoxIsDetayEkleDuzenle.Controls.Add(this.labelDetay2);
            this.groupBoxIsDetayEkleDuzenle.Controls.Add(this.labelDetay1);
            this.groupBoxIsDetayEkleDuzenle.Controls.Add(this.labelIsSiraNo);
            this.groupBoxIsDetayEkleDuzenle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBoxIsDetayEkleDuzenle.Location = new System.Drawing.Point(24, 31);
            this.groupBoxIsDetayEkleDuzenle.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxIsDetayEkleDuzenle.Name = "groupBoxIsDetayEkleDuzenle";
            this.groupBoxIsDetayEkleDuzenle.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxIsDetayEkleDuzenle.Size = new System.Drawing.Size(671, 169);
            this.groupBoxIsDetayEkleDuzenle.TabIndex = 0;
            this.groupBoxIsDetayEkleDuzenle.TabStop = false;
            this.groupBoxIsDetayEkleDuzenle.Text = "Detay Ekle ve Düzenle";
            // 
            // textBoxDetay3
            // 
            this.textBoxDetay3.Location = new System.Drawing.Point(516, 64);
            this.textBoxDetay3.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxDetay3.Name = "textBoxDetay3";
            this.textBoxDetay3.Size = new System.Drawing.Size(132, 23);
            this.textBoxDetay3.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(450, 64);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Detay 3";
            // 
            // buttonSil
            // 
            this.buttonSil.Location = new System.Drawing.Point(437, 108);
            this.buttonSil.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSil.Name = "buttonSil";
            this.buttonSil.Size = new System.Drawing.Size(173, 44);
            this.buttonSil.TabIndex = 8;
            this.buttonSil.Text = "Sil";
            this.buttonSil.UseVisualStyleBackColor = true;
            this.buttonSil.Click += new System.EventHandler(this.buttonSil_Click);
            // 
            // buttonDuzenle
            // 
            this.buttonDuzenle.Location = new System.Drawing.Point(235, 108);
            this.buttonDuzenle.Margin = new System.Windows.Forms.Padding(4);
            this.buttonDuzenle.Name = "buttonDuzenle";
            this.buttonDuzenle.Size = new System.Drawing.Size(173, 44);
            this.buttonDuzenle.TabIndex = 7;
            this.buttonDuzenle.Text = "Düzenle";
            this.buttonDuzenle.UseVisualStyleBackColor = true;
            this.buttonDuzenle.Click += new System.EventHandler(this.buttonDuzenle_Click);
            // 
            // buttonEkle
            // 
            this.buttonEkle.Location = new System.Drawing.Point(28, 108);
            this.buttonEkle.Margin = new System.Windows.Forms.Padding(4);
            this.buttonEkle.Name = "buttonEkle";
            this.buttonEkle.Size = new System.Drawing.Size(173, 44);
            this.buttonEkle.TabIndex = 6;
            this.buttonEkle.Text = "Ekle";
            this.buttonEkle.UseVisualStyleBackColor = true;
            this.buttonEkle.Click += new System.EventHandler(this.buttonEkle_Click);
            // 
            // textBoxDetay2
            // 
            this.textBoxDetay2.Location = new System.Drawing.Point(307, 64);
            this.textBoxDetay2.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxDetay2.Name = "textBoxDetay2";
            this.textBoxDetay2.Size = new System.Drawing.Size(132, 23);
            this.textBoxDetay2.TabIndex = 5;
            // 
            // textBoxDetay1
            // 
            this.textBoxDetay1.Location = new System.Drawing.Point(92, 64);
            this.textBoxDetay1.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxDetay1.Name = "textBoxDetay1";
            this.textBoxDetay1.Size = new System.Drawing.Size(132, 23);
            this.textBoxDetay1.TabIndex = 4;
            // 
            // textBoxSiraNo
            // 
            this.textBoxSiraNo.Location = new System.Drawing.Point(92, 36);
            this.textBoxSiraNo.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxSiraNo.Name = "textBoxSiraNo";
            this.textBoxSiraNo.Size = new System.Drawing.Size(132, 23);
            this.textBoxSiraNo.TabIndex = 3;
            // 
            // labelDetay2
            // 
            this.labelDetay2.AutoSize = true;
            this.labelDetay2.Location = new System.Drawing.Point(241, 64);
            this.labelDetay2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDetay2.Name = "labelDetay2";
            this.labelDetay2.Size = new System.Drawing.Size(57, 17);
            this.labelDetay2.TabIndex = 2;
            this.labelDetay2.Text = "Detay 2";
            // 
            // labelDetay1
            // 
            this.labelDetay1.AutoSize = true;
            this.labelDetay1.Location = new System.Drawing.Point(20, 64);
            this.labelDetay1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDetay1.Name = "labelDetay1";
            this.labelDetay1.Size = new System.Drawing.Size(57, 17);
            this.labelDetay1.TabIndex = 1;
            this.labelDetay1.Text = "Detay 1";
            // 
            // labelIsSiraNo
            // 
            this.labelIsSiraNo.AutoSize = true;
            this.labelIsSiraNo.Location = new System.Drawing.Point(20, 36);
            this.labelIsSiraNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelIsSiraNo.Name = "labelIsSiraNo";
            this.labelIsSiraNo.Size = new System.Drawing.Size(55, 17);
            this.labelIsSiraNo.TabIndex = 0;
            this.labelIsSiraNo.Text = "Sıra No";
            // 
            // buttonExcelFormu
            // 
            this.buttonExcelFormu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonExcelFormu.Location = new System.Drawing.Point(35, 434);
            this.buttonExcelFormu.Name = "buttonExcelFormu";
            this.buttonExcelFormu.Size = new System.Drawing.Size(206, 51);
            this.buttonExcelFormu.TabIndex = 13;
            this.buttonExcelFormu.Text = "Excel\'den Xml\'e Dönüştür";
            this.buttonExcelFormu.UseVisualStyleBackColor = true;
            this.buttonExcelFormu.Click += new System.EventHandler(this.buttonExcelFormu_Click);
            // 
            // buttonXMLKaydet
            // 
            this.buttonXMLKaydet.Location = new System.Drawing.Point(500, 434);
            this.buttonXMLKaydet.Margin = new System.Windows.Forms.Padding(4);
            this.buttonXMLKaydet.Name = "buttonXMLKaydet";
            this.buttonXMLKaydet.Size = new System.Drawing.Size(211, 51);
            this.buttonXMLKaydet.TabIndex = 10;
            this.buttonXMLKaydet.Text = "Dosyayı XML Olarak Kaydet";
            this.buttonXMLKaydet.UseVisualStyleBackColor = true;
            this.buttonXMLKaydet.Click += new System.EventHandler(this.buttonXMLKaydet_Click);
            // 
            // buttonXMLAl
            // 
            this.buttonXMLAl.Location = new System.Drawing.Point(500, 491);
            this.buttonXMLAl.Margin = new System.Windows.Forms.Padding(4);
            this.buttonXMLAl.Name = "buttonXMLAl";
            this.buttonXMLAl.Size = new System.Drawing.Size(211, 54);
            this.buttonXMLAl.TabIndex = 11;
            this.buttonXMLAl.Text = "Bilgileri XML Dosyasından Al";
            this.buttonXMLAl.UseVisualStyleBackColor = true;
            this.buttonXMLAl.Click += new System.EventHandler(this.buttonXMLAl_Click);
            // 
            // buttonXmlFormu
            // 
            this.buttonXmlFormu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonXmlFormu.Location = new System.Drawing.Point(35, 495);
            this.buttonXmlFormu.Name = "buttonXmlFormu";
            this.buttonXmlFormu.Size = new System.Drawing.Size(206, 51);
            this.buttonXmlFormu.TabIndex = 14;
            this.buttonXmlFormu.Text = "Xml\'den Excel\'e Dönüştür";
            this.buttonXmlFormu.UseVisualStyleBackColor = true;
            this.buttonXmlFormu.Click += new System.EventHandler(this.buttonXmlFormu_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(755, 558);
            this.Controls.Add(this.buttonXmlFormu);
            this.Controls.Add(this.buttonExcelFormu);
            this.Controls.Add(this.buttonXMLAl);
            this.Controls.Add(this.buttonXMLKaydet);
            this.Controls.Add(this.groupBoxIsDetay);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "XML Veri İşlemleri";
            this.groupBoxIsDetay.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBoxIsDetayEkleDuzenle.ResumeLayout(false);
            this.groupBoxIsDetayEkleDuzenle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxIsDetay;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBoxIsDetayEkleDuzenle;
        private System.Windows.Forms.Button buttonSil;
        private System.Windows.Forms.Button buttonDuzenle;
        private System.Windows.Forms.Button buttonEkle;
        private System.Windows.Forms.TextBox textBoxDetay2;
        private System.Windows.Forms.TextBox textBoxDetay1;
        private System.Windows.Forms.TextBox textBoxSiraNo;
        private System.Windows.Forms.Label labelDetay2;
        private System.Windows.Forms.Label labelDetay1;
        private System.Windows.Forms.Label labelIsSiraNo;
        private System.Windows.Forms.Button buttonXMLKaydet;
        private System.Windows.Forms.Button buttonXMLAl;
        private System.Windows.Forms.TextBox textBoxDetay3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IsSiraNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Detay1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Detay2;
        private System.Windows.Forms.Button buttonExcelFormu;
        private System.Windows.Forms.Button buttonXmlFormu;
    }
}

