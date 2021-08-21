<%@ Page Title="" Language="C#" MasterPageFile="~/MainMP.master" AutoEventWireup="true" CodeFile="forgot_pass.aspx.cs" Inherits="forgot_pass" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
     <div class="row" style="">
           <div class ="col-md-8 col-sm-8" style="padding-top:60px;padding-left:100px;padding-bottom:60px">
               <div class="panel panel-primary" style="border:1px solid;background-color:aliceblue">
                   <div class="panel-heading" style="font-size:25px; height:50px;background-color:cadetblue; font-weight:bold">Register Panel</div>
                   <div class="panel-body">
                       <div class="col-sm-8 col-md-8" style="padding:8px;font-weight:600">Faculty ID <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox1" ErrorMessage="*" ForeColor="Red" ToolTip="Mandatory field"></asp:RequiredFieldValidator>
                           <asp:TextBox ID="TextBox1" runat="server" CssClass="form-control"></asp:TextBox></div>  
                       <div class="col-sm-8 col-md-8" style="padding:8px;font-weight:600">Mobile no <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox2" ErrorMessage="*" ForeColor="Red" ToolTip="Mandatory field"></asp:RequiredFieldValidator>
                           <asp:TextBox ID="TextBox2" runat="server" CssClass="form-control" TextMode="SingleLine" ToolTip="Registered Mobile no"></asp:TextBox></div>
                       <div class="col-sm-8 col-md-8" style="padding:8px;font-weight:600">DoJoining <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TextBox3" ErrorMessage="*" ForeColor="Red" ToolTip="Mandatory field"></asp:RequiredFieldValidator>
                           <asp:TextBox ID="TextBox3" runat="server" CssClass="form-control" TextMode="Date"></asp:TextBox></div>
                       <div class="col-sm-8 col-md-8" style="padding:8px;font-weight:600">New Password 
                           <asp:TextBox ID="TextBox4" runat="server" CssClass="form-control" TextMode="Password"></asp:TextBox></div>
                       <div class="col-sm-8 col-md-8" style="padding:8px;font-weight:600">Confirm New Password 
                           <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="TextBox4" ControlToValidate="TextBox5" ErrorMessage="Enter same password" ForeColor="Red"></asp:CompareValidator>
                           <asp:TextBox ID="TextBox5" runat="server" CssClass="form-control" TextMode="Password"></asp:TextBox></div>
                       <div class="col-md-8 col-sm-8"style="padding:8px;font-weight:600"> <asp:Label ID="Label2" runat="server" Text="" ForeColor="Red"></asp:Label></div>
                       <div class="col-sm-8 col-md-8" style="padding:10px;font-weight:600;text-align:center">
                           
                           <asp:Button ID="Button1" runat="server" Text="SignUP" CssClass="btn btn-block btn-primary" OnClick="Button1_Click" /></div>
                       </div>
                   </div> 
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
               <asp:HyperLink ID="HyperLink1" runat="server" ForeColor="blue" NavigateUrl="~/Login.aspx">Login Panel</asp:HyperLink>
           </div> </div> 
</asp:Content>

