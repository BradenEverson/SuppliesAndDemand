using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuppliesAndDemand.Services.Interfaces
{
    public interface IEmailService
    {
        public bool Send(string header, string message);
    }
}
