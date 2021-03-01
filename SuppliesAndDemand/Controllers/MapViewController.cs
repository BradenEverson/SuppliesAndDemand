using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SuppliesAndDeman.Models.DataModels;
using SuppliesAndDeman.Models.ViewModels;
using SuppliesAndDemand.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SuppliesAndDemand.Web.Controllers
{
    public class MapViewController : Controller
    {
        private IOrderService orders;
        public MapViewController(IOrderService orders)
        {
            this.orders = orders;
        }
        public IActionResult Index()
        {
            return View(orders.getByZip("53558"));
        }
        public IActionResult OrderForm()
        {
            return View();
        }
        [HttpPost]
        public IActionResult OrderForm(OrderVM order)
        {
            Order newOrder = new Order(order.UserId)
            {
                country = order.country,
                street = order.street,
                zip = order.zip,
                itemNeeded = order.itemNeeded
            };
            if (orders.Add(newOrder))
            {
                return RedirectToAction("Index");
            }
            else
            {
                return RedirectToAction("OrderForm");
            }
        }
    }
}
