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
    public partial class Chitietgiaodich : Form
    {
        QLTGTK db = new QLTGTK();
        public Chitietgiaodich()
        {
            InitializeComponent();
        }

        private void Chitietgiaodich_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLTienGuiTietKiemDataSet2.CHITIET' table. You can move, or remove it, as needed.
            this.cHITIETTableAdapter.Fill(this.qLTienGuiTietKiemDataSet2.CHITIET);
            getcomboBox1();
            getcomboBox2();
            getcomboBox3();
        }
        void getcomboBox1()
        {
            List<SOTIETKIEM> listSotietkiem = db.SOTIETKIEMs.ToList();
            comboBox1.DisplayMember = "SoSo";
            comboBox1.ValueMember = "SoSo";
            comboBox1.DataSource = listSotietkiem;
        }
        void getcomboBox2()
        {
            List<LAISUAT> listLaisuat = db.LAISUATs.ToList();
            comboBox2.DisplayMember = "MaLaiSuat";
            comboBox2.ValueMember = "MaLaiSuat";
            comboBox2.DataSource = listLaisuat;
        }
        void getcomboBox3()
        {
            List<NGOAITE> listNgoaite = db.NGOAITEs.ToList();
            comboBox3.DisplayMember = "MaNgoaiTe";
            comboBox3.ValueMember = "MaNgoaiTe";
            comboBox3.DataSource = listNgoaite;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không ?", "Thông báo !", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void dataGridview1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count - 1)
            {
                string soso = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                CHITIET s = db.CHITIETs.FirstOrDefault(p => p.SoSo.ToString() == soso);
                comboBox1.SelectedValue = s.SoSo;
                string malaisuat = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                CHITIET m1 = db.CHITIETs.FirstOrDefault(p => p.MaLaiSuat.ToString() == malaisuat);
                comboBox2.SelectedValue = m1.MaLaiSuat;
                string mangoaite = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                CHITIET m2 = db.CHITIETs.FirstOrDefault(p => p.MaNgoaiTe.ToString() == mangoaite);
                comboBox3.SelectedValue = m2.MaNgoaiTe;
                textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                dateTimePicker1.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.TextLength == 0)
            {
                MessageBox.Show("Hãy nhập đầy đủ thông tin về chi tiết giao dịch cần thêm hoặc sửa!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            char[] a = textBox2.Text.ToArray();
            if (textBox2.TextLength > 0)
            {
                for (int i = 0; i <= textBox2.TextLength - 1; i++)
                {
                    if (a[i] < '0' || a[i] > '9')
                    {
                        MessageBox.Show("Số tiền giao dịch phải là số!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }
            }
            textBox1.Clear();
            List < CHITIET >  listChitiet = db.CHITIETs.ToList();
            CHITIET s = db.CHITIETs.FirstOrDefault(p=>p.STTLanGiaoDich.ToString()== textBox1.Text);
            if (s == null)
            {
                s = new CHITIET();
                s.STTLanGiaoDich = listChitiet.Count +1;
            }
            s.NgayGiaoDich = DateTime.Now;
            s.SoSo = int.Parse(comboBox1.SelectedValue.ToString());
            s.SoTienGiaoDich = int.Parse(textBox2.Text.Trim());
            s.MaLaiSuat = comboBox2.SelectedValue.ToString();
            s.MaNgoaiTe = comboBox3.SelectedValue.ToString();
            db.CHITIETs.Add(s);
            db.SaveChanges();
            dataGridviewrestore();
            MessageBox.Show("Đã xong!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa giao dịch này không?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                CHITIET s = db.CHITIETs.FirstOrDefault(p => p.STTLanGiaoDich.ToString() == textBox1.Text.Trim());
                if (s != null)
                {
                    db.CHITIETs.Remove(s);
                    db.SaveChanges();
                    dataGridviewrestore();
                    MessageBox.Show("Đã xóa!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridviewrestore();
            MessageBox.Show("Đã xong!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        void dataGridviewrestore()
        {
            dataGridView1.DataSource = qLTienGuiTietKiemDataSet2.CHITIET;
            this.cHITIETTableAdapter.Fill(this.qLTienGuiTietKiemDataSet2.CHITIET);
            textBox1.Clear();
            textBox2.Clear();
            dateTimePicker1.ResetText();
            getcomboBox1();
            getcomboBox2();
            getcomboBox3();
        }
        void dataGridviewclear()
        {
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text.Length == 0)
            {
                MessageBox.Show("Vui lòng chọn số sổ cần lọc!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            List<CHITIET> listChitiet = db.CHITIETs.ToList();
            dataGridviewclear();
            for (int i = 0; i < listChitiet.Count; i++)
            {
                if (comboBox1.Text == listChitiet[i].SoSo.ToString())
                {
                    int index = dataGridView1.Rows.Add();
                    dataGridView1.Rows[index].Cells[0].Value = listChitiet[i].SoSo;
                    dataGridView1.Rows[index].Cells[1].Value = listChitiet[i].STTLanGiaoDich;
                    dataGridView1.Rows[index].Cells[2].Value = listChitiet[i].NgayGiaoDich;
                    dataGridView1.Rows[index].Cells[3].Value = listChitiet[i].SoTienGiaoDich;
                    dataGridView1.Rows[index].Cells[4].Value = listChitiet[i].MaLaiSuat;
                    dataGridView1.Rows[index].Cells[5].Value = listChitiet[i].MaNgoaiTe;
                }
            }
            if (dataGridView1.RowCount == 1)
            {
                dataGridView1.DataSource = qLTienGuiTietKiemDataSet2.CHITIET;
                this.cHITIETTableAdapter.Fill(this.qLTienGuiTietKiemDataSet2.CHITIET);
                textBox1.Clear();
                textBox2.Clear();
                dateTimePicker1.ResetText();
                getcomboBox3();
                getcomboBox2();
                MessageBox.Show("Số sổ chưa được giao dịch!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            textBox1.Clear();
            textBox2.Clear();
            dateTimePicker1.ResetText();
            getcomboBox2();
            getcomboBox3();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (comboBox2.Text.Length == 0)
            {
                MessageBox.Show("Vui lòng chọn mã lãi suất cần lọc!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            List<CHITIET> listChitiet = db.CHITIETs.ToList();
            dataGridviewclear();
            for (int i = 0; i < listChitiet.Count; i++)
            {
                if (comboBox2.Text == listChitiet[i].MaLaiSuat.ToString())
                {
                    int index = dataGridView1.Rows.Add();
                    dataGridView1.Rows[index].Cells[0].Value = listChitiet[i].SoSo;
                    dataGridView1.Rows[index].Cells[1].Value = listChitiet[i].STTLanGiaoDich;
                    dataGridView1.Rows[index].Cells[2].Value = listChitiet[i].NgayGiaoDich;
                    dataGridView1.Rows[index].Cells[3].Value = listChitiet[i].SoTienGiaoDich;
                    dataGridView1.Rows[index].Cells[4].Value = listChitiet[i].MaLaiSuat;
                    dataGridView1.Rows[index].Cells[5].Value = listChitiet[i].MaNgoaiTe;
                }
            }
            if (dataGridView1.RowCount == 1)
            {
                dataGridView1.DataSource = qLTienGuiTietKiemDataSet2.CHITIET;
                this.cHITIETTableAdapter.Fill(this.qLTienGuiTietKiemDataSet2.CHITIET);
                textBox1.Clear();
                textBox2.Clear();
                dateTimePicker1.ResetText();
                getcomboBox1();
                getcomboBox3();
                MessageBox.Show("Mã lãi xuất chưa được đăng ký!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            textBox1.Clear();
            textBox2.Clear();
            dateTimePicker1.ResetText();
            getcomboBox1();
            getcomboBox3();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (comboBox3.Text.Length == 0)
            {
                MessageBox.Show("Vui lòng chọn mã ngoại tệ cần lọc!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            List<CHITIET> listChitiet = db.CHITIETs.ToList();
            dataGridviewclear();
            for (int i = 0; i < listChitiet.Count; i++)
            {
                if (comboBox3.Text == listChitiet[i].MaNgoaiTe.ToString())
                {
                    int index = dataGridView1.Rows.Add();
                    dataGridView1.Rows[index].Cells[0].Value = listChitiet[i].SoSo;
                    dataGridView1.Rows[index].Cells[1].Value = listChitiet[i].STTLanGiaoDich;
                    dataGridView1.Rows[index].Cells[2].Value = listChitiet[i].NgayGiaoDich;
                    dataGridView1.Rows[index].Cells[3].Value = listChitiet[i].SoTienGiaoDich;
                    dataGridView1.Rows[index].Cells[4].Value = listChitiet[i].MaLaiSuat;
                    dataGridView1.Rows[index].Cells[5].Value = listChitiet[i].MaNgoaiTe;
                }
            }
            if(dataGridView1.RowCount==1)
            {
                dataGridView1.DataSource = qLTienGuiTietKiemDataSet2.CHITIET;
                this.cHITIETTableAdapter.Fill(this.qLTienGuiTietKiemDataSet2.CHITIET);
                textBox1.Clear();
                textBox2.Clear();
                dateTimePicker1.ResetText();
                getcomboBox1();
                getcomboBox2();
                MessageBox.Show("Mã ngoại tệ chưa được dùng!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            textBox1.Clear();
            textBox2.Clear();
            dateTimePicker1.ResetText();
            getcomboBox1();
            getcomboBox2();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Baocao formBaoCao = new Baocao();
            formBaoCao.Show();
        }

    }
}


