<%@ Page Title="" Language="C#" MasterPageFile="~/UserMaster.master" AutoEventWireup="true" CodeFile="SellStock.aspx.cs" Inherits="SellStock" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Middle" Runat="Server">



    <form id="form1" runat="server">



    <table style="width: 100%">
        <tr>
            <td class="style3" style="font-size: large; color: #990000; text-align: center">
                SELL SHARES HERE</td>
        </tr>
    </table>

    <br />

    <table align="center" style="width: 100%">
        <tr>
            <td style="width: 141px">
                &nbsp;</td>
            <td class="style3" style="color: #996633; font-size: medium; width: 148px">
                Symbol
            </td>
            <td class="col_w250" style="width: 180px">
                <asp:Label ID="Label1" runat="server" 
                    style="color: #0066FF; font-family: 'Times New Roman', Times, serif; font-size: medium" 
                    Text="Label"></asp:Label>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td style="width: 141px">
                &nbsp;</td>
            <td class="style3" style="color: #996633; font-size: medium; width: 148px">
                Quantity
            </td>
            <td class="col_w250" style="width: 180px">
                <asp:Label ID="Label2" runat="server" 
                    style="color: #0066FF; font-family: 'Times New Roman', Times, serif; font-size: medium" 
                    Text="Label"></asp:Label>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td style="width: 141px">
                &nbsp;</td>
            <td class="style3" style="color: #996633; font-size: medium; width: 148px">
                Market Price
            </td>
            <td class="col_w250" style="width: 180px">
                <asp:Label ID="Label3" runat="server" 
                    style="color: #0066FF; font-family: 'Times New Roman', Times, serif; font-size: medium" 
                    Text="Label"></asp:Label>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td style="width: 141px">
                &nbsp;</td>
            <td class="style3" style="color: #996633; font-size: medium; width: 148px">
                Sell Quantity
            </td>
            <td class="col_w250" style="width: 180px">
                <asp:TextBox ID="TextBox1" runat="server" Width="141px"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td style="width: 141px">
                &nbsp;</td>
            <td style="width: 148px">
                &nbsp;</td>
            <td class="col_w250" style="width: 180px">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td style="width: 141px">
                &nbsp;</td>
            <td style="width: 148px">
                &nbsp;</td>
            <td class="col_w250" style="width: 180px">
                <asp:Button ID="Button1" runat="server" 
                    style="font-family: 'Times New Roman', Times, serif; color: #CC0000; font-size: medium" 
                    Text="Sell" Width="74px" onclick="Button1_Click" />
            </td>
            <td>
                &nbsp;</td>
        </tr>
    </table>
    </form>

</asp:Content>

