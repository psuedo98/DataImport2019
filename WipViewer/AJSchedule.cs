using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Syncfusion.WinForms.Input;
using Syncfusion.Windows.Forms.Tools;
using Syncfusion.Windows.Forms;
using WipViewer;
using System.Reflection; 


namespace WipViewer
{
    public partial class AJSchedule : Form
    {
        public TestEntities db1 = new TestEntities();
        public Scheduling sc1; 
        public DateTime dheldfordata;

        #region bools

        public bool bheldfordata;
        public bool bstartfab;
        public bool bFinishFab;
        public bool bStartMachine3;
        public bool bFinishMachine3;
        public bool bStartMachine5;
        public bool bFinishMachine5;
        public bool bStartAssembly;
        public bool bFinishAssembly;
        public bool bStartHeatTreat;
        public bool bFinishHeatTreat;
        public bool bMaterialOrderStart;
        public bool bMaterialOrderFinish;
        public bool bStartBench;
        public bool bFinishBench;
        public bool bStartPaint;
        public bool bFinishPaint;
        public bool bStartFinalize;
        public bool bFinishFinalize;
        public bool bStartTracker;
        public bool bFinishTracker;
        public bool bStartQA;
        public bool bFinishQA;
        public bool bSell;
        public bool bCommercialItemsOrder;
        public bool bCommercialItemsReceive;
        public bool bDesignStart;
        public bool bDesignFinish;
        public bool bReleaseManufacturing;

        public bool bexists; 

        #endregion
        #region datetimes

        public SfDateTimeEdit ddheld;
        public SfDateTimeEdit ddstartfab;
        public SfDateTimeEdit ddfinishfab;
        public SfDateTimeEdit ddstartmachine3;
        public SfDateTimeEdit ddfinishmachine3;
        public SfDateTimeEdit ddstartmachine5;
        public SfDateTimeEdit ddfinishmachine5;
        public SfDateTimeEdit ddStartAssembly;
        public SfDateTimeEdit ddFinishAssembly;
        public SfDateTimeEdit ddStartHeatTreat;
        public SfDateTimeEdit ddFinishHeatTreat;
        public SfDateTimeEdit ddMaterialOrderStart;
        public SfDateTimeEdit ddMaterialOrderFinish;
        public SfDateTimeEdit ddStartBench;
        public SfDateTimeEdit ddFinishBench;
        public SfDateTimeEdit ddStartPaint;
        public SfDateTimeEdit ddFinishPaint;
        public SfDateTimeEdit ddStartFinalize;
        public SfDateTimeEdit ddFinishFinalize;
        public SfDateTimeEdit ddStartTracker;
        public SfDateTimeEdit ddFinishTracker;
        public SfDateTimeEdit ddStartQA;
        public SfDateTimeEdit ddFinishQA;
        public SfDateTimeEdit ddSell;
        public SfDateTimeEdit ddCommercialItemsOrder;
        public SfDateTimeEdit ddCommercialItemsReceive;
        public SfDateTimeEdit ddDesignStart;
        public SfDateTimeEdit ddDesignFinish;
        public SfDateTimeEdit ddReleaseManufacturing;


        #endregion


        public string contraint1;
        public AJSchedule()
        {
            InitializeComponent();
        }

        public AJSchedule(string jobnumber)
        {
            InitializeComponent();

            sc1 = db1.Schedulings.Find(jobnumber);

            if (sc1 == null)
            {
                sc1 = new Scheduling(); 
                sc1.Base_ID = jobnumber;
                bexists = false; 
            }

            else
            {
                bexists = true;
                this.Controls.Clear(); 

                if (sc1.DataHold == null)
                {

                }
                else
                {

                }

                
            }
        }

