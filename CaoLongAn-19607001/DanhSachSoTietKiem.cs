using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity.Migrations;
using CaoLongAn_19607001.Models;
namespace CaoLongAn_19607001
{
    public partial class DanhSachSoTietKiem : Form
    {
        public DanhSachSoTietKiem()
        {
            InitializeComponent();
        }
        QLTGTK db = new QLTGTK();

        private void DanhSachSoTietKiem_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLTienGuiTietKiemDataSet1.SOTIETKIEM' table. You can move, or remove it, as needed.
            this.sOTIETKIEMTableAdapter1.Fill(this.qLTienGuiTietKiemDataSet1.SOTIETKIEM);
            getcomboBox1();
        }

        void getcomboBox1()
        {
            List<SOTIETKIEM> listSotietkiem = db.SOTIETKIEMs.ToList();
            comboBox1.DisplayMember = "SoSo";
            comboBox1.ValueMember = "SoSo";
            comboBox1.DataSource = listSotietkiem;
        }


        private void dataGridview1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex<dataGridView1.Rows.Count-1)
            {
                String soso = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                SOTIETKIEM s = db.SOTIETKIEMs.FirstOrDefault(p => p.SoSo.ToString() == soso);
                textBox0.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                comboBox1.SelectedValue = s.SoSo;
                textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                dateTimePicker1.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                textBox4.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();   
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.TextLength == 0 || textBox1.TextLength == 0 || textBox2.TextLength == 0 || textBox3.TextLength == 0|| textBox4.TextLength == 0 || textBox4.TextLength == 0)
            {
                MessageBox.Show("Hãy nhập đầy đủ thông tin về sổ cần thêm hoặc sửa!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (textBox3.TextLength < 9 || textBox3.TextLength > 9)
            {
                MessageBox.Show("Số Chứng minh nhân dân phải gồm 9 ký tự!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            char[] b = textBox0.Text.ToArray();
            if (textBox0.TextLength > 0)
            {
                for (int i = 0; i <= textBox0.TextLength - 1; i++)
                {
                    if (b[i] < '0' || b[i] > '9')
                    {
                        MessageBox.Show("Số sổ tiết kiệm phải là số!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }
            }
            char[] a = textBox3.Text.ToArray();
            if (textBox3.TextLength > 0)
            {
                for (int i = 0; i <= textBox3.TextLength - 1; i++)
                {
                    if (a[i] < '0' || a[i] > '9')
                    {
                        MessageBox.Show("Số Chứng minh nhân dân phải là số!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }
            }
            List<SOTIETKIEM> listSotietkiem= db.SOTIETKIEMs.ToList();
            for(int i=0;i<listSotietkiem.Count;i++)
            {
                if(textBox0.Text!=listSotietkiem[i].SoSo.ToString() && textBox3.Text == listSotietkiem[i].SoCMND.ToString())
                {
                    MessageBox.Show("Khách hàng đã đăng ký sổ!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
            SOTIETKIEM s = db.SOTIETKIEMs.FirstOrDefault(p => p.SoSo.ToString() == textBox0.Text.ToString());
            if (s == null)
            {
                s = new SOTIETKIEM();
                s.SoSo =int.Parse(textBox0.Text.ToString());
            }
            int dem = 0;
            for(int i=0;i<listSotietkiem.Count;i++)
            {
                if(textBox0.Text==listSotietkiem[i].SoSo.ToString())
                {
                    s.NgayLapSo = dateTimePicker1.Value;
                    break;
                }
                dem++;
                if(dem==listSotietkiem.Count && textBox0.Text != listSotietkiem[i].SoSo.ToString())
                {
                    s.NgayLapSo = DateTime.Now;
                    break;
                }
            }
            s.TenKhachHang = textBox1.Text.Trim();
            s.SoCMND = textBox3.Text.Trim();
            s.DiaChi = textBox2.Text.Trim();
            s.GhiChu = textBox4.Text.Trim();
            db.SOTIETKIEMs.AddOrUpdate(s);
            db.SaveChanges();
            dataGridviewrestore();
            getcomboBox1();
            MessageBox.Show("Đã xong!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<CHITIET> listChitiet = db.CHITIETs.ToList();
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa sổ tiết kiệm này không?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                for (int i = 0; i < listChitiet.Count; i++)
                {
                    if (comboBox1.Text == listChitiet[i].SoSo.ToString())
                    {
                        MessageBox.Show("Sổ này đã tham gia giao dịch, không thể xóa!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }
                SOTIETKIEM s = db.SOTIETKIEMs.FirstOrDefault(p => p.SoSo.ToString() == comboBox1.Text.Trim());
                if (s != null)
                {
                    db.SOTIETKIEMs.Remove(s);
                    db.SaveChanges();
                    dataGridviewrestore();
                    getcomboBox1();
                    MessageBox.Show("Đã xóa!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            dataGridviewrestore();
            getcomboBox1();
            MessageBox.Show("Đã xong!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if(comboBox1.Text.Length==0)
            {
                MessageBox.Show("Vui lòng chọn số sổ cần lọc!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            List<SOTIETKIEM> listSotietkiem = db.SOTIETKIEMs.ToList();
            dataGridviewclear();
            int index = dataGridView1.Rows.Add();
            for (int i = 0; i < listSotietkiem.Count; i++)
            {
                if (comboBox1.Text == listSotietkiem[i].SoSo.ToString())
                {
                    dataGridView1.Rows[index].Cells[0].Value = listSotietkiem[i].SoSo;
                    dataGridView1.Rows[index].Cells[1].Value = listSotietkiem[i].NgayLapSo;
                    dataGridView1.Rows[index].Cells[2].Value = listSotietkiem[i].TenKhachHang;
                    dataGridView1.Rows[index].Cells[3].Value = listSotietkiem[i].SoCMND;
                    dataGridView1.Rows[index].Cells[4].Value = listSotietkiem[i].DiaChi;
                    dataGridView1.Rows[index].Cells[5].Value = listSotietkiem[i].GhiChu;
                }
            }
            textBox0.Clear();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            dateTimePicker1.ResetText();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            List<SOTIETKIEM> listSotietkiem = db.SOTIETKIEMs.ToList();
            if (textBox5.TextLength == 0|| textBox5.Text == "Nhập tên khách hàng cần tìm...")
            {
                MessageBox.Show("Vui lòng nhập tên người cần tìm!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                int dem = 0;
                dataGridviewclear();
                for (int i = 0; i < listSotietkiem.Count; i++)
                {   
                    dem++;
                    if (textBox5.Text == listSotietkiem[i].TenKhachHang)
                    {
                        int index = dataGridView1.Rows.Add();
                        dataGridView1.Rows[index].Cells[0].Value = listSotietkiem[i].SoSo;
                        dataGridView1.Rows[index].Cells[1].Value = listSotietkiem[i].NgayLapSo;
                        dataGridView1.Rows[index].Cells[2].Value = listSotietkiem[i].TenKhachHang;
                        dataGridView1.Rows[index].Cells[3].Value = listSotietkiem[i].SoCMND;
                        dataGridView1.Rows[index].Cells[4].Value = listSotietkiem[i].DiaChi;
                        dataGridView1.Rows[index].Cells[5].Value = listSotietkiem[i].GhiChu;
                        textBox0.Clear();
                        textBox1.Clear();
                        textBox2.Clear();
                        textBox3.Clear();
                        textBox4.Clear();
                        dateTimePicker1.ResetText();
                        getcomboBox1();
                        MessageBox.Show("Đã tìm thấy!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        continue;
                    }

                    if (dem == listSotietkiem.Count() && textBox5.Text != listSotietkiem[i].TenKhachHang)
                    {
                        dataGridView1.DataSource = qLTienGuiTietKiemDataSet1.SOTIETKIEM;
                        MessageBox.Show("Không tìm thấy khách hàng cần tìm!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        textBox5.Clear();
                    }
                }
            }
        }
        void dataGridviewclear()
        {
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
        }
        private void textBox5_Enter(object sender, EventArgs e)
        {
            if (textBox5.Text == "Nhập tên khách hàng cần tìm...")
            {
                textBox5.Text = "";
                textBox5.ForeColor = Color.Black;
            }
        }

        private void textBox5_Leave(object sender, EventArgs e)
        {
            if (textBox5.Text == "")
            {
                textBox5.Text = "Nhập tên khách hàng cần tìm...";
                textBox5.ForeColor = Color.Gray;
            }
        }
        void dataGridviewrestore()
        {
            dataGridView1.DataSource = qLTienGuiTietKiemDataSet1.SOTIETKIEM;
            this.sOTIETKIEMTableAdapter1.Fill(this.qLTienGuiTietKiemDataSet1.SOTIETKIEM);
            textBox0.Clear();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            dateTimePicker1.ResetText();
        }

    }
}
