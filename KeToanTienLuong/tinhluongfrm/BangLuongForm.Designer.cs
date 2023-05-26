
namespace KeToanTienLuong.tinhluongfrm
{
    partial class BangLuongForm
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
            this.dataGridViewBangLuong = new System.Windows.Forms.DataGridView();
            this.manvDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenvDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaysinhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noidungDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaycongcuathangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaycongthucteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tienluongcobanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.luongtheongaycongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phucapantrueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tienthuongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phucapkhacDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tienphatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tienphucapDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tienbhxhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tienbhtnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tienbhytDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giamtrucanhanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giamtruphuthuocDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tientruocthueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tienthueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tonggiamtruDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tongbaohiemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tientamungDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tienthuclinhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.layBangLuongFullBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ketoantienluongDataSet = new KeToanTienLuong.ketoantienluongDataSet();
            this.bangcongchititietcustomBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bangcongchititietcustomTableAdapter = new KeToanTienLuong.ketoantienluongDataSetTableAdapters.bangcongchititietcustomTableAdapter();
            this.buttonLookup = new System.Windows.Forms.Button();
            this.labelNam = new System.Windows.Forms.Label();
            this.labelThang = new System.Windows.Forms.Label();
            this.layBangLuongFullTableAdapter = new KeToanTienLuong.ketoantienluongDataSetTableAdapters.LayBangLuongFullTableAdapter();
            this.comboBoxThang = new System.Windows.Forms.ComboBox();
            this.comboBoxNam = new System.Windows.Forms.ComboBox();
            this.buttonUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBangLuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layBangLuongFullBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ketoantienluongDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bangcongchititietcustomBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewBangLuong
            // 
            this.dataGridViewBangLuong.AutoGenerateColumns = false;
            this.dataGridViewBangLuong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBangLuong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.manvDataGridViewTextBoxColumn,
            this.tenvDataGridViewTextBoxColumn,
            this.ngaysinhDataGridViewTextBoxColumn,
            this.namDataGridViewTextBoxColumn,
            this.thangDataGridViewTextBoxColumn,
            this.noidungDataGridViewTextBoxColumn,
            this.ngaycongcuathangDataGridViewTextBoxColumn,
            this.ngaycongthucteDataGridViewTextBoxColumn,
            this.tienluongcobanDataGridViewTextBoxColumn,
            this.luongtheongaycongDataGridViewTextBoxColumn,
            this.phucapantrueDataGridViewTextBoxColumn,
            this.tienthuongDataGridViewTextBoxColumn,
            this.phucapkhacDataGridViewTextBoxColumn,
            this.tienphatDataGridViewTextBoxColumn,
            this.tienphucapDataGridViewTextBoxColumn,
            this.tienbhxhDataGridViewTextBoxColumn,
            this.tienbhtnDataGridViewTextBoxColumn,
            this.tienbhytDataGridViewTextBoxColumn,
            this.giamtrucanhanDataGridViewTextBoxColumn,
            this.giamtruphuthuocDataGridViewTextBoxColumn,
            this.tientruocthueDataGridViewTextBoxColumn,
            this.tienthueDataGridViewTextBoxColumn,
            this.tonggiamtruDataGridViewTextBoxColumn,
            this.tongbaohiemDataGridViewTextBoxColumn,
            this.tientamungDataGridViewTextBoxColumn,
            this.tienthuclinhDataGridViewTextBoxColumn});
            this.dataGridViewBangLuong.DataSource = this.layBangLuongFullBindingSource;
            this.dataGridViewBangLuong.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridViewBangLuong.Location = new System.Drawing.Point(0, 222);
            this.dataGridViewBangLuong.Name = "dataGridViewBangLuong";
            this.dataGridViewBangLuong.RowHeadersWidth = 51;
            this.dataGridViewBangLuong.RowTemplate.Height = 24;
            this.dataGridViewBangLuong.Size = new System.Drawing.Size(1113, 443);
            this.dataGridViewBangLuong.TabIndex = 0;
            this.dataGridViewBangLuong.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewBangLuong_CellContentClick);
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
            // namDataGridViewTextBoxColumn
            // 
            this.namDataGridViewTextBoxColumn.DataPropertyName = "nam";
            this.namDataGridViewTextBoxColumn.HeaderText = "Năm";
            this.namDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.namDataGridViewTextBoxColumn.Name = "namDataGridViewTextBoxColumn";
            this.namDataGridViewTextBoxColumn.Width = 125;
            // 
            // thangDataGridViewTextBoxColumn
            // 
            this.thangDataGridViewTextBoxColumn.DataPropertyName = "thang";
            this.thangDataGridViewTextBoxColumn.HeaderText = "Tháng";
            this.thangDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.thangDataGridViewTextBoxColumn.Name = "thangDataGridViewTextBoxColumn";
            this.thangDataGridViewTextBoxColumn.Width = 125;
            // 
            // noidungDataGridViewTextBoxColumn
            // 
            this.noidungDataGridViewTextBoxColumn.DataPropertyName = "noidung";
            this.noidungDataGridViewTextBoxColumn.HeaderText = "Nội dung";
            this.noidungDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.noidungDataGridViewTextBoxColumn.Name = "noidungDataGridViewTextBoxColumn";
            this.noidungDataGridViewTextBoxColumn.Width = 125;
            // 
            // ngaycongcuathangDataGridViewTextBoxColumn
            // 
            this.ngaycongcuathangDataGridViewTextBoxColumn.DataPropertyName = "ngaycongcuathang";
            this.ngaycongcuathangDataGridViewTextBoxColumn.HeaderText = "Ngày công của tháng";
            this.ngaycongcuathangDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ngaycongcuathangDataGridViewTextBoxColumn.Name = "ngaycongcuathangDataGridViewTextBoxColumn";
            this.ngaycongcuathangDataGridViewTextBoxColumn.Width = 125;
            // 
            // ngaycongthucteDataGridViewTextBoxColumn
            // 
            this.ngaycongthucteDataGridViewTextBoxColumn.DataPropertyName = "ngaycongthucte";
            this.ngaycongthucteDataGridViewTextBoxColumn.HeaderText = "Ngày công thực tế";
            this.ngaycongthucteDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ngaycongthucteDataGridViewTextBoxColumn.Name = "ngaycongthucteDataGridViewTextBoxColumn";
            this.ngaycongthucteDataGridViewTextBoxColumn.Width = 125;
            // 
            // tienluongcobanDataGridViewTextBoxColumn
            // 
            this.tienluongcobanDataGridViewTextBoxColumn.DataPropertyName = "tienluongcoban";
            this.tienluongcobanDataGridViewTextBoxColumn.HeaderText = "Tiền lương cơ bản";
            this.tienluongcobanDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tienluongcobanDataGridViewTextBoxColumn.Name = "tienluongcobanDataGridViewTextBoxColumn";
            this.tienluongcobanDataGridViewTextBoxColumn.Width = 125;
            // 
            // luongtheongaycongDataGridViewTextBoxColumn
            // 
            this.luongtheongaycongDataGridViewTextBoxColumn.DataPropertyName = "luongtheongaycong";
            this.luongtheongaycongDataGridViewTextBoxColumn.HeaderText = "Lương theo ngày công";
            this.luongtheongaycongDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.luongtheongaycongDataGridViewTextBoxColumn.Name = "luongtheongaycongDataGridViewTextBoxColumn";
            this.luongtheongaycongDataGridViewTextBoxColumn.Width = 125;
            // 
            // phucapantrueDataGridViewTextBoxColumn
            // 
            this.phucapantrueDataGridViewTextBoxColumn.DataPropertyName = "phucapantrue";
            this.phucapantrueDataGridViewTextBoxColumn.HeaderText = "Phụ cấp ăn trưa";
            this.phucapantrueDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.phucapantrueDataGridViewTextBoxColumn.Name = "phucapantrueDataGridViewTextBoxColumn";
            this.phucapantrueDataGridViewTextBoxColumn.Width = 125;
            // 
            // tienthuongDataGridViewTextBoxColumn
            // 
            this.tienthuongDataGridViewTextBoxColumn.DataPropertyName = "tienthuong";
            this.tienthuongDataGridViewTextBoxColumn.HeaderText = "Tiền thưởng";
            this.tienthuongDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tienthuongDataGridViewTextBoxColumn.Name = "tienthuongDataGridViewTextBoxColumn";
            this.tienthuongDataGridViewTextBoxColumn.Width = 125;
            // 
            // phucapkhacDataGridViewTextBoxColumn
            // 
            this.phucapkhacDataGridViewTextBoxColumn.DataPropertyName = "phucapkhac";
            this.phucapkhacDataGridViewTextBoxColumn.HeaderText = "Phụ cấp khác";
            this.phucapkhacDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.phucapkhacDataGridViewTextBoxColumn.Name = "phucapkhacDataGridViewTextBoxColumn";
            this.phucapkhacDataGridViewTextBoxColumn.Width = 125;
            // 
            // tienphatDataGridViewTextBoxColumn
            // 
            this.tienphatDataGridViewTextBoxColumn.DataPropertyName = "tienphat";
            this.tienphatDataGridViewTextBoxColumn.HeaderText = "Tiền phạt";
            this.tienphatDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tienphatDataGridViewTextBoxColumn.Name = "tienphatDataGridViewTextBoxColumn";
            this.tienphatDataGridViewTextBoxColumn.Width = 125;
            // 
            // tienphucapDataGridViewTextBoxColumn
            // 
            this.tienphucapDataGridViewTextBoxColumn.DataPropertyName = "tienphucap";
            this.tienphucapDataGridViewTextBoxColumn.HeaderText = "Tiền phụ cấp";
            this.tienphucapDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tienphucapDataGridViewTextBoxColumn.Name = "tienphucapDataGridViewTextBoxColumn";
            this.tienphucapDataGridViewTextBoxColumn.Width = 125;
            // 
            // tienbhxhDataGridViewTextBoxColumn
            // 
            this.tienbhxhDataGridViewTextBoxColumn.DataPropertyName = "tienbhxh";
            this.tienbhxhDataGridViewTextBoxColumn.HeaderText = "Tiền BHXH";
            this.tienbhxhDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tienbhxhDataGridViewTextBoxColumn.Name = "tienbhxhDataGridViewTextBoxColumn";
            this.tienbhxhDataGridViewTextBoxColumn.Width = 125;
            // 
            // tienbhtnDataGridViewTextBoxColumn
            // 
            this.tienbhtnDataGridViewTextBoxColumn.DataPropertyName = "tienbhtn";
            this.tienbhtnDataGridViewTextBoxColumn.HeaderText = "Tiền BHTN";
            this.tienbhtnDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tienbhtnDataGridViewTextBoxColumn.Name = "tienbhtnDataGridViewTextBoxColumn";
            this.tienbhtnDataGridViewTextBoxColumn.Width = 125;
            // 
            // tienbhytDataGridViewTextBoxColumn
            // 
            this.tienbhytDataGridViewTextBoxColumn.DataPropertyName = "tienbhyt";
            this.tienbhytDataGridViewTextBoxColumn.HeaderText = "Tiền BHYT";
            this.tienbhytDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tienbhytDataGridViewTextBoxColumn.Name = "tienbhytDataGridViewTextBoxColumn";
            this.tienbhytDataGridViewTextBoxColumn.Width = 125;
            // 
            // giamtrucanhanDataGridViewTextBoxColumn
            // 
            this.giamtrucanhanDataGridViewTextBoxColumn.DataPropertyName = "giamtrucanhan";
            this.giamtrucanhanDataGridViewTextBoxColumn.HeaderText = "Giảm trừ cá nhân";
            this.giamtrucanhanDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.giamtrucanhanDataGridViewTextBoxColumn.Name = "giamtrucanhanDataGridViewTextBoxColumn";
            this.giamtrucanhanDataGridViewTextBoxColumn.Width = 125;
            // 
            // giamtruphuthuocDataGridViewTextBoxColumn
            // 
            this.giamtruphuthuocDataGridViewTextBoxColumn.DataPropertyName = "giamtruphuthuoc";
            this.giamtruphuthuocDataGridViewTextBoxColumn.HeaderText = "Giảm trừ phụ thuộc";
            this.giamtruphuthuocDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.giamtruphuthuocDataGridViewTextBoxColumn.Name = "giamtruphuthuocDataGridViewTextBoxColumn";
            this.giamtruphuthuocDataGridViewTextBoxColumn.Width = 125;
            // 
            // tientruocthueDataGridViewTextBoxColumn
            // 
            this.tientruocthueDataGridViewTextBoxColumn.DataPropertyName = "tientruocthue";
            this.tientruocthueDataGridViewTextBoxColumn.HeaderText = "Tiền lương trước thuế";
            this.tientruocthueDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tientruocthueDataGridViewTextBoxColumn.Name = "tientruocthueDataGridViewTextBoxColumn";
            this.tientruocthueDataGridViewTextBoxColumn.Width = 125;
            // 
            // tienthueDataGridViewTextBoxColumn
            // 
            this.tienthueDataGridViewTextBoxColumn.DataPropertyName = "tienthue";
            this.tienthueDataGridViewTextBoxColumn.HeaderText = "Tiền thuế";
            this.tienthueDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tienthueDataGridViewTextBoxColumn.Name = "tienthueDataGridViewTextBoxColumn";
            this.tienthueDataGridViewTextBoxColumn.Width = 125;
            // 
            // tonggiamtruDataGridViewTextBoxColumn
            // 
            this.tonggiamtruDataGridViewTextBoxColumn.DataPropertyName = "tonggiamtru";
            this.tonggiamtruDataGridViewTextBoxColumn.HeaderText = "Tiền giảm trừ";
            this.tonggiamtruDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tonggiamtruDataGridViewTextBoxColumn.Name = "tonggiamtruDataGridViewTextBoxColumn";
            this.tonggiamtruDataGridViewTextBoxColumn.Width = 125;
            // 
            // tongbaohiemDataGridViewTextBoxColumn
            // 
            this.tongbaohiemDataGridViewTextBoxColumn.DataPropertyName = "tongbaohiem";
            this.tongbaohiemDataGridViewTextBoxColumn.HeaderText = "Tổng bảo hiểm";
            this.tongbaohiemDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tongbaohiemDataGridViewTextBoxColumn.Name = "tongbaohiemDataGridViewTextBoxColumn";
            this.tongbaohiemDataGridViewTextBoxColumn.Width = 125;
            // 
            // tientamungDataGridViewTextBoxColumn
            // 
            this.tientamungDataGridViewTextBoxColumn.DataPropertyName = "tientamung";
            this.tientamungDataGridViewTextBoxColumn.HeaderText = "Tiền tạm ứng";
            this.tientamungDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tientamungDataGridViewTextBoxColumn.Name = "tientamungDataGridViewTextBoxColumn";
            this.tientamungDataGridViewTextBoxColumn.Width = 125;
            // 
            // tienthuclinhDataGridViewTextBoxColumn
            // 
            this.tienthuclinhDataGridViewTextBoxColumn.DataPropertyName = "tienthuclinh";
            this.tienthuclinhDataGridViewTextBoxColumn.HeaderText = "Tiền thực lĩnh";
            this.tienthuclinhDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tienthuclinhDataGridViewTextBoxColumn.Name = "tienthuclinhDataGridViewTextBoxColumn";
            this.tienthuclinhDataGridViewTextBoxColumn.Width = 125;
            // 
            // layBangLuongFullBindingSource
            // 
            this.layBangLuongFullBindingSource.DataMember = "LayBangLuongFull";
            this.layBangLuongFullBindingSource.DataSource = this.ketoantienluongDataSet;
            // 
            // ketoantienluongDataSet
            // 
            this.ketoantienluongDataSet.DataSetName = "ketoantienluongDataSet";
            this.ketoantienluongDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bangcongchititietcustomBindingSource
            // 
            this.bangcongchititietcustomBindingSource.DataMember = "bangcongchititietcustom";
            this.bangcongchititietcustomBindingSource.DataSource = this.ketoantienluongDataSet;
            // 
            // bangcongchititietcustomTableAdapter
            // 
            this.bangcongchititietcustomTableAdapter.ClearBeforeFill = true;
            // 
            // buttonLookup
            // 
            this.buttonLookup.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLookup.Image = global::KeToanTienLuong.Properties.Resources.eye;
            this.buttonLookup.Location = new System.Drawing.Point(516, 131);
            this.buttonLookup.Name = "buttonLookup";
            this.buttonLookup.Size = new System.Drawing.Size(121, 39);
            this.buttonLookup.TabIndex = 65;
            this.buttonLookup.Text = "   Xem";
            this.buttonLookup.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonLookup.UseVisualStyleBackColor = true;
            this.buttonLookup.Click += new System.EventHandler(this.buttonLookup_Click);
            // 
            // labelNam
            // 
            this.labelNam.AutoSize = true;
            this.labelNam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNam.Location = new System.Drawing.Point(411, 86);
            this.labelNam.Name = "labelNam";
            this.labelNam.Size = new System.Drawing.Size(47, 20);
            this.labelNam.TabIndex = 68;
            this.labelNam.Text = "Năm";
            // 
            // labelThang
            // 
            this.labelThang.AutoSize = true;
            this.labelThang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelThang.Location = new System.Drawing.Point(411, 43);
            this.labelThang.Name = "labelThang";
            this.labelThang.Size = new System.Drawing.Size(60, 20);
            this.labelThang.TabIndex = 66;
            this.labelThang.Text = "Tháng";
            // 
            // layBangLuongFullTableAdapter
            // 
            this.layBangLuongFullTableAdapter.ClearBeforeFill = true;
            // 
            // comboBoxThang
            // 
            this.comboBoxThang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxThang.FormattingEnabled = true;
            this.comboBoxThang.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.comboBoxThang.Location = new System.Drawing.Point(518, 38);
            this.comboBoxThang.Name = "comboBoxThang";
            this.comboBoxThang.Size = new System.Drawing.Size(119, 30);
            this.comboBoxThang.TabIndex = 70;
            // 
            // comboBoxNam
            // 
            this.comboBoxNam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxNam.FormattingEnabled = true;
            this.comboBoxNam.Items.AddRange(new object[] {
            "2015",
            "2016",
            "2017",
            "2018",
            "2019",
            "2020",
            "2021",
            "2022",
            "2023",
            "2024",
            "2025",
            "2026",
            "2027",
            "2028",
            "2029",
            "2030",
            "2031",
            "2032",
            "2033",
            "2034",
            "2035"});
            this.comboBoxNam.Location = new System.Drawing.Point(516, 81);
            this.comboBoxNam.Name = "comboBoxNam";
            this.comboBoxNam.Size = new System.Drawing.Size(119, 30);
            this.comboBoxNam.TabIndex = 71;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdate.Image = global::KeToanTienLuong.Properties.Resources.checkmark;
            this.buttonUpdate.Location = new System.Drawing.Point(881, 43);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(207, 56);
            this.buttonUpdate.TabIndex = 72;
            this.buttonUpdate.Text = "   Cập nhật lại dữ liệu";
            this.buttonUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // BangLuongForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.comboBoxNam);
            this.Controls.Add(this.comboBoxThang);
            this.Controls.Add(this.buttonLookup);
            this.Controls.Add(this.labelNam);
            this.Controls.Add(this.labelThang);
            this.Controls.Add(this.dataGridViewBangLuong);
            this.Name = "BangLuongForm";
            this.Size = new System.Drawing.Size(1113, 665);
            this.Load += new System.EventHandler(this.formload);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBangLuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layBangLuongFullBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ketoantienluongDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bangcongchititietcustomBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewBangLuong;
        private System.Windows.Forms.BindingSource bangcongchititietcustomBindingSource;
        private ketoantienluongDataSet ketoantienluongDataSet;
        private ketoantienluongDataSetTableAdapters.bangcongchititietcustomTableAdapter bangcongchititietcustomTableAdapter;
        private System.Windows.Forms.Button buttonLookup;
        private System.Windows.Forms.Label labelNam;
        private System.Windows.Forms.Label labelThang;
        private System.Windows.Forms.DataGridViewTextBoxColumn manvDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenvDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaysinhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn thangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noidungDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaycongcuathangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaycongthucteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tienluongcobanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn luongtheongaycongDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phucapantrueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tienthuongDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phucapkhacDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tienphatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tienphucapDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tienbhxhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tienbhtnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tienbhytDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn giamtrucanhanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn giamtruphuthuocDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tientruocthueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tienthueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tonggiamtruDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tongbaohiemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tientamungDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tienthuclinhDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource layBangLuongFullBindingSource;
        private ketoantienluongDataSetTableAdapters.LayBangLuongFullTableAdapter layBangLuongFullTableAdapter;
        private System.Windows.Forms.ComboBox comboBoxThang;
        private System.Windows.Forms.ComboBox comboBoxNam;
        private System.Windows.Forms.Button buttonUpdate;
    }
}
