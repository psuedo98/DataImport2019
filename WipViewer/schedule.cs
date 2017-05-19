using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WipViewer; 

namespace WipViewer
{
    public partial class schedule : Form
    {
        public string department; 
        public schedule()
        {
            InitializeComponent();
        }

        public schedule(string dept)
        {
            department = dept; 
            InitializeComponent(); 
        }

        public void schedule_Load(object sender, EventArgs e)
        {
            int xx1= 12;
            int xx2 = 127;
            int xx3 = 237;
            int xx4 = 354; 
            int yy = 24;
            if (department == "fab")
            {

                lblCategory.Text = "Start Fab";
                lblfinsih.Visible = false; 

                using (var context = new TestEntities())
                {
                    var jobs = from b in context.ImportantDates

                          .Where(b => b.StartFab.ToString() != "0001-01-01")
                          .OrderBy(x => x.StartFab)
                  
                          select b;
                    var result = jobs.ToList(); 
                    var count = jobs.Count();
                    

                    for (int i = 0; i < count; i++)
                    {
                        Controls.Add(new Label { Location = new Point(xx1, yy), AutoSize = true, Text = result[i].BaseID.ToString() });
                        Controls.Add(new Label { Location = new Point(xx2, yy), AutoSize = true, Text = result[i].StartFab.ToString() });
                     //   Controls.Add(new Label { Location = new Point(xx3, yy), AutoSize = true, Text = result[i].h})
                        yy += 20; 

                    }

                }
            }
            if (department == "machine")
            {
                lblCategory.Text = "Start Machine";
                lblfinsih.Text = "Machine Complete";
                

                using (var context = new TestEntities())
                {
                    var jobs = from b in context.ImportantDates

                          .Where(b => b.StartMachining.ToString() != "0001-01-01")
                          .OrderBy(x => x.StartMachining)

                               select b;
                    var result = jobs.ToList();
                    var count = jobs.Count();


                    for (int i = 0; i < count; i++)
                    {
                        Controls.Add(new Label { Location = new Point(xx1, yy), AutoSize = true, Text = result[i].BaseID.ToString() });
                        Controls.Add(new Label { Location = new Point(xx2, yy), AutoSize = true, Text = Convert.ToDateTime(result[i].StartMachining).ToString("MM/dd/yyyy") });
                        Controls.Add(new Label { Location = new Point(xx3, yy), AutoSize = true, Text = Convert.ToDateTime(result[i].MachComp).ToString("MM/dd/yyyy")});
                        yy += 20;

                    }

                }
            }




        }
    }
}
