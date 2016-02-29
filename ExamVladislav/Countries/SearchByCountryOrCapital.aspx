<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SearchByCountryOrCapital.aspx.cs" Inherits="Countries.ShowInfoForTheCountry" %>

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
            <h3>Enter word to search</h3>
            <asp:Label runat="server" Text="Keyword"></asp:Label>
            <asp:TextBox runat="server" ID="KeywordTextBox"></asp:TextBox>
            <br />
            <br />
           <asp:Button runat="server" ID="SearchButton" Text="Search" OnClick="SearchButton_Click" />
            <br />
            <br />
            <asp:Label runat="server" ID="MessageLabel" Text=""></asp:Label>

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
