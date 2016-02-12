<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UserInfo.aspx.cs" Inherits="UserRegistration.UserInfo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label runat="server" Text="UserName"></asp:Label>
        <asp:TextBox ID="textBox1" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="req1" runat="server" ControlToValidate="textBox1" ErrorMessage="Please enter your name!">
        </asp:RequiredFieldValidator>
        <br />
        <br />
        <asp:Label runat="server" Text="Password"></asp:Label>
        <asp:TextBox ID="textBox2" runat="server" TextMode="Password"></asp:TextBox>
        <asp:RequiredFieldValidator ID="req2" runat="server" ControlToValidate="textBox2" ErrorMessage="Please enter your password!">
        </asp:RequiredFieldValidator>
        <br />
        <br />
        <asp:Label runat="server" Text="Repeat password"></asp:Label>
        <asp:TextBox ID="textBox3" runat="server" TextMode="Password"></asp:TextBox>
        <asp:RequiredFieldValidator ID="req3" runat="server" ControlToValidate="textBox3" ErrorMessage="Please repeat your password!">
        </asp:RequiredFieldValidator>
        <asp:Label ID="label4" runat="server" Text="" Visible="false"></asp:Label>
        <br />
        <br />
        <asp:Label runat="server" Text="Age"></asp:Label>
        <asp:TextBox ID="textBox4" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="req4" runat="server" ControlToValidate="textBox4" ErrorMessage="Please enter your age!">
        </asp:RequiredFieldValidator>
        <br />
        <br />
        <asp:Label runat="server" Text="E-mail"></asp:Label>
        <asp:TextBox ID="textBox5" runat="server" TextMode="Email"></asp:TextBox>
        <asp:RequiredFieldValidator ID="req5" runat="server" ControlToValidate="textBox5" ErrorMessage="Please enter your e-mail!">
        </asp:RequiredFieldValidator>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="Register" OnClick="Button1_Click"/>
    </div>
    </form>
</body>
</html>
