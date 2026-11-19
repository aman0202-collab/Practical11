using Practical11.DAL;
using Practical11.Models;
using System.Web.Http;

namespace Practical11.Controllers
{
    // Web API controller - the same data is also available as an API.
    // It uses the same DAL, so MVC pages and API always show the same data.
    public class ServiceApiController : ApiController
    {
        ServiceRequestDAL dal = new ServiceRequestDAL();

        // GET: api/ServiceApi - returns all requests
        [HttpGet]
        public IHttpActionResult GetRequests()
        {
            return Ok(dal.GetAll());
        }

        // POST: api/ServiceApi - creates a new request
        [HttpPost]
        public IHttpActionResult CreateRequest(ServiceRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            dal.Insert(request);

            return Ok("Service request created successfully");
        }

        // PUT: api/ServiceApi/UpdateStatus/1 - updates the status
        [HttpPut]
        [Route("api/ServiceApi/UpdateStatus/{id:int}")]
        public IHttpActionResult UpdateStatus(int id, [FromBody] string status)
        {
            dal.UpdateStatus(id, status);

            return Ok("Status updated successfully");
        }
    }
}
