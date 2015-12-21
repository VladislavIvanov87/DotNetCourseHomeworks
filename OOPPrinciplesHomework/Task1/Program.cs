namespace Task1
{
    using System;
    
    class Program
    {
        static void Main()
        {

            Teacher teacher = new Teacher("Georgi", "Georgiev", 10, "Mathematics");
            teacher.CheckHomework();
            Console.WriteLine(teacher.Greeting());
            teacher.Goodbay();

            Lecturer lecturer = new Lecturer("Atanas", "Atanasov", 12, "Sofia University");
            lecturer.CheckHomework();
            string str = "wordInSpanish";
            string someString = "";
            string someOtherString = "";
            lecturer.DoSomeExercise();
            lecturer.DoSomeExercise(str);
            lecturer.DoSomeExercise(someString, someOtherString);
            lecturer.Greeting();
            Console.WriteLine(Lecturer.MaximumLecturesOfWeek);

            Professor professor = new Professor("Erik", "Svenson", 15, "Stockholm University", "Associate professor");
            professor.JobInfo();
            professor.CheckHomework();
            professor.ConductAnExam();

            Assistant assistant = new Assistant("Paolo", "Contrera", 7, "University of Lisbon", true);
            assistant.Info();
            assistant.CheckHomework();
            assistant.CheckExams();
            assistant.CreateArticles();

            SchoolTeacher schoolTeacher = new SchoolTeacher("Vasil", "Vasilev", 14, "Biology");
            schoolTeacher.PrintClasses();
            schoolTeacher.CheckHomework();
            schoolTeacher.Entertain();

            CollegeTeacher collegeTeacher = new CollegeTeacher("Ivan", "Ivanov", 11, "Marketing", "MT&M Sofia");
            collegeTeacher.CheckHomework();

            Console.WriteLine(Person.personCount);
        }
    }
}
