using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Powerco.Models;

namespace Powerco.Controllers
{
    public class JoinController : Controller
    {
        // GET: Join
        [AcceptVerbs("GET")]
        public ActionResult Index()
        {
           return View(new CustomerJoin());
        }

        [AcceptVerbs("POST")]
        public async Task<ActionResult> Index(CustomerJoin model)
        {            
            return View("Complete", await IntitiateCustomerJoinAsync(model));
        }

        static async Task<HttpStatusCode> IntitiateCustomerJoinAsync(CustomerJoin customer)
        {
            HttpClient client = new HttpClient();

            client.DefaultRequestHeaders.Add(Constants.HeaderSubscriptionKeyName, Constants.HeaderSubscriptionKeyValue);
            HttpResponseMessage response = await client.PostAsJsonAsync(Constants.UrlJoinInitiate, customer);
            response.EnsureSuccessStatusCode();

            // Return the URI of the created resource.
            return response.StatusCode;
        }
    }
}
 