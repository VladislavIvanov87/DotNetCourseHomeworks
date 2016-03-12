<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddProduct.aspx.cs" Inherits="Budget.AddProduct" %>

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
    <h3>Info for the product</h3>
        
        <asp:Label runat="server" Text="Date"></asp:Label>
        <asp:TextBox runat="server" ID="DateTextBox" TextMode="Date"></asp:TextBox>
        <br />
        <br />
        <asp:Label runat="server" Text="Expense" ></asp:Label>
        <asp:TextBox runat="server" ID="ExpenseTextBox" ></asp:TextBox>
        <br />
        <br />
        <asp:Label runat="server" Text="Price" ></asp:Label>
        <asp:TextBox runat="server" ID="PriceTextBox" TextMode="Number" step="0.01"></asp:TextBox>
        <br />
        <br />
        <asp:Label runat="server" ID="MessageLabel" Text=""></asp:Label>
        <br />
        <asp:Button runat="server" ID="AddButton" Text="Add" OnClick="AddButton_Click" />
    </div>
    </form>
</body>
</html>
