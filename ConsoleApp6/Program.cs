using ConsoleApp6.Models;

Group group = new Group("AB123", 111);

Student student1 = new Student { Id = 1, Fullname = "John Doe", Point = 85 };
Student student2 = new Student { Id = 2, Fullname = "Jane Smith", Point = 92 };

group.AddStudent(student1);
group.AddStudent(student2);


foreach (var student in group.GetAllStudents())
{
    student.StudentInfo();
}


Student st = group.GetStudent(1);
st.StudentInfo();