
namespace KeToanTienLuong.chungtu
{
    partial class GiayBaoNoForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvchitietchungtu = new System.Windows.Forms.DataGridView();
            this.tkno = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dmtkBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ketoantienluongDataSet = new KeToanTienLuong.ketoantienluongDataSet();
            this.tkco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noidung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonLuu = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.cbomanh = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtctlq = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtngay = new System.Windows.Forms.DateTimePicker();
            this.cbomanv = new System.Windows.Forms.ComboBox();
            this.txtnoidung = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblmakh = new System.Windows.Forms.Label();
            this.txtso = new System.Windows.Forms.TextBox();
            this.lblngay = new System.Windows.Forms.Label();
            this.lblsp = new System.Windows.Forms.Label();
            this.dmtkTableAdapter = new KeToanTienLuong.ketoantienluongDataSetTableAdapters.dmtkTableAdapter();
            this.inpTien = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxTkNo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.inpTkCo = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvchitietchungtu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dmtkBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ketoantienluongDataSet)).BeginInit();
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
            this.dgvchitietchungtu.Location = new System.Drawing.Point(4, 326);
            this.dgvchitietchungtu.Margin = new System.Windows.Forms.Padding(4);
            this.dgvchitietchungtu.Name = "dgvchitietchungtu";
            this.dgvchitietchungtu.RowHeadersWidth = 51;
            this.dgvchitietchungtu.Size = new System.Drawing.Size(1221, 214);
            this.dgvchitietchungtu.TabIndex = 48;
            // 
            // tkno
            // 
            this.tkno.DataPropertyName = "tkno";
            this.tkno.DataSource = this.dmtkBindingSource;
            this.tkno.DisplayMember = "matk";
            this.tkno.HeaderText = "Tk nợ";
            this.tkno.MinimumWidth = 6;
            this.tkno.Name = "tkno";
            this.tkno.ValueMember = "matk";
            // 
            // dmtkBindingSource
            // 
            this.dmtkBindingSource.DataMember = "dmtk";
            this.dmtkBindingSource.DataSource = this.ketoantienluongDataSet;
            // 
            // ketoantienluongDataSet
            // 
            this.ketoantienluongDataSet.DataSetName = "ketoantienluongDataSet";
            this.ketoantienluongDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tkco
            // 
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            dataGridViewCellStyle1.Format = "N0";
            dataGridViewCellStyle1.NullValue = "0";
            this.tien.DefaultCellStyle = dataGridViewCellStyle1;
            this.tien.HeaderText = "Thành tiền";
            this.tien.MinimumWidth = 6;
            this.tien.Name = "tien";
            // 
            // buttonLuu
            // 
            this.buttonLuu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLuu.Image = global::KeToanTienLuong.Properties.Resources.checkmark;
            this.buttonLuu.Location = new System.Drawing.Point(826, 581);
            this.buttonLuu.Name = "buttonLuu";
            this.buttonLuu.Size = new System.Drawing.Size(164, 42);
            this.buttonLuu.TabIndex = 53;
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
            this.button3.Location = new System.Drawing.Point(1016, 581);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(152, 42);
            this.button3.TabIndex = 52;
            this.button3.Text = "   Hủy";
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // cbomanh
            // 
            this.cbomanh.FormattingEnabled = true;
            this.cbomanh.Location = new System.Drawing.Point(909, 129);
            this.cbomanh.Margin = new System.Windows.Forms.Padding(4);
            this.cbomanh.Name = "cbomanh";
            this.cbomanh.Size = new System.Drawing.Size(293, 24);
            this.cbomanh.TabIndex = 67;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(774, 136);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 23);
            this.label1.TabIndex = 66;
            this.label1.Text = "Ngân hàng";
            // 
            // txtctlq
            // 
            this.txtctlq.Location = new System.Drawing.Point(909, 184);
            this.txtctlq.Margin = new System.Windows.Forms.Padding(4);
            this.txtctlq.Name = "txtctlq";
            this.txtctlq.Size = new System.Drawing.Size(244, 22);
            this.txtctlq.TabIndex = 62;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(722, 190);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 23);
            this.label2.TabIndex = 65;
            this.label2.Text = "Chi tiết liên quan";
            // 
            // dtngay
            // 
            this.dtngay.CustomFormat = "dd/MM/yyyy";
            this.dtngay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtngay.Location = new System.Drawing.Point(909, 69);
            this.dtngay.Margin = new System.Windows.Forms.Padding(4);
            this.dtngay.Name = "dtngay";
            this.dtngay.Size = new System.Drawing.Size(160, 22);
            this.dtngay.TabIndex = 58;
            // 
            // cbomanv
            // 
            this.cbomanv.FormattingEnabled = true;
            this.cbomanv.Location = new System.Drawing.Point(164, 126);
            this.cbomanv.Margin = new System.Windows.Forms.Padding(4);
            this.cbomanv.Name = "cbomanv";
            this.cbomanv.Size = new System.Drawing.Size(201, 24);
            this.cbomanv.TabIndex = 60;
            // 
            // txtnoidung
            // 
            this.txtnoidung.Location = new System.Drawing.Point(909, 238);
            this.txtnoidung.Margin = new System.Windows.Forms.Padding(4);
            this.txtnoidung.Name = "txtnoidung";
            this.txtnoidung.Size = new System.Drawing.Size(293, 22);
            this.txtnoidung.TabIndex = 61;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(774, 236);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 23);
            this.label6.TabIndex = 64;
            this.label6.Text = "Nội dung";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // lblmakh
            // 
            this.lblmakh.AutoSize = true;
            this.lblmakh.BackColor = System.Drawing.Color.Transparent;
            this.lblmakh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmakh.Location = new System.Drawing.Point(31, 135);
            this.lblmakh.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblmakh.Name = "lblmakh";
            this.lblmakh.Size = new System.Drawing.Size(93, 23);
            this.lblmakh.TabIndex = 63;
            this.lblmakh.Text = "Nhân viên";
            // 
            // txtso
            // 
            this.txtso.Location = new System.Drawing.Point(164, 71);
            this.txtso.Margin = new System.Windows.Forms.Padding(4);
            this.txtso.Name = "txtso";
            this.txtso.Size = new System.Drawing.Size(160, 22);
            this.txtso.TabIndex = 56;
            // 
            // lblngay
            // 
            this.lblngay.AutoSize = true;
            this.lblngay.BackColor = System.Drawing.Color.Transparent;
            this.lblngay.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblngay.Location = new System.Drawing.Point(800, 69);
            this.lblngay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblngay.Name = "lblngay";
            this.lblngay.Size = new System.Drawing.Size(54, 23);
            this.lblngay.TabIndex = 59;
            this.lblngay.Text = "Ngày";
            // 
            // lblsp
            // 
            this.lblsp.AutoSize = true;
            this.lblsp.BackColor = System.Drawing.Color.Transparent;
            this.lblsp.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsp.Location = new System.Drawing.Point(33, 74);
            this.lblsp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblsp.Name = "lblsp";
            this.lblsp.Size = new System.Drawing.Size(81, 23);
            this.lblsp.TabIndex = 57;
            this.lblsp.Text = "Số phiếu";
            // 
            // dmtkTableAdapter
            // 
            this.dmtkTableAdapter.ClearBeforeFill = true;
            // 
            // inpTien
            // 
            this.inpTien.Location = new System.Drawing.Point(164, 181);
            this.inpTien.Margin = new System.Windows.Forms.Padding(4);
            this.inpTien.Name = "inpTien";
            this.inpTien.Size = new System.Drawing.Size(201, 22);
            this.inpTien.TabIndex = 69;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 179);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 23);
            this.label3.TabIndex = 70;
            this.label3.Text = "Số tiền";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(81, 238);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 23);
            this.label4.TabIndex = 72;
            this.label4.Text = "Tk nợ";
            // 
            // comboBoxTkNo
            // 
            this.comboBoxTkNo.FormattingEnabled = true;
            this.comboBoxTkNo.Location = new System.Drawing.Point(164, 238);
            this.comboBoxTkNo.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxTkNo.Name = "comboBoxTkNo";
            this.comboBoxTkNo.Size = new System.Drawing.Size(100, 24);
            this.comboBoxTkNo.TabIndex = 73;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(340, 239);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 23);
            this.label5.TabIndex = 74;
            this.label5.Text = "Tk có";
            // 
            // inpTkCo
            // 
            this.inpTkCo.Location = new System.Drawing.Point(423, 238);
            this.inpTkCo.Margin = new System.Windows.Forms.Padding(4);
            this.inpTkCo.Name = "inpTkCo";
            this.inpTkCo.ReadOnly = true;
            this.inpTkCo.Size = new System.Drawing.Size(81, 22);
            this.inpTkCo.TabIndex = 76;
            this.inpTkCo.Text = "1112";
            this.inpTkCo.TextChanged += new System.EventHandler(this.inpTkCo_TextChanged);
            // 
            // GiayBaoNoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.inpTkCo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBoxTkNo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.inpTien);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbomanh);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtctlq);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtngay);
            this.Controls.Add(this.cbomanv);
            this.Controls.Add(this.txtnoidung);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblmakh);
            this.Controls.Add(this.txtso);
            this.Controls.Add(this.lblngay);
            this.Controls.Add(this.lblsp);
            this.Controls.Add(this.buttonLuu);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dgvchitietchungtu);
            this.Name = "GiayBaoNoForm";
            this.Size = new System.Drawing.Size(1229, 626);
            this.Load += new System.EventHandler(this.GiayBaoNoForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvchitietchungtu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dmtkBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ketoantienluongDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvchitietchungtu;
        private System.Windows.Forms.Button buttonLuu;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox cbomanh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtctlq;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtngay;
        private System.Windows.Forms.ComboBox cbomanv;
        private System.Windows.Forms.TextBox txtnoidung;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblmakh;
        private System.Windows.Forms.TextBox txtso;
        private System.Windows.Forms.Label lblngay;
        private System.Windows.Forms.Label lblsp;
        private System.Windows.Forms.DataGridViewComboBoxColumn tkno;
        private System.Windows.Forms.BindingSource dmtkBindingSource;
        private ketoantienluongDataSet ketoantienluongDataSet;
        private System.Windows.Forms.DataGridViewTextBoxColumn tkco;
        private System.Windows.Forms.DataGridViewTextBoxColumn noidung;
        private System.Windows.Forms.DataGridViewTextBoxColumn tien;
        private ketoantienluongDataSetTableAdapters.dmtkTableAdapter dmtkTableAdapter;
        private System.Windows.Forms.TextBox inpTien;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxTkNo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox inpTkCo;
    }
}
