<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddBook.aspx.cs" Inherits="LibrarySystem.AddBook" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Add new book</title>
    <link href="StyleSheet1.css" rel="stylesheet" />
</head>
<body>
    <div class ="navigation">
        <asp:HyperLink NavigateUrl="~/AddBook.aspx" runat="server" Text="Add new book" ToolTip="Adds new book to the collection of books" />
        <asp:HyperLink NavigateUrl="~/SearchBook.aspx" runat="server" Text="Search for a book" ToolTip="Search for a book in the collection of books" />
        <asp:HyperLink NavigateUrl="~/ListAllBooks.aspx" runat="server" Text="View all books" ToolTip="Displays all the books in the collection of books" />   
    </div>
    <form id="form1" runat="server">
    <div>
    <h3>Enter the info for the book</h3>
        <asp:Label runat="server" Text="Title:"></asp:Label>
        <asp:TextBox ID="titleTextBox" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label runat="server" Text="Author:"></asp:Label>
        <asp:TextBox ID="authorTextBox" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label runat="server" Text="Price:"></asp:Label>
        <asp:TextBox ID="priceTextBox" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="messageLable" runat="server" Text=""></asp:Label>
        <br />
        <asp:Button ID="addButton" runat="server" Text="Add" OnClick="addButton_Click" />

    </div>
    </form>
</body>
</html>
