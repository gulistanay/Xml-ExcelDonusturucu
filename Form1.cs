using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExcelApp = Microsoft.Office.Interop.Excel;
using System.Xml;            



namespace FormXmlKullanimi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void buttonEkle_Click(object sender, EventArgs e)
        {

            int n = dataGridView1.Rows.Add();
            // n adında integer bir değişken oluşturuyoruz bunu datagridview'e satır eklerken kullanıyoruz.
            dataGridView1.Rows[n].Cells[0].Value=textBoxSiraNo.Text;
            //Datagridview'in n satırı  0.sütununa textboxsiraNo'nun Text'ini ekliyoruz.
            dataGridView1.Rows[n].Cells[1].Value=textBoxDetay1.Text;
            //Datagridview'in n satırı  1.sütununa textboxDetay1'nin Text'ini ekliyoruz.
            dataGridView1.Rows[n].Cells[2].Value=textBoxDetay2.Text;
            //Datagridview'in n satırı  2.sütununa textboxDetay2'nin Text'ini ekliyoruz.
            
            textBoxSiraNo.Clear();
            //Verileri ekledikten sonra textbox'ı yeni veri girişi için temizliyoruz.
            textBoxDetay1.Clear();
            //Verileri ekledikten sonra textbox'ı yeni veri girişi için temizliyoruz.
            textBoxDetay2.Clear();
            //Verileri ekledikten sonra textbox'ı yeni veri girişi için temizliyoruz.

        }

        private void buttonXMLKaydet_Click(object sender, EventArgs e)
        {
            //XML Kaydet butonuna tıkladığımızda yapılacaklar.
            DataSet ds = new DataSet("FirmaProjeBilgileri");
            //Verileri dataset'e kaydetmek için "Firma Bilgileri" adından bir dataset oluşturuyoruz.
     
            DataTable dt = new DataTable("Isdetay");
            //Verileri Dataset içinde kaydetmek için "İş Detay"adında datatable oluşturuyoruz.
            
            dt.Columns.Add("SiraNo");//Datatable'ın Sütununa "Sıra No" ekliyoruz.
            dt.Columns.Add("Detay1");//Datatable'ın Sütununa "Detay1" ekliyoruz.
            dt.Columns.Add("Detay2");//Datatable'ın Sütununa "Detay2" ekliyoruz.
            ds.Tables.Add(dt);//Sütunları tablo içine ekliyoruz.


           foreach (DataGridViewRow r in dataGridView1.Rows)
           {//Oluşacak satır sayısıı bilmediğimizden dolayı foreach döngüsü içinde 
               //DataGridView'in satır sayısı kadar değer döndürüyoruz.
          DataRow row = ds.Tables["IsDetay"].NewRow();
          //Isdetay'da oluşturduğumuz tablo değerlerini eklemek için kullanıyoruz.
          

           row["SiraNo"] = r.Cells[0].Value.ToString();
               //Satırdaki SıraNo'nun değerini DetaGridView'den alıyoruz ve geçerli satırın 0.sütünunu alıyoruz.
           row["Detay1"] = r.Cells[1].Value.ToString();
           //Satırdaki Detay1 değerini DetaGridView'den alıyoruz ve geçerli satırın 1.sütünunu alıyoruz.
           row["Detay2"] = r.Cells[2].Value.ToString();
           //Satırdaki Detay2 değerini DetaGridView'den alıyoruz ve geçerli satırın 2.sütünunu alıyoruz.


           ds.Tables["IsDetay"].Rows.Add(row);
               //Dataset içindeki Isdetay tablosuna satırları ekliyoruz.
           }
           ds.WriteXml(@"D:\\avturk\\Veri1.xml");
            //Verileri Dataset ile XML'e yazıyoruz.

        }

        private void buttonXMLAl_Click(object sender, EventArgs e)
        {
            string DosyaYolu = "Veri1" + ".xml";
            //XML dosyamızın var olup olmadığını kontrol için ilk önce bir değişkene dosya yolunu atıyoruz.
            if (System.IO.File.Exists(DosyaYolu))
            {//Eğer Dosyo yolunda belirtilen değer var ise aşağıdaki işlemler yapılıyor.
                DataSet ds = new DataSet();
                //Az önce oluşturduğumuz dataset private olduğundan burada yeniden oluşturuyoruz.
                ds.ReadXml("Veri1.xml");
                //Dataset'imiz ile daha önceden oluşturduğumuz "Veri.xml" dosyasını okutuyoruz.

                foreach (DataRow item in ds.Tables["IsDetay"].Rows)
                {//XML dosyasındaki veri sayısını bilmediğimizden "IsDetay" 
                    //tablosundaki satırlar kadar foreach döngüsüne sokuyoruz.
                    int n = dataGridView1.Rows.Add();
                    //Satır sayısını n değişkenine aktarıyoruz.
                    dataGridView1.Rows[n].Cells[0].Value = item[0].ToString();
                    //DataGridView'in n satırının 0. sütununu datasetten gelen 0.sütun ile eşitliyoruz.
                    dataGridView1.Rows[n].Cells[1].Value = item[1].ToString();
                    //DataGridView'in n satırının 1. sütununu datasetten gelen 1.sütun ile eşitliyoruz.
                    dataGridView1.Rows[n].Cells[2].Value = item[2].ToString();
                    //DataGridView'in n satırının 2. sütununu datasetten gelen 1.sütun ile eşitliyoruz.

                }
            }//if bitisi
            else {//Eğer XML dosyası yok ise 
                MessageBox.Show("Veri1.XML Bulunamadı.XML Dosyasını Oluşturun.");
                //MessageBox ile uyarı veriliyor.
            }


        }


        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            //DatagridView'in mauseClick Event'ini kullanarak seçili satıra tıklandığından 
            //ilgili textboxların içeriğinin dolmasını sağlıyoruz.
            textBoxSiraNo.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            textBoxDetay1.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            textBoxDetay2.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
        
        }

        private void buttonDuzenle_Click(object sender, EventArgs e)
        {//Düzenle butonuna bastığımızda datagridview'den değeri textboxlara çekiyoruz.
        
            dataGridView1.SelectedRows[0].Cells[0].Value = textBoxSiraNo.Text;
            dataGridView1.SelectedRows[0].Cells[1].Value = textBoxDetay1.Text;
            dataGridView1.SelectedRows[0].Cells[2].Value = textBoxDetay2.Text;
        }

        private void buttonSil_Click(object sender, EventArgs e)
        {//Sil butonuna tıklandığından DataGridView'de tıklamış olduğumuz satırı siliyoruz.
            dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
        }


        private void buttonExcelFormu_Click(object sender, EventArgs e)
        {
            this.Hide();
            ExcelFormu formExcel = new ExcelFormu();
            formExcel.Show();
        }

        private void buttonXmlFormu_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            XmlFormu formXml = new XmlFormu();
            formXml.Show();
        }
    }
}
