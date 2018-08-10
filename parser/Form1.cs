using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.OleDb;




namespace parser
{
    public partial class Form1 : Form
    {
        private String FileName = null;
        private String DirName  = null;
        private DataTable Table = new DataTable();
        private System.Data.DataSet ds = new System.Data.DataSet("EXCEL");



        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog OFD = new OpenFileDialog();
            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "Excel (*.XLS)|*.XLS";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            if (OFD.ShowDialog() == DialogResult.OK && OFD.FileName != null)  // просим юзера указать файл таблицы
            {
               // if (openFileDialog1.FileName != null)
                try
                {
                    FileName = openFileDialog1.FileName;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog FBD = new FolderBrowserDialog();
            if (FBD.ShowDialog() == DialogResult.OK && FBD.SelectedPath != null)     // просим юзера указать папку
            {
                try
                {
                    DirName = FBD.SelectedPath;
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

          
        }
    }
}









/*


 // Create New Excel Workbook
ExcelWorkbook Wbook = new ExcelWorkbook();
ExcelCellCollection Cells = Wbook.Worksheets.Add("Sheet1").Cells;

Cells["A1"].Value = "Excel writer example (C#)";
Cells["A1"].Style.Font.Bold = true;
Cells["B1"].Value = "=550 + 5";

// Write Excel XLS file
Wbook.WriteXLS("excel_net.xls");


*/


