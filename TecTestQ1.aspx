<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TecTestQ1.aspx.cs" Inherits="TechTestQ1.GetBanana" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Fruit or Veggie List<br />
            <br />
            <asp:FileUpload ID="bananatxt" runat="server" accept=".txt"/>

            <br />
            <br />
            <asp:Button ID="displayBtn" runat="server" OnClick="displayBtn_Click" Text="Display Table" />

        </div>
        <asp:Label ID="lblmsg" runat="server"></asp:Label>
        <br />
        <br />
        <asp:PlaceHolder ID="PlaceHolder1" runat="server"></asp:PlaceHolder>
    </form>
</body>
</html>
