using System;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuppliesAndDeman.Models.DataModels
{
    public class User : Microsoft.AspNetCore.Identity.IdentityUser
    {
        public int UserPoints { get; set; }
        public string Address { get; set; }
        public string Zip { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
    }
}
