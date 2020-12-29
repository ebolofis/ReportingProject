using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Web.Configuration;

/// <summary>
/// Summary description for SalesNetAmount
/// </summary>
public class SalesNetAmount : DevExpress.XtraReports.UI.XtraReport
{
    private DevExpress.XtraReports.UI.DetailBand Detail;
    private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
    private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
    private XRLabel xrLabel48;
    private XRLabel xrLabel49;
    private XRLabel xrLabel50;
    private XRLabel xrLabel51;
    private XRLabel xrLabel52;
    private XRLabel xrLabel54;
    private XRLabel xrLabel55;
    private XRLabel xrLabel56;
    private XRLabel xrLabel57;
    private XRLabel xrLabel58;
    private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
    private GroupHeaderBand groupHeaderBand1;
    private GroupFooterBand groupFooterBand1;
    private XRLabel xrLabel16;
    private XRLabel xrLabel17;
    private XRLabel xrLabel18;
    private XRLabel xrLabel19;
    private XRLabel xrLabel20;
    private XRLabel xrLabel21;
    private XRLabel xrLabel22;
    private XRLabel xrLabel23;
    private XRLabel xrLabel24;
    private XRLabel xrLabel25;
    private GroupHeaderBand groupHeaderBand2;
    private XRLabel xrLabel26;
    private GroupFooterBand groupFooterBand2;
    private XRLabel xrLabel27;
    private XRLabel xrLabel28;
    private XRLabel xrLabel29;
    private XRLabel xrLabel30;
    private XRLabel xrLabel31;
    private XRLabel xrLabel32;
    private XRLabel xrLabel33;
    private XRLabel xrLabel34;
    private XRLabel xrLabel35;
    private XRLabel xrLabel36;
    private GroupHeaderBand groupHeaderBand3;
    private XRLabel xrLabel37;
    private GroupFooterBand groupFooterBand3;
    private XRLabel xrLabel38;
    private XRLabel xrLabel39;
    private XRLabel xrLabel40;
    private XRLabel xrLabel41;
    private XRLabel xrLabel42;
    private XRLabel xrLabel43;
    private XRLabel xrLabel44;
    private XRLabel xrLabel45;
    private XRLabel xrLabel46;
    private PageFooterBand pageFooterBand1;
    private XRPageInfo xrPageInfo2;
    private ReportHeaderBand reportHeaderBand1;
    private XRLabel xrLabel59;
    private XRLine xrLine3;
    private ReportFooterBand reportFooterBand1;
    private XRLabel xrLabel60;
    private XRLabel xrLabel61;
    private XRLabel xrLabel62;
    private XRLabel xrLabel63;
    private XRLabel xrLabel64;
    private XRLabel xrLabel65;
    private XRLabel xrLabel66;
    private XRLabel xrLabel67;
    private XRLabel xrLabel68;
    private XRLabel xrLabel69;
    private XRControlStyle Title;
    private XRControlStyle FieldCaption;
    private XRControlStyle PageInfo;
    private XRControlStyle DataField;
    private DevExpress.XtraReports.Parameters.Parameter FromDate;
    private DevExpress.XtraReports.Parameters.Parameter ToDate;
    private XRPageInfo xrPageInfo3;
    private XRLabel xrLabel53;
    private XRLabel xrLabel15;
    private XRPivotGrid xrPivotGrid1;
    private DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField fieldCategory1;
    private DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField fieldPrice1;
    private DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField fieldRetQty1;
    private DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField fieldRetTotal1;
    private DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField fieldRetNet1;
    private DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField fieldCoplQty1;
    private DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField fieldCoplTotal1;
    private DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField fieldCoplNet1;
    private DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField fieldQty1;
    private DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField fieldTotal1;
    private DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField fieldNet1;
    private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource2;
    private XRLabel xrLabel47;
    private XRLabel xrLabel74;
    private XRLabel xrLabel75;
    private XRLabel xrLabel76;
    private XRLabel xrLabel77;
    private XRLabel xrLabel78;
    private XRLabel xrLabel71;
    private XRLabel xrLabel72;
    private XRLabel xrLabel73;
    private XRLabel xrLabel80;
    private XRLabel xrLabel79;
    private DevExpress.XtraReports.Parameters.Parameter DepartmentId;
    private XRLabel xrLabel81;
    private XRLine xrLine4;
    private XRLine xrLine2;
    private XRLine xrLine1;
    private XRLabel xrLabel3;
    private XRLabel xrLabel1;
    private XRLabel xrLabel2;
    private XRLabel xrLabel4;
    private XRLabel xrLabel5;
    private XRLabel xrLabel9;
    private XRLabel xrLabel8;
    private XRLabel xrLabel7;
    private XRLabel xrLabel6;
    private XRLabel xrLabel13;
    private XRLabel xrLabel12;
    private XRLabel xrLabel11;
    private XRLabel xrLabel10;
    private XRLabel xrLabel14;
    private XRLabel xrLabel70;
    private PageHeaderBand pageHeaderBand1;
    private SubBand SubBand1;
    private XRLabel xrLabel85;
    private XRLabel xrLabel84;
    private XRLabel xrLabel83;
    private XRLabel xrLabel82;
    private XRSubreport xrSubreport1;

    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    public SalesNetAmount()
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalesNetAmount));
            DevExpress.DataAccess.Sql.CustomSqlQuery customSqlQuery2 = new DevExpress.DataAccess.Sql.CustomSqlQuery();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter3 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter4 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter5 = new DevExpress.DataAccess.Sql.QueryParameter();
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
            DevExpress.XtraReports.UI.XRSummary xrSummary22 = new DevExpress.XtraReports.UI.XRSummary();
            DevExpress.XtraReports.UI.XRSummary xrSummary23 = new DevExpress.XtraReports.UI.XRSummary();
            DevExpress.XtraReports.UI.XRSummary xrSummary24 = new DevExpress.XtraReports.UI.XRSummary();
            DevExpress.XtraReports.UI.XRSummary xrSummary25 = new DevExpress.XtraReports.UI.XRSummary();
            DevExpress.XtraReports.UI.XRSummary xrSummary26 = new DevExpress.XtraReports.UI.XRSummary();
            DevExpress.XtraReports.UI.XRSummary xrSummary27 = new DevExpress.XtraReports.UI.XRSummary();
            DevExpress.XtraReports.UI.XRSummary xrSummary28 = new DevExpress.XtraReports.UI.XRSummary();
            DevExpress.XtraReports.UI.XRSummary xrSummary29 = new DevExpress.XtraReports.UI.XRSummary();
            DevExpress.XtraReports.UI.XRSummary xrSummary30 = new DevExpress.XtraReports.UI.XRSummary();
            DevExpress.XtraReports.UI.XRSummary xrSummary31 = new DevExpress.XtraReports.UI.XRSummary();
            DevExpress.XtraReports.UI.XRSummary xrSummary32 = new DevExpress.XtraReports.UI.XRSummary();
            DevExpress.XtraReports.UI.XRSummary xrSummary33 = new DevExpress.XtraReports.UI.XRSummary();
            DevExpress.XtraReports.UI.XRSummary xrSummary34 = new DevExpress.XtraReports.UI.XRSummary();
            DevExpress.XtraReports.UI.XRSummary xrSummary35 = new DevExpress.XtraReports.UI.XRSummary();
            DevExpress.XtraReports.UI.XRSummary xrSummary36 = new DevExpress.XtraReports.UI.XRSummary();
            DevExpress.XtraReports.UI.XRSummary xrSummary37 = new DevExpress.XtraReports.UI.XRSummary();
            DevExpress.XtraReports.UI.XRSummary xrSummary38 = new DevExpress.XtraReports.UI.XRSummary();
            DevExpress.XtraReports.UI.XRSummary xrSummary39 = new DevExpress.XtraReports.UI.XRSummary();
            DevExpress.DataAccess.Sql.CustomSqlQuery customSqlQuery3 = new DevExpress.DataAccess.Sql.CustomSqlQuery();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter6 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter7 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.CustomSqlQuery customSqlQuery4 = new DevExpress.DataAccess.Sql.CustomSqlQuery();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter8 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter9 = new DevExpress.DataAccess.Sql.QueryParameter();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.xrLabel48 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel49 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel50 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel51 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel52 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel54 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel55 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel56 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel57 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel58 = new DevExpress.XtraReports.UI.XRLabel();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.xrPageInfo3 = new DevExpress.XtraReports.UI.XRPageInfo();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.xrPivotGrid1 = new DevExpress.XtraReports.UI.XRPivotGrid();
            this.fieldCategory1 = new DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField();
            this.fieldPrice1 = new DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField();
            this.fieldRetQty1 = new DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField();
            this.fieldRetTotal1 = new DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField();
            this.fieldRetNet1 = new DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField();
            this.fieldCoplQty1 = new DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField();
            this.fieldCoplTotal1 = new DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField();
            this.fieldCoplNet1 = new DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField();
            this.fieldQty1 = new DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField();
            this.fieldTotal1 = new DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField();
            this.fieldNet1 = new DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField();
            this.groupHeaderBand1 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.xrLabel53 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel15 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel81 = new DevExpress.XtraReports.UI.XRLabel();
            this.SubBand1 = new DevExpress.XtraReports.UI.SubBand();
            this.xrLabel85 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel84 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel83 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel82 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrSubreport1 = new DevExpress.XtraReports.UI.XRSubreport();
            this.groupFooterBand1 = new DevExpress.XtraReports.UI.GroupFooterBand();
            this.xrLabel16 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel17 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel18 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel19 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel20 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel21 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel22 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel23 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel24 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel25 = new DevExpress.XtraReports.UI.XRLabel();
            this.groupHeaderBand2 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.xrLabel47 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel74 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel75 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel76 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel77 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel78 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel71 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel72 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel73 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel26 = new DevExpress.XtraReports.UI.XRLabel();
            this.groupFooterBand2 = new DevExpress.XtraReports.UI.GroupFooterBand();
            this.xrLabel27 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel28 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel29 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel30 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel31 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel32 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel33 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel34 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel35 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel36 = new DevExpress.XtraReports.UI.XRLabel();
            this.groupHeaderBand3 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.xrLabel37 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel38 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel45 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel44 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel43 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel42 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel41 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel40 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel39 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel46 = new DevExpress.XtraReports.UI.XRLabel();
            this.groupFooterBand3 = new DevExpress.XtraReports.UI.GroupFooterBand();
            this.xrLabel80 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel79 = new DevExpress.XtraReports.UI.XRLabel();
            this.pageFooterBand1 = new DevExpress.XtraReports.UI.PageFooterBand();
            this.xrPageInfo2 = new DevExpress.XtraReports.UI.XRPageInfo();
            this.reportHeaderBand1 = new DevExpress.XtraReports.UI.ReportHeaderBand();
            this.xrLabel59 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLine3 = new DevExpress.XtraReports.UI.XRLine();
            this.reportFooterBand1 = new DevExpress.XtraReports.UI.ReportFooterBand();
            this.xrLabel60 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel61 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel62 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel63 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel64 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel65 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel66 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel67 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel68 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel69 = new DevExpress.XtraReports.UI.XRLabel();
            this.Title = new DevExpress.XtraReports.UI.XRControlStyle();
            this.FieldCaption = new DevExpress.XtraReports.UI.XRControlStyle();
            this.PageInfo = new DevExpress.XtraReports.UI.XRControlStyle();
            this.DataField = new DevExpress.XtraReports.UI.XRControlStyle();
            this.FromDate = new DevExpress.XtraReports.Parameters.Parameter();
            this.ToDate = new DevExpress.XtraReports.Parameters.Parameter();
            this.sqlDataSource2 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.DepartmentId = new DevExpress.XtraReports.Parameters.Parameter();
            this.xrLine4 = new DevExpress.XtraReports.UI.XRLine();
            this.xrLine2 = new DevExpress.XtraReports.UI.XRLine();
            this.xrLine1 = new DevExpress.XtraReports.UI.XRLine();
            this.xrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel4 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel5 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel9 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel8 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel7 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel6 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel13 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel12 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel11 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel10 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel14 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel70 = new DevExpress.XtraReports.UI.XRLabel();
            this.pageHeaderBand1 = new DevExpress.XtraReports.UI.PageHeaderBand();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel48,
            this.xrLabel49,
            this.xrLabel50,
            this.xrLabel51,
            this.xrLabel52,
            this.xrLabel54,
            this.xrLabel55,
            this.xrLabel56,
            this.xrLabel57,
            this.xrLabel58});
            this.Detail.HeightF = 20.66666F;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.StyleName = "DataField";
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.Detail.Visible = false;
            // 
            // xrLabel48
            // 
            this.xrLabel48.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.CoplQTY", "{0:#.00}")});
            this.xrLabel48.Font = new System.Drawing.Font("Times New Roman", 8F);
            this.xrLabel48.LocationFloat = new DevExpress.Utils.PointFloat(453.4154F, 0F);
            this.xrLabel48.Name = "xrLabel48";
            this.xrLabel48.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel48.SizeF = new System.Drawing.SizeF(51.90768F, 18F);
            this.xrLabel48.StylePriority.UseFont = false;
            this.xrLabel48.StylePriority.UseTextAlignment = false;
            this.xrLabel48.Text = "xrLabel48";
            this.xrLabel48.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // xrLabel49
            // 
            this.xrLabel49.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.CoplTotal", "{0:#.00}")});
            this.xrLabel49.Font = new System.Drawing.Font("Times New Roman", 8F);
            this.xrLabel49.LocationFloat = new DevExpress.Utils.PointFloat(519.9141F, 0F);
            this.xrLabel49.Name = "xrLabel49";
            this.xrLabel49.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel49.SizeF = new System.Drawing.SizeF(52.8334F, 18F);
            this.xrLabel49.StylePriority.UseFont = false;
            this.xrLabel49.StylePriority.UseTextAlignment = false;
            this.xrLabel49.Text = "xrLabel49";
            this.xrLabel49.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // xrLabel50
            // 
            this.xrLabel50.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.CorplNet", "{0:#.00}")});
            this.xrLabel50.Font = new System.Drawing.Font("Times New Roman", 8F);
            this.xrLabel50.LocationFloat = new DevExpress.Utils.PointFloat(592.5205F, 0F);
            this.xrLabel50.Name = "xrLabel50";
            this.xrLabel50.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel50.SizeF = new System.Drawing.SizeF(52.8334F, 18F);
            this.xrLabel50.StylePriority.UseFont = false;
            this.xrLabel50.StylePriority.UseTextAlignment = false;
            this.xrLabel50.Text = "xrLabel50";
            this.xrLabel50.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // xrLabel51
            // 
            this.xrLabel51.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.Net", "{0:#.00}")});
            this.xrLabel51.Font = new System.Drawing.Font("Times New Roman", 8F);
            this.xrLabel51.LocationFloat = new DevExpress.Utils.PointFloat(368.2718F, 0F);
            this.xrLabel51.Name = "xrLabel51";
            this.xrLabel51.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel51.SizeF = new System.Drawing.SizeF(52.8334F, 18F);
            this.xrLabel51.StylePriority.UseFont = false;
            this.xrLabel51.StylePriority.UseTextAlignment = false;
            this.xrLabel51.Text = "xrLabel51";
            this.xrLabel51.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // xrLabel52
            // 
            this.xrLabel52.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.Price", "{0:#.00}")});
            this.xrLabel52.Font = new System.Drawing.Font("Times New Roman", 8F);
            this.xrLabel52.LocationFloat = new DevExpress.Utils.PointFloat(114.3955F, 0.9999911F);
            this.xrLabel52.Name = "xrLabel52";
            this.xrLabel52.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel52.SizeF = new System.Drawing.SizeF(69.50003F, 18F);
            this.xrLabel52.StylePriority.UseFont = false;
            this.xrLabel52.StylePriority.UseTextAlignment = false;
            this.xrLabel52.Text = "xrLabel52";
            this.xrLabel52.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // xrLabel54
            // 
            this.xrLabel54.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.QTY", "{0:#,##0.00}")});
            this.xrLabel54.Font = new System.Drawing.Font("Times New Roman", 8F);
            this.xrLabel54.LocationFloat = new DevExpress.Utils.PointFloat(229.1667F, 0F);
            this.xrLabel54.Name = "xrLabel54";
            this.xrLabel54.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel54.SizeF = new System.Drawing.SizeF(51.90768F, 18F);
            this.xrLabel54.StylePriority.UseFont = false;
            this.xrLabel54.StylePriority.UseTextAlignment = false;
            this.xrLabel54.Text = "xrLabel54";
            this.xrLabel54.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // xrLabel55
            // 
            this.xrLabel55.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.RetNet", "{0:#.00}")});
            this.xrLabel55.Font = new System.Drawing.Font("Times New Roman", 8F);
            this.xrLabel55.LocationFloat = new DevExpress.Utils.PointFloat(822.2051F, 0F);
            this.xrLabel55.Name = "xrLabel55";
            this.xrLabel55.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel55.SizeF = new System.Drawing.SizeF(51.90768F, 18F);
            this.xrLabel55.StylePriority.UseFont = false;
            this.xrLabel55.StylePriority.UseTextAlignment = false;
            this.xrLabel55.Text = "xrLabel55";
            this.xrLabel55.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // xrLabel56
            // 
            this.xrLabel56.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.RetQTY", "{0:#.00}")});
            this.xrLabel56.Font = new System.Drawing.Font("Times New Roman", 8F);
            this.xrLabel56.LocationFloat = new DevExpress.Utils.PointFloat(683.1F, 0F);
            this.xrLabel56.Name = "xrLabel56";
            this.xrLabel56.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel56.SizeF = new System.Drawing.SizeF(52.8334F, 18F);
            this.xrLabel56.StylePriority.UseFont = false;
            this.xrLabel56.StylePriority.UseTextAlignment = false;
            this.xrLabel56.Text = "xrLabel56";
            this.xrLabel56.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // xrLabel57
            // 
            this.xrLabel57.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.RetTotal", "{0:#.00}")});
            this.xrLabel57.Font = new System.Drawing.Font("Times New Roman", 8F);
            this.xrLabel57.LocationFloat = new DevExpress.Utils.PointFloat(749.5987F, 0F);
            this.xrLabel57.Name = "xrLabel57";
            this.xrLabel57.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel57.SizeF = new System.Drawing.SizeF(52.8334F, 18F);
            this.xrLabel57.StylePriority.UseFont = false;
            this.xrLabel57.StylePriority.UseTextAlignment = false;
            this.xrLabel57.Text = "xrLabel57";
            this.xrLabel57.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // xrLabel58
            // 
            this.xrLabel58.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.Total", "{0:#,##0.00}€")});
            this.xrLabel58.Font = new System.Drawing.Font("Times New Roman", 8F);
            this.xrLabel58.LocationFloat = new DevExpress.Utils.PointFloat(295.6653F, 0F);
            this.xrLabel58.Name = "xrLabel58";
            this.xrLabel58.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel58.SizeF = new System.Drawing.SizeF(52.8334F, 18F);
            this.xrLabel58.StylePriority.UseFont = false;
            this.xrLabel58.StylePriority.UseTextAlignment = false;
            this.xrLabel58.Text = "xrLabel58";
            this.xrLabel58.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // TopMargin
            // 
            this.TopMargin.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrPageInfo3});
            this.TopMargin.HeightF = 100F;
            this.TopMargin.Name = "TopMargin";
            this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrPageInfo3
            // 
            this.xrPageInfo3.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrPageInfo3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.xrPageInfo3.Format = "Ημερομηνία Εκτύπωσης : {0:dddd, d MMMM yyyy h:mm:ss tt}";
            this.xrPageInfo3.LocationFloat = new DevExpress.Utils.PointFloat(0F, 81.23729F);
            this.xrPageInfo3.Name = "xrPageInfo3";
            this.xrPageInfo3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrPageInfo3.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime;
            this.xrPageInfo3.SizeF = new System.Drawing.SizeF(900F, 18.76271F);
            this.xrPageInfo3.StylePriority.UseBorders = false;
            this.xrPageInfo3.StylePriority.UseFont = false;
            // 
            // BottomMargin
            // 
            this.BottomMargin.HeightF = 100F;
            this.BottomMargin.Name = "BottomMargin";
            this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
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
            customSqlQuery2.Name = "SunRepQuery";
            queryParameter3.Name = "FromDate";
            queryParameter3.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter3.Value = new DevExpress.DataAccess.Expression("[Parameters.FromDate]", typeof(System.DateTime));
            queryParameter4.Name = "ToDate";
            queryParameter4.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter4.Value = new DevExpress.DataAccess.Expression("[Parameters.ToDate]", typeof(System.DateTime));
            queryParameter5.Name = "DepartmentId";
            queryParameter5.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter5.Value = new DevExpress.DataAccess.Expression("[Parameters.DepartmentId]", typeof(long));
            customSqlQuery2.Parameters.Add(queryParameter3);
            customSqlQuery2.Parameters.Add(queryParameter4);
            customSqlQuery2.Parameters.Add(queryParameter5);
            customSqlQuery2.Sql = resources.GetString("customSqlQuery2.Sql");
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            customSqlQuery1,
            customSqlQuery2});
            this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
            // 
            // xrPivotGrid1
            // 
            this.xrPivotGrid1.DataMember = "SunRepQuery";
            this.xrPivotGrid1.Fields.AddRange(new DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField[] {
            this.fieldCategory1,
            this.fieldPrice1,
            this.fieldRetQty1,
            this.fieldRetTotal1,
            this.fieldRetNet1,
            this.fieldCoplQty1,
            this.fieldCoplTotal1,
            this.fieldCoplNet1,
            this.fieldQty1,
            this.fieldTotal1,
            this.fieldNet1});
            this.xrPivotGrid1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrPivotGrid1.Name = "xrPivotGrid1";
            this.xrPivotGrid1.OptionsPrint.FilterSeparatorBarPadding = 3;
            this.xrPivotGrid1.OptionsPrint.PrintFilterHeaders = DevExpress.Utils.DefaultBoolean.False;
            this.xrPivotGrid1.OptionsView.ShowColumnGrandTotalHeader = false;
            this.xrPivotGrid1.OptionsView.ShowColumnGrandTotals = false;
            this.xrPivotGrid1.OptionsView.ShowFilterHeaders = false;
            this.xrPivotGrid1.OptionsView.ShowFilterSeparatorBar = false;
            this.xrPivotGrid1.Prefilter.Enabled = false;
            this.xrPivotGrid1.SizeF = new System.Drawing.SizeF(894F, 50F);
            // 
            // fieldCategory1
            // 
            this.fieldCategory1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldCategory1.AreaIndex = 0;
            this.fieldCategory1.Caption = "Κατηγορία";
            this.fieldCategory1.FieldName = "Category";
            this.fieldCategory1.Name = "fieldCategory1";
            this.fieldCategory1.Width = 202;
            // 
            // fieldPrice1
            // 
            this.fieldPrice1.AreaIndex = 0;
            this.fieldPrice1.FieldName = "Price";
            this.fieldPrice1.Name = "fieldPrice1";
            this.fieldPrice1.Visible = false;
            // 
            // fieldRetQty1
            // 
            this.fieldRetQty1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldRetQty1.AreaIndex = 6;
            this.fieldRetQty1.Caption = "Επισ.Ποσ.";
            this.fieldRetQty1.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldRetQty1.FieldName = "RetQty";
            this.fieldRetQty1.Name = "fieldRetQty1";
            this.fieldRetQty1.Width = 68;
            // 
            // fieldRetTotal1
            // 
            this.fieldRetTotal1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldRetTotal1.AreaIndex = 7;
            this.fieldRetTotal1.Caption = "Επισ.Αξία";
            this.fieldRetTotal1.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldRetTotal1.FieldName = "RetTotal";
            this.fieldRetTotal1.Name = "fieldRetTotal1";
            this.fieldRetTotal1.Width = 78;
            // 
            // fieldRetNet1
            // 
            this.fieldRetNet1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldRetNet1.AreaIndex = 8;
            this.fieldRetNet1.Caption = "Επίσ.Καθ.Αξία";
            this.fieldRetNet1.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldRetNet1.FieldName = "RetNet";
            this.fieldRetNet1.Name = "fieldRetNet1";
            this.fieldRetNet1.Width = 77;
            // 
            // fieldCoplQty1
            // 
            this.fieldCoplQty1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldCoplQty1.AreaIndex = 3;
            this.fieldCoplQty1.Caption = "Φιλ.Ποσ.";
            this.fieldCoplQty1.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldCoplQty1.FieldName = "CoplQty";
            this.fieldCoplQty1.Name = "fieldCoplQty1";
            this.fieldCoplQty1.Width = 60;
            // 
            // fieldCoplTotal1
            // 
            this.fieldCoplTotal1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldCoplTotal1.AreaIndex = 4;
            this.fieldCoplTotal1.Caption = "Φιλ.Αξία";
            this.fieldCoplTotal1.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldCoplTotal1.FieldName = "CoplTotal";
            this.fieldCoplTotal1.Name = "fieldCoplTotal1";
            this.fieldCoplTotal1.Width = 72;
            // 
            // fieldCoplNet1
            // 
            this.fieldCoplNet1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldCoplNet1.AreaIndex = 5;
            this.fieldCoplNet1.Caption = "Φιλ.Καθ.Αξία";
            this.fieldCoplNet1.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldCoplNet1.FieldName = "CoplNet";
            this.fieldCoplNet1.Name = "fieldCoplNet1";
            this.fieldCoplNet1.Width = 82;
            // 
            // fieldQty1
            // 
            this.fieldQty1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldQty1.AreaIndex = 0;
            this.fieldQty1.Caption = "Ποσότητα";
            this.fieldQty1.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldQty1.FieldName = "Qty";
            this.fieldQty1.Name = "fieldQty1";
            this.fieldQty1.Width = 68;
            // 
            // fieldTotal1
            // 
            this.fieldTotal1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldTotal1.AreaIndex = 1;
            this.fieldTotal1.Caption = "Αξία";
            this.fieldTotal1.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldTotal1.FieldName = "Total";
            this.fieldTotal1.Name = "fieldTotal1";
            this.fieldTotal1.Width = 68;
            // 
            // fieldNet1
            // 
            this.fieldNet1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldNet1.AreaIndex = 2;
            this.fieldNet1.Caption = "Καθαρή Αξία";
            this.fieldNet1.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldNet1.FieldName = "Net";
            this.fieldNet1.Name = "fieldNet1";
            this.fieldNet1.Width = 82;
            // 
            // groupHeaderBand1
            // 
            this.groupHeaderBand1.BackColor = System.Drawing.Color.Red;
            this.groupHeaderBand1.BorderColor = System.Drawing.Color.Black;
            this.groupHeaderBand1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel53,
            this.xrLabel15,
            this.xrPivotGrid1,
            this.xrLabel81});
            this.groupHeaderBand1.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("DepartmentId", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.groupHeaderBand1.HeightF = 82.29166F;
            this.groupHeaderBand1.Level = 2;
            this.groupHeaderBand1.Name = "groupHeaderBand1";
            this.groupHeaderBand1.StyleName = "DataField";
            this.groupHeaderBand1.StylePriority.UseBackColor = false;
            this.groupHeaderBand1.StylePriority.UseBorderColor = false;
            this.groupHeaderBand1.SubBands.AddRange(new DevExpress.XtraReports.UI.SubBand[] {
            this.SubBand1});
            this.groupHeaderBand1.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.groupHeaderBand1_BeforePrint);
            // 
            // xrLabel53
            // 
            this.xrLabel53.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel53.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.Department")});
            this.xrLabel53.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.xrLabel53.LocationFloat = new DevExpress.Utils.PointFloat(136.4583F, 50F);
            this.xrLabel53.Name = "xrLabel53";
            this.xrLabel53.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel53.SizeF = new System.Drawing.SizeF(757.5417F, 23F);
            this.xrLabel53.StylePriority.UseBorders = false;
            this.xrLabel53.StylePriority.UseFont = false;
            this.xrLabel53.Text = "xrLabel53";
            // 
            // xrLabel15
            // 
            this.xrLabel15.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel15.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.xrLabel15.LocationFloat = new DevExpress.Utils.PointFloat(0F, 50F);
            this.xrLabel15.Name = "xrLabel15";
            this.xrLabel15.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel15.SizeF = new System.Drawing.SizeF(136.4583F, 23F);
            this.xrLabel15.StylePriority.UseBorders = false;
            this.xrLabel15.StylePriority.UseFont = false;
            this.xrLabel15.Text = "Σύνολα Τμήματος";
            // 
            // xrLabel81
            // 
            this.xrLabel81.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.DepartmentId")});
            this.xrLabel81.LocationFloat = new DevExpress.Utils.PointFloat(0F, 10.00001F);
            this.xrLabel81.Name = "xrLabel81";
            this.xrLabel81.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel81.SizeF = new System.Drawing.SizeF(100F, 23F);
            this.xrLabel81.Text = "xrLabel81";
            this.xrLabel81.Visible = false;
            this.xrLabel81.TextChanged += new System.EventHandler(this.xrLabel81_TextChanged);
            // 
            // SubBand1
            // 
            this.SubBand1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel85,
            this.xrLabel84,
            this.xrLabel83,
            this.xrLabel82,
            this.xrSubreport1});
            this.SubBand1.HeightF = 100F;
            this.SubBand1.Name = "SubBand1";
            // 
            // xrLabel85
            // 
            this.xrLabel85.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SunRepQuery.DepartmentId")});
            this.xrLabel85.LocationFloat = new DevExpress.Utils.PointFloat(505.3232F, 21.83332F);
            this.xrLabel85.Name = "xrLabel85";
            this.xrLabel85.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrLabel85.SizeF = new System.Drawing.SizeF(100F, 23F);
            this.xrLabel85.Text = "xrLabel85";
            // 
            // xrLabel84
            // 
            this.xrLabel84.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SunRepQuery.Qty")});
            this.xrLabel84.LocationFloat = new DevExpress.Utils.PointFloat(391.9385F, 21.83332F);
            this.xrLabel84.Name = "xrLabel84";
            this.xrLabel84.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrLabel84.SizeF = new System.Drawing.SizeF(100F, 23F);
            this.xrLabel84.Text = "xrLabel84";
            // 
            // xrLabel83
            // 
            this.xrLabel83.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SunRepQuery.Net")});
            this.xrLabel83.LocationFloat = new DevExpress.Utils.PointFloat(281.0744F, 21.83332F);
            this.xrLabel83.Name = "xrLabel83";
            this.xrLabel83.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrLabel83.SizeF = new System.Drawing.SizeF(100F, 23F);
            this.xrLabel83.Text = "xrLabel83";
            // 
            // xrLabel82
            // 
            this.xrLabel82.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SunRepQuery.Category")});
            this.xrLabel82.LocationFloat = new DevExpress.Utils.PointFloat(169.7917F, 21.83332F);
            this.xrLabel82.Name = "xrLabel82";
            this.xrLabel82.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrLabel82.SizeF = new System.Drawing.SizeF(100F, 23F);
            this.xrLabel82.Text = "xrLabel82";
            // 
            // xrSubreport1
            // 
            this.xrSubreport1.LocationFloat = new DevExpress.Utils.PointFloat(5.999994F, 0F);
            this.xrSubreport1.Name = "xrSubreport1";
            this.xrSubreport1.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("DepartmentId", null, "SunRepQuery.DepartmentId"));
            this.xrSubreport1.SizeF = new System.Drawing.SizeF(885.0001F, 90F);
            // 
            // groupFooterBand1
            // 
            this.groupFooterBand1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel16,
            this.xrLabel17,
            this.xrLabel18,
            this.xrLabel19,
            this.xrLabel20,
            this.xrLabel21,
            this.xrLabel22,
            this.xrLabel23,
            this.xrLabel24,
            this.xrLabel25});
            this.groupFooterBand1.HeightF = 30F;
            this.groupFooterBand1.Level = 2;
            this.groupFooterBand1.Name = "groupFooterBand1";
            this.groupFooterBand1.Visible = false;
            // 
            // xrLabel16
            // 
            this.xrLabel16.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.CoplQTY")});
            this.xrLabel16.LocationFloat = new DevExpress.Utils.PointFloat(333.8769F, 6F);
            this.xrLabel16.Name = "xrLabel16";
            this.xrLabel16.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel16.SizeF = new System.Drawing.SizeF(58.06154F, 18F);
            this.xrLabel16.StyleName = "FieldCaption";
            xrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
            this.xrLabel16.Summary = xrSummary1;
            this.xrLabel16.Text = "xrLabel16";
            // 
            // xrLabel17
            // 
            this.xrLabel17.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.CoplTotal", "{0:C2}")});
            this.xrLabel17.LocationFloat = new DevExpress.Utils.PointFloat(391.9385F, 6F);
            this.xrLabel17.Name = "xrLabel17";
            this.xrLabel17.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel17.SizeF = new System.Drawing.SizeF(61.47692F, 18F);
            this.xrLabel17.StyleName = "FieldCaption";
            xrSummary2.FormatString = "{0:C2}";
            xrSummary2.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
            this.xrLabel17.Summary = xrSummary2;
            this.xrLabel17.Text = "xrLabel17";
            // 
            // xrLabel18
            // 
            this.xrLabel18.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.CorplNet", "{0:C2}")});
            this.xrLabel18.LocationFloat = new DevExpress.Utils.PointFloat(453.4154F, 6F);
            this.xrLabel18.Name = "xrLabel18";
            this.xrLabel18.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel18.SizeF = new System.Drawing.SizeF(57.20769F, 18F);
            this.xrLabel18.StyleName = "FieldCaption";
            xrSummary3.FormatString = "{0:C2}";
            xrSummary3.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
            this.xrLabel18.Summary = xrSummary3;
            this.xrLabel18.Text = "xrLabel18";
            // 
            // xrLabel19
            // 
            this.xrLabel19.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.Net", "{0:C2}")});
            this.xrLabel19.LocationFloat = new DevExpress.Utils.PointFloat(510.6231F, 6F);
            this.xrLabel19.Name = "xrLabel19";
            this.xrLabel19.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel19.SizeF = new System.Drawing.SizeF(23.05385F, 18F);
            this.xrLabel19.StyleName = "FieldCaption";
            xrSummary4.FormatString = "{0:C2}";
            xrSummary4.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
            this.xrLabel19.Summary = xrSummary4;
            this.xrLabel19.Text = "xrLabel19";
            // 
            // xrLabel20
            // 
            this.xrLabel20.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.QTY")});
            this.xrLabel20.LocationFloat = new DevExpress.Utils.PointFloat(683.1F, 6F);
            this.xrLabel20.Name = "xrLabel20";
            this.xrLabel20.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel20.SizeF = new System.Drawing.SizeF(28.17692F, 18F);
            this.xrLabel20.StyleName = "FieldCaption";
            xrSummary5.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
            this.xrLabel20.Summary = xrSummary5;
            this.xrLabel20.Text = "xrLabel20";
            // 
            // xrLabel21
            // 
            this.xrLabel21.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.RetNet", "{0:C2}")});
            this.xrLabel21.LocationFloat = new DevExpress.Utils.PointFloat(711.277F, 6F);
            this.xrLabel21.Name = "xrLabel21";
            this.xrLabel21.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel21.SizeF = new System.Drawing.SizeF(45.25385F, 18F);
            this.xrLabel21.StyleName = "FieldCaption";
            xrSummary6.FormatString = "{0:C2}";
            xrSummary6.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
            this.xrLabel21.Summary = xrSummary6;
            this.xrLabel21.Text = "xrLabel21";
            // 
            // xrLabel22
            // 
            this.xrLabel22.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.RetQTY")});
            this.xrLabel22.LocationFloat = new DevExpress.Utils.PointFloat(756.5308F, 6F);
            this.xrLabel22.Name = "xrLabel22";
            this.xrLabel22.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel22.SizeF = new System.Drawing.SizeF(50.37692F, 18F);
            this.xrLabel22.StyleName = "FieldCaption";
            xrSummary7.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
            this.xrLabel22.Summary = xrSummary7;
            this.xrLabel22.Text = "xrLabel22";
            // 
            // xrLabel23
            // 
            this.xrLabel23.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.RetTotal", "{0:C2}")});
            this.xrLabel23.LocationFloat = new DevExpress.Utils.PointFloat(806.9077F, 6F);
            this.xrLabel23.Name = "xrLabel23";
            this.xrLabel23.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel23.SizeF = new System.Drawing.SizeF(54.64615F, 18F);
            this.xrLabel23.StyleName = "FieldCaption";
            xrSummary8.FormatString = "{0:C2}";
            xrSummary8.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
            this.xrLabel23.Summary = xrSummary8;
            this.xrLabel23.Text = "xrLabel23";
            // 
            // xrLabel24
            // 
            this.xrLabel24.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.Total", "{0:C2}")});
            this.xrLabel24.LocationFloat = new DevExpress.Utils.PointFloat(861.5539F, 6F);
            this.xrLabel24.Name = "xrLabel24";
            this.xrLabel24.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel24.SizeF = new System.Drawing.SizeF(32.44611F, 18F);
            this.xrLabel24.StyleName = "FieldCaption";
            xrSummary9.FormatString = "{0:C2}";
            xrSummary9.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
            this.xrLabel24.Summary = xrSummary9;
            this.xrLabel24.Text = "xrLabel24";
            // 
            // xrLabel25
            // 
            this.xrLabel25.LocationFloat = new DevExpress.Utils.PointFloat(6F, 6F);
            this.xrLabel25.Name = "xrLabel25";
            this.xrLabel25.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel25.SizeF = new System.Drawing.SizeF(327.8769F, 18F);
            this.xrLabel25.StyleName = "FieldCaption";
            this.xrLabel25.Text = "Sum";
            // 
            // groupHeaderBand2
            // 
            this.groupHeaderBand2.BackColor = System.Drawing.Color.Lime;
            this.groupHeaderBand2.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel47,
            this.xrLabel74,
            this.xrLabel75,
            this.xrLabel76,
            this.xrLabel77,
            this.xrLabel78,
            this.xrLabel71,
            this.xrLabel72,
            this.xrLabel73,
            this.xrLabel26});
            this.groupHeaderBand2.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("ProductCategoryDescrtiption", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.groupHeaderBand2.HeightF = 25.5F;
            this.groupHeaderBand2.Level = 1;
            this.groupHeaderBand2.Name = "groupHeaderBand2";
            this.groupHeaderBand2.StyleName = "DataField";
            this.groupHeaderBand2.StylePriority.UseBackColor = false;
            // 
            // xrLabel47
            // 
            this.xrLabel47.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.CoplQTY", "{0:#,##0.00}")});
            this.xrLabel47.Font = new System.Drawing.Font("Times New Roman", 8F);
            this.xrLabel47.LocationFloat = new DevExpress.Utils.PointFloat(421.1052F, 0F);
            this.xrLabel47.Name = "xrLabel47";
            this.xrLabel47.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel47.SizeF = new System.Drawing.SizeF(84.21799F, 23F);
            this.xrLabel47.StylePriority.UseFont = false;
            this.xrLabel47.StylePriority.UseTextAlignment = false;
            this.xrLabel47.Text = "xrLabel48";
            this.xrLabel47.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // xrLabel74
            // 
            this.xrLabel74.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.CoplTotal", "{0:#,##0.00}")});
            this.xrLabel74.Font = new System.Drawing.Font("Times New Roman", 8F);
            this.xrLabel74.LocationFloat = new DevExpress.Utils.PointFloat(505.3232F, 0F);
            this.xrLabel74.Name = "xrLabel74";
            this.xrLabel74.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel74.SizeF = new System.Drawing.SizeF(87.19742F, 23F);
            this.xrLabel74.StylePriority.UseFont = false;
            this.xrLabel74.StylePriority.UseTextAlignment = false;
            this.xrLabel74.Text = "xrLabel49";
            this.xrLabel74.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // xrLabel75
            // 
            this.xrLabel75.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.CorplNet", "{0:#,##0.00}")});
            this.xrLabel75.Font = new System.Drawing.Font("Times New Roman", 8F);
            this.xrLabel75.LocationFloat = new DevExpress.Utils.PointFloat(592.5206F, 0F);
            this.xrLabel75.Name = "xrLabel75";
            this.xrLabel75.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel75.SizeF = new System.Drawing.SizeF(77.90625F, 23F);
            this.xrLabel75.StylePriority.UseFont = false;
            this.xrLabel75.StylePriority.UseTextAlignment = false;
            this.xrLabel75.Text = "xrLabel50";
            this.xrLabel75.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // xrLabel76
            // 
            this.xrLabel76.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.RetQTY", "{0:#,##0.00}")});
            this.xrLabel76.Font = new System.Drawing.Font("Times New Roman", 8F);
            this.xrLabel76.LocationFloat = new DevExpress.Utils.PointFloat(670.4269F, 0F);
            this.xrLabel76.Name = "xrLabel76";
            this.xrLabel76.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel76.SizeF = new System.Drawing.SizeF(69.88055F, 23F);
            this.xrLabel76.StylePriority.UseFont = false;
            this.xrLabel76.StylePriority.UseTextAlignment = false;
            this.xrLabel76.Text = "xrLabel56";
            this.xrLabel76.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // xrLabel77
            // 
            this.xrLabel77.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.RetTotal", "{0:#,##0.00}")});
            this.xrLabel77.Font = new System.Drawing.Font("Times New Roman", 8F);
            this.xrLabel77.LocationFloat = new DevExpress.Utils.PointFloat(740.3074F, 0F);
            this.xrLabel77.Name = "xrLabel77";
            this.xrLabel77.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel77.SizeF = new System.Drawing.SizeF(82.01544F, 23F);
            this.xrLabel77.StylePriority.UseFont = false;
            this.xrLabel77.StylePriority.UseTextAlignment = false;
            this.xrLabel77.Text = "xrLabel57";
            this.xrLabel77.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // xrLabel78
            // 
            this.xrLabel78.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.RetNet", "{0:#,##0.00}")});
            this.xrLabel78.Font = new System.Drawing.Font("Times New Roman", 8F);
            this.xrLabel78.LocationFloat = new DevExpress.Utils.PointFloat(822.3229F, 0F);
            this.xrLabel78.Name = "xrLabel78";
            this.xrLabel78.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel78.SizeF = new System.Drawing.SizeF(77.78857F, 23F);
            this.xrLabel78.StylePriority.UseFont = false;
            this.xrLabel78.StylePriority.UseTextAlignment = false;
            this.xrLabel78.Text = "xrLabel55";
            this.xrLabel78.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // xrLabel71
            // 
            this.xrLabel71.BackColor = System.Drawing.Color.Lime;
            this.xrLabel71.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.QTY")});
            this.xrLabel71.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.xrLabel71.ForeColor = System.Drawing.Color.Black;
            this.xrLabel71.LocationFloat = new DevExpress.Utils.PointFloat(229.1667F, 0F);
            this.xrLabel71.Name = "xrLabel71";
            this.xrLabel71.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel71.SizeF = new System.Drawing.SizeF(51.90768F, 23F);
            this.xrLabel71.StyleName = "FieldCaption";
            this.xrLabel71.StylePriority.UseBackColor = false;
            this.xrLabel71.StylePriority.UseFont = false;
            this.xrLabel71.StylePriority.UseForeColor = false;
            this.xrLabel71.StylePriority.UseTextAlignment = false;
            xrSummary10.FormatString = "{0:#,##0.00}";
            xrSummary10.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
            this.xrLabel71.Summary = xrSummary10;
            this.xrLabel71.Text = "xrLabel42";
            this.xrLabel71.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // xrLabel72
            // 
            this.xrLabel72.BackColor = System.Drawing.Color.Lime;
            this.xrLabel72.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.Total", "{0:C2}")});
            this.xrLabel72.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.xrLabel72.ForeColor = System.Drawing.Color.Black;
            this.xrLabel72.LocationFloat = new DevExpress.Utils.PointFloat(281.0744F, 0F);
            this.xrLabel72.Name = "xrLabel72";
            this.xrLabel72.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel72.SizeF = new System.Drawing.SizeF(67.42429F, 23F);
            this.xrLabel72.StyleName = "FieldCaption";
            this.xrLabel72.StylePriority.UseBackColor = false;
            this.xrLabel72.StylePriority.UseFont = false;
            this.xrLabel72.StylePriority.UseForeColor = false;
            this.xrLabel72.StylePriority.UseTextAlignment = false;
            xrSummary11.FormatString = "{0:#,##0.00}";
            xrSummary11.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
            this.xrLabel72.Summary = xrSummary11;
            this.xrLabel72.Text = "xrLabel46";
            this.xrLabel72.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // xrLabel73
            // 
            this.xrLabel73.BackColor = System.Drawing.Color.Lime;
            this.xrLabel73.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.Net", "{0:C2}")});
            this.xrLabel73.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.xrLabel73.ForeColor = System.Drawing.Color.Black;
            this.xrLabel73.LocationFloat = new DevExpress.Utils.PointFloat(348.4987F, 0F);
            this.xrLabel73.Name = "xrLabel73";
            this.xrLabel73.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel73.SizeF = new System.Drawing.SizeF(72.60645F, 23F);
            this.xrLabel73.StyleName = "FieldCaption";
            this.xrLabel73.StylePriority.UseBackColor = false;
            this.xrLabel73.StylePriority.UseFont = false;
            this.xrLabel73.StylePriority.UseForeColor = false;
            this.xrLabel73.StylePriority.UseTextAlignment = false;
            xrSummary12.FormatString = "{0:#,##0.00}";
            xrSummary12.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
            this.xrLabel73.Summary = xrSummary12;
            this.xrLabel73.Text = "xrLabel41";
            this.xrLabel73.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // xrLabel26
            // 
            this.xrLabel26.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.ProductCategoryDescrtiption")});
            this.xrLabel26.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrLabel26.Name = "xrLabel26";
            this.xrLabel26.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel26.SizeF = new System.Drawing.SizeF(229.1667F, 23F);
            // 
            // groupFooterBand2
            // 
            this.groupFooterBand2.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel27,
            this.xrLabel28,
            this.xrLabel29,
            this.xrLabel30,
            this.xrLabel31,
            this.xrLabel32,
            this.xrLabel33,
            this.xrLabel34,
            this.xrLabel35,
            this.xrLabel36});
            this.groupFooterBand2.HeightF = 30F;
            this.groupFooterBand2.Level = 1;
            this.groupFooterBand2.Name = "groupFooterBand2";
            this.groupFooterBand2.Visible = false;
            // 
            // xrLabel27
            // 
            this.xrLabel27.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.CoplQTY")});
            this.xrLabel27.LocationFloat = new DevExpress.Utils.PointFloat(333.8769F, 6F);
            this.xrLabel27.Name = "xrLabel27";
            this.xrLabel27.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel27.SizeF = new System.Drawing.SizeF(58.06154F, 18F);
            this.xrLabel27.StyleName = "FieldCaption";
            xrSummary13.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
            this.xrLabel27.Summary = xrSummary13;
            this.xrLabel27.Text = "xrLabel27";
            // 
            // xrLabel28
            // 
            this.xrLabel28.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.CoplTotal", "{0:C2}")});
            this.xrLabel28.LocationFloat = new DevExpress.Utils.PointFloat(391.9385F, 6F);
            this.xrLabel28.Name = "xrLabel28";
            this.xrLabel28.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel28.SizeF = new System.Drawing.SizeF(61.47692F, 18F);
            this.xrLabel28.StyleName = "FieldCaption";
            xrSummary14.FormatString = "{0:C2}";
            xrSummary14.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
            this.xrLabel28.Summary = xrSummary14;
            this.xrLabel28.Text = "xrLabel28";
            // 
            // xrLabel29
            // 
            this.xrLabel29.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.CorplNet", "{0:C2}")});
            this.xrLabel29.LocationFloat = new DevExpress.Utils.PointFloat(453.4154F, 6F);
            this.xrLabel29.Name = "xrLabel29";
            this.xrLabel29.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel29.SizeF = new System.Drawing.SizeF(57.20769F, 18F);
            this.xrLabel29.StyleName = "FieldCaption";
            xrSummary15.FormatString = "{0:C2}";
            xrSummary15.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
            this.xrLabel29.Summary = xrSummary15;
            this.xrLabel29.Text = "xrLabel29";
            // 
            // xrLabel30
            // 
            this.xrLabel30.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.Net", "{0:C2}")});
            this.xrLabel30.LocationFloat = new DevExpress.Utils.PointFloat(510.6231F, 6F);
            this.xrLabel30.Name = "xrLabel30";
            this.xrLabel30.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel30.SizeF = new System.Drawing.SizeF(23.05385F, 18F);
            this.xrLabel30.StyleName = "FieldCaption";
            xrSummary16.FormatString = "{0:C2}";
            xrSummary16.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
            this.xrLabel30.Summary = xrSummary16;
            this.xrLabel30.Text = "xrLabel30";
            // 
            // xrLabel31
            // 
            this.xrLabel31.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.QTY")});
            this.xrLabel31.LocationFloat = new DevExpress.Utils.PointFloat(683.1F, 6F);
            this.xrLabel31.Name = "xrLabel31";
            this.xrLabel31.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel31.SizeF = new System.Drawing.SizeF(28.17692F, 18F);
            this.xrLabel31.StyleName = "FieldCaption";
            xrSummary17.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
            this.xrLabel31.Summary = xrSummary17;
            this.xrLabel31.Text = "xrLabel31";
            // 
            // xrLabel32
            // 
            this.xrLabel32.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.RetNet", "{0:C2}")});
            this.xrLabel32.LocationFloat = new DevExpress.Utils.PointFloat(711.277F, 6F);
            this.xrLabel32.Name = "xrLabel32";
            this.xrLabel32.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel32.SizeF = new System.Drawing.SizeF(45.25385F, 18F);
            this.xrLabel32.StyleName = "FieldCaption";
            xrSummary18.FormatString = "{0:C2}";
            xrSummary18.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
            this.xrLabel32.Summary = xrSummary18;
            this.xrLabel32.Text = "xrLabel32";
            // 
            // xrLabel33
            // 
            this.xrLabel33.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.RetQTY")});
            this.xrLabel33.LocationFloat = new DevExpress.Utils.PointFloat(756.5308F, 6F);
            this.xrLabel33.Name = "xrLabel33";
            this.xrLabel33.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel33.SizeF = new System.Drawing.SizeF(50.37692F, 18F);
            this.xrLabel33.StyleName = "FieldCaption";
            xrSummary19.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
            this.xrLabel33.Summary = xrSummary19;
            this.xrLabel33.Text = "xrLabel33";
            // 
            // xrLabel34
            // 
            this.xrLabel34.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.RetTotal", "{0:C2}")});
            this.xrLabel34.LocationFloat = new DevExpress.Utils.PointFloat(806.9077F, 6F);
            this.xrLabel34.Name = "xrLabel34";
            this.xrLabel34.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel34.SizeF = new System.Drawing.SizeF(54.64615F, 18F);
            this.xrLabel34.StyleName = "FieldCaption";
            xrSummary20.FormatString = "{0:C2}";
            xrSummary20.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
            this.xrLabel34.Summary = xrSummary20;
            this.xrLabel34.Text = "xrLabel34";
            // 
            // xrLabel35
            // 
            this.xrLabel35.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.Total", "{0:C2}")});
            this.xrLabel35.LocationFloat = new DevExpress.Utils.PointFloat(861.5539F, 6F);
            this.xrLabel35.Name = "xrLabel35";
            this.xrLabel35.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel35.SizeF = new System.Drawing.SizeF(32.44611F, 18F);
            this.xrLabel35.StyleName = "FieldCaption";
            xrSummary21.FormatString = "{0:C2}";
            xrSummary21.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
            this.xrLabel35.Summary = xrSummary21;
            this.xrLabel35.Text = "xrLabel35";
            // 
            // xrLabel36
            // 
            this.xrLabel36.LocationFloat = new DevExpress.Utils.PointFloat(76.01538F, 6F);
            this.xrLabel36.Name = "xrLabel36";
            this.xrLabel36.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel36.SizeF = new System.Drawing.SizeF(257.8615F, 18F);
            this.xrLabel36.StyleName = "FieldCaption";
            this.xrLabel36.Text = "Sum";
            // 
            // groupHeaderBand3
            // 
            this.groupHeaderBand3.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("ProductCode", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.groupHeaderBand3.HeightF = 23.00002F;
            this.groupHeaderBand3.Name = "groupHeaderBand3";
            this.groupHeaderBand3.StyleName = "DataField";
            this.groupHeaderBand3.Visible = false;
            // 
            // xrLabel37
            // 
            this.xrLabel37.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.ProductDescription")});
            this.xrLabel37.Font = new System.Drawing.Font("Times New Roman", 7F);
            this.xrLabel37.LocationFloat = new DevExpress.Utils.PointFloat(63.52135F, 0.9999911F);
            this.xrLabel37.Name = "xrLabel37";
            this.xrLabel37.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel37.SizeF = new System.Drawing.SizeF(96.2499F, 18F);
            this.xrLabel37.StylePriority.UseFont = false;
            this.xrLabel37.WordWrap = false;
            // 
            // xrLabel38
            // 
            this.xrLabel38.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.CoplQTY")});
            this.xrLabel38.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.xrLabel38.ForeColor = System.Drawing.Color.Black;
            this.xrLabel38.LocationFloat = new DevExpress.Utils.PointFloat(453.4154F, 0.9999911F);
            this.xrLabel38.Name = "xrLabel38";
            this.xrLabel38.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel38.SizeF = new System.Drawing.SizeF(51.90768F, 18F);
            this.xrLabel38.StyleName = "FieldCaption";
            this.xrLabel38.StylePriority.UseFont = false;
            this.xrLabel38.StylePriority.UseForeColor = false;
            this.xrLabel38.StylePriority.UseTextAlignment = false;
            xrSummary22.FormatString = "{0:#,##0.00}";
            xrSummary22.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
            this.xrLabel38.Summary = xrSummary22;
            this.xrLabel38.Text = "xrLabel38";
            this.xrLabel38.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // xrLabel45
            // 
            this.xrLabel45.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.RetTotal", "{0:C2}")});
            this.xrLabel45.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.xrLabel45.ForeColor = System.Drawing.Color.Black;
            this.xrLabel45.LocationFloat = new DevExpress.Utils.PointFloat(749.5987F, 0.9999911F);
            this.xrLabel45.Name = "xrLabel45";
            this.xrLabel45.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel45.SizeF = new System.Drawing.SizeF(67.42429F, 18F);
            this.xrLabel45.StyleName = "FieldCaption";
            this.xrLabel45.StylePriority.UseFont = false;
            this.xrLabel45.StylePriority.UseForeColor = false;
            this.xrLabel45.StylePriority.UseTextAlignment = false;
            xrSummary23.FormatString = "{0:#,##0.00}";
            xrSummary23.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
            this.xrLabel45.Summary = xrSummary23;
            this.xrLabel45.Text = "xrLabel45";
            this.xrLabel45.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // xrLabel44
            // 
            this.xrLabel44.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.RetQTY")});
            this.xrLabel44.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.xrLabel44.ForeColor = System.Drawing.Color.Black;
            this.xrLabel44.LocationFloat = new DevExpress.Utils.PointFloat(683.1F, 0.9999911F);
            this.xrLabel44.Name = "xrLabel44";
            this.xrLabel44.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel44.SizeF = new System.Drawing.SizeF(51.90768F, 18F);
            this.xrLabel44.StyleName = "FieldCaption";
            this.xrLabel44.StylePriority.UseFont = false;
            this.xrLabel44.StylePriority.UseForeColor = false;
            this.xrLabel44.StylePriority.UseTextAlignment = false;
            xrSummary24.FormatString = "{0:#,##0.00}";
            xrSummary24.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
            this.xrLabel44.Summary = xrSummary24;
            this.xrLabel44.Text = "xrLabel44";
            this.xrLabel44.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // xrLabel43
            // 
            this.xrLabel43.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.RetNet", "{0:C2}")});
            this.xrLabel43.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.xrLabel43.ForeColor = System.Drawing.Color.Black;
            this.xrLabel43.LocationFloat = new DevExpress.Utils.PointFloat(822.2051F, 0.9999911F);
            this.xrLabel43.Name = "xrLabel43";
            this.xrLabel43.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel43.SizeF = new System.Drawing.SizeF(72.60645F, 18F);
            this.xrLabel43.StyleName = "FieldCaption";
            this.xrLabel43.StylePriority.UseFont = false;
            this.xrLabel43.StylePriority.UseForeColor = false;
            this.xrLabel43.StylePriority.UseTextAlignment = false;
            xrSummary25.FormatString = "{0:#,##0.00}";
            xrSummary25.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
            this.xrLabel43.Summary = xrSummary25;
            this.xrLabel43.Text = "xrLabel43";
            this.xrLabel43.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // xrLabel42
            // 
            this.xrLabel42.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.QTY")});
            this.xrLabel42.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.xrLabel42.ForeColor = System.Drawing.Color.Black;
            this.xrLabel42.LocationFloat = new DevExpress.Utils.PointFloat(229.1667F, 0.9999911F);
            this.xrLabel42.Name = "xrLabel42";
            this.xrLabel42.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel42.SizeF = new System.Drawing.SizeF(51.90768F, 18F);
            this.xrLabel42.StyleName = "FieldCaption";
            this.xrLabel42.StylePriority.UseFont = false;
            this.xrLabel42.StylePriority.UseForeColor = false;
            this.xrLabel42.StylePriority.UseTextAlignment = false;
            xrSummary26.FormatString = "{0:#,##0.00}";
            xrSummary26.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
            this.xrLabel42.Summary = xrSummary26;
            this.xrLabel42.Text = "xrLabel42";
            this.xrLabel42.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // xrLabel41
            // 
            this.xrLabel41.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.Net", "{0:C2}")});
            this.xrLabel41.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.xrLabel41.ForeColor = System.Drawing.Color.Black;
            this.xrLabel41.LocationFloat = new DevExpress.Utils.PointFloat(348.4987F, 0.9999911F);
            this.xrLabel41.Name = "xrLabel41";
            this.xrLabel41.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel41.SizeF = new System.Drawing.SizeF(72.60645F, 18F);
            this.xrLabel41.StyleName = "FieldCaption";
            this.xrLabel41.StylePriority.UseFont = false;
            this.xrLabel41.StylePriority.UseForeColor = false;
            this.xrLabel41.StylePriority.UseTextAlignment = false;
            xrSummary27.FormatString = "{0:#,##0.00}";
            xrSummary27.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
            this.xrLabel41.Summary = xrSummary27;
            this.xrLabel41.Text = "xrLabel41";
            this.xrLabel41.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // xrLabel40
            // 
            this.xrLabel40.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.CorplNet", "{0:C2}")});
            this.xrLabel40.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.xrLabel40.ForeColor = System.Drawing.Color.Black;
            this.xrLabel40.LocationFloat = new DevExpress.Utils.PointFloat(592.5205F, 0.9999911F);
            this.xrLabel40.Name = "xrLabel40";
            this.xrLabel40.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel40.SizeF = new System.Drawing.SizeF(72.60645F, 18F);
            this.xrLabel40.StyleName = "FieldCaption";
            this.xrLabel40.StylePriority.UseFont = false;
            this.xrLabel40.StylePriority.UseForeColor = false;
            this.xrLabel40.StylePriority.UseTextAlignment = false;
            xrSummary28.FormatString = "{0:#,##0.00}";
            xrSummary28.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
            this.xrLabel40.Summary = xrSummary28;
            this.xrLabel40.Text = "xrLabel40";
            this.xrLabel40.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // xrLabel39
            // 
            this.xrLabel39.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.CoplTotal", "{0:C2}")});
            this.xrLabel39.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.xrLabel39.ForeColor = System.Drawing.Color.Black;
            this.xrLabel39.LocationFloat = new DevExpress.Utils.PointFloat(525.0963F, 0.9999911F);
            this.xrLabel39.Name = "xrLabel39";
            this.xrLabel39.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel39.SizeF = new System.Drawing.SizeF(67.42429F, 18F);
            this.xrLabel39.StyleName = "FieldCaption";
            this.xrLabel39.StylePriority.UseFont = false;
            this.xrLabel39.StylePriority.UseForeColor = false;
            this.xrLabel39.StylePriority.UseTextAlignment = false;
            xrSummary29.FormatString = "{0:#,##0.00}";
            xrSummary29.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
            this.xrLabel39.Summary = xrSummary29;
            this.xrLabel39.Text = "xrLabel39";
            this.xrLabel39.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // xrLabel46
            // 
            this.xrLabel46.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.Total", "{0:C2}")});
            this.xrLabel46.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.xrLabel46.ForeColor = System.Drawing.Color.Black;
            this.xrLabel46.LocationFloat = new DevExpress.Utils.PointFloat(281.0744F, 0.9999911F);
            this.xrLabel46.Name = "xrLabel46";
            this.xrLabel46.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel46.SizeF = new System.Drawing.SizeF(67.42429F, 18F);
            this.xrLabel46.StyleName = "FieldCaption";
            this.xrLabel46.StylePriority.UseFont = false;
            this.xrLabel46.StylePriority.UseForeColor = false;
            this.xrLabel46.StylePriority.UseTextAlignment = false;
            xrSummary30.FormatString = "{0:#,##0.00}";
            xrSummary30.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
            this.xrLabel46.Summary = xrSummary30;
            this.xrLabel46.Text = "xrLabel46";
            this.xrLabel46.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // groupFooterBand3
            // 
            this.groupFooterBand3.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel80,
            this.xrLabel79,
            this.xrLabel37,
            this.xrLabel42,
            this.xrLabel46,
            this.xrLabel41,
            this.xrLabel38,
            this.xrLabel39,
            this.xrLabel40,
            this.xrLabel44,
            this.xrLabel45,
            this.xrLabel43});
            this.groupFooterBand3.HeightF = 20.62499F;
            this.groupFooterBand3.Name = "groupFooterBand3";
            // 
            // xrLabel80
            // 
            this.xrLabel80.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.ProductCode")});
            this.xrLabel80.Font = new System.Drawing.Font("Times New Roman", 6F);
            this.xrLabel80.LocationFloat = new DevExpress.Utils.PointFloat(6.00001F, 0.9999911F);
            this.xrLabel80.Name = "xrLabel80";
            this.xrLabel80.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel80.SizeF = new System.Drawing.SizeF(57.52134F, 18F);
            this.xrLabel80.StylePriority.UseFont = false;
            this.xrLabel80.Text = "xrLabel80";
            this.xrLabel80.WordWrap = false;
            // 
            // xrLabel79
            // 
            this.xrLabel79.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.Price", "{0:#,##0.00}€")});
            this.xrLabel79.Font = new System.Drawing.Font("Times New Roman", 8F);
            this.xrLabel79.LocationFloat = new DevExpress.Utils.PointFloat(159.7713F, 0.9999911F);
            this.xrLabel79.Name = "xrLabel79";
            this.xrLabel79.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel79.SizeF = new System.Drawing.SizeF(56.18716F, 18F);
            this.xrLabel79.StylePriority.UseFont = false;
            this.xrLabel79.StylePriority.UseTextAlignment = false;
            this.xrLabel79.Text = "xrLabel52";
            this.xrLabel79.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // pageFooterBand1
            // 
            this.pageFooterBand1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrPageInfo2});
            this.pageFooterBand1.HeightF = 29.00001F;
            this.pageFooterBand1.Name = "pageFooterBand1";
            // 
            // xrPageInfo2
            // 
            this.xrPageInfo2.Format = "Page {0} of {1}";
            this.xrPageInfo2.LocationFloat = new DevExpress.Utils.PointFloat(10.00007F, 6.00001F);
            this.xrPageInfo2.Name = "xrPageInfo2";
            this.xrPageInfo2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrPageInfo2.SizeF = new System.Drawing.SizeF(883.9999F, 23F);
            this.xrPageInfo2.StyleName = "PageInfo";
            this.xrPageInfo2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // reportHeaderBand1
            // 
            this.reportHeaderBand1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel59,
            this.xrLine3});
            this.reportHeaderBand1.HeightF = 25.99999F;
            this.reportHeaderBand1.Name = "reportHeaderBand1";
            // 
            // xrLabel59
            // 
            this.xrLabel59.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel59.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.xrLabel59.ForeColor = System.Drawing.Color.Black;
            this.xrLabel59.LocationFloat = new DevExpress.Utils.PointFloat(6.00001F, 1.999982F);
            this.xrLabel59.Name = "xrLabel59";
            this.xrLabel59.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel59.SizeF = new System.Drawing.SizeF(888F, 23.375F);
            this.xrLabel59.StyleName = "Title";
            this.xrLabel59.StylePriority.UseBorders = false;
            this.xrLabel59.StylePriority.UseFont = false;
            this.xrLabel59.StylePriority.UseForeColor = false;
            this.xrLabel59.StylePriority.UseTextAlignment = false;
            this.xrLabel59.Text = "Πωλήσεις Καθαρές Αξίες";
            this.xrLabel59.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLine3
            // 
            this.xrLine3.LocationFloat = new DevExpress.Utils.PointFloat(6F, 0F);
            this.xrLine3.Name = "xrLine3";
            this.xrLine3.SizeF = new System.Drawing.SizeF(888F, 2F);
            // 
            // reportFooterBand1
            // 
            this.reportFooterBand1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel60,
            this.xrLabel61,
            this.xrLabel62,
            this.xrLabel63,
            this.xrLabel64,
            this.xrLabel65,
            this.xrLabel66,
            this.xrLabel67,
            this.xrLabel68,
            this.xrLabel69});
            this.reportFooterBand1.HeightF = 30F;
            this.reportFooterBand1.Name = "reportFooterBand1";
            // 
            // xrLabel60
            // 
            this.xrLabel60.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.CoplQTY")});
            this.xrLabel60.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.xrLabel60.ForeColor = System.Drawing.Color.Black;
            this.xrLabel60.LocationFloat = new DevExpress.Utils.PointFloat(453.4154F, 6.00001F);
            this.xrLabel60.Name = "xrLabel60";
            this.xrLabel60.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel60.SizeF = new System.Drawing.SizeF(51.90768F, 18F);
            this.xrLabel60.StyleName = "FieldCaption";
            this.xrLabel60.StylePriority.UseFont = false;
            this.xrLabel60.StylePriority.UseForeColor = false;
            this.xrLabel60.StylePriority.UseTextAlignment = false;
            xrSummary31.FormatString = "{0:#.00}";
            xrSummary31.Running = DevExpress.XtraReports.UI.SummaryRunning.Report;
            this.xrLabel60.Summary = xrSummary31;
            this.xrLabel60.Text = "xrLabel60";
            this.xrLabel60.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // xrLabel61
            // 
            this.xrLabel61.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.CoplTotal", "{0:C2}")});
            this.xrLabel61.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.xrLabel61.ForeColor = System.Drawing.Color.Black;
            this.xrLabel61.LocationFloat = new DevExpress.Utils.PointFloat(519.9141F, 6.00001F);
            this.xrLabel61.Name = "xrLabel61";
            this.xrLabel61.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel61.SizeF = new System.Drawing.SizeF(52.8334F, 18F);
            this.xrLabel61.StyleName = "FieldCaption";
            this.xrLabel61.StylePriority.UseFont = false;
            this.xrLabel61.StylePriority.UseForeColor = false;
            this.xrLabel61.StylePriority.UseTextAlignment = false;
            xrSummary32.FormatString = "{0:#.00}";
            xrSummary32.Running = DevExpress.XtraReports.UI.SummaryRunning.Report;
            this.xrLabel61.Summary = xrSummary32;
            this.xrLabel61.Text = "xrLabel61";
            this.xrLabel61.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // xrLabel62
            // 
            this.xrLabel62.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.CorplNet", "{0:C2}")});
            this.xrLabel62.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.xrLabel62.ForeColor = System.Drawing.Color.Black;
            this.xrLabel62.LocationFloat = new DevExpress.Utils.PointFloat(592.5205F, 6.00001F);
            this.xrLabel62.Name = "xrLabel62";
            this.xrLabel62.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel62.SizeF = new System.Drawing.SizeF(52.8334F, 18F);
            this.xrLabel62.StyleName = "FieldCaption";
            this.xrLabel62.StylePriority.UseFont = false;
            this.xrLabel62.StylePriority.UseForeColor = false;
            this.xrLabel62.StylePriority.UseTextAlignment = false;
            xrSummary33.FormatString = "{0:#.00}";
            xrSummary33.Running = DevExpress.XtraReports.UI.SummaryRunning.Report;
            this.xrLabel62.Summary = xrSummary33;
            this.xrLabel62.Text = "xrLabel62";
            this.xrLabel62.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // xrLabel63
            // 
            this.xrLabel63.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.Net", "{0:C2}")});
            this.xrLabel63.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.xrLabel63.ForeColor = System.Drawing.Color.Black;
            this.xrLabel63.LocationFloat = new DevExpress.Utils.PointFloat(368.2718F, 6.00001F);
            this.xrLabel63.Name = "xrLabel63";
            this.xrLabel63.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel63.SizeF = new System.Drawing.SizeF(52.8334F, 18F);
            this.xrLabel63.StyleName = "FieldCaption";
            this.xrLabel63.StylePriority.UseFont = false;
            this.xrLabel63.StylePriority.UseForeColor = false;
            this.xrLabel63.StylePriority.UseTextAlignment = false;
            xrSummary34.FormatString = "{0:#.00}";
            xrSummary34.Running = DevExpress.XtraReports.UI.SummaryRunning.Report;
            this.xrLabel63.Summary = xrSummary34;
            this.xrLabel63.Text = "xrLabel63";
            this.xrLabel63.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // xrLabel64
            // 
            this.xrLabel64.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.QTY")});
            this.xrLabel64.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.xrLabel64.ForeColor = System.Drawing.Color.Black;
            this.xrLabel64.LocationFloat = new DevExpress.Utils.PointFloat(229.1667F, 6.00001F);
            this.xrLabel64.Name = "xrLabel64";
            this.xrLabel64.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel64.SizeF = new System.Drawing.SizeF(51.90768F, 18F);
            this.xrLabel64.StyleName = "FieldCaption";
            this.xrLabel64.StylePriority.UseFont = false;
            this.xrLabel64.StylePriority.UseForeColor = false;
            this.xrLabel64.StylePriority.UseTextAlignment = false;
            xrSummary35.FormatString = "{0:#.00}";
            xrSummary35.Running = DevExpress.XtraReports.UI.SummaryRunning.Report;
            this.xrLabel64.Summary = xrSummary35;
            this.xrLabel64.Text = "xrLabel64";
            this.xrLabel64.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // xrLabel65
            // 
            this.xrLabel65.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.RetNet", "{0:C2}")});
            this.xrLabel65.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.xrLabel65.ForeColor = System.Drawing.Color.Black;
            this.xrLabel65.LocationFloat = new DevExpress.Utils.PointFloat(822.2051F, 6.00001F);
            this.xrLabel65.Name = "xrLabel65";
            this.xrLabel65.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel65.SizeF = new System.Drawing.SizeF(51.90768F, 18F);
            this.xrLabel65.StyleName = "FieldCaption";
            this.xrLabel65.StylePriority.UseFont = false;
            this.xrLabel65.StylePriority.UseForeColor = false;
            this.xrLabel65.StylePriority.UseTextAlignment = false;
            xrSummary36.FormatString = "{0:#.00}";
            xrSummary36.Running = DevExpress.XtraReports.UI.SummaryRunning.Report;
            this.xrLabel65.Summary = xrSummary36;
            this.xrLabel65.Text = "xrLabel65";
            this.xrLabel65.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // xrLabel66
            // 
            this.xrLabel66.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.RetQTY")});
            this.xrLabel66.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.xrLabel66.ForeColor = System.Drawing.Color.Black;
            this.xrLabel66.LocationFloat = new DevExpress.Utils.PointFloat(683.1F, 6.00001F);
            this.xrLabel66.Name = "xrLabel66";
            this.xrLabel66.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel66.SizeF = new System.Drawing.SizeF(52.8334F, 18F);
            this.xrLabel66.StyleName = "FieldCaption";
            this.xrLabel66.StylePriority.UseFont = false;
            this.xrLabel66.StylePriority.UseForeColor = false;
            this.xrLabel66.StylePriority.UseTextAlignment = false;
            xrSummary37.FormatString = "{0:#.00}";
            xrSummary37.Running = DevExpress.XtraReports.UI.SummaryRunning.Report;
            this.xrLabel66.Summary = xrSummary37;
            this.xrLabel66.Text = "xrLabel66";
            this.xrLabel66.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // xrLabel67
            // 
            this.xrLabel67.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.RetTotal", "{0:C2}")});
            this.xrLabel67.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.xrLabel67.ForeColor = System.Drawing.Color.Black;
            this.xrLabel67.LocationFloat = new DevExpress.Utils.PointFloat(749.5987F, 6.00001F);
            this.xrLabel67.Name = "xrLabel67";
            this.xrLabel67.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel67.SizeF = new System.Drawing.SizeF(52.8334F, 18F);
            this.xrLabel67.StyleName = "FieldCaption";
            this.xrLabel67.StylePriority.UseFont = false;
            this.xrLabel67.StylePriority.UseForeColor = false;
            this.xrLabel67.StylePriority.UseTextAlignment = false;
            xrSummary38.FormatString = "{0:#.00}";
            xrSummary38.Running = DevExpress.XtraReports.UI.SummaryRunning.Report;
            this.xrLabel67.Summary = xrSummary38;
            this.xrLabel67.Text = "xrLabel67";
            this.xrLabel67.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // xrLabel68
            // 
            this.xrLabel68.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.Total", "{0:C2}")});
            this.xrLabel68.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.xrLabel68.ForeColor = System.Drawing.Color.Black;
            this.xrLabel68.LocationFloat = new DevExpress.Utils.PointFloat(295.6653F, 6.00001F);
            this.xrLabel68.Name = "xrLabel68";
            this.xrLabel68.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel68.SizeF = new System.Drawing.SizeF(52.8334F, 18F);
            this.xrLabel68.StyleName = "FieldCaption";
            this.xrLabel68.StylePriority.UseFont = false;
            this.xrLabel68.StylePriority.UseForeColor = false;
            this.xrLabel68.StylePriority.UseTextAlignment = false;
            xrSummary39.FormatString = "{0:#.00}";
            xrSummary39.Running = DevExpress.XtraReports.UI.SummaryRunning.Report;
            this.xrLabel68.Summary = xrSummary39;
            this.xrLabel68.Text = "xrLabel68";
            this.xrLabel68.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // xrLabel69
            // 
            this.xrLabel69.ForeColor = System.Drawing.Color.Black;
            this.xrLabel69.LocationFloat = new DevExpress.Utils.PointFloat(6.00001F, 6.00001F);
            this.xrLabel69.Name = "xrLabel69";
            this.xrLabel69.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel69.SizeF = new System.Drawing.SizeF(209.9584F, 18F);
            this.xrLabel69.StyleName = "FieldCaption";
            this.xrLabel69.StylePriority.UseForeColor = false;
            this.xrLabel69.Text = "Grand Total";
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
            // FromDate
            // 
            this.FromDate.Description = "From Date";
            this.FromDate.Name = "FromDate";
            this.FromDate.Type = typeof(System.DateTime);
            this.FromDate.ValueInfo = "2016-05-25";
            // 
            // ToDate
            // 
            this.ToDate.Description = "To Date";
            this.ToDate.Name = "ToDate";
            this.ToDate.Type = typeof(System.DateTime);
            this.ToDate.ValueInfo = "2016-05-25";
            // 
            // sqlDataSource2
            // 
            this.sqlDataSource2.ConnectionName = "ReportConnection";
            this.sqlDataSource2.Name = "sqlDataSource2";
            customSqlQuery3.Name = "Query";
            queryParameter6.Name = "FromDate";
            queryParameter6.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter6.Value = new DevExpress.DataAccess.Expression("[Parameters.FromDate]", typeof(System.DateTime));
            queryParameter7.Name = "ToDate";
            queryParameter7.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter7.Value = new DevExpress.DataAccess.Expression("[Parameters.ToDate]", typeof(System.DateTime));
            customSqlQuery3.Parameters.Add(queryParameter6);
            customSqlQuery3.Parameters.Add(queryParameter7);
            customSqlQuery3.Sql = resources.GetString("customSqlQuery3.Sql");
            customSqlQuery4.Name = "SunRepQuery";
            queryParameter8.Name = "FromDate";
            queryParameter8.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter8.Value = new DevExpress.DataAccess.Expression("[Parameters.FromDate]", typeof(System.DateTime));
            queryParameter9.Name = "ToDate";
            queryParameter9.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter9.Value = new DevExpress.DataAccess.Expression("[Parameters.ToDate]", typeof(System.DateTime));
            customSqlQuery4.Parameters.Add(queryParameter8);
            customSqlQuery4.Parameters.Add(queryParameter9);
            customSqlQuery4.Sql = resources.GetString("customSqlQuery4.Sql");
            this.sqlDataSource2.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            customSqlQuery3,
            customSqlQuery4});
            this.sqlDataSource2.ResultSchemaSerializable = resources.GetString("sqlDataSource2.ResultSchemaSerializable");
            // 
            // DepartmentId
            // 
            this.DepartmentId.Description = "Department";
            this.DepartmentId.Name = "DepartmentId";
            this.DepartmentId.Type = typeof(long);
            this.DepartmentId.ValueInfo = "0";
            this.DepartmentId.Visible = false;
            // 
            // xrLine4
            // 
            this.xrLine4.LocationFloat = new DevExpress.Utils.PointFloat(0F, 161.75F);
            this.xrLine4.Name = "xrLine4";
            this.xrLine4.SizeF = new System.Drawing.SizeF(900F, 2F);
            // 
            // xrLine2
            // 
            this.xrLine2.LocationFloat = new DevExpress.Utils.PointFloat(5.999994F, 58.50001F);
            this.xrLine2.Name = "xrLine2";
            this.xrLine2.SizeF = new System.Drawing.SizeF(888F, 2F);
            // 
            // xrLine1
            // 
            this.xrLine1.LocationFloat = new DevExpress.Utils.PointFloat(6F, 5F);
            this.xrLine1.Name = "xrLine1";
            this.xrLine1.SizeF = new System.Drawing.SizeF(888F, 2F);
            // 
            // xrLabel3
            // 
            this.xrLabel3.Font = new System.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
            this.xrLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.xrLabel3.LocationFloat = new DevExpress.Utils.PointFloat(10.00004F, 40.5F);
            this.xrLabel3.Name = "xrLabel3";
            this.xrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel3.SizeF = new System.Drawing.SizeF(205.9584F, 18F);
            this.xrLabel3.StylePriority.UseFont = false;
            this.xrLabel3.StylePriority.UseForeColor = false;
            this.xrLabel3.Text = "Προϊόν";
            // 
            // xrLabel1
            // 
            this.xrLabel1.Font = new System.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
            this.xrLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(229.1667F, 40.5F);
            this.xrLabel1.Name = "xrLabel1";
            this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel1.SizeF = new System.Drawing.SizeF(51.90768F, 18F);
            this.xrLabel1.StylePriority.UseFont = false;
            this.xrLabel1.StylePriority.UseForeColor = false;
            this.xrLabel1.Text = "Ποσότητα";
            // 
            // xrLabel2
            // 
            this.xrLabel2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.xrLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.xrLabel2.LocationFloat = new DevExpress.Utils.PointFloat(229.1667F, 10.00001F);
            this.xrLabel2.Name = "xrLabel2";
            this.xrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel2.SizeF = new System.Drawing.SizeF(204.4385F, 18F);
            this.xrLabel2.StylePriority.UseFont = false;
            this.xrLabel2.StylePriority.UseForeColor = false;
            this.xrLabel2.StylePriority.UseTextAlignment = false;
            this.xrLabel2.Text = "ΠΩΛΗΣΕΙΣ";
            this.xrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel4
            // 
            this.xrLabel4.Font = new System.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
            this.xrLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.xrLabel4.LocationFloat = new DevExpress.Utils.PointFloat(295.6653F, 40.5F);
            this.xrLabel4.Name = "xrLabel4";
            this.xrLabel4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel4.SizeF = new System.Drawing.SizeF(72.60651F, 18F);
            this.xrLabel4.StylePriority.UseFont = false;
            this.xrLabel4.StylePriority.UseForeColor = false;
            this.xrLabel4.StylePriority.UseTextAlignment = false;
            this.xrLabel4.Text = "Αξια";
            this.xrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // xrLabel5
            // 
            this.xrLabel5.Font = new System.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
            this.xrLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.xrLabel5.LocationFloat = new DevExpress.Utils.PointFloat(368.2718F, 28.00001F);
            this.xrLabel5.Name = "xrLabel5";
            this.xrLabel5.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel5.SizeF = new System.Drawing.SizeF(65.33337F, 30.5F);
            this.xrLabel5.StylePriority.UseFont = false;
            this.xrLabel5.StylePriority.UseForeColor = false;
            this.xrLabel5.StylePriority.UseTextAlignment = false;
            this.xrLabel5.Text = "Καθαρή Αξία";
            this.xrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // xrLabel9
            // 
            this.xrLabel9.Font = new System.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
            this.xrLabel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.xrLabel9.LocationFloat = new DevExpress.Utils.PointFloat(612.2936F, 28.00001F);
            this.xrLabel9.Name = "xrLabel9";
            this.xrLabel9.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel9.SizeF = new System.Drawing.SizeF(52.8334F, 30.5F);
            this.xrLabel9.StylePriority.UseFont = false;
            this.xrLabel9.StylePriority.UseForeColor = false;
            this.xrLabel9.StylePriority.UseTextAlignment = false;
            this.xrLabel9.Text = "Καθαρή Αξία";
            this.xrLabel9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // xrLabel8
            // 
            this.xrLabel8.Font = new System.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
            this.xrLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.xrLabel8.LocationFloat = new DevExpress.Utils.PointFloat(519.9141F, 40.5F);
            this.xrLabel8.Name = "xrLabel8";
            this.xrLabel8.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel8.SizeF = new System.Drawing.SizeF(72.60651F, 18F);
            this.xrLabel8.StylePriority.UseFont = false;
            this.xrLabel8.StylePriority.UseForeColor = false;
            this.xrLabel8.StylePriority.UseTextAlignment = false;
            this.xrLabel8.Text = "Αξια";
            this.xrLabel8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // xrLabel7
            // 
            this.xrLabel7.Font = new System.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
            this.xrLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.xrLabel7.LocationFloat = new DevExpress.Utils.PointFloat(453.4154F, 40.5F);
            this.xrLabel7.Name = "xrLabel7";
            this.xrLabel7.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel7.SizeF = new System.Drawing.SizeF(51.90768F, 18F);
            this.xrLabel7.StylePriority.UseFont = false;
            this.xrLabel7.StylePriority.UseForeColor = false;
            this.xrLabel7.Text = "Ποσότητα";
            // 
            // xrLabel6
            // 
            this.xrLabel6.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.xrLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.xrLabel6.LocationFloat = new DevExpress.Utils.PointFloat(453.4154F, 10.00001F);
            this.xrLabel6.Name = "xrLabel6";
            this.xrLabel6.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel6.SizeF = new System.Drawing.SizeF(211.7116F, 18F);
            this.xrLabel6.StylePriority.UseFont = false;
            this.xrLabel6.StylePriority.UseForeColor = false;
            this.xrLabel6.StylePriority.UseTextAlignment = false;
            this.xrLabel6.Text = "ΦΙΛΟΞΕΝΙΑ";
            this.xrLabel6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel13
            // 
            this.xrLabel13.Font = new System.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
            this.xrLabel13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.xrLabel13.LocationFloat = new DevExpress.Utils.PointFloat(822.2051F, 28.00001F);
            this.xrLabel13.Name = "xrLabel13";
            this.xrLabel13.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel13.SizeF = new System.Drawing.SizeF(52.8334F, 30.5F);
            this.xrLabel13.StylePriority.UseFont = false;
            this.xrLabel13.StylePriority.UseForeColor = false;
            this.xrLabel13.StylePriority.UseTextAlignment = false;
            this.xrLabel13.Text = "Καθαρή Αξία";
            this.xrLabel13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // xrLabel12
            // 
            this.xrLabel12.Font = new System.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
            this.xrLabel12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.xrLabel12.LocationFloat = new DevExpress.Utils.PointFloat(749.5987F, 40.5F);
            this.xrLabel12.Name = "xrLabel12";
            this.xrLabel12.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel12.SizeF = new System.Drawing.SizeF(52.8334F, 18F);
            this.xrLabel12.StylePriority.UseFont = false;
            this.xrLabel12.StylePriority.UseForeColor = false;
            this.xrLabel12.StylePriority.UseTextAlignment = false;
            this.xrLabel12.Text = "Αξια";
            this.xrLabel12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // xrLabel11
            // 
            this.xrLabel11.Font = new System.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
            this.xrLabel11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.xrLabel11.LocationFloat = new DevExpress.Utils.PointFloat(683.1F, 40.5F);
            this.xrLabel11.Name = "xrLabel11";
            this.xrLabel11.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel11.SizeF = new System.Drawing.SizeF(51.90768F, 18F);
            this.xrLabel11.StylePriority.UseFont = false;
            this.xrLabel11.StylePriority.UseForeColor = false;
            this.xrLabel11.Text = "Ποσότητα";
            // 
            // xrLabel10
            // 
            this.xrLabel10.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.xrLabel10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.xrLabel10.LocationFloat = new DevExpress.Utils.PointFloat(683.1F, 10.00001F);
            this.xrLabel10.Name = "xrLabel10";
            this.xrLabel10.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel10.SizeF = new System.Drawing.SizeF(191.9385F, 18F);
            this.xrLabel10.StylePriority.UseFont = false;
            this.xrLabel10.StylePriority.UseForeColor = false;
            this.xrLabel10.StylePriority.UseTextAlignment = false;
            this.xrLabel10.Text = "ΕΠΙΣΤΡΟΦΕΣ";
            this.xrLabel10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel14
            // 
            this.xrLabel14.Font = new System.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
            this.xrLabel14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.xrLabel14.LocationFloat = new DevExpress.Utils.PointFloat(132.9167F, 22.50001F);
            this.xrLabel14.Name = "xrLabel14";
            this.xrLabel14.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel14.SizeF = new System.Drawing.SizeF(83.04169F, 18.00001F);
            this.xrLabel14.StylePriority.UseFont = false;
            this.xrLabel14.StylePriority.UseForeColor = false;
            this.xrLabel14.StylePriority.UseTextAlignment = false;
            this.xrLabel14.Text = "Τιμοκατάλογος";
            this.xrLabel14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // xrLabel70
            // 
            this.xrLabel70.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel70.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrLabel70.LocationFloat = new DevExpress.Utils.PointFloat(0F, 88.75002F);
            this.xrLabel70.Name = "xrLabel70";
            this.xrLabel70.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel70.SizeF = new System.Drawing.SizeF(894F, 23F);
            this.xrLabel70.StylePriority.UseBorders = false;
            this.xrLabel70.StylePriority.UseFont = false;
            this.xrLabel70.Text = "Σύνολα Κατηγορίών";
            // 
            // pageHeaderBand1
            // 
            this.pageHeaderBand1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel70,
            this.xrLabel14,
            this.xrLabel10,
            this.xrLabel11,
            this.xrLabel12,
            this.xrLabel13,
            this.xrLabel6,
            this.xrLabel7,
            this.xrLabel8,
            this.xrLabel9,
            this.xrLabel5,
            this.xrLabel4,
            this.xrLabel2,
            this.xrLabel1,
            this.xrLabel3,
            this.xrLine1,
            this.xrLine2,
            this.xrLine4});
            this.pageHeaderBand1.HeightF = 172.0833F;
            this.pageHeaderBand1.Name = "pageHeaderBand1";
            // 
            // SalesNetAmount
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.pageHeaderBand1,
            this.groupHeaderBand1,
            this.groupFooterBand1,
            this.groupHeaderBand2,
            this.groupFooterBand2,
            this.groupHeaderBand3,
            this.groupFooterBand3,
            this.pageFooterBand1,
            this.reportHeaderBand1,
            this.reportFooterBand1});
            this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.sqlDataSource1,
            this.sqlDataSource2});
            this.DataMember = "Query";
            this.DataSource = this.sqlDataSource1;
            this.Landscape = true;
            this.Margins = new System.Drawing.Printing.Margins(100, 99, 100, 100);
            this.PageHeight = 850;
            this.PageWidth = 1100;
            this.Parameters.AddRange(new DevExpress.XtraReports.Parameters.Parameter[] {
            this.FromDate,
            this.ToDate,
            this.DepartmentId});
            this.StyleSheet.AddRange(new DevExpress.XtraReports.UI.XRControlStyle[] {
            this.Title,
            this.FieldCaption,
            this.PageInfo,
            this.DataField});
            this.Version = "15.2";
            this.ParametersRequestSubmit += new System.EventHandler<DevExpress.XtraReports.Parameters.ParametersRequestEventArgs>(this.SalesNetAmount_ParametersRequestSubmit);
            this.DataSourceDemanded += new System.EventHandler<System.EventArgs>(this.SalesNetAmount_DataSourceDemanded);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

    }

    #endregion

    private void SalesNetAmount_DataSourceDemanded(object sender, EventArgs e)
    {
        int? dbVersion = Convert.ToInt32(WebConfigurationManager.AppSettings["DBVersion"]);

        if (dbVersion != null && dbVersion == 1)
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

    private void SalesNetAmount_ParametersRequestSubmit(object sender, DevExpress.XtraReports.Parameters.ParametersRequestEventArgs e)
    {
        // fieldOrderDate1 is the name of the PivotGridField with DateTime values; startDate and endDate - report parameters
        
    }

    private void groupHeaderBand1_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
    {
        //var depIt = this.sqlDataSource1.Queries["Query"].
        //(sender as GroupHeaderBand).
        //Int64 depId = -1;
        ////if  string.(this.xrLabel81.Text)

        //Int64.TryParse(this.xrLabel81.Text, out depId);
        //if (depId > 0)
        //    xrPivotGrid1.Prefilter.CriteriaString = string.Format("DepartmentId", depId);
            //this.DepartmentId.Value = depId;
         //searchLookUpEdit.Properties.GetDisplayValueByKeyValue(searchLookUpEdit.EditValue)
            //object displayMemeber = searchLookUpEdit.Properties.GetDisplayValueByKeyValue(searchLookUpEdit.EditValue);

        //xrPivotGrid1.Prefilter.CriteriaString = string.Format("DepartmentId", ); //Int64.Parse(this.xrLabel81.ToString())
    }

    private void xrLabel81_TextChanged(object sender, EventArgs e)
    {
        //Int64 depId = -1;
      

        //Int64.TryParse(this.xrLabel81.Text, out depId);
        //if (depId > 0)
        //{
        //    this.DepartmentId.Value = depId;
        //    this.sqlDataSource1.Queries["SunRepQuery"].Parameters[2].Value = depId;

        //}
            
        //    xrPivotGrid1.Prefilter.CriteriaString = string.Format("DepartmentId", depId);
    }
}
