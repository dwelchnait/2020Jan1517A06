using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp.SamplePages
{
    public partial class ContestEntry : System.Web.UI.Page
    {
        static List<Entry> entries = new List<Entry>();
        protected void Page_Load(object sender, EventArgs e)
        {
            Message.Text = "";
        }

        protected void Submit_Click(object sender, EventArgs e)
        {
            
            //re-execute the Validation Controls on the server side
            if (Page.IsValid)
            {
                if (Terms.Checked)
                {
                    //created an instance of the data class
                    Entry theEntry = new Entry();

                    //loaded the instance with data from the form
                    theEntry.FirstName = FirstName.Text;
                    theEntry.LastName = LastName.Text;
                    theEntry.StreetAddress1 = StreetAddress1.Text;
                    theEntry.StreetAddress2 = string.IsNullOrEmpty(StreetAddress2.Text) ? null : StreetAddress2.Text;
                    theEntry.City = City.Text;
                    theEntry.Province = Province.SelectedValue;
                    theEntry.PostalCode = PostalCode.Text;
                    theEntry.EmailAddress = EmailAddress.Text;

                    //add the new instance to the collection
                    entries.Add(theEntry);

                    //display the collection
                    //use a collection display control: GridView
                    //requirements: a) data source (collection) b) bind the data to the control
                    EntryList.DataSource = entries;
                    EntryList.DataBind();
                }
                else
                {
                    Message.Text = "You did not agree to the contest terms. Entry rejected.";
                }
            }
        }

        protected void Clear_Click(object sender, EventArgs e)
        {
            FirstName.Text = "";
            LastName.Text = "";
            StreetAddress1.Text = "";
            StreetAddress2.Text = "";
            City.Text = "";
            PostalCode.Text = "";
            EmailAddress.Text = "";
            CheckAnswer.Text = "";
            Province.SelectedIndex = 0;
            Terms.Checked = false;
        }
    }
}