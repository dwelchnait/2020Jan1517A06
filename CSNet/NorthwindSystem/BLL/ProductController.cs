using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region Additional Namespaces
using NorthwindSystem.DAL;
using NorthwindSystem.Entities;

#endregion
namespace NorthwindSystem.BLL
{
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
    }
}
