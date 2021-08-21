<%@ Page Title="" Language="C#" MasterPageFile="~/Faculty.master" AutoEventWireup="true" CodeFile="Fdisp_dept.aspx.cs" Inherits="faculty_page_Fdisp_dept" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
     <div class ="col-md-8 col-sm-8" style="padding-top:60px;padding-bottom:60px;padding-left:100px">
               <div class="panel panel-primary" style="border:1px solid ;background-color:aliceblue">
                   <div class="panel-heading" style="font-size:25px; height:40px;background-color:brown;font-weight:bold">All Departments</div>

                   <div class="panel-body">
                       
                       <asp:GridView ID="GridView1" runat="server"    AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" Width="100%" >
                           <AlternatingRowStyle BackColor="White" />
                           <Columns>
                              
                               <asp:BoundField DataField="dept_code" HeaderText="Department Code" />
                               <asp:BoundField DataField="name" HeaderText="Department" />
                               <asp:BoundField DataField="hod_id" HeaderText ="Head OF Department ID" />
                               <asp:BoundField DataField="no_courses" HeaderText="Subjects Offered" /> 
                               
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
                       </div>
                   </div>
        </div>
</asp:Content>

