using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DataGridView
{
    public partial class frmThem : Form
    {
        private ConnectSQL connectSQL;
        public frmThem()
        {
            InitializeComponent();
            this.connectSQL = new ConnectSQL("192.168.137.102", "testing", "sa", "admin123");
            this.connectSQL.connect();
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
            else if (ho_ten.Equals(""))
            {
                MessageBox.Show("Nhập tên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.ActiveControl = this.tbTen;
            }
            else{
                if(clbChucVu.CheckedItems.Count == 0)
                {
                    MessageBox.Show("Chọn ít nhất một chức vụ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.ActiveControl = this.clbChucVu;
                    return;
                }

                //Dữ liệu phù hợp
                //Thêm bảng nhan_vien
                string sql = "INSERT INTO NHAN_VIEN VALUES('"+mscb+"','"+ho_ten+"')";
                this.connectSQL.executeSQL(sql);
                //Thêm bảng có

                foreach (var item in clbChucVu.CheckedItems)
                {
                    var row = (item as DataRowView).Row;
                    sql = "INSERT INTO CO VALUES('" + mscb + "','" + row["MSCV"] + "')";
                    this.connectSQL.executeSQL(sql);
                }
                this.clearAll();
                MessageBox.Show("Thêm thành công nhân viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        }

        private void frmThem_Load(object sender, EventArgs e)
        {
            SqlDataReader reader = this.connectSQL.Query("SELECT * FROM CHUC_VU");

            DataTable dt = new DataTable();
            dt.Load(reader);
            clbChucVu.DataSource = dt;
            ((ListBox)clbChucVu).DisplayMember = "CHUC_VU";
            ((ListBox)clbChucVu).ValueMember = "MSCV";
        }

        private void frmThem_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.connectSQL.closeConnect();
        }
    }
}
