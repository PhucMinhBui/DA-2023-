namespace QuanLyBanHang
{
    partial class frmProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProduct));
            this.label1 = new System.Windows.Forms.Label();
            this.txtMa = new System.Windows.Forms.TextBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSLnhap = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtGianhap = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbLoai = new System.Windows.Forms.ComboBox();
            this.txtGiaxuat = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtGhichu = new System.Windows.Forms.TextBox();
            this.lbGhichu = new System.Windows.Forms.Label();
            this.btnTimkiem = new System.Windows.Forms.Button();
            this.btnHienthi = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lbMaHangHoa = new System.Windows.Forms.Label();
            this.bntSave = new System.Windows.Forms.Button();
            this.bntExit = new System.Windows.Forms.Button();
            this.dgvDshh = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSLxuat = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnOpen = new System.Windows.Forms.Button();
            this.picbClosePro = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDshh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbClosePro)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã hàng hoá";
            // 
            // txtMa
            // 
            this.txtMa.Location = new System.Drawing.Point(198, 28);
            this.txtMa.Name = "txtMa";
            this.txtMa.Size = new System.Drawing.Size(268, 22);
            this.txtMa.TabIndex = 1;
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(199, 60);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(268, 22);
            this.txtTen.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên hàng hoá";
            // 
            // txtSLnhap
            // 
            this.txtSLnhap.Location = new System.Drawing.Point(199, 117);
            this.txtSLnhap.Name = "txtSLnhap";
            this.txtSLnhap.Size = new System.Drawing.Size(268, 22);
            this.txtSLnhap.TabIndex = 5;
            this.txtSLnhap.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.keyPressEvent);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Số lượng nhập";
            // 
            // txtGianhap
            // 
            this.txtGianhap.Location = new System.Drawing.Point(199, 174);
            this.txtGianhap.Name = "txtGianhap";
            this.txtGianhap.Size = new System.Drawing.Size(268, 22);
            this.txtGianhap.TabIndex = 7;
            this.txtGianhap.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.keyPressEvent);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Giá nhập";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Loại hàng hoá";
            // 
            // cmbLoai
            // 
            this.cmbLoai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLoai.FormattingEnabled = true;
            this.cmbLoai.Items.AddRange(new object[] {
            "Trái cây",
            "Rau củ",
            "Thịt ",
            "Hoa",
            "Khác"});
            this.cmbLoai.Location = new System.Drawing.Point(199, 88);
            this.cmbLoai.Name = "cmbLoai";
            this.cmbLoai.Size = new System.Drawing.Size(267, 24);
            this.cmbLoai.TabIndex = 9;
            // 
            // txtGiaxuat
            // 
            this.txtGiaxuat.Location = new System.Drawing.Point(199, 202);
            this.txtGiaxuat.Name = "txtGiaxuat";
            this.txtGiaxuat.Size = new System.Drawing.Size(268, 22);
            this.txtGiaxuat.TabIndex = 11;
            this.txtGiaxuat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.keyPressEvent);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 208);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Giá xuất ";
            // 
            // txtGhichu
            // 
            this.txtGhichu.Location = new System.Drawing.Point(830, 65);
            this.txtGhichu.Multiline = true;
            this.txtGhichu.Name = "txtGhichu";
            this.txtGhichu.Size = new System.Drawing.Size(152, 163);
            this.txtGhichu.TabIndex = 22;
            this.txtGhichu.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbGhichu
            // 
            this.lbGhichu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbGhichu.AutoSize = true;
            this.lbGhichu.Location = new System.Drawing.Point(767, 68);
            this.lbGhichu.Name = "lbGhichu";
            this.lbGhichu.Size = new System.Drawing.Size(51, 16);
            this.lbGhichu.TabIndex = 21;
            this.lbGhichu.Text = "Ghi chú";
            // 
            // btnTimkiem
            // 
            this.btnTimkiem.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnTimkiem.Image = ((System.Drawing.Image)(resources.GetObject("btnTimkiem.Image")));
            this.btnTimkiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimkiem.Location = new System.Drawing.Point(1029, 129);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Size = new System.Drawing.Size(121, 43);
            this.btnTimkiem.TabIndex = 33;
            this.btnTimkiem.Text = "   Tìm kiếm";
            this.btnTimkiem.UseVisualStyleBackColor = true;
            this.btnTimkiem.Click += new System.EventHandler(this.btnTimkiem_Click);
            // 
            // btnHienthi
            // 
            this.btnHienthi.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnHienthi.Image = ((System.Drawing.Image)(resources.GetObject("btnHienthi.Image")));
            this.btnHienthi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHienthi.Location = new System.Drawing.Point(1029, 271);
            this.btnHienthi.Name = "btnHienthi";
            this.btnHienthi.Size = new System.Drawing.Size(121, 50);
            this.btnHienthi.TabIndex = 32;
            this.btnHienthi.Text = "   Hiển Thị DS";
            this.btnHienthi.UseVisualStyleBackColor = true;
            this.btnHienthi.Click += new System.EventHandler(this.btnHienthi_Click);
            // 
            // btnSua
            // 
            this.btnSua.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(51, 513);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(120, 43);
            this.btnSua.TabIndex = 31;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(51, 443);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(120, 43);
            this.btnXoa.TabIndex = 30;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(51, 367);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(120, 43);
            this.btnThem.TabIndex = 29;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label7.Location = new System.Drawing.Point(489, 124);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(309, 32);
            this.label7.TabIndex = 35;
            this.label7.Text = "QUẢN LÝ HÀNG HOÁ";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(1017, 86);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(139, 22);
            this.txtSearch.TabIndex = 36;
            // 
            // lbMaHangHoa
            // 
            this.lbMaHangHoa.AutoSize = true;
            this.lbMaHangHoa.BackColor = System.Drawing.Color.SeaGreen;
            this.lbMaHangHoa.Location = new System.Drawing.Point(1026, 66);
            this.lbMaHangHoa.Name = "lbMaHangHoa";
            this.lbMaHangHoa.Size = new System.Drawing.Size(117, 16);
            this.lbMaHangHoa.TabIndex = 39;
            this.lbMaHangHoa.Text = "Tìm Mã Hàng Hóa";
            // 
            // bntSave
            // 
            this.bntSave.Location = new System.Drawing.Point(1029, 347);
            this.bntSave.Name = "bntSave";
            this.bntSave.Size = new System.Drawing.Size(100, 55);
            this.bntSave.TabIndex = 40;
            this.bntSave.Text = "Save";
            this.bntSave.UseVisualStyleBackColor = true;
            this.bntSave.Click += new System.EventHandler(this.bntSave_Click);
            // 
            // bntExit
            // 
            this.bntExit.Location = new System.Drawing.Point(1027, 501);
            this.bntExit.Name = "bntExit";
            this.bntExit.Size = new System.Drawing.Size(100, 55);
            this.bntExit.TabIndex = 41;
            this.bntExit.Text = "Exit";
            this.bntExit.UseVisualStyleBackColor = true;
            this.bntExit.Click += new System.EventHandler(this.bntExit_Click);
            // 
            // dgvDshh
            // 
            this.dgvDshh.AllowUserToAddRows = false;
            this.dgvDshh.AllowUserToDeleteRows = false;
            this.dgvDshh.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvDshh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDshh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column8,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dgvDshh.Location = new System.Drawing.Point(198, 279);
            this.dgvDshh.Name = "dgvDshh";
            this.dgvDshh.ReadOnly = true;
            this.dgvDshh.RowHeadersWidth = 51;
            this.dgvDshh.RowTemplate.Height = 24;
            this.dgvDshh.Size = new System.Drawing.Size(752, 277);
            this.dgvDshh.TabIndex = 34;
            this.dgvDshh.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDshh_CellClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Ma";
            this.Column1.HeaderText = "Mã hàng hoá";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Ten";
            this.Column2.HeaderText = "Tên hàng hoá";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Loai";
            this.Column3.HeaderText = "Loại hàng hoá";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Soluongnhap";
            this.Column4.HeaderText = "Số lượng nhập";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 125;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "Soluongxuat";
            this.Column8.HeaderText = "Số lượng xuất";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 125;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Gianhap";
            this.Column5.HeaderText = "Giá nhập";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 125;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "Giaxuat";
            this.Column6.HeaderText = "Giá xuất";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 125;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "Ghichu";
            this.Column7.HeaderText = "Ghi chú";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 125;
            // 
            // txtSLxuat
            // 
            this.txtSLxuat.Location = new System.Drawing.Point(198, 146);
            this.txtSLxuat.Name = "txtSLxuat";
            this.txtSLxuat.Size = new System.Drawing.Size(268, 22);
            this.txtSLxuat.TabIndex = 43;
            this.txtSLxuat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.keyPressEvent);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 152);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 16);
            this.label8.TabIndex = 42;
            this.label8.Text = "Số lượng xuất";
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(1029, 431);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(100, 55);
            this.btnOpen.TabIndex = 44;
            this.btnOpen.Text = "ShowFile";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // picbClosePro
            // 
            this.picbClosePro.BackColor = System.Drawing.Color.Transparent;
            this.picbClosePro.FillColor = System.Drawing.SystemColors.Window;
            this.picbClosePro.Image = global::QuanLyBanHang.Properties.Resources.close;
            this.picbClosePro.ImageRotate = 0F;
            this.picbClosePro.Location = new System.Drawing.Point(1176, 9);
            this.picbClosePro.Margin = new System.Windows.Forms.Padding(4);
            this.picbClosePro.Name = "picbClosePro";
            this.picbClosePro.Size = new System.Drawing.Size(31, 28);
            this.picbClosePro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbClosePro.TabIndex = 45;
            this.picbClosePro.TabStop = false;
            this.picbClosePro.Click += new System.EventHandler(this.picbClosePro_Click);
            // 
            // frmProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(1219, 608);
            this.Controls.Add(this.picbClosePro);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.txtSLxuat);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.bntExit);
            this.Controls.Add(this.bntSave);
            this.Controls.Add(this.lbMaHangHoa);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dgvDshh);
            this.Controls.Add(this.btnTimkiem);
            this.Controls.Add(this.btnHienthi);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtGhichu);
            this.Controls.Add(this.lbGhichu);
            this.Controls.Add(this.txtGiaxuat);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbLoai);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtGianhap);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSLnhap);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMa);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmProduct";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDshh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbClosePro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMa;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSLnhap;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtGianhap;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbLoai;
        private System.Windows.Forms.TextBox txtGiaxuat;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtGhichu;
        private System.Windows.Forms.Label lbGhichu;
        private System.Windows.Forms.Button btnTimkiem;
        private System.Windows.Forms.Button btnHienthi;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lbMaHangHoa;
        private System.Windows.Forms.Button bntSave;
        private System.Windows.Forms.Button bntExit;
        private System.Windows.Forms.DataGridView dgvDshh;
        private System.Windows.Forms.TextBox txtSLxuat;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.Button btnOpen;
        private Guna.UI2.WinForms.Guna2PictureBox picbClosePro;
    }
}

