<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.master" AutoEventWireup="true" CodeFile="add_assessment.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
     <div class="row" style="">
           <div class ="col-md-10 col-sm-10" style="padding-top:60px;padding-left:100px;padding-bottom:60px">
               <div class="panel panel-primary" style="border:1px solid ;background-color:aliceblue">
                   <div class="panel-heading" style="font-size:25px; height:50px;background-color:cadetblue;font-weight:bold">Subject Assessment Enter Panel</div>
                   <div class="panel-body">
                        <div class="col-sm-8 col-md-8" style="padding:8px;font-weight:600">Stu-Sub ID
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox1" ErrorMessage="*" ForeColor="Red" ToolTip="Mandatory field"></asp:RequiredFieldValidator>
                            <asp:TextBox ID="TextBox1" runat="server" CssClass="form-control" ToolTip="RN:SEM,N:SUB,N e.g.BT17CSE016:S1:01"></asp:TextBox></div>                 
                        <div class="col-sm-5 col-md-5" style="padding:8px;font-weight:600">Sessional 1<asp:TextBox ID="TextBox2" runat="server" CssClass="form-control" TextMode="SingleLine" ToolTip="Max. marks 20"></asp:TextBox></div>
                        <div class="col-sm-5 col-md-5" style="padding:8px;font-weight:600">Sessional 2<asp:TextBox ID="TextBox7" runat="server" CssClass="form-control" TextMode="SingleLine" ToolTip="Max. marks 20"></asp:TextBox></div>
                       <div class="col-sm-5 col-md-5" style="padding:8px;font-weight:600">Other<asp:TextBox ID="TextBox3" runat="server" CssClass="form-control" TextMode="SingleLine" ToolTip="Max. marks 20"></asp:TextBox></div>
                       <div class="col-sm-5 col-md-5" style="padding:8px;font-weight:600">End Semester<asp:TextBox ID="TextBox5" runat="server" CssClass="form-control" TextMode="SingleLine" ToolTip="Max. marks 40"></asp:TextBox></div>
                       <div class="col-sm-5 col-md-5" style="padding:8px;font-weight:600">End Semester<asp:TextBox ID="TextBox8" runat="server" CssClass="form-control" TextMode="SingleLine" ToolTip="Max. marks 100"></asp:TextBox></div>
                       
                       <div class="col-sm-5 col-md-5" style="padding:8px;font-weight:600">Total Attendence<asp:TextBox ID="TextBox4" runat="server" CssClass="form-control" TextMode="SingleLine"></asp:TextBox></div>
                       <div class="col-sm-5 col-md-5" style="padding:8px;font-weight:600">Grade Point<asp:TextBox ID="TextBox6" runat="server" CssClass="form-control" TextMode="SingleLine"></asp:TextBox></div>
                       <div class="col-sm-8 col-md-8" style="padding:10px;font-weight:600;text-align:center">
                           <asp:Button ID="Button1" runat="server" Text="Add" CssClass="btn btn-primary btn-block" OnClick="Button1_Click" /></div>
                   </div>                                   
               </div>
            </div>
         </div>        
</asp:Content>

