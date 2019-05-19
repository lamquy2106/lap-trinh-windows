namespace lap_trinh_window
{
    partial class fmain
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
            this.dtgsinhvien = new System.Windows.Forms.DataGridView();
            this.lbmasv = new System.Windows.Forms.Label();
            this.lbtensv = new System.Windows.Forms.Label();
            this.lbngaysinh = new System.Windows.Forms.Label();
            this.lbgioitinh = new System.Windows.Forms.Label();
            this.lbdiemrl = new System.Windows.Forms.Label();
            this.lbhoatdong = new System.Windows.Forms.Label();
            this.txtmasv = new System.Windows.Forms.TextBox();
            this.txttensv = new System.Windows.Forms.TextBox();
            this.txtdiemrl = new System.Windows.Forms.TextBox();
            this.txthoatdong = new System.Windows.Forms.TextBox();
            this.btthem = new System.Windows.Forms.Button();
            this.btxoa = new System.Windows.Forms.Button();
            this.btsua = new System.Windows.Forms.Button();
            this.btluu = new System.Windows.Forms.Button();
            this.bthuy = new System.Windows.Forms.Button();
            this.lbtim = new System.Windows.Forms.Label();
            this.txttim = new System.Windows.Forms.TextBox();
            this.btthoat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtgioitinh = new System.Windows.Forms.ComboBox();
            this.txtlop = new System.Windows.Forms.ComboBox();
            this.txtngaysinh = new System.Windows.Forms.MaskedTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dtgsinhvien)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgsinhvien
            // 
            this.dtgsinhvien.BackgroundColor = System.Drawing.Color.White;
            this.dtgsinhvien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgsinhvien.Location = new System.Drawing.Point(51, 428);
            this.dtgsinhvien.Name = "dtgsinhvien";
            this.dtgsinhvien.RowTemplate.Height = 24;
            this.dtgsinhvien.Size = new System.Drawing.Size(1178, 224);
            this.dtgsinhvien.TabIndex = 30;
            this.dtgsinhvien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgsinhvien_CellContentClick);
            // 
            // lbmasv
            // 
            this.lbmasv.AutoSize = true;
            this.lbmasv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbmasv.Location = new System.Drawing.Point(16, 43);
            this.lbmasv.Name = "lbmasv";
            this.lbmasv.Size = new System.Drawing.Size(130, 25);
            this.lbmasv.TabIndex = 1;
            this.lbmasv.Text = "Mã Sinh Viên";
            // 
            // lbtensv
            // 
            this.lbtensv.AutoSize = true;
            this.lbtensv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtensv.Location = new System.Drawing.Point(22, 42);
            this.lbtensv.Name = "lbtensv";
            this.lbtensv.Size = new System.Drawing.Size(137, 25);
            this.lbtensv.TabIndex = 2;
            this.lbtensv.Text = "Tên Sinh Viên";
            // 
            // lbngaysinh
            // 
            this.lbngaysinh.AutoSize = true;
            this.lbngaysinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbngaysinh.Location = new System.Drawing.Point(16, 152);
            this.lbngaysinh.Name = "lbngaysinh";
            this.lbngaysinh.Size = new System.Drawing.Size(103, 25);
            this.lbngaysinh.TabIndex = 3;
            this.lbngaysinh.Text = "Ngày Sinh";
            // 
            // lbgioitinh
            // 
            this.lbgioitinh.AutoSize = true;
            this.lbgioitinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbgioitinh.Location = new System.Drawing.Point(16, 211);
            this.lbgioitinh.Name = "lbgioitinh";
            this.lbgioitinh.Size = new System.Drawing.Size(90, 25);
            this.lbgioitinh.TabIndex = 4;
            this.lbgioitinh.Text = "Giới Tính";
            // 
            // lbdiemrl
            // 
            this.lbdiemrl.AutoSize = true;
            this.lbdiemrl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbdiemrl.Location = new System.Drawing.Point(22, 160);
            this.lbdiemrl.Name = "lbdiemrl";
            this.lbdiemrl.Size = new System.Drawing.Size(156, 25);
            this.lbdiemrl.TabIndex = 5;
            this.lbdiemrl.Text = "Điểm Rèn Luyện";
            // 
            // lbhoatdong
            // 
            this.lbhoatdong.AutoSize = true;
            this.lbhoatdong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbhoatdong.Location = new System.Drawing.Point(22, 99);
            this.lbhoatdong.Name = "lbhoatdong";
            this.lbhoatdong.Size = new System.Drawing.Size(105, 25);
            this.lbhoatdong.TabIndex = 6;
            this.lbhoatdong.Text = "Hoạt Động";
            // 
            // txtmasv
            // 
            this.txtmasv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmasv.Location = new System.Drawing.Point(175, 39);
            this.txtmasv.Name = "txtmasv";
            this.txtmasv.Size = new System.Drawing.Size(222, 30);
            this.txtmasv.TabIndex = 1;
            // 
            // txttensv
            // 
            this.txttensv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttensv.Location = new System.Drawing.Point(188, 42);
            this.txttensv.Name = "txttensv";
            this.txttensv.Size = new System.Drawing.Size(244, 30);
            this.txttensv.TabIndex = 2;
            // 
            // txtdiemrl
            // 
            this.txtdiemrl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdiemrl.Location = new System.Drawing.Point(190, 155);
            this.txtdiemrl.Name = "txtdiemrl";
            this.txtdiemrl.Size = new System.Drawing.Size(242, 30);
            this.txtdiemrl.TabIndex = 7;
            // 
            // txthoatdong
            // 
            this.txthoatdong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txthoatdong.Location = new System.Drawing.Point(188, 98);
            this.txthoatdong.Name = "txthoatdong";
            this.txthoatdong.Size = new System.Drawing.Size(244, 30);
            this.txthoatdong.TabIndex = 6;
            // 
            // btthem
            // 
            this.btthem.BackColor = System.Drawing.Color.Red;
            this.btthem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btthem.ForeColor = System.Drawing.Color.White;
            this.btthem.Location = new System.Drawing.Point(475, 362);
            this.btthem.Name = "btthem";
            this.btthem.Size = new System.Drawing.Size(110, 56);
            this.btthem.TabIndex = 8;
            this.btthem.Text = "Thêm";
            this.btthem.UseVisualStyleBackColor = false;
            this.btthem.Click += new System.EventHandler(this.btthem_Click);
            // 
            // btxoa
            // 
            this.btxoa.BackColor = System.Drawing.Color.Red;
            this.btxoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btxoa.ForeColor = System.Drawing.Color.White;
            this.btxoa.Location = new System.Drawing.Point(601, 362);
            this.btxoa.Name = "btxoa";
            this.btxoa.Size = new System.Drawing.Size(110, 56);
            this.btxoa.TabIndex = 9;
            this.btxoa.Text = "Xóa";
            this.btxoa.UseVisualStyleBackColor = false;
            this.btxoa.Click += new System.EventHandler(this.btxoa_Click);
            // 
            // btsua
            // 
            this.btsua.BackColor = System.Drawing.Color.Red;
            this.btsua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btsua.ForeColor = System.Drawing.Color.White;
            this.btsua.Location = new System.Drawing.Point(731, 362);
            this.btsua.Name = "btsua";
            this.btsua.Size = new System.Drawing.Size(110, 56);
            this.btsua.TabIndex = 10;
            this.btsua.Text = "Sửa";
            this.btsua.UseVisualStyleBackColor = false;
            this.btsua.Click += new System.EventHandler(this.btsua_Click);
            // 
            // btluu
            // 
            this.btluu.BackColor = System.Drawing.Color.Red;
            this.btluu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btluu.ForeColor = System.Drawing.Color.White;
            this.btluu.Location = new System.Drawing.Point(863, 362);
            this.btluu.Name = "btluu";
            this.btluu.Size = new System.Drawing.Size(110, 56);
            this.btluu.TabIndex = 11;
            this.btluu.Text = "Lưu";
            this.btluu.UseVisualStyleBackColor = false;
            this.btluu.Click += new System.EventHandler(this.btluu_Click);
            // 
            // bthuy
            // 
            this.bthuy.BackColor = System.Drawing.Color.Red;
            this.bthuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bthuy.ForeColor = System.Drawing.Color.White;
            this.bthuy.Location = new System.Drawing.Point(994, 364);
            this.bthuy.Name = "bthuy";
            this.bthuy.Size = new System.Drawing.Size(110, 56);
            this.bthuy.TabIndex = 12;
            this.bthuy.Text = "Hủy";
            this.bthuy.UseVisualStyleBackColor = false;
            this.bthuy.Click += new System.EventHandler(this.bthuy_Click);
            // 
            // lbtim
            // 
            this.lbtim.AutoSize = true;
            this.lbtim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtim.Location = new System.Drawing.Point(37, 374);
            this.lbtim.Name = "lbtim";
            this.lbtim.Size = new System.Drawing.Size(185, 25);
            this.lbtim.TabIndex = 18;
            this.lbtim.Text = "Tìm Kiếm Sinh Viên";
            // 
            // txttim
            // 
            this.txttim.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttim.Location = new System.Drawing.Point(238, 372);
            this.txttim.Name = "txttim";
            this.txttim.Size = new System.Drawing.Size(211, 28);
            this.txttim.TabIndex = 14;
            this.txttim.TextChanged += new System.EventHandler(this.txttim_TextChanged);
            // 
            // btthoat
            // 
            this.btthoat.BackColor = System.Drawing.Color.Red;
            this.btthoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btthoat.ForeColor = System.Drawing.Color.White;
            this.btthoat.Location = new System.Drawing.Point(1116, 364);
            this.btthoat.Name = "btthoat";
            this.btthoat.Size = new System.Drawing.Size(110, 56);
            this.btthoat.TabIndex = 13;
            this.btthoat.Text = "Thoát";
            this.btthoat.UseVisualStyleBackColor = false;
            this.btthoat.Click += new System.EventHandler(this.btthoat_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 29);
            this.label1.TabIndex = 22;
            this.label1.Text = "Lớp";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.txthoatdong);
            this.groupBox1.Controls.Add(this.txtdiemrl);
            this.groupBox1.Controls.Add(this.lbhoatdong);
            this.groupBox1.Controls.Add(this.lbdiemrl);
            this.groupBox1.Controls.Add(this.txttensv);
            this.groupBox1.Controls.Add(this.lbtensv);
            this.groupBox1.Location = new System.Drawing.Point(692, 74);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(534, 272);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.txtgioitinh);
            this.groupBox2.Controls.Add(this.txtlop);
            this.groupBox2.Controls.Add(this.txtngaysinh);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtmasv);
            this.groupBox2.Controls.Add(this.lbgioitinh);
            this.groupBox2.Controls.Add(this.lbngaysinh);
            this.groupBox2.Controls.Add(this.lbmasv);
            this.groupBox2.Location = new System.Drawing.Point(42, 74);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(588, 272);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // txtgioitinh
            // 
            this.txtgioitinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtgioitinh.FormattingEnabled = true;
            this.txtgioitinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.txtgioitinh.Location = new System.Drawing.Point(175, 208);
            this.txtgioitinh.Name = "txtgioitinh";
            this.txtgioitinh.Size = new System.Drawing.Size(121, 33);
            this.txtgioitinh.TabIndex = 5;
            // 
            // txtlop
            // 
            this.txtlop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtlop.FormattingEnabled = true;
            this.txtlop.Items.AddRange(new object[] {
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
            this.txtlop.Location = new System.Drawing.Point(175, 96);
            this.txtlop.Name = "txtlop";
            this.txtlop.Size = new System.Drawing.Size(169, 33);
            this.txtlop.TabIndex = 3;
            // 
            // txtngaysinh
            // 
            this.txtngaysinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtngaysinh.Location = new System.Drawing.Point(175, 152);
            this.txtngaysinh.Mask = "00/00/0000";
            this.txtngaysinh.Name = "txtngaysinh";
            this.txtngaysinh.Size = new System.Drawing.Size(130, 30);
            this.txtngaysinh.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1280, 53);
            this.panel1.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(505, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(327, 36);
            this.label2.TabIndex = 0;
            this.label2.Text = "Quản lý điểm rèn luyện ";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(1265, 53);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(15, 635);
            this.panel2.TabIndex = 27;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 53);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(14, 635);
            this.panel3.TabIndex = 27;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(14, 677);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1251, 11);
            this.panel4.TabIndex = 27;
            // 
            // fmain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1280, 688);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btthoat);
            this.Controls.Add(this.txttim);
            this.Controls.Add(this.lbtim);
            this.Controls.Add(this.bthuy);
            this.Controls.Add(this.btluu);
            this.Controls.Add(this.btsua);
            this.Controls.Add(this.btxoa);
            this.Controls.Add(this.btthem);
            this.Controls.Add(this.dtgsinhvien);
            this.Name = "fmain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý";
            this.Load += new System.EventHandler(this.fmain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgsinhvien)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgsinhvien;
        private System.Windows.Forms.Label lbmasv;
        private System.Windows.Forms.Label lbtensv;
        private System.Windows.Forms.Label lbngaysinh;
        private System.Windows.Forms.Label lbgioitinh;
        private System.Windows.Forms.Label lbdiemrl;
        private System.Windows.Forms.Label lbhoatdong;
        private System.Windows.Forms.TextBox txtmasv;
        private System.Windows.Forms.TextBox txttensv;
        private System.Windows.Forms.TextBox txtdiemrl;
        private System.Windows.Forms.TextBox txthoatdong;
        private System.Windows.Forms.Button btthem;
        private System.Windows.Forms.Button btxoa;
        private System.Windows.Forms.Button btsua;
        private System.Windows.Forms.Button btluu;
        private System.Windows.Forms.Button bthuy;
        private System.Windows.Forms.Label lbtim;
        private System.Windows.Forms.TextBox txttim;
        private System.Windows.Forms.Button btthoat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.MaskedTextBox txtngaysinh;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ComboBox txtlop;
        private System.Windows.Forms.ComboBox txtgioitinh;
    }
}

