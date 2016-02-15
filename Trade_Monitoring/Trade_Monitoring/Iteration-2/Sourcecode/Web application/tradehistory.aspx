<%@ Page Title="" Language="C#" MasterPageFile="~/LoginMaster.master" Debug="true" AutoEventWireup="true" CodeFile="tradehistory.aspx.cs" Inherits="tradehistory" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Middle" Runat="Server">




    <form id="form1" runat="server">
     <table style="width: 100%">
     <tr>
     <td class="style3" style="font-size: large; text-align: left; color: #009900">
     
     &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
         <span style="font-size: x-large; color: #CC0099">Historical 
         Stock Information</span></td>
     </tr>

     </table>
     <br />
    <table style="width: 100%">
        <tr>
            <td class="col_w270" 
                
                
                style="width: 189px; font-family: 'Times New Roman', Times, serif; color: #990000; font-size: medium;">
                Company
                Symbol</td>
            <td style="width: 170px">
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:Button ID="Button1" runat="server" onclick="Button1_Click" 
                    Text="Download" style="color: #3333FF" />
            </td>
        </tr>
    </table>
    <br />

    <asp:GridView ID="GridView1" Width="600" runat="server" AllowPaging="True" PageSize="20" 
        BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" 
        CellPadding="3" CellSpacing="2" 
        onpageindexchanging="GridView1_PageIndexChanging">

        <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
        <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" />
        <PagerStyle ForeColor="#8C4510" HorizontalAlign="Center" />
        <RowStyle BackColor="#FFF7E7" ForeColor="#8C4510" />
        <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
        <SortedAscendingCellStyle BackColor="#FFF1D4" />
        <SortedAscendingHeaderStyle BackColor="#B95C30" />
        <SortedDescendingCellStyle BackColor="#F1E5CE" />
        <SortedDescendingHeaderStyle BackColor="#93451F" />

 
    </asp:GridView>

    </form>




</asp:Content>

