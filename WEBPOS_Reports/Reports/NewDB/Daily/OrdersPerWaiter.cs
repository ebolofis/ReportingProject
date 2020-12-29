
using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Web.Configuration;
using WEBPOS_Reports.Helpers;

/// <summary>
/// Summary description for OrdersPerWaiter
/// </summary>
public class OrdersPerWaiter : DevExpress.XtraReports.UI.XtraReport
   {
   private DevExpress.XtraReports.UI.DetailBand Detail;
   private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
   private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
   private XRLabel xrLabel41;
   private XRLabel xrLabel44;
   private XRLabel xrLabel50;
   private XRLabel xrLabel56;
   private XRLabel xrLabel58;
   private XRLabel xrLabel59;
   private XRLabel xrLabel60;
   private XRLabel xrLabel62;
   private XRLabel xrLabel64;
   private XRLabel xrLabel66;
   private XRLabel xrLabel68;
   private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
   private GroupHeaderBand PosInfoId_GroupHeader;
   private XRLabel xrLabel6;
   private GroupHeaderBand StaffCode_GroupHeader;
   private XRLabel xrLabel8;
   private GroupHeaderBand AccountType_GroupHeader;
   private XRLabel xrLabel10;
   private GroupHeaderBand groupHeaderBand6;
   private XRLabel xrLabel11;
   private XRLabel xrLabel14;
   private XRLabel xrLabel20;
   private XRLabel xrLabel27;
   private XRLabel xrLabel29;
   private XRLabel xrLabel30;
   private XRLabel xrLabel31;
   private XRLabel xrLabel33;
   private XRLabel xrLabel35;
   private XRLabel xrLabel37;
   private XRLabel xrLabel39;
   private XRLine xrLine2;
   private PageFooterBand pageFooterBand1;
   private ReportHeaderBand reportHeaderBand1;
   private XRLabel xrLabel70;
   private GroupFooterBand groupFooterBand1;
   private XRLabel xrLabel72;
   private XRLabel xrLabel73;
   private XRLabel xrLabel74;
   private XRLabel xrLabel75;
   private XRLabel xrLabel76;
   private XRLabel xrLabel77;
   private XRLabel xrLabel78;
   private ReportFooterBand reportFooterBand1;
   private XRLabel xrLabel112;
   private XRLabel xrLabel113;
   private XRLabel xrLabel114;
   private XRLabel xrLabel115;
   private XRLabel xrLabel116;
   private XRLabel xrLabel117;
   private XRLabel xrLabel118;
   private XRControlStyle Title;
   private XRControlStyle FieldCaption;
   private XRControlStyle PageInfo;
   private XRControlStyle DataField;
   private DevExpress.XtraReports.Parameters.Parameter FromFODay;
   private DevExpress.XtraReports.Parameters.Parameter UpToFODay;
   private DevExpress.XtraReports.Parameters.Parameter PosInfoID;
   private DevExpress.XtraReports.Parameters.Parameter StaffID;
   private DevExpress.XtraReports.Parameters.Parameter AccountType;
   private XRPageInfo xrPageInfo3;
   private XRPageInfo xrPageInfo1;
   private GroupHeaderBand GroupHeader1;
   private GroupFooterBand GroupFooter1;
   private XRLabel xrLabel1;
   private XRLabel xrLabel2;
   private XRLabel xrLabel3;
   private XRLabel xrLabel5;
   private XRLabel xrLabel7;
   private XRLabel xrLabel9;
   private XRLabel xrLabel12;
   private XRLabel xrLabel13;
   private FormattingRule formattingRule1;
   private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource2;
   private XRLine xrLine7;
   private XRLine xrLine6;
   private XRLabel xrLabel15;
   private XRLabel xrLabel16;
   private XRLabel xrLabel4;
   private XRLabel xrLabel17;
   private XRLabel xrLabel18;
   private XRLabel xrLabel19;
   private XRLabel xrLabel21;
   private XRLabel xrLabel22;
   private XRLabel xrLabel23;
   private XRLabel xrLabel24;
   private GroupFooterBand PosInfoId_GroupFooter;
   private XRLabel xrLabel86;
   private XRLabel xrLabel85;
   private XRLabel xrLabel84;
   private XRLabel xrLabel83;
   private XRLabel xrLabel82;
   private XRLabel xrLabel81;
   private XRLabel xrLabel80;
   private XRLine xrLine3;
   private GroupFooterBand GroupFooter2;
   private XRLine xrLine1;
   private XRLabel xrLabel26;
   private XRLabel xrLabel25;
   private XRLine xrLine5;
   private XRLine xrLine4;
   private XRLabel xrLabel28;

   /// <summary>
   /// Required designer variable.
   /// </summary>
   private System.ComponentModel.IContainer components = null;

   /// <summary>
   /// 
   /// </summary>
   public OrdersPerWaiter()
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
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrdersPerWaiter));
         DevExpress.DataAccess.Sql.CustomSqlQuery customSqlQuery2 = new DevExpress.DataAccess.Sql.CustomSqlQuery();
         DevExpress.DataAccess.Sql.CustomSqlQuery customSqlQuery3 = new DevExpress.DataAccess.Sql.CustomSqlQuery();
         DevExpress.DataAccess.Sql.CustomSqlQuery customSqlQuery4 = new DevExpress.DataAccess.Sql.CustomSqlQuery();
         DevExpress.DataAccess.Sql.CustomSqlQuery customSqlQuery5 = new DevExpress.DataAccess.Sql.CustomSqlQuery();
         DevExpress.DataAccess.Sql.CustomSqlQuery customSqlQuery6 = new DevExpress.DataAccess.Sql.CustomSqlQuery();
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
         DevExpress.XtraReports.Parameters.DynamicListLookUpSettings dynamicListLookUpSettings1 = new DevExpress.XtraReports.Parameters.DynamicListLookUpSettings();
         DevExpress.XtraReports.Parameters.DynamicListLookUpSettings dynamicListLookUpSettings2 = new DevExpress.XtraReports.Parameters.DynamicListLookUpSettings();
         DevExpress.XtraReports.Parameters.DynamicListLookUpSettings dynamicListLookUpSettings3 = new DevExpress.XtraReports.Parameters.DynamicListLookUpSettings();
         DevExpress.XtraReports.UI.XRSummary xrSummary25 = new DevExpress.XtraReports.UI.XRSummary();
         DevExpress.XtraReports.UI.XRSummary xrSummary26 = new DevExpress.XtraReports.UI.XRSummary();
         DevExpress.XtraReports.UI.XRSummary xrSummary27 = new DevExpress.XtraReports.UI.XRSummary();
         DevExpress.XtraReports.UI.XRSummary xrSummary28 = new DevExpress.XtraReports.UI.XRSummary();
         DevExpress.XtraReports.UI.XRSummary xrSummary29 = new DevExpress.XtraReports.UI.XRSummary();
         DevExpress.XtraReports.UI.XRSummary xrSummary30 = new DevExpress.XtraReports.UI.XRSummary();
         DevExpress.DataAccess.Sql.CustomSqlQuery customSqlQuery7 = new DevExpress.DataAccess.Sql.CustomSqlQuery();
         DevExpress.DataAccess.Sql.QueryParameter queryParameter3 = new DevExpress.DataAccess.Sql.QueryParameter();
         DevExpress.DataAccess.Sql.QueryParameter queryParameter4 = new DevExpress.DataAccess.Sql.QueryParameter();
         DevExpress.XtraReports.UI.XRSummary xrSummary31 = new DevExpress.XtraReports.UI.XRSummary();
         DevExpress.XtraReports.UI.XRSummary xrSummary32 = new DevExpress.XtraReports.UI.XRSummary();
         DevExpress.XtraReports.UI.XRSummary xrSummary33 = new DevExpress.XtraReports.UI.XRSummary();
         DevExpress.XtraReports.UI.XRSummary xrSummary34 = new DevExpress.XtraReports.UI.XRSummary();
         DevExpress.XtraReports.UI.XRSummary xrSummary35 = new DevExpress.XtraReports.UI.XRSummary();
         DevExpress.XtraReports.UI.XRSummary xrSummary36 = new DevExpress.XtraReports.UI.XRSummary();
         this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
         this.Detail = new DevExpress.XtraReports.UI.DetailBand();
         this.xrLabel26 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel16 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel41 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel44 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel50 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel56 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel58 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel59 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel60 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel62 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel64 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel66 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel68 = new DevExpress.XtraReports.UI.XRLabel();
         this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
         this.xrPageInfo3 = new DevExpress.XtraReports.UI.XRPageInfo();
         this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
         this.PosInfoId_GroupHeader = new DevExpress.XtraReports.UI.GroupHeaderBand();
         this.xrLabel6 = new DevExpress.XtraReports.UI.XRLabel();
         this.StaffCode_GroupHeader = new DevExpress.XtraReports.UI.GroupHeaderBand();
         this.xrLabel28 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel17 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel18 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel19 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel21 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel22 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel23 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel24 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel8 = new DevExpress.XtraReports.UI.XRLabel();
         this.AccountType_GroupHeader = new DevExpress.XtraReports.UI.GroupHeaderBand();
         this.xrLabel10 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel72 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel73 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel74 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel75 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel76 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel77 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel78 = new DevExpress.XtraReports.UI.XRLabel();
         this.groupHeaderBand6 = new DevExpress.XtraReports.UI.GroupHeaderBand();
         this.xrLabel25 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLine5 = new DevExpress.XtraReports.UI.XRLine();
         this.xrLabel4 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel11 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel14 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel20 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel27 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel29 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel30 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel31 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel33 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel35 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel37 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel39 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLine2 = new DevExpress.XtraReports.UI.XRLine();
         this.pageFooterBand1 = new DevExpress.XtraReports.UI.PageFooterBand();
         this.xrPageInfo1 = new DevExpress.XtraReports.UI.XRPageInfo();
         this.reportHeaderBand1 = new DevExpress.XtraReports.UI.ReportHeaderBand();
         this.xrLabel15 = new DevExpress.XtraReports.UI.XRLabel();
         this.UpToFODay = new DevExpress.XtraReports.Parameters.Parameter();
         this.xrLabel70 = new DevExpress.XtraReports.UI.XRLabel();
         this.FromFODay = new DevExpress.XtraReports.Parameters.Parameter();
         this.groupFooterBand1 = new DevExpress.XtraReports.UI.GroupFooterBand();
         this.reportFooterBand1 = new DevExpress.XtraReports.UI.ReportFooterBand();
         this.xrLine7 = new DevExpress.XtraReports.UI.XRLine();
         this.xrLabel112 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel113 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel114 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel115 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel116 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel117 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel118 = new DevExpress.XtraReports.UI.XRLabel();
         this.Title = new DevExpress.XtraReports.UI.XRControlStyle();
         this.FieldCaption = new DevExpress.XtraReports.UI.XRControlStyle();
         this.PageInfo = new DevExpress.XtraReports.UI.XRControlStyle();
         this.DataField = new DevExpress.XtraReports.UI.XRControlStyle();
         this.PosInfoID = new DevExpress.XtraReports.Parameters.Parameter();
         this.StaffID = new DevExpress.XtraReports.Parameters.Parameter();
         this.AccountType = new DevExpress.XtraReports.Parameters.Parameter();
         this.GroupHeader1 = new DevExpress.XtraReports.UI.GroupHeaderBand();
         this.xrLabel13 = new DevExpress.XtraReports.UI.XRLabel();
         this.formattingRule1 = new DevExpress.XtraReports.UI.FormattingRule();
         this.GroupFooter1 = new DevExpress.XtraReports.UI.GroupFooterBand();
         this.xrLine6 = new DevExpress.XtraReports.UI.XRLine();
         this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel5 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel7 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel9 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel12 = new DevExpress.XtraReports.UI.XRLabel();
         this.sqlDataSource2 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
         this.PosInfoId_GroupFooter = new DevExpress.XtraReports.UI.GroupFooterBand();
         this.xrLine4 = new DevExpress.XtraReports.UI.XRLine();
         this.xrLabel86 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel85 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel84 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel83 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel82 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel81 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel80 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLine3 = new DevExpress.XtraReports.UI.XRLine();
         this.GroupFooter2 = new DevExpress.XtraReports.UI.GroupFooterBand();
         this.xrLine1 = new DevExpress.XtraReports.UI.XRLine();
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
         customSqlQuery2.Name = "PosInfoLookUps";
         customSqlQuery2.Sql = "Select Id, Code, Description from PosInfo";
         customSqlQuery3.Name = "InvoiceTypesLookUps";
         customSqlQuery3.Sql = "Select Distinct Id, Abbreviation, Type\r\nFrom InvoiceTypes\r\nWhere Type NOT IN ( 2," +
    " 3, 8, 10, 11, 12 ) Order By Type";
         customSqlQuery4.Name = "AccountsLookups";
         customSqlQuery4.Sql = "Select Id, Description, Type from Accounts";
         customSqlQuery5.Name = "Query_FastStart";
         customSqlQuery5.Sql = "select * from invoices where id = -1";
         customSqlQuery6.Name = "StaffLookUps";
         customSqlQuery6.Sql = "select isnull(LastName,\'\') + \' \' + isnull(FirstName,\'\') StafName, Code StaffCode " +
    "from Staff";
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
            this.xrLabel26,
            this.xrLabel16,
            this.xrLabel41,
            this.xrLabel44,
            this.xrLabel50,
            this.xrLabel56,
            this.xrLabel58,
            this.xrLabel59,
            this.xrLabel60,
            this.xrLabel62,
            this.xrLabel64,
            this.xrLabel66,
            this.xrLabel68});
         this.Detail.HeightF = 16F;
         this.Detail.Name = "Detail";
         this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
         this.Detail.StyleName = "DataField";
         this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
         // 
         // xrLabel26
         // 
         this.xrLabel26.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.Cover")});
         this.xrLabel26.Font = new System.Drawing.Font("Times New Roman", 8F);
         this.xrLabel26.LocationFloat = new DevExpress.Utils.PointFloat(519.5156F, 0F);
         this.xrLabel26.Name = "xrLabel26";
         this.xrLabel26.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel26.SizeF = new System.Drawing.SizeF(47.67444F, 16F);
         this.xrLabel26.StylePriority.UseFont = false;
         this.xrLabel26.StylePriority.UseTextAlignment = false;
         this.xrLabel26.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
         // 
         // xrLabel16
         // 
         this.xrLabel16.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.Day")});
         this.xrLabel16.Font = new System.Drawing.Font("Times New Roman", 8F);
         this.xrLabel16.LocationFloat = new DevExpress.Utils.PointFloat(2F, 0F);
         this.xrLabel16.Name = "xrLabel16";
         this.xrLabel16.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel16.SizeF = new System.Drawing.SizeF(129.1359F, 16F);
         this.xrLabel16.StylePriority.UseFont = false;
         this.xrLabel16.StylePriority.UseTextAlignment = false;
         this.xrLabel16.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
         // 
         // xrLabel41
         // 
         this.xrLabel41.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.Abbreviation")});
         this.xrLabel41.Font = new System.Drawing.Font("Times New Roman", 8F);
         this.xrLabel41.LocationFloat = new DevExpress.Utils.PointFloat(131.1359F, 0F);
         this.xrLabel41.Name = "xrLabel41";
         this.xrLabel41.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel41.SizeF = new System.Drawing.SizeF(94.66464F, 16F);
         this.xrLabel41.StylePriority.UseFont = false;
         this.xrLabel41.StylePriority.UseTextAlignment = false;
         this.xrLabel41.Text = "xrLabel41";
         this.xrLabel41.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
         // 
         // xrLabel44
         // 
         this.xrLabel44.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.Counter")});
         this.xrLabel44.Font = new System.Drawing.Font("Times New Roman", 8F);
         this.xrLabel44.LocationFloat = new DevExpress.Utils.PointFloat(225.8006F, 0F);
         this.xrLabel44.Name = "xrLabel44";
         this.xrLabel44.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel44.SizeF = new System.Drawing.SizeF(89.98883F, 16F);
         this.xrLabel44.StylePriority.UseFont = false;
         this.xrLabel44.StylePriority.UseTextAlignment = false;
         this.xrLabel44.Text = "xrLabel44";
         this.xrLabel44.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
         // 
         // xrLabel50
         // 
         this.xrLabel50.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.InvoiceTotal", "{0:#,##0.00}")});
         this.xrLabel50.Font = new System.Drawing.Font("Times New Roman", 8F);
         this.xrLabel50.LocationFloat = new DevExpress.Utils.PointFloat(882.1899F, 0F);
         this.xrLabel50.Name = "xrLabel50";
         this.xrLabel50.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel50.SizeF = new System.Drawing.SizeF(111.4557F, 16F);
         this.xrLabel50.StylePriority.UseFont = false;
         this.xrLabel50.StylePriority.UseTextAlignment = false;
         this.xrLabel50.Text = "xrLabel50";
         this.xrLabel50.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
         // 
         // xrLabel56
         // 
         this.xrLabel56.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.Room")});
         this.xrLabel56.Font = new System.Drawing.Font("Times New Roman", 8F);
         this.xrLabel56.LocationFloat = new DevExpress.Utils.PointFloat(315.7894F, 0F);
         this.xrLabel56.Name = "xrLabel56";
         this.xrLabel56.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel56.SizeF = new System.Drawing.SizeF(115.0518F, 16F);
         this.xrLabel56.StylePriority.UseFont = false;
         this.xrLabel56.StylePriority.UseTextAlignment = false;
         this.xrLabel56.Text = "xrLabel56";
         this.xrLabel56.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
         // 
         // xrLabel58
         // 
         this.xrLabel58.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.TableCode")});
         this.xrLabel58.Font = new System.Drawing.Font("Times New Roman", 8F);
         this.xrLabel58.LocationFloat = new DevExpress.Utils.PointFloat(430.8412F, 0F);
         this.xrLabel58.Name = "xrLabel58";
         this.xrLabel58.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel58.SizeF = new System.Drawing.SizeF(88.67444F, 16F);
         this.xrLabel58.StylePriority.UseFont = false;
         this.xrLabel58.StylePriority.UseTextAlignment = false;
         this.xrLabel58.Text = "xrLabel58";
         this.xrLabel58.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
         // 
         // xrLabel59
         // 
         this.xrLabel59.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.TransAmount", "{0:#,##0.00}")});
         this.xrLabel59.Font = new System.Drawing.Font("Times New Roman", 8F);
         this.xrLabel59.LocationFloat = new DevExpress.Utils.PointFloat(993.6456F, 0F);
         this.xrLabel59.Name = "xrLabel59";
         this.xrLabel59.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel59.SizeF = new System.Drawing.SizeF(105.3545F, 16F);
         this.xrLabel59.StylePriority.UseFont = false;
         this.xrLabel59.StylePriority.UseTextAlignment = false;
         this.xrLabel59.Text = "xrLabel59";
         this.xrLabel59.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
         // 
         // xrLabel60
         // 
         this.xrLabel60.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.Vat1", "{0:#,##0.00}")});
         this.xrLabel60.Font = new System.Drawing.Font("Times New Roman", 8F);
         this.xrLabel60.LocationFloat = new DevExpress.Utils.PointFloat(567.1899F, 0F);
         this.xrLabel60.Name = "xrLabel60";
         this.xrLabel60.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel60.SizeF = new System.Drawing.SizeF(63F, 16F);
         this.xrLabel60.StylePriority.UseFont = false;
         this.xrLabel60.StylePriority.UseTextAlignment = false;
         this.xrLabel60.Text = "xrLabel60";
         this.xrLabel60.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
         // 
         // xrLabel62
         // 
         this.xrLabel62.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.Vat2", "{0:#,##0.00}")});
         this.xrLabel62.Font = new System.Drawing.Font("Times New Roman", 8F);
         this.xrLabel62.LocationFloat = new DevExpress.Utils.PointFloat(630.1899F, 0F);
         this.xrLabel62.Name = "xrLabel62";
         this.xrLabel62.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel62.SizeF = new System.Drawing.SizeF(63F, 16F);
         this.xrLabel62.StylePriority.UseFont = false;
         this.xrLabel62.StylePriority.UseTextAlignment = false;
         this.xrLabel62.Text = "xrLabel62";
         this.xrLabel62.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
         // 
         // xrLabel64
         // 
         this.xrLabel64.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.Vat3", "{0:#,##0.00}")});
         this.xrLabel64.Font = new System.Drawing.Font("Times New Roman", 8F);
         this.xrLabel64.LocationFloat = new DevExpress.Utils.PointFloat(693.1899F, 0F);
         this.xrLabel64.Name = "xrLabel64";
         this.xrLabel64.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel64.SizeF = new System.Drawing.SizeF(63F, 16F);
         this.xrLabel64.StylePriority.UseFont = false;
         this.xrLabel64.StylePriority.UseTextAlignment = false;
         this.xrLabel64.Text = "xrLabel64";
         this.xrLabel64.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
         // 
         // xrLabel66
         // 
         this.xrLabel66.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.Vat4", "{0:#,##0.00}")});
         this.xrLabel66.Font = new System.Drawing.Font("Times New Roman", 8F);
         this.xrLabel66.LocationFloat = new DevExpress.Utils.PointFloat(756.1899F, 0F);
         this.xrLabel66.Name = "xrLabel66";
         this.xrLabel66.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel66.SizeF = new System.Drawing.SizeF(63F, 16F);
         this.xrLabel66.StylePriority.UseFont = false;
         this.xrLabel66.StylePriority.UseTextAlignment = false;
         this.xrLabel66.Text = "xrLabel66";
         this.xrLabel66.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
         // 
         // xrLabel68
         // 
         this.xrLabel68.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.Vat5", "{0:#,##0.00}")});
         this.xrLabel68.Font = new System.Drawing.Font("Times New Roman", 8F);
         this.xrLabel68.LocationFloat = new DevExpress.Utils.PointFloat(819.1899F, 0F);
         this.xrLabel68.Name = "xrLabel68";
         this.xrLabel68.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel68.SizeF = new System.Drawing.SizeF(63F, 16F);
         this.xrLabel68.StylePriority.UseFont = false;
         this.xrLabel68.StylePriority.UseTextAlignment = false;
         this.xrLabel68.Text = "xrLabel68";
         this.xrLabel68.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
         // 
         // TopMargin
         // 
         this.TopMargin.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrPageInfo3});
         this.TopMargin.HeightF = 48F;
         this.TopMargin.Name = "TopMargin";
         this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
         this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
         // 
         // xrPageInfo3
         // 
         this.xrPageInfo3.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
         this.xrPageInfo3.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
         this.xrPageInfo3.Format = "Ημερομηνία Εκτύπωσης : {0:dddd, d MMMM yyyy h:mm:ss tt}";
         this.xrPageInfo3.LocationFloat = new DevExpress.Utils.PointFloat(2F, 29.15395F);
         this.xrPageInfo3.Name = "xrPageInfo3";
         this.xrPageInfo3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrPageInfo3.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime;
         this.xrPageInfo3.SizeF = new System.Drawing.SizeF(1097F, 18.76271F);
         this.xrPageInfo3.StylePriority.UseBorders = false;
         this.xrPageInfo3.StylePriority.UseFont = false;
         // 
         // BottomMargin
         // 
         this.BottomMargin.HeightF = 25F;
         this.BottomMargin.Name = "BottomMargin";
         this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
         this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
         // 
         // PosInfoId_GroupHeader
         // 
         this.PosInfoId_GroupHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel6});
         this.PosInfoId_GroupHeader.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("PosInfoId", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
         this.PosInfoId_GroupHeader.HeightF = 17F;
         this.PosInfoId_GroupHeader.Level = 3;
         this.PosInfoId_GroupHeader.Name = "PosInfoId_GroupHeader";
         // 
         // xrLabel6
         // 
         this.xrLabel6.BackColor = System.Drawing.Color.Gray;
         this.xrLabel6.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.PosInfoDescription", "POS : {0}")});
         this.xrLabel6.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
         this.xrLabel6.LocationFloat = new DevExpress.Utils.PointFloat(2F, 0F);
         this.xrLabel6.Name = "xrLabel6";
         this.xrLabel6.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel6.SizeF = new System.Drawing.SizeF(1097F, 17F);
         this.xrLabel6.StyleName = "DataField";
         this.xrLabel6.StylePriority.UseBackColor = false;
         this.xrLabel6.StylePriority.UseFont = false;
         this.xrLabel6.StylePriority.UseTextAlignment = false;
         this.xrLabel6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
         // 
         // StaffCode_GroupHeader
         // 
         this.StaffCode_GroupHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel28,
            this.xrLabel17,
            this.xrLabel18,
            this.xrLabel19,
            this.xrLabel21,
            this.xrLabel22,
            this.xrLabel23,
            this.xrLabel24,
            this.xrLabel8});
         this.StaffCode_GroupHeader.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("StaffCode", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
         this.StaffCode_GroupHeader.HeightF = 17F;
         this.StaffCode_GroupHeader.Level = 2;
         this.StaffCode_GroupHeader.Name = "StaffCode_GroupHeader";
         // 
         // xrLabel28
         // 
         this.xrLabel28.BackColor = System.Drawing.Color.Silver;
         this.xrLabel28.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.Cover")});
         this.xrLabel28.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
         this.xrLabel28.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
         this.xrLabel28.LocationFloat = new DevExpress.Utils.PointFloat(519.5156F, 0F);
         this.xrLabel28.Name = "xrLabel28";
         this.xrLabel28.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel28.SizeF = new System.Drawing.SizeF(47.67438F, 17F);
         this.xrLabel28.StyleName = "FieldCaption";
         this.xrLabel28.StylePriority.UseBackColor = false;
         this.xrLabel28.StylePriority.UseFont = false;
         this.xrLabel28.StylePriority.UseForeColor = false;
         this.xrLabel28.StylePriority.UseTextAlignment = false;
         xrSummary1.IgnoreNullValues = true;
         xrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
         this.xrLabel28.Summary = xrSummary1;
         this.xrLabel28.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
         // 
         // xrLabel17
         // 
         this.xrLabel17.BackColor = System.Drawing.Color.Silver;
         this.xrLabel17.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
         this.xrLabel17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
         this.xrLabel17.LocationFloat = new DevExpress.Utils.PointFloat(407.8411F, 0F);
         this.xrLabel17.Name = "xrLabel17";
         this.xrLabel17.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel17.SizeF = new System.Drawing.SizeF(111.6745F, 17F);
         this.xrLabel17.StyleName = "FieldCaption";
         this.xrLabel17.StylePriority.UseBackColor = false;
         this.xrLabel17.StylePriority.UseFont = false;
         this.xrLabel17.StylePriority.UseForeColor = false;
         this.xrLabel17.StylePriority.UseTextAlignment = false;
         this.xrLabel17.Text = "Σύνολα:";
         this.xrLabel17.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
         // 
         // xrLabel18
         // 
         this.xrLabel18.BackColor = System.Drawing.Color.Silver;
         this.xrLabel18.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.Vat1")});
         this.xrLabel18.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
         this.xrLabel18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
         this.xrLabel18.LocationFloat = new DevExpress.Utils.PointFloat(567.1901F, 0F);
         this.xrLabel18.Name = "xrLabel18";
         this.xrLabel18.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel18.SizeF = new System.Drawing.SizeF(63F, 17F);
         this.xrLabel18.StyleName = "FieldCaption";
         this.xrLabel18.StylePriority.UseBackColor = false;
         this.xrLabel18.StylePriority.UseFont = false;
         this.xrLabel18.StylePriority.UseForeColor = false;
         this.xrLabel18.StylePriority.UseTextAlignment = false;
         xrSummary2.FormatString = "{0:#,##0.00}";
         xrSummary2.IgnoreNullValues = true;
         xrSummary2.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
         this.xrLabel18.Summary = xrSummary2;
         this.xrLabel18.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
         // 
         // xrLabel19
         // 
         this.xrLabel19.BackColor = System.Drawing.Color.Silver;
         this.xrLabel19.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.Vat2")});
         this.xrLabel19.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
         this.xrLabel19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
         this.xrLabel19.LocationFloat = new DevExpress.Utils.PointFloat(630.1901F, 0F);
         this.xrLabel19.Name = "xrLabel19";
         this.xrLabel19.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel19.SizeF = new System.Drawing.SizeF(63F, 17F);
         this.xrLabel19.StyleName = "FieldCaption";
         this.xrLabel19.StylePriority.UseBackColor = false;
         this.xrLabel19.StylePriority.UseFont = false;
         this.xrLabel19.StylePriority.UseForeColor = false;
         this.xrLabel19.StylePriority.UseTextAlignment = false;
         xrSummary3.FormatString = "{0:#,##0.00}";
         xrSummary3.IgnoreNullValues = true;
         xrSummary3.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
         this.xrLabel19.Summary = xrSummary3;
         this.xrLabel19.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
         // 
         // xrLabel21
         // 
         this.xrLabel21.BackColor = System.Drawing.Color.Silver;
         this.xrLabel21.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.Vat3")});
         this.xrLabel21.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
         this.xrLabel21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
         this.xrLabel21.LocationFloat = new DevExpress.Utils.PointFloat(693.1901F, 0F);
         this.xrLabel21.Name = "xrLabel21";
         this.xrLabel21.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel21.SizeF = new System.Drawing.SizeF(63F, 17F);
         this.xrLabel21.StyleName = "FieldCaption";
         this.xrLabel21.StylePriority.UseBackColor = false;
         this.xrLabel21.StylePriority.UseFont = false;
         this.xrLabel21.StylePriority.UseForeColor = false;
         this.xrLabel21.StylePriority.UseTextAlignment = false;
         xrSummary4.FormatString = "{0:#,##0.00}";
         xrSummary4.IgnoreNullValues = true;
         xrSummary4.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
         this.xrLabel21.Summary = xrSummary4;
         this.xrLabel21.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
         // 
         // xrLabel22
         // 
         this.xrLabel22.BackColor = System.Drawing.Color.Silver;
         this.xrLabel22.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.Vat4")});
         this.xrLabel22.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
         this.xrLabel22.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
         this.xrLabel22.LocationFloat = new DevExpress.Utils.PointFloat(756.1901F, 0F);
         this.xrLabel22.Name = "xrLabel22";
         this.xrLabel22.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel22.SizeF = new System.Drawing.SizeF(63F, 17F);
         this.xrLabel22.StyleName = "FieldCaption";
         this.xrLabel22.StylePriority.UseBackColor = false;
         this.xrLabel22.StylePriority.UseFont = false;
         this.xrLabel22.StylePriority.UseForeColor = false;
         this.xrLabel22.StylePriority.UseTextAlignment = false;
         xrSummary5.FormatString = "{0:#,##0.00}";
         xrSummary5.IgnoreNullValues = true;
         xrSummary5.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
         this.xrLabel22.Summary = xrSummary5;
         this.xrLabel22.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
         // 
         // xrLabel23
         // 
         this.xrLabel23.BackColor = System.Drawing.Color.Silver;
         this.xrLabel23.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.Vat5")});
         this.xrLabel23.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
         this.xrLabel23.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
         this.xrLabel23.LocationFloat = new DevExpress.Utils.PointFloat(819.1901F, 0F);
         this.xrLabel23.Name = "xrLabel23";
         this.xrLabel23.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel23.SizeF = new System.Drawing.SizeF(63F, 17F);
         this.xrLabel23.StyleName = "FieldCaption";
         this.xrLabel23.StylePriority.UseBackColor = false;
         this.xrLabel23.StylePriority.UseFont = false;
         this.xrLabel23.StylePriority.UseForeColor = false;
         this.xrLabel23.StylePriority.UseTextAlignment = false;
         xrSummary6.FormatString = "{0:#,##0.00}";
         xrSummary6.IgnoreNullValues = true;
         xrSummary6.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
         this.xrLabel23.Summary = xrSummary6;
         this.xrLabel23.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
         // 
         // xrLabel24
         // 
         this.xrLabel24.BackColor = System.Drawing.Color.Silver;
         this.xrLabel24.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.TransAmount")});
         this.xrLabel24.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
         this.xrLabel24.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
         this.xrLabel24.LocationFloat = new DevExpress.Utils.PointFloat(882.1901F, 0F);
         this.xrLabel24.Name = "xrLabel24";
         this.xrLabel24.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel24.SizeF = new System.Drawing.SizeF(216.8101F, 17F);
         this.xrLabel24.StyleName = "FieldCaption";
         this.xrLabel24.StylePriority.UseBackColor = false;
         this.xrLabel24.StylePriority.UseFont = false;
         this.xrLabel24.StylePriority.UseForeColor = false;
         this.xrLabel24.StylePriority.UseTextAlignment = false;
         xrSummary7.FormatString = "{0:#,##0.00}";
         xrSummary7.IgnoreNullValues = true;
         xrSummary7.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
         this.xrLabel24.Summary = xrSummary7;
         this.xrLabel24.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
         // 
         // xrLabel8
         // 
         this.xrLabel8.BackColor = System.Drawing.Color.Silver;
         this.xrLabel8.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.StafName", "Σερβιτόρος: {0}")});
         this.xrLabel8.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
         this.xrLabel8.LocationFloat = new DevExpress.Utils.PointFloat(2F, 0F);
         this.xrLabel8.Name = "xrLabel8";
         this.xrLabel8.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel8.SizeF = new System.Drawing.SizeF(405.8411F, 17F);
         this.xrLabel8.StyleName = "DataField";
         this.xrLabel8.StylePriority.UseBackColor = false;
         this.xrLabel8.StylePriority.UseFont = false;
         this.xrLabel8.StylePriority.UseTextAlignment = false;
         this.xrLabel8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
         // 
         // AccountType_GroupHeader
         // 
         this.AccountType_GroupHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel10,
            this.xrLabel72,
            this.xrLabel73,
            this.xrLabel74,
            this.xrLabel75,
            this.xrLabel76,
            this.xrLabel77,
            this.xrLabel78});
         this.AccountType_GroupHeader.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("AccountType", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
         this.AccountType_GroupHeader.HeightF = 15.33334F;
         this.AccountType_GroupHeader.Level = 1;
         this.AccountType_GroupHeader.Name = "AccountType_GroupHeader";
         // 
         // xrLabel10
         // 
         this.xrLabel10.BackColor = System.Drawing.Color.LightGray;
         this.xrLabel10.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.AccountDescription", "Account : {0}")});
         this.xrLabel10.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
         this.xrLabel10.LocationFloat = new DevExpress.Utils.PointFloat(2F, 0F);
         this.xrLabel10.Name = "xrLabel10";
         this.xrLabel10.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel10.SizeF = new System.Drawing.SizeF(405.8411F, 15F);
         this.xrLabel10.StyleName = "DataField";
         this.xrLabel10.StylePriority.UseBackColor = false;
         this.xrLabel10.StylePriority.UseFont = false;
         this.xrLabel10.StylePriority.UseTextAlignment = false;
         this.xrLabel10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
         // 
         // xrLabel72
         // 
         this.xrLabel72.BackColor = System.Drawing.Color.LightGray;
         this.xrLabel72.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.TransAmount")});
         this.xrLabel72.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
         this.xrLabel72.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
         this.xrLabel72.LocationFloat = new DevExpress.Utils.PointFloat(882.1899F, 0F);
         this.xrLabel72.Name = "xrLabel72";
         this.xrLabel72.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel72.SizeF = new System.Drawing.SizeF(216.8101F, 15.33333F);
         this.xrLabel72.StyleName = "FieldCaption";
         this.xrLabel72.StylePriority.UseBackColor = false;
         this.xrLabel72.StylePriority.UseFont = false;
         this.xrLabel72.StylePriority.UseForeColor = false;
         this.xrLabel72.StylePriority.UseTextAlignment = false;
         xrSummary8.FormatString = "{0:#,##0.00}";
         xrSummary8.IgnoreNullValues = true;
         xrSummary8.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
         this.xrLabel72.Summary = xrSummary8;
         this.xrLabel72.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
         // 
         // xrLabel73
         // 
         this.xrLabel73.BackColor = System.Drawing.Color.LightGray;
         this.xrLabel73.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.Vat1")});
         this.xrLabel73.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
         this.xrLabel73.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
         this.xrLabel73.LocationFloat = new DevExpress.Utils.PointFloat(519.5156F, 0F);
         this.xrLabel73.Name = "xrLabel73";
         this.xrLabel73.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel73.SizeF = new System.Drawing.SizeF(110.6743F, 15F);
         this.xrLabel73.StyleName = "FieldCaption";
         this.xrLabel73.StylePriority.UseBackColor = false;
         this.xrLabel73.StylePriority.UseFont = false;
         this.xrLabel73.StylePriority.UseForeColor = false;
         this.xrLabel73.StylePriority.UseTextAlignment = false;
         xrSummary9.FormatString = "{0:#,##0.00}";
         xrSummary9.IgnoreNullValues = true;
         xrSummary9.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
         this.xrLabel73.Summary = xrSummary9;
         this.xrLabel73.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
         // 
         // xrLabel74
         // 
         this.xrLabel74.BackColor = System.Drawing.Color.LightGray;
         this.xrLabel74.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.Vat2")});
         this.xrLabel74.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
         this.xrLabel74.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
         this.xrLabel74.LocationFloat = new DevExpress.Utils.PointFloat(630.1899F, 0F);
         this.xrLabel74.Name = "xrLabel74";
         this.xrLabel74.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel74.SizeF = new System.Drawing.SizeF(63F, 15.33334F);
         this.xrLabel74.StyleName = "FieldCaption";
         this.xrLabel74.StylePriority.UseBackColor = false;
         this.xrLabel74.StylePriority.UseFont = false;
         this.xrLabel74.StylePriority.UseForeColor = false;
         this.xrLabel74.StylePriority.UseTextAlignment = false;
         xrSummary10.FormatString = "{0:#,##0.00}";
         xrSummary10.IgnoreNullValues = true;
         xrSummary10.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
         this.xrLabel74.Summary = xrSummary10;
         this.xrLabel74.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
         // 
         // xrLabel75
         // 
         this.xrLabel75.BackColor = System.Drawing.Color.LightGray;
         this.xrLabel75.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.Vat3")});
         this.xrLabel75.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
         this.xrLabel75.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
         this.xrLabel75.LocationFloat = new DevExpress.Utils.PointFloat(693.1899F, 0F);
         this.xrLabel75.Name = "xrLabel75";
         this.xrLabel75.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel75.SizeF = new System.Drawing.SizeF(63F, 15F);
         this.xrLabel75.StyleName = "FieldCaption";
         this.xrLabel75.StylePriority.UseBackColor = false;
         this.xrLabel75.StylePriority.UseFont = false;
         this.xrLabel75.StylePriority.UseForeColor = false;
         this.xrLabel75.StylePriority.UseTextAlignment = false;
         xrSummary11.FormatString = "{0:#,##0.00}";
         xrSummary11.IgnoreNullValues = true;
         xrSummary11.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
         this.xrLabel75.Summary = xrSummary11;
         this.xrLabel75.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
         // 
         // xrLabel76
         // 
         this.xrLabel76.BackColor = System.Drawing.Color.LightGray;
         this.xrLabel76.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.Vat4")});
         this.xrLabel76.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
         this.xrLabel76.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
         this.xrLabel76.LocationFloat = new DevExpress.Utils.PointFloat(756.1899F, 0F);
         this.xrLabel76.Name = "xrLabel76";
         this.xrLabel76.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel76.SizeF = new System.Drawing.SizeF(63F, 15F);
         this.xrLabel76.StyleName = "FieldCaption";
         this.xrLabel76.StylePriority.UseBackColor = false;
         this.xrLabel76.StylePriority.UseFont = false;
         this.xrLabel76.StylePriority.UseForeColor = false;
         this.xrLabel76.StylePriority.UseTextAlignment = false;
         xrSummary12.FormatString = "{0:#,##0.00}";
         xrSummary12.IgnoreNullValues = true;
         xrSummary12.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
         this.xrLabel76.Summary = xrSummary12;
         this.xrLabel76.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
         // 
         // xrLabel77
         // 
         this.xrLabel77.BackColor = System.Drawing.Color.LightGray;
         this.xrLabel77.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.Vat5")});
         this.xrLabel77.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
         this.xrLabel77.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
         this.xrLabel77.LocationFloat = new DevExpress.Utils.PointFloat(819.1899F, 0F);
         this.xrLabel77.Name = "xrLabel77";
         this.xrLabel77.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel77.SizeF = new System.Drawing.SizeF(63F, 15F);
         this.xrLabel77.StyleName = "FieldCaption";
         this.xrLabel77.StylePriority.UseBackColor = false;
         this.xrLabel77.StylePriority.UseFont = false;
         this.xrLabel77.StylePriority.UseForeColor = false;
         this.xrLabel77.StylePriority.UseTextAlignment = false;
         xrSummary13.FormatString = "{0:#,##0.00}";
         xrSummary13.IgnoreNullValues = true;
         xrSummary13.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
         this.xrLabel77.Summary = xrSummary13;
         this.xrLabel77.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
         // 
         // xrLabel78
         // 
         this.xrLabel78.BackColor = System.Drawing.Color.LightGray;
         this.xrLabel78.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
         this.xrLabel78.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
         this.xrLabel78.LocationFloat = new DevExpress.Utils.PointFloat(407.8411F, 0F);
         this.xrLabel78.Name = "xrLabel78";
         this.xrLabel78.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel78.SizeF = new System.Drawing.SizeF(111.6745F, 15F);
         this.xrLabel78.StyleName = "FieldCaption";
         this.xrLabel78.StylePriority.UseBackColor = false;
         this.xrLabel78.StylePriority.UseFont = false;
         this.xrLabel78.StylePriority.UseForeColor = false;
         this.xrLabel78.StylePriority.UseTextAlignment = false;
         this.xrLabel78.Text = "Σύνολα:";
         this.xrLabel78.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
         // 
         // groupHeaderBand6
         // 
         this.groupHeaderBand6.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel25,
            this.xrLine5,
            this.xrLabel4,
            this.xrLabel11,
            this.xrLabel14,
            this.xrLabel20,
            this.xrLabel27,
            this.xrLabel29,
            this.xrLabel30,
            this.xrLabel31,
            this.xrLabel33,
            this.xrLabel35,
            this.xrLabel37,
            this.xrLabel39,
            this.xrLine2});
         this.groupHeaderBand6.HeightF = 18F;
         this.groupHeaderBand6.Name = "groupHeaderBand6";
         this.groupHeaderBand6.StyleName = "FieldCaption";
         // 
         // xrLabel25
         // 
         this.xrLabel25.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
         this.xrLabel25.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
         this.xrLabel25.LocationFloat = new DevExpress.Utils.PointFloat(519.5156F, 2F);
         this.xrLabel25.Name = "xrLabel25";
         this.xrLabel25.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel25.SizeF = new System.Drawing.SizeF(47.67444F, 14F);
         this.xrLabel25.StylePriority.UseFont = false;
         this.xrLabel25.StylePriority.UseForeColor = false;
         this.xrLabel25.StylePriority.UseTextAlignment = false;
         this.xrLabel25.Text = "Couver";
         this.xrLabel25.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
         // 
         // xrLine5
         // 
         this.xrLine5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
         this.xrLine5.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
         this.xrLine5.Name = "xrLine5";
         this.xrLine5.SizeF = new System.Drawing.SizeF(1101F, 2F);
         this.xrLine5.StylePriority.UseForeColor = false;
         // 
         // xrLabel4
         // 
         this.xrLabel4.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
         this.xrLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
         this.xrLabel4.LocationFloat = new DevExpress.Utils.PointFloat(2F, 2F);
         this.xrLabel4.Name = "xrLabel4";
         this.xrLabel4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel4.SizeF = new System.Drawing.SizeF(129.1359F, 14F);
         this.xrLabel4.StylePriority.UseFont = false;
         this.xrLabel4.StylePriority.UseForeColor = false;
         this.xrLabel4.StylePriority.UseTextAlignment = false;
         this.xrLabel4.Text = "Ημέρα - Ώρα";
         this.xrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
         // 
         // xrLabel11
         // 
         this.xrLabel11.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
         this.xrLabel11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
         this.xrLabel11.LocationFloat = new DevExpress.Utils.PointFloat(131.1359F, 2F);
         this.xrLabel11.Name = "xrLabel11";
         this.xrLabel11.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel11.SizeF = new System.Drawing.SizeF(94.66464F, 14F);
         this.xrLabel11.StylePriority.UseFont = false;
         this.xrLabel11.StylePriority.UseForeColor = false;
         this.xrLabel11.StylePriority.UseTextAlignment = false;
         this.xrLabel11.Text = "Τύπος";
         this.xrLabel11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
         // 
         // xrLabel14
         // 
         this.xrLabel14.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
         this.xrLabel14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
         this.xrLabel14.LocationFloat = new DevExpress.Utils.PointFloat(225.8006F, 2F);
         this.xrLabel14.Name = "xrLabel14";
         this.xrLabel14.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel14.SizeF = new System.Drawing.SizeF(89.98883F, 14F);
         this.xrLabel14.StylePriority.UseFont = false;
         this.xrLabel14.StylePriority.UseForeColor = false;
         this.xrLabel14.StylePriority.UseTextAlignment = false;
         this.xrLabel14.Text = "#Απόδειξης";
         this.xrLabel14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
         // 
         // xrLabel20
         // 
         this.xrLabel20.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
         this.xrLabel20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
         this.xrLabel20.LocationFloat = new DevExpress.Utils.PointFloat(882.1899F, 2F);
         this.xrLabel20.Name = "xrLabel20";
         this.xrLabel20.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel20.SizeF = new System.Drawing.SizeF(111.4557F, 14F);
         this.xrLabel20.StylePriority.UseFont = false;
         this.xrLabel20.StylePriority.UseForeColor = false;
         this.xrLabel20.StylePriority.UseTextAlignment = false;
         this.xrLabel20.Text = "Σύνολο";
         this.xrLabel20.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
         // 
         // xrLabel27
         // 
         this.xrLabel27.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
         this.xrLabel27.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
         this.xrLabel27.LocationFloat = new DevExpress.Utils.PointFloat(315.7894F, 2F);
         this.xrLabel27.Name = "xrLabel27";
         this.xrLabel27.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel27.SizeF = new System.Drawing.SizeF(115.0518F, 14F);
         this.xrLabel27.StylePriority.UseFont = false;
         this.xrLabel27.StylePriority.UseForeColor = false;
         this.xrLabel27.StylePriority.UseTextAlignment = false;
         this.xrLabel27.Text = "Δωμάτιο";
         this.xrLabel27.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
         // 
         // xrLabel29
         // 
         this.xrLabel29.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
         this.xrLabel29.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
         this.xrLabel29.LocationFloat = new DevExpress.Utils.PointFloat(430.8412F, 2F);
         this.xrLabel29.Name = "xrLabel29";
         this.xrLabel29.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel29.SizeF = new System.Drawing.SizeF(88.67444F, 14F);
         this.xrLabel29.StylePriority.UseFont = false;
         this.xrLabel29.StylePriority.UseForeColor = false;
         this.xrLabel29.StylePriority.UseTextAlignment = false;
         this.xrLabel29.Text = "Τραπέζι";
         this.xrLabel29.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
         // 
         // xrLabel30
         // 
         this.xrLabel30.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
         this.xrLabel30.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
         this.xrLabel30.LocationFloat = new DevExpress.Utils.PointFloat(993.6456F, 2F);
         this.xrLabel30.Name = "xrLabel30";
         this.xrLabel30.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel30.SizeF = new System.Drawing.SizeF(105.3544F, 14F);
         this.xrLabel30.StylePriority.UseFont = false;
         this.xrLabel30.StylePriority.UseForeColor = false;
         this.xrLabel30.StylePriority.UseTextAlignment = false;
         this.xrLabel30.Text = "Πληρωμένο";
         this.xrLabel30.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
         // 
         // xrLabel31
         // 
         this.xrLabel31.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.Vat1Pst")});
         this.xrLabel31.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
         this.xrLabel31.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
         this.xrLabel31.LocationFloat = new DevExpress.Utils.PointFloat(567.1899F, 2F);
         this.xrLabel31.Name = "xrLabel31";
         this.xrLabel31.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel31.SizeF = new System.Drawing.SizeF(63F, 14F);
         this.xrLabel31.StylePriority.UseFont = false;
         this.xrLabel31.StylePriority.UseForeColor = false;
         this.xrLabel31.StylePriority.UseTextAlignment = false;
         xrSummary14.FormatString = "ΦΠΑ {0:0.##}%";
         xrSummary14.Func = DevExpress.XtraReports.UI.SummaryFunc.Max;
         xrSummary14.Running = DevExpress.XtraReports.UI.SummaryRunning.Report;
         this.xrLabel31.Summary = xrSummary14;
         this.xrLabel31.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
         // 
         // xrLabel33
         // 
         this.xrLabel33.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.Vat2Pst")});
         this.xrLabel33.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
         this.xrLabel33.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
         this.xrLabel33.LocationFloat = new DevExpress.Utils.PointFloat(630.1899F, 2F);
         this.xrLabel33.Name = "xrLabel33";
         this.xrLabel33.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel33.SizeF = new System.Drawing.SizeF(63F, 14F);
         this.xrLabel33.StylePriority.UseFont = false;
         this.xrLabel33.StylePriority.UseForeColor = false;
         this.xrLabel33.StylePriority.UseTextAlignment = false;
         xrSummary15.FormatString = "ΦΠΑ {0:0.##}%";
         xrSummary15.Func = DevExpress.XtraReports.UI.SummaryFunc.Max;
         xrSummary15.Running = DevExpress.XtraReports.UI.SummaryRunning.Report;
         this.xrLabel33.Summary = xrSummary15;
         this.xrLabel33.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
         // 
         // xrLabel35
         // 
         this.xrLabel35.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.Vat3Pst")});
         this.xrLabel35.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
         this.xrLabel35.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
         this.xrLabel35.LocationFloat = new DevExpress.Utils.PointFloat(693.1899F, 2F);
         this.xrLabel35.Name = "xrLabel35";
         this.xrLabel35.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel35.SizeF = new System.Drawing.SizeF(63F, 14F);
         this.xrLabel35.StylePriority.UseFont = false;
         this.xrLabel35.StylePriority.UseForeColor = false;
         this.xrLabel35.StylePriority.UseTextAlignment = false;
         xrSummary16.FormatString = "ΦΠΑ {0:0.##}%";
         xrSummary16.Func = DevExpress.XtraReports.UI.SummaryFunc.Max;
         xrSummary16.Running = DevExpress.XtraReports.UI.SummaryRunning.Report;
         this.xrLabel35.Summary = xrSummary16;
         this.xrLabel35.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
         // 
         // xrLabel37
         // 
         this.xrLabel37.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.Vat4Pst")});
         this.xrLabel37.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
         this.xrLabel37.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
         this.xrLabel37.LocationFloat = new DevExpress.Utils.PointFloat(756.1899F, 2F);
         this.xrLabel37.Name = "xrLabel37";
         this.xrLabel37.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel37.SizeF = new System.Drawing.SizeF(63F, 14F);
         this.xrLabel37.StylePriority.UseFont = false;
         this.xrLabel37.StylePriority.UseForeColor = false;
         this.xrLabel37.StylePriority.UseTextAlignment = false;
         xrSummary17.FormatString = "ΦΠΑ {0:0.##}%";
         xrSummary17.Func = DevExpress.XtraReports.UI.SummaryFunc.Max;
         xrSummary17.IgnoreNullValues = true;
         xrSummary17.Running = DevExpress.XtraReports.UI.SummaryRunning.Report;
         this.xrLabel37.Summary = xrSummary17;
         this.xrLabel37.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
         // 
         // xrLabel39
         // 
         this.xrLabel39.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.Vat5Pst")});
         this.xrLabel39.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
         this.xrLabel39.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
         this.xrLabel39.LocationFloat = new DevExpress.Utils.PointFloat(819.1899F, 2F);
         this.xrLabel39.Name = "xrLabel39";
         this.xrLabel39.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel39.SizeF = new System.Drawing.SizeF(63F, 14F);
         this.xrLabel39.StylePriority.UseFont = false;
         this.xrLabel39.StylePriority.UseForeColor = false;
         this.xrLabel39.StylePriority.UseTextAlignment = false;
         xrSummary18.FormatString = "ΦΠΑ {0:0.##}%";
         xrSummary18.Func = DevExpress.XtraReports.UI.SummaryFunc.Max;
         xrSummary18.IgnoreNullValues = true;
         xrSummary18.Running = DevExpress.XtraReports.UI.SummaryRunning.Report;
         this.xrLabel39.Summary = xrSummary18;
         this.xrLabel39.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
         // 
         // xrLine2
         // 
         this.xrLine2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
         this.xrLine2.LocationFloat = new DevExpress.Utils.PointFloat(0F, 16F);
         this.xrLine2.Name = "xrLine2";
         this.xrLine2.SizeF = new System.Drawing.SizeF(1101F, 2F);
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
         this.xrPageInfo1.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
         this.xrPageInfo1.Format = "Σελίδα {0} από {1}";
         this.xrPageInfo1.LocationFloat = new DevExpress.Utils.PointFloat(2F, 0F);
         this.xrPageInfo1.Name = "xrPageInfo1";
         this.xrPageInfo1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrPageInfo1.SizeF = new System.Drawing.SizeF(1097F, 18.76271F);
         this.xrPageInfo1.StylePriority.UseBorders = false;
         this.xrPageInfo1.StylePriority.UseFont = false;
         this.xrPageInfo1.StylePriority.UseTextAlignment = false;
         this.xrPageInfo1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
         // 
         // reportHeaderBand1
         // 
         this.reportHeaderBand1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel15,
            this.xrLabel70});
         this.reportHeaderBand1.HeightF = 25.99999F;
         this.reportHeaderBand1.Name = "reportHeaderBand1";
         // 
         // xrLabel15
         // 
         this.xrLabel15.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding(this.UpToFODay, "Text", " έως  {0})")});
         this.xrLabel15.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
         this.xrLabel15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
         this.xrLabel15.LocationFloat = new DevExpress.Utils.PointFloat(620.3223F, 0F);
         this.xrLabel15.Name = "xrLabel15";
         this.xrLabel15.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel15.SizeF = new System.Drawing.SizeF(478.6777F, 23F);
         this.xrLabel15.StyleName = "Title";
         this.xrLabel15.StylePriority.UseFont = false;
         this.xrLabel15.StylePriority.UseForeColor = false;
         this.xrLabel15.StylePriority.UseTextAlignment = false;
         this.xrLabel15.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
         // 
         // UpToFODay
         // 
         this.UpToFODay.Description = "UpTo Date";
         this.UpToFODay.Name = "UpToFODay";
         this.UpToFODay.Type = typeof(System.DateTime);
         this.UpToFODay.ValueInfo = "2016-05-31";
         // 
         // xrLabel70
         // 
         this.xrLabel70.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding(this.FromFODay, "Text", "Πωλήσεις ανά Σερβιτόρο (από {0}")});
         this.xrLabel70.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
         this.xrLabel70.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
         this.xrLabel70.LocationFloat = new DevExpress.Utils.PointFloat(2F, 0F);
         this.xrLabel70.Name = "xrLabel70";
         this.xrLabel70.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel70.SizeF = new System.Drawing.SizeF(618.3223F, 23F);
         this.xrLabel70.StyleName = "Title";
         this.xrLabel70.StylePriority.UseFont = false;
         this.xrLabel70.StylePriority.UseForeColor = false;
         this.xrLabel70.StylePriority.UseTextAlignment = false;
         this.xrLabel70.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
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
         // reportFooterBand1
         // 
         this.reportFooterBand1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLine7,
            this.xrLabel112,
            this.xrLabel113,
            this.xrLabel114,
            this.xrLabel115,
            this.xrLabel116,
            this.xrLabel117,
            this.xrLabel118});
         this.reportFooterBand1.HeightF = 23.74999F;
         this.reportFooterBand1.Name = "reportFooterBand1";
         this.reportFooterBand1.Visible = false;
         // 
         // xrLine7
         // 
         this.xrLine7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
         this.xrLine7.LocationFloat = new DevExpress.Utils.PointFloat(0F, 1.5F);
         this.xrLine7.Name = "xrLine7";
         this.xrLine7.SizeF = new System.Drawing.SizeF(1074F, 2F);
         this.xrLine7.StylePriority.UseForeColor = false;
         // 
         // xrLabel112
         // 
         this.xrLabel112.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.TransAmount", "{0:C2}")});
         this.xrLabel112.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
         this.xrLabel112.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
         this.xrLabel112.LocationFloat = new DevExpress.Utils.PointFloat(857.1898F, 4F);
         this.xrLabel112.Name = "xrLabel112";
         this.xrLabel112.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel112.SizeF = new System.Drawing.SizeF(216.8102F, 16F);
         this.xrLabel112.StyleName = "FieldCaption";
         this.xrLabel112.StylePriority.UseFont = false;
         this.xrLabel112.StylePriority.UseForeColor = false;
         this.xrLabel112.StylePriority.UseTextAlignment = false;
         xrSummary19.FormatString = "{0:0.00}";
         xrSummary19.Running = DevExpress.XtraReports.UI.SummaryRunning.Report;
         this.xrLabel112.Summary = xrSummary19;
         this.xrLabel112.Text = "xrLabel112";
         this.xrLabel112.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
         // 
         // xrLabel113
         // 
         this.xrLabel113.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.Vat1", "{0:C2}")});
         this.xrLabel113.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
         this.xrLabel113.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
         this.xrLabel113.LocationFloat = new DevExpress.Utils.PointFloat(423.0541F, 4F);
         this.xrLabel113.Name = "xrLabel113";
         this.xrLabel113.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel113.SizeF = new System.Drawing.SizeF(86.63412F, 16F);
         this.xrLabel113.StyleName = "FieldCaption";
         this.xrLabel113.StylePriority.UseFont = false;
         this.xrLabel113.StylePriority.UseForeColor = false;
         this.xrLabel113.StylePriority.UseTextAlignment = false;
         xrSummary20.FormatString = "{0:0.00}";
         xrSummary20.Running = DevExpress.XtraReports.UI.SummaryRunning.Report;
         this.xrLabel113.Summary = xrSummary20;
         this.xrLabel113.Text = "xrLabel113";
         this.xrLabel113.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
         // 
         // xrLabel114
         // 
         this.xrLabel114.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.Vat2", "{0:C2}")});
         this.xrLabel114.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
         this.xrLabel114.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
         this.xrLabel114.LocationFloat = new DevExpress.Utils.PointFloat(509.6882F, 4F);
         this.xrLabel114.Name = "xrLabel114";
         this.xrLabel114.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel114.SizeF = new System.Drawing.SizeF(86.63412F, 16F);
         this.xrLabel114.StyleName = "FieldCaption";
         this.xrLabel114.StylePriority.UseFont = false;
         this.xrLabel114.StylePriority.UseForeColor = false;
         this.xrLabel114.StylePriority.UseTextAlignment = false;
         xrSummary21.FormatString = "{0:0.00}";
         xrSummary21.Running = DevExpress.XtraReports.UI.SummaryRunning.Report;
         this.xrLabel114.Summary = xrSummary21;
         this.xrLabel114.Text = "xrLabel114";
         this.xrLabel114.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
         // 
         // xrLabel115
         // 
         this.xrLabel115.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.Vat3", "{0:C2}")});
         this.xrLabel115.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
         this.xrLabel115.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
         this.xrLabel115.LocationFloat = new DevExpress.Utils.PointFloat(596.3223F, 4F);
         this.xrLabel115.Name = "xrLabel115";
         this.xrLabel115.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel115.SizeF = new System.Drawing.SizeF(86.63409F, 16F);
         this.xrLabel115.StyleName = "FieldCaption";
         this.xrLabel115.StylePriority.UseFont = false;
         this.xrLabel115.StylePriority.UseForeColor = false;
         this.xrLabel115.StylePriority.UseTextAlignment = false;
         xrSummary22.FormatString = "{0:0.00}";
         xrSummary22.Running = DevExpress.XtraReports.UI.SummaryRunning.Report;
         this.xrLabel115.Summary = xrSummary22;
         this.xrLabel115.Text = "xrLabel115";
         this.xrLabel115.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
         // 
         // xrLabel116
         // 
         this.xrLabel116.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.Vat4", "{0:C2}")});
         this.xrLabel116.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
         this.xrLabel116.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
         this.xrLabel116.LocationFloat = new DevExpress.Utils.PointFloat(684.6959F, 4F);
         this.xrLabel116.Name = "xrLabel116";
         this.xrLabel116.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel116.SizeF = new System.Drawing.SizeF(84.89465F, 16F);
         this.xrLabel116.StyleName = "FieldCaption";
         this.xrLabel116.StylePriority.UseFont = false;
         this.xrLabel116.StylePriority.UseForeColor = false;
         this.xrLabel116.StylePriority.UseTextAlignment = false;
         xrSummary23.FormatString = "{0:0.00}";
         xrSummary23.Running = DevExpress.XtraReports.UI.SummaryRunning.Report;
         this.xrLabel116.Summary = xrSummary23;
         this.xrLabel116.Text = "xrLabel116";
         this.xrLabel116.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
         // 
         // xrLabel117
         // 
         this.xrLabel117.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.Vat5", "{0:C2}")});
         this.xrLabel117.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
         this.xrLabel117.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
         this.xrLabel117.LocationFloat = new DevExpress.Utils.PointFloat(770.5557F, 4F);
         this.xrLabel117.Name = "xrLabel117";
         this.xrLabel117.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel117.SizeF = new System.Drawing.SizeF(86.63409F, 16F);
         this.xrLabel117.StyleName = "FieldCaption";
         this.xrLabel117.StylePriority.UseFont = false;
         this.xrLabel117.StylePriority.UseForeColor = false;
         this.xrLabel117.StylePriority.UseTextAlignment = false;
         xrSummary24.FormatString = "{0:0.00}";
         xrSummary24.Running = DevExpress.XtraReports.UI.SummaryRunning.Report;
         this.xrLabel117.Summary = xrSummary24;
         this.xrLabel117.Text = "xrLabel117";
         this.xrLabel117.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
         // 
         // xrLabel118
         // 
         this.xrLabel118.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
         this.xrLabel118.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
         this.xrLabel118.LocationFloat = new DevExpress.Utils.PointFloat(248.6171F, 3.999974F);
         this.xrLabel118.Name = "xrLabel118";
         this.xrLabel118.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel118.SizeF = new System.Drawing.SizeF(174.437F, 16F);
         this.xrLabel118.StyleName = "FieldCaption";
         this.xrLabel118.StylePriority.UseFont = false;
         this.xrLabel118.StylePriority.UseForeColor = false;
         this.xrLabel118.StylePriority.UseTextAlignment = false;
         this.xrLabel118.Text = "(Β) Γενικά Σύνολα : ";
         this.xrLabel118.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
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
         // StaffID
         // 
         this.StaffID.Description = "Select Staff";
         dynamicListLookUpSettings2.DataAdapter = null;
         dynamicListLookUpSettings2.DataMember = "StaffLookUps";
         dynamicListLookUpSettings2.DataSource = this.sqlDataSource1;
         dynamicListLookUpSettings2.DisplayMember = "StafName";
         dynamicListLookUpSettings2.FilterString = null;
         dynamicListLookUpSettings2.ValueMember = "StaffCode";
         this.StaffID.LookUpSettings = dynamicListLookUpSettings2;
         this.StaffID.MultiValue = true;
         this.StaffID.Name = "StaffID";
         // 
         // AccountType
         // 
         this.AccountType.Description = "Select Account";
         dynamicListLookUpSettings3.DataAdapter = null;
         dynamicListLookUpSettings3.DataMember = "AccountsLookups";
         dynamicListLookUpSettings3.DataSource = this.sqlDataSource1;
         dynamicListLookUpSettings3.DisplayMember = "Description";
         dynamicListLookUpSettings3.FilterString = null;
         dynamicListLookUpSettings3.ValueMember = "Type";
         this.AccountType.LookUpSettings = dynamicListLookUpSettings3;
         this.AccountType.MultiValue = true;
         this.AccountType.Name = "AccountType";
         this.AccountType.Type = typeof(short);
         // 
         // GroupHeader1
         // 
         this.GroupHeader1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel13});
         this.GroupHeader1.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("IsVoided", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
         this.GroupHeader1.HeightF = 17F;
         this.GroupHeader1.Level = 4;
         this.GroupHeader1.Name = "GroupHeader1";
         // 
         // xrLabel13
         // 
         this.xrLabel13.BackColor = System.Drawing.Color.DimGray;
         this.xrLabel13.Borders = DevExpress.XtraPrinting.BorderSide.None;
         this.xrLabel13.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.IsVoided", "Ακυρωμένες")});
         this.xrLabel13.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
         this.xrLabel13.ForeColor = System.Drawing.Color.White;
         this.xrLabel13.FormattingRules.Add(this.formattingRule1);
         this.xrLabel13.LocationFloat = new DevExpress.Utils.PointFloat(2F, 0F);
         this.xrLabel13.Name = "xrLabel13";
         this.xrLabel13.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel13.SizeF = new System.Drawing.SizeF(1097F, 17F);
         this.xrLabel13.StyleName = "DataField";
         this.xrLabel13.StylePriority.UseBackColor = false;
         this.xrLabel13.StylePriority.UseBorders = false;
         this.xrLabel13.StylePriority.UseFont = false;
         this.xrLabel13.StylePriority.UseForeColor = false;
         this.xrLabel13.StylePriority.UseTextAlignment = false;
         this.xrLabel13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
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
         // GroupFooter1
         // 
         this.GroupFooter1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLine6,
            this.xrLabel1,
            this.xrLabel2,
            this.xrLabel3,
            this.xrLabel5,
            this.xrLabel7,
            this.xrLabel9,
            this.xrLabel12});
         this.GroupFooter1.HeightF = 29.16667F;
         this.GroupFooter1.Level = 4;
         this.GroupFooter1.Name = "GroupFooter1";
         // 
         // xrLine6
         // 
         this.xrLine6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
         this.xrLine6.LocationFloat = new DevExpress.Utils.PointFloat(0F, 1.5F);
         this.xrLine6.Name = "xrLine6";
         this.xrLine6.SizeF = new System.Drawing.SizeF(1101F, 2F);
         this.xrLine6.StylePriority.UseForeColor = false;
         // 
         // xrLabel1
         // 
         this.xrLabel1.BackColor = System.Drawing.Color.LightGray;
         this.xrLabel1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
         this.xrLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
         this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(1F, 4F);
         this.xrLabel1.Name = "xrLabel1";
         this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel1.SizeF = new System.Drawing.SizeF(422.054F, 18F);
         this.xrLabel1.StyleName = "FieldCaption";
         this.xrLabel1.StylePriority.UseBackColor = false;
         this.xrLabel1.StylePriority.UseFont = false;
         this.xrLabel1.StylePriority.UseForeColor = false;
         this.xrLabel1.StylePriority.UseTextAlignment = false;
         this.xrLabel1.Text = "Γενικά Σύνολα : ";
         this.xrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
         // 
         // xrLabel2
         // 
         this.xrLabel2.BackColor = System.Drawing.Color.LightGray;
         this.xrLabel2.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.Vat5")});
         this.xrLabel2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
         this.xrLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
         this.xrLabel2.LocationFloat = new DevExpress.Utils.PointFloat(819.1899F, 4.000027F);
         this.xrLabel2.Name = "xrLabel2";
         this.xrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel2.SizeF = new System.Drawing.SizeF(63F, 18F);
         this.xrLabel2.StyleName = "FieldCaption";
         this.xrLabel2.StylePriority.UseBackColor = false;
         this.xrLabel2.StylePriority.UseFont = false;
         this.xrLabel2.StylePriority.UseForeColor = false;
         this.xrLabel2.StylePriority.UseTextAlignment = false;
         xrSummary25.FormatString = "{0:#,##0.00}";
         xrSummary25.IgnoreNullValues = true;
         xrSummary25.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
         this.xrLabel2.Summary = xrSummary25;
         this.xrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
         // 
         // xrLabel3
         // 
         this.xrLabel3.BackColor = System.Drawing.Color.LightGray;
         this.xrLabel3.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.Vat4")});
         this.xrLabel3.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
         this.xrLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
         this.xrLabel3.LocationFloat = new DevExpress.Utils.PointFloat(756.1899F, 4.000027F);
         this.xrLabel3.Name = "xrLabel3";
         this.xrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel3.SizeF = new System.Drawing.SizeF(63F, 18F);
         this.xrLabel3.StyleName = "FieldCaption";
         this.xrLabel3.StylePriority.UseBackColor = false;
         this.xrLabel3.StylePriority.UseFont = false;
         this.xrLabel3.StylePriority.UseForeColor = false;
         this.xrLabel3.StylePriority.UseTextAlignment = false;
         xrSummary26.FormatString = "{0:#,##0.00}";
         xrSummary26.IgnoreNullValues = true;
         xrSummary26.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
         this.xrLabel3.Summary = xrSummary26;
         this.xrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
         // 
         // xrLabel5
         // 
         this.xrLabel5.BackColor = System.Drawing.Color.LightGray;
         this.xrLabel5.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.Vat3")});
         this.xrLabel5.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
         this.xrLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
         this.xrLabel5.LocationFloat = new DevExpress.Utils.PointFloat(693.1899F, 4.000027F);
         this.xrLabel5.Name = "xrLabel5";
         this.xrLabel5.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel5.SizeF = new System.Drawing.SizeF(63F, 18F);
         this.xrLabel5.StyleName = "FieldCaption";
         this.xrLabel5.StylePriority.UseBackColor = false;
         this.xrLabel5.StylePriority.UseFont = false;
         this.xrLabel5.StylePriority.UseForeColor = false;
         this.xrLabel5.StylePriority.UseTextAlignment = false;
         xrSummary27.FormatString = "{0:#,##0.00}";
         xrSummary27.IgnoreNullValues = true;
         xrSummary27.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
         this.xrLabel5.Summary = xrSummary27;
         this.xrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
         // 
         // xrLabel7
         // 
         this.xrLabel7.BackColor = System.Drawing.Color.LightGray;
         this.xrLabel7.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.Vat2")});
         this.xrLabel7.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
         this.xrLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
         this.xrLabel7.LocationFloat = new DevExpress.Utils.PointFloat(630.1899F, 4.000027F);
         this.xrLabel7.Name = "xrLabel7";
         this.xrLabel7.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel7.SizeF = new System.Drawing.SizeF(63F, 18F);
         this.xrLabel7.StyleName = "FieldCaption";
         this.xrLabel7.StylePriority.UseBackColor = false;
         this.xrLabel7.StylePriority.UseFont = false;
         this.xrLabel7.StylePriority.UseForeColor = false;
         this.xrLabel7.StylePriority.UseTextAlignment = false;
         xrSummary28.FormatString = "{0:#,##0.00}";
         xrSummary28.IgnoreNullValues = true;
         xrSummary28.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
         this.xrLabel7.Summary = xrSummary28;
         this.xrLabel7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
         // 
         // xrLabel9
         // 
         this.xrLabel9.BackColor = System.Drawing.Color.LightGray;
         this.xrLabel9.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.Vat1")});
         this.xrLabel9.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
         this.xrLabel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
         this.xrLabel9.LocationFloat = new DevExpress.Utils.PointFloat(423.0541F, 4.000027F);
         this.xrLabel9.Name = "xrLabel9";
         this.xrLabel9.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel9.SizeF = new System.Drawing.SizeF(207.1358F, 18F);
         this.xrLabel9.StyleName = "FieldCaption";
         this.xrLabel9.StylePriority.UseBackColor = false;
         this.xrLabel9.StylePriority.UseFont = false;
         this.xrLabel9.StylePriority.UseForeColor = false;
         this.xrLabel9.StylePriority.UseTextAlignment = false;
         xrSummary29.FormatString = "{0:#,##0.00}";
         xrSummary29.IgnoreNullValues = true;
         xrSummary29.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
         this.xrLabel9.Summary = xrSummary29;
         this.xrLabel9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
         // 
         // xrLabel12
         // 
         this.xrLabel12.BackColor = System.Drawing.Color.LightGray;
         this.xrLabel12.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.TransAmount")});
         this.xrLabel12.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
         this.xrLabel12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
         this.xrLabel12.LocationFloat = new DevExpress.Utils.PointFloat(882.1899F, 4.000027F);
         this.xrLabel12.Name = "xrLabel12";
         this.xrLabel12.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel12.SizeF = new System.Drawing.SizeF(216.8102F, 18F);
         this.xrLabel12.StyleName = "FieldCaption";
         this.xrLabel12.StylePriority.UseBackColor = false;
         this.xrLabel12.StylePriority.UseFont = false;
         this.xrLabel12.StylePriority.UseForeColor = false;
         this.xrLabel12.StylePriority.UseTextAlignment = false;
         xrSummary30.FormatString = "{0:#,##0.00}";
         xrSummary30.IgnoreNullValues = true;
         xrSummary30.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
         this.xrLabel12.Summary = xrSummary30;
         this.xrLabel12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
         // 
         // sqlDataSource2
         // 
         this.sqlDataSource2.ConnectionName = "ReportConnection";
         this.sqlDataSource2.Name = "sqlDataSource2";
         customSqlQuery7.Name = "Query";
         queryParameter3.Name = "FromFODay";
         queryParameter3.Type = typeof(DevExpress.DataAccess.Expression);
         queryParameter3.Value = new DevExpress.DataAccess.Expression("[Parameters.FromFODay]", typeof(System.DateTime));
         queryParameter4.Name = "ToFODay";
         queryParameter4.Type = typeof(DevExpress.DataAccess.Expression);
         queryParameter4.Value = new DevExpress.DataAccess.Expression("[Parameters.UpToFODay]", typeof(System.DateTime));
         customSqlQuery7.Parameters.Add(queryParameter3);
         customSqlQuery7.Parameters.Add(queryParameter4);
         customSqlQuery7.Sql = resources.GetString("customSqlQuery7.Sql");
         this.sqlDataSource2.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            customSqlQuery7});
         this.sqlDataSource2.ResultSchemaSerializable = resources.GetString("sqlDataSource2.ResultSchemaSerializable");
         // 
         // PosInfoId_GroupFooter
         // 
         this.PosInfoId_GroupFooter.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLine4,
            this.xrLabel86,
            this.xrLabel85,
            this.xrLabel84,
            this.xrLabel83,
            this.xrLabel82,
            this.xrLabel81,
            this.xrLabel80,
            this.xrLine3});
         this.PosInfoId_GroupFooter.HeightF = 28.125F;
         this.PosInfoId_GroupFooter.Level = 3;
         this.PosInfoId_GroupFooter.Name = "PosInfoId_GroupFooter";
         // 
         // xrLine4
         // 
         this.xrLine4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
         this.xrLine4.LocationFloat = new DevExpress.Utils.PointFloat(0F, 22.5F);
         this.xrLine4.Name = "xrLine4";
         this.xrLine4.SizeF = new System.Drawing.SizeF(1101F, 2F);
         this.xrLine4.StylePriority.UseForeColor = false;
         // 
         // xrLabel86
         // 
         this.xrLabel86.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
         this.xrLabel86.LocationFloat = new DevExpress.Utils.PointFloat(248.6171F, 4F);
         this.xrLabel86.Name = "xrLabel86";
         this.xrLabel86.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel86.SizeF = new System.Drawing.SizeF(174.437F, 18F);
         this.xrLabel86.StyleName = "FieldCaption";
         this.xrLabel86.StylePriority.UseForeColor = false;
         this.xrLabel86.StylePriority.UseTextAlignment = false;
         this.xrLabel86.Text = "Σύνολα POS : ";
         this.xrLabel86.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
         // 
         // xrLabel85
         // 
         this.xrLabel85.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.Vat5")});
         this.xrLabel85.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
         this.xrLabel85.LocationFloat = new DevExpress.Utils.PointFloat(819.1899F, 3.999992F);
         this.xrLabel85.Name = "xrLabel85";
         this.xrLabel85.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel85.SizeF = new System.Drawing.SizeF(63F, 18F);
         this.xrLabel85.StyleName = "FieldCaption";
         this.xrLabel85.StylePriority.UseForeColor = false;
         this.xrLabel85.StylePriority.UseTextAlignment = false;
         xrSummary31.FormatString = "{0:#,##0.00}";
         xrSummary31.IgnoreNullValues = true;
         xrSummary31.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
         this.xrLabel85.Summary = xrSummary31;
         this.xrLabel85.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
         // 
         // xrLabel84
         // 
         this.xrLabel84.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.Vat4")});
         this.xrLabel84.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
         this.xrLabel84.LocationFloat = new DevExpress.Utils.PointFloat(756.1899F, 3.999992F);
         this.xrLabel84.Name = "xrLabel84";
         this.xrLabel84.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel84.SizeF = new System.Drawing.SizeF(63F, 18F);
         this.xrLabel84.StyleName = "FieldCaption";
         this.xrLabel84.StylePriority.UseForeColor = false;
         this.xrLabel84.StylePriority.UseTextAlignment = false;
         xrSummary32.FormatString = "{0:#,##0.00}";
         xrSummary32.IgnoreNullValues = true;
         xrSummary32.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
         this.xrLabel84.Summary = xrSummary32;
         this.xrLabel84.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
         // 
         // xrLabel83
         // 
         this.xrLabel83.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.Vat3")});
         this.xrLabel83.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
         this.xrLabel83.LocationFloat = new DevExpress.Utils.PointFloat(693.1899F, 3.999992F);
         this.xrLabel83.Name = "xrLabel83";
         this.xrLabel83.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel83.SizeF = new System.Drawing.SizeF(63F, 18F);
         this.xrLabel83.StyleName = "FieldCaption";
         this.xrLabel83.StylePriority.UseForeColor = false;
         this.xrLabel83.StylePriority.UseTextAlignment = false;
         xrSummary33.FormatString = "{0:#,##0.00}";
         xrSummary33.IgnoreNullValues = true;
         xrSummary33.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
         this.xrLabel83.Summary = xrSummary33;
         this.xrLabel83.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
         // 
         // xrLabel82
         // 
         this.xrLabel82.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.Vat2")});
         this.xrLabel82.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
         this.xrLabel82.LocationFloat = new DevExpress.Utils.PointFloat(630.1899F, 3.999992F);
         this.xrLabel82.Name = "xrLabel82";
         this.xrLabel82.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel82.SizeF = new System.Drawing.SizeF(63F, 18F);
         this.xrLabel82.StyleName = "FieldCaption";
         this.xrLabel82.StylePriority.UseForeColor = false;
         this.xrLabel82.StylePriority.UseTextAlignment = false;
         xrSummary34.FormatString = "{0:#,##0.00}";
         xrSummary34.IgnoreNullValues = true;
         xrSummary34.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
         this.xrLabel82.Summary = xrSummary34;
         this.xrLabel82.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
         // 
         // xrLabel81
         // 
         this.xrLabel81.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.Vat1")});
         this.xrLabel81.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
         this.xrLabel81.LocationFloat = new DevExpress.Utils.PointFloat(423.0541F, 3.999992F);
         this.xrLabel81.Name = "xrLabel81";
         this.xrLabel81.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel81.SizeF = new System.Drawing.SizeF(207.1358F, 18F);
         this.xrLabel81.StyleName = "FieldCaption";
         this.xrLabel81.StylePriority.UseForeColor = false;
         this.xrLabel81.StylePriority.UseTextAlignment = false;
         xrSummary35.FormatString = "{0:#,##0.00}";
         xrSummary35.IgnoreNullValues = true;
         xrSummary35.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
         this.xrLabel81.Summary = xrSummary35;
         this.xrLabel81.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
         // 
         // xrLabel80
         // 
         this.xrLabel80.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.TransAmount")});
         this.xrLabel80.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
         this.xrLabel80.LocationFloat = new DevExpress.Utils.PointFloat(882.1899F, 3.999992F);
         this.xrLabel80.Name = "xrLabel80";
         this.xrLabel80.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel80.SizeF = new System.Drawing.SizeF(216.8101F, 18F);
         this.xrLabel80.StyleName = "FieldCaption";
         this.xrLabel80.StylePriority.UseForeColor = false;
         this.xrLabel80.StylePriority.UseTextAlignment = false;
         xrSummary36.FormatString = "{0:#,##0.00}";
         xrSummary36.IgnoreNullValues = true;
         xrSummary36.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
         this.xrLabel80.Summary = xrSummary36;
         this.xrLabel80.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
         // 
         // xrLine3
         // 
         this.xrLine3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
         this.xrLine3.LocationFloat = new DevExpress.Utils.PointFloat(0F, 1.499992F);
         this.xrLine3.Name = "xrLine3";
         this.xrLine3.SizeF = new System.Drawing.SizeF(1101F, 2F);
         this.xrLine3.StylePriority.UseForeColor = false;
         // 
         // GroupFooter2
         // 
         this.GroupFooter2.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLine1});
         this.GroupFooter2.HeightF = 12.5F;
         this.GroupFooter2.Level = 2;
         this.GroupFooter2.Name = "GroupFooter2";
         // 
         // xrLine1
         // 
         this.xrLine1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
         this.xrLine1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
         this.xrLine1.Name = "xrLine1";
         this.xrLine1.SizeF = new System.Drawing.SizeF(1101F, 2F);
         this.xrLine1.StylePriority.UseForeColor = false;
         // 
         // OrdersPerWaiter
         // 
         this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.PosInfoId_GroupHeader,
            this.StaffCode_GroupHeader,
            this.AccountType_GroupHeader,
            this.groupHeaderBand6,
            this.pageFooterBand1,
            this.reportHeaderBand1,
            this.reportFooterBand1,
            this.GroupHeader1,
            this.GroupFooter1,
            this.PosInfoId_GroupFooter,
            this.GroupFooter2});
         this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.sqlDataSource1,
            this.sqlDataSource2});
         this.DataMember = "Query";
         this.DataSource = this.sqlDataSource1;
         this.FilterString = "[FODay] >= ?FromFODay And [FODay] <= ?UpToFODay And [PosInfoId] In (?PosInfoID, ?" +
    ") And [StaffCode] In (?StaffID, ?) And [AccountType] In (?AccountType)";
         this.FormattingRuleSheet.AddRange(new DevExpress.XtraReports.UI.FormattingRule[] {
            this.formattingRule1});
         this.Landscape = true;
         this.Margins = new System.Drawing.Printing.Margins(36, 32, 48, 25);
         this.PageHeight = 827;
         this.PageWidth = 1169;
         this.PaperKind = System.Drawing.Printing.PaperKind.A4;
         this.Parameters.AddRange(new DevExpress.XtraReports.Parameters.Parameter[] {
            this.FromFODay,
            this.UpToFODay,
            this.PosInfoID,
            this.StaffID,
            this.AccountType});
         this.StyleSheet.AddRange(new DevExpress.XtraReports.UI.XRControlStyle[] {
            this.Title,
            this.FieldCaption,
            this.PageInfo,
            this.DataField});
         this.Version = "15.2";
         this.ParametersRequestBeforeShow += new System.EventHandler<DevExpress.XtraReports.Parameters.ParametersRequestEventArgs>(this.OrdersPerWaiter_ParametersRequestBeforeShow);
         this.DataSourceDemanded += new System.EventHandler<System.EventArgs>(this.OrdersPerWaiter_DataSourceDemanded);
         this.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.OrdersPerWaiter_BeforePrint);
         ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

      }

   #endregion

   ////////////////////////////////////////////////////////////////////////////////////////////////
   /// <summary>
   /// 
   /// </summary>
   /// <param name="sender"></param>
   /// <param name="e"></param>
   private void OrdersPerWaiter_ParametersRequestBeforeShow( object sender, DevExpress.XtraReports.Parameters.ParametersRequestEventArgs e )
      {
      sqlDataSource1.Fill();

      foreach ( var paramItem in e.ParametersInformation )
         {

         if ( "DateTime" == paramItem.Parameter.Type.Name )
            {
            paramItem.Parameter.Value = DateTime.Now.Date;
            }
         else if (paramItem.Parameter.MultiValue)
            {

            switch ( paramItem.Parameter.Name )
               {
               case "Department":
                  // select all values for parameter Department
                  paramItem.Parameter.Value = CommonTools.SetAllSelectedForMultiValueParameter<Int64>( sqlDataSource1, "DepartmentsLookUps", "Id" );
                  break;

               case "PosInfoID":
                  // select all values for parameter PosInfoID
                  paramItem.Parameter.Value = CommonTools.SetAllSelectedForMultiValueParameter<Int64>( sqlDataSource1, "PosInfoLookUps", "Id" );
                  break;

               case "StaffID":
                  // select all values for parameter StaffID
                  paramItem.Parameter.Value = CommonTools.SetAllSelectedForMultiValueParameter( sqlDataSource1, "StaffLookUps", "StaffCode" );
                  break;

               case "AccountType":
                  // select all values for parameter AccountType
                  paramItem.Parameter.Value = CommonTools.SetAllSelectedForMultiValueParameter<Int16>( sqlDataSource1, "AccountsLookups", "Type" );
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
   private void OrdersPerWaiter_BeforePrint( object sender, System.Drawing.Printing.PrintEventArgs e )
      {
      var param = ( sender as XtraReport ).Parameters;
      param[0].Value = ( param[0].Value as DateTime? ).Value.Date;
      param[1].Value = ( param[1].Value as DateTime? ).Value.Date;
      }

   ////////////////////////////////////////////////////////////////////////////////////////////////
   /// <summary>
   /// 
   /// </summary>
   /// <param name="sender"></param>
   /// <param name="e"></param>
   private void OrdersPerWaiter_DataSourceDemanded( object sender, EventArgs e )
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
   }

