
namespace KeToanTienLuong.categoryForm
{
    partial class ThamSoLuongForm
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
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonLuong = new System.Windows.Forms.Button();
            this.buttonTNCN = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.panelContent = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Location = new System.Drawing.Point(807, 80);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(8, 8);
            this.flowLayoutPanel2.TabIndex = 10;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(940, 293);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(8, 8);
            this.flowLayoutPanel1.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.buttonLuong);
            this.panel1.Controls.Add(this.buttonTNCN);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(280, 669);
            this.panel1.TabIndex = 8;
            // 
            // buttonLuong
            // 
            this.buttonLuong.BackColor = System.Drawing.SystemColors.Control;
            this.buttonLuong.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLuong.ForeColor = System.Drawing.Color.Black;
            this.buttonLuong.Image = global::KeToanTienLuong.Properties.Resources.payment_day1;
            this.buttonLuong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonLuong.Location = new System.Drawing.Point(0, 88);
            this.buttonLuong.Name = "buttonLuong";
            this.buttonLuong.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.buttonLuong.Size = new System.Drawing.Size(280, 67);
            this.buttonLuong.TabIndex = 2;
            this.buttonLuong.Text = "   Tham số tính lương";
            this.buttonLuong.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonLuong.UseVisualStyleBackColor = false;
            this.buttonLuong.Click += new System.EventHandler(this.button4_Click);
            // 
            // buttonTNCN
            // 
            this.buttonTNCN.BackColor = System.Drawing.SystemColors.Control;
            this.buttonTNCN.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonTNCN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTNCN.ForeColor = System.Drawing.Color.Black;
            this.buttonTNCN.Image = global::KeToanTienLuong.Properties.Resources.taxes;
            this.buttonTNCN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonTNCN.Location = new System.Drawing.Point(0, 0);
            this.buttonTNCN.Name = "buttonTNCN";
            this.buttonTNCN.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.buttonTNCN.Size = new System.Drawing.Size(280, 88);
            this.buttonTNCN.TabIndex = 1;
            this.buttonTNCN.Text = "   Tham số tính thuế TNCN";
            this.buttonTNCN.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonTNCN.UseVisualStyleBackColor = false;
            this.buttonTNCN.Click += new System.EventHandler(this.button3_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // imageList2
            // 
            this.imageList2.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList2.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(911, 26);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(8, 8);
            this.button2.TabIndex = 11;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // panelContent
            // 
            this.panelContent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelContent.Location = new System.Drawing.Point(286, 3);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(883, 663);
            this.panelContent.TabIndex = 12;
            this.panelContent.Paint += new System.Windows.Forms.PaintEventHandler(this.panelContent_Paint);
            // 
            // ThamSoLuongForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button2);
            this.Name = "ThamSoLuongForm";
            this.Size = new System.Drawing.Size(1172, 669);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonTNCN;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buttonLuong;
        private System.Windows.Forms.Panel panelContent;
    }
}
