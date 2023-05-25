
namespace CaoLongAn_19607001
{
    partial class DanhSachSoTietKiem
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DanhSachSoTietKiem));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.soSoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayLapSoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenKhachHangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soCMNDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diaChiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ghiChuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sOTIETKIEMBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.qLTienGuiTietKiemDataSet1 = new CaoLongAn_19607001.QLTienGuiTietKiemDataSet1();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.qLTienGuiTietKiemDataSet = new CaoLongAn_19607001.QLTienGuiTietKiemDataSet();
            this.sOTIETKIEMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sOTIETKIEMTableAdapter = new CaoLongAn_19607001.QLTienGuiTietKiemDataSetTableAdapters.SOTIETKIEMTableAdapter();
            this.sOTIETKIEMTableAdapter1 = new CaoLongAn_19607001.QLTienGuiTietKiemDataSet1TableAdapters.SOTIETKIEMTableAdapter();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox0 = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sOTIETKIEMBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLTienGuiTietKiemDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLTienGuiTietKiemDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sOTIETKIEMBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.soSoDataGridViewTextBoxColumn,
            this.ngayLapSoDataGridViewTextBoxColumn,
            this.tenKhachHangDataGridViewTextBoxColumn,
            this.soCMNDDataGridViewTextBoxColumn,
            this.diaChiDataGridViewTextBoxColumn,
            this.ghiChuDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.sOTIETKIEMBindingSource1;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1.Location = new System.Drawing.Point(376, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(882, 440);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridview1_CellClick);
            // 
            // soSoDataGridViewTextBoxColumn
            // 
            this.soSoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.soSoDataGridViewTextBoxColumn.DataPropertyName = "SoSo";
            this.soSoDataGridViewTextBoxColumn.HeaderText = "Số sổ";
            this.soSoDataGridViewTextBoxColumn.Name = "soSoDataGridViewTextBoxColumn";
            this.soSoDataGridViewTextBoxColumn.ReadOnly = true;
            this.soSoDataGridViewTextBoxColumn.Width = 59;
            // 
            // ngayLapSoDataGridViewTextBoxColumn
            // 
            this.ngayLapSoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ngayLapSoDataGridViewTextBoxColumn.DataPropertyName = "NgayLapSo";
            dataGridViewCellStyle1.Format = "dd/MM/yyyy";
            dataGridViewCellStyle1.NullValue = null;
            this.ngayLapSoDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.ngayLapSoDataGridViewTextBoxColumn.HeaderText = "Ngày lập sổ";
            this.ngayLapSoDataGridViewTextBoxColumn.Name = "ngayLapSoDataGridViewTextBoxColumn";
            this.ngayLapSoDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // tenKhachHangDataGridViewTextBoxColumn
            // 
            this.tenKhachHangDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tenKhachHangDataGridViewTextBoxColumn.DataPropertyName = "TenKhachHang";
            this.tenKhachHangDataGridViewTextBoxColumn.HeaderText = "Tên khách hàng";
            this.tenKhachHangDataGridViewTextBoxColumn.Name = "tenKhachHangDataGridViewTextBoxColumn";
            // 
            // soCMNDDataGridViewTextBoxColumn
            // 
            this.soCMNDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.soCMNDDataGridViewTextBoxColumn.DataPropertyName = "SoCMND";
            this.soCMNDDataGridViewTextBoxColumn.HeaderText = "Số CMND";
            this.soCMNDDataGridViewTextBoxColumn.Name = "soCMNDDataGridViewTextBoxColumn";
            // 
            // diaChiDataGridViewTextBoxColumn
            // 
            this.diaChiDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.diaChiDataGridViewTextBoxColumn.DataPropertyName = "DiaChi";
            this.diaChiDataGridViewTextBoxColumn.HeaderText = "Địa chỉ";
            this.diaChiDataGridViewTextBoxColumn.Name = "diaChiDataGridViewTextBoxColumn";
            // 
            // ghiChuDataGridViewTextBoxColumn
            // 
            this.ghiChuDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ghiChuDataGridViewTextBoxColumn.DataPropertyName = "GhiChu";
            this.ghiChuDataGridViewTextBoxColumn.HeaderText = "Ghi chú";
            this.ghiChuDataGridViewTextBoxColumn.Name = "ghiChuDataGridViewTextBoxColumn";
            // 
            // sOTIETKIEMBindingSource1
            // 
            this.sOTIETKIEMBindingSource1.DataMember = "SOTIETKIEM";
            this.sOTIETKIEMBindingSource1.DataSource = this.qLTienGuiTietKiemDataSet1;
            // 
            // qLTienGuiTietKiemDataSet1
            // 
            this.qLTienGuiTietKiemDataSet1.DataSetName = "QLTienGuiTietKiemDataSet1";
            this.qLTienGuiTietKiemDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(376, 474);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(206, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Số sổ tiết kiệm:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên khách hàng:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(119, 128);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(206, 20);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(119, 165);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(206, 20);
            this.textBox2.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Địa chỉ:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Số CMND:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(119, 203);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(206, 20);
            this.textBox3.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 249);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Ngày lập sổ:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 287);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Ghi chú:";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(65, 284);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(260, 168);
            this.textBox4.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(26, 473);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Thêm/Sửa";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(136, 473);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 15;
            this.button2.Text = "Xóa";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(1183, 473);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 16;
            this.button3.Text = "Thoát";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // qLTienGuiTietKiemDataSet
            // 
            this.qLTienGuiTietKiemDataSet.DataSetName = "QLTienGuiTietKiemDataSet";
            this.qLTienGuiTietKiemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sOTIETKIEMBindingSource
            // 
            this.sOTIETKIEMBindingSource.DataMember = "SOTIETKIEM";
            this.sOTIETKIEMBindingSource.DataSource = this.qLTienGuiTietKiemDataSet;
            // 
            // sOTIETKIEMTableAdapter
            // 
            this.sOTIETKIEMTableAdapter.ClearBeforeFill = true;
            // 
            // sOTIETKIEMTableAdapter1
            // 
            this.sOTIETKIEMTableAdapter1.ClearBeforeFill = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(119, 243);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 17;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(250, 473);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 18;
            this.button4.Text = "Làm mới";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // textBox0
            // 
            this.textBox0.Location = new System.Drawing.Point(119, 90);
            this.textBox0.Name = "textBox0";
            this.textBox0.Size = new System.Drawing.Size(206, 20);
            this.textBox0.TabIndex = 19;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(614, 473);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(105, 23);
            this.button5.TabIndex = 20;
            this.button5.Text = "Lọc sổ tiết kiệm";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // textBox5
            // 
            this.textBox5.ForeColor = System.Drawing.Color.Gray;
            this.textBox5.Location = new System.Drawing.Point(765, 474);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(280, 20);
            this.textBox5.TabIndex = 21;
            this.textBox5.Text = "Nhập tên khách hàng cần tìm...";
            this.textBox5.Enter += new System.EventHandler(this.textBox5_Enter);
            this.textBox5.Leave += new System.EventHandler(this.textBox5_Leave);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(1061, 473);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(83, 23);
            this.button6.TabIndex = 22;
            this.button6.Text = "Tìm kiếm";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Cambria", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(9, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(361, 34);
            this.label8.TabIndex = 37;
            this.label8.Text = "DANH SÁCH SỔ TIẾT KIỆM";
            // 
            // DanhSachSoTietKiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1270, 520);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.textBox0);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "DanhSachSoTietKiem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DANH SÁCH SỔ TIẾT KIỆM";
            this.Load += new System.EventHandler(this.DanhSachSoTietKiem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sOTIETKIEMBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLTienGuiTietKiemDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLTienGuiTietKiemDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sOTIETKIEMBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private QLTienGuiTietKiemDataSet qLTienGuiTietKiemDataSet;
        private System.Windows.Forms.BindingSource sOTIETKIEMBindingSource;
        private QLTienGuiTietKiemDataSetTableAdapters.SOTIETKIEMTableAdapter sOTIETKIEMTableAdapter;
        private QLTienGuiTietKiemDataSet1 qLTienGuiTietKiemDataSet1;
        private System.Windows.Forms.BindingSource sOTIETKIEMBindingSource1;
        private QLTienGuiTietKiemDataSet1TableAdapters.SOTIETKIEMTableAdapter sOTIETKIEMTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn soSoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayLapSoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenKhachHangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soCMNDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diaChiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ghiChuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBox0;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label8;
    }
}