<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="accueil.aspx.cs" Inherits="pratiqueV2Exam2007.accueil" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 90px;
        }
        .auto-style2 {
            width: 100%;
            height: 161px;
        }
    </style>
</head>
<body>
    <asp:Label ID="lbl_début_app" runat="server"  Text="debut App: "></asp:Label><br/>  
    <asp:Label ID="lbl_début_session" runat="server"  Text="debut Session: "></asp:Label><br/> 
    <asp:Label ID="lbl_users" runat="server"  Text="nombre de vues: "></asp:Label><br/>  <br/>  <br/>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style2">
                <tr>
                    <td class="auto-style1">nom</td>
                    <td><asp:Label ID="lbl_nom" runat="server" ></asp:Label></td>
                </tr>
                <tr>
                    <td class="auto-style1">prenom</td>
                    <td><asp:Label ID="lbl_prenom" runat="server" ></asp:Label></td>
                </tr>
                <tr>
                    <td class="auto-style1">Genre</td>
                    <td><asp:Label ID="lbl_genre" runat="server" ></asp:Label></td>
                   
                </tr>
                <tr>
                    <td class="auto-style1">Niveau</td>
                    <td><asp:Label ID="lbl_niveau" runat="server" ></asp:Label></td>
                   
                </tr>
                <tr>
                    <td class="auto-style1">Filière</td>
                    <td><asp:Label ID="lbl_filiere" runat="server" ></asp:Label></td>
                   
                </tr>
            </table>
        </div>
        
        <asp:GridView ID="GridView1" runat="server" BackColor="White" BorderColor="#E7E7FF" BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Horizontal">
            <AlternatingRowStyle BackColor="#F7F7F7" />
            <FooterStyle BackColor="#B5C7DE" ForeColor="#4A3C8C" />
            <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#F7F7F7" />
            <PagerStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" HorizontalAlign="Right" />
            <RowStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" />
            <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="#F7F7F7" />
            <SortedAscendingCellStyle BackColor="#F4F4FD" />
            <SortedAscendingHeaderStyle BackColor="#5A4C9D" />
            <SortedDescendingCellStyle BackColor="#D8D8F0" />
            <SortedDescendingHeaderStyle BackColor="#3E3277" />
        </asp:GridView>     <br/>  <br/>  <br/>
        <asp:Label ID="lbl_total" runat="server" Text="Total : "></asp:Label>  <br/>  <br/>  <br/>
        
         <asp:Label ID="lbl_moyenne" runat="server" Text="Moyenne : "></asp:Label>
        
        
    </form>
</body>
</html>
