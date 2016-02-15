<%@ Page Title="" Language="C#" MasterPageFile="~/UserMaster.master" Debug="true" AutoEventWireup="true" CodeFile="Portfolio.aspx.cs" Inherits="Portfolio" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Middle" Runat="Server">
    <form id="id1" runat="server">
    <asp:Panel ID="pnlGridView" runat="server" ScrollBars="Auto" Height="350px"> 
    <asp:GridView ID="GridView1"  runat="server" BackColor="#DEBA84" onrowcommand="gv_RowCommand" ScrollBars="Vertical"
    BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellPadding="3" 
    CellSpacing="2" AutoGenerateColumns="False" HorizontalAlign="Center">

     <Columns>
     
        <asp:TemplateField HeaderText="ORDER DATE">
                 <ItemTemplate>
                <asp:Label ID="ID2" runat="server" Text='<%#Eval("odate")%>'></asp:Label>
               </ItemTemplate>             
         </asp:TemplateField>
       <asp:TemplateField HeaderText="SYMBOL">
             <ItemTemplate>
                <asp:Label ID="ID3" runat="server" Text='<%#Eval("symbol") %>'></asp:Label>
               </ItemTemplate>                  
        </asp:TemplateField>
     <asp:TemplateField HeaderText="QUANTITY">
                  <ItemTemplate>
                <asp:Label ID="ID4" runat="server" Text='<%#Eval("quantity") %>'></asp:Label>
               </ItemTemplate>             
        </asp:TemplateField>
     <asp:TemplateField HeaderText="PRICE">
                      <ItemTemplate>
                <asp:Label ID="ID5" runat="server" Text='<%#Eval("price") %>'></asp:Label>
               </ItemTemplate>         
        </asp:TemplateField>
     <asp:TemplateField HeaderText="MARKET PRICE" >
                      <ItemTemplate>
                <asp:Label ID="ID6" runat="server" Text='<%#Eval("marketprice") %>'></asp:Label>
               </ItemTemplate>         
        </asp:TemplateField>
     <asp:TemplateField HeaderText="TOTAL COST">
                     <ItemTemplate>
                <asp:Label ID="ID7" runat="server" Text='<%#Eval("avgcost") %>'></asp:Label>
               </ItemTemplate>          
        </asp:TemplateField>
         <asp:TemplateField HeaderText="TOTAL MARKET COST">
                     <ItemTemplate>
                <asp:Label ID="ID8" runat="server" Text='<%#Eval("marketcost") %>'></asp:Label>
               </ItemTemplate>          
        </asp:TemplateField>
         <asp:TemplateField HeaderText="PROFIT/LOSS">
                     <ItemTemplate>
                <asp:Label ID="ID9" runat="server" Text='<%#Eval("profitloss","{0:n}") %>'></asp:Label>
               </ItemTemplate>          
        </asp:TemplateField>
    
    
    
       <asp:TemplateField HeaderText="SELL">
     <ItemTemplate> 
      <asp:Button ID="Button1"  runat="server" Text="Sell" CommandName="sell"/>
    </ItemTemplate>
    </asp:TemplateField>  
    
    
    
    </Columns>

        <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
        <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" />
        <PagerStyle ForeColor="#8C4510" HorizontalAlign="Center" />
        <RowStyle BackColor="#FFF7E7" ForeColor="#8C4510" HorizontalAlign="Center" 
            VerticalAlign="Middle" />
        <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
        <SortedAscendingCellStyle BackColor="#FFF1D4" />
        <SortedAscendingHeaderStyle BackColor="#B95C30" />
        <SortedDescendingCellStyle BackColor="#F1E5CE" />
        <SortedDescendingHeaderStyle BackColor="#93451F" />

    </asp:GridView>
    </asp:Panel>
    <br />
    <span style="color: #0066FF">Total Cost (When User Bought)</span>&nbsp; :
    <asp:Label ID="Label1" runat="server" style="color: #FF6600" Text="Label"></asp:Label>
    <br />
    <span style="color: #0066FF">Total Market Price (Current) </span>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
    :
    <asp:Label ID="Label2" runat="server" style="color: #FF6600" Text="Label"></asp:Label>
    <br />
    <span style="color: #0066FF">Profit/Loss&nbsp; </span>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp; 
    :
    <asp:Label ID="Label3" runat="server" style="color: #FF0000" Text="Label"></asp:Label>
    </form>
</asp:Content>

