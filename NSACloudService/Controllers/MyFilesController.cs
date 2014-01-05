using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using NSA.Mail;
using NSACloudService.DL;

namespace NSACloudService.Controllers
{
    public class MyFilesController : Controller
    {
        private readonly MyFileRepository myFileRepository = new MyFileRepository();
        //
        // GET: /MyFiles/

        public ActionResult Index()
        {
            //new MailSender().SendMail("test", "sharelink", new Dictionary<string, object>());

            IEnumerable<MyFile> files = myFileRepository.GetAll();


            return View(files);
        }

        public ActionResult SendLink(string email, int myFileId)
        {
            if (true)
            {
                MyFile myFile = myFileRepository.GetAll().Single(x => x.Id == myFileId);

                new MailSender().SendMail(email, "MarkDown", new Dictionary<string, object>
                {
                    {"Id", myFile.Id},
                    {"Name", myFile.Name}
                });

                return Index();
            }
        }
    }
}