<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddStudent.aspx.cs" Inherits="StudentSystem.AddStudent" %>

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
    <h3>Enter info for the student</h3>
        <asp:Label runat="server" Text="Name"></asp:Label>
        <asp:TextBox runat="server" ID="nameTextBox"></asp:TextBox>
        <asp:RequiredFieldValidator runat="server" ID="req1" ControlToValidate="nameTextBox" ErrorMessage="Please enter a name">
        </asp:RequiredFieldValidator>
        <br />
        <br />
        <asp:Label runat="server" Text="Faculty"></asp:Label>
        <asp:TextBox runat="server" ID="facultyTextBox"></asp:TextBox>
        <asp:RequiredFieldValidator runat="server" ID="req2" ControlToValidate="facultyTextBox" ErrorMessage="Please enter a faculty">
        </asp:RequiredFieldValidator>
        <br />
        <br />
        <asp:Label runat="server" Text="FacultyNumber"></asp:Label>
        <asp:TextBox runat="server" ID="facultyNumberTextBox"></asp:TextBox>
        <asp:RequiredFieldValidator runat="server" ID="req3" ControlToValidate="facultyNumberTextBox" ErrorMessage="Please enter a faculty number">
        </asp:RequiredFieldValidator>
        <br />
        <br />
        <asp:Label runat="server" Text="GradeAverage"></asp:Label>
        <asp:TextBox runat="server" ID="gradeAverageTextBox"></asp:TextBox>
        <asp:RequiredFieldValidator runat="server" ID="req4" ControlToValidate="gradeAverageTextBox" ErrorMessage="Please enter a grade average">
        </asp:RequiredFieldValidator>
        <br />
        <br />
        <asp:Label runat="server" ID="messageLabel" Text=""></asp:Label>
        <br />
        <asp:Button runat="server" ID="AddButton" Text="Add" OnClick="AddButton_Click" />
    </div>
    </form>
</body>
</html>
