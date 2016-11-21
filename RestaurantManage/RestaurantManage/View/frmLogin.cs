﻿using System;
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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            tbTendangnhap.Focus();
        }

        private void btnDangnhap_Click(object sender, EventArgs e)
        {
            this.Login();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.RefreshForm();
        }
        private void tbTendangnhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                this.Login();
            }
        }

        private void tbMatkhau_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                this.Login();
            }
        }
        #region Hàm hỗ trợ
        // Kiểm tra thông tin đầu vào
        private bool CheckInput(string UserName, string Password)
        {
            if (UserName.Trim() == "" || Password.Trim() == "")
            {
                lblThongbao.Text = "Vui lòng không để trống!";
                return false;
            }
            else
            {
                if (UserName.Trim().Contains(" ") || Password.Trim().Contains(" "))
                {
                    lblThongbao.Text = "Tên đăng nhập hoặc mật khẩu không hợp lệ";
                    return false;
                }
                return true;
            }
        }
        // Dang nhap
        private void Login()
        {
            if (CheckInput(tbTendangnhap.Text, tbMatkhau.Text))
            {
                lblThongbao.Visible = false;
                frmMain _frmMain = new frmMain();
                _frmMain.Show();
                _frmMain.Activate();
                this.Hide();
            }
            else
            {
                lblThongbao.Visible = true;
                return;
            }
        }
        // Refresh
        private void RefreshForm()
        {
            lblThongbao.Visible = false;
            tbMatkhau.Text = "";
            tbTendangnhap.Text = "";
        }
        #endregion
    }
}
