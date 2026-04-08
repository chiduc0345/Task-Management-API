namespace TaskManagerUI
{
    partial class Form1
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
            this.datetimenow = new System.Windows.Forms.DateTimePicker();
            this.cboloc = new System.Windows.Forms.ComboBox();
            this.chckTrangThai = new System.Windows.Forms.CheckBox();
            this.dgvListCongViec = new System.Windows.Forms.DataGridView();
            this.dattimeHanChot = new System.Windows.Forms.DateTimePicker();
            this.cboLoaiCongViec = new System.Windows.Forms.ComboBox();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.txtLuu = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.txtTenCongViec = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListCongViec)).BeginInit();
            this.SuspendLayout();
            // 
            // datetimenow
            // 
            this.datetimenow.Font = new System.Drawing.Font("Cascadia Code", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datetimenow.Location = new System.Drawing.Point(534, 16);
            this.datetimenow.Name = "datetimenow";
            this.datetimenow.Size = new System.Drawing.Size(226, 23);
            this.datetimenow.TabIndex = 44;
            // 
            // cboloc
            // 
            this.cboloc.FormattingEnabled = true;
            this.cboloc.Items.AddRange(new object[] {
            "Việc nhà",
            "Deadline",
            "Chiện lớn",
            "Lụm tiền",
            "Khác",
            "Việc học",
            "Tất cả"});
            this.cboloc.Location = new System.Drawing.Point(41, 245);
            this.cboloc.Name = "cboloc";
            this.cboloc.Size = new System.Drawing.Size(115, 24);
            this.cboloc.TabIndex = 43;
            this.cboloc.SelectedIndexChanged += new System.EventHandler(this.cboloc_SelectedIndexChanged);
            // 
            // chckTrangThai
            // 
            this.chckTrangThai.AutoSize = true;
            this.chckTrangThai.Location = new System.Drawing.Point(569, 122);
            this.chckTrangThai.Name = "chckTrangThai";
            this.chckTrangThai.Size = new System.Drawing.Size(32, 20);
            this.chckTrangThai.TabIndex = 42;
            this.chckTrangThai.Text = " ";
            this.chckTrangThai.UseVisualStyleBackColor = true;
            // 
            // dgvListCongViec
            // 
            this.dgvListCongViec.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListCongViec.Location = new System.Drawing.Point(42, 270);
            this.dgvListCongViec.Name = "dgvListCongViec";
            this.dgvListCongViec.RowHeadersWidth = 51;
            this.dgvListCongViec.RowTemplate.Height = 24;
            this.dgvListCongViec.Size = new System.Drawing.Size(706, 210);
            this.dgvListCongViec.TabIndex = 41;
            this.dgvListCongViec.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListCongViec_CellClick);
            this.dgvListCongViec.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListCongViec_CellContentClick);
            // 
            // dattimeHanChot
            // 
            this.dattimeHanChot.Location = new System.Drawing.Point(279, 197);
            this.dattimeHanChot.Name = "dattimeHanChot";
            this.dattimeHanChot.Size = new System.Drawing.Size(256, 22);
            this.dattimeHanChot.TabIndex = 40;
            // 
            // cboLoaiCongViec
            // 
            this.cboLoaiCongViec.FormattingEnabled = true;
            this.cboLoaiCongViec.Items.AddRange(new object[] {
            "Việc nhà",
            "Deadline",
            "Chiện lớn",
            "Lụm tiền",
            "Khác",
            "Việc học"});
            this.cboLoaiCongViec.Location = new System.Drawing.Point(279, 158);
            this.cboLoaiCongViec.Name = "cboLoaiCongViec";
            this.cboLoaiCongViec.Size = new System.Drawing.Size(256, 24);
            this.cboLoaiCongViec.TabIndex = 39;
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(375, 239);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 36;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(279, 239);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 37;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // txtLuu
            // 
            this.txtLuu.Location = new System.Drawing.Point(470, 239);
            this.txtLuu.Name = "txtLuu";
            this.txtLuu.Size = new System.Drawing.Size(75, 23);
            this.txtLuu.TabIndex = 38;
            this.txtLuu.Text = "Lưu";
            this.txtLuu.UseVisualStyleBackColor = true;
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Location = new System.Drawing.Point(606, 158);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(81, 45);
            this.btnLamMoi.TabIndex = 35;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(184, 239);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 34;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label4.Location = new System.Drawing.Point(162, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 30;
            this.label4.Text = "Hạn chót:";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(619, 242);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(119, 22);
            this.txtTimKiem.TabIndex = 33;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // txtTenCongViec
            // 
            this.txtTenCongViec.Location = new System.Drawing.Point(279, 120);
            this.txtTenCongViec.Name = "txtTenCongViec";
            this.txtTenCongViec.Size = new System.Drawing.Size(256, 22);
            this.txtTenCongViec.TabIndex = 32;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label3.Location = new System.Drawing.Point(162, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 17);
            this.label3.TabIndex = 29;
            this.label3.Text = "Loại công việc";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkOrange;
            this.label2.Location = new System.Drawing.Point(155, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(428, 38);
            this.label2.TabIndex = 28;
            this.label2.Text = "Quản lý công việc cá nhân";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label6.Location = new System.Drawing.Point(162, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 17);
            this.label6.TabIndex = 31;
            this.label6.Text = "Tên công việc";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label1.Location = new System.Drawing.Point(556, 245);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 17);
            this.label1.TabIndex = 27;
            this.label1.Text = "Search:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 513);
            this.Controls.Add(this.datetimenow);
            this.Controls.Add(this.cboloc);
            this.Controls.Add(this.chckTrangThai);
            this.Controls.Add(this.dgvListCongViec);
            this.Controls.Add(this.dattimeHanChot);
            this.Controls.Add(this.cboLoaiCongViec);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.txtLuu);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.txtTenCongViec);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListCongViec)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker datetimenow;
        private System.Windows.Forms.ComboBox cboloc;
        private System.Windows.Forms.CheckBox chckTrangThai;
        private System.Windows.Forms.DataGridView dgvListCongViec;
        private System.Windows.Forms.DateTimePicker dattimeHanChot;
        private System.Windows.Forms.ComboBox cboLoaiCongViec;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button txtLuu;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.TextBox txtTenCongViec;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
    }
}

