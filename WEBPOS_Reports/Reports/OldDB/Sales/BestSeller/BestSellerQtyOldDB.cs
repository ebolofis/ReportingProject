
using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Web.Configuration;
using System.Collections.Generic;
using DevExpress.DataAccess.Sql;
using DevExpress.DataAccess.Native.Sql;
using WEBPOS_Reports.Helpers;

/// <summary>
/// Summary description for BestSellerQtyOldDB
/// </summary>
public class BestSellerQtyOldDB : DevExpress.XtraReports.UI.XtraReport
   {
   private DevExpress.XtraReports.UI.DetailBand Detail;
   private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
   private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
   private XRLabel xrLabel2;
   private XRLabel xrLabel3;
   private XRLabel xrLabel4;
   private XRLabel xrLabel5;
   private XRLabel xrLabel6;
   private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
   private ReportHeaderBand ReportHeader;
   private XRLabel xrLabel1;
   private DevExpress.XtraReports.Parameters.Parameter dtFrom;
   private DevExpress.XtraReports.Parameters.Parameter dtTo;
   private XRLabel xrLabel14;
   private XRLabel xrLabel17;
   private XRLabel xrLabel26;
   private XRLabel xrLabel24;
   private XRLabel xrLabel23;
   private XRLabel xrLabel22;
   private XRLabel xrLabel21;
   private XRLabel xrLabel20;
   private XRLabel xrLabel28;
   private DevExpress.XtraReports.Parameters.Parameter ProductCategory;
   private DevExpress.XtraReports.Parameters.Parameter Categories;
   private XRLabel xrLabel29;
   private XRPageInfo xrPageInfo3;
   private ReportFooterBand ReportFooter;
   private XRLabel xrLabel11;
   private XRLabel xrLabel10;
   private XRLabel xrLabel9;
   private XRLabel xrLabel8;
   private XRLabel xrLabel7;
   private XRLabel xrLabel12;
   private PageFooterBand PageFooter;
   private XRPageInfo xrPageInfo1;
   private GroupHeaderBand GroupHeader1;
   private XRLabel xrLabel13;
   private XRLabel xrLabel15;
   private XRLabel xrLabel16;
   private XRLabel xrLabel18;
   private XRLabel xrLabel19;
   private XRLabel xrLabel25;
   private XRLabel xrLabel27;
   private XRLabel xrLabel30;
   private DevExpress.XtraReports.Parameters.Parameter InvoiceType;
   private DevExpress.XtraReports.Parameters.Parameter PosInfoId;
   private DevExpress.XtraReports.Parameters.Parameter DepartmentId;
   private PageHeaderBand PageHeader;
   private XRLabel xrLabel31;

   //private DevExpress.XtraReports.Parameters.Parameter SortOrder;

   /// <summary>
   /// Required designer variable.
   /// </summary>
   private System.ComponentModel.IContainer components = null;

   public BestSellerQtyOldDB()
      {
      try
         {
         InitializeComponent();
         //
         // TODO: Add constructor logic here
         //
         }
      catch { }
      }

   /// <summary> 
   /// Clean up any resources being used.
   /// </summary>
   /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
   protected override void Dispose( bool disposing )
      {
      if ( disposing && ( components != null ) )
         {
         components.Dispose();
         }
      base.Dispose( disposing );
      }

   #region Designer generated code

   /// <summary>
   /// Required method for Designer support - do not modify
   /// the contents of this method with the code editor.
   /// </summary>
   private void InitializeComponent()
      {
         this.components = new System.ComponentModel.Container();
         DevExpress.DataAccess.Sql.CustomSqlQuery customSqlQuery1 = new DevExpress.DataAccess.Sql.CustomSqlQuery();
         DevExpress.DataAccess.Sql.QueryParameter queryParameter1 = new DevExpress.DataAccess.Sql.QueryParameter();
         DevExpress.DataAccess.Sql.QueryParameter queryParameter2 = new DevExpress.DataAccess.Sql.QueryParameter();
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BestSellerQtyOldDB));
         DevExpress.DataAccess.Sql.CustomSqlQuery customSqlQuery2 = new DevExpress.DataAccess.Sql.CustomSqlQuery();
         DevExpress.DataAccess.Sql.CustomSqlQuery customSqlQuery3 = new DevExpress.DataAccess.Sql.CustomSqlQuery();
         DevExpress.DataAccess.Sql.CustomSqlQuery customSqlQuery4 = new DevExpress.DataAccess.Sql.CustomSqlQuery();
         DevExpress.DataAccess.Sql.CustomSqlQuery customSqlQuery5 = new DevExpress.DataAccess.Sql.CustomSqlQuery();
         DevExpress.DataAccess.Sql.CustomSqlQuery customSqlQuery6 = new DevExpress.DataAccess.Sql.CustomSqlQuery();
         DevExpress.DataAccess.Sql.CustomSqlQuery customSqlQuery7 = new DevExpress.DataAccess.Sql.CustomSqlQuery();
         DevExpress.XtraReports.UI.XRSummary xrSummary1 = new DevExpress.XtraReports.UI.XRSummary();
         DevExpress.XtraReports.UI.XRSummary xrSummary2 = new DevExpress.XtraReports.UI.XRSummary();
         DevExpress.XtraReports.UI.XRSummary xrSummary3 = new DevExpress.XtraReports.UI.XRSummary();
         DevExpress.XtraReports.Parameters.DynamicListLookUpSettings dynamicListLookUpSettings1 = new DevExpress.XtraReports.Parameters.DynamicListLookUpSettings();
         DevExpress.XtraReports.Parameters.DynamicListLookUpSettings dynamicListLookUpSettings2 = new DevExpress.XtraReports.Parameters.DynamicListLookUpSettings();
         DevExpress.XtraReports.UI.XRSummary xrSummary4 = new DevExpress.XtraReports.UI.XRSummary();
         DevExpress.XtraReports.UI.XRSummary xrSummary5 = new DevExpress.XtraReports.UI.XRSummary();
         DevExpress.XtraReports.UI.XRGroupSortingSummary xrGroupSortingSummary1 = new DevExpress.XtraReports.UI.XRGroupSortingSummary();
         DevExpress.XtraReports.UI.XRSummary xrSummary6 = new DevExpress.XtraReports.UI.XRSummary();
         DevExpress.XtraReports.UI.XRSummary xrSummary7 = new DevExpress.XtraReports.UI.XRSummary();
         DevExpress.XtraReports.UI.XRSummary xrSummary8 = new DevExpress.XtraReports.UI.XRSummary();
         DevExpress.XtraReports.UI.XRSummary xrSummary9 = new DevExpress.XtraReports.UI.XRSummary();
         DevExpress.XtraReports.Parameters.DynamicListLookUpSettings dynamicListLookUpSettings3 = new DevExpress.XtraReports.Parameters.DynamicListLookUpSettings();
         DevExpress.XtraReports.Parameters.DynamicListLookUpSettings dynamicListLookUpSettings4 = new DevExpress.XtraReports.Parameters.DynamicListLookUpSettings();
         DevExpress.XtraReports.Parameters.DynamicListLookUpSettings dynamicListLookUpSettings5 = new DevExpress.XtraReports.Parameters.DynamicListLookUpSettings();
         this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
         this.Detail = new DevExpress.XtraReports.UI.DetailBand();
         this.xrLabel11 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel10 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel4 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel5 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel6 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel17 = new DevExpress.XtraReports.UI.XRLabel();
         this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
         this.xrPageInfo3 = new DevExpress.XtraReports.UI.XRPageInfo();
         this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
         this.xrLabel29 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel28 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel14 = new DevExpress.XtraReports.UI.XRLabel();
         this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
         this.xrLabel31 = new DevExpress.XtraReports.UI.XRLabel();
         this.dtTo = new DevExpress.XtraReports.Parameters.Parameter();
         this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
         this.dtFrom = new DevExpress.XtraReports.Parameters.Parameter();
         this.xrLabel9 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel8 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel26 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel24 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel23 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel22 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel21 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel20 = new DevExpress.XtraReports.UI.XRLabel();
         this.ProductCategory = new DevExpress.XtraReports.Parameters.Parameter();
         this.Categories = new DevExpress.XtraReports.Parameters.Parameter();
         this.ReportFooter = new DevExpress.XtraReports.UI.ReportFooterBand();
         this.xrLabel12 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel7 = new DevExpress.XtraReports.UI.XRLabel();
         this.PageFooter = new DevExpress.XtraReports.UI.PageFooterBand();
         this.xrPageInfo1 = new DevExpress.XtraReports.UI.XRPageInfo();
         this.GroupHeader1 = new DevExpress.XtraReports.UI.GroupHeaderBand();
         this.xrLabel13 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel15 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel16 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel18 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel19 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel25 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel27 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel30 = new DevExpress.XtraReports.UI.XRLabel();
         this.InvoiceType = new DevExpress.XtraReports.Parameters.Parameter();
         this.PosInfoId = new DevExpress.XtraReports.Parameters.Parameter();
         this.DepartmentId = new DevExpress.XtraReports.Parameters.Parameter();
         this.PageHeader = new DevExpress.XtraReports.UI.PageHeaderBand();
         ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
         // 
         // sqlDataSource1
         // 
         this.sqlDataSource1.ConnectionName = "ReportConnection";
         this.sqlDataSource1.Name = "sqlDataSource1";
         customSqlQuery1.Name = "Query";
         queryParameter1.Name = "FromDate";
         queryParameter1.Type = typeof(DevExpress.DataAccess.Expression);
         queryParameter1.Value = new DevExpress.DataAccess.Expression("[Parameters.dtFrom]", typeof(System.DateTime));
         queryParameter2.Name = "ToDate";
         queryParameter2.Type = typeof(DevExpress.DataAccess.Expression);
         queryParameter2.Value = new DevExpress.DataAccess.Expression("[Parameters.dtTo]", typeof(System.DateTime));
         customSqlQuery1.Parameters.Add(queryParameter1);
         customSqlQuery1.Parameters.Add(queryParameter2);
         customSqlQuery1.Sql = resources.GetString("customSqlQuery1.Sql");
         customSqlQuery2.Name = "ProductCategories";
         customSqlQuery2.Sql = "SELECT Code, Description FROM ProductCategories ORDER BY Description";
         customSqlQuery3.Name = "PosInfos";
         customSqlQuery3.Sql = "SELECT pif.Id, pif.[Description] [Description] \r\nFROM PosInfo pif\r\nORDER BY pif.[" +
    "Description]";
         customSqlQuery4.Name = "Categories";
         customSqlQuery4.Sql = "SELECT Id, Description FROM Categories ORDER BY Description";
         customSqlQuery5.Name = "Query_FastStart";
         customSqlQuery5.Sql = "select * from invoices where id = -1";
         customSqlQuery6.Name = "InvoiceTypes";
         customSqlQuery6.Sql = "SELECT DISTINCT Id, Abbreviation, Type\r\nFROM InvoiceTypes\r\nWHERE Type NOT IN (2,3" +
    ",8,10,11,12) \r\nORDER BY Type";
         customSqlQuery7.Name = "Departments";
         customSqlQuery7.Sql = "Select Id, Description from Department";
         this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            customSqlQuery1,
            customSqlQuery2,
            customSqlQuery3,
            customSqlQuery4,
            customSqlQuery5,
            customSqlQuery6,
            customSqlQuery7});
         this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
         // 
         // Detail
         // 
         this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel11,
            this.xrLabel10,
            this.xrLabel2,
            this.xrLabel3,
            this.xrLabel4,
            this.xrLabel5,
            this.xrLabel6,
            this.xrLabel17});
         this.Detail.HeightF = 17F;
         this.Detail.Name = "Detail";
         this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
         this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
         this.Detail.Visible = false;
         // 
         // xrLabel11
         // 
         this.xrLabel11.CanGrow = false;
         this.xrLabel11.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.VatAmount", "{0:#,##0.00}")});
         this.xrLabel11.LocationFloat = new DevExpress.Utils.PointFloat(914.2917F, 0F);
         this.xrLabel11.Name = "xrLabel11";
         this.xrLabel11.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel11.SizeF = new System.Drawing.SizeF(62.5F, 17F);
         this.xrLabel11.StylePriority.UseTextAlignment = false;
         this.xrLabel11.Text = "xrLabel11";
         this.xrLabel11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
         this.xrLabel11.WordWrap = false;
         // 
         // xrLabel10
         // 
         this.xrLabel10.CanGrow = false;
         this.xrLabel10.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.Net", "{0:#,##0.00}")});
         this.xrLabel10.LocationFloat = new DevExpress.Utils.PointFloat(834.0834F, 0F);
         this.xrLabel10.Name = "xrLabel10";
         this.xrLabel10.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel10.SizeF = new System.Drawing.SizeF(80.20831F, 17F);
         this.xrLabel10.StylePriority.UseTextAlignment = false;
         this.xrLabel10.Text = "xrLabel10";
         this.xrLabel10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
         this.xrLabel10.WordWrap = false;
         // 
         // xrLabel2
         // 
         this.xrLabel2.CanGrow = false;
         this.xrLabel2.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.CategoryDescription")});
         this.xrLabel2.Font = new System.Drawing.Font("Times New Roman", 8F);
         this.xrLabel2.LocationFloat = new DevExpress.Utils.PointFloat(6.000061F, 0F);
         this.xrLabel2.Name = "xrLabel2";
         this.xrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel2.SizeF = new System.Drawing.SizeF(103.9999F, 17F);
         this.xrLabel2.StylePriority.UseFont = false;
         this.xrLabel2.Text = "xrLabel2";
         this.xrLabel2.WordWrap = false;
         // 
         // xrLabel3
         // 
         this.xrLabel3.CanGrow = false;
         this.xrLabel3.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.ProductCategoryDescrtiption")});
         this.xrLabel3.Font = new System.Drawing.Font("Times New Roman", 8F);
         this.xrLabel3.LocationFloat = new DevExpress.Utils.PointFloat(110F, 0F);
         this.xrLabel3.Name = "xrLabel3";
         this.xrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel3.SizeF = new System.Drawing.SizeF(216.9749F, 17F);
         this.xrLabel3.StylePriority.UseFont = false;
         this.xrLabel3.WordWrap = false;
         // 
         // xrLabel4
         // 
         this.xrLabel4.CanGrow = false;
         this.xrLabel4.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.ProductCode")});
         this.xrLabel4.Font = new System.Drawing.Font("Times New Roman", 8F);
         this.xrLabel4.LocationFloat = new DevExpress.Utils.PointFloat(326.9749F, 0F);
         this.xrLabel4.Name = "xrLabel4";
         this.xrLabel4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel4.SizeF = new System.Drawing.SizeF(103.125F, 17F);
         this.xrLabel4.StylePriority.UseFont = false;
         this.xrLabel4.Text = "xrLabel4";
         this.xrLabel4.WordWrap = false;
         // 
         // xrLabel5
         // 
         this.xrLabel5.CanGrow = false;
         this.xrLabel5.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.ProductDescription")});
         this.xrLabel5.Font = new System.Drawing.Font("Times New Roman", 8F);
         this.xrLabel5.LocationFloat = new DevExpress.Utils.PointFloat(430.0999F, 0F);
         this.xrLabel5.Name = "xrLabel5";
         this.xrLabel5.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel5.SizeF = new System.Drawing.SizeF(341.4835F, 17F);
         this.xrLabel5.StylePriority.UseFont = false;
         this.xrLabel5.Text = "xrLabel5";
         this.xrLabel5.WordWrap = false;
         // 
         // xrLabel6
         // 
         this.xrLabel6.CanGrow = false;
         this.xrLabel6.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.Qty", "{0:0.000}")});
         this.xrLabel6.Font = new System.Drawing.Font("Times New Roman", 8F);
         this.xrLabel6.LocationFloat = new DevExpress.Utils.PointFloat(771.5834F, 0F);
         this.xrLabel6.Name = "xrLabel6";
         this.xrLabel6.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel6.SizeF = new System.Drawing.SizeF(62.5F, 17F);
         this.xrLabel6.StylePriority.UseFont = false;
         this.xrLabel6.StylePriority.UseTextAlignment = false;
         xrSummary1.IgnoreNullValues = true;
         this.xrLabel6.Summary = xrSummary1;
         this.xrLabel6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
         this.xrLabel6.WordWrap = false;
         // 
         // xrLabel17
         // 
         this.xrLabel17.CanGrow = false;
         this.xrLabel17.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.Total", "{0:#,##0.00}")});
         this.xrLabel17.Font = new System.Drawing.Font("Times New Roman", 8F);
         this.xrLabel17.LocationFloat = new DevExpress.Utils.PointFloat(976.7917F, 0F);
         this.xrLabel17.Name = "xrLabel17";
         this.xrLabel17.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel17.SizeF = new System.Drawing.SizeF(80.20831F, 17F);
         this.xrLabel17.StylePriority.UseFont = false;
         this.xrLabel17.StylePriority.UseTextAlignment = false;
         this.xrLabel17.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
         this.xrLabel17.WordWrap = false;
         // 
         // TopMargin
         // 
         this.TopMargin.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrPageInfo3});
         this.TopMargin.HeightF = 39F;
         this.TopMargin.Name = "TopMargin";
         this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
         this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
         // 
         // xrPageInfo3
         // 
         this.xrPageInfo3.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
         this.xrPageInfo3.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
         this.xrPageInfo3.Format = "Ημερομηνία Εκτύπωσης : {0:dddd, d MMMM yyyy h:mm:ss tt}";
         this.xrPageInfo3.LocationFloat = new DevExpress.Utils.PointFloat(6.000061F, 23.23729F);
         this.xrPageInfo3.Name = "xrPageInfo3";
         this.xrPageInfo3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrPageInfo3.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime;
         this.xrPageInfo3.SizeF = new System.Drawing.SizeF(1051F, 15.76271F);
         this.xrPageInfo3.StylePriority.UseBorders = false;
         this.xrPageInfo3.StylePriority.UseFont = false;
         // 
         // BottomMargin
         // 
         this.BottomMargin.HeightF = 36.45833F;
         this.BottomMargin.Name = "BottomMargin";
         this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
         this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
         // 
         // xrLabel29
         // 
         this.xrLabel29.BackColor = System.Drawing.Color.LightGray;
         this.xrLabel29.Borders = DevExpress.XtraPrinting.BorderSide.Top;
         this.xrLabel29.CanGrow = false;
         this.xrLabel29.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.Total")});
         this.xrLabel29.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold);
         this.xrLabel29.LocationFloat = new DevExpress.Utils.PointFloat(976.7917F, 0F);
         this.xrLabel29.Name = "xrLabel29";
         this.xrLabel29.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel29.SizeF = new System.Drawing.SizeF(80.20831F, 15F);
         this.xrLabel29.StylePriority.UseBackColor = false;
         this.xrLabel29.StylePriority.UseBorders = false;
         this.xrLabel29.StylePriority.UseFont = false;
         this.xrLabel29.StylePriority.UseTextAlignment = false;
         xrSummary2.FormatString = "{0:#,##0.00}";
         xrSummary2.Running = DevExpress.XtraReports.UI.SummaryRunning.Report;
         this.xrLabel29.Summary = xrSummary2;
         this.xrLabel29.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
         this.xrLabel29.WordWrap = false;
         // 
         // xrLabel28
         // 
         this.xrLabel28.BackColor = System.Drawing.Color.LightGray;
         this.xrLabel28.Borders = DevExpress.XtraPrinting.BorderSide.Top;
         this.xrLabel28.CanGrow = false;
         this.xrLabel28.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold);
         this.xrLabel28.LocationFloat = new DevExpress.Utils.PointFloat(6.000061F, 0F);
         this.xrLabel28.Name = "xrLabel28";
         this.xrLabel28.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel28.SizeF = new System.Drawing.SizeF(765.5833F, 15F);
         this.xrLabel28.StylePriority.UseBackColor = false;
         this.xrLabel28.StylePriority.UseBorders = false;
         this.xrLabel28.StylePriority.UseFont = false;
         this.xrLabel28.StylePriority.UseTextAlignment = false;
         this.xrLabel28.Text = "Γενικά Σύνολα";
         this.xrLabel28.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
         this.xrLabel28.WordWrap = false;
         // 
         // xrLabel14
         // 
         this.xrLabel14.BackColor = System.Drawing.Color.LightGray;
         this.xrLabel14.Borders = DevExpress.XtraPrinting.BorderSide.Top;
         this.xrLabel14.CanGrow = false;
         this.xrLabel14.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.Qty")});
         this.xrLabel14.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold);
         this.xrLabel14.LocationFloat = new DevExpress.Utils.PointFloat(771.5834F, 0F);
         this.xrLabel14.Name = "xrLabel14";
         this.xrLabel14.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel14.SizeF = new System.Drawing.SizeF(62.5F, 15F);
         this.xrLabel14.StylePriority.UseBackColor = false;
         this.xrLabel14.StylePriority.UseBorders = false;
         this.xrLabel14.StylePriority.UseFont = false;
         this.xrLabel14.StylePriority.UseTextAlignment = false;
         xrSummary3.FormatString = "{0:#.00}";
         xrSummary3.IgnoreNullValues = true;
         xrSummary3.Running = DevExpress.XtraReports.UI.SummaryRunning.Report;
         this.xrLabel14.Summary = xrSummary3;
         this.xrLabel14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
         this.xrLabel14.WordWrap = false;
         // 
         // ReportHeader
         // 
         this.ReportHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel31,
            this.xrLabel1});
         this.ReportHeader.HeightF = 26.33335F;
         this.ReportHeader.Name = "ReportHeader";
         // 
         // xrLabel31
         // 
         this.xrLabel31.Borders = DevExpress.XtraPrinting.BorderSide.None;
         this.xrLabel31.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding(this.dtTo, "Text", " έως {0})")});
         this.xrLabel31.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
         this.xrLabel31.LocationFloat = new DevExpress.Utils.PointFloat(621.25F, 3.000005F);
         this.xrLabel31.Name = "xrLabel31";
         this.xrLabel31.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel31.SizeF = new System.Drawing.SizeF(435.75F, 21.20834F);
         this.xrLabel31.StylePriority.UseBorders = false;
         this.xrLabel31.StylePriority.UseFont = false;
         this.xrLabel31.StylePriority.UseTextAlignment = false;
         this.xrLabel31.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
         // 
         // dtTo
         // 
         this.dtTo.Description = "To Date";
         this.dtTo.Name = "dtTo";
         this.dtTo.Type = typeof(System.DateTime);
         this.dtTo.ValueInfo = "2016-05-01";
         // 
         // xrLabel1
         // 
         this.xrLabel1.Borders = DevExpress.XtraPrinting.BorderSide.None;
         this.xrLabel1.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding(this.dtFrom, "Text", "Best Seller ανά Ποσότητα (από {0}")});
         this.xrLabel1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
         this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(6.000058F, 3.000005F);
         this.xrLabel1.Name = "xrLabel1";
         this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel1.SizeF = new System.Drawing.SizeF(615.2499F, 21.20834F);
         this.xrLabel1.StylePriority.UseBorders = false;
         this.xrLabel1.StylePriority.UseFont = false;
         this.xrLabel1.StylePriority.UseTextAlignment = false;
         this.xrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
         // 
         // dtFrom
         // 
         this.dtFrom.Description = "From Date";
         this.dtFrom.Name = "dtFrom";
         this.dtFrom.Type = typeof(System.DateTime);
         this.dtFrom.ValueInfo = "2016-05-01";
         // 
         // xrLabel9
         // 
         this.xrLabel9.BackColor = System.Drawing.Color.Silver;
         this.xrLabel9.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Bottom)));
         this.xrLabel9.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold);
         this.xrLabel9.LocationFloat = new DevExpress.Utils.PointFloat(914.2916F, 0F);
         this.xrLabel9.Name = "xrLabel9";
         this.xrLabel9.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel9.SizeF = new System.Drawing.SizeF(62.5F, 16F);
         this.xrLabel9.StylePriority.UseBackColor = false;
         this.xrLabel9.StylePriority.UseBorders = false;
         this.xrLabel9.StylePriority.UseFont = false;
         this.xrLabel9.StylePriority.UseTextAlignment = false;
         this.xrLabel9.Text = "ΦΠΑ";
         this.xrLabel9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
         // 
         // xrLabel8
         // 
         this.xrLabel8.BackColor = System.Drawing.Color.Silver;
         this.xrLabel8.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Bottom)));
         this.xrLabel8.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold);
         this.xrLabel8.LocationFloat = new DevExpress.Utils.PointFloat(834.0833F, 0F);
         this.xrLabel8.Name = "xrLabel8";
         this.xrLabel8.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel8.SizeF = new System.Drawing.SizeF(80.20831F, 16F);
         this.xrLabel8.StylePriority.UseBackColor = false;
         this.xrLabel8.StylePriority.UseBorders = false;
         this.xrLabel8.StylePriority.UseFont = false;
         this.xrLabel8.StylePriority.UseTextAlignment = false;
         this.xrLabel8.Text = "Καθαρά";
         this.xrLabel8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
         // 
         // xrLabel26
         // 
         this.xrLabel26.BackColor = System.Drawing.Color.Silver;
         this.xrLabel26.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Bottom)));
         this.xrLabel26.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold);
         this.xrLabel26.LocationFloat = new DevExpress.Utils.PointFloat(976.7916F, 0F);
         this.xrLabel26.Name = "xrLabel26";
         this.xrLabel26.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel26.SizeF = new System.Drawing.SizeF(80.20831F, 16F);
         this.xrLabel26.StylePriority.UseBackColor = false;
         this.xrLabel26.StylePriority.UseBorders = false;
         this.xrLabel26.StylePriority.UseFont = false;
         this.xrLabel26.StylePriority.UseTextAlignment = false;
         this.xrLabel26.Text = "Αξία";
         this.xrLabel26.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
         // 
         // xrLabel24
         // 
         this.xrLabel24.BackColor = System.Drawing.Color.Silver;
         this.xrLabel24.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Bottom)));
         this.xrLabel24.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold);
         this.xrLabel24.LocationFloat = new DevExpress.Utils.PointFloat(771.5833F, 0F);
         this.xrLabel24.Name = "xrLabel24";
         this.xrLabel24.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel24.SizeF = new System.Drawing.SizeF(62.5F, 16F);
         this.xrLabel24.StylePriority.UseBackColor = false;
         this.xrLabel24.StylePriority.UseBorders = false;
         this.xrLabel24.StylePriority.UseFont = false;
         this.xrLabel24.StylePriority.UseTextAlignment = false;
         this.xrLabel24.Text = "Ποσότητα";
         this.xrLabel24.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
         // 
         // xrLabel23
         // 
         this.xrLabel23.BackColor = System.Drawing.Color.Silver;
         this.xrLabel23.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Bottom)));
         this.xrLabel23.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold);
         this.xrLabel23.LocationFloat = new DevExpress.Utils.PointFloat(430.0998F, 0F);
         this.xrLabel23.Name = "xrLabel23";
         this.xrLabel23.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel23.SizeF = new System.Drawing.SizeF(341.4835F, 16F);
         this.xrLabel23.StylePriority.UseBackColor = false;
         this.xrLabel23.StylePriority.UseBorders = false;
         this.xrLabel23.StylePriority.UseFont = false;
         this.xrLabel23.Text = "Περιγραφή Είδους";
         // 
         // xrLabel22
         // 
         this.xrLabel22.BackColor = System.Drawing.Color.Silver;
         this.xrLabel22.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Bottom)));
         this.xrLabel22.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold);
         this.xrLabel22.LocationFloat = new DevExpress.Utils.PointFloat(326.9749F, 0F);
         this.xrLabel22.Name = "xrLabel22";
         this.xrLabel22.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel22.SizeF = new System.Drawing.SizeF(103.125F, 16F);
         this.xrLabel22.StylePriority.UseBackColor = false;
         this.xrLabel22.StylePriority.UseBorders = false;
         this.xrLabel22.StylePriority.UseFont = false;
         this.xrLabel22.Text = "Κωδικός Είδους";
         // 
         // xrLabel21
         // 
         this.xrLabel21.BackColor = System.Drawing.Color.Silver;
         this.xrLabel21.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Bottom)));
         this.xrLabel21.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold);
         this.xrLabel21.LocationFloat = new DevExpress.Utils.PointFloat(109.9999F, 0F);
         this.xrLabel21.Name = "xrLabel21";
         this.xrLabel21.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel21.SizeF = new System.Drawing.SizeF(216.9749F, 16F);
         this.xrLabel21.StylePriority.UseBackColor = false;
         this.xrLabel21.StylePriority.UseBorders = false;
         this.xrLabel21.StylePriority.UseFont = false;
         this.xrLabel21.Text = "Κατηγορία Είδους";
         // 
         // xrLabel20
         // 
         this.xrLabel20.BackColor = System.Drawing.Color.Silver;
         this.xrLabel20.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Bottom)));
         this.xrLabel20.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold);
         this.xrLabel20.LocationFloat = new DevExpress.Utils.PointFloat(6F, 0F);
         this.xrLabel20.Name = "xrLabel20";
         this.xrLabel20.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel20.SizeF = new System.Drawing.SizeF(103.9999F, 16F);
         this.xrLabel20.StylePriority.UseBackColor = false;
         this.xrLabel20.StylePriority.UseBorders = false;
         this.xrLabel20.StylePriority.UseFont = false;
         this.xrLabel20.Text = "Κατηγορία";
         // 
         // ProductCategory
         // 
         this.ProductCategory.Description = "Product Category Code";
         dynamicListLookUpSettings1.DataAdapter = null;
         dynamicListLookUpSettings1.DataMember = "ProductCategories";
         dynamicListLookUpSettings1.DataSource = this.sqlDataSource1;
         dynamicListLookUpSettings1.DisplayMember = "Description";
         dynamicListLookUpSettings1.FilterString = null;
         dynamicListLookUpSettings1.ValueMember = "Code";
         this.ProductCategory.LookUpSettings = dynamicListLookUpSettings1;
         this.ProductCategory.MultiValue = true;
         this.ProductCategory.Name = "ProductCategory";
         // 
         // Categories
         // 
         this.Categories.Description = "Categories";
         dynamicListLookUpSettings2.DataAdapter = null;
         dynamicListLookUpSettings2.DataMember = "Categories";
         dynamicListLookUpSettings2.DataSource = this.sqlDataSource1;
         dynamicListLookUpSettings2.DisplayMember = "Description";
         dynamicListLookUpSettings2.FilterString = null;
         dynamicListLookUpSettings2.ValueMember = "Id";
         this.Categories.LookUpSettings = dynamicListLookUpSettings2;
         this.Categories.MultiValue = true;
         this.Categories.Name = "Categories";
         this.Categories.Type = typeof(long);
         // 
         // ReportFooter
         // 
         this.ReportFooter.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel12,
            this.xrLabel7,
            this.xrLabel14,
            this.xrLabel28,
            this.xrLabel29});
         this.ReportFooter.HeightF = 18.15936F;
         this.ReportFooter.Name = "ReportFooter";
         // 
         // xrLabel12
         // 
         this.xrLabel12.BackColor = System.Drawing.Color.LightGray;
         this.xrLabel12.Borders = DevExpress.XtraPrinting.BorderSide.Top;
         this.xrLabel12.CanGrow = false;
         this.xrLabel12.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.VatAmount")});
         this.xrLabel12.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold);
         this.xrLabel12.LocationFloat = new DevExpress.Utils.PointFloat(914.2917F, 0F);
         this.xrLabel12.Name = "xrLabel12";
         this.xrLabel12.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel12.SizeF = new System.Drawing.SizeF(62.5F, 15F);
         this.xrLabel12.StylePriority.UseBackColor = false;
         this.xrLabel12.StylePriority.UseBorders = false;
         this.xrLabel12.StylePriority.UseFont = false;
         this.xrLabel12.StylePriority.UseTextAlignment = false;
         xrSummary4.FormatString = "{0:#,##0.00}";
         xrSummary4.IgnoreNullValues = true;
         xrSummary4.Running = DevExpress.XtraReports.UI.SummaryRunning.Report;
         this.xrLabel12.Summary = xrSummary4;
         this.xrLabel12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
         this.xrLabel12.WordWrap = false;
         // 
         // xrLabel7
         // 
         this.xrLabel7.BackColor = System.Drawing.Color.LightGray;
         this.xrLabel7.Borders = DevExpress.XtraPrinting.BorderSide.Top;
         this.xrLabel7.CanGrow = false;
         this.xrLabel7.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.Net")});
         this.xrLabel7.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold);
         this.xrLabel7.LocationFloat = new DevExpress.Utils.PointFloat(834.0834F, 0F);
         this.xrLabel7.Name = "xrLabel7";
         this.xrLabel7.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel7.SizeF = new System.Drawing.SizeF(80.20831F, 15F);
         this.xrLabel7.StylePriority.UseBackColor = false;
         this.xrLabel7.StylePriority.UseBorders = false;
         this.xrLabel7.StylePriority.UseFont = false;
         this.xrLabel7.StylePriority.UseTextAlignment = false;
         xrSummary5.FormatString = "{0:#,##0.00}";
         xrSummary5.IgnoreNullValues = true;
         xrSummary5.Running = DevExpress.XtraReports.UI.SummaryRunning.Report;
         this.xrLabel7.Summary = xrSummary5;
         this.xrLabel7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
         this.xrLabel7.WordWrap = false;
         // 
         // PageFooter
         // 
         this.PageFooter.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrPageInfo1});
         this.PageFooter.HeightF = 20.83333F;
         this.PageFooter.Name = "PageFooter";
         // 
         // xrPageInfo1
         // 
         this.xrPageInfo1.Borders = DevExpress.XtraPrinting.BorderSide.Top;
         this.xrPageInfo1.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
         this.xrPageInfo1.Format = "Σελίδα {0} από {1}";
         this.xrPageInfo1.LocationFloat = new DevExpress.Utils.PointFloat(6F, 0F);
         this.xrPageInfo1.Name = "xrPageInfo1";
         this.xrPageInfo1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrPageInfo1.SizeF = new System.Drawing.SizeF(1051F, 18.76271F);
         this.xrPageInfo1.StylePriority.UseBorders = false;
         this.xrPageInfo1.StylePriority.UseFont = false;
         this.xrPageInfo1.StylePriority.UseTextAlignment = false;
         this.xrPageInfo1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
         // 
         // GroupHeader1
         // 
         this.GroupHeader1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel13,
            this.xrLabel15,
            this.xrLabel16,
            this.xrLabel18,
            this.xrLabel19,
            this.xrLabel25,
            this.xrLabel27,
            this.xrLabel30});
         this.GroupHeader1.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("ProductId", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
         this.GroupHeader1.HeightF = 17F;
         this.GroupHeader1.Name = "GroupHeader1";
         xrGroupSortingSummary1.Enabled = true;
         xrGroupSortingSummary1.FieldName = "Qty";
         xrGroupSortingSummary1.SortOrder = DevExpress.XtraReports.UI.XRColumnSortOrder.Descending;
         this.GroupHeader1.SortingSummary = xrGroupSortingSummary1;
         // 
         // xrLabel13
         // 
         this.xrLabel13.CanGrow = false;
         this.xrLabel13.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.Total")});
         this.xrLabel13.Font = new System.Drawing.Font("Times New Roman", 8F);
         this.xrLabel13.LocationFloat = new DevExpress.Utils.PointFloat(976.7917F, 0F);
         this.xrLabel13.Name = "xrLabel13";
         this.xrLabel13.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel13.SizeF = new System.Drawing.SizeF(80.20831F, 17F);
         this.xrLabel13.StylePriority.UseFont = false;
         this.xrLabel13.StylePriority.UseTextAlignment = false;
         xrSummary6.FormatString = "{0:#,##0.00}";
         xrSummary6.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
         this.xrLabel13.Summary = xrSummary6;
         this.xrLabel13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
         this.xrLabel13.WordWrap = false;
         // 
         // xrLabel15
         // 
         this.xrLabel15.CanGrow = false;
         this.xrLabel15.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.Qty")});
         this.xrLabel15.Font = new System.Drawing.Font("Times New Roman", 8F);
         this.xrLabel15.LocationFloat = new DevExpress.Utils.PointFloat(771.5834F, 0F);
         this.xrLabel15.Name = "xrLabel15";
         this.xrLabel15.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel15.SizeF = new System.Drawing.SizeF(62.5F, 17F);
         this.xrLabel15.StylePriority.UseFont = false;
         this.xrLabel15.StylePriority.UseTextAlignment = false;
         xrSummary7.FormatString = "{0:0.000}";
         xrSummary7.IgnoreNullValues = true;
         xrSummary7.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
         this.xrLabel15.Summary = xrSummary7;
         this.xrLabel15.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
         this.xrLabel15.WordWrap = false;
         // 
         // xrLabel16
         // 
         this.xrLabel16.CanGrow = false;
         this.xrLabel16.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.ProductDescription")});
         this.xrLabel16.Font = new System.Drawing.Font("Times New Roman", 8F);
         this.xrLabel16.LocationFloat = new DevExpress.Utils.PointFloat(430.0999F, 0F);
         this.xrLabel16.Name = "xrLabel16";
         this.xrLabel16.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel16.SizeF = new System.Drawing.SizeF(341.4835F, 17F);
         this.xrLabel16.StylePriority.UseFont = false;
         this.xrLabel16.Text = "xrLabel5";
         this.xrLabel16.WordWrap = false;
         // 
         // xrLabel18
         // 
         this.xrLabel18.CanGrow = false;
         this.xrLabel18.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.ProductCode")});
         this.xrLabel18.Font = new System.Drawing.Font("Times New Roman", 8F);
         this.xrLabel18.LocationFloat = new DevExpress.Utils.PointFloat(326.9749F, 0F);
         this.xrLabel18.Name = "xrLabel18";
         this.xrLabel18.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel18.SizeF = new System.Drawing.SizeF(103.125F, 17F);
         this.xrLabel18.StylePriority.UseFont = false;
         this.xrLabel18.Text = "xrLabel4";
         this.xrLabel18.WordWrap = false;
         // 
         // xrLabel19
         // 
         this.xrLabel19.CanGrow = false;
         this.xrLabel19.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.ProductCategoryDescrtiption")});
         this.xrLabel19.Font = new System.Drawing.Font("Times New Roman", 8F);
         this.xrLabel19.LocationFloat = new DevExpress.Utils.PointFloat(110F, 0F);
         this.xrLabel19.Name = "xrLabel19";
         this.xrLabel19.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel19.SizeF = new System.Drawing.SizeF(216.9749F, 17F);
         this.xrLabel19.StylePriority.UseFont = false;
         this.xrLabel19.WordWrap = false;
         // 
         // xrLabel25
         // 
         this.xrLabel25.CanGrow = false;
         this.xrLabel25.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.CategoryDescription")});
         this.xrLabel25.Font = new System.Drawing.Font("Times New Roman", 8F);
         this.xrLabel25.LocationFloat = new DevExpress.Utils.PointFloat(6.000061F, 0F);
         this.xrLabel25.Name = "xrLabel25";
         this.xrLabel25.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel25.SizeF = new System.Drawing.SizeF(103.9999F, 17F);
         this.xrLabel25.StylePriority.UseFont = false;
         this.xrLabel25.Text = "xrLabel2";
         this.xrLabel25.WordWrap = false;
         // 
         // xrLabel27
         // 
         this.xrLabel27.CanGrow = false;
         this.xrLabel27.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.Net")});
         this.xrLabel27.LocationFloat = new DevExpress.Utils.PointFloat(834.0834F, 0F);
         this.xrLabel27.Name = "xrLabel27";
         this.xrLabel27.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel27.SizeF = new System.Drawing.SizeF(80.20831F, 17F);
         this.xrLabel27.StylePriority.UseTextAlignment = false;
         xrSummary8.FormatString = "{0:#,##0.00}";
         xrSummary8.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
         this.xrLabel27.Summary = xrSummary8;
         this.xrLabel27.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
         this.xrLabel27.WordWrap = false;
         // 
         // xrLabel30
         // 
         this.xrLabel30.CanGrow = false;
         this.xrLabel30.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.VatAmount")});
         this.xrLabel30.LocationFloat = new DevExpress.Utils.PointFloat(914.2917F, 0F);
         this.xrLabel30.Name = "xrLabel30";
         this.xrLabel30.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel30.SizeF = new System.Drawing.SizeF(62.5F, 17F);
         this.xrLabel30.StylePriority.UseTextAlignment = false;
         xrSummary9.FormatString = "{0:#,##0.00}";
         xrSummary9.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
         this.xrLabel30.Summary = xrSummary9;
         this.xrLabel30.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
         this.xrLabel30.WordWrap = false;
         // 
         // InvoiceType
         // 
         this.InvoiceType.Description = "Select Invoice Type";
         dynamicListLookUpSettings3.DataAdapter = null;
         dynamicListLookUpSettings3.DataMember = "InvoiceTypes";
         dynamicListLookUpSettings3.DataSource = this.sqlDataSource1;
         dynamicListLookUpSettings3.DisplayMember = "Abbreviation";
         dynamicListLookUpSettings3.FilterString = null;
         dynamicListLookUpSettings3.ValueMember = "Type";
         this.InvoiceType.LookUpSettings = dynamicListLookUpSettings3;
         this.InvoiceType.MultiValue = true;
         this.InvoiceType.Name = "InvoiceType";
         this.InvoiceType.Type = typeof(short);
         // 
         // PosInfoId
         // 
         this.PosInfoId.Description = "Select POS";
         dynamicListLookUpSettings4.DataAdapter = null;
         dynamicListLookUpSettings4.DataMember = "PosInfos";
         dynamicListLookUpSettings4.DataSource = this.sqlDataSource1;
         dynamicListLookUpSettings4.DisplayMember = "Description";
         dynamicListLookUpSettings4.FilterString = null;
         dynamicListLookUpSettings4.ValueMember = "Id";
         this.PosInfoId.LookUpSettings = dynamicListLookUpSettings4;
         this.PosInfoId.MultiValue = true;
         this.PosInfoId.Name = "PosInfoId";
         this.PosInfoId.Type = typeof(long);
         // 
         // DepartmentId
         // 
         this.DepartmentId.Description = "Select Department";
         dynamicListLookUpSettings5.DataAdapter = null;
         dynamicListLookUpSettings5.DataMember = "Departments";
         dynamicListLookUpSettings5.DataSource = this.sqlDataSource1;
         dynamicListLookUpSettings5.DisplayMember = "Description";
         dynamicListLookUpSettings5.ValueMember = "Id";
         this.DepartmentId.LookUpSettings = dynamicListLookUpSettings5;
         this.DepartmentId.MultiValue = true;
         this.DepartmentId.Name = "DepartmentId";
         this.DepartmentId.Type = typeof(long);
         // 
         // PageHeader
         // 
         this.PageHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel20,
            this.xrLabel21,
            this.xrLabel22,
            this.xrLabel23,
            this.xrLabel24,
            this.xrLabel26,
            this.xrLabel8,
            this.xrLabel9});
         this.PageHeader.HeightF = 16F;
         this.PageHeader.Name = "PageHeader";
         // 
         // BestSellerQtyOldDB
         // 
         this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.ReportHeader,
            this.ReportFooter,
            this.PageFooter,
            this.GroupHeader1,
            this.PageHeader});
         this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.sqlDataSource1});
         this.DataMember = "Query_FastStart";
         this.DataSource = this.sqlDataSource1;
         this.FilterString = resources.GetString("$this.FilterString");
         this.Landscape = true;
         this.Margins = new System.Drawing.Printing.Margins(49, 57, 39, 36);
         this.PageHeight = 827;
         this.PageWidth = 1169;
         this.PaperKind = System.Drawing.Printing.PaperKind.A4;
         this.Parameters.AddRange(new DevExpress.XtraReports.Parameters.Parameter[] {
            this.dtFrom,
            this.dtTo,
            this.DepartmentId,
            this.PosInfoId,
            this.ProductCategory,
            this.Categories,
            this.InvoiceType});
         this.Version = "15.2";
         this.ParametersRequestBeforeShow += new System.EventHandler<DevExpress.XtraReports.Parameters.ParametersRequestEventArgs>(this.BestSellerQtyOldDB_ParametersRequestBeforeShow);
         this.DataSourceDemanded += new System.EventHandler<System.EventArgs>(this.BestSellerQtyOldDB_DataSourceDemanded);
         ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

      }

   #endregion

   ////////////////////////////////////////////////////////////////////////////////////////////////
   /// <summary>
   /// 
   /// </summary>
   /// <param name="sender"></param>
   /// <param name="e"></param>
   private void BestSellerQtyOldDB_ParametersRequestBeforeShow( object sender, DevExpress.XtraReports.Parameters.ParametersRequestEventArgs e )
      {
      sqlDataSource1.Fill();

      foreach ( var paramItem in e.ParametersInformation )
         {

         if ( "DateTime" == paramItem.Parameter.Type.Name )
            {
            paramItem.Parameter.Value = DateTime.Now.Date;
            }
         else if ( paramItem.Parameter.MultiValue )
            {

            switch ( paramItem.Parameter.Name )
               {
               case "DepartmentId":
                  // select all values for parameter DepartmentId
                  paramItem.Parameter.Value = CommonTools.SetAllSelectedForMultiValueParameter<Int64>( sqlDataSource1, "Departments", "Id" );
                  break;

               case "PosInfoId":
                  // select all values for parameter PosInfoId
                  paramItem.Parameter.Value = CommonTools.SetAllSelectedForMultiValueParameter<Int64>( sqlDataSource1, "PosInfos", "Id" );
                  break;

               case "ProductCategory":
                  // select all values for parameter ProductCategory
                  paramItem.Parameter.Value = CommonTools.SetAllSelectedForMultiValueParameter( sqlDataSource1, "ProductCategories", "Code" );
                  break;

               case "Categories":
                  // select all values for parameter Categories
                  paramItem.Parameter.Value = CommonTools.SetAllSelectedForMultiValueParameter<Int64>( sqlDataSource1, "Categories", "Id" );
                  break;

               case "InvoiceType":
                  // select all values for parameter InvoiceType
                  paramItem.Parameter.Value = CommonTools.SetAllSelectedForMultiValueParameter<Int16>( sqlDataSource1, "InvoiceTypes", "Type" );
                  break;

               default:
                  break;
               }

            }

         }

      }

   ////////////////////////////////////////////////////////////////////////////////////////////////
   /// <summary>
   /// 
   /// </summary>
   /// <param name="sender"></param>
   /// <param name="e"></param>
   private void BestSellerQtyOldDB_DataSourceDemanded( object sender, EventArgs e )
      {
      this.DataSource = sqlDataSource1;
      this.DataMember = "Query";
      this.sqlDataSource1.RebuildResultSchema();

      /*/

      int? dbVersion = Convert.ToInt32( WebConfigurationManager.AppSettings["DBVersion"] );

      if ( dbVersion != null && dbVersion == 1 )
         {
         //this.DataMember = "QueryV1";
         this.DataSource = sqlDataSource2;
         this.DataMember = "Query";
         this.sqlDataSource2.RebuildResultSchema();
         }
      else
         {
         //this.DataMember = "Query";
         this.DataSource = sqlDataSource1;
         this.DataMember = "Query";
         this.sqlDataSource1.RebuildResultSchema();
         }

      //*/
      }

   ////////////////////////////////////////////////////////////////////////////////////////////////
   }

