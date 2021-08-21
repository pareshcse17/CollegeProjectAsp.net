<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.master" AutoEventWireup="true" CodeFile="disp_fee_rec.aspx.cs" Inherits="fee_rec_disp" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    
                <div class="row" style="">
           <div class ="col-md-10 col-sm-10" style="padding-top:60px;padding-left:100px;padding-bottom:60px">
               <div class="panel panel-primary" style="border:1px solid ;background-color:aliceblue">
                   <div class="panel-heading" style="font-size:25px; height:50px;background-color:cadetblue;font-weight:bold">Student Info Display Panel</div>

                   <div class="panel-body">
                       <asp:Panel ID="Panel1" runat="server" Width="40%" >
                            <div class="panel-heading" style="font-size:20px; height:30px;background-color:azure;font-weight:600">Search Mode 1</div>
                           <div class="col-sm-10 col-md-10" style="padding:8px;font-weight:600">
                               <asp:Label ID="Label1" runat="server" Text="" ForeColor="red"></asp:Label></div>
                           <div class="col-sm-10 col-md-10" style="padding:8px;font-weight:600">Roll Number<asp:TextBox ID="TextBox1" runat="server" CssClass="form-control"></asp:TextBox></div>                 
                             <div class="col-sm-10 col-md-10" style="padding:10px;font-weight:600;text-align:center">
                           <asp:Button ID="Button1" runat="server" Text="Search" CssClass="btn btn-block btn-primary" OnClick="Button1_Click" />
                       </div>

                       </asp:Panel></div> <div class="panel-body">
                       <asp:Panel ID="Panel2" runat="server" Width="40%" >
                            <div class="panel-heading" style="font-size:20px; height:30px;background-color:azure;font-weight:600">Search Mode 2</div>
                            <div class="col-sm-10 col-md-10" style="padding:8px;font-weight:600">
                               <asp:Label ID="Label2" runat="server" Text="" ForeColor="red"></asp:Label></div>
                           <div class="col-sm-10 col-md-10" style="padding:8px;font-weight:600">Batch<asp:TextBox ID="TextBox2" runat="server" CssClass="form-control"></asp:TextBox></div>
                            <div class="col-sm-10 col-md-10" style="padding:8px;font-weight:600">Semester<asp:TextBox ID="TextBox3" runat="server" CssClass="form-control"></asp:TextBox></div>
                            <div class="col-sm-10 col-md-10" style="padding:10px;font-weight:600;text-align:center">
                           <asp:Button ID="Button2" runat="server" Text="Search" CssClass="btn btn-block btn-primary" OnClick="Button2_Click" />
                       </div>

                            </asp:Panel>
                       </div>
                   </div>
               </div>
                     <div class ="col-md-10 col-sm-10" style="padding-top:20px;padding-bottom:60px;padding-left:100px">
               <div class="panel panel-primary" style="border:1px solid ;background-color:aliceblue">
                   <div class="panel-heading" style="font-size:25px; height:40px;background-color:brown;font-weight:bold">Search Results</div>

                   <div class="panel-body">
                       <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" Width="100%" CellPadding="4" ForeColor="#333333" GridLines="None"  >
                           <AlternatingRowStyle BackColor="White" />
        <Columns>
            <asp:BoundField DataField="trans_no" HeaderText="Transaction no" />
            <asp:BoundField DataField="Roll_no" HeaderText="Roll No" />
            <asp:BoundField DataField="batch" HeaderText="batch" />
            <asp:BoundField DataField="sem" HeaderText="Semester" />
            <asp:BoundField DataField="Do_Payment" HeaderText="Date" />
            <asp:BoundField DataField ="amnt_paid" HeaderText="Amount Paid" />
            <asp:TemplateField>
                <ItemTemplate>
                    <asp:LinkButton ID="LinkButton2" runat="server" CssClass="btn btn-primary"  CommandArgument='<% #Eval("Trans_no") %>' OnCommand="LinkButton2_Command" >Edit</asp:LinkButton>
                </ItemTemplate>
                <EditItemTemplate>
                    <asp:LinkButton ID="LinkButton3" runat="server" CssClass="btn btn-primary"  CommandArgument='<% #Eval("Trans_no") %>' OnCommand="LinkButton3_Command">Update</asp:LinkButton>
                    <asp:LinkButton ID="LinkButton4" runat="server" CssClass="btn btn-primary"  CommandArgument='<% #Eval("Trans_no") %>' OnCommand="LinkButton4_Command">Cancel</asp:LinkButton>
                </EditItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField>
                <ItemTemplate>
                    <asp:LinkButton ID="LinkButton1" runat="server" Text="Delete" OnCommand="LinkButton1_Command" CssClass="btn btn-danger"  CommandArgument='<% #Eval("Trans_no") %>' />
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
                    </div>
     <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl=""><-back</asp:HyperLink>
    
    
</asp:Content>

