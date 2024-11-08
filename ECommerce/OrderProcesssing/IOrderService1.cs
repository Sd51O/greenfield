using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProcesssing
{
    public interface IOrderService1
    {
        List<Order> GetAll();
        Order Get(int id);
        bool Insert(Order order);
        bool Update(Order order);
        bool Delete(int id);

    }
}
