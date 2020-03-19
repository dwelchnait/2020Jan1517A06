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
    class SupplierController
    {
        public List<Supplier> Suppliers_List()
        {
            using (var context = new NorthwindSystemContext())
            {
                return context.Suppliers.ToList();
            }
        }
        public Supplier Suppliers_FindByID(int supplierid)
        {
            using (var context = new NorthwindSystemContext())
            {
                return context.Suppliers.Find(supplierid);
            }
        }
    }
}
