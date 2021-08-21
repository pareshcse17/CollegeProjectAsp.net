<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.master" AutoEventWireup="true" CodeFile="attendence.aspx.cs" Inherits="attendence" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
     <div class="row" style="">
           <div class ="col-md-10 col-sm-10" style="padding-top:60px;padding-left:100px;padding-bottom:60px">
               <div class="panel panel-primary" style="border:1px solid ;background-color:aliceblue">
                   <div class="panel-heading" style="font-size:25px; height:50px;background-color:cadetblue;font-weight:bold">Attendence Enter Panel</div>
                   <div class="panel-body">
                       <div class="col-md-10 col-sm-10" style="padding-top:10px; padding-bottom:10px; font-weight:600">
                           &nbsp;Subject Code<asp:DropDownList ID="DropDownList1" runat="server" CssClass="form-control"> </asp:DropDownList> 
                       </div>
                       <div class="col-md-10 col-sm-10" style="padding-top:10px; padding-bottom:10px; font-weight:600">Session
                           <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
                           <asp:TextBox ID="TextBox1" runat="server" ToolTip="yy-yy(17-18)" CssClass="form-control"></asp:TextBox></div>
                        <div class="col-sm-5 col-md-5" style="padding:10px;font-weight:600;text-align:left">
                           <asp:Button ID="Button1" runat="server" Text="Done" CssClass="btn btn-block btn-primary" OnClick="Button1_Click" /></div>
                       </div>
               </div> </div>
               <div class ="col-md-10 col-sm-10" style="padding-top:20px;padding-bottom:60px;padding-left:100px">
               <div class="panel panel-primary" style="border:1px solid ;background-color:aliceblue">
                   <div class="panel-heading" style="font-size:25px; height:40px;background-color:brown;font-weight:bold">Search Results</div>

                   <div class="panel-body">
                       <div class="col-md-10 col-sm-10" style="padding-top:10px; padding-bottom:10px; font-weight:500">Date  
                           <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox2" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
                           &nbsp;<asp:TextBox ID="TextBox2" runat="server" CssClass="form-control"  TextMode="Date" ></asp:TextBox>
                           <br />
                       <asp:GridView ID="GridView1" runat="server" Width="100%" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None">
                           <AlternatingRowStyle BackColor="White" />
                           <Columns>
                               <asp:BoundField DataField ="sub_id" HeaderText ="Stu-Sub ID" />
                               <asp:BoundField DataField ="ROLL_NO" HeaderText="Roll NO" />
                               <asp:BoundField DataField ="c_code" HeaderText ="Subject Code" />
                               <asp:BoundField DataField ="session" HeaderText="Session" />
                               
                               <asp:TemplateField>
                                   <ItemTemplate>
                                       <asp:LinkButton ID="Present" runat="server"  CommandArgument='<%# Container.DataItemIndex %>' OnCommand="Present_Command" >Present</asp:LinkButton>
                                   </ItemTemplate>
                               </asp:TemplateField>
                               <asp:TemplateField>
                                   <ItemTemplate>
                                       <asp:LinkButton ID="Absent" runat="server" CommandArgument='<%# Container.DataItemIndex %>' OnCommand="Absent_Command" ForeColor="Red">Absent</asp:LinkButton>
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
                       </div> </div> </div>
           </div>

     </div>               
                       
</asp:Content>

