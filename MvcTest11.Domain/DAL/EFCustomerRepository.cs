using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MvcTest11.Domain.Abstract;
using MvcTest11.Domain.Entity;
using MvcTest11.Domain.SP_Entity;
using System.Data.SqlClient;
namespace MvcTest11.Domain.DAL
{
    public class EFCustomerRepository : ICustomerRepository
    {
        private EFDbContext context = new EFDbContext();
        public List<MyTestTable> CustomerList(string Name)
        {                        
            return (context.MyTestTables.Where(p => p.strName.Contains(Name)).ToList());
        }

        public List<SP_tvCustomer_CustomSelect> GetCustomSelectFromSP(string Name)
        {
            return (context.Database.SqlQuery<SP_tvCustomer_CustomSelect>("tvCustomer_CustomSelect @strName", new SqlParameter("@strName", Name)).ToList());
        }
    }
}
