<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ControlPanal.aspx.cs" Inherits="SE256_Lab_MikeL.Backend.ControlPanal" %>


<asp:Content ID="Content1" ContentPlaceHolderID="NewCarPartsContent" runat="server">
</asp:Content>


<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Control Panal</h2>

    <table>
        <tr>  <!-- Later use-->
            <td><a href="ECarsMgr.aspx" runat="server">Add a Car to Your Garage</a></td>
        </tr>
        <tr>
            <td><asp:Button ID="btnLogout" runat="server" Text="Log Out" OnClick="btnLogout_Click" /></td>

        </tr>
    </table>
</asp:Content>
