<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="enseignants.aspx.cs" Inherits="pratiqueV2Exam2007.enseignants" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server" method="">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Stagiaires : "></asp:Label>
            <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
            </asp:DropDownList>
        </div>
        <asp:Label ID="lbl_code" runat="server" Text="Code: "></asp:Label>
    </form>
</body>
</html>
