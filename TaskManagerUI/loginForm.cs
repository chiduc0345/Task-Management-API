using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
namespace TaskManagerUI
{
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
        }

        private void txtTenDangNhap_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void loginForm_Load(object sender, EventArgs e)
        {

        }
        private void OpenMainForm()
        {
            this.Hide();
            Form1 main = new Form1();
            main.Show();
        }

        private async void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtTenDangNhap.Text) && !string.IsNullOrWhiteSpace(txtMatKhau.Text))
            {
                var client = new HttpClient();
                var claim = new
                {
                    username = txtTenDangNhap.Text,
                    password = txtMatKhau.Text,
                };
                var json = JsonConvert.SerializeObject(claim);
                var content = new StringContent(json, Encoding.UTF8, "application/json");
                var response = await client.PostAsync("https://localhost:7128/api/auth/login", content);
                if (response.IsSuccessStatusCode)
                {
                    var result = await response.Content.ReadAsStringAsync();
                    var obj = JsonConvert.DeserializeObject<TokenGet>(result);
                    TokenStorage.tokensever = obj.chuoitoken;   
                    MessageBox.Show("Đăng nhập thành công");
                    this.Hide();
                    Form1 f = new Form1();
                    f.Show();
                }
                else
                    MessageBox.Show("Lỗi - " + await response.Content.ReadAsStringAsync());
            }
            else MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
        } 
    }
}
