<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.master" AutoEventWireup="true" CodeFile="disp_fee_tot.aspx.cs" Inherits="disp_fee_tot" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <div class ="col-md-8 col-sm-8" style="padding-top:60px;padding-bottom:60px;padding-left:100px">
               <div class="panel panel-primary" style="border:1px solid ;background-color:aliceblue">
                   <div class="panel-heading" style="font-size:25px; height:40px;background-color:brown;font-weight:bold">Fee Structure</div>

                   <div class="panel-body">
                       
                       <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" Width="100%" OnRowEditing="GridView1_RowEditing">
                           <AlternatingRowStyle BackColor="White" />
                           <Columns>
                               <asp:BoundField DataField="sem" HeaderText="Semester" />
                               <asp:BoundField DataField ="tution" HeaderText="Tution Fee" />
                               <asp:BoundField DataField ="messhostel" HeaderText ="Hostel & Mess" />
                               <asp:BoundField DataField="other" HeaderText="Other Charges" /> 
                               <asp:TemplateField>
                                   <ItemTemplate>
                                       <asp:LinkButton ID="LinkButton2" runat="server" CssClass="btn btn-primary" CommandName="Edit" >Edit</asp:LinkButton>
                                   </ItemTemplate>
                                   <EditItemTemplate>
                                       <asp:LinkButton ID="LinkButton3" runat="server" CssClass="btn btn-primary" OnClick="LinkButton3_Click">Update</asp:LinkButton> 
                                       <asp:LinkButton ID="LinkButton4" runat="server" CssClass="btn btn-primary" OnClick="LinkButton4_Click">Cancel</asp:LinkButton>
                                   </EditItemTemplate>
                               </asp:TemplateField>
                               <asp:TemplateField>
                <ItemTemplate>
                    <asp:LinkButton ID="LinkButton1" runat="server" Text="Delete" CssClass="btn btn-danger" OnCommand="LinkButton1_Command" CommandArgument='<% #Eval("sem") %>' />
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
                       </div>
                   </div>
        </div>
    
</asp:Content>

