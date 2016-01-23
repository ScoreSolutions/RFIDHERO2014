using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FaceCrop_Sample
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Pic.Visible = false;
            FacePic.Visible = false;
        }
        public void Upload(object sender, EventArgs e)
        {
            string FilePath = myFile.PostedFile.FileName;
            int slashpos = FilePath.LastIndexOf('\\');
            if (slashpos < 0) 
                slashpos = -1;
            string FileName = FilePath.Substring(slashpos+1);
      
            myFile.PostedFile.SaveAs("C:\\inetpub\\wwwroot\\" + FileName);

            lblMsg.Text = FileName + " uploaded";

		
            #if ! __DEBUG
            Error: please request the evaluation license key from Luxand, Inc., comment these lines and assign the key to LicenseKey.
            Please visit http://www.luxand.com/facecrop/ to request the key
            #endif
            string LicenseKey = "";
 
            Luxand.fc.Activate(LicenseKey);
            
            Luxand.fc.FaceCrop("C:\\inetpub\\wwwroot\\" + FileName,
                "C:\\inetpub\\wwwroot\\" + FileName + "-crop.jpg", 128, 196);
            
            Luxand.fc.Finalize();

            Pic.ImageUrl = FileName;
            Pic.Visible = true;
            FacePic.ImageUrl = FileName + "-crop.jpg";
            FacePic.Visible = true;
        }
    }
}
