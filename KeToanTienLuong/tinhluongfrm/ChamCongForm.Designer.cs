
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
            this.buttonXem = new System.Windows.Forms.Button();
            this.buttonThem = new System.Windows.Forms.Button();
            this.panelContentBox = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // buttonXem
            // 
            this.buttonXem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonXem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonXem.Image = global::KeToanTienLuong.Properties.Resources.eye;
            this.buttonXem.Location = new System.Drawing.Point(916, 43);
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
            this.buttonThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonThem.Image = global::KeToanTienLuong.Properties.Resources.plus;
            this.buttonThem.Location = new System.Drawing.Point(685, 43);
            this.buttonThem.Name = "buttonThem";
            this.buttonThem.Size = new System.Drawing.Size(194, 63);
            this.buttonThem.TabIndex = 31;
            this.buttonThem.Text = "  Tải bảng công Excel";
            this.buttonThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonThem.UseVisualStyleBackColor = true;
            // 
            // panelContentBox
            // 
            this.panelContentBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelContentBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panelContentBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelContentBox.Location = new System.Drawing.Point(0, 137);
            this.panelContentBox.Name = "panelContentBox";
            this.panelContentBox.Size = new System.Drawing.Size(1123, 562);
            this.panelContentBox.TabIndex = 33;
            // 
            // ChamCongForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelContentBox);
            this.Controls.Add(this.buttonXem);
            this.Controls.Add(this.buttonThem);
            this.Name = "ChamCongForm";
            this.Size = new System.Drawing.Size(1126, 702);
            this.Load += new System.EventHandler(this.ChamCongForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonXem;
        private System.Windows.Forms.Button buttonThem;
        private System.Windows.Forms.Panel panelContentBox;
    }
}
