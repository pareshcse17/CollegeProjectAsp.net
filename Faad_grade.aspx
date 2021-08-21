<%@ Page Title="" Language="C#" MasterPageFile="~/Faculty.master" AutoEventWireup="true" CodeFile="Faad_grade.aspx.cs" Inherits="faculty_page_Faad_grade" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="row" style="">
         <div class="col-sm-8 col-md-8" style="padding-top:10px;padding-bottom:10px;font-weight:600;text-align:center">Batch
                           <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox6" ErrorMessage="*" ForeColor="Red" ToolTip="Mandatory field"></asp:RequiredFieldValidator>
&nbsp;<asp:TextBox ID="TextBox6" runat="server" CssClass=""></asp:TextBox>&nbsp;&nbsp; <asp:Button ID="Button2" runat="server" Text="Go" CausesValidation="false" CssClass="btn btn-primary" OnClick="Button2_Click"/></div>        
           <div class ="col-md-10 col-sm-10" style="padding-top:60px;padding-left:100px;padding-bottom:60px">
               <div class="panel panel-primary" style="border:1px solid ;background-color:aliceblue">
                   <div class="panel-heading" style="font-size:25px; height:50px;background-color:cadetblue;font-weight:bold">Student Grade Enter Panel</div>
                   <div class="panel-body">
                       <div class="col-sm-8 col-md-8" style="padding:8px;font-weight:600">Roll Number
                           <asp:DropDownList ID="DropDownList1" runat="server" CssClass="form-control"></asp:DropDownList></div>                 
                       <div class="col-sm-5 col-md-5" style="padding:8px;font-weight:600"> Semester
                           <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="DropDownList3" ErrorMessage="*" ForeColor="Red" ToolTip="Mandatory field"></asp:RequiredFieldValidator>
&nbsp;<asp:DropDownList ID="DropDownList3" runat="server" CssClass="form-control">
                        <asp:ListItem>1</asp:ListItem>
                        <asp:ListItem>2</asp:ListItem>
                        <asp:ListItem>3</asp:ListItem>
                        <asp:ListItem>4</asp:ListItem>
                        <asp:ListItem>5</asp:ListItem>
                        <asp:ListItem>6</asp:ListItem>
                        <asp:ListItem>7</asp:ListItem>
                        <asp:ListItem>8</asp:ListItem>
                        <asp:ListItem>9</asp:ListItem>
                        <asp:ListItem>10</asp:ListItem>
                        <asp:ListItem>11</asp:ListItem>
                        <asp:ListItem>12</asp:ListItem>
                           </asp:DropDownList>&nbsp &nbsp</div> 
                       <div class="col-sm-8 col-md-8" style="padding:8px;font-weight:600">All Stu-Sub ID<asp:TextBox ID="TextBox2" runat="server" CssClass="form-control" TextMode="MultiLine" ToolTip="subID1,subID2....."></asp:TextBox></div>                 
                        <div class="col-sm-8 col-md-8" style="padding:8px;font-weight:600">Total Credits
                           <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="TextBox5" ErrorMessage="*" ForeColor="Red" ToolTip="Mandatory field"></asp:RequiredFieldValidator>
&nbsp;<asp:TextBox ID="TextBox5" runat="server" CssClass="form-control"></asp:TextBox></div>  
                       <div class="col-sm-8 col-md-8" style="padding:8px;font-weight:600">CGPA
                           <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="TextBox3" ErrorMessage="*" ForeColor="Red" ToolTip="Mandatory field"></asp:RequiredFieldValidator>
                           <asp:TextBox ID="TextBox3" runat="server" CssClass="form-control"></asp:TextBox></div>                 
                       <div class="col-sm-8 col-md-8" style="padding:8px;font-weight:600">SGPA<asp:TextBox ID="TextBox4" runat="server" CssClass="form-control"></asp:TextBox></div>                 
                        
                    <div class="col-sm-8 col-md-8" style="padding:10px;font-weight:600;text-align:center">
                           <asp:Button ID="Button1" runat="server" Text="Add" CssClass="btn btn-primary btn-block" OnClick="Button1_Click" /></div>
                       </div>
                    </div>

                </div>
            </div>
</asp:Content>

