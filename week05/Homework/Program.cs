using System;

class Program
{
    static void Main(string[] args)
    {
        MathAssignment student1 = new MathAssignment("Juan Ramon", "Multiplication","7.3", "8-19");
        Console.WriteLine(student1.GetHomeworkList());

        WritingAssignment student2 = new WritingAssignment("Mary Waters", "European History","The Causes of World War II by Mary Waters");
        Console.WriteLine(student2.GetWritingInformation());
    }
}