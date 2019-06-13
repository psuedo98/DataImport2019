using System;
using System.Windows.Forms;




namespace WipViewer
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            
        }

        private void openJobToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void viewAllActiveJobsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataView activedata = new DataView();
            activedata.Show(); 
            
             

        }

        private void lblWip_Click(object sender, EventArgs e)
        {

        }

        private void commentReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            comment_report Comment_report = new comment_report();
            Comment_report.Show(); 

        }

        private void fabToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string department = "fab";
            schedule Schedule = new schedule(department);
            Schedule.Show(); 
        }

        private void machineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string department = "machine";
            schedule Schedule = new schedule(department);
            Schedule.Show(); 

        }

        private void actionItemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ActionItemReport actionitemreport = new ActionItemReport();
            actionitemreport.Show(); 
            
        }

        private void commentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string reporttype = "comment";
            ScheduleForms.MachSchedule mach = new ScheduleForms.MachSchedule(reporttype);
            mach.Show();


        }

        private void heatTreatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Rfq rfq = new Rfq();
            rfq.Show(); 
           
        }

        private void linkLotsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            JobLinking.LotLink lotlink = new JobLinking.LotLink();
            lotlink.Show(); 

        }

        private void machiningToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string reporttype = "machining"; 
            ScheduleForms.MachSchedule mach = new ScheduleForms.MachSchedule(reporttype);
            mach.Show(); 
        }

        private void shippingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string reporttype = "shipping";
            ScheduleForms.MachSchedule mach = new ScheduleForms.MachSchedule(reporttype);
            mach.Show(); 


        }

        private void completedJobsToolStripMenuItem_Click(object sender, EventArgs e)
        {

           string reporttype = "completedjobs";
            ScheduleForms.MachSchedule mach = new ScheduleForms.MachSchedule(reporttype);
            mach.Show(); 


           // ScheduleForms.CompletedJobsParameters comp = new ScheduleForms.CompletedJobsParameters();
            //comp.Show(); 
            
        }

        private void marginReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string reporttype = "marginreport";
            ScheduleForms.MachSchedule mach = new ScheduleForms.MachSchedule(reporttype);
            mach.Show(); 
        }

        private void outsourceReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string reporttype = "outsourcereport";
            ScheduleForms.MachSchedule mach = new ScheduleForms.MachSchedule(reporttype);
            mach.Show(); 

        }

        private void materialReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string reporttype = "materialreport";
            ScheduleForms.MachSchedule mach = new ScheduleForms.MachSchedule(reporttype);
            mach.Show(); 

            
        }

        private void purchasingToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void shToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string reporttype = "shippingreport";
            ScheduleForms.MachSchedule mach = new ScheduleForms.MachSchedule(reporttype);
            mach.Show(); 
                
        }

        private void teamReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string reporttype = "shippingteam";
            ScheduleForms.MachSchedule mach = new ScheduleForms.MachSchedule(reporttype);
            mach.Show();
        }

        private void createNewRedTagToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRedTag FrmRedTag = new frmRedTag();
            FrmRedTag.Show(); 

        }

        private void openRedTagToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RedTagOpen frmRedTagOpen = new RedTagOpen();
            frmRedTagOpen.Show(); 

        }

        private void costOfQualityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string reporttype = "coq";
            ScheduleForms.MachSchedule mach = new ScheduleForms.MachSchedule(reporttype);
            mach.Show();
        }

        private void redTagSummaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string reporttype = "redtag";
            ScheduleForms.MachSchedule mach = new ScheduleForms.MachSchedule(reporttype);
            mach.Show(); 

            
        }

        private void sofiasnotHermansReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string reporttype = "sofia";
            ScheduleForms.MachSchedule mach = new ScheduleForms.MachSchedule(reporttype);
            mach.Show(); 
        }

        private void materialByVendorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string reporttype = "materialvendor";
            ScheduleForms.MachSchedule mach = new ScheduleForms.MachSchedule(reporttype);
            mach.Show();

        }

        private void lineItemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string reporttype = "lineitems";
            ScheduleForms.MachSchedule mach = new ScheduleForms.MachSchedule(reporttype);
            mach.Show();
        }

        private void onTimeDeliveryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string reporttype = "ontimedelivery";
            ScheduleForms.MachSchedule mach = new ScheduleForms.MachSchedule(reporttype);
            mach.Show();
        }

        private void problemJobsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string reporttype = "problemjobs";
            ScheduleForms.MachSchedule mach = new ScheduleForms.MachSchedule(reporttype);
            mach.Show(); 
        }

        private void testGridToolStripMenuItem_Click(object sender, EventArgs e)
        {
         //   testGrid testgrid = new testGrid();
          //  testgrid.Show(); 
        }

        private void testGridSyncfusionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            testgrid2 tg2 = new testgrid2();
            tg2.Show(); 

        }

        private void viewClosedJobToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenJob oj1 = new OpenJob();
            oj1.Show(); 

        }

        private void laborTicketDetailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string reporttype = "laborticketdetail";
            ScheduleForms.MachSchedule mach = new ScheduleForms.MachSchedule(reporttype);
            mach.Show();
        }

        private void laborTicketDetailToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            string reporttype = "laborticketdetail_dept";
            ScheduleForms.MachSchedule mach = new ScheduleForms.MachSchedule(reporttype);
            mach.Show();
        }

        private void redTagSystemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            redtag2 rt2 = new redtag2();
            rt2.Show();  

        }

        private void hoursByDeptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string reporttype = "laborhoursdept";
            ScheduleForms.MachSchedule mach = new ScheduleForms.MachSchedule(reporttype);
            mach.Show(); 
           
        }

        private void openLaborTicketsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string reporttype = "openlabortickets";
            ScheduleForms.MachSchedule mach = new ScheduleForms.MachSchedule(reporttype);
            mach.Show();
        }

        private void gLLaborToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string reporttype = "gltickets";
            ScheduleForms.MachSchedule mach = new ScheduleForms.MachSchedule(reporttype);
            mach.Show();
        }

        private void showInventorySystemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InventoryMain inventoryMain = new InventoryMain();
            inventoryMain.Show(); 
        }

        private void newMeetingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Meeting meeting = new Meeting(); 

        }

        private void actionItemReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string reporttype = "actionitem";
            ScheduleForms.MachSchedule mach = new ScheduleForms.MachSchedule(reporttype);
            mach.Show();
        }

        private void showSupplierSystemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SupplierDB supp = new SupplierDB();
            supp.Show(); 

        }

        private void actualsReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string reporttype = "actualsreport";
            ScheduleForms.MachSchedule mach = new ScheduleForms.MachSchedule(reporttype);
            mach.Show();
        }
    }
}
