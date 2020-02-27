<%@ Page Title="Hello World" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true"
    CodeBehind="HelloWorld.aspx.cs" Inherits="WebApp.SamplePages.HelloWorld" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Hello World</h1>
    <asp:Label ID="PromptLabel" runat="server" Text="Enter your name"></asp:Label>
    &nbsp;&nbsp;
    <asp:TextBox ID="NameArg" runat="server" ToolTip="Enter your name"
         placeholder="your name"></asp:TextBox>
    &nbsp;&nbsp;
    <asp:Button ID="PressMe" runat="server" Text="Press Me"
         CssClass="btn btn-primary" OnClick="PressMe_Click"/>
    <br />
    <asp:Label ID="OutputArea" runat="server"></asp:Label>
    <br />
    </asp:Content>
