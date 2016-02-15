<%@ Page Title="" Language="C#" MasterPageFile="~/UserMaster.master" AutoEventWireup="true" CodeFile="appointment.aspx.cs" Inherits="appointment" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Middle" Runat="Server">

    <form id="form1" runat="server">
   
   <table style="width: 100%">
       <tr>
           <td class="style3" style="text-align: center; font-size: large; color: #990000">
               Schedule Appointment Here</td>
       </tr>
   </table>
   
   

    <table style="height: 298px; width: 85%;" align="center">
    
    <tr>

    <td class="style2" style="font-size: medium">Select Date :</td>
    <td class="style11" style="width: 342px">
    
        <asp:TextBox ID="TextBox1" ReadOnly="true" runat="server"></asp:TextBox>
    
    &nbsp;</td>
    </tr>

    <tr>
    <td class="style3"></td>
    <td style="width: 342px"> 
        <asp:Calendar ID="Calendar" runat="server" 
           Font-Names="Verdana" 
            NextMonthText="<img src='images/NMonth.ico' border=0>" 
            PrevMonthText="<img src='images/PMonth.ico' border=0>" 
            OnDayRender="Calendar_DayRender" 
            OnSelectionChanged="Calendar_SelectionChanged" Height="16px" Width="110px">
            <SelectedDayStyle BackColor="Navy" BorderColor="Lavender" BorderStyle="Groove" Font-Bold="True" Font-Names="Courier New" Font-Size="Medium" ForeColor="Cyan" />
            <OtherMonthDayStyle BackColor="#E0E0E0" />
            <DayStyle BackColor="White" BorderColor="Gray" BorderStyle="Groove" Font-Names="Verdana"
                Font-Size="Small" />
            <NextPrevStyle BackColor="Yellow" />
            <DayHeaderStyle BackColor="#FFE0C0" BorderColor="Gray" BorderStyle="Outset" Font-Italic="True"
                Font-Size="Small" ForeColor="Blue" />
            <TitleStyle BackColor="Yellow" BorderColor="Olive" BorderStyle="Solid" />
            <SelectorStyle BackColor="#FFE0C0" BorderColor="Gray" BorderStyle="None" />
            <WeekendDayStyle BackColor="LightGoldenrodYellow" />
            <TodayDayStyle BackColor="#C0FFC0" />
        </asp:Calendar></td>
       
        </tr>
  
    
    </table>
   
        <table width="400">
            <tr>
                <td class="style2" style="width: 99px">
                    &nbsp;</td>
                <td class="style4">
                    &nbsp;&nbsp;
                    <img alt="" src="images/red.png" style="width: 11px; height: 17px" />
                    <span class="style5" style="color: #333300; font-size: small">Booked</span></td>
                <td class="style5">
                    &nbsp;&nbsp;
                    <img alt="" src="images/green.png" style="width: 10px; height: 14px" />&nbsp;
                    <span class="style3" style="font-size: small">Available</span></td>
                <td class="style6">
                    &nbsp;
                    <img alt="" src="images/orange.png" style="width: 11px; height: 14px" />
                    <span class="style3" style="color: #333300; font-size: small">No Slots</span></td>
                <td class="style7">
                    &nbsp;</td>
                <td class="style8">
                    &nbsp;</td>
                <td class="style9">
                    &nbsp;</td>
               
            </tr>
            <tr>
                <td class="style2" style="width: 99px">
                    <asp:Label ID="Label1" runat="server" 
                        style="color: #996633; font-size: medium;" Text="Morning" 
                        Visible="False"></asp:Label>
                </td>
                <td class="style4">
                    <asp:Button ID="Button2" runat="server" Text="09:00-09:30" 
                        onclick="Button2_Click" Visible="False" style="color: #6600CC" />
                </td>
                <td class="style5">
                    <asp:Button ID="Button3" runat="server" Text="09:30-10:00" 
                        onclick="Button3_Click" Visible="False" style="color: #6600CC" />
                </td>
                <td class="style6">
                    <asp:Button ID="Button4" runat="server" Text="10:00-10:30" 
                        onclick="Button4_Click" Visible="False" style="color: #6600CC" />
                </td>
                <td class="style7">
                    <asp:Button ID="Button5" runat="server" Text="10:30-11:00" 
                        onclick="Button5_Click" Visible="False" style="color: #6600CC" />
                </td>
                <td class="style8">
                    <asp:Button ID="Button6" runat="server" Text="11:00-11:30" 
                        onclick="Button6_Click" Visible="False" style="color: #6600CC" />
                </td>
                <td class="style9">
                    <asp:Button ID="Button7" runat="server" Text="11:30-12:00" 
                        onclick="Button7_Click" Visible="False" style="color: #6600CC" />
                </td>
               
            </tr>
            <tr>
                <td class="style2" style="width: 99px">
                    <asp:Label ID="Label2" runat="server" 
                        style="color: #996633; font-size: medium;" Text="Afternoon" 
                        Visible="False"></asp:Label>
                </td>
                <td class="style4">
                    <asp:Button ID="Button12" runat="server" Text="02:00-02:30" 
                        onclick="Button12_Click" Visible="False" style="color: #6600CC" />
                </td>
                <td class="style5">
                    <asp:Button ID="Button13" runat="server" Text="02:30-03:00" 
                        onclick="Button13_Click" Visible="False" style="color: #6600CC" />
                </td>
                <td class="style6">
                    <asp:Button ID="Button14" runat="server" Text="03:00-03:30" 
                        onclick="Button14_Click" Visible="False" style="color: #6600CC" />
                </td>
                <td class="style7">
                    <asp:Button ID="Button15" runat="server" Text="03:30-04:00" 
                        onclick="Button15_Click" Visible="False" style="color: #6600CC" />
                </td>
                <td class="style8">
                    <asp:Button ID="Button16" runat="server" Text="04:00-04:30" 
                        onclick="Button16_Click" Visible="False" style="color: #6600CC" />
                </td>
                <td class="style9">
                    <asp:Button ID="Button17" runat="server" Text="04:30-05:00" 
                        onclick="Button17_Click" Visible="False" style="color: #6600CC" />
                </td>
               
               
            </tr>
        </table>
      
     </br>
      
    
    </form>

</asp:Content>

