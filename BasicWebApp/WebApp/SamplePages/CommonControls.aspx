<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" 
    AutoEventWireup="true" CodeBehind="CommonControls.aspx.cs" 
    Inherits="WebApp.SamplePages.CommonControls" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" 
    runat="server">
    <h1>Common Web Form Control using event driven logic</h1>
    <div class="row">
        <div class="col-md-6 text-right">
            <asp:Label ID="Label1" runat="server" 
                Text="Enter a selection choice 1 to 4:"></asp:Label>
        </div>
        <div class="col-md-6">
            <asp:TextBox ID="TextBoxNumberChoice" runat="server"
                 Width="50px" Height="30px" ToolTip="Enter a number between 1 and 4.">
            </asp:TextBox>
            &nbsp;&nbsp;
            <asp:Button ID="SubmitButtonChoice" runat="server" 
                Text="Submit Choice" CssClass="btn btn-primary" OnClick="SubmitButtonChoice_Click" />
        </div>
    </div>
    <div class="row">
        <div class="col-md-6 text-right">
            <asp:Label ID="Label2" runat="server" 
                Text="RadiobuttonList:"
                 Font-Bold="true" Font-Size="Larger"
                 ForeColor="#33cc33"></asp:Label>
        </div>
        <div class="col-md-6">
            <asp:RadioButtonList ID="RadioButtonListChoice" runat="server"
                RepeatDirection="Horizontal" RepeatLayout="Flow">
                <asp:ListItem Value="1">COMP1008&nbsp;</asp:ListItem>
                <asp:ListItem Value="2">CPSC1517&nbsp;</asp:ListItem>
                <asp:ListItem Value="3">DMIT1508&nbsp;</asp:ListItem>
                <asp:ListItem Value="4">DMIT2018</asp:ListItem>
            </asp:RadioButtonList>
        </div>
    </div>
    <div class="row">
        <div class="col-md-6 text-right">
            <asp:Literal ID="Literal1" runat="server"
                 Text="Checkbox:"></asp:Literal>
        </div>
        <div class="col-md-6">
            <asp:CheckBox ID="CheckBoxChoice" runat="server" 
                 Font-Bold="true" Text=" (check if programming language course)"/>
        </div>
    </div>
    <div class="row">
        <div class="col-md-6 text-right">
            <asp:Label ID="Label3" runat="server" 
                Text="DisplayReadOnly:"></asp:Label>
        </div>
        <div class="col-md-6">
            <asp:Label ID="DisplayReadOnly" runat="server" 
                CssClass="form-control" ></asp:Label>
        </div>
    </div>
    <div class="row">
        <div class="col-md-6 text-right">
            <asp:Label ID="Label4" runat="server" 
                Text="DDL Collection"></asp:Label>
        </div>
        <div class="col-md-6">
            <asp:DropDownList ID="CollectionList" runat="server"
                 CssClass="form-control">
            </asp:DropDownList>
            &nbsp;&nbsp;
            <asp:LinkButton ID="LinkButtonCollection" runat="server" OnClick="LinkButtonCollection_Click">
                Submit choice from List</asp:LinkButton>
        </div>
    </div>
    <div class="row">
        <div class="col-md-12 text-center">
            <br /><br />
            <asp:Label ID="MessageLabel" runat="server" ></asp:Label>
       
        </div>
    </div>
   
</asp:Content>
