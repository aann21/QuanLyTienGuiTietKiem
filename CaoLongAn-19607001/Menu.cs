using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaoLongAn_19607001
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void item1ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DanhSachSoTietKiem formDSSTK = new DanhSachSoTietKiem();
            formDSSTK.Show();
        }


        private void item2ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Chitietgiaodich formCTGD = new Chitietgiaodich();
            formCTGD.Show();
        }

        private void item3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Goilaixuat formGLX = new Goilaixuat();
            formGLX.Show();
        }

        private void item1ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Bangtigia formBTG = new Bangtigia();
            formBTG.Show();
        }

        private void item2ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Danhsachngoaite formDSNT = new Danhsachngoaite();
            formDSNT.Show();
        }

        private void item3ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn đăng xuất không?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                this.Hide();            
                Dangnhap formDangnhap = new Dangnhap();
                formDangnhap.Show();
            }

        }

        private void item4ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Dangky formDangky = new Dangky();
            formDangky.Show();
        }

        private void item1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Danhsachtaikhoan formDSTK = new Danhsachtaikhoan();
            formDSTK.Show();
        }

        private void item2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chức năng hiện đang được phát triển!", "Thông báo !", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void item1ToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chức năng hiện đang được phát triển!", "Thông báo !", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void item2ToolStripMenuItem3_Click(object sender, EventArgs e)
        {          
            Lienhe formLH = new Lienhe();
            formLH.Show();
        }

        private void item3ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chức năng hiện đang được phát triển!", "Thông báo !", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }
        
    }
}
