
namespace KeToanTienLuong.danhmucform
{
    partial class BoPhanForm
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
            this.label4 = new System.Windows.Forms.Label();
            this.inpHotline = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.inpTenBoPhan = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.inpMa = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.inpDiaChi = new System.Windows.Forms.TextBox();
            this.dataGridViewBoPhan = new System.Windows.Forms.DataGridView();
            this.mabpDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenbpDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sdtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diachiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dmbpBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ketoantienluongDataSet2 = new KeToanTienLuong.ketoantienluongDataSet2();
            this.dmbpTableAdapter = new KeToanTienLuong.ketoantienluongDataSet2TableAdapters.dmbpTableAdapter();
            this.buttonHuy = new System.Windows.Forms.Button();
            this.buttonLuu = new System.Windows.Forms.Button();
            this.buttonXoa = new System.Windows.Forms.Button();
            this.buttonSua = new System.Windows.Forms.Button();
            this.buttonThem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBoPhan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dmbpBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ketoantienluongDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(37, 257);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 20);
            this.label4.TabIndex = 27;
            this.label4.Text = "Địa chỉ";
            // 
            // inpHotline
            // 
            this.inpHotline.Enabled = false;
            this.inpHotline.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inpHotline.Location = new System.Drawing.Point(226, 200);
            this.inpHotline.Name = "inpHotline";
            this.inpHotline.Size = new System.Drawing.Size(336, 27);
            this.inpHotline.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 25;
            this.label2.Text = "Hotline";
            // 
            // inpTenBoPhan
            // 
            this.inpTenBoPhan.Enabled = false;
            this.inpTenBoPhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inpTenBoPhan.Location = new System.Drawing.Point(226, 140);
            this.inpTenBoPhan.Name = "inpTenBoPhan";
            this.inpTenBoPhan.Size = new System.Drawing.Size(336, 27);
            this.inpTenBoPhan.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 20);
            this.label1.TabIndex = 23;
            this.label1.Text = "Tên bộ phận";
            // 
            // inpMa
            // 
            this.inpMa.Enabled = false;
            this.inpMa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inpMa.Location = new System.Drawing.Point(226, 87);
            this.inpMa.Name = "inpMa";
            this.inpMa.Size = new System.Drawing.Size(336, 27);
            this.inpMa.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(37, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 20);
            this.label3.TabIndex = 21;
            this.label3.Text = "Mã bộ phận";
            // 
            // inpDiaChi
            // 
            this.inpDiaChi.Enabled = false;
            this.inpDiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inpDiaChi.Location = new System.Drawing.Point(226, 254);
            this.inpDiaChi.Name = "inpDiaChi";
            this.inpDiaChi.Size = new System.Drawing.Size(336, 27);
            this.inpDiaChi.TabIndex = 33;
            // 
            // dataGridViewBoPhan
            // 
            this.dataGridViewBoPhan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewBoPhan.AutoGenerateColumns = false;
            this.dataGridViewBoPhan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewBoPhan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBoPhan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mabpDataGridViewTextBoxColumn,
            this.tenbpDataGridViewTextBoxColumn,
            this.sdtDataGridViewTextBoxColumn,
            this.diachiDataGridViewTextBoxColumn});
            this.dataGridViewBoPhan.DataSource = this.dmbpBindingSource;
            this.dataGridViewBoPhan.Location = new System.Drawing.Point(3, 351);
            this.dataGridViewBoPhan.Name = "dataGridViewBoPhan";
            this.dataGridViewBoPhan.RowHeadersWidth = 51;
            this.dataGridViewBoPhan.RowTemplate.Height = 24;
            this.dataGridViewBoPhan.Size = new System.Drawing.Size(1196, 264);
            this.dataGridViewBoPhan.TabIndex = 34;
            this.dataGridViewBoPhan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cellclick);
            // 
            // mabpDataGridViewTextBoxColumn
            // 
            this.mabpDataGridViewTextBoxColumn.DataPropertyName = "Mabp";
            this.mabpDataGridViewTextBoxColumn.HeaderText = "Mã bộ phận";
            this.mabpDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mabpDataGridViewTextBoxColumn.Name = "mabpDataGridViewTextBoxColumn";
            // 
            // tenbpDataGridViewTextBoxColumn
            // 
            this.tenbpDataGridViewTextBoxColumn.DataPropertyName = "Tenbp";
            this.tenbpDataGridViewTextBoxColumn.HeaderText = "Tên bộ phận";
            this.tenbpDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tenbpDataGridViewTextBoxColumn.Name = "tenbpDataGridViewTextBoxColumn";
            // 
            // sdtDataGridViewTextBoxColumn
            // 
            this.sdtDataGridViewTextBoxColumn.DataPropertyName = "sdt";
            this.sdtDataGridViewTextBoxColumn.HeaderText = "Số điện thoại";
            this.sdtDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sdtDataGridViewTextBoxColumn.Name = "sdtDataGridViewTextBoxColumn";
            // 
            // diachiDataGridViewTextBoxColumn
            // 
            this.diachiDataGridViewTextBoxColumn.DataPropertyName = "diachi";
            this.diachiDataGridViewTextBoxColumn.HeaderText = "Địa chỉ";
            this.diachiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.diachiDataGridViewTextBoxColumn.Name = "diachiDataGridViewTextBoxColumn";
            // 
            // dmbpBindingSource
            // 
            this.dmbpBindingSource.DataMember = "dmbp";
            this.dmbpBindingSource.DataSource = this.ketoantienluongDataSet2;
            // 
            // ketoantienluongDataSet2
            // 
            this.ketoantienluongDataSet2.DataSetName = "ketoantienluongDataSet2";
            this.ketoantienluongDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dmbpTableAdapter
            // 
            this.dmbpTableAdapter.ClearBeforeFill = true;
            // 
            // buttonHuy
            // 
            this.buttonHuy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHuy.Image = global::KeToanTienLuong.Properties.Resources.cancelled;
            this.buttonHuy.Location = new System.Drawing.Point(954, 72);
            this.buttonHuy.Name = "buttonHuy";
            this.buttonHuy.Size = new System.Drawing.Size(170, 42);
            this.buttonHuy.TabIndex = 73;
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
            this.buttonLuu.Location = new System.Drawing.Point(739, 72);
            this.buttonLuu.Name = "buttonLuu";
            this.buttonLuu.Size = new System.Drawing.Size(193, 42);
            this.buttonLuu.TabIndex = 72;
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
            this.buttonXoa.Location = new System.Drawing.Point(739, 203);
            this.buttonXoa.Name = "buttonXoa";
            this.buttonXoa.Size = new System.Drawing.Size(170, 42);
            this.buttonXoa.TabIndex = 71;
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
            this.buttonSua.Location = new System.Drawing.Point(954, 140);
            this.buttonSua.Name = "buttonSua";
            this.buttonSua.Size = new System.Drawing.Size(174, 42);
            this.buttonSua.TabIndex = 70;
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
            this.buttonThem.Location = new System.Drawing.Point(739, 140);
            this.buttonThem.Name = "buttonThem";
            this.buttonThem.Size = new System.Drawing.Size(170, 42);
            this.buttonThem.TabIndex = 69;
            this.buttonThem.Text = "  Thêm";
            this.buttonThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonThem.UseVisualStyleBackColor = true;
            this.buttonThem.Click += new System.EventHandler(this.button4_Click);
            // 
            // BoPhanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonHuy);
            this.Controls.Add(this.buttonLuu);
            this.Controls.Add(this.buttonXoa);
            this.Controls.Add(this.buttonSua);
            this.Controls.Add(this.buttonThem);
            this.Controls.Add(this.dataGridViewBoPhan);
            this.Controls.Add(this.inpDiaChi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.inpHotline);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.inpTenBoPhan);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inpMa);
            this.Controls.Add(this.label3);
            this.Name = "BoPhanForm";
            this.Size = new System.Drawing.Size(1202, 618);
            this.Load += new System.EventHandler(this.BoPhanForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBoPhan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dmbpBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ketoantienluongDataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox inpHotline;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox inpTenBoPhan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox inpMa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox inpDiaChi;
        private System.Windows.Forms.DataGridView dataGridViewBoPhan;
        private System.Windows.Forms.BindingSource dmbpBindingSource;
        private ketoantienluongDataSet2 ketoantienluongDataSet2;
        private ketoantienluongDataSet2TableAdapters.dmbpTableAdapter dmbpTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn mabpDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenbpDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sdtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diachiDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button buttonHuy;
        private System.Windows.Forms.Button buttonLuu;
        private System.Windows.Forms.Button buttonXoa;
        private System.Windows.Forms.Button buttonSua;
        private System.Windows.Forms.Button buttonThem;
    }
}
