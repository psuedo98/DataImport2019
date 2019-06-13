using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WipViewer
{
    
    public partial class SupplierAdd : Form
    {
        public string strFile1;
        public string strFile2;
        public string strFile3;
        public string strFile4; 
        public bool bIso;
        public bool bAs;
        public bool bItar;
        public bool bOther; 

        public SupplierAdd()
        {
            InitializeComponent();
            
        
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void rbDirect_CheckedChanged(object sender, EventArgs e)
        {
            panelIndirect.Visible = false;
            panelDirect.Visible = true; 
        }

        private void rbIndirect_CheckedChanged(object sender, EventArgs e)
        {
            panelIndirect.Visible = true;
            panelIndirect.Visible = false; 
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            dtpIso.Visible = true; 
            btnUploadIso.Visible = true; 
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            btnUploadIso.Visible = false;
            dtpIso.Visible = false; 
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            btnUploadAs.Visible = true;
            dtpAS.Visible = true; 

        }

        private void button1_Click(object sender, EventArgs e)
        {
            TestEntities db1 = new TestEntities();
            // CommentEntities db = new CommentEntities();

            SupplierMain supp1 = new SupplierMain(); 

            supp1.Name = txtSupplierName.Text;
            supp1.Risk = cmbRisk.Text;
            supp1.VendorID = txtVendorId.Text; 
            supp1.Email = txtEmail.Text;
            supp1.PrimaryContact = txtPrimaryContact.Text;
           
            supp1.EvalDate = dtpEval.Value; 

            db1.SupplierMains.Add(supp1);


            if (rbDirect.Checked == true)
            {
                SupplierDirect supp2 = new SupplierDirect();
                supp2.Name = txtSupplierName.Text; 
                supp2.FOB = txtFob.Text;
                supp2.PrimaryCommodity = cmbPrimary.Text;
                supp2.SecondaryCommodity = cmbSecondary.Text; 
                
                if (rbAsYes.Checked == true)

                    {
                    supp2.AS9100Registration = "True";
                    supp2.ASExpiration = dtpAS.Value;
                    supp2.ASDocument = "Test";
                    }
                else
                {
                    supp2.AS9100Registration = "False"; 
                }

                if (rbIsoYes.Checked == true)
                {
                    supp2.IsoRegistration = "True";
                    supp2.IsoExpiration = dtpIso.Value;
                    supp2.IsoDocument = "Test"; 

                }
                else
                {
                    supp2.IsoRegistration = "False"; 
                }

                if (rbOtherYes.Checked == true)
                {
                    supp2.OtherRegistration = "True";
                    supp2.OtherExpiration = dtpOther.Value;
                    supp2.OtherDocument = "Test"; 
                }
                else
                {
                    supp2.OtherRegistration = "False"; 
                }

                if (rbItarYes.Checked == true)
                {
                    supp2.ItarApproved = "True";
                    supp2.ItarExpiration = dtpItar.Value;
                    supp2.ItarDocument = "Test"; 
                }
                else
                {
                    supp2.ItarApproved = "False"; 
                }

                if (rbDpdYes.Checked == true)
                {
                    supp2.DPDApproval = "True"; 
                }
                else
                {
                    supp2.DPDApproval = "False"; 
                }

                if (rbSpecialYes.Checked == true)
                {
                    supp2.SpecialProcesses = "True";
                    supp2.SpecialProcessDetail = txtSpecialDetail.Text; 
                }

                string path = "r:\\wipviewer2017\\suppliers\\" + txtSupplierName.Text;
                System.IO.Directory.CreateDirectory(path);

                if (bIso == true)
                {


                    System.IO.File.Copy(strFile1, path + "\\Iso.pdf");
                    supp2.IsoDocument = path + "\\Iso.pdf"; 

                }
                else
                {
                    MessageBox.Show("Fuck Me. No Iso File.");
                    supp2.IsoDocument = "None"; 
                }

                if (bAs == true)
                {


                    System.IO.File.Copy(strFile2, path + "\\AS9100.pdf");
                    supp2.ASDocument = path + "\\AS9100.pdf";
                }
                else
                {
                    MessageBox.Show("No As");
                    supp2.ASDocument = "None";
                }

                if (bOther == true)
                {


                    System.IO.File.Copy(strFile3, path + "\\Other.pdf");
                    supp2.OtherDocument = path + "\\Other.pdf"; 
                }
                else
                {
                    MessageBox.Show("No Other");
                    supp2.OtherDocument = "None";
                }

                if (bItar == true)
                {


                    System.IO.File.Copy(strFile4, path + "\\Itar.pdf");
                    supp2.ItarDocument = path + "\\Itar.pdf"; 
                }
                else
                {
                    MessageBox.Show("No Itar");
                    supp2.ItarDocument = "None";

                }


                db1.SupplierDirects.Add(supp2); 


            }

            
            
            
            db1.SaveChanges();
            MessageBox.Show("Supplier Added. Fuck Yea!");


        }

        private void directsupplier()
        {

        }

        private void rbAsNo_CheckedChanged(object sender, EventArgs e)
        {
            dtpAS.Visible = false;
            btnUploadAs.Visible = false; 
        }

        private void dtpAS_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnUploadAs_Click(object sender, EventArgs e)
        {
            bAs = true;

            if (ofd1.ShowDialog() == DialogResult.OK)
            {
                strFile2 = ofd1.FileName;


            }
        }

        private void rbOtherYes_CheckedChanged(object sender, EventArgs e)
        {
            dtpOther.Visible = true;
            btnUploadOther.Visible = true; 
        }

        private void rbItarYes_CheckedChanged(object sender, EventArgs e)
        {
            dtpItar.Visible = true;
            btnUploadItar.Visible = true; 
        }

        private void rbItarNo_CheckedChanged(object sender, EventArgs e)
        {
            dtpItar.Visible = false;
            btnUploadItar.Visible = false; 


        }

        private void btnUploadIso_Click(object sender, EventArgs e)
        {
            bIso = true; 

            if (ofd1.ShowDialog() == DialogResult.OK)
            {
                strFile1 = ofd1.FileName; 
              
              
            }
        }

        private void rbOtherNo_CheckedChanged(object sender, EventArgs e)
        {
            btnUploadOther.Visible = false;
            dtpOther.Visible = false; 


        }

        private void btnUploadOther_Click(object sender, EventArgs e)
        {
            bOther = true;

            if (ofd1.ShowDialog() == DialogResult.OK)
            {
                strFile3 = ofd1.FileName;


            }
        }

        private void btnUploadItar_Click(object sender, EventArgs e)
        {
            bItar = true;

            if (ofd1.ShowDialog() == DialogResult.OK)
            {
                strFile4 = ofd1.FileName;


            }
        }
    }
    }

