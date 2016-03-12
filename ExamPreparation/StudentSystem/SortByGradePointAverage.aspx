<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SortByGradePointAverage.aspx.cs" Inherits="StudentSystem.SortByGradePointAverage" %>

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
    <h3>Show students ordered by grade average</h3>
        <asp:Label runat="server" Text="Choose a faculty" />
        <asp:DropDownList runat="server" ID="dropDownList" AutoPostBack="true" OnSelectedIndexChanged="dropDownList_SelectedIndexChanged">
            <asp:ListItem Value="Mathematics"></asp:ListItem>
            <asp:ListItem Value="Computer Science"></asp:ListItem>
            <asp:ListItem Value="Engineering"></asp:ListItem>
        </asp:DropDownList>
        <br />
        <br />
            <asp:Repeater runat="server" ID="repeater">
                <ItemTemplate>
                    <div class="container">
                        Name:
                        <asp:Label Text='<%# Eval("Name") %>' runat="server" />
                        <br />
                        Faculty
                        <asp:Label Text='<%# Eval("Faculty") %>' runat="server" />
                        <br />
                        Faculty number
                        <asp:Label Text='<%# Eval("FacultyNumber") %>' runat="server" />
                        <br />
                        Grade average:
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
