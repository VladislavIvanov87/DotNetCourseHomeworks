namespace StudentSystem
{
    public class Student
    {
        public Student(string name, string faculty, int facultyNumber, double gradeAverage)
        {
            this.Name = name;
            this.Faculty = faculty;
            this.FacultyNumber = facultyNumber;
            this.GradeAverage = gradeAverage;
        }

        public string Name { get; set; }

        public string Faculty { get; set; }

        public int FacultyNumber { get; set; }

        public double GradeAverage { get; set; }

        public override string ToString()
        {
            return string.Format("{0} | {1} | {2} | {3}", this.Name, this.Faculty, this.FacultyNumber, this.GradeAverage);
        }
    }
}