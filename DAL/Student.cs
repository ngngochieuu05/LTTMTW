using System;

namespace DAL
{
    public class Student
    {
        public string StudentID { get; set; }
        public string FullName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Gender { get; set; }
        public string Faculty { get; set; }
        public decimal AverageScore { get; set; }
        public string ProfilePicture { get; set; }
    }
}
