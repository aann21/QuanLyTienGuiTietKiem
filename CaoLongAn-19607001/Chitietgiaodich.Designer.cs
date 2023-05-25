
namespace CaoLongAn_19607001
{
    partial class Chitietgiaodich
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Chitietgiaodich));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.soSoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTTLanGiaoDichDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayGiaoDichDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soTienGiaoDichDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maLaiSuatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maNgoaiTeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cHITIETBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLTienGuiTietKiemDataSet2 = new CaoLongAn_19607001.QLTienGuiTietKiemDataSet2();
            this.qLTienGuiTietKiemDataSet = new CaoLongAn_19607001.QLTienGuiTietKiemDataSet();
            this.qLTienGuiTietKiemDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cHITIETTableAdapter = new CaoLongAn_19607001.QLTienGuiTietKiemDataSet2TableAdapters.CHITIETTableAdapter();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.sOTIETKIEMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sOTIETKIEMTableAdapter = new CaoLongAn_19607001.QLTienGuiTietKiemDataSetTableAdapters.SOTIETKIEMTableAdapter();
            this.qLTienGuiTietKiemDataSet1 = new CaoLongAn_19607001.QLTienGuiTietKiemDataSet1();
            this.label1 = new System.Windows.Forms.Label();
            this.button8 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cHITIETBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLTienGuiTietKiemDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLTienGuiTietKiemDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLTienGuiTietKiemDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sOTIETKIEMBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLTienGuiTietKiemDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.soSoDataGridViewTextBoxColumn,
            this.sTTLanGiaoDichDataGridViewTextBoxColumn,
            this.ngayGiaoDichDataGridViewTextBoxColumn,
            this.soTienGiaoDichDataGridViewTextBoxColumn,
            this.maLaiSuatDataGridViewTextBoxColumn,
            this.maNgoaiTeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.cHITIETBindingSource;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1.Location = new System.Drawing.Point(12, 74);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView1.Size = new System.Drawing.Size(999, 218);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridview1_CellClick);
            // 
            // soSoDataGridViewTextBoxColumn
            // 
            this.soSoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.soSoDataGridViewTextBoxColumn.DataPropertyName = "SoSo";
            this.soSoDataGridViewTextBoxColumn.HeaderText = "Số sổ";
            this.soSoDataGridViewTextBoxColumn.Name = "soSoDataGridViewTextBoxColumn";
            this.soSoDataGridViewTextBoxColumn.ReadOnly = true;
            this.soSoDataGridViewTextBoxColumn.Width = 70;
            // 
            // sTTLanGiaoDichDataGridViewTextBoxColumn
            // 
            this.sTTLanGiaoDichDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sTTLanGiaoDichDataGridViewTextBoxColumn.DataPropertyName = "STTLanGiaoDich";
            dataGridViewCellStyle1.NullValue = null;
            this.sTTLanGiaoDichDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.sTTLanGiaoDichDataGridViewTextBoxColumn.HeaderText = "STT lần giao dịch";
            this.sTTLanGiaoDichDataGridViewTextBoxColumn.Name = "sTTLanGiaoDichDataGridViewTextBoxColumn";
            this.sTTLanGiaoDichDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ngayGiaoDichDataGridViewTextBoxColumn
            // 
            this.ngayGiaoDichDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ngayGiaoDichDataGridViewTextBoxColumn.DataPropertyName = "NgayGiaoDich";
            dataGridViewCellStyle2.Format = "dd/MM/yyyy";
            dataGridViewCellStyle2.NullValue = null;
            this.ngayGiaoDichDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.ngayGiaoDichDataGridViewTextBoxColumn.HeaderText = "Ngày giao dịch";
            this.ngayGiaoDichDataGridViewTextBoxColumn.Name = "ngayGiaoDichDataGridViewTextBoxColumn";
            this.ngayGiaoDichDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // soTienGiaoDichDataGridViewTextBoxColumn
            // 
            this.soTienGiaoDichDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.soTienGiaoDichDataGridViewTextBoxColumn.DataPropertyName = "SoTienGiaoDich";
            dataGridViewCellStyle3.Format = "0,000";
            dataGridViewCellStyle3.NullValue = null;
            this.soTienGiaoDichDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.soTienGiaoDichDataGridViewTextBoxColumn.HeaderText = "Số tiền giao dịch";
            this.soTienGiaoDichDataGridViewTextBoxColumn.Name = "soTienGiaoDichDataGridViewTextBoxColumn";
            this.soTienGiaoDichDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // maLaiSuatDataGridViewTextBoxColumn
            // 
            this.maLaiSuatDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.maLaiSuatDataGridViewTextBoxColumn.DataPropertyName = "MaLaiSuat";
            this.maLaiSuatDataGridViewTextBoxColumn.HeaderText = "Mã lãi xuất";
            this.maLaiSuatDataGridViewTextBoxColumn.Name = "maLaiSuatDataGridViewTextBoxColumn";
            this.maLaiSuatDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // maNgoaiTeDataGridViewTextBoxColumn
            // 
            this.maNgoaiTeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.maNgoaiTeDataGridViewTextBoxColumn.DataPropertyName = "MaNgoaiTe";
            this.maNgoaiTeDataGridViewTextBoxColumn.HeaderText = "Mã ngoại tệ";
            this.maNgoaiTeDataGridViewTextBoxColumn.Name = "maNgoaiTeDataGridViewTextBoxColumn";
            this.maNgoaiTeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cHITIETBindingSource
            // 
            this.cHITIETBindingSource.DataMember = "CHITIET";
            this.cHITIETBindingSource.DataSource = this.qLTienGuiTietKiemDataSet2;
            // 
            // qLTienGuiTietKiemDataSet2
            // 
            this.qLTienGuiTietKiemDataSet2.DataSetName = "QLTienGuiTietKiemDataSet2";
            this.qLTienGuiTietKiemDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // qLTienGuiTietKiemDataSet
            // 
            this.qLTienGuiTietKiemDataSet.DataSetName = "QLTienGuiTietKiemDataSet";
            this.qLTienGuiTietKiemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // qLTienGuiTietKiemDataSetBindingSource
            // 
            this.qLTienGuiTietKiemDataSetBindingSource.DataSource = this.qLTienGuiTietKiemDataSet;
            this.qLTienGuiTietKiemDataSetBindingSource.Position = 0;
            // 
            // cHITIETTableAdapter
            // 
            this.cHITIETTableAdapter.ClearBeforeFill = true;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(70, 327);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(94, 21);
            this.comboBox1.TabIndex = 15;
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(304, 327);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(109, 21);
            this.comboBox2.TabIndex = 16;
            // 
            // comboBox3
            // 
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(579, 327);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 21);
            this.comboBox3.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 326);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 18);
            this.label2.TabIndex = 18;
            this.label2.Text = "Số sổ:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(220, 326);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 18);
            this.label3.TabIndex = 19;
            this.label3.Text = "Mã lãi suất:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(484, 326);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 18);
            this.label4.TabIndex = 20;
            this.label4.Text = "Mã ngoại tệ:";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(902, 365);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(43, 20);
            this.textBox1.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(770, 364);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 18);
            this.label5.TabIndex = 23;
            this.label5.Text = "STT lần giao dịch:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(770, 326);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 18);
            this.label6.TabIndex = 24;
            this.label6.Text = "Ngày giao dịch:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(119, 363);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 25;
            this.button1.Text = "Thêm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(227, 363);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 26;
            this.button2.Text = "Xóa";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 363);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 27;
            this.button3.Text = "Thoát";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(335, 363);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 28;
            this.button4.Text = "Làm mới";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(902, 324);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(105, 20);
            this.dateTimePicker1.TabIndex = 29;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(579, 362);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(121, 20);
            this.textBox2.TabIndex = 30;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(452, 364);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 18);
            this.label7.TabIndex = 31;
            this.label7.Text = "Số tiền giao dịch:";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(95, 298);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(44, 23);
            this.button5.TabIndex = 32;
            this.button5.Text = "Lọc";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(335, 298);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(44, 23);
            this.button6.TabIndex = 33;
            this.button6.Text = "Lọc";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(617, 298);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(44, 23);
            this.button7.TabIndex = 34;
            this.button7.Text = "Lọc";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // sOTIETKIEMBindingSource
            // 
            this.sOTIETKIEMBindingSource.DataMember = "SOTIETKIEM";
            this.sOTIETKIEMBindingSource.DataSource = this.qLTienGuiTietKiemDataSetBindingSource;
            // 
            // sOTIETKIEMTableAdapter
            // 
            this.sOTIETKIEMTableAdapter.ClearBeforeFill = true;
            // 
            // qLTienGuiTietKiemDataSet1
            // 
            this.qLTienGuiTietKiemDataSet1.DataSetName = "QLTienGuiTietKiemDataSet1";
            this.qLTienGuiTietKiemDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(287, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(441, 34);
            this.label1.TabIndex = 35;
            this.label1.Text = "THÔNG TIN CHI TIẾT GIAO DỊCH";
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(902, 21);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(109, 30);
            this.button8.TabIndex = 36;
            this.button8.Text = "Tạo báo cáo";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // Chitietgiaodich
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 397);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Chitietgiaodich";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "THÔNG TIN CHI TIẾT GIAO DỊCH";
            this.Load += new System.EventHandler(this.Chitietgiaodich_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cHITIETBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLTienGuiTietKiemDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLTienGuiTietKiemDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLTienGuiTietKiemDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sOTIETKIEMBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLTienGuiTietKiemDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource qLTienGuiTietKiemDataSetBindingSource;
        private QLTienGuiTietKiemDataSet qLTienGuiTietKiemDataSet;
        private QLTienGuiTietKiemDataSet2 qLTienGuiTietKiemDataSet2;
        private System.Windows.Forms.BindingSource cHITIETBindingSource;
        private QLTienGuiTietKiemDataSet2TableAdapters.CHITIETTableAdapter cHITIETTableAdapter;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.BindingSource sOTIETKIEMBindingSource;
        private QLTienGuiTietKiemDataSetTableAdapters.SOTIETKIEMTableAdapter sOTIETKIEMTableAdapter;
        private QLTienGuiTietKiemDataSet1 qLTienGuiTietKiemDataSet1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn soSoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTTLanGiaoDichDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayGiaoDichDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soTienGiaoDichDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maLaiSuatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maNgoaiTeDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button8;
    }
}