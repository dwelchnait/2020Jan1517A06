<%@ Page Title="Job Application" Language="C#" MasterPageFile="~/Site.Master" 
    AutoEventWireup="true" CodeBehind="JobApp.aspx.cs" Inherits="WebApp.SamplePages.JobApp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Job Application</h1>
    <div class="row">
        <div class="col-md-offset-1 col-md-10">
            <blockquote class="alert alert-info" style="font-style:italic">
                This page will illustrate some simple controls to fill out an
                outline job application. The form will use basic 2 column bootstrap
                formatting with assistance from the NuGet package Bootwrap-FreeCode. The form will
                investigate the processing for a CheckBoxList. Data display will
                be to a simple string.
            </blockquote>
        </div>
    </div>
    <div class="row">
        <div class="col-md-6">
            <fieldset class="form-horizontal">
                <legend>Enter your information for application</legend>
                <asp:Label ID="Label1" runat="server" Text="Name"
                     AssociatedControlID="FullName">
                </asp:Label>
                <asp:TextBox ID="FullName" runat="server">
                </asp:TextBox>

                <asp:Label ID="Label2" runat="server" Text="Email"
                     AssociatedControlID="EmailAddress">
                </asp:Label>
                <asp:TextBox ID="EmailAddress" runat="server">
                </asp:TextBox>

                <asp:Label ID="Label3" runat="server" Text="Phone"
                     AssociatedControlID="Phone">
                </asp:Label>
                <asp:TextBox ID="Phone" runat="server">
                </asp:TextBox>

                <asp:Label ID="Label4" runat="server" Text="Time"
                     AssociatedControlID="FullOrPartTime">
                </asp:Label>
                <asp:RadioButtonList ID="FullOrPartTime" runat="server"
                     RepeatDirection="Horizontal" RepeatLayout="Flow">
                    <asp:ListItem Value="1">&nbsp;Full Time&nbsp;&nbsp;</asp:ListItem>
                    <asp:ListItem Value="2">&nbsp;Part Time</asp:ListItem>
                </asp:RadioButtonList>

                <asp:Label ID="Label5" runat="server" Text="Time"
                     AssociatedControlID="Jobs">
                </asp:Label>
                <asp:CheckBoxList ID="Jobs" runat="server">

                    <asp:ListItem>&nbsp;Sales</asp:ListItem>
                    <asp:ListItem>&nbsp;Manufacturing</asp:ListItem>
                    <asp:ListItem>&nbsp;Accounting</asp:ListItem>
                    <asp:ListItem>&nbsp;Shipping/Receiving</asp:ListItem>
                </asp:CheckBoxList>
            </fieldset>
        </div>
        <div class="col-md-6">
            <asp:Button ID="Submit" runat="server" Text="Submit" 
                 CssClass="btn btn-success" OnClick="Submit_Click"/>
            <asp:Button ID="Clear" runat="server" Text="Clear" 
                 CssClass="btn btn-default" OnClick="Clear_Click"/>
            <br /><br />
            <asp:Label ID="MessageLabel" runat="server"></asp:Label>
        </div>
    </div>
    <script src="../Scripts/bootwrap-freecode.js"></script>
</asp:Content>
