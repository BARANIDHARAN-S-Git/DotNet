<%@ Page Title="" Language="C#" MasterPageFile="~/Library.Master" AutoEventWireup="true" CodeBehind="BookRequest.aspx.cs" Inherits="_3rdOctober2022.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        Enter BookNumber<asp:DropDownList ID="BookNumberDropDownList" runat="server" >
            <asp:ListItem>101</asp:ListItem>
            <asp:ListItem>102</asp:ListItem>
            <asp:ListItem>104</asp:ListItem>
        </asp:DropDownList>
    </p>
    <p>
        Enter LibraryIssueId<asp:TextBox ID="LibraryIssueIdTextBox" runat="server" ></asp:TextBox>
    </p>
    <p>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Search" />
    </p>
</asp:Content>
