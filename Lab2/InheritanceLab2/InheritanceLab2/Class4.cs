using System;

public class Class1
{
	public Class1()
	{

        class Student
    {
        public int StudentID { get; set; }
        public string Name { get; set; }
        public List<Course> Courses { get; set; }
    }

    class Course
    {
        public int CourseID { get; set; }
        public string Name { get; set; }
        public Teacher Instructor { get; set; }
    }

    class Teacher
    {
        public int TeacherID { get; set; }
        public string Name { get; set; }
        public List<Course> Courses { get; set; }
    }


    Student student1 = new Student { StudentID = 1, Name = "Hehe" };
    Course course1 = new Course { CourseID = 1, Name = "Wow", Instructor = new Teacher { TeacherID = 1, Name = "Wat" } };

 
    student1.Courses.Add(course1);

    Teacher instructor = course1.Instructor;

}
}
