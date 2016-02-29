<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddCountry.aspx.cs" Inherits="Countries.AddCountry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <div class="navigation" />
    <asp:HyperLink NavigateUrl="~/AddCountry.aspx" runat="server" Text="Add new country" />
    <asp:HyperLink NavigateUrl="~/SearchByCountryOrCapital.aspx" runat="server" Text="SearchByCountryOrCapital" />
    <asp:HyperLink NavigateUrl="~/SearchByPopulationInRange.aspx" runat="server" Text="SearchByPopulation" />
    <div />
    <form id="form1" runat="server">
        <div>
            <h3>Enter info for the country</h3>
            <asp:Label runat="server" Text="Country"></asp:Label>
            <asp:TextBox runat="server" ID="CountryTextBox"></asp:TextBox>
            <br />
            <br />
            <asp:Label runat="server" Text="Capital"></asp:Label>
            <asp:TextBox runat="server" ID="CapitalTextBox"></asp:TextBox>
            <br />
            <br />
            <asp:Label runat="server" Text="Population in range"></asp:Label>
            <asp:TextBox runat="server" ID="PopulationTextBox"></asp:TextBox>
            <br />
            <br />
            <asp:Label runat="server" ID="MessageLabel" Text="" />
            <br />
            <asp:Button runat="server" ID="AddButton" Text="Add" OnClick="AddButton_Click" />
        </div>
    </form>
</body>
</html>
