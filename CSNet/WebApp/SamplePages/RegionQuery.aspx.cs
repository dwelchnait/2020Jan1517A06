using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

#region Additional Namespaces
using NorthwindSystem.BLL;
using NorthwindSystem.Entities;
#endregion

namespace WebApp.SamplePages
{
    public partial class RegionQuery : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            MessageLabel.Text = "";

        }

        //use this method to discover the inner most error message.
        protected Exception GetInnerException(Exception ex)
        {
            //drill down to the inner most exception
            while (ex.InnerException != null)
            {
                ex = ex.InnerException;
            }
            return ex;
        }

        protected void Fetch_Click(object sender, EventArgs e)
        {
            int regionid = 0;
            if (string.IsNullOrEmpty(RegionArg.Text))
            {
                MessageLabel.Text = "Supply a region id before searching";
            }
            else if (!int.TryParse(RegionArg.Text, out regionid))
            {
                MessageLabel.Text = "Region id must be a number";
            }
            else
            {
                //your web application will be calling another project
                //you are to wrap this processing up in a Try/Catch
                try
                {
                    //standard lookup
                    //a) connect to your controller
                    RegionController sysmgr = new RegionController();
                    //b) call the method in the system controller class
                    //   and capture the returning data
                    Region info = sysmgr.Regions_FindByID(int.Parse(RegionArg.Text));
                    //c) check results and process accordingly
                    if (info == null)
                    {
                        //not found
                        MessageLabel.Text = "There is no region for the supplied argument";
                        RegionID.Text = "";
                        Description.Text = "";
                    }
                    else
                    {
                        //found
                        RegionID.Text = info.RegionID.ToString();
                        Description.Text = info.RegionDescription;
                    }
                }
                catch(Exception ex)
                {
                    MessageLabel.Text = GetInnerException(ex).Message;
                }
            }
        }
    }
}