<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PostBack.aspx.cs" Inherits="Statemanagement.PostBack" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="txt1" runat="server"></asp:TextBox><br />
            <asp:Button ID="btnclick" runat="server" Text="Clicks Count" OnClick="btnclick_Click" />
        </div>
    </form>
</body>
</html>
