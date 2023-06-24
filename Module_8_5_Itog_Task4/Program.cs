using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
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
            int i = 1;
            while (br.PeekChar() != -1 && br.ReadString() == "")
            {
                Name = br.ReadString(); 
                Group = br.ReadString();
                Name = Name + "Имя " + Convert.ToString(i) + "-го студента"; 
                Group = Group + "Группа" + Convert.ToString(i);
                i += 1;
                dbl = br.ReadDouble();
                try
                {
                    DateOfBirth = DateTime.FromOADate(dbl);
                }
                catch
                {
                    DateOfBirth = DateTime.Now;
                }
                
                Student st = new(Name, Group, DateOfBirth);
                Students = Students.Append(st).ToArray();
            }
        }
        else
        {
            WriteLine("Нет такой файла, проверьте путь к файлу");
        }

    }
    public static void WriteStudents(string urlPath, Student[] students)
    {
        string name;
        string subPath;
        for (int i = 0; i < students.Length; i++)
        {
            name = students[i].NameS;
            subPath = urlPath + students[i].GroupS + ".dat";
            if (!Directory.Exists(urlPath))
            {
                Directory.CreateDirectory(urlPath);
            }

            WriteLine($"Создана группа студентов {subPath}");
            SaveBin(subPath, name);
        }
    }
    public static void SaveBin(string subPath, string nameStudent) 
    {
        if (!File.Exists(subPath))
        {
            using (BinaryWriter wr = new BinaryWriter(File.Open(subPath, FileMode.OpenOrCreate)))
            {
                wr.Write(nameStudent + "\n");
            }
        }
        else
        {
            using (BinaryWriter wr = new BinaryWriter(File.Open(subPath, FileMode.Append)))
            {
                WriteLine("Файл уже существует! Произойдет добавление в файл");
                wr.Write(nameStudent + "\n");
            }
        }
    }
    public static void WriteDisplayArrayStudent()
    {
        for (int i = 0; i < Students.Length; i++)
        {
            WriteLine(Students[i].NameS+ " " + Students[i].GroupS + " " + Students[i].DateS.ToShortDateString());
        }
    }
    static void Main(string[] args)
    {
        ReadStudents(@"Students.dat");
        WriteDisplayArrayStudent();
        WriteStudents("C://SFM4/", Students);
    }
}


