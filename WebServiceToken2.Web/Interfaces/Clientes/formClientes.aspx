<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="formClientes.aspx.cs" Inherits="WebServiceToken2.Web.Interfaces.Clientes.formClientes" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">

        <table style="width: 100%;">
            <tr>
                <td style="width: 50%;">Identificación:</td>
                <td style="width: 50%;">
                    <asp:TextBox ID="txtIdentificaion" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:Button ID="btnConsultar" runat="server" OnClick="btnConsultar_Click" Text="Consultar" />
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:GridView ID="gvwDatos" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" AutoGenerateColumns="false" EmptyDataText="No se encontraron registros..." HorizontalAlign="Center" Width="100%">
                        <Columns>
                            <asp:BoundField DataField="Id" HeaderText="Id Usuario" />
                            <asp:BoundField DataField="Nombre" HeaderText="Nombre Usuario" />
                            <asp:BoundField DataField="Edad" HeaderText="Edad Usuario" />
                            <asp:BoundField DataField="IdPais" HeaderText="Codígo País" />
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
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
