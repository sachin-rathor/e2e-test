using System;
using System.Linq;
using System.Net;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Azure.Functions.Worker.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace MySpace
{
    public class SachinRathor
    {
        [Function("GetMessage")]
        public HttpResponseData Run([HttpTrigger(AuthorizationLevel.Anonymous, "get")] HttpRequestData req)
        {
	    var json = JsonConvert.SerializeObject("Welcome to DotNet 7 in PR env from Sachin Rathor!");
            var response = req.CreateResponse(HttpStatusCode.OK);
            response.Headers.Add("Content-Type", "text/json; charset=utf-8");
	    response.WriteString(json);

            return response;
        }
    }
}
