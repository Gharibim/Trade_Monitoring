<%@ Page Title="" Language="C#" MasterPageFile="~/UserMaster.master" AutoEventWireup="true" CodeFile="NewOrder.aspx.cs" Inherits="NewOrder" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Middle" Runat="Server">



    <form id="form1" runat="server">



    <table style="width: 100%">
        <tr>
            <td class="style3" 
                style="text-align: center; font-size: x-large; color: #CC3300">
                Place New Order</td>
        </tr>
    </table>
 
    <table style="border: medium outset #FFFFFF; width: 100%; background-image: url('images/bg1.jpg');">
        <tr>
            <td style="width: 75px">
                &nbsp;</td>
            <td class="col_w250" 
                style="width: 191px; color: #996633; font-family: 'Times New Roman', Times, serif; font-size: small;">
                Symbol</td>
            <td style="width: 295px" class="col_w270">
                <asp:DropDownList ID="DropDownList1" runat="server" 
                    onselectedindexchanged="DropDownList1_SelectedIndexChanged" 
                    AutoPostBack="True" 
                    style="color: #006600; font-family: 'Times New Roman', Times, serif">

                 <asp:ListItem Value="0">-- Select Symbol --</asp:ListItem>
                    <asp:ListItem Value="AAPL">AAPL</asp:ListItem>
                    <asp:ListItem Value="ACH">ACH</asp:ListItem>
                    <asp:ListItem Value="BAB">BAB</asp:ListItem>
                    <asp:ListItem Value="DAL">DAL</asp:ListItem>
                    <asp:ListItem Value="DWSN">DWSN</asp:ListItem>
                    <asp:ListItem Value="EXPE">EXPE</asp:ListItem>
                    <asp:ListItem Value="FCF">FCF</asp:ListItem>
                    <asp:ListItem Value="GYRO">GYRO</asp:ListItem>
                    <asp:ListItem Value="HFWA">HFWA</asp:ListItem>
                    <asp:ListItem Value="INFY">INFY</asp:ListItem>
                    <asp:ListItem Value="LAKE">LAKE</asp:ListItem>
                    <asp:ListItem Value="NATI">NATI</asp:ListItem>
                     <asp:ListItem Value="OFC">OFC</asp:ListItem>
                    <asp:ListItem Value="PCTY">PCTY</asp:ListItem>
                    <asp:ListItem Value="SAND">SAND</asp:ListItem>
                    <asp:ListItem Value="VTA">VTA</asp:ListItem>
                    <asp:ListItem Value="WPPGY">WPPGY</asp:ListItem>
                    <asp:ListItem Value="XLV">XLV</asp:ListItem>
                    <asp:ListItem Value="YHOO">YHOO</asp:ListItem>
                    <asp:ListItem Value="YUM">YUM</asp:ListItem>

                   </asp:DropDownList>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td style="width: 75px">
                &nbsp;</td>
            <td class="col_w250" 
                style="width: 191px; color: #996633; font-family: 'Times New Roman', Times, serif; font-size: small;">
                Comany Name</td>
            <td style="width: 295px" class="col_w270">
                <asp:Label ID="Label1" runat="server" Text="Label" Visible="False" 
                    style="color: #0066FF; font-family: 'Times New Roman', Times, serif"></asp:Label>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td style="width: 75px">
                &nbsp;</td>
            <td class="col_w250" 
                style="width: 191px; color: #996633; font-family: 'Times New Roman', Times, serif; font-size: small;">
                Current Market Price</td>
            <td style="width: 295px" class="col_w270">
                <asp:Label ID="Label2" runat="server" Text="Label" Visible="False" 
                    style="color: #0066FF; font-family: 'Times New Roman', Times, serif"></asp:Label>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td style="width: 75px">
                &nbsp;</td>
            <td class="col_w250" 
                style="width: 191px; color: #996633; font-family: 'Times New Roman', Times, serif; font-size: small;">
                Available Shares</td>
            <td style="width: 295px" class="col_w270">
                <asp:Label ID="Label3" runat="server" Text="Label" Visible="False" 
                    style="color: #0066FF; font-family: 'Times New Roman', Times, serif"></asp:Label>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td style="width: 75px">
                &nbsp;</td>
            <td class="col_w250" 
                style="width: 191px; color: #996633; font-family: 'Times New Roman', Times, serif; font-size: small;">
                Quantity</td>
            <td style="width: 295px" class="col_w270">
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td style="width: 75px">
                &nbsp;</td>
            <td class="col_w250" 
                style="width: 191px; color: #996633; font-family: 'Times New Roman', Times, serif; font-size: small;">
                Order Type</td>
            <td style="width: 295px" class="col_w270">
                <asp:DropDownList ID="DropDownList2" runat="server" 
                    onselectedindexchanged="DropDownList2_SelectedIndexChanged" 
                    AutoPostBack="True" 
                    style="font-family: 'Times New Roman', Times, serif; color: #006600">

                <asp:ListItem Value="0">-- Order Type --</asp:ListItem>
                    <asp:ListItem Value="1">Limit</asp:ListItem>
                    <asp:ListItem Value="2">Current Price</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td style="width: 75px">
                &nbsp;</td>
            <td class="col_w250" 
                style="width: 191px; color: #996633; font-family: 'Times New Roman', Times, serif; font-size: small;">
                Price</td>
            <td style="width: 295px; color: #0066FF;" class="col_w270">
                <asp:Label ID="Label4" runat="server" Text="Label" Visible="False" 
                    style="font-family: 'Times New Roman', Times, serif"></asp:Label>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td style="width: 75px">
                &nbsp;</td>
            <td class="col_w250" 
                style="width: 191px; color: #996633; font-family: 'Times New Roman', Times, serif; font-size: small;">
                &nbsp;</td>
            <td style="width: 295px" class="col_w270">
                <span class="style3" style="color: #6600CC">From :</span>
                <asp:TextBox ID="TextBox2" runat="server" Width="74px" Visible="False"></asp:TextBox>
&nbsp; <span class="style3" style="color: #6600CC">To :</span><asp:TextBox ID="TextBox3" runat="server" Width="74px" Visible="False"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td style="width: 75px">
                &nbsp;</td>
            <td class="col_w250" 
                style="width: 191px; color: #996633; font-family: 'Times New Roman', Times, serif; font-size: small;">
                Validity</td>
            <td style="width: 295px" class="col_w270">
                <asp:DropDownList ID="DropDownList3" runat="server" 
                    style="color: #006600; font-family: 'Times New Roman', Times, serif" 
                    Visible="False">
                  <asp:ListItem Value="0">-- Select Validity --</asp:ListItem>
                    <asp:ListItem Value="1">Day</asp:ListItem>
                    <asp:ListItem Value="5">5 Days</asp:ListItem>
                </asp:DropDownList>

              
            </td>
            <td>
                &nbsp;</td>
        </tr>
         <tr>
            <td style="width: 75px">
                &nbsp;</td>
            <td class="col_w250" style="width: 191px">
                &nbsp;</td>
            <td style="width: 295px" class="col_w270">
                <asp:Button ID="Button2" runat="server" Text="Place Order" 
                    
                    style="color: #993300; font-family: 'Times New Roman', Times, serif; font-size: medium" 
                    onclick="Button2_Click" />
            </td>
            <td>
                &nbsp;</td>
        </tr>

    </table>

    <br />

    </form>

</asp:Content>

