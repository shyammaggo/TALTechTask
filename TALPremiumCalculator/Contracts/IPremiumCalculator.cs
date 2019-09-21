using System;
using System.Collections.Generic;
using System.Text;
using Entities.Models;

namespace Contracts
{
    public interface IPremiumCalculator : IRepositoryBase<PremiumCalculator>
    {
        IEnumerable<PremiumCalculator> GetAllInsuredPersons();
        void CreateNewInsuredPerson(PremiumCalculator premiumCalculator);
    }
}
