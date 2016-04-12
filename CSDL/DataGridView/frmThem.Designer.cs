namespace DataGridView
{
    partial class frmThem
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
            this.lbMSCB = new System.Windows.Forms.Label();
            this.lbTen = new System.Windows.Forms.Label();
            this.lbChucVu = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.tbMSCB = new System.Windows.Forms.TextBox();
            this.tbTen = new System.Windows.Forms.TextBox();
            this.clbChucVu = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // lbMSCB
            // 
            this.lbMSCB.AutoSize = true;
            this.lbMSCB.Location = new System.Drawing.Point(50, 28);
            this.lbMSCB.Name = "lbMSCB";
            this.lbMSCB.Size = new System.Drawing.Size(55, 20);
            this.lbMSCB.TabIndex = 0;
            this.lbMSCB.Text = "MSCB";
            // 
            // lbTen
            // 
            this.lbTen.AutoSize = true;
            this.lbTen.Location = new System.Drawing.Point(50, 76);
            this.lbTen.Name = "lbTen";
            this.lbTen.Size = new System.Drawing.Size(57, 20);
            this.lbTen.TabIndex = 1;
            this.lbTen.Text = "Họ tên";
            // 
            // lbChucVu
            // 
            this.lbChucVu.AutoSize = true;
            this.lbChucVu.Location = new System.Drawing.Point(50, 133);
            this.lbChucVu.Name = "lbChucVu";
            this.lbChucVu.Size = new System.Drawing.Size(66, 20);
            this.lbChucVu.TabIndex = 2;
            this.lbChucVu.Text = "Chức vụ";
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(54, 239);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(137, 43);
            this.btnThem.TabIndex = 3;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(205, 239);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(137, 43);
            this.btnXoa.TabIndex = 4;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // tbMSCB
            // 
            this.tbMSCB.Location = new System.Drawing.Point(146, 22);
            this.tbMSCB.Name = "tbMSCB";
            this.tbMSCB.Size = new System.Drawing.Size(169, 26);
            this.tbMSCB.TabIndex = 5;
            // 
            // tbTen
            // 
            this.tbTen.Location = new System.Drawing.Point(146, 70);
            this.tbTen.Name = "tbTen";
            this.tbTen.Size = new System.Drawing.Size(169, 26);
            this.tbTen.TabIndex = 6;
            // 
            // clbChucVu
            // 
            this.clbChucVu.FormattingEnabled = true;
            this.clbChucVu.Location = new System.Drawing.Point(146, 102);
            this.clbChucVu.Name = "clbChucVu";
            this.clbChucVu.Size = new System.Drawing.Size(169, 109);
            this.clbChucVu.TabIndex = 7;
            // 
            // frmThem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 301);
            this.Controls.Add(this.clbChucVu);
            this.Controls.Add(this.tbTen);
            this.Controls.Add(this.tbMSCB);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.lbChucVu);
            this.Controls.Add(this.lbTen);
            this.Controls.Add(this.lbMSCB);
            this.Name = "frmThem";
            this.Text = "Thêm nhân viên";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmThem_FormClosing);
            this.Load += new System.EventHandler(this.frmThem_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbMSCB;
        private System.Windows.Forms.Label lbTen;
        private System.Windows.Forms.Label lbChucVu;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.TextBox tbMSCB;
        private System.Windows.Forms.TextBox tbTen;
        private System.Windows.Forms.CheckedListBox clbChucVu;
    }
}