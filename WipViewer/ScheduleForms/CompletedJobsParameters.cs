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

namespace WipViewer.ScheduleForms
{
    public partial class CompletedJobsParameters : Form
    {
        public CompletedJobsParameters()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            ParameterField startdate = new ParameterField();
            startdate.Name = "@Starting Ship Date";
            ParameterDiscreteValue startdiscrete = new ParameterDiscreteValue();
            startdiscrete.Value = dateTimePicker1.Value.Date;
            startdate.CurrentValues.Add(startdiscrete);

            ParameterField enddate = new ParameterField();
            enddate.Name = "@Starting Ship Date";
            ParameterDiscreteValue enddiscrete = new ParameterDiscreteValue();
            startdiscrete.Value = dateTimePicker2.Value.Date;
           enddate.CurrentValues.Add(enddiscrete);

            string reporttype = "completedjobs";
            
            ScheduleForms.MachSchedule mach = new ScheduleForms.MachSchedule(startdiscrete, enddiscrete);
            mach.Show();



        }
    }
}
