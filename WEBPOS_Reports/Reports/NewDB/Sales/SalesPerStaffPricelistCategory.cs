
using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

/// <summary>
/// Summary description for SalesPerStaffPricelistCategory
/// </summary>
public class SalesPerStaffPricelistCategory : DevExpress.XtraReports.UI.XtraReport
   {
   private DevExpress.XtraReports.UI.DetailBand Detail;
   private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
   private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
   private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
   private GroupHeaderBand POS_GroupHeader;
   private GroupHeaderBand groupHeaderBand3;
   private PageFooterBand pageFooterBand1;
   private ReportHeaderBand reportHeaderBand1;
   private GroupFooterBand groupFooterBand1;
   private GroupFooterBand POS_GroupFooter;
   private ReportFooterBand reportFooterBand1;
   private XRControlStyle Title;
   private XRControlStyle FieldCaption;
   private XRControlStyle PageInfo;
   private XRControlStyle DataField;
   private DevExpress.XtraReports.Parameters.Parameter FromDate;
   private DevExpress.XtraReports.Parameters.Parameter ToDate;
   private XRPageInfo xrPageInfo3;
   private DevExpress.XtraReports.Parameters.Parameter POS;
   private DevExpress.XtraReports.Parameters.Parameter StaffCode;
   private DevExpress.XtraReports.Parameters.Parameter Pricelist;
   private DevExpress.XtraReports.Parameters.Parameter Category;
   private XRPageInfo xrPageInfo1;
   private XRLabel xrLabel29;
   private XRLabel xrLabel42;
   private XRLabel xrLabel43;
   private XRLabel xrLabel46;
   private XRLabel xrLabel48;
   private XRLabel xrLabel49;
   private XRLabel xrLabel50;
   private XRLabel xrLabel51;
   private XRLine xrLine2;
   private XRLabel xrLabel15;
   private XRLine xrLine1;
   private XRLabel xrLabel17;
   private XRLabel xrLabel19;
   private XRLine xrLine6;
   private XRTable xrTable4;
   private XRTableRow xrTableRow4;
   private XRTableCell xrTableCell13;
   private XRTable xrTable6;
   private XRTableRow xrTableRow6;
   private XRTableCell xrTableCell17;
   private XRTableCell xrTableCell18;
   private XRTableCell xrTableCell20;
   private XRTableCell xrTableCell21;
   private XRTableCell xrTableCell19;
   private XRTable xrTable5;
   private XRTableRow xrTableRow5;
   private XRTableCell xrTableCell14;
   private XRTableCell xrTableCell15;
   private XRTableCell xrTableCell16;
   private XRTableCell xrTableCell3;
   private XRTableCell xrTableCell2;
   private XRTableCell xrTableCell8;
   private XRTableCell xrTableCell1;
   private XRTableRow xrTableRow1;
   private XRTable xrTable1;
   private GroupHeaderBand Staff_GroupHeader;
   private XRTableCell xrTableCell12;
   private XRTableCell xrTableCell11;
   private XRTableCell xrTableCell10;
   private XRTableCell xrTableCell9;
   private XRTableRow xrTableRow3;
   private XRTable xrTable3;
   private GroupHeaderBand Pricelist_GroupHeader;
   private XRTableCell xrTableCell7;
   private XRTableCell xrTableCell6;
   private XRTableCell xrTableCell5;
   private XRTableCell xrTableCell4;
   private XRTableRow xrTableRow2;
   private XRTable xrTable2;
   private GroupHeaderBand Category_GroupHeader;

   ////////////////////////////////////////////////////////////////////////////////////////////////
   /// <summary>
   /// Required designer variable.
   /// </summary>
   private System.ComponentModel.IContainer components = null;

   ////////////////////////////////////////////////////////////////////////////////////////////////
   /// <summary>
   /// 
   /// </summary>
   public SalesPerStaffPricelistCategory()
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
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalesPerStaffPricelistCategory));
         DevExpress.DataAccess.Sql.CustomSqlQuery customSqlQuery2 = new DevExpress.DataAccess.Sql.CustomSqlQuery();
         DevExpress.DataAccess.Sql.CustomSqlQuery customSqlQuery3 = new DevExpress.DataAccess.Sql.CustomSqlQuery();
         DevExpress.DataAccess.Sql.CustomSqlQuery customSqlQuery4 = new DevExpress.DataAccess.Sql.CustomSqlQuery();
         DevExpress.DataAccess.Sql.CustomSqlQuery customSqlQuery5 = new DevExpress.DataAccess.Sql.CustomSqlQuery();
         DevExpress.DataAccess.Sql.CustomSqlQuery customSqlQuery6 = new DevExpress.DataAccess.Sql.CustomSqlQuery();
         DevExpress.XtraReports.UI.XRSummary xrSummary1 = new DevExpress.XtraReports.UI.XRSummary();
         DevExpress.XtraReports.UI.XRSummary xrSummary2 = new DevExpress.XtraReports.UI.XRSummary();
         DevExpress.XtraReports.UI.XRSummary xrSummary3 = new DevExpress.XtraReports.UI.XRSummary();
         DevExpress.XtraReports.UI.XRSummary xrSummary4 = new DevExpress.XtraReports.UI.XRSummary();
         DevExpress.XtraReports.Parameters.DynamicListLookUpSettings dynamicListLookUpSettings1 = new DevExpress.XtraReports.Parameters.DynamicListLookUpSettings();
         DevExpress.XtraReports.Parameters.DynamicListLookUpSettings dynamicListLookUpSettings2 = new DevExpress.XtraReports.Parameters.DynamicListLookUpSettings();
         DevExpress.XtraReports.Parameters.DynamicListLookUpSettings dynamicListLookUpSettings3 = new DevExpress.XtraReports.Parameters.DynamicListLookUpSettings();
         DevExpress.XtraReports.Parameters.DynamicListLookUpSettings dynamicListLookUpSettings4 = new DevExpress.XtraReports.Parameters.DynamicListLookUpSettings();
         DevExpress.XtraReports.UI.XRSummary xrSummary5 = new DevExpress.XtraReports.UI.XRSummary();
         DevExpress.XtraReports.UI.XRSummary xrSummary6 = new DevExpress.XtraReports.UI.XRSummary();
         DevExpress.XtraReports.UI.XRSummary xrSummary7 = new DevExpress.XtraReports.UI.XRSummary();
         DevExpress.XtraReports.UI.XRSummary xrSummary8 = new DevExpress.XtraReports.UI.XRSummary();
         DevExpress.XtraReports.UI.XRSummary xrSummary9 = new DevExpress.XtraReports.UI.XRSummary();
         DevExpress.XtraReports.UI.XRSummary xrSummary10 = new DevExpress.XtraReports.UI.XRSummary();
         this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
         this.Detail = new DevExpress.XtraReports.UI.DetailBand();
         this.xrLabel46 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel48 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel49 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel50 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel51 = new DevExpress.XtraReports.UI.XRLabel();
         this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
         this.xrPageInfo3 = new DevExpress.XtraReports.UI.XRPageInfo();
         this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
         this.POS_GroupHeader = new DevExpress.XtraReports.UI.GroupHeaderBand();
         this.xrTable4 = new DevExpress.XtraReports.UI.XRTable();
         this.xrTableRow4 = new DevExpress.XtraReports.UI.XRTableRow();
         this.xrTableCell13 = new DevExpress.XtraReports.UI.XRTableCell();
         this.groupHeaderBand3 = new DevExpress.XtraReports.UI.GroupHeaderBand();
         this.xrTable6 = new DevExpress.XtraReports.UI.XRTable();
         this.xrTableRow6 = new DevExpress.XtraReports.UI.XRTableRow();
         this.xrTableCell17 = new DevExpress.XtraReports.UI.XRTableCell();
         this.xrTableCell18 = new DevExpress.XtraReports.UI.XRTableCell();
         this.xrTableCell20 = new DevExpress.XtraReports.UI.XRTableCell();
         this.xrTableCell21 = new DevExpress.XtraReports.UI.XRTableCell();
         this.xrTableCell19 = new DevExpress.XtraReports.UI.XRTableCell();
         this.xrLine2 = new DevExpress.XtraReports.UI.XRLine();
         this.pageFooterBand1 = new DevExpress.XtraReports.UI.PageFooterBand();
         this.xrPageInfo1 = new DevExpress.XtraReports.UI.XRPageInfo();
         this.reportHeaderBand1 = new DevExpress.XtraReports.UI.ReportHeaderBand();
         this.xrLabel29 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel42 = new DevExpress.XtraReports.UI.XRLabel();
         this.FromDate = new DevExpress.XtraReports.Parameters.Parameter();
         this.xrLabel43 = new DevExpress.XtraReports.UI.XRLabel();
         this.ToDate = new DevExpress.XtraReports.Parameters.Parameter();
         this.groupFooterBand1 = new DevExpress.XtraReports.UI.GroupFooterBand();
         this.POS_GroupFooter = new DevExpress.XtraReports.UI.GroupFooterBand();
         this.xrLabel15 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLine1 = new DevExpress.XtraReports.UI.XRLine();
         this.xrLabel17 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel19 = new DevExpress.XtraReports.UI.XRLabel();
         this.reportFooterBand1 = new DevExpress.XtraReports.UI.ReportFooterBand();
         this.xrTable5 = new DevExpress.XtraReports.UI.XRTable();
         this.xrTableRow5 = new DevExpress.XtraReports.UI.XRTableRow();
         this.xrTableCell14 = new DevExpress.XtraReports.UI.XRTableCell();
         this.xrTableCell15 = new DevExpress.XtraReports.UI.XRTableCell();
         this.xrTableCell16 = new DevExpress.XtraReports.UI.XRTableCell();
         this.xrLine6 = new DevExpress.XtraReports.UI.XRLine();
         this.Title = new DevExpress.XtraReports.UI.XRControlStyle();
         this.FieldCaption = new DevExpress.XtraReports.UI.XRControlStyle();
         this.PageInfo = new DevExpress.XtraReports.UI.XRControlStyle();
         this.DataField = new DevExpress.XtraReports.UI.XRControlStyle();
         this.POS = new DevExpress.XtraReports.Parameters.Parameter();
         this.StaffCode = new DevExpress.XtraReports.Parameters.Parameter();
         this.Pricelist = new DevExpress.XtraReports.Parameters.Parameter();
         this.Category = new DevExpress.XtraReports.Parameters.Parameter();
         this.xrTableCell3 = new DevExpress.XtraReports.UI.XRTableCell();
         this.xrTableCell2 = new DevExpress.XtraReports.UI.XRTableCell();
         this.xrTableCell8 = new DevExpress.XtraReports.UI.XRTableCell();
         this.xrTableCell1 = new DevExpress.XtraReports.UI.XRTableCell();
         this.xrTableRow1 = new DevExpress.XtraReports.UI.XRTableRow();
         this.xrTable1 = new DevExpress.XtraReports.UI.XRTable();
         this.Staff_GroupHeader = new DevExpress.XtraReports.UI.GroupHeaderBand();
         this.xrTableCell12 = new DevExpress.XtraReports.UI.XRTableCell();
         this.xrTableCell11 = new DevExpress.XtraReports.UI.XRTableCell();
         this.xrTableCell10 = new DevExpress.XtraReports.UI.XRTableCell();
         this.xrTableCell9 = new DevExpress.XtraReports.UI.XRTableCell();
         this.xrTableRow3 = new DevExpress.XtraReports.UI.XRTableRow();
         this.xrTable3 = new DevExpress.XtraReports.UI.XRTable();
         this.Pricelist_GroupHeader = new DevExpress.XtraReports.UI.GroupHeaderBand();
         this.xrTableCell7 = new DevExpress.XtraReports.UI.XRTableCell();
         this.xrTableCell6 = new DevExpress.XtraReports.UI.XRTableCell();
         this.xrTableCell5 = new DevExpress.XtraReports.UI.XRTableCell();
         this.xrTableCell4 = new DevExpress.XtraReports.UI.XRTableCell();
         this.xrTableRow2 = new DevExpress.XtraReports.UI.XRTableRow();
         this.xrTable2 = new DevExpress.XtraReports.UI.XRTable();
         this.Category_GroupHeader = new DevExpress.XtraReports.UI.GroupHeaderBand();
         ((System.ComponentModel.ISupportInitialize)(this.xrTable4)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.xrTable6)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.xrTable5)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.xrTable3)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.xrTable2)).BeginInit();
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
         customSqlQuery2.Name = "Staff";
         customSqlQuery2.Sql = "/* Staff */\r\nSelect StaffCode = Code\r\n     , StafName = IsNull( LastName, \'\' ) + " +
    "\' \' + IsNull( FirstName, \'\' )\r\nFrom Staff\r\nOrder By StafName\r\n";
         customSqlQuery3.Name = "PosInfos";
         customSqlQuery3.Sql = "/* PosInfos */\r\nSelect Id, Code, Description\r\nFrom PosInfo\r\n";
         customSqlQuery4.Name = "Pricelists";
         customSqlQuery4.Sql = "/* Pricelists */\r\nSelect Id, Description\r\nFrom Pricelist\r\n";
         customSqlQuery5.Name = "Categories";
         customSqlQuery5.Sql = "/* Categories */\r\nSELECT Id, Description\r\nFROM Categories\r\nORDER BY Description\r\n" +
    "";
         customSqlQuery6.Name = "Query_FastStart";
         customSqlQuery6.Sql = "/* Query_FastStart */\r\nSelect *\r\nFrom Invoices\r\nWhere id = -1\r\n";
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
            this.xrLabel46,
            this.xrLabel48,
            this.xrLabel49,
            this.xrLabel50,
            this.xrLabel51});
         this.Detail.HeightF = 18F;
         this.Detail.Name = "Detail";
         this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
         this.Detail.StyleName = "DataField";
         this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
         // 
         // xrLabel46
         // 
         this.xrLabel46.CanGrow = false;
         this.xrLabel46.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.Total", "{0:#,##0.00}")});
         this.xrLabel46.Font = new System.Drawing.Font("Times New Roman", 8F);
         this.xrLabel46.LocationFloat = new DevExpress.Utils.PointFloat(648.2389F, 0F);
         this.xrLabel46.Name = "xrLabel46";
         this.xrLabel46.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel46.SizeF = new System.Drawing.SizeF(101.7606F, 18F);
         this.xrLabel46.StylePriority.UseFont = false;
         this.xrLabel46.StylePriority.UseTextAlignment = false;
         this.xrLabel46.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
         this.xrLabel46.WordWrap = false;
         // 
         // xrLabel48
         // 
         this.xrLabel48.CanGrow = false;
         this.xrLabel48.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.Qty", "{0:#,##0.000}")});
         this.xrLabel48.Font = new System.Drawing.Font("Times New Roman", 8F);
         this.xrLabel48.LocationFloat = new DevExpress.Utils.PointFloat(543.7143F, 0F);
         this.xrLabel48.Name = "xrLabel48";
         this.xrLabel48.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel48.SizeF = new System.Drawing.SizeF(104.5246F, 18F);
         this.xrLabel48.StylePriority.UseFont = false;
         this.xrLabel48.StylePriority.UseTextAlignment = false;
         this.xrLabel48.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
         this.xrLabel48.WordWrap = false;
         // 
         // xrLabel49
         // 
         this.xrLabel49.CanGrow = false;
         this.xrLabel49.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.InvoiceCount")});
         this.xrLabel49.Font = new System.Drawing.Font("Times New Roman", 8F);
         this.xrLabel49.LocationFloat = new DevExpress.Utils.PointFloat(390.4893F, 0F);
         this.xrLabel49.Name = "xrLabel49";
         this.xrLabel49.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel49.SizeF = new System.Drawing.SizeF(153.225F, 18F);
         this.xrLabel49.StylePriority.UseFont = false;
         this.xrLabel49.StylePriority.UseTextAlignment = false;
         this.xrLabel49.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
         this.xrLabel49.WordWrap = false;
         // 
         // xrLabel50
         // 
         this.xrLabel50.CanGrow = false;
         this.xrLabel50.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.ProductDescription")});
         this.xrLabel50.Font = new System.Drawing.Font("Times New Roman", 8F);
         this.xrLabel50.LocationFloat = new DevExpress.Utils.PointFloat(99.4584F, 0F);
         this.xrLabel50.Name = "xrLabel50";
         this.xrLabel50.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel50.SizeF = new System.Drawing.SizeF(291.0309F, 18F);
         this.xrLabel50.StylePriority.UseFont = false;
         this.xrLabel50.WordWrap = false;
         // 
         // xrLabel51
         // 
         this.xrLabel51.CanGrow = false;
         this.xrLabel51.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.ProductCode")});
         this.xrLabel51.Font = new System.Drawing.Font("Times New Roman", 8F);
         this.xrLabel51.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
         this.xrLabel51.Name = "xrLabel51";
         this.xrLabel51.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel51.SizeF = new System.Drawing.SizeF(99.4584F, 18F);
         this.xrLabel51.StylePriority.UseFont = false;
         this.xrLabel51.WordWrap = false;
         // 
         // TopMargin
         // 
         this.TopMargin.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrPageInfo3});
         this.TopMargin.HeightF = 56F;
         this.TopMargin.Name = "TopMargin";
         this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
         this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
         // 
         // xrPageInfo3
         // 
         this.xrPageInfo3.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
         this.xrPageInfo3.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
         this.xrPageInfo3.Format = "Ημερομηνία Εκτύπωσης : {0:dddd, d MMMM yyyy h:mm:ss tt}";
         this.xrPageInfo3.LocationFloat = new DevExpress.Utils.PointFloat(2F, 37.23729F);
         this.xrPageInfo3.Name = "xrPageInfo3";
         this.xrPageInfo3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrPageInfo3.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime;
         this.xrPageInfo3.SizeF = new System.Drawing.SizeF(746F, 18.76271F);
         this.xrPageInfo3.StylePriority.UseBorders = false;
         this.xrPageInfo3.StylePriority.UseFont = false;
         // 
         // BottomMargin
         // 
         this.BottomMargin.HeightF = 37.47457F;
         this.BottomMargin.Name = "BottomMargin";
         this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
         this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
         // 
         // POS_GroupHeader
         // 
         this.POS_GroupHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable4});
         this.POS_GroupHeader.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("PosInfoId", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
         this.POS_GroupHeader.HeightF = 16F;
         this.POS_GroupHeader.Level = 3;
         this.POS_GroupHeader.Name = "POS_GroupHeader";
         // 
         // xrTable4
         // 
         this.xrTable4.BackColor = System.Drawing.Color.Gray;
         this.xrTable4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
         this.xrTable4.LocationFloat = new DevExpress.Utils.PointFloat(2F, 0F);
         this.xrTable4.Name = "xrTable4";
         this.xrTable4.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow4});
         this.xrTable4.SizeF = new System.Drawing.SizeF(746F, 16F);
         this.xrTable4.StylePriority.UseBackColor = false;
         this.xrTable4.StylePriority.UseFont = false;
         this.xrTable4.StylePriority.UseTextAlignment = false;
         this.xrTable4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
         // 
         // xrTableRow4
         // 
         this.xrTableRow4.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell13});
         this.xrTableRow4.Name = "xrTableRow4";
         this.xrTableRow4.Weight = 1D;
         // 
         // xrTableCell13
         // 
         this.xrTableCell13.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.PosInfoDescription", "POS: {0}")});
         this.xrTableCell13.Name = "xrTableCell13";
         this.xrTableCell13.Weight = 1D;
         // 
         // groupHeaderBand3
         // 
         this.groupHeaderBand3.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable6,
            this.xrLine2});
         this.groupHeaderBand3.HeightF = 22F;
         this.groupHeaderBand3.Level = 1;
         this.groupHeaderBand3.Name = "groupHeaderBand3";
         this.groupHeaderBand3.StyleName = "FieldCaption";
         // 
         // xrTable6
         // 
         this.xrTable6.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
         this.xrTable6.LocationFloat = new DevExpress.Utils.PointFloat(2F, 2F);
         this.xrTable6.Name = "xrTable6";
         this.xrTable6.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow6});
         this.xrTable6.SizeF = new System.Drawing.SizeF(746F, 18F);
         this.xrTable6.StylePriority.UseFont = false;
         this.xrTable6.StylePriority.UseTextAlignment = false;
         this.xrTable6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
         // 
         // xrTableRow6
         // 
         this.xrTableRow6.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell17,
            this.xrTableCell18,
            this.xrTableCell20,
            this.xrTableCell21,
            this.xrTableCell19});
         this.xrTableRow6.Name = "xrTableRow6";
         this.xrTableRow6.Weight = 1D;
         // 
         // xrTableCell17
         // 
         this.xrTableCell17.Name = "xrTableCell17";
         this.xrTableCell17.StylePriority.UseTextAlignment = false;
         this.xrTableCell17.Text = "Κωδ. Είδους";
         this.xrTableCell17.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
         this.xrTableCell17.Weight = 0.65320643407090417D;
         // 
         // xrTableCell18
         // 
         this.xrTableCell18.Name = "xrTableCell18";
         this.xrTableCell18.StylePriority.UseTextAlignment = false;
         this.xrTableCell18.Text = "Περιγραφή";
         this.xrTableCell18.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
         this.xrTableCell18.Weight = 1.9506093145375598D;
         // 
         // xrTableCell20
         // 
         this.xrTableCell20.Name = "xrTableCell20";
         this.xrTableCell20.StylePriority.UseTextAlignment = false;
         this.xrTableCell20.Text = "Σύνολο Παραστατικών";
         this.xrTableCell20.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
         this.xrTableCell20.Weight = 1.0269770430495848D;
         // 
         // xrTableCell21
         // 
         this.xrTableCell21.Name = "xrTableCell21";
         this.xrTableCell21.StylePriority.UseTextAlignment = false;
         this.xrTableCell21.Text = "Ποσότητα";
         this.xrTableCell21.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
         this.xrTableCell21.Weight = 0.69079978983779378D;
         // 
         // xrTableCell19
         // 
         this.xrTableCell19.Name = "xrTableCell19";
         this.xrTableCell19.StylePriority.UseTextAlignment = false;
         this.xrTableCell19.Text = "Σύνολο";
         this.xrTableCell19.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
         this.xrTableCell19.Weight = 0.67840741850415753D;
         // 
         // xrLine2
         // 
         this.xrLine2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
         this.xrLine2.LocationFloat = new DevExpress.Utils.PointFloat(0F, 20F);
         this.xrLine2.Name = "xrLine2";
         this.xrLine2.SizeF = new System.Drawing.SizeF(749.9995F, 2F);
         this.xrLine2.StylePriority.UseForeColor = false;
         // 
         // pageFooterBand1
         // 
         this.pageFooterBand1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrPageInfo1});
         this.pageFooterBand1.HeightF = 18.76271F;
         this.pageFooterBand1.Name = "pageFooterBand1";
         // 
         // xrPageInfo1
         // 
         this.xrPageInfo1.Borders = DevExpress.XtraPrinting.BorderSide.Top;
         this.xrPageInfo1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
         this.xrPageInfo1.Format = "Σελίδα {0} από {1}";
         this.xrPageInfo1.LocationFloat = new DevExpress.Utils.PointFloat(2F, 0F);
         this.xrPageInfo1.Name = "xrPageInfo1";
         this.xrPageInfo1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrPageInfo1.SizeF = new System.Drawing.SizeF(746F, 18.76271F);
         this.xrPageInfo1.StylePriority.UseBorders = false;
         this.xrPageInfo1.StylePriority.UseFont = false;
         this.xrPageInfo1.StylePriority.UseTextAlignment = false;
         this.xrPageInfo1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
         // 
         // reportHeaderBand1
         // 
         this.reportHeaderBand1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel29,
            this.xrLabel42,
            this.xrLabel43});
         this.reportHeaderBand1.HeightF = 47.79167F;
         this.reportHeaderBand1.Name = "reportHeaderBand1";
         // 
         // xrLabel29
         // 
         this.xrLabel29.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
         this.xrLabel29.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
         this.xrLabel29.LocationFloat = new DevExpress.Utils.PointFloat(2F, 0F);
         this.xrLabel29.Name = "xrLabel29";
         this.xrLabel29.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel29.SizeF = new System.Drawing.SizeF(746F, 22.58333F);
         this.xrLabel29.StyleName = "Title";
         this.xrLabel29.StylePriority.UseFont = false;
         this.xrLabel29.StylePriority.UseForeColor = false;
         this.xrLabel29.StylePriority.UseTextAlignment = false;
         this.xrLabel29.Text = "Πωλήσεις ανά Χειριστή, Τιμοκατάλογο και Κατηγορία - Συνοπτικά";
         this.xrLabel29.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
         // 
         // xrLabel42
         // 
         this.xrLabel42.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding(this.FromDate, "Text", "(από {0}")});
         this.xrLabel42.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
         this.xrLabel42.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
         this.xrLabel42.LocationFloat = new DevExpress.Utils.PointFloat(2F, 23F);
         this.xrLabel42.Name = "xrLabel42";
         this.xrLabel42.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel42.SizeF = new System.Drawing.SizeF(373F, 22F);
         this.xrLabel42.StyleName = "Title";
         this.xrLabel42.StylePriority.UseFont = false;
         this.xrLabel42.StylePriority.UseForeColor = false;
         this.xrLabel42.StylePriority.UseTextAlignment = false;
         this.xrLabel42.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
         // 
         // FromDate
         // 
         this.FromDate.Description = "From Date";
         this.FromDate.Name = "FromDate";
         this.FromDate.Type = typeof(System.DateTime);
         this.FromDate.ValueInfo = "2016-09-08";
         // 
         // xrLabel43
         // 
         this.xrLabel43.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding(this.ToDate, "Text", " έως {0})")});
         this.xrLabel43.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
         this.xrLabel43.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
         this.xrLabel43.LocationFloat = new DevExpress.Utils.PointFloat(375F, 23F);
         this.xrLabel43.Name = "xrLabel43";
         this.xrLabel43.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel43.SizeF = new System.Drawing.SizeF(373F, 22F);
         this.xrLabel43.StyleName = "Title";
         this.xrLabel43.StylePriority.UseFont = false;
         this.xrLabel43.StylePriority.UseForeColor = false;
         this.xrLabel43.StylePriority.UseTextAlignment = false;
         this.xrLabel43.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
         // 
         // ToDate
         // 
         this.ToDate.Description = "To Date";
         this.ToDate.Name = "ToDate";
         this.ToDate.Type = typeof(System.DateTime);
         this.ToDate.ValueInfo = "2016-09-10";
         // 
         // groupFooterBand1
         // 
         this.groupFooterBand1.HeightF = 1F;
         this.groupFooterBand1.Name = "groupFooterBand1";
         // 
         // POS_GroupFooter
         // 
         this.POS_GroupFooter.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel15,
            this.xrLine1,
            this.xrLabel17,
            this.xrLabel19});
         this.POS_GroupFooter.HeightF = 30F;
         this.POS_GroupFooter.Level = 3;
         this.POS_GroupFooter.Name = "POS_GroupFooter";
         // 
         // xrLabel15
         // 
         this.xrLabel15.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
         this.xrLabel15.LocationFloat = new DevExpress.Utils.PointFloat(0.0002441406F, 7F);
         this.xrLabel15.Name = "xrLabel15";
         this.xrLabel15.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel15.SizeF = new System.Drawing.SizeF(390.4891F, 18F);
         this.xrLabel15.StylePriority.UseFont = false;
         this.xrLabel15.StylePriority.UseTextAlignment = false;
         this.xrLabel15.Text = "Σύνολα (POS) : ";
         this.xrLabel15.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
         // 
         // xrLine1
         // 
         this.xrLine1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
         this.xrLine1.LocationFloat = new DevExpress.Utils.PointFloat(0.0002441406F, 5F);
         this.xrLine1.Name = "xrLine1";
         this.xrLine1.SizeF = new System.Drawing.SizeF(749.9995F, 2F);
         this.xrLine1.StylePriority.UseForeColor = false;
         // 
         // xrLabel17
         // 
         this.xrLabel17.CanGrow = false;
         this.xrLabel17.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.Qty")});
         this.xrLabel17.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
         this.xrLabel17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
         this.xrLabel17.LocationFloat = new DevExpress.Utils.PointFloat(390.4893F, 7F);
         this.xrLabel17.Name = "xrLabel17";
         this.xrLabel17.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel17.SizeF = new System.Drawing.SizeF(257.7496F, 18F);
         this.xrLabel17.StyleName = "FieldCaption";
         this.xrLabel17.StylePriority.UseFont = false;
         this.xrLabel17.StylePriority.UseForeColor = false;
         this.xrLabel17.StylePriority.UseTextAlignment = false;
         xrSummary1.FormatString = "{0:#,##0.000}";
         xrSummary1.IgnoreNullValues = true;
         xrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
         this.xrLabel17.Summary = xrSummary1;
         this.xrLabel17.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
         this.xrLabel17.WordWrap = false;
         // 
         // xrLabel19
         // 
         this.xrLabel19.CanGrow = false;
         this.xrLabel19.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.Total")});
         this.xrLabel19.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
         this.xrLabel19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
         this.xrLabel19.LocationFloat = new DevExpress.Utils.PointFloat(648.2389F, 7F);
         this.xrLabel19.Name = "xrLabel19";
         this.xrLabel19.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel19.SizeF = new System.Drawing.SizeF(101.7606F, 18F);
         this.xrLabel19.StyleName = "FieldCaption";
         this.xrLabel19.StylePriority.UseFont = false;
         this.xrLabel19.StylePriority.UseForeColor = false;
         this.xrLabel19.StylePriority.UseTextAlignment = false;
         xrSummary2.FormatString = "{0:#,##0.00}";
         xrSummary2.IgnoreNullValues = true;
         xrSummary2.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
         this.xrLabel19.Summary = xrSummary2;
         this.xrLabel19.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
         this.xrLabel19.WordWrap = false;
         // 
         // reportFooterBand1
         // 
         this.reportFooterBand1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable5,
            this.xrLine6});
         this.reportFooterBand1.HeightF = 27.08333F;
         this.reportFooterBand1.Name = "reportFooterBand1";
         // 
         // xrTable5
         // 
         this.xrTable5.BackColor = System.Drawing.Color.Silver;
         this.xrTable5.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
         this.xrTable5.LocationFloat = new DevExpress.Utils.PointFloat(2F, 5F);
         this.xrTable5.Name = "xrTable5";
         this.xrTable5.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow5});
         this.xrTable5.SizeF = new System.Drawing.SizeF(746F, 18F);
         this.xrTable5.StylePriority.UseBackColor = false;
         this.xrTable5.StylePriority.UseFont = false;
         this.xrTable5.StylePriority.UseTextAlignment = false;
         this.xrTable5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
         // 
         // xrTableRow5
         // 
         this.xrTableRow5.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell14,
            this.xrTableCell15,
            this.xrTableCell16});
         this.xrTableRow5.Name = "xrTableRow5";
         this.xrTableRow5.Weight = 1D;
         // 
         // xrTableCell14
         // 
         this.xrTableCell14.Name = "xrTableCell14";
         this.xrTableCell14.StylePriority.UseTextAlignment = false;
         this.xrTableCell14.Text = "Γενικά Σύνολα";
         this.xrTableCell14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
         this.xrTableCell14.Weight = 1.772944670989155D;
         // 
         // xrTableCell15
         // 
         this.xrTableCell15.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.Qty")});
         this.xrTableCell15.Name = "xrTableCell15";
         this.xrTableCell15.StylePriority.UseTextAlignment = false;
         xrSummary3.FormatString = "{0:#,##0.000}";
         xrSummary3.IgnoreNullValues = true;
         xrSummary3.Running = DevExpress.XtraReports.UI.SummaryRunning.Report;
         this.xrTableCell15.Summary = xrSummary3;
         this.xrTableCell15.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
         this.xrTableCell15.Weight = 0.46580325950945256D;
         // 
         // xrTableCell16
         // 
         this.xrTableCell16.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.Total")});
         this.xrTableCell16.Name = "xrTableCell16";
         this.xrTableCell16.StylePriority.UseTextAlignment = false;
         xrSummary4.FormatString = "{0:#,##0.00}";
         xrSummary4.IgnoreNullValues = true;
         xrSummary4.Running = DevExpress.XtraReports.UI.SummaryRunning.Report;
         this.xrTableCell16.Summary = xrSummary4;
         this.xrTableCell16.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
         this.xrTableCell16.Weight = 0.76125206950139257D;
         // 
         // xrLine6
         // 
         this.xrLine6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
         this.xrLine6.LocationFloat = new DevExpress.Utils.PointFloat(0F, 3F);
         this.xrLine6.Name = "xrLine6";
         this.xrLine6.SizeF = new System.Drawing.SizeF(749.9995F, 2F);
         this.xrLine6.StylePriority.UseForeColor = false;
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
         // POS
         // 
         this.POS.Description = "Select POS";
         dynamicListLookUpSettings1.DataAdapter = null;
         dynamicListLookUpSettings1.DataMember = "PosInfos";
         dynamicListLookUpSettings1.DataSource = this.sqlDataSource1;
         dynamicListLookUpSettings1.DisplayMember = "Description";
         dynamicListLookUpSettings1.ValueMember = "Id";
         this.POS.LookUpSettings = dynamicListLookUpSettings1;
         this.POS.MultiValue = true;
         this.POS.Name = "POS";
         this.POS.Type = typeof(long);
         // 
         // StaffCode
         // 
         this.StaffCode.Description = "Select Staff";
         dynamicListLookUpSettings2.DataAdapter = null;
         dynamicListLookUpSettings2.DataMember = "Staff";
         dynamicListLookUpSettings2.DataSource = this.sqlDataSource1;
         dynamicListLookUpSettings2.DisplayMember = "StafName";
         dynamicListLookUpSettings2.ValueMember = "StaffCode";
         this.StaffCode.LookUpSettings = dynamicListLookUpSettings2;
         this.StaffCode.MultiValue = true;
         this.StaffCode.Name = "StaffCode";
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
         // Category
         // 
         this.Category.Description = "Select Category";
         dynamicListLookUpSettings4.DataAdapter = null;
         dynamicListLookUpSettings4.DataMember = "Categories";
         dynamicListLookUpSettings4.DataSource = this.sqlDataSource1;
         dynamicListLookUpSettings4.DisplayMember = "Description";
         dynamicListLookUpSettings4.ValueMember = "Id";
         this.Category.LookUpSettings = dynamicListLookUpSettings4;
         this.Category.MultiValue = true;
         this.Category.Name = "Category";
         this.Category.Type = typeof(long);
         // 
         // xrTableCell3
         // 
         this.xrTableCell3.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.Total")});
         this.xrTableCell3.Name = "xrTableCell3";
         this.xrTableCell3.StylePriority.UseTextAlignment = false;
         xrSummary5.FormatString = "{0:#,##0.00}";
         xrSummary5.IgnoreNullValues = true;
         xrSummary5.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
         this.xrTableCell3.Summary = xrSummary5;
         this.xrTableCell3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
         this.xrTableCell3.Weight = 0.46377258913981656D;
         // 
         // xrTableCell2
         // 
         this.xrTableCell2.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.Qty")});
         this.xrTableCell2.Name = "xrTableCell2";
         this.xrTableCell2.StylePriority.UseTextAlignment = false;
         xrSummary6.IgnoreNullValues = true;
         xrSummary6.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
         this.xrTableCell2.Summary = xrSummary6;
         this.xrTableCell2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
         this.xrTableCell2.Weight = 0.6586657558882395D;
         // 
         // xrTableCell8
         // 
         this.xrTableCell8.Name = "xrTableCell8";
         this.xrTableCell8.StylePriority.UseTextAlignment = false;
         this.xrTableCell8.Text = "Σύνολα:";
         this.xrTableCell8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
         this.xrTableCell8.Weight = 0.51373885762556615D;
         // 
         // xrTableCell1
         // 
         this.xrTableCell1.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.StafName", "Χειριστής : {0}")});
         this.xrTableCell1.Name = "xrTableCell1";
         this.xrTableCell1.Weight = 1.781921173386988D;
         // 
         // xrTableRow1
         // 
         this.xrTableRow1.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell1,
            this.xrTableCell8,
            this.xrTableCell2,
            this.xrTableCell3});
         this.xrTableRow1.Name = "xrTableRow1";
         this.xrTableRow1.Weight = 1D;
         // 
         // xrTable1
         // 
         this.xrTable1.BackColor = System.Drawing.Color.DarkGray;
         this.xrTable1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
         this.xrTable1.LocationFloat = new DevExpress.Utils.PointFloat(2F, 0F);
         this.xrTable1.Name = "xrTable1";
         this.xrTable1.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow1});
         this.xrTable1.SizeF = new System.Drawing.SizeF(746F, 17F);
         this.xrTable1.StylePriority.UseBackColor = false;
         this.xrTable1.StylePriority.UseFont = false;
         this.xrTable1.StylePriority.UseTextAlignment = false;
         this.xrTable1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
         // 
         // Staff_GroupHeader
         // 
         this.Staff_GroupHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable1});
         this.Staff_GroupHeader.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("StaffCode", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
         this.Staff_GroupHeader.HeightF = 17F;
         this.Staff_GroupHeader.Level = 3;
         this.Staff_GroupHeader.Name = "Staff_GroupHeader";
         // 
         // xrTableCell12
         // 
         this.xrTableCell12.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.Total")});
         this.xrTableCell12.Name = "xrTableCell12";
         this.xrTableCell12.StylePriority.UseTextAlignment = false;
         xrSummary7.FormatString = "{0:#,##0.00}";
         xrSummary7.IgnoreNullValues = true;
         xrSummary7.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
         this.xrTableCell12.Summary = xrSummary7;
         this.xrTableCell12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
         this.xrTableCell12.Weight = 0.546963956255017D;
         // 
         // xrTableCell11
         // 
         this.xrTableCell11.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.Qty")});
         this.xrTableCell11.Name = "xrTableCell11";
         this.xrTableCell11.StylePriority.UseTextAlignment = false;
         xrSummary8.FormatString = "{0:#,##0.000}";
         xrSummary8.IgnoreNullValues = true;
         xrSummary8.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
         this.xrTableCell11.Summary = xrSummary8;
         this.xrTableCell11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
         this.xrTableCell11.Weight = 0.776820071833136D;
         // 
         // xrTableCell10
         // 
         this.xrTableCell10.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
         this.xrTableCell10.Name = "xrTableCell10";
         this.xrTableCell10.StylePriority.UseFont = false;
         this.xrTableCell10.StylePriority.UseTextAlignment = false;
         this.xrTableCell10.Text = "Σύνολα:";
         this.xrTableCell10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
         this.xrTableCell10.Weight = 0.60589551826287D;
         // 
         // xrTableCell9
         // 
         this.xrTableCell9.BackColor = System.Drawing.Color.Silver;
         this.xrTableCell9.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.PricelistDescription", "Pricelist : {0}")});
         this.xrTableCell9.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
         this.xrTableCell9.Name = "xrTableCell9";
         this.xrTableCell9.StylePriority.UseBackColor = false;
         this.xrTableCell9.StylePriority.UseFont = false;
         this.xrTableCell9.Weight = 2.1015704536489768D;
         // 
         // xrTableRow3
         // 
         this.xrTableRow3.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell9,
            this.xrTableCell10,
            this.xrTableCell11,
            this.xrTableCell12});
         this.xrTableRow3.Name = "xrTableRow3";
         this.xrTableRow3.Weight = 1D;
         // 
         // xrTable3
         // 
         this.xrTable3.BackColor = System.Drawing.Color.Silver;
         this.xrTable3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
         this.xrTable3.LocationFloat = new DevExpress.Utils.PointFloat(2F, 0F);
         this.xrTable3.Name = "xrTable3";
         this.xrTable3.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow3});
         this.xrTable3.SizeF = new System.Drawing.SizeF(746F, 16.41667F);
         this.xrTable3.StylePriority.UseBackColor = false;
         this.xrTable3.StylePriority.UseFont = false;
         this.xrTable3.StylePriority.UseTextAlignment = false;
         this.xrTable3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
         // 
         // Pricelist_GroupHeader
         // 
         this.Pricelist_GroupHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable3});
         this.Pricelist_GroupHeader.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("PricelistId", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
         this.Pricelist_GroupHeader.HeightF = 16.41667F;
         this.Pricelist_GroupHeader.Level = 2;
         this.Pricelist_GroupHeader.Name = "Pricelist_GroupHeader";
         // 
         // xrTableCell7
         // 
         this.xrTableCell7.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.Total")});
         this.xrTableCell7.Name = "xrTableCell7";
         this.xrTableCell7.StylePriority.UseTextAlignment = false;
         xrSummary9.FormatString = "{0:#,##0.00}";
         xrSummary9.IgnoreNullValues = true;
         xrSummary9.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
         this.xrTableCell7.Summary = xrSummary9;
         this.xrTableCell7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
         this.xrTableCell7.Weight = 0.546963956255017D;
         // 
         // xrTableCell6
         // 
         this.xrTableCell6.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.Qty")});
         this.xrTableCell6.Name = "xrTableCell6";
         this.xrTableCell6.StylePriority.UseTextAlignment = false;
         xrSummary10.FormatString = "{0:#,##0.000}";
         xrSummary10.IgnoreNullValues = true;
         xrSummary10.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
         this.xrTableCell6.Summary = xrSummary10;
         this.xrTableCell6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
         this.xrTableCell6.Weight = 0.776820071833136D;
         // 
         // xrTableCell5
         // 
         this.xrTableCell5.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
         this.xrTableCell5.Name = "xrTableCell5";
         this.xrTableCell5.StylePriority.UseFont = false;
         this.xrTableCell5.StylePriority.UseTextAlignment = false;
         this.xrTableCell5.Text = "Σύνολα:";
         this.xrTableCell5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
         this.xrTableCell5.Weight = 0.60589551826287D;
         // 
         // xrTableCell4
         // 
         this.xrTableCell4.BackColor = System.Drawing.Color.LightGray;
         this.xrTableCell4.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.CategoryDescription", "Category : {0}")});
         this.xrTableCell4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
         this.xrTableCell4.Name = "xrTableCell4";
         this.xrTableCell4.StylePriority.UseBackColor = false;
         this.xrTableCell4.StylePriority.UseFont = false;
         this.xrTableCell4.Weight = 2.1015704536489768D;
         // 
         // xrTableRow2
         // 
         this.xrTableRow2.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell4,
            this.xrTableCell5,
            this.xrTableCell6,
            this.xrTableCell7});
         this.xrTableRow2.Name = "xrTableRow2";
         this.xrTableRow2.Weight = 1D;
         // 
         // xrTable2
         // 
         this.xrTable2.BackColor = System.Drawing.Color.LightGray;
         this.xrTable2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
         this.xrTable2.LocationFloat = new DevExpress.Utils.PointFloat(2F, 0F);
         this.xrTable2.Name = "xrTable2";
         this.xrTable2.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow2});
         this.xrTable2.SizeF = new System.Drawing.SizeF(746F, 16.41667F);
         this.xrTable2.StylePriority.UseBackColor = false;
         this.xrTable2.StylePriority.UseFont = false;
         this.xrTable2.StylePriority.UseTextAlignment = false;
         this.xrTable2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
         // 
         // Category_GroupHeader
         // 
         this.Category_GroupHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable2});
         this.Category_GroupHeader.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("CategoryId", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
         this.Category_GroupHeader.HeightF = 16.41667F;
         this.Category_GroupHeader.Name = "Category_GroupHeader";
         // 
         // SalesPerStaffPricelistCategory
         // 
         this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.POS_GroupHeader,
            this.Staff_GroupHeader,
            this.groupHeaderBand3,
            this.pageFooterBand1,
            this.reportHeaderBand1,
            this.POS_GroupFooter,
            this.reportFooterBand1,
            this.Pricelist_GroupHeader,
            this.Category_GroupHeader});
         this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.sqlDataSource1});
         this.DataMember = "Query";
         this.DataSource = this.sqlDataSource1;
         this.FilterString = "[FODay] >= ?FromDate And [FODay] <= ?ToDate And [PosInfoId] In (?POS) And [StaffC" +
    "ode] In (?StaffCode) And [PricelistId] In (?Pricelist) And [CategoryId] In (?Cat" +
    "egory)";
         this.Margins = new System.Drawing.Printing.Margins(36, 41, 56, 37);
         this.PageHeight = 1169;
         this.PageWidth = 827;
         this.PaperKind = System.Drawing.Printing.PaperKind.A4;
         this.Parameters.AddRange(new DevExpress.XtraReports.Parameters.Parameter[] {
            this.FromDate,
            this.ToDate,
            this.POS,
            this.StaffCode,
            this.Pricelist,
            this.Category});
         this.StyleSheet.AddRange(new DevExpress.XtraReports.UI.XRControlStyle[] {
            this.Title,
            this.FieldCaption,
            this.PageInfo,
            this.DataField});
         this.Version = "15.2";
         ((System.ComponentModel.ISupportInitialize)(this.xrTable4)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.xrTable6)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.xrTable5)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.xrTable3)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.xrTable2)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

      }

   #endregion

   ////////////////////////////////////////////////////////////////////////////////////////////////
   }

