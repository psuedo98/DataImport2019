using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.Shared;
using CrystalDecisions.CrystalReports.Engine; 

namespace WipViewer.ScheduleForms
{
    public partial class MachSchedule : Form
    {
        public MachSchedule()
        {
            InitializeComponent();
        }

        

        public MachSchedule(string reporttype)
        {
            InitializeComponent();

            string reporttype_ = reporttype;



            switch (reporttype_)
            {
                case "shipping":
                    crp1.ReportSource = "R:\\wipviewer2017\\Reports\\ShipDeviation.rpt";
                    break;
                case "machining":
                    crp1.ReportSource = "R:\\wipviewer2017\\MachineSchedule.rpt";
                    break;
                case "completedjobs":
                    crp1.ReportSource = "R:\\wipviewer2017\\Reports\\completedjobs.rpt";
                    break;
                case "marginreport":
                    crp1.ReportSource = "R:\\wipviewer2017\\Reports\\marginreport.rpt";
                    break;
                case "outsourcereport":
                    crp1.ReportSource = "R:\\wipviewer2017\\Reports\\outsourcereport.rpt";
                    break;
                case "materialreport":
                    crp1.ReportSource = "R:\\wipviewer2017\\Reports\\materialreport.rpt";
                    break;
                case "shippingreport":
                    crp1.ReportSource = "R:\\wipviewer2017\\Reports\\wipship.rpt";
                    break;
                case "shippingteam":
                    crp1.ReportSource = "R:\\wipviewer2017\\Reports\\wipship_team.rpt";
                    break;
                case "coq":
                    crp1.ReportSource = "R:\\wipviewer2017\\Reports\\costofquality.rpt";
                    break;
                case "redtag":
                    crp1.ReportSource = "R:\\wipviewer2017\\Reports\\redtagsummary.rpt";
                    break;
                case "sofia":
                    crp1.ReportSource = "R:\\wipviewer2017\\Reports\\sofiasreport.rpt";
                    break;
                case "materialvendor":
                    crp1.ReportSource = "R:\\wipviewer2017\\Reports\\materialvendor.rpt";
                    break;
                case "lineitems":
                    crp1.ReportSource = "R:\\wipviewer2017\\Reports\\amandasreport.rpt";
                    break;
                case "ontimedelivery":
                    crp1.ReportSource = "R:\\wipviewer2017\\Reports\\amandassecondreport.rpt";
                    break;

                case "problemjobs":
                    crp1.ReportSource = "R:\\wipviewer2017\\Reports\\problemjobs.rpt";
                    break;

                case "comment":
                    crp1.ReportSource = "R:\\wipviewer2017\\Reports\\ComentReport.rpt";
                    break;

                case "laborticketdetail":
                    crp1.ReportSource = "R:\\wipviewer2017\\Reports\\laborticketdetail.rpt";
                    break;

                case "laborticketdetail_dept":
                    crp1.ReportSource = "R:\\wipviewer2017\\Reports\\laborticketdetail_dept.rpt";
                    break;









            }

            crp1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None; 

        }

        public MachSchedule(ParameterDiscreteValue startdate, ParameterDiscreteValue enddate)
        {
            InitializeComponent();

       //     DateTime startd = Convert.ToDateTime(startdate); 

           
            crp1.ReportSource = "R:\\wipviewer2017\\Reports\\completedjobs.rpt";
            crp1.ShowParameterPanelButton = true; 
           //crp1.ParameterFieldInfo["Starting Ship Date"].CurrentValues.Add(startdate);
          // crp1.ParameterFieldInfo["Ending Ship Date"].CurrentValues.Add(enddate);
            crp1.Refresh(); 
            
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void MachSchedule_Load(object sender, EventArgs e)
        {

        }
    }
}
