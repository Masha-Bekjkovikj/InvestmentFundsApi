using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace InvestmentFundsApi.Controllers
{
    public class RequestsController : ApiController
    {
        
        
        public void Post(int FundId, int SellType, Decimal Amount, int SellBank, string SellAccount)
        {
           
        }


        // POST api/Zahtevi3
        public void Post(string sourceFund, string destinationFund, string sellType, decimal ProspectAcceptanceTransfer, bool RiskAcceptanceTransfer)
        {

        }

    }
}
