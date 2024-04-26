using System;
class Student
{
    public string LastName {get; set;}
    public DateTime DateOfBirth {get; set;}
    public string GroupNumber {get; set;}
    public int[] Grades {get; set;}
    public Student(string lastName, DateTime dateOfBirth, string groupNumber, int[] grades)
    {
        LastName = lastName;
        DateOfBirth = dateOfBirth;
        GroupNumber = groupNumber;
        Grades = grades; 
    }
    public void ChangeStudentInfo(string newLastName, DateTime newDateOfBirth, string newGroupNumber)
    {
        LastName = newLastName;
        DateOfBirth = newDateOfBirth;
        GroupNumber = newGroupNumber; 
    }
    public void DisplayStudentInfo()
    {
        Console.WriteLine($"Фамилия: {LastName}");
        Console.WriteLine($"День рождения: {DateOfBirth:dd/MM/yyyy}");
        Console.WriteLine($"Номер группы: {GroupNumber}");
        Console.WriteLine("Успеваемость:");
        foreach (var grade in Grades)
        {
            Console.Write($"{grade} ");
        }
        Console.WriteLine();
        
    } 
}
class Program
{
    static void Main()
    {
        int[] studentGrades = { 5, 4, 5, 3, 5 };
        Student student1 = new Student("Иванов", new DateTime(2000, 5, 15), "345", studentGrades);
        student1.DisplayStudentInfo();
        Console.WriteLine("Введите фамилию:");
        string newLastName = Console.ReadLine();
        Console.WriteLine("Введите дату рождения (dd/MM/yyyy):");
        DateTime newDateOfBirth = DateTime.Parse(Console.ReadLine());
        Console.WriteLine("Введите номер группы:");
        string newGroupNumber = Console.ReadLine();
        student1.ChangeStudentInfo(newLastName, newDateOfBirth, newGroupNumber);
        Console.WriteLine("Измененная информация:");
        student1.DisplayStudentInfo(); 
    } 
}