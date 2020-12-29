
using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Web.Configuration;
using WEBPOS_Reports.Helpers;

/// <summary>
/// Summary description for SalesNetAmount2
/// </summary>
public class SalesNetAmount2 : DevExpress.XtraReports.UI.XtraReport
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
   private XRLabel xrLabel26;
   private XRLabel xrLabel37;
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
   private XRLabel xrLabel70;
   private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource2;
   private XRSubreport xrSubreport1;
   private GroupHeaderBand ProductGroupHeader;
   private GroupHeaderBand ProductCategoryGroupHeader;
   private XRLabel xrLabel71;
   private XRLabel xrLabel72;
   private XRLabel xrLabel73;
   private XRLabel xrLabel74;
   private XRLabel xrLabel75;
   private XRLabel xrLabel76;
   private XRLabel xrLabel77;
   private XRLabel xrLabel78;
   private XRLabel xrLabel79;
   private GroupHeaderBand CategoryGroupHeader;
   private XRLabel xrLabel80;
   private XRLabel xrLabel81;
   private XRLabel xrLabel82;
   private XRLabel xrLabel83;
   private XRLabel xrLabel84;
   private XRLabel xrLabel85;
   private XRLabel xrLabel86;
   private XRLabel xrLabel87;
   private XRLabel xrLabel88;
   private XRLabel xrLabel89;
   private GroupHeaderBand DepartmentGroupHeader;
   private XRLine xrLine3;
   private XRLine xrLine5;
   private XRLabel xrLabel90;
   private XRLabel xrLabel91;
   private XRLabel xrLabel92;
   private XRLabel xrLabel93;
   private XRLabel xrLabel94;
   private XRLabel xrLabel98;
   private XRLabel xrLabel102;
   private XRLabel xrLabel1;
   private XRLabel xrLabel2;
   private XRLabel xrLabel3;
   private XRLabel xrLabel4;
   private XRLabel xrLabel5;
   private XRLabel xrLabel6;
   private XRLabel xrLabel7;
   private XRLabel xrLabel8;
   private XRLabel xrLabel9;
   private XRLabel xrLabel11;
   private XRLabel xrLabel18;
   private XRLabel xrLabel19;
   private XRLabel xrLabel20;
   private XRLabel xrLabel21;
   private XRLabel xrLabel22;
   private XRLabel xrLabel23;
   private XRLabel xrLabel24;
   private XRLabel xrLabel25;
   private XRLabel xrLabel27;
   private XRLabel xrLabel28;
   private XRLabel xrLabel14;
   private XRLabel xrLabel16;
   private XRLabel xrLabel17;
   private XRLabel xrLabel10;
   private XRLabel xrLabel12;
   private XRLabel xrLabel13;
   private DevExpress.XtraReports.Parameters.Parameter DepartmentId;
   private DevExpress.XtraReports.Parameters.Parameter CategoryId;
   private DevExpress.XtraReports.Parameters.Parameter ProductCategoryCode;

   /// <summary>
   /// Required designer variable.
   /// </summary>
   private System.ComponentModel.IContainer components = null;

   public SalesNetAmount2()
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalesNetAmount2));
            DevExpress.DataAccess.Sql.CustomSqlQuery customSqlQuery2 = new DevExpress.DataAccess.Sql.CustomSqlQuery();
            DevExpress.DataAccess.Sql.CustomSqlQuery customSqlQuery3 = new DevExpress.DataAccess.Sql.CustomSqlQuery();
            DevExpress.DataAccess.Sql.CustomSqlQuery customSqlQuery4 = new DevExpress.DataAccess.Sql.CustomSqlQuery();
            DevExpress.DataAccess.Sql.CustomSqlQuery customSqlQuery5 = new DevExpress.DataAccess.Sql.CustomSqlQuery();
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
            DevExpress.DataAccess.Sql.CustomSqlQuery customSqlQuery6 = new DevExpress.DataAccess.Sql.CustomSqlQuery();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter3 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter4 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.CustomSqlQuery customSqlQuery7 = new DevExpress.DataAccess.Sql.CustomSqlQuery();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter5 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter6 = new DevExpress.DataAccess.Sql.QueryParameter();
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
            DevExpress.XtraReports.UI.XRSummary xrSummary40 = new DevExpress.XtraReports.UI.XRSummary();
            DevExpress.XtraReports.UI.XRSummary xrSummary41 = new DevExpress.XtraReports.UI.XRSummary();
            DevExpress.XtraReports.UI.XRSummary xrSummary42 = new DevExpress.XtraReports.UI.XRSummary();
            DevExpress.XtraReports.UI.XRSummary xrSummary43 = new DevExpress.XtraReports.UI.XRSummary();
            DevExpress.XtraReports.UI.XRSummary xrSummary44 = new DevExpress.XtraReports.UI.XRSummary();
            DevExpress.XtraReports.UI.XRSummary xrSummary45 = new DevExpress.XtraReports.UI.XRSummary();
            DevExpress.XtraReports.UI.XRSummary xrSummary46 = new DevExpress.XtraReports.UI.XRSummary();
            DevExpress.XtraReports.UI.XRSummary xrSummary47 = new DevExpress.XtraReports.UI.XRSummary();
            DevExpress.XtraReports.UI.XRSummary xrSummary48 = new DevExpress.XtraReports.UI.XRSummary();
            DevExpress.XtraReports.UI.XRSummary xrSummary49 = new DevExpress.XtraReports.UI.XRSummary();
            DevExpress.XtraReports.UI.XRSummary xrSummary50 = new DevExpress.XtraReports.UI.XRSummary();
            DevExpress.XtraReports.UI.XRSummary xrSummary51 = new DevExpress.XtraReports.UI.XRSummary();
            DevExpress.XtraReports.UI.XRSummary xrSummary52 = new DevExpress.XtraReports.UI.XRSummary();
            DevExpress.XtraReports.UI.XRSummary xrSummary53 = new DevExpress.XtraReports.UI.XRSummary();
            DevExpress.XtraReports.UI.XRSummary xrSummary54 = new DevExpress.XtraReports.UI.XRSummary();
            DevExpress.XtraReports.Parameters.DynamicListLookUpSettings dynamicListLookUpSettings1 = new DevExpress.XtraReports.Parameters.DynamicListLookUpSettings();
            DevExpress.XtraReports.Parameters.DynamicListLookUpSettings dynamicListLookUpSettings2 = new DevExpress.XtraReports.Parameters.DynamicListLookUpSettings();
            DevExpress.XtraReports.Parameters.DynamicListLookUpSettings dynamicListLookUpSettings3 = new DevExpress.XtraReports.Parameters.DynamicListLookUpSettings();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
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
            this.xrLabel70 = new DevExpress.XtraReports.UI.XRLabel();
            this.groupHeaderBand1 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel4 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel5 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel6 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel7 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel8 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel9 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel53 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel15 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel26 = new DevExpress.XtraReports.UI.XRLabel();
            this.FromDate = new DevExpress.XtraReports.Parameters.Parameter();
            this.ToDate = new DevExpress.XtraReports.Parameters.Parameter();
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
            this.pageFooterBand1 = new DevExpress.XtraReports.UI.PageFooterBand();
            this.xrPageInfo2 = new DevExpress.XtraReports.UI.XRPageInfo();
            this.reportHeaderBand1 = new DevExpress.XtraReports.UI.ReportHeaderBand();
            this.xrLabel18 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel59 = new DevExpress.XtraReports.UI.XRLabel();
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
            this.sqlDataSource2 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.ProductGroupHeader = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.ProductCategoryGroupHeader = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.xrLabel71 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel72 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel73 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel74 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel75 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel76 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel77 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel78 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel79 = new DevExpress.XtraReports.UI.XRLabel();
            this.CategoryGroupHeader = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.xrLabel80 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel81 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel82 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel83 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel84 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel85 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel86 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel87 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel88 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel89 = new DevExpress.XtraReports.UI.XRLabel();
            this.DepartmentGroupHeader = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.xrLabel14 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel16 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel17 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel10 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel12 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel13 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel19 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel20 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel21 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel22 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel23 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel24 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel25 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel27 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel28 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel11 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLine3 = new DevExpress.XtraReports.UI.XRLine();
            this.xrLine5 = new DevExpress.XtraReports.UI.XRLine();
            this.xrLabel90 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel91 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel92 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel93 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel94 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel98 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel102 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrSubreport1 = new DevExpress.XtraReports.UI.XRSubreport();
            this.CategoryId = new DevExpress.XtraReports.Parameters.Parameter();
            this.DepartmentId = new DevExpress.XtraReports.Parameters.Parameter();
            this.ProductCategoryCode = new DevExpress.XtraReports.Parameters.Parameter();
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
            customSqlQuery2.Name = "Query_FastStart";
            customSqlQuery2.Sql = "select * from invoices where id = -1";
            customSqlQuery3.Name = "Departments";
            customSqlQuery3.Sql = "/* Departments */\r\nSelect Id\r\n     , [Description]\r\nFrom Department\r\nOrder By Id\r" +
    "\n";
            customSqlQuery4.Name = "Categories";
            customSqlQuery4.Sql = "/* Categories */\r\nSELECT Id\r\n     , CategoryDescription = ISNULL(c.[Description]," +
    "\'No Category\')\r\nFROM Categories c\r\nORDER BY [Description]\r\n";
            customSqlQuery5.Name = "ProductCategories";
            customSqlQuery5.Sql = "/* ProductCategories */\r\nSelect Code = IsNull( Code, \'No Category\' )\r\n     , [Des" +
    "cription]\r\nFrom ProductCategories\r\nOrder By [Description] Asc\r\n";
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            customSqlQuery1,
            customSqlQuery2,
            customSqlQuery3,
            customSqlQuery4,
            customSqlQuery5});
            this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
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
            this.Detail.HeightF = 18.99999F;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.StyleName = "DataField";
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.Detail.Visible = false;
            // 
            // xrLabel48
            // 
            this.xrLabel48.CanGrow = false;
            this.xrLabel48.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.CoplQTY", "{0:0.##}")});
            this.xrLabel48.Font = new System.Drawing.Font("Times New Roman", 8F);
            this.xrLabel48.LocationFloat = new DevExpress.Utils.PointFloat(504.7909F, 0F);
            this.xrLabel48.Name = "xrLabel48";
            this.xrLabel48.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel48.SizeF = new System.Drawing.SizeF(91F, 18F);
            this.xrLabel48.StylePriority.UseFont = false;
            this.xrLabel48.StylePriority.UseTextAlignment = false;
            this.xrLabel48.Text = "xrLabel48";
            this.xrLabel48.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.xrLabel48.WordWrap = false;
            // 
            // xrLabel49
            // 
            this.xrLabel49.CanGrow = false;
            this.xrLabel49.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.CoplTotal", "{0:#,##0.00}")});
            this.xrLabel49.Font = new System.Drawing.Font("Times New Roman", 8F);
            this.xrLabel49.LocationFloat = new DevExpress.Utils.PointFloat(595.8835F, 0F);
            this.xrLabel49.Name = "xrLabel49";
            this.xrLabel49.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel49.SizeF = new System.Drawing.SizeF(93.7168F, 18F);
            this.xrLabel49.StylePriority.UseFont = false;
            this.xrLabel49.StylePriority.UseTextAlignment = false;
            this.xrLabel49.Text = "xrLabel49";
            this.xrLabel49.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.xrLabel49.WordWrap = false;
            // 
            // xrLabel50
            // 
            this.xrLabel50.CanGrow = false;
            this.xrLabel50.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.CorplNet", "{0:#,##0.00}")});
            this.xrLabel50.Font = new System.Drawing.Font("Times New Roman", 8F);
            this.xrLabel50.LocationFloat = new DevExpress.Utils.PointFloat(689.6003F, 0F);
            this.xrLabel50.Name = "xrLabel50";
            this.xrLabel50.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel50.SizeF = new System.Drawing.SizeF(91F, 18F);
            this.xrLabel50.StylePriority.UseFont = false;
            this.xrLabel50.StylePriority.UseTextAlignment = false;
            this.xrLabel50.Text = "xrLabel50";
            this.xrLabel50.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.xrLabel50.WordWrap = false;
            // 
            // xrLabel51
            // 
            this.xrLabel51.CanGrow = false;
            this.xrLabel51.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.Net", "{0:#,##0.00}")});
            this.xrLabel51.Font = new System.Drawing.Font("Times New Roman", 8F);
            this.xrLabel51.LocationFloat = new DevExpress.Utils.PointFloat(413.3835F, 0F);
            this.xrLabel51.Name = "xrLabel51";
            this.xrLabel51.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel51.SizeF = new System.Drawing.SizeF(91F, 18F);
            this.xrLabel51.StylePriority.UseFont = false;
            this.xrLabel51.StylePriority.UseTextAlignment = false;
            this.xrLabel51.Text = "xrLabel51";
            this.xrLabel51.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.xrLabel51.WordWrap = false;
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
            this.xrLabel54.CanGrow = false;
            this.xrLabel54.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.QTY", "{0:0.##}")});
            this.xrLabel54.Font = new System.Drawing.Font("Times New Roman", 8F);
            this.xrLabel54.LocationFloat = new DevExpress.Utils.PointFloat(229.1667F, 0F);
            this.xrLabel54.Name = "xrLabel54";
            this.xrLabel54.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel54.SizeF = new System.Drawing.SizeF(90.49998F, 18F);
            this.xrLabel54.StylePriority.UseFont = false;
            this.xrLabel54.StylePriority.UseTextAlignment = false;
            this.xrLabel54.Text = "xrLabel54";
            this.xrLabel54.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.xrLabel54.WordWrap = false;
            // 
            // xrLabel55
            // 
            this.xrLabel55.CanGrow = false;
            this.xrLabel55.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.RetNet", "{0:#,##0.00}")});
            this.xrLabel55.Font = new System.Drawing.Font("Times New Roman", 8F);
            this.xrLabel55.LocationFloat = new DevExpress.Utils.PointFloat(965.3171F, 0F);
            this.xrLabel55.Name = "xrLabel55";
            this.xrLabel55.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel55.SizeF = new System.Drawing.SizeF(90.68292F, 18F);
            this.xrLabel55.StylePriority.UseFont = false;
            this.xrLabel55.StylePriority.UseTextAlignment = false;
            this.xrLabel55.Text = "xrLabel55";
            this.xrLabel55.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.xrLabel55.WordWrap = false;
            // 
            // xrLabel56
            // 
            this.xrLabel56.CanGrow = false;
            this.xrLabel56.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.RetQTY", "{0:0.##}")});
            this.xrLabel56.Font = new System.Drawing.Font("Times New Roman", 8F);
            this.xrLabel56.LocationFloat = new DevExpress.Utils.PointFloat(781.1918F, 0F);
            this.xrLabel56.Name = "xrLabel56";
            this.xrLabel56.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel56.SizeF = new System.Drawing.SizeF(90.40851F, 18F);
            this.xrLabel56.StylePriority.UseFont = false;
            this.xrLabel56.StylePriority.UseTextAlignment = false;
            this.xrLabel56.Text = "xrLabel56";
            this.xrLabel56.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.xrLabel56.WordWrap = false;
            // 
            // xrLabel57
            // 
            this.xrLabel57.CanGrow = false;
            this.xrLabel57.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.RetTotal", "{0:#,##0.00}")});
            this.xrLabel57.Font = new System.Drawing.Font("Times New Roman", 8F);
            this.xrLabel57.LocationFloat = new DevExpress.Utils.PointFloat(871.6003F, 0F);
            this.xrLabel57.Name = "xrLabel57";
            this.xrLabel57.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel57.SizeF = new System.Drawing.SizeF(93.7168F, 18F);
            this.xrLabel57.StylePriority.UseFont = false;
            this.xrLabel57.StylePriority.UseTextAlignment = false;
            this.xrLabel57.Text = "xrLabel57";
            this.xrLabel57.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.xrLabel57.WordWrap = false;
            // 
            // xrLabel58
            // 
            this.xrLabel58.CanGrow = false;
            this.xrLabel58.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.Total", "{0:#,##0.00}")});
            this.xrLabel58.Font = new System.Drawing.Font("Times New Roman", 8F);
            this.xrLabel58.LocationFloat = new DevExpress.Utils.PointFloat(319.6667F, 0F);
            this.xrLabel58.Name = "xrLabel58";
            this.xrLabel58.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel58.SizeF = new System.Drawing.SizeF(93.7168F, 18F);
            this.xrLabel58.StylePriority.UseFont = false;
            this.xrLabel58.StylePriority.UseTextAlignment = false;
            this.xrLabel58.Text = "xrLabel58";
            this.xrLabel58.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.xrLabel58.WordWrap = false;
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
            this.xrPageInfo3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.xrPageInfo3.Format = "Ημερομηνία Εκτύπωσης : {0:dddd, d MMMM yyyy h:mm:ss tt}";
            this.xrPageInfo3.LocationFloat = new DevExpress.Utils.PointFloat(6F, 38.23729F);
            this.xrPageInfo3.Name = "xrPageInfo3";
            this.xrPageInfo3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrPageInfo3.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime;
            this.xrPageInfo3.SizeF = new System.Drawing.SizeF(1050F, 18.76271F);
            this.xrPageInfo3.StylePriority.UseBorders = false;
            this.xrPageInfo3.StylePriority.UseFont = false;
            // 
            // BottomMargin
            // 
            this.BottomMargin.HeightF = 36F;
            this.BottomMargin.Name = "BottomMargin";
            this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrLabel70
            // 
            this.xrLabel70.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel70.CanGrow = false;
            this.xrLabel70.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.xrLabel70.LocationFloat = new DevExpress.Utils.PointFloat(6F, 22F);
            this.xrLabel70.Name = "xrLabel70";
            this.xrLabel70.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel70.SizeF = new System.Drawing.SizeF(222.6667F, 18F);
            this.xrLabel70.StylePriority.UseBorders = false;
            this.xrLabel70.StylePriority.UseFont = false;
            this.xrLabel70.Text = "Σύνολα Κατηγορίών";
            // 
            // groupHeaderBand1
            // 
            this.groupHeaderBand1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel1,
            this.xrLabel2,
            this.xrLabel3,
            this.xrLabel4,
            this.xrLabel5,
            this.xrLabel6,
            this.xrLabel7,
            this.xrLabel8,
            this.xrLabel9,
            this.xrLabel53,
            this.xrLabel15});
            this.groupHeaderBand1.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("Department", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.groupHeaderBand1.HeightF = 18F;
            this.groupHeaderBand1.Name = "groupHeaderBand1";
            this.groupHeaderBand1.StyleName = "DataField";
            this.groupHeaderBand1.Visible = false;
            // 
            // xrLabel1
            // 
            this.xrLabel1.CanGrow = false;
            this.xrLabel1.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.Total", "{0:C2}")});
            this.xrLabel1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.xrLabel1.ForeColor = System.Drawing.Color.Black;
            this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(319.6667F, 0F);
            this.xrLabel1.Name = "xrLabel1";
            this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel1.SizeF = new System.Drawing.SizeF(93.7168F, 18F);
            this.xrLabel1.StyleName = "FieldCaption";
            this.xrLabel1.StylePriority.UseFont = false;
            this.xrLabel1.StylePriority.UseForeColor = false;
            this.xrLabel1.StylePriority.UseTextAlignment = false;
            xrSummary1.FormatString = "{0:#,##0.00}";
            xrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
            this.xrLabel1.Summary = xrSummary1;
            this.xrLabel1.Text = "xrLabel46";
            this.xrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.xrLabel1.WordWrap = false;
            // 
            // xrLabel2
            // 
            this.xrLabel2.CanGrow = false;
            this.xrLabel2.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.CoplQTY")});
            this.xrLabel2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.xrLabel2.ForeColor = System.Drawing.Color.Black;
            this.xrLabel2.LocationFloat = new DevExpress.Utils.PointFloat(504.7909F, 0F);
            this.xrLabel2.Name = "xrLabel2";
            this.xrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel2.SizeF = new System.Drawing.SizeF(91F, 18F);
            this.xrLabel2.StyleName = "FieldCaption";
            this.xrLabel2.StylePriority.UseFont = false;
            this.xrLabel2.StylePriority.UseForeColor = false;
            this.xrLabel2.StylePriority.UseTextAlignment = false;
            xrSummary2.FormatString = "{0:0.##}";
            xrSummary2.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
            this.xrLabel2.Summary = xrSummary2;
            this.xrLabel2.Text = "xrLabel38";
            this.xrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.xrLabel2.WordWrap = false;
            // 
            // xrLabel3
            // 
            this.xrLabel3.CanGrow = false;
            this.xrLabel3.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.RetTotal", "{0:C2}")});
            this.xrLabel3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.xrLabel3.ForeColor = System.Drawing.Color.Black;
            this.xrLabel3.LocationFloat = new DevExpress.Utils.PointFloat(871.6003F, 0F);
            this.xrLabel3.Name = "xrLabel3";
            this.xrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel3.SizeF = new System.Drawing.SizeF(93.7168F, 18F);
            this.xrLabel3.StyleName = "FieldCaption";
            this.xrLabel3.StylePriority.UseFont = false;
            this.xrLabel3.StylePriority.UseForeColor = false;
            this.xrLabel3.StylePriority.UseTextAlignment = false;
            xrSummary3.FormatString = "{0:#,##0.00}";
            xrSummary3.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
            this.xrLabel3.Summary = xrSummary3;
            this.xrLabel3.Text = "xrLabel45";
            this.xrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.xrLabel3.WordWrap = false;
            // 
            // xrLabel4
            // 
            this.xrLabel4.CanGrow = false;
            this.xrLabel4.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.RetQTY")});
            this.xrLabel4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.xrLabel4.ForeColor = System.Drawing.Color.Black;
            this.xrLabel4.LocationFloat = new DevExpress.Utils.PointFloat(780.6003F, 0F);
            this.xrLabel4.Name = "xrLabel4";
            this.xrLabel4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel4.SizeF = new System.Drawing.SizeF(91F, 18F);
            this.xrLabel4.StyleName = "FieldCaption";
            this.xrLabel4.StylePriority.UseFont = false;
            this.xrLabel4.StylePriority.UseForeColor = false;
            this.xrLabel4.StylePriority.UseTextAlignment = false;
            xrSummary4.FormatString = "{0:0.##}";
            xrSummary4.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
            this.xrLabel4.Summary = xrSummary4;
            this.xrLabel4.Text = "xrLabel44";
            this.xrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.xrLabel4.WordWrap = false;
            // 
            // xrLabel5
            // 
            this.xrLabel5.CanGrow = false;
            this.xrLabel5.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.RetNet", "{0:C2}")});
            this.xrLabel5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.xrLabel5.ForeColor = System.Drawing.Color.Black;
            this.xrLabel5.LocationFloat = new DevExpress.Utils.PointFloat(965.3171F, 0F);
            this.xrLabel5.Name = "xrLabel5";
            this.xrLabel5.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel5.SizeF = new System.Drawing.SizeF(90.68292F, 18F);
            this.xrLabel5.StyleName = "FieldCaption";
            this.xrLabel5.StylePriority.UseFont = false;
            this.xrLabel5.StylePriority.UseForeColor = false;
            this.xrLabel5.StylePriority.UseTextAlignment = false;
            xrSummary5.FormatString = "{0:#,##0.00}";
            xrSummary5.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
            this.xrLabel5.Summary = xrSummary5;
            this.xrLabel5.Text = "xrLabel43";
            this.xrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.xrLabel5.WordWrap = false;
            // 
            // xrLabel6
            // 
            this.xrLabel6.CanGrow = false;
            this.xrLabel6.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.QTY")});
            this.xrLabel6.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.xrLabel6.ForeColor = System.Drawing.Color.Black;
            this.xrLabel6.LocationFloat = new DevExpress.Utils.PointFloat(229.1667F, 0F);
            this.xrLabel6.Name = "xrLabel6";
            this.xrLabel6.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel6.SizeF = new System.Drawing.SizeF(90.49998F, 18F);
            this.xrLabel6.StyleName = "FieldCaption";
            this.xrLabel6.StylePriority.UseFont = false;
            this.xrLabel6.StylePriority.UseForeColor = false;
            this.xrLabel6.StylePriority.UseTextAlignment = false;
            xrSummary6.FormatString = "{0:0.##}";
            xrSummary6.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
            this.xrLabel6.Summary = xrSummary6;
            this.xrLabel6.Text = "xrLabel42";
            this.xrLabel6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.xrLabel6.WordWrap = false;
            // 
            // xrLabel7
            // 
            this.xrLabel7.CanGrow = false;
            this.xrLabel7.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.Net", "{0:C2}")});
            this.xrLabel7.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.xrLabel7.ForeColor = System.Drawing.Color.Black;
            this.xrLabel7.LocationFloat = new DevExpress.Utils.PointFloat(413.3835F, 0F);
            this.xrLabel7.Name = "xrLabel7";
            this.xrLabel7.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel7.SizeF = new System.Drawing.SizeF(91F, 18F);
            this.xrLabel7.StyleName = "FieldCaption";
            this.xrLabel7.StylePriority.UseFont = false;
            this.xrLabel7.StylePriority.UseForeColor = false;
            this.xrLabel7.StylePriority.UseTextAlignment = false;
            xrSummary7.FormatString = "{0:#,##0.00}";
            xrSummary7.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
            this.xrLabel7.Summary = xrSummary7;
            this.xrLabel7.Text = "xrLabel41";
            this.xrLabel7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.xrLabel7.WordWrap = false;
            // 
            // xrLabel8
            // 
            this.xrLabel8.CanGrow = false;
            this.xrLabel8.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.CorplNet", "{0:C2}")});
            this.xrLabel8.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.xrLabel8.ForeColor = System.Drawing.Color.Black;
            this.xrLabel8.LocationFloat = new DevExpress.Utils.PointFloat(689.6003F, 0F);
            this.xrLabel8.Name = "xrLabel8";
            this.xrLabel8.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel8.SizeF = new System.Drawing.SizeF(91F, 18F);
            this.xrLabel8.StyleName = "FieldCaption";
            this.xrLabel8.StylePriority.UseFont = false;
            this.xrLabel8.StylePriority.UseForeColor = false;
            this.xrLabel8.StylePriority.UseTextAlignment = false;
            xrSummary8.FormatString = "{0:#,##0.00}";
            xrSummary8.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
            this.xrLabel8.Summary = xrSummary8;
            this.xrLabel8.Text = "xrLabel40";
            this.xrLabel8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.xrLabel8.WordWrap = false;
            // 
            // xrLabel9
            // 
            this.xrLabel9.CanGrow = false;
            this.xrLabel9.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.CoplTotal", "{0:C2}")});
            this.xrLabel9.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.xrLabel9.ForeColor = System.Drawing.Color.Black;
            this.xrLabel9.LocationFloat = new DevExpress.Utils.PointFloat(595.8835F, 0F);
            this.xrLabel9.Name = "xrLabel9";
            this.xrLabel9.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel9.SizeF = new System.Drawing.SizeF(93.7168F, 18F);
            this.xrLabel9.StyleName = "FieldCaption";
            this.xrLabel9.StylePriority.UseFont = false;
            this.xrLabel9.StylePriority.UseForeColor = false;
            this.xrLabel9.StylePriority.UseTextAlignment = false;
            xrSummary9.FormatString = "{0:#,##0.00}";
            xrSummary9.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
            this.xrLabel9.Summary = xrSummary9;
            this.xrLabel9.Text = "xrLabel39";
            this.xrLabel9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.xrLabel9.WordWrap = false;
            // 
            // xrLabel53
            // 
            this.xrLabel53.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel53.CanGrow = false;
            this.xrLabel53.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.Department")});
            this.xrLabel53.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.xrLabel53.LocationFloat = new DevExpress.Utils.PointFloat(117.4583F, 0F);
            this.xrLabel53.Name = "xrLabel53";
            this.xrLabel53.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel53.SizeF = new System.Drawing.SizeF(111.2084F, 18F);
            this.xrLabel53.StylePriority.UseBorders = false;
            this.xrLabel53.StylePriority.UseFont = false;
            this.xrLabel53.Text = "xrLabel53";
            this.xrLabel53.WordWrap = false;
            // 
            // xrLabel15
            // 
            this.xrLabel15.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel15.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.xrLabel15.LocationFloat = new DevExpress.Utils.PointFloat(6F, 0F);
            this.xrLabel15.Name = "xrLabel15";
            this.xrLabel15.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel15.SizeF = new System.Drawing.SizeF(111.4583F, 18F);
            this.xrLabel15.StylePriority.UseBorders = false;
            this.xrLabel15.StylePriority.UseFont = false;
            this.xrLabel15.Text = "Σύνολα Τμήματος";
            // 
            // xrLabel26
            // 
            this.xrLabel26.BackColor = System.Drawing.Color.DarkGray;
            this.xrLabel26.CanGrow = false;
            this.xrLabel26.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.ProductCategoryDescrtiption")});
            this.xrLabel26.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrLabel26.LocationFloat = new DevExpress.Utils.PointFloat(5.999985F, 0F);
            this.xrLabel26.Name = "xrLabel26";
            this.xrLabel26.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel26.SizeF = new System.Drawing.SizeF(222.6667F, 18F);
            this.xrLabel26.StylePriority.UseBackColor = false;
            this.xrLabel26.StylePriority.UseFont = false;
            this.xrLabel26.Text = "xrLabel26";
            this.xrLabel26.WordWrap = false;
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
            // xrLabel37
            // 
            this.xrLabel37.CanGrow = false;
            this.xrLabel37.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.ProductDescription")});
            this.xrLabel37.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.xrLabel37.LocationFloat = new DevExpress.Utils.PointFloat(6F, 0F);
            this.xrLabel37.Name = "xrLabel37";
            this.xrLabel37.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel37.SizeF = new System.Drawing.SizeF(222.6667F, 15F);
            this.xrLabel37.StylePriority.UseFont = false;
            this.xrLabel37.WordWrap = false;
            // 
            // xrLabel38
            // 
            this.xrLabel38.CanGrow = false;
            this.xrLabel38.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.CoplQTY")});
            this.xrLabel38.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.xrLabel38.ForeColor = System.Drawing.Color.Black;
            this.xrLabel38.LocationFloat = new DevExpress.Utils.PointFloat(505.8834F, 0F);
            this.xrLabel38.Name = "xrLabel38";
            this.xrLabel38.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel38.SizeF = new System.Drawing.SizeF(89.9075F, 15F);
            this.xrLabel38.StyleName = "FieldCaption";
            this.xrLabel38.StylePriority.UseFont = false;
            this.xrLabel38.StylePriority.UseForeColor = false;
            this.xrLabel38.StylePriority.UseTextAlignment = false;
            xrSummary10.FormatString = "{0:0.##}";
            xrSummary10.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
            this.xrLabel38.Summary = xrSummary10;
            this.xrLabel38.Text = "xrLabel38";
            this.xrLabel38.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.xrLabel38.WordWrap = false;
            // 
            // xrLabel45
            // 
            this.xrLabel45.CanGrow = false;
            this.xrLabel45.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.RetTotal", "{0:C2}")});
            this.xrLabel45.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.xrLabel45.ForeColor = System.Drawing.Color.Black;
            this.xrLabel45.LocationFloat = new DevExpress.Utils.PointFloat(871.6003F, 0F);
            this.xrLabel45.Name = "xrLabel45";
            this.xrLabel45.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel45.SizeF = new System.Drawing.SizeF(93.7168F, 15F);
            this.xrLabel45.StyleName = "FieldCaption";
            this.xrLabel45.StylePriority.UseFont = false;
            this.xrLabel45.StylePriority.UseForeColor = false;
            this.xrLabel45.StylePriority.UseTextAlignment = false;
            xrSummary11.FormatString = "{0:#,##0.00}";
            xrSummary11.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
            this.xrLabel45.Summary = xrSummary11;
            this.xrLabel45.Text = "xrLabel45";
            this.xrLabel45.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.xrLabel45.WordWrap = false;
            // 
            // xrLabel44
            // 
            this.xrLabel44.CanGrow = false;
            this.xrLabel44.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.RetQTY")});
            this.xrLabel44.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.xrLabel44.ForeColor = System.Drawing.Color.Black;
            this.xrLabel44.LocationFloat = new DevExpress.Utils.PointFloat(780.6003F, 0F);
            this.xrLabel44.Name = "xrLabel44";
            this.xrLabel44.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel44.SizeF = new System.Drawing.SizeF(91F, 15F);
            this.xrLabel44.StyleName = "FieldCaption";
            this.xrLabel44.StylePriority.UseFont = false;
            this.xrLabel44.StylePriority.UseForeColor = false;
            this.xrLabel44.StylePriority.UseTextAlignment = false;
            xrSummary12.FormatString = "{0:0.##}";
            xrSummary12.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
            this.xrLabel44.Summary = xrSummary12;
            this.xrLabel44.Text = "xrLabel44";
            this.xrLabel44.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.xrLabel44.WordWrap = false;
            // 
            // xrLabel43
            // 
            this.xrLabel43.CanGrow = false;
            this.xrLabel43.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.RetNet", "{0:C2}")});
            this.xrLabel43.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.xrLabel43.ForeColor = System.Drawing.Color.Black;
            this.xrLabel43.LocationFloat = new DevExpress.Utils.PointFloat(965.3171F, 0F);
            this.xrLabel43.Name = "xrLabel43";
            this.xrLabel43.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel43.SizeF = new System.Drawing.SizeF(91.00006F, 15F);
            this.xrLabel43.StyleName = "FieldCaption";
            this.xrLabel43.StylePriority.UseFont = false;
            this.xrLabel43.StylePriority.UseForeColor = false;
            this.xrLabel43.StylePriority.UseTextAlignment = false;
            xrSummary13.FormatString = "{0:#,##0.00}";
            xrSummary13.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
            this.xrLabel43.Summary = xrSummary13;
            this.xrLabel43.Text = "xrLabel43";
            this.xrLabel43.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.xrLabel43.WordWrap = false;
            // 
            // xrLabel42
            // 
            this.xrLabel42.CanGrow = false;
            this.xrLabel42.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.QTY")});
            this.xrLabel42.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.xrLabel42.ForeColor = System.Drawing.Color.Black;
            this.xrLabel42.LocationFloat = new DevExpress.Utils.PointFloat(229.1667F, 0F);
            this.xrLabel42.Name = "xrLabel42";
            this.xrLabel42.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel42.SizeF = new System.Drawing.SizeF(90.49998F, 15F);
            this.xrLabel42.StyleName = "FieldCaption";
            this.xrLabel42.StylePriority.UseFont = false;
            this.xrLabel42.StylePriority.UseForeColor = false;
            this.xrLabel42.StylePriority.UseTextAlignment = false;
            xrSummary14.FormatString = "{0:0.##}";
            xrSummary14.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
            this.xrLabel42.Summary = xrSummary14;
            this.xrLabel42.Text = "xrLabel42";
            this.xrLabel42.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.xrLabel42.WordWrap = false;
            // 
            // xrLabel41
            // 
            this.xrLabel41.CanGrow = false;
            this.xrLabel41.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.Net", "{0:C2}")});
            this.xrLabel41.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.xrLabel41.ForeColor = System.Drawing.Color.Black;
            this.xrLabel41.LocationFloat = new DevExpress.Utils.PointFloat(413.3835F, 0F);
            this.xrLabel41.Name = "xrLabel41";
            this.xrLabel41.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel41.SizeF = new System.Drawing.SizeF(92.49988F, 15F);
            this.xrLabel41.StyleName = "FieldCaption";
            this.xrLabel41.StylePriority.UseFont = false;
            this.xrLabel41.StylePriority.UseForeColor = false;
            this.xrLabel41.StylePriority.UseTextAlignment = false;
            xrSummary15.FormatString = "{0:#,##0.00}";
            xrSummary15.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
            this.xrLabel41.Summary = xrSummary15;
            this.xrLabel41.Text = "xrLabel41";
            this.xrLabel41.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.xrLabel41.WordWrap = false;
            // 
            // xrLabel40
            // 
            this.xrLabel40.CanGrow = false;
            this.xrLabel40.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.CorplNet", "{0:C2}")});
            this.xrLabel40.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.xrLabel40.ForeColor = System.Drawing.Color.Black;
            this.xrLabel40.LocationFloat = new DevExpress.Utils.PointFloat(689.6003F, 0F);
            this.xrLabel40.Name = "xrLabel40";
            this.xrLabel40.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel40.SizeF = new System.Drawing.SizeF(91F, 15F);
            this.xrLabel40.StyleName = "FieldCaption";
            this.xrLabel40.StylePriority.UseFont = false;
            this.xrLabel40.StylePriority.UseForeColor = false;
            this.xrLabel40.StylePriority.UseTextAlignment = false;
            xrSummary16.FormatString = "{0:#,##0.00}";
            xrSummary16.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
            this.xrLabel40.Summary = xrSummary16;
            this.xrLabel40.Text = "xrLabel40";
            this.xrLabel40.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.xrLabel40.WordWrap = false;
            // 
            // xrLabel39
            // 
            this.xrLabel39.CanGrow = false;
            this.xrLabel39.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.CoplTotal", "{0:C2}")});
            this.xrLabel39.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.xrLabel39.ForeColor = System.Drawing.Color.Black;
            this.xrLabel39.LocationFloat = new DevExpress.Utils.PointFloat(595.7909F, 0F);
            this.xrLabel39.Name = "xrLabel39";
            this.xrLabel39.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel39.SizeF = new System.Drawing.SizeF(93.80939F, 15F);
            this.xrLabel39.StyleName = "FieldCaption";
            this.xrLabel39.StylePriority.UseFont = false;
            this.xrLabel39.StylePriority.UseForeColor = false;
            this.xrLabel39.StylePriority.UseTextAlignment = false;
            xrSummary17.FormatString = "{0:#,##0.00}";
            xrSummary17.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
            this.xrLabel39.Summary = xrSummary17;
            this.xrLabel39.Text = "xrLabel39";
            this.xrLabel39.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.xrLabel39.WordWrap = false;
            // 
            // xrLabel46
            // 
            this.xrLabel46.CanGrow = false;
            this.xrLabel46.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.Total", "{0:C2}")});
            this.xrLabel46.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.xrLabel46.ForeColor = System.Drawing.Color.Black;
            this.xrLabel46.LocationFloat = new DevExpress.Utils.PointFloat(319.6667F, 0F);
            this.xrLabel46.Name = "xrLabel46";
            this.xrLabel46.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel46.SizeF = new System.Drawing.SizeF(93.7168F, 15F);
            this.xrLabel46.StyleName = "FieldCaption";
            this.xrLabel46.StylePriority.UseFont = false;
            this.xrLabel46.StylePriority.UseForeColor = false;
            this.xrLabel46.StylePriority.UseTextAlignment = false;
            xrSummary18.FormatString = "{0:#,##0.00}";
            xrSummary18.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
            this.xrLabel46.Summary = xrSummary18;
            this.xrLabel46.Text = "xrLabel46";
            this.xrLabel46.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.xrLabel46.WordWrap = false;
            // 
            // pageFooterBand1
            // 
            this.pageFooterBand1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrPageInfo2});
            this.pageFooterBand1.HeightF = 20.66663F;
            this.pageFooterBand1.Name = "pageFooterBand1";
            // 
            // xrPageInfo2
            // 
            this.xrPageInfo2.Borders = DevExpress.XtraPrinting.BorderSide.Top;
            this.xrPageInfo2.Format = "Σελίδα {0} από {1}";
            this.xrPageInfo2.LocationFloat = new DevExpress.Utils.PointFloat(6F, 0F);
            this.xrPageInfo2.Name = "xrPageInfo2";
            this.xrPageInfo2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrPageInfo2.SizeF = new System.Drawing.SizeF(1050F, 18F);
            this.xrPageInfo2.StyleName = "PageInfo";
            this.xrPageInfo2.StylePriority.UseBorders = false;
            this.xrPageInfo2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // reportHeaderBand1
            // 
            this.reportHeaderBand1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel18,
            this.xrLabel59});
            this.reportHeaderBand1.HeightF = 25.99999F;
            this.reportHeaderBand1.Name = "reportHeaderBand1";
            // 
            // xrLabel18
            // 
            this.xrLabel18.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel18.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding(this.ToDate, "Text", " έως {0})")});
            this.xrLabel18.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.xrLabel18.ForeColor = System.Drawing.Color.Black;
            this.xrLabel18.LocationFloat = new DevExpress.Utils.PointFloat(629.4751F, 1.999982F);
            this.xrLabel18.Name = "xrLabel18";
            this.xrLabel18.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel18.SizeF = new System.Drawing.SizeF(426.5249F, 23.375F);
            this.xrLabel18.StyleName = "Title";
            this.xrLabel18.StylePriority.UseBorders = false;
            this.xrLabel18.StylePriority.UseFont = false;
            this.xrLabel18.StylePriority.UseForeColor = false;
            this.xrLabel18.StylePriority.UseTextAlignment = false;
            this.xrLabel18.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrLabel59
            // 
            this.xrLabel59.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel59.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding(this.FromDate, "Text", "Καθαρές Αξίες Πωλήσεων (από {0}")});
            this.xrLabel59.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.xrLabel59.ForeColor = System.Drawing.Color.Black;
            this.xrLabel59.LocationFloat = new DevExpress.Utils.PointFloat(6F, 1.999982F);
            this.xrLabel59.Name = "xrLabel59";
            this.xrLabel59.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel59.SizeF = new System.Drawing.SizeF(623.4751F, 23.375F);
            this.xrLabel59.StyleName = "Title";
            this.xrLabel59.StylePriority.UseBorders = false;
            this.xrLabel59.StylePriority.UseFont = false;
            this.xrLabel59.StylePriority.UseForeColor = false;
            this.xrLabel59.StylePriority.UseTextAlignment = false;
            this.xrLabel59.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
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
            this.xrLabel60.BackColor = System.Drawing.Color.Silver;
            this.xrLabel60.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel60.CanGrow = false;
            this.xrLabel60.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.CoplQTY")});
            this.xrLabel60.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.xrLabel60.ForeColor = System.Drawing.Color.Black;
            this.xrLabel60.LocationFloat = new DevExpress.Utils.PointFloat(504.8835F, 6.00001F);
            this.xrLabel60.Name = "xrLabel60";
            this.xrLabel60.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel60.SizeF = new System.Drawing.SizeF(90.90738F, 18F);
            this.xrLabel60.StyleName = "FieldCaption";
            this.xrLabel60.StylePriority.UseBackColor = false;
            this.xrLabel60.StylePriority.UseBorders = false;
            this.xrLabel60.StylePriority.UseFont = false;
            this.xrLabel60.StylePriority.UseForeColor = false;
            this.xrLabel60.StylePriority.UseTextAlignment = false;
            xrSummary19.FormatString = "{0:0.##}";
            xrSummary19.Running = DevExpress.XtraReports.UI.SummaryRunning.Report;
            this.xrLabel60.Summary = xrSummary19;
            this.xrLabel60.Text = "xrLabel60";
            this.xrLabel60.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.xrLabel60.WordWrap = false;
            // 
            // xrLabel61
            // 
            this.xrLabel61.BackColor = System.Drawing.Color.Silver;
            this.xrLabel61.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel61.CanGrow = false;
            this.xrLabel61.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.CoplTotal", "{0:C2}")});
            this.xrLabel61.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.xrLabel61.ForeColor = System.Drawing.Color.Black;
            this.xrLabel61.LocationFloat = new DevExpress.Utils.PointFloat(595.7909F, 6.00001F);
            this.xrLabel61.Name = "xrLabel61";
            this.xrLabel61.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel61.SizeF = new System.Drawing.SizeF(93.80939F, 18F);
            this.xrLabel61.StyleName = "FieldCaption";
            this.xrLabel61.StylePriority.UseBackColor = false;
            this.xrLabel61.StylePriority.UseBorders = false;
            this.xrLabel61.StylePriority.UseFont = false;
            this.xrLabel61.StylePriority.UseForeColor = false;
            this.xrLabel61.StylePriority.UseTextAlignment = false;
            xrSummary20.FormatString = "{0:#,##0.00}";
            xrSummary20.Running = DevExpress.XtraReports.UI.SummaryRunning.Report;
            this.xrLabel61.Summary = xrSummary20;
            this.xrLabel61.Text = "xrLabel61";
            this.xrLabel61.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.xrLabel61.WordWrap = false;
            // 
            // xrLabel62
            // 
            this.xrLabel62.BackColor = System.Drawing.Color.Silver;
            this.xrLabel62.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel62.CanGrow = false;
            this.xrLabel62.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.CorplNet", "{0:C2}")});
            this.xrLabel62.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.xrLabel62.ForeColor = System.Drawing.Color.Black;
            this.xrLabel62.LocationFloat = new DevExpress.Utils.PointFloat(689.6003F, 6.00001F);
            this.xrLabel62.Name = "xrLabel62";
            this.xrLabel62.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel62.SizeF = new System.Drawing.SizeF(91F, 18F);
            this.xrLabel62.StyleName = "FieldCaption";
            this.xrLabel62.StylePriority.UseBackColor = false;
            this.xrLabel62.StylePriority.UseBorders = false;
            this.xrLabel62.StylePriority.UseFont = false;
            this.xrLabel62.StylePriority.UseForeColor = false;
            this.xrLabel62.StylePriority.UseTextAlignment = false;
            xrSummary21.FormatString = "{0:#,##0.00}";
            xrSummary21.Running = DevExpress.XtraReports.UI.SummaryRunning.Report;
            this.xrLabel62.Summary = xrSummary21;
            this.xrLabel62.Text = "xrLabel62";
            this.xrLabel62.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.xrLabel62.WordWrap = false;
            // 
            // xrLabel63
            // 
            this.xrLabel63.BackColor = System.Drawing.Color.Silver;
            this.xrLabel63.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel63.CanGrow = false;
            this.xrLabel63.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.Net", "{0:C2}")});
            this.xrLabel63.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.xrLabel63.ForeColor = System.Drawing.Color.Black;
            this.xrLabel63.LocationFloat = new DevExpress.Utils.PointFloat(413.3835F, 6.00001F);
            this.xrLabel63.Name = "xrLabel63";
            this.xrLabel63.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel63.SizeF = new System.Drawing.SizeF(91F, 18F);
            this.xrLabel63.StyleName = "FieldCaption";
            this.xrLabel63.StylePriority.UseBackColor = false;
            this.xrLabel63.StylePriority.UseBorders = false;
            this.xrLabel63.StylePriority.UseFont = false;
            this.xrLabel63.StylePriority.UseForeColor = false;
            this.xrLabel63.StylePriority.UseTextAlignment = false;
            xrSummary22.FormatString = "{0:#,##0.00}";
            xrSummary22.Running = DevExpress.XtraReports.UI.SummaryRunning.Report;
            this.xrLabel63.Summary = xrSummary22;
            this.xrLabel63.Text = "xrLabel63";
            this.xrLabel63.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.xrLabel63.WordWrap = false;
            // 
            // xrLabel64
            // 
            this.xrLabel64.BackColor = System.Drawing.Color.Silver;
            this.xrLabel64.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel64.CanGrow = false;
            this.xrLabel64.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.QTY")});
            this.xrLabel64.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.xrLabel64.ForeColor = System.Drawing.Color.Black;
            this.xrLabel64.LocationFloat = new DevExpress.Utils.PointFloat(228.6667F, 6.00001F);
            this.xrLabel64.Name = "xrLabel64";
            this.xrLabel64.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel64.SizeF = new System.Drawing.SizeF(90.99998F, 18F);
            this.xrLabel64.StyleName = "FieldCaption";
            this.xrLabel64.StylePriority.UseBackColor = false;
            this.xrLabel64.StylePriority.UseBorders = false;
            this.xrLabel64.StylePriority.UseFont = false;
            this.xrLabel64.StylePriority.UseForeColor = false;
            this.xrLabel64.StylePriority.UseTextAlignment = false;
            xrSummary23.FormatString = "{0:0.##}";
            xrSummary23.Running = DevExpress.XtraReports.UI.SummaryRunning.Report;
            this.xrLabel64.Summary = xrSummary23;
            this.xrLabel64.Text = "xrLabel64";
            this.xrLabel64.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.xrLabel64.WordWrap = false;
            // 
            // xrLabel65
            // 
            this.xrLabel65.BackColor = System.Drawing.Color.Silver;
            this.xrLabel65.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel65.CanGrow = false;
            this.xrLabel65.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.RetNet", "{0:C2}")});
            this.xrLabel65.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.xrLabel65.ForeColor = System.Drawing.Color.Black;
            this.xrLabel65.LocationFloat = new DevExpress.Utils.PointFloat(965.3171F, 6.00001F);
            this.xrLabel65.Name = "xrLabel65";
            this.xrLabel65.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel65.SizeF = new System.Drawing.SizeF(90.68292F, 18F);
            this.xrLabel65.StyleName = "FieldCaption";
            this.xrLabel65.StylePriority.UseBackColor = false;
            this.xrLabel65.StylePriority.UseBorders = false;
            this.xrLabel65.StylePriority.UseFont = false;
            this.xrLabel65.StylePriority.UseForeColor = false;
            this.xrLabel65.StylePriority.UseTextAlignment = false;
            xrSummary24.FormatString = "{0:#,##0.00}";
            xrSummary24.Running = DevExpress.XtraReports.UI.SummaryRunning.Report;
            this.xrLabel65.Summary = xrSummary24;
            this.xrLabel65.Text = "xrLabel65";
            this.xrLabel65.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.xrLabel65.WordWrap = false;
            // 
            // xrLabel66
            // 
            this.xrLabel66.BackColor = System.Drawing.Color.Silver;
            this.xrLabel66.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel66.CanGrow = false;
            this.xrLabel66.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.RetQTY")});
            this.xrLabel66.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.xrLabel66.ForeColor = System.Drawing.Color.Black;
            this.xrLabel66.LocationFloat = new DevExpress.Utils.PointFloat(780.6003F, 6.00001F);
            this.xrLabel66.Name = "xrLabel66";
            this.xrLabel66.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel66.SizeF = new System.Drawing.SizeF(91F, 18F);
            this.xrLabel66.StyleName = "FieldCaption";
            this.xrLabel66.StylePriority.UseBackColor = false;
            this.xrLabel66.StylePriority.UseBorders = false;
            this.xrLabel66.StylePriority.UseFont = false;
            this.xrLabel66.StylePriority.UseForeColor = false;
            this.xrLabel66.StylePriority.UseTextAlignment = false;
            xrSummary25.FormatString = "{0:0.##}";
            xrSummary25.Running = DevExpress.XtraReports.UI.SummaryRunning.Report;
            this.xrLabel66.Summary = xrSummary25;
            this.xrLabel66.Text = "xrLabel66";
            this.xrLabel66.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.xrLabel66.WordWrap = false;
            // 
            // xrLabel67
            // 
            this.xrLabel67.BackColor = System.Drawing.Color.Silver;
            this.xrLabel67.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel67.CanGrow = false;
            this.xrLabel67.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.RetTotal", "{0:C2}")});
            this.xrLabel67.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.xrLabel67.ForeColor = System.Drawing.Color.Black;
            this.xrLabel67.LocationFloat = new DevExpress.Utils.PointFloat(871.6003F, 6.00001F);
            this.xrLabel67.Name = "xrLabel67";
            this.xrLabel67.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel67.SizeF = new System.Drawing.SizeF(93.7168F, 18F);
            this.xrLabel67.StyleName = "FieldCaption";
            this.xrLabel67.StylePriority.UseBackColor = false;
            this.xrLabel67.StylePriority.UseBorders = false;
            this.xrLabel67.StylePriority.UseFont = false;
            this.xrLabel67.StylePriority.UseForeColor = false;
            this.xrLabel67.StylePriority.UseTextAlignment = false;
            xrSummary26.FormatString = "{0:#,##0.00}";
            xrSummary26.Running = DevExpress.XtraReports.UI.SummaryRunning.Report;
            this.xrLabel67.Summary = xrSummary26;
            this.xrLabel67.Text = "xrLabel67";
            this.xrLabel67.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.xrLabel67.WordWrap = false;
            // 
            // xrLabel68
            // 
            this.xrLabel68.BackColor = System.Drawing.Color.Silver;
            this.xrLabel68.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel68.CanGrow = false;
            this.xrLabel68.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.Total", "{0:C2}")});
            this.xrLabel68.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.xrLabel68.ForeColor = System.Drawing.Color.Black;
            this.xrLabel68.LocationFloat = new DevExpress.Utils.PointFloat(319.6667F, 6.00001F);
            this.xrLabel68.Name = "xrLabel68";
            this.xrLabel68.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel68.SizeF = new System.Drawing.SizeF(93.7168F, 18F);
            this.xrLabel68.StyleName = "FieldCaption";
            this.xrLabel68.StylePriority.UseBackColor = false;
            this.xrLabel68.StylePriority.UseBorders = false;
            this.xrLabel68.StylePriority.UseFont = false;
            this.xrLabel68.StylePriority.UseForeColor = false;
            this.xrLabel68.StylePriority.UseTextAlignment = false;
            xrSummary27.FormatString = "{0:#,##0.00}";
            xrSummary27.Running = DevExpress.XtraReports.UI.SummaryRunning.Report;
            this.xrLabel68.Summary = xrSummary27;
            this.xrLabel68.Text = "xrLabel68";
            this.xrLabel68.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.xrLabel68.WordWrap = false;
            // 
            // xrLabel69
            // 
            this.xrLabel69.BackColor = System.Drawing.Color.Silver;
            this.xrLabel69.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel69.CanGrow = false;
            this.xrLabel69.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.xrLabel69.ForeColor = System.Drawing.Color.Black;
            this.xrLabel69.LocationFloat = new DevExpress.Utils.PointFloat(6F, 6.00001F);
            this.xrLabel69.Name = "xrLabel69";
            this.xrLabel69.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel69.SizeF = new System.Drawing.SizeF(222.6667F, 18F);
            this.xrLabel69.StyleName = "FieldCaption";
            this.xrLabel69.StylePriority.UseBackColor = false;
            this.xrLabel69.StylePriority.UseBorders = false;
            this.xrLabel69.StylePriority.UseFont = false;
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
            // sqlDataSource2
            // 
            this.sqlDataSource2.ConnectionName = "ReportConnection";
            this.sqlDataSource2.Name = "sqlDataSource2";
            customSqlQuery6.Name = "Query";
            queryParameter3.Name = "FromDate";
            queryParameter3.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter3.Value = new DevExpress.DataAccess.Expression("[Parameters.FromDate]", typeof(System.DateTime));
            queryParameter4.Name = "ToDate";
            queryParameter4.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter4.Value = new DevExpress.DataAccess.Expression("[Parameters.ToDate]", typeof(System.DateTime));
            customSqlQuery6.Parameters.Add(queryParameter3);
            customSqlQuery6.Parameters.Add(queryParameter4);
            customSqlQuery6.Sql = resources.GetString("customSqlQuery6.Sql");
            customSqlQuery7.Name = "SunRepQuery";
            queryParameter5.Name = "FromDate";
            queryParameter5.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter5.Value = new DevExpress.DataAccess.Expression("[Parameters.FromDate]", typeof(System.DateTime));
            queryParameter6.Name = "ToDate";
            queryParameter6.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter6.Value = new DevExpress.DataAccess.Expression("[Parameters.ToDate]", typeof(System.DateTime));
            customSqlQuery7.Parameters.Add(queryParameter5);
            customSqlQuery7.Parameters.Add(queryParameter6);
            customSqlQuery7.Sql = resources.GetString("customSqlQuery7.Sql");
            this.sqlDataSource2.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            customSqlQuery6,
            customSqlQuery7});
            this.sqlDataSource2.ResultSchemaSerializable = resources.GetString("sqlDataSource2.ResultSchemaSerializable");
            // 
            // ProductGroupHeader
            // 
            this.ProductGroupHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel37,
            this.xrLabel39,
            this.xrLabel40,
            this.xrLabel41,
            this.xrLabel42,
            this.xrLabel43,
            this.xrLabel44,
            this.xrLabel45,
            this.xrLabel38,
            this.xrLabel46});
            this.ProductGroupHeader.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("ProductId", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.ProductGroupHeader.HeightF = 15F;
            this.ProductGroupHeader.Level = 1;
            this.ProductGroupHeader.Name = "ProductGroupHeader";
            this.ProductGroupHeader.StylePriority.UseBackColor = false;
            // 
            // ProductCategoryGroupHeader
            // 
            this.ProductCategoryGroupHeader.BackColor = System.Drawing.Color.Gray;
            this.ProductCategoryGroupHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel71,
            this.xrLabel72,
            this.xrLabel73,
            this.xrLabel74,
            this.xrLabel75,
            this.xrLabel76,
            this.xrLabel77,
            this.xrLabel78,
            this.xrLabel79,
            this.xrLabel26});
            this.ProductCategoryGroupHeader.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("ProductCategoryDescrtiption", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.ProductCategoryGroupHeader.HeightF = 18F;
            this.ProductCategoryGroupHeader.Level = 2;
            this.ProductCategoryGroupHeader.Name = "ProductCategoryGroupHeader";
            this.ProductCategoryGroupHeader.StylePriority.UseBackColor = false;
            // 
            // xrLabel71
            // 
            this.xrLabel71.BackColor = System.Drawing.Color.DarkGray;
            this.xrLabel71.CanGrow = false;
            this.xrLabel71.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.Total", "{0:C2}")});
            this.xrLabel71.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.xrLabel71.ForeColor = System.Drawing.Color.Black;
            this.xrLabel71.LocationFloat = new DevExpress.Utils.PointFloat(319.6667F, 0F);
            this.xrLabel71.Name = "xrLabel71";
            this.xrLabel71.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel71.SizeF = new System.Drawing.SizeF(93.7168F, 18F);
            this.xrLabel71.StyleName = "FieldCaption";
            this.xrLabel71.StylePriority.UseBackColor = false;
            this.xrLabel71.StylePriority.UseFont = false;
            this.xrLabel71.StylePriority.UseForeColor = false;
            this.xrLabel71.StylePriority.UseTextAlignment = false;
            xrSummary28.FormatString = "{0:#,##0.00}";
            xrSummary28.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
            this.xrLabel71.Summary = xrSummary28;
            this.xrLabel71.Text = "xrLabel46";
            this.xrLabel71.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.xrLabel71.WordWrap = false;
            // 
            // xrLabel72
            // 
            this.xrLabel72.BackColor = System.Drawing.Color.DarkGray;
            this.xrLabel72.CanGrow = false;
            this.xrLabel72.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.CoplQTY")});
            this.xrLabel72.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.xrLabel72.ForeColor = System.Drawing.Color.Black;
            this.xrLabel72.LocationFloat = new DevExpress.Utils.PointFloat(504.7909F, 0F);
            this.xrLabel72.Name = "xrLabel72";
            this.xrLabel72.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel72.SizeF = new System.Drawing.SizeF(91F, 18F);
            this.xrLabel72.StyleName = "FieldCaption";
            this.xrLabel72.StylePriority.UseBackColor = false;
            this.xrLabel72.StylePriority.UseFont = false;
            this.xrLabel72.StylePriority.UseForeColor = false;
            this.xrLabel72.StylePriority.UseTextAlignment = false;
            xrSummary29.FormatString = "{0:0.##}";
            xrSummary29.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
            this.xrLabel72.Summary = xrSummary29;
            this.xrLabel72.Text = "xrLabel38";
            this.xrLabel72.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.xrLabel72.WordWrap = false;
            // 
            // xrLabel73
            // 
            this.xrLabel73.BackColor = System.Drawing.Color.DarkGray;
            this.xrLabel73.CanGrow = false;
            this.xrLabel73.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.RetTotal", "{0:C2}")});
            this.xrLabel73.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.xrLabel73.ForeColor = System.Drawing.Color.Black;
            this.xrLabel73.LocationFloat = new DevExpress.Utils.PointFloat(871.6003F, 0F);
            this.xrLabel73.Name = "xrLabel73";
            this.xrLabel73.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel73.SizeF = new System.Drawing.SizeF(93.7168F, 18F);
            this.xrLabel73.StyleName = "FieldCaption";
            this.xrLabel73.StylePriority.UseBackColor = false;
            this.xrLabel73.StylePriority.UseFont = false;
            this.xrLabel73.StylePriority.UseForeColor = false;
            this.xrLabel73.StylePriority.UseTextAlignment = false;
            xrSummary30.FormatString = "{0:#,##0.00}";
            xrSummary30.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
            this.xrLabel73.Summary = xrSummary30;
            this.xrLabel73.Text = "xrLabel45";
            this.xrLabel73.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.xrLabel73.WordWrap = false;
            // 
            // xrLabel74
            // 
            this.xrLabel74.BackColor = System.Drawing.Color.DarkGray;
            this.xrLabel74.CanGrow = false;
            this.xrLabel74.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.RetQTY")});
            this.xrLabel74.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.xrLabel74.ForeColor = System.Drawing.Color.Black;
            this.xrLabel74.LocationFloat = new DevExpress.Utils.PointFloat(780.6003F, 0F);
            this.xrLabel74.Name = "xrLabel74";
            this.xrLabel74.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel74.SizeF = new System.Drawing.SizeF(91F, 18F);
            this.xrLabel74.StyleName = "FieldCaption";
            this.xrLabel74.StylePriority.UseBackColor = false;
            this.xrLabel74.StylePriority.UseFont = false;
            this.xrLabel74.StylePriority.UseForeColor = false;
            this.xrLabel74.StylePriority.UseTextAlignment = false;
            xrSummary31.FormatString = "{0:0.##}";
            xrSummary31.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
            this.xrLabel74.Summary = xrSummary31;
            this.xrLabel74.Text = "xrLabel44";
            this.xrLabel74.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.xrLabel74.WordWrap = false;
            // 
            // xrLabel75
            // 
            this.xrLabel75.BackColor = System.Drawing.Color.DarkGray;
            this.xrLabel75.CanGrow = false;
            this.xrLabel75.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.RetNet", "{0:C2}")});
            this.xrLabel75.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.xrLabel75.ForeColor = System.Drawing.Color.Black;
            this.xrLabel75.LocationFloat = new DevExpress.Utils.PointFloat(965.3171F, 0F);
            this.xrLabel75.Name = "xrLabel75";
            this.xrLabel75.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel75.SizeF = new System.Drawing.SizeF(90.68292F, 18F);
            this.xrLabel75.StyleName = "FieldCaption";
            this.xrLabel75.StylePriority.UseBackColor = false;
            this.xrLabel75.StylePriority.UseFont = false;
            this.xrLabel75.StylePriority.UseForeColor = false;
            this.xrLabel75.StylePriority.UseTextAlignment = false;
            xrSummary32.FormatString = "{0:#,##0.00}";
            xrSummary32.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
            this.xrLabel75.Summary = xrSummary32;
            this.xrLabel75.Text = "xrLabel43";
            this.xrLabel75.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.xrLabel75.WordWrap = false;
            // 
            // xrLabel76
            // 
            this.xrLabel76.BackColor = System.Drawing.Color.DarkGray;
            this.xrLabel76.CanGrow = false;
            this.xrLabel76.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.QTY")});
            this.xrLabel76.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.xrLabel76.ForeColor = System.Drawing.Color.Black;
            this.xrLabel76.LocationFloat = new DevExpress.Utils.PointFloat(228.6667F, 0F);
            this.xrLabel76.Name = "xrLabel76";
            this.xrLabel76.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel76.SizeF = new System.Drawing.SizeF(90.99998F, 18F);
            this.xrLabel76.StyleName = "FieldCaption";
            this.xrLabel76.StylePriority.UseBackColor = false;
            this.xrLabel76.StylePriority.UseFont = false;
            this.xrLabel76.StylePriority.UseForeColor = false;
            this.xrLabel76.StylePriority.UseTextAlignment = false;
            xrSummary33.FormatString = "{0:0.##}";
            xrSummary33.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
            this.xrLabel76.Summary = xrSummary33;
            this.xrLabel76.Text = "xrLabel42";
            this.xrLabel76.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.xrLabel76.WordWrap = false;
            // 
            // xrLabel77
            // 
            this.xrLabel77.BackColor = System.Drawing.Color.DarkGray;
            this.xrLabel77.CanGrow = false;
            this.xrLabel77.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.Net", "{0:C2}")});
            this.xrLabel77.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.xrLabel77.ForeColor = System.Drawing.Color.Black;
            this.xrLabel77.LocationFloat = new DevExpress.Utils.PointFloat(413.3835F, 0F);
            this.xrLabel77.Name = "xrLabel77";
            this.xrLabel77.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel77.SizeF = new System.Drawing.SizeF(91F, 18F);
            this.xrLabel77.StyleName = "FieldCaption";
            this.xrLabel77.StylePriority.UseBackColor = false;
            this.xrLabel77.StylePriority.UseFont = false;
            this.xrLabel77.StylePriority.UseForeColor = false;
            this.xrLabel77.StylePriority.UseTextAlignment = false;
            xrSummary34.FormatString = "{0:#,##0.00}";
            xrSummary34.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
            this.xrLabel77.Summary = xrSummary34;
            this.xrLabel77.Text = "xrLabel41";
            this.xrLabel77.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.xrLabel77.WordWrap = false;
            // 
            // xrLabel78
            // 
            this.xrLabel78.BackColor = System.Drawing.Color.DarkGray;
            this.xrLabel78.CanGrow = false;
            this.xrLabel78.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.CorplNet", "{0:C2}")});
            this.xrLabel78.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.xrLabel78.ForeColor = System.Drawing.Color.Black;
            this.xrLabel78.LocationFloat = new DevExpress.Utils.PointFloat(689.6003F, 0F);
            this.xrLabel78.Name = "xrLabel78";
            this.xrLabel78.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel78.SizeF = new System.Drawing.SizeF(91F, 18F);
            this.xrLabel78.StyleName = "FieldCaption";
            this.xrLabel78.StylePriority.UseBackColor = false;
            this.xrLabel78.StylePriority.UseFont = false;
            this.xrLabel78.StylePriority.UseForeColor = false;
            this.xrLabel78.StylePriority.UseTextAlignment = false;
            xrSummary35.FormatString = "{0:#,##0.00}";
            xrSummary35.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
            this.xrLabel78.Summary = xrSummary35;
            this.xrLabel78.Text = "xrLabel40";
            this.xrLabel78.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.xrLabel78.WordWrap = false;
            // 
            // xrLabel79
            // 
            this.xrLabel79.BackColor = System.Drawing.Color.DarkGray;
            this.xrLabel79.CanGrow = false;
            this.xrLabel79.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.CoplTotal", "{0:C2}")});
            this.xrLabel79.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.xrLabel79.ForeColor = System.Drawing.Color.Black;
            this.xrLabel79.LocationFloat = new DevExpress.Utils.PointFloat(595.7909F, 0F);
            this.xrLabel79.Name = "xrLabel79";
            this.xrLabel79.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel79.SizeF = new System.Drawing.SizeF(93.80939F, 18F);
            this.xrLabel79.StyleName = "FieldCaption";
            this.xrLabel79.StylePriority.UseBackColor = false;
            this.xrLabel79.StylePriority.UseFont = false;
            this.xrLabel79.StylePriority.UseForeColor = false;
            this.xrLabel79.StylePriority.UseTextAlignment = false;
            xrSummary36.FormatString = "{0:#,##0.00}";
            xrSummary36.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
            this.xrLabel79.Summary = xrSummary36;
            this.xrLabel79.Text = "xrLabel39";
            this.xrLabel79.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.xrLabel79.WordWrap = false;
            // 
            // CategoryGroupHeader
            // 
            this.CategoryGroupHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel80,
            this.xrLabel81,
            this.xrLabel82,
            this.xrLabel83,
            this.xrLabel84,
            this.xrLabel85,
            this.xrLabel86,
            this.xrLabel87,
            this.xrLabel88,
            this.xrLabel89});
            this.CategoryGroupHeader.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("CategoryId", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.CategoryGroupHeader.HeightF = 18F;
            this.CategoryGroupHeader.Level = 3;
            this.CategoryGroupHeader.Name = "CategoryGroupHeader";
            // 
            // xrLabel80
            // 
            this.xrLabel80.BackColor = System.Drawing.Color.Gray;
            this.xrLabel80.CanGrow = false;
            this.xrLabel80.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.CategoryDescription")});
            this.xrLabel80.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrLabel80.LocationFloat = new DevExpress.Utils.PointFloat(5.999985F, 0F);
            this.xrLabel80.Name = "xrLabel80";
            this.xrLabel80.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel80.SizeF = new System.Drawing.SizeF(222.6667F, 18F);
            this.xrLabel80.StylePriority.UseBackColor = false;
            this.xrLabel80.StylePriority.UseFont = false;
            this.xrLabel80.StylePriority.UseTextAlignment = false;
            this.xrLabel80.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrLabel80.WordWrap = false;
            // 
            // xrLabel81
            // 
            this.xrLabel81.BackColor = System.Drawing.Color.Gray;
            this.xrLabel81.CanGrow = false;
            this.xrLabel81.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.CoplTotal", "{0:C2}")});
            this.xrLabel81.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.xrLabel81.ForeColor = System.Drawing.Color.Black;
            this.xrLabel81.LocationFloat = new DevExpress.Utils.PointFloat(595.7909F, 0F);
            this.xrLabel81.Name = "xrLabel81";
            this.xrLabel81.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel81.SizeF = new System.Drawing.SizeF(93.80939F, 18F);
            this.xrLabel81.StyleName = "FieldCaption";
            this.xrLabel81.StylePriority.UseBackColor = false;
            this.xrLabel81.StylePriority.UseFont = false;
            this.xrLabel81.StylePriority.UseForeColor = false;
            this.xrLabel81.StylePriority.UseTextAlignment = false;
            xrSummary37.FormatString = "{0:#,##0.00}";
            xrSummary37.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
            this.xrLabel81.Summary = xrSummary37;
            this.xrLabel81.Text = "xrLabel39";
            this.xrLabel81.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrLabel81.WordWrap = false;
            // 
            // xrLabel82
            // 
            this.xrLabel82.BackColor = System.Drawing.Color.Gray;
            this.xrLabel82.CanGrow = false;
            this.xrLabel82.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.CorplNet", "{0:C2}")});
            this.xrLabel82.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.xrLabel82.ForeColor = System.Drawing.Color.Black;
            this.xrLabel82.LocationFloat = new DevExpress.Utils.PointFloat(689.6003F, 0F);
            this.xrLabel82.Name = "xrLabel82";
            this.xrLabel82.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel82.SizeF = new System.Drawing.SizeF(91F, 18F);
            this.xrLabel82.StyleName = "FieldCaption";
            this.xrLabel82.StylePriority.UseBackColor = false;
            this.xrLabel82.StylePriority.UseFont = false;
            this.xrLabel82.StylePriority.UseForeColor = false;
            this.xrLabel82.StylePriority.UseTextAlignment = false;
            xrSummary38.FormatString = "{0:#,##0.00}";
            xrSummary38.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
            this.xrLabel82.Summary = xrSummary38;
            this.xrLabel82.Text = "xrLabel40";
            this.xrLabel82.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrLabel82.WordWrap = false;
            // 
            // xrLabel83
            // 
            this.xrLabel83.BackColor = System.Drawing.Color.Gray;
            this.xrLabel83.CanGrow = false;
            this.xrLabel83.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.Net", "{0:C2}")});
            this.xrLabel83.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.xrLabel83.ForeColor = System.Drawing.Color.Black;
            this.xrLabel83.LocationFloat = new DevExpress.Utils.PointFloat(413.3835F, 0F);
            this.xrLabel83.Name = "xrLabel83";
            this.xrLabel83.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel83.SizeF = new System.Drawing.SizeF(91F, 18F);
            this.xrLabel83.StyleName = "FieldCaption";
            this.xrLabel83.StylePriority.UseBackColor = false;
            this.xrLabel83.StylePriority.UseFont = false;
            this.xrLabel83.StylePriority.UseForeColor = false;
            this.xrLabel83.StylePriority.UseTextAlignment = false;
            xrSummary39.FormatString = "{0:#,##0.00}";
            xrSummary39.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
            this.xrLabel83.Summary = xrSummary39;
            this.xrLabel83.Text = "xrLabel41";
            this.xrLabel83.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrLabel83.WordWrap = false;
            // 
            // xrLabel84
            // 
            this.xrLabel84.BackColor = System.Drawing.Color.Gray;
            this.xrLabel84.CanGrow = false;
            this.xrLabel84.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.QTY")});
            this.xrLabel84.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.xrLabel84.ForeColor = System.Drawing.Color.Black;
            this.xrLabel84.LocationFloat = new DevExpress.Utils.PointFloat(228.6667F, 0F);
            this.xrLabel84.Name = "xrLabel84";
            this.xrLabel84.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel84.SizeF = new System.Drawing.SizeF(90.99998F, 18F);
            this.xrLabel84.StyleName = "FieldCaption";
            this.xrLabel84.StylePriority.UseBackColor = false;
            this.xrLabel84.StylePriority.UseFont = false;
            this.xrLabel84.StylePriority.UseForeColor = false;
            this.xrLabel84.StylePriority.UseTextAlignment = false;
            xrSummary40.FormatString = "{0:0.##}";
            xrSummary40.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
            this.xrLabel84.Summary = xrSummary40;
            this.xrLabel84.Text = "xrLabel42";
            this.xrLabel84.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrLabel84.WordWrap = false;
            // 
            // xrLabel85
            // 
            this.xrLabel85.BackColor = System.Drawing.Color.Gray;
            this.xrLabel85.CanGrow = false;
            this.xrLabel85.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.RetNet", "{0:C2}")});
            this.xrLabel85.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.xrLabel85.ForeColor = System.Drawing.Color.Black;
            this.xrLabel85.LocationFloat = new DevExpress.Utils.PointFloat(965.3171F, 0F);
            this.xrLabel85.Name = "xrLabel85";
            this.xrLabel85.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel85.SizeF = new System.Drawing.SizeF(90.68292F, 18F);
            this.xrLabel85.StyleName = "FieldCaption";
            this.xrLabel85.StylePriority.UseBackColor = false;
            this.xrLabel85.StylePriority.UseFont = false;
            this.xrLabel85.StylePriority.UseForeColor = false;
            this.xrLabel85.StylePriority.UseTextAlignment = false;
            xrSummary41.FormatString = "{0:#,##0.00}";
            xrSummary41.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
            this.xrLabel85.Summary = xrSummary41;
            this.xrLabel85.Text = "xrLabel43";
            this.xrLabel85.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrLabel85.WordWrap = false;
            // 
            // xrLabel86
            // 
            this.xrLabel86.BackColor = System.Drawing.Color.Gray;
            this.xrLabel86.CanGrow = false;
            this.xrLabel86.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.RetQTY")});
            this.xrLabel86.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.xrLabel86.ForeColor = System.Drawing.Color.Black;
            this.xrLabel86.LocationFloat = new DevExpress.Utils.PointFloat(780.6003F, 0F);
            this.xrLabel86.Name = "xrLabel86";
            this.xrLabel86.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel86.SizeF = new System.Drawing.SizeF(91F, 18F);
            this.xrLabel86.StyleName = "FieldCaption";
            this.xrLabel86.StylePriority.UseBackColor = false;
            this.xrLabel86.StylePriority.UseFont = false;
            this.xrLabel86.StylePriority.UseForeColor = false;
            this.xrLabel86.StylePriority.UseTextAlignment = false;
            xrSummary42.FormatString = "{0:0.##}";
            xrSummary42.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
            this.xrLabel86.Summary = xrSummary42;
            this.xrLabel86.Text = "xrLabel44";
            this.xrLabel86.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrLabel86.WordWrap = false;
            // 
            // xrLabel87
            // 
            this.xrLabel87.BackColor = System.Drawing.Color.Gray;
            this.xrLabel87.CanGrow = false;
            this.xrLabel87.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.RetTotal", "{0:C2}")});
            this.xrLabel87.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.xrLabel87.ForeColor = System.Drawing.Color.Black;
            this.xrLabel87.LocationFloat = new DevExpress.Utils.PointFloat(871.6003F, 0F);
            this.xrLabel87.Name = "xrLabel87";
            this.xrLabel87.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel87.SizeF = new System.Drawing.SizeF(93.7168F, 18F);
            this.xrLabel87.StyleName = "FieldCaption";
            this.xrLabel87.StylePriority.UseBackColor = false;
            this.xrLabel87.StylePriority.UseFont = false;
            this.xrLabel87.StylePriority.UseForeColor = false;
            this.xrLabel87.StylePriority.UseTextAlignment = false;
            xrSummary43.FormatString = "{0:#,##0.00}";
            xrSummary43.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
            this.xrLabel87.Summary = xrSummary43;
            this.xrLabel87.Text = "xrLabel45";
            this.xrLabel87.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrLabel87.WordWrap = false;
            // 
            // xrLabel88
            // 
            this.xrLabel88.BackColor = System.Drawing.Color.Gray;
            this.xrLabel88.CanGrow = false;
            this.xrLabel88.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.CoplQTY")});
            this.xrLabel88.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.xrLabel88.ForeColor = System.Drawing.Color.Black;
            this.xrLabel88.LocationFloat = new DevExpress.Utils.PointFloat(504.7909F, 0F);
            this.xrLabel88.Name = "xrLabel88";
            this.xrLabel88.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel88.SizeF = new System.Drawing.SizeF(91F, 18F);
            this.xrLabel88.StyleName = "FieldCaption";
            this.xrLabel88.StylePriority.UseBackColor = false;
            this.xrLabel88.StylePriority.UseFont = false;
            this.xrLabel88.StylePriority.UseForeColor = false;
            this.xrLabel88.StylePriority.UseTextAlignment = false;
            xrSummary44.FormatString = "{0:0.##}";
            xrSummary44.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
            this.xrLabel88.Summary = xrSummary44;
            this.xrLabel88.Text = "xrLabel38";
            this.xrLabel88.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrLabel88.WordWrap = false;
            // 
            // xrLabel89
            // 
            this.xrLabel89.BackColor = System.Drawing.Color.Gray;
            this.xrLabel89.CanGrow = false;
            this.xrLabel89.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.Total", "{0:C2}")});
            this.xrLabel89.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.xrLabel89.ForeColor = System.Drawing.Color.Black;
            this.xrLabel89.LocationFloat = new DevExpress.Utils.PointFloat(319.6667F, 0F);
            this.xrLabel89.Name = "xrLabel89";
            this.xrLabel89.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel89.SizeF = new System.Drawing.SizeF(93.7168F, 18F);
            this.xrLabel89.StyleName = "FieldCaption";
            this.xrLabel89.StylePriority.UseBackColor = false;
            this.xrLabel89.StylePriority.UseFont = false;
            this.xrLabel89.StylePriority.UseForeColor = false;
            this.xrLabel89.StylePriority.UseTextAlignment = false;
            xrSummary45.FormatString = "{0:#,##0.00}";
            xrSummary45.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
            this.xrLabel89.Summary = xrSummary45;
            this.xrLabel89.Text = "xrLabel46";
            this.xrLabel89.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrLabel89.WordWrap = false;
            // 
            // DepartmentGroupHeader
            // 
            this.DepartmentGroupHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel14,
            this.xrLabel16,
            this.xrLabel17,
            this.xrLabel10,
            this.xrLabel12,
            this.xrLabel13,
            this.xrLabel19,
            this.xrLabel20,
            this.xrLabel21,
            this.xrLabel22,
            this.xrLabel23,
            this.xrLabel24,
            this.xrLabel25,
            this.xrLabel27,
            this.xrLabel28,
            this.xrLabel11,
            this.xrLine3,
            this.xrLine5,
            this.xrLabel90,
            this.xrLabel91,
            this.xrLabel92,
            this.xrLabel93,
            this.xrLabel94,
            this.xrLabel98,
            this.xrLabel102,
            this.xrSubreport1,
            this.xrLabel70});
            this.DepartmentGroupHeader.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("DepartmentId", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.DepartmentGroupHeader.HeightF = 130.9167F;
            this.DepartmentGroupHeader.KeepTogether = true;
            this.DepartmentGroupHeader.Level = 4;
            this.DepartmentGroupHeader.Name = "DepartmentGroupHeader";
            // 
            // xrLabel14
            // 
            this.xrLabel14.Font = new System.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
            this.xrLabel14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.xrLabel14.LocationFloat = new DevExpress.Utils.PointFloat(780.6003F, 115.9167F);
            this.xrLabel14.Name = "xrLabel14";
            this.xrLabel14.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel14.SizeF = new System.Drawing.SizeF(91F, 13F);
            this.xrLabel14.StylePriority.UseFont = false;
            this.xrLabel14.StylePriority.UseForeColor = false;
            this.xrLabel14.StylePriority.UseTextAlignment = false;
            this.xrLabel14.Text = "Ποσότητα";
            this.xrLabel14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // xrLabel16
            // 
            this.xrLabel16.Font = new System.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
            this.xrLabel16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.xrLabel16.LocationFloat = new DevExpress.Utils.PointFloat(871.6003F, 115.9167F);
            this.xrLabel16.Name = "xrLabel16";
            this.xrLabel16.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel16.SizeF = new System.Drawing.SizeF(93.7168F, 13F);
            this.xrLabel16.StylePriority.UseFont = false;
            this.xrLabel16.StylePriority.UseForeColor = false;
            this.xrLabel16.StylePriority.UseTextAlignment = false;
            this.xrLabel16.Text = "Αξια";
            this.xrLabel16.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // xrLabel17
            // 
            this.xrLabel17.Font = new System.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
            this.xrLabel17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.xrLabel17.LocationFloat = new DevExpress.Utils.PointFloat(965.3171F, 115.9167F);
            this.xrLabel17.Name = "xrLabel17";
            this.xrLabel17.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel17.SizeF = new System.Drawing.SizeF(91F, 13F);
            this.xrLabel17.StylePriority.UseFont = false;
            this.xrLabel17.StylePriority.UseForeColor = false;
            this.xrLabel17.StylePriority.UseTextAlignment = false;
            this.xrLabel17.Text = "Καθαρή Αξία";
            this.xrLabel17.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // xrLabel10
            // 
            this.xrLabel10.Font = new System.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
            this.xrLabel10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.xrLabel10.LocationFloat = new DevExpress.Utils.PointFloat(504.7909F, 115.9167F);
            this.xrLabel10.Name = "xrLabel10";
            this.xrLabel10.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel10.SizeF = new System.Drawing.SizeF(91F, 13F);
            this.xrLabel10.StylePriority.UseFont = false;
            this.xrLabel10.StylePriority.UseForeColor = false;
            this.xrLabel10.StylePriority.UseTextAlignment = false;
            this.xrLabel10.Text = "Ποσότητα";
            this.xrLabel10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // xrLabel12
            // 
            this.xrLabel12.Font = new System.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
            this.xrLabel12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.xrLabel12.LocationFloat = new DevExpress.Utils.PointFloat(595.8835F, 115.9167F);
            this.xrLabel12.Name = "xrLabel12";
            this.xrLabel12.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel12.SizeF = new System.Drawing.SizeF(93.7168F, 13F);
            this.xrLabel12.StylePriority.UseFont = false;
            this.xrLabel12.StylePriority.UseForeColor = false;
            this.xrLabel12.StylePriority.UseTextAlignment = false;
            this.xrLabel12.Text = "Αξια";
            this.xrLabel12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // xrLabel13
            // 
            this.xrLabel13.Font = new System.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
            this.xrLabel13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.xrLabel13.LocationFloat = new DevExpress.Utils.PointFloat(689.6003F, 115.9167F);
            this.xrLabel13.Name = "xrLabel13";
            this.xrLabel13.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel13.SizeF = new System.Drawing.SizeF(91F, 13F);
            this.xrLabel13.StylePriority.UseFont = false;
            this.xrLabel13.StylePriority.UseForeColor = false;
            this.xrLabel13.StylePriority.UseTextAlignment = false;
            this.xrLabel13.Text = "Καθαρή Αξία";
            this.xrLabel13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // xrLabel19
            // 
            this.xrLabel19.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel19.CanGrow = false;
            this.xrLabel19.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.Total", "{0:C2}")});
            this.xrLabel19.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.xrLabel19.ForeColor = System.Drawing.Color.Black;
            this.xrLabel19.LocationFloat = new DevExpress.Utils.PointFloat(319.6667F, 22F);
            this.xrLabel19.Name = "xrLabel19";
            this.xrLabel19.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel19.SizeF = new System.Drawing.SizeF(93.7168F, 18F);
            this.xrLabel19.StyleName = "FieldCaption";
            this.xrLabel19.StylePriority.UseBorders = false;
            this.xrLabel19.StylePriority.UseFont = false;
            this.xrLabel19.StylePriority.UseForeColor = false;
            this.xrLabel19.StylePriority.UseTextAlignment = false;
            xrSummary46.FormatString = "{0:#,##0.00}";
            xrSummary46.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
            this.xrLabel19.Summary = xrSummary46;
            this.xrLabel19.Text = "xrLabel46";
            this.xrLabel19.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.xrLabel19.WordWrap = false;
            // 
            // xrLabel20
            // 
            this.xrLabel20.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel20.CanGrow = false;
            this.xrLabel20.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.CoplQTY")});
            this.xrLabel20.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.xrLabel20.ForeColor = System.Drawing.Color.Black;
            this.xrLabel20.LocationFloat = new DevExpress.Utils.PointFloat(504.8835F, 22F);
            this.xrLabel20.Name = "xrLabel20";
            this.xrLabel20.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel20.SizeF = new System.Drawing.SizeF(90.90735F, 18F);
            this.xrLabel20.StyleName = "FieldCaption";
            this.xrLabel20.StylePriority.UseBorders = false;
            this.xrLabel20.StylePriority.UseFont = false;
            this.xrLabel20.StylePriority.UseForeColor = false;
            this.xrLabel20.StylePriority.UseTextAlignment = false;
            xrSummary47.FormatString = "{0:0.##}";
            xrSummary47.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
            this.xrLabel20.Summary = xrSummary47;
            this.xrLabel20.Text = "xrLabel38";
            this.xrLabel20.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.xrLabel20.WordWrap = false;
            // 
            // xrLabel21
            // 
            this.xrLabel21.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel21.CanGrow = false;
            this.xrLabel21.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.RetTotal", "{0:C2}")});
            this.xrLabel21.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.xrLabel21.ForeColor = System.Drawing.Color.Black;
            this.xrLabel21.LocationFloat = new DevExpress.Utils.PointFloat(867.5075F, 22F);
            this.xrLabel21.Name = "xrLabel21";
            this.xrLabel21.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel21.SizeF = new System.Drawing.SizeF(97.80957F, 18F);
            this.xrLabel21.StyleName = "FieldCaption";
            this.xrLabel21.StylePriority.UseBorders = false;
            this.xrLabel21.StylePriority.UseFont = false;
            this.xrLabel21.StylePriority.UseForeColor = false;
            this.xrLabel21.StylePriority.UseTextAlignment = false;
            xrSummary48.FormatString = "{0:#,##0.00}";
            xrSummary48.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
            this.xrLabel21.Summary = xrSummary48;
            this.xrLabel21.Text = "xrLabel45";
            this.xrLabel21.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.xrLabel21.WordWrap = false;
            // 
            // xrLabel22
            // 
            this.xrLabel22.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel22.CanGrow = false;
            this.xrLabel22.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.RetQTY")});
            this.xrLabel22.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.xrLabel22.ForeColor = System.Drawing.Color.Black;
            this.xrLabel22.LocationFloat = new DevExpress.Utils.PointFloat(777.5999F, 22F);
            this.xrLabel22.Name = "xrLabel22";
            this.xrLabel22.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel22.SizeF = new System.Drawing.SizeF(89.90765F, 18F);
            this.xrLabel22.StyleName = "FieldCaption";
            this.xrLabel22.StylePriority.UseBorders = false;
            this.xrLabel22.StylePriority.UseFont = false;
            this.xrLabel22.StylePriority.UseForeColor = false;
            this.xrLabel22.StylePriority.UseTextAlignment = false;
            xrSummary49.FormatString = "{0:0.##}";
            xrSummary49.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
            this.xrLabel22.Summary = xrSummary49;
            this.xrLabel22.Text = "xrLabel44";
            this.xrLabel22.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.xrLabel22.WordWrap = false;
            // 
            // xrLabel23
            // 
            this.xrLabel23.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel23.CanGrow = false;
            this.xrLabel23.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.RetNet", "{0:C2}")});
            this.xrLabel23.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.xrLabel23.ForeColor = System.Drawing.Color.Black;
            this.xrLabel23.LocationFloat = new DevExpress.Utils.PointFloat(965.3171F, 22F);
            this.xrLabel23.Name = "xrLabel23";
            this.xrLabel23.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel23.SizeF = new System.Drawing.SizeF(90.68292F, 18F);
            this.xrLabel23.StyleName = "FieldCaption";
            this.xrLabel23.StylePriority.UseBorders = false;
            this.xrLabel23.StylePriority.UseFont = false;
            this.xrLabel23.StylePriority.UseForeColor = false;
            this.xrLabel23.StylePriority.UseTextAlignment = false;
            xrSummary50.FormatString = "{0:#,##0.00}";
            xrSummary50.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
            this.xrLabel23.Summary = xrSummary50;
            this.xrLabel23.Text = "xrLabel43";
            this.xrLabel23.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.xrLabel23.WordWrap = false;
            // 
            // xrLabel24
            // 
            this.xrLabel24.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel24.CanGrow = false;
            this.xrLabel24.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.QTY")});
            this.xrLabel24.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.xrLabel24.ForeColor = System.Drawing.Color.Black;
            this.xrLabel24.LocationFloat = new DevExpress.Utils.PointFloat(229.1667F, 22F);
            this.xrLabel24.Name = "xrLabel24";
            this.xrLabel24.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel24.SizeF = new System.Drawing.SizeF(90.49998F, 18F);
            this.xrLabel24.StyleName = "FieldCaption";
            this.xrLabel24.StylePriority.UseBorders = false;
            this.xrLabel24.StylePriority.UseFont = false;
            this.xrLabel24.StylePriority.UseForeColor = false;
            this.xrLabel24.StylePriority.UseTextAlignment = false;
            xrSummary51.FormatString = "{0:0.##}";
            xrSummary51.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
            this.xrLabel24.Summary = xrSummary51;
            this.xrLabel24.Text = "xrLabel42";
            this.xrLabel24.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.xrLabel24.WordWrap = false;
            // 
            // xrLabel25
            // 
            this.xrLabel25.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel25.CanGrow = false;
            this.xrLabel25.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.Net", "{0:C2}")});
            this.xrLabel25.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.xrLabel25.ForeColor = System.Drawing.Color.Black;
            this.xrLabel25.LocationFloat = new DevExpress.Utils.PointFloat(413.3835F, 22F);
            this.xrLabel25.Name = "xrLabel25";
            this.xrLabel25.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel25.SizeF = new System.Drawing.SizeF(91F, 18F);
            this.xrLabel25.StyleName = "FieldCaption";
            this.xrLabel25.StylePriority.UseBorders = false;
            this.xrLabel25.StylePriority.UseFont = false;
            this.xrLabel25.StylePriority.UseForeColor = false;
            this.xrLabel25.StylePriority.UseTextAlignment = false;
            xrSummary52.FormatString = "{0:#,##0.00}";
            xrSummary52.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
            this.xrLabel25.Summary = xrSummary52;
            this.xrLabel25.Text = "xrLabel41";
            this.xrLabel25.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.xrLabel25.WordWrap = false;
            // 
            // xrLabel27
            // 
            this.xrLabel27.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel27.CanGrow = false;
            this.xrLabel27.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.CorplNet", "{0:C2}")});
            this.xrLabel27.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.xrLabel27.ForeColor = System.Drawing.Color.Black;
            this.xrLabel27.LocationFloat = new DevExpress.Utils.PointFloat(687.6922F, 22F);
            this.xrLabel27.Name = "xrLabel27";
            this.xrLabel27.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel27.SizeF = new System.Drawing.SizeF(89.90765F, 18F);
            this.xrLabel27.StyleName = "FieldCaption";
            this.xrLabel27.StylePriority.UseBorders = false;
            this.xrLabel27.StylePriority.UseFont = false;
            this.xrLabel27.StylePriority.UseForeColor = false;
            this.xrLabel27.StylePriority.UseTextAlignment = false;
            xrSummary53.FormatString = "{0:#,##0.00}";
            xrSummary53.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
            this.xrLabel27.Summary = xrSummary53;
            this.xrLabel27.Text = "xrLabel40";
            this.xrLabel27.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.xrLabel27.WordWrap = false;
            // 
            // xrLabel28
            // 
            this.xrLabel28.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel28.CanGrow = false;
            this.xrLabel28.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.CoplTotal", "{0:C2}")});
            this.xrLabel28.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.xrLabel28.ForeColor = System.Drawing.Color.Black;
            this.xrLabel28.LocationFloat = new DevExpress.Utils.PointFloat(595.7908F, 22F);
            this.xrLabel28.Name = "xrLabel28";
            this.xrLabel28.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel28.SizeF = new System.Drawing.SizeF(91.90137F, 18F);
            this.xrLabel28.StyleName = "FieldCaption";
            this.xrLabel28.StylePriority.UseBorders = false;
            this.xrLabel28.StylePriority.UseFont = false;
            this.xrLabel28.StylePriority.UseForeColor = false;
            this.xrLabel28.StylePriority.UseTextAlignment = false;
            xrSummary54.FormatString = "{0:#,##0.00}";
            xrSummary54.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
            this.xrLabel28.Summary = xrSummary54;
            this.xrLabel28.Text = "xrLabel39";
            this.xrLabel28.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.xrLabel28.WordWrap = false;
            // 
            // xrLabel11
            // 
            this.xrLabel11.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel11.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.Department", "Department : {0}")});
            this.xrLabel11.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrLabel11.LocationFloat = new DevExpress.Utils.PointFloat(6F, 0F);
            this.xrLabel11.Name = "xrLabel11";
            this.xrLabel11.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel11.SizeF = new System.Drawing.SizeF(302.5743F, 19F);
            this.xrLabel11.StylePriority.UseBorders = false;
            this.xrLabel11.StylePriority.UseFont = false;
            // 
            // xrLine3
            // 
            this.xrLine3.LocationFloat = new DevExpress.Utils.PointFloat(6F, 128.9167F);
            this.xrLine3.Name = "xrLine3";
            this.xrLine3.SizeF = new System.Drawing.SizeF(1050F, 2F);
            // 
            // xrLine5
            // 
            this.xrLine5.LocationFloat = new DevExpress.Utils.PointFloat(6F, 94.4167F);
            this.xrLine5.Name = "xrLine5";
            this.xrLine5.SizeF = new System.Drawing.SizeF(1050F, 2F);
            // 
            // xrLabel90
            // 
            this.xrLabel90.Font = new System.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
            this.xrLabel90.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.xrLabel90.LocationFloat = new DevExpress.Utils.PointFloat(6F, 115.9167F);
            this.xrLabel90.Name = "xrLabel90";
            this.xrLabel90.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel90.SizeF = new System.Drawing.SizeF(222.6667F, 13F);
            this.xrLabel90.StylePriority.UseFont = false;
            this.xrLabel90.StylePriority.UseForeColor = false;
            this.xrLabel90.Text = "Προϊόν";
            // 
            // xrLabel91
            // 
            this.xrLabel91.Font = new System.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
            this.xrLabel91.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.xrLabel91.LocationFloat = new DevExpress.Utils.PointFloat(228.6667F, 115.9167F);
            this.xrLabel91.Name = "xrLabel91";
            this.xrLabel91.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel91.SizeF = new System.Drawing.SizeF(91F, 13F);
            this.xrLabel91.StylePriority.UseFont = false;
            this.xrLabel91.StylePriority.UseForeColor = false;
            this.xrLabel91.StylePriority.UseTextAlignment = false;
            this.xrLabel91.Text = "Ποσότητα";
            this.xrLabel91.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // xrLabel92
            // 
            this.xrLabel92.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.xrLabel92.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.xrLabel92.LocationFloat = new DevExpress.Utils.PointFloat(228.6667F, 97.4167F);
            this.xrLabel92.Name = "xrLabel92";
            this.xrLabel92.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel92.SizeF = new System.Drawing.SizeF(275.7168F, 16F);
            this.xrLabel92.StylePriority.UseFont = false;
            this.xrLabel92.StylePriority.UseForeColor = false;
            this.xrLabel92.StylePriority.UseTextAlignment = false;
            this.xrLabel92.Text = "ΠΩΛΗΣΕΙΣ";
            this.xrLabel92.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel93
            // 
            this.xrLabel93.Font = new System.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
            this.xrLabel93.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.xrLabel93.LocationFloat = new DevExpress.Utils.PointFloat(319.6667F, 115.9167F);
            this.xrLabel93.Name = "xrLabel93";
            this.xrLabel93.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel93.SizeF = new System.Drawing.SizeF(93.7168F, 13F);
            this.xrLabel93.StylePriority.UseFont = false;
            this.xrLabel93.StylePriority.UseForeColor = false;
            this.xrLabel93.StylePriority.UseTextAlignment = false;
            this.xrLabel93.Text = "Αξια";
            this.xrLabel93.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // xrLabel94
            // 
            this.xrLabel94.Font = new System.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
            this.xrLabel94.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.xrLabel94.LocationFloat = new DevExpress.Utils.PointFloat(413.3835F, 115.9167F);
            this.xrLabel94.Name = "xrLabel94";
            this.xrLabel94.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel94.SizeF = new System.Drawing.SizeF(91F, 13F);
            this.xrLabel94.StylePriority.UseFont = false;
            this.xrLabel94.StylePriority.UseForeColor = false;
            this.xrLabel94.StylePriority.UseTextAlignment = false;
            this.xrLabel94.Text = "Καθαρή Αξία";
            this.xrLabel94.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // xrLabel98
            // 
            this.xrLabel98.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.xrLabel98.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.xrLabel98.LocationFloat = new DevExpress.Utils.PointFloat(504.8835F, 97.4167F);
            this.xrLabel98.Name = "xrLabel98";
            this.xrLabel98.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel98.SizeF = new System.Drawing.SizeF(275.8083F, 16F);
            this.xrLabel98.StylePriority.UseFont = false;
            this.xrLabel98.StylePriority.UseForeColor = false;
            this.xrLabel98.StylePriority.UseTextAlignment = false;
            this.xrLabel98.Text = "ΦΙΛΟΞΕΝΙΑ";
            this.xrLabel98.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel102
            // 
            this.xrLabel102.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.xrLabel102.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.xrLabel102.LocationFloat = new DevExpress.Utils.PointFloat(781.1918F, 97.4167F);
            this.xrLabel102.Name = "xrLabel102";
            this.xrLabel102.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel102.SizeF = new System.Drawing.SizeF(274.8082F, 16F);
            this.xrLabel102.StylePriority.UseFont = false;
            this.xrLabel102.StylePriority.UseForeColor = false;
            this.xrLabel102.StylePriority.UseTextAlignment = false;
            this.xrLabel102.Text = "ΕΠΙΣΤΡΟΦΕΣ";
            this.xrLabel102.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrSubreport1
            // 
            this.xrSubreport1.CanShrink = true;
            this.xrSubreport1.LocationFloat = new DevExpress.Utils.PointFloat(6F, 41F);
            this.xrSubreport1.Name = "xrSubreport1";
            this.xrSubreport1.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("FromDate", this.FromDate));
            this.xrSubreport1.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("ToDate", this.ToDate));
            this.xrSubreport1.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("DepartmentId", null, "Query.DepartmentId"));
            this.xrSubreport1.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("CategoryId", this.CategoryId));
            this.xrSubreport1.ReportSource = new SalesNetAmount_Subreport();
            this.xrSubreport1.SizeF = new System.Drawing.SizeF(1050F, 51.99999F);
            // 
            // CategoryId
            // 
            this.CategoryId.Description = "Select Category";
            dynamicListLookUpSettings1.DataAdapter = null;
            dynamicListLookUpSettings1.DataMember = "Categories";
            dynamicListLookUpSettings1.DataSource = this.sqlDataSource1;
            dynamicListLookUpSettings1.DisplayMember = "CategoryDescription";
            dynamicListLookUpSettings1.ValueMember = "Id";
            this.CategoryId.LookUpSettings = dynamicListLookUpSettings1;
            this.CategoryId.MultiValue = true;
            this.CategoryId.Name = "CategoryId";
            this.CategoryId.Type = typeof(long);
            this.CategoryId.ValueInfo = "0";
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
            // ProductCategoryCode
            // 
            this.ProductCategoryCode.Description = "Select ProductCategory";
            dynamicListLookUpSettings3.DataAdapter = null;
            dynamicListLookUpSettings3.DataMember = "ProductCategories";
            dynamicListLookUpSettings3.DataSource = this.sqlDataSource1;
            dynamicListLookUpSettings3.DisplayMember = "Description";
            dynamicListLookUpSettings3.ValueMember = "Code";
            this.ProductCategoryCode.LookUpSettings = dynamicListLookUpSettings3;
            this.ProductCategoryCode.MultiValue = true;
            this.ProductCategoryCode.Name = "ProductCategoryCode";
            // 
            // SalesNetAmount2
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.groupHeaderBand1,
            this.pageFooterBand1,
            this.reportHeaderBand1,
            this.reportFooterBand1,
            this.ProductGroupHeader,
            this.ProductCategoryGroupHeader,
            this.CategoryGroupHeader,
            this.DepartmentGroupHeader});
            this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.sqlDataSource1,
            this.sqlDataSource2});
            this.DataMember = "Query_FastStart";
            this.DataSource = this.sqlDataSource1;
            this.FilterString = "[DepartmentId] In (?DepartmentId) And [CategoryId] In (?CategoryId) And [ProductC" +
    "ategoryCode] In (?ProductCategoryCode)";
            this.Landscape = true;
            this.Margins = new System.Drawing.Printing.Margins(51, 56, 57, 36);
            this.PageHeight = 827;
            this.PageWidth = 1169;
            this.PaperKind = System.Drawing.Printing.PaperKind.A4;
            this.Parameters.AddRange(new DevExpress.XtraReports.Parameters.Parameter[] {
            this.FromDate,
            this.ToDate,
            this.DepartmentId,
            this.CategoryId,
            this.ProductCategoryCode});
            this.StyleSheet.AddRange(new DevExpress.XtraReports.UI.XRControlStyle[] {
            this.Title,
            this.FieldCaption,
            this.PageInfo,
            this.DataField});
            this.Version = "15.2";
            this.ParametersRequestBeforeShow += new System.EventHandler<DevExpress.XtraReports.Parameters.ParametersRequestEventArgs>(this.SalesNetAmount2_ParametersRequestBeforeShow);
            this.DataSourceDemanded += new System.EventHandler<System.EventArgs>(this.SalesNetAmount2_DataSourceDemanded);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

      }

   #endregion

   ////////////////////////////////////////////////////////////////////////////////////////////////
   /// <summary>
   /// 
   /// </summary>
   /// <param name="sender"></param>
   /// <param name="e"></param>
   private void SalesNetAmount2_DataSourceDemanded( object sender, EventArgs e )
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
   private void SalesNetAmount2_ParametersRequestBeforeShow( object sender
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

               case "CategoryId":
                  // select all values for parameter CategoryId
                  paramItem.Parameter.Value = CommonTools.SetAllSelectedForMultiValueParameter<Int64>( sqlDataSource1, "Categories", "Id" );
                  break;

               case "ProductCategoryCode":
                  // select all values for parameter ProductCategoryCode
                  paramItem.Parameter.Value = CommonTools.SetAllSelectedForMultiValueParameter( sqlDataSource1, "ProductCategories", "Code" );
                  break;

               default:
                  break;
               }

            }

         }

      }

   ////////////////////////////////////////////////////////////////////////////////////////////////
   }

