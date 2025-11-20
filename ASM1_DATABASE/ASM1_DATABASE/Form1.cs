using System;
using System.Data;
using System.Data.SqlClient;
//thư  viện mã hóa 
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;


namespace ASM1_DATABASE
{
    // Lớp này giúp truyền thông tin user sang MainForm (và các form con nếu cần)
    public partial class Form1 : Form
    {
        private const string connectionString = "server = LAPTOP-5BLS6617\\SQLEXPRESS; database = StoreX_SalesDB; Integrated Security=True";


        SqlConnection conn;
        public Form1()
        {
            InitializeComponent();
            conn = new SqlConnection(connectionString);

        }

        //hàm mã hóa SHA-256
        private string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = Encoding.UTF8.GetBytes(password);
                byte[] hash = sha256.ComputeHash(bytes);
                return BitConverter.ToString(hash).Replace("-", "");

            }
        }
        // Hàm băm mật khẩu -> trả về byte[] (tương ứng với HASHBYTES('SHA2_256', ...) trong SQL)

        private byte[] HashPasswordToBytes(string password)
        {
            if (password == null) return null;

            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] inputBytes = Encoding.UTF8.GetBytes(password);
                byte[] hashBytes = sha256.ComputeHash(inputBytes);
                return hashBytes;
            }
        }


        private void Login_Load(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                MessageBox.Show("✅ Kết nối SQL thành công!", "Thông báo");
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Kết nối SQL thất bại!\nLỗi: " + ex.Message, "Lỗi");
            }

        }

        private void label_Login_Click(object sender, EventArgs e)
        {

        }

        private void Password_Click(object sender, EventArgs e)
        {

        }

        private void Username_Click(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }



        private void btn_Exit_Click(object sender, EventArgs e)
        {


            if (MessageBox.Show("Bạn có chắc muốn thoát ứng dụng?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }


        private void btn_Login_Click(object sender, EventArgs e)
        {

            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text; // không Trim() mật khẩu để tránh thay đổi ký tự người dùng nhập (tùy yêu cầu)

            // 1) Kiểm tra hợp lệ input
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Username và Password.", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // 2) Băm mật khẩu thành byte[] để so sánh với cột Password (đã lưu bằng HASHBYTES ở SQL)
            byte[] hashedPassword = HashPasswordToBytes(password);

            // 3) Truy vấn database với parameterized query (ngăn SQL Injection)
            string sql = @"
                SELECT EmployeeID, EmployeeName, Position, AuthorityLevel
                FROM Employee
                WHERE Username = @username AND Password = @password;";

            // Dùng chuỗi kết nối đã khai báo ở trên để tạo kết nối mới
            using (SqlConnection loginConn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(sql, loginConn))


                try
                {

                    {
                        // Thêm tham số: username dạng string; password dạng varbinary
                        cmd.Parameters.Add("@username", SqlDbType.VarChar, 50).Value = username;

                        //  Dùng SqlDbType.VarBinary và kích thước 32 (cho SHA-256)
                        cmd.Parameters.Add("@password", SqlDbType.VarBinary, 32).Value = hashedPassword;
                        loginConn.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                //Đăng nhập thành công: Lưu dữ liệu user vào UserSession
                                UserSession.EmployeeID = Convert.ToInt32(reader["EmployeeID"]);
                                UserSession.EmployeeName = reader["EmployeeName"].ToString();
                                UserSession.Position = reader["Position"].ToString();
                                UserSession.AuthorityLevel = Convert.ToInt32(reader["AuthorityLevel"]);
                                MessageBox.Show(
                                $"Đăng nhập thành công. Chào {UserSession.EmployeeName} ({UserSession.Position})",
                                "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                //  Mở MainForm và truyền quyền cho nó
                                MainForm main = new MainForm();
                                main.Show();

                                //  Ẩn form Login sau khi mở MainForm
                                this.Hide();
                            }
                            else
                            {
                                // Đăng nhập thất bại
                                MessageBox.Show("Sai Username hoặc Password.", "Đăng nhập thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Xử lý lỗi kết nối/ truy vấn
                    MessageBox.Show("Lỗi khi đăng nhập: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

        }
    }

    public static class UserSession
    {
        public static int EmployeeID { get; set; }
        public static string EmployeeName { get; set; }
        public static string Position { get; set; }
        public static int AuthorityLevel { get; set; }
    }
}
