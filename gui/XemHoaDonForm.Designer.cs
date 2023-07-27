namespace DoAnLapTop.gui
{
    partial class XemHoaDonForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvXemCT = new System.Windows.Forms.DataGridView();
            this.malaptop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenlaptop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hanglaptop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dongia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thanhtien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbNgay = new System.Windows.Forms.Label();
            this.lbMaPM = new System.Windows.Forms.Label();
            this.lbn = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbThanhTien = new System.Windows.Forms.Label();
            this.lbSoDT = new System.Windows.Forms.Label();
            this.lbDiaChi = new System.Windows.Forms.Label();
            this.lbTenKH = new System.Windows.Forms.Label();
            this.lbMaKH = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lb = new System.Windows.Forms.Label();
            this.lbMa = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnThoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvXemCT)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvXemCT
            // 
            this.dgvXemCT.AllowUserToAddRows = false;
            this.dgvXemCT.AllowUserToDeleteRows = false;
            this.dgvXemCT.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.dgvXemCT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvXemCT.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.malaptop,
            this.tenlaptop,
            this.hanglaptop,
            this.soluong,
            this.dongia,
            this.thanhtien});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvXemCT.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvXemCT.Location = new System.Drawing.Point(6, 21);
            this.dgvXemCT.Name = "dgvXemCT";
            this.dgvXemCT.ReadOnly = true;
            this.dgvXemCT.RowHeadersWidth = 51;
            this.dgvXemCT.RowTemplate.Height = 24;
            this.dgvXemCT.Size = new System.Drawing.Size(1058, 244);
            this.dgvXemCT.TabIndex = 2;
            this.dgvXemCT.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvXemCT_CellContentClick);
            // 
            // malaptop
            // 
            this.malaptop.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.malaptop.DataPropertyName = "malaptop";
            this.malaptop.HeaderText = "Mã lap top";
            this.malaptop.MinimumWidth = 6;
            this.malaptop.Name = "malaptop";
            this.malaptop.ReadOnly = true;
            // 
            // tenlaptop
            // 
            this.tenlaptop.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tenlaptop.DataPropertyName = "tenlaptop";
            this.tenlaptop.HeaderText = "Tên lap top";
            this.tenlaptop.MinimumWidth = 6;
            this.tenlaptop.Name = "tenlaptop";
            this.tenlaptop.ReadOnly = true;
            // 
            // hanglaptop
            // 
            this.hanglaptop.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.hanglaptop.DataPropertyName = "hanglaptop";
            this.hanglaptop.HeaderText = "Hãng";
            this.hanglaptop.MinimumWidth = 6;
            this.hanglaptop.Name = "hanglaptop";
            this.hanglaptop.ReadOnly = true;
            // 
            // soluong
            // 
            this.soluong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.soluong.DataPropertyName = "soluong";
            this.soluong.HeaderText = "Số lượng ";
            this.soluong.MinimumWidth = 6;
            this.soluong.Name = "soluong";
            this.soluong.ReadOnly = true;
            // 
            // dongia
            // 
            this.dongia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dongia.DataPropertyName = "dongia";
            this.dongia.HeaderText = "Đơn giá";
            this.dongia.MinimumWidth = 6;
            this.dongia.Name = "dongia";
            this.dongia.ReadOnly = true;
            // 
            // thanhtien
            // 
            this.thanhtien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.thanhtien.DataPropertyName = "thanhtien";
            this.thanhtien.HeaderText = "Thành tiền";
            this.thanhtien.MinimumWidth = 6;
            this.thanhtien.Name = "thanhtien";
            this.thanhtien.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lbNgay);
            this.panel1.Controls.Add(this.lbMaPM);
            this.panel1.Controls.Add(this.lbn);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.lbMa);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1076, 437);
            this.panel1.TabIndex = 3;
            // 
            // lbNgay
            // 
            this.lbNgay.AutoSize = true;
            this.lbNgay.ForeColor = System.Drawing.Color.LightGray;
            this.lbNgay.Location = new System.Drawing.Point(61, 41);
            this.lbNgay.Name = "lbNgay";
            this.lbNgay.Size = new System.Drawing.Size(51, 16);
            this.lbNgay.TabIndex = 7;
            this.lbNgay.Text = "lbNgay";
            // 
            // lbMaPM
            // 
            this.lbMaPM.AutoSize = true;
            this.lbMaPM.ForeColor = System.Drawing.Color.LightGray;
            this.lbMaPM.Location = new System.Drawing.Point(112, 15);
            this.lbMaPM.Name = "lbMaPM";
            this.lbMaPM.Size = new System.Drawing.Size(57, 16);
            this.lbMaPM.TabIndex = 6;
            this.lbMaPM.Text = "lbMaPM";
            // 
            // lbn
            // 
            this.lbn.AutoSize = true;
            this.lbn.ForeColor = System.Drawing.Color.LightGray;
            this.lbn.Location = new System.Drawing.Point(12, 41);
            this.lbn.Name = "lbn";
            this.lbn.Size = new System.Drawing.Size(43, 16);
            this.lbn.TabIndex = 5;
            this.lbn.Text = "Ngày:";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.lbThanhTien);
            this.panel3.Controls.Add(this.lbSoDT);
            this.panel3.Controls.Add(this.lbDiaChi);
            this.panel3.Controls.Add(this.lbTenKH);
            this.panel3.Controls.Add(this.lbMaKH);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.lb);
            this.panel3.Location = new System.Drawing.Point(3, 78);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1063, 356);
            this.panel3.TabIndex = 4;
            // 
            // lbThanhTien
            // 
            this.lbThanhTien.AutoSize = true;
            this.lbThanhTien.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbThanhTien.ForeColor = System.Drawing.Color.LightGray;
            this.lbThanhTien.Location = new System.Drawing.Point(159, 299);
            this.lbThanhTien.Name = "lbThanhTien";
            this.lbThanhTien.Size = new System.Drawing.Size(96, 19);
            this.lbThanhTien.TabIndex = 10;
            this.lbThanhTien.Text = "lbThanhTien";
            // 
            // lbSoDT
            // 
            this.lbSoDT.AutoSize = true;
            this.lbSoDT.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbSoDT.ForeColor = System.Drawing.Color.LightGray;
            this.lbSoDT.Location = new System.Drawing.Point(178, 175);
            this.lbSoDT.Name = "lbSoDT";
            this.lbSoDT.Size = new System.Drawing.Size(62, 19);
            this.lbSoDT.TabIndex = 9;
            this.lbSoDT.Text = "lbSoDT";
            // 
            // lbDiaChi
            // 
            this.lbDiaChi.AutoSize = true;
            this.lbDiaChi.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbDiaChi.ForeColor = System.Drawing.Color.LightGray;
            this.lbDiaChi.Location = new System.Drawing.Point(116, 127);
            this.lbDiaChi.Name = "lbDiaChi";
            this.lbDiaChi.Size = new System.Drawing.Size(59, 19);
            this.lbDiaChi.TabIndex = 8;
            this.lbDiaChi.Text = "DiaChi";
            // 
            // lbTenKH
            // 
            this.lbTenKH.AutoSize = true;
            this.lbTenKH.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbTenKH.ForeColor = System.Drawing.Color.LightGray;
            this.lbTenKH.Location = new System.Drawing.Point(197, 77);
            this.lbTenKH.Name = "lbTenKH";
            this.lbTenKH.Size = new System.Drawing.Size(68, 19);
            this.lbTenKH.TabIndex = 7;
            this.lbTenKH.Text = "lbTenKH";
            // 
            // lbMaKH
            // 
            this.lbMaKH.AutoSize = true;
            this.lbMaKH.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbMaKH.ForeColor = System.Drawing.Color.LightGray;
            this.lbMaKH.Location = new System.Drawing.Point(197, 29);
            this.lbMaKH.Name = "lbMaKH";
            this.lbMaKH.Size = new System.Drawing.Size(65, 19);
            this.lbMaKH.TabIndex = 5;
            this.lbMaKH.Text = "lbMaKH";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.LightGray;
            this.label1.Location = new System.Drawing.Point(36, 300);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tổng tiền:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.ForeColor = System.Drawing.Color.LightGray;
            this.label5.Location = new System.Drawing.Point(36, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 19);
            this.label5.TabIndex = 3;
            this.label5.Text = "Số điện thoại:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.ForeColor = System.Drawing.Color.LightGray;
            this.label3.Location = new System.Drawing.Point(36, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Địa chỉ:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.Color.LightGray;
            this.label2.Location = new System.Drawing.Point(36, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã khách hàng:";
            // 
            // lb
            // 
            this.lb.AutoSize = true;
            this.lb.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb.ForeColor = System.Drawing.Color.LightGray;
            this.lb.Location = new System.Drawing.Point(36, 78);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(140, 19);
            this.lb.TabIndex = 0;
            this.lb.Text = "Tên khách hàng:";
            // 
            // lbMa
            // 
            this.lbMa.AutoSize = true;
            this.lbMa.ForeColor = System.Drawing.Color.LightGray;
            this.lbMa.Location = new System.Drawing.Point(12, 15);
            this.lbMa.Name = "lbMa";
            this.lbMa.Size = new System.Drawing.Size(94, 16);
            this.lbMa.TabIndex = 4;
            this.lbMa.Text = "Mã phiếu mua:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(346, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(402, 42);
            this.label4.TabIndex = 3;
            this.label4.Text = "HÓA ĐƠN BÁN HÀNG";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.Controls.Add(this.dgvXemCT);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.ForeColor = System.Drawing.Color.LightGray;
            this.groupBox1.Location = new System.Drawing.Point(15, 455);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1073, 271);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chi tiết đơn hàng";
            // 
            // btnThoat
            // 
            this.btnThoat.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnThoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.btnThoat.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThoat.ForeColor = System.Drawing.Color.Red;
            this.btnThoat.Image = global::DoAnLapTop.Properties.Resources.icons8_logout_16;
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThoat.Location = new System.Drawing.Point(425, 733);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(246, 58);
            this.btnThoat.TabIndex = 9;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // XemHoaDonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1095, 803);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "XemHoaDonForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "xem";
            this.Load += new System.EventHandler(this.xem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvXemCT)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvXemCT;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbNgay;
        private System.Windows.Forms.Label lbMaPM;
        private System.Windows.Forms.Label lbn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbThanhTien;
        private System.Windows.Forms.Label lbSoDT;
        private System.Windows.Forms.Label lbDiaChi;
        private System.Windows.Forms.Label lbTenKH;
        private System.Windows.Forms.Label lbMaKH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb;
        private System.Windows.Forms.Label lbMa;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.DataGridViewTextBoxColumn malaptop;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenlaptop;
        private System.Windows.Forms.DataGridViewTextBoxColumn hanglaptop;
        private System.Windows.Forms.DataGridViewTextBoxColumn soluong;
        private System.Windows.Forms.DataGridViewTextBoxColumn dongia;
        private System.Windows.Forms.DataGridViewTextBoxColumn thanhtien;
    }
}