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
    public partial class Bangtigia : Form
    {
        QLTGTK db = new QLTGTK();
        public Bangtigia()
        {
            InitializeComponent();
        }

        private void Bangtigia_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLTienGuiTietKiemDataSet4.TYGIA' table. You can move, or remove it, as needed.
            this.tYGIATableAdapter.Fill(this.qLTienGuiTietKiemDataSet4.TYGIA);
            getcomboBox1();
        }
        void getcomboBox1()
        {
            List<NGOAITE> listNgoaite = db.NGOAITEs.ToList();
            comboBox1.DisplayMember = "MaNgoaiTe";
            comboBox1.ValueMember = "MaNgoaiTe";
            comboBox1.DataSource = listNgoaite;
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
                string mangoaite = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                TYGIA s = db.TYGIAs.FirstOrDefault(p => p.MaNgoaiTe == mangoaite);
                comboBox1.SelectedValue = s.MaNgoaiTe;
                dateTimePicker1.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.TextLength == 0 || textBox2.TextLength == 0)
            {
                MessageBox.Show("Hãy nhập đầy đủ thông tin về tỷ giá cần thêm hoặc sửa!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            char[] a = textBox1.Text.ToArray();
            if (textBox1.TextLength > 0)
            {
                for (int i = 0; i <= textBox1.TextLength - 1; i++)
                {
                    if (a[i] < '0' || a[i] > '9')
                    {
                        MessageBox.Show("Quy ra VND phải là số!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }
            }
            TYGIA s = db.TYGIAs.FirstOrDefault(p => p.MaNgoaiTe == comboBox1.SelectedValue.ToString());
            if (s == null)
            {
                s = new TYGIA();
                s.MaNgoaiTe = comboBox1.SelectedValue.ToString();
            }
            s.NgayBatDauApDung = dateTimePicker1.Value;
            s.QuyRaVND = int.Parse(textBox1.Text.Trim());
            s.GhiChu=textBox2.Text.Trim();
            db.TYGIAs.AddOrUpdate(s);
            db.SaveChanges();
            dataGridviewrestore();
            MessageBox.Show("Đã xong!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa tỷ giá này không?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                TYGIA s = db.TYGIAs.FirstOrDefault(p => p.MaNgoaiTe == comboBox1.SelectedValue.ToString());
                if (s != null)
                {
                    db.TYGIAs.Remove(s);
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

        private void button5_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text.Length == 0)
            {
                MessageBox.Show("Vui lòng chọn mã ngoại tệ cần lọc!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            List<TYGIA> listTygia = db.TYGIAs.ToList();
            dataGridviewclear();
            int index = dataGridView1.Rows.Add();
            for (int i = 0; i < listTygia.Count; i++)
            {
                if (comboBox1.Text == listTygia[i].MaNgoaiTe.ToString())
                {
                    dataGridView1.Rows[index].Cells[0].Value = listTygia[i].MaNgoaiTe;
                    dataGridView1.Rows[index].Cells[1].Value = listTygia[i].NgayBatDauApDung;
                    dataGridView1.Rows[index].Cells[2].Value = listTygia[i].QuyRaVND;
                    dataGridView1.Rows[index].Cells[3].Value = listTygia[i].GhiChu;
                }
            }
            textBox1.Clear();
            textBox2.Clear();
            dateTimePicker1.ResetText();
        }
        void dataGridviewrestore()
        {
            dataGridView1.DataSource = qLTienGuiTietKiemDataSet4.TYGIA;
            this.tYGIATableAdapter.Fill(this.qLTienGuiTietKiemDataSet4.TYGIA);
            getcomboBox1();
            dateTimePicker1.ResetText();
            textBox1.Clear();
            textBox2.Clear();
        }
        void dataGridviewclear()
        {
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
        }
    }
}
