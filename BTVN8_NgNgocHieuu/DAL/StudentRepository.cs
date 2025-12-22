using System;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class StudentRepository
    {
        private string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=StudentManagementDB;Integrated Security=True;TrustServerCertificate=True";

        public StudentRepository()
        {
        }

        public DataTable GetAllStudents()
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = @"SELECT 
                        StudentID as MaSV, 
                        FullName as HoTen, 
                        Gender as GioiTinh, 
                        Faculty as Khoa, 
                        AverageScore as DiemTB 
                        FROM Students";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    conn.Open();
                    adapter.Fill(dt);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error retrieving students list: " + ex.Message);
            }
            return dt;
        }

        public Student GetStudentById(string studentId)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "SELECT StudentID, FullName, Gender, Faculty, AverageScore FROM Students WHERE StudentID = @StudentID";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@StudentID", studentId);
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        return new Student
                        {
                            StudentID = reader["StudentID"].ToString(),
                            FullName = reader["FullName"].ToString(),
                            DateOfBirth = DateTime.Now.AddYears(-20),
                            Gender = reader["Gender"].ToString(),
                            Faculty = reader["Faculty"].ToString(),
                            AverageScore = Convert.ToDecimal(reader["AverageScore"]),
                            ProfilePicture = null
                        };
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error finding student: " + ex.Message);
            }
            return null;
        }

        public bool AddStudent(Student student)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "INSERT INTO Students (StudentID, FullName, Gender, Faculty, AverageScore) VALUES (@StudentID, @FullName, @Gender, @Faculty, @AverageScore)";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@StudentID", student.StudentID);
                    cmd.Parameters.AddWithValue("@FullName", student.FullName);
                    cmd.Parameters.AddWithValue("@Gender", student.Gender);
                    cmd.Parameters.AddWithValue("@Faculty", student.Faculty);
                    cmd.Parameters.AddWithValue("@AverageScore", student.AverageScore);
                    conn.Open();
                    int result = cmd.ExecuteNonQuery();
                    return result > 0;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error adding student: " + ex.Message);
            }
        }

        public bool UpdateStudent(Student student)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "UPDATE Students SET FullName = @FullName, Gender = @Gender, Faculty = @Faculty, AverageScore = @AverageScore WHERE StudentID = @StudentID";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@StudentID", student.StudentID);
                    cmd.Parameters.AddWithValue("@FullName", student.FullName);
                    cmd.Parameters.AddWithValue("@Gender", student.Gender);
                    cmd.Parameters.AddWithValue("@Faculty", student.Faculty);
                    cmd.Parameters.AddWithValue("@AverageScore", student.AverageScore);
                    conn.Open();
                    int result = cmd.ExecuteNonQuery();
                    return result > 0;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error updating student: " + ex.Message);
            }
        }

        public bool DeleteStudent(string studentId)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "DELETE FROM Students WHERE StudentID = @StudentID";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@StudentID", studentId);
                    conn.Open();
                    int result = cmd.ExecuteNonQuery();
                    return result > 0;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error deleting student: " + ex.Message);
            }
        }

        public DataTable SearchStudents(string keyword)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = @"SELECT 
                        StudentID as MaSV, 
                        FullName as HoTen, 
                        Gender as GioiTinh, 
                        Faculty as Khoa, 
                        AverageScore as DiemTB 
                        FROM Students 
                        WHERE StudentID LIKE @keyword OR FullName LIKE @keyword OR Faculty LIKE @keyword";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@keyword", "%" + keyword + "%");
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    conn.Open();
                    adapter.Fill(dt);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error searching students: " + ex.Message);
            }
            return dt;
        }
    }
}
