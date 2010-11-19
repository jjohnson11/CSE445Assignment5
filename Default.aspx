<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div>
        <table>
            <tr>
                <td>Username:</td>
                <td><asp:TextBox ID="usernameTxt" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Password:</td>
                <td><asp:TextBox ID="passwordTxt" runat="server"></asp:TextBox>
                </td>
            </tr>
           
            </table>
            <asp:Button ID="login" runat="server" Text="Login" onclick="login_Click" />
    </div>
</asp:Content>

