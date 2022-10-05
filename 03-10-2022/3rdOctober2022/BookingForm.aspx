<%@ Page Title="" Language="C#" MasterPageFile="~/Library.Master" AutoEventWireup="true" CodeBehind="BookingForm.aspx.cs" Inherits="_3rdOctober2022.BookingForm" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p style="font-size: 15px; font-weight: bold; font-style: normal; font-variant: small-caps; text-transform: capitalize; color: #000080">
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; LoginForm</p>
    <p style="font-size: 15px; font-weight: bold; font-style: normal; font-variant: small-caps; text-transform: capitalize; color: #000080">
        &nbsp;</p>
    <p style="font-size: 15px; font-weight: bold; font-style: normal; font-variant: small-caps; text-transform: capitalize; color: #000080">
        <asp:Label ID="userid" runat="server" Text="UserId"></asp:Label>
        <asp:TextBox ID="UserIdTextBox" runat="server" TextMode="Email"></asp:TextBox>
        <br />
    </p>
    <p style="font-size: 15px; font-weight: bold; font-style: normal; font-variant: small-caps; text-transform: capitalize; color: #000080">
        <asp:Label ID="passwordid" runat="server" Text="Password"></asp:Label>
        <asp:TextBox ID="PasswodTextBox" runat="server"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Login" />
    </p>
</asp:Content>
