using System;
using System.Collections.Generic;
using System.Text;
using System.Data.OleDb;
using System.Data;
using System.Windows.Forms;
using System.IO;

namespace DataGridView
{
    class ReadAndWriteExcelFile
    {
        private string DataSource;//Duong dan den file excel
        private DataTable dtSheet;//Bang chua cac gia tri sheet name
        private StringBuilder sb;//Chuoi ket noi
        private Dictionary<string, string> props = new Dictionary<string, string>();//Chua thong tin cau hinh ve file excel
        private OleDbConnection conn; //Ket noi 
        public ReadAndWriteExcelFile(string DataSource)
        {
            this.DataSource = DataSource;
            this.SetConnectString();
        }

        private void SetProps()
        {
            if (Path.GetExtension(this.DataSource).Equals(".xls"))
            {
                //Excel 2003
                this.props["Provider"] = "Microsoft.Jet.OLEDB.4.0";
                this.props["Extended Properties"] = "Excel 8.0";
                this.props["Data Source"] = this.DataSource;
            }
            else if (Path.GetExtension(this.DataSource).Equals(".xlsx"))
            {
                //Excel 2007,2010,2012,2013
                this.props["Provider"] = "Microsoft.ACE.OLEDB.12.0";
                this.props["Extended Properties"] = "Excel 12.0 XML";
                this.props["Data Source"] = this.DataSource;
            }
        }

        private void SetConnectString()
        {
            this.SetProps();
            this.sb = new StringBuilder();
            foreach(KeyValuePair<string,string> prop in props)
            {
                this.sb.Append(prop.Key);
                this.sb.Append('=');
                this.sb.Append(prop.Value);
                this.sb.Append(';');
            }
        }

        public DataTable GetDataSheet()
        {
            //Get all sheet in excel file
            this.OpenConnect();
            this.dtSheet = this.conn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables,null);
            this.CloseConnect();
            return this.dtSheet;
        }

        private void OpenConnect()
        {
            this.conn = new OleDbConnection(this.sb.ToString());
            this.conn.Open();
        }

        private void CloseConnect()
        {
            this.conn.Close();
        }

        public DataTable Read(string sheetName)
        {
            DataTable dt = new DataTable();
            try
            {
                this.OpenConnect();
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = this.conn;
                //Get all rows from the sheet
                //dt.TableName = sheetName;
                cmd.CommandText = "SELECT * FROM [" + sheetName + "]";
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                da.Fill(dt);
                cmd = null;
                this.CloseConnect();
            }
            catch (Exception ex)
            {
                //
            }
            return dt;
        }

        public void Write(string nameSheet, string[] ColumnHeaders,DataTable data)
        {
            try
            {
                if (File.Exists(this.props["Data Source"]))
                    File.Delete(this.props["Data Source"]);
                string sql = "CREATE TABLE [" + nameSheet + "] (";
                for (int i = 0; i < ColumnHeaders.Length; i++)
                {
                    sql +="["+ ColumnHeaders[i] + "] String,";
                }
                sql = sql.Substring(0, sql.Length - 1) + ")";
                OleDbCommand cmd = new OleDbCommand();
                this.OpenConnect();
                cmd.Connection = this.conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
                ///
               /// cmd.Connection = this.conn;
               /// 
                for (int i = 0; i < data.Rows.Count;i++)
                {
                    cmd.CommandText = "INSERT INTO [" + nameSheet + "] VALUES('" + data.Rows[i][0] + "','" + data.Rows[i][1] + "','" + data.Rows[i][2] + "','" + data.Rows[i][3] + "','" +  String.Format("{0:0.00}", data.Rows[i][17]) + "')";
                    cmd.ExecuteNonQuery();
                }
                this.CloseConnect();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
