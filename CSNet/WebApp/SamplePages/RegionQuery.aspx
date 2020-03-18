<%@ Page Title="Region Query String" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="RegionQuery.aspx.cs" Inherits="WebApp.SamplePages.RegionQuery" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Region Query</h1>
    <div class="row">
         <div class="col-md-6 text-right">
            <asp:Label ID="Label1" runat="server" Text="Select a Region:"></asp:Label>&nbsp;&nbsp;
            <asp:TextBox ID="RegionArg" runat="server"></asp:TextBox>&nbsp;&nbsp;
            <asp:LinkButton ID="Fetch" runat="server">
                <i class="fa fa-search"></i> Search
            </asp:LinkButton>
            <br /><br />
            <asp:Label ID="MessageLabel" runat="server" ></asp:Label>
        </div>
        <div class="col-md-6 text-left">
            <asp:Label ID="label2" runat="server" Text="Region:"></asp:Label>&nbsp;&nbsp;
            <asp:Label ID="RegionID" runat="server" ></asp:Label>
            <br />
             <asp:Label ID="label3" runat="server" Text="Description:"></asp:Label>&nbsp;&nbsp;
             <asp:Label ID="Description" runat="server" ></asp:Label>
        </div>
    </div>
</asp:Content>
