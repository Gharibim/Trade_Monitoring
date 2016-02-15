<%@ Page Title="" Language="C#" MasterPageFile="~/LoginMaster.master" Debug="true" AutoEventWireup="true" CodeFile="Continue.aspx.cs" Inherits="Continue" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Middle" Runat="Server">


                        
 

                      
    <form id="form1" runat="server">


                        
 

                      
    <table style="width: 102%; height: 41px; color: #990000; background-image: url('images/bg.jpg');">
        <tr>
            <td class="style3" 
                style="font-size: xx-large; color: #009933; text-align: center;">
                MAKE PAYMENT</td>
        </tr>
    </table>


                        
 

                      
    <table style="width: 102%; height: 340px; background-image: url('images/bg.jpg');">
        <tr>
            <td style="width: 35px; height: 42px;">
                </td>
            <td style="width: 181px; height: 42px; font-size: medium; color: #996633;" 
                class="style3">
                Years Of Membership</td>
            <td class="col_w270" style="width: 375px; height: 42px;">
                <asp:DropDownList ID="DropDownList1" runat="server" 
                    onselectedindexchanged="DropDownList1_SelectedIndexChanged" 
                    AutoPostBack="True" Width="174px">
                    <asp:ListItem Value="0">--Select Years--</asp:ListItem>
                    <asp:ListItem>1</asp:ListItem>
                    <asp:ListItem>2</asp:ListItem>
                    <asp:ListItem>3</asp:ListItem>
                    <asp:ListItem>4</asp:ListItem>
                    <asp:ListItem>5</asp:ListItem>
                    <asp:ListItem>6</asp:ListItem>
                    <asp:ListItem>7</asp:ListItem>
                    <asp:ListItem>8</asp:ListItem>
                    <asp:ListItem>9</asp:ListItem>
                    <asp:ListItem>10</asp:ListItem>
                    <asp:ListItem>11</asp:ListItem>
                    <asp:ListItem>12</asp:ListItem>
                    <asp:ListItem>13</asp:ListItem>
                    <asp:ListItem>14</asp:ListItem>
                    <asp:ListItem>15</asp:ListItem>
                    <asp:ListItem>16</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td style="width: 10px; height: 42px;">
                </td>
        </tr>
        <tr>
            <td style="height: 33px; width: 35px">
                </td>
            <td style="width: 181px; height: 33px; font-size: medium; color: #996633;" 
                class="style3">
                Total Amount 
                ($)</td>
            <td class="col_w270" style="width: 475px; height: 33px;">
                <asp:TextBox ID="TextBox1" ReadOnly="true" runat="server"></asp:TextBox>
            </td>
            <td style="height: 33px; width: 10px">
                </td>
        </tr>
        <tr>
            <td style="width: 35px">
                &nbsp;</td>
            <td style="width: 181px; font-size: medium; color: #996633;" class="style3">
                Card Number</td>
            <td class="col_w270" style="width: 475px">
                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            </td>
            <td style="width: 10px">
                &nbsp;</td>
        </tr>
        <tr>
            <td style="width: 35px">
                &nbsp;</td>
            <td style="width: 181px; font-size: medium; color: #996633;" class="style3">
                Expiry Date</td>
            <td class="col_w270" style="width: 475px">
                <asp:DropDownList ID="DropDownList2" runat="server" Width="155px" 
                    AutoPostBack="True" onselectedindexchanged="DropDownList2_SelectedIndexChanged">
                    <asp:ListItem Value="0">-- Select Month --</asp:ListItem>
                    <asp:ListItem Value="1">JAN</asp:ListItem>
                    <asp:ListItem Value="2">FEB</asp:ListItem>
                    <asp:ListItem Value="3">MAR</asp:ListItem>
                    <asp:ListItem Value="4">APR</asp:ListItem>
                    <asp:ListItem Value="5">MAY</asp:ListItem>
                    <asp:ListItem Value="6">JUN</asp:ListItem>
                    <asp:ListItem Value="7">JULY</asp:ListItem>
                    <asp:ListItem Value="8">AUG</asp:ListItem>
                    <asp:ListItem Value="9">SEP</asp:ListItem>
                    <asp:ListItem Value="10">OCT</asp:ListItem>
                    <asp:ListItem Value="11">NOV</asp:ListItem>
                    <asp:ListItem Value="12">DEC</asp:ListItem>
                </asp:DropDownList>
                <asp:DropDownList ID="DropDownList3" runat="server" AutoPostBack="True">
                                     


                </asp:DropDownList>
                <asp:DropDownList ID="DropDownList4" runat="server">
                 <asp:ListItem Value="0">-- Select Year --</asp:ListItem>
                    <asp:ListItem>2016</asp:ListItem>
                    <asp:ListItem>2017</asp:ListItem>
                    <asp:ListItem>2018</asp:ListItem>
                    <asp:ListItem>2019</asp:ListItem>
                    <asp:ListItem>2020</asp:ListItem>
                    <asp:ListItem>2021</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td style="width: 10px">
                &nbsp;</td>
        </tr>
        <tr>
            <td style="width: 35px">
                &nbsp;</td>
            <td style="width: 181px; font-size: medium; color: #996633;" class="style3">
                Card Type</td>
            <td class="col_w270" style="width: 475px">
                <asp:DropDownList ID="DropDownList5" runat="server" Width="175px">
                 <asp:ListItem Value="0">-- Select Card Type --</asp:ListItem>
                    <asp:ListItem>Visa</asp:ListItem>
                    <asp:ListItem>Master</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td style="width: 10px">
                &nbsp;</td>
        </tr>
        <tr>
            <td style="width: 35px">
                &nbsp;</td>
            <td style="width: 181px; font-size: medium; color: #996633;" class="style3">
                Security Number</td>
            <td class="col_w270" style="width: 475px">
                <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            </td>
            <td style="width: 10px">
                &nbsp;</td>
        </tr>
        <tr>
            <td style="width: 35px">
                &nbsp;</td>
            <td style="width: 181px; color: #996633;">
                &nbsp;</td>
            <td class="col_w270" style="width: 475px">
                <asp:ImageButton ID="ImageButton1" runat="server" Height="40px" 
                    ImageUrl="~/images/submit.png" Width="143px" 
                    onclick="ImageButton1_Click" />
            </td>
            <td style="width: 10px">
                &nbsp;</td>
        </tr>
        <tr>
            <td style="width: 35px">
                &nbsp;</td>
            <td style="width: 181px; color: #996633;">
                &nbsp;</td>
            <td class="col_w270" style="width: 475px">
                &nbsp;</td>
            <td style="width: 10px">
                &nbsp;</td>
        </tr>
    </table>
    </form>

                        
 

                      
</asp:Content>

