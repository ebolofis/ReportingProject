using DevExpress.Xpo;
using DXWebApplication_ReportDesigner.DAL;
using DXWebApplication_ReportDesigner.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WEBPOS_Reports.Models;

using DevExpress.DataAccess.Sql;
using WEBPOS_Reports.Helpers;

namespace WEBPOS_Reports.Controllers
{
    public class DesignerController : Controller
    {
        [HttpGet]
        [OutputCache(NoStore = true, Duration = 0, VaryByParam = "None")]
        public ActionResult Index()
        {
            //using (var session = SessionFactory.Create())
            //{
            //    var reports = session.Query<DXWebApplication_ReportDesigner.DAL.ReportEntity>()
            //        .Select(x => new WEBPOS_Reports.Models.NewReportModel
            //        {
            //            Url = x.Url
            //        })
            //        .ToList<NewReportModel>();

            //    var firstReport = reports.FirstOrDefault();
            //    var model = new IndexModel
            //    {
            //        SelectedReportUrl = firstReport != null ? firstReport.Url : String.Empty,
            //        Reports = reports
            //    };
            //    return View("Index", model);


            //}

            return RedirectToAction("Index", "ReportList");
        }

        [HttpPost]
        public ActionResult Delete(string url)
        {
            using (var session = SessionFactory.Create())
            {
                var report = session.GetObjectByKey<ReportEntity>(url);
                session.Delete(report);

                session.CommitChanges();
            }
            return RedirectToRoute(new { controller = "Designer", action = "Index" });
        }


        [HttpGet]
        public ActionResult Design(string url)
        {
            return View("Design", new DesignModel { Url = url, DataSource = CommonTools.CreateSqlDataSource() });
        }

        [HttpGet]
        public ActionResult New()
        {
            return View("Design", new DesignModel { Url = null, DataSource = CommonTools.CreateSqlDataSource() });
        }

        [HttpGet]
        public ActionResult Preview(string url)
        {
            return View("Preview", new DesignModel { Url = url, DataSource = CommonTools.CreateSqlDataSource() });
        }




        public JsonResult getAll()
        {
            using (RepDataEntity dataContext = new RepDataEntity())
            {
                var employeeList = dataContext.EFReportEntity.ToList();
                return Json(employeeList, JsonRequestBehavior.AllowGet);
            }

        }

        public JsonResult getReportByUrl(string EmpNo)
        {
            using (RepDataEntity dataContext = new RepDataEntity())
            {
                int no = Convert.ToInt32(EmpNo);
                var employeeList = dataContext.EFReportEntity.Find(no);
                return Json(employeeList, JsonRequestBehavior.AllowGet);
            }
        }

        public JsonResult getReportById(int Id)
        {
            using (RepDataEntity dataContext = new RepDataEntity())
            {
                var employeeList = dataContext.EFReportEntity.Find(Id);
                return Json(employeeList, JsonRequestBehavior.AllowGet);
            }
        }

    }
}