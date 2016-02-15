<%@ Page Title="" Language="C#" MasterPageFile="~/UserMaster.master" AutoEventWireup="true" CodeFile="AppointmentDetails.aspx.cs" Inherits="AppointmentDetails" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Middle" Runat="Server">
    <form id="id1" runat="server">
 <table style="width: 100%">
     <tr>
         <td class="style3" style="font-size: large; color: #800000; text-align: center">
             APPOINTMENT DETAILS</td>
     </tr>
 </table>
 <br />
    <asp:Panel ID="pnlGridView" runat="server" ScrollBars="Auto" Height="350px"> 
    <asp:GridView ID="GridView1"  runat="server" BackColor="#DEBA84" 
           ScrollBars="Vertical"
    BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellPadding="3" 
    CellSpacing="2" AutoGenerateColumns="False" HorizontalAlign="Center">

     <Columns>
      <asp:TemplateField HeaderText="APPOINTMENT ID">
                 <ItemTemplate>
                <asp:Label ID="ID2" runat="server" Text='<%#Eval("appointmentid")%>'></asp:Label>
               </ItemTemplate>             
         </asp:TemplateField>
        <asp:TemplateField HeaderText="APPOINTMENT DATE">
                 <ItemTemplate>
                <asp:Label ID="ID3" runat="server" Text='<%#Eval("slotdate")%>'></asp:Label>
               </ItemTemplate>             
         </asp:TemplateField>
       <asp:TemplateField HeaderText="APPOINTMENT TIME">
             <ItemTemplate>
                <asp:Label ID="ID4" runat="server" Text='<%#Eval("slottime") %>'></asp:Label>
               </ItemTemplate>                  
        </asp:TemplateField>
       
    
      
      <asp:TemplateField HeaderText="CANCEL">
                        <ItemTemplate>
                            <asp:LinkButton ID="lnkdelete" runat="server" OnClick="lnkdelete_Click" Text="Cancel"></asp:LinkButton>
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
      </form>
    </br>
  
</asp:Content>

