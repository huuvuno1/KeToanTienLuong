
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
            this.cbomabp = new System.Windows.Forms.ComboBox();
            this.lblmakh = new System.Windows.Forms.Label();
            this.txtngaycong = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtnoidung = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtthang = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtnam = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtso = new System.Windows.Forms.TextBox();
            this.lblsp = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonUpload = new System.Windows.Forms.Button();
            this.buttonLuu = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridViewChamCong = new System.Windows.Forms.DataGridView();
            this.chitietbangccBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ketoantienluongDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ketoantienluongDataSet = new KeToanTienLuong.ketoantienluongDataSet();
            this.buttonXem = new System.Windows.Forms.Button();
            this.buttonThem = new System.Windows.Forms.Button();
            this.chitietbangccTableAdapter = new KeToanTienLuong.ketoantienluongDataSetTableAdapters.chitietbangccTableAdapter();
            this.panelContentBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChamCong)).BeginInit();
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
            this.panelContentBox.Controls.Add(this.cbomabp);
            this.panelContentBox.Controls.Add(this.lblmakh);
            this.panelContentBox.Controls.Add(this.txtngaycong);
            this.panelContentBox.Controls.Add(this.label4);
            this.panelContentBox.Controls.Add(this.txtnoidung);
            this.panelContentBox.Controls.Add(this.label6);
            this.panelContentBox.Controls.Add(this.txtthang);
            this.panelContentBox.Controls.Add(this.label3);
            this.panelContentBox.Controls.Add(this.txtnam);
            this.panelContentBox.Controls.Add(this.label5);
            this.panelContentBox.Controls.Add(this.txtso);
            this.panelContentBox.Controls.Add(this.lblsp);
            this.panelContentBox.Controls.Add(this.button4);
            this.panelContentBox.Controls.Add(this.button1);
            this.panelContentBox.Controls.Add(this.buttonUpload);
            this.panelContentBox.Controls.Add(this.buttonLuu);
            this.panelContentBox.Controls.Add(this.button3);
            this.panelContentBox.Controls.Add(this.dataGridViewChamCong);
            this.panelContentBox.Location = new System.Drawing.Point(0, 126);
            this.panelContentBox.Name = "panelContentBox";
            this.panelContentBox.Size = new System.Drawing.Size(1125, 744);
            this.panelContentBox.TabIndex = 33;
            this.panelContentBox.Paint += new System.Windows.Forms.PaintEventHandler(this.panelContentBox_Paint);
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
            // lblmakh
            // 
            this.lblmakh.AutoSize = true;
            this.lblmakh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmakh.Location = new System.Drawing.Point(659, 72);
            this.lblmakh.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblmakh.Name = "lblmakh";
            this.lblmakh.Size = new System.Drawing.Size(78, 23);
            this.lblmakh.TabIndex = 58;
            this.lblmakh.Text = "Bộ phận";
            // 
            // txtngaycong
            // 
            this.txtngaycong.Location = new System.Drawing.Point(786, 28);
            this.txtngaycong.Margin = new System.Windows.Forms.Padding(4);
            this.txtngaycong.Name = "txtngaycong";
            this.txtngaycong.Size = new System.Drawing.Size(233, 22);
            this.txtngaycong.TabIndex = 57;
            this.txtngaycong.Text = "0";
            this.txtngaycong.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(553, 26);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(184, 23);
            this.label4.TabIndex = 56;
            this.label4.Text = "Ngày công của tháng";
            // 
            // txtnoidung
            // 
            this.txtnoidung.Location = new System.Drawing.Point(786, 115);
            this.txtnoidung.Margin = new System.Windows.Forms.Padding(4);
            this.txtnoidung.Name = "txtnoidung";
            this.txtnoidung.Size = new System.Drawing.Size(288, 22);
            this.txtnoidung.TabIndex = 55;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(653, 115);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 23);
            this.label6.TabIndex = 54;
            this.label6.Text = "Nội dung";
            // 
            // txtthang
            // 
            this.txtthang.Location = new System.Drawing.Point(168, 66);
            this.txtthang.Margin = new System.Windows.Forms.Padding(4);
            this.txtthang.Name = "txtthang";
            this.txtthang.Size = new System.Drawing.Size(160, 22);
            this.txtthang.TabIndex = 49;
            this.txtthang.Text = "0";
            this.txtthang.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtthang.TextChanged += new System.EventHandler(this.txtthang_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(37, 64);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 23);
            this.label3.TabIndex = 48;
            this.label3.Text = "Tháng";
            // 
            // txtnam
            // 
            this.txtnam.Location = new System.Drawing.Point(168, 107);
            this.txtnam.Margin = new System.Windows.Forms.Padding(4);
            this.txtnam.Name = "txtnam";
            this.txtnam.Size = new System.Drawing.Size(160, 22);
            this.txtnam.TabIndex = 47;
            this.txtnam.Text = "0";
            this.txtnam.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(37, 105);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 23);
            this.label5.TabIndex = 46;
            this.label5.Text = "Năm";
            // 
            // txtso
            // 
            this.txtso.Location = new System.Drawing.Point(168, 28);
            this.txtso.Margin = new System.Windows.Forms.Padding(4);
            this.txtso.Name = "txtso";
            this.txtso.Size = new System.Drawing.Size(160, 22);
            this.txtso.TabIndex = 43;
            // 
            // lblsp
            // 
            this.lblsp.AutoSize = true;
            this.lblsp.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsp.Location = new System.Drawing.Point(37, 26);
            this.lblsp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblsp.Name = "lblsp";
            this.lblsp.Size = new System.Drawing.Size(31, 23);
            this.lblsp.TabIndex = 42;
            this.lblsp.Text = "Số";
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
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::KeToanTienLuong.Properties.Resources.download2;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.Location = new System.Drawing.Point(627, 193);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(203, 91);
            this.button1.TabIndex = 38;
            this.button1.Text = " Tải file mẫu";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonUpload
            // 
            this.buttonUpload.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonUpload.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpload.Image = global::KeToanTienLuong.Properties.Resources.upload_file;
            this.buttonUpload.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonUpload.Location = new System.Drawing.Point(353, 193);
            this.buttonUpload.Name = "buttonUpload";
            this.buttonUpload.Size = new System.Drawing.Size(236, 91);
            this.buttonUpload.TabIndex = 35;
            this.buttonUpload.Text = "  Tải lên file chấm công";
            this.buttonUpload.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonUpload.UseVisualStyleBackColor = true;
            this.buttonUpload.Click += new System.EventHandler(this.buttonUpload_Click);
            // 
            // buttonLuu
            // 
            this.buttonLuu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLuu.Image = global::KeToanTienLuong.Properties.Resources.checkmark;
            this.buttonLuu.Location = new System.Drawing.Point(770, 674);
            this.buttonLuu.Name = "buttonLuu";
            this.buttonLuu.Size = new System.Drawing.Size(137, 42);
            this.buttonLuu.TabIndex = 34;
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
            this.button3.Location = new System.Drawing.Point(954, 674);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(137, 42);
            this.button3.TabIndex = 33;
            this.button3.Text = "   Reset";
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // dataGridViewChamCong
            // 
            this.dataGridViewChamCong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewChamCong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewChamCong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewChamCong.Location = new System.Drawing.Point(-1, 313);
            this.dataGridViewChamCong.Name = "dataGridViewChamCong";
            this.dataGridViewChamCong.RowHeadersWidth = 51;
            this.dataGridViewChamCong.RowTemplate.Height = 24;
            this.dataGridViewChamCong.Size = new System.Drawing.Size(1121, 323);
            this.dataGridViewChamCong.TabIndex = 27;
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
            // buttonXem
            // 
            this.buttonXem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonXem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonXem.Image = global::KeToanTienLuong.Properties.Resources.eye;
            this.buttonXem.Location = new System.Drawing.Point(918, 36);
            this.buttonXem.Name = "buttonXem";
            this.buttonXem.Size = new System.Drawing.Size(175, 63);
            this.buttonXem.TabIndex = 32;
            this.buttonXem.Text = "   Xem bảng công";
            this.buttonXem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonXem.UseVisualStyleBackColor = true;
            // 
            // buttonThem
            // 
            this.buttonThem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonThem.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonThem.Image = global::KeToanTienLuong.Properties.Resources.plus;
            this.buttonThem.Location = new System.Drawing.Point(629, 36);
            this.buttonThem.Name = "buttonThem";
            this.buttonThem.Size = new System.Drawing.Size(194, 63);
            this.buttonThem.TabIndex = 31;
            this.buttonThem.Text = "  Cập nhật công tháng";
            this.buttonThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonThem.UseVisualStyleBackColor = false;
            // 
            // chitietbangccTableAdapter
            // 
            this.chitietbangccTableAdapter.ClearBeforeFill = true;
            // 
            // ChamCongForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelContentBox);
            this.Controls.Add(this.buttonXem);
            this.Controls.Add(this.buttonThem);
            this.Name = "ChamCongForm";
            this.Size = new System.Drawing.Size(1125, 873);
            this.Load += new System.EventHandler(this.ChamCongForm_Load);
            this.panelContentBox.ResumeLayout(false);
            this.panelContentBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChamCong)).EndInit();
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
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox txtthang;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtnam;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtso;
        private System.Windows.Forms.Label lblsp;
        private System.Windows.Forms.ComboBox cbomabp;
        private System.Windows.Forms.Label lblmakh;
        private System.Windows.Forms.TextBox txtngaycong;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtnoidung;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.BindingSource chitietbangccBindingSource;
        private System.Windows.Forms.BindingSource ketoantienluongDataSetBindingSource;
        private ketoantienluongDataSet ketoantienluongDataSet;
        private ketoantienluongDataSetTableAdapters.chitietbangccTableAdapter chitietbangccTableAdapter;
    }
}
