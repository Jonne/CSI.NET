using System.Collections.Generic;
using System.Web.Mvc;
using NSACloudService.DL;

namespace NSACloudService.Controllers
{
    public class MyMailController : Controller
    {
        //
        // GET: /MyMail/

        public ActionResult Index()
        {
            var mailRepository = new MyMailRepository();
            IEnumerable<MyMail> mail = mailRepository.GetAll();

            return View(mail);
        }
    }
}