using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGridView
{
    public partial class frmExcel : Form
    {
        private ReadAndWriteExcelFile readExcel;
        public frmExcel()
        {
            InitializeComponent();
        }

        private void btnMo_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileExcel.ShowDialog();
            if (result == DialogResult.OK) // Test result.
            {
                this.readExcel = new ReadAndWriteExcelFile(openFileExcel.FileName);
                this.dgvExcel.DataSource = this.readExcel.Read("Sheet1$");
            }
            Console.WriteLine(result); // <-- For debugging use.
        }
    }
}
