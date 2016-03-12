namespace StudentSystem
{
    using System;
    using System.Linq;

    public partial class SortByGradePointAverage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void dropDownList_SelectedIndexChanged(object sender, EventArgs e)
        {
            var studentsToShow = Opeations.ReadFromDataBase();
            var sortedStudents = studentsToShow.OrderByDescending(x => x.GradeAverage)
                                               .ThenBy(x => x.Name);

            foreach (var item in sortedStudents)
            {

                if (this.dropDownList.SelectedValue == "Mathematics")
                {
                    this.repeater.DataSource = sortedStudents.Where(x => x.Faculty == "Mathematics");
                    this.repeater.DataBind();
                }
                else if (this.dropDownList.SelectedValue == "Computer Science")
                {
                    this.repeater.DataSource = sortedStudents.Where(x => x.Faculty == "Computer Science");
                    this.repeater.DataBind();
                }
                else
                {
                    this.repeater.DataSource = sortedStudents.Where(x => x.Faculty == "Engineering");
                    this.repeater.DataBind();
                }
            }
        }
    }
}