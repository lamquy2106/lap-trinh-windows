namespace lap_trinh_window
{
    partial class fsinhvien
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txttim = new System.Windows.Forms.TextBox();
            this.lbtim = new System.Windows.Forms.Label();
            this.dtgsinhvien = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtlop = new System.Windows.Forms.ComboBox();
            this.btthoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgsinhvien)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txttim
            // 
            this.txttim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttim.Location = new System.Drawing.Point(289, 116);
            this.txttim.Name = "txttim";
            this.txttim.Size = new System.Drawing.Size(211, 30);
            this.txttim.TabIndex = 37;
            this.txttim.TextChanged += new System.EventHandler(this.txttim_TextChanged);
            // 
            // lbtim
            // 
            this.lbtim.AutoSize = true;
            this.lbtim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtim.Location = new System.Drawing.Point(98, 118);
            this.lbtim.Name = "lbtim";
            this.lbtim.Size = new System.Drawing.Size(185, 25);
            this.lbtim.TabIndex = 36;
            this.lbtim.Text = "Tìm Kiếm Sinh Viên";
            // 
            // dtgsinhvien
            // 
            this.dtgsinhvien.BackgroundColor = System.Drawing.Color.White;
            this.dtgsinhvien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgsinhvien.Location = new System.Drawing.Point(52, 211);
            this.dtgsinhvien.Name = "dtgsinhvien";
            this.dtgsinhvien.RowTemplate.Height = 24;
            this.dtgsinhvien.Size = new System.Drawing.Size(1178, 435);
            this.dtgsinhvien.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(505, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(359, 36);
            this.label2.TabIndex = 0;
            this.label2.Text = "Danh sách điểm rèn luyện";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1280, 53);
            this.panel1.TabIndex = 39;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(1265, 53);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(15, 635);
            this.panel2.TabIndex = 42;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 53);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(14, 635);
            this.panel3.TabIndex = 41;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(14, 677);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1251, 11);
            this.panel4.TabIndex = 40;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(646, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 25);
            this.label1.TabIndex = 44;
            this.label1.Text = "Lớp";
            // 
            // txtlop
            // 
            this.txtlop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtlop.FormattingEnabled = true;
            this.txtlop.Items.AddRange(new object[] {
            "Tất cả",
            "D17PM01",
            "D17PM02",
            "D17PM03",
            "D16PM01",
            "D16PM02",
            "D15PM03",
            "D15PM02",
            "D15PM01",
            "D17TQ01",
            "D17TQ02"});
            this.txtlop.Location = new System.Drawing.Point(707, 113);
            this.txtlop.Name = "txtlop";
            this.txtlop.Size = new System.Drawing.Size(169, 33);
            this.txtlop.TabIndex = 45;
            this.txtlop.SelectedIndexChanged += new System.EventHandler(this.txtlop_SelectedIndexChanged);
            // 
            // btthoat
            // 
            this.btthoat.Location = new System.Drawing.Point(1020, 108);
            this.btthoat.Name = "btthoat";
            this.btthoat.Size = new System.Drawing.Size(110, 47);
            this.btthoat.TabIndex = 46;
            this.btthoat.Text = "Thoát";
            this.btthoat.UseVisualStyleBackColor = true;
            this.btthoat.Click += new System.EventHandler(this.btthoat_Click);
            // 
            // fsinhvien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 688);
            this.Controls.Add(this.btthoat);
            this.Controls.Add(this.txtlop);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txttim);
            this.Controls.Add(this.lbtim);
            this.Controls.Add(this.dtgsinhvien);
            this.Name = "fsinhvien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sinh viên";
            this.Load += new System.EventHandler(this.fsinhvien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgsinhvien)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txttim;
        private System.Windows.Forms.Label lbtim;
        private System.Windows.Forms.DataGridView dtgsinhvien;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox txtlop;
        private System.Windows.Forms.Button btthoat;
    }
}