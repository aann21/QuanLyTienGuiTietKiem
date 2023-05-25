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
namespace CaoLongAn_19607001
{
    public partial class Dangky : Form
    {
        QLTGTK db = new QLTGTK();
        public Dangky()
        {
            InitializeComponent();
        }

        private void Dangky_Load(object sender, EventArgs e)
        {
            if(textBox1.TextLength==0|| textBox2.TextLength == 0|| textBox3.TextLength == 0|| textBox4.TextLength == 0|| textBox5.TextLength == 0)
            {
                button1.Enabled = false;
            }
            else
            {
                button1.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<DANGNHAP> listDangnhap = db.DANGNHAPs.ToList();
            for(int i = 0;i<listDangnhap.Count;i++)
            {
                if(textBox2.Text==listDangnhap[i].Taikhoan)
                {
                    MessageBox.Show("Tên tài khoản đã được sử dụng", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBox2.Focus();
                    return;
                }
            }
            if(textBox4.Text!=textBox5.Text)
            {
                MessageBox.Show("Mật khẩu không khớp!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            DANGNHAP s = new DANGNHAP();
            s.STT = listDangnhap.Count + 1;
            s.Taikhoan = textBox2.Text.Trim();
            s.Matkhau = textBox5.Text.Trim();
            s.Ten = textBox1.Text.Trim();
            s.Email = textBox3.Text.Trim();
            db.DANGNHAPs.Add(s);
            db.SaveChanges();
            MessageBox.Show("Đăng ký thành công!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (MessageBox.Show("Bạn có muốn đăng ký thêm tài khoản khác không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
            {
                this.Close();
            }
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox1.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn hủy đăng ký không?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
