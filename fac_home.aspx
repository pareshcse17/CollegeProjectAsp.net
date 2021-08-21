<%@ Page Title="" Language="C#" MasterPageFile="~/Faculty.master" AutoEventWireup="true" CodeFile="fac_home.aspx.cs" Inherits="AdminHome" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <link href="bootstrap.min.css" rel="stylesheet" />

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
   <div class="card bg-dark text-white" style="width:90%; top: 1px; left: 58px; font-size:35px;font-weight:bold; padding-top:10px;padding-bottom:10px">
       <div class="card-header"> Your Profile
       </div>
       <div class="card-body bg-light text-dark">

           <div class="col-md-12">
                                <img alt="image" class="img-responsive" src='<%=getPath()%>' style="display: block;background-size: cover;height: 100px; background-repeat: no-repeat; background-position: center center; margin-left:-13px; width: 100px; margin-right: auto; margin-top: 0; margin-bottom: 0;"/>
                            </div>
           <div class="col-sm-8 col-md-8" style="padding:8px;font-weight:600">Faculty ID
                        <asp:TextBox ID="TextBox1" runat="server" ReadOnly="true" CssClass="form-control"></asp:TextBox></div>
       
       <div class="col-sm-8 col-md-8" style="padding:8px;font-weight:600">Name
                        <asp:TextBox ID="TextBox2" runat="server" ReadOnly="true" CssClass="form-control"></asp:TextBox></div>
       
    <div class="col-sm-8 col-md-8" style="padding:8px;font-weight:600">Email
                        <asp:TextBox ID="TextBox3" runat="server" ReadOnly="true" CssClass="form-control"></asp:TextBox></div>
       
    <div class="col-sm-8 col-md-8" style="padding:8px;font-weight:600">Phone
                        <asp:TextBox ID="TextBox4" runat="server" ReadOnly="true" CssClass="form-control"></asp:TextBox></div>
       
    <div class="col-sm-8 col-md-8" style="padding:8px;font-weight:600">DoBirth
                        <asp:TextBox ID="TextBox5" runat="server" ReadOnly="true" CssClass="form-control"></asp:TextBox></div>
      
       <div class="col-sm-8 col-md-8" style="padding:8px;font-weight:600">Permanent Address
                        <asp:TextBox ID="TextBox6" runat="server" ReadOnly="true" CssClass="form-control"></asp:TextBox></div>
      
    <div class="col-sm-8 col-md-8" style="padding:8px;font-weight:600">Department Code
                        <asp:TextBox ID="TextBox7" runat="server" ReadOnly="true" CssClass="form-control"></asp:TextBox></div>
        </div>

   </div>
    
</asp:Content>
