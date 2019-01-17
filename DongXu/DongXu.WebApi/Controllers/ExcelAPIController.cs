using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DongXu.WebApi.Controllers
{
    using DongXu.IServices;
    using Newtonsoft.Json;
    using System.Data;
    using System.Data.OleDb;
    [RoutePrefix("Excel")]

    public class ExcelAPIController : ApiController
    {

        public ITargetDetailsServices targetDetailsServices { get; set; }
        /// <summary>
        /// 将数据导出到指定的Excel文件中
        /// </summary>
        /// <param name="destFileName">指定目标文件路径</param>
        /// <param name="tableName">要导出到的表名称</param>
        /// <returns>导出的记录的行数</returns>
        public static int ExportToExcel(DataTable dt, string destFileName, string tableName)
        {


            //得到字段名
            string szFields = "";
            string szValues = "";

            for (int i = 1; i < dt.Columns.Count; i++)
            {
                szFields += "[" + dt.Columns[i] + "],";
            }
            szFields = szFields.TrimEnd(',');

            //定义数据连接

            OleDbConnection connection = new OleDbConnection();

            connection.ConnectionString = GetConnectionString("D:\\" + destFileName + ".xlsx");

            OleDbCommand command = new OleDbCommand();

            command.Connection = connection;

            command.CommandType = CommandType.Text;

            //打开数据库连接

            try
            {
                connection.Open();
            }
            catch
            {
                throw new Exception("目标文件路径错误。");
            }
            //创建数据库表

            try
            {
                command.CommandText = GetCreateTableSql("[" + tableName + "]", szFields.Split(','));
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                //如果允许覆盖则删除已有数据
                throw ex;
            }
            try
            {
                //循环处理数据------------------------------------------
                int recordCount = 0;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    szValues = "";

                    for (int j = 1; j < dt.Columns.Count; j++)
                    {
                        szValues += "'" + dt.Rows[i][j] + "',";
                    }

                    szValues = szValues.TrimEnd(',');

                    //组合成SQL语句并执行
                    string szSql = "INSERT INTO [" + tableName + "](" + szFields + ") VALUES(" + szValues + ")";

                    command.CommandText = szSql;
                    recordCount += command.ExecuteNonQuery();
                }
                connection.Close();
                return recordCount;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        //得到连接字符串
        private static String GetConnectionString(string fullPath)
        {
            string szConnection;
            szConnection = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + fullPath + ";Extended Properties=Excel 12.0;";
            return szConnection;

        }

        //得到创建表的SQL语句
        private static string GetCreateTableSql(string tableName, string[] fields)
        {
            string szSql = "CREATE TABLE " + tableName + "(";
            for (int i = 0; i < fields.Length; i++)
            {
                szSql += fields[i] + " Text,";
            }
            szSql = szSql.TrimEnd(',') + ")";
            return szSql;

        }
        [Route("GetUnit")]
        [HttpGet]
        public int GetUnit(string fileName, string tableName)
        {
            var list = targetDetailsServices.GetTargetDetails(); 

            var dt = JsonConvert.DeserializeObject<DataTable>(JsonConvert.SerializeObject(list));

            int i = ExportToExcel(dt, fileName, tableName);

            return i;
        }
    }
}
