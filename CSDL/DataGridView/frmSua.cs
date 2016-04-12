using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DataGridView
{
    public partial class frmSua : Form
    {
        private ConnectSQL connectSQL;
        public frmSua()
        {
            InitializeComponent();
            this.connectSQL = new ConnectSQL("192.168.137.102", "testing", "sa", "admin123");
            this.connectSQL.connect();
        }

        private void frmSua_Load(object sender, EventArgs e)
        {
            SqlDataReader reader = this.connectSQL.Query("SELECT * FROM CHUC_VU");
            DataTable dt = new DataTable();
            dt.Load(reader);
            clbChucVu.DataSource = dt;
            ((ListBox)clbChucVu).DisplayMember = "CHUC_VU";
            ((ListBox)clbChucVu).ValueMember = "MSCV";
        }

        private void frmSua_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.connectSQL.closeConnect();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            string mscb = this.tbMSCB.Text;
            //Kiểm tra dữ liệu
            if (mscb.Equals(""))
            {
                MessageBox.Show("Nhập mscb", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.ActiveControl = this.tbMSCB;
            }
            else
            {
                SqlDataReader reader = this.connectSQL.Query("SELECT dbo.NHAN_VIEN.MSCB, " +
                " dbo.NHAN_VIEN.TEN,dbo.CHUC_VU.CHUC_VU FROM " +
                " dbo.CHUC_VU INNER JOIN dbo.CO ON dbo.CO.MSCV = dbo.CHUC_VU.MSCV " +
                " INNER JOIN dbo.NHAN_VIEN ON dbo.CO.MSCB = dbo.NHAN_VIEN.MSCB "+
                " WHERE dbo.NHAN_VIEN.MSCB = '"+mscb+"' ");

                if (reader.Read())
                {
                    this.tbMSCB.ReadOnly = true;
                    this.tbTen.Text = reader.GetString(1);
                    for (int count = 0; count < clbChucVu.Items.Count; count++)
                    {
                        DataRowView oDataRowView = clbChucVu.Items[count] as DataRowView;
                        if (oDataRowView["CHUC_VU"].ToString().Equals(reader.GetString(2)))
                        {
                            clbChucVu.SetItemChecked(count, true);
                            break;
                        }
                    }

                    while (reader.Read())
                    {
                        for (int count = 0; count < clbChucVu.Items.Count; count++)
                        {
                            DataRowView oDataRowView = clbChucVu.Items[count] as DataRowView;
                            if (oDataRowView["CHUC_VU"].ToString().Equals(reader.GetString(2)))
                            {
                                clbChucVu.SetItemChecked(count, true);
                            }
                        }
                    }

                }
                else
                {
                    MessageBox.Show("Không có nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.ActiveControl = this.tbMSCB;
                }
                reader.Close();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string mscb = this.tbMSCB.Text;
            string ho_ten = this.tbTen.Text;
            //Kiểm tra dữ liệu
            if (mscb.Equals(""))
            {
                MessageBox.Show("Nhập mscb", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.ActiveControl = this.tbMSCB;
            }
            else if(ho_ten.Equals(""))
            {
                MessageBox.Show("Nhập tên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.ActiveControl = this.tbTen;
            }
            else {
                if (clbChucVu.CheckedItems.Count == 0)
                {
                    MessageBox.Show("Chọn ít nhất một chức vụ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.ActiveControl = this.clbChucVu;
                    return;
                }

                //Dữ liệu phù hợp
                //Xóa bảng có
                string sql = "DELETE FROM dbo.CO WHERE dbo.CO.MSCB = '" + mscb+"'";
                this.connectSQL.executeSQL(sql);

                //Sửa bảng nhan_vien
                sql = "UPDATE dbo.NHAN_VIEN SET dbo.NHAN_VIEN.TEN =N'"+ ho_ten+ "' WHERE dbo.NHAN_VIEN.MSCB='" + mscb + "'";
                this.connectSQL.executeSQL(sql);
                //Thêm bảng có
                foreach (var item in clbChucVu.CheckedItems)
                {
                    var row = (item as DataRowView).Row;
                    sql = "INSERT INTO CO VALUES('" + mscb + "','" + row["MSCV"] + "')";
                    this.connectSQL.executeSQL(sql);
                }
                this.clearAll();
                MessageBox.Show("Sửa thành công nhân viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.ActiveControl = this.tbMSCB;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            this.clearAll();
        }

        private void clearAll()
        {
            this.tbMSCB.Clear();
            this.tbTen.Clear();
            for (int i = 0; i < clbChucVu.Items.Count; i++)
                clbChucVu.SetItemCheckState(i, CheckState.Unchecked);
            this.tbMSCB.ReadOnly = false;
        }
    }
}
