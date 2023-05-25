
namespace KeToanTienLuong.thamsoluongform
{
    partial class ThamSoThueForm
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
            this.thamsothuetncnBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ketoantienluongDataSet = new KeToanTienLuong.ketoantienluongDataSet();
            this.thamsothuetncnTableAdapter = new KeToanTienLuong.ketoantienluongDataSetTableAdapters.thamsothuetncnTableAdapter();
            this.mucthueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tientuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tiendenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tyleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thamsothuetncnBindingSource)).BeginInit();
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
            this.mucthueDataGridViewTextBoxColumn,
            this.tientuDataGridViewTextBoxColumn,
            this.tiendenDataGridViewTextBoxColumn,
            this.tyleDataGridViewTextBoxColumn});
            this.dataGridView.DataSource = this.thamsothuetncnBindingSource;
            this.dataGridView.Location = new System.Drawing.Point(44, 187);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(1135, 503);
            this.dataGridView.TabIndex = 57;
            // 
            // thamsothuetncnBindingSource
            // 
            this.thamsothuetncnBindingSource.DataMember = "thamsothuetncn";
            this.thamsothuetncnBindingSource.DataSource = this.ketoantienluongDataSet;
            // 
            // ketoantienluongDataSet
            // 
            this.ketoantienluongDataSet.DataSetName = "ketoantienluongDataSet";
            this.ketoantienluongDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // thamsothuetncnTableAdapter
            // 
            this.thamsothuetncnTableAdapter.ClearBeforeFill = true;
            // 
            // mucthueDataGridViewTextBoxColumn
            // 
            this.mucthueDataGridViewTextBoxColumn.DataPropertyName = "mucthue";
            this.mucthueDataGridViewTextBoxColumn.HeaderText = "Mức thuê";
            this.mucthueDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mucthueDataGridViewTextBoxColumn.Name = "mucthueDataGridViewTextBoxColumn";
            // 
            // tientuDataGridViewTextBoxColumn
            // 
            this.tientuDataGridViewTextBoxColumn.DataPropertyName = "tientu";
            this.tientuDataGridViewTextBoxColumn.HeaderText = "Từ mức tiền";
            this.tientuDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tientuDataGridViewTextBoxColumn.Name = "tientuDataGridViewTextBoxColumn";
            // 
            // tiendenDataGridViewTextBoxColumn
            // 
            this.tiendenDataGridViewTextBoxColumn.DataPropertyName = "tienden";
            this.tiendenDataGridViewTextBoxColumn.HeaderText = "Đến mức tiền";
            this.tiendenDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tiendenDataGridViewTextBoxColumn.Name = "tiendenDataGridViewTextBoxColumn";
            // 
            // tyleDataGridViewTextBoxColumn
            // 
            this.tyleDataGridViewTextBoxColumn.DataPropertyName = "tyle";
            this.tyleDataGridViewTextBoxColumn.HeaderText = "Tỷ lệ";
            this.tyleDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tyleDataGridViewTextBoxColumn.Name = "tyleDataGridViewTextBoxColumn";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(378, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(476, 32);
            this.label1.TabIndex = 58;
            this.label1.Text = "Biểu tính thuế TNCN lũy tiến 2023";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ThamSoThueForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView);
            this.Name = "ThamSoThueForm";
            this.Size = new System.Drawing.Size(1216, 763);
            this.Load += new System.EventHandler(this.ThamSoThueForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thamsothuetncnBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ketoantienluongDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.BindingSource thamsothuetncnBindingSource;
        private ketoantienluongDataSet ketoantienluongDataSet;
        private ketoantienluongDataSetTableAdapters.thamsothuetncnTableAdapter thamsothuetncnTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn mucthueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tientuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tiendenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tyleDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
    }
}
