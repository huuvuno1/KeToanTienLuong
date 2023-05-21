
namespace KeToanTienLuong.chungtu
{
    partial class PhieuChiForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvchitietchungtu = new System.Windows.Forms.DataGridView();
            this.lblsp = new System.Windows.Forms.Label();
            this.lblngay = new System.Windows.Forms.Label();
            this.txtso = new System.Windows.Forms.TextBox();
            this.lblmakh = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtnoidung = new System.Windows.Forms.TextBox();
            this.cbomanv = new System.Windows.Forms.ComboBox();
            this.dtngay = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txtctlq = new System.Windows.Forms.TextBox();
            this.pnDoiTuong = new System.Windows.Forms.Panel();
            this.labelMessage = new System.Windows.Forms.Label();
            this.buttonLuu = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.ketoantienluongDataSet = new KeToanTienLuong.ketoantienluongDataSet();
            this.dmtkBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dmtkTableAdapter = new KeToanTienLuong.ketoantienluongDataSetTableAdapters.dmtkTableAdapter();
            this.tkno = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.tkco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noidung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvchitietchungtu)).BeginInit();
            this.pnDoiTuong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ketoantienluongDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dmtkBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvchitietchungtu
            // 
            this.dgvchitietchungtu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvchitietchungtu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvchitietchungtu.BackgroundColor = System.Drawing.Color.White;
            this.dgvchitietchungtu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvchitietchungtu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tkno,
            this.tkco,
            this.noidung,
            this.tien});
            this.dgvchitietchungtu.Location = new System.Drawing.Point(4, 366);
            this.dgvchitietchungtu.Margin = new System.Windows.Forms.Padding(4);
            this.dgvchitietchungtu.Name = "dgvchitietchungtu";
            this.dgvchitietchungtu.RowHeadersWidth = 51;
            this.dgvchitietchungtu.Size = new System.Drawing.Size(1166, 199);
            this.dgvchitietchungtu.TabIndex = 6;
            this.dgvchitietchungtu.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.kkk);
            // 
            // lblsp
            // 
            this.lblsp.AutoSize = true;
            this.lblsp.BackColor = System.Drawing.Color.Transparent;
            this.lblsp.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsp.Location = new System.Drawing.Point(17, 103);
            this.lblsp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblsp.Name = "lblsp";
            this.lblsp.Size = new System.Drawing.Size(81, 23);
            this.lblsp.TabIndex = 0;
            this.lblsp.Text = "Số phiếu";
            // 
            // lblngay
            // 
            this.lblngay.AutoSize = true;
            this.lblngay.BackColor = System.Drawing.Color.Transparent;
            this.lblngay.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblngay.Location = new System.Drawing.Point(784, 98);
            this.lblngay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblngay.Name = "lblngay";
            this.lblngay.Size = new System.Drawing.Size(54, 23);
            this.lblngay.TabIndex = 1;
            this.lblngay.Text = "Ngày";
            // 
            // txtso
            // 
            this.txtso.Location = new System.Drawing.Point(148, 100);
            this.txtso.Margin = new System.Windows.Forms.Padding(4);
            this.txtso.Name = "txtso";
            this.txtso.Size = new System.Drawing.Size(160, 28);
            this.txtso.TabIndex = 0;
            // 
            // lblmakh
            // 
            this.lblmakh.AutoSize = true;
            this.lblmakh.BackColor = System.Drawing.Color.Transparent;
            this.lblmakh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmakh.Location = new System.Drawing.Point(15, 164);
            this.lblmakh.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblmakh.Name = "lblmakh";
            this.lblmakh.Size = new System.Drawing.Size(93, 23);
            this.lblmakh.TabIndex = 6;
            this.lblmakh.Text = "Nhân viên";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 218);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 23);
            this.label6.TabIndex = 14;
            this.label6.Text = "Nội dung";
            // 
            // txtnoidung
            // 
            this.txtnoidung.Location = new System.Drawing.Point(148, 214);
            this.txtnoidung.Margin = new System.Windows.Forms.Padding(4);
            this.txtnoidung.Name = "txtnoidung";
            this.txtnoidung.Size = new System.Drawing.Size(293, 28);
            this.txtnoidung.TabIndex = 4;
            // 
            // cbomanv
            // 
            this.cbomanv.FormattingEnabled = true;
            this.cbomanv.Location = new System.Drawing.Point(148, 155);
            this.cbomanv.Margin = new System.Windows.Forms.Padding(4);
            this.cbomanv.Name = "cbomanv";
            this.cbomanv.Size = new System.Drawing.Size(293, 30);
            this.cbomanv.TabIndex = 2;
            // 
            // dtngay
            // 
            this.dtngay.CustomFormat = "dd/MM/yyyy";
            this.dtngay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtngay.Location = new System.Drawing.Point(893, 98);
            this.dtngay.Margin = new System.Windows.Forms.Padding(4);
            this.dtngay.Name = "dtngay";
            this.dtngay.Size = new System.Drawing.Size(160, 28);
            this.dtngay.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(706, 219);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 23);
            this.label2.TabIndex = 42;
            this.label2.Text = "Chi tiết liên quan";
            // 
            // txtctlq
            // 
            this.txtctlq.Location = new System.Drawing.Point(903, 213);
            this.txtctlq.Margin = new System.Windows.Forms.Padding(4);
            this.txtctlq.Name = "txtctlq";
            this.txtctlq.Size = new System.Drawing.Size(244, 28);
            this.txtctlq.TabIndex = 5;
            // 
            // pnDoiTuong
            // 
            this.pnDoiTuong.BackColor = System.Drawing.Color.Transparent;
            this.pnDoiTuong.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnDoiTuong.Controls.Add(this.labelMessage);
            this.pnDoiTuong.Controls.Add(this.txtctlq);
            this.pnDoiTuong.Controls.Add(this.label2);
            this.pnDoiTuong.Controls.Add(this.dtngay);
            this.pnDoiTuong.Controls.Add(this.cbomanv);
            this.pnDoiTuong.Controls.Add(this.txtnoidung);
            this.pnDoiTuong.Controls.Add(this.label6);
            this.pnDoiTuong.Controls.Add(this.lblmakh);
            this.pnDoiTuong.Controls.Add(this.txtso);
            this.pnDoiTuong.Controls.Add(this.lblngay);
            this.pnDoiTuong.Controls.Add(this.lblsp);
            this.pnDoiTuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnDoiTuong.Location = new System.Drawing.Point(4, 4);
            this.pnDoiTuong.Margin = new System.Windows.Forms.Padding(4);
            this.pnDoiTuong.Name = "pnDoiTuong";
            this.pnDoiTuong.Size = new System.Drawing.Size(1166, 354);
            this.pnDoiTuong.TabIndex = 5;
            this.pnDoiTuong.Paint += new System.Windows.Forms.PaintEventHandler(this.pnDoiTuong_Paint);
            // 
            // labelMessage
            // 
            this.labelMessage.AutoSize = true;
            this.labelMessage.BackColor = System.Drawing.Color.Transparent;
            this.labelMessage.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMessage.ForeColor = System.Drawing.Color.DarkRed;
            this.labelMessage.Location = new System.Drawing.Point(17, 277);
            this.labelMessage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Size = new System.Drawing.Size(0, 23);
            this.labelMessage.TabIndex = 43;
            // 
            // buttonLuu
            // 
            this.buttonLuu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLuu.Image = global::KeToanTienLuong.Properties.Resources.checkmark;
            this.buttonLuu.Location = new System.Drawing.Point(748, 627);
            this.buttonLuu.Name = "buttonLuu";
            this.buttonLuu.Size = new System.Drawing.Size(164, 42);
            this.buttonLuu.TabIndex = 51;
            this.buttonLuu.Text = "   Lưu";
            this.buttonLuu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonLuu.UseVisualStyleBackColor = true;
            this.buttonLuu.Click += new System.EventHandler(this.buttonLuu_Click);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Image = global::KeToanTienLuong.Properties.Resources.delete;
            this.button3.Location = new System.Drawing.Point(938, 627);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(152, 42);
            this.button3.TabIndex = 50;
            this.button3.Text = "   Hủy";
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // ketoantienluongDataSet
            // 
            this.ketoantienluongDataSet.DataSetName = "ketoantienluongDataSet";
            this.ketoantienluongDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dmtkBindingSource
            // 
            this.dmtkBindingSource.DataMember = "dmtk";
            this.dmtkBindingSource.DataSource = this.ketoantienluongDataSet;
            // 
            // dmtkTableAdapter
            // 
            this.dmtkTableAdapter.ClearBeforeFill = true;
            // 
            // tkno
            // 
            this.tkno.DataPropertyName = "tkno";
            this.tkno.DataSource = this.dmtkBindingSource;
            this.tkno.DisplayMember = "matk";
            this.tkno.HeaderText = "Tài khoản nợ";
            this.tkno.MinimumWidth = 6;
            this.tkno.Name = "tkno";
            this.tkno.ValueMember = "matk";
            // 
            // tkco
            // 
            this.tkco.DataPropertyName = "tkco";
            this.tkco.HeaderText = "Tài khoản có";
            this.tkco.MinimumWidth = 6;
            this.tkco.Name = "tkco";
            // 
            // noidung
            // 
            this.noidung.DataPropertyName = "noidung";
            this.noidung.HeaderText = "Nội dung";
            this.noidung.MinimumWidth = 6;
            this.noidung.Name = "noidung";
            // 
            // tien
            // 
            this.tien.DataPropertyName = "tien";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            dataGridViewCellStyle4.Format = "N0";
            dataGridViewCellStyle4.NullValue = "0";
            this.tien.DefaultCellStyle = dataGridViewCellStyle4;
            this.tien.HeaderText = "Thành tiền";
            this.tien.MinimumWidth = 6;
            this.tien.Name = "tien";
            // 
            // PhieuChiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonLuu);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.pnDoiTuong);
            this.Controls.Add(this.dgvchitietchungtu);
            this.Name = "PhieuChiForm";
            this.Size = new System.Drawing.Size(1175, 689);
            this.Load += new System.EventHandler(this.PhieuChiForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvchitietchungtu)).EndInit();
            this.pnDoiTuong.ResumeLayout(false);
            this.pnDoiTuong.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ketoantienluongDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dmtkBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvchitietchungtu;
        private System.Windows.Forms.Label lblsp;
        private System.Windows.Forms.Label lblngay;
        private System.Windows.Forms.TextBox txtso;
        private System.Windows.Forms.Label lblmakh;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtnoidung;
        private System.Windows.Forms.ComboBox cbomanv;
        private System.Windows.Forms.DateTimePicker dtngay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtctlq;
        private System.Windows.Forms.Panel pnDoiTuong;
        private System.Windows.Forms.Button buttonLuu;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label labelMessage;
        private System.Windows.Forms.BindingSource dmtkBindingSource;
        private ketoantienluongDataSet ketoantienluongDataSet;
        private ketoantienluongDataSetTableAdapters.dmtkTableAdapter dmtkTableAdapter;
        private System.Windows.Forms.DataGridViewComboBoxColumn tkno;
        private System.Windows.Forms.DataGridViewTextBoxColumn tkco;
        private System.Windows.Forms.DataGridViewTextBoxColumn noidung;
        private System.Windows.Forms.DataGridViewTextBoxColumn tien;
    }
}
