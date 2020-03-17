<%@ Page Title="" Language="C#" MasterPageFile="~/masterpage.Master" AutoEventWireup="true" CodeBehind="child1.aspx.cs" Inherits="WebApplication3.child1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table>
        <tr>
            <td>
                username
            </td>
            <td>
                <asp:TextBox ID="txtusername" runat="server" ClientIDMode="Static"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                password
            </td>
            <td>
                <asp:TextBox ID="txtpassword" runat="server" ClientIDMode="Static"></asp:TextBox>
            </td>
            <td>
                <asp:Label ID="lblMessage" runat="server" Text="" ClientIDMode="Static"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Button ID="Button1" runat="server" Text="login" OnClick="txtbutton_Click" />
            </td>
        </tr>
    </table>
</asp:Content>
