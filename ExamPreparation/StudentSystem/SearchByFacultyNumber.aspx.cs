namespace StudentSystem
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public partial class SearchByFacultyNumber : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void searchButton_Click(object sender, EventArgs e)
        {
            var students = Opeations.ReadFromDataBase();
            var foundStudents = new List<Student>();

            foreach (var s in students.Where(p =>
            p.FacultyNumber.ToString().Contains(this.searchTextBox.Text)))
            {
                foundStudents.Add(s);
            }

            if (foundStudents.Count == 0)
            {
                this.messageLabel.Text = "No results found!";
            }

            this.repeater.DataSource = foundStudents;
            this.repeater.DataBind();
        }
    }
}