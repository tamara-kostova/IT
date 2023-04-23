<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Glasaj.aspx.cs" Inherits="Lab1.Glasaj" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row">
        <div class="col-md-3">
        <asp:Label ID="lblprofesor" runat="server" Text=""></asp:Label>
    </div>
    </div>
    <div class="row">
        <div class="col-md-3">
        <asp:ListBox ID="lbPredmeti" runat="server" 
            AutoPostBack="True" 
            OnSelectedIndexChanged="lbPredmeti_SelectedIndexChanged"></asp:ListBox>
        </div>
        <div class="col-md-3">
            <asp:ListBox ID="lbKrediti" runat="server"></asp:ListBox>
        </div>
    </div>
    <div class="row">
        <div class="col-md-3">
        <asp:Button ID="btnglasaj" runat="server" Text="Гласај" OnClick="btnglasaj_Click" />
    </div>
    </div>
    <div class="row">
        <div class="col-md-3">
            Предмет:
        <asp:TextBox ID="tbPredmet" runat="server"></asp:TextBox>
        </div>
    </div>
        <div class="row">
        <div class="col-md-3">
            Кредити:
        <asp:TextBox ID="tbKrediti" runat="server"></asp:TextBox>
        </div>
    </div>
    <div class="row">
        <div class="col-md-3">
        <asp:Button ID="btndodadi" runat="server" Text="Додади" OnClick="btndodadi_Click" />
    </div>
    </div>
    <div class="row">
        <div class="col-md-3">
        <asp:Button ID="btnIzbrisi" runat="server" Text="Избриши" OnClick="btnIzbrisi_Click" />
    </div>
    </div>
</asp:Content>
