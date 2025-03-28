namespace ConsoleApp6.Models;

public class Student
{
    public int Id { get; set; }
    public string Fullname { get; set; }
    public int Point { get; set; }

    public void StudentInfo()
    {
        Console.WriteLine($"ID: {Id}, Name: {Fullname}, Point: {Point}");
    }
}
