using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DataGridView
{
    public partial class frmMain : Form
    {
        private ConnectSQL connectSQL;
        public frmMain()
        {
            InitializeComponent();
            this.connectSQL = new ConnectSQL("192.168.137.102", "testing", "sa", "admin123");
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            this.connectSQL.connect();
            SqlDataReader reader = this.connectSQL.Query("SELECT dbo.NHAN_VIEN.MSCB, "+
                " dbo.NHAN_VIEN.TEN,dbo.CHUC_VU.CHUC_VU FROM " +
                " dbo.CHUC_VU INNER JOIN dbo.CO ON dbo.CO.MSCV = dbo.CHUC_VU.MSCV "+
                " INNER JOIN dbo.NHAN_VIEN ON dbo.CO.MSCB = dbo.NHAN_VIEN.MSCB");

            DataTable dt = new DataTable();

            dt.Load(reader);

            dt.Columns.Add("stt", typeof(System.Int32));
            uint stt = 0;
            foreach (DataRow row in dt.Rows)
            {
                row["stt"] = ++stt;
            }
            dgvDemo.DataSource = dt;
            reader.Close();

        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.connectSQL.closeConnect();
        }
    }
}
