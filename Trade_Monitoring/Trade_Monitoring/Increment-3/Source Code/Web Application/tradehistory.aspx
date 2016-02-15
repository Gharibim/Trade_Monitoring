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
                <asp:DropDownList ID="DropDownList1" runat="server" 
                    
                    style="font-family: 'Times New Roman', Times, serif; font-size: medium; color: #006600" 
                    AutoPostBack="True" 
                    onselectedindexchanged="DropDownList1_SelectedIndexChanged1">

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
    </table>
    <br />
    <asp:Button ID="Button2" runat="server" onclick="Button2_Click" 
         style="font-family: 'Times New Roman', Times, serif; color: #6600CC; font-size: medium;" 
         Text="Export To Excel" Visible="False" />
    <asp:GridView ID="GridView1" Width="600px" runat="server" AllowPaging="True" PageSize="20" 
        BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" 
        CellPadding="3" CellSpacing="2" 
        onpageindexchanging="GridView1_PageIndexChanging" HorizontalAlign="Center">

        <EditRowStyle HorizontalAlign="Center" VerticalAlign="Middle" />

        <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
        <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" 
            HorizontalAlign="Center" VerticalAlign="Middle" />
        <PagerStyle ForeColor="#8C4510" HorizontalAlign="Center" 
            VerticalAlign="Middle" />
        <RowStyle BackColor="#FFF7E7" ForeColor="#8C4510" HorizontalAlign="Center" 
            VerticalAlign="Middle" />
        <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
        <SortedAscendingCellStyle BackColor="#FFF1D4" />
        <SortedAscendingHeaderStyle BackColor="#B95C30" />
        <SortedDescendingCellStyle BackColor="#F1E5CE" />
        <SortedDescendingHeaderStyle BackColor="#93451F" />

 
    </asp:GridView>

 

    

  
    </form>
   



</asp:Content>

