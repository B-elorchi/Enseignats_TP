<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="inscription.aspx.cs" Inherits="pratiqueV2Exam2007.inscription" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
      <asp:Label ID="lbl_code" runat="server" Text=""></asp:Label><br/><br/><br/>
nom : <asp:TextBox ID="nom" runat="server" ></asp:TextBox> <br/>
prenom : <asp:TextBox ID="prenom" runat="server"></asp:TextBox> <br/>
genre : <asp:RadioButton ID="rd1" runat="server" value="M" GroupName="rd"/> Masculin
        <asp:RadioButton ID="rd2" runat="server" value="F" GroupName="rd"/> Feminin  <br />
            niveau :
            <asp:DropDownList ID="DropDownList1" runat="server">
                <asp:ListItem>Bac</asp:ListItem>
                <asp:ListItem>technicien</asp:ListItem>
                <asp:ListItem>TS</asp:ListItem>
            </asp:DropDownList>
            <br /> <br />
            Filière :
            <asp:DropDownList ID="DropDownList2" runat="server">
                <asp:ListItem Value="TDI">Développement informatique</asp:ListItem>
                <asp:ListItem Value="TRI">Réseaux informatiques</asp:ListItem>
                <asp:ListItem Value="TSC">Commerce</asp:ListItem>
            </asp:DropDownList><br/> <br />
            <asp:Button ID="btn_inscrire" runat="server" Text="Inscrire" OnClick="btn_inscrire_Click" />
            <asp:Button ID="btn_annuler" runat="server" Text="Annuler" />
        </div>
    </form>
</body>
</html>
