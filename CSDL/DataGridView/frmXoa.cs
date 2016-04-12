using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DataGridView
{
    public partial class frmXoa : Form
    {
        private ConnectSQL connectSQL;
        public frmXoa()
        {
            InitializeComponent();
            this.connectSQL = new ConnectSQL("192.168.137.102", "testing", "sa", "admin123");
            this.connectSQL.connect();
        }

        private void frmXoa_Load(object sender, EventArgs e)
        {
            dgvDemo.Rows.Clear();
            dgvDemo.Refresh();
            this.load();
        }

        private void load()
        {
            SqlDataReader reader = this.connectSQL.Query("SELECT dbo.NHAN_VIEN.MSCB, " +
                " dbo.NHAN_VIEN.TEN,dbo.CHUC_VU.CHUC_VU FROM " +
                " dbo.CHUC_VU INNER JOIN dbo.CO ON dbo.CO.MSCV = dbo.CHUC_VU.MSCV " +
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

        private void tsmiXoa_Click(object sender, EventArgs e)
        {
            
            if (dgvDemo.SelectedCells.Count > 0)
            {
                DialogResult dialogResult = MessageBox.Show("Có chắc xóa nhân viên này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    //Lấy thông tin đối tượng cần xóa
                    int selectedrowindex = dgvDemo.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedRow = dgvDemo.Rows[selectedrowindex];
                    string mscb = Convert.ToString(selectedRow.Cells["colMSCB"].Value);
                    //Xóa
                    string sql = "DELETE FROM NHAN_VIEN WHERE MSCB = " + mscb;
                    this.connectSQL.executeSQL(sql);
                    this.load();
                }
                
            }
        }

        private void frmXoa_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.connectSQL.closeConnect();
        }
    }
}
