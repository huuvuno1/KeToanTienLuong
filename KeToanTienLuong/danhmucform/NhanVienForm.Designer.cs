
namespace KeToanTienLuong.danhmucform
{
    partial class NhanVienForm
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.manvDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenvDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaysinhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diachiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.masothueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioitinhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.macvDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mabpDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bangcapDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trinhdoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.songuoiphuthuocDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trangthaiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.luongcobanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dmnvBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.ketoantienluongDataSet = new KeToanTienLuong.ketoantienluongDataSet();
            this.dmnvBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ketoantienluongDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inpDiaChi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.inpNgaySinh = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.inpTen = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.inpMa = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.inpTrinhDo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.inpLuongCoban = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.inpBangCap = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.inpMaSoThue = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBoxDMBP = new System.Windows.Forms.ComboBox();
            this.comboBoxChucVu = new System.Windows.Forms.ComboBox();
            this.dmnvTableAdapter = new KeToanTienLuong.ketoantienluongDataSetTableAdapters.dmnvTableAdapter();
            this.inpPhuThuoc = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.buttonHuy = new System.Windows.Forms.Button();
            this.buttonLuu = new System.Windows.Forms.Button();
            this.buttonXoa = new System.Windows.Forms.Button();
            this.buttonSua = new System.Windows.Forms.Button();
            this.buttonThem = new System.Windows.Forms.Button();
            this.comboBoxGioiTinh = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dmnvBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ketoantienluongDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dmnvBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ketoantienluongDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.manvDataGridViewTextBoxColumn,
            this.tenvDataGridViewTextBoxColumn,
            this.ngaysinhDataGridViewTextBoxColumn,
            this.diachiDataGridViewTextBoxColumn,
            this.masothueDataGridViewTextBoxColumn,
            this.gioitinhDataGridViewTextBoxColumn,
            this.macvDataGridViewTextBoxColumn,
            this.mabpDataGridViewTextBoxColumn,
            this.bangcapDataGridViewTextBoxColumn,
            this.trinhdoDataGridViewTextBoxColumn,
            this.songuoiphuthuocDataGridViewTextBoxColumn,
            this.trangthaiDataGridViewTextBoxColumn,
            this.luongcobanDataGridViewTextBoxColumn});
            this.dataGridView.DataSource = this.dmnvBindingSource1;
            this.dataGridView.Location = new System.Drawing.Point(0, 350);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(1285, 307);
            this.dataGridView.TabIndex = 47;
            this.dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cellClick);
            // 
            // manvDataGridViewTextBoxColumn
            // 
            this.manvDataGridViewTextBoxColumn.DataPropertyName = "manv";
            this.manvDataGridViewTextBoxColumn.HeaderText = "Mã nhân viên";
            this.manvDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.manvDataGridViewTextBoxColumn.Name = "manvDataGridViewTextBoxColumn";
            this.manvDataGridViewTextBoxColumn.Width = 125;
            // 
            // tenvDataGridViewTextBoxColumn
            // 
            this.tenvDataGridViewTextBoxColumn.DataPropertyName = "tenv";
            this.tenvDataGridViewTextBoxColumn.HeaderText = "Tên nhân viên";
            this.tenvDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tenvDataGridViewTextBoxColumn.Name = "tenvDataGridViewTextBoxColumn";
            this.tenvDataGridViewTextBoxColumn.Width = 125;
            // 
            // ngaysinhDataGridViewTextBoxColumn
            // 
            this.ngaysinhDataGridViewTextBoxColumn.DataPropertyName = "ngaysinh";
            this.ngaysinhDataGridViewTextBoxColumn.HeaderText = "Ngày sinh";
            this.ngaysinhDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ngaysinhDataGridViewTextBoxColumn.Name = "ngaysinhDataGridViewTextBoxColumn";
            this.ngaysinhDataGridViewTextBoxColumn.Width = 125;
            // 
            // diachiDataGridViewTextBoxColumn
            // 
            this.diachiDataGridViewTextBoxColumn.DataPropertyName = "diachi";
            this.diachiDataGridViewTextBoxColumn.HeaderText = "Địa chỉ";
            this.diachiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.diachiDataGridViewTextBoxColumn.Name = "diachiDataGridViewTextBoxColumn";
            this.diachiDataGridViewTextBoxColumn.Width = 125;
            // 
            // masothueDataGridViewTextBoxColumn
            // 
            this.masothueDataGridViewTextBoxColumn.DataPropertyName = "masothue";
            this.masothueDataGridViewTextBoxColumn.HeaderText = "Mã số thuế";
            this.masothueDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.masothueDataGridViewTextBoxColumn.Name = "masothueDataGridViewTextBoxColumn";
            this.masothueDataGridViewTextBoxColumn.Width = 125;
            // 
            // gioitinhDataGridViewTextBoxColumn
            // 
            this.gioitinhDataGridViewTextBoxColumn.DataPropertyName = "gioitinh";
            this.gioitinhDataGridViewTextBoxColumn.HeaderText = "Giới tính";
            this.gioitinhDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.gioitinhDataGridViewTextBoxColumn.Name = "gioitinhDataGridViewTextBoxColumn";
            this.gioitinhDataGridViewTextBoxColumn.Width = 125;
            // 
            // macvDataGridViewTextBoxColumn
            // 
            this.macvDataGridViewTextBoxColumn.DataPropertyName = "macv";
            this.macvDataGridViewTextBoxColumn.HeaderText = "Mã chức vụ";
            this.macvDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.macvDataGridViewTextBoxColumn.Name = "macvDataGridViewTextBoxColumn";
            this.macvDataGridViewTextBoxColumn.Width = 125;
            // 
            // mabpDataGridViewTextBoxColumn
            // 
            this.mabpDataGridViewTextBoxColumn.DataPropertyName = "mabp";
            this.mabpDataGridViewTextBoxColumn.HeaderText = "Mã bộ phận";
            this.mabpDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mabpDataGridViewTextBoxColumn.Name = "mabpDataGridViewTextBoxColumn";
            this.mabpDataGridViewTextBoxColumn.Width = 125;
            // 
            // bangcapDataGridViewTextBoxColumn
            // 
            this.bangcapDataGridViewTextBoxColumn.DataPropertyName = "bangcap";
            this.bangcapDataGridViewTextBoxColumn.HeaderText = "Bằng cấp";
            this.bangcapDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bangcapDataGridViewTextBoxColumn.Name = "bangcapDataGridViewTextBoxColumn";
            this.bangcapDataGridViewTextBoxColumn.Width = 125;
            // 
            // trinhdoDataGridViewTextBoxColumn
            // 
            this.trinhdoDataGridViewTextBoxColumn.DataPropertyName = "trinhdo";
            this.trinhdoDataGridViewTextBoxColumn.HeaderText = "Trình độ";
            this.trinhdoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.trinhdoDataGridViewTextBoxColumn.Name = "trinhdoDataGridViewTextBoxColumn";
            this.trinhdoDataGridViewTextBoxColumn.Width = 125;
            // 
            // songuoiphuthuocDataGridViewTextBoxColumn
            // 
            this.songuoiphuthuocDataGridViewTextBoxColumn.DataPropertyName = "songuoiphuthuoc";
            this.songuoiphuthuocDataGridViewTextBoxColumn.HeaderText = "Số người phụ thuộc";
            this.songuoiphuthuocDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.songuoiphuthuocDataGridViewTextBoxColumn.Name = "songuoiphuthuocDataGridViewTextBoxColumn";
            this.songuoiphuthuocDataGridViewTextBoxColumn.Width = 125;
            // 
            // trangthaiDataGridViewTextBoxColumn
            // 
            this.trangthaiDataGridViewTextBoxColumn.DataPropertyName = "trangthai";
            this.trangthaiDataGridViewTextBoxColumn.HeaderText = "Trạng thái";
            this.trangthaiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.trangthaiDataGridViewTextBoxColumn.Name = "trangthaiDataGridViewTextBoxColumn";
            this.trangthaiDataGridViewTextBoxColumn.Width = 125;
            // 
            // luongcobanDataGridViewTextBoxColumn
            // 
            this.luongcobanDataGridViewTextBoxColumn.DataPropertyName = "luongcoban";
            this.luongcobanDataGridViewTextBoxColumn.HeaderText = "Lương cơ bản";
            this.luongcobanDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.luongcobanDataGridViewTextBoxColumn.Name = "luongcobanDataGridViewTextBoxColumn";
            this.luongcobanDataGridViewTextBoxColumn.Width = 125;
            // 
            // dmnvBindingSource1
            // 
            this.dmnvBindingSource1.DataMember = "dmnv";
            this.dmnvBindingSource1.DataSource = this.ketoantienluongDataSet;
            // 
            // ketoantienluongDataSet
            // 
            this.ketoantienluongDataSet.DataSetName = "ketoantienluongDataSet";
            this.ketoantienluongDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dmnvBindingSource
            // 
            this.dmnvBindingSource.DataMember = "dmnv";
            this.dmnvBindingSource.DataSource = this.ketoantienluongDataSet;
            // 
            // ketoantienluongDataSetBindingSource
            // 
            this.ketoantienluongDataSetBindingSource.DataSource = this.ketoantienluongDataSet;
            this.ketoantienluongDataSetBindingSource.Position = 0;
            // 
            // inpDiaChi
            // 
            this.inpDiaChi.Enabled = false;
            this.inpDiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inpDiaChi.Location = new System.Drawing.Point(253, 191);
            this.inpDiaChi.Name = "inpDiaChi";
            this.inpDiaChi.Size = new System.Drawing.Size(336, 27);
            this.inpDiaChi.TabIndex = 46;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(37, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 20);
            this.label4.TabIndex = 41;
            this.label4.Text = "Địa chỉ";
            // 
            // inpNgaySinh
            // 
            this.inpNgaySinh.Enabled = false;
            this.inpNgaySinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inpNgaySinh.Location = new System.Drawing.Point(253, 137);
            this.inpNgaySinh.Name = "inpNgaySinh";
            this.inpNgaySinh.Size = new System.Drawing.Size(336, 27);
            this.inpNgaySinh.TabIndex = 40;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 20);
            this.label2.TabIndex = 39;
            this.label2.Text = "Ngày sinh";
            // 
            // inpTen
            // 
            this.inpTen.Enabled = false;
            this.inpTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inpTen.Location = new System.Drawing.Point(253, 77);
            this.inpTen.Name = "inpTen";
            this.inpTen.Size = new System.Drawing.Size(336, 27);
            this.inpTen.TabIndex = 38;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 20);
            this.label1.TabIndex = 37;
            this.label1.Text = "Tên nhân viên";
            // 
            // inpMa
            // 
            this.inpMa.Enabled = false;
            this.inpMa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inpMa.Location = new System.Drawing.Point(253, 24);
            this.inpMa.Name = "inpMa";
            this.inpMa.Size = new System.Drawing.Size(336, 27);
            this.inpMa.TabIndex = 36;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(37, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 20);
            this.label3.TabIndex = 35;
            this.label3.Text = "Mã nhân viên";
            // 
            // inpTrinhDo
            // 
            this.inpTrinhDo.Enabled = false;
            this.inpTrinhDo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inpTrinhDo.Location = new System.Drawing.Point(253, 247);
            this.inpTrinhDo.Name = "inpTrinhDo";
            this.inpTrinhDo.Size = new System.Drawing.Size(336, 27);
            this.inpTrinhDo.TabIndex = 49;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(37, 250);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 20);
            this.label5.TabIndex = 48;
            this.label5.Text = "Trình độ";
            // 
            // inpLuongCoban
            // 
            this.inpLuongCoban.Enabled = false;
            this.inpLuongCoban.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inpLuongCoban.Location = new System.Drawing.Point(916, 247);
            this.inpLuongCoban.Name = "inpLuongCoban";
            this.inpLuongCoban.Size = new System.Drawing.Size(336, 27);
            this.inpLuongCoban.TabIndex = 59;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(727, 250);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 20);
            this.label6.TabIndex = 58;
            this.label6.Text = "Lương cơ bản";
            // 
            // inpBangCap
            // 
            this.inpBangCap.Enabled = false;
            this.inpBangCap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inpBangCap.Location = new System.Drawing.Point(916, 191);
            this.inpBangCap.Name = "inpBangCap";
            this.inpBangCap.Size = new System.Drawing.Size(336, 27);
            this.inpBangCap.TabIndex = 57;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(727, 194);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 20);
            this.label7.TabIndex = 56;
            this.label7.Text = "Bằng cấp";
            // 
            // inpMaSoThue
            // 
            this.inpMaSoThue.Enabled = false;
            this.inpMaSoThue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inpMaSoThue.Location = new System.Drawing.Point(916, 137);
            this.inpMaSoThue.Name = "inpMaSoThue";
            this.inpMaSoThue.Size = new System.Drawing.Size(336, 27);
            this.inpMaSoThue.TabIndex = 55;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(727, 140);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 20);
            this.label8.TabIndex = 54;
            this.label8.Text = "Mã số thuế";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(727, 80);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 20);
            this.label9.TabIndex = 52;
            this.label9.Text = "Chức vụ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(727, 27);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 20);
            this.label10.TabIndex = 50;
            this.label10.Text = "Bộ phận";
            // 
            // comboBoxDMBP
            // 
            this.comboBoxDMBP.Enabled = false;
            this.comboBoxDMBP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxDMBP.FormattingEnabled = true;
            this.comboBoxDMBP.Items.AddRange(new object[] {
            "Admin",
            "Kế toán"});
            this.comboBoxDMBP.Location = new System.Drawing.Point(916, 24);
            this.comboBoxDMBP.Name = "comboBoxDMBP";
            this.comboBoxDMBP.Size = new System.Drawing.Size(336, 28);
            this.comboBoxDMBP.TabIndex = 60;
            this.comboBoxDMBP.SelectedIndexChanged += new System.EventHandler(this.comboBoxDMBP_SelectedIndexChanged);
            // 
            // comboBoxChucVu
            // 
            this.comboBoxChucVu.Enabled = false;
            this.comboBoxChucVu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxChucVu.FormattingEnabled = true;
            this.comboBoxChucVu.Items.AddRange(new object[] {
            "Admin",
            "Kế toán"});
            this.comboBoxChucVu.Location = new System.Drawing.Point(916, 77);
            this.comboBoxChucVu.Name = "comboBoxChucVu";
            this.comboBoxChucVu.Size = new System.Drawing.Size(336, 28);
            this.comboBoxChucVu.TabIndex = 61;
            // 
            // dmnvTableAdapter
            // 
            this.dmnvTableAdapter.ClearBeforeFill = true;
            // 
            // inpPhuThuoc
            // 
            this.inpPhuThuoc.Enabled = false;
            this.inpPhuThuoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inpPhuThuoc.Location = new System.Drawing.Point(253, 297);
            this.inpPhuThuoc.Name = "inpPhuThuoc";
            this.inpPhuThuoc.Size = new System.Drawing.Size(336, 27);
            this.inpPhuThuoc.TabIndex = 63;
            this.inpPhuThuoc.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(37, 300);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(180, 20);
            this.label11.TabIndex = 62;
            this.label11.Text = "Số người phục thuộc";
            // 
            // buttonHuy
            // 
            this.buttonHuy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHuy.Image = global::KeToanTienLuong.Properties.Resources.cancelled;
            this.buttonHuy.Location = new System.Drawing.Point(553, 685);
            this.buttonHuy.Name = "buttonHuy";
            this.buttonHuy.Size = new System.Drawing.Size(170, 42);
            this.buttonHuy.TabIndex = 68;
            this.buttonHuy.Text = "   Hủy";
            this.buttonHuy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonHuy.UseVisualStyleBackColor = true;
            this.buttonHuy.Click += new System.EventHandler(this.buttonHuy_Click);
            // 
            // buttonLuu
            // 
            this.buttonLuu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLuu.Image = global::KeToanTienLuong.Properties.Resources.checkmark;
            this.buttonLuu.Location = new System.Drawing.Point(299, 685);
            this.buttonLuu.Name = "buttonLuu";
            this.buttonLuu.Size = new System.Drawing.Size(193, 42);
            this.buttonLuu.TabIndex = 67;
            this.buttonLuu.Text = "   Lưu";
            this.buttonLuu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonLuu.UseVisualStyleBackColor = true;
            this.buttonLuu.Click += new System.EventHandler(this.buttonLuu_Click_1);
            // 
            // buttonXoa
            // 
            this.buttonXoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonXoa.Image = global::KeToanTienLuong.Properties.Resources.delete;
            this.buttonXoa.Location = new System.Drawing.Point(998, 685);
            this.buttonXoa.Name = "buttonXoa";
            this.buttonXoa.Size = new System.Drawing.Size(170, 42);
            this.buttonXoa.TabIndex = 66;
            this.buttonXoa.Text = "   Xóa";
            this.buttonXoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonXoa.UseVisualStyleBackColor = true;
            this.buttonXoa.Click += new System.EventHandler(this.buttonXoa_Click);
            // 
            // buttonSua
            // 
            this.buttonSua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSua.Image = global::KeToanTienLuong.Properties.Resources.pencil;
            this.buttonSua.Location = new System.Drawing.Point(771, 685);
            this.buttonSua.Name = "buttonSua";
            this.buttonSua.Size = new System.Drawing.Size(174, 42);
            this.buttonSua.TabIndex = 65;
            this.buttonSua.Text = "   Sửa";
            this.buttonSua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonSua.UseVisualStyleBackColor = true;
            this.buttonSua.Click += new System.EventHandler(this.buttonSua_Click);
            // 
            // buttonThem
            // 
            this.buttonThem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonThem.Image = global::KeToanTienLuong.Properties.Resources.plus;
            this.buttonThem.Location = new System.Drawing.Point(76, 685);
            this.buttonThem.Name = "buttonThem";
            this.buttonThem.Size = new System.Drawing.Size(148, 42);
            this.buttonThem.TabIndex = 64;
            this.buttonThem.Text = "  Thêm";
            this.buttonThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonThem.UseVisualStyleBackColor = true;
            this.buttonThem.Click += new System.EventHandler(this.buttonThem_Click_1);
            // 
            // comboBoxGioiTinh
            // 
            this.comboBoxGioiTinh.Enabled = false;
            this.comboBoxGioiTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxGioiTinh.FormattingEnabled = true;
            this.comboBoxGioiTinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.comboBoxGioiTinh.Location = new System.Drawing.Point(916, 297);
            this.comboBoxGioiTinh.Name = "comboBoxGioiTinh";
            this.comboBoxGioiTinh.Size = new System.Drawing.Size(336, 28);
            this.comboBoxGioiTinh.TabIndex = 70;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(727, 300);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(80, 20);
            this.label12.TabIndex = 69;
            this.label12.Text = "Giới tính";
            // 
            // NhanVienForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.comboBoxGioiTinh);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.buttonHuy);
            this.Controls.Add(this.buttonLuu);
            this.Controls.Add(this.buttonXoa);
            this.Controls.Add(this.buttonSua);
            this.Controls.Add(this.buttonThem);
            this.Controls.Add(this.inpPhuThuoc);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.comboBoxChucVu);
            this.Controls.Add(this.comboBoxDMBP);
            this.Controls.Add(this.inpLuongCoban);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.inpBangCap);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.inpMaSoThue);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.inpTrinhDo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.inpDiaChi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.inpNgaySinh);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.inpTen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inpMa);
            this.Controls.Add(this.label3);
            this.Name = "NhanVienForm";
            this.Size = new System.Drawing.Size(1285, 784);
            this.Load += new System.EventHandler(this.NhanVienForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dmnvBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ketoantienluongDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dmnvBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ketoantienluongDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.TextBox inpDiaChi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox inpNgaySinh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox inpTen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox inpMa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox inpTrinhDo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox inpLuongCoban;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox inpBangCap;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox inpMaSoThue;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBoxDMBP;
        private System.Windows.Forms.ComboBox comboBoxChucVu;
        private System.Windows.Forms.BindingSource ketoantienluongDataSetBindingSource;
        private ketoantienluongDataSet ketoantienluongDataSet;
        private System.Windows.Forms.BindingSource dmnvBindingSource;
        private ketoantienluongDataSetTableAdapters.dmnvTableAdapter dmnvTableAdapter;
        private System.Windows.Forms.TextBox inpPhuThuoc;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridViewTextBoxColumn mablDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hesoluongDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn manvDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenvDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaysinhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diachiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn masothueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioitinhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn macvDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mabpDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bangcapDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn trinhdoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn songuoiphuthuocDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn trangthaiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn luongcobanDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource dmnvBindingSource1;
        private System.Windows.Forms.Button buttonHuy;
        private System.Windows.Forms.Button buttonLuu;
        private System.Windows.Forms.Button buttonXoa;
        private System.Windows.Forms.Button buttonSua;
        private System.Windows.Forms.Button buttonThem;
        private System.Windows.Forms.ComboBox comboBoxGioiTinh;
        private System.Windows.Forms.Label label12;
    }
}
