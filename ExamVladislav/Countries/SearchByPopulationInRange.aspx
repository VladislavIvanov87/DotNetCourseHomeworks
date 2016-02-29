<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SearchByPopulationInRange.aspx.cs" Inherits="Countries.SearchByPopulationInRange" %>

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
            <h3>Select population in range</h3>
            <asp:Label runat="server" Text="Choose a population in range: " />
            <asp:DropDownList runat="server" ID="DropDownList" AutoPostBack="true" OnSelectedIndexChanged="DropDownList_SelectedIndexChanged">
                <asp:ListItem Value="Small countries" Text="1 000 000 - 10 000 000"></asp:ListItem>
                <asp:ListItem Value="Big countries" Text="10 000 000 - 100 000 000"></asp:ListItem>
                <asp:ListItem Value="Large countries" Text="100 000 000 - 2 000 000 000"></asp:ListItem>
            </asp:DropDownList>
            <br />
            <br />

            <asp:Repeater runat="server" ID="repeater">
                <ItemTemplate>
                    <div class="container">
                        Country:
                        <asp:Label Text='<%# Eval("Country") %>' runat="server" />
                        <br />
                        Capital:
                        <asp:Label Text='<%# Eval("Capital") %>' runat="server" />
                        <br />
                        Population:
                        <asp:Label Text='<%# Eval("PopulationInRange") %>' runat="server" />
                        <br />
                        <br />
                    </div>
                </ItemTemplate>
            </asp:Repeater>
        </div>
    </form>
</body>
</html>
