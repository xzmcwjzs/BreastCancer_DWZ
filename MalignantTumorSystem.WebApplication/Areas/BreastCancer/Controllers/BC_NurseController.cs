﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MalignantTumorSystem.WebApplication.Areas.BreastCancer.Controllers
{
    public class BC_NurseController : Controller
    {
        // GET: BreastCancer/BC_Nurse
        #region 框架页

        public ActionResult Frame()
        {
            return View();
        }
        public ActionResult Top()
        {
            return View();
        }
        public ActionResult Body()
        {
            return View();
        }
       
        #endregion
        //列表页
        public ActionResult List()
        {
            return View();
        }
    }
}