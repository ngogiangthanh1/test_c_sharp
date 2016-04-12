namespace DataGridView
{
    partial class frmSua
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
            this.clbChucVu = new System.Windows.Forms.CheckedListBox();
            this.tbTen = new System.Windows.Forms.TextBox();
            this.tbMSCB = new System.Windows.Forms.TextBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.lbChucVu = new System.Windows.Forms.Label();
            this.lbTen = new System.Windows.Forms.Label();
            this.lbMSCB = new System.Windows.Forms.Label();
            this.btnTim = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // clbChucVu
            // 
            this.clbChucVu.FormattingEnabled = true;
            this.clbChucVu.Location = new System.Drawing.Point(138, 100);
            this.clbChucVu.Name = "clbChucVu";
            this.clbChucVu.Size = new System.Drawing.Size(169, 109);
            this.clbChucVu.TabIndex = 15;
            // 
            // tbTen
            // 
            this.tbTen.Location = new System.Drawing.Point(138, 68);
            this.tbTen.Name = "tbTen";
            this.tbTen.Size = new System.Drawing.Size(169, 26);
            this.tbTen.TabIndex = 14;
            // 
            // tbMSCB
            // 
            this.tbMSCB.Location = new System.Drawing.Point(138, 20);
            this.tbMSCB.Name = "tbMSCB";
            this.tbMSCB.Size = new System.Drawing.Size(169, 26);
            this.tbMSCB.TabIndex = 13;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(236, 237);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(137, 43);
            this.btnXoa.TabIndex = 12;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(85, 237);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(137, 43);
            this.btnThem.TabIndex = 11;
            this.btnThem.Text = "Sửa";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // lbChucVu
            // 
            this.lbChucVu.AutoSize = true;
            this.lbChucVu.Location = new System.Drawing.Point(42, 131);
            this.lbChucVu.Name = "lbChucVu";
            this.lbChucVu.Size = new System.Drawing.Size(66, 20);
            this.lbChucVu.TabIndex = 10;
            this.lbChucVu.Text = "Chức vụ";
            // 
            // lbTen
            // 
            this.lbTen.AutoSize = true;
            this.lbTen.Location = new System.Drawing.Point(42, 74);
            this.lbTen.Name = "lbTen";
            this.lbTen.Size = new System.Drawing.Size(57, 20);
            this.lbTen.TabIndex = 9;
            this.lbTen.Text = "Họ tên";
            // 
            // lbMSCB
            // 
            this.lbMSCB.AutoSize = true;
            this.lbMSCB.Location = new System.Drawing.Point(42, 26);
            this.lbMSCB.Name = "lbMSCB";
            this.lbMSCB.Size = new System.Drawing.Size(55, 20);
            this.lbMSCB.TabIndex = 8;
            this.lbMSCB.Text = "MSCB";
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(313, 12);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(133, 39);
            this.btnTim.TabIndex = 16;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // frmSua
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 304);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.clbChucVu);
            this.Controls.Add(this.tbTen);
            this.Controls.Add(this.tbMSCB);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.lbChucVu);
            this.Controls.Add(this.lbTen);
            this.Controls.Add(this.lbMSCB);
            this.MaximumSize = new System.Drawing.Size(480, 360);
            this.MinimumSize = new System.Drawing.Size(480, 360);
            this.Name = "frmSua";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sửa nhân viên";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmSua_FormClosing);
            this.Load += new System.EventHandler(this.frmSua_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox clbChucVu;
        private System.Windows.Forms.TextBox tbTen;
        private System.Windows.Forms.TextBox tbMSCB;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label lbChucVu;
        private System.Windows.Forms.Label lbTen;
        private System.Windows.Forms.Label lbMSCB;
        private System.Windows.Forms.Button btnTim;
    }
}