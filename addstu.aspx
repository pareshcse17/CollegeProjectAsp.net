﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.master" AutoEventWireup="true" CodeFile="addstu.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server" >
   
       <div class="row" style="">
           <div class ="col-md-10 col-sm-10" style="padding-top:60px;padding-left:100px;padding-bottom:60px">
               <div class="panel panel-primary" style="border:1px solid ;background-color:aliceblue">
                   <div class="panel-heading" style="font-size:25px; height:50px;background-color:cadetblue;font-weight:bold">Student Info Enter Panel</div>
                   <div class="panel-body">
                       <div class="col-sm-8 col-md-8" style="padding:8px;font-weight:600">Roll Number
                           <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox1" ErrorMessage="*" ForeColor="Red" ToolTip="Mandatory field"></asp:RequiredFieldValidator>
                           <asp:TextBox ID="TextBox1" runat="server" CssClass="form-control"></asp:TextBox></div> 
                        <div class="col-sm-8 col-md-8" style="padding:8px;font-weight:600">Batch
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TextBox12" ErrorMessage="*" ForeColor="Red" ToolTip="Mandatory field"></asp:RequiredFieldValidator>
                            <asp:TextBox ID="TextBox12" runat="server" CssClass="form-control" ToolTip="yy-yy(17-18)*"></asp:TextBox></div>               
                       <div class="col-sm-8 col-md-8" style="padding:8px;font-weight:600">Name
                           <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="TextBox2" ErrorMessage="*" ForeColor="Red" ToolTip="Mandatory field"></asp:RequiredFieldValidator>
                           <asp:TextBox ID="TextBox2" runat="server" CssClass="form-control"></asp:TextBox></div>
                       <div class="col-sm-5 col-md-5" style="padding:8px;font-weight:600">DOB
                           <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="TextBox3" ErrorMessage="*" ForeColor="Red" ToolTip="Mandatory field"></asp:RequiredFieldValidator>
                           <asp:TextBox ID="TextBox3" runat="server" CssClass="form-control" TextMode="Date"></asp:TextBox></div>

                       <div class="col-sm-8 col-md-8" style="padding:8px;font-weight:600">Gender <asp:CheckBoxList ID="CheckBoxList1" runat="server" Height="20px" RepeatDirection="Horizontal" Width="421px" BorderStyle="None">
                           <asp:ListItem>Male</asp:ListItem>
                           <asp:ListItem>Female</asp:ListItem>
                           <asp:ListItem>Other</asp:ListItem>
                           </asp:CheckBoxList></div>      
                       <div class="col-sm-8 col-md-8" style="padding:8px;font-weight:600">Father's Name<asp:TextBox ID="TextBox4" runat="server" CssClass="form-control"></asp:TextBox></div>
                       <div class="col-sm-8 col-md-8" style="padding:8px;font-weight:600">Temporary Address&nbsp;
                           <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="TextBox5" ErrorMessage="*" ForeColor="Red" ToolTip="Mandatory field"></asp:RequiredFieldValidator>
                           <asp:TextBox ID="TextBox5" runat="server" CssClass="form-control" TextMode="MultiLine"></asp:TextBox></div>
                       <div class="col-sm-8 col-md-8" style="padding:8px;font-weight:600">Permanent Address
                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Button ID="Button2" runat="server" Text="Use address above" CssClass="btn btn-dark " OnClick="CheckBox1_CheckedChanged" CausesValidation="false" />
                           <asp:TextBox ID="TextBox6" runat="server" CssClass="form-control" TextMode="MultiLine"></asp:TextBox></div>
                       <div class="col-sm-5 col-md-5" style="padding:8px;font-weight:600">DoAdmission
                           <asp:RequiredFieldValidator ID="RequiredFieldValidator13" runat="server" ControlToValidate="TextBox7" ErrorMessage="*" ForeColor="Red" ToolTip="Mandatory field"></asp:RequiredFieldValidator>
&nbsp;<asp:TextBox ID="TextBox7" runat="server" CssClass="form-control" TextMode="Date"></asp:TextBox></div>
                       <div class="col-sm-5 col-md-5" style="padding:8px;font-weight:600">Current Semester<asp:TextBox ID="TextBox11" runat="server" CssClass="form-control" TextMode="SingleLine"></asp:TextBox></div>
                       
                       <div class="col-sm-8 col-md-8" style="padding:8px;font-weight:600">Mobile
                           <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ControlToValidate="TextBox8" ErrorMessage="*" ForeColor="Red" ToolTip="Mandatory field"></asp:RequiredFieldValidator>
                           <asp:TextBox ID="TextBox8" runat="server" CssClass="form-control" TextMode="Phone"></asp:TextBox></div>
                       <div class="col-sm-8 col-md-8" style="padding:8px;font-weight:600">E-Mail
                           <asp:TextBox ID="TextBox9" runat="server" CssClass="form-control" TextMode="Email"></asp:TextBox></div>
                       <div class="col-sm-5 col-md-5" style="padding:8px;font-weight:600">Category
                           <asp:RequiredFieldValidator ID="RequiredFieldValidator10" runat="server" ControlToValidate="DropDownList1" ErrorMessage="*" ForeColor="Red" ToolTip="Mandatory field"></asp:RequiredFieldValidator>
                           <asp:DropDownList ID="DropDownList1" runat="server" CssClass="form-control">
                           <asp:ListItem>GEN</asp:ListItem>
                           <asp:ListItem>SC</asp:ListItem>
                           <asp:ListItem>ST</asp:ListItem>
                           <asp:ListItem>Other</asp:ListItem>
                           </asp:DropDownList>
                       </div>   
                       <div class="col-sm-5 col-md-5" style="padding:8px;font-weight:600">Department Code
                           <asp:RequiredFieldValidator ID="RequiredFieldValidator11" runat="server" ControlToValidate="DropDownList2" ErrorMessage="*" ForeColor="Red" ToolTip="Mandatory field"></asp:RequiredFieldValidator>
                           <asp:DropDownList ID="DropDownList2" runat="server" CssClass="form-control">
                           </asp:DropDownList>
                       </div> 
                       <div class="col-sm-8 col-md-8" style="padding:8px;font-weight:600">Faculty Advisor ID
                           <asp:RequiredFieldValidator ID="RequiredFieldValidator12" runat="server" ControlToValidate="TextBox10" ErrorMessage="*" ForeColor="Red" ToolTip="Mandatory field"></asp:RequiredFieldValidator>
                           <asp:TextBox ID="TextBox10" runat="server" CssClass="form-control"></asp:TextBox></div>
                       <div class="col-sm-8 col-md-8" style="padding:8px;font-weight:600">
                           <asp:FileUpload ID="FileUpload1" runat="server" CssClass="form-control" />
                       </div>
                       <div class="col-sm-8 col-md-8" style="padding:10px;font-weight:600;text-align:center">
                           <asp:Button ID="Button1" runat="server" Text="Add" CssClass="btn btn-primary btn-block" OnClick="Button1_Click" /></div>
                       </div>
               </div>
           </div>

     </div>
        
</asp:Content>

