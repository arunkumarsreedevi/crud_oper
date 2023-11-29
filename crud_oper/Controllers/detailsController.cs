using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using crud_oper.Models;

namespace crud_oper.Controllers
{
    public class detailsController : Controller
    {
        db_crudEntities dbobj = new db_crudEntities();
        // GET: details
        public ActionResult prof_load()
        {
            var getd = dbobj.sp_read(Session["name"].ToString()).FirstOrDefault();
          //var getdata = dbobj.sp_read(Session["name"].ToString()).FirstOrDefault();
            return View(new readandupdatecs
            {
                name = getd.name,
                age = getd.age,
                des = getd.des
            }
            ) ;
        }
        public ActionResult prof_update(readandupdatecs obj)
        {
            dbobj.sp_update(Session["name"].ToString(), obj.age);
           var getd= dbobj.sp_read(Session["name"].ToString()).FirstOrDefault();
            return View("prof_load",new readandupdatecs
            {
               
                age = getd.age,
             
            }
              );
        }
    }
}