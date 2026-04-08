using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using TaskManager.Model;

namespace TaskManager.DAO
{
    public class taskDAO
    {
        string strconnect = "Data Source=.\\SQLEXPRESS;Initial Catalog=quanlycongviec;Integrated Security=True;Trust Server Certificate=True";


        public List<TaskIterm> GetAll()
        {
            List<TaskIterm> list=new List<TaskIterm>();
            using (SqlConnection conn = new SqlConnection(strconnect)) { 
            conn.Open();
                SqlCommand cmd = new SqlCommand("Select * From Congviec order by hanchot asc", conn);
                SqlDataReader read= cmd.ExecuteReader();
                while(read.Read())
                {
                    TaskIterm task = new TaskIterm();
                    task.MaCV = Convert.ToInt32(read["MaCV"]);
                    task.TenCongViec = Convert.ToString(read["TenCongViec"]);
                    task.LoaiCongViec = Convert.ToString(read["LoaiCongViec"]);
                    task.HanChot = Convert.ToDateTime(read["HanChot"]);
                    task.TrangThai = Convert.ToBoolean(read["TrangThai"]);
                    list.Add(task);
                }
                return list;
            }

        }
        public bool Insert(TaskIterm taskIterms)
        {
            
            using (SqlConnection conn = new SqlConnection(strconnect))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("Insert into Congviec Values(@tencv,@loaicv,@hanchot,@trangthai)", conn);
            
                cmd.Parameters.AddWithValue("@loaicv", taskIterms.LoaiCongViec);
                cmd.Parameters.AddWithValue("@tencv", taskIterms.TenCongViec);
                cmd.Parameters.AddWithValue("@hanchot",taskIterms.HanChot);
                cmd.Parameters.AddWithValue("@trangthai", taskIterms.TrangThai);
                return cmd.ExecuteNonQuery()>0;    
            }

        }
        public bool Delete(int macv)
        {
            
            using (SqlConnection conn = new SqlConnection(strconnect))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("Delete from CongViec where MaCV = @macv", conn);

                cmd.Parameters.AddWithValue("@macv", macv);
                
                return cmd.ExecuteNonQuery() > 0;
            }
        }
        public bool Update(TaskIterm taskIterms)
        {

            using (SqlConnection conn = new SqlConnection(strconnect))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("Update CongViec set tencongviec=@tencv,loaicongviec=@loaicv,HanChot=@hanchot,TrangThai=@trangthai where macv=@macv", conn);
                cmd.Parameters.AddWithValue("@macv", taskIterms.MaCV);
                cmd.Parameters.AddWithValue("@loaicv", taskIterms.LoaiCongViec);
                cmd.Parameters.AddWithValue("@tencv", taskIterms.TenCongViec);
                cmd.Parameters.AddWithValue("@hanchot", taskIterms.HanChot);
                cmd.Parameters.AddWithValue("@trangthai", taskIterms.TrangThai);
                return cmd.ExecuteNonQuery() > 0;
            }
        }
        public List<TaskIterm> Search (string text)
        {
            using (SqlConnection conn = new SqlConnection(strconnect))
            {
                List<TaskIterm> list = new List<TaskIterm>();
                conn.Open();
                if (string.IsNullOrEmpty(text))
                {
                    SqlCommand cmd = new SqlCommand("Select* from congviec ", conn);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        TaskIterm task = new TaskIterm();
                        task.MaCV = Convert.ToInt32(reader["MaCV"]);
                        task.TenCongViec = Convert.ToString(reader["TenCongViec"]);
                        task.LoaiCongViec = Convert.ToString(reader["LoaiCongViec"]);
                        task.HanChot = Convert.ToDateTime(reader["HanChot"]);
                        task.TrangThai = Convert.ToBoolean(reader["TrangThai"]);
                        list.Add(task);
                    }        
                }
                else
                {
                    SqlCommand cmd = new SqlCommand("Select* from congviec where LOWER(tencongviec) like '%' + LOWER(@text) + '%'", conn);
                    cmd.Parameters.AddWithValue("@text", text);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        TaskIterm task = new TaskIterm();

                        task.MaCV = Convert.ToInt32(reader["MaCV"]);
                        task.TenCongViec = Convert.ToString(reader["TenCongViec"]);
                        task.LoaiCongViec = Convert.ToString(reader["LoaiCongViec"]);
                        task.HanChot = Convert.ToDateTime(reader["HanChot"]);
                        task.TrangThai = Convert.ToBoolean(reader["TrangThai"]);
                        list.Add(task);
                    }
                }
                return list;
            }
        }
        public List<TaskIterm> Loc(string text)
        {
            using (SqlConnection conn = new SqlConnection(strconnect)) { 
            conn.Open();
                List<TaskIterm> list = new List<TaskIterm>();
                SqlCommand cmd = new SqlCommand("Select* from congviec where Lower(loaicongviec) like '%'+Lower(@loaicongviec)+'%'", conn);
                cmd.Parameters.AddWithValue("@loaicongviec", text);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read()) {
                    TaskIterm task = new TaskIterm();
                    task.MaCV = Convert.ToInt32(reader["MaCV"]);
                    task.TenCongViec = Convert.ToString(reader["TenCongViec"]);
                    task.LoaiCongViec = Convert.ToString(reader["LoaiCongViec"]);
                    task.HanChot = Convert.ToDateTime(reader["HanChot"]);
                    task.TrangThai = Convert.ToBoolean(reader["TrangThai"]);
                    list.Add(task);
                }
                return list;
            }
        }
    }

}
