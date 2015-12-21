namespace Task1
{
    using System;

    public class Lecturer : Person, ITeacher
    {
        public const int MaximumLecturesOfWeek = 8;

        public string University { get; protected set; }

        public Lecturer()
        {
        }

        public Lecturer(string name, string family, int yearsExperience, string university)
            : base(name, family, yearsExperience)
        {
            this.University = university; 
        }

        public void DoSomeExercise()
        {
            Console.WriteLine("Practise your grammar!");
        }

        public void DoSomeExercise(string wordInSpanish)
        {
            Console.WriteLine("Practise your spanish!");
        }

        public void DoSomeExercise(string someString, string someOtherString)
        {
            Console.WriteLine("One more exercise!");
        }

        public virtual void CheckHomework()
        {
            Console.WriteLine("Checking the homework!");
        }

       public string Greeting()
        {
            return "Good afternoon, students!";
        }
    }
}
