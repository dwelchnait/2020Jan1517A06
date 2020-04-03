using NorthwindSystem.BLL;
using NorthwindSystem.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp.NorthwindPages
{
    public partial class ProductCRUD : System.Web.UI.Page
    {
        List<string> errormsgs = new List<string>();

        protected void Page_Load(object sender, EventArgs e)
        {
            Message.DataSource = null;
            Message.DataBind();

            //execute when page is first displayed
            if (!Page.IsPostBack)
            {
                BindProductList();
            }

        }

        //use this method to discover the inner most error message.
        //this rotuing has been created by the user
        protected Exception GetInnerException(Exception ex)
        {
            //drill down to the inner most exception
            while (ex.InnerException != null)
            {
                ex = ex.InnerException;
            }
            return ex;
        }

        //use this method to load a DataList with a variable
        //number of message lines.
        //each line is a string
        //the strings (lines) are passed to this routine in
        //   a List<string>
        //second parameter is the bootstrap cssclass
        protected void LoadMessageDisplay(List<string> errormsglist, string cssclass)
        {
            Message.CssClass = cssclass;
            Message.DataSource = errormsglist;
            Message.DataBind();
        }

        protected void BindProductList()
        {
            try
            {
                ProductController sysmgr = new ProductController();
                List<Product> info = sysmgr.Products_List();
                info.Sort((x, y) => x.ProductName.CompareTo(y.ProductName));
                ProductList.DataSource = info;
                ProductList.DataTextField = nameof(Product.ProductName);
                ProductList.DataValueField = nameof(Product.ProductID);
                ProductList.DataBind();
                ProductList.Items.Insert(0, new ListItem("select ...", "0"));
            }
            catch(Exception ex)
            {
                errormsgs.Add(GetInnerException(ex).Message);
                LoadMessageDisplay(errormsgs, "alert alert-danger");
            }
        }

        protected void Search_Click(object sender, EventArgs e)
        {
            //standard lookup
            if (ProductList.SelectedIndex == 0)
            {
                errormsgs.Add("Select a product to look up.");
                LoadMessageDisplay(errormsgs, "alert alert-info");
            }
            else
            {
                try
                {
                    ProductController sysmgr = new ProductController();

                    Product info = sysmgr.Products_FindByID(int.Parse(ProductList.SelectedValue));
                    if (info == null)
                    {
                        errormsgs.Add("Selected product no longer on file. Select a different product.");
                        LoadMessageDisplay(errormsgs, "alert alert-info");
                        BindProductList();
                    }
                    else
                    {
                        //load the co-responding individual field
                        ProductID.Text = info.ProductID.ToString();
                        ProductName.Text = info.ProductName;
                        if ( info.SupplierID.HasValue)
                        {
                            SupplierList.SelectedIndex = 0;
                        }
                        else
                        {
                            SupplierList.SelectedValue = info.SupplierID.ToString();
                        }
                        if (info.CategoryID == null)
                        {
                            CategoryList.SelectedIndex = 0;
                        }
                        else
                        {
                            CategoryList.SelectedValue = info.CategoryID.ToString();
                        }
                        QuantityPerUnit.Text = string.IsNullOrEmpty(info.QuantityPerUnit) ? "" : info.QuantityPerUnit;
                        UnitPrice.Text = info.UnitPrice == null ? "" : string.Format("{0:0.00}",info.UnitPrice);
                        UnitsInStock.Text = info.UnitsInStock == null ? "" :info.UnitsInStock.ToString();
                        UnitsOnOrder.Text = info.UnitsOnOrder == null ? "" : info.UnitsOnOrder.ToString();
                        ReorderLevel.Text = info.ReorderLevel == null ? "" : info.ReorderLevel.ToString();
                        Discontinued.Checked = info.Discontinued;
                    }
                }
                catch (Exception ex)
                {
                    errormsgs.Add(GetInnerException(ex).Message);
                    LoadMessageDisplay(errormsgs, "alert alert-danger");
                }
            }
        }

        protected void Clear_Click(object sender, EventArgs e)
        {
            ProductID.Text = "";
            ProductName.Text = "";
            QuantityPerUnit.Text = "";
            UnitPrice.Text = "";
            UnitsInStock.Text = "";
            UnitsOnOrder.Text = "";
            ReorderLevel.Text = "";
            Discontinued.Checked = false;
            SupplierList.ClearSelection();
            CategoryList.ClearSelection();
            //optionally
            ProductList.ClearSelection();
        }
    }
}