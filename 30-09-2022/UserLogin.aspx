<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UserLogin.aspx.cs" Inherits="_30thSeptember2022.UserLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="font-size: 40px">
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; LoginPage<br />
            <br />
            <asp:Label ID="userid" runat="server" Text="UserId:"></asp:Label>
            <asp:TextBox ID="useridtextbox" runat="server" TextMode="Search"></asp:TextBox>
            <asp:RequiredFieldValidator ID="useridvalidator" runat="server" ControlToValidate="useridtextbox" ErrorMessage="PleaseEnterUserId" ForeColor="#CC3300"></asp:RequiredFieldValidator>
            <br />
            <asp:Label ID="password" runat="server" Text="Password:"></asp:Label>
            <asp:TextBox ID="passwordtextbox" runat="server" TextMode="Password"></asp:TextBox>
            <asp:RequiredFieldValidator ID="passwordvalidator" runat="server" ControlToValidate="passwordtextbox" ErrorMessage="PleaseEnterPassword" ForeColor="#CC3300"></asp:RequiredFieldValidator>
            <br />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="submitbutton" runat="server" Height="43px" OnClick="submitbutton_Click" style="margin-top: 0px; margin-bottom: 0px" Text="Login" />
        </div>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
