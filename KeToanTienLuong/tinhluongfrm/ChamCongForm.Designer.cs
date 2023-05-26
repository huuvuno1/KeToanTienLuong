
namespace KeToanTienLuong.tinhluongfrm
{
    partial class ChamCongForm
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
            this.panelContentBox = new System.Windows.Forms.Panel();
            this.log = new System.Windows.Forms.RichTextBox();
            this.buttonLookup = new System.Windows.Forms.Button();
            this.inpNam = new System.Windows.Forms.TextBox();
            this.labelNam = new System.Windows.Forms.Label();
            this.inpThang = new System.Windows.Forms.TextBox();
            this.labelThang = new System.Windows.Forms.Label();
            this.cbomabp = new System.Windows.Forms.ComboBox();
            this.labelBoPhan = new System.Windows.Forms.Label();
            this.txtngaycong = new System.Windows.Forms.TextBox();
            this.labelNgayCong = new System.Windows.Forms.Label();
            this.txtnoidung = new System.Windows.Forms.TextBox();
            this.labelNoiDung = new System.Windows.Forms.Label();
            this.txtthang = new System.Windows.Forms.TextBox();
            this.labelThang1 = new System.Windows.Forms.Label();
            this.txtnam = new System.Windows.Forms.TextBox();
            this.labelNam1 = new System.Windows.Forms.Label();
            this.txtso = new System.Windows.Forms.TextBox();
            this.labelSo = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.buttonDownload = new System.Windows.Forms.Button();
            this.buttonUpload = new System.Windows.Forms.Button();
            this.buttonLuu = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.dataGridViewChamCong = new System.Windows.Forms.DataGridView();
            this.dataGridViewBangCong = new System.Windows.Forms.DataGridView();
            this.soDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manvDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaycongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayphepDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaykhongphepDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tienphucapDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tienthuongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chitietbangccBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ketoantienluongDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ketoantienluongDataSet = new KeToanTienLuong.ketoantienluongDataSet();
            this.chitietbangccTableAdapter = new KeToanTienLuong.ketoantienluongDataSetTableAdapters.chitietbangccTableAdapter();
            this.buttonXem = new System.Windows.Forms.Button();
            this.buttonThem = new System.Windows.Forms.Button();
            this.panelContentBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChamCong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBangCong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chitietbangccBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ketoantienluongDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ketoantienluongDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // panelContentBox
            // 
            this.panelContentBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelContentBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panelContentBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelContentBox.Controls.Add(this.log);
            this.panelContentBox.Controls.Add(this.buttonLookup);
            this.panelContentBox.Controls.Add(this.inpNam);
            this.panelContentBox.Controls.Add(this.labelNam);
            this.panelContentBox.Controls.Add(this.inpThang);
            this.panelContentBox.Controls.Add(this.labelThang);
            this.panelContentBox.Controls.Add(this.cbomabp);
            this.panelContentBox.Controls.Add(this.labelBoPhan);
            this.panelContentBox.Controls.Add(this.txtngaycong);
            this.panelContentBox.Controls.Add(this.labelNgayCong);
            this.panelContentBox.Controls.Add(this.txtnoidung);
            this.panelContentBox.Controls.Add(this.labelNoiDung);
            this.panelContentBox.Controls.Add(this.txtthang);
            this.panelContentBox.Controls.Add(this.labelThang1);
            this.panelContentBox.Controls.Add(this.txtnam);
            this.panelContentBox.Controls.Add(this.labelNam1);
            this.panelContentBox.Controls.Add(this.txtso);
            this.panelContentBox.Controls.Add(this.labelSo);
            this.panelContentBox.Controls.Add(this.button4);
            this.panelContentBox.Controls.Add(this.buttonDownload);
            this.panelContentBox.Controls.Add(this.buttonUpload);
            this.panelContentBox.Controls.Add(this.buttonLuu);
            this.panelContentBox.Controls.Add(this.buttonReset);
            this.panelContentBox.Controls.Add(this.dataGridViewChamCong);
            this.panelContentBox.Controls.Add(this.dataGridViewBangCong);
            this.panelContentBox.Location = new System.Drawing.Point(0, 126);
            this.panelContentBox.Name = "panelContentBox";
            this.panelContentBox.Size = new System.Drawing.Size(1406, 962);
            this.panelContentBox.TabIndex = 33;
            this.panelContentBox.Paint += new System.Windows.Forms.PaintEventHandler(this.panelContentBox_Paint);
            // 
            // log
            // 
            this.log.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.log.Location = new System.Drawing.Point(41, 666);
            this.log.Name = "log";
            this.log.ReadOnly = true;
            this.log.Size = new System.Drawing.Size(964, 108);
            this.log.TabIndex = 65;
            this.log.Text = "LOG";
            // 
            // buttonLookup
            // 
            this.buttonLookup.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLookup.Image = global::KeToanTienLuong.Properties.Resources.eye;
            this.buttonLookup.Location = new System.Drawing.Point(494, 115);
            this.buttonLookup.Name = "buttonLookup";
            this.buttonLookup.Size = new System.Drawing.Size(117, 39);
            this.buttonLookup.TabIndex = 34;
            this.buttonLookup.Text = "   Xem";
            this.buttonLookup.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonLookup.UseVisualStyleBackColor = true;
            this.buttonLookup.Visible = false;
            this.buttonLookup.Click += new System.EventHandler(this.buttonLookup_Click);
            // 
            // inpNam
            // 
            this.inpNam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inpNam.Location = new System.Drawing.Point(494, 65);
            this.inpNam.Name = "inpNam";
            this.inpNam.Size = new System.Drawing.Size(117, 27);
            this.inpNam.TabIndex = 64;
            this.inpNam.Visible = false;
            // 
            // labelNam
            // 
            this.labelNam.AutoSize = true;
            this.labelNam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNam.Location = new System.Drawing.Point(387, 71);
            this.labelNam.Name = "labelNam";
            this.labelNam.Size = new System.Drawing.Size(47, 20);
            this.labelNam.TabIndex = 63;
            this.labelNam.Text = "Năm";
            this.labelNam.Visible = false;
            // 
            // inpThang
            // 
            this.inpThang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inpThang.Location = new System.Drawing.Point(494, 25);
            this.inpThang.Name = "inpThang";
            this.inpThang.Size = new System.Drawing.Size(117, 27);
            this.inpThang.TabIndex = 62;
            this.inpThang.Visible = false;
            // 
            // labelThang
            // 
            this.labelThang.AutoSize = true;
            this.labelThang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelThang.Location = new System.Drawing.Point(387, 28);
            this.labelThang.Name = "labelThang";
            this.labelThang.Size = new System.Drawing.Size(60, 20);
            this.labelThang.TabIndex = 61;
            this.labelThang.Text = "Tháng";
            this.labelThang.Visible = false;
            // 
            // cbomabp
            // 
            this.cbomabp.FormattingEnabled = true;
            this.cbomabp.Location = new System.Drawing.Point(786, 74);
            this.cbomabp.Margin = new System.Windows.Forms.Padding(4);
            this.cbomabp.Name = "cbomabp";
            this.cbomabp.Size = new System.Drawing.Size(233, 24);
            this.cbomabp.TabIndex = 59;
            this.cbomabp.SelectedIndexChanged += new System.EventHandler(this.cbomabp_SelectedIndexChanged);
            // 
            // labelBoPhan
            // 
            this.labelBoPhan.AutoSize = true;
            this.labelBoPhan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBoPhan.Location = new System.Drawing.Point(659, 72);
            this.labelBoPhan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelBoPhan.Name = "labelBoPhan";
            this.labelBoPhan.Size = new System.Drawing.Size(78, 23);
            this.labelBoPhan.TabIndex = 58;
            this.labelBoPhan.Text = "Bộ phận";
            // 
            // txtngaycong
            // 
            this.txtngaycong.Location = new System.Drawing.Point(786, 28);
            this.txtngaycong.Margin = new System.Windows.Forms.Padding(4);
            this.txtngaycong.Name = "txtngaycong";
            this.txtngaycong.Size = new System.Drawing.Size(233, 22);
            this.txtngaycong.TabIndex = 57;
            this.txtngaycong.Text = "22";
            this.txtngaycong.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelNgayCong
            // 
            this.labelNgayCong.AutoSize = true;
            this.labelNgayCong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNgayCong.Location = new System.Drawing.Point(553, 26);
            this.labelNgayCong.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNgayCong.Name = "labelNgayCong";
            this.labelNgayCong.Size = new System.Drawing.Size(184, 23);
            this.labelNgayCong.TabIndex = 56;
            this.labelNgayCong.Text = "Ngày công của tháng";
            // 
            // txtnoidung
            // 
            this.txtnoidung.Location = new System.Drawing.Point(786, 115);
            this.txtnoidung.Margin = new System.Windows.Forms.Padding(4);
            this.txtnoidung.Name = "txtnoidung";
            this.txtnoidung.Size = new System.Drawing.Size(288, 22);
            this.txtnoidung.TabIndex = 55;
            // 
            // labelNoiDung
            // 
            this.labelNoiDung.AutoSize = true;
            this.labelNoiDung.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNoiDung.Location = new System.Drawing.Point(653, 115);
            this.labelNoiDung.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNoiDung.Name = "labelNoiDung";
            this.labelNoiDung.Size = new System.Drawing.Size(84, 23);
            this.labelNoiDung.TabIndex = 54;
            this.labelNoiDung.Text = "Nội dung";
            // 
            // txtthang
            // 
            this.txtthang.Location = new System.Drawing.Point(168, 66);
            this.txtthang.Margin = new System.Windows.Forms.Padding(4);
            this.txtthang.Name = "txtthang";
            this.txtthang.Size = new System.Drawing.Size(160, 22);
            this.txtthang.TabIndex = 49;
            this.txtthang.Text = "5";
            this.txtthang.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtthang.TextChanged += new System.EventHandler(this.txtthang_TextChanged);
            // 
            // labelThang1
            // 
            this.labelThang1.AutoSize = true;
            this.labelThang1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelThang1.Location = new System.Drawing.Point(37, 64);
            this.labelThang1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelThang1.Name = "labelThang1";
            this.labelThang1.Size = new System.Drawing.Size(63, 23);
            this.labelThang1.TabIndex = 48;
            this.labelThang1.Text = "Tháng";
            // 
            // txtnam
            // 
            this.txtnam.Location = new System.Drawing.Point(168, 107);
            this.txtnam.Margin = new System.Windows.Forms.Padding(4);
            this.txtnam.Name = "txtnam";
            this.txtnam.Size = new System.Drawing.Size(160, 22);
            this.txtnam.TabIndex = 47;
            this.txtnam.Text = "2023";
            this.txtnam.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelNam1
            // 
            this.labelNam1.AutoSize = true;
            this.labelNam1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNam1.Location = new System.Drawing.Point(37, 105);
            this.labelNam1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNam1.Name = "labelNam1";
            this.labelNam1.Size = new System.Drawing.Size(49, 23);
            this.labelNam1.TabIndex = 46;
            this.labelNam1.Text = "Năm";
            // 
            // txtso
            // 
            this.txtso.Enabled = false;
            this.txtso.Location = new System.Drawing.Point(168, 28);
            this.txtso.Margin = new System.Windows.Forms.Padding(4);
            this.txtso.Name = "txtso";
            this.txtso.Size = new System.Drawing.Size(160, 22);
            this.txtso.TabIndex = 43;
            this.txtso.Text = "Tạo tự động";
            // 
            // labelSo
            // 
            this.labelSo.AutoSize = true;
            this.labelSo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSo.Location = new System.Drawing.Point(37, 26);
            this.labelSo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSo.Name = "labelSo";
            this.labelSo.Size = new System.Drawing.Size(31, 23);
            this.labelSo.TabIndex = 42;
            this.labelSo.Text = "Số";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(60, 13);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(8, 8);
            this.button4.TabIndex = 40;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // buttonDownload
            // 
            this.buttonDownload.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonDownload.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDownload.Image = global::KeToanTienLuong.Properties.Resources.download2;
            this.buttonDownload.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonDownload.Location = new System.Drawing.Point(768, 193);
            this.buttonDownload.Name = "buttonDownload";
            this.buttonDownload.Size = new System.Drawing.Size(203, 91);
            this.buttonDownload.TabIndex = 38;
            this.buttonDownload.Text = " Tải file mẫu";
            this.buttonDownload.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonDownload.UseVisualStyleBackColor = true;
            this.buttonDownload.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonUpload
            // 
            this.buttonUpload.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonUpload.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpload.Image = global::KeToanTienLuong.Properties.Resources.upload_file;
            this.buttonUpload.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonUpload.Location = new System.Drawing.Point(494, 193);
            this.buttonUpload.Name = "buttonUpload";
            this.buttonUpload.Size = new System.Drawing.Size(236, 91);
            this.buttonUpload.TabIndex = 35;
            this.buttonUpload.Text = "  Tải lên file chấm công/thưởng";
            this.buttonUpload.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonUpload.UseVisualStyleBackColor = true;
            this.buttonUpload.Click += new System.EventHandler(this.buttonUpload_Click);
            // 
            // buttonLuu
            // 
            this.buttonLuu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLuu.Image = global::KeToanTienLuong.Properties.Resources.checkmark;
            this.buttonLuu.Location = new System.Drawing.Point(1048, 718);
            this.buttonLuu.Name = "buttonLuu";
            this.buttonLuu.Size = new System.Drawing.Size(137, 42);
            this.buttonLuu.TabIndex = 34;
            this.buttonLuu.Text = "   Lưu";
            this.buttonLuu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonLuu.UseVisualStyleBackColor = true;
            this.buttonLuu.Click += new System.EventHandler(this.buttonLuu_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReset.Image = global::KeToanTienLuong.Properties.Resources.delete;
            this.buttonReset.Location = new System.Drawing.Point(1232, 718);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(137, 42);
            this.buttonReset.TabIndex = 33;
            this.buttonReset.Text = "   Reset";
            this.buttonReset.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.button3_Click);
            // 
            // dataGridViewChamCong
            // 
            this.dataGridViewChamCong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewChamCong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewChamCong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewChamCong.Location = new System.Drawing.Point(-2, 325);
            this.dataGridViewChamCong.Name = "dataGridViewChamCong";
            this.dataGridViewChamCong.RowHeadersWidth = 51;
            this.dataGridViewChamCong.RowTemplate.Height = 24;
            this.dataGridViewChamCong.Size = new System.Drawing.Size(1402, 323);
            this.dataGridViewChamCong.TabIndex = 27;
            // 
            // dataGridViewBangCong
            // 
            this.dataGridViewBangCong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewBangCong.AutoGenerateColumns = false;
            this.dataGridViewBangCong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewBangCong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBangCong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.soDataGridViewTextBoxColumn,
            this.manvDataGridViewTextBoxColumn,
            this.ngaycongDataGridViewTextBoxColumn,
            this.ngayphepDataGridViewTextBoxColumn,
            this.ngaykhongphepDataGridViewTextBoxColumn,
            this.tienphucapDataGridViewTextBoxColumn,
            this.tienthuongDataGridViewTextBoxColumn});
            this.dataGridViewBangCong.DataSource = this.chitietbangccBindingSource;
            this.dataGridViewBangCong.Location = new System.Drawing.Point(-2, 289);
            this.dataGridViewBangCong.Name = "dataGridViewBangCong";
            this.dataGridViewBangCong.RowHeadersWidth = 51;
            this.dataGridViewBangCong.RowTemplate.Height = 24;
            this.dataGridViewBangCong.Size = new System.Drawing.Size(1402, 456);
            this.dataGridViewBangCong.TabIndex = 60;
            this.dataGridViewBangCong.Visible = false;
            // 
            // soDataGridViewTextBoxColumn
            // 
            this.soDataGridViewTextBoxColumn.DataPropertyName = "so";
            this.soDataGridViewTextBoxColumn.HeaderText = "Số";
            this.soDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.soDataGridViewTextBoxColumn.Name = "soDataGridViewTextBoxColumn";
            // 
            // manvDataGridViewTextBoxColumn
            // 
            this.manvDataGridViewTextBoxColumn.DataPropertyName = "manv";
            this.manvDataGridViewTextBoxColumn.HeaderText = "Mã nhân viên";
            this.manvDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.manvDataGridViewTextBoxColumn.Name = "manvDataGridViewTextBoxColumn";
            // 
            // ngaycongDataGridViewTextBoxColumn
            // 
            this.ngaycongDataGridViewTextBoxColumn.DataPropertyName = "ngaycong";
            this.ngaycongDataGridViewTextBoxColumn.HeaderText = "Ngày công";
            this.ngaycongDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ngaycongDataGridViewTextBoxColumn.Name = "ngaycongDataGridViewTextBoxColumn";
            // 
            // ngayphepDataGridViewTextBoxColumn
            // 
            this.ngayphepDataGridViewTextBoxColumn.DataPropertyName = "ngayphep";
            this.ngayphepDataGridViewTextBoxColumn.HeaderText = "Ngày phép";
            this.ngayphepDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ngayphepDataGridViewTextBoxColumn.Name = "ngayphepDataGridViewTextBoxColumn";
            // 
            // ngaykhongphepDataGridViewTextBoxColumn
            // 
            this.ngaykhongphepDataGridViewTextBoxColumn.DataPropertyName = "ngaykhongphep";
            this.ngaykhongphepDataGridViewTextBoxColumn.HeaderText = "Ngày không phép";
            this.ngaykhongphepDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ngaykhongphepDataGridViewTextBoxColumn.Name = "ngaykhongphepDataGridViewTextBoxColumn";
            // 
            // tienphucapDataGridViewTextBoxColumn
            // 
            this.tienphucapDataGridViewTextBoxColumn.DataPropertyName = "tienphucap";
            this.tienphucapDataGridViewTextBoxColumn.HeaderText = "Tiền phụ cấp";
            this.tienphucapDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tienphucapDataGridViewTextBoxColumn.Name = "tienphucapDataGridViewTextBoxColumn";
            // 
            // tienthuongDataGridViewTextBoxColumn
            // 
            this.tienthuongDataGridViewTextBoxColumn.DataPropertyName = "tienthuong";
            this.tienthuongDataGridViewTextBoxColumn.HeaderText = "Tiền thưởng";
            this.tienthuongDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tienthuongDataGridViewTextBoxColumn.Name = "tienthuongDataGridViewTextBoxColumn";
            // 
            // chitietbangccBindingSource
            // 
            this.chitietbangccBindingSource.DataMember = "chitietbangcc";
            this.chitietbangccBindingSource.DataSource = this.ketoantienluongDataSetBindingSource;
            // 
            // ketoantienluongDataSetBindingSource
            // 
            this.ketoantienluongDataSetBindingSource.DataSource = this.ketoantienluongDataSet;
            this.ketoantienluongDataSetBindingSource.Position = 0;
            // 
            // ketoantienluongDataSet
            // 
            this.ketoantienluongDataSet.DataSetName = "ketoantienluongDataSet";
            this.ketoantienluongDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // chitietbangccTableAdapter
            // 
            this.chitietbangccTableAdapter.ClearBeforeFill = true;
            // 
            // buttonXem
            // 
            this.buttonXem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonXem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonXem.Image = global::KeToanTienLuong.Properties.Resources.eye;
            this.buttonXem.Location = new System.Drawing.Point(1198, 21);
            this.buttonXem.Name = "buttonXem";
            this.buttonXem.Size = new System.Drawing.Size(176, 78);
            this.buttonXem.TabIndex = 32;
            this.buttonXem.Text = "   Xem bảng công/thưởng";
            this.buttonXem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonXem.UseVisualStyleBackColor = true;
            this.buttonXem.Click += new System.EventHandler(this.buttonXem_Click);
            // 
            // buttonThem
            // 
            this.buttonThem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonThem.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonThem.Image = global::KeToanTienLuong.Properties.Resources.plus;
            this.buttonThem.Location = new System.Drawing.Point(910, 21);
            this.buttonThem.Name = "buttonThem";
            this.buttonThem.Size = new System.Drawing.Size(194, 78);
            this.buttonThem.TabIndex = 31;
            this.buttonThem.Text = "  Cập nhật công/thưởng tháng";
            this.buttonThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonThem.UseVisualStyleBackColor = false;
            this.buttonThem.Click += new System.EventHandler(this.buttonThem_Click);
            // 
            // ChamCongForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelContentBox);
            this.Controls.Add(this.buttonXem);
            this.Controls.Add(this.buttonThem);
            this.Name = "ChamCongForm";
            this.Size = new System.Drawing.Size(1406, 1091);
            this.Load += new System.EventHandler(this.ChamCongForm_Load);
            this.panelContentBox.ResumeLayout(false);
            this.panelContentBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChamCong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBangCong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chitietbangccBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ketoantienluongDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ketoantienluongDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonXem;
        private System.Windows.Forms.Button buttonThem;
        private System.Windows.Forms.Panel panelContentBox;
        private System.Windows.Forms.DataGridView dataGridViewChamCong;
        private System.Windows.Forms.Button buttonUpload;
        private System.Windows.Forms.Button buttonLuu;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonDownload;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox txtthang;
        private System.Windows.Forms.Label labelThang1;
        private System.Windows.Forms.TextBox txtnam;
        private System.Windows.Forms.Label labelNam1;
        private System.Windows.Forms.TextBox txtso;
        private System.Windows.Forms.Label labelSo;
        private System.Windows.Forms.ComboBox cbomabp;
        private System.Windows.Forms.Label labelBoPhan;
        private System.Windows.Forms.TextBox txtngaycong;
        private System.Windows.Forms.Label labelNgayCong;
        private System.Windows.Forms.TextBox txtnoidung;
        private System.Windows.Forms.Label labelNoiDung;
        private System.Windows.Forms.BindingSource chitietbangccBindingSource;
        private System.Windows.Forms.BindingSource ketoantienluongDataSetBindingSource;
        private ketoantienluongDataSet ketoantienluongDataSet;
        private ketoantienluongDataSetTableAdapters.chitietbangccTableAdapter chitietbangccTableAdapter;
        private System.Windows.Forms.DataGridView dataGridViewBangCong;
        private System.Windows.Forms.TextBox inpNam;
        private System.Windows.Forms.Label labelNam;
        private System.Windows.Forms.TextBox inpThang;
        private System.Windows.Forms.Label labelThang;
        private System.Windows.Forms.DataGridViewTextBoxColumn soDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn manvDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaycongDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayphepDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaykhongphepDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tienphucapDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tienthuongDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button buttonLookup;
        private System.Windows.Forms.RichTextBox log;
    }
}
