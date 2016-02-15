<%@ Page Title="" Language="C#" MasterPageFile="~/UserMaster.master" AutoEventWireup="true" CodeFile="Reports.aspx.cs" Inherits="Reports" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Middle" Runat="Server">



    <form id="form1" runat="server">



    <table style="width: 100%">
        <tr>
            <td class="style3" 
                style="text-align: center; font-size: x-large; color: #990000">
                Trade Monitoring Statistics</td>
        </tr>
    </table>

    <br />

    <table style="width: 100%">
        <tr>
            <td style="height: 6px; width: 133px">
            </td>
            <td class="style3" 
                style="height: 6px; width: 148px; color: #996633; font-size: medium">
                Stasistics On</td>
            <td style="height: 6px; width: 223px">
                <asp:DropDownList ID="DropDownList1" runat="server" 
                    
                    style="color: #0000FF; font-family: 'Times New Roman', Times, serif; font-size: medium" 
                    AutoPostBack="True" onselectedindexchanged="DropDownList1_SelectedIndexChanged">


                     <asp:ListItem Value="0">-- Select Option --</asp:ListItem>
                    <asp:ListItem Value="1">Available Shares</asp:ListItem>
                    <asp:ListItem Value="2">Buy Shares</asp:ListItem>
                    <asp:ListItem Value="3">Sell Shares</asp:ListItem>
                    <asp:ListItem Value="4">Shares Statistics</asp:ListItem>
                   
                </asp:DropDownList>
            </td>
            <td style="height: 6px">
            </td>
        </tr>
    </table>

      <br />
   
  <asp:Chart ID="Chart1" runat="server" BackColor="0, 0, 64" BackGradientStyle="LeftRight"  
        BorderlineWidth="0" Height="540px" Palette="None" PaletteCustomColors="Maroon"  
        Width="600px" BorderlineColor="64, 0, 64" Visible="False">  
        <Titles>  
            <asp:Title ShadowOffset="10" Name="Items" />  
        </Titles>  
        <Legends>  
            <asp:Legend Alignment="Center" Docking="Bottom" IsTextAutoFit="False" Name="Default"  
                LegendStyle="Row" />  
        </Legends>  
        <Series>  
            <asp:Series Name="Default" />  
        </Series>  
        <ChartAreas>  
            <asp:ChartArea Name="ChartArea1" BorderWidth="0" />  
        </ChartAreas>  
    </asp:Chart>  

    <asp:Chart ID="Chart2" runat="server" Height="400px" Width="700" 
        Palette="EarthTones" ViewStateContent="Default, Appearance" 
        BackColor="Turquoise" BackHatchStyle="SmallGrid" 
        BackImageTransparentColor="Fuchsia" Visible="False" 
        IsMapAreaAttributesEncoded="True">
       <Series>
           <asp:Series Name="Series1" XValueMember="symbol" YValueMembers="count">
           </asp:Series>
       </Series>
       <ChartAreas>
           <asp:ChartArea Name="ChartArea1"  Area3DStyle-Enable3D="true" BackColor="LemonChiffon">
           </asp:ChartArea>
       </ChartAreas>
   </asp:Chart>


    <asp:Chart ID="Chart3" runat="server" BorderlineDashStyle="Solid" 
        BorderlineWidth="2" BorderlineColor="Olive"
            Width="500"
            BackColor="Gold"
            Palette="Bright" Visible="False" style="text-align: center">
            <Legends>
                <asp:Legend Docking="Top">
                </asp:Legend>
            </Legends>
            <Series>
           <asp:Series Name="Series2" XValueMember="shares" YValueMembers="count">
           </asp:Series>
       </Series>
            <ChartAreas>
                <asp:ChartArea 
                    Name="ChartArea2" 
                    BackColor="Snow" 
                    BorderDashStyle="Dot"
                    BorderColor="ForestGreen"
                    BorderWidth="2"
                    >
                    <Area3DStyle Enable3D="true" />
                    <AxisX LineColor="LawnGreen"></AxisX>
                    <AxisY LineColor="MediumSeaGreen"></AxisY>
                </asp:ChartArea>
            </ChartAreas>
        </asp:Chart>

    </form>

</asp:Content>

