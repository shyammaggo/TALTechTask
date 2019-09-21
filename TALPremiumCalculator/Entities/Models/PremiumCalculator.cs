using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entities.Models
{
    [Table("PremiumCalculator")]
    public class PremiumCalculator
    {
        public int id { get; set; }
        public int insuredName { get; set; }
        public int age { get; set; }
        public int dateOfBirth { get; set; }
        public int sumInsured { get; set; }
       
    }
}
