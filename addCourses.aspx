<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.master" AutoEventWireup="true" CodeFile="addCourses.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="row" style="">
           <div class ="col-md-10 col-sm-10" style="padding-top:60px;padding-left:100px;padding-bottom:60px">
               <div class="panel panel-primary" style="border:1px solid ;background-color:aliceblue">
                   <div class="panel-heading" style="font-size:25px; height:50px;background-color:cadetblue;font-weight:bold">Subject Add Panel</div>
                   <div class="panel-body">
                       <div class="col-sm-5 col-md-5" style="padding:8px;font-weight:600">Department Code
                           <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="DropDownList2" ErrorMessage="*" ForeColor="Red" ToolTip="Mandatory field"></asp:RequiredFieldValidator>
                           <asp:DropDownList ID="DropDownList2" runat="server" CssClass="form-control">
                           </asp:DropDownList>
                       </div>
                       <div class="col-sm-5 col-md-5" style="padding:8px;font-weight:600">Subject Code
                           <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox1" ErrorMessage="*" ForeColor="Red" ToolTip="Mandatory field"></asp:RequiredFieldValidator>
&nbsp;<asp:TextBox ID="TextBox1" runat="server" CssClass="form-control"></asp:TextBox></div>                 
                         
                       <div class="col-sm-8 col-md-8" style="padding:8px;font-weight:600">Title
                           <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TextBox2" ErrorMessage="*" ForeColor="Red" ToolTip="Mandatory field"></asp:RequiredFieldValidator>
&nbsp;<asp:TextBox ID="TextBox2" runat="server" CssClass="form-control"></asp:TextBox></div>
                       <div class="col-sm-5 col-md-5" style="padding:8px;font-weight:600">Subject Credits<asp:TextBox ID="TextBox3" runat="server" CssClass="form-control"></asp:TextBox></div>                 
                       <div class="col-sm-5 col-md-5" style="padding:8px;font-weight:600">Subject Classes/w<asp:TextBox ID="TextBox4" runat="server" CssClass="form-control"></asp:TextBox></div>                 
                       <div class="col-sm-5 col-md-5" style="padding:8px;font-weight:600">Subject Labs/w<asp:TextBox ID="TextBox5" runat="server" CssClass="form-control"></asp:TextBox></div> 
                       <div class="col-sm-5 col-md-5" style="padding:8px;font-weight:600">Semesters allowed<asp:DropDownList ID="DropDownList1" runat="server" CssClass="form-control">
                           <asp:ListItem>Odd</asp:ListItem>
                           <asp:ListItem>Even</asp:ListItem>
                           <asp:ListItem>Any</asp:ListItem>
                           </asp:DropDownList></div>
                       <div class="col-sm-5 col-md-5" style="padding:8px;font-weight:600">
                           <asp:CheckBox ID="CheckBox1" runat="server" ToolTip="if course is core. CHECK" Text="Core" />   </div>
                       <div class="col-sm-8 col-md-8" style="padding:8px;font-weight:600">Description<asp:TextBox ID="TextBox7" runat="server" CssClass="form-control" TextMode="MultiLine" ></asp:TextBox></div>                                               
                       <div class="col-sm-8 col-md-8" style="padding:10px;font-weight:600;text-align:center">
                           <asp:Button ID="Button1" runat="server" Text="Add" CssClass="btn btn-primary btn-block" OnClick="Button1_Click" /></div>
                       </div>
                   </div>    
               </div>

           </div>
    </div>  
</asp:Content>

