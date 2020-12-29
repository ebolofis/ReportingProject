
using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Web.Configuration;

/// <summary>
/// Summary description for SalesPerPricelistOldDB
/// </summary>
public class SalesPerPricelistOldDB : DevExpress.XtraReports.UI.XtraReport
   {
   private DevExpress.XtraReports.UI.DetailBand Detail;
   private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
   private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
   private XRLabel xrLabel12;
   private XRLabel xrLabel13;
   private XRLabel xrLabel14;
   private XRLabel xrLabel15;
   private XRLabel xrLabel17;
   private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
   private GroupHeaderBand groupHeaderBand1;
   private XRLabel xrLabel2;
   private PageFooterBand pageFooterBand1;
   private ReportHeaderBand reportHeaderBand1;
   private XRLabel xrLabel21;
   private GroupFooterBand groupFooterBand1;
   private GroupFooterBand groupFooterBand2;
   private XRLabel xrLabel22;
   private XRLabel xrLabel23;
   private XRLabel xrLabel24;
   private ReportFooterBand reportFooterBand1;
   private XRLabel xrLabel25;
   private XRLabel xrLabel26;
   private XRLabel xrLabel27;
   private XRControlStyle Title;
   private XRControlStyle FieldCaption;
   private XRControlStyle PageInfo;
   private XRControlStyle DataField;
   private XRLine xrLine2;
   private XRLine xrLine1;
   private XRLabel xrLabel8;
   private XRLabel xrLabel6;
   private XRLabel xrLabel5;
   private XRLabel xrLabel4;
   private XRLabel xrLabel3;
   private GroupHeaderBand groupHeaderBand2;
   private DevExpress.XtraReports.Parameters.Parameter FromFODay;
   private DevExpress.XtraReports.Parameters.Parameter UpToFODay;
   private XRPageInfo xrPageInfo3;
   private XRPageInfo xrPageInfo1;
   private XRLabel xrLabel10;
   private XRLabel xrLabel9;
   private XRLabel xrLabel1;
   private DevExpress.XtraReports.Parameters.Parameter PricelistId;
   private XRLine xrLine4;
   private XRLine xrLine3;
   private XRControlStyle xrControlStyle1;
   private XRLabel xrLabel7;

   /// <summary>
   /// Required designer variable.
   /// </summary>
   private System.ComponentModel.IContainer components = null;

   public SalesPerPricelistOldDB()
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
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalesPerPricelistOldDB));
         DevExpress.DataAccess.Sql.CustomSqlQuery customSqlQuery2 = new DevExpress.DataAccess.Sql.CustomSqlQuery();
         DevExpress.DataAccess.Sql.CustomSqlQuery customSqlQuery3 = new DevExpress.DataAccess.Sql.CustomSqlQuery();
         DevExpress.XtraReports.UI.XRSummary xrSummary1 = new DevExpress.XtraReports.UI.XRSummary();
         DevExpress.XtraReports.UI.XRSummary xrSummary2 = new DevExpress.XtraReports.UI.XRSummary();
         DevExpress.XtraReports.UI.XRSummary xrSummary3 = new DevExpress.XtraReports.UI.XRSummary();
         DevExpress.XtraReports.UI.XRSummary xrSummary4 = new DevExpress.XtraReports.UI.XRSummary();
         DevExpress.XtraReports.UI.XRSummary xrSummary5 = new DevExpress.XtraReports.UI.XRSummary();
         DevExpress.XtraReports.UI.XRSummary xrSummary6 = new DevExpress.XtraReports.UI.XRSummary();
         DevExpress.XtraReports.Parameters.DynamicListLookUpSettings dynamicListLookUpSettings1 = new DevExpress.XtraReports.Parameters.DynamicListLookUpSettings();
         this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
         this.Detail = new DevExpress.XtraReports.UI.DetailBand();
         this.xrLabel12 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel13 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel14 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel15 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel17 = new DevExpress.XtraReports.UI.XRLabel();
         this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
         this.xrPageInfo3 = new DevExpress.XtraReports.UI.XRPageInfo();
         this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
         this.groupHeaderBand1 = new DevExpress.XtraReports.UI.GroupHeaderBand();
         this.xrLabel10 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel9 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
         this.pageFooterBand1 = new DevExpress.XtraReports.UI.PageFooterBand();
         this.xrPageInfo1 = new DevExpress.XtraReports.UI.XRPageInfo();
         this.reportHeaderBand1 = new DevExpress.XtraReports.UI.ReportHeaderBand();
         this.xrLabel21 = new DevExpress.XtraReports.UI.XRLabel();
         this.groupFooterBand1 = new DevExpress.XtraReports.UI.GroupFooterBand();
         this.groupFooterBand2 = new DevExpress.XtraReports.UI.GroupFooterBand();
         this.xrLine4 = new DevExpress.XtraReports.UI.XRLine();
         this.xrLabel22 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel23 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel24 = new DevExpress.XtraReports.UI.XRLabel();
         this.reportFooterBand1 = new DevExpress.XtraReports.UI.ReportFooterBand();
         this.xrLine3 = new DevExpress.XtraReports.UI.XRLine();
         this.xrLabel25 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel26 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel27 = new DevExpress.XtraReports.UI.XRLabel();
         this.Title = new DevExpress.XtraReports.UI.XRControlStyle();
         this.FieldCaption = new DevExpress.XtraReports.UI.XRControlStyle();
         this.PageInfo = new DevExpress.XtraReports.UI.XRControlStyle();
         this.DataField = new DevExpress.XtraReports.UI.XRControlStyle();
         this.xrLine2 = new DevExpress.XtraReports.UI.XRLine();
         this.xrLine1 = new DevExpress.XtraReports.UI.XRLine();
         this.xrLabel8 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel6 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel5 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel4 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
         this.groupHeaderBand2 = new DevExpress.XtraReports.UI.GroupHeaderBand();
         this.FromFODay = new DevExpress.XtraReports.Parameters.Parameter();
         this.UpToFODay = new DevExpress.XtraReports.Parameters.Parameter();
         this.PricelistId = new DevExpress.XtraReports.Parameters.Parameter();
         this.xrControlStyle1 = new DevExpress.XtraReports.UI.XRControlStyle();
         this.xrLabel7 = new DevExpress.XtraReports.UI.XRLabel();
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
         queryParameter2.Name = "ToDate";
         queryParameter2.Type = typeof(DevExpress.DataAccess.Expression);
         queryParameter2.Value = new DevExpress.DataAccess.Expression("[Parameters.UpToFODay]", typeof(System.DateTime));
         customSqlQuery1.Parameters.Add(queryParameter1);
         customSqlQuery1.Parameters.Add(queryParameter2);
         customSqlQuery1.Sql = resources.GetString("customSqlQuery1.Sql");
         customSqlQuery2.Name = "Query_FastStart";
         customSqlQuery2.Sql = "select * from invoices where id = -1";
         customSqlQuery3.Name = "PricelistLookups";
         customSqlQuery3.Sql = "SELECT Id,Description FROM Pricelist";
         this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            customSqlQuery1,
            customSqlQuery2,
            customSqlQuery3});
         this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
         // 
         // Detail
         // 
         this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel12,
            this.xrLabel13,
            this.xrLabel14,
            this.xrLabel15,
            this.xrLabel17});
         this.Detail.EvenStyleName = "xrControlStyle1";
         this.Detail.HeightF = 18F;
         this.Detail.Name = "Detail";
         this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
         this.Detail.StyleName = "DataField";
         this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
         // 
         // xrLabel12
         // 
         this.xrLabel12.CanGrow = false;
         this.xrLabel12.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.ProductCode")});
         this.xrLabel12.Font = new System.Drawing.Font("Times New Roman", 8F);
         this.xrLabel12.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
         this.xrLabel12.Name = "xrLabel12";
         this.xrLabel12.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel12.SizeF = new System.Drawing.SizeF(99.4584F, 18F);
         this.xrLabel12.StylePriority.UseFont = false;
         this.xrLabel12.WordWrap = false;
         // 
         // xrLabel13
         // 
         this.xrLabel13.CanGrow = false;
         this.xrLabel13.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.ProductDescription")});
         this.xrLabel13.Font = new System.Drawing.Font("Times New Roman", 8F);
         this.xrLabel13.LocationFloat = new DevExpress.Utils.PointFloat(99.4584F, 0F);
         this.xrLabel13.Name = "xrLabel13";
         this.xrLabel13.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel13.SizeF = new System.Drawing.SizeF(212.0308F, 18F);
         this.xrLabel13.StylePriority.UseFont = false;
         this.xrLabel13.WordWrap = false;
         // 
         // xrLabel14
         // 
         this.xrLabel14.CanGrow = false;
         this.xrLabel14.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.InvoiceCount")});
         this.xrLabel14.Font = new System.Drawing.Font("Times New Roman", 8F);
         this.xrLabel14.LocationFloat = new DevExpress.Utils.PointFloat(311.4892F, 0F);
         this.xrLabel14.Name = "xrLabel14";
         this.xrLabel14.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel14.SizeF = new System.Drawing.SizeF(113.2245F, 18F);
         this.xrLabel14.StylePriority.UseFont = false;
         this.xrLabel14.StylePriority.UseTextAlignment = false;
         this.xrLabel14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
         this.xrLabel14.WordWrap = false;
         // 
         // xrLabel15
         // 
         this.xrLabel15.CanGrow = false;
         this.xrLabel15.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.Qty")});
         this.xrLabel15.Font = new System.Drawing.Font("Times New Roman", 8F);
         this.xrLabel15.LocationFloat = new DevExpress.Utils.PointFloat(424.7137F, 0F);
         this.xrLabel15.Name = "xrLabel15";
         this.xrLabel15.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel15.SizeF = new System.Drawing.SizeF(110.1378F, 18F);
         this.xrLabel15.StylePriority.UseFont = false;
         this.xrLabel15.StylePriority.UseTextAlignment = false;
         this.xrLabel15.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
         this.xrLabel15.WordWrap = false;
         // 
         // xrLabel17
         // 
         this.xrLabel17.CanGrow = false;
         this.xrLabel17.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.Total", "{0:c2}")});
         this.xrLabel17.Font = new System.Drawing.Font("Times New Roman", 8F);
         this.xrLabel17.LocationFloat = new DevExpress.Utils.PointFloat(534.8516F, 0F);
         this.xrLabel17.Name = "xrLabel17";
         this.xrLabel17.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel17.SizeF = new System.Drawing.SizeF(115.1484F, 18F);
         this.xrLabel17.StylePriority.UseFont = false;
         this.xrLabel17.StylePriority.UseTextAlignment = false;
         this.xrLabel17.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
         this.xrLabel17.WordWrap = false;
         // 
         // TopMargin
         // 
         this.TopMargin.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrPageInfo3});
         this.TopMargin.HeightF = 53.00002F;
         this.TopMargin.Name = "TopMargin";
         this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
         this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
         // 
         // xrPageInfo3
         // 
         this.xrPageInfo3.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
         this.xrPageInfo3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
         this.xrPageInfo3.Format = "Ημερομηνία Εκτύπωσης : {0:dddd, d MMMM yyyy h:mm:ss tt}";
         this.xrPageInfo3.LocationFloat = new DevExpress.Utils.PointFloat(0F, 38.2373F);
         this.xrPageInfo3.Name = "xrPageInfo3";
         this.xrPageInfo3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrPageInfo3.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime;
         this.xrPageInfo3.SizeF = new System.Drawing.SizeF(650F, 14.76271F);
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
         // groupHeaderBand1
         // 
         this.groupHeaderBand1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel10,
            this.xrLabel9,
            this.xrLabel1,
            this.xrLabel2});
         this.groupHeaderBand1.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("PricelistId", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
         this.groupHeaderBand1.HeightF = 17.41667F;
         this.groupHeaderBand1.Level = 1;
         this.groupHeaderBand1.Name = "groupHeaderBand1";
         // 
         // xrLabel10
         // 
         this.xrLabel10.BackColor = System.Drawing.Color.Silver;
         this.xrLabel10.CanGrow = false;
         this.xrLabel10.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.Total", "{0:C2}")});
         this.xrLabel10.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
         this.xrLabel10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
         this.xrLabel10.LocationFloat = new DevExpress.Utils.PointFloat(534.8516F, 0F);
         this.xrLabel10.Name = "xrLabel10";
         this.xrLabel10.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel10.SizeF = new System.Drawing.SizeF(115.1484F, 17.41667F);
         this.xrLabel10.StyleName = "FieldCaption";
         this.xrLabel10.StylePriority.UseBackColor = false;
         this.xrLabel10.StylePriority.UseFont = false;
         this.xrLabel10.StylePriority.UseForeColor = false;
         this.xrLabel10.StylePriority.UseTextAlignment = false;
         xrSummary1.FormatString = "{0:C2}";
         xrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
         this.xrLabel10.Summary = xrSummary1;
         this.xrLabel10.Text = "xrLabel23";
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
         this.xrLabel9.LocationFloat = new DevExpress.Utils.PointFloat(424.7137F, 0F);
         this.xrLabel9.Name = "xrLabel9";
         this.xrLabel9.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel9.SizeF = new System.Drawing.SizeF(110.1378F, 17.41667F);
         this.xrLabel9.StyleName = "FieldCaption";
         this.xrLabel9.StylePriority.UseBackColor = false;
         this.xrLabel9.StylePriority.UseFont = false;
         this.xrLabel9.StylePriority.UseForeColor = false;
         this.xrLabel9.StylePriority.UseTextAlignment = false;
         xrSummary2.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
         this.xrLabel9.Summary = xrSummary2;
         this.xrLabel9.Text = "xrLabel22";
         this.xrLabel9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
         this.xrLabel9.WordWrap = false;
         // 
         // xrLabel1
         // 
         this.xrLabel1.BackColor = System.Drawing.Color.Silver;
         this.xrLabel1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
         this.xrLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
         this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(315.4893F, 0F);
         this.xrLabel1.Name = "xrLabel1";
         this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel1.SizeF = new System.Drawing.SizeF(109.2244F, 17.41667F);
         this.xrLabel1.StyleName = "FieldCaption";
         this.xrLabel1.StylePriority.UseBackColor = false;
         this.xrLabel1.StylePriority.UseFont = false;
         this.xrLabel1.StylePriority.UseForeColor = false;
         this.xrLabel1.Text = "Σύνολα:";
         // 
         // xrLabel2
         // 
         this.xrLabel2.BackColor = System.Drawing.Color.Silver;
         this.xrLabel2.CanGrow = false;
         this.xrLabel2.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.PricelistDescription", "Pricelist : {0}")});
         this.xrLabel2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold);
         this.xrLabel2.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
         this.xrLabel2.Name = "xrLabel2";
         this.xrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel2.SizeF = new System.Drawing.SizeF(315.4893F, 17.41667F);
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
         this.pageFooterBand1.HeightF = 17.54163F;
         this.pageFooterBand1.Name = "pageFooterBand1";
         // 
         // xrPageInfo1
         // 
         this.xrPageInfo1.Borders = DevExpress.XtraPrinting.BorderSide.Top;
         this.xrPageInfo1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
         this.xrPageInfo1.Format = "Σελίδα {0} από {1}";
         this.xrPageInfo1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0.2372742F);
         this.xrPageInfo1.Name = "xrPageInfo1";
         this.xrPageInfo1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrPageInfo1.SizeF = new System.Drawing.SizeF(650F, 14.76271F);
         this.xrPageInfo1.StylePriority.UseBorders = false;
         this.xrPageInfo1.StylePriority.UseFont = false;
         this.xrPageInfo1.StylePriority.UseTextAlignment = false;
         this.xrPageInfo1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
         // 
         // reportHeaderBand1
         // 
         this.reportHeaderBand1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel7,
            this.xrLabel21});
         this.reportHeaderBand1.HeightF = 23.91666F;
         this.reportHeaderBand1.Name = "reportHeaderBand1";
         // 
         // xrLabel21
         // 
         this.xrLabel21.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding(this.FromFODay, "Text", "Πωλήσεις Ειδών ανά Τιμοκατάλογο (από {0}")});
         this.xrLabel21.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
         this.xrLabel21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
         this.xrLabel21.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
         this.xrLabel21.Name = "xrLabel21";
         this.xrLabel21.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel21.SizeF = new System.Drawing.SizeF(423F, 21.45833F);
         this.xrLabel21.StyleName = "Title";
         this.xrLabel21.StylePriority.UseFont = false;
         this.xrLabel21.StylePriority.UseForeColor = false;
         this.xrLabel21.StylePriority.UseTextAlignment = false;
         this.xrLabel21.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
         // 
         // groupFooterBand1
         // 
         this.groupFooterBand1.HeightF = 1F;
         this.groupFooterBand1.Name = "groupFooterBand1";
         // 
         // groupFooterBand2
         // 
         this.groupFooterBand2.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLine4,
            this.xrLabel22,
            this.xrLabel23,
            this.xrLabel24});
         this.groupFooterBand2.HeightF = 30F;
         this.groupFooterBand2.Name = "groupFooterBand2";
         // 
         // xrLine4
         // 
         this.xrLine4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
         this.xrLine4.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
         this.xrLine4.Name = "xrLine4";
         this.xrLine4.SizeF = new System.Drawing.SizeF(650F, 2F);
         this.xrLine4.StylePriority.UseForeColor = false;
         // 
         // xrLabel22
         // 
         this.xrLabel22.CanGrow = false;
         this.xrLabel22.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.Qty")});
         this.xrLabel22.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
         this.xrLabel22.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
         this.xrLabel22.LocationFloat = new DevExpress.Utils.PointFloat(424.7137F, 2.00001F);
         this.xrLabel22.Name = "xrLabel22";
         this.xrLabel22.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel22.SizeF = new System.Drawing.SizeF(110.1378F, 18F);
         this.xrLabel22.StyleName = "FieldCaption";
         this.xrLabel22.StylePriority.UseFont = false;
         this.xrLabel22.StylePriority.UseForeColor = false;
         this.xrLabel22.StylePriority.UseTextAlignment = false;
         xrSummary3.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
         this.xrLabel22.Summary = xrSummary3;
         this.xrLabel22.Text = "xrLabel22";
         this.xrLabel22.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
         this.xrLabel22.Visible = false;
         this.xrLabel22.WordWrap = false;
         // 
         // xrLabel23
         // 
         this.xrLabel23.CanGrow = false;
         this.xrLabel23.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.Total", "{0:C2}")});
         this.xrLabel23.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
         this.xrLabel23.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
         this.xrLabel23.LocationFloat = new DevExpress.Utils.PointFloat(534.8516F, 2.00001F);
         this.xrLabel23.Name = "xrLabel23";
         this.xrLabel23.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel23.SizeF = new System.Drawing.SizeF(115.1484F, 18F);
         this.xrLabel23.StyleName = "FieldCaption";
         this.xrLabel23.StylePriority.UseFont = false;
         this.xrLabel23.StylePriority.UseForeColor = false;
         this.xrLabel23.StylePriority.UseTextAlignment = false;
         xrSummary4.FormatString = "{0:C2}";
         xrSummary4.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
         this.xrLabel23.Summary = xrSummary4;
         this.xrLabel23.Text = "xrLabel23";
         this.xrLabel23.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
         this.xrLabel23.Visible = false;
         this.xrLabel23.WordWrap = false;
         // 
         // xrLabel24
         // 
         this.xrLabel24.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
         this.xrLabel24.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
         this.xrLabel24.LocationFloat = new DevExpress.Utils.PointFloat(0F, 2.00001F);
         this.xrLabel24.Name = "xrLabel24";
         this.xrLabel24.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel24.SizeF = new System.Drawing.SizeF(311.4892F, 18F);
         this.xrLabel24.StyleName = "FieldCaption";
         this.xrLabel24.StylePriority.UseFont = false;
         this.xrLabel24.StylePriority.UseForeColor = false;
         this.xrLabel24.Text = "Γενικά Σύνολα";
         this.xrLabel24.Visible = false;
         // 
         // reportFooterBand1
         // 
         this.reportFooterBand1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLine3,
            this.xrLabel25,
            this.xrLabel26,
            this.xrLabel27});
         this.reportFooterBand1.HeightF = 30F;
         this.reportFooterBand1.Name = "reportFooterBand1";
         // 
         // xrLine3
         // 
         this.xrLine3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
         this.xrLine3.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
         this.xrLine3.Name = "xrLine3";
         this.xrLine3.SizeF = new System.Drawing.SizeF(650F, 2F);
         this.xrLine3.StylePriority.UseForeColor = false;
         // 
         // xrLabel25
         // 
         this.xrLabel25.CanGrow = false;
         this.xrLabel25.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.Qty")});
         this.xrLabel25.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
         this.xrLabel25.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
         this.xrLabel25.LocationFloat = new DevExpress.Utils.PointFloat(424.7138F, 2.00001F);
         this.xrLabel25.Name = "xrLabel25";
         this.xrLabel25.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel25.SizeF = new System.Drawing.SizeF(110.1377F, 18F);
         this.xrLabel25.StyleName = "FieldCaption";
         this.xrLabel25.StylePriority.UseFont = false;
         this.xrLabel25.StylePriority.UseForeColor = false;
         this.xrLabel25.StylePriority.UseTextAlignment = false;
         xrSummary5.Running = DevExpress.XtraReports.UI.SummaryRunning.Report;
         this.xrLabel25.Summary = xrSummary5;
         this.xrLabel25.Text = "xrLabel25";
         this.xrLabel25.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
         this.xrLabel25.WordWrap = false;
         // 
         // xrLabel26
         // 
         this.xrLabel26.CanGrow = false;
         this.xrLabel26.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.Total", "{0:C2}")});
         this.xrLabel26.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
         this.xrLabel26.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
         this.xrLabel26.LocationFloat = new DevExpress.Utils.PointFloat(534.8516F, 2.00001F);
         this.xrLabel26.Name = "xrLabel26";
         this.xrLabel26.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel26.SizeF = new System.Drawing.SizeF(115.1484F, 18F);
         this.xrLabel26.StyleName = "FieldCaption";
         this.xrLabel26.StylePriority.UseFont = false;
         this.xrLabel26.StylePriority.UseForeColor = false;
         this.xrLabel26.StylePriority.UseTextAlignment = false;
         xrSummary6.FormatString = "{0:C2}";
         xrSummary6.Running = DevExpress.XtraReports.UI.SummaryRunning.Report;
         this.xrLabel26.Summary = xrSummary6;
         this.xrLabel26.Text = "xrLabel26";
         this.xrLabel26.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
         this.xrLabel26.WordWrap = false;
         // 
         // xrLabel27
         // 
         this.xrLabel27.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
         this.xrLabel27.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
         this.xrLabel27.LocationFloat = new DevExpress.Utils.PointFloat(0F, 2.00001F);
         this.xrLabel27.Name = "xrLabel27";
         this.xrLabel27.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel27.SizeF = new System.Drawing.SizeF(311.4892F, 18F);
         this.xrLabel27.StyleName = "FieldCaption";
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
         // xrLine2
         // 
         this.xrLine2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
         this.xrLine2.LocationFloat = new DevExpress.Utils.PointFloat(0F, 20F);
         this.xrLine2.Name = "xrLine2";
         this.xrLine2.SizeF = new System.Drawing.SizeF(650F, 2F);
         this.xrLine2.StylePriority.UseForeColor = false;
         // 
         // xrLine1
         // 
         this.xrLine1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
         this.xrLine1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
         this.xrLine1.Name = "xrLine1";
         this.xrLine1.SizeF = new System.Drawing.SizeF(650F, 2F);
         this.xrLine1.StylePriority.UseForeColor = false;
         // 
         // xrLabel8
         // 
         this.xrLabel8.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
         this.xrLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
         this.xrLabel8.LocationFloat = new DevExpress.Utils.PointFloat(534.8516F, 2.000001F);
         this.xrLabel8.Name = "xrLabel8";
         this.xrLabel8.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel8.SizeF = new System.Drawing.SizeF(115.1484F, 18F);
         this.xrLabel8.StylePriority.UseFont = false;
         this.xrLabel8.StylePriority.UseForeColor = false;
         this.xrLabel8.StylePriority.UseTextAlignment = false;
         this.xrLabel8.Text = "Σύνολο";
         this.xrLabel8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
         // 
         // xrLabel6
         // 
         this.xrLabel6.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
         this.xrLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
         this.xrLabel6.LocationFloat = new DevExpress.Utils.PointFloat(424.7137F, 2.000001F);
         this.xrLabel6.Name = "xrLabel6";
         this.xrLabel6.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel6.SizeF = new System.Drawing.SizeF(110.1378F, 18F);
         this.xrLabel6.StylePriority.UseFont = false;
         this.xrLabel6.StylePriority.UseForeColor = false;
         this.xrLabel6.StylePriority.UseTextAlignment = false;
         this.xrLabel6.Text = "Ποσότητα";
         this.xrLabel6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
         // 
         // xrLabel5
         // 
         this.xrLabel5.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
         this.xrLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
         this.xrLabel5.LocationFloat = new DevExpress.Utils.PointFloat(311.4892F, 2.000001F);
         this.xrLabel5.Name = "xrLabel5";
         this.xrLabel5.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel5.SizeF = new System.Drawing.SizeF(113.2245F, 18F);
         this.xrLabel5.StylePriority.UseFont = false;
         this.xrLabel5.StylePriority.UseForeColor = false;
         this.xrLabel5.StylePriority.UseTextAlignment = false;
         this.xrLabel5.Text = "Σύνολο Παραστ.";
         this.xrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
         // 
         // xrLabel4
         // 
         this.xrLabel4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
         this.xrLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
         this.xrLabel4.LocationFloat = new DevExpress.Utils.PointFloat(99.4584F, 2F);
         this.xrLabel4.Name = "xrLabel4";
         this.xrLabel4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel4.SizeF = new System.Drawing.SizeF(212.0308F, 18F);
         this.xrLabel4.StylePriority.UseFont = false;
         this.xrLabel4.StylePriority.UseForeColor = false;
         this.xrLabel4.Text = "Περιγραφή";
         // 
         // xrLabel3
         // 
         this.xrLabel3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
         this.xrLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
         this.xrLabel3.LocationFloat = new DevExpress.Utils.PointFloat(0F, 2.000001F);
         this.xrLabel3.Name = "xrLabel3";
         this.xrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel3.SizeF = new System.Drawing.SizeF(99.4584F, 18F);
         this.xrLabel3.StylePriority.UseFont = false;
         this.xrLabel3.StylePriority.UseForeColor = false;
         this.xrLabel3.Text = "Κωδ. Είδους";
         // 
         // groupHeaderBand2
         // 
         this.groupHeaderBand2.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel3,
            this.xrLabel4,
            this.xrLabel5,
            this.xrLabel6,
            this.xrLabel8,
            this.xrLine1,
            this.xrLine2});
         this.groupHeaderBand2.HeightF = 22F;
         this.groupHeaderBand2.Name = "groupHeaderBand2";
         this.groupHeaderBand2.StyleName = "FieldCaption";
         // 
         // FromFODay
         // 
         this.FromFODay.Description = "From Date";
         this.FromFODay.Name = "FromFODay";
         this.FromFODay.Type = typeof(System.DateTime);
         this.FromFODay.ValueInfo = "2016-05-31";
         // 
         // UpToFODay
         // 
         this.UpToFODay.Description = "UpTo Date";
         this.UpToFODay.Name = "UpToFODay";
         this.UpToFODay.Type = typeof(System.DateTime);
         this.UpToFODay.ValueInfo = "2016-05-31";
         // 
         // PricelistId
         // 
         this.PricelistId.Description = "Select Pricelist";
         dynamicListLookUpSettings1.DataAdapter = null;
         dynamicListLookUpSettings1.DataMember = "PricelistLookups";
         dynamicListLookUpSettings1.DataSource = this.sqlDataSource1;
         dynamicListLookUpSettings1.DisplayMember = "Description";
         dynamicListLookUpSettings1.FilterString = null;
         dynamicListLookUpSettings1.ValueMember = "Id";
         this.PricelistId.LookUpSettings = dynamicListLookUpSettings1;
         this.PricelistId.MultiValue = true;
         this.PricelistId.Name = "PricelistId";
         this.PricelistId.Type = typeof(int);
         // 
         // xrControlStyle1
         // 
         this.xrControlStyle1.BackColor = System.Drawing.Color.Silver;
         this.xrControlStyle1.Name = "xrControlStyle1";
         this.xrControlStyle1.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
         // 
         // xrLabel7
         // 
         this.xrLabel7.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding(this.UpToFODay, "Text", " έως {0})")});
         this.xrLabel7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
         this.xrLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
         this.xrLabel7.LocationFloat = new DevExpress.Utils.PointFloat(423.7138F, 0F);
         this.xrLabel7.Name = "xrLabel7";
         this.xrLabel7.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel7.SizeF = new System.Drawing.SizeF(226.2862F, 21.45833F);
         this.xrLabel7.StyleName = "Title";
         this.xrLabel7.StylePriority.UseFont = false;
         this.xrLabel7.StylePriority.UseForeColor = false;
         this.xrLabel7.StylePriority.UseTextAlignment = false;
         this.xrLabel7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
         // 
         // SalesPerPricelistOldDB
         // 
         this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.groupHeaderBand1,
            this.groupHeaderBand2,
            this.pageFooterBand1,
            this.reportHeaderBand1,
            this.groupFooterBand2,
            this.reportFooterBand1});
         this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.sqlDataSource1});
         this.DataMember = "Query_FastStart";
         this.DataSource = this.sqlDataSource1;
         this.FilterString = "[FODay] >= ?FromFODay And [FODay] <= ?UpToFODay And [PricelistId] In (?PricelistI" +
    "d)";
         this.Margins = new System.Drawing.Printing.Margins(100, 100, 53, 36);
         this.Parameters.AddRange(new DevExpress.XtraReports.Parameters.Parameter[] {
            this.FromFODay,
            this.UpToFODay,
            this.PricelistId});
         this.StyleSheet.AddRange(new DevExpress.XtraReports.UI.XRControlStyle[] {
            this.Title,
            this.FieldCaption,
            this.PageInfo,
            this.DataField,
            this.xrControlStyle1});
         this.Version = "15.2";
         this.DataSourceDemanded += new System.EventHandler<System.EventArgs>(this.SalesPerPricelistOldDB_DataSourceDemanded);
         ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

      }

   #endregion

   ////////////////////////////////////////////////////////////////////////////////////////////////
   /// <summary>
   /// 
   /// </summary>
   /// <param name="sender"></param>
   /// <param name="e"></param>
   private void SalesPerPricelistOldDB_DataSourceDemanded( object sender, EventArgs e )
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

