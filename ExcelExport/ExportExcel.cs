using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Office.Tools.Ribbon;
using excel = Microsoft.Office.Interop.Excel;
using System.Windows.Forms; 

namespace ExcelExport
{
    public partial class ExportExcel
    {

        public excel.Workbook wbook;
        public excel.Application eapp;
         
        private void ExportExcel_Load(object sender, RibbonUIEventArgs e)
        {

            wbook = Globals.ThisAddIn.Application.ActiveWorkbook; 

        }

        private void btnImport_Click(object sender, RibbonControlEventArgs e)
        {
            Info infoform = new Info(wbook);
            infoform.Show(); 

        }

        private void btnImpRA_Click(object sender, RibbonControlEventArgs e)
        {
            string doctype = "riskassessment"; 
            JobNumber jn = new JobNumber(doctype);
            jn.Show(); 

        }

        private void btnAqp_Click(object sender, RibbonControlEventArgs e)
        {
            string doctype = "aqp"; 
            JobNumber jn = new JobNumber(doctype);
            jn.Show();
        }
    }
}