        private void buttonAdv1_Click(object sender, EventArgs e)
        {
            #region if statements 
            if (bheldfordata == true)
            {
                sc1.DataHold = Convert.ToDateTime(ddheld.DateTimeText);
            }
            if (bstartfab == true)
            {
                sc1.StartFab = Convert.ToDateTime(ddstartfab.DateTimeText);
            }
            if (bFinishFab == true)
            {
                sc1.FinishFab = Convert.ToDateTime(ddfinishfab.DateTimeText);
            }
            if (bStartMachine3 == true)
            {
                sc1.StartMach3 = Convert.ToDateTime(ddstartmachine3.DateTimeText);
            }
            if (bFinishMachine3 == true)
            {
                sc1.FinishMach3 = Convert.ToDateTime(ddfinishmachine3.DateTimeText);
            }
            if (bStartMachine5 == true)
            {
                sc1.StartMach5 = Convert.ToDateTime(ddstartmachine5.DateTimeText);
            }
            if (bFinishMachine5 == true)
            {
                sc1.FinishMach5 = Convert.ToDateTime(ddfinishmachine5.DateTimeText);
            }
            if (bStartAssembly == true)
            {
                sc1.StartAssembly = Convert.ToDateTime(ddStartAssembly.DateTimeText);
            }
            if (bFinishAssembly == true)
            {
                sc1.FinishAsssembly = Convert.ToDateTime(ddFinishAssembly.DateTimeText);
            }
            if (bStartHeatTreat == true)
            {
                sc1.StartHeat = Convert.ToDateTime(ddStartHeatTreat.DateTimeText);
            }
            if (bFinishHeatTreat == true)
            {
                sc1.FinishHeat = Convert.ToDateTime(ddFinishHeatTreat.DateTimeText);
            }
            if (bMaterialOrderStart == true)
            {
                sc1.StartMaterial = Convert.ToDateTime(ddMaterialOrderStart.DateTimeText);
            }
            if (bMaterialOrderFinish == true)
            {
                sc1.FinishMaterial = Convert.ToDateTime(ddMaterialOrderFinish.DateTimeText);
            }
            if (bStartBench == true)
            {
                sc1.StartBench = Convert.ToDateTime(ddStartBench.DateTimeText);
            }
            if (bFinishBench == true)
            {
                sc1.FinishBench = Convert.ToDateTime(ddFinishBench.DateTimeText);
            }

            if (bStartPaint == true)
            {
                sc1.StartPaint = Convert.ToDateTime(ddStartPaint.DateTimeText);
            }
            if (bFinishPaint == true)
            {
                sc1.FinishPaint = Convert.ToDateTime(ddFinishPaint.DateTimeText);
            }
            if (bStartFinalize == true)
            {
                sc1.StartFinalize = Convert.ToDateTime(ddStartFinalize.DateTimeText);
            }
            if (bFinishFinalize == true)
            {
                sc1.FinishFinalize = Convert.ToDateTime(ddFinishFinalize.DateTimeText);
            }
            if (bStartTracker == true)
            {
                sc1.StartTracker = Convert.ToDateTime(ddStartTracker.DateTimeText);
            }
            if (bFinishTracker == true)
            {
                sc1.FinishTracker = Convert.ToDateTime(ddFinishTracker.DateTimeText);
            }
            if (bStartQA == true)
            {
                sc1.StartQa = Convert.ToDateTime(ddStartQA.DateTimeText);
            }
            if (bFinishQA == true)
            {
                sc1.FinishQa = Convert.ToDateTime(ddFinishQA.DateTimeText);
            }
            if (bSell == true)
            {
                sc1.StartSts = Convert.ToDateTime(ddSell.DateTimeText);
            }
            if (bCommercialItemsOrder == true)
            {
                sc1.StartCommercial = Convert.ToDateTime(ddCommercialItemsOrder.DateTimeText);
            }
            if (bCommercialItemsReceive == true)
            {
                sc1.FinishCommercial = Convert.ToDateTime(ddCommercialItemsReceive.DateTimeText);
            }
            if (bDesignStart == true)
            {
                sc1.StartDesign = Convert.ToDateTime(ddDesignStart.DateTimeText);
            }
            if (bDesignFinish == true)
            {
                sc1.FinishDesign = Convert.ToDateTime(ddDesignFinish.DateTimeText);
            }
            if (bReleaseManufacturing == true)
            {
                sc1.DesignRelease = Convert.ToDateTime(ddReleaseManufacturing.DateTimeText);
            }

            #endregion

            db1.Schedulings.Add(sc1); 
            db1.SaveChanges(); 

        }
  


        private void queryBuilder(string scheduler, SfDateTimeEdit sfd)
            
