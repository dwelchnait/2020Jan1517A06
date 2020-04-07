<%@ Page Title="CRUD" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ProductCRUD.aspx.cs" Inherits="WebApp.NorthwindPages.ProductCRUD" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <link href="../Content/myStyles.css" rel="stylesheet" />
   <div class="page-header">
        <h1>Product CRUD Maintenance</h1>
    </div>

    <div class="col-md-12">
        <div class="alert alert-warning">
            <blockquote style="font-style: italic">
                This illustrates a single web form page CRUD maintenance. 
               
            </blockquote>
        </div>
    </div>
    <asp:RequiredFieldValidator ID="RequiredProductName" runat="server" 
        ErrorMessage="Product Name is requried" Display="None"
         SetFocusOnError="true" ForeColor="Firebrick" ControlToValidate="ProductName">
    </asp:RequiredFieldValidator>
   <div class="row">
       <div class="col-md-12">
           <asp:ValidationSummary ID="ValidationSummary1" runat="server" 
                HeaderText="Please address the following concerns with your data:"/>
       </div>
   </div>
      <%--  this will be the lookup control area--%>
         <div class="col-md-12"> 
             <asp:Label ID="Label5" runat="server" Text="Select a Product"></asp:Label>&nbsp;&nbsp;
             <asp:DropDownList ID="ProductList" runat="server"></asp:DropDownList>&nbsp;&nbsp;
             <asp:LinkButton ID="Search" runat="server" Font-Size="X-Large" OnClick="Search_Click" 
                  CausesValidation="false">Search</asp:LinkButton>&nbsp;&nbsp;
             <asp:LinkButton ID="Clear" runat="server" Font-Size="X-Large" OnClick="Clear_Click" 
                  CausesValidation="false">Clear</asp:LinkButton>&nbsp;&nbsp;
             <asp:LinkButton ID="AddProduct" runat="server" Font-Size="X-Large" OnClick="AddProduct_Click" >Add</asp:LinkButton>&nbsp;&nbsp;
             <asp:LinkButton ID="UpdateProduct" runat="server" Font-Size="X-Large" OnClick="UpdateProduct_Click" >Update</asp:LinkButton>&nbsp;&nbsp;
             <asp:LinkButton ID="RemoveProduct" runat="server" Font-Size="X-Large" 
                  CausesValidation="false" OnClick="RemoveProduct_Click"
                  OnClientClick="return confirm('Are you sure you wish to discontinue this product?')">Remove</asp:LinkButton>&nbsp;&nbsp;
         
             <br /><br />
             <asp:DataList ID="Message" runat="server">
                <ItemTemplate>
                    <%# Container.DataItem %>
                </ItemTemplate>
             </asp:DataList>

        
        </div>
      <%--  this will be the entity CRUD area--%>
        <div class ="row">
            <div class="col-md-6">
                <div class="text-right" >
                <asp:Label ID="Label12" runat="server" Text="ID" Font-Size="Larger" ></asp:Label>&nbsp;&nbsp;<br />
                <asp:Label ID="Label2" runat="server" Text="Name" Font-Size="Larger"></asp:Label>&nbsp;&nbsp;<br />
                <asp:Label ID="Label3" runat="server" Text="Supplier" Font-Size="Larger" ></asp:Label>&nbsp;&nbsp;<br />
                <asp:Label ID="Label6" runat="server" Text="Category" Font-Size="Larger" ></asp:Label>&nbsp;&nbsp;<br />
                <asp:Label ID="Label7" runat="server" Text="Quantity/Unit" Font-Size="Larger" ></asp:Label>&nbsp;&nbsp;<br />
                <asp:Label ID="Label8" runat="server" Text="Unit Price" Font-Size="Larger" ></asp:Label>&nbsp;&nbsp;<br />
                <asp:Label ID="Label9" runat="server" Text="In Stock" Font-Size="Larger" ></asp:Label>&nbsp;&nbsp;<br />
                <asp:Label ID="Label10" runat="server" Text="On Order" Font-Size="Larger" ></asp:Label>&nbsp;&nbsp;<br />
                <asp:Label ID="Label11" runat="server" Text="ROL" Font-Size="Larger" ></asp:Label>&nbsp;&nbsp;<br />
                <asp:Label ID="Label4" runat="server" Text="Status" Font-Size="Larger" ></asp:Label>&nbsp;&nbsp;<br />
                </div>
             </div>
            <div class="col-md-6 ">
                <asp:Label ID="ProductID" runat="server" ></asp:Label><br />
                <asp:TextBox ID="ProductName" runat="server" ></asp:TextBox><br />
                <asp:DropDownList ID="SupplierList" runat="server" Width="350px" 
                    DataSourceID="SupplerListODS" 
                    DataTextField="CompanyName" 
                    DataValueField="SupplierID"
                     AppendDataBoundItems ="true">
                    <asp:ListItem Value="0">None</asp:ListItem>
                </asp:DropDownList><br />
                <asp:DropDownList ID="CategoryList" runat="server" Width="350px" 
                    DataSourceID="CategoryListODS" 
                    DataTextField="CategoryName" 
                    DataValueField="CategoryID"
                     AppendDataBoundItems="true">
                    <asp:ListItem Value="0">None</asp:ListItem>
                </asp:DropDownList><br />
                <asp:TextBox ID="QuantityPerUnit" runat="server" ></asp:TextBox><br />
                <asp:TextBox ID="UnitPrice" runat="server" ></asp:TextBox><br />
                <asp:TextBox ID="UnitsInStock" runat="server" ></asp:TextBox><br />
                <asp:TextBox ID="UnitsOnOrder" runat="server" ></asp:TextBox><br />
                <asp:TextBox ID="ReorderLevel" runat="server" ></asp:TextBox><br />
                <asp:CheckBox ID="Discontinued" runat="server" Text=" (Discontinued if check)" ></asp:CheckBox><br />
            </div>
        </div>
    <asp:ObjectDataSource ID="SupplerListODS" runat="server" 
        OldValuesParameterFormatString="original_{0}" 
        SelectMethod="Suppliers_List" 
        TypeName="NorthwindSystem.BLL.SupplierController">
    </asp:ObjectDataSource>
    <asp:ObjectDataSource ID="CategoryListODS" runat="server" 
        OldValuesParameterFormatString="original_{0}" 
        SelectMethod="Categories_List" 
        TypeName="NorthwindSystem.BLL.CategoryController">
    </asp:ObjectDataSource>
</asp:Content>
