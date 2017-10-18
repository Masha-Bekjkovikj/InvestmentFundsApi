using Swashbuckle.Swagger.Annotations;
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
        [HttpPost]
        [Route("request/sell", Name = "RequestSellSharesPost")]
        [SwaggerOperation("SellShares")]
        public void Post(int FundId, int SellType, decimal Amount, int SellBank, string SellAccount )
        {
        }

        [HttpPost]
        [Route("request/transfer", Name = "RequestTransferSharesPost")]
        [SwaggerOperation("TransferShares")]
        public void Post(string sourceFund, string destinationFund, string sellType, decimal ProspectAcceptanceTransfer, bool RiskAcceptanceTransfer)
        {

        }
        [HttpPost]
        [Route("request/buy", Name = "RequestBuySharesPost")]
        [SwaggerOperation("BuyShares")]
        public void Post(int FundId, decimal Amount, int PaymentType)
        {

        }

    }
}
