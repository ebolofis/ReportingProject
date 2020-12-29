using DevExpress.Xpo;
using DXWebApplication_ReportDesigner.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WEBPOS_Reports.Helpers;
using WEBPOS_Reports.Models;


namespace WEBPOS_Reports.Controllers
{
    public class ReportListController : Controller
    {
        [HttpGet]
        [OutputCache(NoStore = true, Duration = 0, VaryByParam = "None")]
        public ActionResult Index()
        {
            try
            {
                using (var session = SessionFactory.Create())
                {

                    var reports = session.Query<ReportEntity>()
                        .Select(x => new NewReportModel
                        {
                            Url = x.Url
                        })
                        .ToList<NewReportModel>();


                    var firstReport = reports.FirstOrDefault();
                    var model = new IndexModel
                    {
                        SelectedReportUrl = firstReport != null ? firstReport.Url : string.Empty,
                        Reports = reports
                    };
                    return View("Index", model);
                }
            }
            catch (Exception ex)
            {
                CommonTools.Log("ReportListController Index - " + ex.Message);
                return null;
            }
        }

        [HttpGet]        
        public ActionResult ShowUploadForm()
        {
            
            return View("UploadFileView");
            
        }


        public JsonResult getAll()
        {
            try
            {
                using (RepDataEntity dataContext = new RepDataEntity())
                {
                    var reportList = dataContext.EFReportEntity.ToList();
                    var jsonResult = Json(new { reports = reportList }, JsonRequestBehavior.AllowGet);
                    jsonResult.MaxJsonLength = int.MaxValue;
                    return jsonResult;
                }
            }
            catch(Exception ex)
            {
                CommonTools.Log("getAll - " + ex.Message);
                return null;
            }
        }

        public EFReportEntity getById(int id)
        {
            using (RepDataEntity dataContext = new RepDataEntity())
            {
                EFReportEntity report = dataContext.EFReportEntity.Find(id);
                if (report == null)
                    CommonTools.Log("getById - " + "Not found id = " + id.ToString());
                return report;
            }
        }

        public string UpdateReport(EFReportEntity Rep)
        {

            try
            {
                if (Rep != null)
                {
                    using (RepDataEntity dataContext = new RepDataEntity())
                    {
                        int Id = Rep.Id;
                        var reportList = dataContext.EFReportEntity.Where(x => x.Id == Id).FirstOrDefault();
                        reportList.ReportName = Rep.ReportName;
                        reportList.Url = Rep.Url;
                        reportList.Menu = Rep.Menu;
                        reportList.Submenu = Rep.Submenu;
                        dataContext.SaveChanges();
                        return "Report Updated";
                    }
                }
                else
                {
                    return "Invalid Report";
                }
            }
            catch(Exception ex)
            {
                CommonTools.Log("UpdateReport - " + ex.Message);
                return "Update Error";
            }
        }

        public bool AddReport(EFReportEntity Rep)
        {

            try
            { 
                if (Rep != null)
                {
                    using (RepDataEntity dataContext = new RepDataEntity())
                    {
                        dataContext.EFReportEntity.Add(Rep);
                        dataContext.SaveChanges();
                        CommonTools.Log("AddReport - Report " + Rep.Url + " added / uploaded !");
                        return true;
                    }
                }
                else
                {
                    return false;
                }
            }   
            catch(System.Exception ex)
            {
                CommonTools.Log("AddReport - " + ex.Message);
                return false;
            }

        }

        public string deleteReport(EFReportEntity Rep)
        {
            try
            {
                if (Rep != null)
                {
                    using (RepDataEntity dataContext = new RepDataEntity())
                    {
                        var reportList = dataContext.EFReportEntity.Where(x => x.Id == Rep.Id).FirstOrDefault();
                        dataContext.EFReportEntity.Remove(reportList);
                        dataContext.SaveChanges();
                        CommonTools.Log("deleteReport - Report " + Rep.Url + " deleted !");
                        return "Report Deleted";
                    }
                }
                else
                {
                    return "Invalid Report";
                }
            }
            catch (System.Exception ex)
            {
                CommonTools.Log("deleteReport - " + ex.Message);
                return "Delete Report Error !";
            }
        }

        [HttpGet]
        public FileResult DownLoadFile(int id)
        {
            EFReportEntity report = getById(id);            
            return File(report.Layout, "application/xml", report.Url + ".posrpt");
        }


        [HttpPost]
        public ActionResult UploadFile(FileModel model)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return RedirectToAction("ShowUploadForm", "ReportList");
                }

                byte[] uploadedFile = new byte[model.File.InputStream.Length];
                model.File.InputStream.Read(uploadedFile, 0, uploadedFile.Length);

                EFReportEntity report = new Models.EFReportEntity();
                report.Layout = uploadedFile;
                report.ReportName = "";
                report.Url = model.Url;

                if (AddReport(report))
                    return RedirectToAction("Index", "ReportList");
                else
                {
                    return RedirectToAction("ShowUploadForm", "ReportList");
                }
            }
            catch (System.Exception ex)
            {
                CommonTools.Log("UploadFile - " + ex.Message);
                return null;
            }
        }


    }
}