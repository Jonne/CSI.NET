using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
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
            var mail = mailRepository.GetAll();

            return View(mail);
        }

    }
}
