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
    public partial class ProductQuery : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            MessageLabel.Text = "";

            //on the first presentation of this pae, load the 
            //   dropdownlist with Region data
            if (!Page.IsPostBack)
            {
                //any time you leave the web page to 
                //   access another project, place your
                //   code within a try catch
                try
                {
                    //create an instance of the interface class
                    //   that exists in your BLL
                    //you will need to have declared the namespace
                    //   of the class at the top of this file
                    ProductController sysmger = new ProductController();
                    //call the method in the controller that will
                    //   return the data that you wish
                    //you will need to have declared the namespace
                    //   of the entity class at the top of this file
                    List<Product> info = sysmger.Products_List();

                    //sort the returned data
                    info.Sort((x, y) => x.ProductName.CompareTo(y.ProductName));

                    //load the dropdownlist
                    ProductList.DataSource = info;
                    ProductList.DataTextField = nameof(Product.ProductName);
                    ProductList.DataValueField = nameof(Product.ProductID);
                    ProductList.DataBind();

                    //add a prompt line to the list
                    ProductList.Items.Insert(0, new ListItem("select..", "0"));
                }
                catch (Exception ex)
                {
                    //Sometimes, depending on the exception you will
                    //   simply get a message pointing you to the
                    //   Inner Exception which will hold the true error
                    //Pass the exception to the GetInnerException() method
                    //   we have supplied.
                    //This GetInnerException() returns the most inner
                    //   error message
                    MessageLabel.Text = GetInnerException(ex).Message;
                }
            }
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
    }
}