using System;
using System.Collections.Generic;
using LoggerService;
using System.Text;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Contracts;
using Entities;
using TALPremiumCalculator.Controllers;
using Entities.Models;

namespace TALPremiumCalculatorUnitTest
{
    [TestClass]
    public class GetOccupationListUnitTest
    {
        PremiumCalculator pc1;
        PremiumCalculator pc2;
        PremiumCalculator pc3;

        private LoggerManager _logger;
        private Mock<IRepositoryWrapper> _repository;
        private List<PremiumCalculator> PremiumCalculatorList;

    }
}
