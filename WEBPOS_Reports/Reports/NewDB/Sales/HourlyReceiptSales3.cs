using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

/// <summary>
/// Summary description for HourlyReceiptSales3
/// </summary>
public class HourlyReceiptSales3 : DevExpress.XtraReports.UI.XtraReport
   {
   private DevExpress.XtraReports.UI.DetailBand Detail;
   private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
   private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
   private XRLabel xrLabel7;
   private XRLabel xrLabel8;
   private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
   private GroupHeaderBand groupHeaderBand1;
   private XRLabel xrLabel2;
   private GroupHeaderBand groupHeaderBand3;
   private XRLabel xrLabel5;
   private XRLabel xrLabel6;
   private XRLine xrLine1;
   private XRLine xrLine2;
   private PageFooterBand pageFooterBand1;
   private ReportHeaderBand reportHeaderBand1;
   private GroupFooterBand groupFooterBand1;
   private GroupFooterBand groupFooterBand3;
   private XRLabel xrLabel13;
   private XRLabel xrLabel14;
   private XRLabel xrLabel15;
   private ReportFooterBand reportFooterBand1;
   private XRLabel xrLabel16;
   private XRLabel xrLabel17;
   private XRLabel xrLabel18;
   private XRControlStyle Title;
   private XRControlStyle FieldCaption;
   private XRControlStyle PageInfo;
   private XRControlStyle DataField;
   private DevExpress.XtraReports.Parameters.Parameter FromFODay;
   private DevExpress.XtraReports.Parameters.Parameter UpToDate;
   private DevExpress.XtraReports.Parameters.Parameter PosInfoID;
   private XRPageInfo xrPageInfo2;
   private XRLabel xrLabel19;
   private XRLabel xrLabel9;
   private XRPageInfo xrPageInfo1;

   /// <summary>
   /// Required designer variable.
   /// </summary>
   private System.ComponentModel.IContainer components = null;

   public HourlyReceiptSales3()
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
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HourlyReceiptSales3));
         DevExpress.DataAccess.Sql.CustomSqlQuery customSqlQuery2 = new DevExpress.DataAccess.Sql.CustomSqlQuery();
         DevExpress.XtraReports.UI.XRSummary xrSummary1 = new DevExpress.XtraReports.UI.XRSummary();
         DevExpress.XtraReports.UI.XRSummary xrSummary2 = new DevExpress.XtraReports.UI.XRSummary();
         DevExpress.XtraReports.UI.XRSummary xrSummary3 = new DevExpress.XtraReports.UI.XRSummary();
         DevExpress.XtraReports.UI.XRSummary xrSummary4 = new DevExpress.XtraReports.UI.XRSummary();
         DevExpress.XtraReports.Parameters.DynamicListLookUpSettings dynamicListLookUpSettings1 = new DevExpress.XtraReports.Parameters.DynamicListLookUpSettings();
         this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
         this.Detail = new DevExpress.XtraReports.UI.DetailBand();
         this.xrLabel19 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel7 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel8 = new DevExpress.XtraReports.UI.XRLabel();
         this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
         this.xrPageInfo2 = new DevExpress.XtraReports.UI.XRPageInfo();
         this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
         this.groupHeaderBand1 = new DevExpress.XtraReports.UI.GroupHeaderBand();
         this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
         this.groupHeaderBand3 = new DevExpress.XtraReports.UI.GroupHeaderBand();
         this.xrLabel5 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel6 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLine1 = new DevExpress.XtraReports.UI.XRLine();
         this.xrLine2 = new DevExpress.XtraReports.UI.XRLine();
         this.pageFooterBand1 = new DevExpress.XtraReports.UI.PageFooterBand();
         this.xrPageInfo1 = new DevExpress.XtraReports.UI.XRPageInfo();
         this.reportHeaderBand1 = new DevExpress.XtraReports.UI.ReportHeaderBand();
         this.xrLabel9 = new DevExpress.XtraReports.UI.XRLabel();
         this.groupFooterBand1 = new DevExpress.XtraReports.UI.GroupFooterBand();
         this.groupFooterBand3 = new DevExpress.XtraReports.UI.GroupFooterBand();
         this.xrLabel13 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel14 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel15 = new DevExpress.XtraReports.UI.XRLabel();
         this.reportFooterBand1 = new DevExpress.XtraReports.UI.ReportFooterBand();
         this.xrLabel16 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel17 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel18 = new DevExpress.XtraReports.UI.XRLabel();
         this.Title = new DevExpress.XtraReports.UI.XRControlStyle();
         this.FieldCaption = new DevExpress.XtraReports.UI.XRControlStyle();
         this.PageInfo = new DevExpress.XtraReports.UI.XRControlStyle();
         this.DataField = new DevExpress.XtraReports.UI.XRControlStyle();
         this.FromFODay = new DevExpress.XtraReports.Parameters.Parameter();
         this.UpToDate = new DevExpress.XtraReports.Parameters.Parameter();
         this.PosInfoID = new DevExpress.XtraReports.Parameters.Parameter();
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
         queryParameter2.Value = new DevExpress.DataAccess.Expression("[Parameters.UpToDate]", typeof(System.DateTime));
         customSqlQuery1.Parameters.Add(queryParameter1);
         customSqlQuery1.Parameters.Add(queryParameter2);
         customSqlQuery1.Sql = resources.GetString("customSqlQuery1.Sql");
         customSqlQuery2.Name = "PosInfoLookUps";
         customSqlQuery2.Sql = "Select Id, Code, Description from PosInfo";
         this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            customSqlQuery1,
            customSqlQuery2});
         this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
         // 
         // Detail
         // 
         this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel19,
            this.xrLabel7,
            this.xrLabel8});
         this.Detail.HeightF = 29F;
         this.Detail.Name = "Detail";
         this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
         this.Detail.SortFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("Abbreviation", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
         this.Detail.StyleName = "DataField";
         this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
         // 
         // xrLabel19
         // 
         this.xrLabel19.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.Abbreviation")});
         this.xrLabel19.LocationFloat = new DevExpress.Utils.PointFloat(6F, 0F);
         this.xrLabel19.Name = "xrLabel19";
         this.xrLabel19.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel19.SizeF = new System.Drawing.SizeF(100F, 17F);
         this.xrLabel19.StylePriority.UseTextAlignment = false;
         this.xrLabel19.Text = "xrLabel19";
         this.xrLabel19.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
         // 
         // xrLabel7
         // 
         this.xrLabel7.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.InvoiceCount")});
         this.xrLabel7.LocationFloat = new DevExpress.Utils.PointFloat(379.1695F, 0F);
         this.xrLabel7.Name = "xrLabel7";
         this.xrLabel7.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel7.SizeF = new System.Drawing.SizeF(156F, 17F);
         this.xrLabel7.StylePriority.UseTextAlignment = false;
         this.xrLabel7.Text = "xrLabel7";
         this.xrLabel7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
         // 
         // xrLabel8
         // 
         this.xrLabel8.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.Total", "{0:C2}")});
         this.xrLabel8.LocationFloat = new DevExpress.Utils.PointFloat(535.1695F, 0F);
         this.xrLabel8.Name = "xrLabel8";
         this.xrLabel8.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel8.SizeF = new System.Drawing.SizeF(183.8305F, 17F);
         this.xrLabel8.StylePriority.UseTextAlignment = false;
         this.xrLabel8.Text = "xrLabel8";
         this.xrLabel8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
         // 
         // TopMargin
         // 
         this.TopMargin.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrPageInfo2});
         this.TopMargin.HeightF = 46F;
         this.TopMargin.Name = "TopMargin";
         this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
         this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
         // 
         // xrPageInfo2
         // 
         this.xrPageInfo2.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
         this.xrPageInfo2.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
         this.xrPageInfo2.Format = "Ημερομηνία Εκτύπωσης : {0:dddd, d MMMM yyyy h:mm:ss tt}";
         this.xrPageInfo2.LocationFloat = new DevExpress.Utils.PointFloat(6F, 30.23729F);
         this.xrPageInfo2.Name = "xrPageInfo2";
         this.xrPageInfo2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrPageInfo2.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime;
         this.xrPageInfo2.SizeF = new System.Drawing.SizeF(713F, 15.76271F);
         this.xrPageInfo2.StylePriority.UseBorders = false;
         this.xrPageInfo2.StylePriority.UseFont = false;
         // 
         // BottomMargin
         // 
         this.BottomMargin.HeightF = 23F;
         this.BottomMargin.Name = "BottomMargin";
         this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
         this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
         // 
         // groupHeaderBand1
         // 
         this.groupHeaderBand1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel2});
         this.groupHeaderBand1.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("ByHour", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
         this.groupHeaderBand1.HeightF = 20.375F;
         this.groupHeaderBand1.Level = 1;
         this.groupHeaderBand1.Name = "groupHeaderBand1";
         // 
         // xrLabel2
         // 
         this.xrLabel2.BackColor = System.Drawing.Color.DarkGray;
         this.xrLabel2.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.ByHour", "Ώρα {0:0#}")});
         this.xrLabel2.LocationFloat = new DevExpress.Utils.PointFloat(6F, 0F);
         this.xrLabel2.Name = "xrLabel2";
         this.xrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel2.SizeF = new System.Drawing.SizeF(713F, 17F);
         this.xrLabel2.StyleName = "DataField";
         this.xrLabel2.StylePriority.UseBackColor = false;
         // 
         // groupHeaderBand3
         // 
         this.groupHeaderBand3.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel5,
            this.xrLabel6,
            this.xrLine1,
            this.xrLine2});
         this.groupHeaderBand3.HeightF = 27F;
         this.groupHeaderBand3.Name = "groupHeaderBand3";
         this.groupHeaderBand3.StyleName = "FieldCaption";
         // 
         // xrLabel5
         // 
         this.xrLabel5.LocationFloat = new DevExpress.Utils.PointFloat(379.1695F, 7F);
         this.xrLabel5.Name = "xrLabel5";
         this.xrLabel5.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel5.SizeF = new System.Drawing.SizeF(156F, 18F);
         this.xrLabel5.StylePriority.UseTextAlignment = false;
         this.xrLabel5.Text = "Invoice Count";
         this.xrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
         // 
         // xrLabel6
         // 
         this.xrLabel6.LocationFloat = new DevExpress.Utils.PointFloat(535.1695F, 7F);
         this.xrLabel6.Name = "xrLabel6";
         this.xrLabel6.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel6.SizeF = new System.Drawing.SizeF(183.8305F, 18F);
         this.xrLabel6.StylePriority.UseTextAlignment = false;
         this.xrLabel6.Text = "Total";
         this.xrLabel6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
         // 
         // xrLine1
         // 
         this.xrLine1.LocationFloat = new DevExpress.Utils.PointFloat(6F, 5F);
         this.xrLine1.Name = "xrLine1";
         this.xrLine1.SizeF = new System.Drawing.SizeF(713F, 2F);
         // 
         // xrLine2
         // 
         this.xrLine2.LocationFloat = new DevExpress.Utils.PointFloat(6F, 25F);
         this.xrLine2.Name = "xrLine2";
         this.xrLine2.SizeF = new System.Drawing.SizeF(713F, 2F);
         // 
         // pageFooterBand1
         // 
         this.pageFooterBand1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrPageInfo1});
         this.pageFooterBand1.HeightF = 25.87496F;
         this.pageFooterBand1.Name = "pageFooterBand1";
         // 
         // xrPageInfo1
         // 
         this.xrPageInfo1.Borders = DevExpress.XtraPrinting.BorderSide.Top;
         this.xrPageInfo1.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
         this.xrPageInfo1.Format = "Σελίδα {0} από {1}";
         this.xrPageInfo1.LocationFloat = new DevExpress.Utils.PointFloat(6F, 0F);
         this.xrPageInfo1.Name = "xrPageInfo1";
         this.xrPageInfo1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrPageInfo1.SizeF = new System.Drawing.SizeF(713F, 18.76271F);
         this.xrPageInfo1.StylePriority.UseBorders = false;
         this.xrPageInfo1.StylePriority.UseFont = false;
         this.xrPageInfo1.StylePriority.UseTextAlignment = false;
         this.xrPageInfo1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
         // 
         // reportHeaderBand1
         // 
         this.reportHeaderBand1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel9});
         this.reportHeaderBand1.HeightF = 31.12501F;
         this.reportHeaderBand1.Name = "reportHeaderBand1";
         // 
         // xrLabel9
         // 
         this.xrLabel9.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
         this.xrLabel9.LocationFloat = new DevExpress.Utils.PointFloat(6F, 4F);
         this.xrLabel9.Name = "xrLabel9";
         this.xrLabel9.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel9.SizeF = new System.Drawing.SizeF(713F, 23F);
         this.xrLabel9.StyleName = "Title";
         this.xrLabel9.StylePriority.UseFont = false;
         this.xrLabel9.StylePriority.UseTextAlignment = false;
         this.xrLabel9.Text = "Ωριαίες Πωλήσεις Αποδείξεων ανά Τύπο Παραστατικού";
         this.xrLabel9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
         // 
         // groupFooterBand1
         // 
         this.groupFooterBand1.HeightF = 1F;
         this.groupFooterBand1.Name = "groupFooterBand1";
         // 
         // groupFooterBand3
         // 
         this.groupFooterBand3.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel13,
            this.xrLabel14,
            this.xrLabel15});
         this.groupFooterBand3.HeightF = 30F;
         this.groupFooterBand3.Level = 1;
         this.groupFooterBand3.Name = "groupFooterBand3";
         // 
         // xrLabel13
         // 
         this.xrLabel13.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.InvoiceCount")});
         this.xrLabel13.LocationFloat = new DevExpress.Utils.PointFloat(379.1695F, 6F);
         this.xrLabel13.Name = "xrLabel13";
         this.xrLabel13.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel13.SizeF = new System.Drawing.SizeF(156F, 18F);
         this.xrLabel13.StyleName = "FieldCaption";
         xrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
         this.xrLabel13.Summary = xrSummary1;
         this.xrLabel13.Text = "xrLabel13";
         // 
         // xrLabel14
         // 
         this.xrLabel14.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.Total", "{0:C2}")});
         this.xrLabel14.LocationFloat = new DevExpress.Utils.PointFloat(535.1695F, 6F);
         this.xrLabel14.Name = "xrLabel14";
         this.xrLabel14.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel14.SizeF = new System.Drawing.SizeF(183.8305F, 18F);
         this.xrLabel14.StyleName = "FieldCaption";
         xrSummary2.FormatString = "{0:C2}";
         xrSummary2.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
         this.xrLabel14.Summary = xrSummary2;
         this.xrLabel14.Text = "xrLabel14";
         // 
         // xrLabel15
         // 
         this.xrLabel15.LocationFloat = new DevExpress.Utils.PointFloat(6F, 6F);
         this.xrLabel15.Name = "xrLabel15";
         this.xrLabel15.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel15.SizeF = new System.Drawing.SizeF(30F, 18F);
         this.xrLabel15.StyleName = "FieldCaption";
         this.xrLabel15.Text = "Sum";
         // 
         // reportFooterBand1
         // 
         this.reportFooterBand1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel16,
            this.xrLabel17,
            this.xrLabel18});
         this.reportFooterBand1.HeightF = 30F;
         this.reportFooterBand1.Name = "reportFooterBand1";
         // 
         // xrLabel16
         // 
         this.xrLabel16.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.InvoiceCount")});
         this.xrLabel16.LocationFloat = new DevExpress.Utils.PointFloat(379.1695F, 6F);
         this.xrLabel16.Name = "xrLabel16";
         this.xrLabel16.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel16.SizeF = new System.Drawing.SizeF(156F, 18F);
         this.xrLabel16.StyleName = "FieldCaption";
         xrSummary3.Running = DevExpress.XtraReports.UI.SummaryRunning.Report;
         this.xrLabel16.Summary = xrSummary3;
         this.xrLabel16.Text = "xrLabel16";
         // 
         // xrLabel17
         // 
         this.xrLabel17.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.Total", "{0:C2}")});
         this.xrLabel17.LocationFloat = new DevExpress.Utils.PointFloat(535.1695F, 6F);
         this.xrLabel17.Name = "xrLabel17";
         this.xrLabel17.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel17.SizeF = new System.Drawing.SizeF(183.8305F, 18F);
         this.xrLabel17.StyleName = "FieldCaption";
         xrSummary4.FormatString = "{0:C2}";
         xrSummary4.Running = DevExpress.XtraReports.UI.SummaryRunning.Report;
         this.xrLabel17.Summary = xrSummary4;
         this.xrLabel17.Text = "xrLabel17";
         // 
         // xrLabel18
         // 
         this.xrLabel18.LocationFloat = new DevExpress.Utils.PointFloat(6F, 6F);
         this.xrLabel18.Name = "xrLabel18";
         this.xrLabel18.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel18.SizeF = new System.Drawing.SizeF(72F, 18F);
         this.xrLabel18.StyleName = "FieldCaption";
         this.xrLabel18.Text = "Grand Total";
         // 
         // Title
         // 
         this.Title.BackColor = System.Drawing.Color.Transparent;
         this.Title.BorderColor = System.Drawing.Color.Black;
         this.Title.Borders = DevExpress.XtraPrinting.BorderSide.None;
         this.Title.BorderWidth = 1F;
         this.Title.Font = new System.Drawing.Font("Times New Roman", 21F);
         this.Title.ForeColor = System.Drawing.Color.Black;
         this.Title.Name = "Title";
         // 
         // FieldCaption
         // 
         this.FieldCaption.BackColor = System.Drawing.Color.Transparent;
         this.FieldCaption.BorderColor = System.Drawing.Color.Black;
         this.FieldCaption.Borders = DevExpress.XtraPrinting.BorderSide.None;
         this.FieldCaption.BorderWidth = 1F;
         this.FieldCaption.Font = new System.Drawing.Font("Times New Roman", 10F);
         this.FieldCaption.ForeColor = System.Drawing.Color.Black;
         this.FieldCaption.Name = "FieldCaption";
         // 
         // PageInfo
         // 
         this.PageInfo.BackColor = System.Drawing.Color.Transparent;
         this.PageInfo.BorderColor = System.Drawing.Color.Black;
         this.PageInfo.Borders = DevExpress.XtraPrinting.BorderSide.None;
         this.PageInfo.BorderWidth = 1F;
         this.PageInfo.Font = new System.Drawing.Font("Arial", 8F);
         this.PageInfo.ForeColor = System.Drawing.Color.Black;
         this.PageInfo.Name = "PageInfo";
         // 
         // DataField
         // 
         this.DataField.BackColor = System.Drawing.Color.Transparent;
         this.DataField.BorderColor = System.Drawing.Color.Black;
         this.DataField.Borders = DevExpress.XtraPrinting.BorderSide.None;
         this.DataField.BorderWidth = 1F;
         this.DataField.Font = new System.Drawing.Font("Arial", 9F);
         this.DataField.ForeColor = System.Drawing.Color.Black;
         this.DataField.Name = "DataField";
         this.DataField.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         // 
         // FromFODay
         // 
         this.FromFODay.Description = "From Date";
         this.FromFODay.Name = "FromFODay";
         this.FromFODay.Type = typeof(System.DateTime);
         this.FromFODay.ValueInfo = "2016-06-02";
         // 
         // UpToDate
         // 
         this.UpToDate.Description = "UpTo Date";
         this.UpToDate.Name = "UpToDate";
         this.UpToDate.Type = typeof(System.DateTime);
         this.UpToDate.ValueInfo = "2016-06-02";
         // 
         // PosInfoID
         // 
         this.PosInfoID.Description = "Select POS";
         dynamicListLookUpSettings1.DataAdapter = null;
         dynamicListLookUpSettings1.DataMember = "PosInfoLookUps";
         dynamicListLookUpSettings1.DataSource = this.sqlDataSource1;
         dynamicListLookUpSettings1.DisplayMember = "Description";
         dynamicListLookUpSettings1.ValueMember = "Id";
         this.PosInfoID.LookUpSettings = dynamicListLookUpSettings1;
         this.PosInfoID.MultiValue = true;
         this.PosInfoID.Name = "PosInfoID";
         this.PosInfoID.Type = typeof(long);
         this.PosInfoID.ValueInfo = "0";
         // 
         // HourlyReceiptSales3
         // 
         this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.groupHeaderBand1,
            this.groupHeaderBand3,
            this.pageFooterBand1,
            this.reportHeaderBand1,
            this.groupFooterBand3,
            this.reportFooterBand1});
         this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.sqlDataSource1});
         this.DataMember = "Query";
         this.DataSource = this.sqlDataSource1;
         this.FilterString = "[FODay] >= ?FromFODay And [FODay] <= ?UpToDate And [PosInfoId] In (?PosInfoID)";
         this.Margins = new System.Drawing.Printing.Margins(50, 52, 46, 23);
         this.PageHeight = 1169;
         this.PageWidth = 827;
         this.PaperKind = System.Drawing.Printing.PaperKind.A4;
         this.Parameters.AddRange(new DevExpress.XtraReports.Parameters.Parameter[] {
            this.FromFODay,
            this.UpToDate,
            this.PosInfoID});
         this.StyleSheet.AddRange(new DevExpress.XtraReports.UI.XRControlStyle[] {
            this.Title,
            this.FieldCaption,
            this.PageInfo,
            this.DataField});
         this.Version = "15.2";
         ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

      }

   #endregion
   }
