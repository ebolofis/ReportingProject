
using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Web.Configuration;

/// <summary>
/// Summary description for SalesCostOldDB
/// </summary>
public class SalesCostOldDB : DevExpress.XtraReports.UI.XtraReport
   {
   private DevExpress.XtraReports.UI.DetailBand Detail;
   private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
   private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
   private XRLabel xrLabel24;
   private XRLabel xrLabel27;
   private XRLabel xrLabel29;
   private XRLabel xrLabel31;
   private XRLabel xrLabel32;
   private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
   private PageHeaderBand pageHeaderBand1;
   private XRLabel xrLabel7;
   private XRLabel xrLabel8;
   private XRLabel xrLabel9;
   private XRLabel xrLabel10;
   private XRLine xrLine1;
   private XRLine xrLine2;
   private GroupHeaderBand DepartmentDescriptionGroupHeader;
   private XRLabel xrLabel13;
   private GroupFooterBand groupFooterBand1;
   private XRLabel xrLabel14;
   private XRLabel xrLabel15;
   private XRLabel xrLabel16;
   private XRLabel xrLabel17;
   private GroupHeaderBand CategoryGroupHeader;
   private XRLabel xrLabel18;
   private GroupFooterBand groupFooterBand2;
   private XRLabel xrLabel19;
   private XRLabel xrLabel20;
   private XRLabel xrLabel21;
   private XRLabel xrLabel22;
   private PageFooterBand pageFooterBand1;
   private ReportHeaderBand reportHeaderBand1;
   private XRLabel xrLabel33;
   private ReportFooterBand reportFooterBand1;
   private XRLabel xrLabel34;
   private XRLabel xrLabel35;
   private XRLabel xrLabel36;
   private XRLabel xrLabel37;
   private XRControlStyle Title;
   private XRControlStyle FieldCaption;
   private XRControlStyle PageInfo;
   private XRControlStyle DataField;
   private DevExpress.XtraReports.Parameters.Parameter dtFrom;
   private DevExpress.XtraReports.Parameters.Parameter dtTo;
   private DevExpress.XtraReports.Parameters.Parameter CostPriceList;
   private XRLabel xrLabel1;
   private XRLabel xrLabel3;
   private XRLabel xrLabel2;
   private XRLine xrLine5;
   private XRLine xrLine4;
   private XRLine xrLine6;
   private DevExpress.XtraReports.Parameters.Parameter Depart;
   private DevExpress.XtraReports.Parameters.Parameter Category;
   private DevExpress.XtraReports.Parameters.Parameter PriceLists;
   private XRPageInfo xrPageInfo3;
   private XRPageInfo xrPageInfo1;
   private XRControlStyle xrControlStyle1;
   private XRLabel xrLabel4;

   /// <summary>
   /// Required designer variable.
   /// </summary>
   private System.ComponentModel.IContainer components = null;

   public SalesCostOldDB()
      {
      InitializeComponent();
      //
      // TODO: Add constructor logic here
      //
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
         DevExpress.DataAccess.Sql.QueryParameter queryParameter3 = new DevExpress.DataAccess.Sql.QueryParameter();
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalesCostOldDB));
         DevExpress.DataAccess.Sql.CustomSqlQuery customSqlQuery2 = new DevExpress.DataAccess.Sql.CustomSqlQuery();
         DevExpress.DataAccess.Sql.CustomSqlQuery customSqlQuery3 = new DevExpress.DataAccess.Sql.CustomSqlQuery();
         DevExpress.DataAccess.Sql.CustomSqlQuery customSqlQuery4 = new DevExpress.DataAccess.Sql.CustomSqlQuery();
         DevExpress.DataAccess.Sql.CustomSqlQuery customSqlQuery5 = new DevExpress.DataAccess.Sql.CustomSqlQuery();
         DevExpress.XtraReports.UI.XRSummary xrSummary1 = new DevExpress.XtraReports.UI.XRSummary();
         DevExpress.XtraReports.UI.XRSummary xrSummary2 = new DevExpress.XtraReports.UI.XRSummary();
         DevExpress.XtraReports.UI.XRSummary xrSummary3 = new DevExpress.XtraReports.UI.XRSummary();
         DevExpress.XtraReports.UI.XRSummary xrSummary4 = new DevExpress.XtraReports.UI.XRSummary();
         DevExpress.XtraReports.UI.XRSummary xrSummary5 = new DevExpress.XtraReports.UI.XRSummary();
         DevExpress.XtraReports.UI.XRSummary xrSummary6 = new DevExpress.XtraReports.UI.XRSummary();
         DevExpress.XtraReports.UI.XRSummary xrSummary7 = new DevExpress.XtraReports.UI.XRSummary();
         DevExpress.XtraReports.UI.XRSummary xrSummary8 = new DevExpress.XtraReports.UI.XRSummary();
         DevExpress.XtraReports.UI.XRSummary xrSummary9 = new DevExpress.XtraReports.UI.XRSummary();
         DevExpress.XtraReports.Parameters.DynamicListLookUpSettings dynamicListLookUpSettings1 = new DevExpress.XtraReports.Parameters.DynamicListLookUpSettings();
         DevExpress.XtraReports.Parameters.DynamicListLookUpSettings dynamicListLookUpSettings2 = new DevExpress.XtraReports.Parameters.DynamicListLookUpSettings();
         DevExpress.XtraReports.Parameters.DynamicListLookUpSettings dynamicListLookUpSettings3 = new DevExpress.XtraReports.Parameters.DynamicListLookUpSettings();
         DevExpress.XtraReports.Parameters.DynamicListLookUpSettings dynamicListLookUpSettings4 = new DevExpress.XtraReports.Parameters.DynamicListLookUpSettings();
         this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
         this.Detail = new DevExpress.XtraReports.UI.DetailBand();
         this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel24 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel27 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel29 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel31 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel32 = new DevExpress.XtraReports.UI.XRLabel();
         this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
         this.xrPageInfo3 = new DevExpress.XtraReports.UI.XRPageInfo();
         this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
         this.pageHeaderBand1 = new DevExpress.XtraReports.UI.PageHeaderBand();
         this.xrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel7 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel8 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel9 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel10 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLine1 = new DevExpress.XtraReports.UI.XRLine();
         this.xrLine2 = new DevExpress.XtraReports.UI.XRLine();
         this.DepartmentDescriptionGroupHeader = new DevExpress.XtraReports.UI.GroupHeaderBand();
         this.xrLabel13 = new DevExpress.XtraReports.UI.XRLabel();
         this.groupFooterBand1 = new DevExpress.XtraReports.UI.GroupFooterBand();
         this.xrLabel14 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel15 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel16 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel17 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLine5 = new DevExpress.XtraReports.UI.XRLine();
         this.CategoryGroupHeader = new DevExpress.XtraReports.UI.GroupHeaderBand();
         this.xrLabel18 = new DevExpress.XtraReports.UI.XRLabel();
         this.groupFooterBand2 = new DevExpress.XtraReports.UI.GroupFooterBand();
         this.xrLine4 = new DevExpress.XtraReports.UI.XRLine();
         this.xrLabel19 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel20 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel21 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel22 = new DevExpress.XtraReports.UI.XRLabel();
         this.pageFooterBand1 = new DevExpress.XtraReports.UI.PageFooterBand();
         this.xrPageInfo1 = new DevExpress.XtraReports.UI.XRPageInfo();
         this.reportHeaderBand1 = new DevExpress.XtraReports.UI.ReportHeaderBand();
         this.xrLabel33 = new DevExpress.XtraReports.UI.XRLabel();
         this.reportFooterBand1 = new DevExpress.XtraReports.UI.ReportFooterBand();
         this.xrLabel34 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel35 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel36 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel37 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLine6 = new DevExpress.XtraReports.UI.XRLine();
         this.Title = new DevExpress.XtraReports.UI.XRControlStyle();
         this.FieldCaption = new DevExpress.XtraReports.UI.XRControlStyle();
         this.PageInfo = new DevExpress.XtraReports.UI.XRControlStyle();
         this.DataField = new DevExpress.XtraReports.UI.XRControlStyle();
         this.dtFrom = new DevExpress.XtraReports.Parameters.Parameter();
         this.dtTo = new DevExpress.XtraReports.Parameters.Parameter();
         this.CostPriceList = new DevExpress.XtraReports.Parameters.Parameter();
         this.Depart = new DevExpress.XtraReports.Parameters.Parameter();
         this.Category = new DevExpress.XtraReports.Parameters.Parameter();
         this.PriceLists = new DevExpress.XtraReports.Parameters.Parameter();
         this.xrControlStyle1 = new DevExpress.XtraReports.UI.XRControlStyle();
         this.xrLabel4 = new DevExpress.XtraReports.UI.XRLabel();
         ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
         // 
         // sqlDataSource1
         // 
         this.sqlDataSource1.ConnectionName = "ReportConnection";
         this.sqlDataSource1.Name = "sqlDataSource1";
         customSqlQuery1.Name = "Query";
         queryParameter1.Name = "SelPlID";
         queryParameter1.Type = typeof(DevExpress.DataAccess.Expression);
         queryParameter1.Value = new DevExpress.DataAccess.Expression("[Parameters.CostPriceList]", typeof(long));
         queryParameter2.Name = "FromDate";
         queryParameter2.Type = typeof(DevExpress.DataAccess.Expression);
         queryParameter2.Value = new DevExpress.DataAccess.Expression("[Parameters.dtFrom]", typeof(System.DateTime));
         queryParameter3.Name = "ToDate";
         queryParameter3.Type = typeof(DevExpress.DataAccess.Expression);
         queryParameter3.Value = new DevExpress.DataAccess.Expression("[Parameters.dtTo]", typeof(System.DateTime));
         customSqlQuery1.Parameters.Add(queryParameter1);
         customSqlQuery1.Parameters.Add(queryParameter2);
         customSqlQuery1.Parameters.Add(queryParameter3);
         customSqlQuery1.Sql = resources.GetString("customSqlQuery1.Sql");
         customSqlQuery2.Name = "PriceListLookUp";
         customSqlQuery2.Sql = "SELECT p.Id, p.[Description] [Description] \r\nFROM Pricelist p \r\nORDER BY [Descrip" +
    "tion]";
         customSqlQuery3.Name = "DepartmentLookUp";
         customSqlQuery3.Sql = "SELECT id, d.[Description] \r\nFROM Department d \r\nORDER BY d.[Description]";
         customSqlQuery4.Name = "CategoriesLookUp";
         customSqlQuery4.Sql = "SELECT c.Id, c.[Description] \r\nFROM Categories c \r\nORDER BY c.[Description]";
         customSqlQuery5.Name = "Query_FastStart";
         customSqlQuery5.Sql = "select * from invoices where id = -1";
         this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            customSqlQuery1,
            customSqlQuery2,
            customSqlQuery3,
            customSqlQuery4,
            customSqlQuery5});
         this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
         // 
         // Detail
         // 
         this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel1,
            this.xrLabel24,
            this.xrLabel27,
            this.xrLabel29,
            this.xrLabel31,
            this.xrLabel32});
         this.Detail.HeightF = 18F;
         this.Detail.Name = "Detail";
         this.Detail.OddStyleName = "xrControlStyle1";
         this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
         this.Detail.StyleName = "DataField";
         this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
         // 
         // xrLabel1
         // 
         this.xrLabel1.CanGrow = false;
         this.xrLabel1.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.CostPriceList")});
         this.xrLabel1.Font = new System.Drawing.Font("Times New Roman", 8F);
         this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(332.051F, 0F);
         this.xrLabel1.Name = "xrLabel1";
         this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel1.SizeF = new System.Drawing.SizeF(108.5514F, 18F);
         this.xrLabel1.StylePriority.UseFont = false;
         this.xrLabel1.Text = "xrLabel1";
         this.xrLabel1.WordWrap = false;
         // 
         // xrLabel24
         // 
         this.xrLabel24.CanGrow = false;
         this.xrLabel24.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.Cost", "{0:#,##0.00}")});
         this.xrLabel24.Font = new System.Drawing.Font("Times New Roman", 8F);
         this.xrLabel24.LocationFloat = new DevExpress.Utils.PointFloat(575.7264F, 0F);
         this.xrLabel24.Name = "xrLabel24";
         this.xrLabel24.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel24.SizeF = new System.Drawing.SizeF(74.27362F, 18F);
         this.xrLabel24.StylePriority.UseFont = false;
         this.xrLabel24.StylePriority.UseTextAlignment = false;
         this.xrLabel24.Text = "xrLabel24";
         this.xrLabel24.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
         this.xrLabel24.WordWrap = false;
         // 
         // xrLabel27
         // 
         this.xrLabel27.CanGrow = false;
         this.xrLabel27.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.ProductDescription")});
         this.xrLabel27.Font = new System.Drawing.Font("Times New Roman", 8F);
         this.xrLabel27.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
         this.xrLabel27.Name = "xrLabel27";
         this.xrLabel27.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel27.SizeF = new System.Drawing.SizeF(223.4996F, 18F);
         this.xrLabel27.StylePriority.UseFont = false;
         this.xrLabel27.WordWrap = false;
         // 
         // xrLabel29
         // 
         this.xrLabel29.CanGrow = false;
         this.xrLabel29.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.Qty", "{0:0.000}")});
         this.xrLabel29.Font = new System.Drawing.Font("Times New Roman", 8F);
         this.xrLabel29.LocationFloat = new DevExpress.Utils.PointFloat(440.6024F, 0F);
         this.xrLabel29.Name = "xrLabel29";
         this.xrLabel29.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel29.SizeF = new System.Drawing.SizeF(61.19666F, 18F);
         this.xrLabel29.StylePriority.UseFont = false;
         this.xrLabel29.StylePriority.UseTextAlignment = false;
         this.xrLabel29.Text = "xrLabel29";
         this.xrLabel29.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
         this.xrLabel29.WordWrap = false;
         // 
         // xrLabel31
         // 
         this.xrLabel31.CanGrow = false;
         this.xrLabel31.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.SalesPriceList")});
         this.xrLabel31.Font = new System.Drawing.Font("Times New Roman", 8F);
         this.xrLabel31.LocationFloat = new DevExpress.Utils.PointFloat(223.4996F, 0F);
         this.xrLabel31.Name = "xrLabel31";
         this.xrLabel31.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel31.SizeF = new System.Drawing.SizeF(108.5514F, 18F);
         this.xrLabel31.StylePriority.UseFont = false;
         this.xrLabel31.Text = "xrLabel31";
         this.xrLabel31.WordWrap = false;
         // 
         // xrLabel32
         // 
         this.xrLabel32.CanGrow = false;
         this.xrLabel32.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.Total", "{0:#,##0.00}")});
         this.xrLabel32.Font = new System.Drawing.Font("Times New Roman", 8F);
         this.xrLabel32.LocationFloat = new DevExpress.Utils.PointFloat(501.7992F, 0F);
         this.xrLabel32.Name = "xrLabel32";
         this.xrLabel32.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel32.SizeF = new System.Drawing.SizeF(73.92719F, 18F);
         this.xrLabel32.StylePriority.UseFont = false;
         this.xrLabel32.StylePriority.UseTextAlignment = false;
         this.xrLabel32.Text = "xrLabel32";
         this.xrLabel32.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
         this.xrLabel32.WordWrap = false;
         // 
         // TopMargin
         // 
         this.TopMargin.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrPageInfo3});
         this.TopMargin.HeightF = 57.58332F;
         this.TopMargin.Name = "TopMargin";
         this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
         this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
         // 
         // xrPageInfo3
         // 
         this.xrPageInfo3.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
         this.xrPageInfo3.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
         this.xrPageInfo3.Format = "Ημερομηνία Εκτύπωσης : {0:dddd, d MMMM yyyy h:mm:ss tt}";
         this.xrPageInfo3.LocationFloat = new DevExpress.Utils.PointFloat(0F, 38.82061F);
         this.xrPageInfo3.Name = "xrPageInfo3";
         this.xrPageInfo3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrPageInfo3.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime;
         this.xrPageInfo3.SizeF = new System.Drawing.SizeF(650F, 18.76271F);
         this.xrPageInfo3.StylePriority.UseBorders = false;
         this.xrPageInfo3.StylePriority.UseFont = false;
         // 
         // BottomMargin
         // 
         this.BottomMargin.HeightF = 35.75007F;
         this.BottomMargin.Name = "BottomMargin";
         this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
         this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
         // 
         // pageHeaderBand1
         // 
         this.pageHeaderBand1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel3,
            this.xrLabel2,
            this.xrLabel7,
            this.xrLabel8,
            this.xrLabel9,
            this.xrLabel10,
            this.xrLine1,
            this.xrLine2});
         this.pageHeaderBand1.HeightF = 21.25F;
         this.pageHeaderBand1.Name = "pageHeaderBand1";
         // 
         // xrLabel3
         // 
         this.xrLabel3.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
         this.xrLabel3.ForeColor = System.Drawing.Color.Black;
         this.xrLabel3.LocationFloat = new DevExpress.Utils.PointFloat(575.7264F, 2.000001F);
         this.xrLabel3.Name = "xrLabel3";
         this.xrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel3.SizeF = new System.Drawing.SizeF(74.27362F, 17.24999F);
         this.xrLabel3.StyleName = "FieldCaption";
         this.xrLabel3.StylePriority.UseFont = false;
         this.xrLabel3.StylePriority.UseForeColor = false;
         this.xrLabel3.StylePriority.UseTextAlignment = false;
         this.xrLabel3.Text = "Κόστος";
         this.xrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
         // 
         // xrLabel2
         // 
         this.xrLabel2.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
         this.xrLabel2.ForeColor = System.Drawing.Color.Black;
         this.xrLabel2.LocationFloat = new DevExpress.Utils.PointFloat(332.051F, 2.000001F);
         this.xrLabel2.Name = "xrLabel2";
         this.xrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel2.SizeF = new System.Drawing.SizeF(108.5514F, 17.24999F);
         this.xrLabel2.StyleName = "FieldCaption";
         this.xrLabel2.StylePriority.UseFont = false;
         this.xrLabel2.StylePriority.UseForeColor = false;
         this.xrLabel2.Text = "Τιμοκατάλογος Κόστους";
         // 
         // xrLabel7
         // 
         this.xrLabel7.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
         this.xrLabel7.ForeColor = System.Drawing.Color.Black;
         this.xrLabel7.LocationFloat = new DevExpress.Utils.PointFloat(0F, 2.000001F);
         this.xrLabel7.Name = "xrLabel7";
         this.xrLabel7.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel7.SizeF = new System.Drawing.SizeF(223.4996F, 17.25F);
         this.xrLabel7.StyleName = "FieldCaption";
         this.xrLabel7.StylePriority.UseFont = false;
         this.xrLabel7.StylePriority.UseForeColor = false;
         this.xrLabel7.Text = "Προϊόν";
         // 
         // xrLabel8
         // 
         this.xrLabel8.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
         this.xrLabel8.ForeColor = System.Drawing.Color.Black;
         this.xrLabel8.LocationFloat = new DevExpress.Utils.PointFloat(223.4996F, 2.000001F);
         this.xrLabel8.Name = "xrLabel8";
         this.xrLabel8.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel8.SizeF = new System.Drawing.SizeF(108.5514F, 17.24999F);
         this.xrLabel8.StyleName = "FieldCaption";
         this.xrLabel8.StylePriority.UseFont = false;
         this.xrLabel8.StylePriority.UseForeColor = false;
         this.xrLabel8.Text = "Τιμοκατάλογος Πώλησης";
         // 
         // xrLabel9
         // 
         this.xrLabel9.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
         this.xrLabel9.ForeColor = System.Drawing.Color.Black;
         this.xrLabel9.LocationFloat = new DevExpress.Utils.PointFloat(440.6024F, 2.000001F);
         this.xrLabel9.Name = "xrLabel9";
         this.xrLabel9.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel9.SizeF = new System.Drawing.SizeF(61.19672F, 17.24999F);
         this.xrLabel9.StyleName = "FieldCaption";
         this.xrLabel9.StylePriority.UseFont = false;
         this.xrLabel9.StylePriority.UseForeColor = false;
         this.xrLabel9.StylePriority.UseTextAlignment = false;
         this.xrLabel9.Text = "Ποσ.";
         this.xrLabel9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
         // 
         // xrLabel10
         // 
         this.xrLabel10.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
         this.xrLabel10.ForeColor = System.Drawing.Color.Black;
         this.xrLabel10.LocationFloat = new DevExpress.Utils.PointFloat(501.7991F, 2.000001F);
         this.xrLabel10.Name = "xrLabel10";
         this.xrLabel10.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel10.SizeF = new System.Drawing.SizeF(73.92719F, 17.24999F);
         this.xrLabel10.StyleName = "FieldCaption";
         this.xrLabel10.StylePriority.UseFont = false;
         this.xrLabel10.StylePriority.UseForeColor = false;
         this.xrLabel10.StylePriority.UseTextAlignment = false;
         this.xrLabel10.Text = "Σύνολο";
         this.xrLabel10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
         // 
         // xrLine1
         // 
         this.xrLine1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
         this.xrLine1.Name = "xrLine1";
         this.xrLine1.SizeF = new System.Drawing.SizeF(649.9999F, 2F);
         // 
         // xrLine2
         // 
         this.xrLine2.LocationFloat = new DevExpress.Utils.PointFloat(0F, 19.25F);
         this.xrLine2.Name = "xrLine2";
         this.xrLine2.SizeF = new System.Drawing.SizeF(649.9999F, 2F);
         // 
         // DepartmentDescriptionGroupHeader
         // 
         this.DepartmentDescriptionGroupHeader.BorderColor = System.Drawing.Color.Black;
         this.DepartmentDescriptionGroupHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel13});
         this.DepartmentDescriptionGroupHeader.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("DepartmentDescription", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
         this.DepartmentDescriptionGroupHeader.HeightF = 18F;
         this.DepartmentDescriptionGroupHeader.KeepTogether = true;
         this.DepartmentDescriptionGroupHeader.Level = 1;
         this.DepartmentDescriptionGroupHeader.Name = "DepartmentDescriptionGroupHeader";
         this.DepartmentDescriptionGroupHeader.StyleName = "DataField";
         this.DepartmentDescriptionGroupHeader.StylePriority.UseBackColor = false;
         this.DepartmentDescriptionGroupHeader.StylePriority.UseBorderColor = false;
         // 
         // xrLabel13
         // 
         this.xrLabel13.BackColor = System.Drawing.Color.Gray;
         this.xrLabel13.Borders = DevExpress.XtraPrinting.BorderSide.None;
         this.xrLabel13.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.DepartmentDescription", "Τμήμα: {0}")});
         this.xrLabel13.ForeColor = System.Drawing.Color.Black;
         this.xrLabel13.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
         this.xrLabel13.Name = "xrLabel13";
         this.xrLabel13.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel13.SizeF = new System.Drawing.SizeF(649.9999F, 18F);
         this.xrLabel13.StylePriority.UseBackColor = false;
         this.xrLabel13.StylePriority.UseBorders = false;
         this.xrLabel13.StylePriority.UseForeColor = false;
         this.xrLabel13.StylePriority.UseTextAlignment = false;
         this.xrLabel13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
         // 
         // groupFooterBand1
         // 
         this.groupFooterBand1.BackColor = System.Drawing.Color.Gray;
         this.groupFooterBand1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel14,
            this.xrLabel15,
            this.xrLabel16,
            this.xrLabel17,
            this.xrLine5});
         this.groupFooterBand1.HeightF = 22.70832F;
         this.groupFooterBand1.KeepTogether = true;
         this.groupFooterBand1.Level = 1;
         this.groupFooterBand1.Name = "groupFooterBand1";
         this.groupFooterBand1.StylePriority.UseBackColor = false;
         // 
         // xrLabel14
         // 
         this.xrLabel14.BackColor = System.Drawing.Color.Transparent;
         this.xrLabel14.CanGrow = false;
         this.xrLabel14.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.Cost")});
         this.xrLabel14.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
         this.xrLabel14.ForeColor = System.Drawing.Color.Black;
         this.xrLabel14.LocationFloat = new DevExpress.Utils.PointFloat(575.7264F, 2F);
         this.xrLabel14.Name = "xrLabel14";
         this.xrLabel14.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel14.SizeF = new System.Drawing.SizeF(74.27362F, 18F);
         this.xrLabel14.StyleName = "FieldCaption";
         this.xrLabel14.StylePriority.UseBackColor = false;
         this.xrLabel14.StylePriority.UseFont = false;
         this.xrLabel14.StylePriority.UseForeColor = false;
         this.xrLabel14.StylePriority.UseTextAlignment = false;
         xrSummary1.FormatString = "{0:#,##0.00}";
         xrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
         this.xrLabel14.Summary = xrSummary1;
         this.xrLabel14.Text = "xrLabel14";
         this.xrLabel14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
         this.xrLabel14.WordWrap = false;
         // 
         // xrLabel15
         // 
         this.xrLabel15.BackColor = System.Drawing.Color.Transparent;
         this.xrLabel15.CanGrow = false;
         this.xrLabel15.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.Qty")});
         this.xrLabel15.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
         this.xrLabel15.ForeColor = System.Drawing.Color.Black;
         this.xrLabel15.LocationFloat = new DevExpress.Utils.PointFloat(440.6024F, 2F);
         this.xrLabel15.Name = "xrLabel15";
         this.xrLabel15.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel15.SizeF = new System.Drawing.SizeF(61.19672F, 18F);
         this.xrLabel15.StyleName = "FieldCaption";
         this.xrLabel15.StylePriority.UseBackColor = false;
         this.xrLabel15.StylePriority.UseFont = false;
         this.xrLabel15.StylePriority.UseForeColor = false;
         this.xrLabel15.StylePriority.UseTextAlignment = false;
         xrSummary2.FormatString = "{0:0.000}";
         xrSummary2.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
         this.xrLabel15.Summary = xrSummary2;
         this.xrLabel15.Text = "xrLabel15";
         this.xrLabel15.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
         this.xrLabel15.WordWrap = false;
         // 
         // xrLabel16
         // 
         this.xrLabel16.BackColor = System.Drawing.Color.Transparent;
         this.xrLabel16.CanGrow = false;
         this.xrLabel16.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.Total", "{0:C2}")});
         this.xrLabel16.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
         this.xrLabel16.ForeColor = System.Drawing.Color.Black;
         this.xrLabel16.LocationFloat = new DevExpress.Utils.PointFloat(501.7991F, 2F);
         this.xrLabel16.Name = "xrLabel16";
         this.xrLabel16.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel16.SizeF = new System.Drawing.SizeF(73.92725F, 18F);
         this.xrLabel16.StyleName = "FieldCaption";
         this.xrLabel16.StylePriority.UseBackColor = false;
         this.xrLabel16.StylePriority.UseFont = false;
         this.xrLabel16.StylePriority.UseForeColor = false;
         this.xrLabel16.StylePriority.UseTextAlignment = false;
         xrSummary3.FormatString = "{0:#,##0.00}";
         xrSummary3.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
         this.xrLabel16.Summary = xrSummary3;
         this.xrLabel16.Text = "xrLabel16";
         this.xrLabel16.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
         this.xrLabel16.WordWrap = false;
         // 
         // xrLabel17
         // 
         this.xrLabel17.BackColor = System.Drawing.Color.Transparent;
         this.xrLabel17.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
         this.xrLabel17.ForeColor = System.Drawing.Color.Black;
         this.xrLabel17.LocationFloat = new DevExpress.Utils.PointFloat(0F, 2F);
         this.xrLabel17.Name = "xrLabel17";
         this.xrLabel17.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel17.SizeF = new System.Drawing.SizeF(440.6024F, 18F);
         this.xrLabel17.StyleName = "FieldCaption";
         this.xrLabel17.StylePriority.UseBackColor = false;
         this.xrLabel17.StylePriority.UseFont = false;
         this.xrLabel17.StylePriority.UseForeColor = false;
         this.xrLabel17.Text = "Σύνολα Τμήματος";
         // 
         // xrLine5
         // 
         this.xrLine5.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
         this.xrLine5.Name = "xrLine5";
         this.xrLine5.SizeF = new System.Drawing.SizeF(650F, 2F);
         // 
         // CategoryGroupHeader
         // 
         this.CategoryGroupHeader.BorderColor = System.Drawing.Color.Black;
         this.CategoryGroupHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel18});
         this.CategoryGroupHeader.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("Category", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
         this.CategoryGroupHeader.HeightF = 18F;
         this.CategoryGroupHeader.KeepTogether = true;
         this.CategoryGroupHeader.Name = "CategoryGroupHeader";
         this.CategoryGroupHeader.StyleName = "DataField";
         this.CategoryGroupHeader.StylePriority.UseBorderColor = false;
         // 
         // xrLabel18
         // 
         this.xrLabel18.BackColor = System.Drawing.Color.DarkGray;
         this.xrLabel18.Borders = DevExpress.XtraPrinting.BorderSide.None;
         this.xrLabel18.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.Category", "Κατηγορία: {0}")});
         this.xrLabel18.ForeColor = System.Drawing.Color.Black;
         this.xrLabel18.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
         this.xrLabel18.Name = "xrLabel18";
         this.xrLabel18.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel18.SizeF = new System.Drawing.SizeF(649.9999F, 18F);
         this.xrLabel18.StylePriority.UseBackColor = false;
         this.xrLabel18.StylePriority.UseBorderColor = false;
         this.xrLabel18.StylePriority.UseBorders = false;
         this.xrLabel18.StylePriority.UseForeColor = false;
         this.xrLabel18.Text = "xrLabel18";
         // 
         // groupFooterBand2
         // 
         this.groupFooterBand2.BorderColor = System.Drawing.Color.DarkGray;
         this.groupFooterBand2.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLine4,
            this.xrLabel19,
            this.xrLabel20,
            this.xrLabel21,
            this.xrLabel22});
         this.groupFooterBand2.HeightF = 26.87499F;
         this.groupFooterBand2.KeepTogether = true;
         this.groupFooterBand2.Name = "groupFooterBand2";
         this.groupFooterBand2.StylePriority.UseBorderColor = false;
         // 
         // xrLine4
         // 
         this.xrLine4.LocationFloat = new DevExpress.Utils.PointFloat(0F, 4.00001F);
         this.xrLine4.Name = "xrLine4";
         this.xrLine4.SizeF = new System.Drawing.SizeF(649.9999F, 2F);
         // 
         // xrLabel19
         // 
         this.xrLabel19.BackColor = System.Drawing.Color.Transparent;
         this.xrLabel19.CanGrow = false;
         this.xrLabel19.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.Cost")});
         this.xrLabel19.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
         this.xrLabel19.ForeColor = System.Drawing.Color.Black;
         this.xrLabel19.LocationFloat = new DevExpress.Utils.PointFloat(575.7263F, 6.00001F);
         this.xrLabel19.Name = "xrLabel19";
         this.xrLabel19.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel19.SizeF = new System.Drawing.SizeF(74.27368F, 18F);
         this.xrLabel19.StyleName = "FieldCaption";
         this.xrLabel19.StylePriority.UseBackColor = false;
         this.xrLabel19.StylePriority.UseFont = false;
         this.xrLabel19.StylePriority.UseForeColor = false;
         this.xrLabel19.StylePriority.UseTextAlignment = false;
         xrSummary4.FormatString = "{0:#,##0.00}";
         xrSummary4.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
         this.xrLabel19.Summary = xrSummary4;
         this.xrLabel19.Text = "xrLabel19";
         this.xrLabel19.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
         this.xrLabel19.WordWrap = false;
         // 
         // xrLabel20
         // 
         this.xrLabel20.BackColor = System.Drawing.Color.Transparent;
         this.xrLabel20.CanGrow = false;
         this.xrLabel20.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.Qty")});
         this.xrLabel20.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
         this.xrLabel20.ForeColor = System.Drawing.Color.Black;
         this.xrLabel20.LocationFloat = new DevExpress.Utils.PointFloat(440.6024F, 6.00001F);
         this.xrLabel20.Name = "xrLabel20";
         this.xrLabel20.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel20.SizeF = new System.Drawing.SizeF(61.19666F, 18F);
         this.xrLabel20.StyleName = "FieldCaption";
         this.xrLabel20.StylePriority.UseBackColor = false;
         this.xrLabel20.StylePriority.UseFont = false;
         this.xrLabel20.StylePriority.UseForeColor = false;
         this.xrLabel20.StylePriority.UseTextAlignment = false;
         xrSummary5.FormatString = "{0:0.000}";
         xrSummary5.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
         this.xrLabel20.Summary = xrSummary5;
         this.xrLabel20.Text = "xrLabel20";
         this.xrLabel20.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
         this.xrLabel20.WordWrap = false;
         // 
         // xrLabel21
         // 
         this.xrLabel21.BackColor = System.Drawing.Color.Transparent;
         this.xrLabel21.CanGrow = false;
         this.xrLabel21.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.Total", "{0:C2}")});
         this.xrLabel21.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
         this.xrLabel21.ForeColor = System.Drawing.Color.Black;
         this.xrLabel21.LocationFloat = new DevExpress.Utils.PointFloat(501.7991F, 6.00001F);
         this.xrLabel21.Name = "xrLabel21";
         this.xrLabel21.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel21.SizeF = new System.Drawing.SizeF(73.92725F, 18F);
         this.xrLabel21.StyleName = "FieldCaption";
         this.xrLabel21.StylePriority.UseBackColor = false;
         this.xrLabel21.StylePriority.UseFont = false;
         this.xrLabel21.StylePriority.UseForeColor = false;
         this.xrLabel21.StylePriority.UseTextAlignment = false;
         xrSummary6.FormatString = "{0:#,##0.00}";
         xrSummary6.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
         this.xrLabel21.Summary = xrSummary6;
         this.xrLabel21.Text = "xrLabel21";
         this.xrLabel21.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
         this.xrLabel21.WordWrap = false;
         // 
         // xrLabel22
         // 
         this.xrLabel22.BackColor = System.Drawing.Color.Transparent;
         this.xrLabel22.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
         this.xrLabel22.ForeColor = System.Drawing.Color.Black;
         this.xrLabel22.LocationFloat = new DevExpress.Utils.PointFloat(0F, 6.00001F);
         this.xrLabel22.Name = "xrLabel22";
         this.xrLabel22.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel22.SizeF = new System.Drawing.SizeF(440.6024F, 18F);
         this.xrLabel22.StyleName = "FieldCaption";
         this.xrLabel22.StylePriority.UseBackColor = false;
         this.xrLabel22.StylePriority.UseFont = false;
         this.xrLabel22.StylePriority.UseForeColor = false;
         this.xrLabel22.Text = "Σύνολα Κατηγορίας";
         // 
         // pageFooterBand1
         // 
         this.pageFooterBand1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrPageInfo1});
         this.pageFooterBand1.HeightF = 21.7083F;
         this.pageFooterBand1.Name = "pageFooterBand1";
         // 
         // xrPageInfo1
         // 
         this.xrPageInfo1.Borders = DevExpress.XtraPrinting.BorderSide.Top;
         this.xrPageInfo1.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
         this.xrPageInfo1.Format = "Σελίδα {0} από {1}";
         this.xrPageInfo1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
         this.xrPageInfo1.Name = "xrPageInfo1";
         this.xrPageInfo1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrPageInfo1.SizeF = new System.Drawing.SizeF(650F, 18.76271F);
         this.xrPageInfo1.StylePriority.UseBorders = false;
         this.xrPageInfo1.StylePriority.UseFont = false;
         this.xrPageInfo1.StylePriority.UseTextAlignment = false;
         this.xrPageInfo1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
         // 
         // reportHeaderBand1
         // 
         this.reportHeaderBand1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel4,
            this.xrLabel33});
         this.reportHeaderBand1.HeightF = 27.04166F;
         this.reportHeaderBand1.Name = "reportHeaderBand1";
         // 
         // xrLabel33
         // 
         this.xrLabel33.Borders = DevExpress.XtraPrinting.BorderSide.None;
         this.xrLabel33.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding(this.dtFrom, "Text", "Κόστος Πωληθέντων (από {0}")});
         this.xrLabel33.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
         this.xrLabel33.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
         this.xrLabel33.LocationFloat = new DevExpress.Utils.PointFloat(0F, 1.999998F);
         this.xrLabel33.Name = "xrLabel33";
         this.xrLabel33.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel33.SizeF = new System.Drawing.SizeF(414F, 21.54166F);
         this.xrLabel33.StyleName = "Title";
         this.xrLabel33.StylePriority.UseBorders = false;
         this.xrLabel33.StylePriority.UseFont = false;
         this.xrLabel33.StylePriority.UseForeColor = false;
         this.xrLabel33.StylePriority.UseTextAlignment = false;
         this.xrLabel33.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
         // 
         // reportFooterBand1
         // 
         this.reportFooterBand1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel34,
            this.xrLabel35,
            this.xrLabel36,
            this.xrLabel37,
            this.xrLine6});
         this.reportFooterBand1.HeightF = 21.66665F;
         this.reportFooterBand1.Name = "reportFooterBand1";
         // 
         // xrLabel34
         // 
         this.xrLabel34.BackColor = System.Drawing.Color.Silver;
         this.xrLabel34.CanGrow = false;
         this.xrLabel34.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.Cost")});
         this.xrLabel34.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
         this.xrLabel34.ForeColor = System.Drawing.Color.Black;
         this.xrLabel34.LocationFloat = new DevExpress.Utils.PointFloat(575.7264F, 2F);
         this.xrLabel34.Name = "xrLabel34";
         this.xrLabel34.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel34.SizeF = new System.Drawing.SizeF(74.27356F, 18F);
         this.xrLabel34.StyleName = "FieldCaption";
         this.xrLabel34.StylePriority.UseBackColor = false;
         this.xrLabel34.StylePriority.UseFont = false;
         this.xrLabel34.StylePriority.UseForeColor = false;
         this.xrLabel34.StylePriority.UseTextAlignment = false;
         xrSummary7.FormatString = "{0:#,##0.00}";
         xrSummary7.Running = DevExpress.XtraReports.UI.SummaryRunning.Report;
         this.xrLabel34.Summary = xrSummary7;
         this.xrLabel34.Text = "xrLabel34";
         this.xrLabel34.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
         this.xrLabel34.WordWrap = false;
         // 
         // xrLabel35
         // 
         this.xrLabel35.BackColor = System.Drawing.Color.Silver;
         this.xrLabel35.CanGrow = false;
         this.xrLabel35.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.Qty")});
         this.xrLabel35.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
         this.xrLabel35.ForeColor = System.Drawing.Color.Black;
         this.xrLabel35.LocationFloat = new DevExpress.Utils.PointFloat(440.6024F, 2F);
         this.xrLabel35.Name = "xrLabel35";
         this.xrLabel35.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel35.SizeF = new System.Drawing.SizeF(61.19666F, 18F);
         this.xrLabel35.StyleName = "FieldCaption";
         this.xrLabel35.StylePriority.UseBackColor = false;
         this.xrLabel35.StylePriority.UseFont = false;
         this.xrLabel35.StylePriority.UseForeColor = false;
         this.xrLabel35.StylePriority.UseTextAlignment = false;
         xrSummary8.FormatString = "{0:0.000}";
         xrSummary8.Running = DevExpress.XtraReports.UI.SummaryRunning.Report;
         this.xrLabel35.Summary = xrSummary8;
         this.xrLabel35.Text = "xrLabel35";
         this.xrLabel35.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
         this.xrLabel35.WordWrap = false;
         // 
         // xrLabel36
         // 
         this.xrLabel36.BackColor = System.Drawing.Color.Silver;
         this.xrLabel36.CanGrow = false;
         this.xrLabel36.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.Total", "{0:C2}")});
         this.xrLabel36.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
         this.xrLabel36.ForeColor = System.Drawing.Color.Black;
         this.xrLabel36.LocationFloat = new DevExpress.Utils.PointFloat(501.7991F, 2F);
         this.xrLabel36.Name = "xrLabel36";
         this.xrLabel36.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel36.SizeF = new System.Drawing.SizeF(73.92725F, 18F);
         this.xrLabel36.StyleName = "FieldCaption";
         this.xrLabel36.StylePriority.UseBackColor = false;
         this.xrLabel36.StylePriority.UseFont = false;
         this.xrLabel36.StylePriority.UseForeColor = false;
         this.xrLabel36.StylePriority.UseTextAlignment = false;
         xrSummary9.FormatString = "{0:#,##0.00}";
         xrSummary9.Running = DevExpress.XtraReports.UI.SummaryRunning.Report;
         this.xrLabel36.Summary = xrSummary9;
         this.xrLabel36.Text = "xrLabel36";
         this.xrLabel36.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
         this.xrLabel36.WordWrap = false;
         // 
         // xrLabel37
         // 
         this.xrLabel37.BackColor = System.Drawing.Color.Silver;
         this.xrLabel37.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
         this.xrLabel37.ForeColor = System.Drawing.Color.Black;
         this.xrLabel37.LocationFloat = new DevExpress.Utils.PointFloat(0F, 2F);
         this.xrLabel37.Name = "xrLabel37";
         this.xrLabel37.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel37.SizeF = new System.Drawing.SizeF(440.6024F, 18F);
         this.xrLabel37.StyleName = "FieldCaption";
         this.xrLabel37.StylePriority.UseBackColor = false;
         this.xrLabel37.StylePriority.UseFont = false;
         this.xrLabel37.StylePriority.UseForeColor = false;
         this.xrLabel37.Text = "Γενικά Σύνολα";
         // 
         // xrLine6
         // 
         this.xrLine6.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
         this.xrLine6.Name = "xrLine6";
         this.xrLine6.SizeF = new System.Drawing.SizeF(650F, 2F);
         // 
         // Title
         // 
         this.Title.BackColor = System.Drawing.Color.Transparent;
         this.Title.BorderColor = System.Drawing.Color.Black;
         this.Title.Borders = DevExpress.XtraPrinting.BorderSide.None;
         this.Title.BorderWidth = 1F;
         this.Title.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold);
         this.Title.ForeColor = System.Drawing.Color.Maroon;
         this.Title.Name = "Title";
         // 
         // FieldCaption
         // 
         this.FieldCaption.BackColor = System.Drawing.Color.Transparent;
         this.FieldCaption.BorderColor = System.Drawing.Color.Black;
         this.FieldCaption.Borders = DevExpress.XtraPrinting.BorderSide.None;
         this.FieldCaption.BorderWidth = 1F;
         this.FieldCaption.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
         this.FieldCaption.ForeColor = System.Drawing.Color.Maroon;
         this.FieldCaption.Name = "FieldCaption";
         // 
         // PageInfo
         // 
         this.PageInfo.BackColor = System.Drawing.Color.Transparent;
         this.PageInfo.BorderColor = System.Drawing.Color.Black;
         this.PageInfo.Borders = DevExpress.XtraPrinting.BorderSide.None;
         this.PageInfo.BorderWidth = 1F;
         this.PageInfo.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
         this.PageInfo.ForeColor = System.Drawing.Color.Black;
         this.PageInfo.Name = "PageInfo";
         // 
         // DataField
         // 
         this.DataField.BackColor = System.Drawing.Color.Transparent;
         this.DataField.BorderColor = System.Drawing.Color.Black;
         this.DataField.Borders = DevExpress.XtraPrinting.BorderSide.None;
         this.DataField.BorderWidth = 1F;
         this.DataField.Font = new System.Drawing.Font("Times New Roman", 10F);
         this.DataField.ForeColor = System.Drawing.Color.Black;
         this.DataField.Name = "DataField";
         this.DataField.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         // 
         // dtFrom
         // 
         this.dtFrom.Description = "Από Ημερομηνία";
         this.dtFrom.Name = "dtFrom";
         this.dtFrom.Type = typeof(System.DateTime);
         this.dtFrom.ValueInfo = "2016-05-01";
         // 
         // dtTo
         // 
         this.dtTo.Description = "Έως  Ημερομηνία";
         this.dtTo.Name = "dtTo";
         this.dtTo.Type = typeof(System.DateTime);
         this.dtTo.ValueInfo = "2016-05-01";
         // 
         // CostPriceList
         // 
         this.CostPriceList.Description = "Κόστος";
         dynamicListLookUpSettings1.DataAdapter = null;
         dynamicListLookUpSettings1.DataMember = "PriceListLookUp";
         dynamicListLookUpSettings1.DataSource = this.sqlDataSource1;
         dynamicListLookUpSettings1.DisplayMember = "Description";
         dynamicListLookUpSettings1.FilterString = null;
         dynamicListLookUpSettings1.ValueMember = "Id";
         this.CostPriceList.LookUpSettings = dynamicListLookUpSettings1;
         this.CostPriceList.Name = "CostPriceList";
         this.CostPriceList.Type = typeof(long);
         this.CostPriceList.ValueInfo = "0";
         // 
         // Depart
         // 
         this.Depart.Description = "Τμήμα";
         dynamicListLookUpSettings2.DataAdapter = null;
         dynamicListLookUpSettings2.DataMember = "DepartmentLookUp";
         dynamicListLookUpSettings2.DataSource = this.sqlDataSource1;
         dynamicListLookUpSettings2.DisplayMember = "Description";
         dynamicListLookUpSettings2.FilterString = null;
         dynamicListLookUpSettings2.ValueMember = "id";
         this.Depart.LookUpSettings = dynamicListLookUpSettings2;
         this.Depart.MultiValue = true;
         this.Depart.Name = "Depart";
         this.Depart.Type = typeof(long);
         // 
         // Category
         // 
         this.Category.Description = "Κατηγορία Είδους";
         dynamicListLookUpSettings3.DataAdapter = null;
         dynamicListLookUpSettings3.DataMember = "CategoriesLookUp";
         dynamicListLookUpSettings3.DataSource = this.sqlDataSource1;
         dynamicListLookUpSettings3.DisplayMember = "Description";
         dynamicListLookUpSettings3.FilterString = null;
         dynamicListLookUpSettings3.ValueMember = "Id";
         this.Category.LookUpSettings = dynamicListLookUpSettings3;
         this.Category.MultiValue = true;
         this.Category.Name = "Category";
         this.Category.Type = typeof(long);
         // 
         // PriceLists
         // 
         this.PriceLists.Description = "Τιμοκατάλογοι";
         dynamicListLookUpSettings4.DataAdapter = null;
         dynamicListLookUpSettings4.DataMember = "PriceListLookUp";
         dynamicListLookUpSettings4.DataSource = this.sqlDataSource1;
         dynamicListLookUpSettings4.DisplayMember = "Description";
         dynamicListLookUpSettings4.FilterString = null;
         dynamicListLookUpSettings4.ValueMember = "Id";
         this.PriceLists.LookUpSettings = dynamicListLookUpSettings4;
         this.PriceLists.MultiValue = true;
         this.PriceLists.Name = "PriceLists";
         this.PriceLists.Type = typeof(long);
         // 
         // xrControlStyle1
         // 
         this.xrControlStyle1.BackColor = System.Drawing.Color.LightGray;
         this.xrControlStyle1.Name = "xrControlStyle1";
         this.xrControlStyle1.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
         // 
         // xrLabel4
         // 
         this.xrLabel4.Borders = DevExpress.XtraPrinting.BorderSide.None;
         this.xrLabel4.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding(this.dtTo, "Text", " έως {0})")});
         this.xrLabel4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
         this.xrLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
         this.xrLabel4.LocationFloat = new DevExpress.Utils.PointFloat(414F, 1.999998F);
         this.xrLabel4.Name = "xrLabel4";
         this.xrLabel4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel4.SizeF = new System.Drawing.SizeF(235.9999F, 21.54166F);
         this.xrLabel4.StyleName = "Title";
         this.xrLabel4.StylePriority.UseBorders = false;
         this.xrLabel4.StylePriority.UseFont = false;
         this.xrLabel4.StylePriority.UseForeColor = false;
         this.xrLabel4.StylePriority.UseTextAlignment = false;
         this.xrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
         // 
         // SalesCostOldDB
         // 
         this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.pageHeaderBand1,
            this.DepartmentDescriptionGroupHeader,
            this.groupFooterBand1,
            this.CategoryGroupHeader,
            this.groupFooterBand2,
            this.pageFooterBand1,
            this.reportHeaderBand1,
            this.reportFooterBand1});
         this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.sqlDataSource1});
         this.DataMember = "Query_FastStart";
         this.DataSource = this.sqlDataSource1;
         this.FilterString = "[DepartmentId] In (?Depart) And [CategoryId] In (?Category) And [SalesPriceListId" +
    "] In (?PriceLists)";
         this.Margins = new System.Drawing.Printing.Margins(100, 100, 58, 36);
         this.Parameters.AddRange(new DevExpress.XtraReports.Parameters.Parameter[] {
            this.dtFrom,
            this.dtTo,
            this.CostPriceList,
            this.Depart,
            this.Category,
            this.PriceLists});
         this.StyleSheet.AddRange(new DevExpress.XtraReports.UI.XRControlStyle[] {
            this.Title,
            this.FieldCaption,
            this.PageInfo,
            this.DataField,
            this.xrControlStyle1});
         this.Version = "15.2";
         this.DataSourceDemanded += new System.EventHandler<System.EventArgs>(this.SalesCostOldDB_DataSourceDemanded);
         ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

      }

   #endregion

   ////////////////////////////////////////////////////////////////////////////////////////////////
   /// <summary>
   /// 
   /// </summary>
   /// <param name="sender"></param>
   /// <param name="e"></param>
   private void SalesCostOldDB_DataSourceDemanded( object sender, EventArgs e )
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

   }

