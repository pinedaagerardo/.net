<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="webtestPGN.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="Button1" runat="server" Text="Insertar" OnClick="Button1_Click" />
            <asp:GridView ID="GridView1" runat="server" Height="254px" Width="610px" >
            </asp:GridView>
            <asp:TextBox ID="txtidb" runat="server"></asp:TextBox><asp:Button ID="Button2" runat="server" Text="Borrar" OnClick="Button2_Click" />
        </div>
    </form>
</body>
</html>
