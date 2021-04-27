<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="SE256_Lab_MikeL.About" %>


<%--Placeholder for CarPartsContent. If there are no new car parts, clear the DIV Tags.--%>

<asp:Content ID="Content1" ContentPlaceHolderID="NewCarPartsContent" runat="server">
    <div>

    </div>
</asp:Content>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>
    <h3>Mike's Mission</h3>
    <p>Mike's Auto Shop has always been supporting our local community with fresh and new parts for every person's ride. This application will allow you to check our inventory for parts for sale for your next project. </p>
    <p> Need new brakes? New wheels? Maybe a new car entirely to replace that rustbucket? Well come check our wares to see if we have what YOU need.</p>
</asp:Content>