        {
            switch (scheduler)
            {
                case "Held For Data":
                    bheldfordata = true;
                    ddheld = sfd; 
                    break;
                case "Start Fab":
                    bstartfab = true;
                    ddstartfab = sfd;
                    break;
                case "Finish Fab":
                    bFinishFab = true;
                    ddfinishfab = sfd;
                    break; 
                case "Start Machine (3 Axis)":
                    bStartMachine3 = true;
                    ddstartmachine3 = sfd;
                    break;
                case "Finish Machine (3 Axis)":
                    bFinishMachine3 = true;
                    ddfinishmachine3 = sfd;
                    break;
                case "Start Machine (5 Axis)":
                    bStartMachine5 = true;
                    ddstartmachine5 = sfd;
                    break;
                case "Finish Machine (5 Axis)":
                    bFinishMachine5 = true;
                    ddfinishmachine5 = sfd;
                    break;
                case "Start Assembly":
                    bStartAssembly = true;
                    ddStartAssembly = sfd;
                    break;
                case "Finish Assmbly":
                    bFinishAssembly = true;
                    ddFinishAssembly = sfd;
                    break;
                case "Start Heat Treat":
                    bStartHeatTreat = true;
                    ddStartHeatTreat = sfd;
                    break; 
                case "Finish Heat Treat":
                    bFinishHeatTreat = true;
                    ddFinishHeatTreat = sfd;
                    break; 
                case "Material Order Start":
                    bMaterialOrderStart = true;
                    ddMaterialOrderStart = sfd;
                    break;
                case "Material Order Finish":
                    bMaterialOrderFinish = true;
                    ddMaterialOrderFinish = sfd;
                    break;
                case "Start Bench":
                    bStartBench = true;
                    ddStartBench = sfd;
                    break;
                case "Finish Bench":
                    bFinishBench = true;
                    ddFinishBench = sfd;
                    break; 
                case "Start Paint":
                    bStartPaint = true;
                    ddStartPaint = sfd;
                    break; 
                case "Finish Paint":
                    bFinishPaint = true;
                    ddFinishPaint = sfd;
                    break; 
                case "Finalize Start":
                    bStartFinalize = true;
                    ddStartFinalize = sfd;
                    break; 
                case "Finalize Finish":
                    bFinishFinalize = true;
                    ddFinishFinalize = sfd;
                    break;
                case "Tracker Start":
                    bStartTracker = true;
                    ddStartTracker = sfd;
                    break; 
                case "Tracker Finish":
                    bFinishTracker = true;
                    ddFinishTracker = sfd;
                    break;
                case "Start QA":
                    bStartQA = true;
                    ddStartQA = sfd;
                    break;
                case "Finish QA":
                    bFinishQA = true;
                    ddFinishQA = sfd;
                    break;
                case "Sell to Source":
                    bSell = true;
                    ddSell = sfd;
                    break;
                case "Commercial Items Order":
                    bCommercialItemsOrder = true;
                    ddCommercialItemsOrder = sfd;
                    break;
                case "Commercial Items Recieve":
                    bCommercialItemsReceive = true;
                    ddCommercialItemsReceive = sfd;
                    break;
                case "Design Start":
                    bDesignStart = true;
                    ddDesignStart = sfd;
                    break;
                case "DesignFinish":
                    bDesignFinish = true;
                    ddDesignFinish = sfd;
                    break;
                case "Release to Manufacturing":
                    bReleaseManufacturing = true;
                    ddReleaseManufacturing = sfd;
                    break;





            }
        }
       

