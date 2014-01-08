using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using NSA.Mail;
using NSACloudService.BL;
using NSACloudService.DL;
using NSACloudService.Models;

namespace NSACloudService.Controllers
{
    public class MyFilesController : Controller
    {
        private readonly MyFileRepository myFileRepository = new MyFileRepository();
        //
        // GET: /MyFiles/

        public ActionResult Index()
        {
            IEnumerable<MyFile> files = myFileRepository.GetAll();

            return View(files);
        }

        public ActionResult SendLink(string email, int myFileId)
        {
            MyFile myFile = myFileRepository.GetAll().Single(x => x.Id == myFileId);

            new MailSender().SendMail(email, "MarkDown", new Dictionary<string, object>
            {
                {"Id", myFile.Id},
                {"Name", myFile.Name}
            });

            return Index();
        }

        public ActionResult View(int fileId)
        {
            string text = System.IO.File.ReadAllText(Server.MapPath(@"\Files\MyFile.txt"));

            var model = new MyFileModel {Id = fileId, Name = "MyFileModel", Content = text};

            DomainEvents.Instance.FileAuthenticated += model.OnFileAuthenticated;

            // Will invoke the authentication event
            new FileAuthenticationService().Authenticate();

            return View(model);
        }

        public ActionResult InvokeGC()
        {
            GC.Collect();

            return new EmptyResult();
        }
    }
}