using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PurpleBricksCodeEvaluation.DAL;


namespace PurpleBricksCodeEvaluation.Controllers
{
    public class AddPropertyController : Controller
    {
        //
        // GET: /AddProperty/

        [HttpGet]
        public ActionResult Index()
        {
            DAL.Models.Property model = new DAL.Models.House();
            return View(model);
        }


        [HttpPost]
        public ActionResult Create(DAL.Models.House model)
        {
            try
            {
                DAL.DAL dal = new DAL.DAL();
                dal.AddProperty(model);
                return RedirectToAction("AddedOK", "PropertyAdded");
            }
            catch
            {
                return View("Index", model);
            }
        }

       
    }
}
