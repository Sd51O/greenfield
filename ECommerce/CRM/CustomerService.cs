using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM
{
    public class CustomerService : iCusttomerService
    {
        private List<Customer> _customerList;

        public CustomerService()
        {
            this._customerList = new List<Customer>();
        }
        public bool Delete(int id)
        {   Customer customer = this._customerList[id];
            return this._customerList.Remove(customer);

        }

        public Customer Get(int id)
        {
            foreach (Customer customer in _customerList)
            {
                if (customer.Id == id) return customer;
            }
            return null;
        }

        public List<Customer> GetAll()
        {
            return _customerList;
        }

        public bool Insert(Customer customer)
        {
            this._customerList.Add(customer);
             return true;
        }

        public bool Update(Customer customer)
        {
           Customer Customer = this.Get(customer.Id);
           this._customerList.Remove(Customer);
            this._customerList.Add(customer);
            return true;
        }
    }
}
