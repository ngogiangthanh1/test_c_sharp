using System;
using System.Data;
using System.Windows.Forms;

namespace CSDL
{
    public partial class frmMain : Form
    {
        private ConnectSQL connectSQL;
        public frmMain()
        {
            InitializeComponent();
            this.connectSQL = new ConnectSQL("192.168.137.102", "testing", "sa", "admin123");
        }

        private void btnConnect_Click(object sender, EventArgs e) {
            this.connectSQL.testSQL();
            this.btnConnect.Enabled = false;
            this.btnClose.Enabled = true;
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            if (this.connectSQL.getConnect().State == ConnectionState.Open)
            {
                MessageBox.Show("Kết nối đang mở!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (this.connectSQL.getConnect() != null && this.connectSQL.getConnect().State == ConnectionState.Closed)
            {
                MessageBox.Show("Kết nối đã đóng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.btnConnect.Enabled = true;
            this.connectSQL.closeConnect();
            this.btnClose.Enabled = false;
        }
    }
}
