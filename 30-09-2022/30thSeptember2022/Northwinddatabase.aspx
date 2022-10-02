<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Northwinddatabase.aspx.cs" Inherits="_30thSeptember2022.Northwinddatabase" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="ProductId"></asp:Label>
            <asp:TextBox ID="ProductIdTextBox" runat="server" TextMode="Number"></asp:TextBox>
        </div>
        <asp:Button ID="SearchButton" runat="server" OnClick="SearchButton_Click" Text="Search" />
        <br />
        <br />
        &nbsp;ProductID:<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        &nbsp;ProductName:
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
    &nbsp;<br />
        SupplierID:<asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        <br />
        CategoryID:<asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
        <br />
        UnitPrice:<asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
    </form>
</body>
</html>
