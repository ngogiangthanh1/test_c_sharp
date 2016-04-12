namespace DataGridView
{
    partial class frmXoa
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
            this.components = new System.ComponentModel.Container();
            this.dgvDemo = new System.Windows.Forms.DataGridView();
            this.colSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMSCB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colChucVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ctmstrXoa = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiXoa = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDemo)).BeginInit();
            this.ctmstrXoa.SuspendLayout();
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
            this.dgvDemo.ContextMenuStrip = this.ctmstrXoa;
            this.dgvDemo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDemo.Location = new System.Drawing.Point(0, 0);
            this.dgvDemo.MultiSelect = false;
            this.dgvDemo.Name = "dgvDemo";
            this.dgvDemo.ReadOnly = true;
            this.dgvDemo.RowTemplate.Height = 28;
            this.dgvDemo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDemo.Size = new System.Drawing.Size(446, 244);
            this.dgvDemo.TabIndex = 1;
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
            // ctmstrXoa
            // 
            this.ctmstrXoa.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.ctmstrXoa.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiXoa});
            this.ctmstrXoa.Name = "ctmstrXoa";
            this.ctmstrXoa.Size = new System.Drawing.Size(129, 34);
            // 
            // tsmiXoa
            // 
            this.tsmiXoa.Name = "tsmiXoa";
            this.tsmiXoa.Size = new System.Drawing.Size(211, 30);
            this.tsmiXoa.Text = "Xóa";
            this.tsmiXoa.Click += new System.EventHandler(this.tsmiXoa_Click);
            // 
            // frmXoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 244);
            this.Controls.Add(this.dgvDemo);
            this.Name = "frmXoa";
            this.Text = "Xóa trên DatagridView";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmXoa_FormClosing);
            this.Load += new System.EventHandler(this.frmXoa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDemo)).EndInit();
            this.ctmstrXoa.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDemo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMSCB;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn colChucVu;
        private System.Windows.Forms.ContextMenuStrip ctmstrXoa;
        private System.Windows.Forms.ToolStripMenuItem tsmiXoa;
    }
}