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
    public partial class Danhsachngoaite : Form
    {
        QLTGTK db = new QLTGTK();
        public Danhsachngoaite()
        {
            InitializeComponent();
        }

        private void Danhsachngoaite_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLTienGuiTietKiemDataSet5.NGOAITE' table. You can move, or remove it, as needed.
            this.nGOAITETableAdapter.Fill(this.qLTienGuiTietKiemDataSet5.NGOAITE);
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
                string mangoaite = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                NGOAITE s = db.NGOAITEs.FirstOrDefault(p => p.MaNgoaiTe == mangoaite);
                textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                comboBox1.SelectedValue = s.MaNgoaiTe;
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text.Length == 0)
            {
                MessageBox.Show("Vui lòng chọn mã ngoại tệ cần lọc!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            List<NGOAITE> listNgoaite = db.NGOAITEs.ToList();
            dataGridviewclear();
            for (int i = 0; i < listNgoaite.Count; i++)
            {
                if (comboBox1.Text == listNgoaite[i].MaNgoaiTe.ToString())
                {
                    int index = dataGridView1.Rows.Add();
                    dataGridView1.Rows[index].Cells[0].Value = listNgoaite[i].MaNgoaiTe;
                    dataGridView1.Rows[index].Cells[1].Value = listNgoaite[i].TenNgoaiTe;
                }
            }
            textBox1.Clear();
            textBox2.Clear();
        }
        void dataGridviewclear()
        {
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.TextLength == 0 || textBox2.TextLength == 0 )
            {
                MessageBox.Show("Hãy nhập đầy đủ thông tin về ngoại tệ cần thêm hoặc sửa!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (textBox1.TextLength < 3 || textBox1.TextLength > 3)
            {
                MessageBox.Show("Mã ngoại tệ phải gồm 3 ký tự!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            char[] a = textBox1.Text.ToArray();
            if (textBox1.TextLength > 0)
            {
                for (int i = 0; i <= textBox1.TextLength - 1; i++)
                {
                    if (a[i] < 'A' || a[i] > 'Z')
                    {
                        MessageBox.Show("Mã ngoại tệ phải là chữ cái in hoa!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }
            }
            NGOAITE s = db.NGOAITEs.FirstOrDefault(p => p.MaNgoaiTe == textBox1.Text.Trim());
            if (s == null)
            {
                s = new NGOAITE();
                s.MaNgoaiTe = textBox1.Text.Trim();
            }
            s.TenNgoaiTe = textBox2.Text.Trim();
            db.NGOAITEs.AddOrUpdate(s);
            db.SaveChanges();
            dataGridviewrestore();
            MessageBox.Show("Đã xong!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<CHITIET> listChitiet = db.CHITIETs.ToList();
            List<TYGIA> listTygia = db.TYGIAs.ToList();
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa ngoại tệ này không?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                for (int i = 0; i < listChitiet.Count; i++)
                {
                    if (textBox1.Text == listChitiet[i].MaNgoaiTe)
                    {
                        MessageBox.Show("Ngoai tệ này đã được giao dịch, không thể xóa!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }
                for (int i = 0; i < listTygia.Count; i++)
                {
                    if (textBox1.Text == listTygia[i].MaNgoaiTe)
                    {
                        MessageBox.Show("Ngoại tệ này đã được nhập tỷ giá, không thể xóa!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }
                NGOAITE s = db.NGOAITEs.FirstOrDefault(p => p.MaNgoaiTe == textBox1.Text.Trim());
                if (s != null)
                {
                    db.NGOAITEs.Remove(s);
                    db.SaveChanges();
                    dataGridviewrestore();
                    MessageBox.Show("Đã xóa!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        }



        private void button5_Click(object sender, EventArgs e)
        {
            dataGridviewrestore();
            MessageBox.Show("Đã làm mới!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        void getcomboBox1()
        {
            List<NGOAITE> listNgoaite = db.NGOAITEs.ToList();
            comboBox1.DisplayMember = "MaNgoaiTe";
            comboBox1.ValueMember = "MaNgoaiTe";
            comboBox1.DataSource = listNgoaite;
        }
        void dataGridviewrestore()
        {
            dataGridView1.DataSource = qLTienGuiTietKiemDataSet5.NGOAITE;
            this.nGOAITETableAdapter.Fill(this.qLTienGuiTietKiemDataSet5.NGOAITE);
            textBox1.Clear();
            textBox2.Clear();
            getcomboBox1();
        }
    }
}
