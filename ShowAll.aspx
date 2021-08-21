<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.master" AutoEventWireup="true" CodeFile="ShowAll.aspx.cs" Inherits="hello" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
     <div class="row" style="">
           <div class ="col-md-10 col-sm-10" style="padding-top:60px;padding-left:100px;padding-bottom:20px">
               <div class="panel panel-primary" style="border:1px solid ;background-color:aliceblue">
                   <div class="panel-heading" style="font-size:25px; height:50px;background-color:#6699FF; font-weight:bold">Select Category</div>

                   <div class="panel-body">
                       <div class="col-sm-10 col-md-10" style="padding:8px;font-weight:600">
                       <asp:DropDownList ID="DropDownList1" runat="server" CssClass="form-control">
                           <asp:ListItem Text="Student" Value="1"></asp:ListItem>
                           <asp:ListItem Text="Subject" Value="2"></asp:ListItem>
                           <asp:ListItem Text="Department" Value="3"></asp:ListItem>
                           <asp:ListItem Text="Faculty" Value="10"></asp:ListItem>
                           <asp:ListItem Text="Student Subjects" Value="4"></asp:ListItem>
                           <asp:ListItem Text="Faculty-Subjects" Value="5"></asp:ListItem>
                           <asp:ListItem Text="Subject Assessment" Value="6"></asp:ListItem>
                           <asp:ListItem Text="Grade Assessment" Value="7"></asp:ListItem>
                           <asp:ListItem Text="Fee Response" Value="8"></asp:ListItem>
                           <asp:ListItem Text="Fee Structure" Value="9"></asp:ListItem>
                          
                       </asp:DropDownList>
                           <div class="col-md-10 col-sm-10" style="padding:8px; text-align:center">
                           <asp:Button ID="Button1" runat="server" Text="Show data" OnClick="Button1_Click" CssClass="btn btn-block btn-primary"/>
                           </div></div>
                       </div> </div> </div>
         <div class ="col-md-12 col-sm-12" style=";padding-left:100px;padding-bottom:60px">
               <div class="panel panel-primary" style="border:1px solid ;background-color:aliceblue">
                   <div class="panel-heading" style="font-size:25px; height:50px;background-color:#6666FF; font-weight:bold">Record File</div>
                   <div class="panel-body">
                       <asp:GridView ID="GridView1" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" AutoGenerateColumns="false" Visible="false" Width="100%">
                           <Columns>
                               <asp:BoundField DataField="stu_id" HeaderText="Admission ID" />
                               <asp:BoundField DataField="roll_no" HeaderText="Roll No" />
                               <asp:BoundField DataField="Name" HeaderText="Name" />
                               <asp:BoundField DataField="fath_na" HeaderText="Father Name" />
                               <asp:BoundField DataField="clg_address" HeaderText="College Add" />
                               <asp:BoundField DataField="per_address" HeaderText="Permanent Add" />
                               <asp:BoundField DataField="DoBirth" HeaderText="DOB" />
                               <asp:BoundField DataField="DoAdmission" HeaderText="DoAdmission" />
                               <asp:BoundField DataField="Sem" HeaderText="SEM" />
                               <asp:BoundField DataField="ph_no" HeaderText="Mobile" />
                               <asp:BoundField DataField="EMail" HeaderText="E-Mail" />
                               <asp:BoundField DataField="dept_code" HeaderText="Department" />
                               <asp:BoundField DataField="advsr_fac_id" HeaderText="FAC Advisor" />
                               <asp:BoundField DataField="category" HeaderText="Category" />
                               <asp:BoundField DataField="gender" HeaderText="Gender" />
                               <asp:ImageField DataImageUrlField="photo" HeaderText="Photo" ControlStyle-Height="80px" ControlStyle-Width="80px"></asp:ImageField>
                           </Columns>
                           <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                           <EditRowStyle BackColor="#999999" />
                           <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                           <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                           <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                           <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                           <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                           <SortedAscendingCellStyle BackColor="#E9E7E2" />
                           <SortedAscendingHeaderStyle BackColor="#506C8C" />
                           <SortedDescendingCellStyle BackColor="#FFFDF8" />
                           <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
                       </asp:GridView>
                       <asp:GridView ID="GridView2" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" AutoGenerateColumns="false" Visible="false" Width="100%">
                           <Columns>
                               <asp:BoundField DataField ="c_code" HeaderText="Course Code" />
                               <asp:BoundField DataField ="dept_code" HeaderText ="Dept. Code" />
                               <asp:BoundField DataField ="title" HeaderText="Title" />
                               <asp:BoundField DataField ="c_credits" HeaderText="Credits" />
                               <asp:BoundField DataField ="lec_w" HeaderText="Lectures/Week" />
                               <asp:BoundField DataField ="prac_w" HeaderText="Practical/Week" />
                               <asp:BoundField DataField ="core" HeaderText="Core Subject" />
                               <asp:BoundField DataField ="sem" HeaderText="Semester Allowed" />
                               <asp:BoundField DataField ="about" HeaderText ="Description" />
                           </Columns>
                           <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                           <EditRowStyle BackColor="#999999" />
                           <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                           <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                           <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                           <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                           <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                           <SortedAscendingCellStyle BackColor="#E9E7E2" />
                           <SortedAscendingHeaderStyle BackColor="#506C8C" />
                           <SortedDescendingCellStyle BackColor="#FFFDF8" />
                           <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
                       </asp:GridView>
                       <asp:GridView ID="GridView3" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" AutoGenerateColumns="false" Visible="false" Width="100%">
                           <Columns>
                               <asp:BoundField DataField="dept_code" HeaderText="Department Code" />
                               <asp:BoundField DataField="name" HeaderText="Department" />
                               <asp:BoundField DataField="hod_id" HeaderText ="Head OF Department ID" />
                               <asp:BoundField DataField="no_courses" HeaderText="Courses Offered" />
                           </Columns>
                           <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                           <EditRowStyle BackColor="#999999" />
                           <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                           <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                           <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                           <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                           <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                           <SortedAscendingCellStyle BackColor="#E9E7E2" />
                           <SortedAscendingHeaderStyle BackColor="#506C8C" />
                           <SortedDescendingCellStyle BackColor="#FFFDF8" />
                           <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
                       </asp:GridView>
                       <asp:GridView ID="GridView4" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" AutoGenerateColumns="false" Visible="false" Width="100%">
                           <Columns>
                               <asp:BoundField DataField ="sub_id" HeaderText ="Subject ID" />
                               <asp:BoundField DataField ="ROLL_NO" HeaderText="Roll NO" />
                               <asp:BoundField DataField ="c_code" HeaderText ="Course Code" />
                               <asp:BoundField DataField ="sem" HeaderText="Enrolled Semester" />
                           </Columns>
                           <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                           <EditRowStyle BackColor="#999999" />
                           <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                           <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                           <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                           <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                           <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                           <SortedAscendingCellStyle BackColor="#E9E7E2" />
                           <SortedAscendingHeaderStyle BackColor="#506C8C" />
                           <SortedDescendingCellStyle BackColor="#FFFDF8" />
                           <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
                       </asp:GridView>
                       <asp:GridView ID="GridView5" runat="server" Visible="False" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" Width="100%">
                           <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                           <Columns>
                               <asp:BoundField DataField ="fac_id" HeaderText="Faculty ID" />
                               <asp:BoundField DataField ="C_CODE" HeaderText="Subjects Code" />
                           </Columns>
                           <EditRowStyle BackColor="#999999" />
                           <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                           <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                           <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                           <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                           <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                           <SortedAscendingCellStyle BackColor="#E9E7E2" />
                           <SortedAscendingHeaderStyle BackColor="#506C8C" />
                           <SortedDescendingCellStyle BackColor="#FFFDF8" />
                           <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
                       </asp:GridView>
                       <asp:GridView ID="GridView6" runat="server" Visible="False" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" Width="100%">
                           <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                           <Columns>
                               <asp:BoundField DataField ="sub_id" HeaderText="Subject ID" />
                               <asp:BoundField DataField ="S1" HeaderText ="Sessional 1(20)" />
                               <asp:BoundField DataField ="S2" HeaderText ="Sessional 2(20)" />
                               <asp:BoundField DataField ="ends" HeaderText ="End Semester(40)" />
                               <asp:BoundField DataField ="other" HeaderText ="Other(20)" />
                               <asp:BoundField DataField ="attend" HeaderText ="Total Attendence" />
                               <asp:BoundField DataField ="totalm" HeaderText ="Total Marks" />
                               <asp:BoundField DataField ="gradep" HeaderText ="Grade Point" />
                           </Columns>
                           <EditRowStyle BackColor="#999999" />
                           <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                           <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                           <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                           <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                           <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                           <SortedAscendingCellStyle BackColor="#E9E7E2" />
                           <SortedAscendingHeaderStyle BackColor="#506C8C" />
                           <SortedDescendingCellStyle BackColor="#FFFDF8" />
                           <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
                       </asp:GridView>
                       <asp:GridView ID="GridView7" runat="server" Visible="False" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" Width="100%">
                           <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                           <Columns>
                               <asp:BoundField DataField ="roll_no" HeaderText ="Roll NO" />
                               <asp:BoundField DataField ="sem" HeaderText="Semester" />
                               <asp:BoundField DataField ="sub_ids" HeaderText ="Subject IDs" />
                               <asp:BoundField DataField ="Tot_credits" HeaderText="Total Credits" />
                               <asp:BoundField DataField ="CGPA" HeaderText ="CGPA" />
                               <asp:BoundField DataField ="SGPA" HeaderText ="SGPA" />
                           </Columns>
                           <EditRowStyle BackColor="#999999" />
                           <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                           <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                           <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                           <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                           <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                           <SortedAscendingCellStyle BackColor="#E9E7E2" />
                           <SortedAscendingHeaderStyle BackColor="#506C8C" />
                           <SortedDescendingCellStyle BackColor="#FFFDF8" />
                           <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
                       </asp:GridView>
                       <asp:GridView ID="GridView8" runat="server" Visible="False" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" Width="100%">
                           <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                           <Columns>
                               <asp:BoundField DataField="trans_no" HeaderText="Transaction no" />
                               <asp:BoundField DataField="Roll_no" HeaderText="Roll No" />
                               <asp:BoundField DataField="batch" HeaderText="batch" />
                               <asp:BoundField DataField="sem" HeaderText="Semester" />
                               <asp:BoundField DataField="Do_Payment" HeaderText="Date" />
                               <asp:BoundField DataField ="amnt_paid" HeaderText="Amount Paid" />
                           </Columns>
                           <EditRowStyle BackColor="#999999" />
                           <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                           <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                           <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                           <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                           <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                           <SortedAscendingCellStyle BackColor="#E9E7E2" />
                           <SortedAscendingHeaderStyle BackColor="#506C8C" />
                           <SortedDescendingCellStyle BackColor="#FFFDF8" />
                           <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
                       </asp:GridView>
                       <asp:GridView ID="GridView9" runat="server" Visible="False" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" Width="100%">
                           <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                           <Columns>
                               <asp:BoundField DataField="sem" HeaderText="Semester" />
                               <asp:BoundField DataField ="tution" HeaderText="Tution Fee" />
                               <asp:BoundField DataField ="messhostel" HeaderText ="Hostel & Mess" />
                               <asp:BoundField DataField="other" HeaderText="Other Charges" />
                           </Columns>
                           <EditRowStyle BackColor="#999999" />
                           <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                           <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                           <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                           <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                           <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                           <SortedAscendingCellStyle BackColor="#E9E7E2" />
                           <SortedAscendingHeaderStyle BackColor="#506C8C" />
                           <SortedDescendingCellStyle BackColor="#FFFDF8" />
                           <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
                       </asp:GridView>
                       <asp:GridView ID="GridView10" runat="server" Visible="False" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" Width="100%">
                           <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                           <Columns>
                               <asp:BoundField DataField="fac_id" HeaderText="Faculty ID" />
                               
                               <asp:BoundField DataField="Name" HeaderText="Name" />
                              
                               <asp:BoundField DataField="per_address" HeaderText="Permanent Address" />
                                 <asp:BoundField DataField="res_address" HeaderText="Residential Address" />
                                <asp:BoundField DataField="ph_no" HeaderText="Mobile" />
                               <asp:BoundField DataField="EMail" HeaderText="E-Mail" />
                                <asp:BoundField DataField="Qualification" HeaderText="Qualification" />
                                <asp:BoundField DataField="expirience" HeaderText="Expirience" />
                               <asp:BoundField DataField="DoBirth" HeaderText="DOB" />
                               <asp:BoundField DataField="DoJoin" HeaderText="DoJoin" />
                               <asp:BoundField DataField="salary" HeaderText="Salary" />
                              
                               
                               <asp:BoundField DataField="dept_code" HeaderText="Department" />
                             
                               
                               <asp:BoundField DataField="gender" HeaderText="Gender" />
                               <asp:ImageField DataImageUrlField="photo" HeaderText="Photo" ControlStyle-Height="80px" ControlStyle-Width="80px"></asp:ImageField>
                           </Columns>
                           <EditRowStyle BackColor="#999999" />
                           <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                           <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                           <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                           <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                           <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                           <SortedAscendingCellStyle BackColor="#E9E7E2" />
                           <SortedAscendingHeaderStyle BackColor="#506C8C" />
                           <SortedDescendingCellStyle BackColor="#FFFDF8" />
                           <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
                       </asp:GridView>



                   </div>
               </div> </div>  </div>
</asp:Content>

