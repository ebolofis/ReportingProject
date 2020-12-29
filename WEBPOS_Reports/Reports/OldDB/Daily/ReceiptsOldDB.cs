
using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using DevExpress.DataAccess.Sql;
using System.Text;
using DevExpress.DataAccess;
using System.Linq;
using System.Web.Configuration;
using System.Collections.Generic;
using DevExpress.DataAccess.Native.Sql;
using WEBPOS_Reports.Helpers;

/// <summary>
/// Summary description for ReceiptsOldDB
/// </summary>
public class ReceiptsOldDB : DevExpress.XtraReports.UI.XtraReport
   {
   private DevExpress.XtraReports.UI.DetailBand Detail;
   private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
   private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
   private XRLabel xrLabel24;
   private XRLabel xrLabel25;
   private XRLabel xrLabel27;
   private XRLabel xrLabel28;
   private XRLabel xrLabel29;
   private XRLabel xrLabel30;
   private XRLabel xrLabel31;
   private XRLabel xrLabel32;
   private XRLabel xrLabel33;
   private XRLabel xrLabel34;
   private XRLabel xrLabel35;
   public SqlDataSource sqlDataSource1;
   private GroupHeaderBand groupHeaderBand1;
   private XRLabel xrLabel2;
   private GroupHeaderBand groupHeaderBand2;
   private XRLabel xrLabel4;
   private GroupHeaderBand groupHeaderBand3;
   private XRLabel xrLabel6;
   private GroupHeaderBand groupHeaderBand4;
   private XRLabel xrLabel7;
   private XRLabel xrLabel8;
   private XRLabel xrLabel10;
   private XRLabel xrLabel11;
   private XRLabel xrLabel12;
   private XRLabel xrLabel13;
   private XRLabel xrLabel15;
   private XRLabel xrLabel16;
   private XRLabel xrLabel17;
   private XRLabel xrLabel18;
   private XRLine xrLine2;
   private PageFooterBand pageFooterBand1;
   private ReportHeaderBand reportHeaderBand1;
   private XRLabel xrLabel41;
   private GroupFooterBand groupFooterBand1;
   private GroupFooterBand groupFooterBand2;
   private XRLabel xrLabel42;
   private XRLabel xrLabel43;
   private XRLabel xrLabel44;
   private XRLabel xrLabel45;
   private XRLabel xrLabel46;
   private XRLabel xrLabel47;
   private XRLabel xrLabel48;
   private XRLabel xrLabel49;
   private GroupFooterBand groupFooterBand3;
   private XRLabel xrLabel51;
   private XRLabel xrLabel52;
   private XRLabel xrLabel53;
   private XRLabel xrLabel54;
   private XRLabel xrLabel55;
   private XRLabel xrLabel56;
   private XRLabel xrLabel57;
   private GroupFooterBand groupFooterBand4;
   private XRLabel xrLabel59;
   private XRLabel xrLabel60;
   private XRLabel xrLabel61;
   private XRLabel xrLabel62;
   private XRLabel xrLabel63;
   private XRLabel xrLabel64;
   private XRLabel xrLabel65;
   private ReportFooterBand reportFooterBand1;
   private XRLabel xrLabel67;
   private XRLabel xrLabel68;
   private XRLabel xrLabel69;
   private XRLabel xrLabel70;
   private XRLabel xrLabel71;
   private XRLabel xrLabel72;
   private XRLabel xrLabel73;
   private XRControlStyle Title;
   private XRControlStyle FieldCaption;
   private XRControlStyle PageInfo;
   private XRControlStyle DataField;
   private XRPageInfo xrPageInfo1;
   private XRPageInfo xrPageInfo2;
   private XRLine xrLine3;
   private XRLine xrLine4;
   private XRLine xrLine5;
   private XRLine xrLine6;
   private XRLabel xrLabel19;
   private XRLabel xrLabel14;
   private XRLabel xrLabel21;
   private XRLabel xrLabel22;
   private XRLabel xrLabel23;
   private XRLabel xrLabel37;
   private XRLabel xrLabel20;
   private XRLabel xrLabel38;
   private DevExpress.XtraReports.Parameters.Parameter DepartmentID;
   private DevExpress.XtraReports.Parameters.Parameter PosInfoID;
   private DevExpress.XtraReports.Parameters.Parameter AccountType;
   private DevExpress.XtraReports.Parameters.Parameter FromFODay;
   private DevExpress.XtraReports.Parameters.Parameter UpToFODay;
   private XRLabel xrLabel1;
   private XRLabel xrLabel3;
   private DevExpress.XtraReports.Parameters.Parameter InvoiceTypes;
   private GroupHeaderBand GroupHeader1;
   private XRLabel xrLabel5;
   private CalculatedField calculatedField1;
   private FormattingRule formattingRule1;
   private GroupFooterBand GroupFooter1;
   private XRLabel xrLabel58;
   private XRLabel xrLabel50;
   private XRLabel xrLabel40;
   private XRLabel xrLabel39;
   private XRLabel xrLabel36;
   private XRLabel xrLabel26;
   private XRLabel xrLabel9;
   private XRLine xrLine7;
   private XRLine xrLine8;
   private XRLabel xrLabel66;
   private XRControlStyle xrControlStyle1;

   /// <summary>
   /// Required designer variable.
   /// </summary>
   private System.ComponentModel.IContainer components = null;

   public ReceiptsOldDB()
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
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReceiptsOldDB));
         DevExpress.DataAccess.Sql.CustomSqlQuery customSqlQuery2 = new DevExpress.DataAccess.Sql.CustomSqlQuery();
         DevExpress.DataAccess.Sql.CustomSqlQuery customSqlQuery3 = new DevExpress.DataAccess.Sql.CustomSqlQuery();
         DevExpress.DataAccess.Sql.CustomSqlQuery customSqlQuery4 = new DevExpress.DataAccess.Sql.CustomSqlQuery();
         DevExpress.DataAccess.Sql.CustomSqlQuery customSqlQuery5 = new DevExpress.DataAccess.Sql.CustomSqlQuery();
         DevExpress.DataAccess.Sql.CustomSqlQuery customSqlQuery6 = new DevExpress.DataAccess.Sql.CustomSqlQuery();
         DevExpress.DataAccess.Sql.QueryParameter queryParameter3 = new DevExpress.DataAccess.Sql.QueryParameter();
         DevExpress.DataAccess.Sql.QueryParameter queryParameter4 = new DevExpress.DataAccess.Sql.QueryParameter();
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
         DevExpress.XtraReports.Parameters.DynamicListLookUpSettings dynamicListLookUpSettings1 = new DevExpress.XtraReports.Parameters.DynamicListLookUpSettings();
         DevExpress.XtraReports.Parameters.DynamicListLookUpSettings dynamicListLookUpSettings2 = new DevExpress.XtraReports.Parameters.DynamicListLookUpSettings();
         DevExpress.XtraReports.Parameters.DynamicListLookUpSettings dynamicListLookUpSettings3 = new DevExpress.XtraReports.Parameters.DynamicListLookUpSettings();
         DevExpress.XtraReports.Parameters.DynamicListLookUpSettings dynamicListLookUpSettings4 = new DevExpress.XtraReports.Parameters.DynamicListLookUpSettings();
         DevExpress.XtraReports.UI.XRSummary xrSummary37 = new DevExpress.XtraReports.UI.XRSummary();
         DevExpress.XtraReports.UI.XRSummary xrSummary38 = new DevExpress.XtraReports.UI.XRSummary();
         DevExpress.XtraReports.UI.XRSummary xrSummary39 = new DevExpress.XtraReports.UI.XRSummary();
         DevExpress.XtraReports.UI.XRSummary xrSummary40 = new DevExpress.XtraReports.UI.XRSummary();
         DevExpress.XtraReports.UI.XRSummary xrSummary41 = new DevExpress.XtraReports.UI.XRSummary();
         DevExpress.XtraReports.UI.XRSummary xrSummary42 = new DevExpress.XtraReports.UI.XRSummary();
         this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
         this.Detail = new DevExpress.XtraReports.UI.DetailBand();
         this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel24 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel25 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel27 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel28 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel29 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel30 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel31 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel32 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel33 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel34 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel35 = new DevExpress.XtraReports.UI.XRLabel();
         this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
         this.xrPageInfo2 = new DevExpress.XtraReports.UI.XRPageInfo();
         this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
         this.groupHeaderBand1 = new DevExpress.XtraReports.UI.GroupHeaderBand();
         this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
         this.groupHeaderBand2 = new DevExpress.XtraReports.UI.GroupHeaderBand();
         this.xrLabel4 = new DevExpress.XtraReports.UI.XRLabel();
         this.groupHeaderBand3 = new DevExpress.XtraReports.UI.GroupHeaderBand();
         this.xrLabel21 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel22 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel23 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel37 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel20 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel6 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel44 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel49 = new DevExpress.XtraReports.UI.XRLabel();
         this.groupHeaderBand4 = new DevExpress.XtraReports.UI.GroupHeaderBand();
         this.xrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel7 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel8 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel10 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel11 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel12 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel13 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel15 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel16 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel17 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel18 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLine2 = new DevExpress.XtraReports.UI.XRLine();
         this.xrLabel19 = new DevExpress.XtraReports.UI.XRLabel();
         this.pageFooterBand1 = new DevExpress.XtraReports.UI.PageFooterBand();
         this.xrPageInfo1 = new DevExpress.XtraReports.UI.XRPageInfo();
         this.reportHeaderBand1 = new DevExpress.XtraReports.UI.ReportHeaderBand();
         this.xrLabel66 = new DevExpress.XtraReports.UI.XRLabel();
         this.UpToFODay = new DevExpress.XtraReports.Parameters.Parameter();
         this.xrLabel41 = new DevExpress.XtraReports.UI.XRLabel();
         this.FromFODay = new DevExpress.XtraReports.Parameters.Parameter();
         this.groupFooterBand1 = new DevExpress.XtraReports.UI.GroupFooterBand();
         this.groupFooterBand2 = new DevExpress.XtraReports.UI.GroupFooterBand();
         this.xrLabel38 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel14 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLine3 = new DevExpress.XtraReports.UI.XRLine();
         this.xrLabel42 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel43 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel45 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel46 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel47 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel48 = new DevExpress.XtraReports.UI.XRLabel();
         this.groupFooterBand3 = new DevExpress.XtraReports.UI.GroupFooterBand();
         this.xrLine4 = new DevExpress.XtraReports.UI.XRLine();
         this.xrLabel51 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel52 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel53 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel54 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel55 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel56 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel57 = new DevExpress.XtraReports.UI.XRLabel();
         this.groupFooterBand4 = new DevExpress.XtraReports.UI.GroupFooterBand();
         this.xrLine5 = new DevExpress.XtraReports.UI.XRLine();
         this.xrLabel59 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel60 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel61 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel62 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel63 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel64 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel65 = new DevExpress.XtraReports.UI.XRLabel();
         this.reportFooterBand1 = new DevExpress.XtraReports.UI.ReportFooterBand();
         this.xrLine6 = new DevExpress.XtraReports.UI.XRLine();
         this.xrLabel67 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel68 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel69 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel70 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel71 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel72 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel73 = new DevExpress.XtraReports.UI.XRLabel();
         this.Title = new DevExpress.XtraReports.UI.XRControlStyle();
         this.FieldCaption = new DevExpress.XtraReports.UI.XRControlStyle();
         this.PageInfo = new DevExpress.XtraReports.UI.XRControlStyle();
         this.DataField = new DevExpress.XtraReports.UI.XRControlStyle();
         this.DepartmentID = new DevExpress.XtraReports.Parameters.Parameter();
         this.PosInfoID = new DevExpress.XtraReports.Parameters.Parameter();
         this.AccountType = new DevExpress.XtraReports.Parameters.Parameter();
         this.InvoiceTypes = new DevExpress.XtraReports.Parameters.Parameter();
         this.GroupHeader1 = new DevExpress.XtraReports.UI.GroupHeaderBand();
         this.xrLabel5 = new DevExpress.XtraReports.UI.XRLabel();
         this.formattingRule1 = new DevExpress.XtraReports.UI.FormattingRule();
         this.calculatedField1 = new DevExpress.XtraReports.UI.CalculatedField();
         this.GroupFooter1 = new DevExpress.XtraReports.UI.GroupFooterBand();
         this.xrLine8 = new DevExpress.XtraReports.UI.XRLine();
         this.xrLabel58 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel50 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel40 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel39 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel36 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel26 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel9 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLine7 = new DevExpress.XtraReports.UI.XRLine();
         this.xrControlStyle1 = new DevExpress.XtraReports.UI.XRControlStyle();
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
         customSqlQuery2.Name = "InvoiceTypes";
         customSqlQuery2.Sql = "select Id,Type, Abbreviation from InvoiceTypes";
         customSqlQuery3.Name = "Accounts";
         customSqlQuery3.Sql = "Select Id, Description, Type from Accounts";
         customSqlQuery4.Name = "PosInfos";
         customSqlQuery4.Sql = "Select Id, Code, Description from PosInfo";
         customSqlQuery5.Name = "Departments";
         customSqlQuery5.Sql = "Select Id, Description from Department";
         customSqlQuery6.Name = "Query_FastStart";
         queryParameter3.Name = "FromFODay";
         queryParameter3.Type = typeof(DevExpress.DataAccess.Expression);
         queryParameter3.Value = new DevExpress.DataAccess.Expression("[Parameters.FromFODay]", typeof(System.DateTime));
         queryParameter4.Name = "ToFODay";
         queryParameter4.Type = typeof(DevExpress.DataAccess.Expression);
         queryParameter4.Value = new DevExpress.DataAccess.Expression("[Parameters.UpToFODay]", typeof(System.DateTime));
         customSqlQuery6.Parameters.Add(queryParameter3);
         customSqlQuery6.Parameters.Add(queryParameter4);
         customSqlQuery6.Sql = resources.GetString("customSqlQuery6.Sql");
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
            this.xrLabel1,
            this.xrLabel24,
            this.xrLabel25,
            this.xrLabel27,
            this.xrLabel28,
            this.xrLabel29,
            this.xrLabel30,
            this.xrLabel31,
            this.xrLabel32,
            this.xrLabel33,
            this.xrLabel34,
            this.xrLabel35});
         this.Detail.HeightF = 18F;
         this.Detail.Name = "Detail";
         this.Detail.OddStyleName = "xrControlStyle1";
         this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
         this.Detail.StyleName = "DataField";
         this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
         // 
         // xrLabel1
         // 
         this.xrLabel1.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.InvoiceTotal", "{0:#0.00}")});
         this.xrLabel1.Font = new System.Drawing.Font("Times New Roman", 8F);
         this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(897.7753F, 0F);
         this.xrLabel1.Name = "xrLabel1";
         this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel1.SizeF = new System.Drawing.SizeF(81.05859F, 18F);
         this.xrLabel1.StylePriority.UseFont = false;
         this.xrLabel1.StylePriority.UseTextAlignment = false;
         this.xrLabel1.Text = "xrLabel1";
         this.xrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
         // 
         // xrLabel24
         // 
         this.xrLabel24.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.Abbreviation")});
         this.xrLabel24.Font = new System.Drawing.Font("Times New Roman", 8F);
         this.xrLabel24.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
         this.xrLabel24.Name = "xrLabel24";
         this.xrLabel24.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel24.SizeF = new System.Drawing.SizeF(81.05846F, 18F);
         this.xrLabel24.StylePriority.UseFont = false;
         this.xrLabel24.StylePriority.UseTextAlignment = false;
         this.xrLabel24.Text = "xrLabel24";
         this.xrLabel24.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
         // 
         // xrLabel25
         // 
         this.xrLabel25.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.Counter")});
         this.xrLabel25.Font = new System.Drawing.Font("Times New Roman", 8F);
         this.xrLabel25.LocationFloat = new DevExpress.Utils.PointFloat(81.05846F, 0F);
         this.xrLabel25.Name = "xrLabel25";
         this.xrLabel25.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel25.SizeF = new System.Drawing.SizeF(68.94154F, 18F);
         this.xrLabel25.StylePriority.UseFont = false;
         this.xrLabel25.StylePriority.UseTextAlignment = false;
         this.xrLabel25.Text = "xrLabel25";
         this.xrLabel25.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
         // 
         // xrLabel27
         // 
         this.xrLabel27.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.Room")});
         this.xrLabel27.Font = new System.Drawing.Font("Times New Roman", 8F);
         this.xrLabel27.LocationFloat = new DevExpress.Utils.PointFloat(347.8837F, 0F);
         this.xrLabel27.Name = "xrLabel27";
         this.xrLabel27.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel27.SizeF = new System.Drawing.SizeF(64.07385F, 18F);
         this.xrLabel27.StylePriority.UseFont = false;
         this.xrLabel27.StylePriority.UseTextAlignment = false;
         this.xrLabel27.Text = "xrLabel27";
         this.xrLabel27.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
         // 
         // xrLabel28
         // 
         this.xrLabel28.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.StafName")});
         this.xrLabel28.Font = new System.Drawing.Font("Times New Roman", 8F);
         this.xrLabel28.LocationFloat = new DevExpress.Utils.PointFloat(150F, 0F);
         this.xrLabel28.Name = "xrLabel28";
         this.xrLabel28.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel28.SizeF = new System.Drawing.SizeF(197.8837F, 18F);
         this.xrLabel28.StylePriority.UseFont = false;
         this.xrLabel28.StylePriority.UseTextAlignment = false;
         this.xrLabel28.Text = "xrLabel28";
         this.xrLabel28.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
         this.xrLabel28.WordWrap = false;
         // 
         // xrLabel29
         // 
         this.xrLabel29.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.TableCode")});
         this.xrLabel29.Font = new System.Drawing.Font("Times New Roman", 8F);
         this.xrLabel29.LocationFloat = new DevExpress.Utils.PointFloat(411.9576F, 0F);
         this.xrLabel29.Name = "xrLabel29";
         this.xrLabel29.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel29.SizeF = new System.Drawing.SizeF(57.95078F, 18F);
         this.xrLabel29.StylePriority.UseFont = false;
         this.xrLabel29.StylePriority.UseTextAlignment = false;
         this.xrLabel29.Text = "xrLabel29";
         this.xrLabel29.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
         // 
         // xrLabel30
         // 
         this.xrLabel30.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.TransAmount", "{0:#0.00}")});
         this.xrLabel30.Font = new System.Drawing.Font("Times New Roman", 8F);
         this.xrLabel30.LocationFloat = new DevExpress.Utils.PointFloat(978.8339F, 0F);
         this.xrLabel30.Name = "xrLabel30";
         this.xrLabel30.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel30.SizeF = new System.Drawing.SizeF(90.16615F, 18F);
         this.xrLabel30.StylePriority.UseFont = false;
         this.xrLabel30.StylePriority.UseTextAlignment = false;
         this.xrLabel30.Text = "xrLabel30";
         this.xrLabel30.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
         // 
         // xrLabel31
         // 
         this.xrLabel31.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.Vat1", "{0:#0.00}")});
         this.xrLabel31.Font = new System.Drawing.Font("Times New Roman", 8F);
         this.xrLabel31.LocationFloat = new DevExpress.Utils.PointFloat(469.9081F, 0F);
         this.xrLabel31.Name = "xrLabel31";
         this.xrLabel31.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel31.SizeF = new System.Drawing.SizeF(85.25079F, 18F);
         this.xrLabel31.StylePriority.UseFont = false;
         this.xrLabel31.StylePriority.UseTextAlignment = false;
         this.xrLabel31.Text = "xrLabel31";
         this.xrLabel31.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
         // 
         // xrLabel32
         // 
         this.xrLabel32.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.Vat2", "{0:#0.00}")});
         this.xrLabel32.Font = new System.Drawing.Font("Times New Roman", 8F);
         this.xrLabel32.LocationFloat = new DevExpress.Utils.PointFloat(555.1589F, 0F);
         this.xrLabel32.Name = "xrLabel32";
         this.xrLabel32.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel32.SizeF = new System.Drawing.SizeF(86.25067F, 18F);
         this.xrLabel32.StylePriority.UseFont = false;
         this.xrLabel32.StylePriority.UseTextAlignment = false;
         this.xrLabel32.Text = "xrLabel32";
         this.xrLabel32.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
         // 
         // xrLabel33
         // 
         this.xrLabel33.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.Vat3", "{0:#0.00}")});
         this.xrLabel33.Font = new System.Drawing.Font("Times New Roman", 8F);
         this.xrLabel33.LocationFloat = new DevExpress.Utils.PointFloat(641.4096F, 0F);
         this.xrLabel33.Name = "xrLabel33";
         this.xrLabel33.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel33.SizeF = new System.Drawing.SizeF(86.25061F, 18F);
         this.xrLabel33.StylePriority.UseFont = false;
         this.xrLabel33.StylePriority.UseTextAlignment = false;
         this.xrLabel33.Text = "xrLabel33";
         this.xrLabel33.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
         // 
         // xrLabel34
         // 
         this.xrLabel34.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.Vat4", "{0:#0.00}")});
         this.xrLabel34.Font = new System.Drawing.Font("Times New Roman", 8F);
         this.xrLabel34.LocationFloat = new DevExpress.Utils.PointFloat(727.6602F, 0F);
         this.xrLabel34.Name = "xrLabel34";
         this.xrLabel34.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel34.SizeF = new System.Drawing.SizeF(85.25067F, 18F);
         this.xrLabel34.StylePriority.UseFont = false;
         this.xrLabel34.StylePriority.UseTextAlignment = false;
         this.xrLabel34.Text = "xrLabel34";
         this.xrLabel34.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
         // 
         // xrLabel35
         // 
         this.xrLabel35.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.Vat5", "{0:#0.00}")});
         this.xrLabel35.Font = new System.Drawing.Font("Times New Roman", 8F);
         this.xrLabel35.LocationFloat = new DevExpress.Utils.PointFloat(812.9108F, 0F);
         this.xrLabel35.Name = "xrLabel35";
         this.xrLabel35.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel35.SizeF = new System.Drawing.SizeF(84.86456F, 18F);
         this.xrLabel35.StylePriority.UseFont = false;
         this.xrLabel35.StylePriority.UseTextAlignment = false;
         this.xrLabel35.Text = "xrLabel35";
         this.xrLabel35.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
         // 
         // TopMargin
         // 
         this.TopMargin.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrPageInfo2});
         this.TopMargin.HeightF = 48.95833F;
         this.TopMargin.Name = "TopMargin";
         this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
         this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
         // 
         // xrPageInfo2
         // 
         this.xrPageInfo2.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
         this.xrPageInfo2.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
         this.xrPageInfo2.Format = "Ημερομηνία Εκτύπωσης : {0:dddd, d MMMM yyyy h:mm:ss tt}";
         this.xrPageInfo2.LocationFloat = new DevExpress.Utils.PointFloat(0F, 30.19562F);
         this.xrPageInfo2.Name = "xrPageInfo2";
         this.xrPageInfo2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrPageInfo2.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime;
         this.xrPageInfo2.SizeF = new System.Drawing.SizeF(1069F, 18.76271F);
         this.xrPageInfo2.StylePriority.UseBorders = false;
         this.xrPageInfo2.StylePriority.UseFont = false;
         // 
         // BottomMargin
         // 
         this.BottomMargin.HeightF = 24.62508F;
         this.BottomMargin.Name = "BottomMargin";
         this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
         this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
         // 
         // groupHeaderBand1
         // 
         this.groupHeaderBand1.BackColor = System.Drawing.Color.Silver;
         this.groupHeaderBand1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel2});
         this.groupHeaderBand1.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("DepartmentId", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
         this.groupHeaderBand1.HeightF = 16.20833F;
         this.groupHeaderBand1.Level = 3;
         this.groupHeaderBand1.Name = "groupHeaderBand1";
         this.groupHeaderBand1.StylePriority.UseBackColor = false;
         // 
         // xrLabel2
         // 
         this.xrLabel2.BackColor = System.Drawing.Color.Gray;
         this.xrLabel2.Borders = DevExpress.XtraPrinting.BorderSide.None;
         this.xrLabel2.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.DepartmentDescription", "Department: {0}")});
         this.xrLabel2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
         this.xrLabel2.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
         this.xrLabel2.Name = "xrLabel2";
         this.xrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel2.SizeF = new System.Drawing.SizeF(1069F, 16F);
         this.xrLabel2.StyleName = "DataField";
         this.xrLabel2.StylePriority.UseBackColor = false;
         this.xrLabel2.StylePriority.UseBorders = false;
         this.xrLabel2.StylePriority.UseFont = false;
         this.xrLabel2.StylePriority.UseTextAlignment = false;
         this.xrLabel2.Text = "xrLabel2";
         this.xrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
         // 
         // groupHeaderBand2
         // 
         this.groupHeaderBand2.BackColor = System.Drawing.Color.Silver;
         this.groupHeaderBand2.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel4});
         this.groupHeaderBand2.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("PosInfoId", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
         this.groupHeaderBand2.HeightF = 15F;
         this.groupHeaderBand2.Level = 2;
         this.groupHeaderBand2.Name = "groupHeaderBand2";
         this.groupHeaderBand2.StylePriority.UseBackColor = false;
         // 
         // xrLabel4
         // 
         this.xrLabel4.BackColor = System.Drawing.Color.Silver;
         this.xrLabel4.Borders = DevExpress.XtraPrinting.BorderSide.None;
         this.xrLabel4.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.PosInfoDescription", "POS Description: {0}")});
         this.xrLabel4.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
         this.xrLabel4.LocationFloat = new DevExpress.Utils.PointFloat(7.947286E-06F, 0F);
         this.xrLabel4.Name = "xrLabel4";
         this.xrLabel4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel4.SizeF = new System.Drawing.SizeF(1069F, 15F);
         this.xrLabel4.StyleName = "DataField";
         this.xrLabel4.StylePriority.UseBackColor = false;
         this.xrLabel4.StylePriority.UseBorders = false;
         this.xrLabel4.StylePriority.UseFont = false;
         this.xrLabel4.StylePriority.UseTextAlignment = false;
         this.xrLabel4.Text = "xrLabel4";
         this.xrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
         // 
         // groupHeaderBand3
         // 
         this.groupHeaderBand3.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel21,
            this.xrLabel22,
            this.xrLabel23,
            this.xrLabel37,
            this.xrLabel20,
            this.xrLabel6,
            this.xrLabel44,
            this.xrLabel49});
         this.groupHeaderBand3.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("AccountType", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
         this.groupHeaderBand3.HeightF = 14F;
         this.groupHeaderBand3.Level = 1;
         this.groupHeaderBand3.Name = "groupHeaderBand3";
         // 
         // xrLabel21
         // 
         this.xrLabel21.BackColor = System.Drawing.Color.LightGray;
         this.xrLabel21.Borders = DevExpress.XtraPrinting.BorderSide.Top;
         this.xrLabel21.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.Vat3", "{0:C2}")});
         this.xrLabel21.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
         this.xrLabel21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
         this.xrLabel21.LocationFloat = new DevExpress.Utils.PointFloat(641.4096F, 0F);
         this.xrLabel21.Name = "xrLabel21";
         this.xrLabel21.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel21.SizeF = new System.Drawing.SizeF(86.25061F, 14F);
         this.xrLabel21.StyleName = "FieldCaption";
         this.xrLabel21.StylePriority.UseBackColor = false;
         this.xrLabel21.StylePriority.UseBorders = false;
         this.xrLabel21.StylePriority.UseFont = false;
         this.xrLabel21.StylePriority.UseForeColor = false;
         this.xrLabel21.StylePriority.UseTextAlignment = false;
         xrSummary1.FormatString = "{0:#,##0.00}";
         xrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
         this.xrLabel21.Summary = xrSummary1;
         this.xrLabel21.Text = "xrLabel46";
         this.xrLabel21.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
         // 
         // xrLabel22
         // 
         this.xrLabel22.BackColor = System.Drawing.Color.LightGray;
         this.xrLabel22.Borders = DevExpress.XtraPrinting.BorderSide.Top;
         this.xrLabel22.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.Vat4", "{0:C2}")});
         this.xrLabel22.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
         this.xrLabel22.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
         this.xrLabel22.LocationFloat = new DevExpress.Utils.PointFloat(727.6602F, 0F);
         this.xrLabel22.Name = "xrLabel22";
         this.xrLabel22.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel22.SizeF = new System.Drawing.SizeF(85.25061F, 14F);
         this.xrLabel22.StyleName = "FieldCaption";
         this.xrLabel22.StylePriority.UseBackColor = false;
         this.xrLabel22.StylePriority.UseBorders = false;
         this.xrLabel22.StylePriority.UseFont = false;
         this.xrLabel22.StylePriority.UseForeColor = false;
         this.xrLabel22.StylePriority.UseTextAlignment = false;
         xrSummary2.FormatString = "{0:#,##0.00}";
         xrSummary2.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
         this.xrLabel22.Summary = xrSummary2;
         this.xrLabel22.Text = "xrLabel47";
         this.xrLabel22.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
         // 
         // xrLabel23
         // 
         this.xrLabel23.BackColor = System.Drawing.Color.LightGray;
         this.xrLabel23.Borders = DevExpress.XtraPrinting.BorderSide.Top;
         this.xrLabel23.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.Vat5", "{0:C2}")});
         this.xrLabel23.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
         this.xrLabel23.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
         this.xrLabel23.LocationFloat = new DevExpress.Utils.PointFloat(812.9108F, 0F);
         this.xrLabel23.Name = "xrLabel23";
         this.xrLabel23.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel23.SizeF = new System.Drawing.SizeF(84.86456F, 14F);
         this.xrLabel23.StyleName = "FieldCaption";
         this.xrLabel23.StylePriority.UseBackColor = false;
         this.xrLabel23.StylePriority.UseBorders = false;
         this.xrLabel23.StylePriority.UseFont = false;
         this.xrLabel23.StylePriority.UseForeColor = false;
         this.xrLabel23.StylePriority.UseTextAlignment = false;
         xrSummary3.FormatString = "{0:#,##0.00}";
         xrSummary3.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
         this.xrLabel23.Summary = xrSummary3;
         this.xrLabel23.Text = "xrLabel48";
         this.xrLabel23.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
         // 
         // xrLabel37
         // 
         this.xrLabel37.BackColor = System.Drawing.Color.LightGray;
         this.xrLabel37.Borders = DevExpress.XtraPrinting.BorderSide.Top;
         this.xrLabel37.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.TransAmount", "{0:C2}")});
         this.xrLabel37.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
         this.xrLabel37.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
         this.xrLabel37.LocationFloat = new DevExpress.Utils.PointFloat(897.7754F, 0F);
         this.xrLabel37.Name = "xrLabel37";
         this.xrLabel37.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel37.SizeF = new System.Drawing.SizeF(171.2246F, 14F);
         this.xrLabel37.StyleName = "FieldCaption";
         this.xrLabel37.StylePriority.UseBackColor = false;
         this.xrLabel37.StylePriority.UseBorders = false;
         this.xrLabel37.StylePriority.UseFont = false;
         this.xrLabel37.StylePriority.UseForeColor = false;
         this.xrLabel37.StylePriority.UseTextAlignment = false;
         xrSummary4.FormatString = "{0:#,##0.00}";
         xrSummary4.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
         this.xrLabel37.Summary = xrSummary4;
         this.xrLabel37.Text = "xrLabel43";
         this.xrLabel37.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
         // 
         // xrLabel20
         // 
         this.xrLabel20.BackColor = System.Drawing.Color.LightGray;
         this.xrLabel20.Borders = DevExpress.XtraPrinting.BorderSide.Top;
         this.xrLabel20.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.Vat2", "{0:C2}")});
         this.xrLabel20.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
         this.xrLabel20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
         this.xrLabel20.LocationFloat = new DevExpress.Utils.PointFloat(555.159F, 0F);
         this.xrLabel20.Name = "xrLabel20";
         this.xrLabel20.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel20.SizeF = new System.Drawing.SizeF(86.25061F, 14F);
         this.xrLabel20.StyleName = "FieldCaption";
         this.xrLabel20.StylePriority.UseBackColor = false;
         this.xrLabel20.StylePriority.UseBorders = false;
         this.xrLabel20.StylePriority.UseFont = false;
         this.xrLabel20.StylePriority.UseForeColor = false;
         this.xrLabel20.StylePriority.UseTextAlignment = false;
         xrSummary5.FormatString = "{0:#,##0.00}";
         xrSummary5.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
         this.xrLabel20.Summary = xrSummary5;
         this.xrLabel20.Text = "xrLabel45";
         this.xrLabel20.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
         // 
         // xrLabel6
         // 
         this.xrLabel6.BackColor = System.Drawing.Color.LightGray;
         this.xrLabel6.Borders = DevExpress.XtraPrinting.BorderSide.Top;
         this.xrLabel6.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.AccountDescription", "Account Description: {0}")});
         this.xrLabel6.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
         this.xrLabel6.LocationFloat = new DevExpress.Utils.PointFloat(7.947286E-06F, 0F);
         this.xrLabel6.Name = "xrLabel6";
         this.xrLabel6.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel6.SizeF = new System.Drawing.SizeF(383.8407F, 14F);
         this.xrLabel6.StyleName = "DataField";
         this.xrLabel6.StylePriority.UseBackColor = false;
         this.xrLabel6.StylePriority.UseBorders = false;
         this.xrLabel6.StylePriority.UseFont = false;
         this.xrLabel6.Text = "xrLabel6";
         // 
         // xrLabel44
         // 
         this.xrLabel44.BackColor = System.Drawing.Color.LightGray;
         this.xrLabel44.Borders = DevExpress.XtraPrinting.BorderSide.Top;
         this.xrLabel44.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.Vat1", "{0:C2}")});
         this.xrLabel44.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
         this.xrLabel44.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
         this.xrLabel44.LocationFloat = new DevExpress.Utils.PointFloat(469.9083F, 0F);
         this.xrLabel44.Name = "xrLabel44";
         this.xrLabel44.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel44.SizeF = new System.Drawing.SizeF(85.25067F, 14F);
         this.xrLabel44.StyleName = "FieldCaption";
         this.xrLabel44.StylePriority.UseBackColor = false;
         this.xrLabel44.StylePriority.UseBorders = false;
         this.xrLabel44.StylePriority.UseFont = false;
         this.xrLabel44.StylePriority.UseForeColor = false;
         this.xrLabel44.StylePriority.UseTextAlignment = false;
         xrSummary6.FormatString = "{0:#,##0.00}";
         xrSummary6.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
         this.xrLabel44.Summary = xrSummary6;
         this.xrLabel44.Text = "xrLabel44";
         this.xrLabel44.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
         // 
         // xrLabel49
         // 
         this.xrLabel49.BackColor = System.Drawing.Color.LightGray;
         this.xrLabel49.Borders = DevExpress.XtraPrinting.BorderSide.Top;
         this.xrLabel49.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
         this.xrLabel49.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
         this.xrLabel49.LocationFloat = new DevExpress.Utils.PointFloat(383.8407F, 0F);
         this.xrLabel49.Name = "xrLabel49";
         this.xrLabel49.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel49.SizeF = new System.Drawing.SizeF(86.06763F, 14F);
         this.xrLabel49.StyleName = "FieldCaption";
         this.xrLabel49.StylePriority.UseBackColor = false;
         this.xrLabel49.StylePriority.UseBorders = false;
         this.xrLabel49.StylePriority.UseFont = false;
         this.xrLabel49.StylePriority.UseForeColor = false;
         this.xrLabel49.StylePriority.UseTextAlignment = false;
         this.xrLabel49.Text = "Σύνολα :";
         this.xrLabel49.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
         // 
         // groupHeaderBand4
         // 
         this.groupHeaderBand4.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel3,
            this.xrLabel7,
            this.xrLabel8,
            this.xrLabel10,
            this.xrLabel11,
            this.xrLabel12,
            this.xrLabel13,
            this.xrLabel15,
            this.xrLabel16,
            this.xrLabel17,
            this.xrLabel18,
            this.xrLine2,
            this.xrLabel19});
         this.groupHeaderBand4.HeightF = 20.91668F;
         this.groupHeaderBand4.Name = "groupHeaderBand4";
         this.groupHeaderBand4.StyleName = "FieldCaption";
         // 
         // xrLabel3
         // 
         this.xrLabel3.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
         this.xrLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
         this.xrLabel3.LocationFloat = new DevExpress.Utils.PointFloat(897.7754F, 9.536743E-07F);
         this.xrLabel3.Name = "xrLabel3";
         this.xrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel3.SizeF = new System.Drawing.SizeF(81.05853F, 18F);
         this.xrLabel3.StylePriority.UseFont = false;
         this.xrLabel3.StylePriority.UseForeColor = false;
         this.xrLabel3.StylePriority.UseTextAlignment = false;
         this.xrLabel3.Text = "Σύνολο";
         this.xrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
         // 
         // xrLabel7
         // 
         this.xrLabel7.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
         this.xrLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
         this.xrLabel7.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
         this.xrLabel7.Name = "xrLabel7";
         this.xrLabel7.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel7.SizeF = new System.Drawing.SizeF(81.05846F, 18F);
         this.xrLabel7.StylePriority.UseFont = false;
         this.xrLabel7.StylePriority.UseForeColor = false;
         this.xrLabel7.StylePriority.UseTextAlignment = false;
         this.xrLabel7.Text = "Τύπος";
         this.xrLabel7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
         // 
         // xrLabel8
         // 
         this.xrLabel8.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
         this.xrLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
         this.xrLabel8.LocationFloat = new DevExpress.Utils.PointFloat(81.05846F, 0F);
         this.xrLabel8.Name = "xrLabel8";
         this.xrLabel8.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel8.SizeF = new System.Drawing.SizeF(66.94154F, 18F);
         this.xrLabel8.StylePriority.UseFont = false;
         this.xrLabel8.StylePriority.UseForeColor = false;
         this.xrLabel8.StylePriority.UseTextAlignment = false;
         this.xrLabel8.Text = "#Απόδ.";
         this.xrLabel8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
         // 
         // xrLabel10
         // 
         this.xrLabel10.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
         this.xrLabel10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
         this.xrLabel10.LocationFloat = new DevExpress.Utils.PointFloat(345.8838F, 0F);
         this.xrLabel10.Name = "xrLabel10";
         this.xrLabel10.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel10.SizeF = new System.Drawing.SizeF(64.07385F, 18F);
         this.xrLabel10.StylePriority.UseFont = false;
         this.xrLabel10.StylePriority.UseForeColor = false;
         this.xrLabel10.StylePriority.UseTextAlignment = false;
         this.xrLabel10.Text = "Δωμάτιο";
         this.xrLabel10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
         // 
         // xrLabel11
         // 
         this.xrLabel11.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
         this.xrLabel11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
         this.xrLabel11.LocationFloat = new DevExpress.Utils.PointFloat(148F, 0F);
         this.xrLabel11.Name = "xrLabel11";
         this.xrLabel11.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel11.SizeF = new System.Drawing.SizeF(197.8838F, 18F);
         this.xrLabel11.StylePriority.UseFont = false;
         this.xrLabel11.StylePriority.UseForeColor = false;
         this.xrLabel11.StylePriority.UseTextAlignment = false;
         this.xrLabel11.Text = "Προσωπικό";
         this.xrLabel11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
         // 
         // xrLabel12
         // 
         this.xrLabel12.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
         this.xrLabel12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
         this.xrLabel12.LocationFloat = new DevExpress.Utils.PointFloat(409.9576F, 0F);
         this.xrLabel12.Name = "xrLabel12";
         this.xrLabel12.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel12.SizeF = new System.Drawing.SizeF(59.95053F, 18F);
         this.xrLabel12.StylePriority.UseFont = false;
         this.xrLabel12.StylePriority.UseForeColor = false;
         this.xrLabel12.StylePriority.UseTextAlignment = false;
         this.xrLabel12.Text = "Τραπέζι";
         this.xrLabel12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
         // 
         // xrLabel13
         // 
         this.xrLabel13.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
         this.xrLabel13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
         this.xrLabel13.LocationFloat = new DevExpress.Utils.PointFloat(978.8339F, 0F);
         this.xrLabel13.Name = "xrLabel13";
         this.xrLabel13.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel13.SizeF = new System.Drawing.SizeF(90.16615F, 18F);
         this.xrLabel13.StylePriority.UseFont = false;
         this.xrLabel13.StylePriority.UseForeColor = false;
         this.xrLabel13.StylePriority.UseTextAlignment = false;
         this.xrLabel13.Text = "Πληρωμένο";
         this.xrLabel13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
         // 
         // xrLabel15
         // 
         this.xrLabel15.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.Vat2Pst")});
         this.xrLabel15.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
         this.xrLabel15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
         this.xrLabel15.LocationFloat = new DevExpress.Utils.PointFloat(555.1589F, 0F);
         this.xrLabel15.Name = "xrLabel15";
         this.xrLabel15.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel15.SizeF = new System.Drawing.SizeF(86.25067F, 18F);
         this.xrLabel15.StylePriority.UseFont = false;
         this.xrLabel15.StylePriority.UseForeColor = false;
         this.xrLabel15.StylePriority.UseTextAlignment = false;
         xrSummary7.FormatString = "ΦΠΑ {0:0.##}%";
         xrSummary7.Func = DevExpress.XtraReports.UI.SummaryFunc.Max;
         xrSummary7.Running = DevExpress.XtraReports.UI.SummaryRunning.Report;
         this.xrLabel15.Summary = xrSummary7;
         this.xrLabel15.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
         // 
         // xrLabel16
         // 
         this.xrLabel16.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.Vat3Pst")});
         this.xrLabel16.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
         this.xrLabel16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
         this.xrLabel16.LocationFloat = new DevExpress.Utils.PointFloat(641.4096F, 0F);
         this.xrLabel16.Name = "xrLabel16";
         this.xrLabel16.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel16.SizeF = new System.Drawing.SizeF(86.25061F, 18F);
         this.xrLabel16.StylePriority.UseFont = false;
         this.xrLabel16.StylePriority.UseForeColor = false;
         this.xrLabel16.StylePriority.UseTextAlignment = false;
         xrSummary8.FormatString = "ΦΠΑ {0:0.##}%";
         xrSummary8.Func = DevExpress.XtraReports.UI.SummaryFunc.Max;
         xrSummary8.Running = DevExpress.XtraReports.UI.SummaryRunning.Report;
         this.xrLabel16.Summary = xrSummary8;
         this.xrLabel16.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
         // 
         // xrLabel17
         // 
         this.xrLabel17.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.Vat4Pst")});
         this.xrLabel17.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
         this.xrLabel17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
         this.xrLabel17.LocationFloat = new DevExpress.Utils.PointFloat(727.6602F, 0F);
         this.xrLabel17.Name = "xrLabel17";
         this.xrLabel17.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel17.SizeF = new System.Drawing.SizeF(85.25061F, 18F);
         this.xrLabel17.StylePriority.UseFont = false;
         this.xrLabel17.StylePriority.UseForeColor = false;
         this.xrLabel17.StylePriority.UseTextAlignment = false;
         xrSummary9.FormatString = "ΦΠΑ {0:0.##}%";
         xrSummary9.Func = DevExpress.XtraReports.UI.SummaryFunc.Max;
         xrSummary9.Running = DevExpress.XtraReports.UI.SummaryRunning.Report;
         this.xrLabel17.Summary = xrSummary9;
         this.xrLabel17.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
         // 
         // xrLabel18
         // 
         this.xrLabel18.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.Vat5Pst")});
         this.xrLabel18.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
         this.xrLabel18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
         this.xrLabel18.LocationFloat = new DevExpress.Utils.PointFloat(812.9108F, 9.536743E-07F);
         this.xrLabel18.Name = "xrLabel18";
         this.xrLabel18.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel18.SizeF = new System.Drawing.SizeF(84.86456F, 18F);
         this.xrLabel18.StylePriority.UseFont = false;
         this.xrLabel18.StylePriority.UseForeColor = false;
         this.xrLabel18.StylePriority.UseTextAlignment = false;
         xrSummary10.FormatString = "ΦΠΑ {0:0.##}%";
         xrSummary10.Func = DevExpress.XtraReports.UI.SummaryFunc.Max;
         xrSummary10.Running = DevExpress.XtraReports.UI.SummaryRunning.Report;
         this.xrLabel18.Summary = xrSummary10;
         this.xrLabel18.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
         // 
         // xrLine2
         // 
         this.xrLine2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
         this.xrLine2.LocationFloat = new DevExpress.Utils.PointFloat(0F, 18.91668F);
         this.xrLine2.Name = "xrLine2";
         this.xrLine2.SizeF = new System.Drawing.SizeF(1069F, 2F);
         this.xrLine2.StylePriority.UseForeColor = false;
         // 
         // xrLabel19
         // 
         this.xrLabel19.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.Vat1Pst")});
         this.xrLabel19.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
         this.xrLabel19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
         this.xrLabel19.LocationFloat = new DevExpress.Utils.PointFloat(469.9081F, 0F);
         this.xrLabel19.Name = "xrLabel19";
         this.xrLabel19.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel19.SizeF = new System.Drawing.SizeF(85.25079F, 18F);
         this.xrLabel19.StyleName = "FieldCaption";
         this.xrLabel19.StylePriority.UseFont = false;
         this.xrLabel19.StylePriority.UseForeColor = false;
         this.xrLabel19.StylePriority.UseTextAlignment = false;
         xrSummary11.FormatString = "ΦΠΑ {0:0.##}%";
         xrSummary11.Func = DevExpress.XtraReports.UI.SummaryFunc.Max;
         xrSummary11.Running = DevExpress.XtraReports.UI.SummaryRunning.Report;
         this.xrLabel19.Summary = xrSummary11;
         this.xrLabel19.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
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
         this.xrPageInfo1.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
         this.xrPageInfo1.Format = "Σελίδα {0} από {1}";
         this.xrPageInfo1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
         this.xrPageInfo1.Name = "xrPageInfo1";
         this.xrPageInfo1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrPageInfo1.SizeF = new System.Drawing.SizeF(1069F, 18.76271F);
         this.xrPageInfo1.StylePriority.UseBorders = false;
         this.xrPageInfo1.StylePriority.UseFont = false;
         this.xrPageInfo1.StylePriority.UseTextAlignment = false;
         this.xrPageInfo1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
         // 
         // reportHeaderBand1
         // 
         this.reportHeaderBand1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel66,
            this.xrLabel41});
         this.reportHeaderBand1.HeightF = 22.79168F;
         this.reportHeaderBand1.Name = "reportHeaderBand1";
         // 
         // xrLabel66
         // 
         this.xrLabel66.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding(this.UpToFODay, "Text", " έως: {0})")});
         this.xrLabel66.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
         this.xrLabel66.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
         this.xrLabel66.LocationFloat = new DevExpress.Utils.PointFloat(604.9576F, 0.7916768F);
         this.xrLabel66.Name = "xrLabel66";
         this.xrLabel66.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel66.SizeF = new System.Drawing.SizeF(464.0424F, 22F);
         this.xrLabel66.StyleName = "Title";
         this.xrLabel66.StylePriority.UseFont = false;
         this.xrLabel66.StylePriority.UseForeColor = false;
         this.xrLabel66.StylePriority.UseTextAlignment = false;
         this.xrLabel66.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
         // 
         // UpToFODay
         // 
         this.UpToFODay.Description = "UpTo Date";
         this.UpToFODay.Name = "UpToFODay";
         this.UpToFODay.Type = typeof(System.DateTime);
         this.UpToFODay.ValueInfo = "2016-05-31";
         // 
         // xrLabel41
         // 
         this.xrLabel41.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding(this.FromFODay, "Text", "Αποδείξεις με ΦΠΑ (από: {0}")});
         this.xrLabel41.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
         this.xrLabel41.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
         this.xrLabel41.LocationFloat = new DevExpress.Utils.PointFloat(0.0001220703F, 0.7916768F);
         this.xrLabel41.Name = "xrLabel41";
         this.xrLabel41.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel41.SizeF = new System.Drawing.SizeF(604.9575F, 22F);
         this.xrLabel41.StyleName = "Title";
         this.xrLabel41.StylePriority.UseFont = false;
         this.xrLabel41.StylePriority.UseForeColor = false;
         this.xrLabel41.StylePriority.UseTextAlignment = false;
         this.xrLabel41.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
         // 
         // FromFODay
         // 
         this.FromFODay.Description = "From Date";
         this.FromFODay.Name = "FromFODay";
         this.FromFODay.Type = typeof(System.DateTime);
         this.FromFODay.ValueInfo = "2016-05-31";
         // 
         // groupFooterBand1
         // 
         this.groupFooterBand1.HeightF = 1F;
         this.groupFooterBand1.Name = "groupFooterBand1";
         // 
         // groupFooterBand2
         // 
         this.groupFooterBand2.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel38,
            this.xrLabel14,
            this.xrLine3,
            this.xrLabel42,
            this.xrLabel43,
            this.xrLabel45,
            this.xrLabel46,
            this.xrLabel47,
            this.xrLabel48});
         this.groupFooterBand2.HeightF = 30F;
         this.groupFooterBand2.Level = 1;
         this.groupFooterBand2.Name = "groupFooterBand2";
         this.groupFooterBand2.Visible = false;
         // 
         // xrLabel38
         // 
         this.xrLabel38.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
         this.xrLabel38.LocationFloat = new DevExpress.Utils.PointFloat(216.3158F, 6F);
         this.xrLabel38.Name = "xrLabel38";
         this.xrLabel38.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel38.SizeF = new System.Drawing.SizeF(195.6418F, 18F);
         this.xrLabel38.StyleName = "FieldCaption";
         this.xrLabel38.StylePriority.UseForeColor = false;
         this.xrLabel38.StylePriority.UseTextAlignment = false;
         this.xrLabel38.Text = "Account - Σύνολα :";
         this.xrLabel38.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
         // 
         // xrLabel14
         // 
         this.xrLabel14.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.Vat1", "{0:C2}")});
         this.xrLabel14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
         this.xrLabel14.LocationFloat = new DevExpress.Utils.PointFloat(469.9083F, 6.00001F);
         this.xrLabel14.Name = "xrLabel14";
         this.xrLabel14.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel14.SizeF = new System.Drawing.SizeF(82.86469F, 18F);
         this.xrLabel14.StyleName = "FieldCaption";
         this.xrLabel14.StylePriority.UseForeColor = false;
         this.xrLabel14.StylePriority.UseTextAlignment = false;
         xrSummary12.FormatString = "{0:#0.00}";
         xrSummary12.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
         this.xrLabel14.Summary = xrSummary12;
         this.xrLabel14.Text = "xrLabel44";
         this.xrLabel14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
         // 
         // xrLine3
         // 
         this.xrLine3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
         this.xrLine3.LocationFloat = new DevExpress.Utils.PointFloat(0.0001220703F, 0F);
         this.xrLine3.Name = "xrLine3";
         this.xrLine3.SizeF = new System.Drawing.SizeF(1069F, 2F);
         this.xrLine3.StylePriority.UseForeColor = false;
         // 
         // xrLabel42
         // 
         this.xrLabel42.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.InvoiceTotal", "{0:C2}")});
         this.xrLabel42.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
         this.xrLabel42.LocationFloat = new DevExpress.Utils.PointFloat(897.7754F, 6F);
         this.xrLabel42.Name = "xrLabel42";
         this.xrLabel42.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel42.SizeF = new System.Drawing.SizeF(81.05846F, 18F);
         this.xrLabel42.StyleName = "FieldCaption";
         this.xrLabel42.StylePriority.UseForeColor = false;
         this.xrLabel42.StylePriority.UseTextAlignment = false;
         xrSummary13.FormatString = "{0:#0.00}";
         xrSummary13.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
         this.xrLabel42.Summary = xrSummary13;
         this.xrLabel42.Text = "xrLabel42";
         this.xrLabel42.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
         // 
         // xrLabel43
         // 
         this.xrLabel43.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.TransAmount", "{0:C2}")});
         this.xrLabel43.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
         this.xrLabel43.LocationFloat = new DevExpress.Utils.PointFloat(978.8339F, 6F);
         this.xrLabel43.Name = "xrLabel43";
         this.xrLabel43.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel43.SizeF = new System.Drawing.SizeF(90.16615F, 18F);
         this.xrLabel43.StyleName = "FieldCaption";
         this.xrLabel43.StylePriority.UseForeColor = false;
         this.xrLabel43.StylePriority.UseTextAlignment = false;
         xrSummary14.FormatString = "{0:#0.00}";
         xrSummary14.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
         this.xrLabel43.Summary = xrSummary14;
         this.xrLabel43.Text = "xrLabel43";
         this.xrLabel43.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
         // 
         // xrLabel45
         // 
         this.xrLabel45.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.Vat2", "{0:C2}")});
         this.xrLabel45.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
         this.xrLabel45.LocationFloat = new DevExpress.Utils.PointFloat(555.159F, 6.00001F);
         this.xrLabel45.Name = "xrLabel45";
         this.xrLabel45.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel45.SizeF = new System.Drawing.SizeF(83.86462F, 18F);
         this.xrLabel45.StyleName = "FieldCaption";
         this.xrLabel45.StylePriority.UseForeColor = false;
         this.xrLabel45.StylePriority.UseTextAlignment = false;
         xrSummary15.FormatString = "{0:#0.00}";
         xrSummary15.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
         this.xrLabel45.Summary = xrSummary15;
         this.xrLabel45.Text = "xrLabel45";
         this.xrLabel45.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
         // 
         // xrLabel46
         // 
         this.xrLabel46.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.Vat3", "{0:C2}")});
         this.xrLabel46.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
         this.xrLabel46.LocationFloat = new DevExpress.Utils.PointFloat(641.4096F, 6.00001F);
         this.xrLabel46.Name = "xrLabel46";
         this.xrLabel46.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel46.SizeF = new System.Drawing.SizeF(83.86462F, 18F);
         this.xrLabel46.StyleName = "FieldCaption";
         this.xrLabel46.StylePriority.UseForeColor = false;
         this.xrLabel46.StylePriority.UseTextAlignment = false;
         xrSummary16.FormatString = "{0:#0.00}";
         xrSummary16.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
         this.xrLabel46.Summary = xrSummary16;
         this.xrLabel46.Text = "xrLabel46";
         this.xrLabel46.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
         // 
         // xrLabel47
         // 
         this.xrLabel47.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.Vat4", "{0:C2}")});
         this.xrLabel47.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
         this.xrLabel47.LocationFloat = new DevExpress.Utils.PointFloat(727.6602F, 6.00001F);
         this.xrLabel47.Name = "xrLabel47";
         this.xrLabel47.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel47.SizeF = new System.Drawing.SizeF(83.86462F, 18F);
         this.xrLabel47.StyleName = "FieldCaption";
         this.xrLabel47.StylePriority.UseForeColor = false;
         this.xrLabel47.StylePriority.UseTextAlignment = false;
         xrSummary17.FormatString = "{0:#0.00}";
         xrSummary17.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
         this.xrLabel47.Summary = xrSummary17;
         this.xrLabel47.Text = "xrLabel47";
         this.xrLabel47.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
         // 
         // xrLabel48
         // 
         this.xrLabel48.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.Vat5", "{0:C2}")});
         this.xrLabel48.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
         this.xrLabel48.LocationFloat = new DevExpress.Utils.PointFloat(813.9108F, 6.00001F);
         this.xrLabel48.Name = "xrLabel48";
         this.xrLabel48.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel48.SizeF = new System.Drawing.SizeF(83.86456F, 18F);
         this.xrLabel48.StyleName = "FieldCaption";
         this.xrLabel48.StylePriority.UseForeColor = false;
         this.xrLabel48.StylePriority.UseTextAlignment = false;
         xrSummary18.FormatString = "{0:#0.00}";
         xrSummary18.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
         this.xrLabel48.Summary = xrSummary18;
         this.xrLabel48.Text = "xrLabel48";
         this.xrLabel48.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
         // 
         // groupFooterBand3
         // 
         this.groupFooterBand3.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLine4,
            this.xrLabel51,
            this.xrLabel52,
            this.xrLabel53,
            this.xrLabel54,
            this.xrLabel55,
            this.xrLabel56,
            this.xrLabel57});
         this.groupFooterBand3.HeightF = 21.00001F;
         this.groupFooterBand3.Level = 2;
         this.groupFooterBand3.Name = "groupFooterBand3";
         // 
         // xrLine4
         // 
         this.xrLine4.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
         this.xrLine4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
         this.xrLine4.LocationFloat = new DevExpress.Utils.PointFloat(0.0001220703F, 0F);
         this.xrLine4.Name = "xrLine4";
         this.xrLine4.SizeF = new System.Drawing.SizeF(1069F, 2F);
         this.xrLine4.StylePriority.UseBorderDashStyle = false;
         this.xrLine4.StylePriority.UseForeColor = false;
         // 
         // xrLabel51
         // 
         this.xrLabel51.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.TransAmount", "{0:C2}")});
         this.xrLabel51.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
         this.xrLabel51.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
         this.xrLabel51.LocationFloat = new DevExpress.Utils.PointFloat(978.8339F, 3F);
         this.xrLabel51.Name = "xrLabel51";
         this.xrLabel51.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel51.SizeF = new System.Drawing.SizeF(90.16615F, 18F);
         this.xrLabel51.StyleName = "FieldCaption";
         this.xrLabel51.StylePriority.UseFont = false;
         this.xrLabel51.StylePriority.UseForeColor = false;
         this.xrLabel51.StylePriority.UseTextAlignment = false;
         xrSummary19.FormatString = "{0:#,##0.00}";
         xrSummary19.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
         this.xrLabel51.Summary = xrSummary19;
         this.xrLabel51.Text = "xrLabel51";
         this.xrLabel51.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
         // 
         // xrLabel52
         // 
         this.xrLabel52.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.Vat1", "{0:C2}")});
         this.xrLabel52.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
         this.xrLabel52.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
         this.xrLabel52.LocationFloat = new DevExpress.Utils.PointFloat(469.9083F, 3F);
         this.xrLabel52.Name = "xrLabel52";
         this.xrLabel52.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel52.SizeF = new System.Drawing.SizeF(82.86469F, 18F);
         this.xrLabel52.StyleName = "FieldCaption";
         this.xrLabel52.StylePriority.UseFont = false;
         this.xrLabel52.StylePriority.UseForeColor = false;
         this.xrLabel52.StylePriority.UseTextAlignment = false;
         xrSummary20.FormatString = "{0:#,##0.00}";
         xrSummary20.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
         this.xrLabel52.Summary = xrSummary20;
         this.xrLabel52.Text = "xrLabel52";
         this.xrLabel52.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
         // 
         // xrLabel53
         // 
         this.xrLabel53.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.Vat2", "{0:C2}")});
         this.xrLabel53.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
         this.xrLabel53.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
         this.xrLabel53.LocationFloat = new DevExpress.Utils.PointFloat(556.7237F, 3F);
         this.xrLabel53.Name = "xrLabel53";
         this.xrLabel53.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel53.SizeF = new System.Drawing.SizeF(82.29993F, 18F);
         this.xrLabel53.StyleName = "FieldCaption";
         this.xrLabel53.StylePriority.UseFont = false;
         this.xrLabel53.StylePriority.UseForeColor = false;
         this.xrLabel53.StylePriority.UseTextAlignment = false;
         xrSummary21.FormatString = "{0:#,##0.00}";
         xrSummary21.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
         this.xrLabel53.Summary = xrSummary21;
         this.xrLabel53.Text = "xrLabel53";
         this.xrLabel53.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
         // 
         // xrLabel54
         // 
         this.xrLabel54.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.Vat3", "{0:C2}")});
         this.xrLabel54.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
         this.xrLabel54.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
         this.xrLabel54.LocationFloat = new DevExpress.Utils.PointFloat(641.4096F, 3F);
         this.xrLabel54.Name = "xrLabel54";
         this.xrLabel54.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel54.SizeF = new System.Drawing.SizeF(83.86462F, 18F);
         this.xrLabel54.StyleName = "FieldCaption";
         this.xrLabel54.StylePriority.UseFont = false;
         this.xrLabel54.StylePriority.UseForeColor = false;
         this.xrLabel54.StylePriority.UseTextAlignment = false;
         xrSummary22.FormatString = "{0:#,##0.00}";
         xrSummary22.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
         this.xrLabel54.Summary = xrSummary22;
         this.xrLabel54.Text = "xrLabel54";
         this.xrLabel54.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
         // 
         // xrLabel55
         // 
         this.xrLabel55.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.Vat4", "{0:C2}")});
         this.xrLabel55.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
         this.xrLabel55.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
         this.xrLabel55.LocationFloat = new DevExpress.Utils.PointFloat(727.6602F, 3F);
         this.xrLabel55.Name = "xrLabel55";
         this.xrLabel55.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel55.SizeF = new System.Drawing.SizeF(83.86462F, 18F);
         this.xrLabel55.StyleName = "FieldCaption";
         this.xrLabel55.StylePriority.UseFont = false;
         this.xrLabel55.StylePriority.UseForeColor = false;
         this.xrLabel55.StylePriority.UseTextAlignment = false;
         xrSummary23.FormatString = "{0:#,##0.00}";
         xrSummary23.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
         this.xrLabel55.Summary = xrSummary23;
         this.xrLabel55.Text = "xrLabel55";
         this.xrLabel55.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
         // 
         // xrLabel56
         // 
         this.xrLabel56.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.Vat5", "{0:C2}")});
         this.xrLabel56.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
         this.xrLabel56.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
         this.xrLabel56.LocationFloat = new DevExpress.Utils.PointFloat(813.9108F, 3F);
         this.xrLabel56.Name = "xrLabel56";
         this.xrLabel56.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel56.SizeF = new System.Drawing.SizeF(83.86456F, 18F);
         this.xrLabel56.StyleName = "FieldCaption";
         this.xrLabel56.StylePriority.UseFont = false;
         this.xrLabel56.StylePriority.UseForeColor = false;
         this.xrLabel56.StylePriority.UseTextAlignment = false;
         xrSummary24.FormatString = "{0:#,##0.00}";
         xrSummary24.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
         this.xrLabel56.Summary = xrSummary24;
         this.xrLabel56.Text = "xrLabel56";
         this.xrLabel56.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
         // 
         // xrLabel57
         // 
         this.xrLabel57.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
         this.xrLabel57.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
         this.xrLabel57.LocationFloat = new DevExpress.Utils.PointFloat(216.3158F, 3.00001F);
         this.xrLabel57.Name = "xrLabel57";
         this.xrLabel57.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel57.SizeF = new System.Drawing.SizeF(195.6418F, 18F);
         this.xrLabel57.StyleName = "FieldCaption";
         this.xrLabel57.StylePriority.UseFont = false;
         this.xrLabel57.StylePriority.UseForeColor = false;
         this.xrLabel57.StylePriority.UseTextAlignment = false;
         this.xrLabel57.Text = "POS - Σύνολα :";
         this.xrLabel57.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
         // 
         // groupFooterBand4
         // 
         this.groupFooterBand4.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLine5,
            this.xrLabel59,
            this.xrLabel60,
            this.xrLabel61,
            this.xrLabel62,
            this.xrLabel63,
            this.xrLabel64,
            this.xrLabel65});
         this.groupFooterBand4.HeightF = 20.00001F;
         this.groupFooterBand4.Level = 3;
         this.groupFooterBand4.Name = "groupFooterBand4";
         // 
         // xrLine5
         // 
         this.xrLine5.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
         this.xrLine5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
         this.xrLine5.LocationFloat = new DevExpress.Utils.PointFloat(0.0001220703F, 0F);
         this.xrLine5.Name = "xrLine5";
         this.xrLine5.SizeF = new System.Drawing.SizeF(1069F, 2F);
         this.xrLine5.StylePriority.UseBorderDashStyle = false;
         this.xrLine5.StylePriority.UseForeColor = false;
         // 
         // xrLabel59
         // 
         this.xrLabel59.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.TransAmount", "{0:C2}")});
         this.xrLabel59.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
         this.xrLabel59.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
         this.xrLabel59.LocationFloat = new DevExpress.Utils.PointFloat(978.8339F, 2F);
         this.xrLabel59.Name = "xrLabel59";
         this.xrLabel59.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel59.SizeF = new System.Drawing.SizeF(90.16615F, 18F);
         this.xrLabel59.StyleName = "FieldCaption";
         this.xrLabel59.StylePriority.UseFont = false;
         this.xrLabel59.StylePriority.UseForeColor = false;
         this.xrLabel59.StylePriority.UseTextAlignment = false;
         xrSummary25.FormatString = "{0:#,##0.00}";
         xrSummary25.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
         this.xrLabel59.Summary = xrSummary25;
         this.xrLabel59.Text = "xrLabel59";
         this.xrLabel59.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
         // 
         // xrLabel60
         // 
         this.xrLabel60.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.Vat1", "{0:C2}")});
         this.xrLabel60.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
         this.xrLabel60.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
         this.xrLabel60.LocationFloat = new DevExpress.Utils.PointFloat(469.9083F, 2F);
         this.xrLabel60.Name = "xrLabel60";
         this.xrLabel60.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel60.SizeF = new System.Drawing.SizeF(82.86469F, 18F);
         this.xrLabel60.StyleName = "FieldCaption";
         this.xrLabel60.StylePriority.UseFont = false;
         this.xrLabel60.StylePriority.UseForeColor = false;
         this.xrLabel60.StylePriority.UseTextAlignment = false;
         xrSummary26.FormatString = "{0:#,##0.00}";
         xrSummary26.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
         this.xrLabel60.Summary = xrSummary26;
         this.xrLabel60.Text = "xrLabel60";
         this.xrLabel60.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
         // 
         // xrLabel61
         // 
         this.xrLabel61.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.Vat2", "{0:C2}")});
         this.xrLabel61.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
         this.xrLabel61.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
         this.xrLabel61.LocationFloat = new DevExpress.Utils.PointFloat(556.7237F, 2F);
         this.xrLabel61.Name = "xrLabel61";
         this.xrLabel61.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel61.SizeF = new System.Drawing.SizeF(82.29993F, 18F);
         this.xrLabel61.StyleName = "FieldCaption";
         this.xrLabel61.StylePriority.UseFont = false;
         this.xrLabel61.StylePriority.UseForeColor = false;
         this.xrLabel61.StylePriority.UseTextAlignment = false;
         xrSummary27.FormatString = "{0:#,##0.00}";
         xrSummary27.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
         this.xrLabel61.Summary = xrSummary27;
         this.xrLabel61.Text = "xrLabel61";
         this.xrLabel61.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
         // 
         // xrLabel62
         // 
         this.xrLabel62.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.Vat3", "{0:C2}")});
         this.xrLabel62.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
         this.xrLabel62.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
         this.xrLabel62.LocationFloat = new DevExpress.Utils.PointFloat(641.4096F, 2F);
         this.xrLabel62.Name = "xrLabel62";
         this.xrLabel62.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel62.SizeF = new System.Drawing.SizeF(83.86462F, 18F);
         this.xrLabel62.StyleName = "FieldCaption";
         this.xrLabel62.StylePriority.UseFont = false;
         this.xrLabel62.StylePriority.UseForeColor = false;
         this.xrLabel62.StylePriority.UseTextAlignment = false;
         xrSummary28.FormatString = "{0:#,##0.00}";
         xrSummary28.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
         this.xrLabel62.Summary = xrSummary28;
         this.xrLabel62.Text = "xrLabel62";
         this.xrLabel62.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
         // 
         // xrLabel63
         // 
         this.xrLabel63.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.Vat4", "{0:C2}")});
         this.xrLabel63.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
         this.xrLabel63.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
         this.xrLabel63.LocationFloat = new DevExpress.Utils.PointFloat(727.6602F, 2F);
         this.xrLabel63.Name = "xrLabel63";
         this.xrLabel63.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel63.SizeF = new System.Drawing.SizeF(83.86462F, 18F);
         this.xrLabel63.StyleName = "FieldCaption";
         this.xrLabel63.StylePriority.UseFont = false;
         this.xrLabel63.StylePriority.UseForeColor = false;
         this.xrLabel63.StylePriority.UseTextAlignment = false;
         xrSummary29.FormatString = "{0:#,##0.00}";
         xrSummary29.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
         this.xrLabel63.Summary = xrSummary29;
         this.xrLabel63.Text = "xrLabel63";
         this.xrLabel63.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
         // 
         // xrLabel64
         // 
         this.xrLabel64.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.Vat5", "{0:C2}")});
         this.xrLabel64.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
         this.xrLabel64.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
         this.xrLabel64.LocationFloat = new DevExpress.Utils.PointFloat(813.9108F, 2F);
         this.xrLabel64.Name = "xrLabel64";
         this.xrLabel64.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel64.SizeF = new System.Drawing.SizeF(83.86456F, 18F);
         this.xrLabel64.StyleName = "FieldCaption";
         this.xrLabel64.StylePriority.UseFont = false;
         this.xrLabel64.StylePriority.UseForeColor = false;
         this.xrLabel64.StylePriority.UseTextAlignment = false;
         xrSummary30.FormatString = "{0:#,##0.00}";
         xrSummary30.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
         this.xrLabel64.Summary = xrSummary30;
         this.xrLabel64.Text = "xrLabel64";
         this.xrLabel64.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
         // 
         // xrLabel65
         // 
         this.xrLabel65.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
         this.xrLabel65.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
         this.xrLabel65.LocationFloat = new DevExpress.Utils.PointFloat(216.3158F, 2.00001F);
         this.xrLabel65.Name = "xrLabel65";
         this.xrLabel65.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel65.SizeF = new System.Drawing.SizeF(195.6417F, 18F);
         this.xrLabel65.StyleName = "FieldCaption";
         this.xrLabel65.StylePriority.UseFont = false;
         this.xrLabel65.StylePriority.UseForeColor = false;
         this.xrLabel65.StylePriority.UseTextAlignment = false;
         this.xrLabel65.Text = "Department - Σύνολα :";
         this.xrLabel65.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
         // 
         // reportFooterBand1
         // 
         this.reportFooterBand1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLine6,
            this.xrLabel67,
            this.xrLabel68,
            this.xrLabel69,
            this.xrLabel70,
            this.xrLabel71,
            this.xrLabel72,
            this.xrLabel73});
         this.reportFooterBand1.Expanded = false;
         this.reportFooterBand1.HeightF = 20.00001F;
         this.reportFooterBand1.Name = "reportFooterBand1";
         this.reportFooterBand1.Visible = false;
         // 
         // xrLine6
         // 
         this.xrLine6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
         this.xrLine6.LocationFloat = new DevExpress.Utils.PointFloat(6.000122F, 0F);
         this.xrLine6.Name = "xrLine6";
         this.xrLine6.SizeF = new System.Drawing.SizeF(1063F, 2F);
         this.xrLine6.StylePriority.UseForeColor = false;
         this.xrLine6.Visible = false;
         // 
         // xrLabel67
         // 
         this.xrLabel67.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.TransAmount", "{0:C2}")});
         this.xrLabel67.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
         this.xrLabel67.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
         this.xrLabel67.LocationFloat = new DevExpress.Utils.PointFloat(978.8339F, 2F);
         this.xrLabel67.Name = "xrLabel67";
         this.xrLabel67.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel67.SizeF = new System.Drawing.SizeF(90.16615F, 18F);
         this.xrLabel67.StyleName = "FieldCaption";
         this.xrLabel67.StylePriority.UseFont = false;
         this.xrLabel67.StylePriority.UseForeColor = false;
         this.xrLabel67.StylePriority.UseTextAlignment = false;
         xrSummary31.FormatString = "{0:#,##0.00}";
         xrSummary31.Running = DevExpress.XtraReports.UI.SummaryRunning.Report;
         this.xrLabel67.Summary = xrSummary31;
         this.xrLabel67.Text = "xrLabel67";
         this.xrLabel67.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
         // 
         // xrLabel68
         // 
         this.xrLabel68.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.Vat1", "{0:C2}")});
         this.xrLabel68.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
         this.xrLabel68.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
         this.xrLabel68.LocationFloat = new DevExpress.Utils.PointFloat(469.9083F, 2F);
         this.xrLabel68.Name = "xrLabel68";
         this.xrLabel68.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel68.SizeF = new System.Drawing.SizeF(82.86469F, 18F);
         this.xrLabel68.StyleName = "FieldCaption";
         this.xrLabel68.StylePriority.UseFont = false;
         this.xrLabel68.StylePriority.UseForeColor = false;
         this.xrLabel68.StylePriority.UseTextAlignment = false;
         xrSummary32.FormatString = "{0:#,##0.00}";
         xrSummary32.Running = DevExpress.XtraReports.UI.SummaryRunning.Report;
         this.xrLabel68.Summary = xrSummary32;
         this.xrLabel68.Text = "xrLabel68";
         this.xrLabel68.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
         // 
         // xrLabel69
         // 
         this.xrLabel69.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.Vat2", "{0:C2}")});
         this.xrLabel69.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
         this.xrLabel69.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
         this.xrLabel69.LocationFloat = new DevExpress.Utils.PointFloat(556.7237F, 2F);
         this.xrLabel69.Name = "xrLabel69";
         this.xrLabel69.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel69.SizeF = new System.Drawing.SizeF(82.29993F, 18F);
         this.xrLabel69.StyleName = "FieldCaption";
         this.xrLabel69.StylePriority.UseFont = false;
         this.xrLabel69.StylePriority.UseForeColor = false;
         this.xrLabel69.StylePriority.UseTextAlignment = false;
         xrSummary33.FormatString = "{0:#,##0.00}";
         xrSummary33.Running = DevExpress.XtraReports.UI.SummaryRunning.Report;
         this.xrLabel69.Summary = xrSummary33;
         this.xrLabel69.Text = "xrLabel69";
         this.xrLabel69.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
         // 
         // xrLabel70
         // 
         this.xrLabel70.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.Vat3", "{0:C2}")});
         this.xrLabel70.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
         this.xrLabel70.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
         this.xrLabel70.LocationFloat = new DevExpress.Utils.PointFloat(641.4096F, 2F);
         this.xrLabel70.Name = "xrLabel70";
         this.xrLabel70.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel70.SizeF = new System.Drawing.SizeF(83.86462F, 18F);
         this.xrLabel70.StyleName = "FieldCaption";
         this.xrLabel70.StylePriority.UseFont = false;
         this.xrLabel70.StylePriority.UseForeColor = false;
         this.xrLabel70.StylePriority.UseTextAlignment = false;
         xrSummary34.FormatString = "{0:#,##0.00}";
         xrSummary34.Running = DevExpress.XtraReports.UI.SummaryRunning.Report;
         this.xrLabel70.Summary = xrSummary34;
         this.xrLabel70.Text = "xrLabel70";
         this.xrLabel70.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
         // 
         // xrLabel71
         // 
         this.xrLabel71.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.Vat4", "{0:C2}")});
         this.xrLabel71.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
         this.xrLabel71.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
         this.xrLabel71.LocationFloat = new DevExpress.Utils.PointFloat(727.6602F, 2F);
         this.xrLabel71.Name = "xrLabel71";
         this.xrLabel71.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel71.SizeF = new System.Drawing.SizeF(83.86462F, 18F);
         this.xrLabel71.StyleName = "FieldCaption";
         this.xrLabel71.StylePriority.UseFont = false;
         this.xrLabel71.StylePriority.UseForeColor = false;
         this.xrLabel71.StylePriority.UseTextAlignment = false;
         xrSummary35.FormatString = "{0:#,##0.00}";
         xrSummary35.Running = DevExpress.XtraReports.UI.SummaryRunning.Report;
         this.xrLabel71.Summary = xrSummary35;
         this.xrLabel71.Text = "xrLabel71";
         this.xrLabel71.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
         // 
         // xrLabel72
         // 
         this.xrLabel72.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.Vat5", "{0:C2}")});
         this.xrLabel72.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
         this.xrLabel72.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
         this.xrLabel72.LocationFloat = new DevExpress.Utils.PointFloat(813.9108F, 2F);
         this.xrLabel72.Name = "xrLabel72";
         this.xrLabel72.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel72.SizeF = new System.Drawing.SizeF(83.86456F, 18F);
         this.xrLabel72.StyleName = "FieldCaption";
         this.xrLabel72.StylePriority.UseFont = false;
         this.xrLabel72.StylePriority.UseForeColor = false;
         this.xrLabel72.StylePriority.UseTextAlignment = false;
         xrSummary36.FormatString = "{0:#,##0.00}";
         xrSummary36.Running = DevExpress.XtraReports.UI.SummaryRunning.Report;
         this.xrLabel72.Summary = xrSummary36;
         this.xrLabel72.Text = "xrLabel72";
         this.xrLabel72.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
         // 
         // xrLabel73
         // 
         this.xrLabel73.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
         this.xrLabel73.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
         this.xrLabel73.LocationFloat = new DevExpress.Utils.PointFloat(216.3158F, 2.00001F);
         this.xrLabel73.Name = "xrLabel73";
         this.xrLabel73.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel73.SizeF = new System.Drawing.SizeF(195.6417F, 18F);
         this.xrLabel73.StyleName = "FieldCaption";
         this.xrLabel73.StylePriority.UseFont = false;
         this.xrLabel73.StylePriority.UseForeColor = false;
         this.xrLabel73.StylePriority.UseTextAlignment = false;
         this.xrLabel73.Text = "(A) - Γενικά Σύνολά :";
         this.xrLabel73.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
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
         // DepartmentID
         // 
         this.DepartmentID.Description = "Select Department";
         dynamicListLookUpSettings1.DataAdapter = null;
         dynamicListLookUpSettings1.DataMember = "Departments";
         dynamicListLookUpSettings1.DataSource = this.sqlDataSource1;
         dynamicListLookUpSettings1.DisplayMember = "Description";
         dynamicListLookUpSettings1.FilterString = null;
         dynamicListLookUpSettings1.ValueMember = "Id";
         this.DepartmentID.LookUpSettings = dynamicListLookUpSettings1;
         this.DepartmentID.MultiValue = true;
         this.DepartmentID.Name = "DepartmentID";
         this.DepartmentID.Type = typeof(long);
         this.DepartmentID.ValueInfo = "-1";
         // 
         // PosInfoID
         // 
         this.PosInfoID.Description = "Select POS";
         dynamicListLookUpSettings2.DataAdapter = null;
         dynamicListLookUpSettings2.DataMember = "PosInfos";
         dynamicListLookUpSettings2.DataSource = this.sqlDataSource1;
         dynamicListLookUpSettings2.DisplayMember = "Description";
         dynamicListLookUpSettings2.FilterString = null;
         dynamicListLookUpSettings2.ValueMember = "Id";
         this.PosInfoID.LookUpSettings = dynamicListLookUpSettings2;
         this.PosInfoID.MultiValue = true;
         this.PosInfoID.Name = "PosInfoID";
         this.PosInfoID.Type = typeof(long);
         // 
         // AccountType
         // 
         this.AccountType.Description = "Select Account";
         dynamicListLookUpSettings3.DataAdapter = null;
         dynamicListLookUpSettings3.DataMember = "Accounts";
         dynamicListLookUpSettings3.DataSource = this.sqlDataSource1;
         dynamicListLookUpSettings3.DisplayMember = "Description";
         dynamicListLookUpSettings3.FilterString = null;
         dynamicListLookUpSettings3.ValueMember = "Type";
         this.AccountType.LookUpSettings = dynamicListLookUpSettings3;
         this.AccountType.MultiValue = true;
         this.AccountType.Name = "AccountType";
         this.AccountType.Type = typeof(short);
         // 
         // InvoiceTypes
         // 
         this.InvoiceTypes.Description = "Select Invoice Types";
         dynamicListLookUpSettings4.DataAdapter = null;
         dynamicListLookUpSettings4.DataMember = "InvoiceTypes";
         dynamicListLookUpSettings4.DataSource = this.sqlDataSource1;
         dynamicListLookUpSettings4.DisplayMember = "Abbreviation";
         dynamicListLookUpSettings4.FilterString = null;
         dynamicListLookUpSettings4.ValueMember = "Type";
         this.InvoiceTypes.LookUpSettings = dynamicListLookUpSettings4;
         this.InvoiceTypes.MultiValue = true;
         this.InvoiceTypes.Name = "InvoiceTypes";
         this.InvoiceTypes.Type = typeof(short);
         // 
         // GroupHeader1
         // 
         this.GroupHeader1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel5});
         this.GroupHeader1.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("IsVoided", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
         this.GroupHeader1.HeightF = 17F;
         this.GroupHeader1.Level = 4;
         this.GroupHeader1.Name = "GroupHeader1";
         // 
         // xrLabel5
         // 
         this.xrLabel5.BackColor = System.Drawing.Color.DimGray;
         this.xrLabel5.Borders = DevExpress.XtraPrinting.BorderSide.None;
         this.xrLabel5.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.IsVoided", "Ακυρωμένες")});
         this.xrLabel5.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
         this.xrLabel5.ForeColor = System.Drawing.Color.White;
         this.xrLabel5.FormattingRules.Add(this.formattingRule1);
         this.xrLabel5.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
         this.xrLabel5.Name = "xrLabel5";
         this.xrLabel5.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel5.SizeF = new System.Drawing.SizeF(1069F, 17F);
         this.xrLabel5.StyleName = "DataField";
         this.xrLabel5.StylePriority.UseBackColor = false;
         this.xrLabel5.StylePriority.UseBorders = false;
         this.xrLabel5.StylePriority.UseFont = false;
         this.xrLabel5.StylePriority.UseForeColor = false;
         this.xrLabel5.StylePriority.UseTextAlignment = false;
         this.xrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
         // 
         // formattingRule1
         // 
         this.formattingRule1.Condition = "IsNull([IsVoided]) Or [IsVoided] == False";
         // 
         // 
         // 
         this.formattingRule1.Formatting.Visible = DevExpress.Utils.DefaultBoolean.False;
         this.formattingRule1.Name = "formattingRule1";
         // 
         // calculatedField1
         // 
         this.calculatedField1.Expression = "[Query.IsVoided] == true";
         this.calculatedField1.Name = "calculatedField1";
         // 
         // GroupFooter1
         // 
         this.GroupFooter1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLine8,
            this.xrLabel58,
            this.xrLabel50,
            this.xrLabel40,
            this.xrLabel39,
            this.xrLabel36,
            this.xrLabel26,
            this.xrLabel9,
            this.xrLine7});
         this.GroupFooter1.HeightF = 21.875F;
         this.GroupFooter1.Level = 4;
         this.GroupFooter1.Name = "GroupFooter1";
         // 
         // xrLine8
         // 
         this.xrLine8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
         this.xrLine8.LocationFloat = new DevExpress.Utils.PointFloat(0.0001220703F, 16F);
         this.xrLine8.Name = "xrLine8";
         this.xrLine8.SizeF = new System.Drawing.SizeF(1069F, 2F);
         this.xrLine8.StylePriority.UseForeColor = false;
         // 
         // xrLabel58
         // 
         this.xrLabel58.BackColor = System.Drawing.Color.Silver;
         this.xrLabel58.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.TransAmount")});
         this.xrLabel58.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
         this.xrLabel58.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
         this.xrLabel58.LocationFloat = new DevExpress.Utils.PointFloat(896.7755F, 2F);
         this.xrLabel58.Name = "xrLabel58";
         this.xrLabel58.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel58.SizeF = new System.Drawing.SizeF(172.2245F, 14F);
         this.xrLabel58.StyleName = "FieldCaption";
         this.xrLabel58.StylePriority.UseBackColor = false;
         this.xrLabel58.StylePriority.UseFont = false;
         this.xrLabel58.StylePriority.UseForeColor = false;
         this.xrLabel58.StylePriority.UseTextAlignment = false;
         xrSummary37.FormatString = "{0:#,##0.00}";
         xrSummary37.IgnoreNullValues = true;
         xrSummary37.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
         this.xrLabel58.Summary = xrSummary37;
         this.xrLabel58.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
         // 
         // xrLabel50
         // 
         this.xrLabel50.BackColor = System.Drawing.Color.Silver;
         this.xrLabel50.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.Vat5")});
         this.xrLabel50.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
         this.xrLabel50.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
         this.xrLabel50.LocationFloat = new DevExpress.Utils.PointFloat(811.5248F, 2F);
         this.xrLabel50.Name = "xrLabel50";
         this.xrLabel50.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel50.SizeF = new System.Drawing.SizeF(85.25061F, 14F);
         this.xrLabel50.StyleName = "FieldCaption";
         this.xrLabel50.StylePriority.UseBackColor = false;
         this.xrLabel50.StylePriority.UseFont = false;
         this.xrLabel50.StylePriority.UseForeColor = false;
         this.xrLabel50.StylePriority.UseTextAlignment = false;
         xrSummary38.FormatString = "{0:#,##0.00}";
         xrSummary38.IgnoreNullValues = true;
         xrSummary38.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
         this.xrLabel50.Summary = xrSummary38;
         this.xrLabel50.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
         // 
         // xrLabel40
         // 
         this.xrLabel40.BackColor = System.Drawing.Color.Silver;
         this.xrLabel40.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.Vat4")});
         this.xrLabel40.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
         this.xrLabel40.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
         this.xrLabel40.LocationFloat = new DevExpress.Utils.PointFloat(725.2742F, 2F);
         this.xrLabel40.Name = "xrLabel40";
         this.xrLabel40.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel40.SizeF = new System.Drawing.SizeF(86.25061F, 14F);
         this.xrLabel40.StyleName = "FieldCaption";
         this.xrLabel40.StylePriority.UseBackColor = false;
         this.xrLabel40.StylePriority.UseFont = false;
         this.xrLabel40.StylePriority.UseForeColor = false;
         this.xrLabel40.StylePriority.UseTextAlignment = false;
         xrSummary39.FormatString = "{0:#,##0.00}";
         xrSummary39.IgnoreNullValues = true;
         xrSummary39.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
         this.xrLabel40.Summary = xrSummary39;
         this.xrLabel40.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
         // 
         // xrLabel39
         // 
         this.xrLabel39.BackColor = System.Drawing.Color.Silver;
         this.xrLabel39.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.Vat3")});
         this.xrLabel39.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
         this.xrLabel39.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
         this.xrLabel39.LocationFloat = new DevExpress.Utils.PointFloat(639.0236F, 2F);
         this.xrLabel39.Name = "xrLabel39";
         this.xrLabel39.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel39.SizeF = new System.Drawing.SizeF(86.25061F, 14F);
         this.xrLabel39.StyleName = "FieldCaption";
         this.xrLabel39.StylePriority.UseBackColor = false;
         this.xrLabel39.StylePriority.UseFont = false;
         this.xrLabel39.StylePriority.UseForeColor = false;
         this.xrLabel39.StylePriority.UseTextAlignment = false;
         xrSummary40.FormatString = "{0:#,##0.00}";
         xrSummary40.IgnoreNullValues = true;
         xrSummary40.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
         this.xrLabel39.Summary = xrSummary40;
         this.xrLabel39.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
         // 
         // xrLabel36
         // 
         this.xrLabel36.BackColor = System.Drawing.Color.Silver;
         this.xrLabel36.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.Vat2")});
         this.xrLabel36.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
         this.xrLabel36.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
         this.xrLabel36.LocationFloat = new DevExpress.Utils.PointFloat(552.7729F, 2F);
         this.xrLabel36.Name = "xrLabel36";
         this.xrLabel36.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel36.SizeF = new System.Drawing.SizeF(86.25073F, 14F);
         this.xrLabel36.StyleName = "FieldCaption";
         this.xrLabel36.StylePriority.UseBackColor = false;
         this.xrLabel36.StylePriority.UseFont = false;
         this.xrLabel36.StylePriority.UseForeColor = false;
         this.xrLabel36.StylePriority.UseTextAlignment = false;
         xrSummary41.FormatString = "{0:#,##0.00}";
         xrSummary41.IgnoreNullValues = true;
         xrSummary41.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
         this.xrLabel36.Summary = xrSummary41;
         this.xrLabel36.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
         // 
         // xrLabel26
         // 
         this.xrLabel26.BackColor = System.Drawing.Color.Silver;
         this.xrLabel26.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.Vat1")});
         this.xrLabel26.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
         this.xrLabel26.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
         this.xrLabel26.LocationFloat = new DevExpress.Utils.PointFloat(411.9575F, 2F);
         this.xrLabel26.Name = "xrLabel26";
         this.xrLabel26.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel26.SizeF = new System.Drawing.SizeF(140.8154F, 14F);
         this.xrLabel26.StyleName = "FieldCaption";
         this.xrLabel26.StylePriority.UseBackColor = false;
         this.xrLabel26.StylePriority.UseFont = false;
         this.xrLabel26.StylePriority.UseForeColor = false;
         this.xrLabel26.StylePriority.UseTextAlignment = false;
         xrSummary42.FormatString = "{0:#,##0.00}";
         xrSummary42.IgnoreNullValues = true;
         xrSummary42.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
         this.xrLabel26.Summary = xrSummary42;
         this.xrLabel26.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
         // 
         // xrLabel9
         // 
         this.xrLabel9.BackColor = System.Drawing.Color.Silver;
         this.xrLabel9.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
         this.xrLabel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
         this.xrLabel9.LocationFloat = new DevExpress.Utils.PointFloat(7.947286E-06F, 2F);
         this.xrLabel9.Name = "xrLabel9";
         this.xrLabel9.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel9.SizeF = new System.Drawing.SizeF(411.9575F, 14F);
         this.xrLabel9.StyleName = "FieldCaption";
         this.xrLabel9.StylePriority.UseBackColor = false;
         this.xrLabel9.StylePriority.UseFont = false;
         this.xrLabel9.StylePriority.UseForeColor = false;
         this.xrLabel9.StylePriority.UseTextAlignment = false;
         this.xrLabel9.Text = "Γενικά Σύνολα :";
         this.xrLabel9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
         // 
         // xrLine7
         // 
         this.xrLine7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
         this.xrLine7.LocationFloat = new DevExpress.Utils.PointFloat(7.947286E-06F, 0F);
         this.xrLine7.Name = "xrLine7";
         this.xrLine7.SizeF = new System.Drawing.SizeF(1069F, 2F);
         this.xrLine7.StylePriority.UseForeColor = false;
         // 
         // xrControlStyle1
         // 
         this.xrControlStyle1.BackColor = System.Drawing.Color.Silver;
         this.xrControlStyle1.Name = "xrControlStyle1";
         this.xrControlStyle1.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
         // 
         // ReceiptsOldDB
         // 
         this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.groupHeaderBand1,
            this.groupHeaderBand2,
            this.groupHeaderBand3,
            this.groupHeaderBand4,
            this.pageFooterBand1,
            this.reportHeaderBand1,
            this.groupFooterBand2,
            this.groupFooterBand3,
            this.groupFooterBand4,
            this.reportFooterBand1,
            this.GroupHeader1,
            this.GroupFooter1});
         this.CalculatedFields.AddRange(new DevExpress.XtraReports.UI.CalculatedField[] {
            this.calculatedField1});
         this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.sqlDataSource1});
         this.DataMember = "Query_FastStart";
         this.DataSource = this.sqlDataSource1;
         this.FilterString = "[FODay] >= ?FromFODay And [FODay] <= ?UpToFODay And [AccountType] In (?AccountTyp" +
    "e) And [PosInfoId] In (?PosInfoID) And [DepartmentId] In (?DepartmentID) And [In" +
    "voiceType] In (?InvoiceTypes)";
         this.FormattingRuleSheet.AddRange(new DevExpress.XtraReports.UI.FormattingRule[] {
            this.formattingRule1});
         this.Landscape = true;
         this.Margins = new System.Drawing.Printing.Margins(48, 52, 49, 25);
         this.PageHeight = 827;
         this.PageWidth = 1169;
         this.PaperKind = System.Drawing.Printing.PaperKind.A4;
         this.Parameters.AddRange(new DevExpress.XtraReports.Parameters.Parameter[] {
            this.FromFODay,
            this.UpToFODay,
            this.DepartmentID,
            this.PosInfoID,
            this.AccountType,
            this.InvoiceTypes});
         this.StyleSheet.AddRange(new DevExpress.XtraReports.UI.XRControlStyle[] {
            this.Title,
            this.FieldCaption,
            this.PageInfo,
            this.DataField,
            this.xrControlStyle1});
         this.Version = "15.2";
         this.ParametersRequestBeforeShow += new System.EventHandler<DevExpress.XtraReports.Parameters.ParametersRequestEventArgs>(this.ReceiptsOldDB_ParametersRequestBeforeShow);
         this.DataSourceDemanded += new System.EventHandler<System.EventArgs>(this.ReceiptsOldDB_DataSourceDemanded);
         ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

      }

   #endregion

   ////////////////////////////////////////////////////////////////////////////////////////////////
   /// <summary>
   /// 
   /// </summary>
   /// <param name="sender"></param>
   /// <param name="e"></param>
   private void ReceiptsOldDB_ParametersRequestBeforeShow( object sender
                                 , DevExpress.XtraReports.Parameters.ParametersRequestEventArgs e )
      {
      sqlDataSource1.Fill();

      foreach ( var paramItem in e.ParametersInformation )
         {

         if ( "DateTime" == paramItem.Parameter.Type.Name )
            {
            //paramItem.Parameter.Value = DateTime.MinValue;
            paramItem.Parameter.Value = DateTime.Now.Date;
            }
         else if ( paramItem.Parameter.MultiValue )
            {

            switch ( paramItem.Parameter.Name )
               {
               case "DepartmentID":
                  // select all values for parameter Department
                  paramItem.Parameter.Value = CommonTools.SetAllSelectedForMultiValueParameter<Int64>( sqlDataSource1, "Departments", "Id" );
                  break;

               case "PosInfoID":
                  // select all values for parameter PosInfo
                  paramItem.Parameter.Value = CommonTools.SetAllSelectedForMultiValueParameter<Int64>( sqlDataSource1, "PosInfos", "Id" );
                  break;

               case "AccountType":
                  // select all values for parameter AccountType
                  paramItem.Parameter.Value = CommonTools.SetAllSelectedForMultiValueParameter<Int16>( sqlDataSource1, "Accounts", "Type" );
                  break;

               case "InvoiceTypes":
                  // select all values for parameter InvoiceTypes
                  paramItem.Parameter.Value = CommonTools.SetAllSelectedForMultiValueParameter<Int16>( sqlDataSource1, "InvoiceTypes", "Type" );
                  break;

               default:
                  break;
               }

            }

         }

      }

   ////////////////////////////////////////////////////////////////////////////////////////////////
   /// <summary>
   /// 
   /// </summary>
   /// <param name="sender"></param>
   /// <param name="e"></param>
   private void ReceiptsOldDB_DataSourceDemanded( object sender, EventArgs e )
      {
      this.DataSource = sqlDataSource1;
      this.DataMember = "Query";
      this.sqlDataSource1.RebuildResultSchema();

      //this.sqlDataSource1.Queries["QueryV1"].Name = "tmp";
      //this.sqlDataSource1.Queries["Query"].Name = "QueryV1";
      //this.sqlDataSource1.Queries["tmp"].Name = "Query";
      //this.DataMember = "Query";

      //this.sqlDataSource1.RebuildResultSchema();

      /*/

      int? dbVersion = Convert.ToInt32( WebConfigurationManager.AppSettings["DBVersion"] );

      if ( dbVersion != null && dbVersion == 1 )
         {
         this.DataSource = sqlDataSource2;
         this.DataMember = "Query";
         this.sqlDataSource2.RebuildResultSchema();
         }
      else
         {
         this.DataSource = sqlDataSource1;
         this.DataMember = "Query";
         this.sqlDataSource1.RebuildResultSchema();
         }

      //*/

      }

   ////////////////////////////////////////////////////////////////////////////////////////////////
   }

