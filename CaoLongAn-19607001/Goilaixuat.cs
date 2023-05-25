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
    public partial class Goilaixuat : Form
    {
        QLTGTK db = new QLTGTK();
        public Goilaixuat()
        {
            InitializeComponent();
        }

        private void Goilaixuat_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLTienGuiTietKiemDataSet3.LAISUAT' table. You can move, or remove it, as needed.
            this.lAISUATTableAdapter.Fill(this.qLTienGuiTietKiemDataSet3.LAISUAT);
            getcomboBox1();
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
                string malaisuat = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                LAISUAT s = db.LAISUATs.FirstOrDefault(p => p.MaLaiSuat.ToString() == malaisuat);
                textBox0.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                dateTimePicker1.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                comboBox1.SelectedValue = s.MaLaiSuat;
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text.Length == 0)
            {
                MessageBox.Show("Vui lòng chọn hoặc nhập mã lãi suất cần lọc!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            List<LAISUAT> listLaisuat = db.LAISUATs.ToList();
            dataGridviewclear();
            int dem = 0;
            for (int i = 0; i < listLaisuat.Count; i++)
            {
                dem++;
                if (comboBox1.Text == listLaisuat[i].MaLaiSuat.ToString())
                {
                    int index = dataGridView1.Rows.Add();
                    dataGridView1.Rows[index].Cells[0].Value = listLaisuat[i].MaLaiSuat;
                    dataGridView1.Rows[index].Cells[1].Value = listLaisuat[i].KyHan;
                    dataGridView1.Rows[index].Cells[2].Value = listLaisuat[i].PhanTramLaiXuat;
                    dataGridView1.Rows[index].Cells[3].Value = listLaisuat[i].NgayBatDauApDung;
                    dataGridView1.Rows[index].Cells[4].Value = listLaisuat[i].GhiChu;
                    break;
                }
                if (dem == listLaisuat.Count() && comboBox1.Text != listLaisuat[i].MaLaiSuat)
                {
                    dataGridView1.DataSource = qLTienGuiTietKiemDataSet3.LAISUAT;
                    MessageBox.Show("Nhập hoặc chọn đúng mã đã có sẵn!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    getcomboBox1();
                    return;
                }
            }
            textBox0.Clear();
            textBox1.Clear();
            textBox2.Clear();
            textBox2.Clear();
            textBox3.Clear();
            dateTimePicker1.ResetText();
        }
        void dataGridviewclear()
        {
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox0.TextLength==0||textBox1.TextLength==0||textBox2.TextLength==0||textBox3.TextLength==0)
            {
                MessageBox.Show("Hãy nhập đầy đủ thông tin về gói cần thêm hoặc sửa!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (textBox0.TextLength<5 ||textBox0.TextLength>5)
            {
                MessageBox.Show("Mã lãi suất phải gồm 5 ký tự!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            char[] a = textBox2.Text.ToArray();
            if(textBox2.TextLength>0)
            {
                for(int i = 0;i<=textBox2.TextLength-1;i++)
                {
                    if(a[i]<'0'||a[i]>'9')
                    {
                        MessageBox.Show("Phần trăm lãi suất phải là số!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }
            }
            LAISUAT s = db.LAISUATs.FirstOrDefault(p => p.MaLaiSuat.ToString() == textBox0.Text.Trim());
            if (s == null)
            {
                s = new LAISUAT();
                s.MaLaiSuat = textBox0.Text.Trim();
            }
            s.KyHan = textBox1.Text.Trim();
            s.PhanTramLaiXuat =Decimal.Parse(textBox2.Text.Trim());
            s.NgayBatDauApDung = dateTimePicker1.Value;
            s.GhiChu = textBox3.Text.Trim();
            db.LAISUATs.AddOrUpdate(s);
            db.SaveChanges();
            dataGridviewrestore();
            MessageBox.Show("Đã xong!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<CHITIET> listChitiet = db.CHITIETs.ToList();
            if(MessageBox.Show("Bạn có chắc chắn muốn xóa gói này không?","Thông báo!",MessageBoxButtons.YesNo,MessageBoxIcon.Warning)==DialogResult.Yes)
            {
                for (int i = 0; i < listChitiet.Count; i++)
                {
                    if (textBox0.Text == listChitiet[i].MaLaiSuat.ToString())
                    {
                        MessageBox.Show("Gói này đang được khách hàng đăng ký, không thể xóa!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }
                LAISUAT s = db.LAISUATs.FirstOrDefault(p => p.MaLaiSuat == textBox0.Text.Trim());
                if (s != null)
                {
                    db.LAISUATs.Remove(s);
                    db.SaveChanges();
                    dataGridviewrestore();
                    MessageBox.Show("Đã xóa!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        }


        void dataGridviewrestore()
        {
            dataGridView1.DataSource = qLTienGuiTietKiemDataSet3.LAISUAT;
            this.lAISUATTableAdapter.Fill(this.qLTienGuiTietKiemDataSet3.LAISUAT);
            textBox0.Clear();
            textBox1.Clear();
            textBox2.Clear();
            textBox2.Clear();
            textBox3.Clear();
            dateTimePicker1.ResetText();
            getcomboBox1();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dataGridviewrestore();
            MessageBox.Show("Đã làm mới!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        void getcomboBox1()
        {
            comboBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBox1.AutoCompleteSource = AutoCompleteSource.ListItems;
            List<LAISUAT> listLaixuat = db.LAISUATs.ToList();
            comboBox1.DisplayMember = "MaLaiSuat";
            comboBox1.ValueMember = "MaLaiSuat";
            comboBox1.DataSource = listLaixuat;
        }
    }
}

