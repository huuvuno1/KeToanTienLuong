
namespace KeToanTienLuong.danhmucform
{
    partial class ChucVuForm
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
            this.inpMoTa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.inpTen = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.inpMaCv = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.macvDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tencvDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.motaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dmcvBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ketoantienluongDataSet = new KeToanTienLuong.ketoantienluongDataSet();
            this.dmcvTableAdapter = new KeToanTienLuong.ketoantienluongDataSetTableAdapters.dmcvTableAdapter();
            this.buttonHuy = new System.Windows.Forms.Button();
            this.buttonLuu = new System.Windows.Forms.Button();
            this.buttonXoa = new System.Windows.Forms.Button();
            this.buttonSua = new System.Windows.Forms.Button();
            this.buttonThem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dmcvBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ketoantienluongDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // inpMoTa
            // 
            this.inpMoTa.Enabled = false;
            this.inpMoTa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inpMoTa.Location = new System.Drawing.Point(226, 156);
            this.inpMoTa.Name = "inpMoTa";
            this.inpMoTa.Size = new System.Drawing.Size(336, 27);
            this.inpMoTa.TabIndex = 40;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 20);
            this.label2.TabIndex = 39;
            this.label2.Text = "Mô tả";
            // 
            // inpTen
            // 
            this.inpTen.Enabled = false;
            this.inpTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inpTen.Location = new System.Drawing.Point(226, 96);
            this.inpTen.Name = "inpTen";
            this.inpTen.Size = new System.Drawing.Size(336, 27);
            this.inpTen.TabIndex = 38;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 20);
            this.label1.TabIndex = 37;
            this.label1.Text = "Tên chức vụ";
            // 
            // inpMaCv
            // 
            this.inpMaCv.Enabled = false;
            this.inpMaCv.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inpMaCv.Location = new System.Drawing.Point(226, 43);
            this.inpMaCv.Name = "inpMaCv";
            this.inpMaCv.Size = new System.Drawing.Size(336, 27);
            this.inpMaCv.TabIndex = 36;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(37, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 20);
            this.label3.TabIndex = 35;
            this.label3.Text = "Mã chức vụ";
            // 
            // dataGridView
            // 
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.macvDataGridViewTextBoxColumn,
            this.tencvDataGridViewTextBoxColumn,
            this.motaDataGridViewTextBoxColumn});
            this.dataGridView.DataSource = this.dmcvBindingSource;
            this.dataGridView.Location = new System.Drawing.Point(0, 303);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(1212, 436);
            this.dataGridView.TabIndex = 46;
            this.dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellClick);
            // 
            // macvDataGridViewTextBoxColumn
            // 
            this.macvDataGridViewTextBoxColumn.DataPropertyName = "macv";
            this.macvDataGridViewTextBoxColumn.HeaderText = "Mã chức vụ";
            this.macvDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.macvDataGridViewTextBoxColumn.Name = "macvDataGridViewTextBoxColumn";
            // 
            // tencvDataGridViewTextBoxColumn
            // 
            this.tencvDataGridViewTextBoxColumn.DataPropertyName = "tencv";
            this.tencvDataGridViewTextBoxColumn.HeaderText = "Tên chức vụ";
            this.tencvDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tencvDataGridViewTextBoxColumn.Name = "tencvDataGridViewTextBoxColumn";
            // 
            // motaDataGridViewTextBoxColumn
            // 
            this.motaDataGridViewTextBoxColumn.DataPropertyName = "mota";
            this.motaDataGridViewTextBoxColumn.HeaderText = "Mô tả";
            this.motaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.motaDataGridViewTextBoxColumn.Name = "motaDataGridViewTextBoxColumn";
            // 
            // dmcvBindingSource
            // 
            this.dmcvBindingSource.DataMember = "dmcv";
            this.dmcvBindingSource.DataSource = this.ketoantienluongDataSet;
            // 
            // ketoantienluongDataSet
            // 
            this.ketoantienluongDataSet.DataSetName = "ketoantienluongDataSet";
            this.ketoantienluongDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dmcvTableAdapter
            // 
            this.dmcvTableAdapter.ClearBeforeFill = true;
            // 
            // buttonHuy
            // 
            this.buttonHuy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHuy.Image = global::KeToanTienLuong.Properties.Resources.cancelled;
            this.buttonHuy.Location = new System.Drawing.Point(998, 35);
            this.buttonHuy.Name = "buttonHuy";
            this.buttonHuy.Size = new System.Drawing.Size(170, 42);
            this.buttonHuy.TabIndex = 78;
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
            this.buttonLuu.Location = new System.Drawing.Point(783, 35);
            this.buttonLuu.Name = "buttonLuu";
            this.buttonLuu.Size = new System.Drawing.Size(193, 42);
            this.buttonLuu.TabIndex = 77;
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
            this.buttonXoa.Location = new System.Drawing.Point(783, 166);
            this.buttonXoa.Name = "buttonXoa";
            this.buttonXoa.Size = new System.Drawing.Size(170, 42);
            this.buttonXoa.TabIndex = 76;
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
            this.buttonSua.Location = new System.Drawing.Point(998, 103);
            this.buttonSua.Name = "buttonSua";
            this.buttonSua.Size = new System.Drawing.Size(174, 42);
            this.buttonSua.TabIndex = 75;
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
            this.buttonThem.Location = new System.Drawing.Point(783, 103);
            this.buttonThem.Name = "buttonThem";
            this.buttonThem.Size = new System.Drawing.Size(170, 42);
            this.buttonThem.TabIndex = 74;
            this.buttonThem.Text = "  Thêm";
            this.buttonThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonThem.UseVisualStyleBackColor = true;
            this.buttonThem.Click += new System.EventHandler(this.buttonThem_Click_1);
            // 
            // ChucVuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonHuy);
            this.Controls.Add(this.buttonLuu);
            this.Controls.Add(this.buttonXoa);
            this.Controls.Add(this.buttonSua);
            this.Controls.Add(this.buttonThem);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.inpMoTa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.inpTen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inpMaCv);
            this.Controls.Add(this.label3);
            this.Name = "ChucVuForm";
            this.Size = new System.Drawing.Size(1215, 739);
            this.Load += new System.EventHandler(this.ChucVuForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dmcvBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ketoantienluongDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox inpMoTa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox inpTen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox inpMaCv;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn macvDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tencvDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn motaDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource dmcvBindingSource;
        private ketoantienluongDataSet ketoantienluongDataSet;
        private ketoantienluongDataSetTableAdapters.dmcvTableAdapter dmcvTableAdapter;
        private System.Windows.Forms.Button buttonHuy;
        private System.Windows.Forms.Button buttonLuu;
        private System.Windows.Forms.Button buttonXoa;
        private System.Windows.Forms.Button buttonSua;
        private System.Windows.Forms.Button buttonThem;
    }
}
