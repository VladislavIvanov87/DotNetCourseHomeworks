namespace StudentSystem
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    public class Opeations
    {
        public const string FilePath = @"C:\Users\Vlado\Desktop\SIPartTwo\Students.txt";

        public static List<Student> ReadFromDataBase()
        {
            var listOfStudents = new List<Student>();
            using (var reader = new StreamReader(Opeations.FilePath))
            {
                var line = reader.ReadLine();
                while (line != null)
                {
                    var currentStudent = line.Split('|');
                    var student = new Student(
                        currentStudent[0].Trim(),
                        currentStudent[1].Trim(),
                        int.Parse(currentStudent[2].Trim()),
                        double.Parse(currentStudent[3].Trim()));
                    listOfStudents.Add(student);
                    line = reader.ReadLine();
                }
            }
            return listOfStudents;
        }

        public static bool AddStudent(Student studentToAdd)
        {
            try
            {
                using (var writer = new StreamWriter(Opeations.FilePath, true))
                {
                    writer.WriteLine(studentToAdd);
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}