using System;
using static System.Console;

namespace Module_8_5_Itog_Task4;
public class Student
{
    public string NameS;
    public string GroupS;
    public DateTime DateS;
    public Student(string name, string group, DateTime date)
    {
        NameS = name;
        GroupS = group;
        DateS = date;
    }
}
internal class Program
{
    public static Student[] Students = Array.Empty<Student>();
    public static void ReadStudents(string urlPath)
    {
        Double dbl;
        string Name;
        string Group;
        DateTime DateOfBirth;
        FileInfo file = new(urlPath);
        WriteLine(file.FullName);
        if (File.Exists(file.FullName))
        {
            WriteLine("Есть такой файл");
            using var rd = File.Open(file.FullName, FileMode.Open);
            using BinaryReader br = new BinaryReader(rd);
            while (br.PeekChar() != -1 && br.ReadString() == "")
            {
                Name = br.ReadString(); 
                Group = br.ReadString();
                dbl = br.ReadDouble();
                try
                {
                    DateOfBirth = DateTime.FromOADate(dbl);
                }
                catch
                {
                    DateOfBirth = DateTime.Now;
                }
                    WriteLine(Name + " " + Group + " " + DateOfBirth.ToShortDateString());
                Student st = new(Name, Group, DateOfBirth);
                Students = Students.Append(st).ToArray();
            }
        }
        else
        {
            WriteLine("Нет такой файла, проверьте путь к файлу");
        }

    }
    public static void WriteArrayStudent()
    {
        for (int i = 0; i < Students.Length; i++)
        {
            WriteLine(Students[i].NameS + Students[i].GroupS + Students[i].DateS.ToShortDateString());
        }
    }
    static void Main(string[] args)
    {
        ReadStudents(@"Students.dat");
        WriteArrayStudent();
    }
}


