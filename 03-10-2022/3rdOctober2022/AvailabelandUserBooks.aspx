<%@ Page Title="" Language="C#" MasterPageFile="~/Library.Master" AutoEventWireup="true" CodeBehind="AvailabelandUserBooks.aspx.cs" Inherits="_3rdOctober2022.AvailabeandUserBooks" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    AvailableBooksInLibrary:<asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Search" />
    <br />
    UserBooksInhisAccount:<asp:Button ID="Button2" runat="server" Text="Search" OnClick="Button2_Click" />
    <br />
    
    <div>
        <asp:GridView ID="AvailableBooks" runat="server" AutoGenerateColumns="false">
            <Columns>
                 <asp:BoundField DataField="Book_No" HeaderText="Book_No" />
                 <asp:BoundField DataField="Book_Name" HeaderText="Book_Name" />
                 <asp:BoundField DataField="Author" HeaderText="Author" />
                 <asp:BoundField DataField="cost" HeaderText="cost" />
                <asp:BoundField DataField="category" HeaderText="category" />

            </Columns>

        </asp:GridView>
    </div>
     <div>
        <asp:GridView ID="UserBooks" runat="server" AutoGenerateColumns="false">
            <Columns>
                 <asp:BoundField DataField="Lib_Issue_Id" HeaderText="Lib_Issue_Id" />
                 <asp:BoundField DataField="Book_No" HeaderText="Book_No" />
                <asp:BoundField DataField="IssueDate" HeaderText="Issue_Date" />
                
                

            </Columns>

        </asp:GridView>
    </div>

</asp:Content>
