namespace Task1
{
    using System;

    public class Professor : Lecturer, ITeacher
    {
        public string JobTitle { get; protected set; }

        public Professor(string name, string family, int yearsExperience, 
            string university, string jobTitle)
            : base(name, family, yearsExperience, university)
        {
            this.JobTitle = jobTitle;
        }

        public override void CheckHomework()
        {
            Console.WriteLine("{0} {1} is checking the homework!", this.JobTitle, this.Family);
        }

        public void JobInfo()
        {
            Console.WriteLine("I am {0} and I have {1} years'experience.", this.JobTitle, this.YearsExperience);
        }

        public void ConductAnExam()
        {
            Console.WriteLine("Conducting an exam!");
        }
    }
}
