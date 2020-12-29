
using DXWebApplication_ReportDesigner.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Configuration;
using System.Web.Mvc;
using WEBPOS_Reports.Helpers;
using WEBPOS_Reports.Models;

namespace WEBPOS_Reports.Controllers
{

    public class HomeController : Controller
    {

        public ActionResult Index(string strParam, string strType)
        {
            /*
             *  Reports Id syntax:
             *  1st Char:  DB version 
             *                      N: new DB,  
             *                      O: old DB
             *  2nd Char: Main Menu
             *                      D: "Καθημερινές Λειτουργίες"
             *                      F: "Αρχείο Συστήματος"
             *                      S: "Πωλήσεις"
             *  
             *  3rd char: submenu
             *                      _: no submeny
             *                      B: Best Seller
             *                      R: Ανά Δωμάτιο
             *                      O: Ανά Χειριστή
             *                      P: Ανά Τιμοκατάλογο
             *                      C: Ανά Κατηγορία
             *                      F: flat
             * 4th Char: a number
             * 
             * 
             * ex: NF_2 means: New DataBase, Main Menu: "Αρχείο Συστήματος", Submenu: non
             * 
             * */



            ViewBag.Message = "Welcome to our ASP.NET MVC application for Web POS Reports!";
            int dbVersion = 2;
            Int32.TryParse(WebConfigurationManager.AppSettings["DBVersion"], out dbVersion);
            ViewBag.DBVersion = dbVersion;
            //return View();

            // Get application version number
            Assembly assembly = Assembly.GetExecutingAssembly();
            FileVersionInfo fvi = FileVersionInfo.GetVersionInfo(assembly.Location);
            ViewBag.ApplicationVersion = "v." + fvi.FileVersion;

            //get reports from webconfig and store them into a Dictionary
            StringCollection repos = Properties.Settings.Default.Reports;
            Dictionary<string, ReportModel> Reports = new Dictionary<string, ReportModel>();
            foreach(string item in repos)
            {
                ReportModel rm = JsonConvert.DeserializeObject<ReportModel>(item.ToString());
                Reports.Add(rm.Key, rm);             
            }

            
            //****************************
            //gbs add reports
            //****************************

            using (RepDataEntity dataContext = new RepDataEntity())
            {
                var reportList = dataContext.EFReportEntity.ToList();
                foreach (EFReportEntity rep in reportList)
                {
                    string key = KeyFromMenu(rep.Menu, rep.Submenu);
                    ReportModel rm = new ReportModel();
                    rm.ReportType = REPORT_TYPE.NEW_CUSTOM_REPORT;
                    rm.Name = rep.Url;
                    rm.Key = key;
                    Reports.Add(rm.Key + rep.Url, rm);
                }
            }

            //****************************


            ViewBag.Reports = Reports;

            //return the selected report
            if (string.IsNullOrEmpty(strParam))
            {
                ViewBag.ReportTitle = "Welcome";
                return View("IndexEmpty");
            }
            else
            {
                ReportModel rm = new ReportModel();
                try
                {
                    if (strParam == "NewReport")
                    {
                        return RedirectToAction("Index", "ReportList");
                    }

                    if (strType == "OLD")
                    {
                        //get the model of the selected report
                        rm = Reports[strParam];
                        ViewBag.ReportTitle = rm.Name;
                        //use reflection to create an instanse of report's class
                        var type = Type.GetType(rm.ClassName);
                        if (type == null) throw new Exception("Class: '" + rm.ClassName + "' does not exist. Check the WebConfig file. <----<<<");
                        return View(Activator.CreateInstance(type));
                    }
                    else
                    {
                        ViewBag.ReportTitle = strParam;
                        return View("Preview", new DesignModel { Url = strParam, DataSource = CommonTools.CreateSqlDataSource() });
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error reading report: " + rm.ToString() + " from WebConfig file.", ex);
                }

            }


            /*      switch (strParam)
                  {
                      default:
                          ViewBag.ReportTitle = "Welcome";
                          return View("IndexEmpty");

                      case "R1i0":
                          ViewBag.ReportTitle = Properties.Settings.Default.R1i0;//Αναφορά Αποδείξεων
                          return View(new Receipts());

                      case "R1i0b":
                          ViewBag.ReportTitle = Properties.Settings.Default.R1i0b;//Αναφορά Αποδείξεων
                          return View(new ReceiptsOldDB());

                      case "R1i1":
                          ViewBag.ReportTitle = Properties.Settings.Default.R1i1;//Πωλήσεις ανά Σερβιτόρο
                          return View(new SalesPerWaiter());

                      case "R1i1b":
                          ViewBag.ReportTitle = Properties.Settings.Default.R1i1b;//Πωλήσεις ανά Σερβιτόρο
                          return View(new SalesPerWaiterOldDB());

                      case "R1i2":
                          ViewBag.ReportTitle = Properties.Settings.Default.R1i2;//Εισπράξεις ανά Σερβιτόρο
                          return View(new RevenuePerWaiter());

                      //case "1i3":
                      //   ViewBag.ReportTitle = "Αναφορά Πωλήσεων Ημέρας";
                      //   return View( new Receipts() );

                      //case "1i4":
                      //   ViewBag.ReportTitle = "Vat Per Account";
                      //   return View( new Receipts() );

                      case "R1i5":
                          ViewBag.ReportTitle = Properties.Settings.Default.R1i5;//Ημερολόγιο Πωλήσεων
                          return View(new SalesDiary());

                      case "R1i6":
                          ViewBag.ReportTitle = Properties.Settings.Default.R1i6;//Πωλήσεις ανά Τραπέζι
                          return View(new RevenuePerTable());

                      case "R1i6b":
                          ViewBag.ReportTitle = Properties.Settings.Default.R1i6b;//Πωλήσεις ανά Τραπέζι
                          return View(new RevenuePerTableOldDB());

                      case "R1i7":
                          ViewBag.ReportTitle = Properties.Settings.Default.R1i7;//Ημερολόγιο Πωλήσεων με Σχόλιο Είδους
                          return View(new SalesDiaryItemRemark());
                      //case "1i7":
                      //   ViewBag.ReportTitle = "Ημερολόγιο Πωλήσεων (μόνο εκπτώσεις)";
                      //   return View( new Receipts() );

                      //=========================================

                      //case "2i0":
                      //   ViewBag.ReportTitle = "Food & Beverage Statistics";
                      //   return View( new () );

                      //=== best seller submenu =================

                      case "R2i01":   // NEW DB
                          ViewBag.ReportTitle = Properties.Settings.Default.R2i01;//Best Seller Εσόδων ανά POS
                          return View(new BestSellerRevenuePerPos());

                      case "R2i02":   // NEW DB
                          ViewBag.ReportTitle = Properties.Settings.Default.R2i02;//Best Seller Εσόδων
                          return View(new BestSellerRevenue());

                      case "R2i03":   // NEW DB
                          ViewBag.ReportTitle = Properties.Settings.Default.R2i03;//Best Seller (ανά Αξία)
                          return View(new BestSellerRevenue2());

                      case "R2i04":   // NEW DB
                          ViewBag.ReportTitle = Properties.Settings.Default.R2i04;//Best Seller (ανά Ποσότητα)
                          return View(new BestSellerQty());

                      case "R2i05":   // NEW DB
                          ViewBag.ReportTitle = Properties.Settings.Default.R2i05;//Best Seller (ανά Ποσότητα)
                          return View(new BestSellerQty());

                      case "R2i06":   // NEW DB
                          ViewBag.ReportTitle = Properties.Settings.Default.R2i06;//Best Seller Ποσότητας ανά Κατηγορία Είδους
                          return View(new BestSellerQtyGrpPC());

                      case "R2i01b":   // OLD DB
                          ViewBag.ReportTitle = Properties.Settings.Default.R2i01b;//Best Seller Εσόδων ανά POS
                          return View(new BestSellerRevenuePerPosOldDB());

                      case "R2i03b":   // OLD DB
                          ViewBag.ReportTitle = Properties.Settings.Default.R2i03b;//Best Seller (ανά Αξία)
                          return View(new BestSellerRevenue2OldDB());

                      case "R2i05b":   // OLD DB
                          ViewBag.ReportTitle = Properties.Settings.Default.R2i05b;//Best Seller (ανά Ποσότητα)
                          return View(new BestSellerQtyOldDB());

                      //=== best seller on main menu ============

                      case "R2i0":
                          ViewBag.ReportTitle = Properties.Settings.Default.R2i0;//Best Seller Εσόδων ανά POS
                          return View(new BestSellerRevenuePerPos());

                      case "R2i1":
                          ViewBag.ReportTitle = Properties.Settings.Default.R2i1;//Best Seller Εσόδων
                          return View(new BestSellerRevenue());

                      case "R2i1a":
                          ViewBag.ReportTitle = Properties.Settings.Default.R2i1a;//Best Seller (ανά Ποσότητα)
                          return View(new BestSellerQty());

                      //=== sales menu option ============

                      case "R2i2":
                          ViewBag.ReportTitle = Properties.Settings.Default.R2i2;//Πωλήσεις Complimentary vs Room
                          return View(new CoplimenatryVsRoom());

                      case "R2i3":
                          ViewBag.ReportTitle = Properties.Settings.Default.R2i3;//Πωλήσεις Ειδών ανά Χειριστή - Συνοπτικά
                          return View(new SalesPerStaffTotal());

                      case "R2i3a":
                          ViewBag.ReportTitle = Properties.Settings.Default.R2i3a;//Πωλήσεις Ειδών ανά Χειριστή και POS - Συνοπτικά
                          return View(new SalesPerStaffAndPosTotal());

                      case "R2i3ab":
                          ViewBag.ReportTitle = Properties.Settings.Default.R2i3ab;//Πωλήσεις ανά Χειριστή και Τρόπο Πληρωμής - Συνοπτικά
                          return View(new SalesPerPaymentTotal2());

                      case "R2i3abc":
                          ViewBag.ReportTitle = Properties.Settings.Default.R2i3abc;//Πωλήσεις ανά Τιμοκατάλογο και ’τομα - Συνοπτικά
                          return View(new SalesPerPricelistCoverTotal2());

                      case "R2i4":
                          ViewBag.ReportTitle = Properties.Settings.Default.R2i4;//Πωλήσεις Ειδών ανά Χειριστή - Αναλυτικά
                          return View(new SalesPerStaffAnalytical());

                      case "R2i4a":
                          ViewBag.ReportTitle = Properties.Settings.Default.R2i4a;//Πωλήσεις Ειδών ανά Χειριστή και POS - Αναλυτικά
                          return View(new SalesPerStaffAndPosAnalytical());

                      case "R2i4ab":
                          ViewBag.ReportTitle = Properties.Settings.Default.R2i4ab;//Πωλήσεις Ειδών ανά Χειριστή POS και Τιμοκατάλογο - Αναλυτικά
                          return View(new SalesPerStaffPosPricelistAnalytical());

                      case "R2i4c":
                          ViewBag.ReportTitle = Properties.Settings.Default.R2i4c;//Πωλήσεις ανά Χειριστή, Τιμοκατάλογο και Κατηγορία - Συνοπτικά
                          return View(new SalesPerStaffPricelistCategory2());

                      case "R2i4d":
                          ViewBag.ReportTitle = Properties.Settings.Default.R2i4d;//Πωλήσεις ανά Χειριστή, Τιμοκατάλογο και Κατηγορία Προϊόντων - Συνοπτικά
                          return View(new SalesPerStaffPricelistCategory3());

                      case "R2i4e":
                          ViewBag.ReportTitle = Properties.Settings.Default.R2i4e;//Δελτία Παραγγελίας ανά Χειριστή - Αναλυτικά
                          return View(new OrdersPerStaffAnalytical());

                      case "R2i5":
                          ViewBag.ReportTitle = Properties.Settings.Default.R2i5;//Πωλήσεις Ειδών ανά Τιμοκατάλογο
                          return View(new SalesPerPricelist());

                      case "R2i5a":
                          ViewBag.ReportTitle = Properties.Settings.Default.R2i5a;//Πωλήσεις Ειδών ανά Τιμοκατάλογο και POS
                          return View(new SalesPerPricelistAndPos());

                      case "R2i5ab":
                          ViewBag.ReportTitle = Properties.Settings.Default.R2i5ab;//Πωλήσεις Ειδών ανά Τιμοκατάλογο POS και Κατηγορία
                          return View(new SalesPerPricelistPosCategory());

                      case "R2i6aa":
                          ViewBag.ReportTitle = Properties.Settings.Default.R2i6aa;//Πωλήσεις Ειδών ανά Κατηγορία
                          return View(new SalesPerCategory());

                      case "R2i6ab":
                          ViewBag.ReportTitle = Properties.Settings.Default.R2i6ab;//Πωλήσεις Ειδών ανά Κατηγορία και POS
                          return View(new SalesPerCategoryAndPos());

                      case "R2i6ac":
                          ViewBag.ReportTitle = Properties.Settings.Default.R2i6ac;//Πωλήσεις Ειδών ανά Κατηγορία και POS - Συνοπτικά
                          return View(new SalesPerCategoryAndPosTotal());

                      case "R2i8":
                          ViewBag.ReportTitle = Properties.Settings.Default.R2i8;//Κόστος Πωληθέντων
                          return View(new SalesCost());

                      case "R2i9":
                          ViewBag.ReportTitle = Properties.Settings.Default.R2i9;//Κόστος Πωληθέντων (maison)
                          return View(new SalesCostMaison());

                      case "R2i10":
                          ViewBag.ReportTitle = Properties.Settings.Default.R2i10;//Κόστος Πωληθέντων (AI)
                          return View(new SalesCostAL());

                      case "R2i11":
                          ViewBag.ReportTitle = Properties.Settings.Default.R2i11;//Καθαρές Αξίες Πωλήσεων
                          return View(new SalesNetAmount2());

                      case "R2i12":
                          ViewBag.ReportTitle = Properties.Settings.Default.R2i12;//Πωλήσεις Complimentary vs Room Area
                          return View(new CoplimenatryVsRoomArea());

                      //case "2i13":
                      //   ViewBag.ReportTitle = "Best Seller (Grouped by Pos)";
                      //   return View( new () );

                      //case "2i14":
                      //   ViewBag.ReportTitle = "Best Seller";
                      //   return View( new () );--------

                      case "R2i15":
                          ViewBag.ReportTitle = Properties.Settings.Default.R2i15;//Ωριαίες Πωλήσεις Ειδών
                          return View(new HourlyProductSales());

                      case "R2i16":
                          ViewBag.ReportTitle = Properties.Settings.Default.R2i16;//Food & Beverage Statistics
                          return View(new FnB_Statistics());

                      case "R2i17":
                          ViewBag.ReportTitle = Properties.Settings.Default.R2i17;//Ωριαίες Πωλήσεις Αποδείξεων ανά Τύπο Παραστατικού
                          return View(new HourlyReceiptSalesPerInvoiceType());

                      case "R2i17b":
                          ViewBag.ReportTitle = Properties.Settings.Default.R2i17b;//Ωριαίες Πωλήσεις ανά Τύπο Παραστατικού Συνοπτικά
                          return View(new HourlySalesPerInvoiceTypeTotal_OldDB());

                      case "R2i18":
                          ViewBag.ReportTitle = Properties.Settings.Default.R2i18;//Πωλήσεις ανά Είδος (flat)
                          return View(new SalesPerProductFlat());

                      case "R2i19":
                          ViewBag.ReportTitle = Properties.Settings.Default.R2i19;//Πωλήσεις ανά Τιμοκατάλογο, Είδος και ΦΠΑ (flat)
                          return View(new SalesPerPricelistCodeVat_Flat());

                      case "R2i20":
                          ViewBag.ReportTitle = Properties.Settings.Default.R2i20;//Πωλήσεις ανά Δωμάτιο Συνοπτικά
                          return View(new SalesPerRoomTotal());

                      case "R2i21":
                          ViewBag.ReportTitle = Properties.Settings.Default.R2i21;//Πωλήσεις ανά Τραπέζι - Αναλυτικά
                          return View(new SalesPerCategoryAndPosAndRegionTables());

                      case "R2i22":
                          ViewBag.ReportTitle = Properties.Settings.Default.R2i22;//Πωλήσεις ανά Buzzer - Αναλυτικά
                          return View(new SalesPerBuzzerAnalytical());

                      //
                      //-----------------------------------------

                      case "R2i3b":   // OLD DB
                          ViewBag.ReportTitle = Properties.Settings.Default.R2i3b;//Πωλήσεις Ειδών ανά Χειριστή Συνοπτικά
                          return View(new SalesPerStaffTotalOldDB());

                      case "R2i4b":   // OLD DB
                          ViewBag.ReportTitle = Properties.Settings.Default.R2i4b;//Πωλήσεις Ειδών ανά Χειριστή Αναλυτικά
                          return View(new SalesPerStaffAnalyticalOldDB());

                      case "R2i5b":   // OLD DB
                          ViewBag.ReportTitle = Properties.Settings.Default.R2i5b;//Πωλήσεις Ειδών ανά Τιμοκατάλογο
                          return View(new SalesPerPricelistOldDB());

                      case "R2i6b":   // OLD DB
                          ViewBag.ReportTitle = Properties.Settings.Default.R2i6b;//Πωλήσεις Ειδών ανά Κατηγορία
                          return View(new SalesPerCategoryOldDB());

                      case "R2i7b":   // OLD DB
                          ViewBag.ReportTitle = Properties.Settings.Default.R2i7b;//Πωλήσεις Ειδών ανά Κατηγορία και POS
                          return View(new SalesPerCategoryAndPosOldDB());

                      case "R2i8b":   // OLD DB
                          ViewBag.ReportTitle = Properties.Settings.Default.R2i8b;//Κόστος Πωληθέντων
                          return View(new SalesCostOldDB());

                      //=========================================

                      case "R3i0":
                          ViewBag.ReportTitle = Properties.Settings.Default.R3i0;//Εκτύπωση Κλεισίματος
                          return View(new EndOfDay());

                      case "R3i1":
                          ViewBag.ReportTitle = Properties.Settings.Default.R3i1;//Εκτύπωση Κλεισίματος ανά Δωμάτιο
                          return View(new EndOfDayPerRoom());

                      //case "3i2":
                      //   ViewBag.ReportTitle = "Εκτύπωση Κλεισίματος ανά Απόδειξη";
                      //   return View( new () );

                      //=========================================

                      case "R4i0":
                          ViewBag.ReportTitle = Properties.Settings.Default.R4i0;//Αρχείο Ειδών
                          return View(new ProductFilesPivot());

                      case "R4i1":
                          ViewBag.ReportTitle = Properties.Settings.Default.R4i1;//Προϊόντα ανά Σελίδα
                          return View(new PageButton());

                      case "R4i2":
                          ViewBag.ReportTitle = Properties.Settings.Default.R4i2;//Προϊόντα ανά Σελίδα και POS
                          return View(new PageButtonPerPos());
                  }*/

        }

        public ActionResult InvoicesPerVat()
        {
            return View(new Receipts());
        }


        string KeyFromMenu(string Menu, string Submenu)
        {
            String res = "";

            if (Menu == "1")
                res = "ND_";
            else if (Menu == "2")
                res = "NF_";
            else if (Menu == "4")
                res = "NP_";
            else if (Menu == "5")
                res = "NB_";
            else if (Menu == "3")
            {
                if (Submenu == "1")
                    res = "NSB";
                else if (Submenu == "2")
                    res = "NSR";
                else if (Submenu == "3")
                    res = "NSO";
                else if (Submenu == "4")
                    res = "NSP";
                else if (Submenu == "5")
                    res = "NSC";
                else if (Submenu == "6")
                    res = "NSF";
                else if (Submenu == "")
                    res = "NS_";

            }



            return res;

        }
    }

}

