using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TheWorld.ViewModels;
using TheWorld.Services;
using Microsoft.Extensions.Configuration;

namespace TheWorld.Controllers.Web
{
    public class AppController : Controller
    {
        private IMailService mailService;
        private IConfigurationRoot cfg;

        public AppController(IMailService mailService, IConfigurationRoot cfg)
        {
            this.mailService = mailService;
            this.cfg = cfg;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Contact()
        {

            return View();
        }
        [HttpPost]
        public IActionResult Contact(ContactViewModel model)
        {
            // Validate and add a model error
            //ModelState.AddModelError()
            //
            // could be shown to: 
            // < span asp - validation - summary = "ModelOnly" ></ span >
            // or next to the property

            if (ModelState.IsValid)
            {
                var mailTo = cfg["MailSetting:ToAddress"];
                mailService.SendMail(mailTo, model.Email, model.Name, model.Message);
                ModelState.Clear();
                ViewBag.UserMessage = "Message Sent!";
            }
            return View();
        }

        public IActionResult About()
        {
            return View();
        }
    }
}
