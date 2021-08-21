<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.master" AutoEventWireup="true" CodeFile="disp_fee_resp.aspx.cs" Inherits="fee_resp_disp" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" Width="550px" >
        <Columns>
            <asp:BoundField DataField="trans_no" HeaderText="Transaction no" />
            <asp:BoundField DataField="Roll_no" HeaderText="Roll No" />
            <asp:BoundField DataField="batch" HeaderText="batch" />
            <asp:BoundField DataField="sem" HeaderText="Semester" />
            <asp:BoundField DataField="Do_Payment" HeaderText="Date" />
            <asp:BoundField DataField ="amnt_paid" HeaderText="Amount Paid" />
        </Columns>
    </asp:GridView>
    <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/add_Fee_collection.aspx"><-back</asp:HyperLink>
</asp:Content>

