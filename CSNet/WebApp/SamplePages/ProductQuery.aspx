<%@ Page Title="Product Query List" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ProductQuery.aspx.cs" Inherits="WebApp.SamplePages.ProductQuery" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
     <h1>Product Query</h1>
    <div class="row">
        <div class="col-md-12">
            <asp:Label ID="Label1" runat="server" Text="Select a Product:"></asp:Label>&nbsp;&nbsp;
            <asp:DropDownList ID="ProductList" runat="server"></asp:DropDownList>&nbsp;&nbsp;
            <asp:LinkButton ID="Fetch" runat="server" OnClick="Fetch_Click">
                <i class="fa fa-search"></i> Search
            </asp:LinkButton>
            <br />
            <asp:Label ID="MessageLabel" runat="server" ></asp:Label>
            <br />
         </div>
    </div>
    <div class="row">
        <div class="col-md-2 text-right">
            <asp:Label ID="label2" runat="server" Text="ID:"></asp:Label><br/>
            <asp:Label ID="label3" runat="server" Text="Name:"></asp:Label><br/>
            <asp:Label ID="label4" runat="server" Text="Supplier:"></asp:Label><br/>
            <asp:Label ID="label6" runat="server" Text="Category:"></asp:Label><br/>
            <asp:Label ID="label8" runat="server" Text="Qty/Unit:"></asp:Label><br/>
            <asp:Label ID="label10" runat="server" Text="Price:"></asp:Label><br/>
            <asp:Label ID="label12" runat="server" Text="QOH:"></asp:Label><br/>
            <asp:Label ID="label14" runat="server" Text="QOO:"></asp:Label><br/>
            <asp:Label ID="label16" runat="server" Text="ROL:"></asp:Label><br/>
            <asp:Label ID="label18" runat="server" Text="Disc:"></asp:Label>
                
        </div>
        <div class="col-md-10 text-left">
            <asp:Label ID="ProductID" runat="server"></asp:Label><br/>
            <asp:Label ID="ProductName" runat="server" ></asp:Label><br/>
            <asp:Label ID="SupplierID" runat="server" ></asp:Label><br/>
            <asp:Label ID="CategoryID" runat="server" ></asp:Label><br/>
            <asp:Label ID="QuantityPerUnit" runat="server" ></asp:Label><br/>
            <asp:Label ID="UnitPrice" runat="server" ></asp:Label><br/>
            <asp:Label ID="UnitsInStock" runat="server" ></asp:Label><br/>
            <asp:Label ID="UnitsOnOrder" runat="server" ></asp:Label><br/>
            <asp:Label ID="ReorderLevel" runat="server" ></asp:Label><br/>
            <asp:CheckBox ID="Discontinued" runat="server"
                Text="  (checked if discontinued)"></asp:CheckBox>
        </div>
    </div>
</asp:Content>
