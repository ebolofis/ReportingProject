using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Web.Configuration;

/// <summary>
/// Summary description for SalesPerProductFlat
/// </summary>
public class SalesPerProductFlat : DevExpress.XtraReports.UI.XtraReport
{
    private DevExpress.XtraReports.UI.DetailBand Detail;
    private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
    private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
    private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
    private ReportHeaderBand ReportHeader;
    private DevExpress.XtraReports.Parameters.Parameter dtFrom;
    private DevExpress.XtraReports.Parameters.Parameter dtTo;
    private DevExpress.XtraReports.Parameters.Parameter ProductCategory;
    private DevExpress.XtraReports.Parameters.Parameter Categories;
   private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource2;
   private XRTable xrTable1;
   private XRTableRow xrTableRow1;
   private XRTableCell xrTableCell1;
   private XRTableCell xrTableCell2;
   private XRTableCell xrTableCell4;
   private XRTableCell xrTableCell5;
   private XRTableCell xrTableCell8;
   private XRTableCell xrTableCell16;
   private XRTableCell xrTableCell18;
   private XRTableCell xrTableCell20;
   private XRTableCell xrTableCell22;
   private XRTableCell xrTableCell24;
   private XRTableCell xrTableCell25;
   private XRTableCell xrTableCell27;
   private XRTableCell xrTableCell28;
   private XRTableCell xrTableCell34;
   private XRTableCell xrTableCell35;
   private XRTableCell xrTableCell38;
   private DevExpress.XtraReports.Parameters.Parameter Pricelist;
   private DevExpress.XtraReports.Parameters.Parameter SalesType;
   private DevExpress.XtraReports.Parameters.Parameter PosInfoId;
   private DevExpress.XtraReports.Parameters.Parameter DepartmentId;
   private XRTableCell xrTableCell3;
   private XRTableCell xrTableCell6;
   private XRTableCell xrTableCell7;
   private XRTableCell xrTableCell40;
   private XRTable xrTable2;
   private XRTableRow xrTableRow2;
   private XRTableCell xrTableCell9;
   private XRTableCell xrTableCell10;
   private XRTableCell xrTableCell11;
   private XRTableCell xrTableCell12;
   private XRTableCell xrTableCell13;
   private XRTableCell xrTableCell14;
   private XRTableCell xrTableCell39;
   private XRTableCell xrTableCell15;
   private XRTableCell xrTableCell17;
   private XRTableCell xrTableCell19;
   private XRTableCell xrTableCell21;
   private XRTableCell xrTableCell23;
   private XRTableCell xrTableCell26;
   private XRTableCell xrTableCell29;
   private XRTableCell xrTableCell30;
   private XRTableCell xrTableCell31;
   private XRTableCell xrTableCell32;
   private XRTableCell xrTableCell33;
   private XRTableCell xrTableCell36;
   private XRTableCell xrTableCell37;
   private XRTableRow xrTableRow3;
   private XRTableCell xrTableCell42;
   private XRTableCell xrTableCell43;

   /// <summary>
   /// Required designer variable.
   /// </summary>
   private System.ComponentModel.IContainer components = null;

