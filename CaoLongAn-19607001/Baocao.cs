using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CaoLongAn_19607001.Models;
using System.Data.Entity.Migrations;
using Microsoft.Reporting.WinForms;
using System.Data.SqlClient;

namespace CaoLongAn_19607001
{
    
    public partial class Baocao : Form
    {
        QLTGTK db = new QLTGTK();
        public Baocao()
        {
            InitializeComponent();
        }

        private void Baocao_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'datasetRP.CHITIET' table. You can move, or remove it, as needed.
            this.cHITIETTableAdapter.Fill(this.datasetRP.CHITIET);
            // TODO: This line of code loads data into the 'datasetRP.CHITIET' table. You can move, or remove it, as needed.
            reportViewer1.RefreshReport();
            getcomboBox1();
        }

        void getcomboBox1()
        {
            List<SOTIETKIEM> listSotietkiem = db.SOTIETKIEMs.ToList();
            comboBox1.DisplayMember = "SoSo";
            comboBox1.ValueMember = "SoSo";
            comboBox1.DataSource = listSotietkiem;
        }
        private void button1_Click(object sender, EventArgs e)
        {   
            
            String sql = "Select * from CHITIET Where NgayGiaoDich ='" +dateTimePicker1.Value.ToString()+"'";
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Server =.\SQLEXPRESS; Database =QLTienGuiTietKiem; Trusted_Connection = true";
            SqlDataAdapter adp = new SqlDataAdapter(sql, con);
            DatasetRP ds = new DatasetRP();
            adp.Fill(ds,"CHITIET");
            reportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;
            reportViewer1.LocalReport.ReportPath = "ChitietgiaodichRP.rdlc";
            if (ds.Tables["CHITIET"].Rows.Count>0)
            {
                ReportDataSource rds = new ReportDataSource("DatasetRP",ds.Tables[0]);
                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(rds);
                reportViewer1.RefreshReport();
            }
            else
            {
                MessageBox.Show("Ngày này không có giao dịch nào!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String sql = "Select * from CHITIET Where SoSo =" + comboBox1.SelectedValue.ToString() + "";
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Server =.\SQLEXPRESS; Database =QLTienGuiTietKiem; Trusted_Connection = true";
            SqlDataAdapter adp = new SqlDataAdapter(sql, con);
            DatasetRP ds = new DatasetRP();
            adp.Fill(ds, "CHITIET");
            reportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;
            reportViewer1.LocalReport.ReportPath = "ChitietgiaodichRP.rdlc";
            if (ds.Tables["CHITIET"].Rows.Count > 0)
            {
                ReportDataSource rds = new ReportDataSource("DatasetRP", ds.Tables[0]);
                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(rds);
                reportViewer1.RefreshReport();
            }
            else
            {
                MessageBox.Show("Số sổ này chưa thực hiện giao dịch nào!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không ?", "Thông báo !", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }


}
