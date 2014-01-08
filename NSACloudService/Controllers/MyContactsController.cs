using System.Collections.Generic;
using System.Web.Mvc;
using NSACloudService.DL;

namespace NSACloudService.Controllers
{
    public class MyContactsController : Controller
    {
        //
        // GET: /Contacts/
        public ActionResult Index()
        {
            IEnumerable<MyContact> contacts = new MyContactsRepository().GetAll();
            return View(contacts);
        }
    }
}