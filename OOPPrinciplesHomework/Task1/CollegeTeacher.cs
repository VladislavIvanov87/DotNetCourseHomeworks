namespace Task1
{
    using System;

    public class CollegeTeacher : Teacher, ITeacher
    {
        public string College { get; protected set; }

        public CollegeTeacher(string name, string family, int yearsExperience,
          string subject, string college)
            : base(name, family, yearsExperience, subject)
        {
            this.College = college;
        }

        public CollegeTeacher()
        {
        }
    }
}