using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestOOP3
{
    class Course
    {
        private string courseName;
        private string instructorName;
        private DateTime startDate;
        private DateTime endDate;
        private int courseSize;

        public Course(string courseName, string instructorName, DateTime startDate, DateTime endDate, int courseSize)
        {
            this.courseName = courseName;
            this.instructorName = instructorName;
            this.startDate = startDate;
            this.endDate = endDate;
            this.courseSize = courseSize;
        }

        public Course()
        {
            courseSize = 10;
        }
        public string CourseName { get => courseName; set => courseName = value; }
        public string InstructorName { get => instructorName; set => instructorName = value; }
        public DateTime StartDate { get => startDate; set => startDate = value; }
        public DateTime EndDate { get => endDate; set => endDate = value; }
        public int CourseSize { get => courseSize; set => courseSize = value; }


        public int GetDurationInDays()
        {
            return (EndDate - StartDate).Days;

        }



    }
}
