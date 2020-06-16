namespace DOAN_HTTTKT
{
    partial class PXuatNL2
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnThemMoi = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtTienChu = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSaveEdit = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.dgvXuatNL = new System.Windows.Forms.DataGridView();
            this.MSNL = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.TENNL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LOAI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DVT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DVT2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SOLUONG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DONGIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.THANHTIEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtbPhieuSo = new System.Windows.Forms.TextBox();
            this.lblPhieuSo = new System.Windows.Forms.Label();
            this.grbthongtinPhieu = new System.Windows.Forms.GroupBox();
            this.txtNguoiGiao = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbbKhoNhap = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpNgayXuat = new System.Windows.Forms.DateTimePicker();
            this.cbbKhoXuat = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtbTenCH = new System.Windows.Forms.TextBox();
            this.txtLiDo = new System.Windows.Forms.TextBox();
            this.lblTenCH = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblCH = new System.Windows.Forms.Label();
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvXuatNL)).BeginInit();
            this.grbthongtinPhieu.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSaveEdit);
            this.groupBox2.Controls.Add(this.btnThemMoi);
            this.groupBox2.Controls.Add(this.btnEdit);
            this.groupBox2.Controls.Add(this.btnThoat);
            this.groupBox2.Controls.Add(this.btnReset);
            this.groupBox2.Controls.Add(this.btnDelete);
            this.groupBox2.Controls.Add(this.btnSave);
            this.groupBox2.Location = new System.Drawing.Point(10, 397);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(341, 47);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thao tác";
            // 
            // btnThemMoi
            // 
            this.btnThemMoi.Location = new System.Drawing.Point(173, 19);
            this.btnThemMoi.Name = "btnThemMoi";
            this.btnThemMoi.Size = new System.Drawing.Size(75, 23);
            this.btnThemMoi.TabIndex = 4;
            this.btnThemMoi.Text = "Thêm mới";
            this.btnThemMoi.UseVisualStyleBackColor = true;
            this.btnThemMoi.Click += new System.EventHandler(this.btnThemMoi_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(255, 19);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 3;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(173, 18);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 2;
            this.btnReset.Text = "Làm lại";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Brown;
            this.btnDelete.Location = new System.Drawing.Point(92, 19);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.LimeGreen;
            this.btnSave.Location = new System.Drawing.Point(11, 18);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Lưu và in";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.UseWaitCursor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtTienChu
            // 
            this.txtTienChu.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtTienChu.ForeColor = System.Drawing.Color.Red;
            this.txtTienChu.Location = new System.Drawing.Point(460, 423);
            this.txtTienChu.Name = "txtTienChu";
            this.txtTienChu.Size = new System.Drawing.Size(429, 20);
            this.txtTienChu.TabIndex = 26;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(357, 430);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(97, 13);
            this.label14.TabIndex = 25;
            this.label14.Text = "Tổng TT bằng chữ";
            // 
            // txtTongTien
            // 
            this.txtTongTien.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtTongTien.Location = new System.Drawing.Point(722, 397);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(167, 20);
            this.txtTongTien.TabIndex = 24;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(660, 404);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(52, 13);
            this.label13.TabIndex = 23;
            this.label13.Text = "Tổng tiền";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvXuatNL);
            this.groupBox1.Location = new System.Drawing.Point(10, 147);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(885, 244);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin NL xuất";
            // 
            // btnSaveEdit
            // 
            this.btnSaveEdit.BackColor = System.Drawing.Color.LimeGreen;
            this.btnSaveEdit.Location = new System.Drawing.Point(11, 18);
            this.btnSaveEdit.Name = "btnSaveEdit";
            this.btnSaveEdit.Size = new System.Drawing.Size(75, 23);
            this.btnSaveEdit.TabIndex = 13;
            this.btnSaveEdit.Text = "Lưu";
            this.btnSaveEdit.UseVisualStyleBackColor = false;
            this.btnSaveEdit.UseWaitCursor = true;
            this.btnSaveEdit.Click += new System.EventHandler(this.btnSaveEdit_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.LimeGreen;
            this.btnEdit.Location = new System.Drawing.Point(11, 18);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 5;
            this.btnEdit.Text = "Chỉnh Sửa";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.UseWaitCursor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // dgvXuatNL
            // 
            this.dgvXuatNL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvXuatNL.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MSNL,
            this.TENNL,
            this.LOAI,
            this.DVT,
            this.DVT2,
            this.SOLUONG,
            this.DONGIA,
            this.THANHTIEN});
            this.dgvXuatNL.Location = new System.Drawing.Point(8, 26);
            this.dgvXuatNL.Name = "dgvXuatNL";
            this.dgvXuatNL.Size = new System.Drawing.Size(869, 152);
            this.dgvXuatNL.TabIndex = 12;
            this.dgvXuatNL.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvXuatNL_CellValueChanged);
            this.dgvXuatNL.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dgvXuatNL_RowsRemoved);
            // 
            // MSNL
            // 
            this.MSNL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.MSNL.HeaderText = "Mã nguyên liệu";
            this.MSNL.Name = "MSNL";
            this.MSNL.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.MSNL.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.MSNL.Width = 105;
            // 
            // TENNL
            // 
            this.TENNL.HeaderText = "Tên nguyên liệu";
            this.TENNL.Name = "TENNL";
            this.TENNL.ReadOnly = true;
            this.TENNL.Width = 150;
            // 
            // LOAI
            // 
            this.LOAI.HeaderText = "Loại";
            this.LOAI.Name = "LOAI";
            this.LOAI.ReadOnly = true;
            this.LOAI.Width = 95;
            // 
            // DVT
            // 
            this.DVT.HeaderText = "ĐVT (Cây/Bao/Bình)";
            this.DVT.Name = "DVT";
            this.DVT.ReadOnly = true;
            // 
            // DVT2
            // 
            this.DVT2.HeaderText = "ĐVT Khác (Lít/Kg)";
            this.DVT2.Name = "DVT2";
            this.DVT2.ReadOnly = true;
            // 
            // SOLUONG
            // 
            this.SOLUONG.HeaderText = "Số lượng";
            this.SOLUONG.Name = "SOLUONG";
            this.SOLUONG.Width = 80;
            // 
            // DONGIA
            // 
            this.DONGIA.HeaderText = "Đơn giá";
            this.DONGIA.Name = "DONGIA";
            this.DONGIA.ReadOnly = true;
            // 
            // THANHTIEN
            // 
            this.THANHTIEN.HeaderText = "Thành tiền";
            this.THANHTIEN.Name = "THANHTIEN";
            this.THANHTIEN.ReadOnly = true;
            // 
            // txtbPhieuSo
            // 
            this.txtbPhieuSo.Location = new System.Drawing.Point(760, 12);
            this.txtbPhieuSo.Name = "txtbPhieuSo";
            this.txtbPhieuSo.Size = new System.Drawing.Size(135, 20);
            this.txtbPhieuSo.TabIndex = 19;
            this.txtbPhieuSo.TextChanged += new System.EventHandler(this.txtbPhieuSo_TextChanged);
            // 
            // lblPhieuSo
            // 
            this.lblPhieuSo.AutoSize = true;
            this.lblPhieuSo.Location = new System.Drawing.Point(704, 19);
            this.lblPhieuSo.Name = "lblPhieuSo";
            this.lblPhieuSo.Size = new System.Drawing.Size(50, 13);
            this.lblPhieuSo.TabIndex = 18;
            this.lblPhieuSo.Text = "Phiếu Số";
            // 
            // grbthongtinPhieu
            // 
            this.grbthongtinPhieu.Controls.Add(this.txtNguoiGiao);
            this.grbthongtinPhieu.Controls.Add(this.label2);
            this.grbthongtinPhieu.Controls.Add(this.cbbKhoNhap);
            this.grbthongtinPhieu.Controls.Add(this.label1);
            this.grbthongtinPhieu.Controls.Add(this.dtpNgayXuat);
            this.grbthongtinPhieu.Controls.Add(this.cbbKhoXuat);
            this.grbthongtinPhieu.Controls.Add(this.label7);
            this.grbthongtinPhieu.Controls.Add(this.txtbTenCH);
            this.grbthongtinPhieu.Controls.Add(this.txtLiDo);
            this.grbthongtinPhieu.Controls.Add(this.lblTenCH);
            this.grbthongtinPhieu.Controls.Add(this.label6);
            this.grbthongtinPhieu.Controls.Add(this.lblCH);
            this.grbthongtinPhieu.Location = new System.Drawing.Point(10, 46);
            this.grbthongtinPhieu.Name = "grbthongtinPhieu";
            this.grbthongtinPhieu.Size = new System.Drawing.Size(885, 95);
            this.grbthongtinPhieu.TabIndex = 16;
            this.grbthongtinPhieu.TabStop = false;
            this.grbthongtinPhieu.Text = "Thông tin Phiếu xuất NL";
            // 
            // txtNguoiGiao
            // 
            this.txtNguoiGiao.Location = new System.Drawing.Point(653, 44);
            this.txtNguoiGiao.Name = "txtNguoiGiao";
            this.txtNguoiGiao.Size = new System.Drawing.Size(224, 20);
            this.txtNguoiGiao.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(561, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Người giao hàng";
            // 
            // cbbKhoNhap
            // 
            this.cbbKhoNhap.FormattingEnabled = true;
            this.cbbKhoNhap.Location = new System.Drawing.Point(653, 20);
            this.cbbKhoNhap.Name = "cbbKhoNhap";
            this.cbbKhoNhap.Size = new System.Drawing.Size(224, 21);
            this.cbbKhoNhap.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(561, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Địa chỉ kho nhận";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dtpNgayXuat
            // 
            this.dtpNgayXuat.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayXuat.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayXuat.Location = new System.Drawing.Point(110, 44);
            this.dtpNgayXuat.Name = "dtpNgayXuat";
            this.dtpNgayXuat.Size = new System.Drawing.Size(100, 20);
            this.dtpNgayXuat.TabIndex = 0;
            this.dtpNgayXuat.ValueChanged += new System.EventHandler(this.dtpNgayXuat_ValueChanged);
            // 
            // cbbKhoXuat
            // 
            this.cbbKhoXuat.FormattingEnabled = true;
            this.cbbKhoXuat.Location = new System.Drawing.Point(110, 19);
            this.cbbKhoXuat.Name = "cbbKhoXuat";
            this.cbbKhoXuat.Size = new System.Drawing.Size(100, 21);
            this.cbbKhoXuat.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(224, 51);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Lý do xuất";
            // 
            // txtbTenCH
            // 
            this.txtbTenCH.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtbTenCH.Location = new System.Drawing.Point(329, 20);
            this.txtbTenCH.Name = "txtbTenCH";
            this.txtbTenCH.Size = new System.Drawing.Size(215, 20);
            this.txtbTenCH.TabIndex = 3;
            // 
            // txtLiDo
            // 
            this.txtLiDo.Location = new System.Drawing.Point(329, 44);
            this.txtLiDo.Name = "txtLiDo";
            this.txtLiDo.Size = new System.Drawing.Size(215, 20);
            this.txtLiDo.TabIndex = 3;
            // 
            // lblTenCH
            // 
            this.lblTenCH.AutoSize = true;
            this.lblTenCH.Location = new System.Drawing.Point(224, 27);
            this.lblTenCH.Name = "lblTenCH";
            this.lblTenCH.Size = new System.Drawing.Size(101, 13);
            this.lblTenCH.TabIndex = 2;
            this.lblTenCH.Text = "Tên kho/ Cửa hàng";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Ngày xuất NL";
            // 
            // lblCH
            // 
            this.lblCH.AutoSize = true;
            this.lblCH.Location = new System.Drawing.Point(7, 27);
            this.lblCH.Name = "lblCH";
            this.lblCH.Size = new System.Drawing.Size(97, 13);
            this.lblCH.TabIndex = 0;
            this.lblCH.Text = "Mã kho/ Cửa hàng";
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.AutoSize = true;
            this.lblTieuDe.BackColor = System.Drawing.SystemColors.Control;
            this.lblTieuDe.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTieuDe.ForeColor = System.Drawing.Color.DarkRed;
            this.lblTieuDe.Location = new System.Drawing.Point(273, 9);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(289, 24);
            this.lblTieuDe.TabIndex = 15;
            this.lblTieuDe.Text = "PHIẾU XUẤT NGUYÊN LIỆU";
            this.lblTieuDe.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // PXuatNL2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 453);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txtTienChu);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtTongTien);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtbPhieuSo);
            this.Controls.Add(this.lblPhieuSo);
            this.Controls.Add(this.grbthongtinPhieu);
            this.Controls.Add(this.lblTieuDe);
            this.Name = "PXuatNL2";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.PXuatNL2_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvXuatNL)).EndInit();
            this.grbthongtinPhieu.ResumeLayout(false);
            this.grbthongtinPhieu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtTienChu;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtbPhieuSo;
        private System.Windows.Forms.Label lblPhieuSo;
        private System.Windows.Forms.GroupBox grbthongtinPhieu;
        private System.Windows.Forms.DateTimePicker dtpNgayXuat;
        private System.Windows.Forms.ComboBox cbbKhoXuat;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtbTenCH;
        private System.Windows.Forms.TextBox txtLiDo;
        private System.Windows.Forms.Label lblTenCH;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblCH;
        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.DataGridView dgvXuatNL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbKhoNhap;
        private System.Windows.Forms.TextBox txtNguoiGiao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewComboBoxColumn MSNL;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENNL;
        private System.Windows.Forms.DataGridViewTextBoxColumn LOAI;
        private System.Windows.Forms.DataGridViewTextBoxColumn DVT;
        private System.Windows.Forms.DataGridViewTextBoxColumn DVT2;
        private System.Windows.Forms.DataGridViewTextBoxColumn SOLUONG;
        private System.Windows.Forms.DataGridViewTextBoxColumn DONGIA;
        private System.Windows.Forms.DataGridViewTextBoxColumn THANHTIEN;
        private System.Windows.Forms.Button btnThemMoi;
        private System.Windows.Forms.Button btnSaveEdit;
        private System.Windows.Forms.Button btnEdit;
    }
}