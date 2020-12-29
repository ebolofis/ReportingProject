
using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Web.Configuration;
using WEBPOS_Reports.Helpers;

/// <summary>
/// Summary description for SalesPerCategoryAndPosTotal
/// </summary>
public class SalesPerCategoryAndPosTotal : DevExpress.XtraReports.UI.XtraReport
{
    private DevExpress.XtraReports.UI.DetailBand Detail;
    private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
    private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
    private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
    private PageFooterBand pageFooterBand1;
    private ReportHeaderBand reportHeaderBand1;
    private GroupFooterBand groupFooterBand1;
    private ReportFooterBand reportFooterBand1;
    private XRControlStyle Title;
    private XRControlStyle FieldCaption;
    private XRControlStyle PageInfo;
    private XRControlStyle DataField;
    private DevExpress.XtraReports.Parameters.Parameter FromFODay;
    private DevExpress.XtraReports.Parameters.Parameter UpToFODay;
    private XRPageInfo xrPageInfo3;
    private XRPageInfo xrPageInfo1;
    private DevExpress.XtraReports.Parameters.Parameter PosInfoID;
    private GroupHeaderBand PosInfoGroupHeader;
    private XRTable xrTable1;
    private XRTableRow xrTableRow1;
    private XRTableCell xrTableCell2;
    private XRTableRow xrTableRow2;
    private XRTableCell xrTableCell4;
    private XRTableCell xrTableCell6;
    private XRTable xrTable5;
    private XRTableRow xrTableRow6;
    private XRTableCell xrTableCell11;
    private XRTableCell xrTableCell12;
    private XRTableCell xrTableCell13;
    private XRTableCell xrTableCell30;
    private XRTable xrTable8;
    private XRTableRow xrTableRow9;
    private XRTableCell xrTableCell20;
    private XRTableCell xrTableCell21;
    private XRTableCell xrTableCell22;
    private XRTable xrTable2;
    private XRTableRow xrTableRow3;
    private XRTableCell xrTableCell1;
    private GroupHeaderBand PaymentsDescription_GroupHeader;
    private XRTable xrTable9;
    private XRTableRow xrTableRow11;
    private XRTableCell xrTableCell9;
    private XRTableCell xrTableCell32;
    private XRTableCell xrTableCell33;
    private GroupHeaderBand FODay_GroupHeader;
    private XRTable xrTable10;
    private XRTableRow xrTableRow12;
    private XRTableCell xrTableCell34;
    private XRTableCell xrTableCell35;
    private XRTableCell xrTableCell3;
    private XRTableCell xrTableCell7;
    private XRTableCell xrTableCell8;
    private XRTableCell xrTableCell10;
    private XRTableCell xrTableCell14;
    private XRTableCell xrTableCell15;
    private GroupHeaderBand VoidStatus_GroupHeader;
    private XRTable xrTable4;
    private XRTableRow xrTableRow5;
    private XRTableCell xrTableCell23;
    private XRTableCell xrTableCell24;
    private XRTableCell xrTableCell25;
    private XRTableCell xrTableCell26;
    private GroupHeaderBand Labels_Header;
    private XRTable xrTable3;
    private XRTableRow xrTableRow4;
    private XRTableCell xrTableCell16;
    private XRTableCell xrTableCell17;
    private XRTableCell xrTableCell18;
    private XRTableCell xrTableCell19;
    private XRTableCell xrTableCell27;
    private XRTableCell xrTableCell28;
    private XRTableCell xrTableCell5;
    private XRTableCell xrTableCell29;
    private FormattingRule formattingRule1;
    private GroupFooterBand FODay_GroupFooter;
    private XRSubreport xrSubreport1;
    private DevExpress.XtraReports.Parameters.Parameter InvoiceTypes;

    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    public SalesPerCategoryAndPosTotal()
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalesPerCategoryAndPosTotal));
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
        this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
        this.Detail = new DevExpress.XtraReports.UI.DetailBand();
        this.xrTable5 = new DevExpress.XtraReports.UI.XRTable();
        this.xrTableRow6 = new DevExpress.XtraReports.UI.XRTableRow();
        this.xrTableCell11 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell12 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell27 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell13 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell5 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell30 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell29 = new DevExpress.XtraReports.UI.XRTableCell();
        this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
        this.xrPageInfo3 = new DevExpress.XtraReports.UI.XRPageInfo();
        this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
        this.pageFooterBand1 = new DevExpress.XtraReports.UI.PageFooterBand();
        this.xrPageInfo1 = new DevExpress.XtraReports.UI.XRPageInfo();
        this.reportHeaderBand1 = new DevExpress.XtraReports.UI.ReportHeaderBand();
        this.xrTable1 = new DevExpress.XtraReports.UI.XRTable();
        this.xrTableRow1 = new DevExpress.XtraReports.UI.XRTableRow();
        this.xrTableCell2 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableRow2 = new DevExpress.XtraReports.UI.XRTableRow();
        this.xrTableCell4 = new DevExpress.XtraReports.UI.XRTableCell();
        this.FromFODay = new DevExpress.XtraReports.Parameters.Parameter();
        this.xrTableCell6 = new DevExpress.XtraReports.UI.XRTableCell();
        this.UpToFODay = new DevExpress.XtraReports.Parameters.Parameter();
        this.groupFooterBand1 = new DevExpress.XtraReports.UI.GroupFooterBand();
        this.reportFooterBand1 = new DevExpress.XtraReports.UI.ReportFooterBand();
        this.xrTable8 = new DevExpress.XtraReports.UI.XRTable();
        this.xrTableRow9 = new DevExpress.XtraReports.UI.XRTableRow();
        this.xrTableCell20 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell21 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell35 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell22 = new DevExpress.XtraReports.UI.XRTableCell();
        this.Title = new DevExpress.XtraReports.UI.XRControlStyle();
        this.FieldCaption = new DevExpress.XtraReports.UI.XRControlStyle();
        this.PageInfo = new DevExpress.XtraReports.UI.XRControlStyle();
        this.DataField = new DevExpress.XtraReports.UI.XRControlStyle();
        this.PosInfoID = new DevExpress.XtraReports.Parameters.Parameter();
        this.PosInfoGroupHeader = new DevExpress.XtraReports.UI.GroupHeaderBand();
        this.xrTable2 = new DevExpress.XtraReports.UI.XRTable();
        this.xrTableRow3 = new DevExpress.XtraReports.UI.XRTableRow();
        this.xrTableCell1 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell10 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell14 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell15 = new DevExpress.XtraReports.UI.XRTableCell();
        this.PaymentsDescription_GroupHeader = new DevExpress.XtraReports.UI.GroupHeaderBand();
        this.xrTable9 = new DevExpress.XtraReports.UI.XRTable();
        this.xrTableRow11 = new DevExpress.XtraReports.UI.XRTableRow();
        this.xrTableCell9 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell32 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell33 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell3 = new DevExpress.XtraReports.UI.XRTableCell();
        this.FODay_GroupHeader = new DevExpress.XtraReports.UI.GroupHeaderBand();
        this.xrTable10 = new DevExpress.XtraReports.UI.XRTable();
        this.xrTableRow12 = new DevExpress.XtraReports.UI.XRTableRow();
        this.xrTableCell34 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell28 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell7 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell8 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrSubreport1 = new DevExpress.XtraReports.UI.XRSubreport();
        this.VoidStatus_GroupHeader = new DevExpress.XtraReports.UI.GroupHeaderBand();
        this.xrTable4 = new DevExpress.XtraReports.UI.XRTable();
        this.xrTableRow5 = new DevExpress.XtraReports.UI.XRTableRow();
        this.xrTableCell23 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell24 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell25 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell26 = new DevExpress.XtraReports.UI.XRTableCell();
        this.formattingRule1 = new DevExpress.XtraReports.UI.FormattingRule();
        this.Labels_Header = new DevExpress.XtraReports.UI.GroupHeaderBand();
        this.xrTable3 = new DevExpress.XtraReports.UI.XRTable();
        this.xrTableRow4 = new DevExpress.XtraReports.UI.XRTableRow();
        this.xrTableCell16 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell17 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell18 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell19 = new DevExpress.XtraReports.UI.XRTableCell();
        this.InvoiceTypes = new DevExpress.XtraReports.Parameters.Parameter();
        this.FODay_GroupFooter = new DevExpress.XtraReports.UI.GroupFooterBand();
        ((System.ComponentModel.ISupportInitialize)(this.xrTable5)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.xrTable8)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.xrTable2)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.xrTable9)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.xrTable10)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.xrTable4)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.xrTable3)).BeginInit();
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
        customSqlQuery3.Name = "CategoriesLookups";
        customSqlQuery3.Sql = "Select Id, Description From Categories -- Order By Description";
        customSqlQuery4.Name = "ProductCategoriesLookups";
        customSqlQuery4.Sql = "Select Id, Code, Description\r\nFrom ProductCategories\r\nOrder By Code\r\n-- Order By " +
