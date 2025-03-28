using System.Text.RegularExpressions;

namespace ConsoleApp6.Models;

public class Group
{

    private string _groupNo;
    public string GroupNo
    {
        get => _groupNo;
        set
        {
            if (Regex.IsMatch(value, "^[A-Z]{2}\\d{3}$"))
                _groupNo = value;
            else
                Console.WriteLine("group adi sehvdi");
        }
    }


    private int _studentLimit;
    public int StudentLimit
    {
        get => _studentLimit;
        set
        {
            if (value >= 5 && value <= 18)
                _studentLimit = value;
            else
                Console.WriteLine("min 5 max 18 olmalidi");
        }
    }


    private Student[] Students = new Student[] { };

    public Group(string groupNo, int studentLimit)
    {
        GroupNo = groupNo;
        StudentLimit = studentLimit;
    }

    public void AddStudent(Student student)
    {
        if (Students.Length == StudentLimit)
        {
            Console.WriteLine("Limit dolub");
            return;
        }
        Array.Resize(ref Students, Students.Length + 1);
        Students[Students.Length - 1] = student;
        return;
    }


    public Student GetStudent(int id)
    {
        foreach (var item in Students)
        {
            if (item.Id == id) return item;


        }
        return null;
    }

    public Student[] GetAllStudents()
    {
        return Students;
    }
}
