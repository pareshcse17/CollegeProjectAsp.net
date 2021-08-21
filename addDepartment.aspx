﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.master" AutoEventWireup="true" CodeFile="addDepartment.aspx.cs" Inherits="addDepartment" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="row" style="">
        <div class="col-md-10 col-sm-10" style="padding-top:60px; padding-left:100px;padding-bottom:60px">
             <div class="panel panel-primary" style="border:1px solid;background-color:aliceblue">
             <div class="panel-heading" style="font-size:25px; height:50px;background-color:cadetblue;font-weight:bold">Department Add panel</div>
             <div class="panel-body">
                 <div class="col-sm-8 col-md-8" style="padding:8px;font-weight:600">Department Code
                     <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox1" ErrorMessage="*" ForeColor="Red" ToolTip="Mandatory field"></asp:RequiredFieldValidator>
&nbsp;<asp:TextBox ID="TextBox1" runat="server" CssClass="form-control"></asp:TextBox></div>                 
                 <div class="col-sm-8 col-md-8" style="padding:8px;font-weight:600">Department Name
                     <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TextBox2" ErrorMessage="*" ForeColor="Red" ToolTip="Mandatory field"></asp:RequiredFieldValidator>
                     <asp:TextBox ID="TextBox2" runat="server" CssClass="form-control"></asp:TextBox></div>                 
                 <div class="col-sm-8 col-md-8" style="padding:8px;font-weight:600">HOD FAC_ID<asp:TextBox ID="TextBox3" runat="server" CssClass="form-control"></asp:TextBox></div>     
                 <div class="col-sm-8 col-md-8" style="padding:8px;font-weight:600">No of Subjects <asp:TextBox ID="TextBox4" runat="server" CssClass="form-control"></asp:TextBox></div>                             
                 <div class="col-sm-8 col-md-8" style="padding:10px;font-weight:600;text-align:center">
                           <asp:Button ID="Button1" runat="server" Text="Add" CssClass="btn btn-primary btn-block" OnClick="Button1_Click" /></div>
                       </div>
             </div>
        </div>
        </div>
       
    </div>
</asp:Content>

