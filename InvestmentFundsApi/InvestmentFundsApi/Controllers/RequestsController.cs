using Swashbuckle.Swagger.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using InvestmentFundsApi.Models;

namespace InvestmentFundsApi.Controllers
{
    public class RequestsController : ApiController
    {
        [HttpGet]
        [Route("requests", Name = "GetRequests")]
        [SwaggerOperation("GetRequests")]
        public List<Request> Get()
        {
            return new List<Request>();
        }
        [HttpPost]
        [Route("request/sell", Name = "RequestSellSharesPost")]
        [SwaggerOperation("SellRequest")]
        public void Post(SellRequest sellRequest)
        {
        }

        [HttpPost]
        [Route("request/transfer", Name = "RequestTransferSharesPost")]
        [SwaggerOperation("TransferRequest")]
        public void Post(TransferRequest transferRequest)
        {

        }
        [HttpPost]
        [Route("request/buy", Name = "RequestBuySharesPost")]
        [SwaggerOperation("BuyRequest")]
        public void Post(BuyRequest buyRequest)
        {

        }

    }
}
