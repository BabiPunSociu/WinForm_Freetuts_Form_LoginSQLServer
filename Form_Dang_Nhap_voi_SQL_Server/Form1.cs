using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DevExpress.XtraEditors.Mask.MaskSettings;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Form_Dang_Nhap_voi_SQL_Server
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static string UserName = "";
        public object ConfigurationManager { get; private set; }

        private void chkbtnShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (chkbtnShowPass.Checked)
                txtPass.PasswordChar = (char)0;
            else
                txtPass.PasswordChar = '*';
        }

        private void sbtnLogin_Click(object sender, EventArgs e)
        {
            /*
             * 
            Nếu tài khoản đăng nhập là admin thì trả về 1
            ngược lại nếu là user thì trả về 0. 
            
            Trường hợp tài khoản đăng nhập sai hoặc không tồn tại thì trả về 2 và 3
            */

            // Tạo Stored Procedure trong csdl

            /*
            Mình sẽ sử dụng phương thức ExecuteScalar trong 
                class SqlCommand để lấy kết quả trả về từ SQL Server.
            */

            SqlConnection conn = new SqlConnection();
            try
            {
                conn.ConnectionString = ConfigurationManager.ConnectionStrings["connStr"].ConnectionString;
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_AuthoLogin";
                cmd.Parameters.AddWithValue("@UserName", txtEUser.Text);
                cmd.Parameters.AddWithValue("@Password", txtPass.Text);
                cmd.Connection = conn;
                UserName = txtEUser.Text;
                object kq = cmd.ExecuteScalar();
                int code = Convert.ToInt32(kq);
                if (code == 0)
                {
                    MessageBox.Show("Chào mừng User đăng nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else if (code == 1)
                {
                    MessageBox.Show("Chào mừng Admin đăng nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else if (code == 2)
                {
                    MessageBox.Show("Tài khoản hoặc mật khẩu không đúng !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtPass.Text = "";
                    txtEUser.Text = "";
                    txtEUser.Focus();
                }
                else
                {
                    MessageBox.Show("Tài khoản không tồn tại !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtPass.Text = "";
                    txtEUser.Text = "";
                    txtEUser.Focus();
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
