<%@ Page Title="" Language="C#" MasterPageFile="~/Faculty.master" AutoEventWireup="true" CodeFile="Fdisp_teaches.aspx.cs" Inherits="faculty_page_Fdisp_teaches" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
        <div class="row" style="">
           <div class ="col-md-10 col-sm-10" style="padding-top:60px;padding-left:100px;padding-bottom:60px">
               <div class="panel panel-primary" style="border:1px solid ;background-color:aliceblue">
                   <div class="panel-heading" style="font-size:25px; height:50px;background-color:cadetblue;font-weight:bold">Faculty-Courses Display Panel</div>

                   <div class="panel-body">
                       <asp:Panel ID="Panel1" runat="server" Width="40%" >
                            <div class="panel-heading" style="font-size:20px; height:30px;background-color:azure;font-weight:600">Search Mode</div>
                           <div class="col-sm-10 col-md-10" style="padding:8px;font-weight:600">
                               <asp:Label ID="Label1" runat="server" Text="" ForeColor="red"></asp:Label></div>
                           <div class="col-sm-10 col-md-10" style="padding:8px;font-weight:600">Faculty ID<asp:TextBox ID="TextBox1" runat="server" CssClass="form-control"></asp:TextBox></div>                 
                             <div class="col-sm-10 col-md-10" style="padding:10px;font-weight:600;text-align:center">
                           <asp:Button ID="Button1" runat="server" Text="Search" CssClass="btn btn-block btn-primary" OnClick="Button1_Click" />
                       </div>

                       </asp:Panel>

                       </div>
                   </div>
               </div>
                     <div class ="col-md-5 col-sm-5" style="padding-top:20px;padding-bottom:60px;padding-left :100px">
               <div class="panel panel-primary" style="border:1px solid ;background-color:aliceblue">
                   <div class="panel-heading" style="font-size:25px; height:40px;background-color:brown;font-weight:bold">Search Results</div>

                   <div class="panel-body">
                       <asp:GridView ID="GridView1" runat="server" Width="100%" AutoGenerateColumns="False"  CellPadding="4" ForeColor="#333333" GridLines="None">
                           <AlternatingRowStyle BackColor="White" />
                           <Columns>
                               <asp:BoundField DataField ="fac_id" HeaderText="Faculty ID" />
                               <asp:BoundField DataField ="C_CODE" HeaderText="Subject Code" />
                               
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

