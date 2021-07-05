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
           
            
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.ColumnHeadersVisible = true; 

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

            

        }
    }
}
