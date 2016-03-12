<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SearchByFacultyNumber.aspx.cs" Inherits="StudentSystem.SearchByFacultyNumber" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <div class="navigation" />
    <asp:HyperLink NavigateUrl="~/AddStudent.aspx" runat="server" Text="Add new student" />
    <asp:HyperLink NavigateUrl="~/SearchByFacultyNumber.aspx" runat="server" Text="Search for a student" />
    <asp:HyperLink NavigateUrl="~/SortByGradePointAverage.aspx" runat="server" Text="Sort by grade average" />
    <div />
    <form id="form1" runat="server">
        <div>
            <h3>Enter faculty number</h3>
            <asp:Label runat="server" Text="Search"></asp:Label>
            <asp:TextBox runat="server" ID="searchTextBox"></asp:TextBox>
            <br />
            <br />
            <asp:Button runat="server" Text="Search" ID="searchButton" OnClick="searchButton_Click" />
            <br />
            <br />
            <asp:Label runat="server" ID="messageLabel" Text=""></asp:Label>
            
            <asp:Repeater runat="server" ID="repeater">
                <ItemTemplate>
                    <div class="container">
                        Name:
                        <asp:Label Text='<%# Eval("Name") %>' runat="server" />
                        <br />
                        Faculty: 
                        <asp:Label Text='<%# Eval("Faculty") %>' runat="server" />
                        <br />
                        FacultyNumber:
                        <asp:Label Text='<%# Eval("FacultyNumber") %>' runat="server" />
                        <br />
                        Grade Average:
                        <asp:Label Text='<%# Eval("GradeAverage") %>' runat="server" />
                        <br />
                        <br />
                    </div>
                </ItemTemplate>
            </asp:Repeater> 
        </div>
    </form>
</body>
</html>
