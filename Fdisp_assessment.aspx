<%@ Page Title="" Language="C#" MasterPageFile="~/Faculty.master" AutoEventWireup="true" CodeFile="Fdisp_assessment.aspx.cs" Inherits="faculty_page_Fdisp_assessment" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
      <div class="row" style="">
           <div class ="col-md-10 col-sm-10" style="padding-top:60px;padding-left:100px;padding-bottom:60px">
               <div class="panel panel-primary" style="border:1px solid ;background-color:aliceblue">
                   <div class="panel-heading" style="font-size:25px; height:50px;background-color:cadetblue;font-weight:bold">Subject Assessment Display Panel</div>

                   <div class="panel-body">
                      
                            <asp:Panel ID="Panel2" runat="server" Width="40%" >
                            <div class="panel-heading" style="font-size:20px; height:30px;background-color:azure;font-weight:600">Search Mode</div>
                           <div class="col-sm-10 col-md-10" style="padding:8px;font-weight:600">
                               <asp:Label ID="Label2" runat="server" Text="" ForeColor="red"></asp:Label></div>
                           <div class="col-sm-10 col-md-10" style="padding:8px;font-weight:600"> Subject Code<asp:DropDownList ID="DropDownList1" runat="server" CssClass="form-control"></asp:DropDownList></div>
                              <div class="col-sm-10 col-md-10" style="padding:8px;font-weight:600">Session<asp:TextBox ID="TextBox2" runat="server" CssClass="form-control"></asp:TextBox></div>                 
                       
                             <div class="col-sm-10 col-md-10" style="padding:10px;font-weight:600;text-align:center">
                           <asp:Button ID="Button2" runat="server" Text="Search" CssClass="btn btn-block btn-primary" OnClick="Button2_Click" />
                       </div>

                       </asp:Panel>
                        </div>
                   </div>
               </div>
                     <div class ="col-md-11 col-sm-11" style="padding-top:20px;padding-bottom:60px;padding-left :100px">
               <div class="panel panel-primary" style="border:1px solid ;background-color:aliceblue">
                   <div class="panel-heading" style="font-size:25px; height:40px;background-color:brown;font-weight:bold">Search Results</div>

                   <div class="panel-body">
                       <asp:GridView ID="GridView1" runat="server" Width="100%" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None">
                           <AlternatingRowStyle BackColor="White" />
                           <Columns>
                               <asp:BoundField DataField ="sub_id" HeaderText="Subject ID" />
                               <asp:BoundField DataField ="S1" HeaderText ="Sessional 1(20)" />
                               <asp:BoundField DataField ="S2" HeaderText ="Sessional 2(20)" />
                               <asp:BoundField DataField ="ends" HeaderText ="End Semester(40)" />
                               <asp:BoundField DataField ="other" HeaderText ="Other(20)" />
                               <asp:BoundField DataField ="attend" HeaderText ="Total Attendence" />
                               <asp:BoundField DataField ="totalm" HeaderText ="Total Marks" />
                               <asp:BoundField DataField ="gradep" HeaderText ="Grade Point" />
                               <asp:TemplateField>
                                   <ItemTemplate>
                                       <asp:LinkButton ID="LinkButton2" runat="server" CommandName="Edit" CssClass="btn btn-primary" OnCommand="LinkButton2_Command" CommandArgument='<%#Eval("sub_id") %>'>Edit</asp:LinkButton>
                                   </ItemTemplate>
                                   <EditItemTemplate>
                                       <asp:LinkButton ID="LinkButton3" runat="server"  CommandArgument='<%#Eval("sub_id") %>' OnCommand="LinkButton3_Command" CssClass="btn btn-primary">Update</asp:LinkButton>
                                       <asp:LinkButton ID="LinkButton4" runat="server" CommandArgument='<%#Eval("sub_id") %>' OnCommand="LinkButton4_Command" CssClass ="btn btn-primary">Cancel</asp:LinkButton>
                                   </EditItemTemplate>
                               </asp:TemplateField>
                                <asp:TemplateField>
                                   <ItemTemplate>
                                       <asp:LinkButton ID="LinkButton1" runat="server" Text="Delete"  OnCommand="LinkButton1_Command" CssClass="btn btn-danger" CommandArgument='<% #Eval("sub_id") %>' OnClientClick='return Confirm("Are you sure you want to delete")'/>
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

