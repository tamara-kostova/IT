<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Najava.aspx.cs" Inherits="Lab1.Najava" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row">
        <div class="col-md-3">
        Име:
        <asp:TextBox ID="ime" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator 
                class="text-danger"
                ID="RequiredFieldValidator1" 
                runat="server" 
                ErrorMessage="Полето за име е задолжително!" 
                ControlToValidate="ime">
            </asp:RequiredFieldValidator>
        </div>
    </div>
    <div class="row">
        <div class="col-md-3">
        Лозинка:
        <asp:TextBox ID="lozinka" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator 
                class="text-danger"
                ID="RequiredFieldValidator2" 
                runat="server" 
                ErrorMessage="Полето за лозинка е задолжително" 
                ControlToValidate="lozinka">
            </asp:RequiredFieldValidator>
        </div>
    </div>
    <div class="row">
        <div class="col-md-3">
        е-адреса:
        <asp:TextBox ID="email" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator 
                class="text-danger"
                ID="RequiredFieldValidator3" 
                runat="server" 
                ErrorMessage="Полето за email е задолжително" 
                ControlToValidate="email">
            </asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator 
                class="text-danger"
                ID="RegularExpressionValidator1" 
                runat="server" 
                ErrorMessage="Погрешен формат на е-адреса" 
                ControlToValidate="email" 
                ValidationExpression="\S+@\w+\.\w+"></asp:RegularExpressionValidator>
        </div>
    </div>
    <div class="row">
        <div class="col-md-3">
            <asp:Button ID="btnnajava" runat="server" Text="Најавете се" OnClick="btnnajava_Click" />
        </div>
    </div>
</asp:Content>
