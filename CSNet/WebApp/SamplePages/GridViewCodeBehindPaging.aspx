<%@ Page Title="GridView Paging Filter Search" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="GridViewCodeBehindPaging.aspx.cs" Inherits="WebApp.SamplePages.GridViewCodeBehindPaging" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
       <div class="page-header">
        <h1>Filter Search on Partial Product Name</h1>
    </div>

    <div class="row col-md-12">
        <div class="alert alert-warning">
            <blockquote style="font-style: italic">
                This web page uses only code-behind techniques.<br /><br />
                This web form will do a filter search on Products. The user will enter
                a partial product name and product a list of products containing
                the partial string. The Gridview will display only a few fields.
                The Product primary key will be hidden on the gridview row. The Gridview
                will be limited to 3 rows of display. The paging for the GridView will be
                done using code behind. The page will demonstrate row selection from the GridView.
            </blockquote>
        </div>
    </div>

     <div class="row">
        <div class="col-md-6">
            <asp:Label ID="Label1" runat="server" Text="Select a Product:"></asp:Label>&nbsp;&nbsp;
            <asp:TextBox ID="ProductArg" runat="server"></asp:TextBox>&nbsp;&nbsp;
            <asp:LinkButton ID="Fetch" runat="server" OnClick="Fetch_Click">
                <i class="fa fa-search"></i> Search
            </asp:LinkButton>&nbsp;&nbsp;
            <asp:LinkButton ID="Clear" runat="server" OnClick="Clear_Click" >
                <i class="fa fa-trash"></i>Clear</asp:LinkButton>
            <br />
            <asp:Label ID="MessageLabel" runat="server" ></asp:Label>
            <br />
            <asp:GridView ID="ProductList" runat="server" AutoGenerateColumns="False"
                 CssClass="table table-striped" GridLines="Horizontal" BorderStyle="None" 
                 OnSelectedIndexChanged="ProductList_SelectedIndexChanged"
                 AllowPaging="true" PageSize="4" PagerSettings-Mode="Numeric">

                <Columns>
                    <asp:CommandField SelectText="View" ShowSelectButton="True" 
                        ButtonType="Button"  CausesValidation="false" 
                        ></asp:CommandField>
                    <asp:TemplateField HeaderText="Name">
                        <ItemTemplate>
                            <asp:Label ID="ProductID" runat="server" 
                                Text='<%# Eval("ProductID") %>'
                                 Visible="false"></asp:Label>
                            <asp:Label ID="ProductName" runat="server" 
                                Text='<%# Eval("ProductName") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Price">
                        <ItemTemplate>
                            <asp:Label ID="UnitPrice" runat="server" 
                                Text='<%# string.Format("{0:0.00}",Eval("UnitPrice")) %>'></asp:Label>
                        </ItemTemplate>
                        <ItemStyle HorizontalAlign="Right">
                        </ItemStyle>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Qty">
                        <ItemTemplate>
                            <asp:Label ID="UnitsInStock" runat="server" 
                                Text='<%# Eval("UnitsInStock") %>'></asp:Label>
                        </ItemTemplate>
                        <ItemStyle HorizontalAlign="Right">
                        </ItemStyle>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
         </div>
         <div class="col-md-6">
             <table>
                 <tr>
                     <td align="right">
                         <asp:Label ID="Label2" runat="server" Text="ID"></asp:Label>&nbsp;&nbsp;
                     </td>
                     <td align="left">
                         <asp:Label ID="ProductID" runat="server" ></asp:Label>
                     </td>
                 </tr>
                 <tr>
                     <td align="right">
                         <asp:Label ID="Label3" runat="server" Text="Name"></asp:Label>&nbsp;&nbsp;
                     </td>
                     <td align="left">
                         <asp:Label ID="ProductName" runat="server"></asp:Label>
                     </td>
                 </tr>
                 <tr>
                     <td align="right">
                         <asp:Label ID="Label4" runat="server" Text="Price"></asp:Label>&nbsp;&nbsp;
                     </td>
                     <td align="left">
                         <asp:Label ID="UnitPrice" runat="server" ></asp:Label>
                     </td>
                 </tr>
                 <tr>
                     <td align="right">
                         <asp:Label ID="Label5" runat="server" Text="Disc"></asp:Label>&nbsp;&nbsp;
                     </td>
                     <td align="left" >
                         <asp:CheckBox ID="Discontinued" runat="server"
                              Text=" (discontinued if checked)" />
                     </td>
                 </tr>
             </table>
         </div>
    </div>
</asp:Content>
