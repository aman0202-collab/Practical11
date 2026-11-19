using Practical11.DAL;
using Practical11.Models;
using System.Web.Mvc;

namespace Practical11.Controllers
{
    // MVC controller - handles the portal pages (Views)
    public class ServiceRequestController : Controller
    {
        ServiceRequestDAL dal = new ServiceRequestDAL();

        // GET: ServiceRequest - shows all requests in a table
        public ActionResult Index()
        {
            return View(dal.GetAll());
        }

        // GET: ServiceRequest/Create - shows the empty form
        public ActionResult Create()
        {
            return View();
        }

        // POST: ServiceRequest/Create - saves the new request
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ServiceRequest request)
        {
            if (ModelState.IsValid)
            {
                dal.Insert(request);

                return RedirectToAction("Index");
            }

            return View(request);
        }

        // GET: ServiceRequest/UpdateStatus/1 - shows the status form
        public ActionResult UpdateStatus(int id)
        {
            ViewBag.RequestId = id;

            return View();
        }

        // POST: ServiceRequest/UpdateStatus - updates the status
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult UpdateStatus(int id, string status)
        {
            dal.UpdateStatus(id, status);

            return RedirectToAction("Index");
        }
    }
}
