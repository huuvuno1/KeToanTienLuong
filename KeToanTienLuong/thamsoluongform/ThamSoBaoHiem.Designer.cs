
namespace KeToanTienLuong.thamsoluongform
{
    partial class ThamSoBaoHiem
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
            this.matsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tentsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noidungDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tyleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thamsoluongBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ketoantienluongDataSet = new KeToanTienLuong.ketoantienluongDataSet();
            this.thamsoluongTableAdapter = new KeToanTienLuong.ketoantienluongDataSetTableAdapters.thamsoluongTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thamsoluongBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ketoantienluongDataSet)).BeginInit();
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
            this.matsDataGridViewTextBoxColumn,
            this.tentsDataGridViewTextBoxColumn,
            this.noidungDataGridViewTextBoxColumn,
            this.tyleDataGridViewTextBoxColumn});
            this.dataGridView.DataSource = this.thamsoluongBindingSource;
            this.dataGridView.Location = new System.Drawing.Point(45, 232);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(1215, 436);
            this.dataGridView.TabIndex = 70;
            // 
            // matsDataGridViewTextBoxColumn
            // 
            this.matsDataGridViewTextBoxColumn.DataPropertyName = "mats";
            this.matsDataGridViewTextBoxColumn.HeaderText = "Mã tham số";
            this.matsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.matsDataGridViewTextBoxColumn.Name = "matsDataGridViewTextBoxColumn";
            // 
            // tentsDataGridViewTextBoxColumn
            // 
            this.tentsDataGridViewTextBoxColumn.DataPropertyName = "tents";
            this.tentsDataGridViewTextBoxColumn.HeaderText = "Tên tham số";
            this.tentsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tentsDataGridViewTextBoxColumn.Name = "tentsDataGridViewTextBoxColumn";
            // 
            // noidungDataGridViewTextBoxColumn
            // 
            this.noidungDataGridViewTextBoxColumn.DataPropertyName = "noidung";
            this.noidungDataGridViewTextBoxColumn.HeaderText = "Nội dung";
            this.noidungDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.noidungDataGridViewTextBoxColumn.Name = "noidungDataGridViewTextBoxColumn";
            // 
            // tyleDataGridViewTextBoxColumn
            // 
            this.tyleDataGridViewTextBoxColumn.DataPropertyName = "tyle";
            this.tyleDataGridViewTextBoxColumn.HeaderText = "Tỷ lệ";
            this.tyleDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tyleDataGridViewTextBoxColumn.Name = "tyleDataGridViewTextBoxColumn";
            // 
            // thamsoluongBindingSource
            // 
            this.thamsoluongBindingSource.DataMember = "thamsoluong";
            this.thamsoluongBindingSource.DataSource = this.ketoantienluongDataSet;
            // 
            // ketoantienluongDataSet
            // 
            this.ketoantienluongDataSet.DataSetName = "ketoantienluongDataSet";
            this.ketoantienluongDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // thamsoluongTableAdapter
            // 
            this.thamsoluongTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(497, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 32);
            this.label1.TabIndex = 71;
            this.label1.Text = "Tham số tính lương";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ThamSoBaoHiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView);
            this.Name = "ThamSoBaoHiem";
            this.Size = new System.Drawing.Size(1295, 793);
            this.Load += new System.EventHandler(this.ThamSoBaoHiem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thamsoluongBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ketoantienluongDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn matsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tentsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noidungDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tyleDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource thamsoluongBindingSource;
        private ketoantienluongDataSet ketoantienluongDataSet;
        private ketoantienluongDataSetTableAdapters.thamsoluongTableAdapter thamsoluongTableAdapter;
        private System.Windows.Forms.Label label1;
    }
}
