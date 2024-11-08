using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM
{
    //POCO:Plain Old CLR object
    public class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailId { get; set; }
        public string ContactNo { get; set; }
        public int Id { get; set; }


    }
}