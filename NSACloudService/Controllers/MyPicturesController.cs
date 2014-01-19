using System.Collections.Generic;
using System.Web.Mvc;
using NSACloudService.DL;

namespace NSACloudService.Controllers
{
    public class MyPicturesController : Controller
    {
        //
        // GET: /MyPictures/

        public ActionResult Index()
        {
            var picturesRepository = new MyPicturesRepository();
            IEnumerable<MyPicture> mail = picturesRepository.GetAll();

            return View(mail);
        }
    }
}