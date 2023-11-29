using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using crud_oper.Models;

namespace crud_oper.Controllers
{
    public class RegisterController : Controller
    {
        db_crudEntities dbobj = new db_crudEntities();
        // GET: Register
        public ActionResult reg_load()
        {
            return View();
        }
        public ActionResult reg_click(insertdb objcls)
         {
            if (ModelState.IsValid)
            {
                dbobj.sp_insert(objcls.name, objcls.age, objcls.des);
                Session["name"] = objcls.name;
                objcls.msg = "success";
                return View("reg_load", objcls);
            }
            return View("reg_load", objcls);
        }
    }
}