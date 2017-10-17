using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace InvestmentFundsApi.Controllers
{
    public class RequestController : ApiController
    {
        [HttpPost]
        [Route("request/sell", Name = "Request_Sell_Shares_Post")]
        public void Post(int FundId, int SellType, Decimal Amount, int SellBank, string SellAccount )
        {
        }

        [HttpPost]
        [Route("request/transfer/", Name = "Request_Transfers_Shares_Post")]
        public void Post(string sourceFund, string destinationFund, string sellType, decimal ProspectAcceptanceTransfer, bool RiskAcceptanceTransfer)
        {

        }


    }
}
