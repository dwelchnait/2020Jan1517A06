using NorthwindSystem.BLL;
using NorthwindSystem.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp.SamplePages
{
    public partial class GridViewCodeBehindPaging : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            MessageLabel.Text = "";
        }

        //use this method to discover the inner most error message.
        //this routing has been created by the user
        protected Exception GetInnerException(Exception ex)
        {
            //drill down to the inner most exception
            while (ex.InnerException != null)
            {
                ex = ex.InnerException;
            }
            return ex;
        }//eom
        protected void Fetch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(ProductArg.Text))
            {
                MessageLabel.Text = "Supply a product partial name before searching.";
            }
            else
            {
                try
                {
                    ProductController sysmgr = new ProductController();
                    List<Product> info = sysmgr.Products_GetByPartialProductName(ProductArg.Text);
                    if (info.Count == 0)
                    {
                        MessageLabel.Text = "No products match the supplied argument.";
                        Clear_Click(sender, e);
                    }
                    else
                    {
                        ProductList.DataSource = info;
                        ProductList.DataBind();
                    }

                }
                catch(Exception ex)
                {
                    MessageLabel.Text = GetInnerException(ex).Message;
                }
            }

        }

        protected void ProductList_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                GridViewRow agrvow = ProductList.Rows[ProductList.SelectedIndex];
                int pid = int.Parse((agrvow.FindControl("ProductID") as Label).Text);
                ProductController sysmgr = new ProductController();
                Product info = sysmgr.Products_FindByID(pid);
                if (info == null)
                {
                    MessageLabel.Text = "Product no currently on file.";
                    Fetch_Click(sender, e);
                }
                else
                {
                    ProductID.Text = info.ProductID.ToString();
                    ProductName.Text = info.ProductName;
                    UnitPrice.Text = string.Format("{0:0.00}",info.UnitPrice);
                    Discontinued.Checked = info.Discontinued;
                }

            }
            catch (Exception ex)
            {
                MessageLabel.Text = GetInnerException(ex).Message;
            }
        }

        protected void Clear_Click(object sender, EventArgs e)
        {
            ProductList.DataSource = null;
            ProductList.DataBind();
            ProductID.Text = "";
            ProductName.Text = "";
            UnitPrice.Text = "";
            Discontinued.Checked = false;
        }

        protected void ProductList_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            //you must manually alter the current PageIndex
            //the page index along with the Pagesize will determine which
            //   rows of your dataset (collection) to display
            //the required page index is located inside the variable parameter e
            ProductList.PageIndex = e.NewPageIndex;

            //you must now refresh your data set (collection)
            Fetch_Click(sender, new EventArgs());
        }
    }
}