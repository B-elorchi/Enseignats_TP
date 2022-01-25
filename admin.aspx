<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="admin.aspx.cs" Inherits="pratiqueV2Exam2007.admin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
nom : <asp:TextBox ID="login" runat="server" ></asp:TextBox> <br/>
Code : <asp:TextBox ID="pwd" runat="server"></asp:TextBox> <br/>
<asp:Button ID="connecter" runat="server" Text="Se Connecter" OnClick="connecter_Click"  />
       </div>
        <p>
            <asp:Label ID="err" runat="server" Text=""></asp:Label>
        </p>
    </form>
</body>
</html>
