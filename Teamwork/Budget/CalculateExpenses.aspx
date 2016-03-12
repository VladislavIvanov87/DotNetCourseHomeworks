<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CalculateExpenses.aspx.cs" Inherits="Budget.CalculateExpenses" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <div class="navigation">
        <asp:HyperLink NavigateUrl="~/AddProduct.aspx" runat="server" Text="Add product" ToolTip="Adds new product" />
        <asp:HyperLink NavigateUrl="~/CalculateExpenses.aspx" runat="server" Text="Calculate expenses" ToolTip="Calculates all expenses" />
        <asp:HyperLink NavigateUrl="~/ShowAllProducts.aspx" runat="server" Text="Show all products" ToolTip="Displays all products" />
    </div>
    <form id="form1" runat="server">
    <div>
    <h3>Calculate expenses</h3>
        <asp:Label runat="server" Text="Choose a period"></asp:Label>
        <asp:DropDownList runat="server" ID="DropDownList" AutoPostBack="true" OnSelectedIndexChanged="DropDownList_SelectedIndexChanged">
            <asp:ListItem Value="7">For a week</asp:ListItem>
            <asp:ListItem Value="30">For a month</asp:ListItem>
            <asp:ListItem Value="365">For a year</asp:ListItem>
        </asp:DropDownList>
        <br />
        <br />
        <asp:Label runat="server" ID="MessageLabel" Text=""></asp:Label>
    </div>
    </form>
</body>
</html>
