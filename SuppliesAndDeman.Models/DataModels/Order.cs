using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuppliesAndDeman.Models.DataModels
{
    public class Order
    {
        public string UserId { get; set; }
        public string id { get; set; }
        public string itemNeeded { get; set; }
        public string street { get; set; }
        public string zip { get; set; }
        public string country { get; set; }
        public Order(string userId)
        {
            UserId = userId;
            id = Guid.NewGuid().ToString();
        }
    }
}
