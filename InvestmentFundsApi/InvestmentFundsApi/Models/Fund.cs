using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InvestmentFundsApi.Models
{
    public class Fund
    {
        public int fundId { get; set; }

        public String fundName { get; set; }

        public Decimal fundShareNumber { get; set; }

        public Decimal fundSharePrice { get; set; }

        public Decimal fundState { get; set; }

        public DateTime fundDateCalculated { get; set; }


    }
}