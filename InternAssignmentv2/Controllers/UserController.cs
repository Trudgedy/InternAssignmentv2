using InternAssignmentv2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace InternAssignmentv2.Controllers
{
    public class UserController : Controller
    {
        InternAssignmentv2Db _db = new InternAssignmentv2Db();
        public ActionResult Index()
        {
            var model = _db.Users.ToList();
            return View(model);
        }
    }
}