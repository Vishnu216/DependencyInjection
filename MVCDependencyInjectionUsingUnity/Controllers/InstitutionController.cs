using ServicesCL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCDependencyInjectionUsingUnity.Controllers
{
    public class InstitutionController : Controller
    {
        private IInstitutionService institutionService;
        public InstitutionController(IInstitutionService institutionService)
        {
            this.institutionService = institutionService;
        }
        public ActionResult Index()
        {
            return View(this.institutionService.GetInstitutionByID(1));
        }
    }

}