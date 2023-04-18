using System;

public class Class1
{
	public Class1()
	{

        public class Student
    {
        public int StudentID { get; set; }
        public string Name { get; set; }
        public List<Course> Courses { get; set; }
    }

    public class Course
    {
        public int CourseID { get; set; }
        public string CourseName { get; set; }
        public Teacher Teacher { get; set; }
    }

    public class Teacher
    {
        public int TeacherID { get; set; }
        public string Name { get; set; }
    }

}
}
