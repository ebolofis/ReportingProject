
using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Web.Configuration;
using WEBPOS_Reports.Helpers;

/// <summary>
/// Summary description for SalesPerPricelistCoverTotal
/// </summary>
public class SalesPerPricelistCoverTotal : DevExpress.XtraReports.UI.XtraReport
   {
   private DevExpress.XtraReports.UI.DetailBand Detail;
   private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
   private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
   private XRLabel xrLabel12;
   private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
   private GroupHeaderBand StaffCode_GroupHeader;
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
   private XRLabel xrLabel7;
   private XRLabel xrLabel6;
   private XRLabel xrLabel3;
   private GroupHeaderBand groupHeaderBand2;
   private DevExpress.XtraReports.Parameters.Parameter FromFODay;
   private DevExpress.XtraReports.Parameters.Parameter UpToFODay;
   private XRPageInfo xrPageInfo3;
   private XRPageInfo xrPageInfo1;
   private XRLabel xrLabel9;
   private XRLabel xrLabel17;
   private XRLabel xrLabel15;
   private XRLabel xrLabel18;
   private XRLine xrLine5;
   private XRLine xrLine6;
   private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource2;
   private DevExpress.XtraReports.Parameters.Parameter PosInfoID;
   private GroupHeaderBand POS_GroupHeader;
   private GroupFooterBand POS_GroupFooter;
   private XRLabel xrLabel11;
   private XRLabel xrLabel29;
   private XRLabel xrLabel28;
   private XRLine xrLine7;
   private XRLabel xrLabel20;
   private XRLabel xrLabel30;
   private DevExpress.XtraReports.Parameters.Parameter DepartmentId;
   private DevExpress.XtraReports.Parameters.Parameter Pricelist;
   private GroupHeaderBand Department_GroupHeader;
   private XRLabel xrLabel10;
   private GroupHeaderBand Pricelist_GroupHeader;
   private XRLabel xrLabel19;
   private XRLabel xrLabel4;
   private XRLabel xrLabel31;
   private GroupFooterBand Department_GroupFooter;
   private XRLabel xrLabel32;
   private XRLine xrLine3;
   private XRLabel xrLabel33;
   private XRLabel xrLabel34;
   private XRLabel xrLabel1;
   private XRLabel xrLabel5;
   private XRLabel xrLabel35;
   private XRLabel xrLabel36;
   private XRLabel xrLabel37;
   private XRLabel xrLabel38;
   private XRLabel xrLabel39;

   /// <summary>
   /// Required designer variable.
   /// </summary>
   private System.ComponentModel.IContainer components = null;

   public SalesPerPricelistCoverTotal()
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
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalesPerPricelistCoverTotal));
         DevExpress.DataAccess.Sql.CustomSqlQuery customSqlQuery2 = new DevExpress.DataAccess.Sql.CustomSqlQuery();
         DevExpress.DataAccess.Sql.CustomSqlQuery customSqlQuery3 = new DevExpress.DataAccess.Sql.CustomSqlQuery();
         DevExpress.DataAccess.Sql.CustomSqlQuery customSqlQuery4 = new DevExpress.DataAccess.Sql.CustomSqlQuery();
         DevExpress.DataAccess.Sql.CustomSqlQuery customSqlQuery5 = new DevExpress.DataAccess.Sql.CustomSqlQuery();
         DevExpress.DataAccess.Sql.CustomSqlQuery customSqlQuery6 = new DevExpress.DataAccess.Sql.CustomSqlQuery();
         DevExpress.DataAccess.Sql.CustomSqlQuery customSqlQuery7 = new DevExpress.DataAccess.Sql.CustomSqlQuery();
         DevExpress.XtraReports.UI.XRSummary xrSummary1 = new DevExpress.XtraReports.UI.XRSummary();
         DevExpress.XtraReports.UI.XRSummary xrSummary2 = new DevExpress.XtraReports.UI.XRSummary();
         DevExpress.XtraReports.UI.XRSummary xrSummary3 = new DevExpress.XtraReports.UI.XRSummary();
         DevExpress.XtraReports.UI.XRSummary xrSummary4 = new DevExpress.XtraReports.UI.XRSummary();
         DevExpress.XtraReports.UI.XRSummary xrSummary5 = new DevExpress.XtraReports.UI.XRSummary();
         DevExpress.XtraReports.UI.XRSummary xrSummary6 = new DevExpress.XtraReports.UI.XRSummary();
         DevExpress.XtraReports.UI.XRSummary xrSummary7 = new DevExpress.XtraReports.UI.XRSummary();
         DevExpress.XtraReports.UI.XRSummary xrSummary8 = new DevExpress.XtraReports.UI.XRSummary();
         DevExpress.XtraReports.UI.XRSummary xrSummary9 = new DevExpress.XtraReports.UI.XRSummary();
         DevExpress.DataAccess.Sql.CustomSqlQuery customSqlQuery8 = new DevExpress.DataAccess.Sql.CustomSqlQuery();
         DevExpress.DataAccess.Sql.QueryParameter queryParameter3 = new DevExpress.DataAccess.Sql.QueryParameter();
         DevExpress.DataAccess.Sql.QueryParameter queryParameter4 = new DevExpress.DataAccess.Sql.QueryParameter();
         DevExpress.XtraReports.Parameters.DynamicListLookUpSettings dynamicListLookUpSettings1 = new DevExpress.XtraReports.Parameters.DynamicListLookUpSettings();
         DevExpress.XtraReports.UI.XRSummary xrSummary10 = new DevExpress.XtraReports.UI.XRSummary();
         DevExpress.XtraReports.UI.XRSummary xrSummary11 = new DevExpress.XtraReports.UI.XRSummary();
         DevExpress.XtraReports.UI.XRSummary xrSummary12 = new DevExpress.XtraReports.UI.XRSummary();
         DevExpress.XtraReports.Parameters.DynamicListLookUpSettings dynamicListLookUpSettings2 = new DevExpress.XtraReports.Parameters.DynamicListLookUpSettings();
         DevExpress.XtraReports.Parameters.DynamicListLookUpSettings dynamicListLookUpSettings3 = new DevExpress.XtraReports.Parameters.DynamicListLookUpSettings();
         DevExpress.XtraReports.UI.XRSummary xrSummary13 = new DevExpress.XtraReports.UI.XRSummary();
         DevExpress.XtraReports.UI.XRSummary xrSummary14 = new DevExpress.XtraReports.UI.XRSummary();
         DevExpress.XtraReports.UI.XRSummary xrSummary15 = new DevExpress.XtraReports.UI.XRSummary();
         DevExpress.XtraReports.UI.XRSummary xrSummary16 = new DevExpress.XtraReports.UI.XRSummary();
         DevExpress.XtraReports.UI.XRSummary xrSummary17 = new DevExpress.XtraReports.UI.XRSummary();
         DevExpress.XtraReports.UI.XRSummary xrSummary18 = new DevExpress.XtraReports.UI.XRSummary();
         this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
         this.Detail = new DevExpress.XtraReports.UI.DetailBand();
         this.xrLabel17 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel15 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel12 = new DevExpress.XtraReports.UI.XRLabel();
         this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
         this.xrPageInfo3 = new DevExpress.XtraReports.UI.XRPageInfo();
         this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
         this.StaffCode_GroupHeader = new DevExpress.XtraReports.UI.GroupHeaderBand();
         this.xrLabel4 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel9 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel18 = new DevExpress.XtraReports.UI.XRLabel();
         this.pageFooterBand1 = new DevExpress.XtraReports.UI.PageFooterBand();
         this.xrPageInfo1 = new DevExpress.XtraReports.UI.XRPageInfo();
         this.reportHeaderBand1 = new DevExpress.XtraReports.UI.ReportHeaderBand();
         this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
         this.FromFODay = new DevExpress.XtraReports.Parameters.Parameter();
         this.xrLabel30 = new DevExpress.XtraReports.UI.XRLabel();
         this.UpToFODay = new DevExpress.XtraReports.Parameters.Parameter();
         this.xrLabel21 = new DevExpress.XtraReports.UI.XRLabel();
         this.groupFooterBand1 = new DevExpress.XtraReports.UI.GroupFooterBand();
         this.groupFooterBand2 = new DevExpress.XtraReports.UI.GroupFooterBand();
         this.xrLabel5 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLine5 = new DevExpress.XtraReports.UI.XRLine();
         this.xrLabel22 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel23 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel24 = new DevExpress.XtraReports.UI.XRLabel();
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
         this.xrLine2 = new DevExpress.XtraReports.UI.XRLine();
         this.xrLine1 = new DevExpress.XtraReports.UI.XRLine();
         this.xrLabel8 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel7 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel6 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
         this.groupHeaderBand2 = new DevExpress.XtraReports.UI.GroupHeaderBand();
         this.sqlDataSource2 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
         this.PosInfoID = new DevExpress.XtraReports.Parameters.Parameter();
         this.POS_GroupHeader = new DevExpress.XtraReports.UI.GroupHeaderBand();
         this.xrLabel11 = new DevExpress.XtraReports.UI.XRLabel();
         this.POS_GroupFooter = new DevExpress.XtraReports.UI.GroupFooterBand();
         this.xrLabel35 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel29 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel28 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLine7 = new DevExpress.XtraReports.UI.XRLine();
         this.xrLabel20 = new DevExpress.XtraReports.UI.XRLabel();
         this.DepartmentId = new DevExpress.XtraReports.Parameters.Parameter();
         this.Pricelist = new DevExpress.XtraReports.Parameters.Parameter();
         this.Department_GroupHeader = new DevExpress.XtraReports.UI.GroupHeaderBand();
         this.xrLabel10 = new DevExpress.XtraReports.UI.XRLabel();
         this.Pricelist_GroupHeader = new DevExpress.XtraReports.UI.GroupHeaderBand();
         this.xrLabel37 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel38 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel39 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel19 = new DevExpress.XtraReports.UI.XRLabel();
         this.Department_GroupFooter = new DevExpress.XtraReports.UI.GroupFooterBand();
         this.xrLabel36 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel32 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLine3 = new DevExpress.XtraReports.UI.XRLine();
         this.xrLabel33 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel34 = new DevExpress.XtraReports.UI.XRLabel();
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
         customSqlQuery2.Sql = "/* Query_FastStart */\r\nselect * from invoices where id = -1";
         customSqlQuery3.Name = "StaffLookUps";
         customSqlQuery3.Sql = "Select IsNull( LastName, \'\' ) + \' \' + IsNull( FirstName, \'\' ) StafName, Code Staf" +
    "fCode\r\nFrom Staff\r\nOrder By StafName";
         customSqlQuery4.Name = "PosInfoLookUps";
         customSqlQuery4.Sql = "Select Id, Code, Description from PosInfo";
         customSqlQuery5.Name = "Departments";
         customSqlQuery5.Sql = "------------------------\r\n-- Departments Lookup --\r\n------------------------\r\nSel" +
    "ect Id, Description\r\nFrom Department\r\n-- Order By Description\r\nOrder By Id\r\n\r\n\r\n" +
    "";
         customSqlQuery6.Name = "Accounts";
         customSqlQuery6.Sql = "---------------------\r\n-- Accounts Lookup --\r\n---------------------\r\nSelect Id, T" +
    "ype, Description\r\nFrom Accounts\r\nOrder By Description\r\n";
         customSqlQuery7.Name = "Pricelists";
         customSqlQuery7.Sql = "Select Id, Description From Pricelist";
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
            this.xrLabel17,
            this.xrLabel15,
            this.xrLabel12});
         this.Detail.HeightF = 18F;
         this.Detail.Name = "Detail";
         this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
         this.Detail.StyleName = "DataField";
         this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
         // 
         // xrLabel17
         // 
         this.xrLabel17.CanGrow = false;
         this.xrLabel17.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.Total", "{0:#,##0.00}")});
         this.xrLabel17.Font = new System.Drawing.Font("Times New Roman", 8F);
         this.xrLabel17.LocationFloat = new DevExpress.Utils.PointFloat(604.6017F, 0F);
         this.xrLabel17.Name = "xrLabel17";
         this.xrLabel17.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel17.SizeF = new System.Drawing.SizeF(145.3978F, 18F);
         this.xrLabel17.StylePriority.UseFont = false;
         this.xrLabel17.StylePriority.UseTextAlignment = false;
         this.xrLabel17.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
         this.xrLabel17.Visible = false;
         this.xrLabel17.WordWrap = false;
         // 
         // xrLabel15
         // 
         this.xrLabel15.CanGrow = false;
         this.xrLabel15.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.Qty", "{0:c2}")});
         this.xrLabel15.Font = new System.Drawing.Font("Times New Roman", 8F);
         this.xrLabel15.LocationFloat = new DevExpress.Utils.PointFloat(479.3509F, 0F);
         this.xrLabel15.Name = "xrLabel15";
         this.xrLabel15.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel15.SizeF = new System.Drawing.SizeF(125.2508F, 18F);
         this.xrLabel15.StylePriority.UseFont = false;
         this.xrLabel15.StylePriority.UseTextAlignment = false;
         this.xrLabel15.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
         this.xrLabel15.Visible = false;
         this.xrLabel15.WordWrap = false;
         // 
         // xrLabel12
         // 
         this.xrLabel12.CanGrow = false;
         this.xrLabel12.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.StafName")});
         this.xrLabel12.Font = new System.Drawing.Font("Times New Roman", 8F);
         this.xrLabel12.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
         this.xrLabel12.Name = "xrLabel12";
         this.xrLabel12.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel12.SizeF = new System.Drawing.SizeF(206.4187F, 18F);
         this.xrLabel12.StylePriority.UseFont = false;
         this.xrLabel12.Text = "[ProductCode]";
         this.xrLabel12.Visible = false;
         this.xrLabel12.WordWrap = false;
         // 
         // TopMargin
         // 
         this.TopMargin.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrPageInfo3});
         this.TopMargin.HeightF = 57.00001F;
         this.TopMargin.Name = "TopMargin";
         this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
         this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
         // 
         // xrPageInfo3
         // 
         this.xrPageInfo3.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
         this.xrPageInfo3.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
         this.xrPageInfo3.Format = "Ημερομηνία Εκτύπωσης : {0:dddd, d MMMM yyyy h:mm:ss tt}";
         this.xrPageInfo3.LocationFloat = new DevExpress.Utils.PointFloat(0F, 38.2373F);
         this.xrPageInfo3.Name = "xrPageInfo3";
         this.xrPageInfo3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrPageInfo3.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime;
         this.xrPageInfo3.SizeF = new System.Drawing.SizeF(750F, 18.76271F);
         this.xrPageInfo3.StylePriority.UseBorders = false;
         this.xrPageInfo3.StylePriority.UseFont = false;
         // 
         // BottomMargin
         // 
         this.BottomMargin.HeightF = 37F;
         this.BottomMargin.Name = "BottomMargin";
         this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
         this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
         // 
         // StaffCode_GroupHeader
         // 
         this.StaffCode_GroupHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel4,
            this.xrLabel9,
            this.xrLabel2,
            this.xrLabel18});
         this.StaffCode_GroupHeader.Font = new System.Drawing.Font("Times New Roman", 8F);
         this.StaffCode_GroupHeader.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("StaffCode", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
         this.StaffCode_GroupHeader.HeightF = 21.41667F;
         this.StaffCode_GroupHeader.Name = "StaffCode_GroupHeader";
         this.StaffCode_GroupHeader.StylePriority.UseFont = false;
         // 
         // xrLabel4
         // 
         this.xrLabel4.BackColor = System.Drawing.Color.White;
         this.xrLabel4.CanGrow = false;
         this.xrLabel4.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.Cover")});
         this.xrLabel4.Font = new System.Drawing.Font("Arial", 8F);
         this.xrLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
         this.xrLabel4.LocationFloat = new DevExpress.Utils.PointFloat(377.7137F, 0F);
         this.xrLabel4.Name = "xrLabel4";
         this.xrLabel4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel4.SizeF = new System.Drawing.SizeF(101.6372F, 21.41667F);
         this.xrLabel4.StyleName = "FieldCaption";
         this.xrLabel4.StylePriority.UseBackColor = false;
         this.xrLabel4.StylePriority.UseFont = false;
         this.xrLabel4.StylePriority.UseForeColor = false;
         this.xrLabel4.StylePriority.UseTextAlignment = false;
         xrSummary1.FormatString = "{0}";
         xrSummary1.IgnoreNullValues = true;
         xrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
         this.xrLabel4.Summary = xrSummary1;
         this.xrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
         this.xrLabel4.WordWrap = false;
         // 
         // xrLabel9
         // 
         this.xrLabel9.BackColor = System.Drawing.Color.White;
         this.xrLabel9.CanGrow = false;
         this.xrLabel9.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.Qty")});
         this.xrLabel9.Font = new System.Drawing.Font("Arial", 8F);
         this.xrLabel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
         this.xrLabel9.LocationFloat = new DevExpress.Utils.PointFloat(479.3509F, 0F);
         this.xrLabel9.Name = "xrLabel9";
         this.xrLabel9.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel9.SizeF = new System.Drawing.SizeF(125.2508F, 21.41667F);
         this.xrLabel9.StyleName = "FieldCaption";
         this.xrLabel9.StylePriority.UseBackColor = false;
         this.xrLabel9.StylePriority.UseFont = false;
         this.xrLabel9.StylePriority.UseForeColor = false;
         this.xrLabel9.StylePriority.UseTextAlignment = false;
         xrSummary2.FormatString = "{0}";
         xrSummary2.IgnoreNullValues = true;
         xrSummary2.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
         this.xrLabel9.Summary = xrSummary2;
         this.xrLabel9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
         this.xrLabel9.WordWrap = false;
         // 
         // xrLabel2
         // 
         this.xrLabel2.BackColor = System.Drawing.Color.White;
         this.xrLabel2.CanGrow = false;
         this.xrLabel2.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.PricelistDescription", "{0}")});
         this.xrLabel2.Font = new System.Drawing.Font("Times New Roman", 8F);
         this.xrLabel2.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
         this.xrLabel2.Name = "xrLabel2";
         this.xrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel2.SizeF = new System.Drawing.SizeF(377.7137F, 21.41667F);
         this.xrLabel2.StyleName = "DataField";
         this.xrLabel2.StylePriority.UseBackColor = false;
         this.xrLabel2.StylePriority.UseFont = false;
         this.xrLabel2.StylePriority.UseTextAlignment = false;
         this.xrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
         this.xrLabel2.WordWrap = false;
         // 
         // xrLabel18
         // 
         this.xrLabel18.BackColor = System.Drawing.Color.White;
         this.xrLabel18.CanGrow = false;
         this.xrLabel18.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.Total")});
         this.xrLabel18.Font = new System.Drawing.Font("Arial", 10F);
         this.xrLabel18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
         this.xrLabel18.LocationFloat = new DevExpress.Utils.PointFloat(604.6017F, 0F);
         this.xrLabel18.Name = "xrLabel18";
         this.xrLabel18.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel18.SizeF = new System.Drawing.SizeF(145.3978F, 21.41667F);
         this.xrLabel18.StyleName = "FieldCaption";
         this.xrLabel18.StylePriority.UseBackColor = false;
         this.xrLabel18.StylePriority.UseFont = false;
         this.xrLabel18.StylePriority.UseForeColor = false;
         this.xrLabel18.StylePriority.UseTextAlignment = false;
         xrSummary3.FormatString = "{0:#,##0.00}";
         xrSummary3.IgnoreNullValues = true;
         xrSummary3.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
         this.xrLabel18.Summary = xrSummary3;
         this.xrLabel18.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
         this.xrLabel18.WordWrap = false;
         // 
         // pageFooterBand1
         // 
         this.pageFooterBand1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrPageInfo1});
         this.pageFooterBand1.HeightF = 20.15045F;
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
         this.xrPageInfo1.SizeF = new System.Drawing.SizeF(749.9995F, 18.76271F);
         this.xrPageInfo1.StylePriority.UseBorders = false;
         this.xrPageInfo1.StylePriority.UseFont = false;
         this.xrPageInfo1.StylePriority.UseTextAlignment = false;
         this.xrPageInfo1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
         // 
         // reportHeaderBand1
         // 
         this.reportHeaderBand1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel1,
            this.xrLabel30,
            this.xrLabel21});
         this.reportHeaderBand1.HeightF = 53.47669F;
         this.reportHeaderBand1.Name = "reportHeaderBand1";
         // 
         // xrLabel1
         // 
         this.xrLabel1.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding(this.FromFODay, "Text", "(από {0}")});
         this.xrLabel1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
         this.xrLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
         this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 26F);
         this.xrLabel1.Name = "xrLabel1";
         this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel1.SizeF = new System.Drawing.SizeF(372.3067F, 22.58333F);
         this.xrLabel1.StyleName = "Title";
         this.xrLabel1.StylePriority.UseFont = false;
         this.xrLabel1.StylePriority.UseForeColor = false;
         this.xrLabel1.StylePriority.UseTextAlignment = false;
         this.xrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
         // 
         // FromFODay
         // 
         this.FromFODay.Description = "From Date";
         this.FromFODay.Name = "FromFODay";
         this.FromFODay.Type = typeof(System.DateTime);
         this.FromFODay.ValueInfo = "2016-05-31";
         // 
         // xrLabel30
         // 
         this.xrLabel30.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding(this.UpToFODay, "Text", " έως {0})")});
         this.xrLabel30.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
         this.xrLabel30.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
         this.xrLabel30.LocationFloat = new DevExpress.Utils.PointFloat(372.3067F, 26F);
         this.xrLabel30.Name = "xrLabel30";
         this.xrLabel30.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel30.SizeF = new System.Drawing.SizeF(377.6928F, 22.58333F);
         this.xrLabel30.StyleName = "Title";
         this.xrLabel30.StylePriority.UseFont = false;
         this.xrLabel30.StylePriority.UseForeColor = false;
         this.xrLabel30.StylePriority.UseTextAlignment = false;
         this.xrLabel30.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
         // 
         // UpToFODay
         // 
         this.UpToFODay.Description = "UpTo Date";
         this.UpToFODay.Name = "UpToFODay";
         this.UpToFODay.Type = typeof(System.DateTime);
         this.UpToFODay.ValueInfo = "2016-05-31";
         // 
         // xrLabel21
         // 
         this.xrLabel21.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
         this.xrLabel21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
         this.xrLabel21.LocationFloat = new DevExpress.Utils.PointFloat(0F, 3F);
         this.xrLabel21.Name = "xrLabel21";
         this.xrLabel21.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel21.SizeF = new System.Drawing.SizeF(749.9995F, 22.58333F);
         this.xrLabel21.StyleName = "Title";
         this.xrLabel21.StylePriority.UseFont = false;
         this.xrLabel21.StylePriority.UseForeColor = false;
         this.xrLabel21.StylePriority.UseTextAlignment = false;
         this.xrLabel21.Text = "Πωλήσεις ανά Τιμοκατάλογο και Άτομα - Συνοπτικά";
         this.xrLabel21.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
         // 
         // groupFooterBand1
         // 
         this.groupFooterBand1.HeightF = 1F;
         this.groupFooterBand1.Name = "groupFooterBand1";
         // 
         // groupFooterBand2
         // 
         this.groupFooterBand2.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel5,
            this.xrLine5,
            this.xrLabel22,
            this.xrLabel23,
            this.xrLabel24});
         this.groupFooterBand2.HeightF = 27.88136F;
         this.groupFooterBand2.Level = 1;
         this.groupFooterBand2.Name = "groupFooterBand2";
         this.groupFooterBand2.Visible = false;
         // 
         // xrLabel5
         // 
         this.xrLabel5.CanGrow = false;
         this.xrLabel5.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.Cover")});
         this.xrLabel5.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
         this.xrLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
         this.xrLabel5.LocationFloat = new DevExpress.Utils.PointFloat(377.7137F, 6.00001F);
         this.xrLabel5.Name = "xrLabel5";
         this.xrLabel5.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel5.SizeF = new System.Drawing.SizeF(101.6372F, 18F);
         this.xrLabel5.StyleName = "FieldCaption";
         this.xrLabel5.StylePriority.UseFont = false;
         this.xrLabel5.StylePriority.UseForeColor = false;
         this.xrLabel5.StylePriority.UseTextAlignment = false;
         xrSummary4.IgnoreNullValues = true;
         xrSummary4.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
         this.xrLabel5.Summary = xrSummary4;
         this.xrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
         this.xrLabel5.WordWrap = false;
         // 
         // xrLine5
         // 
         this.xrLine5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
         this.xrLine5.LocationFloat = new DevExpress.Utils.PointFloat(0F, 4.00001F);
         this.xrLine5.Name = "xrLine5";
         this.xrLine5.SizeF = new System.Drawing.SizeF(749.9995F, 2F);
         this.xrLine5.StylePriority.UseForeColor = false;
         // 
         // xrLabel22
         // 
         this.xrLabel22.CanGrow = false;
         this.xrLabel22.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.Qty")});
         this.xrLabel22.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
         this.xrLabel22.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
         this.xrLabel22.LocationFloat = new DevExpress.Utils.PointFloat(479.3509F, 6.00001F);
         this.xrLabel22.Name = "xrLabel22";
         this.xrLabel22.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel22.SizeF = new System.Drawing.SizeF(125.2513F, 18F);
         this.xrLabel22.StyleName = "FieldCaption";
         this.xrLabel22.StylePriority.UseFont = false;
         this.xrLabel22.StylePriority.UseForeColor = false;
         this.xrLabel22.StylePriority.UseTextAlignment = false;
         xrSummary5.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
         this.xrLabel22.Summary = xrSummary5;
         this.xrLabel22.Text = "xrLabel22";
         this.xrLabel22.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
         this.xrLabel22.WordWrap = false;
         // 
         // xrLabel23
         // 
         this.xrLabel23.CanGrow = false;
         this.xrLabel23.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.Total")});
         this.xrLabel23.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
         this.xrLabel23.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
         this.xrLabel23.LocationFloat = new DevExpress.Utils.PointFloat(604.6022F, 6.00001F);
         this.xrLabel23.Name = "xrLabel23";
         this.xrLabel23.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel23.SizeF = new System.Drawing.SizeF(145.3973F, 18F);
         this.xrLabel23.StyleName = "FieldCaption";
         this.xrLabel23.StylePriority.UseFont = false;
         this.xrLabel23.StylePriority.UseForeColor = false;
         this.xrLabel23.StylePriority.UseTextAlignment = false;
         xrSummary6.FormatString = "{0:#,##0.00}";
         xrSummary6.IgnoreNullValues = true;
         xrSummary6.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
         this.xrLabel23.Summary = xrSummary6;
         this.xrLabel23.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
         this.xrLabel23.WordWrap = false;
         // 
         // xrLabel24
         // 
         this.xrLabel24.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
         this.xrLabel24.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
         this.xrLabel24.LocationFloat = new DevExpress.Utils.PointFloat(0F, 6.00001F);
         this.xrLabel24.Name = "xrLabel24";
         this.xrLabel24.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel24.SizeF = new System.Drawing.SizeF(377.7137F, 18F);
         this.xrLabel24.StyleName = "FieldCaption";
         this.xrLabel24.StylePriority.UseFont = false;
         this.xrLabel24.StylePriority.UseForeColor = false;
         this.xrLabel24.Text = "Γενικά Σύνολα";
         // 
         // reportFooterBand1
         // 
         this.reportFooterBand1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
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
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.Cover")});
         this.xrLabel31.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
         this.xrLabel31.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
         this.xrLabel31.LocationFloat = new DevExpress.Utils.PointFloat(377.7137F, 6.00001F);
         this.xrLabel31.Name = "xrLabel31";
         this.xrLabel31.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel31.SizeF = new System.Drawing.SizeF(101.6372F, 18F);
         this.xrLabel31.StyleName = "FieldCaption";
         this.xrLabel31.StylePriority.UseBackColor = false;
         this.xrLabel31.StylePriority.UseFont = false;
         this.xrLabel31.StylePriority.UseForeColor = false;
         this.xrLabel31.StylePriority.UseTextAlignment = false;
         xrSummary7.IgnoreNullValues = true;
         xrSummary7.Running = DevExpress.XtraReports.UI.SummaryRunning.Report;
         this.xrLabel31.Summary = xrSummary7;
         this.xrLabel31.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
         this.xrLabel31.WordWrap = false;
         // 
         // xrLine6
         // 
         this.xrLine6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
         this.xrLine6.LocationFloat = new DevExpress.Utils.PointFloat(0F, 4.00001F);
         this.xrLine6.Name = "xrLine6";
         this.xrLine6.SizeF = new System.Drawing.SizeF(749.9995F, 2F);
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
         this.xrLabel25.LocationFloat = new DevExpress.Utils.PointFloat(479.3509F, 6.00001F);
         this.xrLabel25.Name = "xrLabel25";
         this.xrLabel25.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel25.SizeF = new System.Drawing.SizeF(125.2508F, 18F);
         this.xrLabel25.StyleName = "FieldCaption";
         this.xrLabel25.StylePriority.UseBackColor = false;
         this.xrLabel25.StylePriority.UseFont = false;
         this.xrLabel25.StylePriority.UseForeColor = false;
         this.xrLabel25.StylePriority.UseTextAlignment = false;
         xrSummary8.Running = DevExpress.XtraReports.UI.SummaryRunning.Report;
         this.xrLabel25.Summary = xrSummary8;
         this.xrLabel25.Text = "xrLabel25";
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
         this.xrLabel26.LocationFloat = new DevExpress.Utils.PointFloat(604.6027F, 6.00001F);
         this.xrLabel26.Name = "xrLabel26";
         this.xrLabel26.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel26.SizeF = new System.Drawing.SizeF(145.3983F, 18F);
         this.xrLabel26.StyleName = "FieldCaption";
         this.xrLabel26.StylePriority.UseBackColor = false;
         this.xrLabel26.StylePriority.UseFont = false;
         this.xrLabel26.StylePriority.UseForeColor = false;
         this.xrLabel26.StylePriority.UseTextAlignment = false;
         xrSummary9.FormatString = "{0:#,##0.00}";
         xrSummary9.IgnoreNullValues = true;
         xrSummary9.Running = DevExpress.XtraReports.UI.SummaryRunning.Report;
         this.xrLabel26.Summary = xrSummary9;
         this.xrLabel26.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
         this.xrLabel26.WordWrap = false;
         // 
         // xrLabel27
         // 
         this.xrLabel27.BackColor = System.Drawing.Color.LightGray;
         this.xrLabel27.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
         this.xrLabel27.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
         this.xrLabel27.LocationFloat = new DevExpress.Utils.PointFloat(0F, 6.00001F);
         this.xrLabel27.Name = "xrLabel27";
         this.xrLabel27.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel27.SizeF = new System.Drawing.SizeF(377.7137F, 18F);
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
         // xrLine2
         // 
         this.xrLine2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
         this.xrLine2.LocationFloat = new DevExpress.Utils.PointFloat(0F, 25F);
         this.xrLine2.Name = "xrLine2";
         this.xrLine2.SizeF = new System.Drawing.SizeF(750F, 2F);
         this.xrLine2.StylePriority.UseForeColor = false;
         // 
         // xrLine1
         // 
         this.xrLine1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
         this.xrLine1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 5F);
         this.xrLine1.Name = "xrLine1";
         this.xrLine1.SizeF = new System.Drawing.SizeF(750.001F, 2F);
         this.xrLine1.StylePriority.UseForeColor = false;
         // 
         // xrLabel8
         // 
         this.xrLabel8.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
         this.xrLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
         this.xrLabel8.LocationFloat = new DevExpress.Utils.PointFloat(604.6017F, 7.000001F);
         this.xrLabel8.Name = "xrLabel8";
         this.xrLabel8.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel8.SizeF = new System.Drawing.SizeF(145.3978F, 18F);
         this.xrLabel8.StylePriority.UseFont = false;
         this.xrLabel8.StylePriority.UseForeColor = false;
         this.xrLabel8.StylePriority.UseTextAlignment = false;
         this.xrLabel8.Text = "Σύνολο";
         this.xrLabel8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
         // 
         // xrLabel7
         // 
         this.xrLabel7.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
         this.xrLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
         this.xrLabel7.LocationFloat = new DevExpress.Utils.PointFloat(377.7137F, 7.000001F);
         this.xrLabel7.Name = "xrLabel7";
         this.xrLabel7.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel7.SizeF = new System.Drawing.SizeF(101.6372F, 18F);
         this.xrLabel7.StylePriority.UseFont = false;
         this.xrLabel7.StylePriority.UseForeColor = false;
         this.xrLabel7.StylePriority.UseTextAlignment = false;
         this.xrLabel7.Text = "Couver";
         this.xrLabel7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
         // 
         // xrLabel6
         // 
         this.xrLabel6.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
         this.xrLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
         this.xrLabel6.LocationFloat = new DevExpress.Utils.PointFloat(479.3509F, 7.000001F);
         this.xrLabel6.Name = "xrLabel6";
         this.xrLabel6.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel6.SizeF = new System.Drawing.SizeF(125.2508F, 18F);
         this.xrLabel6.StylePriority.UseFont = false;
         this.xrLabel6.StylePriority.UseForeColor = false;
         this.xrLabel6.StylePriority.UseTextAlignment = false;
         this.xrLabel6.Text = "Ποσότητα";
         this.xrLabel6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
         // 
         // xrLabel3
         // 
         this.xrLabel3.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
         this.xrLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
         this.xrLabel3.LocationFloat = new DevExpress.Utils.PointFloat(0F, 7.000001F);
         this.xrLabel3.Name = "xrLabel3";
         this.xrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel3.SizeF = new System.Drawing.SizeF(377.7137F, 18F);
         this.xrLabel3.StylePriority.UseFont = false;
         this.xrLabel3.StylePriority.UseForeColor = false;
         this.xrLabel3.Text = "Τιμοκατάλογος";
         // 
         // groupHeaderBand2
         // 
         this.groupHeaderBand2.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel3,
            this.xrLabel6,
            this.xrLabel7,
            this.xrLabel8,
            this.xrLine1,
            this.xrLine2});
         this.groupHeaderBand2.HeightF = 27F;
         this.groupHeaderBand2.Level = 1;
         this.groupHeaderBand2.Name = "groupHeaderBand2";
         this.groupHeaderBand2.StyleName = "FieldCaption";
         // 
         // sqlDataSource2
         // 
         this.sqlDataSource2.ConnectionName = "ReportConnection";
         this.sqlDataSource2.Name = "sqlDataSource2";
         customSqlQuery8.Name = "Query";
         queryParameter3.Name = "FromDate";
         queryParameter3.Type = typeof(DevExpress.DataAccess.Expression);
         queryParameter3.Value = new DevExpress.DataAccess.Expression("[Parameters.FromFODay]", typeof(System.DateTime));
         queryParameter4.Name = "ToDate";
         queryParameter4.Type = typeof(DevExpress.DataAccess.Expression);
         queryParameter4.Value = new DevExpress.DataAccess.Expression("[Parameters.UpToFODay]", typeof(System.DateTime));
         customSqlQuery8.Parameters.Add(queryParameter3);
         customSqlQuery8.Parameters.Add(queryParameter4);
         customSqlQuery8.Sql = resources.GetString("customSqlQuery8.Sql");
         this.sqlDataSource2.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            customSqlQuery8});
         this.sqlDataSource2.ResultSchemaSerializable = resources.GetString("sqlDataSource2.ResultSchemaSerializable");
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
         // 
         // POS_GroupHeader
         // 
         this.POS_GroupHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel11});
         this.POS_GroupHeader.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("PosInfoId", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
         this.POS_GroupHeader.HeightF = 17F;
         this.POS_GroupHeader.Level = 3;
         this.POS_GroupHeader.Name = "POS_GroupHeader";
         // 
         // xrLabel11
         // 
         this.xrLabel11.BackColor = System.Drawing.Color.DarkGray;
         this.xrLabel11.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.PosInfoDescription", "POS : {0}")});
         this.xrLabel11.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold);
         this.xrLabel11.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
         this.xrLabel11.Name = "xrLabel11";
         this.xrLabel11.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel11.SizeF = new System.Drawing.SizeF(749.9995F, 17F);
         this.xrLabel11.StyleName = "DataField";
         this.xrLabel11.StylePriority.UseBackColor = false;
         this.xrLabel11.StylePriority.UseFont = false;
         this.xrLabel11.StylePriority.UseTextAlignment = false;
         this.xrLabel11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
         this.xrLabel11.WordWrap = false;
         // 
         // POS_GroupFooter
         // 
         this.POS_GroupFooter.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel35,
            this.xrLabel29,
            this.xrLabel28,
            this.xrLine7,
            this.xrLabel20});
         this.POS_GroupFooter.HeightF = 26.23371F;
         this.POS_GroupFooter.Level = 3;
         this.POS_GroupFooter.Name = "POS_GroupFooter";
         // 
         // xrLabel35
         // 
         this.xrLabel35.CanGrow = false;
         this.xrLabel35.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.Cover")});
         this.xrLabel35.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
         this.xrLabel35.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
         this.xrLabel35.LocationFloat = new DevExpress.Utils.PointFloat(377.7137F, 2F);
         this.xrLabel35.Name = "xrLabel35";
         this.xrLabel35.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel35.SizeF = new System.Drawing.SizeF(101.6372F, 18F);
         this.xrLabel35.StyleName = "FieldCaption";
         this.xrLabel35.StylePriority.UseFont = false;
         this.xrLabel35.StylePriority.UseForeColor = false;
         this.xrLabel35.StylePriority.UseTextAlignment = false;
         xrSummary10.IgnoreNullValues = true;
         xrSummary10.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
         this.xrLabel35.Summary = xrSummary10;
         this.xrLabel35.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
         this.xrLabel35.WordWrap = false;
         // 
         // xrLabel29
         // 
         this.xrLabel29.CanGrow = false;
         this.xrLabel29.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.Total")});
         this.xrLabel29.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
         this.xrLabel29.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
         this.xrLabel29.LocationFloat = new DevExpress.Utils.PointFloat(604.6022F, 2F);
         this.xrLabel29.Name = "xrLabel29";
         this.xrLabel29.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel29.SizeF = new System.Drawing.SizeF(145.3973F, 18F);
         this.xrLabel29.StyleName = "FieldCaption";
         this.xrLabel29.StylePriority.UseFont = false;
         this.xrLabel29.StylePriority.UseForeColor = false;
         this.xrLabel29.StylePriority.UseTextAlignment = false;
         xrSummary11.FormatString = "{0:#,##0.00}";
         xrSummary11.IgnoreNullValues = true;
         xrSummary11.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
         this.xrLabel29.Summary = xrSummary11;
         this.xrLabel29.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
         this.xrLabel29.WordWrap = false;
         // 
         // xrLabel28
         // 
         this.xrLabel28.CanGrow = false;
         this.xrLabel28.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.Qty")});
         this.xrLabel28.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
         this.xrLabel28.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
         this.xrLabel28.LocationFloat = new DevExpress.Utils.PointFloat(479.3509F, 2F);
         this.xrLabel28.Name = "xrLabel28";
         this.xrLabel28.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel28.SizeF = new System.Drawing.SizeF(125.2508F, 18F);
         this.xrLabel28.StyleName = "FieldCaption";
         this.xrLabel28.StylePriority.UseFont = false;
         this.xrLabel28.StylePriority.UseForeColor = false;
         this.xrLabel28.StylePriority.UseTextAlignment = false;
         xrSummary12.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
         this.xrLabel28.Summary = xrSummary12;
         this.xrLabel28.Text = "xrLabel22";
         this.xrLabel28.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
         this.xrLabel28.WordWrap = false;
         // 
         // xrLine7
         // 
         this.xrLine7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
         this.xrLine7.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
         this.xrLine7.Name = "xrLine7";
         this.xrLine7.SizeF = new System.Drawing.SizeF(749.9995F, 2F);
         this.xrLine7.StylePriority.UseForeColor = false;
         // 
         // xrLabel20
         // 
         this.xrLabel20.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
         this.xrLabel20.LocationFloat = new DevExpress.Utils.PointFloat(0F, 2F);
         this.xrLabel20.Name = "xrLabel20";
         this.xrLabel20.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel20.SizeF = new System.Drawing.SizeF(377.7137F, 18F);
         this.xrLabel20.StylePriority.UseFont = false;
         this.xrLabel20.StylePriority.UseTextAlignment = false;
         this.xrLabel20.Text = "Σύνολα POS : ";
         this.xrLabel20.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
         // 
         // DepartmentId
         // 
         this.DepartmentId.Description = "Select Department";
         dynamicListLookUpSettings2.DataAdapter = null;
         dynamicListLookUpSettings2.DataMember = "Departments";
         dynamicListLookUpSettings2.DataSource = this.sqlDataSource1;
         dynamicListLookUpSettings2.DisplayMember = "Description";
         dynamicListLookUpSettings2.ValueMember = "Id";
         this.DepartmentId.LookUpSettings = dynamicListLookUpSettings2;
         this.DepartmentId.MultiValue = true;
         this.DepartmentId.Name = "DepartmentId";
         this.DepartmentId.Type = typeof(long);
         // 
         // Pricelist
         // 
         this.Pricelist.Description = "Select Pricelist";
         dynamicListLookUpSettings3.DataAdapter = null;
         dynamicListLookUpSettings3.DataMember = "Pricelists";
         dynamicListLookUpSettings3.DataSource = this.sqlDataSource1;
         dynamicListLookUpSettings3.DisplayMember = "Description";
         dynamicListLookUpSettings3.ValueMember = "Id";
         this.Pricelist.LookUpSettings = dynamicListLookUpSettings3;
         this.Pricelist.MultiValue = true;
         this.Pricelist.Name = "Pricelist";
         this.Pricelist.Type = typeof(long);
         // 
         // Department_GroupHeader
         // 
         this.Department_GroupHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel10});
         this.Department_GroupHeader.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("DepartmentId", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
         this.Department_GroupHeader.HeightF = 16F;
         this.Department_GroupHeader.Level = 4;
         this.Department_GroupHeader.Name = "Department_GroupHeader";
         // 
         // xrLabel10
         // 
         this.xrLabel10.BackColor = System.Drawing.Color.Gray;
         this.xrLabel10.Borders = DevExpress.XtraPrinting.BorderSide.None;
         this.xrLabel10.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.DepartmentDescription", "Department: {0}")});
         this.xrLabel10.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
         this.xrLabel10.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
         this.xrLabel10.Name = "xrLabel10";
         this.xrLabel10.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel10.SizeF = new System.Drawing.SizeF(749.9995F, 16F);
         this.xrLabel10.StyleName = "DataField";
         this.xrLabel10.StylePriority.UseBackColor = false;
         this.xrLabel10.StylePriority.UseBorders = false;
         this.xrLabel10.StylePriority.UseFont = false;
         this.xrLabel10.StylePriority.UseTextAlignment = false;
         this.xrLabel10.Text = "xrLabel2";
         this.xrLabel10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
         // 
         // Pricelist_GroupHeader
         // 
         this.Pricelist_GroupHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel37,
            this.xrLabel38,
            this.xrLabel39,
            this.xrLabel19});
         this.Pricelist_GroupHeader.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("PricelistId", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
         this.Pricelist_GroupHeader.HeightF = 17F;
         this.Pricelist_GroupHeader.Level = 2;
         this.Pricelist_GroupHeader.Name = "Pricelist_GroupHeader";
         // 
         // xrLabel37
         // 
         this.xrLabel37.BackColor = System.Drawing.Color.Silver;
         this.xrLabel37.CanGrow = false;
         this.xrLabel37.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.Cover")});
         this.xrLabel37.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold);
         this.xrLabel37.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
         this.xrLabel37.LocationFloat = new DevExpress.Utils.PointFloat(377.7137F, 0F);
         this.xrLabel37.Name = "xrLabel37";
         this.xrLabel37.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel37.SizeF = new System.Drawing.SizeF(101.6372F, 17F);
         this.xrLabel37.StyleName = "FieldCaption";
         this.xrLabel37.StylePriority.UseBackColor = false;
         this.xrLabel37.StylePriority.UseFont = false;
         this.xrLabel37.StylePriority.UseForeColor = false;
         this.xrLabel37.StylePriority.UseTextAlignment = false;
         xrSummary13.IgnoreNullValues = true;
         xrSummary13.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
         this.xrLabel37.Summary = xrSummary13;
         this.xrLabel37.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
         this.xrLabel37.WordWrap = false;
         // 
         // xrLabel38
         // 
         this.xrLabel38.BackColor = System.Drawing.Color.Silver;
         this.xrLabel38.CanGrow = false;
         this.xrLabel38.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.Qty")});
         this.xrLabel38.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold);
         this.xrLabel38.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
         this.xrLabel38.LocationFloat = new DevExpress.Utils.PointFloat(479.3509F, 0F);
         this.xrLabel38.Name = "xrLabel38";
         this.xrLabel38.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel38.SizeF = new System.Drawing.SizeF(125.2513F, 17F);
         this.xrLabel38.StyleName = "FieldCaption";
         this.xrLabel38.StylePriority.UseBackColor = false;
         this.xrLabel38.StylePriority.UseFont = false;
         this.xrLabel38.StylePriority.UseForeColor = false;
         this.xrLabel38.StylePriority.UseTextAlignment = false;
         xrSummary14.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
         this.xrLabel38.Summary = xrSummary14;
         this.xrLabel38.Text = "xrLabel22";
         this.xrLabel38.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
         this.xrLabel38.WordWrap = false;
         // 
         // xrLabel39
         // 
         this.xrLabel39.BackColor = System.Drawing.Color.Silver;
         this.xrLabel39.CanGrow = false;
         this.xrLabel39.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.Total")});
         this.xrLabel39.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold);
         this.xrLabel39.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
         this.xrLabel39.LocationFloat = new DevExpress.Utils.PointFloat(604.6017F, 0F);
         this.xrLabel39.Name = "xrLabel39";
         this.xrLabel39.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel39.SizeF = new System.Drawing.SizeF(145.3973F, 17F);
         this.xrLabel39.StyleName = "FieldCaption";
         this.xrLabel39.StylePriority.UseBackColor = false;
         this.xrLabel39.StylePriority.UseFont = false;
         this.xrLabel39.StylePriority.UseForeColor = false;
         this.xrLabel39.StylePriority.UseTextAlignment = false;
         xrSummary15.FormatString = "{0:#,##0.00}";
         xrSummary15.IgnoreNullValues = true;
         xrSummary15.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
         this.xrLabel39.Summary = xrSummary15;
         this.xrLabel39.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
         this.xrLabel39.WordWrap = false;
         // 
         // xrLabel19
         // 
         this.xrLabel19.BackColor = System.Drawing.Color.Silver;
         this.xrLabel19.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.PricelistDescription", "Pricelist : {0}")});
         this.xrLabel19.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold);
         this.xrLabel19.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
         this.xrLabel19.Name = "xrLabel19";
         this.xrLabel19.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel19.SizeF = new System.Drawing.SizeF(377.7137F, 17F);
         this.xrLabel19.StyleName = "DataField";
         this.xrLabel19.StylePriority.UseBackColor = false;
         this.xrLabel19.StylePriority.UseFont = false;
         this.xrLabel19.StylePriority.UseTextAlignment = false;
         this.xrLabel19.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
         this.xrLabel19.WordWrap = false;
         // 
         // Department_GroupFooter
         // 
         this.Department_GroupFooter.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel36,
            this.xrLabel32,
            this.xrLine3,
            this.xrLabel33,
            this.xrLabel34});
         this.Department_GroupFooter.HeightF = 25.84748F;
         this.Department_GroupFooter.Level = 4;
         this.Department_GroupFooter.Name = "Department_GroupFooter";
         // 
         // xrLabel36
         // 
         this.xrLabel36.CanGrow = false;
         this.xrLabel36.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.Cover")});
         this.xrLabel36.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
         this.xrLabel36.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
         this.xrLabel36.LocationFloat = new DevExpress.Utils.PointFloat(377.7137F, 2F);
         this.xrLabel36.Name = "xrLabel36";
         this.xrLabel36.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel36.SizeF = new System.Drawing.SizeF(101.6372F, 18F);
         this.xrLabel36.StyleName = "FieldCaption";
         this.xrLabel36.StylePriority.UseFont = false;
         this.xrLabel36.StylePriority.UseForeColor = false;
         this.xrLabel36.StylePriority.UseTextAlignment = false;
         xrSummary16.IgnoreNullValues = true;
         xrSummary16.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
         this.xrLabel36.Summary = xrSummary16;
         this.xrLabel36.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
         this.xrLabel36.WordWrap = false;
         // 
         // xrLabel32
         // 
         this.xrLabel32.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
         this.xrLabel32.LocationFloat = new DevExpress.Utils.PointFloat(0F, 2F);
         this.xrLabel32.Name = "xrLabel32";
         this.xrLabel32.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel32.SizeF = new System.Drawing.SizeF(377.7137F, 18F);
         this.xrLabel32.StylePriority.UseFont = false;
         this.xrLabel32.StylePriority.UseTextAlignment = false;
         this.xrLabel32.Text = "Σύνολα Department : ";
         this.xrLabel32.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
         // 
         // xrLine3
         // 
         this.xrLine3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
         this.xrLine3.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
         this.xrLine3.Name = "xrLine3";
         this.xrLine3.SizeF = new System.Drawing.SizeF(749.9995F, 2F);
         this.xrLine3.StylePriority.UseForeColor = false;
         // 
         // xrLabel33
         // 
         this.xrLabel33.CanGrow = false;
         this.xrLabel33.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.Qty")});
         this.xrLabel33.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
         this.xrLabel33.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
         this.xrLabel33.LocationFloat = new DevExpress.Utils.PointFloat(479.3509F, 2F);
         this.xrLabel33.Name = "xrLabel33";
         this.xrLabel33.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel33.SizeF = new System.Drawing.SizeF(125.2513F, 18F);
         this.xrLabel33.StyleName = "FieldCaption";
         this.xrLabel33.StylePriority.UseFont = false;
         this.xrLabel33.StylePriority.UseForeColor = false;
         this.xrLabel33.StylePriority.UseTextAlignment = false;
         xrSummary17.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
         this.xrLabel33.Summary = xrSummary17;
         this.xrLabel33.Text = "xrLabel22";
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
         this.xrLabel34.LocationFloat = new DevExpress.Utils.PointFloat(604.6022F, 2F);
         this.xrLabel34.Name = "xrLabel34";
         this.xrLabel34.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel34.SizeF = new System.Drawing.SizeF(145.3973F, 18F);
         this.xrLabel34.StyleName = "FieldCaption";
         this.xrLabel34.StylePriority.UseFont = false;
         this.xrLabel34.StylePriority.UseForeColor = false;
         this.xrLabel34.StylePriority.UseTextAlignment = false;
         xrSummary18.FormatString = "{0:#,##0.00}";
         xrSummary18.IgnoreNullValues = true;
         xrSummary18.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
         this.xrLabel34.Summary = xrSummary18;
         this.xrLabel34.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
         this.xrLabel34.WordWrap = false;
         // 
         // SalesPerPricelistCoverTotal
         // 
         this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.StaffCode_GroupHeader,
            this.groupHeaderBand2,
            this.pageFooterBand1,
            this.reportHeaderBand1,
            this.groupFooterBand2,
            this.reportFooterBand1,
            this.POS_GroupHeader,
            this.POS_GroupFooter,
            this.Department_GroupHeader,
            this.Pricelist_GroupHeader,
            this.Department_GroupFooter});
         this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.sqlDataSource1,
            this.sqlDataSource2});
         this.DataMember = "Query";
         this.DataSource = this.sqlDataSource1;
         this.FilterString = "[FODay] >= ?FromFODay And [FODay] <= ?UpToFODay And [DepartmentId] In (?Departmen" +
    "tId) And [PosInfoId] In (?PosInfoID) And [PricelistId] In (?Pricelist)";
         this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
         this.Margins = new System.Drawing.Printing.Margins(36, 40, 57, 37);
         this.PageHeight = 1169;
         this.PageWidth = 827;
         this.PaperKind = System.Drawing.Printing.PaperKind.A4;
         this.Parameters.AddRange(new DevExpress.XtraReports.Parameters.Parameter[] {
            this.FromFODay,
            this.UpToFODay,
            this.DepartmentId,
            this.PosInfoID,
            this.Pricelist});
         this.StyleSheet.AddRange(new DevExpress.XtraReports.UI.XRControlStyle[] {
            this.Title,
            this.FieldCaption,
            this.PageInfo,
            this.DataField});
         this.Version = "15.2";
         this.ParametersRequestBeforeShow += new System.EventHandler<DevExpress.XtraReports.Parameters.ParametersRequestEventArgs>(this.SalesPerPricelistCoverTotal_ParametersRequestBeforeShow);
         this.DataSourceDemanded += new System.EventHandler<System.EventArgs>(this.SalesPerPricelistCoverTotal_DataSourceDemanded);
         ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

      }

   #endregion

   ////////////////////////////////////////////////////////////////////////////////////////////////
   /// <summary>
   /// 
   /// </summary>
   /// <param name="sender"></param>
   /// <param name="e"></param>
   private void SalesPerPricelistCoverTotal_DataSourceDemanded( object sender, EventArgs e )
      {
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

      }

   ////////////////////////////////////////////////////////////////////////////////////////////////
   /// <summary>
   /// 
   /// </summary>
   /// <param name="sender"></param>
   /// <param name="e"></param>
   private void SalesPerPricelistCoverTotal_ParametersRequestBeforeShow( object sender
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
                  // select all values for parameter DepartmentId
                  paramItem.Parameter.Value = CommonTools.SetAllSelectedForMultiValueParameter<Int64>( sqlDataSource1, "Departments", "Id" );
                  break;

               case "StaffCode":
                  // select all values for parameter StaffCode
                  paramItem.Parameter.Value = CommonTools.SetAllSelectedForMultiValueParameter( sqlDataSource1, "StaffLookUps", "StaffCode" );
                  break;

               case "PosInfoID":
                  // select all values for parameter PosInfo
                  paramItem.Parameter.Value = CommonTools.SetAllSelectedForMultiValueParameter<Int64>( sqlDataSource1, "PosInfoLookUps", "Id" );
                  break;

               case "Pricelist":
                  // select all values for parameter Pricelist
                  paramItem.Parameter.Value = CommonTools.SetAllSelectedForMultiValueParameter<Int64>( sqlDataSource1, "Pricelists", "Id" );
                  break;

               case "AccountType":
                  // select all values for parameter AccountType
                  paramItem.Parameter.Value = CommonTools.SetAllSelectedForMultiValueParameter<Int16>( sqlDataSource1, "Accounts", "Type" );
                  break;

               default:
                  break;
               }

            }

         }

      }

   ////////////////////////////////////////////////////////////////////////////////////////////////
   }

