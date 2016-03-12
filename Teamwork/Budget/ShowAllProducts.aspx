<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ShowAllProducts.aspx.cs" Inherits="Budget.ShowAllProducts" %>

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
    <asp:Repeater runat="server" ID="Repeater">
        <ItemTemplate>
            Date:
            <asp:Label runat="server" Text='<%# Eval("Date", "{0:dd/MM/yyyy}") %>' />
            <br />
            Expense:
            <asp:Label runat="server" Text='<%# Eval("Expense") %>' />
            <br />
            Price:
            <asp:Label runat="server" Text='<%# Eval("Price") %>' />
            <br />
            <br />
        </ItemTemplate>
    </asp:Repeater>
    </div>
    </form>
</body>
</html>
