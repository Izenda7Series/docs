<%@ Page Title="Izenda" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Izenda.aspx.cs" Inherits="WebFormsStarterKit.Izenda" %>

<asp:Content ID="IzendaContent" ContentPlaceHolderID="MainContent" runat="server">
    <script type="text/javascript">
        $(document).ready(function () {
            izendaInit();
        });
    </script>

    <div class="loader" id="progressLoader"></div>
    <div class="izenda-container" id="izenda-root"></div>
</asp:Content>
