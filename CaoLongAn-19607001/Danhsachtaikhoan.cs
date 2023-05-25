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
    public partial class Danhsachtaikhoan : Form
    {
        public Danhsachtaikhoan()
        {
            InitializeComponent();
        }
        QLTGTK db = new QLTGTK();

        private void Danhsachtaikhoan_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLTienGuiTietKiemDataSetTaikhoan.DANGNHAP' table. You can move, or remove it, as needed.
            this.dANGNHAPTableAdapter.Fill(this.qLTienGuiTietKiemDataSetTaikhoan.DANGNHAP);
            getcomboBox1();
        }
        void getcomboBox1()
        {            
            List<DANGNHAP> listDangnhap = db.DANGNHAPs.ToList();
            comboBox1.DisplayMember = "STT";
            comboBox1.ValueMember = "STT";
            comboBox1.DataSource = listDangnhap;            

        }

        void dataGridviewrestore()
        {
            dataGridView1.DataSource = qLTienGuiTietKiemDataSetTaikhoan.DANGNHAP;
            this.dANGNHAPTableAdapter.Fill(this.qLTienGuiTietKiemDataSetTaikhoan.DANGNHAP);
            getcomboBox1();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            
        }
        void dataGridviewclear()
        {
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dataGridviewrestore();
            MessageBox.Show("Đã xong!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dataGridview1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count - 1)
            {
                string stt = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                DANGNHAP s = db.DANGNHAPs.FirstOrDefault(p => p.STT.ToString() == stt);
                comboBox1.SelectedValue = s.STT;
                textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text.Length == 0)
            {
                MessageBox.Show("Vui lòng chọn số thứ tự cần lọc!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            List<DANGNHAP> listDangnhap = db.DANGNHAPs.ToList();
            dataGridviewclear();
            for (int i = 0; i < listDangnhap.Count; i++)
            {
                if (comboBox1.Text == listDangnhap[i].STT.ToString())
                {
                    int index = dataGridView1.Rows.Add();
                    dataGridView1.Rows[index].Cells[0].Value = listDangnhap[i].STT;
                    dataGridView1.Rows[index].Cells[1].Value = listDangnhap[i].Taikhoan;
                    dataGridView1.Rows[index].Cells[2].Value = listDangnhap[i].Ten;
                    dataGridView1.Rows[index].Cells[3].Value = listDangnhap[i].Email;
                }
            }
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox2.TextLength == 0||textBox3.TextLength==0)
            {
                MessageBox.Show("Hãy nhập đầy đủ thông tin về tài khoản cần sửa!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            char[] a = textBox2.Text.ToArray();
            if (textBox2.TextLength > 0)
            {
                for (int i = 0; i <= textBox2.TextLength - 1; i++)
                {
                    if (a[i] >= '0' && a[i] <= '9')
                    {
                        MessageBox.Show("Tên người dùng phải là chữ cái!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }
            }
            if (textBox2.TextLength > 0 && textBox3.TextLength > 0)
            {
                if (MessageBox.Show("Bạn có chắc chắn muốn sửa tài khoản này không", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
                {
                    return;
                }
            }
            List<DANGNHAP> listDangnhap = db.DANGNHAPs.ToList();
            DANGNHAP s = db.DANGNHAPs.FirstOrDefault(p => p.STT.ToString() == comboBox1.SelectedValue.ToString());
            if (s == null)
            {
                s = new DANGNHAP();
                s.STT = int.Parse(comboBox1.SelectedValue.ToString());
            }
            s.Taikhoan = textBox1.Text.Trim();
            s.Ten = textBox2.Text.Trim();
            s.Email = textBox3.Text.Trim();
            db.DANGNHAPs.AddOrUpdate(s);
            db.SaveChanges();
            dataGridviewrestore();
            MessageBox.Show("Đã sửa xong!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(comboBox1.SelectedValue.ToString()=="1")
            {
                MessageBox.Show("Đây là tài khoản ADMIN, không thể xóa!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa tài khoản này không?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                DANGNHAP s = db.DANGNHAPs.FirstOrDefault(p => p.STT.ToString() == comboBox1.SelectedValue.ToString());
                if (s != null)
                {
                    db.DANGNHAPs.Remove(s);
                    db.SaveChanges();
                    dataGridviewrestore();
                    MessageBox.Show("Đã xóa tài khoản!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không ?", "Thông báo !", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}
