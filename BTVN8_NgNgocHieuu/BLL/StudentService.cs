using System;
using System.Data;
using DAL;

namespace BLL
{
    public class StudentService
    {
        private StudentRepository repository = new StudentRepository();

        public DataTable GetAllStudents()
        {
            return repository.GetAllStudents();
        }

        public bool AddStudent(Student student, out string error)
        {
            error = "";
            
            if (string.IsNullOrWhiteSpace(student.StudentID))
            {
                error = "Student ID cannot be empty!";
                return false;
            }
            
            if (string.IsNullOrWhiteSpace(student.FullName))
            {
                error = "Full name cannot be empty!";
                return false;
            }
            
            if (student.DateOfBirth > DateTime.Now)
            {
                error = "Date of birth is invalid!";
                return false;
            }
            
            if (repository.GetStudentById(student.StudentID) != null)
            {
                error = "Student ID already exists!";
                return false;
            }
            
            try
            {
                return repository.AddStudent(student);
            }
            catch (Exception ex)
            {
                error = ex.Message;
                return false;
            }
        }

        public bool UpdateStudent(Student student, out string error)
        {
            error = "";
            
            if (string.IsNullOrWhiteSpace(student.StudentID))
            {
                error = "Student ID cannot be empty!";
                return false;
            }
            
            if (string.IsNullOrWhiteSpace(student.FullName))
            {
                error = "Full name cannot be empty!";
                return false;
            }
            
            if (student.DateOfBirth > DateTime.Now)
            {
                error = "Date of birth is invalid!";
                return false;
            }
            
            try
            {
                return repository.UpdateStudent(student);
            }
            catch (Exception ex)
            {
                error = ex.Message;
                return false;
            }
        }

        public bool DeleteStudent(string studentId, out string error)
        {
            error = "";
            
            if (string.IsNullOrWhiteSpace(studentId))
            {
                error = "Student ID is invalid!";
                return false;
            }
            
            try
            {
                return repository.DeleteStudent(studentId);
            }
            catch (Exception ex)
            {
                error = ex.Message;
                return false;
            }
        }

        public DataTable SearchStudents(string keyword)
        {
            if (string.IsNullOrWhiteSpace(keyword))
            {
                return GetAllStudents();
            }
            return repository.SearchStudents(keyword);
        }

        public Student GetStudentById(string studentId)
        {
            return repository.GetStudentById(studentId);
        }
    }
}
