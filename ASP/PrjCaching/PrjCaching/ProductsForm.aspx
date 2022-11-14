<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ProductsForm.aspx.cs" Inherits="PrjCaching.ProductsForm" %>
<%@ OutputCache Duration="30" Location="Client" VaryByParam="None" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Select a product :<asp:DropDownList ID="Dpdown1" runat="server"
                OnSelectedIndexChanged="Dpdown1_SelectedIndexChanged" AutoPostBack="True">
                <asp:ListItem Text="All" Value="All"></asp:ListItem>
                <asp:ListItem Text="Laptops" Value="laps">             
                </asp:ListItem>
                <asp:ListItem Text="Desktops" Value="desks"></asp:ListItem>
                <asp:ListItem Text="Mobiles" Value="mob"></asp:ListItem>
                <asp:ListItem Text="Tablet" Value="tab">
                    
                </asp:ListItem>
                <asp:ListItem Text="SmartWatches" Value="watch"></asp:ListItem>
                              </asp:DropDownList>
            <br />
            <br />
            <br />
            <asp:GridView ID="GridView1" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None">
                <AlternatingRowStyle BackColor="White" />
                <EditRowStyle BackColor="#2461BF" />
                <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle BackColor="#EFF3FB" />
                <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                <SortedAscendingCellStyle BackColor="#F5F7FB" />
                <SortedAscendingHeaderStyle BackColor="#6D95E1" />
                <SortedDescendingCellStyle BackColor="#E9EBEF" />
                <SortedDescendingHeaderStyle BackColor="#4870BE" />
            </asp:GridView>
            &nbsp;<br />
            <br />
            <br />
            <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" DataKeyNames="Empid" DataSourceID="SqlDataSource1">
                <Columns>
                    <asp:BoundField DataField="Empid" HeaderText="Empid" ReadOnly="True" SortExpression="Empid" />
                    <asp:BoundField DataField="Empname" HeaderText="Empname" SortExpression="Empname" />
                    <asp:BoundField DataField="Salary" HeaderText="Salary" SortExpression="Salary" />
                    <asp:BoundField DataField="Gender" HeaderText="Gender" SortExpression="Gender" />
                    <asp:BoundField DataField="DeptId" HeaderText="DeptId" SortExpression="DeptId" />
                    <asp:BoundField DataField="Phone" HeaderText="Phone" SortExpression="Phone" />
                </Columns>
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:InfiniteDBConnectionString %>" SelectCommand="SELECT * FROM [Employee] WHERE ([DeptId] = @DeptId)">
                <SelectParameters>
                    <asp:ControlParameter ControlID="GridView2" DefaultValue="1" Name="DeptId" PropertyName="SelectedValue" Type="Int32" />
                </SelectParameters>
            </asp:SqlDataSource>
            <br />
        </div>
        <p>
            Server Time :
            <asp:Label ID="lbltime" runat="server" ></asp:Label>
        </p>
        <p>&nbsp;</p>
        <p>
            Client Time :
            <script>
                document.write(Date());
            </script>
        </p>
    </form>
</body>
</html>
