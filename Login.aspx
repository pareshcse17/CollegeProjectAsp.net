<%@ Page Title="" Language="C#" MasterPageFile="~/MainMP.master" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
     <div class="row" style="">
           <div class ="col-md-8 col-sm-8" style="padding-top:60px;padding-left:100px;padding-bottom:60px">
               <div class="panel panel-primary" style="border:1px solid;background-color:aliceblue">
                   <div class="panel-heading" style="font-size:25px; height:50px;background-color:cadetblue; font-weight:bold">Login Panel</div>
                   <div class="panel-body">
                       <div class="col-sm-8 col-md-8" style="padding:8px;font-weight:600">
                           <asp:CheckBox ID="CheckBox1" runat="server" Text="login as admin"/>  </div>
                       <div class="col-sm-8 col-md-8" style="padding:8px;font-weight:600">Faculty/Admin ID
                           <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox1" ErrorMessage="*" ForeColor="Red" ToolTip="Mandatory field"></asp:RequiredFieldValidator>
                           <asp:TextBox ID="TextBox1" runat="server" CssClass="form-control"></asp:TextBox></div>                 
                       <div class="col-sm-8 col-md-8" style="padding:8px;font-weight:600"> Password
                           <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TextBox2" ErrorMessage="*" ForeColor="Red" ToolTip="Mandatory field"></asp:RequiredFieldValidator>
                           <asp:TextBox ID="TextBox2" runat="server" CssClass="form-control" TextMode="Password"></asp:TextBox></div> 
                       <div class="col-md-8 col-sm-8"style="padding:8px;font-weight:600"> <asp:Label ID="Label2" runat="server" Text="" ForeColor="Red"></asp:Label></div>
                       <div class="col-sm-8 col-md-8" style="padding:10px;font-weight:600;text-align:center">
                           
                           <asp:Button ID="Button1" runat="server" Text="Login" CssClass="btn btn-block btn-primary" OnClick="Button1_Click" /></div>
                       </div>
                   </div>
               &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
               <asp:HyperLink ID="HyperLink1" runat="server" ForeColor="blue" NavigateUrl="~/Register_fac.aspx">Not Registered yet!</asp:HyperLink>
               &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
               <asp:HyperLink ID="HyperLink2" runat="server" ForeColor="blue" NavigateUrl="~/forgot_pass.aspx">Forgot Password!</asp:HyperLink>
                   </div>
               </div>
</asp:Content>

