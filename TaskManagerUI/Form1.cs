using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
namespace TaskManagerUI
{
    public partial class Form1 : Form
    {
        HttpClient client = new HttpClient();
        int macv;
        string tencv;
        string loaicv;
        DateTime hanchot;
        bool trangthai;
        public Form1()
        {
            InitializeComponent();
        }

        private  void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
            cboLoaiCongViec.SelectedIndex = 0;
        }

        private  void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtTenCongViec.Clear();
            txtTenCongViec.Focus();
            LoadData();
            chckTrangThai.Checked = false;
        }

        private async void btnThem_Click(object sender, EventArgs e)
        {
            TaskIterm task = new TaskIterm();
            if (string.IsNullOrEmpty(txtTenCongViec.Text)) { MessageBox.Show("Vui long nhap day du thong tin!");
                return; 
            }
            task.TenCongViec= txtTenCongViec.Text;
            task.LoaiCongViec = cboLoaiCongViec.Text;
            task.HanChot = Convert.ToDateTime(dattimeHanChot.Value);
            if (chckTrangThai.Checked) task.TrangThai = true;
            else task.TrangThai= false;
            var json = JsonSerializer.Serialize(task);
            var content = new StringContent(json,Encoding.UTF8,"application/json");
            var reponse = await client.PostAsync("https://localhost:7128/api/task",content);
            if (reponse.IsSuccessStatusCode)
            {
                MessageBox.Show("Them thanh cong");
                LoadData();
            }
            else MessageBox.Show("Them that bai");
        }
        
        
        private async void LoadData()
        {
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", TokenStorage.tokensever);
            var response = await client.GetAsync("https://localhost:7128/api/task");

            if (!response.IsSuccessStatusCode)
            {
                MessageBox.Show("Lỗi API: " + response.StatusCode);
                return;
            }

            var json = await response.Content.ReadAsStringAsync();

            var list = JsonSerializer.Deserialize<List<TaskIterm>>(json,
                new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
            dgvListCongViec.DataSource = list;
        }
        

        private async void btnXoa_Click(object sender, EventArgs e)
        {
            client.DefaultRequestHeaders.Authorization= new AuthenticationHeaderValue("Bearer",TokenStorage.tokensever);
            TaskIterm task = new TaskIterm();
            task.TenCongViec = txtTenCongViec.Text;
            task.MaCV = macv;
            if(string.IsNullOrWhiteSpace(txtTenCongViec.Text))
            {
                MessageBox.Show("Vui long chon cong viec");
                return;
            }
            if(!chckTrangThai.Checked)
            {
                MessageBox.Show("Cong viec chua hoan thanh");
                return;
            }
            var response = await client.DeleteAsync($"https://localhost:7128/api/task?macv={macv}");
            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Xoa thanh cong");
                 LoadData();
            }
            else
            {
                MessageBox.Show("Xoa that bai");
            }
        }
        

        private void dgvListCongViec_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dgvListCongViec_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvListCongViec.Rows[e.RowIndex];
                txtTenCongViec.Text = row.Cells["TenCongViec"].Value.ToString();
                cboLoaiCongViec.Text = row.Cells["LoaiCongViec"].Value.ToString();
                if (Convert.ToBoolean(row.Cells["TrangThai"].Value))
                    chckTrangThai.Checked = true;
                else
                    chckTrangThai.Checked = false;
                dattimeHanChot.Value = Convert.ToDateTime(row.Cells["HanChot"].Value);
                macv = Convert.ToInt32(row.Cells["MaCV"].Value);
                tencv = row.Cells["TenCongViec"].Value.ToString();
                loaicv = row.Cells["LoaiCongViec"].Value.ToString();
                if (Convert.ToBoolean(row.Cells["TrangThai"].Value))
                    trangthai = true;
                else
                    trangthai = false;
                hanchot = Convert.ToDateTime(row.Cells["HanChot"].Value);
            }
        }

        private async void btnSua_Click(object sender, EventArgs e)
        {
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", TokenStorage.tokensever);
            TaskIterm task = new TaskIterm();
            task.MaCV = macv;
            task.TenCongViec = txtTenCongViec.Text;
            task.LoaiCongViec = cboLoaiCongViec.Text;
            task.HanChot = dattimeHanChot.Value;
            if (chckTrangThai.Checked == false) task.TrangThai = false;
            else task.TrangThai = true;
            if (task.TenCongViec == tencv&&task.LoaiCongViec==loaicv&&task.HanChot.Date==hanchot.Date&&task.TrangThai==trangthai)
            {
                MessageBox.Show("Thong tin chua duoc chinh sua");
                return;
            }
            var json =  JsonSerializer.Serialize(task);
            var content = new StringContent(json,Encoding.UTF8,"application/json");
            var reponse = await client.PutAsync("https://localhost:7128/api/task", content);
            if (reponse.IsSuccessStatusCode) 
            { 
                MessageBox.Show("Updated");
                LoadData();
            }
            else 
            { 
                MessageBox.Show("Update fail");
                MessageBox.Show(json);
            }
        }

        private async void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", TokenStorage.tokensever);
            string text = txtTimKiem.Text;
            if (string.IsNullOrWhiteSpace(text))
            {
                LoadData();
                return;
            }
            else
            {
                var response = await client.GetAsync($"https://localhost:7128/api/task/search/{text}");
                if (response.IsSuccessStatusCode)
                {
                    var json = await response.Content.ReadAsStringAsync();
                    var list = JsonSerializer.Deserialize<List<TaskIterm>>(json, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
                    dgvListCongViec.DataSource = list;
                }
            }
        }

        private async void cboloc_SelectedIndexChanged(object sender, EventArgs e)
        {
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", TokenStorage.tokensever);
            string text = cboloc.Text;
            var response = await client.GetAsync($"https://localhost:7128/api/task/filter/{text}");
            if (response.IsSuccessStatusCode && response.Content != null)
            {
                var json = await response.Content.ReadAsStringAsync();
                var list =  JsonSerializer.Deserialize<List<TaskIterm>>(json,new JsonSerializerOptions { PropertyNameCaseInsensitive=true});
                dgvListCongViec.DataSource= list;
            }
        }
    }
}
