using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WipViewer
{
    public partial class JobKickoff : Form
    {
        public string strJobnumber;
        public JobKickoff()
        {
            InitializeComponent();
        }

        public JobKickoff(string jobnumber)
        {
            InitializeComponent();
            strJobnumber = jobnumber;
        }
        private void JobKickoff_Load(object sender, EventArgs e)
        {
            using (var db = new TestEntities())
            {
                Kickoff ko = db.Kickoffs.Find(strJobnumber);

                lblProcessingEst.Text = "Processing: " + ko.PlanningEst;
                lblProcessingKO.Text = "Processing: " + ko.Planning;
                lblDesignEst.Text = "Design: " + ko.DesignEst;
                lblDesignKO.Text = "Design: " + ko.Design;
                int strWeldEst = Convert.ToInt32(ko.WaterjetEst) + Convert.ToInt32(ko.WeldEst); 
               
                lblWeldEst.Text = "Weld: " + strWeldEst;

                int strWeldKO = Convert.ToInt32(ko.Waterjet) + Convert.ToInt32(ko.Weld);

                lblWeldKO.Text = "Weld: " + strWeldKO;

                int strMachineEst = Convert.ToInt32(ko.ConventionalEst) + Convert.ToInt32(ko.NCEst);
                int strMachineKO = Convert.ToInt32(ko.Convetional) + Convert.ToInt32(ko.NC); 
               

                lblMachineEst.Text = "Machine: " + strMachineEst;
                lblMachineKO.Text = "Machine: " + strMachineKO;

                lblAssemblyEst.Text = "Assembly: " + ko.AssemblyEst;
                lblAssemblyKO.Text = "Assembly: " + ko.Assy;

                lblQaEst.Text = "QA: " + ko.InspectionEst;
                lblQAKO.Text = "QA: " + ko.Inspection;

                lblOutsourceEst.Text = "Outsource: " + ko.OutsourceEst;
                lblOutsourceKO.Text = "Outsouce: " + ko.Outsource;
            }
        }
    }
}
