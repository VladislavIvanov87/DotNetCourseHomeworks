namespace Task1
{
    using System;

    public class SchoolTeacher : Teacher, ITeacher
    {
        public static string[] Classes = new string[5]
        {
            "2A", "3B", "4C", "5D", "6A"
        };

        public SchoolTeacher(string name, string family, int yearsExperience, string subject)
            : base(name, family, yearsExperience, subject)
        {
        }

        public void PrintClasses()
        {
            foreach (var item in Classes)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

        public void Entertain()
        {
            Console.WriteLine("Entertain the pupils!");
        }
    }
}
