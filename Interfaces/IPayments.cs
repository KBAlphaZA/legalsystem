using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LegalSystem.Interfaces
{
    public interface IPayments
    {
        Task<bool> ProcessPayment();
    }
}
