using MySql.Data.MySqlClient;
using System.Data.Common;

namespace g
{
    public partial class Form1 : Form
    { 
        Podcl podcl = new Podcl();
        public Form1()
        {
            InitializeComponent();

        }
        //1 �������� ����� 13

        //2 ������� �����
        //3 ������� ����� ��� �������� �� � �������������.
        //4 ������� ������ �� �������� ������������� � ����.

        //5 ������� ������ ��� �������
        //8 ����� ������������� 
        //9 �������������� � ���������� �������������

        //10 �������� ��������� �����������.
        //11 ������� ����� ������.
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            Hide();
            form2.ShowDialog();
        }

        //private bool User(string username, string password)
        //{
        //    string checkLockQuery = @"SELECT LockoutEnd FROM Users 
        //                            WHERE Username=@Username AND IsActive=1";
        //    SqlCommand checkLockCmd = new SqlCommand(checkLockQuery, connection);
        //    checkLockCmd.Parameters.AddWithValue("@Username", username);

        //    object lockoutEnd = checkLockCmd.ExecuteScalar();
        //    if (lockoutEnd != null && lockoutEnd != DBNull.Value)
        //    {
        //        DateTime lockTime = (DateTime)lockoutEnd;
        //        if (lockTime > DateTime.Now)
        //        {
        //            MessageBox.Show($"������� ������������ �� {lockTime:HH:mm:ss}");
        //            return false;
        //        }
        //        podcl.DatabaseConnection();
        //            string query = "SELECT COUNT(1) ��� COUNT(*) FROM Users WHERE Username=@Username AND Password=@Password AND IsActive=1";

        //            using (MySqlCommand command = new MySqlCommand(query, new MySqlConnection(podcl.pod())))
        //            {
        //                command.Parameters.AddWithValue("@Username", username);
        //                command.Parameters.AddWithValue("@Password", password);

        //                int count = Convert.ToInt32(command.ExecuteScalar());
        //                return count == 1;
        //            }
        //        string getHashQuery = @"SELECT PasswordHash FROM Users 
        //                          WHERE Username=@Username AND IsActive=1";
        //        SqlCommand getHashCmd = new SqlCommand(getHashQuery, connection);
        //        getHashCmd.Parameters.AddWithValue("@Username", username);

        //        object result = getHashCmd.ExecuteScalar();
        //        if (result == null) return false;

        //        string storedHash = result.ToString();
        //        bool isValid = PasswordHasher.VerifyPassword(password, storedHash);

        //        // ��������� ������� �������
        //        string updateAttemptsQuery = @"UPDATE Users SET 
        //                                FailedLoginAttempts = CASE 
        //                                    WHEN @IsValid = 1 THEN 0
        //                                    ELSE FailedLoginAttempts + 1
        //                                END,
        //                                LockoutEnd = CASE
        //                                    WHEN FailedLoginAttempts >= 4 THEN DATEADD(MINUTE, 30, GETDATE())
        //                                    ELSE NULL
        //                                END
        //                                WHERE Username=@Username";

        //        SqlCommand updateCmd = new SqlCommand(updateAttemptsQuery, connection);
        //        updateCmd.Parameters.AddWithValue("@IsValid", isValid);
        //        updateCmd.Parameters.AddWithValue("@Username", username);
        //        updateCmd.ExecuteNonQuery();

        //        return isValid;
        //    }
        //catch (Exception ex)
        //{
        //        // ����������� ������
        //        return false;
        //    }

        //}
    }
}
