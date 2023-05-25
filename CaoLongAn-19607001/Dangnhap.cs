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
    public partial class Dangnhap : Form
    {
        public Dangnhap()
        {
            InitializeComponent();
        }
        QLTGTK data = new QLTGTK();
        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.TextLength==0|| textBox2.TextLength==0)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin đăng nhập!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            List<DANGNHAP> Login = data.DANGNHAPs.ToList();
            int dem = 0;
            int i=0;
            do
            {
                if (textBox1.Text == Login[i].Taikhoan && textBox2.Text == Login[i].Matkhau)
                {
                    Menu formMenu = new Menu();
                    MessageBox.Show("Đăng nhập thành công!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    formMenu.Show();
                    return;
                }
                i++;

            } while( i < Login.Count);

            MessageBox.Show("Thông tin đăng nhập sai, vui lòng nhập lại!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            textBox1.Clear();
            textBox2.Clear();
            textBox1.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có muốn thoát khỏi đăng nhập không?","Thoát",MessageBoxButtons.YesNo,MessageBoxIcon.Information)==DialogResult.Yes)
            {
                System.Windows.Forms.Application.ExitThread();
            }
        }

        private void Dangnhap_Load(object sender, EventArgs e)
        {

        }
    }
}
