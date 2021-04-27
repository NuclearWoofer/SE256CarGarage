<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="SE256_Lab_MikeL.Contact" %>


<%--Placeholder for CarPartsContent. If there are no new car parts, clear the DIV Tags.--%>
<asp:Content ID="Content1" ContentPlaceHolderID="NewCarPartsContent" runat="server">
    <div>
      
    </div>
</asp:Content>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>
    <h3>Mike's Contacts</h3>
    <address>
        4 Lamborghini Drive.<br />
        Lincoln, RI 02886<br />
        <abbr title="Phone">P:</abbr>
        401-654-8227
    </address>

    <address>
        <strong>Support:</strong>   <a href="miketatooine@gmail.com">MikeTatooine@Gmail.com</a><br />
        <strong>Support:</strong>   <a href="miketatooine@gmail.com">MikeTatooine@Gmail.com</a><br />
        <strong>Marketing:</strong> <a href="mailto:MikeMarketing@Gmail.com">MikeMarketing@Gmail.com</a>
    </address>
</asp:Content>
