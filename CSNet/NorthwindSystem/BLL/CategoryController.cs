using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region Additional Namespaces
using NorthwindSystem.DAL;
using NorthwindSystem.Entities;
using System.ComponentModel; //used by ODS wizard exposure
#endregion

namespace NorthwindSystem.BLL
{
    //expose the class
    [DataObject]
    public class CategoryController
    {
        [DataObjectMethod(DataObjectMethodType.Select,false)]
        public List<Category> Categories_List()
        {
            using (var context = new NorthwindSystemContext())
            {
                return context.Categories.ToList();
            }
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public Category Categories_FindByID(int categoryid)
        {
            using (var context = new NorthwindSystemContext())
            {
                return context.Categories.Find(categoryid);
            }
        }
    }
}
