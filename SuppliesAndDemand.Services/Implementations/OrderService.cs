using Microsoft.AspNetCore.Identity;
using SuppliesAndDeman.Models.DataModels;
using SuppliesAndDemand.Data;
using SuppliesAndDemand.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuppliesAndDemand.Services
{
    public class OrderService : IOrderService
    {
        private readonly AppDbContext _context;
        public OrderService(UserManager<User> users, AppDbContext context)
        {
            _context = context;
        }
        public bool Add(Order order)
        {
            try
            {
                _context.Orders.Add(order);
                _context.SaveChanges();
            }
            catch
            {
                return false;
            }
            return true;
        }

        public Order get(string id)
        {
            return _context.Orders.FirstOrDefault(order => order.id == id);
        }

        public List<Order> getByCountry(string country)
        {
            return _context.Orders.Where(order => order.country.ToLowerInvariant() == country.ToLowerInvariant()).ToList();
        }

        public List<Order> getByUser(string userId)
        {
            return _context.Orders.Where(order => order.UserId == userId).ToList();
        }

        public List<Order> getByZip(string zip)
        {
            return _context.Orders.Where(order => order.zip == zip).ToList();
        }
    }
}
