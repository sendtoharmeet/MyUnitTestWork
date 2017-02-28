using BusinessUnit;
using DataModel;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;

namespace UnitTest.Controllers
{
    [RoutePrefix("api")]
    public class ValuesController : ApiController
    {
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }
	
	[Route("ProcessOrder")]
        [ResponseType(typeof(OrderDetail))]
        public HttpResponseMessage Post(OrderDetail obj)
        {
            OrderManager o = new OrderManager();
            var status = o.SaveMyOrder(obj);

            return Request.CreateResponse(HttpStatusCode.OK, status);
        }
    }
}


/*
 var obj = {FirstName: "1", LastName : "531", State:"dfsd", Zip:"sadfad"};

$.ajax({
 type: "POST",
 url: "api/ProcessOrder",
 data: obj,
 success: function(msg) {
 	alert('Saved');
 },
 error: function(a,b,c) {
	alert(a.responseText);
 }
});
 * */
