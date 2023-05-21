
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
            this.ketoantienluongDataSet = new KeToanTienLuong.ketoantienluongDataSet();
            this.bangcongchititietcustomBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bangcongchititietcustomTableAdapter = new KeToanTienLuong.ketoantienluongDataSetTableAdapters.bangcongchititietcustomTableAdapter();
            this.manvDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenvDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaysinhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.songuoiphuthuocDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.luongcobanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noidungDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaycongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayphepDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaykhongphepDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tienphucapDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tienthuongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonLookup = new System.Windows.Forms.Button();
            this.inpNam = new System.Windows.Forms.TextBox();
            this.labelNam = new System.Windows.Forms.Label();
            this.inpThang = new System.Windows.Forms.TextBox();
            this.labelThang = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBangLuong)).BeginInit();
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
            this.songuoiphuthuocDataGridViewTextBoxColumn,
            this.luongcobanDataGridViewTextBoxColumn,
            this.thangDataGridViewTextBoxColumn,
            this.namDataGridViewTextBoxColumn,
            this.noidungDataGridViewTextBoxColumn,
            this.ngaycongDataGridViewTextBoxColumn,
            this.ngayphepDataGridViewTextBoxColumn,
            this.ngaykhongphepDataGridViewTextBoxColumn,
            this.tienphucapDataGridViewTextBoxColumn,
            this.tienthuongDataGridViewTextBoxColumn});
            this.dataGridViewBangLuong.DataSource = this.bangcongchititietcustomBindingSource;
            this.dataGridViewBangLuong.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridViewBangLuong.Location = new System.Drawing.Point(0, 222);
            this.dataGridViewBangLuong.Name = "dataGridViewBangLuong";
            this.dataGridViewBangLuong.RowHeadersWidth = 51;
            this.dataGridViewBangLuong.RowTemplate.Height = 24;
            this.dataGridViewBangLuong.Size = new System.Drawing.Size(1113, 443);
            this.dataGridViewBangLuong.TabIndex = 0;
            this.dataGridViewBangLuong.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewBangLuong_CellContentClick);
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
            // songuoiphuthuocDataGridViewTextBoxColumn
            // 
            this.songuoiphuthuocDataGridViewTextBoxColumn.DataPropertyName = "songuoiphuthuoc";
            this.songuoiphuthuocDataGridViewTextBoxColumn.HeaderText = "Số người phụ thuộc";
            this.songuoiphuthuocDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.songuoiphuthuocDataGridViewTextBoxColumn.Name = "songuoiphuthuocDataGridViewTextBoxColumn";
            this.songuoiphuthuocDataGridViewTextBoxColumn.Width = 125;
            // 
            // luongcobanDataGridViewTextBoxColumn
            // 
            this.luongcobanDataGridViewTextBoxColumn.DataPropertyName = "luongcoban";
            this.luongcobanDataGridViewTextBoxColumn.HeaderText = "Lương cơ bản";
            this.luongcobanDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.luongcobanDataGridViewTextBoxColumn.Name = "luongcobanDataGridViewTextBoxColumn";
            this.luongcobanDataGridViewTextBoxColumn.Width = 125;
            // 
            // thangDataGridViewTextBoxColumn
            // 
            this.thangDataGridViewTextBoxColumn.DataPropertyName = "thang";
            this.thangDataGridViewTextBoxColumn.HeaderText = "Tháng tính lương";
            this.thangDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.thangDataGridViewTextBoxColumn.Name = "thangDataGridViewTextBoxColumn";
            this.thangDataGridViewTextBoxColumn.Width = 125;
            // 
            // namDataGridViewTextBoxColumn
            // 
            this.namDataGridViewTextBoxColumn.DataPropertyName = "nam";
            this.namDataGridViewTextBoxColumn.HeaderText = "Năm tính lương";
            this.namDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.namDataGridViewTextBoxColumn.Name = "namDataGridViewTextBoxColumn";
            this.namDataGridViewTextBoxColumn.Width = 125;
            // 
            // noidungDataGridViewTextBoxColumn
            // 
            this.noidungDataGridViewTextBoxColumn.DataPropertyName = "noidung";
            this.noidungDataGridViewTextBoxColumn.HeaderText = "Nội dung";
            this.noidungDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.noidungDataGridViewTextBoxColumn.Name = "noidungDataGridViewTextBoxColumn";
            this.noidungDataGridViewTextBoxColumn.Width = 125;
            // 
            // ngaycongDataGridViewTextBoxColumn
            // 
            this.ngaycongDataGridViewTextBoxColumn.DataPropertyName = "ngaycong";
            this.ngaycongDataGridViewTextBoxColumn.HeaderText = "Ngày công của tháng";
            this.ngaycongDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ngaycongDataGridViewTextBoxColumn.Name = "ngaycongDataGridViewTextBoxColumn";
            this.ngaycongDataGridViewTextBoxColumn.Width = 125;
            // 
            // ngayphepDataGridViewTextBoxColumn
            // 
            this.ngayphepDataGridViewTextBoxColumn.DataPropertyName = "ngayphep";
            this.ngayphepDataGridViewTextBoxColumn.HeaderText = "Ngày nghỉ có phép";
            this.ngayphepDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ngayphepDataGridViewTextBoxColumn.Name = "ngayphepDataGridViewTextBoxColumn";
            this.ngayphepDataGridViewTextBoxColumn.Width = 125;
            // 
            // ngaykhongphepDataGridViewTextBoxColumn
            // 
            this.ngaykhongphepDataGridViewTextBoxColumn.DataPropertyName = "ngaykhongphep";
            this.ngaykhongphepDataGridViewTextBoxColumn.HeaderText = "Ngày nghỉ không phép";
            this.ngaykhongphepDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ngaykhongphepDataGridViewTextBoxColumn.Name = "ngaykhongphepDataGridViewTextBoxColumn";
            this.ngaykhongphepDataGridViewTextBoxColumn.Width = 125;
            // 
            // tienphucapDataGridViewTextBoxColumn
            // 
            this.tienphucapDataGridViewTextBoxColumn.DataPropertyName = "tienphucap";
            this.tienphucapDataGridViewTextBoxColumn.HeaderText = "Tiền phụ cấp";
            this.tienphucapDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tienphucapDataGridViewTextBoxColumn.Name = "tienphucapDataGridViewTextBoxColumn";
            this.tienphucapDataGridViewTextBoxColumn.Width = 125;
            // 
            // tienthuongDataGridViewTextBoxColumn
            // 
            this.tienthuongDataGridViewTextBoxColumn.DataPropertyName = "tienthuong";
            this.tienthuongDataGridViewTextBoxColumn.HeaderText = "Tiền thưởng";
            this.tienthuongDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tienthuongDataGridViewTextBoxColumn.Name = "tienthuongDataGridViewTextBoxColumn";
            this.tienthuongDataGridViewTextBoxColumn.Width = 125;
            // 
            // buttonLookup
            // 
            this.buttonLookup.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLookup.Image = global::KeToanTienLuong.Properties.Resources.eye;
            this.buttonLookup.Location = new System.Drawing.Point(154, 126);
            this.buttonLookup.Name = "buttonLookup";
            this.buttonLookup.Size = new System.Drawing.Size(117, 39);
            this.buttonLookup.TabIndex = 65;
            this.buttonLookup.Text = "   Xem";
            this.buttonLookup.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonLookup.UseVisualStyleBackColor = true;
            this.buttonLookup.Click += new System.EventHandler(this.buttonLookup_Click);
            // 
            // inpNam
            // 
            this.inpNam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inpNam.Location = new System.Drawing.Point(154, 76);
            this.inpNam.Name = "inpNam";
            this.inpNam.Size = new System.Drawing.Size(117, 27);
            this.inpNam.TabIndex = 69;
            // 
            // labelNam
            // 
            this.labelNam.AutoSize = true;
            this.labelNam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNam.Location = new System.Drawing.Point(47, 82);
            this.labelNam.Name = "labelNam";
            this.labelNam.Size = new System.Drawing.Size(47, 20);
            this.labelNam.TabIndex = 68;
            this.labelNam.Text = "Năm";
            // 
            // inpThang
            // 
            this.inpThang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inpThang.Location = new System.Drawing.Point(154, 36);
            this.inpThang.Name = "inpThang";
            this.inpThang.Size = new System.Drawing.Size(117, 27);
            this.inpThang.TabIndex = 67;
            // 
            // labelThang
            // 
            this.labelThang.AutoSize = true;
            this.labelThang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelThang.Location = new System.Drawing.Point(47, 39);
            this.labelThang.Name = "labelThang";
            this.labelThang.Size = new System.Drawing.Size(60, 20);
            this.labelThang.TabIndex = 66;
            this.labelThang.Text = "Tháng";
            // 
            // BangLuongForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonLookup);
            this.Controls.Add(this.inpNam);
            this.Controls.Add(this.labelNam);
            this.Controls.Add(this.inpThang);
            this.Controls.Add(this.labelThang);
            this.Controls.Add(this.dataGridViewBangLuong);
            this.Name = "BangLuongForm";
            this.Size = new System.Drawing.Size(1113, 665);
            this.Load += new System.EventHandler(this.formload);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBangLuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ketoantienluongDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bangcongchititietcustomBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewBangLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn manvDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenvDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaysinhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn songuoiphuthuocDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn luongcobanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn thangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noidungDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaycongDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayphepDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaykhongphepDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tienphucapDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tienthuongDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bangcongchititietcustomBindingSource;
        private ketoantienluongDataSet ketoantienluongDataSet;
        private ketoantienluongDataSetTableAdapters.bangcongchititietcustomTableAdapter bangcongchititietcustomTableAdapter;
        private System.Windows.Forms.Button buttonLookup;
        private System.Windows.Forms.TextBox inpNam;
        private System.Windows.Forms.Label labelNam;
        private System.Windows.Forms.TextBox inpThang;
        private System.Windows.Forms.Label labelThang;
    }
}
