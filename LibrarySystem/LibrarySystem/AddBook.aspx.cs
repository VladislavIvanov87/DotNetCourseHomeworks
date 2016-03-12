using System;
namespace LibrarySystem
{
    public partial class AddBook : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void addButton_Click(object sender, EventArgs e)
        {
            var bookToAdd = new Book(
                this.titleTextBox.Text,
                this.authorTextBox.Text,
                double.Parse(this.priceTextBox.Text));

            if (FileOperations.AddBookToDataBase(bookToAdd))
            {
                this.messageLable.Text = "Successfully added the book to the library";
                this.titleTextBox.Text = string.Empty;
                this.authorTextBox.Text = string.Empty;
                this.priceTextBox.Text = string.Empty;
            }
            else
            {
                this.messageLable.ForeColor = System.Drawing.Color.Red;
                this.messageLable.Text = "An error occured while adding the book";
            }
        }
    }
}