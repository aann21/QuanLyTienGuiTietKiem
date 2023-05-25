
namespace CaoLongAn_19607001
{
    partial class Bangtigia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bangtigia));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.maNgoaiTeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayBatDauApDungDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quyRaVNDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ghiChuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tYGIABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLTienGuiTietKiemDataSet4 = new CaoLongAn_19607001.QLTienGuiTietKiemDataSet4();
            this.tYGIATableAdapter = new CaoLongAn_19607001.QLTienGuiTietKiemDataSet4TableAdapters.TYGIATableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tYGIABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLTienGuiTietKiemDataSet4)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maNgoaiTeDataGridViewTextBoxColumn,
            this.ngayBatDauApDungDataGridViewTextBoxColumn,
            this.quyRaVNDDataGridViewTextBoxColumn,
            this.ghiChuDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tYGIABindingSource;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1.Location = new System.Drawing.Point(12, 56);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 250);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridview1_CellClick);
            // 
            // maNgoaiTeDataGridViewTextBoxColumn
            // 
            this.maNgoaiTeDataGridViewTextBoxColumn.DataPropertyName = "MaNgoaiTe";
            dataGridViewCellStyle1.NullValue = null;
            this.maNgoaiTeDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.maNgoaiTeDataGridViewTextBoxColumn.HeaderText = "Mã ngoại tệ";
            this.maNgoaiTeDataGridViewTextBoxColumn.Name = "maNgoaiTeDataGridViewTextBoxColumn";
            // 
            // ngayBatDauApDungDataGridViewTextBoxColumn
            // 
            this.ngayBatDauApDungDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ngayBatDauApDungDataGridViewTextBoxColumn.DataPropertyName = "NgayBatDauApDung";
            dataGridViewCellStyle2.Format = "dd/MM/yyyy";
            dataGridViewCellStyle2.NullValue = null;
            this.ngayBatDauApDungDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.ngayBatDauApDungDataGridViewTextBoxColumn.HeaderText = "Ngày bắt đầu áp dụng";
            this.ngayBatDauApDungDataGridViewTextBoxColumn.Name = "ngayBatDauApDungDataGridViewTextBoxColumn";
            // 
            // quyRaVNDDataGridViewTextBoxColumn
            // 
            this.quyRaVNDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.quyRaVNDDataGridViewTextBoxColumn.DataPropertyName = "QuyRaVND";
            dataGridViewCellStyle3.Format = "0,0\' VND";
            dataGridViewCellStyle3.NullValue = null;
            this.quyRaVNDDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.quyRaVNDDataGridViewTextBoxColumn.HeaderText = "Quy ra VND";
            this.quyRaVNDDataGridViewTextBoxColumn.Name = "quyRaVNDDataGridViewTextBoxColumn";
            // 
            // ghiChuDataGridViewTextBoxColumn
            // 
            this.ghiChuDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ghiChuDataGridViewTextBoxColumn.DataPropertyName = "GhiChu";
            this.ghiChuDataGridViewTextBoxColumn.HeaderText = "Ghi chú";
            this.ghiChuDataGridViewTextBoxColumn.Name = "ghiChuDataGridViewTextBoxColumn";
            // 
            // tYGIABindingSource
            // 
            this.tYGIABindingSource.DataMember = "TYGIA";
            this.tYGIABindingSource.DataSource = this.qLTienGuiTietKiemDataSet4;
            // 
            // qLTienGuiTietKiemDataSet4
            // 
            this.qLTienGuiTietKiemDataSet4.DataSetName = "QLTienGuiTietKiemDataSet4";
            this.qLTienGuiTietKiemDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tYGIATableAdapter
            // 
            this.tYGIATableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(42, 323);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "Mã ngoại tệ: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(191, 323);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 16);
            this.label3.TabIndex = 16;
            this.label3.Text = "Ngày bắt đầu áp dụng:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(410, 325);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 16);
            this.label4.TabIndex = 17;
            this.label4.Text = "Quy ra VND:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(653, 326);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 16);
            this.label5.TabIndex = 18;
            this.label5.Text = "Ghi chú:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 345);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(75, 21);
            this.comboBox1.TabIndex = 19;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(387, 345);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(87, 20);
            this.textBox1.TabIndex = 21;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(570, 345);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(218, 93);
            this.textBox2.TabIndex = 22;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(210, 345);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(100, 20);
            this.dateTimePicker1.TabIndex = 23;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(135, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 24;
            this.button1.Text = "Thêm/Sửa";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(260, 415);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 25;
            this.button2.Text = "Xóa";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 415);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 26;
            this.button3.Text = "Thoát";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(384, 415);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 27;
            this.button4.Text = "Làm mới";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(480, 347);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 16);
            this.label6.TabIndex = 28;
            this.label6.Text = "VND";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(98, 344);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(50, 23);
            this.button5.TabIndex = 29;
            this.button5.Text = "Lọc";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Cambria", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(303, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(189, 34);
            this.label8.TabIndex = 39;
            this.label8.Text = "BẢNG TỶ GIÁ";
            // 
            // Bangtigia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 450);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Bangtigia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BẢNG TỶ GIÁ";
            this.Load += new System.EventHandler(this.Bangtigia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tYGIABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLTienGuiTietKiemDataSet4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private QLTienGuiTietKiemDataSet4 qLTienGuiTietKiemDataSet4;
        private System.Windows.Forms.BindingSource tYGIABindingSource;
        private QLTienGuiTietKiemDataSet4TableAdapters.TYGIATableAdapter tYGIATableAdapter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridViewTextBoxColumn maNgoaiTeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayBatDauApDungDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quyRaVNDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ghiChuDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label8;
    }
}