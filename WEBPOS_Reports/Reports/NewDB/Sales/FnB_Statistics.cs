
using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Web.Configuration;
using WEBPOS_Reports.Helpers;

///////////////////////////////////////////////////////////////////////////////////////////////////
/// <summary>
/// Summary description for FnB_Statistics
/// </summary>
public class FnB_Statistics : DevExpress.XtraReports.UI.XtraReport
   {
   private DevExpress.XtraReports.UI.DetailBand Detail;
   private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
   private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
   private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
   private GroupHeaderBand Department_GroupHeader;
   private GroupHeaderBand TimeZone_GroupHeader;
   private GroupHeaderBand CategoryId_GroupHeader;
   private GroupHeaderBand groupHeaderBand5;
   private PageFooterBand pageFooterBand1;
   private ReportHeaderBand reportHeaderBand1;
   private GroupFooterBand groupFooterBand1;
   private GroupFooterBand Department_GroupFooter;
   private ReportFooterBand reportFooterBand1;
   private XRControlStyle Title;
   private XRControlStyle FieldCaption;
   private XRControlStyle PageInfo;
   private XRControlStyle DataField;
   private DevExpress.XtraReports.Parameters.Parameter FromDate;
   private DevExpress.XtraReports.Parameters.Parameter ToDate;
   private XRPageInfo xrPageInfo3;
   private XRPageInfo xrPageInfo1;
   private XRTable xrTable5;
   private XRTableRow xrTableRow5;
   private XRTableCell xrTableCell14;
   private XRTableCell xrTableCell15;
   private XRTableCell xrTableCell16;
   private XRLine xrLine6;
   private XRTable xrTable6;
   private XRTableRow xrTableRow6;
   private XRTableCell xrTableCell17;
   private XRTableCell xrTableCell18;
   private XRTableCell xrTableCell21;
   private XRLine xrLine5;
   private XRTable xrTable4;
   private XRTableRow xrTableRow4;
   private XRTableCell xrTableCell13;
   private XRTable xrTable1;
   private XRTableRow xrTableRow1;
   private XRTableCell xrTableCell1;
   private XRTableCell xrTableCell8;
   private XRTableCell xrTableCell2;
   private XRTableCell xrTableCell3;
   private XRTable xrTable3;
   private XRTableRow xrTableRow3;
   private XRTableCell xrTableCell9;
   private XRTableCell xrTableCell10;
   private XRTableCell xrTableCell12;
   private GroupHeaderBand ProductCategory_GroupHeader;
   private XRTable xrTable7;
   private XRTableRow xrTableRow7;
   private XRTableCell xrTableCell22;
   private XRTableCell xrTableCell25;
   private XRTableCell xrTableCell23;
   private XRTableCell xrTableCell24;
   private XRTable xrTable8;
   private XRTableRow xrTableRow8;
   private XRTableCell xrTableCell26;
   private XRTableCell xrTableCell27;
   private XRTableCell xrTableCell28;
   private XRTableCell xrTableCell29;
   private XRTable xrTable9;
   private XRTableRow xrTableRow9;
   private XRTableCell xrTableCell30;
   private XRTableCell xrTableCell31;
   private XRTableCell xrTableCell32;
   private XRLine xrLine3;
   private XRLine xrLine1;
   private GroupFooterBand TimeZone_GroupFooter;
   private XRLine xrLine2;
   private GroupFooterBand Category_GroupFooter;
   private XRLine xrLine4;
   private XRTableCell xrTableCell34;
   private XRTableCell xrTableCell37;
   private XRTableCell xrTableCell20;
   private XRTableCell xrTableCell35;
   private XRTableCell xrTableCell36;
   private XRTableCell xrTableCell33;
   private XRTable xrTable10;
   private XRTableRow xrTableRow10;
   private XRTableCell xrTableCell40;
   private XRTableRow xrTableRow11;
   private XRTableCell xrTableCell43;
   private XRTableCell xrTableCell44;
   private DevExpress.XtraReports.Parameters.Parameter Department;
   private GroupHeaderBand IsComplimentary_GroupHeader;
   private XRTable xrTable11;
   private XRTableRow xrTableRow12;
   private XRTableCell xrTableCell41;
   private FormattingRule formattingRule1;
   private XRTableCell xrTableCell4;
   private GroupFooterBand ProductCategory_GroupFooter;
   private GroupFooterBand IsComplimentary_GroupFooter;
   private XRLine xrLine7;
   private FormattingRule formattingRule2;
   private XRTableCell xrTableCell39;
   private XRTableCell xrTableCell45;
   private XRTableCell xrTableCell46;
   private XRTableCell xrTableCell42;
   private XRTableCell xrTableCell6;
   private XRLine xrLine8;
   private XRTableCell xrTableCell11;
   private XRTableCell xrTableCell19;
   private XRTableCell xrTableCell38;
   private CalculatedField CalculateComplimentary;
   private XRTableCell xrTableCell7;
   private XRTableCell xrTableCell5;
   private FormattingRule formattingRule4Category;
   private FormattingRule formattingRule4ProductCategory;

   ////////////////////////////////////////////////////////////////////////////////////////////////
   /// <summary>
   /// Required designer variable.
   /// </summary>
   private System.ComponentModel.IContainer components = null;

   ////////////////////////////////////////////////////////////////////////////////////////////////
   /// <summary>
   /// 
   /// </summary>
   public FnB_Statistics()
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FnB_Statistics));
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
            DevExpress.XtraReports.UI.XRSummary xrSummary10 = new DevExpress.XtraReports.UI.XRSummary();
            DevExpress.XtraReports.UI.XRSummary xrSummary11 = new DevExpress.XtraReports.UI.XRSummary();
            DevExpress.XtraReports.UI.XRSummary xrSummary12 = new DevExpress.XtraReports.UI.XRSummary();
            DevExpress.XtraReports.UI.XRSummary xrSummary13 = new DevExpress.XtraReports.UI.XRSummary();
            DevExpress.XtraReports.UI.XRSummary xrSummary14 = new DevExpress.XtraReports.UI.XRSummary();
            DevExpress.XtraReports.UI.XRSummary xrSummary15 = new DevExpress.XtraReports.UI.XRSummary();
            DevExpress.XtraReports.UI.XRSummary xrSummary16 = new DevExpress.XtraReports.UI.XRSummary();
            DevExpress.XtraReports.UI.XRSummary xrSummary17 = new DevExpress.XtraReports.UI.XRSummary();
            DevExpress.XtraReports.UI.XRSummary xrSummary18 = new DevExpress.XtraReports.UI.XRSummary();
            DevExpress.XtraReports.UI.XRSummary xrSummary19 = new DevExpress.XtraReports.UI.XRSummary();
            DevExpress.XtraReports.UI.XRSummary xrSummary20 = new DevExpress.XtraReports.UI.XRSummary();
            DevExpress.XtraReports.UI.XRSummary xrSummary21 = new DevExpress.XtraReports.UI.XRSummary();
            DevExpress.XtraReports.Parameters.DynamicListLookUpSettings dynamicListLookUpSettings1 = new DevExpress.XtraReports.Parameters.DynamicListLookUpSettings();
            DevExpress.XtraReports.UI.XRSummary xrSummary22 = new DevExpress.XtraReports.UI.XRSummary();
            DevExpress.XtraReports.UI.XRSummary xrSummary23 = new DevExpress.XtraReports.UI.XRSummary();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.xrTable8 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow8 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell26 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell27 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell28 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell34 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell29 = new DevExpress.XtraReports.UI.XRTableCell();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.xrPageInfo3 = new DevExpress.XtraReports.UI.XRPageInfo();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.Department_GroupHeader = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.xrTable4 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow4 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell13 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell39 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell45 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell46 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell42 = new DevExpress.XtraReports.UI.XRTableCell();
            this.TimeZone_GroupHeader = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.xrTable1 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow1 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell1 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell8 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell2 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell37 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell3 = new DevExpress.XtraReports.UI.XRTableCell();
            this.CategoryId_GroupHeader = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.xrTable3 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow3 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell9 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell10 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell12 = new DevExpress.XtraReports.UI.XRTableCell();
            this.formattingRule4Category = new DevExpress.XtraReports.UI.FormattingRule();
            this.groupHeaderBand5 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.xrLine5 = new DevExpress.XtraReports.UI.XRLine();
            this.xrTable6 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow6 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell17 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell18 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell4 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell21 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell20 = new DevExpress.XtraReports.UI.XRTableCell();
            this.pageFooterBand1 = new DevExpress.XtraReports.UI.PageFooterBand();
            this.xrPageInfo1 = new DevExpress.XtraReports.UI.XRPageInfo();
            this.reportHeaderBand1 = new DevExpress.XtraReports.UI.ReportHeaderBand();
            this.xrTable10 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow10 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell40 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow11 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell43 = new DevExpress.XtraReports.UI.XRTableCell();
            this.FromDate = new DevExpress.XtraReports.Parameters.Parameter();
            this.xrTableCell44 = new DevExpress.XtraReports.UI.XRTableCell();
            this.ToDate = new DevExpress.XtraReports.Parameters.Parameter();
            this.groupFooterBand1 = new DevExpress.XtraReports.UI.GroupFooterBand();
            this.Department_GroupFooter = new DevExpress.XtraReports.UI.GroupFooterBand();
            this.xrTable9 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow9 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell30 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell31 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell35 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell32 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell7 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrLine3 = new DevExpress.XtraReports.UI.XRLine();
            this.xrLine1 = new DevExpress.XtraReports.UI.XRLine();
            this.reportFooterBand1 = new DevExpress.XtraReports.UI.ReportFooterBand();
            this.xrLine6 = new DevExpress.XtraReports.UI.XRLine();
            this.xrTable5 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow5 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell14 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell5 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell15 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell36 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell16 = new DevExpress.XtraReports.UI.XRTableCell();
            this.Title = new DevExpress.XtraReports.UI.XRControlStyle();
            this.FieldCaption = new DevExpress.XtraReports.UI.XRControlStyle();
            this.PageInfo = new DevExpress.XtraReports.UI.XRControlStyle();
            this.DataField = new DevExpress.XtraReports.UI.XRControlStyle();
            this.ProductCategory_GroupHeader = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.xrTable7 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow7 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell22 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell25 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell23 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell33 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell24 = new DevExpress.XtraReports.UI.XRTableCell();
            this.TimeZone_GroupFooter = new DevExpress.XtraReports.UI.GroupFooterBand();
            this.xrLine2 = new DevExpress.XtraReports.UI.XRLine();
            this.Category_GroupFooter = new DevExpress.XtraReports.UI.GroupFooterBand();
            this.xrLine4 = new DevExpress.XtraReports.UI.XRLine();
            this.Department = new DevExpress.XtraReports.Parameters.Parameter();
            this.IsComplimentary_GroupHeader = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.xrTable11 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow12 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell41 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell6 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell11 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell19 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell38 = new DevExpress.XtraReports.UI.XRTableCell();
            this.formattingRule2 = new DevExpress.XtraReports.UI.FormattingRule();
            this.formattingRule1 = new DevExpress.XtraReports.UI.FormattingRule();
            this.ProductCategory_GroupFooter = new DevExpress.XtraReports.UI.GroupFooterBand();
            this.xrLine7 = new DevExpress.XtraReports.UI.XRLine();
            this.IsComplimentary_GroupFooter = new DevExpress.XtraReports.UI.GroupFooterBand();
            this.xrLine8 = new DevExpress.XtraReports.UI.XRLine();
            this.CalculateComplimentary = new DevExpress.XtraReports.UI.CalculatedField();
            this.formattingRule4ProductCategory = new DevExpress.XtraReports.UI.FormattingRule();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable11)).BeginInit();
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
            customSqlQuery2.Name = "PosInfos";
            customSqlQuery2.Sql = "/* PosInfo */\r\nSelect Id\r\n     , Code\r\n     , Description\r\nFrom PosInfo\r\n";
            customSqlQuery3.Name = "Staffs";
            customSqlQuery3.Sql = "/* Staff */\r\nSelect StaffCode = Code\r\n     , StafName = IsNull( LastName, \'\' ) + " +
    "\' \' + IsNull( FirstName, \'\' )\r\nFrom Staff\r\nOrder By StafName\r\n";
            customSqlQuery4.Name = "Pricelists";
            customSqlQuery4.Sql = "/* Pricelists */\r\nSelect Id\r\n     , Description\r\nFrom Pricelist\r\n";
            customSqlQuery5.Name = "ProductCategories";
            customSqlQuery5.Sql = "/* ProductCategories */\r\nSelect Code = IsNull( Code, \'No Category\' )\r\n     , Desc" +
    "ription\r\nFrom ProductCategories\r\nOrder By Code Asc\r\n";
            customSqlQuery6.Name = "Query_FastStart";
            customSqlQuery6.Sql = "/* Query_FastStart */\r\nSelect *\r\nFrom Invoices\r\nWhere id = -1\r\n";
            customSqlQuery7.Name = "Departments";
            customSqlQuery7.Sql = "/* Departments */\r\nSelect Id\r\n     , Description\r\nFrom Department\r\nOrder By Id\r\n";
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
            this.xrTable8});
            this.Detail.HeightF = 18F;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.StyleName = "DataField";
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.Detail.Visible = false;
            // 
            // xrTable8
            // 
            this.xrTable8.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.xrTable8.LocationFloat = new DevExpress.Utils.PointFloat(4F, 0F);
            this.xrTable8.Name = "xrTable8";
            this.xrTable8.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow8});
            this.xrTable8.SizeF = new System.Drawing.SizeF(1085F, 18F);
            this.xrTable8.StylePriority.UseFont = false;
            this.xrTable8.StylePriority.UseTextAlignment = false;
            this.xrTable8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // xrTableRow8
            // 
            this.xrTableRow8.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell26,
            this.xrTableCell27,
            this.xrTableCell28,
            this.xrTableCell34,
            this.xrTableCell29});
            this.xrTableRow8.Name = "xrTableRow8";
            this.xrTableRow8.Weight = 1D;
            // 
            // xrTableCell26
            // 
            this.xrTableCell26.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.ProductCategoryDescription", " {0}")});
            this.xrTableCell26.Name = "xrTableCell26";
            this.xrTableCell26.StylePriority.UseTextAlignment = false;
            this.xrTableCell26.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrTableCell26.Weight = 1.4294929639034673D;
            // 
            // xrTableCell27
            // 
            this.xrTableCell27.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.Total")});
            this.xrTableCell27.Name = "xrTableCell27";
            this.xrTableCell27.StylePriority.UseTextAlignment = false;
            xrSummary1.FormatString = "{0:#,##0.00}";
            xrSummary1.IgnoreNullValues = true;
            xrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
            this.xrTableCell27.Summary = xrSummary1;
            this.xrTableCell27.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrTableCell27.Weight = 0.39262675196695168D;
            // 
            // xrTableCell28
            // 
            this.xrTableCell28.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.Net")});
            this.xrTableCell28.Name = "xrTableCell28";
            xrSummary2.FormatString = "{0:#,##0.00}";
            xrSummary2.IgnoreNullValues = true;
            xrSummary2.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
            this.xrTableCell28.Summary = xrSummary2;
            this.xrTableCell28.Weight = 0.392626732656737D;
            // 
            // xrTableCell34
            // 
            this.xrTableCell34.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.Qty")});
            this.xrTableCell34.Name = "xrTableCell34";
            xrSummary3.FormatString = "{0:#,##0.000}";
            xrSummary3.IgnoreNullValues = true;
            xrSummary3.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
            this.xrTableCell34.Summary = xrSummary3;
            this.xrTableCell34.Weight = 0.39262671730199228D;
            // 
            // xrTableCell29
            // 
            this.xrTableCell29.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.Discount")});
            this.xrTableCell29.Name = "xrTableCell29";
            xrSummary4.FormatString = "{0:#,##0.00}";
            xrSummary4.IgnoreNullValues = true;
            xrSummary4.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
            this.xrTableCell29.Summary = xrSummary4;
            this.xrTableCell29.Weight = 0.39262688780780375D;
            // 
            // TopMargin
            // 
            this.TopMargin.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrPageInfo3});
            this.TopMargin.HeightF = 57.29167F;
            this.TopMargin.Name = "TopMargin";
            this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrPageInfo3
            // 
            this.xrPageInfo3.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrPageInfo3.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.xrPageInfo3.Format = "Ημερομηνία Εκτύπωσης : {0:dddd, d MMMM yyyy h:mm:ss tt}";
            this.xrPageInfo3.LocationFloat = new DevExpress.Utils.PointFloat(4F, 34.52896F);
            this.xrPageInfo3.Name = "xrPageInfo3";
            this.xrPageInfo3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrPageInfo3.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime;
            this.xrPageInfo3.SizeF = new System.Drawing.SizeF(1085F, 18.76271F);
            this.xrPageInfo3.StylePriority.UseBorders = false;
            this.xrPageInfo3.StylePriority.UseFont = false;
            // 
            // BottomMargin
            // 
            this.BottomMargin.HeightF = 35.66666F;
            this.BottomMargin.Name = "BottomMargin";
            this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // Department_GroupHeader
            // 
            this.Department_GroupHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable4});
            this.Department_GroupHeader.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("DepartmentId", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.Department_GroupHeader.HeightF = 26F;
            this.Department_GroupHeader.Level = 5;
            this.Department_GroupHeader.Name = "Department_GroupHeader";
            // 
            // xrTable4
            // 
            this.xrTable4.BackColor = System.Drawing.Color.Gray;
            this.xrTable4.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrTable4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.xrTable4.LocationFloat = new DevExpress.Utils.PointFloat(4F, 10F);
            this.xrTable4.Name = "xrTable4";
            this.xrTable4.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow4});
            this.xrTable4.SizeF = new System.Drawing.SizeF(1085F, 16F);
            this.xrTable4.StylePriority.UseBackColor = false;
            this.xrTable4.StylePriority.UseBorders = false;
            this.xrTable4.StylePriority.UseFont = false;
            this.xrTable4.StylePriority.UseTextAlignment = false;
            this.xrTable4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrTableRow4
            // 
            this.xrTableRow4.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell13,
            this.xrTableCell39,
            this.xrTableCell45,
            this.xrTableCell46,
            this.xrTableCell42});
            this.xrTableRow4.ForeColor = System.Drawing.Color.White;
            this.xrTableRow4.Name = "xrTableRow4";
            this.xrTableRow4.StylePriority.UseForeColor = false;
            this.xrTableRow4.Weight = 1D;
            // 
            // xrTableCell13
            // 
            this.xrTableCell13.BackColor = System.Drawing.Color.DimGray;
            this.xrTableCell13.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.DepartmentDescription", " Department: {0}")});
            this.xrTableCell13.Name = "xrTableCell13";
            this.xrTableCell13.StylePriority.UseBackColor = false;
            this.xrTableCell13.StylePriority.UseTextAlignment = false;
            this.xrTableCell13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrTableCell13.Weight = 1.4215880768442255D;
            // 
            // xrTableCell39
            // 
            this.xrTableCell39.BackColor = System.Drawing.Color.DimGray;
            this.xrTableCell39.Name = "xrTableCell39";
            this.xrTableCell39.StylePriority.UseBackColor = false;
            this.xrTableCell39.StylePriority.UseTextAlignment = false;
            this.xrTableCell39.Text = " Couvers : ";
            this.xrTableCell39.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrTableCell39.Weight = 0.414286233317088D;
            // 
            // xrTableCell45
            // 
            this.xrTableCell45.BackColor = System.Drawing.Color.DimGray;
            this.xrTableCell45.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.Couvers")});
            this.xrTableCell45.Name = "xrTableCell45";
            this.xrTableCell45.StylePriority.UseBackColor = false;
            this.xrTableCell45.StylePriority.UseTextAlignment = false;
            xrSummary5.FormatString = "{0:#,##0}";
            xrSummary5.IgnoreNullValues = true;
            xrSummary5.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
            this.xrTableCell45.Summary = xrSummary5;
            this.xrTableCell45.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrTableCell45.Weight = 0.3666248718941767D;
            // 
            // xrTableCell46
            // 
            this.xrTableCell46.BackColor = System.Drawing.Color.DimGray;
            this.xrTableCell46.Name = "xrTableCell46";
            this.xrTableCell46.StylePriority.UseBackColor = false;
            this.xrTableCell46.StylePriority.UseTextAlignment = false;
            this.xrTableCell46.Text = "Total : ";
            this.xrTableCell46.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrTableCell46.Weight = 0.38834512715667435D;
            // 
            // xrTableCell42
            // 
            this.xrTableCell42.BackColor = System.Drawing.Color.DimGray;
            this.xrTableCell42.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.Total")});
            this.xrTableCell42.Name = "xrTableCell42";
            this.xrTableCell42.StylePriority.UseBackColor = false;
            this.xrTableCell42.StylePriority.UseTextAlignment = false;
            xrSummary6.FormatString = "{0:#,##0.00}";
            xrSummary6.IgnoreNullValues = true;
            xrSummary6.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
            this.xrTableCell42.Summary = xrSummary6;
            this.xrTableCell42.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrTableCell42.Weight = 0.39256610550089382D;
            // 
            // TimeZone_GroupHeader
            // 
            this.TimeZone_GroupHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable1});
            this.TimeZone_GroupHeader.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("TimeZoneId", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.TimeZone_GroupHeader.HeightF = 17F;
            this.TimeZone_GroupHeader.Level = 3;
            this.TimeZone_GroupHeader.Name = "TimeZone_GroupHeader";
            // 
            // xrTable1
            // 
            this.xrTable1.BackColor = System.Drawing.Color.DarkGray;
            this.xrTable1.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrTable1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.xrTable1.LocationFloat = new DevExpress.Utils.PointFloat(4F, 0F);
            this.xrTable1.Name = "xrTable1";
            this.xrTable1.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow1});
            this.xrTable1.SizeF = new System.Drawing.SizeF(1084.232F, 17F);
            this.xrTable1.StylePriority.UseBackColor = false;
            this.xrTable1.StylePriority.UseBorders = false;
            this.xrTable1.StylePriority.UseFont = false;
            this.xrTable1.StylePriority.UseTextAlignment = false;
            this.xrTable1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrTableRow1
            // 
            this.xrTableRow1.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell1,
            this.xrTableCell8,
            this.xrTableCell2,
            this.xrTableCell37,
            this.xrTableCell3});
            this.xrTableRow1.Name = "xrTableRow1";
            this.xrTableRow1.Weight = 1D;
            // 
            // xrTableCell1
            // 
            this.xrTableCell1.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.TimeZone", " TimeZone : {0}")});
            this.xrTableCell1.Name = "xrTableCell1";
            this.xrTableCell1.Weight = 1.6287158301351481D;
            // 
            // xrTableCell8
            // 
            this.xrTableCell8.Name = "xrTableCell8";
            this.xrTableCell8.StylePriority.UseTextAlignment = false;
            this.xrTableCell8.Text = "Couvers : ";
            this.xrTableCell8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrTableCell8.Weight = 0.474648434611996D;
            // 
            // xrTableCell2
            // 
            this.xrTableCell2.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.Couvers")});
            this.xrTableCell2.Name = "xrTableCell2";
            this.xrTableCell2.StylePriority.UseTextAlignment = false;
            xrSummary7.FormatString = "{0:#,##0}";
            xrSummary7.IgnoreNullValues = true;
            xrSummary7.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
            this.xrTableCell2.Summary = xrSummary7;
            this.xrTableCell2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrTableCell2.Weight = 0.4200427717603763D;
            // 
            // xrTableCell37
            // 
            this.xrTableCell37.Name = "xrTableCell37";
            this.xrTableCell37.StylePriority.UseTextAlignment = false;
            this.xrTableCell37.Text = "Total : ";
            this.xrTableCell37.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrTableCell37.Weight = 0.44492764155955677D;
            // 
            // xrTableCell3
            // 
            this.xrTableCell3.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.Total")});
            this.xrTableCell3.Name = "xrTableCell3";
            this.xrTableCell3.StylePriority.UseTextAlignment = false;
            xrSummary8.FormatString = "{0:#,##0.00}";
            xrSummary8.IgnoreNullValues = true;
            xrSummary8.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
            this.xrTableCell3.Summary = xrSummary8;
            this.xrTableCell3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrTableCell3.Weight = 0.44734566725332159D;
            // 
            // CategoryId_GroupHeader
            // 
            this.CategoryId_GroupHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable3});
            this.CategoryId_GroupHeader.FormattingRules.Add(this.formattingRule4Category);
            this.CategoryId_GroupHeader.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("CategoryId", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.CategoryId_GroupHeader.HeightF = 16.41667F;
            this.CategoryId_GroupHeader.Level = 2;
            this.CategoryId_GroupHeader.Name = "CategoryId_GroupHeader";
            // 
            // xrTable3
            // 
            this.xrTable3.BackColor = System.Drawing.Color.Silver;
            this.xrTable3.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrTable3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.xrTable3.LocationFloat = new DevExpress.Utils.PointFloat(4F, 0F);
            this.xrTable3.Name = "xrTable3";
            this.xrTable3.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow3});
            this.xrTable3.SizeF = new System.Drawing.SizeF(1084.232F, 16.41667F);
            this.xrTable3.StylePriority.UseBackColor = false;
            this.xrTable3.StylePriority.UseBorders = false;
            this.xrTable3.StylePriority.UseFont = false;
            this.xrTable3.StylePriority.UseTextAlignment = false;
            this.xrTable3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrTableRow3
            // 
            this.xrTableRow3.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell9,
            this.xrTableCell10,
            this.xrTableCell12});
            this.xrTableRow3.Name = "xrTableRow3";
            this.xrTableRow3.Weight = 1D;
            // 
            // xrTableCell9
            // 
            this.xrTableCell9.BackColor = System.Drawing.Color.Silver;
            this.xrTableCell9.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.CategoryDescription", " Category : {0}")});
            this.xrTableCell9.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.xrTableCell9.Name = "xrTableCell9";
            this.xrTableCell9.StylePriority.UseBackColor = false;
            this.xrTableCell9.StylePriority.UseFont = false;
            this.xrTableCell9.Weight = 2.9760655816635024D;
            // 
            // xrTableCell10
            // 
            this.xrTableCell10.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.xrTableCell10.Name = "xrTableCell10";
            this.xrTableCell10.StylePriority.UseFont = false;
            this.xrTableCell10.StylePriority.UseTextAlignment = false;
            this.xrTableCell10.Text = "Total : ";
            this.xrTableCell10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrTableCell10.Weight = 0.52474070397778494D;
            // 
            // xrTableCell12
            // 
            this.xrTableCell12.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.Total")});
            this.xrTableCell12.Name = "xrTableCell12";
            this.xrTableCell12.StylePriority.UseTextAlignment = false;
            xrSummary9.FormatString = "{0:#,##0.00}";
            xrSummary9.IgnoreNullValues = true;
            xrSummary9.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
            this.xrTableCell12.Summary = xrSummary9;
            this.xrTableCell12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrTableCell12.Weight = 0.52759209653632688D;
            // 
            // formattingRule4Category
            // 
            this.formattingRule4Category.Condition = "IsNull( [CategoryId] ) Or ( [CategoryId] == 0 )";
            // 
            // 
            // 
            this.formattingRule4Category.Formatting.Visible = DevExpress.Utils.DefaultBoolean.False;
            this.formattingRule4Category.Name = "formattingRule4Category";
            // 
            // groupHeaderBand5
            // 
            this.groupHeaderBand5.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLine5,
            this.xrTable6});
            this.groupHeaderBand5.FormattingRules.Add(this.formattingRule4Category);
            this.groupHeaderBand5.HeightF = 20F;
            this.groupHeaderBand5.Level = 1;
            this.groupHeaderBand5.Name = "groupHeaderBand5";
            this.groupHeaderBand5.StyleName = "FieldCaption";
            // 
            // xrLine5
            // 
            this.xrLine5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.xrLine5.LocationFloat = new DevExpress.Utils.PointFloat(0F, 18F);
            this.xrLine5.Name = "xrLine5";
            this.xrLine5.SizeF = new System.Drawing.SizeF(1091F, 2F);
            this.xrLine5.StylePriority.UseForeColor = false;
            // 
            // xrTable6
            // 
            this.xrTable6.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.xrTable6.LocationFloat = new DevExpress.Utils.PointFloat(3.999964F, 0F);
            this.xrTable6.Name = "xrTable6";
            this.xrTable6.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow6});
            this.xrTable6.SizeF = new System.Drawing.SizeF(1085F, 18F);
            this.xrTable6.StylePriority.UseFont = false;
            this.xrTable6.StylePriority.UseTextAlignment = false;
            this.xrTable6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrTableRow6
            // 
            this.xrTableRow6.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell17,
            this.xrTableCell18,
            this.xrTableCell4,
            this.xrTableCell21,
            this.xrTableCell20});
            this.xrTableRow6.Name = "xrTableRow6";
            this.xrTableRow6.Weight = 1D;
            // 
            // xrTableCell17
            // 
            this.xrTableCell17.Name = "xrTableCell17";
            this.xrTableCell17.StylePriority.UseTextAlignment = false;
            this.xrTableCell17.Text = " Product Category";
            this.xrTableCell17.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrTableCell17.Weight = 1.2375079104475115D;
            // 
            // xrTableCell18
            // 
            this.xrTableCell18.Name = "xrTableCell18";
            this.xrTableCell18.StylePriority.UseTextAlignment = false;
            this.xrTableCell18.Text = "Total";
            this.xrTableCell18.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrTableCell18.Weight = 0.33989580568707622D;
            // 
            // xrTableCell4
            // 
            this.xrTableCell4.Name = "xrTableCell4";
            this.xrTableCell4.StylePriority.UseTextAlignment = false;
            this.xrTableCell4.Text = "Net";
            this.xrTableCell4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrTableCell4.Weight = 0.33989579389839158D;
            // 
            // xrTableCell21
            // 
            this.xrTableCell21.Name = "xrTableCell21";
            this.xrTableCell21.StylePriority.UseTextAlignment = false;
            this.xrTableCell21.Text = "Quantity";
            this.xrTableCell21.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrTableCell21.Weight = 0.33989580204990255D;
            // 
            // xrTableCell20
            // 
            this.xrTableCell20.Name = "xrTableCell20";
            this.xrTableCell20.StylePriority.UseTextAlignment = false;
            this.xrTableCell20.Text = "Discount";
            this.xrTableCell20.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrTableCell20.Weight = 0.33989583665406831D;
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
            this.xrPageInfo1.SizeF = new System.Drawing.SizeF(1087F, 18.76271F);
            this.xrPageInfo1.StylePriority.UseBorders = false;
            this.xrPageInfo1.StylePriority.UseFont = false;
            this.xrPageInfo1.StylePriority.UseTextAlignment = false;
            this.xrPageInfo1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // reportHeaderBand1
            // 
            this.reportHeaderBand1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable10});
            this.reportHeaderBand1.HeightF = 40F;
            this.reportHeaderBand1.Name = "reportHeaderBand1";
            // 
            // xrTable10
            // 
            this.xrTable10.LocationFloat = new DevExpress.Utils.PointFloat(4F, 0F);
            this.xrTable10.Name = "xrTable10";
            this.xrTable10.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow10,
            this.xrTableRow11});
            this.xrTable10.SizeF = new System.Drawing.SizeF(1085F, 40F);
            this.xrTable10.StylePriority.UseTextAlignment = false;
            this.xrTable10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrTableRow10
            // 
            this.xrTableRow10.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell40});
            this.xrTableRow10.Name = "xrTableRow10";
            this.xrTableRow10.Weight = 1D;
            // 
            // xrTableCell40
            // 
            this.xrTableCell40.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold);
            this.xrTableCell40.Name = "xrTableCell40";
            this.xrTableCell40.StylePriority.UseFont = false;
            this.xrTableCell40.StylePriority.UseTextAlignment = false;
            this.xrTableCell40.Text = "Food & Beverage Statistics";
            this.xrTableCell40.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell40.Weight = 2D;
            // 
            // xrTableRow11
            // 
            this.xrTableRow11.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell43,
            this.xrTableCell44});
            this.xrTableRow11.Name = "xrTableRow11";
            this.xrTableRow11.Weight = 1D;
            // 
            // xrTableCell43
            // 
            this.xrTableCell43.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding(this.FromDate, "Text", "(από {0}")});
            this.xrTableCell43.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.xrTableCell43.Name = "xrTableCell43";
            this.xrTableCell43.StylePriority.UseFont = false;
            this.xrTableCell43.StylePriority.UseTextAlignment = false;
            this.xrTableCell43.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrTableCell43.Weight = 1D;
            // 
            // FromDate
            // 
            this.FromDate.Description = "From Date";
            this.FromDate.Name = "FromDate";
            this.FromDate.Type = typeof(System.DateTime);
            this.FromDate.ValueInfo = "2016-05-08";
            // 
            // xrTableCell44
            // 
            this.xrTableCell44.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding(this.ToDate, "Text", " έως {0})")});
            this.xrTableCell44.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.xrTableCell44.Name = "xrTableCell44";
            this.xrTableCell44.StylePriority.UseFont = false;
            this.xrTableCell44.StylePriority.UseTextAlignment = false;
            this.xrTableCell44.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrTableCell44.Weight = 1D;
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
            // Department_GroupFooter
            // 
            this.Department_GroupFooter.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable9,
            this.xrLine3,
            this.xrLine1});
            this.Department_GroupFooter.HeightF = 30F;
            this.Department_GroupFooter.Level = 5;
            this.Department_GroupFooter.Name = "Department_GroupFooter";
            // 
            // xrTable9
            // 
            this.xrTable9.BackColor = System.Drawing.Color.Transparent;
            this.xrTable9.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.xrTable9.LocationFloat = new DevExpress.Utils.PointFloat(4F, 6F);
            this.xrTable9.Name = "xrTable9";
            this.xrTable9.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow9});
            this.xrTable9.SizeF = new System.Drawing.SizeF(1085F, 18F);
            this.xrTable9.StylePriority.UseBackColor = false;
            this.xrTable9.StylePriority.UseFont = false;
            this.xrTable9.StylePriority.UseTextAlignment = false;
            this.xrTable9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTable9.Visible = false;
            // 
            // xrTableRow9
            // 
            this.xrTableRow9.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell30,
            this.xrTableCell31,
            this.xrTableCell35,
            this.xrTableCell32,
            this.xrTableCell7});
            this.xrTableRow9.Name = "xrTableRow9";
            this.xrTableRow9.Weight = 1D;
            // 
            // xrTableCell30
            // 
            this.xrTableCell30.Name = "xrTableCell30";
            this.xrTableCell30.StylePriority.UseTextAlignment = false;
            this.xrTableCell30.Text = " Σύνολα Department";
            this.xrTableCell30.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrTableCell30.Weight = 1.429494822232581D;
            // 
            // xrTableCell31
            // 
            this.xrTableCell31.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.Total")});
            this.xrTableCell31.Name = "xrTableCell31";
            this.xrTableCell31.StylePriority.UseTextAlignment = false;
            xrSummary10.FormatString = "{0:#,##0.00}";
            xrSummary10.IgnoreNullValues = true;
            xrSummary10.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
            this.xrTableCell31.Summary = xrSummary10;
            this.xrTableCell31.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrTableCell31.Weight = 0.39262724033637425D;
            // 
            // xrTableCell35
            // 
            this.xrTableCell35.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.Net")});
            this.xrTableCell35.Name = "xrTableCell35";
            this.xrTableCell35.StylePriority.UseTextAlignment = false;
            xrSummary11.FormatString = "{0:#,##0.00}";
            xrSummary11.IgnoreNullValues = true;
            xrSummary11.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
            this.xrTableCell35.Summary = xrSummary11;
            this.xrTableCell35.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrTableCell35.Weight = 0.3926264271842041D;
            // 
            // xrTableCell32
            // 
            this.xrTableCell32.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.Qty")});
            this.xrTableCell32.Name = "xrTableCell32";
            this.xrTableCell32.StylePriority.UseTextAlignment = false;
            xrSummary12.FormatString = "{0:#,##0.000}";
            xrSummary12.IgnoreNullValues = true;
            xrSummary12.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
            this.xrTableCell32.Summary = xrSummary12;
            this.xrTableCell32.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrTableCell32.Weight = 0.39050495896071397D;
            // 
            // xrTableCell7
            // 
            this.xrTableCell7.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.Discount")});
            this.xrTableCell7.Name = "xrTableCell7";
            this.xrTableCell7.StylePriority.UseTextAlignment = false;
            xrSummary13.FormatString = "{0:#,##0.00}";
            xrSummary13.IgnoreNullValues = true;
            xrSummary13.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
            this.xrTableCell7.Summary = xrSummary13;
            this.xrTableCell7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrTableCell7.Weight = 0.3947506489836809D;
            // 
            // xrLine3
            // 
            this.xrLine3.LocationFloat = new DevExpress.Utils.PointFloat(0F, 4F);
            this.xrLine3.Name = "xrLine3";
            this.xrLine3.SizeF = new System.Drawing.SizeF(1091F, 2F);
            // 
            // xrLine1
            // 
            this.xrLine1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 24F);
            this.xrLine1.Name = "xrLine1";
            this.xrLine1.SizeF = new System.Drawing.SizeF(1091F, 2F);
            // 
            // reportFooterBand1
            // 
            this.reportFooterBand1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLine6,
            this.xrTable5});
            this.reportFooterBand1.HeightF = 24.79165F;
            this.reportFooterBand1.Name = "reportFooterBand1";
            // 
            // xrLine6
            // 
            this.xrLine6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.xrLine6.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0.9999866F);
            this.xrLine6.Name = "xrLine6";
            this.xrLine6.SizeF = new System.Drawing.SizeF(1091F, 2F);
            this.xrLine6.StylePriority.UseForeColor = false;
            // 
            // xrTable5
            // 
            this.xrTable5.BackColor = System.Drawing.Color.Silver;
            this.xrTable5.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.xrTable5.LocationFloat = new DevExpress.Utils.PointFloat(4F, 2.999987F);
            this.xrTable5.Name = "xrTable5";
            this.xrTable5.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow5});
            this.xrTable5.SizeF = new System.Drawing.SizeF(1087F, 18F);
            this.xrTable5.StylePriority.UseBackColor = false;
            this.xrTable5.StylePriority.UseFont = false;
            this.xrTable5.StylePriority.UseTextAlignment = false;
            this.xrTable5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrTableRow5
            // 
            this.xrTableRow5.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell14,
            this.xrTableCell5,
            this.xrTableCell15,
            this.xrTableCell36,
            this.xrTableCell16});
            this.xrTableRow5.Name = "xrTableRow5";
            this.xrTableRow5.Weight = 1D;
            // 
            // xrTableCell14
            // 
            this.xrTableCell14.Name = "xrTableCell14";
            this.xrTableCell14.StylePriority.UseTextAlignment = false;
            this.xrTableCell14.Text = " Γενικά Σύνολα";
            this.xrTableCell14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrTableCell14.Weight = 1.4294929453774152D;
            // 
            // xrTableCell5
            // 
            this.xrTableCell5.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.Total")});
            this.xrTableCell5.Name = "xrTableCell5";
            this.xrTableCell5.StylePriority.UseTextAlignment = false;
            xrSummary14.FormatString = "{0:#,##0.00}";
            xrSummary14.IgnoreNullValues = true;
            xrSummary14.Running = DevExpress.XtraReports.UI.SummaryRunning.Report;
            this.xrTableCell5.Summary = xrSummary14;
            this.xrTableCell5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrTableCell5.Weight = 0.39262676062403462D;
            // 
            // xrTableCell15
            // 
            this.xrTableCell15.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.Net")});
            this.xrTableCell15.Name = "xrTableCell15";
            this.xrTableCell15.StylePriority.UseTextAlignment = false;
            xrSummary15.FormatString = "{0:#,##0.00}";
            xrSummary15.IgnoreNullValues = true;
            xrSummary15.Running = DevExpress.XtraReports.UI.SummaryRunning.Report;
            this.xrTableCell15.Summary = xrSummary15;
            this.xrTableCell15.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrTableCell15.Weight = 0.39262672193308823D;
            // 
            // xrTableCell36
            // 
            this.xrTableCell36.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.Qty")});
            this.xrTableCell36.Name = "xrTableCell36";
            this.xrTableCell36.StylePriority.UseTextAlignment = false;
            xrSummary16.FormatString = "{0:#,##0.000}";
            xrSummary16.IgnoreNullValues = true;
            xrSummary16.Running = DevExpress.XtraReports.UI.SummaryRunning.Report;
            this.xrTableCell36.Summary = xrSummary16;
            this.xrTableCell36.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrTableCell36.Weight = 0.39262674389010455D;
            // 
            // xrTableCell16
            // 
            this.xrTableCell16.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.Discount")});
            this.xrTableCell16.Name = "xrTableCell16";
            this.xrTableCell16.StylePriority.UseTextAlignment = false;
            xrSummary17.FormatString = "{0:#,##0.00}";
            xrSummary17.IgnoreNullValues = true;
            xrSummary17.Running = DevExpress.XtraReports.UI.SummaryRunning.Report;
            this.xrTableCell16.Summary = xrSummary17;
            this.xrTableCell16.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrTableCell16.Weight = 0.39815688719047859D;
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
            // ProductCategory_GroupHeader
            // 
            this.ProductCategory_GroupHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable7});
            this.ProductCategory_GroupHeader.FormattingRules.Add(this.formattingRule4Category);
            this.ProductCategory_GroupHeader.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("ProductCategoryCode", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.ProductCategory_GroupHeader.HeightF = 18F;
            this.ProductCategory_GroupHeader.Name = "ProductCategory_GroupHeader";
            // 
            // xrTable7
            // 
            this.xrTable7.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.xrTable7.LocationFloat = new DevExpress.Utils.PointFloat(4F, 0F);
            this.xrTable7.Name = "xrTable7";
            this.xrTable7.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow7});
            this.xrTable7.SizeF = new System.Drawing.SizeF(1085F, 18F);
            this.xrTable7.StylePriority.UseFont = false;
            this.xrTable7.StylePriority.UseTextAlignment = false;
            this.xrTable7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // xrTableRow7
            // 
            this.xrTableRow7.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell22,
            this.xrTableCell25,
            this.xrTableCell23,
            this.xrTableCell33,
            this.xrTableCell24});
            this.xrTableRow7.Name = "xrTableRow7";
            this.xrTableRow7.Weight = 1D;
            // 
            // xrTableCell22
            // 
            this.xrTableCell22.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.ProductCategoryDescription", " {0}")});
            this.xrTableCell22.Name = "xrTableCell22";
            this.xrTableCell22.StylePriority.UseTextAlignment = false;
            this.xrTableCell22.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrTableCell22.Weight = 1.4294928834716008D;
            // 
            // xrTableCell25
            // 
            this.xrTableCell25.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.Total")});
            this.xrTableCell25.Name = "xrTableCell25";
            this.xrTableCell25.StylePriority.UseTextAlignment = false;
            xrSummary18.FormatString = "{0:#,##0.00}";
            xrSummary18.IgnoreNullValues = true;
            xrSummary18.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
            this.xrTableCell25.Summary = xrSummary18;
            this.xrTableCell25.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrTableCell25.Weight = 0.39262671677774796D;
            // 
            // xrTableCell23
            // 
            this.xrTableCell23.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.Net")});
            this.xrTableCell23.Name = "xrTableCell23";
            xrSummary19.FormatString = "{0:#,##0.00}";
            xrSummary19.IgnoreNullValues = true;
            xrSummary19.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
            this.xrTableCell23.Summary = xrSummary19;
            this.xrTableCell23.Weight = 0.39262672649385155D;
            // 
            // xrTableCell33
            // 
            this.xrTableCell33.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.Qty")});
            this.xrTableCell33.Name = "xrTableCell33";
            xrSummary20.FormatString = "{0:#,##0.000}";
            xrSummary20.IgnoreNullValues = true;
            xrSummary20.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
            this.xrTableCell33.Summary = xrSummary20;
            this.xrTableCell33.Weight = 0.39262669964425756D;
            // 
            // xrTableCell24
            // 
            this.xrTableCell24.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.Discount")});
            this.xrTableCell24.Name = "xrTableCell24";
            xrSummary21.FormatString = "{0:#,##0.00}";
            xrSummary21.IgnoreNullValues = true;
            xrSummary21.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
            this.xrTableCell24.Summary = xrSummary21;
            this.xrTableCell24.Weight = 0.39262691667855359D;
            // 
            // TimeZone_GroupFooter
            // 
            this.TimeZone_GroupFooter.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLine2});
            this.TimeZone_GroupFooter.HeightF = 13.54167F;
            this.TimeZone_GroupFooter.Level = 3;
            this.TimeZone_GroupFooter.Name = "TimeZone_GroupFooter";
            this.TimeZone_GroupFooter.Visible = false;
            // 
            // xrLine2
            // 
            this.xrLine2.ForeColor = System.Drawing.Color.White;
            this.xrLine2.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrLine2.Name = "xrLine2";
            this.xrLine2.SizeF = new System.Drawing.SizeF(1091F, 2F);
            this.xrLine2.StylePriority.UseForeColor = false;
            // 
            // Category_GroupFooter
            // 
            this.Category_GroupFooter.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLine4});
            this.Category_GroupFooter.HeightF = 12.5F;
            this.Category_GroupFooter.Level = 2;
            this.Category_GroupFooter.Name = "Category_GroupFooter";
            // 
            // xrLine4
            // 
            this.xrLine4.ForeColor = System.Drawing.Color.White;
            this.xrLine4.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrLine4.Name = "xrLine4";
            this.xrLine4.SizeF = new System.Drawing.SizeF(1091F, 2F);
            this.xrLine4.StylePriority.UseForeColor = false;
            // 
            // Department
            // 
            this.Department.Description = "Select Department";
            dynamicListLookUpSettings1.DataAdapter = null;
            dynamicListLookUpSettings1.DataMember = "Departments";
            dynamicListLookUpSettings1.DataSource = this.sqlDataSource1;
            dynamicListLookUpSettings1.DisplayMember = "Description";
            dynamicListLookUpSettings1.ValueMember = "Id";
            this.Department.LookUpSettings = dynamicListLookUpSettings1;
            this.Department.MultiValue = true;
            this.Department.Name = "Department";
            this.Department.Type = typeof(long);
            // 
            // IsComplimentary_GroupHeader
            // 
            this.IsComplimentary_GroupHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable11});
            this.IsComplimentary_GroupHeader.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("IsComplimentary", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.IsComplimentary_GroupHeader.HeightF = 17F;
            this.IsComplimentary_GroupHeader.Level = 4;
            this.IsComplimentary_GroupHeader.Name = "IsComplimentary_GroupHeader";
            // 
            // xrTable11
            // 
            this.xrTable11.BackColor = System.Drawing.Color.DimGray;
            this.xrTable11.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrTable11.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.xrTable11.ForeColor = System.Drawing.Color.White;
            this.xrTable11.LocationFloat = new DevExpress.Utils.PointFloat(4F, 0F);
            this.xrTable11.Name = "xrTable11";
            this.xrTable11.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow12});
            this.xrTable11.SizeF = new System.Drawing.SizeF(1085F, 17F);
            this.xrTable11.StylePriority.UseBackColor = false;
            this.xrTable11.StylePriority.UseBorders = false;
            this.xrTable11.StylePriority.UseFont = false;
            this.xrTable11.StylePriority.UseForeColor = false;
            // 
            // xrTableRow12
            // 
            this.xrTableRow12.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell41,
            this.xrTableCell6,
            this.xrTableCell11,
            this.xrTableCell19,
            this.xrTableCell38});
            this.xrTableRow12.Name = "xrTableRow12";
            this.xrTableRow12.Weight = 1D;
            // 
            // xrTableCell41
            // 
            this.xrTableCell41.BackColor = System.Drawing.Color.Gray;
            this.xrTableCell41.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.CalculateComplimentary", " {0}")});
            this.xrTableCell41.Name = "xrTableCell41";
            this.xrTableCell41.StylePriority.UseBackColor = false;
            this.xrTableCell41.StylePriority.UseTextAlignment = false;
            this.xrTableCell41.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell41.Weight = 0.27706057441816095D;
            // 
            // xrTableCell6
            // 
            this.xrTableCell6.BackColor = System.Drawing.Color.Gray;
            this.xrTableCell6.Name = "xrTableCell6";
            this.xrTableCell6.StylePriority.UseBackColor = false;
            this.xrTableCell6.StylePriority.UseTextAlignment = false;
            this.xrTableCell6.Text = "Couvers : ";
            this.xrTableCell6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrTableCell6.Weight = 0.080742370039873487D;
            // 
            // xrTableCell11
            // 
            this.xrTableCell11.BackColor = System.Drawing.Color.Gray;
            this.xrTableCell11.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.Couvers")});
            this.xrTableCell11.Name = "xrTableCell11";
            this.xrTableCell11.StylePriority.UseBackColor = false;
            this.xrTableCell11.StylePriority.UseTextAlignment = false;
            xrSummary22.FormatString = "{0:#,##0}";
            xrSummary22.IgnoreNullValues = true;
            xrSummary22.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
            this.xrTableCell11.Summary = xrSummary22;
            this.xrTableCell11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrTableCell11.Weight = 0.071453404420063774D;
            // 
            // xrTableCell19
            // 
            this.xrTableCell19.BackColor = System.Drawing.Color.Gray;
            this.xrTableCell19.Name = "xrTableCell19";
            this.xrTableCell19.StylePriority.UseBackColor = false;
            this.xrTableCell19.StylePriority.UseTextAlignment = false;
            this.xrTableCell19.Text = "Total : ";
            this.xrTableCell19.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrTableCell19.Weight = 0.075686574357441055D;
            // 
            // xrTableCell38
            // 
            this.xrTableCell38.BackColor = System.Drawing.Color.Gray;
            this.xrTableCell38.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.Total")});
            this.xrTableCell38.Name = "xrTableCell38";
            this.xrTableCell38.StylePriority.UseBackColor = false;
            this.xrTableCell38.StylePriority.UseTextAlignment = false;
            xrSummary23.FormatString = "{0:#,##0.00}";
            xrSummary23.IgnoreNullValues = true;
            xrSummary23.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
            this.xrTableCell38.Summary = xrSummary23;
            this.xrTableCell38.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrTableCell38.Weight = 0.076509232811273351D;
            // 
            // formattingRule2
            // 
            this.formattingRule2.Condition = "IsNull([IsComplimentary]) Or [IsComplimentary] == False";
            // 
            // 
            // 
            this.formattingRule2.Formatting.Visible = DevExpress.Utils.DefaultBoolean.True;
            this.formattingRule2.Name = "formattingRule2";
            // 
            // formattingRule1
            // 
            this.formattingRule1.Condition = "IsNull( [IsComplimentary] ) Or ( [IsComplimentary] == False )";
            // 
            // 
            // 
            this.formattingRule1.Formatting.Visible = DevExpress.Utils.DefaultBoolean.False;
            this.formattingRule1.Name = "formattingRule1";
            // 
            // ProductCategory_GroupFooter
            // 
            this.ProductCategory_GroupFooter.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLine7});
            this.ProductCategory_GroupFooter.HeightF = 12.5F;
            this.ProductCategory_GroupFooter.Name = "ProductCategory_GroupFooter";
            this.ProductCategory_GroupFooter.Visible = false;
            // 
            // xrLine7
            // 
            this.xrLine7.ForeColor = System.Drawing.Color.White;
            this.xrLine7.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrLine7.Name = "xrLine7";
            this.xrLine7.SizeF = new System.Drawing.SizeF(1091F, 2F);
            this.xrLine7.StylePriority.UseForeColor = false;
            // 
            // IsComplimentary_GroupFooter
            // 
            this.IsComplimentary_GroupFooter.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLine8});
            this.IsComplimentary_GroupFooter.HeightF = 13.54167F;
            this.IsComplimentary_GroupFooter.Level = 4;
            this.IsComplimentary_GroupFooter.Name = "IsComplimentary_GroupFooter";
            // 
            // xrLine8
            // 
            this.xrLine8.ForeColor = System.Drawing.Color.White;
            this.xrLine8.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrLine8.Name = "xrLine8";
            this.xrLine8.SizeF = new System.Drawing.SizeF(1091F, 2F);
            this.xrLine8.StylePriority.UseForeColor = false;
            // 
            // CalculateComplimentary
            // 
            this.CalculateComplimentary.DataMember = "Query";
            this.CalculateComplimentary.DisplayName = "InhouseOrComplimentary";
            this.CalculateComplimentary.Expression = "Iif([IsComplimentary] == 0,  \'INHOUSE DETAILS\', \'COMPLIMENTARY DETAILS\' )";
            this.CalculateComplimentary.FieldType = DevExpress.XtraReports.UI.FieldType.String;
            this.CalculateComplimentary.Name = "CalculateComplimentary";
            // 
            // formattingRule4ProductCategory
            // 
            this.formattingRule4ProductCategory.Condition = "IsNull( [ProductCategoryCode] ) Or ( [ProductCategoryCode] == 0 )";
            // 
            // 
            // 
            this.formattingRule4ProductCategory.Formatting.Visible = DevExpress.Utils.DefaultBoolean.False;
            this.formattingRule4ProductCategory.Name = "formattingRule4ProductCategory";
            // 
            // FnB_Statistics
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.Department_GroupHeader,
            this.TimeZone_GroupHeader,
            this.CategoryId_GroupHeader,
            this.groupHeaderBand5,
            this.pageFooterBand1,
            this.reportHeaderBand1,
            this.Department_GroupFooter,
            this.reportFooterBand1,
            this.ProductCategory_GroupHeader,
            this.TimeZone_GroupFooter,
            this.Category_GroupFooter,
            this.IsComplimentary_GroupHeader,
            this.ProductCategory_GroupFooter,
            this.IsComplimentary_GroupFooter});
            this.CalculatedFields.AddRange(new DevExpress.XtraReports.UI.CalculatedField[] {
            this.CalculateComplimentary});
            this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.sqlDataSource1});
            this.DataMember = "Query_FastStart";
            this.DataSource = this.sqlDataSource1;
            this.FilterString = "[FODay] >= ?FromDate And [FODay] <= ?ToDate And [DepartmentId] In (?Department)";
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.FormattingRuleSheet.AddRange(new DevExpress.XtraReports.UI.FormattingRule[] {
            this.formattingRule1,
            this.formattingRule2,
            this.formattingRule4Category,
            this.formattingRule4ProductCategory});
            this.Landscape = true;
            this.Margins = new System.Drawing.Printing.Margins(38, 40, 57, 36);
            this.PageHeight = 827;
            this.PageWidth = 1169;
            this.PaperKind = System.Drawing.Printing.PaperKind.A4;
            this.Parameters.AddRange(new DevExpress.XtraReports.Parameters.Parameter[] {
            this.FromDate,
            this.ToDate,
            this.Department});
            this.StyleSheet.AddRange(new DevExpress.XtraReports.UI.XRControlStyle[] {
            this.Title,
            this.FieldCaption,
            this.PageInfo,
            this.DataField});
            this.Version = "15.2";
            this.ParametersRequestBeforeShow += new System.EventHandler<DevExpress.XtraReports.Parameters.ParametersRequestEventArgs>(this.FnB_Statistics_ParametersRequestBeforeShow);
            this.DataSourceDemanded += new System.EventHandler<System.EventArgs>(this.FnB_Statistics_DataSourceDemanded);
            ((System.ComponentModel.ISupportInitialize)(this.xrTable8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

      }

   #endregion

   ////////////////////////////////////////////////////////////////////////////////////////////////
   /// <summary>
   /// 
   /// </summary>
   /// <param name="sender"></param>
   /// <param name="e"></param>
   private void FnB_Statistics_DataSourceDemanded( object sender, EventArgs e )
      {
      int? dbVersion = Convert.ToInt32( WebConfigurationManager.AppSettings["DBVersion"] );

      if ( dbVersion != null && dbVersion != 1 )
         {
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
   private void FnB_Statistics_ParametersRequestBeforeShow( object sender
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
                  // select all values for parameter PosInfoId
                  paramItem.Parameter.Value = CommonTools.SetAllSelectedForMultiValueParameter<Int64>( sqlDataSource1, "Departments", "Id" );
                  break;

                  /*/
               case "StaffCode":
                  // select all values for parameter StaffCode
                  paramItem.Parameter.Value = CommonTools.SetAllSelectedForMultiValueParameter( sqlDataSource1, "Staffs", "StaffCode" );
                  break;

               case "PricelistId":
                  // select all values for parameter PricelistId
                  paramItem.Parameter.Value = CommonTools.SetAllSelectedForMultiValueParameter<Int64>( sqlDataSource1, "Pricelists", "Id" );
                  break;

               case "ProductCategory":
                  // select all values for parameter ProductCategory
                  paramItem.Parameter.Value = CommonTools.SetAllSelectedForMultiValueParameter( sqlDataSource1, "ProductCategories", "Code" );
                  break;

                  //*/

               default:
                  break;
               }

            }

         }

      }

   ////////////////////////////////////////////////////////////////////////////////////////////////
   }

