using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM
{ //prototype,contract,specification
    public interface iCusttomerService
    {
        List<Customer> GetAll();
        Customer Get(int id);
       
        bool Insert(Customer customer);

        bool Update(Customer customer);

        bool Delete(int id);
    }
}
