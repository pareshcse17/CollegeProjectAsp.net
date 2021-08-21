<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.master" AutoEventWireup="true" CodeFile="add_teaches.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="row" style="">
           <div class ="col-md-8 col-sm-8" style="padding-top:60px;padding-left:100px;padding-bottom:60px">
               <div class="panel panel-primary" style="border:1px solid ;background-color:aliceblue">
                   <div class="panel-heading" style="font-size:25px; height:50px;background-color:cadetblue;font-weight:bold">Faculty-Subject Enter Panel</div>
                   <div class="panel-body">
                       <div class="col-sm-5 col-md-5" style="padding:8px;font-weight:600">Faculty ID
                           <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox1" ErrorMessage="*" ForeColor="Red" ToolTip="Mandatory field"></asp:RequiredFieldValidator>
                           <asp:TextBox ID="TextBox1" runat="server" CssClass="form-control"></asp:TextBox></div>                 
                       <div class="col-sm-5 col-md-5" style="padding:8px;font-weight:600"> Subject Code<asp:DropDownList ID="DropDownList1" runat="server" CssClass="form-control">
                           </asp:DropDownList></div> 
                       <div class="col-sm-5 col-md-5" style="padding:10px;font-weight:600;text-align:center">
                           <asp:Button ID="Button1" runat="server" Text="Add" CssClass="btn btn-primary btn-block" OnClick="Button1_Click" /></div>
                       </div>
                       </div>
                   </div>
               </div>
       
</asp:Content>

