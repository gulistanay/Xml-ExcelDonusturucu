
namespace FormXmlKullanimi
{
    partial class ExcelFormu
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
            this.labelDosyaYukle = new System.Windows.Forms.Label();
            this.textBoxDosyaSec = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonXMLKaydet = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelDosyaYukle
            // 
            this.labelDosyaYukle.AutoSize = true;
            this.labelDosyaYukle.BackColor = System.Drawing.SystemColors.ControlLight;
            this.labelDosyaYukle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelDosyaYukle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelDosyaYukle.Location = new System.Drawing.Point(666, 54);
            this.labelDosyaYukle.Name = "labelDosyaYukle";
            this.labelDosyaYukle.Size = new System.Drawing.Size(91, 22);
            this.labelDosyaYukle.TabIndex = 12;
            this.labelDosyaYukle.Text = "Dosya seç";
            this.labelDosyaYukle.Click += new System.EventHandler(this.labelDosyaYukle_Click);
            // 
            // textBoxDosyaSec
            // 
            this.textBoxDosyaSec.Location = new System.Drawing.Point(45, 54);
            this.textBoxDosyaSec.Name = "textBoxDosyaSec";
            this.textBoxDosyaSec.Size = new System.Drawing.Size(602, 22);
            this.textBoxDosyaSec.TabIndex = 11;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(45, 100);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(710, 266);
            this.dataGridView1.TabIndex = 13;
            // 
            // buttonXMLKaydet
            // 
            this.buttonXMLKaydet.Location = new System.Drawing.Point(290, 384);
            this.buttonXMLKaydet.Margin = new System.Windows.Forms.Padding(4);
            this.buttonXMLKaydet.Name = "buttonXMLKaydet";
            this.buttonXMLKaydet.Size = new System.Drawing.Size(240, 44);
            this.buttonXMLKaydet.TabIndex = 14;
            this.buttonXMLKaydet.Text = "Dosyayı XML Olarak Kaydet";
            this.buttonXMLKaydet.UseVisualStyleBackColor = true;
            this.buttonXMLKaydet.Click += new System.EventHandler(this.buttonXMLKaydet_Click);
            // 
            // ExcelFormu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonXMLKaydet);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.labelDosyaYukle);
            this.Controls.Add(this.textBoxDosyaSec);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.MaximizeBox = false;
            this.Name = "ExcelFormu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Excel\'den Xml\'e Dönüşüm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDosyaYukle;
        private System.Windows.Forms.TextBox textBoxDosyaSec;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonXMLKaydet;
    }
}