        #region Selection Change Event Handlers
        public void cmb1_SelectedValueChanged(object sender, EventArgs e)
        {
            SfDateTimeEdit Dt1 = new SfDateTimeEdit();
            this.Controls.Add(Dt1);
            string task = cmb1.Text; 

            int y = cmb1.Location.Y - 6;
            int x = cmb1.Location.X + 192;

            Dt1.Location = new Point(x, y);
            Dt1.Size = new Size(101, 32);

            foreach (Control C in this.Controls)
            {
                if (C.GetType() == typeof(ComboBoxAdv))
                {
                    ComboBoxAdv cc = C as ComboBoxAdv;
                    cc.Items.Remove(cmb1.Text); 
                }
            }

            cmb1.Text = task;

            queryBuilder(task, Dt1); 


        }
        private void cmb2_SelectedValueChanged(object sender, EventArgs e)
        {
            SfDateTimeEdit Dt2 = new SfDateTimeEdit();
            this.Controls.Add(Dt2);
            string task = cmb2.Text;

            int y = cmb2.Location.Y - 6;
            int x = cmb2.Location.X + 192;

            Dt2.Location = new Point(x, y);
            Dt2.Size = new Size(101, 32);

            foreach (Control C in this.Controls)
            {
                if (C.GetType() == typeof(ComboBoxAdv))
                {
                    ComboBoxAdv cc = C as ComboBoxAdv;
                    cc.Items.Remove(cmb2.Text);
                }
            }

            cmb2.Text = task;

            queryBuilder(task, Dt2);

        }
        private void comboBoxAdv1_SelectedValueChanged(object sender, EventArgs e)
        {
            SfDateTimeEdit Dt3 = new SfDateTimeEdit();
            this.Controls.Add(Dt3);
            string task = cmb3.Text;

            int y = cmb3.Location.Y - 6;
            int x = cmb3.Location.X + 192;

            Dt3.Location = new Point(x, y);
            Dt3.Size = new Size(101, 32);

            foreach (Control C in this.Controls)
            {
                if (C.GetType() == typeof(ComboBoxAdv))
                {
                    ComboBoxAdv cc = C as ComboBoxAdv;
                    cc.Items.Remove(cmb3.Text);
                }
            }
            cmb3.Text = task;

            queryBuilder(task, Dt3);

        }
        private void cmb4_SelectedValueChanged(object sender, EventArgs e)
        {
            SfDateTimeEdit Dt4 = new SfDateTimeEdit();
            this.Controls.Add(Dt4);
            string task = cmb4.Text;

            int y = cmb4.Location.Y - 6;
            int x = cmb4.Location.X + 192;

            Dt4.Location = new Point(x, y);
            Dt4.Size = new Size(101, 32);

            foreach (Control C in this.Controls)
            {
                if (C.GetType() == typeof(ComboBoxAdv))
                {
                    ComboBoxAdv cc = C as ComboBoxAdv;
                    cc.Items.Remove(cmb4.Text);
                }
            }

            cmb4.Text = task;

            queryBuilder(task, Dt4);
        }
        private void cmb5_SelectedValueChanged(object sender, EventArgs e)
        {
            SfDateTimeEdit Dt5 = new SfDateTimeEdit();
            this.Controls.Add(Dt5);
            string task = cmb5.Text;

            int y = cmb5.Location.Y - 6;
            int x = cmb5.Location.X + 192;

            Dt5.Location = new Point(x, y);
            Dt5.Size = new Size(101, 32);

            foreach (Control C in this.Controls)
            {
                if (C.GetType() == typeof(ComboBoxAdv))
                {
                    ComboBoxAdv cc = C as ComboBoxAdv;
                    cc.Items.Remove(cmb5.Text);
                }
            }

            cmb5.Text = task;

            queryBuilder(task, Dt5);
        }
        private void cmb6_SelectedValueChanged(object sender, EventArgs e)
        {
            SfDateTimeEdit Dt6 = new SfDateTimeEdit();
            this.Controls.Add(Dt6);
            string task = cmb6.Text;

            int y = cmb6.Location.Y - 6;
            int x = cmb6.Location.X + 192;

            Dt6.Location = new Point(x, y);
            Dt6.Size = new Size(101, 32);

            foreach (Control C in this.Controls)
            {
                if (C.GetType() == typeof(ComboBoxAdv))
                {
                    ComboBoxAdv cc = C as ComboBoxAdv;
                    cc.Items.Remove(cmb6.Text);
                }
            }

            cmb6.Text = task;
            queryBuilder(task, Dt6);
        }
        private void cmb7_SelectedValueChanged(object sender, EventArgs e)
        {
            SfDateTimeEdit Dt7 = new SfDateTimeEdit();
            this.Controls.Add(Dt7);

            string task = cmb7.Text;

            int y = cmb7.Location.Y - 6;
            int x = cmb7.Location.X + 192;

            Dt7.Location = new Point(x, y);
            Dt7.Size = new Size(101, 32);

            foreach (Control C in this.Controls)
            {
                if (C.GetType() == typeof(ComboBoxAdv))
                {
                    ComboBoxAdv cc = C as ComboBoxAdv;
                    cc.Items.Remove(cmb7.Text);
                }
            }

            cmb7.Text = task;
            queryBuilder(task, Dt7);
        }
        private void cmb8_SelectedValueChanged(object sender, EventArgs e)
        {
            SfDateTimeEdit Dt8 = new SfDateTimeEdit();
            this.Controls.Add(Dt8);

            string task = cmb8.Text; 

            int y = cmb8.Location.Y - 6;
            int x = cmb8.Location.X + 192;

            Dt8.Location = new Point(x, y);
            Dt8.Size = new Size(101, 32);

            foreach (Control C in this.Controls)
            {
                if (C.GetType() == typeof(ComboBoxAdv))
                {
                    ComboBoxAdv cc = C as ComboBoxAdv;
                    cc.Items.Remove(cmb8.Text);
                }
            }

            cmb8.Text = task;
            queryBuilder(task, Dt8);
        }
        private void cmb9_SelectedValueChanged(object sender, EventArgs e)
        {
            SfDateTimeEdit Dt9 = new SfDateTimeEdit();
            this.Controls.Add(Dt9);

            string task = cmb9.Text; 

            int y = cmb9.Location.Y - 6;
            int x = cmb9.Location.X + 192;

            Dt9.Location = new Point(x, y);
            Dt9.Size = new Size(101, 32);

            foreach (Control C in this.Controls)
            {
                if (C.GetType() == typeof(ComboBoxAdv))
                {
                    ComboBoxAdv cc = C as ComboBoxAdv;
                    cc.Items.Remove(cmb9.Text);
                }
            }

            cmb9.Text = task;
            queryBuilder(task, Dt9);
        }
        private void cmb10_SelectedValueChanged(object sender, EventArgs e)
        {
            SfDateTimeEdit Dt10 = new SfDateTimeEdit();
            this.Controls.Add(Dt10);

            string task = cmb10.Text;

            int y = cmb10.Location.Y - 6;
            int x = cmb10.Location.X + 192;

            Dt10.Location = new Point(x, y);
            Dt10.Size = new Size(101, 32);

            foreach (Control C in this.Controls)
            {
                if (C.GetType() == typeof(ComboBoxAdv))
                {
                    ComboBoxAdv cc = C as ComboBoxAdv;
                    cc.Items.Remove(cmb10.Text);
                }
            }

            cmb10.Text = task;
            queryBuilder(task, Dt10);
        }
        private void cmb11_SelectedValueChanged(object sender, EventArgs e)
        {

            SfDateTimeEdit Dt11 = new SfDateTimeEdit();
            this.Controls.Add(Dt11);

            string task = cmb11.Text;

            int y = cmb11.Location.Y - 6;
            int x = cmb11.Location.X + 192;

            Dt11.Location = new Point(x, y);
            Dt11.Size = new Size(101, 32);

            foreach (Control C in this.Controls)
            {
                if (C.GetType() == typeof(ComboBoxAdv))
                {
                    ComboBoxAdv cc = C as ComboBoxAdv;
                    cc.Items.Remove(cmb11.Text);
                }
            }

            cmb11.Text = task;
            queryBuilder(task, Dt11);

        }
        private void cmb12_SelectedValueChanged(object sender, EventArgs e)
        {


            SfDateTimeEdit Dt12 = new SfDateTimeEdit();
            this.Controls.Add(Dt12);

            string task = cmb12.Text;

            int y = cmb12.Location.Y - 6;
            int x = cmb12.Location.X + 192;

            Dt12.Location = new Point(x, y);
            Dt12.Size = new Size(101, 32);

            foreach (Control C in this.Controls)
            {
                if (C.GetType() == typeof(ComboBoxAdv))
                {
                    ComboBoxAdv cc = C as ComboBoxAdv;
                    cc.Items.Remove(cmb12.Text);
                }
            }

            cmb12.Text = task;
            queryBuilder(task, Dt12);

        }
        private void cmb13_SelectedValueChanged(object sender, EventArgs e)
        {


            SfDateTimeEdit Dt13 = new SfDateTimeEdit();
            this.Controls.Add(Dt13);

            string task = cmb13.Text;

            int y = cmb13.Location.Y - 6;
            int x = cmb13.Location.X + 192;

            Dt13.Location = new Point(x, y);
            Dt13.Size = new Size(101, 32);

            foreach (Control C in this.Controls)
            {
                if (C.GetType() == typeof(ComboBoxAdv))
                {
                    ComboBoxAdv cc = C as ComboBoxAdv;
                    cc.Items.Remove(cmb13.Text);
                }
            }

            cmb13.Text = task;
            queryBuilder(task, Dt13);
        }
        private void cmb14_SelectedValueChanged(object sender, EventArgs e)
        {
            SfDateTimeEdit Dt14 = new SfDateTimeEdit();
            this.Controls.Add(Dt14);

            string task = cmb14.Text;

            int y = cmb14.Location.Y - 6;
            int x = cmb14.Location.X + 192;

            Dt14.Location = new Point(x, y);
            Dt14.Size = new Size(101, 32);

            foreach (Control C in this.Controls)
            {
                if (C.GetType() == typeof(ComboBoxAdv))
                {
                    ComboBoxAdv cc = C as ComboBoxAdv;
                    cc.Items.Remove(cmb14.Text);
                }
            }

            cmb14.Text = task;
            queryBuilder(task, Dt14);

        }
        private void cmb15_SelectedValueChanged(object sender, EventArgs e)
        {
            SfDateTimeEdit Dt15 = new SfDateTimeEdit();
            this.Controls.Add(Dt15);

            string task = cmb15.Text;

            int y = cmb15.Location.Y - 6;
            int x = cmb15.Location.X + 192;

            Dt15.Location = new Point(x, y);
            Dt15.Size = new Size(101, 32);

            foreach (Control C in this.Controls)
            {
                if (C.GetType() == typeof(ComboBoxAdv))
                {
                    ComboBoxAdv cc = C as ComboBoxAdv;
                    cc.Items.Remove(cmb15.Text);
                }
            }

            cmb15.Text = task;
            queryBuilder(task, Dt15);

        }
        private void cmb16_SelectedValueChanged(object sender, EventArgs e)
        {
            SfDateTimeEdit Dt16 = new SfDateTimeEdit();
            this.Controls.Add(Dt16);

            string task = cmb16.Text;

            int y = cmb16.Location.Y - 6;
            int x = cmb16.Location.X + 192;

            Dt16.Location = new Point(x, y);
            Dt16.Size = new Size(101, 32);

            foreach (Control C in this.Controls)
            {
                if (C.GetType() == typeof(ComboBoxAdv))
                {
                    ComboBoxAdv cc = C as ComboBoxAdv;
                    cc.Items.Remove(cmb16.Text);
                }
            }

            cmb16.Text = task;
            queryBuilder(task, Dt16);
        }
        private void cmb17_SelectedValueChanged(object sender, EventArgs e)
        {

            SfDateTimeEdit Dt17 = new SfDateTimeEdit();
            this.Controls.Add(Dt17);

            string task = cmb17.Text;

            int y = cmb17.Location.Y - 6;
            int x = cmb17.Location.X + 192;

            Dt17.Location = new Point(x, y);
            Dt17.Size = new Size(101, 32);

            foreach (Control C in this.Controls)
            {
                if (C.GetType() == typeof(ComboBoxAdv))
                {
                    ComboBoxAdv cc = C as ComboBoxAdv;
                    cc.Items.Remove(cmb17.Text);
                }
            }

            cmb17.Text = task;
            queryBuilder(task, Dt17);

        }
        private void cmb18_SelectedValueChanged(object sender, EventArgs e)
        {

            SfDateTimeEdit Dt18 = new SfDateTimeEdit();
            this.Controls.Add(Dt18);

            string task = cmb18.Text;

            int y = cmb18.Location.Y - 6;
            int x = cmb18.Location.X + 192;

            Dt18.Location = new Point(x, y);
            Dt18.Size = new Size(101, 32);

            foreach (Control C in this.Controls)
            {
                if (C.GetType() == typeof(ComboBoxAdv))
                {
                    ComboBoxAdv cc = C as ComboBoxAdv;
                    cc.Items.Remove(cmb18.Text);
                }
            }

            cmb18.Text = task;
            queryBuilder(task, Dt18);

        }

        #endregion

        private void cmb3_Click(object sender, EventArgs e)
        {

        }

       
    
    }
    
}



