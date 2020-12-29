
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using DevExpress.DataAccess.Native.Sql;
using DevExpress.DataAccess.Sql;
using System.IO;
using System.Collections.Specialized;

namespace WEBPOS_Reports.Helpers
   {

   public static class CommonTools
      {

      ////////////////////////////////////////////////////////////////////////////////////////////////
      /// <summary>
      /// Select all values for the given report parameter.
      /// </summary>
      /// <typeparam name="T">The type of the parameter.</typeparam>
      /// <param name="sqlDataSource"></param>
      /// <param name="strTableName">The name of the table source for the parameter.</param>
      /// <param name="strKeyFieldName">The name of the key field (return value/s) in the table.</param>
      /// <returns></returns>
      public static List<T> SetAllSelectedForMultiValueParameter<T>( SqlDataSource sqlDataSource
                                                                   , string strTableName
                                                                   , string strKeyFieldName )
         {
         List<T> resultList = new List<T>();
         ResultSet resultSet = ( sqlDataSource as IListSource ).GetList() as ResultSet;

         foreach ( ResultTable resultTable in resultSet.Tables )
            {

            if ( strTableName == resultTable.TableName )
               {
               ResultColumn resultColumn = resultTable.Columns.Find( ( col ) => col.Name == strKeyFieldName );

               for ( int i = 0; i < resultTable.Count; i++ )
                  {
                  ResultRow resultRow = resultTable[i];
                  T keyFieldValue = ( T ) ( resultColumn.GetValue( resultRow ) );
                  resultList.Add( keyFieldValue );
                  }

               break;
               }

            }

         return resultList;
         }

      ////////////////////////////////////////////////////////////////////////////////////////////////
      /// <summary>
      /// Select all values for the given report parameter.
      /// </summary>
      /// <param name="sqlDataSource"></param>
      /// <param name="strTableName"></param>
      /// <param name="strKeyFieldName"></param>
      /// <returns></returns>
      public static List<string> SetAllSelectedForMultiValueParameter( SqlDataSource sqlDataSource
                                                                     , string strTableName
                                                                     , string strKeyFieldName )
         {
         List<string> resultList = new List<string>();
         ResultSet resultSet = ( sqlDataSource as IListSource ).GetList() as ResultSet;

         foreach ( ResultTable resultTable in resultSet.Tables )
            {

            if ( strTableName == resultTable.TableName )
               {
               ResultColumn resultColumn = resultTable.Columns.Find( ( col ) => col.Name == strKeyFieldName );

               for ( int i = 0; i < resultTable.Count; i++ )
                  {
                  ResultRow resultRow = resultTable[i];
                  string keyFieldValue = resultColumn.GetValue( resultRow ).ToString();
                  resultList.Add( keyFieldValue );
                  }

               break;
               }

            }

         return resultList;
         }

        public static SqlDataSource CreateSqlDataSource()
        {
            SqlDataSource ds = null;

            try
            { 
                ds = new SqlDataSource("ReportConnection");
                ds.Name = "DataSourceName";
            
                StringCollection tables = Properties.Settings.Default.Tables;
            
                foreach (string item in tables)
                {            
                    ds.Queries.Add(new CustomSqlQuery(item, "SELECT * FROM " + item));
                }
            
                ds.RebuildResultSchema();
            }
            catch(Exception ex)
            {
                CommonTools.Log("CreateSqlDataSource " + ex.Message);
            }

            return ds;
        }

        public static void Log(string sErrMsg)
        {
            string sPathName = System.Web.HttpContext.Current.Server.MapPath("~");
            string sLogFormat = DateTime.Now.ToShortDateString().ToString() + " " + DateTime.Now.ToLongTimeString().ToString() + " ==> ";
            string sYear = DateTime.Now.Year.ToString();
            string sMonth = DateTime.Now.Month.ToString();
            string sDay = DateTime.Now.Day.ToString();
            string sErrorTime = sYear + sMonth + sDay;

            StreamWriter sw = new StreamWriter(sPathName + sErrorTime + ".log", true);
            sw.WriteLine(sLogFormat + sErrMsg);
            sw.Flush();
            sw.Close();
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////
    }



}


/*/
https://www.devexpress.com/Support/Center/Question/Details/T307368

private void XtraReport1_ParametersRequestBeforeShow(object sender, DevExpress.XtraReports.Parameters.ParametersRequestEventArgs e)
   {
   List<int> categoryIDList = new List<int>();

   sqlDataSource1.Fill();
   ResultSet rSet = (sqlDataSource1 as IListSource).GetList() as ResultSet;
   ResultTable categoriesTable = rSet["Categories"];
   ResultColumn resCol = rSet["Categories"].Columns.Find((col) => col.Name == "CategoryID");

   for(int i = 0; i < categoriesTable.Count; i++)
      {
      ResultRow rRow = categoriesTable[i];
      int id = 0;
      Int32.TryParse(resCol.GetValue(rRow).ToString(), out id);
      categoryIDList.Add(id);    
      }

   e.ParametersInformation[0].Parameter.Value = categoryIDList;
   }

//*/

