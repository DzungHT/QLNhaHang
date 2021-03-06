﻿using RestaurantManage.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantManage.View
{
    public partial class frmMain : Form
    {
        private NhanVien _NhanVien;

        public NhanVien NhanVien
        {
            get
            {
                return _NhanVien;
            }

            set
            {
                _NhanVien = value;
            }
        }
        public string Username { get; set; }

        public frmMain()
        {
            InitializeComponent();
            frmLogin login = new frmLogin();
            login.Callback += LoadStatusStrip;
            login.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var x = MessageBox.Show("Thoát chương trình?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(x== DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            
        }

        public void LoadStatusStrip(NhanVien nhanVien, string username)
        {
            this.NhanVien = nhanVien;
            this.Username = username;
            toolStripStatusLabel2.Text = Username;
            toolStripStatusLabel5.Text = NhanVien.HoTen;
        }

        private void bánHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            UC_View.UC_BanHang ucBanHang = new UC_View.UC_BanHang();
            ucBanHang.NhanVienID = NhanVien.NhanVienID;
            panel1.Controls.Add(ucBanHang);
            ucBanHang.Dock = DockStyle.Fill;
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            UC_View.UC_QuanLyNhanVien uc = new UC_View.UC_QuanLyNhanVien();
            panel1.Controls.Add(uc);
            uc.Dock = DockStyle.Fill;
        }

        private void loạiMónĂnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            UC_View.UC_Quanlyloaimonan uc = new UC_View.UC_Quanlyloaimonan();
            panel1.Controls.Add(uc);
            uc.Dock = DockStyle.Fill;
        }

        private void mónĂnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            UC_View.UC_Quanlymonan uc = new UC_View.UC_Quanlymonan();
            panel1.Controls.Add(uc);
            uc.Dock = DockStyle.Fill;
        }

        private void khuVựcBànĂnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            UC_View.UC_Quanlykhuvuc uc = new UC_View.UC_Quanlykhuvuc();
            panel1.Controls.Add(uc);
            uc.Dock = DockStyle.Fill;
        }

        private void bănĂnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            UC_View.UC_Quanlybanan uc = new UC_View.UC_Quanlybanan();
            panel1.Controls.Add(uc);
            uc.Dock = DockStyle.Fill;
        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            UC_View.UC_QuanLyKhachHang uc= new UC_View.UC_QuanLyKhachHang();
            panel1.Controls.Add(uc);
            uc.Dock = DockStyle.Fill;
        }

        private void thêmAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            UC_View.UC_QuanLyAccount uc = new UC_View.UC_QuanLyAccount();
            panel1.Controls.Add(uc);
            uc.Dock = DockStyle.Fill;
        }

        private void hóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            UC_View.UC_Quanlyhoadon uc = new UC_View.UC_Quanlyhoadon();
            panel1.Controls.Add(uc);
            uc.Dock = DockStyle.Fill;
        }
    }
}
