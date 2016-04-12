using System.Data.SqlClient;
using System.Windows.Forms;

namespace DataGridView
{
    public class ConnectSQL
    {
        private string stringConnect;
        private string dataSource;
        private string catalog;
        private string userID;
        private string password;
        private SqlConnection conn;
        
        public ConnectSQL(string server,string database,string userid,string pass)
        {
            this.dataSource = server;
            this.catalog = database;
            this.userID = userid;
            this.password = pass;
            this.stringConnect = "Data Source="+this.dataSource+";Initial Catalog="+this.catalog+";Persist Security Info=True;User ID="+this.userID+";Password="+this.password;
            this.conn = new SqlConnection(this.stringConnect);
        }

        public void connect()
        {
            try
            {
                this.conn.Open();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public SqlConnection getConnect()
        {
            return this.conn;
        }

        public void executeSQL(string strsql)
        {
            try{
            SqlCommand sqlcom = new SqlCommand(strsql, this.conn);
            sqlcom.ExecuteNonQuery();
            }
            catch(SqlException ex){
                 MessageBox.Show("Lỗi thực thi truy vấn: "+ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public SqlDataReader Query(string strsql)
        {
            SqlDataReader dr;
            SqlCommand sqlcom = new SqlCommand(strsql, this.conn);
            dr = sqlcom.ExecuteReader();
            
            return dr;
        }

        public void closeConnect()
        {
            this.conn.Close();
        }
    }
}
