using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

/// <summary>
/// Summary description for HourlyReceiptSales1
/// </summary>
public class HourlyReceiptSales1 : DevExpress.XtraReports.UI.XtraReport
   {
   private DevExpress.XtraReports.UI.DetailBand Detail;
   private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
   private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
   private XRLabel xrLabel1;
   private XRLabel xrLabel2;
   private XRLabel xrLabel3;
   private XRLabel xrLabel4;
   private XRLabel xrLabel5;
   private XRLabel xrLabel6;
   private XRLabel xrLabel7;
   private XRLabel xrLabel8;
   private XRLine xrLine1;
   private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
   private PageFooterBand pageFooterBand1;
   private ReportHeaderBand reportHeaderBand1;
   private XRLabel xrLabel9;
   private XRControlStyle Title;
   private XRControlStyle FieldCaption;
   private XRControlStyle PageInfo;
   private XRControlStyle DataField;
   private DevExpress.XtraReports.Parameters.Parameter FromFODay;
   private DevExpress.XtraReports.Parameters.Parameter ToFODay;
   private XRPageInfo xrPageInfo2;
   private XRPageInfo xrPageInfo1;
   private DevExpress.XtraReports.Parameters.Parameter PosInfoID;
   private GroupHeaderBand GroupHeader1;
   private XRLabel xrLabel10;
   private GroupFooterBand GroupFooter1;
   private XRLabel xrLabel13;
   private XRLabel xrLabel12;
   private XRLabel xrLabel11;

   /// <summary>
   /// Required designer variable.
   /// </summary>
   private System.ComponentModel.IContainer components = null;

   public HourlyReceiptSales1()
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
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HourlyReceiptSales1));
         DevExpress.DataAccess.Sql.CustomSqlQuery customSqlQuery2 = new DevExpress.DataAccess.Sql.CustomSqlQuery();
         DevExpress.DataAccess.Sql.CustomSqlQuery customSqlQuery3 = new DevExpress.DataAccess.Sql.CustomSqlQuery();
         DevExpress.XtraReports.Parameters.DynamicListLookUpSettings dynamicListLookUpSettings1 = new DevExpress.XtraReports.Parameters.DynamicListLookUpSettings();
         this.Detail = new DevExpress.XtraReports.UI.DetailBand();
         this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
         this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
         this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
         this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel4 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel5 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel6 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel7 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel8 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLine1 = new DevExpress.XtraReports.UI.XRLine();
         this.pageFooterBand1 = new DevExpress.XtraReports.UI.PageFooterBand();
         this.reportHeaderBand1 = new DevExpress.XtraReports.UI.ReportHeaderBand();
         this.xrLabel9 = new DevExpress.XtraReports.UI.XRLabel();
         this.Title = new DevExpress.XtraReports.UI.XRControlStyle();
         this.FieldCaption = new DevExpress.XtraReports.UI.XRControlStyle();
         this.PageInfo = new DevExpress.XtraReports.UI.XRControlStyle();
         this.DataField = new DevExpress.XtraReports.UI.XRControlStyle();
         this.FromFODay = new DevExpress.XtraReports.Parameters.Parameter();
         this.ToFODay = new DevExpress.XtraReports.Parameters.Parameter();
         this.xrPageInfo2 = new DevExpress.XtraReports.UI.XRPageInfo();
         this.xrPageInfo1 = new DevExpress.XtraReports.UI.XRPageInfo();
         this.PosInfoID = new DevExpress.XtraReports.Parameters.Parameter();
         this.GroupHeader1 = new DevExpress.XtraReports.UI.GroupHeaderBand();
         this.xrLabel10 = new DevExpress.XtraReports.UI.XRLabel();
         this.GroupFooter1 = new DevExpress.XtraReports.UI.GroupFooterBand();
         this.xrLabel11 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel12 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel13 = new DevExpress.XtraReports.UI.XRLabel();
         ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
         // 
         // Detail
         // 
         this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel1,
            this.xrLabel2,
            this.xrLabel3,
            this.xrLabel4,
            this.xrLabel5,
            this.xrLabel6,
            this.xrLabel7,
            this.xrLabel8,
            this.xrLine1});
         this.Detail.HeightF = 41F;
         this.Detail.Name = "Detail";
         this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
         this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
         // 
         // TopMargin
         // 
         this.TopMargin.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrPageInfo2});
         this.TopMargin.HeightF = 46F;
         this.TopMargin.Name = "TopMargin";
         this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
         this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
         // 
         // BottomMargin
         // 
         this.BottomMargin.HeightF = 33.58335F;
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
         queryParameter1.Value = new DevExpress.DataAccess.Expression("[Parameters.FromFODay]", typeof(System.DateTime));
         queryParameter2.Name = "ToDate";
         queryParameter2.Type = typeof(DevExpress.DataAccess.Expression);
         queryParameter2.Value = new DevExpress.DataAccess.Expression("[Parameters.ToFODay]", typeof(System.DateTime));
         customSqlQuery1.Parameters.Add(queryParameter1);
         customSqlQuery1.Parameters.Add(queryParameter2);
         customSqlQuery1.Sql = resources.GetString("customSqlQuery1.Sql");
         customSqlQuery2.Name = "Query_1";
         customSqlQuery2.Sql = "select * from invoices where id = -1";
         customSqlQuery3.Name = "PosInfoLookUps";
         customSqlQuery3.Sql = "Select Id, Code, Description from PosInfo";
         this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            customSqlQuery1,
            customSqlQuery2,
            customSqlQuery3});
         this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
         // 
         // xrLabel1
         // 
         this.xrLabel1.BackColor = System.Drawing.Color.DarkGray;
         this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(359F, 5F);
         this.xrLabel1.Name = "xrLabel1";
         this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
         this.xrLabel1.SizeF = new System.Drawing.SizeF(131F, 18F);
         this.xrLabel1.StyleName = "FieldCaption";
         this.xrLabel1.StylePriority.UseBackColor = false;
         this.xrLabel1.StylePriority.UseTextAlignment = false;
         this.xrLabel1.Text = "Τύπος Παραστατικού";
         this.xrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
         // 
         // xrLabel2
         // 
         this.xrLabel2.BackColor = System.Drawing.Color.DarkGray;
         this.xrLabel2.LocationFloat = new DevExpress.Utils.PointFloat(6.000002F, 5F);
         this.xrLabel2.Name = "xrLabel2";
         this.xrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
         this.xrLabel2.SizeF = new System.Drawing.SizeF(353F, 18F);
         this.xrLabel2.StyleName = "FieldCaption";
         this.xrLabel2.StylePriority.UseBackColor = false;
         this.xrLabel2.StylePriority.UseTextAlignment = false;
         this.xrLabel2.Text = "By Hour";
         this.xrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
         // 
         // xrLabel3
         // 
         this.xrLabel3.BackColor = System.Drawing.Color.DarkGray;
         this.xrLabel3.LocationFloat = new DevExpress.Utils.PointFloat(490F, 5F);
         this.xrLabel3.Name = "xrLabel3";
         this.xrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
         this.xrLabel3.SizeF = new System.Drawing.SizeF(135F, 18F);
         this.xrLabel3.StyleName = "FieldCaption";
         this.xrLabel3.StylePriority.UseBackColor = false;
         this.xrLabel3.StylePriority.UseTextAlignment = false;
         this.xrLabel3.Text = "#Εγγραφών";
         this.xrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
         // 
         // xrLabel4
         // 
         this.xrLabel4.BackColor = System.Drawing.Color.DarkGray;
         this.xrLabel4.LocationFloat = new DevExpress.Utils.PointFloat(625F, 5F);
         this.xrLabel4.Name = "xrLabel4";
         this.xrLabel4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
         this.xrLabel4.SizeF = new System.Drawing.SizeF(95F, 18F);
         this.xrLabel4.StyleName = "FieldCaption";
         this.xrLabel4.StylePriority.UseBackColor = false;
         this.xrLabel4.StylePriority.UseTextAlignment = false;
         this.xrLabel4.Text = "Σύνολο";
         this.xrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
         // 
         // xrLabel5
         // 
         this.xrLabel5.BackColor = System.Drawing.Color.LightGray;
         this.xrLabel5.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.Abbreviation")});
         this.xrLabel5.LocationFloat = new DevExpress.Utils.PointFloat(359F, 23F);
         this.xrLabel5.Name = "xrLabel5";
         this.xrLabel5.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
         this.xrLabel5.SizeF = new System.Drawing.SizeF(131F, 18F);
         this.xrLabel5.StyleName = "DataField";
         this.xrLabel5.StylePriority.UseBackColor = false;
         this.xrLabel5.StylePriority.UseTextAlignment = false;
         this.xrLabel5.Text = "xrLabel5";
         this.xrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
         // 
         // xrLabel6
         // 
         this.xrLabel6.BackColor = System.Drawing.Color.LightGray;
         this.xrLabel6.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.ByHour")});
         this.xrLabel6.LocationFloat = new DevExpress.Utils.PointFloat(6.000002F, 23F);
         this.xrLabel6.Name = "xrLabel6";
         this.xrLabel6.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
         this.xrLabel6.SizeF = new System.Drawing.SizeF(353F, 18F);
         this.xrLabel6.StyleName = "DataField";
         this.xrLabel6.StylePriority.UseBackColor = false;
         this.xrLabel6.StylePriority.UseTextAlignment = false;
         this.xrLabel6.Text = "xrLabel6";
         this.xrLabel6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
         // 
         // xrLabel7
         // 
         this.xrLabel7.BackColor = System.Drawing.Color.LightGray;
         this.xrLabel7.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.InvoiceCount")});
         this.xrLabel7.LocationFloat = new DevExpress.Utils.PointFloat(490F, 23F);
         this.xrLabel7.Name = "xrLabel7";
         this.xrLabel7.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
         this.xrLabel7.SizeF = new System.Drawing.SizeF(135F, 18F);
         this.xrLabel7.StyleName = "DataField";
         this.xrLabel7.StylePriority.UseBackColor = false;
         this.xrLabel7.StylePriority.UseTextAlignment = false;
         this.xrLabel7.Text = "xrLabel7";
         this.xrLabel7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
         // 
         // xrLabel8
         // 
         this.xrLabel8.BackColor = System.Drawing.Color.LightGray;
         this.xrLabel8.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.Total", "{0:C2}")});
         this.xrLabel8.LocationFloat = new DevExpress.Utils.PointFloat(625F, 23F);
         this.xrLabel8.Name = "xrLabel8";
         this.xrLabel8.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
         this.xrLabel8.SizeF = new System.Drawing.SizeF(95F, 18F);
         this.xrLabel8.StyleName = "DataField";
         this.xrLabel8.StylePriority.UseBackColor = false;
         this.xrLabel8.StylePriority.UseTextAlignment = false;
         this.xrLabel8.Text = "xrLabel8";
         this.xrLabel8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
         // 
         // xrLine1
         // 
         this.xrLine1.LocationFloat = new DevExpress.Utils.PointFloat(6F, 3F);
         this.xrLine1.Name = "xrLine1";
         this.xrLine1.SizeF = new System.Drawing.SizeF(714F, 2F);
         // 
         // pageFooterBand1
         // 
         this.pageFooterBand1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrPageInfo1});
         this.pageFooterBand1.HeightF = 18.76271F;
         this.pageFooterBand1.Name = "pageFooterBand1";
         // 
         // reportHeaderBand1
         // 
         this.reportHeaderBand1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel9});
         this.reportHeaderBand1.HeightF = 33.20834F;
         this.reportHeaderBand1.Name = "reportHeaderBand1";
         // 
         // xrLabel9
         // 
         this.xrLabel9.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
         this.xrLabel9.LocationFloat = new DevExpress.Utils.PointFloat(6.000002F, 6.00001F);
         this.xrLabel9.Name = "xrLabel9";
         this.xrLabel9.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel9.SizeF = new System.Drawing.SizeF(714F, 23F);
         this.xrLabel9.StyleName = "Title";
         this.xrLabel9.StylePriority.UseFont = false;
         this.xrLabel9.StylePriority.UseTextAlignment = false;
         this.xrLabel9.Text = "Ωριαίες Πωλήσεις Αποδείξεων";
         this.xrLabel9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
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
         // FromFODay
         // 
         this.FromFODay.Description = "FromDate";
         this.FromFODay.Name = "FromFODay";
         this.FromFODay.Type = typeof(System.DateTime);
         this.FromFODay.ValueInfo = "2016-06-01";
         // 
         // ToFODay
         // 
         this.ToFODay.Description = "UpToDate";
         this.ToFODay.Name = "ToFODay";
         this.ToFODay.Type = typeof(System.DateTime);
         this.ToFODay.ValueInfo = "2016-06-01";
         // 
         // xrPageInfo2
         // 
         this.xrPageInfo2.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
         this.xrPageInfo2.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
         this.xrPageInfo2.Format = "Ημερομηνία Εκτύπωσης : {0:dddd, d MMMM yyyy h:mm:ss tt}";
         this.xrPageInfo2.LocationFloat = new DevExpress.Utils.PointFloat(6F, 30.23729F);
         this.xrPageInfo2.Name = "xrPageInfo2";
         this.xrPageInfo2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrPageInfo2.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime;
         this.xrPageInfo2.SizeF = new System.Drawing.SizeF(714F, 15.76271F);
         this.xrPageInfo2.StylePriority.UseBorders = false;
         this.xrPageInfo2.StylePriority.UseFont = false;
         // 
         // xrPageInfo1
         // 
         this.xrPageInfo1.Borders = DevExpress.XtraPrinting.BorderSide.Top;
         this.xrPageInfo1.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
         this.xrPageInfo1.Format = "Σελίδα {0} από {1}";
         this.xrPageInfo1.LocationFloat = new DevExpress.Utils.PointFloat(6F, 0F);
         this.xrPageInfo1.Name = "xrPageInfo1";
         this.xrPageInfo1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrPageInfo1.SizeF = new System.Drawing.SizeF(714F, 18.76271F);
         this.xrPageInfo1.StylePriority.UseBorders = false;
         this.xrPageInfo1.StylePriority.UseFont = false;
         this.xrPageInfo1.StylePriority.UseTextAlignment = false;
         this.xrPageInfo1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
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
         this.PosInfoID.ValueInfo = "0";
         // 
         // GroupHeader1
         // 
         this.GroupHeader1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel10});
         this.GroupHeader1.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("ByHour", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
         this.GroupHeader1.HeightF = 15F;
         this.GroupHeader1.Name = "GroupHeader1";
         // 
         // xrLabel10
         // 
         this.xrLabel10.BackColor = System.Drawing.Color.DimGray;
         this.xrLabel10.Borders = DevExpress.XtraPrinting.BorderSide.None;
         this.xrLabel10.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.PosInfoDescription", "POS Description: {0}")});
         this.xrLabel10.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
         this.xrLabel10.LocationFloat = new DevExpress.Utils.PointFloat(6F, 0F);
         this.xrLabel10.Name = "xrLabel10";
         this.xrLabel10.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel10.SizeF = new System.Drawing.SizeF(714F, 15F);
         this.xrLabel10.StyleName = "DataField";
         this.xrLabel10.StylePriority.UseBackColor = false;
         this.xrLabel10.StylePriority.UseBorders = false;
         this.xrLabel10.StylePriority.UseFont = false;
         this.xrLabel10.StylePriority.UseTextAlignment = false;
         this.xrLabel10.Text = "xrLabel4";
         this.xrLabel10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
         // 
         // GroupFooter1
         // 
         this.GroupFooter1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel13,
            this.xrLabel12,
            this.xrLabel11});
         this.GroupFooter1.HeightF = 48.95833F;
         this.GroupFooter1.Name = "GroupFooter1";
         // 
         // xrLabel11
         // 
         this.xrLabel11.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.Abbreviation")});
         this.xrLabel11.LocationFloat = new DevExpress.Utils.PointFloat(152.7083F, 10.00001F);
         this.xrLabel11.Name = "xrLabel11";
         this.xrLabel11.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
         this.xrLabel11.SizeF = new System.Drawing.SizeF(100F, 23F);
         this.xrLabel11.Text = "xrLabel11";
         // 
         // xrLabel12
         // 
         this.xrLabel12.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.Total")});
         this.xrLabel12.LocationFloat = new DevExpress.Utils.PointFloat(616.0001F, 10.00001F);
         this.xrLabel12.Name = "xrLabel12";
         this.xrLabel12.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
         this.xrLabel12.SizeF = new System.Drawing.SizeF(100F, 23F);
         this.xrLabel12.Text = "xrLabel12";
         // 
         // xrLabel13
         // 
         this.xrLabel13.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.InvoiceCount")});
         this.xrLabel13.LocationFloat = new DevExpress.Utils.PointFloat(10.00001F, 10.00001F);
         this.xrLabel13.Name = "xrLabel13";
         this.xrLabel13.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
         this.xrLabel13.SizeF = new System.Drawing.SizeF(100F, 23F);
         this.xrLabel13.Text = "xrLabel13";
         // 
         // HourlyReceiptSales1
         // 
         this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.pageFooterBand1,
            this.reportHeaderBand1,
            this.GroupHeader1,
            this.GroupFooter1});
         this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.sqlDataSource1});
         this.DataMember = "Query";
         this.DataSource = this.sqlDataSource1;
         this.FilterString = "[PosInfoId] In (?PosInfoID)";
         this.Font = new System.Drawing.Font("Tahoma", 8F);
         this.Margins = new System.Drawing.Printing.Margins(51, 50, 46, 34);
         this.PageHeight = 1169;
         this.PageWidth = 827;
         this.PaperKind = System.Drawing.Printing.PaperKind.A4;
         this.Parameters.AddRange(new DevExpress.XtraReports.Parameters.Parameter[] {
            this.FromFODay,
            this.ToFODay,
            this.PosInfoID});
         this.StyleSheet.AddRange(new DevExpress.XtraReports.UI.XRControlStyle[] {
            this.Title,
            this.FieldCaption,
            this.PageInfo,
            this.DataField});
         this.Version = "15.2";
         ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

      }

   #endregion
   }
