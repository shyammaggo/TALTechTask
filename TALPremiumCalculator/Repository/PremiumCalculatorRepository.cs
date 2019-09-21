using System;
using System.Collections.Generic;
using System.Text;
using Contracts;
using Entities;
using Entities.Models;
using System.Linq;

namespace Repository
{
   public  class PremiumCalculatorRepository:RepositoryBase<PremiumCalculator>, IPremiumCalculator
    {

        public PremiumCalculatorRepository(RepositoryContext repositoryContext)
            : base(repositoryContext)
        { }

        public void CreateNewInsuredPerson(PremiumCalculator premiumCalculator)
        {
            Create(premiumCalculator);
        }

        public IEnumerable<PremiumCalculator> GetAllInsuredPersons()
        {
            return ListAllInsuredPersons()
                    .OrderBy(ow => ow.insuredName)
                    .ToList();
        }
    }
}
