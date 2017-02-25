using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SimpleBlogHm.Areas.Admin.Controllers
{
    public class UsersController : Controller
    {
        //
        // GET: /Admin/Users/
        public ActionResult Index()
        {
            return Content("Users Index Screen");
        }
        public ActionResult List()
        {
            return Content("Users List Screen");
        }
        public ActionResult Edit(int id=0)
        {
            return Content("Users Edit="+id);
        }
	}
}