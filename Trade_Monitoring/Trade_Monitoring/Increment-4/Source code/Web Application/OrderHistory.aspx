<%@ Page Title="" Language="C#" MasterPageFile="~/UserMaster.master" AutoEventWireup="true" CodeFile="OrderHistory.aspx.cs" Inherits="OrderHistory" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Middle" Runat="Server">



    <form id="form1" runat="server">



    <table style="width: 100%">
        <tr>
            <td class="style3" 
                style="font-size: x-large; text-align: center; color: #CC0000">
                ORDER HISTORY</td>
        </tr>
    </table>

    <br />

    <table style="width: 100%" align="center">
        <tr>
            <td class="col_w250" 
                
                style="width: 252px; font-family: 'Times New Roman', Times, serif; font-size: medium; color: #996633; text-align: right;">
                Select Status : </td>
            <td>
                <asp:DropDownList ID="DropDownList1" runat="server" 
                    
                    style="font-family: 'Times New Roman', Times, serif; font-size: medium; color: #336600" 
                    onselectedindexchanged="DropDownList1_SelectedIndexChanged" 
                    AutoPostBack="True">

                 <asp:ListItem Value="0">-- Select Status --</asp:ListItem>
                    <asp:ListItem Value="1">Open</asp:ListItem>
                    <asp:ListItem Value="2">Closed</asp:ListItem>
                    <asp:ListItem Value="3">Failed</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
    </table>
     <br />
    <asp:GridView ID="GridView1" runat="server" BackColor="#DEBA84" 
        BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellPadding="3" 
        CellSpacing="2" HorizontalAlign="Center" 
        
        style="text-align: center; font-family: 'Times New Roman', Times, serif; font-size: small" 
        Visible="False">
        <EditRowStyle HorizontalAlign="Center" />
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
    
    <asp:GridView ID="GridView2" runat="server" BackColor="#DEBA84" 
        BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellPadding="3" 
        CellSpacing="2" HorizontalAlign="Center" 
        style="font-family: 'Times New Roman', Times, serif; font-size: small; text-align: center" 
        Visible="False">
        <EditRowStyle HorizontalAlign="Center" VerticalAlign="Middle" />
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

