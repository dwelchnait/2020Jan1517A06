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
    public class CategoryController
    {
        public List<Category> Categories_List()
        {
            using (var context = new NorthwindSystemContext())
            {
                return context.Categories.ToList();
            }
        }
        public Category Categories_FindByID(int categoryid)
        {
            using (var context = new NorthwindSystemContext())
            {
                return context.Categories.Find(categoryid);
            }
        }
    }
}
