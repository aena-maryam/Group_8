﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WebApplication6.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1 style="margin-top:70px"> <i class="glyphicon glyphicon-cutlery" style="font-size:50px; left:49%; color:#29364f"></i> </h1>
    <h2 style="text-align:center; margin-top: 130px; font-weight:bold; font-size:40px; color:#ffffff; font-family:'Adobe Hebrew'"> Log In To RMS</h2>
    <p style="margin-top:30px">
        <i class="glyphicon glyphicon-user" style="font-size:24px; left:40%; color:#29364f"></i>
        <asp:TextBox ID="u_name" placeholder="Enter the username" style="color: #29364f; margin-top:10px; font-size:18px; margin-left:41.5%; padding-top:10px; padding-bottom:-10px;" runat="server"></asp:TextBox>
    </p>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" style="margin-left:43%; font-size:18px" ControlToValidate="u_name" ErrorMessage="Username Required" ForeColor="Red"></asp:RequiredFieldValidator>
    
    <p style="margin-top:10px">
        <i class="glyphicon glyphicon-lock" style="font-size:24px;left:40%; color:#29364f"></i>
        <asp:TextBox ID="password_" placeholder="Enter the password"  TextMode="Password" style="color: #29364f; font-size:18px; margin-left:41.5%; padding-top:10px; padding-bottom:-10px;" runat="server"></asp:TextBox>
    </p>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" style="margin-left:43%; font-size:18px" ControlToValidate="password_" ErrorMessage="Password required" ForeColor="Red"></asp:RequiredFieldValidator>

    <br />
    <asp:Button OnClick="LoginButton_Click" ID="Button1" style="font-size:30px; color:#ffffff; font-family:'Adobe Hebrew'; font-weight:bold; border: 2px solid #ffffff; background-color: #42c1b6; text-align: center; display: inline-block; margin-top:10px; margin-left:45.8%;" runat="server" Text="Sign In" />
    <br />
    <asp:Label ID="Message" runat="server" style="font-size:24px; margin-left:28%; margin-top:10px; font-weight:bold" Text=""></asp:Label>
</asp:Content>
