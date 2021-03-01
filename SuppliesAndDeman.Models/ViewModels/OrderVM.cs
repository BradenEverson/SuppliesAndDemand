using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuppliesAndDeman.Models.ViewModels
{
    public class OrderVM
    {
        public string itemNeeded { get; set; }
        public string street { get; set; }
        public string zip { get; set; }
        public string country { get; set; }
        public string UserId { get; set; }
    }
}
