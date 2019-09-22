using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;
using Entities.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TALPremiumCalculator.Controllers
{
    [System.Web.Http.Route("api/[controller]")]
    [ApiController]
    public class PremiumCalculatorController : ApiController
    {
        PremiumCalculator premiumCalcParam = new PremiumCalculator();
        
        //return this.premiumCalc.sumInsured* filterVal * this.premiumCalc.age) / 1000 * 12
    }
}