"Description Desc\r\n";
        customSqlQuery5.Name = "PosInfoLookUps";
        customSqlQuery5.Sql = "Select Id, Code, Description From PosInfo Order By Description";
        customSqlQuery6.Name = "Vats";
        customSqlQuery6.Sql = "/* VATS */\r\nSELECT [Id]\r\n      ,[Description]\r\n      ,[Percentage]\r\n      ,[Code]" +
"\r\nFROM Vat\r\n";
        customSqlQuery7.Name = "InvoiceTypes";
        customSqlQuery7.Sql = "select Id,Type, Abbreviation from InvoiceTypes";
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
            this.xrTable5});
        this.Detail.HeightF = 18F;
        this.Detail.Name = "Detail";
        this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
        this.Detail.StyleName = "DataField";
        this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
        // 
        // xrTable5
        // 
        this.xrTable5.Font = new System.Drawing.Font("Times New Roman", 8F);
        this.xrTable5.LocationFloat = new DevExpress.Utils.PointFloat(3F, 0F);
        this.xrTable5.Name = "xrTable5";
        this.xrTable5.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow6});
        this.xrTable5.SizeF = new System.Drawing.SizeF(744F, 18F);
        this.xrTable5.StylePriority.UseFont = false;
        this.xrTable5.StylePriority.UseTextAlignment = false;
        this.xrTable5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        // 
        // xrTableRow6
        // 
        this.xrTableRow6.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell11,
            this.xrTableCell12,
            this.xrTableCell27,
            this.xrTableCell13,
            this.xrTableCell5,
            this.xrTableCell30,
            this.xrTableCell29});
        this.xrTableRow6.Name = "xrTableRow6";
        this.xrTableRow6.Weight = 1D;
        // 
        // xrTableCell11
        // 
        this.xrTableCell11.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.Category")});
        this.xrTableCell11.Name = "xrTableCell11";
        this.xrTableCell11.StylePriority.UseTextAlignment = false;
        this.xrTableCell11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
        this.xrTableCell11.Weight = 2.4898454495978841D;
        // 
        // xrTableCell12
        // 
        this.xrTableCell12.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.Total")});
        this.xrTableCell12.Name = "xrTableCell12";
        this.xrTableCell12.StylePriority.UseTextAlignment = false;
        this.xrTableCell12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
        this.xrTableCell12.Weight = 0.9423690767846471D;
        // 
        // xrTableCell27
        // 
        this.xrTableCell27.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.GroupTotal")});
        this.xrTableCell27.ForeColor = System.Drawing.Color.Black;
        this.xrTableCell27.Name = "xrTableCell27";
        this.xrTableCell27.StylePriority.UseForeColor = false;
        this.xrTableCell27.StylePriority.UseTextAlignment = false;
        this.xrTableCell27.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
        this.xrTableCell27.Visible = false;
        this.xrTableCell27.Weight = 0.013440604456196791D;
        // 
        // xrTableCell13
        // 
        this.xrTableCell13.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.Net")});
        this.xrTableCell13.Name = "xrTableCell13";
        this.xrTableCell13.StylePriority.UseTextAlignment = false;
        this.xrTableCell13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
        this.xrTableCell13.Weight = 0.7474546790093165D;
        // 
        // xrTableCell5
        // 
        this.xrTableCell5.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.GroupNet")});
        this.xrTableCell5.Name = "xrTableCell5";
        this.xrTableCell5.StylePriority.UseTextAlignment = false;
        this.xrTableCell5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
        this.xrTableCell5.Visible = false;
        this.xrTableCell5.Weight = 0.013440841090487821D;
        // 
        // xrTableCell30
        // 
        this.xrTableCell30.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.VatAmount")});
        this.xrTableCell30.Name = "xrTableCell30";
        this.xrTableCell30.StylePriority.UseTextAlignment = false;
        this.xrTableCell30.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
        this.xrTableCell30.Weight = 0.78000840418348061D;
        // 
        // xrTableCell29
        // 
        this.xrTableCell29.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.GroupVatAmount")});
        this.xrTableCell29.Name = "xrTableCell29";
        this.xrTableCell29.StylePriority.UseTextAlignment = false;
        this.xrTableCell29.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
        this.xrTableCell29.Visible = false;
        this.xrTableCell29.Weight = 0.013441115491964258D;
        // 
        // TopMargin
        // 
        this.TopMargin.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrPageInfo3});
        this.TopMargin.HeightF = 57F;
        this.TopMargin.Name = "TopMargin";
        this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
        this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
        // 
        // xrPageInfo3
        // 
        this.xrPageInfo3.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
        this.xrPageInfo3.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
        this.xrPageInfo3.Format = "Ημερομηνία Εκτύπωσης : {0:dddd, d MMMM yyyy h:mm:ss tt}";
        this.xrPageInfo3.LocationFloat = new DevExpress.Utils.PointFloat(3F, 37.57062F);
        this.xrPageInfo3.Name = "xrPageInfo3";
        this.xrPageInfo3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.xrPageInfo3.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime;
        this.xrPageInfo3.SizeF = new System.Drawing.SizeF(744F, 16.76271F);
        this.xrPageInfo3.StylePriority.UseBorders = false;
        this.xrPageInfo3.StylePriority.UseFont = false;
        // 
        // BottomMargin
        // 
        this.BottomMargin.HeightF = 36.48729F;
        this.BottomMargin.Name = "BottomMargin";
        this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
        this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
        // 
        // pageFooterBand1
        // 
        this.pageFooterBand1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrPageInfo1});
        this.pageFooterBand1.HeightF = 15.76271F;
        this.pageFooterBand1.Name = "pageFooterBand1";
        // 
        // xrPageInfo1
        // 
        this.xrPageInfo1.Borders = DevExpress.XtraPrinting.BorderSide.Top;
        this.xrPageInfo1.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
        this.xrPageInfo1.Format = "Σελίδα {0} από {1}";
        this.xrPageInfo1.LocationFloat = new DevExpress.Utils.PointFloat(3F, 0F);
        this.xrPageInfo1.Name = "xrPageInfo1";
        this.xrPageInfo1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.xrPageInfo1.SizeF = new System.Drawing.SizeF(744F, 15.76271F);
        this.xrPageInfo1.StylePriority.UseBorders = false;
        this.xrPageInfo1.StylePriority.UseFont = false;
        this.xrPageInfo1.StylePriority.UseTextAlignment = false;
        this.xrPageInfo1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
        // 
        // reportHeaderBand1
        // 
        this.reportHeaderBand1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable1});
        this.reportHeaderBand1.HeightF = 37.49999F;
        this.reportHeaderBand1.Name = "reportHeaderBand1";
        // 
        // xrTable1
        // 
        this.xrTable1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
        this.xrTable1.LocationFloat = new DevExpress.Utils.PointFloat(3F, 0F);
        this.xrTable1.Name = "xrTable1";
        this.xrTable1.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow1,
            this.xrTableRow2});
        this.xrTable1.SizeF = new System.Drawing.SizeF(744F, 36F);
        this.xrTable1.StylePriority.UseFont = false;
        // 
        // xrTableRow1
        // 
        this.xrTableRow1.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell2});
        this.xrTableRow1.Name = "xrTableRow1";
        this.xrTableRow1.Weight = 1D;
        // 
        // xrTableCell2
        // 
        this.xrTableCell2.Name = "xrTableCell2";
        this.xrTableCell2.StylePriority.UseTextAlignment = false;
        this.xrTableCell2.Text = "Πωλήσεις Ειδών ανά Κατηγορία και POS - Συνοπτικά";
        this.xrTableCell2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
        this.xrTableCell2.Weight = 3D;
        // 
        // xrTableRow2
        // 
        this.xrTableRow2.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell4,
            this.xrTableCell6});
        this.xrTableRow2.Name = "xrTableRow2";
        this.xrTableRow2.Weight = 1D;
        // 
        // xrTableCell4
        // 
        this.xrTableCell4.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding(this.FromFODay, "Text", "(από {0}")});
        this.xrTableCell4.Name = "xrTableCell4";
        this.xrTableCell4.StylePriority.UseTextAlignment = false;
        this.xrTableCell4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
        this.xrTableCell4.Weight = 1.493907190138293D;
        // 
        // FromFODay
        // 
        this.FromFODay.Description = "From Date";
        this.FromFODay.Name = "FromFODay";
        this.FromFODay.Type = typeof(System.DateTime);
        this.FromFODay.ValueInfo = "2016-05-25";
        // 
        // xrTableCell6
        // 
        this.xrTableCell6.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding(this.UpToFODay, "Text", " έως {0})")});
        this.xrTableCell6.Name = "xrTableCell6";
        this.xrTableCell6.Weight = 1.506092809861707D;
        // 
        // UpToFODay
        // 
        this.UpToFODay.Description = "UpTo Date";
        this.UpToFODay.Name = "UpToFODay";
        this.UpToFODay.Type = typeof(System.DateTime);
        this.UpToFODay.ValueInfo = "2016-05-25";
        // 
        // groupFooterBand1
        // 
        this.groupFooterBand1.HeightF = 1F;
        this.groupFooterBand1.Name = "groupFooterBand1";
        // 
        // reportFooterBand1
        // 
        this.reportFooterBand1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable8});
        this.reportFooterBand1.HeightF = 21.37509F;
        this.reportFooterBand1.Name = "reportFooterBand1";
        // 
        // xrTable8
        // 
        this.xrTable8.BackColor = System.Drawing.Color.LightGray;
        this.xrTable8.Borders = DevExpress.XtraPrinting.BorderSide.Top;
        this.xrTable8.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
        this.xrTable8.LocationFloat = new DevExpress.Utils.PointFloat(3F, 0F);
        this.xrTable8.Name = "xrTable8";
        this.xrTable8.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow9});
        this.xrTable8.SizeF = new System.Drawing.SizeF(744F, 18F);
        this.xrTable8.StylePriority.UseBackColor = false;
        this.xrTable8.StylePriority.UseBorders = false;
        this.xrTable8.StylePriority.UseFont = false;
        this.xrTable8.StylePriority.UseTextAlignment = false;
        this.xrTable8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        // 
        // xrTableRow9
        // 
        this.xrTableRow9.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell20,
            this.xrTableCell21,
            this.xrTableCell35,
            this.xrTableCell22});
        this.xrTableRow9.Name = "xrTableRow9";
        this.xrTableRow9.Weight = 1D;
        // 
        // xrTableCell20
        // 
        this.xrTableCell20.Name = "xrTableCell20";
        this.xrTableCell20.StylePriority.UseTextAlignment = false;
        this.xrTableCell20.Text = "Γενικά Σύνολα";
        this.xrTableCell20.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
        this.xrTableCell20.Weight = 1.484180964763131D;
        // 
        // xrTableCell21
        // 
        this.xrTableCell21.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.Total")});
        this.xrTableCell21.Name = "xrTableCell21";
        this.xrTableCell21.StylePriority.UseTextAlignment = false;
        xrSummary1.FormatString = "{0:#,##0.00}";
        xrSummary1.IgnoreNullValues = true;
        xrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Report;
        this.xrTableCell21.Summary = xrSummary1;
        this.xrTableCell21.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
        this.xrTableCell21.Weight = 0.56975200266214865D;
        // 
        // xrTableCell35
        // 
        this.xrTableCell35.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.Net")});
        this.xrTableCell35.Name = "xrTableCell35";
        this.xrTableCell35.StylePriority.UseTextAlignment = false;
        xrSummary2.FormatString = "{0:#,##0.00}";
        xrSummary2.IgnoreNullValues = true;
        xrSummary2.Running = DevExpress.XtraReports.UI.SummaryRunning.Report;
        this.xrTableCell35.Summary = xrSummary2;
        this.xrTableCell35.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
        this.xrTableCell35.Weight = 0.453565233307116D;
        // 
        // xrTableCell22
        // 
        this.xrTableCell22.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.VatAmount")});
        this.xrTableCell22.Name = "xrTableCell22";
        this.xrTableCell22.StylePriority.UseTextAlignment = false;
        xrSummary3.FormatString = "{0:#,##0.00}";
        xrSummary3.IgnoreNullValues = true;
        xrSummary3.Running = DevExpress.XtraReports.UI.SummaryRunning.Report;
        this.xrTableCell22.Summary = xrSummary3;
        this.xrTableCell22.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
        this.xrTableCell22.Weight = 0.47297005704859996D;
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
        // PosInfoID
        // 
        this.PosInfoID.Description = "Select POS";
        dynamicListLookUpSettings1.DataAdapter = null;
        dynamicListLookUpSettings1.DataMember = "PosInfoLookUps";
        dynamicListLookUpSettings1.DataSource = this.sqlDataSource1;
        dynamicListLookUpSettings1.DisplayMember = "Description";
        dynamicListLookUpSettings1.FilterString = null;
        dynamicListLookUpSettings1.ValueMember = "Id";
        this.PosInfoID.LookUpSettings = dynamicListLookUpSettings1;
        this.PosInfoID.MultiValue = true;
        this.PosInfoID.Name = "PosInfoID";
        this.PosInfoID.Type = typeof(long);
        // 
        // InvoiceTypes
        // 
        this.InvoiceTypes.Description = "Select Invoice Types";
        dynamicListLookUpSettings2.DataAdapter = null;
        dynamicListLookUpSettings2.DataMember = "InvoiceTypes";
        dynamicListLookUpSettings2.DataSource = this.sqlDataSource1;
        dynamicListLookUpSettings2.DisplayMember = "Abbreviation";
        dynamicListLookUpSettings2.FilterString = null;
        dynamicListLookUpSettings2.ValueMember = "Type";
        this.InvoiceTypes.LookUpSettings = dynamicListLookUpSettings2;
        this.InvoiceTypes.MultiValue = true;
        this.InvoiceTypes.Name = "InvoiceTypes";
        this.InvoiceTypes.Type = typeof(short);
        // 
        // PosInfoGroupHeader
        // 
        this.PosInfoGroupHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable2});
        this.PosInfoGroupHeader.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("PosInfoId", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
        this.PosInfoGroupHeader.HeightF = 18F;
        this.PosInfoGroupHeader.Level = 3;
        this.PosInfoGroupHeader.Name = "PosInfoGroupHeader";
        // 
        // xrTable2
        // 
        this.xrTable2.BackColor = System.Drawing.Color.Gray;
        this.xrTable2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
        this.xrTable2.ForeColor = System.Drawing.Color.White;
        this.xrTable2.LocationFloat = new DevExpress.Utils.PointFloat(3F, 0F);
        this.xrTable2.Name = "xrTable2";
        this.xrTable2.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow3});
        this.xrTable2.SizeF = new System.Drawing.SizeF(744F, 18F);
        this.xrTable2.StylePriority.UseBackColor = false;
        this.xrTable2.StylePriority.UseFont = false;
        this.xrTable2.StylePriority.UseForeColor = false;
        this.xrTable2.StylePriority.UseTextAlignment = false;
        this.xrTable2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        // 
        // xrTableRow3
        // 
        this.xrTableRow3.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell1,
            this.xrTableCell10,
            this.xrTableCell14,
            this.xrTableCell15});
        this.xrTableRow3.Name = "xrTableRow3";
        this.xrTableRow3.Weight = 1D;
        // 
        // xrTableCell1
        // 
        this.xrTableCell1.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.PosInfoDescription", "Σημείο Πώλησης : {0}")});
        this.xrTableCell1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
        this.xrTableCell1.Name = "xrTableCell1";
        this.xrTableCell1.StylePriority.UseFont = false;
        this.xrTableCell1.StylePriority.UseTextAlignment = false;
        this.xrTableCell1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
        this.xrTableCell1.Weight = 0.49796906337943136D;
        // 
        // xrTableCell10
        // 
        this.xrTableCell10.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.GroupTotal")});
        this.xrTableCell10.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
        this.xrTableCell10.Name = "xrTableCell10";
        this.xrTableCell10.StylePriority.UseFont = false;
        this.xrTableCell10.StylePriority.UseTextAlignment = false;
        xrSummary4.FormatString = "{0:#,##0.00}";
        xrSummary4.IgnoreNullValues = true;
        xrSummary4.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
        this.xrTableCell10.Summary = xrSummary4;
        this.xrTableCell10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
        this.xrTableCell10.Weight = 0.19116198632024956D;
        // 
        // xrTableCell14
        // 
        this.xrTableCell14.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.GroupNet")});
        this.xrTableCell14.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
        this.xrTableCell14.Name = "xrTableCell14";
        this.xrTableCell14.StylePriority.UseFont = false;
        this.xrTableCell14.StylePriority.UseTextAlignment = false;
        xrSummary5.FormatString = "{0:#,##0.00}";
        xrSummary5.IgnoreNullValues = true;
        xrSummary5.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
        this.xrTableCell14.Summary = xrSummary5;
        this.xrTableCell14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
        this.xrTableCell14.Weight = 0.15217922398213024D;
        // 
        // xrTableCell15
        // 
        this.xrTableCell15.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.GroupVatAmount")});
        this.xrTableCell15.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
        this.xrTableCell15.Name = "xrTableCell15";
        this.xrTableCell15.StylePriority.UseFont = false;
        this.xrTableCell15.StylePriority.UseTextAlignment = false;
        xrSummary6.FormatString = "{0:#,##0.00}";
        xrSummary6.IgnoreNullValues = true;
        xrSummary6.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
        this.xrTableCell15.Summary = xrSummary6;
        this.xrTableCell15.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
        this.xrTableCell15.Weight = 0.15868980523559573D;
        // 
        // PaymentsDescription_GroupHeader
        // 
        this.PaymentsDescription_GroupHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable9});
        this.PaymentsDescription_GroupHeader.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("PaymentsDesc", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
        this.PaymentsDescription_GroupHeader.HeightF = 19F;
        this.PaymentsDescription_GroupHeader.Level = 1;
        this.PaymentsDescription_GroupHeader.Name = "PaymentsDescription_GroupHeader";
        // 
        // xrTable9
        // 
        this.xrTable9.BackColor = System.Drawing.Color.Silver;
        this.xrTable9.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
        this.xrTable9.LocationFloat = new DevExpress.Utils.PointFloat(3F, 0F);
        this.xrTable9.Name = "xrTable9";
        this.xrTable9.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow11});
        this.xrTable9.SizeF = new System.Drawing.SizeF(744F, 19F);
        this.xrTable9.StylePriority.UseBackColor = false;
        this.xrTable9.StylePriority.UseFont = false;
        this.xrTable9.StylePriority.UseTextAlignment = false;
        this.xrTable9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        // 
        // xrTableRow11
        // 
        this.xrTableRow11.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell9,
            this.xrTableCell32,
            this.xrTableCell33,
            this.xrTableCell3});
        this.xrTableRow11.Name = "xrTableRow11";
        this.xrTableRow11.Weight = 1D;
        // 
        // xrTableCell9
        // 
        this.xrTableCell9.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.PaymentsDesc")});
        this.xrTableCell9.Name = "xrTableCell9";
        this.xrTableCell9.StylePriority.UseTextAlignment = false;
        this.xrTableCell9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
        this.xrTableCell9.Weight = 1.4939071901382939D;
        // 
        // xrTableCell32
        // 
        this.xrTableCell32.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.Total")});
        this.xrTableCell32.Name = "xrTableCell32";
        this.xrTableCell32.StylePriority.UseTextAlignment = false;
        xrSummary7.FormatString = "{0:#,##0.00}";
        xrSummary7.IgnoreNullValues = true;
        xrSummary7.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
        this.xrTableCell32.Summary = xrSummary7;
        this.xrTableCell32.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
        this.xrTableCell32.Weight = 0.57348571285124728D;
        // 
        // xrTableCell33
        // 
        this.xrTableCell33.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.Net")});
        this.xrTableCell33.Name = "xrTableCell33";
        this.xrTableCell33.StylePriority.UseTextAlignment = false;
        xrSummary8.FormatString = "{0:#,##0.00}";
        xrSummary8.IgnoreNullValues = true;
        xrSummary8.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
        this.xrTableCell33.Summary = xrSummary8;
        this.xrTableCell33.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
        this.xrTableCell33.Weight = 0.45653755434097781D;
        // 
        // xrTableCell3
        // 
        this.xrTableCell3.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.VatAmount")});
        this.xrTableCell3.Name = "xrTableCell3";
        this.xrTableCell3.StylePriority.UseTextAlignment = false;
        xrSummary9.FormatString = "{0:#,##0.00}";
        xrSummary9.IgnoreNullValues = true;
        xrSummary9.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
        this.xrTableCell3.Summary = xrSummary9;
        this.xrTableCell3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
        this.xrTableCell3.Weight = 0.47606954266948071D;
        // 
        // FODay_GroupHeader
        // 
        this.FODay_GroupHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable10,
            this.xrSubreport1});
        this.FODay_GroupHeader.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("FODay", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
        this.FODay_GroupHeader.HeightF = 64.5F;
        this.FODay_GroupHeader.Level = 4;
        this.FODay_GroupHeader.Name = "FODay_GroupHeader";
        // 
        // xrTable10
        // 
        this.xrTable10.BackColor = System.Drawing.Color.Gray;
        this.xrTable10.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
        this.xrTable10.ForeColor = System.Drawing.Color.White;
        this.xrTable10.LocationFloat = new DevExpress.Utils.PointFloat(3F, 0F);
        this.xrTable10.Name = "xrTable10";
        this.xrTable10.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow12});
        this.xrTable10.SizeF = new System.Drawing.SizeF(744F, 18F);
        this.xrTable10.StylePriority.UseBackColor = false;
        this.xrTable10.StylePriority.UseFont = false;
        this.xrTable10.StylePriority.UseForeColor = false;
        this.xrTable10.StylePriority.UseTextAlignment = false;
        this.xrTable10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        // 
        // xrTableRow12
        // 
        this.xrTableRow12.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell34,
            this.xrTableCell28,
            this.xrTableCell7,
            this.xrTableCell8});
        this.xrTableRow12.Name = "xrTableRow12";
        this.xrTableRow12.Weight = 1D;
        // 
        // xrTableCell34
        // 
        this.xrTableCell34.BackColor = System.Drawing.Color.DimGray;
        this.xrTableCell34.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.FODay", "{0:dddd, d MMMM yyyy}")});
        this.xrTableCell34.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
        this.xrTableCell34.ForeColor = System.Drawing.Color.White;
        this.xrTableCell34.Name = "xrTableCell34";
        this.xrTableCell34.StylePriority.UseBackColor = false;
        this.xrTableCell34.StylePriority.UseFont = false;
        this.xrTableCell34.StylePriority.UseForeColor = false;
        this.xrTableCell34.StylePriority.UseTextAlignment = false;
        this.xrTableCell34.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
        this.xrTableCell34.Weight = 0.501536133468792D;
        // 
        // xrTableCell28
        // 
        this.xrTableCell28.BackColor = System.Drawing.Color.DimGray;
        this.xrTableCell28.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.GroupTotal")});
        this.xrTableCell28.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
        this.xrTableCell28.ForeColor = System.Drawing.Color.White;
        this.xrTableCell28.Name = "xrTableCell28";
        this.xrTableCell28.StylePriority.UseBackColor = false;
        this.xrTableCell28.StylePriority.UseFont = false;
        this.xrTableCell28.StylePriority.UseForeColor = false;
        this.xrTableCell28.StylePriority.UseTextAlignment = false;
        xrSummary10.FormatString = "{0:#,##0.00}";
        xrSummary10.IgnoreNullValues = true;
        xrSummary10.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
        this.xrTableCell28.Summary = xrSummary10;
        this.xrTableCell28.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
        this.xrTableCell28.Weight = 0.18759491623088892D;
        // 
        // xrTableCell7
        // 
        this.xrTableCell7.BackColor = System.Drawing.Color.DimGray;
        this.xrTableCell7.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.GroupNet")});
        this.xrTableCell7.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
        this.xrTableCell7.ForeColor = System.Drawing.Color.White;
        this.xrTableCell7.Name = "xrTableCell7";
        this.xrTableCell7.StylePriority.UseBackColor = false;
        this.xrTableCell7.StylePriority.UseFont = false;
        this.xrTableCell7.StylePriority.UseForeColor = false;
        this.xrTableCell7.StylePriority.UseTextAlignment = false;
        xrSummary11.FormatString = "{0:#,##0.00}";
        xrSummary11.IgnoreNullValues = true;
        xrSummary11.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
        this.xrTableCell7.Summary = xrSummary11;
        this.xrTableCell7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
        this.xrTableCell7.Weight = 0.15217918478032591D;
        // 
        // xrTableCell8
        // 
        this.xrTableCell8.BackColor = System.Drawing.Color.DimGray;
        this.xrTableCell8.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.GroupVatAmount")});
        this.xrTableCell8.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
        this.xrTableCell8.ForeColor = System.Drawing.Color.White;
        this.xrTableCell8.Name = "xrTableCell8";
        this.xrTableCell8.StylePriority.UseBackColor = false;
        this.xrTableCell8.StylePriority.UseFont = false;
        this.xrTableCell8.StylePriority.UseForeColor = false;
        this.xrTableCell8.StylePriority.UseTextAlignment = false;
        xrSummary12.FormatString = "{0:#,##0.00}";
        xrSummary12.IgnoreNullValues = true;
        xrSummary12.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
        this.xrTableCell8.Summary = xrSummary12;
        this.xrTableCell8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
        this.xrTableCell8.Weight = 0.15868976551999331D;
        // 
        // xrSubreport1
        // 
        this.xrSubreport1.CanShrink = true;
        this.xrSubreport1.LocationFloat = new DevExpress.Utils.PointFloat(3F, 21.25002F);
        this.xrSubreport1.Name = "xrSubreport1";
        this.xrSubreport1.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("FromDate", null, "Query.FODay"));
        this.xrSubreport1.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("ToDate", null, "Query.FODay"));
        this.xrSubreport1.ReportSource = new SalesPerCategoryAndPosTotal_Subreport();
        this.xrSubreport1.SizeF = new System.Drawing.SizeF(744F, 37.75F);
        // 
        // VoidStatus_GroupHeader
        // 
        this.VoidStatus_GroupHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable4});
        this.VoidStatus_GroupHeader.FormattingRules.Add(this.formattingRule1);
        this.VoidStatus_GroupHeader.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("VoidStatus", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
        this.VoidStatus_GroupHeader.HeightF = 19F;
        this.VoidStatus_GroupHeader.Level = 2;
        this.VoidStatus_GroupHeader.Name = "VoidStatus_GroupHeader";
        // 
        // xrTable4
        // 
        this.xrTable4.BackColor = System.Drawing.Color.DarkGray;
        this.xrTable4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
        this.xrTable4.LocationFloat = new DevExpress.Utils.PointFloat(3F, 0F);
        this.xrTable4.Name = "xrTable4";
        this.xrTable4.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow5});
        this.xrTable4.SizeF = new System.Drawing.SizeF(744F, 19F);
        this.xrTable4.StylePriority.UseBackColor = false;
        this.xrTable4.StylePriority.UseFont = false;
        this.xrTable4.StylePriority.UseTextAlignment = false;
        this.xrTable4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        // 
        // xrTableRow5
        // 
        this.xrTableRow5.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell23,
            this.xrTableCell24,
            this.xrTableCell25,
            this.xrTableCell26});
        this.xrTableRow5.Name = "xrTableRow5";
        this.xrTableRow5.Weight = 1D;
        // 
        // xrTableCell23
        // 
        this.xrTableCell23.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.VoidStatus")});
        this.xrTableCell23.Name = "xrTableCell23";
        this.xrTableCell23.StylePriority.UseTextAlignment = false;
        this.xrTableCell23.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
        this.xrTableCell23.Weight = 1.4939071901382939D;
        // 
        // xrTableCell24
        // 
        this.xrTableCell24.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.Total")});
        this.xrTableCell24.Name = "xrTableCell24";
        this.xrTableCell24.StylePriority.UseTextAlignment = false;
        xrSummary13.FormatString = "{0:#,##0.00}";
        xrSummary13.IgnoreNullValues = true;
        xrSummary13.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
        this.xrTableCell24.Summary = xrSummary13;
        this.xrTableCell24.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
        this.xrTableCell24.Weight = 0.57348571285124728D;
        // 
        // xrTableCell25
        // 
        this.xrTableCell25.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.Net")});
        this.xrTableCell25.Name = "xrTableCell25";
        this.xrTableCell25.StylePriority.UseTextAlignment = false;
        xrSummary14.FormatString = "{0:#,##0.00}";
        xrSummary14.IgnoreNullValues = true;
        xrSummary14.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
        this.xrTableCell25.Summary = xrSummary14;
        this.xrTableCell25.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
        this.xrTableCell25.Weight = 0.45653755434097781D;
        // 
        // xrTableCell26
        // 
        this.xrTableCell26.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.VatAmount")});
        this.xrTableCell26.Name = "xrTableCell26";
        this.xrTableCell26.StylePriority.UseTextAlignment = false;
        xrSummary15.FormatString = "{0:#,##0.00}";
        xrSummary15.IgnoreNullValues = true;
        xrSummary15.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
        this.xrTableCell26.Summary = xrSummary15;
        this.xrTableCell26.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
        this.xrTableCell26.Weight = 0.47606954266948071D;
        // 
        // formattingRule1
        // 
        this.formattingRule1.Condition = "[VoidStatus] == \'\'";
        // 
        // 
        // 
        this.formattingRule1.Formatting.Visible = DevExpress.Utils.DefaultBoolean.False;
        this.formattingRule1.Name = "formattingRule1";
        // 
        // Labels_Header
        // 
        this.Labels_Header.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable3});
        this.Labels_Header.HeightF = 17F;
        this.Labels_Header.Name = "Labels_Header";
        // 
        // xrTable3
        // 
        this.xrTable3.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
        this.xrTable3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
        this.xrTable3.LocationFloat = new DevExpress.Utils.PointFloat(3F, 3F);
        this.xrTable3.Name = "xrTable3";
        this.xrTable3.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow4});
        this.xrTable3.SizeF = new System.Drawing.SizeF(744F, 14F);
        this.xrTable3.StylePriority.UseBorders = false;
        this.xrTable3.StylePriority.UseFont = false;
        this.xrTable3.StylePriority.UseTextAlignment = false;
        this.xrTable3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        // 
        // xrTableRow4
        // 
        this.xrTableRow4.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell16,
            this.xrTableCell17,
            this.xrTableCell18,
            this.xrTableCell19});
        this.xrTableRow4.Name = "xrTableRow4";
        this.xrTableRow4.Weight = 1D;
        // 
        // xrTableCell16
        // 
        this.xrTableCell16.Name = "xrTableCell16";
        this.xrTableCell16.StylePriority.UseTextAlignment = false;
        this.xrTableCell16.Text = "Λογιστική Ομάδα";
        this.xrTableCell16.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
        this.xrTableCell16.Weight = 1.9918762535177255D;
        // 
        // xrTableCell17
        // 
        this.xrTableCell17.Name = "xrTableCell17";
        this.xrTableCell17.StylePriority.UseTextAlignment = false;
        this.xrTableCell17.Text = "Μικτή";
        this.xrTableCell17.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
        this.xrTableCell17.Weight = 0.76464761713499663D;
        // 
        // xrTableCell18
        // 
        this.xrTableCell18.Name = "xrTableCell18";
        this.xrTableCell18.StylePriority.UseTextAlignment = false;
        this.xrTableCell18.Text = "Καθαρή";
        this.xrTableCell18.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
        this.xrTableCell18.Weight = 0.60871673912130353D;
        // 
        // xrTableCell19
        // 
        this.xrTableCell19.Name = "xrTableCell19";
        this.xrTableCell19.StylePriority.UseTextAlignment = false;
        this.xrTableCell19.Text = "Αξία ΦΠΑ";
        this.xrTableCell19.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
        this.xrTableCell19.Weight = 0.6347593902259745D;
        // 
        // FODay_GroupFooter
        // 
        this.FODay_GroupFooter.HeightF = 0F;
        this.FODay_GroupFooter.Level = 4;
        this.FODay_GroupFooter.Name = "FODay_GroupFooter";
        // 
        // SalesPerCategoryAndPosTotal
        // 
        this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.pageFooterBand1,
            this.reportHeaderBand1,
            this.reportFooterBand1,
            this.PosInfoGroupHeader,
            this.PaymentsDescription_GroupHeader,
            this.FODay_GroupHeader,
            this.VoidStatus_GroupHeader,
            this.Labels_Header,
            this.FODay_GroupFooter});
        this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.sqlDataSource1});
        this.DataMember = "Query_FastStart";
        this.DataSource = this.sqlDataSource1;
        this.FilterString = "[FODay] >= ?FromFODay And [FODay] <= ?UpToFODay And [PosInfoId] In (?PosInfoID) And [InvoiceType] In (?InvoiceTypes)";
        this.FormattingRuleSheet.AddRange(new DevExpress.XtraReports.UI.FormattingRule[] {
            this.formattingRule1});
        this.Margins = new System.Drawing.Printing.Margins(37, 40, 57, 36);
        this.PageHeight = 1169;
        this.PageWidth = 827;
        this.PaperKind = System.Drawing.Printing.PaperKind.A4;
        this.Parameters.AddRange(new DevExpress.XtraReports.Parameters.Parameter[] {
            this.FromFODay,
            this.UpToFODay,
            this.PosInfoID,
        this.InvoiceTypes});
        this.StyleSheet.AddRange(new DevExpress.XtraReports.UI.XRControlStyle[] {
            this.Title,
            this.FieldCaption,
            this.PageInfo,
            this.DataField});
        this.Version = "15.2";
        this.ParametersRequestBeforeShow += new System.EventHandler<DevExpress.XtraReports.Parameters.ParametersRequestEventArgs>(this.SalesPerCategoryAndPosTotal_ParametersRequestBeforeShow);
        this.DataSourceDemanded += new System.EventHandler<System.EventArgs>(this.SalesPerCategoryAndPosTotal_DataSourceDemanded);
        ((System.ComponentModel.ISupportInitialize)(this.xrTable5)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.xrTable8)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.xrTable2)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.xrTable9)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.xrTable10)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.xrTable4)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.xrTable3)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

    }

    #endregion

    ////////////////////////////////////////////////////////////////////////////////////////////////
    /// <summary>
    /// 
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void SalesPerCategoryAndPosTotal_DataSourceDemanded(object sender, EventArgs e)
    {
        int? dbVersion = Convert.ToInt32(WebConfigurationManager.AppSettings["DBVersion"]);

        if (dbVersion != 1)
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
    private void SalesPerCategoryAndPosTotal_ParametersRequestBeforeShow(object sender
                                , DevExpress.XtraReports.Parameters.ParametersRequestEventArgs e)
    {
        sqlDataSource1.Fill();

        foreach (var paramItem in e.ParametersInformation)
        {

            if ("DateTime" == paramItem.Parameter.Type.Name)
            {
                //paramItem.Parameter.Value = DateTime.MinValue;
                paramItem.Parameter.Value = DateTime.Now.Date;
            }
            else if (paramItem.Parameter.MultiValue)
            {

                switch (paramItem.Parameter.Name)
                {
                    case "CategoryId":
                        // select all values for parameter CategoryId
                        paramItem.Parameter.Value = CommonTools.SetAllSelectedForMultiValueParameter<Int64>(sqlDataSource1, "CategoriesLookups", "Id");
                        break;

                    case "PosInfoID":
                        // select all values for parameter PosInfoID
                        paramItem.Parameter.Value = CommonTools.SetAllSelectedForMultiValueParameter<Int64>(sqlDataSource1, "PosInfoLookUps", "Id");
                        break;

                    case "ProductCategoryID":
                        // select all values for parameter ProductCategoryID
                        paramItem.Parameter.Value = CommonTools.SetAllSelectedForMultiValueParameter<Int64>(sqlDataSource1, "ProductCategoriesLookups", "Id");
                        break;

                    case "InvoiceTypes":
                        // select all values for parameter InvoiceTypes
                        paramItem.Parameter.Value = CommonTools.SetAllSelectedForMultiValueParameter<Int16>(sqlDataSource1, "InvoiceTypes", "Type");
                        break;

                    default:
                        break;
                }

            }

        }

    }

    ////////////////////////////////////////////////////////////////////////////////////////////////
}

