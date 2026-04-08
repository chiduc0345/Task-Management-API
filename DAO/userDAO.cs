using Microsoft.Data.SqlClient;
using TaskManager.DTO;
using TaskManager.Model;

namespace TaskManager.DAO
{
    public class userDAO
    {
        string strconnect = "Data Source=.\\SQLEXPRESS;Initial Catalog=quanlycongviec;Integrated Security=True;Trust Server Certificate=True";
        public user GetUserByNameUser(string username)
        {
            using (SqlConnection conn = new SqlConnection(strconnect))
            {
                conn.Open();
                string query = "SELECT * FROM Users WHERE Username = @username";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@username", username);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    return new user
                    {
                        Id = (int)reader["Id"],
                        UserName = reader["Username"].ToString(),
                        PasswordHash = reader["PasswordHash"].ToString(),
                        Role = reader["Role"].ToString()
                    };
                }
                return null;
            }
        }
    }
}
