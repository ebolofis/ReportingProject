﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace WEBPOS_Reports.PosModel_Info
{
    [DisplayName("Ver : 2.0.0.1")]
    public class ScriptsPerVersion
    {
        public List<string> Ver_2_0_0_1 { get; }

        public ScriptsPerVersion()
        {
            Ver_2_0_0_1 = new List<string>();
            Ver_2_0_0_1.Add("DECLARE @SQL VARCHAR(MAX) \n"
                           + "IF EXISTS(select 1 FROM sys.views where name = 'pos_sales_analysis') \n"
                           + "	SET @SQL = 'ALTER ' \n"
                           + "ELSE \n"
                           + "	SET @SQL = 'CREATE ' \n"
                           + "SET @SQL = @SQL + ' VIEW [dbo].[pos_sales_analysis] AS \n"
                           + "	SELECT DepartmentId = pi.DepartmentId, DepartmentDescription = d.[Description] \n"
                           + "		 , PosInfoId = i.PosInfoId, PosInfoDescription = pi.[Description] \n"
                           + "		 , CategoryId = pc.categoryid, CategoryDescription = c.[Description] \n"
                           + "		 , ProductCategoryCode = pc.Code, ProductCategoryDescription = pc.[Description] \n"
                           + "		 , DetailedInvoiceId = odi.Id \n"
                           + "		 , odi.ProductId, ProductCode = p.Code, ProductDescription = p.[Description] \n"
                           + "		 , odi.Qty \n"
                           + "		 , odi.Price \n"
                           + "		 , odi.Discount \n"
                           + "		 , odi.Total \n"
                           + "		 , odi.Net \n"
                           + "		 , odi.VatAmount \n"
                           + "		 , VatPercentage = v.Percentage \n"
                           + "		 , PricelistId = pl.Id, PricelistCode = pl.Code, PricelistDescription = pl.[Description] \n"
                           + "		 , odi.VatId \n"
                           + "		 , InvoiceTotal = i.Total \n"
                           + "		 , InvoiceId = i.Id, InvoiceType = odi.InvoiceType \n"
                           + "		 , odi.Abbreviation \n"
                           + "		 , ReceiptNo = odi.[Counter] \n"
                           + "		 , i.Cover \n"
                           + "		 , i.Rooms \n"
                           + "		 , InvoiceDate = i.[Day] \n"
                           + "		 , odi.SalesTypeId \n"
                           + "		 , SalesTypeDescription = st.[Description] \n"
                           + "		 , StaffCode = s.Code \n"
                           + "		 , StafName = IsNull( LastName, '''' ) + '' '' + IsNull( FirstName, '''' ) \n"
                           + "		 , FODay = ISNULL( eod.FODay, CAST( GETDATE() AS DATE ) ) \n"
                           + "		 , EndOfDayId = ISNULL(i.EndOfDayId, 0) \n"
                           + "		 , odi.IsExtra \n"
                           + "		 , t.AccountId, t.AccountType, t.AccountDescription \n"
                           + "	FROM dbo.OrderDetailInvoices_View AS odi \n"
                           + "		 INNER JOIN dbo.Invoices_View AS i ON odi.InvoicesId = i.Id \n"
                           + "		 LEFT OUTER JOIN dbo.EndOfDay_View AS eod ON i.EndOfDayId = eod.Id \n"
                           + "		 LEFT OUTER JOIN dbo.Pricelist AS pl ON odi.PricelistId = pl.Id \n"
                           + "		 LEFT OUTER JOIN dbo.Vat AS v ON odi.VatId = v.Id \n"
                           + "		 LEFT OUTER JOIN dbo.SalesType AS st ON st.Id = odi.SalesTypeId \n"
                           + "		 LEFT OUTER JOIN dbo.Staff AS s ON i.StaffId = s.Id \n"
                           + "		 LEFT OUTER JOIN dbo.PosInfo AS pi ON i.PosInfoId = pi.Id \n"
                           + "		 LEFT OUTER JOIN dbo.Department AS d ON pi.DepartmentId = d.Id \n"
                           + "		 LEFT OUTER JOIN dbo.Ingredients AS ing ON ing.Id = odi.ProductId AND odi.IsExtra = 1 \n"
                           + "		 LEFT OUTER JOIN dbo.Product AS p ON p.Id = odi.ProductId \n"
                           + "		 LEFT OUTER JOIN dbo.ProductCategories AS pc ON pc.Id = odi.ProductCategoryId \n"
                           + "		 LEFT OUTER JOIN dbo.Categories as c on c.id = pc.categoryid    \n"
                           + "		 INNER JOIN(  \n"
                           + "		 	SELECT t1.InvoicesId , t1.AccountId , a1.Type AS AccountType ,  \n"
                           + "		 		a1.[Description] AS AccountDescription , SUM( t1.Amount ) AS TransAmount \n"
                           + "		    FROM dbo.Transactions AS t1 \n"
                           + "			LEFT OUTER JOIN dbo.Accounts AS a1 ON t1.AccountId = a1.Id \n"
                           + "		    WHERE ( ISNULL( t1.IsDeleted, 0 ) <> 1 ) \n"
                           + "		    GROUP BY t1.InvoicesId, t1.AccountId, a1.Type, a1.[Description]  \n"
                           + "		 ) AS t ON t.InvoicesId = i.Id \n"
                           + "	WHERE ( ISNULL( i.IsDeleted, 0 ) = 0 ) \n"
                           + "		  AND ( ISNULL( i.IsVoided, 0 ) = 0 ) \n"
                           + "		  AND ( ISNULL( odi.IsDeleted, 0 ) = 0 ) \n"
                           + "		  AND ( odi.InvoiceType NOT IN ( 2, 3, 8, 10, 11, 12 ) ) ' \n" 
                           + "EXEC(@SQL)");
            Ver_2_0_0_1.Add("DECLARE @SQL VARCHAR(MAX) \n"
                           + "IF EXISTS(select 1 FROM sys.views where name = 'pos_sales_analysis2') \n"
                           + "	SET @SQL = 'ALTER ' \n"
                           + "ELSE \n"
                           + "	SET @SQL = 'CREATE ' \n"
                           + "SET @SQL = @SQL + ' VIEW [dbo].[pos_sales_analysis2] AS \n"
                           + "            SELECT DepartmentId = pi.DepartmentId, DepartmentDescription = d.[Description] \n"
                           + "                 , PosInfoId = i.PosInfoId, PosInfoDescription = pi.[Description] \n"
                           + "                 , CategoryId = pc.categoryid, CategoryDescription = c.[Description] \n"
                           + "                 , ProductCategoryCode = pc.Code, ProductCategoryDescription = pc.[Description] \n"
                           + "                 , DetailedInvoiceId = odi.Id \n"
                           + "                 , ProductId = odi.ProductId \n"
                           + "                 , ProductCode = CASE odi.IsExtra \n"
                           + "                                 WHEN 1 THEN ing.Code \n"
                           + "                                 ELSE p.Code \n"
                           + "                                 END \n"
                           + "                 , ProductDescription = CASE odi.IsExtra \n"
                           + "                                        WHEN 1 THEN ing.[Description] \n"
                           + "                                        ELSE p.[Description] \n"
                           + "                                        END \n"
                           + "                 , Qty = CASE odi.IsExtra \n"
                           + "                         WHEN 1 THEN 0 \n"
                           + "                         ELSE odi.Qty \n"
                           + "                         END    \n"
                           + "                 , Price = odi.Price, Discount = odi.Discount, Total = odi.Total, Net = odi.Net, InvoiceTotal = i.Total \n"
                           + "                 , VatAmount = odi.VatAmount, VatPercentage = v.Percentage \n"
                           + "                 , PricelistId = pl.Id, PricelistCode = pl.Code, PricelistDescription = pl.[Description] \n"
                           + "                 , VatId = odi.VatId      \n"
                           + "                 , InvoiceId = i.Id, InvoiceType = odi.InvoiceType, InvoiceDate = i.[Day] \n"
                           + "                 , Abbreviation = odi.Abbreviation \n"
                           + "                 , ReceiptNo = odi.[Counter] \n"
                           + "                 , Cover = i.Cover \n"
                           + "                 , Rooms = i.Rooms \n"
                           + "                 , SalesTypeId = odi.SalesTypeId, SalesTypeDescription = st.[Description] \n"
                           + "                 , StaffCode = s.Code, StafName = IsNull( LastName, '''' ) + '' '' + IsNull( FirstName, '''' ) \n"
                           + "                 , FODay = ISNULL( eod.FODay, CAST( GETDATE() AS DATE ) ) \n"
                           + "                 , EndOfDayId = ISNULL(i.EndOfDayId, 0) \n"
                           + "                 , odi.IsExtra \n"
                           + "            FROM dbo.OrderDetailInvoices_View AS odi \n"
                           + "                 INNER JOIN dbo.Invoices_View AS i ON odi.InvoicesId = i.Id \n"
                           + "                 LEFT OUTER JOIN dbo.EndOfDay_View AS eod ON i.EndOfDayId = eod.Id \n"
                           + "                 LEFT OUTER JOIN dbo.Pricelist AS pl ON odi.PricelistId = pl.Id \n"
                           + "                 LEFT OUTER JOIN dbo.Vat AS v ON odi.VatId = v.Id \n"
                           + "                 LEFT OUTER JOIN dbo.SalesType AS st ON st.Id = odi.SalesTypeId \n"
                           + "                 LEFT OUTER JOIN dbo.Staff AS s ON i.StaffId = s.Id \n"
                           + "                 LEFT OUTER JOIN dbo.PosInfo AS pi ON i.PosInfoId = pi.Id \n"
                           + "                 LEFT OUTER JOIN dbo.Department AS d ON pi.DepartmentId = d.Id \n"
                           + "                 LEFT OUTER JOIN dbo.Ingredients AS ing ON ing.Id = odi.ProductId AND odi.IsExtra = 1 \n"
                           + "                 LEFT OUTER JOIN dbo.Product AS p ON p.Id = odi.ProductId \n"
                           + "                 LEFT OUTER JOIN dbo.ProductCategories AS pc ON pc.Id = odi.ProductCategoryId \n"
                           + "                 LEFT OUTER JOIN dbo.Categories as c on c.id = pc.categoryid    \n"
                           + "            WHERE ( ISNULL( i.IsDeleted, 0 ) = 0 ) \n"
                           + "                  AND ( ISNULL( i.IsVoided, 0 ) = 0 ) \n"
                           + "                  AND ( ISNULL( odi.IsDeleted, 0 ) = 0 ) \n"
                           + "                  AND ( odi.InvoiceType NOT IN ( 2, 3, 8, 10, 11, 12 ) )' \n"
                           + "EXEC(@SQL)");
            Ver_2_0_0_1.Add("DECLARE @SQL VARCHAR(MAX) \n"
                            + "IF EXISTS(select 1 FROM sys.views where name = 'pos_sales_analysis3') \n"
                            + "	SET @SQL = 'ALTER ' \n"
                            + "ELSE \n"
                            + "	SET @SQL = 'CREATE ' \n"
                            + "SET @SQL = @SQL + ' VIEW [dbo].[pos_sales_analysis3] AS \n"
                            + "            SELECT DepartmentId = pi.DepartmentId, DepartmentDescription = d.[Description] \n"
                            + "                 , PosInfoId = i.PosInfoId, PosInfoDescription = pi.[Description] \n"
                            + "                 , CategoryId = pc.categoryid, CategoryDescription = c.[Description] \n"
                            + "                 , ProductCategoryCode = pc.Code, ProductCategoryDescription = pc.[Description] \n"
                            + "                 , DetailedInvoiceId = odi.Id \n"
                            + "                 , odi.ProductId, ProductCode = p.Code, ProductDescription = p.[Description] \n"
                            + "                 , odi.Qty \n"
                            + "                 , odi.Price \n"
                            + "                 , odi.Discount \n"
                            + "                 , odi.Total \n"
                            + "                 , odi.Net \n"
                            + "                 , odi.VatAmount \n"
                            + "                 , VatPercentage = v.Percentage \n"
                            + "                 , PricelistId = pl.Id, PricelistCode = pl.Code, PricelistDescription = pl.[Description] \n"
                            + "                 , odi.VatId \n"
                            + "                 , InvoiceTotal = i.Total \n"
                            + "                 , InvoiceId = i.Id, InvoiceType = odi.InvoiceType \n"
                            + "                 , odi.Abbreviation \n"
                            + "                 , ReceiptNo = odi.[Counter] \n"
                            + "                 , i.Cover \n"
                            + "                 , i.Rooms \n"
                            + "                 , InvoiceDate = i.[Day] \n"
                            + "                 , odi.SalesTypeId \n"
                            + "                 , SalesTypeDescription = st.[Description] \n"
                            + "                 , StaffCode = s.Code \n"
                            + "                 , StafName = IsNull( LastName, '''' ) + '' '' + IsNull( FirstName, '''' ) \n"
                            + "                 , FODay = ISNULL( eod.FODay, CAST( GETDATE() AS DATE ) ) \n"
                            + "                 , EndOfDayId = ISNULL(i.EndOfDayId, 0) \n"
                            + "                 , odi.IsExtra \n"
                            + "                 , t.AccountId, t.AccountType, t.AccountDescription \n"
                            + "                 , odi.OrderDetailId \n"
                            + "            FROM dbo.OrderDetailInvoices_View AS odi \n"
                            + "             INNER JOIN dbo.Invoices_View AS i ON odi.InvoicesId = i.Id \n"
                            + "             LEFT OUTER JOIN dbo.EndOfDay_View AS eod ON i.EndOfDayId = eod.Id \n"
                            + "             LEFT OUTER JOIN dbo.Pricelist AS pl ON odi.PricelistId = pl.Id \n"
                            + "             LEFT OUTER JOIN dbo.Vat AS v ON odi.VatId = v.Id \n"
                            + "             LEFT OUTER JOIN dbo.SalesType AS st ON st.Id = odi.SalesTypeId \n"
                            + "             LEFT OUTER JOIN dbo.Staff AS s ON i.StaffId = s.Id \n"
                            + "             LEFT OUTER JOIN dbo.PosInfo AS pi ON i.PosInfoId = pi.Id \n"
                            + "             LEFT OUTER JOIN dbo.Department AS d ON pi.DepartmentId = d.Id \n"
                            + "             LEFT OUTER JOIN dbo.Ingredients AS ing ON ing.Id = odi.ProductId AND odi.IsExtra = 1 \n"
                            + "             LEFT OUTER JOIN dbo.Product AS p ON p.Id = odi.ProductId \n"
                            + "             LEFT OUTER JOIN dbo.ProductCategories AS pc ON pc.Id = odi.ProductCategoryId \n"
                            + "             LEFT OUTER JOIN dbo.Categories as c on c.id = pc.categoryid    \n"
                            + "             INNER JOIN( SELECT t1.InvoicesId , t1.AccountId , a1.Type AS AccountType \n"
                            + "							, a1.[Description] AS AccountDescription, SUM( t1.Amount ) AS TransAmount \n"
                            + "                          FROM dbo.Transactions_View AS t1 \n"
                            + "                          LEFT OUTER JOIN dbo.Accounts AS a1 ON t1.AccountId = a1.Id \n"
                            + "                          WHERE ( ISNULL( t1.IsDeleted, 0 ) <> 1 ) \n"
                            + "                          GROUP BY t1.InvoicesId , t1.AccountId , a1.Type , a1.[Description] ) AS t ON t.InvoicesId = i.Id \n"
                            + "            WHERE ( ISNULL( i.IsDeleted, 0 ) = 0 ) \n"
                            + "                  AND ( ISNULL( i.IsVoided, 0 ) = 0 ) \n"
                            + "                  AND ( ISNULL( odi.IsDeleted, 0 ) = 0 ) \n"
                            + "                  AND ( odi.InvoiceType NOT IN ( 2, 3, 8, 10, 11, 12 ) )' \n"
                            + "EXEC(@SQL)");

        }
    }
}
