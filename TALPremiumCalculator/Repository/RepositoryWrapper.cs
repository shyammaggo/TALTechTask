using Contracts;
using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public class RepositoryWrapper : IRepositoryWrapper
    {
        private RepositoryContext _repoContext;
        private IPremiumCalculator _premiumcalculator;
        public RepositoryWrapper(RepositoryContext repoContext)
        {
            _repoContext = repoContext;
        }

        public IPremiumCalculator premiumCalculator
        {
            get
            {
                if (_premiumcalculator == null)
                {
                    _premiumcalculator = new PremiumCalculatorRepository(_repoContext);
                }
                return _premiumcalculator;
            }
        }



        public void Save()
        {
            _repoContext.SaveChanges();
        }
    }
}
