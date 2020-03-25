using bootstrap_model_data_inserttion.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace bootstrap_model_data_inserttion.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
            Asp_DaniyalEntities asp = new Asp_DaniyalEntities();

                List<Dep_tbl> list = asp.Dep_tbl.ToList();
                ViewBag.dep_li = new SelectList(list, "Dep_id", "Dep_name");
                return View();
        }
        [HttpPost]
        public ActionResult Index(Class2 model)
        {
            try
            {
                Asp_DaniyalEntities asp = new Asp_DaniyalEntities();
                List<Dep_tbl> list = asp.Dep_tbl.ToList();
                ViewBag.dep_li = new SelectList(list, "Dep_id", "Dep_name");

                emp_tbl emp = new emp_tbl();
                emp.Address = model.Address;
                emp.Emp_name = model.Emp_name;
                emp.Dep_id = model.Dep_id;

                asp.emp_tbl.Add(emp);
                asp.SaveChanges();

                int lastempid = emp.Emp_id;

                site_tbl si = new site_tbl();
                si.site_name = model.site_name;
                si.Emp_id = lastempid;

                asp.site_tbl.Add(si);
                asp.SaveChanges();
                return View();
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}