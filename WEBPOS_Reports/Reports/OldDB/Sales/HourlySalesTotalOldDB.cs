
using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Web.Configuration;
using WEBPOS_Reports.Helpers;

/// <summary>
/// Summary description for HourlySalesTotalOldDB
/// </summary>
public class HourlySalesTotalOldDB : DevExpress.XtraReports.UI.XtraReport
   {
   private DevExpress.XtraReports.UI.DetailBand Detail;
   private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
   private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
   private XRLabel xrLabel14;
   private XRLabel xrLabel15;
   private XRLabel xrLabel17;
   private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
   private GroupHeaderBand Hour_GroupHeader;
   private XRLabel xrLabel2;
   private PageFooterBand pageFooterBand1;
   private ReportHeaderBand reportHeaderBand1;
   private XRLabel xrLabel21;
   private GroupFooterBand groupFooterBand1;
   private ReportFooterBand reportFooterBand1;
   private XRLabel xrLabel25;
   private XRLabel xrLabel26;
   private XRLabel xrLabel27;
   private XRControlStyle Title;
   private XRControlStyle FieldCaption;
   private XRControlStyle PageInfo;
   private XRControlStyle DataField;
   private DevExpress.XtraReports.Parameters.Parameter FromFODay;
   private DevExpress.XtraReports.Parameters.Parameter UpToFODay;
   private XRPageInfo xrPageInfo3;
   private XRPageInfo xrPageInfo1;
   private DevExpress.XtraReports.Parameters.Parameter HourOfDay;
   private XRLine xrLine5;
   private XRLabel xrLabel7;
   private DevExpress.XtraReports.Parameters.Parameter DepartmentId;
   private DevExpress.XtraReports.Parameters.Parameter PosInfoId;
   private DevExpress.XtraReports.Parameters.Parameter InvoiceType;
   private GroupHeaderBand InvoiceType_GroupHeader;
   private XRLabel xrLabel28;
   private XRLabel xrLabel12;
   private XRLabel xrLabel29;
   private XRLabel xrLabel10;
   private XRLabel xrLabel9;
   private XRLabel xrLabel3;
   private XRLabel xrLabel4;
   private XRLabel xrLabel5;
   private XRLabel xrLabel6;
   private GroupHeaderBand GroupHeader1;
   private XRLine xrLine2;
   private XRLine xrLine1;
   private XRLabel xrLabel8;
   private XRLabel xrLabel11;
   private XRLabel xrLabel13;
   private XRLabel xrLabel18;

   /// <summary>
   /// Required designer variable.
   /// </summary>
   private System.ComponentModel.IContainer components = null;

   public HourlySalesTotalOldDB()
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
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HourlySalesTotalOldDB));
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
         DevExpress.XtraReports.Parameters.DynamicListLookUpSettings dynamicListLookUpSettings1 = new DevExpress.XtraReports.Parameters.DynamicListLookUpSettings();
         DevExpress.XtraReports.Parameters.DynamicListLookUpSettings dynamicListLookUpSettings2 = new DevExpress.XtraReports.Parameters.DynamicListLookUpSettings();
         DevExpress.XtraReports.Parameters.DynamicListLookUpSettings dynamicListLookUpSettings3 = new DevExpress.XtraReports.Parameters.DynamicListLookUpSettings();
         DevExpress.XtraReports.Parameters.DynamicListLookUpSettings dynamicListLookUpSettings4 = new DevExpress.XtraReports.Parameters.DynamicListLookUpSettings();
         DevExpress.XtraReports.UI.XRSummary xrSummary9 = new DevExpress.XtraReports.UI.XRSummary();
         DevExpress.XtraReports.UI.XRSummary xrSummary10 = new DevExpress.XtraReports.UI.XRSummary();
         DevExpress.XtraReports.UI.XRSummary xrSummary11 = new DevExpress.XtraReports.UI.XRSummary();
         this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
         this.Detail = new DevExpress.XtraReports.UI.DetailBand();
         this.xrLabel12 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel14 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel15 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel17 = new DevExpress.XtraReports.UI.XRLabel();
         this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
         this.xrPageInfo3 = new DevExpress.XtraReports.UI.XRPageInfo();
         this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
         this.Hour_GroupHeader = new DevExpress.XtraReports.UI.GroupHeaderBand();
         this.xrLabel29 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel10 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel9 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
         this.pageFooterBand1 = new DevExpress.XtraReports.UI.PageFooterBand();
         this.xrPageInfo1 = new DevExpress.XtraReports.UI.XRPageInfo();
         this.reportHeaderBand1 = new DevExpress.XtraReports.UI.ReportHeaderBand();
         this.xrLabel28 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel7 = new DevExpress.XtraReports.UI.XRLabel();
         this.UpToFODay = new DevExpress.XtraReports.Parameters.Parameter();
         this.xrLabel21 = new DevExpress.XtraReports.UI.XRLabel();
         this.FromFODay = new DevExpress.XtraReports.Parameters.Parameter();
         this.groupFooterBand1 = new DevExpress.XtraReports.UI.GroupFooterBand();
         this.reportFooterBand1 = new DevExpress.XtraReports.UI.ReportFooterBand();
         this.xrLine5 = new DevExpress.XtraReports.UI.XRLine();
         this.xrLabel25 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel26 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel27 = new DevExpress.XtraReports.UI.XRLabel();
         this.Title = new DevExpress.XtraReports.UI.XRControlStyle();
         this.FieldCaption = new DevExpress.XtraReports.UI.XRControlStyle();
         this.PageInfo = new DevExpress.XtraReports.UI.XRControlStyle();
         this.DataField = new DevExpress.XtraReports.UI.XRControlStyle();
         this.HourOfDay = new DevExpress.XtraReports.Parameters.Parameter();
         this.DepartmentId = new DevExpress.XtraReports.Parameters.Parameter();
         this.PosInfoId = new DevExpress.XtraReports.Parameters.Parameter();
         this.InvoiceType = new DevExpress.XtraReports.Parameters.Parameter();
         this.InvoiceType_GroupHeader = new DevExpress.XtraReports.UI.GroupHeaderBand();
         this.xrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel4 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel5 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel6 = new DevExpress.XtraReports.UI.XRLabel();
         this.GroupHeader1 = new DevExpress.XtraReports.UI.GroupHeaderBand();
         this.xrLine2 = new DevExpress.XtraReports.UI.XRLine();
         this.xrLine1 = new DevExpress.XtraReports.UI.XRLine();
         this.xrLabel8 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel11 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel13 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel18 = new DevExpress.XtraReports.UI.XRLabel();
         ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
         // 
         // sqlDataSource1
         // 
         this.sqlDataSource1.ConnectionName = "ReportConnection";
         this.sqlDataSource1.Name = "sqlDataSource1";
         customSqlQuery1.Name = "Query";
         queryParameter1.Name = "FromDate";
         queryParameter1.Type = typeof(DevExpress.DataAccess.Expression);
         queryParameter1.Value = new DevExpress.DataAccess.Expression("[Parameters.FromFODay]", typeof(System.DateTime));
         queryParameter2.Name = "UpToDate";
         queryParameter2.Type = typeof(DevExpress.DataAccess.Expression);
         queryParameter2.Value = new DevExpress.DataAccess.Expression("[Parameters.UpToFODay]", typeof(System.DateTime));
         customSqlQuery1.Parameters.Add(queryParameter1);
         customSqlQuery1.Parameters.Add(queryParameter2);
         customSqlQuery1.Sql = resources.GetString("customSqlQuery1.Sql");
         customSqlQuery2.Name = "Departments";
         customSqlQuery2.Sql = "Select Id, Description from Department";
         customSqlQuery3.Name = "HourOfDayLookUps";
         customSqlQuery3.Sql = "/* HourOfDay */\r\nSELECT Distinct CONVERT( VARCHAR(2), day, 108 ) HourOfDay\r\nFROM " +
    "Invoices\r\nOrder By HourOfDay Asc";
         customSqlQuery4.Name = "PosInfos";
         customSqlQuery4.Sql = "Select Id, Code, Description from PosInfo";
         customSqlQuery5.Name = "Query_FastStart";
         customSqlQuery5.Sql = "select * from invoices where id = -1";
         customSqlQuery6.Name = "InvoiceTypes";
         customSqlQuery6.Sql = "/* InvoiceTypes */\r\nSELECT DISTINCT Id, Abbreviation, Type\r\nFROM InvoiceTypes\r\nWH" +
    "ERE Type NOT IN (2,3,8,10,11,12) \r\nORDER BY Type\r\n";
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
            this.xrLabel12,
            this.xrLabel14,
            this.xrLabel15,
            this.xrLabel17});
         this.Detail.HeightF = 18F;
         this.Detail.Name = "Detail";
         this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
         this.Detail.StyleName = "DataField";
         this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
         this.Detail.Visible = false;
         // 
         // xrLabel12
         // 
         this.xrLabel12.CanGrow = false;
         this.xrLabel12.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.Abbreviation")});
         this.xrLabel12.Font = new System.Drawing.Font("Times New Roman", 8F);
         this.xrLabel12.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
         this.xrLabel12.Name = "xrLabel12";
         this.xrLabel12.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel12.SizeF = new System.Drawing.SizeF(305.4892F, 18F);
         this.xrLabel12.StylePriority.UseFont = false;
         this.xrLabel12.WordWrap = false;
         // 
         // xrLabel14
         // 
         this.xrLabel14.CanGrow = false;
         this.xrLabel14.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.InvoiceCount")});
         this.xrLabel14.Font = new System.Drawing.Font("Times New Roman", 8F);
         this.xrLabel14.LocationFloat = new DevExpress.Utils.PointFloat(305.4892F, 0F);
         this.xrLabel14.Name = "xrLabel14";
         this.xrLabel14.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel14.SizeF = new System.Drawing.SizeF(159.2245F, 18F);
         this.xrLabel14.StylePriority.UseFont = false;
         this.xrLabel14.StylePriority.UseTextAlignment = false;
         xrSummary1.IgnoreNullValues = true;
         xrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
         this.xrLabel14.Summary = xrSummary1;
         this.xrLabel14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
         this.xrLabel14.WordWrap = false;
         // 
         // xrLabel15
         // 
         this.xrLabel15.CanGrow = false;
         this.xrLabel15.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.Qty")});
         this.xrLabel15.Font = new System.Drawing.Font("Times New Roman", 8F);
         this.xrLabel15.LocationFloat = new DevExpress.Utils.PointFloat(464.7137F, 0F);
         this.xrLabel15.Name = "xrLabel15";
         this.xrLabel15.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel15.SizeF = new System.Drawing.SizeF(113.8881F, 18F);
         this.xrLabel15.StylePriority.UseFont = false;
         this.xrLabel15.StylePriority.UseTextAlignment = false;
         xrSummary2.FormatString = "{0:#,##0.00}";
         xrSummary2.IgnoreNullValues = true;
         xrSummary2.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
         this.xrLabel15.Summary = xrSummary2;
         this.xrLabel15.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
         this.xrLabel15.WordWrap = false;
         // 
         // xrLabel17
         // 
         this.xrLabel17.CanGrow = false;
         this.xrLabel17.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.Total")});
         this.xrLabel17.Font = new System.Drawing.Font("Times New Roman", 8F);
         this.xrLabel17.LocationFloat = new DevExpress.Utils.PointFloat(578.6017F, 0F);
         this.xrLabel17.Name = "xrLabel17";
         this.xrLabel17.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel17.SizeF = new System.Drawing.SizeF(146.398F, 18F);
         this.xrLabel17.StylePriority.UseFont = false;
         this.xrLabel17.StylePriority.UseTextAlignment = false;
         xrSummary3.FormatString = "{0:#,##0.00}";
         xrSummary3.IgnoreNullValues = true;
         xrSummary3.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
         this.xrLabel17.Summary = xrSummary3;
         this.xrLabel17.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
         this.xrLabel17.WordWrap = false;
         // 
         // TopMargin
         // 
         this.TopMargin.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrPageInfo3});
         this.TopMargin.HeightF = 55.83334F;
         this.TopMargin.Name = "TopMargin";
         this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
         this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
         // 
         // xrPageInfo3
         // 
         this.xrPageInfo3.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
         this.xrPageInfo3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
         this.xrPageInfo3.Format = "Ημερομηνία Εκτύπωσης : {0:dddd, d MMMM yyyy h:mm:ss tt}";
         this.xrPageInfo3.LocationFloat = new DevExpress.Utils.PointFloat(0F, 37.07063F);
         this.xrPageInfo3.Name = "xrPageInfo3";
         this.xrPageInfo3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrPageInfo3.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime;
         this.xrPageInfo3.SizeF = new System.Drawing.SizeF(725F, 18.76271F);
         this.xrPageInfo3.StylePriority.UseBorders = false;
         this.xrPageInfo3.StylePriority.UseFont = false;
         // 
         // BottomMargin
         // 
         this.BottomMargin.HeightF = 34.5417F;
         this.BottomMargin.Name = "BottomMargin";
         this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
         this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
         // 
         // Hour_GroupHeader
         // 
         this.Hour_GroupHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel29,
            this.xrLabel10,
            this.xrLabel9,
            this.xrLabel2});
         this.Hour_GroupHeader.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("HourOfDay", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
         this.Hour_GroupHeader.HeightF = 17.41667F;
         this.Hour_GroupHeader.Level = 1;
         this.Hour_GroupHeader.Name = "Hour_GroupHeader";
         // 
         // xrLabel29
         // 
         this.xrLabel29.BackColor = System.Drawing.Color.Silver;
         this.xrLabel29.CanGrow = false;
         this.xrLabel29.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.InvoiceCount")});
         this.xrLabel29.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
         this.xrLabel29.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
         this.xrLabel29.LocationFloat = new DevExpress.Utils.PointFloat(305.4892F, 0F);
         this.xrLabel29.Name = "xrLabel29";
         this.xrLabel29.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel29.SizeF = new System.Drawing.SizeF(159.2245F, 17.41667F);
         this.xrLabel29.StyleName = "FieldCaption";
         this.xrLabel29.StylePriority.UseBackColor = false;
         this.xrLabel29.StylePriority.UseFont = false;
         this.xrLabel29.StylePriority.UseForeColor = false;
         this.xrLabel29.StylePriority.UseTextAlignment = false;
         xrSummary4.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
         this.xrLabel29.Summary = xrSummary4;
         this.xrLabel29.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
         this.xrLabel29.WordWrap = false;
         // 
         // xrLabel10
         // 
         this.xrLabel10.BackColor = System.Drawing.Color.Silver;
         this.xrLabel10.CanGrow = false;
         this.xrLabel10.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.Total")});
         this.xrLabel10.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
         this.xrLabel10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
         this.xrLabel10.LocationFloat = new DevExpress.Utils.PointFloat(578.6017F, 0F);
         this.xrLabel10.Name = "xrLabel10";
         this.xrLabel10.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel10.SizeF = new System.Drawing.SizeF(146.398F, 17.41667F);
         this.xrLabel10.StyleName = "FieldCaption";
         this.xrLabel10.StylePriority.UseBackColor = false;
         this.xrLabel10.StylePriority.UseFont = false;
         this.xrLabel10.StylePriority.UseForeColor = false;
         this.xrLabel10.StylePriority.UseTextAlignment = false;
         xrSummary5.FormatString = "{0:#,##0.00}";
         xrSummary5.IgnoreNullValues = true;
         xrSummary5.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
         this.xrLabel10.Summary = xrSummary5;
         this.xrLabel10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
         this.xrLabel10.WordWrap = false;
         // 
         // xrLabel9
         // 
         this.xrLabel9.BackColor = System.Drawing.Color.Silver;
         this.xrLabel9.CanGrow = false;
         this.xrLabel9.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.Qty")});
         this.xrLabel9.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
         this.xrLabel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
         this.xrLabel9.LocationFloat = new DevExpress.Utils.PointFloat(464.7137F, 0F);
         this.xrLabel9.Name = "xrLabel9";
         this.xrLabel9.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel9.SizeF = new System.Drawing.SizeF(113.8881F, 17.41667F);
         this.xrLabel9.StyleName = "FieldCaption";
         this.xrLabel9.StylePriority.UseBackColor = false;
         this.xrLabel9.StylePriority.UseFont = false;
         this.xrLabel9.StylePriority.UseForeColor = false;
         this.xrLabel9.StylePriority.UseTextAlignment = false;
         xrSummary6.FormatString = "{0:#,##0.00}";
         xrSummary6.IgnoreNullValues = true;
         xrSummary6.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
         this.xrLabel9.Summary = xrSummary6;
         this.xrLabel9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
         this.xrLabel9.WordWrap = false;
         // 
         // xrLabel2
         // 
         this.xrLabel2.BackColor = System.Drawing.Color.Silver;
         this.xrLabel2.CanGrow = false;
         this.xrLabel2.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.HourOfDay", "Hour : {0}")});
         this.xrLabel2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold);
         this.xrLabel2.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
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
         // pageFooterBand1
         // 
         this.pageFooterBand1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrPageInfo1});
         this.pageFooterBand1.HeightF = 20.66663F;
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
            this.xrLabel28,
            this.xrLabel7,
            this.xrLabel21});
         this.reportHeaderBand1.HeightF = 52.04166F;
         this.reportHeaderBand1.Name = "reportHeaderBand1";
         // 
         // xrLabel28
         // 
         this.xrLabel28.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
         this.xrLabel28.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
         this.xrLabel28.LocationFloat = new DevExpress.Utils.PointFloat(0F, 4F);
         this.xrLabel28.Name = "xrLabel28";
         this.xrLabel28.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel28.SizeF = new System.Drawing.SizeF(724.9998F, 22.58333F);
         this.xrLabel28.StyleName = "Title";
         this.xrLabel28.StylePriority.UseFont = false;
         this.xrLabel28.StylePriority.UseForeColor = false;
         this.xrLabel28.StylePriority.UseTextAlignment = false;
         this.xrLabel28.Text = "Ωριαίες Πωλήσεις ανά Τύπο Παραστατικού";
         this.xrLabel28.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
         // 
         // xrLabel7
         // 
         this.xrLabel7.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding(this.UpToFODay, "Text", " έως {0})")});
         this.xrLabel7.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
         this.xrLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
         this.xrLabel7.LocationFloat = new DevExpress.Utils.PointFloat(362.5103F, 26.58333F);
         this.xrLabel7.Name = "xrLabel7";
         this.xrLabel7.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel7.SizeF = new System.Drawing.SizeF(362.49F, 21.46F);
         this.xrLabel7.StyleName = "Title";
         this.xrLabel7.StylePriority.UseFont = false;
         this.xrLabel7.StylePriority.UseForeColor = false;
         this.xrLabel7.StylePriority.UseTextAlignment = false;
         this.xrLabel7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
         // 
         // UpToFODay
         // 
         this.UpToFODay.Description = "UpTo Date";
         this.UpToFODay.Name = "UpToFODay";
         this.UpToFODay.Type = typeof(System.DateTime);
         this.UpToFODay.ValueInfo = "2016-05-26";
         // 
         // xrLabel21
         // 
         this.xrLabel21.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding(this.FromFODay, "Text", "(από {0}")});
         this.xrLabel21.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
         this.xrLabel21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
         this.xrLabel21.LocationFloat = new DevExpress.Utils.PointFloat(0F, 26.58333F);
         this.xrLabel21.Name = "xrLabel21";
         this.xrLabel21.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel21.SizeF = new System.Drawing.SizeF(362.51F, 21.46F);
         this.xrLabel21.StyleName = "Title";
         this.xrLabel21.StylePriority.UseFont = false;
         this.xrLabel21.StylePriority.UseForeColor = false;
         this.xrLabel21.StylePriority.UseTextAlignment = false;
         this.xrLabel21.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
         // 
         // FromFODay
         // 
         this.FromFODay.Description = "From Date";
         this.FromFODay.Name = "FromFODay";
         this.FromFODay.Type = typeof(System.DateTime);
         this.FromFODay.ValueInfo = "2016-05-26";
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
            this.xrLabel25,
            this.xrLabel26,
            this.xrLabel27});
         this.reportFooterBand1.HeightF = 22.1667F;
         this.reportFooterBand1.Name = "reportFooterBand1";
         // 
         // xrLine5
         // 
         this.xrLine5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
         this.xrLine5.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
         this.xrLine5.Name = "xrLine5";
         this.xrLine5.SizeF = new System.Drawing.SizeF(725F, 2F);
         this.xrLine5.StylePriority.UseForeColor = false;
         // 
         // xrLabel25
         // 
         this.xrLabel25.BackColor = System.Drawing.Color.LightGray;
         this.xrLabel25.CanGrow = false;
         this.xrLabel25.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.Qty")});
         this.xrLabel25.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
         this.xrLabel25.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
         this.xrLabel25.LocationFloat = new DevExpress.Utils.PointFloat(464.7137F, 2F);
         this.xrLabel25.Name = "xrLabel25";
         this.xrLabel25.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel25.SizeF = new System.Drawing.SizeF(113.8881F, 18F);
         this.xrLabel25.StyleName = "FieldCaption";
         this.xrLabel25.StylePriority.UseBackColor = false;
         this.xrLabel25.StylePriority.UseFont = false;
         this.xrLabel25.StylePriority.UseForeColor = false;
         this.xrLabel25.StylePriority.UseTextAlignment = false;
         xrSummary7.FormatString = "{0:#,##0.00}";
         xrSummary7.IgnoreNullValues = true;
         xrSummary7.Running = DevExpress.XtraReports.UI.SummaryRunning.Report;
         this.xrLabel25.Summary = xrSummary7;
         this.xrLabel25.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
         this.xrLabel25.WordWrap = false;
         // 
         // xrLabel26
         // 
         this.xrLabel26.BackColor = System.Drawing.Color.LightGray;
         this.xrLabel26.CanGrow = false;
         this.xrLabel26.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.Total")});
         this.xrLabel26.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
         this.xrLabel26.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
         this.xrLabel26.LocationFloat = new DevExpress.Utils.PointFloat(578.6017F, 2F);
         this.xrLabel26.Name = "xrLabel26";
         this.xrLabel26.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel26.SizeF = new System.Drawing.SizeF(146.398F, 18F);
         this.xrLabel26.StyleName = "FieldCaption";
         this.xrLabel26.StylePriority.UseBackColor = false;
         this.xrLabel26.StylePriority.UseFont = false;
         this.xrLabel26.StylePriority.UseForeColor = false;
         this.xrLabel26.StylePriority.UseTextAlignment = false;
         xrSummary8.FormatString = "{0:#,##0.00}";
         xrSummary8.Running = DevExpress.XtraReports.UI.SummaryRunning.Report;
         this.xrLabel26.Summary = xrSummary8;
         this.xrLabel26.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
         this.xrLabel26.WordWrap = false;
         // 
         // xrLabel27
         // 
         this.xrLabel27.BackColor = System.Drawing.Color.LightGray;
         this.xrLabel27.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
         this.xrLabel27.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
         this.xrLabel27.LocationFloat = new DevExpress.Utils.PointFloat(0F, 2F);
         this.xrLabel27.Name = "xrLabel27";
         this.xrLabel27.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel27.SizeF = new System.Drawing.SizeF(464.7137F, 18F);
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
         // HourOfDay
         // 
         this.HourOfDay.Description = "Select Hour";
         dynamicListLookUpSettings1.DataAdapter = null;
         dynamicListLookUpSettings1.DataMember = "HourOfDayLookUps";
         dynamicListLookUpSettings1.DataSource = this.sqlDataSource1;
         dynamicListLookUpSettings1.DisplayMember = "HourOfDay";
         dynamicListLookUpSettings1.FilterString = null;
         dynamicListLookUpSettings1.ValueMember = "HourOfDay";
         this.HourOfDay.LookUpSettings = dynamicListLookUpSettings1;
         this.HourOfDay.MultiValue = true;
         this.HourOfDay.Name = "HourOfDay";
         this.HourOfDay.Type = typeof(short);
         // 
         // DepartmentId
         // 
         this.DepartmentId.Description = "Select Department";
         dynamicListLookUpSettings2.DataAdapter = null;
         dynamicListLookUpSettings2.DataMember = "Departments";
         dynamicListLookUpSettings2.DataSource = this.sqlDataSource1;
         dynamicListLookUpSettings2.DisplayMember = "Description";
         dynamicListLookUpSettings2.FilterString = null;
         dynamicListLookUpSettings2.ValueMember = "Id";
         this.DepartmentId.LookUpSettings = dynamicListLookUpSettings2;
         this.DepartmentId.MultiValue = true;
         this.DepartmentId.Name = "DepartmentId";
         this.DepartmentId.Type = typeof(long);
         // 
         // PosInfoId
         // 
         this.PosInfoId.Description = "Select POS";
         dynamicListLookUpSettings3.DataAdapter = null;
         dynamicListLookUpSettings3.DataMember = "PosInfos";
         dynamicListLookUpSettings3.DataSource = this.sqlDataSource1;
         dynamicListLookUpSettings3.DisplayMember = "Description";
         dynamicListLookUpSettings3.FilterString = null;
         dynamicListLookUpSettings3.ValueMember = "Id";
         this.PosInfoId.LookUpSettings = dynamicListLookUpSettings3;
         this.PosInfoId.MultiValue = true;
         this.PosInfoId.Name = "PosInfoId";
         this.PosInfoId.Type = typeof(long);
         // 
         // InvoiceType
         // 
         this.InvoiceType.Description = "Select Invoice Type";
         dynamicListLookUpSettings4.DataAdapter = null;
         dynamicListLookUpSettings4.DataMember = "InvoiceTypes";
         dynamicListLookUpSettings4.DataSource = this.sqlDataSource1;
         dynamicListLookUpSettings4.DisplayMember = "Abbreviation";
         dynamicListLookUpSettings4.ValueMember = "Type";
         this.InvoiceType.LookUpSettings = dynamicListLookUpSettings4;
         this.InvoiceType.MultiValue = true;
         this.InvoiceType.Name = "InvoiceType";
         this.InvoiceType.Type = typeof(short);
         this.InvoiceType.ValueInfo = "0";
         // 
         // InvoiceType_GroupHeader
         // 
         this.InvoiceType_GroupHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel3,
            this.xrLabel4,
            this.xrLabel5,
            this.xrLabel6});
         this.InvoiceType_GroupHeader.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("InvoiceType", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
         this.InvoiceType_GroupHeader.HeightF = 18F;
         this.InvoiceType_GroupHeader.Name = "InvoiceType_GroupHeader";
         // 
         // xrLabel3
         // 
         this.xrLabel3.CanGrow = false;
         this.xrLabel3.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.Total")});
         this.xrLabel3.Font = new System.Drawing.Font("Times New Roman", 8F);
         this.xrLabel3.LocationFloat = new DevExpress.Utils.PointFloat(578.6017F, 0F);
         this.xrLabel3.Name = "xrLabel3";
         this.xrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel3.SizeF = new System.Drawing.SizeF(146.398F, 18F);
         this.xrLabel3.StylePriority.UseFont = false;
         this.xrLabel3.StylePriority.UseTextAlignment = false;
         xrSummary9.FormatString = "{0:#,##0.00}";
         xrSummary9.IgnoreNullValues = true;
         xrSummary9.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
         this.xrLabel3.Summary = xrSummary9;
         this.xrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
         this.xrLabel3.WordWrap = false;
         // 
         // xrLabel4
         // 
         this.xrLabel4.CanGrow = false;
         this.xrLabel4.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.Qty")});
         this.xrLabel4.Font = new System.Drawing.Font("Times New Roman", 8F);
         this.xrLabel4.LocationFloat = new DevExpress.Utils.PointFloat(464.7137F, 0F);
         this.xrLabel4.Name = "xrLabel4";
         this.xrLabel4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel4.SizeF = new System.Drawing.SizeF(113.8881F, 18F);
         this.xrLabel4.StylePriority.UseFont = false;
         this.xrLabel4.StylePriority.UseTextAlignment = false;
         xrSummary10.FormatString = "{0:#,##0.00}";
         xrSummary10.IgnoreNullValues = true;
         xrSummary10.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
         this.xrLabel4.Summary = xrSummary10;
         this.xrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
         this.xrLabel4.WordWrap = false;
         // 
         // xrLabel5
         // 
         this.xrLabel5.CanGrow = false;
         this.xrLabel5.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.InvoiceCount")});
         this.xrLabel5.Font = new System.Drawing.Font("Times New Roman", 8F);
         this.xrLabel5.LocationFloat = new DevExpress.Utils.PointFloat(305.4892F, 0F);
         this.xrLabel5.Name = "xrLabel5";
         this.xrLabel5.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel5.SizeF = new System.Drawing.SizeF(159.2245F, 18F);
         this.xrLabel5.StylePriority.UseFont = false;
         this.xrLabel5.StylePriority.UseTextAlignment = false;
         xrSummary11.IgnoreNullValues = true;
         xrSummary11.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
         this.xrLabel5.Summary = xrSummary11;
         this.xrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
         this.xrLabel5.WordWrap = false;
         // 
         // xrLabel6
         // 
         this.xrLabel6.CanGrow = false;
         this.xrLabel6.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.Abbreviation")});
         this.xrLabel6.Font = new System.Drawing.Font("Times New Roman", 8F);
         this.xrLabel6.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
         this.xrLabel6.Name = "xrLabel6";
         this.xrLabel6.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel6.SizeF = new System.Drawing.SizeF(305.4892F, 18F);
         this.xrLabel6.StylePriority.UseFont = false;
         this.xrLabel6.WordWrap = false;
         // 
         // GroupHeader1
         // 
         this.GroupHeader1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLine2,
            this.xrLine1,
            this.xrLabel8,
            this.xrLabel11,
            this.xrLabel13,
            this.xrLabel18});
         this.GroupHeader1.HeightF = 23F;
         this.GroupHeader1.Level = 2;
         this.GroupHeader1.Name = "GroupHeader1";
         // 
         // xrLine2
         // 
         this.xrLine2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
         this.xrLine2.LocationFloat = new DevExpress.Utils.PointFloat(0F, 21F);
         this.xrLine2.Name = "xrLine2";
         this.xrLine2.SizeF = new System.Drawing.SizeF(725F, 2F);
         this.xrLine2.StylePriority.UseForeColor = false;
         // 
         // xrLine1
         // 
         this.xrLine1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
         this.xrLine1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 1F);
         this.xrLine1.Name = "xrLine1";
         this.xrLine1.SizeF = new System.Drawing.SizeF(725F, 2F);
         this.xrLine1.StylePriority.UseForeColor = false;
         // 
         // xrLabel8
         // 
         this.xrLabel8.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
         this.xrLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
         this.xrLabel8.LocationFloat = new DevExpress.Utils.PointFloat(578.6017F, 3F);
         this.xrLabel8.Name = "xrLabel8";
         this.xrLabel8.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel8.SizeF = new System.Drawing.SizeF(146.398F, 18F);
         this.xrLabel8.StylePriority.UseFont = false;
         this.xrLabel8.StylePriority.UseForeColor = false;
         this.xrLabel8.StylePriority.UseTextAlignment = false;
         this.xrLabel8.Text = "Σύνολο";
         this.xrLabel8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
         // 
         // xrLabel11
         // 
         this.xrLabel11.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
         this.xrLabel11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
         this.xrLabel11.LocationFloat = new DevExpress.Utils.PointFloat(464.7137F, 3F);
         this.xrLabel11.Name = "xrLabel11";
         this.xrLabel11.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel11.SizeF = new System.Drawing.SizeF(113.8881F, 18F);
         this.xrLabel11.StylePriority.UseFont = false;
         this.xrLabel11.StylePriority.UseForeColor = false;
         this.xrLabel11.StylePriority.UseTextAlignment = false;
         this.xrLabel11.Text = "Ποσότητα";
         this.xrLabel11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
         // 
         // xrLabel13
         // 
         this.xrLabel13.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
         this.xrLabel13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
         this.xrLabel13.LocationFloat = new DevExpress.Utils.PointFloat(305.4892F, 3F);
         this.xrLabel13.Name = "xrLabel13";
         this.xrLabel13.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel13.SizeF = new System.Drawing.SizeF(159.2245F, 18F);
         this.xrLabel13.StylePriority.UseFont = false;
         this.xrLabel13.StylePriority.UseForeColor = false;
         this.xrLabel13.StylePriority.UseTextAlignment = false;
         this.xrLabel13.Text = "Σύνολο Παραστατικών";
         this.xrLabel13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
         // 
         // xrLabel18
         // 
         this.xrLabel18.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
         this.xrLabel18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
         this.xrLabel18.LocationFloat = new DevExpress.Utils.PointFloat(0F, 3F);
         this.xrLabel18.Name = "xrLabel18";
         this.xrLabel18.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel18.SizeF = new System.Drawing.SizeF(305.4892F, 18F);
         this.xrLabel18.StylePriority.UseFont = false;
         this.xrLabel18.StylePriority.UseForeColor = false;
         this.xrLabel18.Text = "Παραστατικό";
         // 
         // HourlySalesTotalOldDB
         // 
         this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.Hour_GroupHeader,
            this.pageFooterBand1,
            this.reportHeaderBand1,
            this.reportFooterBand1,
            this.InvoiceType_GroupHeader,
            this.GroupHeader1});
         this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.sqlDataSource1});
         this.DataMember = "Query";
         this.DataSource = this.sqlDataSource1;
         this.FilterString = "[FODay] >= ?FromFODay And [FODay] <= ?UpToFODay And [DepartmentId] In (?Departmen" +
    "tId) And [PosInfoId] In (?PosInfoId) And [InvoiceType] In (?InvoiceType) And [Ho" +
    "urOfDay] In (?HourOfDay)";
         this.Margins = new System.Drawing.Printing.Margins(50, 52, 56, 35);
         this.PageHeight = 1169;
         this.PageWidth = 827;
         this.PaperKind = System.Drawing.Printing.PaperKind.A4;
         this.Parameters.AddRange(new DevExpress.XtraReports.Parameters.Parameter[] {
            this.FromFODay,
            this.UpToFODay,
            this.DepartmentId,
            this.PosInfoId,
            this.InvoiceType,
            this.HourOfDay});
         this.StyleSheet.AddRange(new DevExpress.XtraReports.UI.XRControlStyle[] {
            this.Title,
            this.FieldCaption,
            this.PageInfo,
            this.DataField});
         this.Version = "15.2";
         this.ParametersRequestBeforeShow += new System.EventHandler<DevExpress.XtraReports.Parameters.ParametersRequestEventArgs>(this.HourlySalesTotalOldDB_ParametersRequestBeforeShow);
         this.DataSourceDemanded += new System.EventHandler<System.EventArgs>(this.HourlySalesTotalOldDB_DataSourceDemanded);
         ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

      }

   #endregion

   ////////////////////////////////////////////////////////////////////////////////////////////////
   /// <summary>
   /// 
   /// </summary>
   /// <param name="sender"></param>
   /// <param name="e"></param>
   private void HourlySalesTotalOldDB_DataSourceDemanded( object sender, EventArgs e )
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
   private void HourlySalesTotalOldDB_ParametersRequestBeforeShow( object sender
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
               case "DepartmentId":
                  // select all values for parameter Department
                  paramItem.Parameter.Value = CommonTools.SetAllSelectedForMultiValueParameter<Int64>( sqlDataSource1, "Departments", "Id" );
                  break;

               case "PosInfoId":
                  // select all values for parameter PosInfo
                  paramItem.Parameter.Value = CommonTools.SetAllSelectedForMultiValueParameter<Int64>( sqlDataSource1, "PosInfos", "Id" );
                  break;

               case "InvoiceType":
                  // select all values for parameter InvoiceType
                  paramItem.Parameter.Value = CommonTools.SetAllSelectedForMultiValueParameter<Int16>( sqlDataSource1, "InvoiceTypes", "Type" );
                  break;

               case "HourOfDay":
                  // select all values for parameter HourOfDay
                  paramItem.Parameter.Value = CommonTools.SetAllSelectedForMultiValueParameter( sqlDataSource1, "HourOfDayLookUps", "HourOfDay" );
                  break;

               default:
                  break;
               }

            }

         }

      }

   ////////////////////////////////////////////////////////////////////////////////////////////////
   }

