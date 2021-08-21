﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.master" AutoEventWireup="true" CodeFile="disp_stu_sub.aspx.cs" Inherits="disp_stu_sub" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
        <div class="row" style="">
           <div class ="col-md-10 col-sm-10" style="padding-top:60px;padding-left:100px;padding-bottom:60px">
               <div class="panel panel-primary" style="border:1px solid ;background-color:aliceblue">
                   <div class="panel-heading" style="font-size:25px; height:50px;background-color:cadetblue;font-weight:bold">Student Info Display Panel</div>

                   <div class="panel-body">
                        <asp:Panel ID="Panel1" runat="server" Width="50%" >
                            <div class="panel-heading" style="font-size:20px; height:30px;background-color:azure;font-weight:600">Search Mode </div>
                           <div class="col-sm-10 col-md-10" style="padding:8px;font-weight:600">
                               <asp:Label ID="Label1" runat="server" Text="" ForeColor="red"></asp:Label></div>
                           <div class="col-sm-10 col-md-10" style="padding:8px;font-weight:600">Roll Number<asp:TextBox ID="TextBox1" runat="server" CssClass="form-control"></asp:TextBox></div>                 
                            <div class="col-sm-10 col-md-10" style="padding:8px;font-weight:600">Semester<asp:TextBox ID="TextBox2" runat="server" CssClass="form-control"></asp:TextBox></div>
                             <div class="col-sm-10 col-md-10" style="padding:10px;font-weight:600;text-align:center">
                           <asp:Button ID="Button1" runat="server" Text="Search" CssClass="btn btn-block btn-primary" OnClick="Button1_Click" />
                       </div>
                            </asp:Panel>
                       </div></div> </div> 
            <div class ="col-md-10 col-sm-10" style="padding-top:20px;padding-bottom:60px;padding-left:100px">
               <div class="panel panel-primary" style="border:1px solid ;background-color:aliceblue">
                   <div class="panel-heading" style="font-size:25px; height:40px;background-color:brown;font-weight:bold">Search Results</div>

                   <div class="panel-body">
                       
                       <asp:GridView ID="GridView1" runat="server" Width="100%" AutoGenerateColumns="False"  OnRowEditing="GridView1_RowEditing" CellPadding="4" ForeColor="#333333" GridLines="None">
                           <AlternatingRowStyle BackColor="White" />
                           <Columns>
                               <asp:BoundField DataField ="sub_id" HeaderText ="Stu-Sub ID" />
                               <asp:BoundField DataField ="ROLL_NO" HeaderText="Roll NO" />
                               <asp:BoundField DataField ="c_code" HeaderText ="Subject Code" />
                               <asp:BoundField DataField ="sem" HeaderText="Enrolled Semester" />
                               <asp:BoundField DataField ="session" HeaderText="Session" />
                               <asp:TemplateField>
                                   <ItemTemplate>
                                       <asp:LinkButton ID="LinkButton1" runat="server" CssClass="btn btn-primary" CommandName="edit">Edit</asp:LinkButton>
                                   </ItemTemplate>
                                   <EditItemTemplate>
                                       <asp:LinkButton ID="LinkButton2" runat="server" CssClass="btn btn-primary" OnClick="LinkButton2_Click">Update</asp:LinkButton>
                                       <asp:LinkButton ID="LinkButton3" runat="server" CssClass="btn btn-primary" OnClick="LinkButton3_Click">Cancel</asp:LinkButton>
                                   </EditItemTemplate>
                               </asp:TemplateField>
                               <asp:TemplateField>
                                   <ItemTemplate>
                                       <asp:LinkButton ID="LinkButton4" runat="server" CssClass="btn btn-danger" CommandArgument='<%#Eval("sub_id") %>' OnCommand="LinkButton4_Command">Delete</asp:LinkButton>
                                   </ItemTemplate>
                               </asp:TemplateField>

                           </Columns>
                           <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
                           <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
                           <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" />
                           <RowStyle BackColor="#FFFBD6" ForeColor="#333333" />
                           <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
                           <SortedAscendingCellStyle BackColor="#FDF5AC" />
                           <SortedAscendingHeaderStyle BackColor="#4D0000" />
                           <SortedDescendingCellStyle BackColor="#FCF6C0" />
                           <SortedDescendingHeaderStyle BackColor="#820000" />
                       </asp:GridView>
                       </div> </div> </div> </div> 
</asp:Content>

