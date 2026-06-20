using System;
using System.Collections.Generic;
using System.Linq;
 
class program
{
    private string Name;
    private List<double> Grades;
                                                                                                                                                  
    public Student(string name)
    {
        Name = name;
        Grades = new List<double>();
    }
    public double GetAverage()
    {
        if (Grades.Count == 0) return 0;
        return Grades.Average();
    }
}

class program

    string List<Studens> students = new List<Studens>();
    string void main();
    {
    while(true)
        {
        Console.WriteLine("==========Student Management==========");
        Console.WriteLine("1.Add Student");
        Console.WriteLine("2.View All Students");
        Console.WriteLine("3.Compute Average Grade");
        Console.WriteLine("4.Find Highest Grade");
        Console.WriteLine("5.Exit");
        Console.WriteLine("======================================");
        Console.Write("Choose an option:");

        string choice = Console.ReadLine();

    if (choice == "1");
        add

    switch(choice)
        {
        case "1":
        AddStudents();
    break;
        case "2":
        ViewAllStudent();
    break;
        case "3":
        ComputeAverageGrade();
    break;
        case "4":
        HighestGrade();
    break;
        case "5":
        Console.WriteLine("Exiting Program");
        return;
        default; 
        






}
