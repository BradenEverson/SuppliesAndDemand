using SuppliesAndDeman.Models.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuppliesAndDemand.Services.Interfaces
{
    public interface IOrderService
    {
        public Order get(string id);
        public List<Order> getByUser(string userId);
        public List<Order> getByCountry(string country);
        public List<Order> getByZip(string zip);
        public bool Add(Order order);
    }
}
