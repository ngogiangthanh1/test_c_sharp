using System.Data.SqlClient;
using System.Windows.Forms;

namespace CSDL
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

        public SqlConnection getConnect()
        {
            return this.conn;
        }

        public bool testSQL()
        {
            try
            {
                this.conn.Open();
                MessageBox.Show("Kết nối CSDL thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            catch (SqlException ex)
            {

                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }


        public void closeConnect()
        {
            this.conn.Close();
        }
    }
}
