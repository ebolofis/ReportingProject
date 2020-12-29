using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using DevExpress.Web.ASPxPivotGrid;

/// <summary>
/// Summary description for ProductFilesPivot
/// </summary>
public class ProductFilesPivot : DevExpress.XtraReports.UI.XtraReport
{
    private DevExpress.XtraReports.UI.DetailBand Detail;
    private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
    private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
    private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
    private XRPivotGrid xrPivotGrid1;
    private XRLabel xrLabel1;
    private XRLine xrLine1;
    private XRPageInfo xrPageInfo1;
    private XRPageInfo xrPageInfo2;
    private DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField fieldCode1;
    private DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField fieldDescription1;
    private DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField fieldProductCategoryID1;
    private DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField fieldProductCategory1;
    private DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField fieldCategoryID1;
    private DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField fieldCategory1;
    private DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField fieldPriceListID1;
    private DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField fieldPriceList1;
    private DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField fieldPrice1;
    private ReportFooterBand ReportFooter;
    private DevExpress.XtraReports.Parameters.Parameter IsDeletedPrm;
    private DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField Ενεργό;

    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    public ProductFilesPivot()
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductFilesPivot));
            DevExpress.XtraReports.Parameters.StaticListLookUpSettings staticListLookUpSettings1 = new DevExpress.XtraReports.Parameters.StaticListLookUpSettings();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.xrPivotGrid1 = new DevExpress.XtraReports.UI.XRPivotGrid();
            this.fieldCode1 = new DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField();
            this.fieldDescription1 = new DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField();
            this.fieldProductCategoryID1 = new DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField();
            this.fieldProductCategory1 = new DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField();
            this.fieldCategoryID1 = new DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField();
            this.fieldCategory1 = new DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField();
            this.fieldPriceListID1 = new DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField();
            this.fieldPriceList1 = new DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField();
            this.fieldPrice1 = new DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField();
            this.Ενεργό = new DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.xrLine1 = new DevExpress.XtraReports.UI.XRLine();
            this.xrPageInfo1 = new DevExpress.XtraReports.UI.XRPageInfo();
            this.xrPageInfo2 = new DevExpress.XtraReports.UI.XRPageInfo();
            this.ReportFooter = new DevExpress.XtraReports.UI.ReportFooterBand();
            this.IsDeletedPrm = new DevExpress.XtraReports.Parameters.Parameter();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "ReportConnection";
            this.sqlDataSource1.Name = "sqlDataSource1";
            customSqlQuery1.Name = "Query";
            queryParameter1.Name = "SelectedProducts";
            queryParameter1.Type = typeof(short);
            queryParameter1.ValueInfo = "0";
            customSqlQuery1.Parameters.Add(queryParameter1);
            customSqlQuery1.Sql = resources.GetString("customSqlQuery1.Sql");
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            customSqlQuery1});
            this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
            // 
            // Detail
            // 
            this.Detail.HeightF = 30.20833F;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.Detail.Visible = false;
            // 
            // xrPivotGrid1
            // 
            this.xrPivotGrid1.DataMember = "Query";
            this.xrPivotGrid1.Fields.AddRange(new DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField[] {
            this.fieldCode1,
            this.fieldDescription1,
            this.fieldProductCategoryID1,
            this.fieldProductCategory1,
            this.fieldCategoryID1,
            this.fieldCategory1,
            this.fieldPriceListID1,
            this.fieldPriceList1,
            this.fieldPrice1,
            this.Ενεργό});
            this.xrPivotGrid1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrPivotGrid1.Name = "xrPivotGrid1";
            this.xrPivotGrid1.OptionsPrint.FilterSeparatorBarPadding = 3;
            this.xrPivotGrid1.OptionsPrint.PrintFilterHeaders = DevExpress.Utils.DefaultBoolean.True;
            this.xrPivotGrid1.OptionsView.ShowColumnGrandTotalHeader = false;
            this.xrPivotGrid1.OptionsView.ShowColumnGrandTotals = false;
            this.xrPivotGrid1.OptionsView.ShowColumnTotals = false;
            this.xrPivotGrid1.OptionsView.ShowRowGrandTotalHeader = false;
            this.xrPivotGrid1.OptionsView.ShowRowGrandTotals = false;
            this.xrPivotGrid1.OptionsView.ShowRowTotals = false;
            this.xrPivotGrid1.SizeF = new System.Drawing.SizeF(1100F, 65.625F);
            // 
            // fieldCode1
            // 
            this.fieldCode1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldCode1.AreaIndex = 0;
            this.fieldCode1.Caption = "Κωδικός";
            this.fieldCode1.FieldName = "Code";
            this.fieldCode1.Name = "fieldCode1";
            this.fieldCode1.Width = 70;
            // 
            // fieldDescription1
            // 
            this.fieldDescription1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldDescription1.AreaIndex = 1;
            this.fieldDescription1.Caption = "Περιγραφή";
            this.fieldDescription1.FieldName = "Description";
            this.fieldDescription1.Name = "fieldDescription1";
            this.fieldDescription1.Width = 130;
            // 
            // fieldProductCategoryID1
            // 
            this.fieldProductCategoryID1.AreaIndex = 0;
            this.fieldProductCategoryID1.FieldName = "ProductCategoryID";
            this.fieldProductCategoryID1.Name = "fieldProductCategoryID1";
            this.fieldProductCategoryID1.Visible = false;
            // 
            // fieldProductCategory1
            // 
            this.fieldProductCategory1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldProductCategory1.AreaIndex = 2;
            this.fieldProductCategory1.Caption = "Είδος";
            this.fieldProductCategory1.FieldName = "ProductCategory";
            this.fieldProductCategory1.Name = "fieldProductCategory1";
            this.fieldProductCategory1.Options.AllowFilter = DevExpress.Utils.DefaultBoolean.True;
            this.fieldProductCategory1.Options.AllowFilterBySummary = DevExpress.Utils.DefaultBoolean.True;
            this.fieldProductCategory1.Options.GroupFilterMode = DevExpress.XtraPivotGrid.PivotGroupFilterMode.List;
            this.fieldProductCategory1.Width = 110;
            // 
            // fieldCategoryID1
            // 
            this.fieldCategoryID1.AreaIndex = 0;
            this.fieldCategoryID1.FieldName = "CategoryID";
            this.fieldCategoryID1.Name = "fieldCategoryID1";
            this.fieldCategoryID1.Visible = false;
            // 
            // fieldCategory1
            // 
            this.fieldCategory1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldCategory1.AreaIndex = 3;
            this.fieldCategory1.Caption = "Κατηγορία";
            this.fieldCategory1.FieldName = "Category";
            this.fieldCategory1.Name = "fieldCategory1";
            this.fieldCategory1.Width = 110;
            // 
            // fieldPriceListID1
            // 
            this.fieldPriceListID1.AreaIndex = 0;
            this.fieldPriceListID1.FieldName = "PriceListID";
            this.fieldPriceListID1.Name = "fieldPriceListID1";
            this.fieldPriceListID1.Visible = false;
            // 
            // fieldPriceList1
            // 
            this.fieldPriceList1.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.fieldPriceList1.AreaIndex = 0;
            this.fieldPriceList1.Caption = "Τιμοκατάλογος";
            this.fieldPriceList1.FieldName = "PriceList";
            this.fieldPriceList1.Name = "fieldPriceList1";
            this.fieldPriceList1.Options.AllowFilter = DevExpress.Utils.DefaultBoolean.True;
            this.fieldPriceList1.Options.AllowFilterBySummary = DevExpress.Utils.DefaultBoolean.True;
            this.fieldPriceList1.Options.GroupFilterMode = DevExpress.XtraPivotGrid.PivotGroupFilterMode.List;
            this.fieldPriceList1.Width = 40;
            // 
            // fieldPrice1
            // 
            this.fieldPrice1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldPrice1.AreaIndex = 0;
            this.fieldPrice1.Caption = "Τιμή";
            this.fieldPrice1.CellFormat.FormatString = "#.00";
            this.fieldPrice1.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldPrice1.FieldName = "Price";
            this.fieldPrice1.Name = "fieldPrice1";
            // 
            // Ενεργό
            // 
            this.Ενεργό.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.Ενεργό.AreaIndex = 4;
            this.Ενεργό.FieldName = "IsDeleted";
            this.Ενεργό.Name = "Ενεργό";
            // 
            // TopMargin
            // 
            this.TopMargin.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel1});
            this.TopMargin.HeightF = 51F;
            this.TopMargin.Name = "TopMargin";
            this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrLabel1
            // 
            this.xrLabel1.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel1.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold);
            this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 10.00001F);
            this.xrLabel1.Name = "xrLabel1";
            this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel1.SizeF = new System.Drawing.SizeF(1100F, 35.5F);
            this.xrLabel1.StylePriority.UseBorders = false;
            this.xrLabel1.StylePriority.UseFont = false;
            this.xrLabel1.StylePriority.UseTextAlignment = false;
            this.xrLabel1.Text = "Αρχείο Ειδών";
            this.xrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // BottomMargin
            // 
            this.BottomMargin.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLine1,
            this.xrPageInfo1,
            this.xrPageInfo2});
            this.BottomMargin.HeightF = 35F;
            this.BottomMargin.Name = "BottomMargin";
            this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrLine1
            // 
            this.xrLine1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 8.000007F);
            this.xrLine1.Name = "xrLine1";
            this.xrLine1.SizeF = new System.Drawing.SizeF(1100F, 2F);
            // 
            // xrPageInfo1
            // 
            this.xrPageInfo1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 10.00001F);
            this.xrPageInfo1.Name = "xrPageInfo1";
            this.xrPageInfo1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrPageInfo1.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime;
            this.xrPageInfo1.SizeF = new System.Drawing.SizeF(313F, 23F);
            // 
            // xrPageInfo2
            // 
            this.xrPageInfo2.Format = "Page {0} of {1}";
            this.xrPageInfo2.LocationFloat = new DevExpress.Utils.PointFloat(325F, 10.00001F);
            this.xrPageInfo2.Name = "xrPageInfo2";
            this.xrPageInfo2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrPageInfo2.SizeF = new System.Drawing.SizeF(775F, 23F);
            this.xrPageInfo2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // ReportFooter
            // 
            this.ReportFooter.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrPivotGrid1});
            this.ReportFooter.HeightF = 70.83334F;
            this.ReportFooter.Name = "ReportFooter";
            // 
            // IsDeletedPrm
            // 
            this.IsDeletedPrm.Description = "Select Product Types";
            staticListLookUpSettings1.LookUpValues.Add(new DevExpress.XtraReports.Parameters.LookUpValue(((short)(2)), "Deleted"));
            staticListLookUpSettings1.LookUpValues.Add(new DevExpress.XtraReports.Parameters.LookUpValue(((short)(1)), "Active"));
            this.IsDeletedPrm.LookUpSettings = staticListLookUpSettings1;
            this.IsDeletedPrm.MultiValue = true;
            this.IsDeletedPrm.Name = "IsDeletedPrm";
            this.IsDeletedPrm.Type = typeof(short);
            // 
            // ProductFilesPivot
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.ReportFooter});
            this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.sqlDataSource1});
            this.DataMember = "Query";
            this.DataSource = this.sqlDataSource1;
            this.Landscape = true;
            this.Margins = new System.Drawing.Printing.Margins(18, 50, 51, 35);
            this.PageHeight = 827;
            this.PageWidth = 1169;
            this.PaperKind = System.Drawing.Printing.PaperKind.A4;
            this.Parameters.AddRange(new DevExpress.XtraReports.Parameters.Parameter[] {
            this.IsDeletedPrm});
            this.Version = "15.2";
            this.ParametersRequestBeforeShow += new System.EventHandler<DevExpress.XtraReports.Parameters.ParametersRequestEventArgs>(this.ProductFilesPivot_ParametersRequestBeforeShow);
            this.ParametersRequestSubmit += new System.EventHandler<DevExpress.XtraReports.Parameters.ParametersRequestEventArgs>(this.ProductFilesPivot_ParametersRequestSubmit);
            this.DataSourceDemanded += new System.EventHandler<System.EventArgs>(this.ProductFilesPivot_DataSourceDemanded);
            this.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.ProductFilesPivot_BeforePrint);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

    }


    #endregion

    private void ProductFilesPivot_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
    {

    }

    private void ProductFilesPivot_ParametersRequestBeforeShow(object sender, DevExpress.XtraReports.Parameters.ParametersRequestEventArgs e)
    {

    }

    private void ProductFilesPivot_ParametersRequestSubmit(object sender, DevExpress.XtraReports.Parameters.ParametersRequestEventArgs e)
    {

    }

    private void ProductFilesPivot_DataSourceDemanded(object sender, EventArgs e)
    {
        var param = (sender as XtraReport).Parameters;
        if (((short[])param[0].Value).Length > 1 )
        {
            sqlDataSource1.Queries[0].Parameters[0].Value = 3;
        }
        else
        {
            sqlDataSource1.Queries[0].Parameters[0].Value = ((short[])param[0].Value)[0];
        }
        sqlDataSource1.Fill();
    }
}
