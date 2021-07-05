using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using DataTable = Microsoft.Office.Interop.Excel.DataTable;
using ExcelApp = Microsoft.Office.Interop.Excel;


namespace FormXmlKullanimi
{
    public partial class XmlFormu : Form
    {
        public XmlFormu()
        {
            InitializeComponent();
        }

        DataTable dt ;
        DataSet ds = new DataSet();
        private void labelDosyaYukle_Click(object sender, EventArgs e)
        {          
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "XML | *.xml";
            
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    XmlReader xmlFile = XmlReader.Create(ofd.FileName, new XmlReaderSettings());
                    ds.ReadXml(xmlFile);
                    dataGridView1.DataSource = ds.Tables[0].DefaultView;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }


        private void buttonExcelKaydet_Click(object sender, EventArgs e)
        {
            //SaveFileDialog sfd = new SaveFileDialog();
            //sfd.Filter = "Excel Dosyası | *.xls; *.xlsx; *.xlsm";
            //if (sfd.ShowDialog() == DialogResult.OK)
            //{
            //    try
            //    {

            //        //dt.WriteXml(sfd.FileName);
            //        if (MessageBox.Show("Excel dosyası hazırlandı. Dosya açılsın mı?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            //            System.Diagnostics.Process.Start(sfd.FileName);
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show(ex.ToString());
            //    }
            //}
            
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.ColumnHeadersVisible = true; //?? Çalışmıyo??  Başlıkları çekmiyor!!!

            dataGridView1.Refresh();


            dataGridView1.SelectAll();
            DataObject dataObj = dataGridView1.GetClipboardContent();
            if (dataObj != null)
                Clipboard.SetDataObject(dataObj);
            

            Microsoft.Office.Interop.Excel.Application xlexcel;
            Microsoft.Office.Interop.Excel.Workbook xlWorkBook;
            Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value;
            xlexcel = new ExcelApp.Application();
            xlexcel.Visible = true;
            xlWorkBook = xlexcel.Workbooks.Add(misValue);
            xlWorkSheet = (ExcelApp.Worksheet)xlWorkBook.Worksheets.get_Item(1);
            ExcelApp.Range CR = (ExcelApp.Range)xlWorkSheet.Cells[1, 1];
            CR.Select();
            xlWorkSheet.PasteSpecial(CR, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);

            

            //ExcelApp.Application excel = new ExcelApp.Application();

            //excel.Visible = true;
            //object Missing = Type.Missing;
            //ExcelApp.Workbook excelBook = excel.Workbooks.Add(Missing);
            //ExcelApp._Worksheet excelSheet = excelBook.Sheets[1];
            //int StartCol = 1;
            //int StartRow = 1;
            //for (int j = 0; j<=dataGridView1.Columns.Count; j++)
            //{
            //    Range myRange = (Range)excelSheet.Cells[StartRow, StartCol + j];
            //    myRange.Value2 = dataGridView1.Columns[j].HeaderText;
            //}
            //StartRow++;
            //for (int i = 0; i<=dataGridView1.Rows.Count; i++)
            //{
            //    for (int j = 0; j<=dataGridView1.Columns.Count; j++)
            //    {

            //        Range myRange = (Range)excelSheet.Cells[StartRow + i, StartCol + j];
            //        myRange.Value2 = dataGridView1[j, i].Value == null ? "" : dataGridView1[j, i].Value;
            //        myRange.Select();


            //    }
            //}
        }
    }
}
