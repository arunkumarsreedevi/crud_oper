using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using crud_oper.Models;
namespace crud_oper.Controllers
{
    public class pupdateController : Controller
    {
        db_crudEntities dbobj = new db_crudEntities();
        // GET: pupdate
        public ActionResult Index()
        {
            return View();
        }
    }
}