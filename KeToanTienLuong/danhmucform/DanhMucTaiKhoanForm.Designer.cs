
namespace KeToanTienLuong.danhmucform
{
    partial class DanhMucTaiKhoanForm
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
            this.lalcap = new System.Windows.Forms.Label();
            this.pnDoiTuong = new System.Windows.Forms.Panel();
            this.inpMaTk = new System.Windows.Forms.TextBox();
            this.cbotkme = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblmota = new System.Windows.Forms.Label();
            this.inpTenTk = new System.Windows.Forms.TextBox();
            this.lblten = new System.Windows.Forms.Label();
            this.inpCapTk = new System.Windows.Forms.TextBox();
            this.lblma = new System.Windows.Forms.Label();
            this.pnCacNut = new System.Windows.Forms.Panel();
            this.buttonXoa = new System.Windows.Forms.Button();
            this.buttonHuy = new System.Windows.Forms.Button();
            this.buttonSua = new System.Windows.Forms.Button();
            this.buttonLuu = new System.Windows.Forms.Button();
            this.buttonThem = new System.Windows.Forms.Button();
            this.captk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tkme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pndgv = new System.Windows.Forms.Panel();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.tentk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnDoiTuong.SuspendLayout();
            this.pnCacNut.SuspendLayout();
            this.pndgv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // lalcap
            // 
            this.lalcap.AutoSize = true;
            this.lalcap.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lalcap.Location = new System.Drawing.Point(508, 44);
            this.lalcap.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lalcap.Name = "lalcap";
            this.lalcap.Size = new System.Drawing.Size(76, 23);
            this.lalcap.TabIndex = 7;
            this.lalcap.Text = "Cấp TK";
            // 
            // pnDoiTuong
            // 
            this.pnDoiTuong.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnDoiTuong.BackColor = System.Drawing.Color.DarkGray;
            this.pnDoiTuong.Controls.Add(this.inpMaTk);
            this.pnDoiTuong.Controls.Add(this.lalcap);
            this.pnDoiTuong.Controls.Add(this.cbotkme);
            this.pnDoiTuong.Controls.Add(this.label1);
            this.pnDoiTuong.Controls.Add(this.lblmota);
            this.pnDoiTuong.Controls.Add(this.inpTenTk);
            this.pnDoiTuong.Controls.Add(this.lblten);
            this.pnDoiTuong.Controls.Add(this.inpCapTk);
            this.pnDoiTuong.Controls.Add(this.lblma);
            this.pnDoiTuong.Location = new System.Drawing.Point(15, 25);
            this.pnDoiTuong.Margin = new System.Windows.Forms.Padding(4);
            this.pnDoiTuong.Name = "pnDoiTuong";
            this.pnDoiTuong.Size = new System.Drawing.Size(1245, 193);
            this.pnDoiTuong.TabIndex = 4;
            this.pnDoiTuong.Paint += new System.Windows.Forms.PaintEventHandler(this.pnDoiTuong_Paint);
            // 
            // inpMaTk
            // 
            this.inpMaTk.BackColor = System.Drawing.Color.White;
            this.inpMaTk.Enabled = false;
            this.inpMaTk.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inpMaTk.Location = new System.Drawing.Point(183, 44);
            this.inpMaTk.Margin = new System.Windows.Forms.Padding(4);
            this.inpMaTk.Name = "inpMaTk";
            this.inpMaTk.Size = new System.Drawing.Size(207, 28);
            this.inpMaTk.TabIndex = 8;
            // 
            // cbotkme
            // 
            this.cbotkme.Enabled = false;
            this.cbotkme.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbotkme.FormattingEnabled = true;
            this.cbotkme.Items.AddRange(new object[] {
            "111",
            "112",
            "113",
            "121",
            "128",
            "131",
            "133",
            "136",
            "138",
            "141",
            "151",
            "152",
            "153",
            "154",
            "155",
            "156",
            "157",
            "158",
            "161",
            "171",
            "211",
            "212",
            "213",
            "214",
            "217",
            "221",
            "222",
            "228",
            "229",
            "241",
            "242",
            "243",
            "244",
            "331",
            "333",
            "334",
            "335",
            "336",
            "337",
            "338",
            "341",
            "343",
            "344",
            "347",
            "352",
            "353",
            "356",
            "357",
            "411",
            "412",
            "413",
            "414",
            "417",
            "418",
            "419",
            "421",
            "441",
            "461",
            "466",
            "511",
            "515",
            "521",
            "611",
            "621",
            "622",
            "623",
            "627",
            "631",
            "632",
            "635",
            "641",
            "642",
            "711",
            "811",
            "821",
            "911"});
            this.cbotkme.Location = new System.Drawing.Point(183, 122);
            this.cbotkme.Margin = new System.Windows.Forms.Padding(4);
            this.cbotkme.Name = "cbotkme";
            this.cbotkme.Size = new System.Drawing.Size(131, 28);
            this.cbotkme.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(599, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 24);
            this.label1.TabIndex = 6;
            // 
            // lblmota
            // 
            this.lblmota.AutoSize = true;
            this.lblmota.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmota.Location = new System.Drawing.Point(27, 122);
            this.lblmota.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblmota.Name = "lblmota";
            this.lblmota.Size = new System.Drawing.Size(101, 23);
            this.lblmota.TabIndex = 4;
            this.lblmota.Text = "TK cấp mẹ";
            // 
            // inpTenTk
            // 
            this.inpTenTk.BackColor = System.Drawing.Color.White;
            this.inpTenTk.Enabled = false;
            this.inpTenTk.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inpTenTk.Location = new System.Drawing.Point(639, 118);
            this.inpTenTk.Margin = new System.Windows.Forms.Padding(4);
            this.inpTenTk.Name = "inpTenTk";
            this.inpTenTk.Size = new System.Drawing.Size(331, 28);
            this.inpTenTk.TabIndex = 3;
            // 
            // lblten
            // 
            this.lblten.AutoSize = true;
            this.lblten.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblten.Location = new System.Drawing.Point(503, 122);
            this.lblten.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblten.Name = "lblten";
            this.lblten.Size = new System.Drawing.Size(74, 23);
            this.lblten.TabIndex = 2;
            this.lblten.Text = "Tên TK";
            // 
            // inpCapTk
            // 
            this.inpCapTk.BackColor = System.Drawing.Color.White;
            this.inpCapTk.Enabled = false;
            this.inpCapTk.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inpCapTk.Location = new System.Drawing.Point(639, 47);
            this.inpCapTk.Margin = new System.Windows.Forms.Padding(4);
            this.inpCapTk.Name = "inpCapTk";
            this.inpCapTk.Size = new System.Drawing.Size(207, 28);
            this.inpCapTk.TabIndex = 1;
            // 
            // lblma
            // 
            this.lblma.AutoSize = true;
            this.lblma.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblma.Location = new System.Drawing.Point(57, 46);
            this.lblma.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblma.Name = "lblma";
            this.lblma.Size = new System.Drawing.Size(70, 23);
            this.lblma.TabIndex = 0;
            this.lblma.Text = "Mã TK";
            // 
            // pnCacNut
            // 
            this.pnCacNut.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnCacNut.BackColor = System.Drawing.Color.DarkGray;
            this.pnCacNut.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnCacNut.Controls.Add(this.buttonXoa);
            this.pnCacNut.Controls.Add(this.buttonHuy);
            this.pnCacNut.Controls.Add(this.buttonSua);
            this.pnCacNut.Controls.Add(this.buttonLuu);
            this.pnCacNut.Controls.Add(this.buttonThem);
            this.pnCacNut.Location = new System.Drawing.Point(15, 516);
            this.pnCacNut.Margin = new System.Windows.Forms.Padding(4);
            this.pnCacNut.Name = "pnCacNut";
            this.pnCacNut.Size = new System.Drawing.Size(1244, 91);
            this.pnCacNut.TabIndex = 3;
            this.pnCacNut.Paint += new System.Windows.Forms.PaintEventHandler(this.pnCacNut_Paint);
            // 
            // buttonXoa
            // 
            this.buttonXoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonXoa.Image = global::KeToanTienLuong.Properties.Resources.delete;
            this.buttonXoa.Location = new System.Drawing.Point(978, 24);
            this.buttonXoa.Name = "buttonXoa";
            this.buttonXoa.Size = new System.Drawing.Size(170, 42);
            this.buttonXoa.TabIndex = 76;
            this.buttonXoa.Text = "   Xóa";
            this.buttonXoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonXoa.UseVisualStyleBackColor = true;
            this.buttonXoa.Click += new System.EventHandler(this.buttonXoa_Click);
            // 
            // buttonHuy
            // 
            this.buttonHuy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHuy.Image = global::KeToanTienLuong.Properties.Resources.cancelled;
            this.buttonHuy.Location = new System.Drawing.Point(537, 24);
            this.buttonHuy.Name = "buttonHuy";
            this.buttonHuy.Size = new System.Drawing.Size(170, 42);
            this.buttonHuy.TabIndex = 78;
            this.buttonHuy.Text = "   Hủy";
            this.buttonHuy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonHuy.UseVisualStyleBackColor = true;
            this.buttonHuy.Click += new System.EventHandler(this.buttonHuy_Click);
            // 
            // buttonSua
            // 
            this.buttonSua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSua.Image = global::KeToanTienLuong.Properties.Resources.pencil;
            this.buttonSua.Location = new System.Drawing.Point(748, 24);
            this.buttonSua.Name = "buttonSua";
            this.buttonSua.Size = new System.Drawing.Size(174, 42);
            this.buttonSua.TabIndex = 75;
            this.buttonSua.Text = "   Sửa";
            this.buttonSua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonSua.UseVisualStyleBackColor = true;
            this.buttonSua.Click += new System.EventHandler(this.buttonSua_Click);
            // 
            // buttonLuu
            // 
            this.buttonLuu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLuu.Image = global::KeToanTienLuong.Properties.Resources.checkmark;
            this.buttonLuu.Location = new System.Drawing.Point(299, 24);
            this.buttonLuu.Name = "buttonLuu";
            this.buttonLuu.Size = new System.Drawing.Size(193, 42);
            this.buttonLuu.TabIndex = 77;
            this.buttonLuu.Text = "   Lưu";
            this.buttonLuu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonLuu.UseVisualStyleBackColor = true;
            this.buttonLuu.Click += new System.EventHandler(this.buttonLuu_Click);
            // 
            // buttonThem
            // 
            this.buttonThem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonThem.Image = global::KeToanTienLuong.Properties.Resources.plus;
            this.buttonThem.Location = new System.Drawing.Point(97, 24);
            this.buttonThem.Name = "buttonThem";
            this.buttonThem.Size = new System.Drawing.Size(170, 42);
            this.buttonThem.TabIndex = 74;
            this.buttonThem.Text = "  Thêm";
            this.buttonThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonThem.UseVisualStyleBackColor = true;
            this.buttonThem.Click += new System.EventHandler(this.buttonThem_Click);
            // 
            // captk
            // 
            this.captk.DataPropertyName = "captk";
            this.captk.HeaderText = "Cấp tài khoản";
            this.captk.MinimumWidth = 6;
            this.captk.Name = "captk";
            this.captk.ReadOnly = true;
            // 
            // tkme
            // 
            this.tkme.DataPropertyName = "tkme";
            this.tkme.HeaderText = "Tài khoản mẹ";
            this.tkme.MinimumWidth = 6;
            this.tkme.Name = "tkme";
            this.tkme.ReadOnly = true;
            // 
            // matk
            // 
            this.matk.DataPropertyName = "matk";
            this.matk.HeaderText = "Mã Tài Khoản";
            this.matk.MinimumWidth = 6;
            this.matk.Name = "matk";
            this.matk.ReadOnly = true;
            // 
            // pndgv
            // 
            this.pndgv.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pndgv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pndgv.Controls.Add(this.dataGridView);
            this.pndgv.Location = new System.Drawing.Point(15, 226);
            this.pndgv.Margin = new System.Windows.Forms.Padding(4);
            this.pndgv.Name = "pndgv";
            this.pndgv.Size = new System.Drawing.Size(1245, 235);
            this.pndgv.TabIndex = 5;
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.BackgroundColor = System.Drawing.Color.LightGray;
            this.dataGridView.ColumnHeadersHeight = 29;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.matk,
            this.tkme,
            this.captk,
            this.tentk});
            this.dataGridView.Location = new System.Drawing.Point(0, 0);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.Size = new System.Drawing.Size(1245, 235);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvdmtk_CellContentClick);
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            // 
            // tentk
            // 
            this.tentk.DataPropertyName = "tentk";
            this.tentk.HeaderText = "Tên tài khoản";
            this.tentk.MinimumWidth = 6;
            this.tentk.Name = "tentk";
            this.tentk.ReadOnly = true;
            // 
            // DanhMucTaiKhoanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnDoiTuong);
            this.Controls.Add(this.pnCacNut);
            this.Controls.Add(this.pndgv);
            this.Name = "DanhMucTaiKhoanForm";
            this.Size = new System.Drawing.Size(1275, 626);
            this.Load += new System.EventHandler(this.DanhMucTaiKhoanForm_Load);
            this.pnDoiTuong.ResumeLayout(false);
            this.pnDoiTuong.PerformLayout();
            this.pnCacNut.ResumeLayout(false);
            this.pndgv.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lalcap;
        private System.Windows.Forms.Panel pnDoiTuong;
        private System.Windows.Forms.TextBox inpMaTk;
        private System.Windows.Forms.ComboBox cbotkme;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblmota;
        private System.Windows.Forms.TextBox inpTenTk;
        private System.Windows.Forms.Label lblten;
        private System.Windows.Forms.TextBox inpCapTk;
        private System.Windows.Forms.Label lblma;
        private System.Windows.Forms.Panel pnCacNut;
        private System.Windows.Forms.DataGridViewTextBoxColumn captk;
        private System.Windows.Forms.DataGridViewTextBoxColumn tkme;
        private System.Windows.Forms.DataGridViewTextBoxColumn matk;
        private System.Windows.Forms.Panel pndgv;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn tentk;
        private System.Windows.Forms.Button buttonXoa;
        private System.Windows.Forms.Button buttonHuy;
        private System.Windows.Forms.Button buttonSua;
        private System.Windows.Forms.Button buttonLuu;
        private System.Windows.Forms.Button buttonThem;
    }
}
