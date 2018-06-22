using System;
using Microsoft.Office.Tools.Ribbon;
using Outlook = Microsoft.Office.Interop.Outlook;


namespace MessageExport
{
    public partial class Ribbon
    {
        private void Ribbon_Load(object sender, RibbonUIEventArgs e)
        {

        }

        private void bntExport_Click(object sender, RibbonControlEventArgs e)
        {
            Outlook.Application olApp = new Outlook.Application();
            //Microsoft.Office.Interop.Outlook.Inspector myItem = new Inspector();


            //MailItem msg1 = new MailItem(myItem.CurrentItem);

            int SavedMsgCounter = 0;
            foreach (Object selObject in olApp.ActiveExplorer().Selection)
            {
                SavedMsgCounter++;
                if ((selObject is Outlook.MailItem))
                {
                    Outlook.MailItem mailItem = (selObject as Outlook.MailItem);
                    //   Outlook.UserProperty userProp = mailItem.UserProperties["SOMEFLAG"];
                    //if (userProp != null)
                    //{
                    //    userProp.Delete();
                    //}
                    //else
                    //{
                    //    mailItem.UserProperties.Add("SOMEFLAG", Outlook.OlUserPropertyType.olYesNo, null, null).Value = "True";
                    //    // mailItem.SaveAs(@"c:\test" + SavedMsgCounter.ToString() + ".msg", Outlook.OlSaveAsType.olMSGUnicode);
                    //}

                    info Info = new MessageExport.info(mailItem);
                    Info.Show(); 


                    //mailItem.SaveAs("R:\\wipviewer2017\\jobfiles\\MOST1008VCT_1\\Emails\\message.msg", Outlook.OlSaveAsType.olMSG);
                    //mailItem.Save();
                }

            }
        }
    }
}
