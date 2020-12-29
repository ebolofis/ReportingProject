
using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Web.Configuration;
using WEBPOS_Reports.Helpers;

////////////////////////////////////////////////////////////////////////////////////////////////
/// <summary>
/// Summary description for HourlySalesPerInvoiceTypeTotal_OldDB
/// </summary>
public class HourlySalesPerInvoiceTypeTotal_OldDB : DevExpress.XtraReports.UI.XtraReport
   {
   private DevExpress.XtraReports.UI.DetailBand Detail;
   private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
   private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
   private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
   private GroupHeaderBand Hour_GroupHeader;
   private GroupHeaderBand InvoiceType_GroupHeader;
   private PageFooterBand pageFooterBand1;
   private ReportHeaderBand reportHeaderBand1;
   private GroupFooterBand groupFooterBand1;
   private ReportFooterBand reportFooterBand1;
   private XRControlStyle Title;
   private XRControlStyle FieldCaption;
   private XRControlStyle PageInfo;
   private XRControlStyle DataField;
   private DevExpress.XtraReports.Parameters.Parameter FromDate;
   private DevExpress.XtraReports.Parameters.Parameter ToDate;
   private XRPageInfo xrPageInfo3;
   private XRPageInfo xrPageInfo1;
   private DevExpress.XtraReports.Parameters.Parameter HourOfDay;
   private DevExpress.XtraReports.Parameters.Parameter InvoiceType;
   private DevExpress.XtraReports.Parameters.Parameter Department;
   private DevExpress.XtraReports.Parameters.Parameter PosInfo;
   private XRLabel xrLabel29;
   private XRLabel xrLabel39;
   private XRLabel xrLabel40;
   private XRLabel xrLabel2;
   private XRLabel xrLabel1;
   private XRLabel xrLabel41;
   private XRLabel xrLabel42;
   private XRLabel xrLabel17;
   private XRLabel xrLabel18;
   private XRLabel xrLabel19;
   private XRLabel xrLabel20;
   private GroupHeaderBand Department_GroupHeader;
   private GroupHeaderBand POS_GroupHeader;
   private GroupFooterBand Department_GroupFooter;
   private GroupFooterBand POS_GroupFooter;
   private XRLabel xrLabel5;
   private XRLabel xrLabel6;
   private XRLabel xrLabel13;
   private XRLabel xrLabel14;
   private XRLabel xrLabel15;
   private XRLabel xrLabel16;
   private GroupHeaderBand GroupHeader1;
   private XRLine xrLine2;
   private XRLabel xrLabel44;
   private XRLabel xrLabel43;
   private XRLabel xrLabel4;
   private XRLabel xrLabel3;
   private XRLabel xrLabel7;
   private XRLabel xrLabel28;
   private XRLine xrLine7;
   private XRLabel xrLabel8;
   private XRLabel xrLabel32;
   private XRLine xrLine3;
   private XRLabel xrLabel33;
   private XRLabel xrLabel34;
   private XRLabel xrLabel31;
   private XRLine xrLine6;
   private XRLabel xrLabel25;
   private XRLabel xrLabel26;
   private XRLabel xrLabel27;
   private XRLabel xrLabel36;
   private XRLabel xrLabel35;
   private XRLine xrLine1;
   private XRLine xrLine5;
   private XRLine xrLine4;

   /// <summary>
   /// Required designer variable.
   /// </summary>
   private System.ComponentModel.IContainer components = null;

   ////////////////////////////////////////////////////////////////////////////////////////////////
   public HourlySalesPerInvoiceTypeTotal_OldDB()
      {
      InitializeComponent();
      //
      // TODO: Add constructor logic here
      //
      }

   ////////////////////////////////////////////////////////////////////////////////////////////////
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
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HourlySalesPerInvoiceTypeTotal_OldDB));
         DevExpress.DataAccess.Sql.CustomSqlQuery customSqlQuery2 = new DevExpress.DataAccess.Sql.CustomSqlQuery();
         DevExpress.DataAccess.Sql.CustomSqlQuery customSqlQuery3 = new DevExpress.DataAccess.Sql.CustomSqlQuery();
         DevExpress.DataAccess.Sql.CustomSqlQuery customSqlQuery4 = new DevExpress.DataAccess.Sql.CustomSqlQuery();
         DevExpress.DataAccess.Sql.CustomSqlQuery customSqlQuery5 = new DevExpress.DataAccess.Sql.CustomSqlQuery();
         DevExpress.DataAccess.Sql.CustomSqlQuery customSqlQuery6 = new DevExpress.DataAccess.Sql.CustomSqlQuery();
         DevExpress.XtraReports.UI.XRSummary xrSummary1 = new DevExpress.XtraReports.UI.XRSummary();
         DevExpress.XtraReports.UI.XRSummary xrSummary2 = new DevExpress.XtraReports.UI.XRSummary();
         DevExpress.XtraReports.UI.XRSummary xrSummary3 = new DevExpress.XtraReports.UI.XRSummary();
         DevExpress.XtraReports.UI.XRSummary xrSummary4 = new DevExpress.XtraReports.UI.XRSummary();
         DevExpress.XtraReports.UI.XRSummary xrSummary5 = new DevExpress.XtraReports.UI.XRSummary();
         DevExpress.XtraReports.UI.XRSummary xrSummary6 = new DevExpress.XtraReports.UI.XRSummary();
         DevExpress.XtraReports.UI.XRSummary xrSummary7 = new DevExpress.XtraReports.UI.XRSummary();
         DevExpress.XtraReports.UI.XRSummary xrSummary8 = new DevExpress.XtraReports.UI.XRSummary();
         DevExpress.XtraReports.UI.XRSummary xrSummary9 = new DevExpress.XtraReports.UI.XRSummary();
         DevExpress.XtraReports.UI.XRSummary xrSummary10 = new DevExpress.XtraReports.UI.XRSummary();
         DevExpress.XtraReports.UI.XRSummary xrSummary11 = new DevExpress.XtraReports.UI.XRSummary();
         DevExpress.XtraReports.UI.XRSummary xrSummary12 = new DevExpress.XtraReports.UI.XRSummary();
         DevExpress.XtraReports.UI.XRSummary xrSummary13 = new DevExpress.XtraReports.UI.XRSummary();
         DevExpress.XtraReports.Parameters.DynamicListLookUpSettings dynamicListLookUpSettings1 = new DevExpress.XtraReports.Parameters.DynamicListLookUpSettings();
         DevExpress.XtraReports.Parameters.DynamicListLookUpSettings dynamicListLookUpSettings2 = new DevExpress.XtraReports.Parameters.DynamicListLookUpSettings();
         DevExpress.XtraReports.Parameters.DynamicListLookUpSettings dynamicListLookUpSettings3 = new DevExpress.XtraReports.Parameters.DynamicListLookUpSettings();
         DevExpress.XtraReports.Parameters.DynamicListLookUpSettings dynamicListLookUpSettings4 = new DevExpress.XtraReports.Parameters.DynamicListLookUpSettings();
         DevExpress.XtraReports.UI.XRSummary xrSummary14 = new DevExpress.XtraReports.UI.XRSummary();
         DevExpress.XtraReports.UI.XRSummary xrSummary15 = new DevExpress.XtraReports.UI.XRSummary();
         DevExpress.XtraReports.UI.XRSummary xrSummary16 = new DevExpress.XtraReports.UI.XRSummary();
         DevExpress.XtraReports.UI.XRSummary xrSummary17 = new DevExpress.XtraReports.UI.XRSummary();
         DevExpress.XtraReports.UI.XRSummary xrSummary18 = new DevExpress.XtraReports.UI.XRSummary();
         DevExpress.XtraReports.UI.XRSummary xrSummary19 = new DevExpress.XtraReports.UI.XRSummary();
         this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
         this.Detail = new DevExpress.XtraReports.UI.DetailBand();
         this.xrLabel17 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel18 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel19 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel20 = new DevExpress.XtraReports.UI.XRLabel();
         this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
         this.xrPageInfo3 = new DevExpress.XtraReports.UI.XRPageInfo();
         this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
         this.Hour_GroupHeader = new DevExpress.XtraReports.UI.GroupHeaderBand();
         this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel41 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel42 = new DevExpress.XtraReports.UI.XRLabel();
         this.InvoiceType_GroupHeader = new DevExpress.XtraReports.UI.GroupHeaderBand();
         this.xrLabel13 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel14 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel15 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel16 = new DevExpress.XtraReports.UI.XRLabel();
         this.pageFooterBand1 = new DevExpress.XtraReports.UI.PageFooterBand();
         this.xrPageInfo1 = new DevExpress.XtraReports.UI.XRPageInfo();
         this.reportHeaderBand1 = new DevExpress.XtraReports.UI.ReportHeaderBand();
         this.xrLabel29 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel39 = new DevExpress.XtraReports.UI.XRLabel();
         this.ToDate = new DevExpress.XtraReports.Parameters.Parameter();
         this.xrLabel40 = new DevExpress.XtraReports.UI.XRLabel();
         this.FromDate = new DevExpress.XtraReports.Parameters.Parameter();
         this.groupFooterBand1 = new DevExpress.XtraReports.UI.GroupFooterBand();
         this.reportFooterBand1 = new DevExpress.XtraReports.UI.ReportFooterBand();
         this.xrLabel31 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLine6 = new DevExpress.XtraReports.UI.XRLine();
         this.xrLabel25 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel26 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel27 = new DevExpress.XtraReports.UI.XRLabel();
         this.Title = new DevExpress.XtraReports.UI.XRControlStyle();
         this.FieldCaption = new DevExpress.XtraReports.UI.XRControlStyle();
         this.PageInfo = new DevExpress.XtraReports.UI.XRControlStyle();
         this.DataField = new DevExpress.XtraReports.UI.XRControlStyle();
         this.HourOfDay = new DevExpress.XtraReports.Parameters.Parameter();
         this.InvoiceType = new DevExpress.XtraReports.Parameters.Parameter();
         this.Department = new DevExpress.XtraReports.Parameters.Parameter();
         this.PosInfo = new DevExpress.XtraReports.Parameters.Parameter();
         this.Department_GroupHeader = new DevExpress.XtraReports.UI.GroupHeaderBand();
         this.xrLabel5 = new DevExpress.XtraReports.UI.XRLabel();
         this.POS_GroupHeader = new DevExpress.XtraReports.UI.GroupHeaderBand();
         this.xrLabel6 = new DevExpress.XtraReports.UI.XRLabel();
         this.Department_GroupFooter = new DevExpress.XtraReports.UI.GroupFooterBand();
         this.xrLabel36 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel32 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLine3 = new DevExpress.XtraReports.UI.XRLine();
         this.xrLabel33 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel34 = new DevExpress.XtraReports.UI.XRLabel();
         this.POS_GroupFooter = new DevExpress.XtraReports.UI.GroupFooterBand();
         this.xrLine1 = new DevExpress.XtraReports.UI.XRLine();
         this.xrLabel35 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel7 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel28 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLine7 = new DevExpress.XtraReports.UI.XRLine();
         this.xrLabel8 = new DevExpress.XtraReports.UI.XRLabel();
         this.GroupHeader1 = new DevExpress.XtraReports.UI.GroupHeaderBand();
         this.xrLine2 = new DevExpress.XtraReports.UI.XRLine();
         this.xrLabel44 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel43 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel4 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLine4 = new DevExpress.XtraReports.UI.XRLine();
         this.xrLine5 = new DevExpress.XtraReports.UI.XRLine();
         ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
         // 
         // sqlDataSource1
         // 
         this.sqlDataSource1.ConnectionName = "ReportConnection";
         this.sqlDataSource1.Name = "sqlDataSource1";
         customSqlQuery1.Name = "Query";
         queryParameter1.Name = "FromDate";
         queryParameter1.Type = typeof(DevExpress.DataAccess.Expression);
         queryParameter1.Value = new DevExpress.DataAccess.Expression("[Parameters.FromDate]", typeof(System.DateTime));
         queryParameter2.Name = "ToDate";
         queryParameter2.Type = typeof(DevExpress.DataAccess.Expression);
         queryParameter2.Value = new DevExpress.DataAccess.Expression("[Parameters.ToDate]", typeof(System.DateTime));
         customSqlQuery1.Parameters.Add(queryParameter1);
         customSqlQuery1.Parameters.Add(queryParameter2);
         customSqlQuery1.Sql = resources.GetString("customSqlQuery1.Sql");
         customSqlQuery2.Name = "Query_FastStart";
         customSqlQuery2.Sql = "/* Query_FastStart */\r\nSelect *\r\nFrom Invoices\r\nWhere id = -1\r\n";
         customSqlQuery3.Name = "Departments";
         customSqlQuery3.Sql = "/* Departments */\r\nSelect Id, Description\r\nFrom Department\r\n";
         customSqlQuery4.Name = "Posinfos";
         customSqlQuery4.Sql = "/* Posinfos */\r\nSelect Id, Code, Description\r\nFrom PosInfo\r\n";
         customSqlQuery5.Name = "HourOfDay";
         customSqlQuery5.Sql = "/* HourOfDay */\r\nSELECT Distinct CONVERT( VARCHAR(2), day, 108 ) HourOfDay\r\nFROM " +
    "Invoices\r\nOrder By HourOfDay Asc";
         customSqlQuery6.Name = "InvoiceTypes";
         customSqlQuery6.Sql = "/* InvoiceTypes */\r\nSelect Distinct Id, Abbreviation, Type\r\nFrom InvoiceTypes\r\nWh" +
    "ere Type NOT IN ( 2, 3, 8, 10, 11, 12 )\r\nOrder By Type";
         this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            customSqlQuery1,
            customSqlQuery2,
            customSqlQuery3,
            customSqlQuery4,
            customSqlQuery5,
            customSqlQuery6});
         this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
         // 
         // Detail
         // 
         this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel17,
            this.xrLabel18,
            this.xrLabel19,
            this.xrLabel20});
         this.Detail.HeightF = 18F;
         this.Detail.Name = "Detail";
         this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
         this.Detail.StyleName = "DataField";
         this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
         this.Detail.Visible = false;
         // 
         // xrLabel17
         // 
         this.xrLabel17.CanGrow = false;
         this.xrLabel17.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.Abbreviation")});
         this.xrLabel17.Font = new System.Drawing.Font("Times New Roman", 8F);
         this.xrLabel17.LocationFloat = new DevExpress.Utils.PointFloat(0.0001525879F, 0F);
         this.xrLabel17.Name = "xrLabel17";
         this.xrLabel17.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel17.SizeF = new System.Drawing.SizeF(305.4892F, 18F);
         this.xrLabel17.StylePriority.UseFont = false;
         this.xrLabel17.WordWrap = false;
         // 
         // xrLabel18
         // 
         this.xrLabel18.CanGrow = false;
         this.xrLabel18.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.InvoiceCount")});
         this.xrLabel18.Font = new System.Drawing.Font("Times New Roman", 8F);
         this.xrLabel18.LocationFloat = new DevExpress.Utils.PointFloat(305.4893F, 0F);
         this.xrLabel18.Name = "xrLabel18";
         this.xrLabel18.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel18.SizeF = new System.Drawing.SizeF(159.2245F, 18F);
         this.xrLabel18.StylePriority.UseFont = false;
         this.xrLabel18.StylePriority.UseTextAlignment = false;
         xrSummary1.FormatString = "{0:#,##0}";
         xrSummary1.IgnoreNullValues = true;
         xrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
         this.xrLabel18.Summary = xrSummary1;
         this.xrLabel18.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
         this.xrLabel18.WordWrap = false;
         // 
         // xrLabel19
         // 
         this.xrLabel19.CanGrow = false;
         this.xrLabel19.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.Qty")});
         this.xrLabel19.Font = new System.Drawing.Font("Times New Roman", 8F);
         this.xrLabel19.LocationFloat = new DevExpress.Utils.PointFloat(464.7139F, 0F);
         this.xrLabel19.Name = "xrLabel19";
         this.xrLabel19.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel19.SizeF = new System.Drawing.SizeF(113.8881F, 18F);
         this.xrLabel19.StylePriority.UseFont = false;
         this.xrLabel19.StylePriority.UseTextAlignment = false;
         xrSummary2.FormatString = "{0:#,##0.000}";
         xrSummary2.IgnoreNullValues = true;
         xrSummary2.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
         this.xrLabel19.Summary = xrSummary2;
         this.xrLabel19.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
         this.xrLabel19.WordWrap = false;
         // 
         // xrLabel20
         // 
         this.xrLabel20.CanGrow = false;
         this.xrLabel20.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.Total")});
         this.xrLabel20.Font = new System.Drawing.Font("Times New Roman", 8F);
         this.xrLabel20.LocationFloat = new DevExpress.Utils.PointFloat(578.6018F, 0F);
         this.xrLabel20.Name = "xrLabel20";
         this.xrLabel20.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel20.SizeF = new System.Drawing.SizeF(146.398F, 18F);
         this.xrLabel20.StylePriority.UseFont = false;
         this.xrLabel20.StylePriority.UseTextAlignment = false;
         xrSummary3.FormatString = "{0:#,##0.00}";
         xrSummary3.IgnoreNullValues = true;
         xrSummary3.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
         this.xrLabel20.Summary = xrSummary3;
         this.xrLabel20.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
         this.xrLabel20.WordWrap = false;
         // 
         // TopMargin
         // 
         this.TopMargin.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrPageInfo3});
         this.TopMargin.HeightF = 56.26271F;
         this.TopMargin.Name = "TopMargin";
         this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
         this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
         // 
         // xrPageInfo3
         // 
         this.xrPageInfo3.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
         this.xrPageInfo3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
         this.xrPageInfo3.Format = "Ημερομηνία Εκτύπωσης : {0:dddd, d MMMM yyyy h:mm:ss tt}";
         this.xrPageInfo3.LocationFloat = new DevExpress.Utils.PointFloat(0F, 37.5F);
         this.xrPageInfo3.Name = "xrPageInfo3";
         this.xrPageInfo3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrPageInfo3.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime;
         this.xrPageInfo3.SizeF = new System.Drawing.SizeF(725F, 18.76271F);
         this.xrPageInfo3.StylePriority.UseBorders = false;
         this.xrPageInfo3.StylePriority.UseFont = false;
         // 
         // BottomMargin
         // 
         this.BottomMargin.HeightF = 36.95831F;
         this.BottomMargin.Name = "BottomMargin";
         this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
         this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
         // 
         // Hour_GroupHeader
         // 
         this.Hour_GroupHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel2,
            this.xrLabel1,
            this.xrLabel41,
            this.xrLabel42});
         this.Hour_GroupHeader.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("HourOfDay", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
         this.Hour_GroupHeader.HeightF = 17.41667F;
         this.Hour_GroupHeader.Level = 1;
         this.Hour_GroupHeader.Name = "Hour_GroupHeader";
         // 
         // xrLabel2
         // 
         this.xrLabel2.BackColor = System.Drawing.Color.Silver;
         this.xrLabel2.CanGrow = false;
         this.xrLabel2.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.HourOfDay", "Hour : {0}")});
         this.xrLabel2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold);
         this.xrLabel2.LocationFloat = new DevExpress.Utils.PointFloat(0.0001525879F, 0F);
         this.xrLabel2.Name = "xrLabel2";
         this.xrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel2.SizeF = new System.Drawing.SizeF(305.4892F, 17.41667F);
         this.xrLabel2.StyleName = "DataField";
         this.xrLabel2.StylePriority.UseBackColor = false;
         this.xrLabel2.StylePriority.UseFont = false;
         this.xrLabel2.StylePriority.UseTextAlignment = false;
         this.xrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
         this.xrLabel2.WordWrap = false;
         // 
         // xrLabel1
         // 
         this.xrLabel1.BackColor = System.Drawing.Color.Silver;
         this.xrLabel1.CanGrow = false;
         this.xrLabel1.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.InvoiceCount")});
         this.xrLabel1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
         this.xrLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
         this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(305.4893F, 0F);
         this.xrLabel1.Name = "xrLabel1";
         this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel1.SizeF = new System.Drawing.SizeF(159.2245F, 17.41667F);
         this.xrLabel1.StyleName = "FieldCaption";
         this.xrLabel1.StylePriority.UseBackColor = false;
         this.xrLabel1.StylePriority.UseFont = false;
         this.xrLabel1.StylePriority.UseForeColor = false;
         this.xrLabel1.StylePriority.UseTextAlignment = false;
         xrSummary4.FormatString = "{0:#,##0}";
         xrSummary4.IgnoreNullValues = true;
         xrSummary4.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
         this.xrLabel1.Summary = xrSummary4;
         this.xrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
         this.xrLabel1.WordWrap = false;
         // 
         // xrLabel41
         // 
         this.xrLabel41.BackColor = System.Drawing.Color.Silver;
         this.xrLabel41.CanGrow = false;
         this.xrLabel41.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.Qty")});
         this.xrLabel41.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
         this.xrLabel41.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
         this.xrLabel41.LocationFloat = new DevExpress.Utils.PointFloat(464.7139F, 0F);
         this.xrLabel41.Name = "xrLabel41";
         this.xrLabel41.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel41.SizeF = new System.Drawing.SizeF(113.8881F, 17.41667F);
         this.xrLabel41.StyleName = "FieldCaption";
         this.xrLabel41.StylePriority.UseBackColor = false;
         this.xrLabel41.StylePriority.UseFont = false;
         this.xrLabel41.StylePriority.UseForeColor = false;
         this.xrLabel41.StylePriority.UseTextAlignment = false;
         xrSummary5.FormatString = "{0:#,##0.000}";
         xrSummary5.IgnoreNullValues = true;
         xrSummary5.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
         this.xrLabel41.Summary = xrSummary5;
         this.xrLabel41.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
         this.xrLabel41.WordWrap = false;
         // 
         // xrLabel42
         // 
         this.xrLabel42.BackColor = System.Drawing.Color.Silver;
         this.xrLabel42.CanGrow = false;
         this.xrLabel42.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.Total")});
         this.xrLabel42.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
         this.xrLabel42.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
         this.xrLabel42.LocationFloat = new DevExpress.Utils.PointFloat(578.6018F, 0F);
         this.xrLabel42.Name = "xrLabel42";
         this.xrLabel42.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel42.SizeF = new System.Drawing.SizeF(146.398F, 17.41667F);
         this.xrLabel42.StyleName = "FieldCaption";
         this.xrLabel42.StylePriority.UseBackColor = false;
         this.xrLabel42.StylePriority.UseFont = false;
         this.xrLabel42.StylePriority.UseForeColor = false;
         this.xrLabel42.StylePriority.UseTextAlignment = false;
         xrSummary6.FormatString = "{0:#,##0.00}";
         xrSummary6.IgnoreNullValues = true;
         xrSummary6.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
         this.xrLabel42.Summary = xrSummary6;
         this.xrLabel42.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
         this.xrLabel42.WordWrap = false;
         // 
         // InvoiceType_GroupHeader
         // 
         this.InvoiceType_GroupHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel13,
            this.xrLabel14,
            this.xrLabel15,
            this.xrLabel16});
         this.InvoiceType_GroupHeader.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("InvoiceType", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
         this.InvoiceType_GroupHeader.HeightF = 20F;
         this.InvoiceType_GroupHeader.Name = "InvoiceType_GroupHeader";
         // 
         // xrLabel13
         // 
         this.xrLabel13.CanGrow = false;
         this.xrLabel13.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.Total")});
         this.xrLabel13.Font = new System.Drawing.Font("Times New Roman", 8F);
         this.xrLabel13.LocationFloat = new DevExpress.Utils.PointFloat(578.6018F, 1F);
         this.xrLabel13.Name = "xrLabel13";
         this.xrLabel13.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel13.SizeF = new System.Drawing.SizeF(146.398F, 18F);
         this.xrLabel13.StylePriority.UseFont = false;
         this.xrLabel13.StylePriority.UseTextAlignment = false;
         xrSummary7.FormatString = "{0:#,##0.00}";
         xrSummary7.IgnoreNullValues = true;
         xrSummary7.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
         this.xrLabel13.Summary = xrSummary7;
         this.xrLabel13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
         this.xrLabel13.WordWrap = false;
         // 
         // xrLabel14
         // 
         this.xrLabel14.CanGrow = false;
         this.xrLabel14.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.Qty")});
         this.xrLabel14.Font = new System.Drawing.Font("Times New Roman", 8F);
         this.xrLabel14.LocationFloat = new DevExpress.Utils.PointFloat(464.7139F, 1F);
         this.xrLabel14.Name = "xrLabel14";
         this.xrLabel14.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel14.SizeF = new System.Drawing.SizeF(113.8881F, 18F);
         this.xrLabel14.StylePriority.UseFont = false;
         this.xrLabel14.StylePriority.UseTextAlignment = false;
         xrSummary8.FormatString = "{0:#,##0.000}";
         xrSummary8.IgnoreNullValues = true;
         xrSummary8.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
         this.xrLabel14.Summary = xrSummary8;
         this.xrLabel14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
         this.xrLabel14.WordWrap = false;
         // 
         // xrLabel15
         // 
         this.xrLabel15.CanGrow = false;
         this.xrLabel15.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.InvoiceCount")});
         this.xrLabel15.Font = new System.Drawing.Font("Times New Roman", 8F);
         this.xrLabel15.LocationFloat = new DevExpress.Utils.PointFloat(305.4893F, 1F);
         this.xrLabel15.Name = "xrLabel15";
         this.xrLabel15.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel15.SizeF = new System.Drawing.SizeF(159.2245F, 18F);
         this.xrLabel15.StylePriority.UseFont = false;
         this.xrLabel15.StylePriority.UseTextAlignment = false;
         xrSummary9.FormatString = "{0:#,##0}";
         xrSummary9.IgnoreNullValues = true;
         xrSummary9.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
         this.xrLabel15.Summary = xrSummary9;
         this.xrLabel15.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
         this.xrLabel15.WordWrap = false;
         // 
         // xrLabel16
         // 
         this.xrLabel16.CanGrow = false;
         this.xrLabel16.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.Abbreviation")});
         this.xrLabel16.Font = new System.Drawing.Font("Times New Roman", 8F);
         this.xrLabel16.LocationFloat = new DevExpress.Utils.PointFloat(0.0001831055F, 1F);
         this.xrLabel16.Name = "xrLabel16";
         this.xrLabel16.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel16.SizeF = new System.Drawing.SizeF(305.4892F, 18F);
         this.xrLabel16.StylePriority.UseFont = false;
         this.xrLabel16.WordWrap = false;
         // 
         // pageFooterBand1
         // 
         this.pageFooterBand1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrPageInfo1});
         this.pageFooterBand1.HeightF = 20.58334F;
         this.pageFooterBand1.Name = "pageFooterBand1";
         // 
         // xrPageInfo1
         // 
         this.xrPageInfo1.Borders = DevExpress.XtraPrinting.BorderSide.Top;
         this.xrPageInfo1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
         this.xrPageInfo1.Format = "Σελίδα {0} από {1}";
         this.xrPageInfo1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
         this.xrPageInfo1.Name = "xrPageInfo1";
         this.xrPageInfo1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrPageInfo1.SizeF = new System.Drawing.SizeF(725F, 18.76271F);
         this.xrPageInfo1.StylePriority.UseBorders = false;
         this.xrPageInfo1.StylePriority.UseFont = false;
         this.xrPageInfo1.StylePriority.UseTextAlignment = false;
         this.xrPageInfo1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
         // 
         // reportHeaderBand1
         // 
         this.reportHeaderBand1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel29,
            this.xrLabel39,
            this.xrLabel40});
         this.reportHeaderBand1.HeightF = 51.79167F;
         this.reportHeaderBand1.Name = "reportHeaderBand1";
         // 
         // xrLabel29
         // 
         this.xrLabel29.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
         this.xrLabel29.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
         this.xrLabel29.LocationFloat = new DevExpress.Utils.PointFloat(0F, 2.478336F);
         this.xrLabel29.Name = "xrLabel29";
         this.xrLabel29.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel29.SizeF = new System.Drawing.SizeF(724.9998F, 22.58333F);
         this.xrLabel29.StyleName = "Title";
         this.xrLabel29.StylePriority.UseFont = false;
         this.xrLabel29.StylePriority.UseForeColor = false;
         this.xrLabel29.StylePriority.UseTextAlignment = false;
         this.xrLabel29.Text = "Ωριαίες Πωλήσεις ανά Τύπο Παραστατικού";
         this.xrLabel29.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
         // 
         // xrLabel39
         // 
         this.xrLabel39.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding(this.ToDate, "Text", " έως {0})")});
         this.xrLabel39.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
         this.xrLabel39.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
         this.xrLabel39.LocationFloat = new DevExpress.Utils.PointFloat(362.5102F, 25.06167F);
         this.xrLabel39.Name = "xrLabel39";
         this.xrLabel39.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel39.SizeF = new System.Drawing.SizeF(362.49F, 21.46F);
         this.xrLabel39.StyleName = "Title";
         this.xrLabel39.StylePriority.UseFont = false;
         this.xrLabel39.StylePriority.UseForeColor = false;
         this.xrLabel39.StylePriority.UseTextAlignment = false;
         this.xrLabel39.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
         // 
         // ToDate
         // 
         this.ToDate.Description = "To Date";
         this.ToDate.Name = "ToDate";
         this.ToDate.Type = typeof(System.DateTime);
         this.ToDate.ValueInfo = "2016-09-14";
         // 
         // xrLabel40
         // 
         this.xrLabel40.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding(this.FromDate, "Text", "(από {0}")});
         this.xrLabel40.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
         this.xrLabel40.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
         this.xrLabel40.LocationFloat = new DevExpress.Utils.PointFloat(0F, 25.06167F);
         this.xrLabel40.Name = "xrLabel40";
         this.xrLabel40.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel40.SizeF = new System.Drawing.SizeF(362.51F, 21.46F);
         this.xrLabel40.StyleName = "Title";
         this.xrLabel40.StylePriority.UseFont = false;
         this.xrLabel40.StylePriority.UseForeColor = false;
         this.xrLabel40.StylePriority.UseTextAlignment = false;
         xrSummary10.FormatString = "(από ";
         this.xrLabel40.Summary = xrSummary10;
         this.xrLabel40.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
         // 
         // FromDate
         // 
         this.FromDate.Description = "From Date";
         this.FromDate.Name = "FromDate";
         this.FromDate.Type = typeof(System.DateTime);
         this.FromDate.ValueInfo = "2016-09-08";
         // 
         // groupFooterBand1
         // 
         this.groupFooterBand1.HeightF = 1F;
         this.groupFooterBand1.Name = "groupFooterBand1";
         // 
         // reportFooterBand1
         // 
         this.reportFooterBand1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLine5,
            this.xrLabel31,
            this.xrLine6,
            this.xrLabel25,
            this.xrLabel26,
            this.xrLabel27});
         this.reportFooterBand1.HeightF = 30F;
         this.reportFooterBand1.Name = "reportFooterBand1";
         // 
         // xrLabel31
         // 
         this.xrLabel31.BackColor = System.Drawing.Color.LightGray;
         this.xrLabel31.CanGrow = false;
         this.xrLabel31.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.InvoiceCount")});
         this.xrLabel31.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
         this.xrLabel31.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
         this.xrLabel31.LocationFloat = new DevExpress.Utils.PointFloat(305.4893F, 7F);
         this.xrLabel31.Name = "xrLabel31";
         this.xrLabel31.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel31.SizeF = new System.Drawing.SizeF(159.2244F, 18F);
         this.xrLabel31.StyleName = "FieldCaption";
         this.xrLabel31.StylePriority.UseBackColor = false;
         this.xrLabel31.StylePriority.UseFont = false;
         this.xrLabel31.StylePriority.UseForeColor = false;
         this.xrLabel31.StylePriority.UseTextAlignment = false;
         xrSummary11.FormatString = "{0:#,##0}";
         xrSummary11.IgnoreNullValues = true;
         xrSummary11.Running = DevExpress.XtraReports.UI.SummaryRunning.Report;
         this.xrLabel31.Summary = xrSummary11;
         this.xrLabel31.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
         this.xrLabel31.WordWrap = false;
         // 
         // xrLine6
         // 
         this.xrLine6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
         this.xrLine6.LocationFloat = new DevExpress.Utils.PointFloat(0.0001831055F, 5F);
         this.xrLine6.Name = "xrLine6";
         this.xrLine6.SizeF = new System.Drawing.SizeF(725F, 2F);
         this.xrLine6.StylePriority.UseForeColor = false;
         // 
         // xrLabel25
         // 
         this.xrLabel25.BackColor = System.Drawing.Color.LightGray;
         this.xrLabel25.CanGrow = false;
         this.xrLabel25.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.Qty")});
         this.xrLabel25.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
         this.xrLabel25.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
         this.xrLabel25.LocationFloat = new DevExpress.Utils.PointFloat(464.7139F, 7F);
         this.xrLabel25.Name = "xrLabel25";
         this.xrLabel25.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel25.SizeF = new System.Drawing.SizeF(113.8878F, 18F);
         this.xrLabel25.StyleName = "FieldCaption";
         this.xrLabel25.StylePriority.UseBackColor = false;
         this.xrLabel25.StylePriority.UseFont = false;
         this.xrLabel25.StylePriority.UseForeColor = false;
         this.xrLabel25.StylePriority.UseTextAlignment = false;
         xrSummary12.FormatString = "{0:#,##0.000}";
         xrSummary12.IgnoreNullValues = true;
         xrSummary12.Running = DevExpress.XtraReports.UI.SummaryRunning.Report;
         this.xrLabel25.Summary = xrSummary12;
         this.xrLabel25.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
         this.xrLabel25.WordWrap = false;
         // 
         // xrLabel26
         // 
         this.xrLabel26.BackColor = System.Drawing.Color.LightGray;
         this.xrLabel26.CanGrow = false;
         this.xrLabel26.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.Total")});
         this.xrLabel26.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
         this.xrLabel26.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
         this.xrLabel26.LocationFloat = new DevExpress.Utils.PointFloat(578.6017F, 7F);
         this.xrLabel26.Name = "xrLabel26";
         this.xrLabel26.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel26.SizeF = new System.Drawing.SizeF(146.398F, 18F);
         this.xrLabel26.StyleName = "FieldCaption";
         this.xrLabel26.StylePriority.UseBackColor = false;
         this.xrLabel26.StylePriority.UseFont = false;
         this.xrLabel26.StylePriority.UseForeColor = false;
         this.xrLabel26.StylePriority.UseTextAlignment = false;
         xrSummary13.FormatString = "{0:#,##0.00}";
         xrSummary13.IgnoreNullValues = true;
         xrSummary13.Running = DevExpress.XtraReports.UI.SummaryRunning.Report;
         this.xrLabel26.Summary = xrSummary13;
         this.xrLabel26.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
         this.xrLabel26.WordWrap = false;
         // 
         // xrLabel27
         // 
         this.xrLabel27.BackColor = System.Drawing.Color.LightGray;
         this.xrLabel27.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
         this.xrLabel27.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
         this.xrLabel27.LocationFloat = new DevExpress.Utils.PointFloat(0F, 7F);
         this.xrLabel27.Name = "xrLabel27";
         this.xrLabel27.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel27.SizeF = new System.Drawing.SizeF(305.4892F, 18F);
         this.xrLabel27.StyleName = "FieldCaption";
         this.xrLabel27.StylePriority.UseBackColor = false;
         this.xrLabel27.StylePriority.UseFont = false;
         this.xrLabel27.StylePriority.UseForeColor = false;
         this.xrLabel27.Text = "Γενικά Σύνολα";
         // 
         // Title
         // 
         this.Title.BackColor = System.Drawing.Color.Transparent;
         this.Title.BorderColor = System.Drawing.Color.Black;
         this.Title.Borders = DevExpress.XtraPrinting.BorderSide.None;
         this.Title.BorderWidth = 1F;
         this.Title.Font = new System.Drawing.Font("Times New Roman", 24F);
         this.Title.ForeColor = System.Drawing.Color.Black;
         this.Title.Name = "Title";
         // 
         // FieldCaption
         // 
         this.FieldCaption.BackColor = System.Drawing.Color.Transparent;
         this.FieldCaption.BorderColor = System.Drawing.Color.Black;
         this.FieldCaption.Borders = DevExpress.XtraPrinting.BorderSide.None;
         this.FieldCaption.BorderWidth = 1F;
         this.FieldCaption.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
         this.FieldCaption.ForeColor = System.Drawing.Color.Black;
         this.FieldCaption.Name = "FieldCaption";
         // 
         // PageInfo
         // 
         this.PageInfo.BackColor = System.Drawing.Color.Transparent;
         this.PageInfo.BorderColor = System.Drawing.Color.Black;
         this.PageInfo.Borders = DevExpress.XtraPrinting.BorderSide.None;
         this.PageInfo.BorderWidth = 1F;
         this.PageInfo.Font = new System.Drawing.Font("Times New Roman", 8F);
         this.PageInfo.ForeColor = System.Drawing.Color.Black;
         this.PageInfo.Name = "PageInfo";
         // 
         // DataField
         // 
         this.DataField.BackColor = System.Drawing.Color.Transparent;
         this.DataField.BorderColor = System.Drawing.Color.Black;
         this.DataField.Borders = DevExpress.XtraPrinting.BorderSide.None;
         this.DataField.BorderWidth = 1F;
         this.DataField.Font = new System.Drawing.Font("Times New Roman", 8F);
         this.DataField.ForeColor = System.Drawing.Color.Black;
         this.DataField.Name = "DataField";
         this.DataField.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         // 
         // HourOfDay
         // 
         this.HourOfDay.Description = "Select Hour";
         dynamicListLookUpSettings1.DataAdapter = null;
         dynamicListLookUpSettings1.DataMember = "HourOfDay";
         dynamicListLookUpSettings1.DataSource = this.sqlDataSource1;
         dynamicListLookUpSettings1.DisplayMember = "HourOfDay";
         dynamicListLookUpSettings1.ValueMember = "HourOfDay";
         this.HourOfDay.LookUpSettings = dynamicListLookUpSettings1;
         this.HourOfDay.MultiValue = true;
         this.HourOfDay.Name = "HourOfDay";
         // 
         // InvoiceType
         // 
         this.InvoiceType.Description = "Select InvoiceType";
         dynamicListLookUpSettings2.DataAdapter = null;
         dynamicListLookUpSettings2.DataMember = "InvoiceTypes";
         dynamicListLookUpSettings2.DataSource = this.sqlDataSource1;
         dynamicListLookUpSettings2.DisplayMember = "Abbreviation";
         dynamicListLookUpSettings2.ValueMember = "Type";
         this.InvoiceType.LookUpSettings = dynamicListLookUpSettings2;
         this.InvoiceType.MultiValue = true;
         this.InvoiceType.Name = "InvoiceType";
         this.InvoiceType.Type = typeof(short);
         // 
         // Department
         // 
         this.Department.Description = "Select Department";
         dynamicListLookUpSettings3.DataAdapter = null;
         dynamicListLookUpSettings3.DataMember = "Departments";
         dynamicListLookUpSettings3.DataSource = this.sqlDataSource1;
         dynamicListLookUpSettings3.DisplayMember = "Description";
         dynamicListLookUpSettings3.ValueMember = "Id";
         this.Department.LookUpSettings = dynamicListLookUpSettings3;
         this.Department.MultiValue = true;
         this.Department.Name = "Department";
         this.Department.Type = typeof(long);
         // 
         // PosInfo
         // 
         this.PosInfo.Description = "Select POS";
         dynamicListLookUpSettings4.DataAdapter = null;
         dynamicListLookUpSettings4.DataMember = "Posinfos";
         dynamicListLookUpSettings4.DataSource = this.sqlDataSource1;
         dynamicListLookUpSettings4.DisplayMember = "Description";
         dynamicListLookUpSettings4.ValueMember = "Id";
         this.PosInfo.LookUpSettings = dynamicListLookUpSettings4;
         this.PosInfo.MultiValue = true;
         this.PosInfo.Name = "PosInfo";
         this.PosInfo.Type = typeof(long);
         // 
         // Department_GroupHeader
         // 
         this.Department_GroupHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel5});
         this.Department_GroupHeader.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("DepartmentId", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
         this.Department_GroupHeader.HeightF = 16F;
         this.Department_GroupHeader.Level = 4;
         this.Department_GroupHeader.Name = "Department_GroupHeader";
         // 
         // xrLabel5
         // 
         this.xrLabel5.BackColor = System.Drawing.Color.Gray;
         this.xrLabel5.Borders = DevExpress.XtraPrinting.BorderSide.None;
         this.xrLabel5.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.DepartmentDescription", "Department: {0}")});
         this.xrLabel5.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
         this.xrLabel5.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
         this.xrLabel5.Name = "xrLabel5";
         this.xrLabel5.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel5.SizeF = new System.Drawing.SizeF(725.0002F, 16F);
         this.xrLabel5.StyleName = "DataField";
         this.xrLabel5.StylePriority.UseBackColor = false;
         this.xrLabel5.StylePriority.UseBorders = false;
         this.xrLabel5.StylePriority.UseFont = false;
         this.xrLabel5.StylePriority.UseTextAlignment = false;
         this.xrLabel5.Text = "xrLabel2";
         this.xrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
         // 
         // POS_GroupHeader
         // 
         this.POS_GroupHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel6});
         this.POS_GroupHeader.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("PosInfoId", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
         this.POS_GroupHeader.HeightF = 17F;
         this.POS_GroupHeader.Level = 3;
         this.POS_GroupHeader.Name = "POS_GroupHeader";
         // 
         // xrLabel6
         // 
         this.xrLabel6.BackColor = System.Drawing.Color.DarkGray;
         this.xrLabel6.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.PosInfoDescription", "POS : {0}")});
         this.xrLabel6.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold);
         this.xrLabel6.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
         this.xrLabel6.Name = "xrLabel6";
         this.xrLabel6.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel6.SizeF = new System.Drawing.SizeF(725.0002F, 17F);
         this.xrLabel6.StyleName = "DataField";
         this.xrLabel6.StylePriority.UseBackColor = false;
         this.xrLabel6.StylePriority.UseFont = false;
         this.xrLabel6.StylePriority.UseTextAlignment = false;
         this.xrLabel6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
         this.xrLabel6.WordWrap = false;
         // 
         // Department_GroupFooter
         // 
         this.Department_GroupFooter.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLine4,
            this.xrLabel36,
            this.xrLabel32,
            this.xrLine3,
            this.xrLabel33,
            this.xrLabel34});
         this.Department_GroupFooter.HeightF = 30.20833F;
         this.Department_GroupFooter.Level = 4;
         this.Department_GroupFooter.Name = "Department_GroupFooter";
         // 
         // xrLabel36
         // 
         this.xrLabel36.CanGrow = false;
         this.xrLabel36.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.InvoiceCount")});
         this.xrLabel36.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
         this.xrLabel36.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
         this.xrLabel36.LocationFloat = new DevExpress.Utils.PointFloat(305.4892F, 3.979167F);
         this.xrLabel36.Name = "xrLabel36";
         this.xrLabel36.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel36.SizeF = new System.Drawing.SizeF(159.2247F, 18F);
         this.xrLabel36.StyleName = "FieldCaption";
         this.xrLabel36.StylePriority.UseFont = false;
         this.xrLabel36.StylePriority.UseForeColor = false;
         this.xrLabel36.StylePriority.UseTextAlignment = false;
         xrSummary14.FormatString = "{0:#,##0}";
         xrSummary14.IgnoreNullValues = true;
         xrSummary14.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
         this.xrLabel36.Summary = xrSummary14;
         this.xrLabel36.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
         this.xrLabel36.WordWrap = false;
         // 
         // xrLabel32
         // 
         this.xrLabel32.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
         this.xrLabel32.LocationFloat = new DevExpress.Utils.PointFloat(0F, 3.979167F);
         this.xrLabel32.Name = "xrLabel32";
         this.xrLabel32.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel32.SizeF = new System.Drawing.SizeF(305.4894F, 18F);
         this.xrLabel32.StylePriority.UseFont = false;
         this.xrLabel32.StylePriority.UseTextAlignment = false;
         this.xrLabel32.Text = "Σύνολα Department : ";
         this.xrLabel32.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
         // 
         // xrLine3
         // 
         this.xrLine3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
         this.xrLine3.LocationFloat = new DevExpress.Utils.PointFloat(0F, 1.979167F);
         this.xrLine3.Name = "xrLine3";
         this.xrLine3.SizeF = new System.Drawing.SizeF(725.0002F, 2F);
         this.xrLine3.StylePriority.UseForeColor = false;
         // 
         // xrLabel33
         // 
         this.xrLabel33.CanGrow = false;
         this.xrLabel33.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.Qty")});
         this.xrLabel33.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
         this.xrLabel33.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
         this.xrLabel33.LocationFloat = new DevExpress.Utils.PointFloat(464.7139F, 3.979167F);
         this.xrLabel33.Name = "xrLabel33";
         this.xrLabel33.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel33.SizeF = new System.Drawing.SizeF(113.8878F, 18F);
         this.xrLabel33.StyleName = "FieldCaption";
         this.xrLabel33.StylePriority.UseFont = false;
         this.xrLabel33.StylePriority.UseForeColor = false;
         this.xrLabel33.StylePriority.UseTextAlignment = false;
         xrSummary15.FormatString = "{0:#,##0.000}";
         xrSummary15.IgnoreNullValues = true;
         xrSummary15.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
         this.xrLabel33.Summary = xrSummary15;
         this.xrLabel33.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
         this.xrLabel33.WordWrap = false;
         // 
         // xrLabel34
         // 
         this.xrLabel34.CanGrow = false;
         this.xrLabel34.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.Total")});
         this.xrLabel34.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
         this.xrLabel34.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
         this.xrLabel34.LocationFloat = new DevExpress.Utils.PointFloat(578.6017F, 3.979167F);
         this.xrLabel34.Name = "xrLabel34";
         this.xrLabel34.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel34.SizeF = new System.Drawing.SizeF(146.398F, 18F);
         this.xrLabel34.StyleName = "FieldCaption";
         this.xrLabel34.StylePriority.UseFont = false;
         this.xrLabel34.StylePriority.UseForeColor = false;
         this.xrLabel34.StylePriority.UseTextAlignment = false;
         xrSummary16.FormatString = "{0:#,##0.00}";
         xrSummary16.IgnoreNullValues = true;
         xrSummary16.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
         this.xrLabel34.Summary = xrSummary16;
         this.xrLabel34.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
         this.xrLabel34.WordWrap = false;
         // 
         // POS_GroupFooter
         // 
         this.POS_GroupFooter.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLine1,
            this.xrLabel35,
            this.xrLabel7,
            this.xrLabel28,
            this.xrLine7,
            this.xrLabel8});
         this.POS_GroupFooter.HeightF = 33.33333F;
         this.POS_GroupFooter.Level = 3;
         this.POS_GroupFooter.Name = "POS_GroupFooter";
         // 
         // xrLine1
         // 
         this.xrLine1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
         this.xrLine1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 23.16667F);
         this.xrLine1.Name = "xrLine1";
         this.xrLine1.SizeF = new System.Drawing.SizeF(725.0002F, 2F);
         this.xrLine1.StylePriority.UseForeColor = false;
         // 
         // xrLabel35
         // 
         this.xrLabel35.CanGrow = false;
         this.xrLabel35.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.InvoiceCount")});
         this.xrLabel35.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
         this.xrLabel35.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
         this.xrLabel35.LocationFloat = new DevExpress.Utils.PointFloat(305.4892F, 5.020832F);
         this.xrLabel35.Name = "xrLabel35";
         this.xrLabel35.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel35.SizeF = new System.Drawing.SizeF(159.2247F, 18F);
         this.xrLabel35.StyleName = "FieldCaption";
         this.xrLabel35.StylePriority.UseFont = false;
         this.xrLabel35.StylePriority.UseForeColor = false;
         this.xrLabel35.StylePriority.UseTextAlignment = false;
         xrSummary17.FormatString = "{0:#,##0}";
         xrSummary17.IgnoreNullValues = true;
         xrSummary17.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
         this.xrLabel35.Summary = xrSummary17;
         this.xrLabel35.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
         this.xrLabel35.WordWrap = false;
         // 
         // xrLabel7
         // 
         this.xrLabel7.CanGrow = false;
         this.xrLabel7.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.Total")});
         this.xrLabel7.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
         this.xrLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
         this.xrLabel7.LocationFloat = new DevExpress.Utils.PointFloat(578.6017F, 5.020833F);
         this.xrLabel7.Name = "xrLabel7";
         this.xrLabel7.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel7.SizeF = new System.Drawing.SizeF(146.398F, 18F);
         this.xrLabel7.StyleName = "FieldCaption";
         this.xrLabel7.StylePriority.UseFont = false;
         this.xrLabel7.StylePriority.UseForeColor = false;
         this.xrLabel7.StylePriority.UseTextAlignment = false;
         xrSummary18.FormatString = "{0:#,##0.00}";
         xrSummary18.IgnoreNullValues = true;
         xrSummary18.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
         this.xrLabel7.Summary = xrSummary18;
         this.xrLabel7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
         this.xrLabel7.WordWrap = false;
         // 
         // xrLabel28
         // 
         this.xrLabel28.CanGrow = false;
         this.xrLabel28.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.Qty")});
         this.xrLabel28.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
         this.xrLabel28.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
         this.xrLabel28.LocationFloat = new DevExpress.Utils.PointFloat(464.7137F, 5.020833F);
         this.xrLabel28.Name = "xrLabel28";
         this.xrLabel28.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel28.SizeF = new System.Drawing.SizeF(113.888F, 18F);
         this.xrLabel28.StyleName = "FieldCaption";
         this.xrLabel28.StylePriority.UseFont = false;
         this.xrLabel28.StylePriority.UseForeColor = false;
         this.xrLabel28.StylePriority.UseTextAlignment = false;
         xrSummary19.FormatString = "{0:#,##0.000}";
         xrSummary19.IgnoreNullValues = true;
         xrSummary19.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
         this.xrLabel28.Summary = xrSummary19;
         this.xrLabel28.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
         this.xrLabel28.WordWrap = false;
         // 
         // xrLine7
         // 
         this.xrLine7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
         this.xrLine7.LocationFloat = new DevExpress.Utils.PointFloat(0F, 3.020833F);
         this.xrLine7.Name = "xrLine7";
         this.xrLine7.SizeF = new System.Drawing.SizeF(725.0002F, 2F);
         this.xrLine7.StylePriority.UseForeColor = false;
         // 
         // xrLabel8
         // 
         this.xrLabel8.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
         this.xrLabel8.LocationFloat = new DevExpress.Utils.PointFloat(0F, 5.020833F);
         this.xrLabel8.Name = "xrLabel8";
         this.xrLabel8.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel8.SizeF = new System.Drawing.SizeF(305.4892F, 18F);
         this.xrLabel8.StylePriority.UseFont = false;
         this.xrLabel8.StylePriority.UseTextAlignment = false;
         this.xrLabel8.Text = "Σύνολα POS : ";
         this.xrLabel8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
         // 
         // GroupHeader1
         // 
         this.GroupHeader1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLine2,
            this.xrLabel44,
            this.xrLabel43,
            this.xrLabel4,
            this.xrLabel3});
         this.GroupHeader1.HeightF = 23F;
         this.GroupHeader1.Level = 2;
         this.GroupHeader1.Name = "GroupHeader1";
         this.GroupHeader1.RepeatEveryPage = true;
         // 
         // xrLine2
         // 
         this.xrLine2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
         this.xrLine2.LocationFloat = new DevExpress.Utils.PointFloat(0F, 21F);
         this.xrLine2.Name = "xrLine2";
         this.xrLine2.SizeF = new System.Drawing.SizeF(725F, 2F);
         this.xrLine2.StylePriority.UseForeColor = false;
         // 
         // xrLabel44
         // 
         this.xrLabel44.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
         this.xrLabel44.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
         this.xrLabel44.LocationFloat = new DevExpress.Utils.PointFloat(578.6017F, 3F);
         this.xrLabel44.Name = "xrLabel44";
         this.xrLabel44.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel44.SizeF = new System.Drawing.SizeF(146.398F, 18F);
         this.xrLabel44.StylePriority.UseFont = false;
         this.xrLabel44.StylePriority.UseForeColor = false;
         this.xrLabel44.StylePriority.UseTextAlignment = false;
         this.xrLabel44.Text = "Σύνολο";
         this.xrLabel44.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
         // 
         // xrLabel43
         // 
         this.xrLabel43.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
         this.xrLabel43.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
         this.xrLabel43.LocationFloat = new DevExpress.Utils.PointFloat(464.7137F, 3F);
         this.xrLabel43.Name = "xrLabel43";
         this.xrLabel43.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel43.SizeF = new System.Drawing.SizeF(113.8881F, 18F);
         this.xrLabel43.StylePriority.UseFont = false;
         this.xrLabel43.StylePriority.UseForeColor = false;
         this.xrLabel43.StylePriority.UseTextAlignment = false;
         this.xrLabel43.Text = "Ποσότητα";
         this.xrLabel43.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
         // 
         // xrLabel4
         // 
         this.xrLabel4.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
         this.xrLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
         this.xrLabel4.LocationFloat = new DevExpress.Utils.PointFloat(305.4892F, 3F);
         this.xrLabel4.Name = "xrLabel4";
         this.xrLabel4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel4.SizeF = new System.Drawing.SizeF(159.2245F, 18F);
         this.xrLabel4.StylePriority.UseFont = false;
         this.xrLabel4.StylePriority.UseForeColor = false;
         this.xrLabel4.StylePriority.UseTextAlignment = false;
         this.xrLabel4.Text = "Σύνολο Παραστατικών";
         this.xrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
         // 
         // xrLabel3
         // 
         this.xrLabel3.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
         this.xrLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
         this.xrLabel3.LocationFloat = new DevExpress.Utils.PointFloat(0F, 3F);
         this.xrLabel3.Name = "xrLabel3";
         this.xrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel3.SizeF = new System.Drawing.SizeF(305.4892F, 18F);
         this.xrLabel3.StylePriority.UseFont = false;
         this.xrLabel3.StylePriority.UseForeColor = false;
         this.xrLabel3.Text = "Παραστατικό";
         // 
         // xrLine4
         // 
         this.xrLine4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
         this.xrLine4.LocationFloat = new DevExpress.Utils.PointFloat(0F, 21.97917F);
         this.xrLine4.Name = "xrLine4";
         this.xrLine4.SizeF = new System.Drawing.SizeF(725.0002F, 2F);
         this.xrLine4.StylePriority.UseForeColor = false;
         // 
         // xrLine5
         // 
         this.xrLine5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
         this.xrLine5.LocationFloat = new DevExpress.Utils.PointFloat(0F, 25F);
         this.xrLine5.Name = "xrLine5";
         this.xrLine5.SizeF = new System.Drawing.SizeF(725F, 2F);
         this.xrLine5.StylePriority.UseForeColor = false;
         // 
         // HourlySalesPerInvoiceTypeTotal_OldDB
         // 
         this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.Hour_GroupHeader,
            this.InvoiceType_GroupHeader,
            this.pageFooterBand1,
            this.reportHeaderBand1,
            this.reportFooterBand1,
            this.Department_GroupHeader,
            this.POS_GroupHeader,
            this.Department_GroupFooter,
            this.POS_GroupFooter,
            this.GroupHeader1});
         this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.sqlDataSource1});
         this.DataMember = "Query_FastStart";
         this.DataSource = this.sqlDataSource1;
         this.FilterString = "[FODay] >= ?FromDate And [FODay] <= ?ToDate And [DepartmentId] In (?Department) A" +
    "nd [PosInfoId] In (?PosInfo) And [InvoiceType] In (?InvoiceType) And [HourOfDay]" +
    " In (?HourOfDay)";
         this.Margins = new System.Drawing.Printing.Margins(47, 55, 56, 37);
         this.PageHeight = 1169;
         this.PageWidth = 827;
         this.PaperKind = System.Drawing.Printing.PaperKind.A4;
         this.Parameters.AddRange(new DevExpress.XtraReports.Parameters.Parameter[] {
            this.FromDate,
            this.ToDate,
            this.Department,
            this.PosInfo,
            this.InvoiceType,
            this.HourOfDay});
         this.StyleSheet.AddRange(new DevExpress.XtraReports.UI.XRControlStyle[] {
            this.Title,
            this.FieldCaption,
            this.PageInfo,
            this.DataField});
         this.Version = "15.2";
         this.ParametersRequestBeforeShow += new System.EventHandler<DevExpress.XtraReports.Parameters.ParametersRequestEventArgs>(this.HourlySalesPerInvoiceTypeTotal_OldDB_ParametersRequestBeforeShow);
         this.DataSourceDemanded += new System.EventHandler<System.EventArgs>(this.HourlySalesPerInvoiceTypeTotal_OldDB_DataSourceDemanded);
         ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

      }

   #endregion

   ////////////////////////////////////////////////////////////////////////////////////////////////
   /// <summary>
   /// 
   /// </summary>
   /// <param name="sender"></param>
   /// <param name="e"></param>
   private void HourlySalesPerInvoiceTypeTotal_OldDB_DataSourceDemanded( object sender, EventArgs e )
      {
      int? dbVersion = Convert.ToInt32( WebConfigurationManager.AppSettings["DBVersion"] );

      if ( dbVersion != null && dbVersion == 1 )
         {
         //this.DataMember = "Query";
         this.DataSource = sqlDataSource1;
         this.DataMember = "Query";
         this.sqlDataSource1.RebuildResultSchema();
         }

      }

   ////////////////////////////////////////////////////////////////////////////////////////////////
   /// <summary>
   /// 
   /// </summary>
   /// <param name="sender"></param>
   /// <param name="e"></param>
   private void HourlySalesPerInvoiceTypeTotal_OldDB_ParametersRequestBeforeShow( object sender
                                 , DevExpress.XtraReports.Parameters.ParametersRequestEventArgs e )
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
               case "Department":
                  // select all values for parameter Department
                  paramItem.Parameter.Value = CommonTools.SetAllSelectedForMultiValueParameter<Int64>( sqlDataSource1, "Departments", "Id" );
                  break;

               case "PosInfo":
                  // select all values for parameter PosInfo
                  paramItem.Parameter.Value = CommonTools.SetAllSelectedForMultiValueParameter<Int64>( sqlDataSource1, "Posinfos", "Id" );
                  break;

               case "InvoiceType":
                  // select all values for parameter InvoiceType
                  paramItem.Parameter.Value = CommonTools.SetAllSelectedForMultiValueParameter<Int16>( sqlDataSource1, "InvoiceTypes", "Type" );
                  break;

               case "HourOfDay":
                  // select all values for parameter HourOfDay
                  paramItem.Parameter.Value = CommonTools.SetAllSelectedForMultiValueParameter( sqlDataSource1, "HourOfDay", "HourOfDay" );
                  break;

               default:
                  break;
               }

            }

         }

      }

   ////////////////////////////////////////////////////////////////////////////////////////////////
   }