    public SalesPerProductFlat()
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
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalesPerProductFlat));
            DevExpress.DataAccess.Sql.CustomSqlQuery customSqlQuery2 = new DevExpress.DataAccess.Sql.CustomSqlQuery();
            DevExpress.DataAccess.Sql.CustomSqlQuery customSqlQuery3 = new DevExpress.DataAccess.Sql.CustomSqlQuery();
            DevExpress.DataAccess.Sql.CustomSqlQuery customSqlQuery4 = new DevExpress.DataAccess.Sql.CustomSqlQuery();
            DevExpress.DataAccess.Sql.CustomSqlQuery customSqlQuery5 = new DevExpress.DataAccess.Sql.CustomSqlQuery();
            DevExpress.DataAccess.Sql.CustomSqlQuery customSqlQuery6 = new DevExpress.DataAccess.Sql.CustomSqlQuery();
            DevExpress.DataAccess.Sql.CustomSqlQuery customSqlQuery7 = new DevExpress.DataAccess.Sql.CustomSqlQuery();
            DevExpress.DataAccess.Sql.CustomSqlQuery customSqlQuery8 = new DevExpress.DataAccess.Sql.CustomSqlQuery();
            DevExpress.DataAccess.Sql.CustomSqlQuery customSqlQuery9 = new DevExpress.DataAccess.Sql.CustomSqlQuery();
            DevExpress.XtraReports.Parameters.DynamicListLookUpSettings dynamicListLookUpSettings1 = new DevExpress.XtraReports.Parameters.DynamicListLookUpSettings();
            DevExpress.XtraReports.Parameters.DynamicListLookUpSettings dynamicListLookUpSettings2 = new DevExpress.XtraReports.Parameters.DynamicListLookUpSettings();
            DevExpress.DataAccess.Sql.CustomSqlQuery customSqlQuery10 = new DevExpress.DataAccess.Sql.CustomSqlQuery();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter3 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter4 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.XtraReports.Parameters.DynamicListLookUpSettings dynamicListLookUpSettings3 = new DevExpress.XtraReports.Parameters.DynamicListLookUpSettings();
            DevExpress.XtraReports.Parameters.DynamicListLookUpSettings dynamicListLookUpSettings4 = new DevExpress.XtraReports.Parameters.DynamicListLookUpSettings();
            DevExpress.XtraReports.Parameters.DynamicListLookUpSettings dynamicListLookUpSettings5 = new DevExpress.XtraReports.Parameters.DynamicListLookUpSettings();
            DevExpress.XtraReports.Parameters.DynamicListLookUpSettings dynamicListLookUpSettings6 = new DevExpress.XtraReports.Parameters.DynamicListLookUpSettings();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.xrTable1 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow1 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell1 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell7 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell2 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell4 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell5 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell8 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell40 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell16 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell3 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell6 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell18 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell20 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell22 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell24 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell25 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell27 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell28 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell34 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell35 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell38 = new DevExpress.XtraReports.UI.XRTableCell();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
            this.xrTable2 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow3 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell42 = new DevExpress.XtraReports.UI.XRTableCell();
            this.dtFrom = new DevExpress.XtraReports.Parameters.Parameter();
            this.xrTableCell43 = new DevExpress.XtraReports.UI.XRTableCell();
            this.dtTo = new DevExpress.XtraReports.Parameters.Parameter();
            this.xrTableRow2 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell9 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell10 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell11 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell12 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell13 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell14 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell39 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell15 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell17 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell19 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell21 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell23 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell26 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell29 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell30 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell31 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell32 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell33 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell36 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell37 = new DevExpress.XtraReports.UI.XRTableCell();
            this.ProductCategory = new DevExpress.XtraReports.Parameters.Parameter();
            this.Categories = new DevExpress.XtraReports.Parameters.Parameter();
            this.sqlDataSource2 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.Pricelist = new DevExpress.XtraReports.Parameters.Parameter();
            this.SalesType = new DevExpress.XtraReports.Parameters.Parameter();
            this.PosInfoId = new DevExpress.XtraReports.Parameters.Parameter();
            this.DepartmentId = new DevExpress.XtraReports.Parameters.Parameter();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).BeginInit();
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
            queryParameter1.Value = new DevExpress.DataAccess.Expression("[Parameters.dtFrom]", typeof(System.DateTime));
            queryParameter2.Name = "ToDate";
            queryParameter2.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter2.Value = new DevExpress.DataAccess.Expression("[Parameters.dtTo]", typeof(System.DateTime));
            customSqlQuery1.Parameters.Add(queryParameter1);
            customSqlQuery1.Parameters.Add(queryParameter2);
            customSqlQuery1.Sql = resources.GetString("customSqlQuery1.Sql");
            customSqlQuery2.Name = "ProductCategoriesLookUp";
            customSqlQuery2.Sql = "SELECT Id, Description FROM ProductCategories ORDER BY Description";
            customSqlQuery3.Name = "PosInfoLookUp";
            customSqlQuery3.Sql = "SELECT pif.Id, pif.[Description] [Description] \r\nFROM PosInfo pif\r\nORDER BY pif.[" +
    "Description]";
            customSqlQuery4.Name = "InvoiceTypeLookUp";
            customSqlQuery4.Sql = "SELECT it.Id, it.Abbreviation, it.[Type] \r\nFROM InvoiceTypes it \r\nWHERE it.[Type]" +
    " NOT IN (2,8) \r\nORDER BY it.[Type]";
            customSqlQuery5.Name = "CategoriesLookUp";
            customSqlQuery5.Sql = "Select Id = 0,\r\n       Description = \'No Category\'\r\n\r\nUnion All\r\n\r\nSelect Id, Des" +
    "cription\r\nFrom Categories\r\nOrder By Description\r\n";
            customSqlQuery6.Name = "Query_FastStart";
            customSqlQuery6.Sql = "select * from invoices where id = -1";
            customSqlQuery7.Name = "DepartmentsLookUps";
            customSqlQuery7.Sql = "Select Id, Description from Department";
            customSqlQuery8.Name = "SalesTypeLookups";
            customSqlQuery8.Sql = "select id, description from SalesType";
            customSqlQuery9.Name = "PricelistLookups";
            customSqlQuery9.Sql = "select id, Description from Pricelist";
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            customSqlQuery1,
            customSqlQuery2,
            customSqlQuery3,
            customSqlQuery4,
            customSqlQuery5,
            customSqlQuery6,
            customSqlQuery7,
            customSqlQuery8,
            customSqlQuery9});
            this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable1});
            this.Detail.HeightF = 19F;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrTable1
            // 
            this.xrTable1.LocationFloat = new DevExpress.Utils.PointFloat(4F, 0F);
            this.xrTable1.Name = "xrTable1";
            this.xrTable1.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow1});
            this.xrTable1.SizeF = new System.Drawing.SizeF(2261F, 19F);
            // 
            // xrTableRow1
            // 
            this.xrTableRow1.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell1,
            this.xrTableCell7,
            this.xrTableCell2,
            this.xrTableCell4,
            this.xrTableCell5,
            this.xrTableCell8,
            this.xrTableCell40,
            this.xrTableCell16,
            this.xrTableCell3,
            this.xrTableCell6,
            this.xrTableCell18,
            this.xrTableCell20,
            this.xrTableCell22,
            this.xrTableCell24,
            this.xrTableCell25,
            this.xrTableCell27,
            this.xrTableCell28,
            this.xrTableCell34,
            this.xrTableCell35,
            this.xrTableCell38});
            this.xrTableRow1.Name = "xrTableRow1";
            this.xrTableRow1.Weight = 11.5D;
            // 
            // xrTableCell1
            // 
            this.xrTableCell1.CanGrow = false;
            this.xrTableCell1.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.Abbreviation")});
            this.xrTableCell1.Name = "xrTableCell1";
            this.xrTableCell1.StylePriority.UseTextAlignment = false;
            this.xrTableCell1.Text = "xrTableCell1";
            this.xrTableCell1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.xrTableCell1.Weight = 0.037920819714432008D;
            this.xrTableCell1.WordWrap = false;
            // 
            // xrTableCell7
            // 
            this.xrTableCell7.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.ReceiptNo")});
            this.xrTableCell7.Name = "xrTableCell7";
            this.xrTableCell7.StylePriority.UseTextAlignment = false;
            this.xrTableCell7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.xrTableCell7.Weight = 0.036480360361073536D;
            // 
            // xrTableCell2
            // 
            this.xrTableCell2.CanGrow = false;
            this.xrTableCell2.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.CategoryDescription")});
            this.xrTableCell2.Name = "xrTableCell2";
            this.xrTableCell2.Text = "xrTableCell2";
            this.xrTableCell2.Weight = 0.059020538643213258D;
            this.xrTableCell2.WordWrap = false;
            // 
            // xrTableCell4
            // 
            this.xrTableCell4.CanGrow = false;
            this.xrTableCell4.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.Cover")});
            this.xrTableCell4.Name = "xrTableCell4";
            this.xrTableCell4.StylePriority.UseTextAlignment = false;
            this.xrTableCell4.Text = "xrTableCell4";
            this.xrTableCell4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.xrTableCell4.Weight = 0.031643064367123531D;
            this.xrTableCell4.WordWrap = false;
            // 
            // xrTableCell5
            // 
            this.xrTableCell5.CanGrow = false;
            this.xrTableCell5.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.DepartmentDescription")});
            this.xrTableCell5.Name = "xrTableCell5";
            this.xrTableCell5.Text = "xrTableCell5";
            this.xrTableCell5.Weight = 0.064077161751244D;
            this.xrTableCell5.WordWrap = false;
            // 
            // xrTableCell8
            // 
            this.xrTableCell8.CanGrow = false;
            this.xrTableCell8.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.FODay", "{0:dd/MM/yyyy}")});
            this.xrTableCell8.Name = "xrTableCell8";
            this.xrTableCell8.StylePriority.UseTextAlignment = false;
            this.xrTableCell8.Text = "xrTableCell8";
            this.xrTableCell8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.xrTableCell8.Weight = 0.029709571368068913D;
            this.xrTableCell8.WordWrap = false;
            // 
            // xrTableCell40
            // 
            this.xrTableCell40.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.InvoiceDay", "{0:HH:mm}")});
            this.xrTableCell40.Name = "xrTableCell40";
            this.xrTableCell40.StylePriority.UseTextAlignment = false;
            this.xrTableCell40.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.xrTableCell40.Weight = 0.035588389388149934D;
            // 
            // xrTableCell16
            // 
            this.xrTableCell16.CanGrow = false;
            this.xrTableCell16.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.PosInfoDescription")});
            this.xrTableCell16.Name = "xrTableCell16";
            this.xrTableCell16.Text = "xrTableCell16";
            this.xrTableCell16.Weight = 0.053618485499825681D;
            this.xrTableCell16.WordWrap = false;
            // 
            // xrTableCell3
            // 
            this.xrTableCell3.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.StafName")});
            this.xrTableCell3.Name = "xrTableCell3";
            this.xrTableCell3.Weight = 0.087693416030583268D;
            // 
            // xrTableCell6
            // 
            this.xrTableCell6.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.TableCode")});
            this.xrTableCell6.Name = "xrTableCell6";
            this.xrTableCell6.Weight = 0.040766530095872305D;
            // 
            // xrTableCell18
            // 
            this.xrTableCell18.CanGrow = false;
            this.xrTableCell18.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.PricelistDescription")});
            this.xrTableCell18.Name = "xrTableCell18";
            this.xrTableCell18.StylePriority.UseTextAlignment = false;
            this.xrTableCell18.Text = "xrTableCell18";
            this.xrTableCell18.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableCell18.Weight = 0.061807916142847918D;
            this.xrTableCell18.WordWrap = false;
            // 
            // xrTableCell20
            // 
            this.xrTableCell20.CanGrow = false;
            this.xrTableCell20.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.ProductDescription")});
            this.xrTableCell20.Name = "xrTableCell20";
            this.xrTableCell20.Text = "xrTableCell20";
            this.xrTableCell20.Weight = 0.084288397981259339D;
            this.xrTableCell20.WordWrap = false;
            // 
            // xrTableCell22
            // 
            this.xrTableCell22.CanGrow = false;
            this.xrTableCell22.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.ProductCategoryDescrtiption")});
            this.xrTableCell22.Name = "xrTableCell22";
            this.xrTableCell22.Text = "xrTableCell22";
            this.xrTableCell22.Weight = 0.085564686670833667D;
            this.xrTableCell22.WordWrap = false;
            // 
            // xrTableCell24
            // 
            this.xrTableCell24.CanGrow = false;
            this.xrTableCell24.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.ProductCode")});
            this.xrTableCell24.Name = "xrTableCell24";
            this.xrTableCell24.Text = "xrTableCell24";
            this.xrTableCell24.Weight = 0.045772393961869606D;
            this.xrTableCell24.WordWrap = false;
            // 
            // xrTableCell25
            // 
            this.xrTableCell25.CanGrow = false;
            this.xrTableCell25.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.Price", "{0:#,##0.00}")});
            this.xrTableCell25.Name = "xrTableCell25";
            this.xrTableCell25.StylePriority.UseTextAlignment = false;
            this.xrTableCell25.Text = "xrTableCell25";
            this.xrTableCell25.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.xrTableCell25.Weight = 0.039997563655383553D;
            this.xrTableCell25.WordWrap = false;
            // 
            // xrTableCell27
            // 
            this.xrTableCell27.CanGrow = false;
            this.xrTableCell27.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.Qty", "{0:0.##}")});
            this.xrTableCell27.Name = "xrTableCell27";
            this.xrTableCell27.StylePriority.UseTextAlignment = false;
            this.xrTableCell27.Text = "xrTableCell27";
            this.xrTableCell27.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.xrTableCell27.Weight = 0.032353192447091256D;
            this.xrTableCell27.WordWrap = false;
            // 
            // xrTableCell28
            // 
            this.xrTableCell28.CanGrow = false;
            this.xrTableCell28.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.Net", "{0:#,##0.00}")});
            this.xrTableCell28.Name = "xrTableCell28";
            this.xrTableCell28.StylePriority.UseTextAlignment = false;
            this.xrTableCell28.Text = "xrTableCell28";
            this.xrTableCell28.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.xrTableCell28.Weight = 0.036021567087761358D;
            this.xrTableCell28.WordWrap = false;
            // 
            // xrTableCell34
            // 
            this.xrTableCell34.CanGrow = false;
            this.xrTableCell34.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.Total", "{0:#,##0.00}")});
            this.xrTableCell34.Name = "xrTableCell34";
            this.xrTableCell34.StylePriority.UseTextAlignment = false;
            this.xrTableCell34.Text = "xrTableCell34";
            this.xrTableCell34.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.xrTableCell34.Weight = 0.028513470946276147D;
            this.xrTableCell34.WordWrap = false;
            // 
            // xrTableCell35
            // 
            this.xrTableCell35.CanGrow = false;
            this.xrTableCell35.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.VatAmount", "{0:#,##0.00}")});
            this.xrTableCell35.Name = "xrTableCell35";
            this.xrTableCell35.StylePriority.UseTextAlignment = false;
            this.xrTableCell35.Text = "xrTableCell35";
            this.xrTableCell35.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.xrTableCell35.Weight = 0.0369582514286841D;
            this.xrTableCell35.WordWrap = false;
            // 
            // xrTableCell38
            // 
            this.xrTableCell38.CanGrow = false;
            this.xrTableCell38.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.VatPercentage", "{0:0.00}")});
            this.xrTableCell38.Name = "xrTableCell38";
            this.xrTableCell38.StylePriority.UseTextAlignment = false;
            this.xrTableCell38.Text = "xrTableCell38";
            this.xrTableCell38.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.xrTableCell38.Weight = 0.042598233593928822D;
            this.xrTableCell38.WordWrap = false;
            // 
            // TopMargin
            // 
            this.TopMargin.HeightF = 24F;
            this.TopMargin.Name = "TopMargin";
            this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // BottomMargin
            // 
            this.BottomMargin.HeightF = 23F;
            this.BottomMargin.Name = "BottomMargin";
            this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // ReportHeader
            // 
            this.ReportHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable2});
            this.ReportHeader.HeightF = 40F;
            this.ReportHeader.Name = "ReportHeader";
            // 
            // xrTable2
            // 
            this.xrTable2.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.xrTable2.LocationFloat = new DevExpress.Utils.PointFloat(4F, 0F);
            this.xrTable2.Name = "xrTable2";
            this.xrTable2.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow3,
            this.xrTableRow2});
            this.xrTable2.SizeF = new System.Drawing.SizeF(2261F, 40F);
            this.xrTable2.StylePriority.UseFont = false;
            this.xrTable2.StylePriority.UseTextAlignment = false;
            this.xrTable2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrTableRow3
            // 
            this.xrTableRow3.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell42,
            this.xrTableCell43});
            this.xrTableRow3.Name = "xrTableRow3";
            this.xrTableRow3.Weight = 1D;
            // 
            // xrTableCell42
            // 
            this.xrTableCell42.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding(this.dtFrom, "Text", "Πωλήσεις ανά Είδος (από: {0}")});
            this.xrTableCell42.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.xrTableCell42.Name = "xrTableCell42";
            this.xrTableCell42.StylePriority.UseFont = false;
            this.xrTableCell42.StylePriority.UseTextAlignment = false;
            this.xrTableCell42.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrTableCell42.Weight = 7.8883788503708292D;
            // 
            // dtFrom
            // 
            this.dtFrom.Description = "From Date";
            this.dtFrom.Name = "dtFrom";
            this.dtFrom.Type = typeof(System.DateTime);
            this.dtFrom.ValueInfo = "2016-06-09";
            // 
            // xrTableCell43
            // 
            this.xrTableCell43.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding(this.dtTo, "Text", ", έως: {0})")});
            this.xrTableCell43.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.xrTableCell43.Name = "xrTableCell43";
            this.xrTableCell43.StylePriority.UseFont = false;
            this.xrTableCell43.StylePriority.UseTextAlignment = false;
            this.xrTableCell43.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrTableCell43.Weight = 7.90162114962915D;
            // 
            // dtTo
            // 
            this.dtTo.Description = "To Date";
            this.dtTo.Name = "dtTo";
            this.dtTo.Type = typeof(System.DateTime);
            this.dtTo.ValueInfo = "2016-06-09";
            // 
            // xrTableRow2
            // 
            this.xrTableRow2.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell9,
            this.xrTableCell10,
            this.xrTableCell11,
            this.xrTableCell12,
            this.xrTableCell13,
            this.xrTableCell14,
            this.xrTableCell39,
            this.xrTableCell15,
            this.xrTableCell17,
            this.xrTableCell19,
            this.xrTableCell21,
            this.xrTableCell23,
            this.xrTableCell26,
            this.xrTableCell29,
            this.xrTableCell30,
            this.xrTableCell31,
            this.xrTableCell32,
            this.xrTableCell33,
            this.xrTableCell36,
            this.xrTableCell37});
            this.xrTableRow2.Name = "xrTableRow2";
            this.xrTableRow2.Weight = 1D;
            // 
            // xrTableCell9
            // 
            this.xrTableCell9.Name = "xrTableCell9";
            this.xrTableCell9.Text = "Τύπος";
            this.xrTableCell9.Weight = 0.61703773582893784D;
            // 
            // xrTableCell10
            // 
            this.xrTableCell10.Name = "xrTableCell10";
            this.xrTableCell10.Text = "Αρ. Παραστατικού";
            this.xrTableCell10.Weight = 0.59359895246422223D;
            // 
            // xrTableCell11
            // 
            this.xrTableCell11.Name = "xrTableCell11";
            this.xrTableCell11.StylePriority.UseTextAlignment = false;
            this.xrTableCell11.Text = "Κατηγορία";
            this.xrTableCell11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrTableCell11.Weight = 0.96036689430989308D;
            // 
            // xrTableCell12
            // 
            this.xrTableCell12.Name = "xrTableCell12";
            this.xrTableCell12.Text = "Cover";
            this.xrTableCell12.Weight = 0.5148877487958714D;
            // 
            // xrTableCell13
            // 
            this.xrTableCell13.Name = "xrTableCell13";
            this.xrTableCell13.StylePriority.UseTextAlignment = false;
            this.xrTableCell13.Text = "Τμήμα";
            this.xrTableCell13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrTableCell13.Weight = 1.0426471022513522D;
            // 
            // xrTableCell14
            // 
            this.xrTableCell14.Name = "xrTableCell14";
            this.xrTableCell14.Text = "Ημερομηνία";
            this.xrTableCell14.Weight = 0.483426653842175D;
            // 
            // xrTableCell39
            // 
            this.xrTableCell39.Name = "xrTableCell39";
            this.xrTableCell39.Text = "Ώρα";
            this.xrTableCell39.Weight = 0.5790850617494373D;
            // 
            // xrTableCell15
            // 
            this.xrTableCell15.Name = "xrTableCell15";
            this.xrTableCell15.StylePriority.UseTextAlignment = false;
            this.xrTableCell15.Text = "POS";
            this.xrTableCell15.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrTableCell15.Weight = 0.87246596767015561D;
            // 
            // xrTableCell17
            // 
            this.xrTableCell17.Name = "xrTableCell17";
            this.xrTableCell17.StylePriority.UseTextAlignment = false;
            this.xrTableCell17.Text = "Χειριστής";
            this.xrTableCell17.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrTableCell17.Weight = 1.4269246061477765D;
            // 
            // xrTableCell19
            // 
            this.xrTableCell19.Name = "xrTableCell19";
            this.xrTableCell19.StylePriority.UseTextAlignment = false;
            this.xrTableCell19.Text = "Τραπέζι";
            this.xrTableCell19.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrTableCell19.Weight = 0.66334266385901364D;
            // 
            // xrTableCell21
            // 
            this.xrTableCell21.Name = "xrTableCell21";
            this.xrTableCell21.StylePriority.UseTextAlignment = false;
            this.xrTableCell21.Text = "Τιμοκατάλογος";
            this.xrTableCell21.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrTableCell21.Weight = 1.0057228159915022D;
            // 
            // xrTableCell23
            // 
            this.xrTableCell23.Name = "xrTableCell23";
            this.xrTableCell23.StylePriority.UseTextAlignment = false;
            this.xrTableCell23.Text = "Περιγραφή Είδους";
            this.xrTableCell23.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrTableCell23.Weight = 1.3715188691764726D;
            // 
            // xrTableCell26
            // 
            this.xrTableCell26.Name = "xrTableCell26";
            this.xrTableCell26.StylePriority.UseTextAlignment = false;
            this.xrTableCell26.Text = "Κατηγ.Προϊόντων";
            this.xrTableCell26.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrTableCell26.Weight = 1.3922864676555247D;
            // 
            // xrTableCell29
            // 
            this.xrTableCell29.Name = "xrTableCell29";
            this.xrTableCell29.StylePriority.UseTextAlignment = false;
            this.xrTableCell29.Text = "Κωδικός Είδους";
            this.xrTableCell29.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrTableCell29.Weight = 0.74479637520548336D;
            // 
            // xrTableCell30
            // 
            this.xrTableCell30.Name = "xrTableCell30";
            this.xrTableCell30.StylePriority.UseTextAlignment = false;
            this.xrTableCell30.Text = "Τιμή";
            this.xrTableCell30.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrTableCell30.Weight = 0.65083016342844724D;
            // 
            // xrTableCell31
            // 
            this.xrTableCell31.Name = "xrTableCell31";
            this.xrTableCell31.StylePriority.UseTextAlignment = false;
            this.xrTableCell31.Text = "Ποσότητα";
            this.xrTableCell31.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrTableCell31.Weight = 0.52644266954410956D;
            // 
            // xrTableCell32
            // 
            this.xrTableCell32.Name = "xrTableCell32";
            this.xrTableCell32.StylePriority.UseTextAlignment = false;
            this.xrTableCell32.Text = "Καθαρή Αξία";
            this.xrTableCell32.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrTableCell32.Weight = 0.58613352276592434D;
            // 
            // xrTableCell33
            // 
            this.xrTableCell33.Name = "xrTableCell33";
            this.xrTableCell33.StylePriority.UseTextAlignment = false;
            this.xrTableCell33.Text = "Σύνολο";
            this.xrTableCell33.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrTableCell33.Weight = 0.4639641927375775D;
            // 
            // xrTableCell36
            // 
            this.xrTableCell36.Name = "xrTableCell36";
            this.xrTableCell36.StylePriority.UseTextAlignment = false;
            this.xrTableCell36.Text = "ΦΠΑ";
            this.xrTableCell36.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrTableCell36.Weight = 0.60137523662933245D;
            // 
            // xrTableCell37
            // 
            this.xrTableCell37.Name = "xrTableCell37";
            this.xrTableCell37.StylePriority.UseTextAlignment = false;
            this.xrTableCell37.Text = "%";
            this.xrTableCell37.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrTableCell37.Weight = 0.69314629994679489D;
            // 
            // ProductCategory
            // 
            this.ProductCategory.Description = "Product Category Code";
            dynamicListLookUpSettings1.DataAdapter = null;
            dynamicListLookUpSettings1.DataMember = "ProductCategoriesLookUp";
            dynamicListLookUpSettings1.DataSource = this.sqlDataSource1;
            dynamicListLookUpSettings1.DisplayMember = "Description";
            dynamicListLookUpSettings1.FilterString = null;
            dynamicListLookUpSettings1.ValueMember = "Id";
            this.ProductCategory.LookUpSettings = dynamicListLookUpSettings1;
            this.ProductCategory.MultiValue = true;
            this.ProductCategory.Name = "ProductCategory";
            this.ProductCategory.Type = typeof(long);
            // 
            // Categories
            // 
            this.Categories.Description = "Categories";
            dynamicListLookUpSettings2.DataAdapter = null;
            dynamicListLookUpSettings2.DataMember = "CategoriesLookUp";
            dynamicListLookUpSettings2.DataSource = this.sqlDataSource1;
            dynamicListLookUpSettings2.DisplayMember = "Description";
            dynamicListLookUpSettings2.FilterString = null;
            dynamicListLookUpSettings2.ValueMember = "Id";
            this.Categories.LookUpSettings = dynamicListLookUpSettings2;
            this.Categories.MultiValue = true;
            this.Categories.Name = "Categories";
            this.Categories.Type = typeof(long);
            // 
            // sqlDataSource2
            // 
            this.sqlDataSource2.ConnectionName = "ReportConnection";
            this.sqlDataSource2.Name = "sqlDataSource2";
            customSqlQuery10.Name = "Query";
            queryParameter3.Name = "FromDate";
            queryParameter3.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter3.Value = new DevExpress.DataAccess.Expression("[Parameters.dtFrom]", typeof(System.DateTime));
            queryParameter4.Name = "ToDate";
            queryParameter4.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter4.Value = new DevExpress.DataAccess.Expression("[Parameters.dtTo]", typeof(System.DateTime));
            customSqlQuery10.Parameters.Add(queryParameter3);
            customSqlQuery10.Parameters.Add(queryParameter4);
            customSqlQuery10.Sql = resources.GetString("customSqlQuery10.Sql");
            this.sqlDataSource2.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            customSqlQuery10});
            this.sqlDataSource2.ResultSchemaSerializable = resources.GetString("sqlDataSource2.ResultSchemaSerializable");
            // 
            // Pricelist
            // 
            this.Pricelist.Description = "Select Pricelist";
            dynamicListLookUpSettings3.DataAdapter = null;
            dynamicListLookUpSettings3.DataMember = "PricelistLookups";
            dynamicListLookUpSettings3.DataSource = this.sqlDataSource1;
            dynamicListLookUpSettings3.DisplayMember = "Description";
            dynamicListLookUpSettings3.FilterString = null;
            dynamicListLookUpSettings3.ValueMember = "id";
            this.Pricelist.LookUpSettings = dynamicListLookUpSettings3;
            this.Pricelist.MultiValue = true;
            this.Pricelist.Name = "Pricelist";
            this.Pricelist.Type = typeof(long);
            // 
            // SalesType
            // 
            this.SalesType.Description = "Select Sales Type";
            dynamicListLookUpSettings4.DataAdapter = null;
            dynamicListLookUpSettings4.DataMember = "SalesTypeLookups";
            dynamicListLookUpSettings4.DataSource = this.sqlDataSource1;
            dynamicListLookUpSettings4.DisplayMember = "description";
            dynamicListLookUpSettings4.FilterString = null;
            dynamicListLookUpSettings4.ValueMember = "id";
            this.SalesType.LookUpSettings = dynamicListLookUpSettings4;
            this.SalesType.MultiValue = true;
            this.SalesType.Name = "SalesType";
            this.SalesType.Type = typeof(long);
            // 
            // PosInfoId
            // 
            this.PosInfoId.Description = "Select POS";
            dynamicListLookUpSettings5.DataAdapter = null;
            dynamicListLookUpSettings5.DataMember = "PosInfoLookUp";
            dynamicListLookUpSettings5.DataSource = this.sqlDataSource1;
            dynamicListLookUpSettings5.DisplayMember = "Description";
            dynamicListLookUpSettings5.FilterString = null;
            dynamicListLookUpSettings5.ValueMember = "Id";
            this.PosInfoId.LookUpSettings = dynamicListLookUpSettings5;
            this.PosInfoId.MultiValue = true;
            this.PosInfoId.Name = "PosInfoId";
            this.PosInfoId.Type = typeof(long);
            // 
            // DepartmentId
            // 
            this.DepartmentId.Description = "Select Department";
            dynamicListLookUpSettings6.DataAdapter = null;
            dynamicListLookUpSettings6.DataMember = "DepartmentsLookUps";
            dynamicListLookUpSettings6.DataSource = this.sqlDataSource1;
            dynamicListLookUpSettings6.DisplayMember = "Description";
            dynamicListLookUpSettings6.FilterString = null;
            dynamicListLookUpSettings6.ValueMember = "Id";
            this.DepartmentId.LookUpSettings = dynamicListLookUpSettings6;
            this.DepartmentId.MultiValue = true;
            this.DepartmentId.Name = "DepartmentId";
            this.DepartmentId.Type = typeof(long);
            // 
            // SalesPerProductFlat
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.ReportHeader});
            this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.sqlDataSource1,
            this.sqlDataSource2});
            this.DataMember = "Query_FastStart";
            this.DataSource = this.sqlDataSource1;
            this.FilterString = resources.GetString("$this.FilterString");
            this.Landscape = true;
            this.Margins = new System.Drawing.Printing.Margins(35, 33, 24, 23);
            this.PageHeight = 1654;
            this.PageWidth = 2339;
            this.PaperKind = System.Drawing.Printing.PaperKind.A2;
            this.Parameters.AddRange(new DevExpress.XtraReports.Parameters.Parameter[] {
            this.dtFrom,
            this.dtTo,
            this.ProductCategory,
            this.Categories,
            this.Pricelist,
            this.SalesType,
            this.PosInfoId,
            this.DepartmentId});
            this.Version = "15.2";
            this.ParametersRequestBeforeShow += new System.EventHandler<DevExpress.XtraReports.Parameters.ParametersRequestEventArgs>(this.SalesPerProductFlat_ParametersRequestBeforeShow);
            this.DataSourceDemanded += new System.EventHandler<System.EventArgs>(this.SalesPerProductFlat_DataSourceDemanded);
            this.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.SalesPerProductFlat_BeforePrint);
            ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

    }

   #endregion

   private void SalesPerProductFlat_ParametersRequestBeforeShow( object sender, DevExpress.XtraReports.Parameters.ParametersRequestEventArgs e )
      {

      foreach ( var paramItem in e.ParametersInformation )
         {

         if ( "DateTime" == paramItem.Parameter.Type.Name )
            {
            paramItem.Parameter.Value = DateTime.Now.Date;
            }

         }

      }

   private void SalesPerProductFlat_BeforePrint( object sender, System.Drawing.Printing.PrintEventArgs e )
      {
      var param = ( sender as XtraReport ).Parameters;
      param[0].Value = ( param[0].Value as DateTime? ).Value.Date;
      param[1].Value = ( param[1].Value as DateTime? ).Value.Date;
      }

   private void xrLabel26_PreviewClick(object sender, PreviewMouseEventArgs e)
   {

   }

   private void SalesPerProductFlat_DataSourceDemanded( object sender, EventArgs e )
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
   }
