using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MvcTest11.Domain.Entity;
using MvcTest11.Domain.SP_Entity;

namespace MvcTest11.Domain.Abstract
{
    public interface ICustomerRepository
    {
        List<MyTestTable> CustomerList(string Name);
        List<SP_tvCustomer_CustomSelect> GetCustomSelectFromSP(string strName);
    }
}
