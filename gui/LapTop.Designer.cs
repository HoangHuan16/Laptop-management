namespace DoAnLapTop.gui
{
    partial class LapTopForm
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.cboNCC = new System.Windows.Forms.ComboBox();
            this.btnDeleLapTop = new System.Windows.Forms.Button();
            this.btnFixLapTop = new System.Windows.Forms.Button();
            this.btnThemLapTop = new System.Windows.Forms.Button();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.txtTenLapTop = new System.Windows.Forms.TextBox();
            this.txtMaLapTop = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dgvLapTop = new System.Windows.Forms.DataGridView();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLapTop)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Controls.Add(this.cboNCC);
            this.panel3.Controls.Add(this.btnDeleLapTop);
            this.panel3.Controls.Add(this.btnFixLapTop);
            this.panel3.Controls.Add(this.btnThemLapTop);
            this.panel3.Controls.Add(this.txtDonGia);
            this.panel3.Controls.Add(this.txtTenLapTop);
            this.panel3.Controls.Add(this.txtMaLapTop);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Location = new System.Drawing.Point(12, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1075, 184);
            this.panel3.TabIndex = 2;
            // 
            // cboNCC
            // 
            this.cboNCC.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboNCC.DisplayMember = "TenNCC";
            this.cboNCC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cboNCC.FormattingEnabled = true;
            this.cboNCC.Location = new System.Drawing.Point(173, 142);
            this.cboNCC.Name = "cboNCC";
            this.cboNCC.Size = new System.Drawing.Size(681, 28);
            this.cboNCC.TabIndex = 11;
            this.cboNCC.ValueMember = "MaNCC";
            this.cboNCC.SelectedIndexChanged += new System.EventHandler(this.cboNCC_SelectedIndexChanged);
            // 
            // btnDeleLapTop
            // 
            this.btnDeleLapTop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleLapTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.btnDeleLapTop.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnDeleLapTop.FlatAppearance.BorderSize = 3;
            this.btnDeleLapTop.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDeleLapTop.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnDeleLapTop.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnDeleLapTop.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDeleLapTop.ForeColor = System.Drawing.Color.Red;
            this.btnDeleLapTop.Image = global::DoAnLapTop.Properties.Resources.icons8_multiply_16;
            this.btnDeleLapTop.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeleLapTop.Location = new System.Drawing.Point(910, 129);
            this.btnDeleLapTop.Name = "btnDeleLapTop";
            this.btnDeleLapTop.Size = new System.Drawing.Size(144, 40);
            this.btnDeleLapTop.TabIndex = 10;
            this.btnDeleLapTop.Text = "Xóa";
            this.btnDeleLapTop.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDeleLapTop.UseVisualStyleBackColor = false;
            this.btnDeleLapTop.Click += new System.EventHandler(this.btnDeleLapTop_Click);
            // 
            // btnFixLapTop
            // 
            this.btnFixLapTop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFixLapTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.btnFixLapTop.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnFixLapTop.FlatAppearance.BorderSize = 3;
            this.btnFixLapTop.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnFixLapTop.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnFixLapTop.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnFixLapTop.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnFixLapTop.ForeColor = System.Drawing.Color.Red;
            this.btnFixLapTop.Image = global::DoAnLapTop.Properties.Resources.icons8_support_16;
            this.btnFixLapTop.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFixLapTop.Location = new System.Drawing.Point(910, 71);
            this.btnFixLapTop.Name = "btnFixLapTop";
            this.btnFixLapTop.Size = new System.Drawing.Size(144, 40);
            this.btnFixLapTop.TabIndex = 9;
            this.btnFixLapTop.Text = "Sửa";
            this.btnFixLapTop.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFixLapTop.UseVisualStyleBackColor = false;
            this.btnFixLapTop.Click += new System.EventHandler(this.btnFixLapTop_Click);
            // 
            // btnThemLapTop
            // 
            this.btnThemLapTop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThemLapTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.btnThemLapTop.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnThemLapTop.FlatAppearance.BorderSize = 3;
            this.btnThemLapTop.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnThemLapTop.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnThemLapTop.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnThemLapTop.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThemLapTop.ForeColor = System.Drawing.Color.Red;
            this.btnThemLapTop.Image = global::DoAnLapTop.Properties.Resources.icons8_plus_math_16__2_;
            this.btnThemLapTop.Location = new System.Drawing.Point(910, 10);
            this.btnThemLapTop.Name = "btnThemLapTop";
            this.btnThemLapTop.Size = new System.Drawing.Size(144, 40);
            this.btnThemLapTop.TabIndex = 8;
            this.btnThemLapTop.Text = "Thêm";
            this.btnThemLapTop.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThemLapTop.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThemLapTop.UseVisualStyleBackColor = false;
            this.btnThemLapTop.Click += new System.EventHandler(this.btnThemLapTop_Click);
            // 
            // txtDonGia
            // 
            this.txtDonGia.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDonGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtDonGia.Location = new System.Drawing.Point(173, 102);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(681, 27);
            this.txtDonGia.TabIndex = 6;
            // 
            // txtTenLapTop
            // 
            this.txtTenLapTop.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTenLapTop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTenLapTop.Location = new System.Drawing.Point(173, 60);
            this.txtTenLapTop.Name = "txtTenLapTop";
            this.txtTenLapTop.Size = new System.Drawing.Size(681, 27);
            this.txtTenLapTop.TabIndex = 5;
            // 
            // txtMaLapTop
            // 
            this.txtMaLapTop.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMaLapTop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMaLapTop.Location = new System.Drawing.Point(173, 17);
            this.txtMaLapTop.Name = "txtMaLapTop";
            this.txtMaLapTop.Size = new System.Drawing.Size(681, 27);
            this.txtMaLapTop.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.ForeColor = System.Drawing.Color.LightGray;
            this.label5.Location = new System.Drawing.Point(3, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Nhà cung cấp:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.ForeColor = System.Drawing.Color.LightGray;
            this.label6.Location = new System.Drawing.Point(3, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "Đơn giá:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.ForeColor = System.Drawing.Color.LightGray;
            this.label7.Location = new System.Drawing.Point(3, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 20);
            this.label7.TabIndex = 1;
            this.label7.Text = "Tên LapTop:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label8.ForeColor = System.Drawing.Color.LightGray;
            this.label8.Location = new System.Drawing.Point(3, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "Mã LapTop:";
            // 
            // dgvLapTop
            // 
            this.dgvLapTop.AllowUserToAddRows = false;
            this.dgvLapTop.AllowUserToDeleteRows = false;
            this.dgvLapTop.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvLapTop.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.dgvLapTop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLapTop.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLapTop.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvLapTop.Location = new System.Drawing.Point(3, 3);
            this.dgvLapTop.Name = "dgvLapTop";
            this.dgvLapTop.ReadOnly = true;
            this.dgvLapTop.RowHeadersWidth = 51;
            this.dgvLapTop.RowTemplate.Height = 24;
            this.dgvLapTop.Size = new System.Drawing.Size(1068, 220);
            this.dgvLapTop.TabIndex = 3;
            this.dgvLapTop.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLapTop_RowEnter);
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "MaLapTop";
            this.Column5.HeaderText = "Mã Lap Top";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 125;
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column6.DataPropertyName = "TenLapTop";
            this.Column6.HeaderText = "Tên Lap Top";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "DonGia";
            this.Column7.HeaderText = "Đơn giá";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 125;
            // 
            // Column8
            // 
            this.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column8.DataPropertyName = "NhaCungCap";
            this.Column8.HeaderText = "Nhà cung cấp";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.dgvLapTop);
            this.panel1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.panel1.Location = new System.Drawing.Point(9, 202);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1078, 232);
            this.panel1.TabIndex = 3;
            // 
            // LapTopForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1092, 434);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Name = "LapTopForm";
            this.Text = "LapTop";
            this.Load += new System.EventHandler(this.LapTop_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLapTop)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox cboNCC;
        private System.Windows.Forms.Button btnDeleLapTop;
        private System.Windows.Forms.Button btnFixLapTop;
        private System.Windows.Forms.Button btnThemLapTop;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.TextBox txtTenLapTop;
        private System.Windows.Forms.TextBox txtMaLapTop;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgvLapTop;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.Panel panel1;
    }
}