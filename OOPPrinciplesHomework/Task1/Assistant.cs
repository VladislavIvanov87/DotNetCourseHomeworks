namespace Task1
{
    using System;

    public class Assistant : Lecturer, ITeacher
    {
        public bool IsHeadAssistant { get; protected set; }

        public Assistant(string name, string family, int yearsExperience, 
            string university, bool isHeadAssistant)
            : base(name, family, yearsExperience, university)
        {
            this.IsHeadAssistant = isHeadAssistant;
        }

        public override void CheckHomework()
        {
            Console.WriteLine("{0} is checking the homework!", this.Family);
        }

        public void Info()
        {
            Console.WriteLine("My name is {0} {1}. {2}.", this.Name, this.Family, this.IsHeadAssistant);
        }

        public void CreateArticles()
        {
            Console.WriteLine("Write scientific articles!");
        }

        public void CheckExams()
        {
            Console.WriteLine("Check exams!");
        }
    }
}
