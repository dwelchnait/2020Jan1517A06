using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region Additional Namespaces
using NorthwindSystem.DAL;
using NorthwindSystem.Entities;
using System.ComponentModel;  //ODS
using System.Data.SqlClient;    //SqlParameter()

#endregion
namespace NorthwindSystem.BLL
{
    [DataObject]
    public class ProductController
    {
        public List<Product> Products_List()
        {
            //ensure the sql connection is closed at the end
            //   of the query process
            using (var context = new NorthwindSystemContext())
            {
                //use an extension method of EntityFrame to get
                //all of the data from the sql table Region
                //use the property DbSet that maps the Region sql table to 
                //    the application
                //the dbset T type is Region which describes a single record
                //the actual collection type that is returned from
                //    EntityFramework is either IEnumerable or IQuerable
                //Change the collection type to a List<T> using .ToList()
                return context.Products.ToList();
            }
        }
        public Product Products_FindByID(int productid)
        {
            using (var context = new NorthwindSystemContext())
            {
                //the .Find() method does a primary key lookup of the
                //    sql table
                return context.Products.Find(productid);
            }
        }

        //this query will use a NON_PRIMARY key field off the Product
        //   record to lookup data from the database table
        [DataObjectMethod(DataObjectMethodType.Select,false)]
        public List<Product> Products_FindByCategory(int categoryid)
        {
            using (var context = new NorthwindSystemContext())
            {
                //call to an Sql Procedure
                //the call returns a datatype of IEnumerable<T>
                //.SqlQuery<T>(execution string[, list of SqlParameter instances])
                //execution string >>   "procedurename parameterlist"
                //a parameter is specified using SqlParameter("parametername", value)
                //SqlParameter() requires using System.Data.SqlClient; namespace
                IEnumerable<Product> results = context.Database.SqlQuery<Product>("Products_GetByCategories @CategoryID",
                    new SqlParameter("CategoryID", categoryid));

                //convert the IEnumerable<T> to a List<T>
                return results.ToList();
            }
        }

        public List<Product> Products_GetByPartialProductName(string productname)
        {
            using (var context = new NorthwindSystemContext())
            {
                IEnumerable<Product> results = context.Database.SqlQuery<Product>("Products_GetByPartialProductName @PartialName",
                    new SqlParameter("PartialName", productname));
                return results.ToList();
            }
        }

    }
}
