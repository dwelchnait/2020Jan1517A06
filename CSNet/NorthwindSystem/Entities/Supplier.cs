using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region Additional Namespaces
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
#endregion


namespace NorthwindSystem.Entities
{
    [Table("Suppliers")]
    public class Supplier
    {
        private string _ContactName;
        private string _ContactTitle;
        private string _Address;
        private string _City;
        private string _Region;
        private string _PostalCode;
        private string _Country;
        private string _Phone;
        private string _Fax;
        private string _HomePageTitle;
        private string _HomePageUrl;

        [Key]
        public int SupplierID { get; set; }

        [Required(ErrorMessage = "Company name is required.")]
        [StringLength(40, ErrorMessage = "Company name is limited to 40 characters")]
        public string CompanyName { get; set; }

        [StringLength(30, ErrorMessage = "Contact name is limited to 30 characters")]
        public string ContactName 
        {
            get { return _ContactName; }
            set { _ContactName = string.IsNullOrEmpty(value) ? null : value; }
        }
        [StringLength(30, ErrorMessage = "Contact title is limited to 30 characters")]
        public string ContactTitle
        {
            get { return _ContactTitle; }
            set { _ContactTitle = string.IsNullOrEmpty(value) ? null : value; }
        }
        [StringLength(60, ErrorMessage = "Address is limited to 60 characters")]
        public string Address
        {
            get { return _Address; }
            set { _Address = string.IsNullOrEmpty(value) ? null : value; }
        }
        [StringLength(15, ErrorMessage = "City is limited to 15 characters")]
        public string City
        {
            get { return _City; }
            set { _City = string.IsNullOrEmpty(value) ? null : value; }
        }
        [StringLength(15, ErrorMessage = "Region is limited to 15 characters")]
        public string Region
        {
            get { return _Region; }
            set { _Region = string.IsNullOrEmpty(value) ? null : value; }
        }
        [StringLength(10, ErrorMessage = "PostalCode is limited to 10 characters")]
        public string PostalCode
        {
            get { return _PostalCode; }
            set { _PostalCode = string.IsNullOrEmpty(value) ? null : value; }
        }
        [StringLength(15, ErrorMessage = "Country is limited to 15 characters")]
        public string Country
        {
            get { return _Country; }
            set { _Country = string.IsNullOrEmpty(value) ? null : value; }
        }
        [StringLength(24, ErrorMessage = "Phone is limited to 24 characters")]
        public string Phone
        {
            get { return _Phone; }
            set { _Phone = string.IsNullOrEmpty(value) ? null : value; }
        }
        [StringLength(24, ErrorMessage = "Fax is limited to 24 characters")]
        public string Fax
        {
            get { return _Fax; }
            set { _Fax = string.IsNullOrEmpty(value) ? null : value; }
        }
        [StringLength(100, ErrorMessage = "HomePage Title is limited to 100 characters")]
        public string HomePageTitle
        {
            get { return _HomePageTitle; }
            set { _HomePageTitle = string.IsNullOrEmpty(value) ? null : value; }
        }
        [StringLength(100, ErrorMessage = "Home Page Url is limited to 100 characters")]
        public string HomePageUrl
        {
            get { return _HomePageUrl; }
            set { _HomePageUrl = string.IsNullOrEmpty(value) ? null : value; }
        }
    }
}
