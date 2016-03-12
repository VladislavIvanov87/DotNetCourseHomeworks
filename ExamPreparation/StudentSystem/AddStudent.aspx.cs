namespace StudentSystem
{
    using System;
    using System.Web.UI;

    public partial class AddStudent : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
        }

        protected void AddButton_Click(object sender, EventArgs e)
        {
            var studentToAdd = new Student(
                this.nameTextBox.Text,
                this.facultyTextBox.Text,
                int.Parse(this.facultyNumberTextBox.Text),
                double.Parse(this.gradeAverageTextBox.Text));

            if (Opeations.AddStudent(studentToAdd))
            {
                this.messageLabel.Text = "Successfully added";
                this.nameTextBox.Text = string.Empty;
                this.facultyTextBox.Text = string.Empty;
                this.facultyNumberTextBox.Text = string.Empty;
                this.gradeAverageTextBox.Text = string.Empty;
            }
            else
            {
                this.messageLabel.Text = "An error occured while adding the student";
            }
        }
    }
}