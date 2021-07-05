using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using ExcelApp = Microsoft.Office.Interop.Excel;

namespace FormXmlKullanimi
{
    public partial class ExcelFormu : Form
    {

        public ExcelFormu()
        {
            InitializeComponent();
        }

        DataTable dt;
        private void labelDosyaYukle_Click(object sender, EventArgs e)
        {
            try
            {

                string DosyaYolu;
                string DosyaAdi;
                
                OpenFileDialog file = new OpenFileDialog();
                
                file.Filter = "Excel Dosyası | *.xls; *.xlsx; *.xlsm";
                
                if (file.ShowDialog() == DialogResult.OK)
                {
                    Cursor.Current = Cursors.WaitCursor;
                    DosyaYolu = file.FileName;// seçilen dosyanın tüm yolunu verir
                    DosyaAdi = file.SafeFileName;// seçilen dosyanın adını verir.
                    ExcelApp.Application excelApp = new ExcelApp.Application();
                    if (excelApp == null)
                    {
                        MessageBox.Show("Excel yüklü değil.");
                        return;
                    }
                    //Excel Dosyası Açılıyor.
                    ExcelApp.Workbook excelBook = excelApp.Workbooks.Open(DosyaYolu);
                    //Excel Dosyasının Sayfası Seçilir.
                    ExcelApp._Worksheet excelSheet = excelBook.Sheets[1];
                    //Excel Dosyasının ne kadar satır ve sütun kaplıyorsa tüm alanları alır.
                    ExcelApp.Range excelRange = excelSheet.UsedRange;
                    int satirSayisi = excelRange.Rows.Count; //Sayfanın satır sayısını alır.
                    int sutunSayisi = excelRange.Columns.Count;//Sayfanın sütun sayısını alır.
                    dt = ToDataTable(excelRange, satirSayisi, sutunSayisi);

                    dt.TableName = DosyaAdi.Split('.')[0]; //XML e kayıt

                    dataGridView1.DataSource = dt;
                    dataGridView1.Refresh();

                    Cursor.Current = Cursors.Default;

                    excelApp.Quit();
                    System.Runtime.InteropServices.Marshal.ReleaseComObject(excelApp);
                }
                else
                {
                    MessageBox.Show("Dosya Seçilemedi.");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Dosya okunamadı.");
            }
        }

        public DataTable ToDataTable(ExcelApp.Range range, int rows, int cols)
        {
            DataTable table = new DataTable();
            for (int i = 1; i <= rows; i++)
            {
                if (i == 1)
                { // ilk satırı Sutun Adları olarak kullanıldığından
                  // bunları Sutün Adları Olarak Kaydediyoruz.
                    for (int j = 1; j <= cols; j++)
                    {
                        //Sütunların içeriği boş mu kontrolü yapılmaktadır.
                        if (range.Cells[i, j] != null && range.Cells[i, j].Value2 != null)
                            table.Columns.Add(range.Cells[i, j].Value2.ToString());
                        else //Boş olduğunda Kaçınsı Sutünsa Adı veriliyor.
                            table.Columns.Add(j.ToString() + ".Sütun");
                    }
                    continue;
                }
                //Yukarıda Sütunlar eklendi
                // onun şemasına göre yeni bir satır oluşturuyoruz. 
                //Okunan verileri yan yana sıralamak için
                var yeniSatir = table.NewRow();
                for (int j = 1; j <= cols; j++)
                {
                    //Sütunların içeriği boş mu kontrolü yapılmaktadır.
                    if (range.Cells[i, j] != null && range.Cells[i, j].Value2 != null)
                        yeniSatir[j - 1] = range.Cells[i, j].Value2.ToString();
                    else // İçeriği boş hücrede hata vermesini önlemek için
                        yeniSatir[j - 1] = String.Empty;
                }
                table.Rows.Add(yeniSatir);
            }
            return table;


        }

        private void buttonXMLKaydet_Click(object sender, EventArgs e)
        {
            
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "XML|*.xml";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                
                try
                {
                    dt.WriteXml(sfd.FileName);
                    if (MessageBox.Show("XML dosyası hazırlandı. Dosya açılsın mı?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        System.Diagnostics.Process.Start(sfd.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }

            


            //--------------ÇALIŞIYOR--------
            //try
            //{
            //    DataTable dt = GetDataTableFromDGV(dataGridView1);
            //    DataSet ds = new DataSet();
            //    ds.Tables.Add(dt);
            //    ds.WriteXml(File.OpenWrite(@"D:\avturk\XMLDosyasi.xml"));
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.ToString());
            //}





            //DataTable dt = new DataTable();
            //for (int i = 1; i < dataGridView1.Columns.Count + 1; i++)
            //{
            //    DataColumn column = new DataColumn(dataGridView1.Columns[i - 1].HeaderText);
            //    dt.Columns.Add(column);
            //}
            //int ColumnCount = dataGridView1.Columns.Count;
            //foreach (DataGridViewRow dr in dataGridView1.Rows)
            //{
            //    DataRow dataRow = dt.NewRow();
            //    for (int i = 0; i < ColumnCount; i++)
            //    {
            //        dataRow[i] = dr.Cells[i];
            //    }
            //}

            //DataSet ds = new DataSet();
            //ds.Tables.Add(dt);
            //XmlTextWriter newXml = new XmlTextWriter("D:/avturk/newXML.xml", Encoding.UTF8);
            //ds.WriteXml(newXml);


            //const string FILENAME = @"D:\avturk\test.xml";
            //XDocument doc = new XDocument(new XDeclaration("1.0", "ISO-8859-1", "yes"));
            //XElement root = new XElement("root");
            //XElement tbl = new XElement("table");
            //List<XElement> entries = dataGridView1.Rows.Cast<DataGridViewRow>()
            //.Select(row => new XElement("row", new XElement[]
            //    {
            //new XElement("one", row.Cells[0].Value.ToString()),
            //new XElement("two", row.Cells[1].Value.ToString()),
            //new XElement("child", new XElement("three", row.Cells[2].Value.ToString()))
            //    }))
            //    .ToList();
            //tbl.Add(entries);
            //root.Add(tbl);
            //doc.Add(root);
            //doc.Save(FILENAME);


            //DataSet ds = new DataSet();
            //ds.Tables.Add(dt);

            ////Finally the save part:
            //XmlTextWriter xmlSave = new XmlTextWriter(XML_Save_Path_Filename, Encoding.UTF8);
            //xmlSave.Formatting = Formatting.Indented;
            //ds.DataSetName = "Data";
            //ds.WriteXml(xmlSave);
            //xmlSave.Close();


            //Cursor.Current = Cursors.WaitCursor;
            //DataTable dt = (DataTable)grdcExcell.DataSource;
            //SaveFileDialog sf = new SaveFileDialog();
            //sf.Filter = "XML|*.xml";
            //if (sf.ShowDialog() == DialogResult.OK)
            //{
            //    try
            //    {
            //        dt.WriteXml(sf.FileName);
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show($"HATA: {sf.FileName} kaydedilemedi.\nMESAJ: {ex.Message}");
            //    }
            //}



            //DataSet ds = new DataSet("ProjeBilgileri");
            //DataTable dt = new DataTable("IsDetay");
            //dt.Columns.Add();
            //ds.Tables.Add(dt);
            //foreach (DataGridViewRow r in dataGridView1.Rows)
            //{
            //    DataRow row = ds.Tables["IsDetay"].NewRow();
            //    ds.Tables["IsDetay"].Rows.Add(row);
            //}
            //ds.WriteXml(@"D:\\avturk\\ExcelDonusum.xml");



        }

        //ÇALIŞAN KISIM PART2
        //private DataTable GetDataTableFromDGV(DataGridView dgv)
        //{
        //    var dt = new DataTable();
        //    foreach (DataGridViewColumn column in dgv.Columns)
        //    {
        //        if (column.Visible)
        //        {
                    
        //             dt.Columns.Add(column.HeaderText);
        //        }
        //    }
        //    object[] cellValues = new object[dgv.Columns.Count];
        //    foreach (DataGridViewRow row in dgv.Rows)
        //    {
        //        for (int i = 0; i < row.Cells.Count; i++)
        //        {
        //            cellValues[i] = row.Cells[i].Value;
        //        }
        //        dt.Rows.Add(cellValues);
        //    }
        //    return dt;
        //}
    }
}
