
namespace KeToanTienLuong.danhmucform
{
    partial class NganHangForm
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
            this.soDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tennhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chinhanhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dmnhBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ketoantienluongDataSet = new KeToanTienLuong.ketoantienluongDataSet();
            this.label2 = new System.Windows.Forms.Label();
            this.inpTen = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.inpMa = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.inpStk = new System.Windows.Forms.TextBox();
            this.dmcvBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dmcvTableAdapter = new KeToanTienLuong.ketoantienluongDataSetTableAdapters.dmcvTableAdapter();
            this.dmnhTableAdapter = new KeToanTienLuong.ketoantienluongDataSetTableAdapters.dmnhTableAdapter();
            this.label4 = new System.Windows.Forms.Label();
            this.inpChiNhanh = new System.Windows.Forms.TextBox();
            this.buttonHuy = new System.Windows.Forms.Button();
            this.buttonLuu = new System.Windows.Forms.Button();
            this.buttonXoa = new System.Windows.Forms.Button();
            this.buttonSua = new System.Windows.Forms.Button();
            this.buttonThem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dmnhBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ketoantienluongDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dmcvBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.soDataGridViewTextBoxColumn,
            this.stkDataGridViewTextBoxColumn,
            this.tennhDataGridViewTextBoxColumn,
            this.chinhanhDataGridViewTextBoxColumn});
            this.dataGridView.DataSource = this.dmnhBindingSource;
            this.dataGridView.Location = new System.Drawing.Point(3, 297);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(1164, 499);
            this.dataGridView.TabIndex = 57;
            this.dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellClick);
            // 
            // soDataGridViewTextBoxColumn
            // 
            this.soDataGridViewTextBoxColumn.DataPropertyName = "so";
            this.soDataGridViewTextBoxColumn.HeaderText = "Mã ngân hàng";
            this.soDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.soDataGridViewTextBoxColumn.Name = "soDataGridViewTextBoxColumn";
            // 
            // stkDataGridViewTextBoxColumn
            // 
            this.stkDataGridViewTextBoxColumn.DataPropertyName = "stk";
            this.stkDataGridViewTextBoxColumn.HeaderText = "Số tài khoản";
            this.stkDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.stkDataGridViewTextBoxColumn.Name = "stkDataGridViewTextBoxColumn";
            // 
            // tennhDataGridViewTextBoxColumn
            // 
            this.tennhDataGridViewTextBoxColumn.DataPropertyName = "tennh";
            this.tennhDataGridViewTextBoxColumn.HeaderText = "Tên ngân hàng";
            this.tennhDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tennhDataGridViewTextBoxColumn.Name = "tennhDataGridViewTextBoxColumn";
            // 
            // chinhanhDataGridViewTextBoxColumn
            // 
            this.chinhanhDataGridViewTextBoxColumn.DataPropertyName = "chinhanh";
            this.chinhanhDataGridViewTextBoxColumn.HeaderText = "Chi nhánh";
            this.chinhanhDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.chinhanhDataGridViewTextBoxColumn.Name = "chinhanhDataGridViewTextBoxColumn";
            // 
            // dmnhBindingSource
            // 
            this.dmnhBindingSource.DataMember = "dmnh";
            this.dmnhBindingSource.DataSource = this.ketoantienluongDataSet;
            // 
            // ketoantienluongDataSet
            // 
            this.ketoantienluongDataSet.DataSetName = "ketoantienluongDataSet";
            this.ketoantienluongDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 20);
            this.label2.TabIndex = 51;
            this.label2.Text = "Số tài khoản";
            // 
            // inpTen
            // 
            this.inpTen.Enabled = false;
            this.inpTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inpTen.Location = new System.Drawing.Point(229, 90);
            this.inpTen.Name = "inpTen";
            this.inpTen.Size = new System.Drawing.Size(336, 27);
            this.inpTen.TabIndex = 50;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 20);
            this.label1.TabIndex = 49;
            this.label1.Text = "Tên ngân hàng";
            // 
            // inpMa
            // 
            this.inpMa.Enabled = false;
            this.inpMa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inpMa.Location = new System.Drawing.Point(229, 37);
            this.inpMa.Name = "inpMa";
            this.inpMa.Size = new System.Drawing.Size(336, 27);
            this.inpMa.TabIndex = 48;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(40, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 20);
            this.label3.TabIndex = 47;
            this.label3.Text = "Mã ngân hàng";
            // 
            // inpStk
            // 
            this.inpStk.Enabled = false;
            this.inpStk.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inpStk.Location = new System.Drawing.Point(229, 150);
            this.inpStk.Name = "inpStk";
            this.inpStk.Size = new System.Drawing.Size(336, 27);
            this.inpStk.TabIndex = 52;
            // 
            // dmcvBindingSource
            // 
            this.dmcvBindingSource.DataMember = "dmcv";
            this.dmcvBindingSource.DataSource = this.ketoantienluongDataSet;
            // 
            // dmcvTableAdapter
            // 
            this.dmcvTableAdapter.ClearBeforeFill = true;
            // 
            // dmnhTableAdapter
            // 
            this.dmnhTableAdapter.ClearBeforeFill = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(40, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 20);
            this.label4.TabIndex = 58;
            this.label4.Text = "Chi nhánh";
            // 
            // inpChiNhanh
            // 
            this.inpChiNhanh.Enabled = false;
            this.inpChiNhanh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inpChiNhanh.Location = new System.Drawing.Point(229, 206);
            this.inpChiNhanh.Name = "inpChiNhanh";
            this.inpChiNhanh.Size = new System.Drawing.Size(336, 27);
            this.inpChiNhanh.TabIndex = 59;
            // 
            // buttonHuy
            // 
            this.buttonHuy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHuy.Image = global::KeToanTienLuong.Properties.Resources.cancelled;
            this.buttonHuy.Location = new System.Drawing.Point(913, 29);
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
            this.buttonLuu.Location = new System.Drawing.Point(698, 29);
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
            this.buttonXoa.Location = new System.Drawing.Point(698, 160);
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
            this.buttonSua.Location = new System.Drawing.Point(913, 97);
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
            this.buttonThem.Location = new System.Drawing.Point(698, 97);
            this.buttonThem.Name = "buttonThem";
            this.buttonThem.Size = new System.Drawing.Size(170, 42);
            this.buttonThem.TabIndex = 74;
            this.buttonThem.Text = "  Thêm";
            this.buttonThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonThem.UseVisualStyleBackColor = true;
            this.buttonThem.Click += new System.EventHandler(this.buttonThem_Click_1);
            // 
            // NganHangForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonHuy);
            this.Controls.Add(this.buttonLuu);
            this.Controls.Add(this.buttonXoa);
            this.Controls.Add(this.buttonSua);
            this.Controls.Add(this.buttonThem);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.inpChiNhanh);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.inpTen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inpMa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.inpStk);
            this.Name = "NganHangForm";
            this.Size = new System.Drawing.Size(1170, 799);
            this.Load += new System.EventHandler(this.NganHangForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dmnhBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ketoantienluongDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dmcvBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ketoantienluongDataSetTableAdapters.dmcvTableAdapter dmcvTableAdapter;
        private System.Windows.Forms.BindingSource dmcvBindingSource;
        private ketoantienluongDataSet ketoantienluongDataSet;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox inpTen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox inpMa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox inpStk;
        private System.Windows.Forms.BindingSource dmnhBindingSource;
        private ketoantienluongDataSetTableAdapters.dmnhTableAdapter dmnhTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn soDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stkDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tennhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn chinhanhDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox inpChiNhanh;
        private System.Windows.Forms.Button buttonHuy;
        private System.Windows.Forms.Button buttonLuu;
        private System.Windows.Forms.Button buttonXoa;
        private System.Windows.Forms.Button buttonSua;
        private System.Windows.Forms.Button buttonThem;
    }
}
