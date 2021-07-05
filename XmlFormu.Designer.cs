
namespace FormXmlKullanimi
{
    partial class XmlFormu
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
            this.buttonExcelKaydet = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.labelDosyaYukle = new System.Windows.Forms.Label();
            this.textBoxDosyaSec = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonExcelKaydet
            // 
            this.buttonExcelKaydet.Location = new System.Drawing.Point(545, 379);
            this.buttonExcelKaydet.Margin = new System.Windows.Forms.Padding(4);
            this.buttonExcelKaydet.Name = "buttonExcelKaydet";
            this.buttonExcelKaydet.Size = new System.Drawing.Size(209, 44);
            this.buttonExcelKaydet.TabIndex = 18;
            this.buttonExcelKaydet.Text = "Dosyayı Excel Olarak Kaydet";
            this.buttonExcelKaydet.UseVisualStyleBackColor = true;
            this.buttonExcelKaydet.Click += new System.EventHandler(this.buttonExcelKaydet_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(44, 84);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(710, 266);
            this.dataGridView1.TabIndex = 17;
            // 
            // labelDosyaYukle
            // 
            this.labelDosyaYukle.AutoSize = true;
            this.labelDosyaYukle.BackColor = System.Drawing.SystemColors.ControlLight;
            this.labelDosyaYukle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelDosyaYukle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelDosyaYukle.Location = new System.Drawing.Point(665, 38);
            this.labelDosyaYukle.Name = "labelDosyaYukle";
            this.labelDosyaYukle.Size = new System.Drawing.Size(91, 22);
            this.labelDosyaYukle.TabIndex = 16;
            this.labelDosyaYukle.Text = "Dosya seç";
            this.labelDosyaYukle.Click += new System.EventHandler(this.labelDosyaYukle_Click);
            // 
            // textBoxDosyaSec
            // 
            this.textBoxDosyaSec.Location = new System.Drawing.Point(44, 38);
            this.textBoxDosyaSec.Name = "textBoxDosyaSec";
            this.textBoxDosyaSec.Size = new System.Drawing.Size(602, 22);
            this.textBoxDosyaSec.TabIndex = 15;
            // 
            // XmlFormu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonExcelKaydet);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.labelDosyaYukle);
            this.Controls.Add(this.textBoxDosyaSec);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "XmlFormu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Xml\'den Excel\'e Dönüşüm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonExcelKaydet;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label labelDosyaYukle;
        private System.Windows.Forms.TextBox textBoxDosyaSec;
    }
}