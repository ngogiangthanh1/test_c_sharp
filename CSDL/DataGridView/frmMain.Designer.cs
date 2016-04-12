namespace DataGridView
{
    partial class frmMain
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
            this.dgvDemo = new System.Windows.Forms.DataGridView();
            this.colSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMSCB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colChucVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDemo)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDemo
            // 
            this.dgvDemo.AllowUserToAddRows = false;
            this.dgvDemo.AllowUserToDeleteRows = false;
            this.dgvDemo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDemo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSTT,
            this.colMSCB,
            this.colHoTen,
            this.colChucVu});
            this.dgvDemo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDemo.Location = new System.Drawing.Point(0, 0);
            this.dgvDemo.MultiSelect = false;
            this.dgvDemo.Name = "dgvDemo";
            this.dgvDemo.ReadOnly = true;
            this.dgvDemo.RowTemplate.Height = 28;
            this.dgvDemo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDemo.Size = new System.Drawing.Size(698, 304);
            this.dgvDemo.TabIndex = 0;
            // 
            // colSTT
            // 
            this.colSTT.DataPropertyName = "stt";
            this.colSTT.HeaderText = "STT";
            this.colSTT.Name = "colSTT";
            this.colSTT.ReadOnly = true;
            // 
            // colMSCB
            // 
            this.colMSCB.DataPropertyName = "mscb";
            this.colMSCB.HeaderText = "MSCB";
            this.colMSCB.Name = "colMSCB";
            this.colMSCB.ReadOnly = true;
            // 
            // colHoTen
            // 
            this.colHoTen.DataPropertyName = "ten";
            this.colHoTen.HeaderText = "Họ tên";
            this.colHoTen.Name = "colHoTen";
            this.colHoTen.ReadOnly = true;
            // 
            // colChucVu
            // 
            this.colChucVu.DataPropertyName = "chuc_vu";
            this.colChucVu.HeaderText = "Chức vụ";
            this.colChucVu.Name = "colChucVu";
            this.colChucVu.ReadOnly = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 304);
            this.Controls.Add(this.dgvDemo);
            this.MaximumSize = new System.Drawing.Size(720, 360);
            this.MinimumSize = new System.Drawing.Size(720, 360);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Demo DataGridview";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDemo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDemo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMSCB;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn colChucVu;
    }
}

