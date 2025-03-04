﻿using STMS.Persistence.Models;
using static STMS.Persistence.Models.Enums.Enums;

namespace STMS.Service.DTO
{
    //View Student DTO
    internal class ViewStudentDTO
    {
        public string FirstName { get; set; }
        public string? MiddleName { get; set; }
        public string LastName { get; set; } = string.Empty;
        public string StudentId { get; set; } = string.Empty;
        public Semester? JoiningBatch { get; set; }
        public Department Department { get; set; } = Department.None;
        public Degree Degree { get; set; } = Degree.None;
        public List<Course> AttendedCourse { get; set; }
        public List<Semester> SemestersAttended { get; set; }

        public ViewStudentDTO()
        {
            JoiningBatch = new Semester();
        }
    }
}
