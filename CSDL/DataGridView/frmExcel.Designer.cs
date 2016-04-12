namespace DataGridView
{
    partial class frmExcel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnMo = new System.Windows.Forms.Button();
            this.lbDuongDan = new System.Windows.Forms.Label();
            this.spcMain = new System.Windows.Forms.SplitContainer();
            this.dgvExcel = new System.Windows.Forms.DataGridView();
            this.openFileExcel = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.spcMain)).BeginInit();
            this.spcMain.Panel1.SuspendLayout();
            this.spcMain.Panel2.SuspendLayout();
            this.spcMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExcel)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMo
            // 
            this.btnMo.Location = new System.Drawing.Point(559, 12);
            this.btnMo.Name = "btnMo";
            this.btnMo.Size = new System.Drawing.Size(132, 43);
            this.btnMo.TabIndex = 0;
            this.btnMo.Text = "Mở file";
            this.btnMo.UseVisualStyleBackColor = true;
            this.btnMo.Click += new System.EventHandler(this.btnMo_Click);
            // 
            // lbDuongDan
            // 
            this.lbDuongDan.AutoSize = true;
            this.lbDuongDan.Location = new System.Drawing.Point(8, 23);
            this.lbDuongDan.Name = "lbDuongDan";
            this.lbDuongDan.Size = new System.Drawing.Size(96, 20);
            this.lbDuongDan.TabIndex = 1;
            this.lbDuongDan.Text = "Đường dẫn: ";
            // 
            // spcMain
            // 
            this.spcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spcMain.Location = new System.Drawing.Point(0, 0);
            this.spcMain.Name = "spcMain";
            this.spcMain.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // spcMain.Panel1
            // 
            this.spcMain.Panel1.Controls.Add(this.lbDuongDan);
            this.spcMain.Panel1.Controls.Add(this.btnMo);
            // 
            // spcMain.Panel2
            // 
            this.spcMain.Panel2.Controls.Add(this.dgvExcel);
            this.spcMain.Size = new System.Drawing.Size(698, 424);
            this.spcMain.SplitterDistance = 63;
            this.spcMain.TabIndex = 2;
            // 
            // dgvExcel
            // 
            this.dgvExcel.AllowUserToAddRows = false;
            this.dgvExcel.AllowUserToDeleteRows = false;
            this.dgvExcel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExcel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvExcel.Location = new System.Drawing.Point(0, 0);
            this.dgvExcel.MultiSelect = false;
            this.dgvExcel.Name = "dgvExcel";
            this.dgvExcel.ReadOnly = true;
            this.dgvExcel.RowTemplate.Height = 28;
            this.dgvExcel.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvExcel.Size = new System.Drawing.Size(698, 357);
            this.dgvExcel.TabIndex = 0;
            // 
            // openFileExcel
            // 
            this.openFileExcel.Filter = "Excel 2003|*.xls|Excel 2007 - 2010 - 2013|*.xlsx";
            this.openFileExcel.Title = "Mở file excel";
            // 
            // frmExcel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 424);
            this.Controls.Add(this.spcMain);
            this.MaximumSize = new System.Drawing.Size(720, 480);
            this.MinimumSize = new System.Drawing.Size(720, 480);
            this.Name = "frmExcel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đọc file excel";
            this.spcMain.Panel1.ResumeLayout(false);
            this.spcMain.Panel1.PerformLayout();
            this.spcMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spcMain)).EndInit();
            this.spcMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvExcel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMo;
        private System.Windows.Forms.Label lbDuongDan;
        private System.Windows.Forms.SplitContainer spcMain;
        private System.Windows.Forms.DataGridView dgvExcel;
        private System.Windows.Forms.OpenFileDialog openFileExcel;
    }
}