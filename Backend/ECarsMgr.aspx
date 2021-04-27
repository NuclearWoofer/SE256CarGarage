<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ECarsMgr.aspx.cs" Inherits="SE256_Lab_MikeL.Backend.ECarsMgr" %>

<asp:Content ID="Content1" ContentPlaceHolderID="NewCarPartsContent" runat="server">
    <a href="ControlPanal.aspx" runat="server">Return to Control Panal</a>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <table>
       
        <tr>
            <td>Car ID</td>
            <td><asp:Label ID="lblCars_ID" runat="server" /></td>
        </tr>
 
        <tr>
            <td>Car Make</td>
            <td><asp:TextBox ID="txtCarMake" runat="server" MaxLength="50" /></td>
        </tr>
        <tr>
            <td>Car Model</td>
            <td><asp:TextBox ID="txtCarModel" runat="server" MaxLength="50" /></td>
        </tr> 
     
        <tr>
            <td>Car Style</td>
            <td><asp:TextBox ID="txtCarStyle" runat="server" MaxLength="50" /></td>
        </tr> 
        <tr>
            <td>Car Year</td>
            <td><asp:Calendar ID="calCarYear" runat="server" /></td>
        </tr>
      
        <tr>
            <td>Car Cylinders</td>
            <td><asp:TextBox ID="txtCarCylinders" runat="server" MaxLength="10" /></td>
        </tr>
        <tr>
            <td>Car Purchase Price</td>
            <td>$<asp:TextBox ID="txtCarPurchasePrice" runat="server" MaxLength="100" /></td>
        </tr>
    </table>
     
    <br />
    <asp:Button ID="btnAdd" runat="server" Text="Add" OnClick="btnAdd_Click" />

    <br />
    <asp:Label ID ="lblFeedback" runat="server" />
</asp:Content>
