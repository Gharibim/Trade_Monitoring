<%@ Page Title="" Language="C#" MasterPageFile="~/UserMaster.master" AutoEventWireup="true" CodeFile="UpdateProfile.aspx.cs" Inherits="UpdateProfile" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Middle" Runat="Server">

    <form id="form1" runat="server">

    <table style="width: 100%">
        <tr>
            <td class="style3" style="font-size: large; text-align: center; color: #990000">
                UPDATE PROFILE</td>
        </tr>
    </table>

<br />

<table style="width: 100%; height: 174px">
        <tr>
        <td style="width: 126px"></td>
            <td class="style3" 
                style="font-size: medium; width: 175px; color: #996633; height: 28px">
                Membership ID</td>
            <td style="height: 28px">
                <asp:Label ID="Label1" runat="server" Text="Label" style="color: #0066FF"></asp:Label>
            </td>
            <td></td>
        </tr>
        <tr>
        <td style="width: 126px"></td>
            <td class="style3" style="font-size: medium; width: 175px; color: #996633">
                Full Name</td>
            <td>
                <asp:Label ID="Label2" runat="server" Text="Label" style="color: #0066FF"></asp:Label>
            </td>
            <td></td>
        </tr>
        <tr>
        <td style="width: 126px"></td>
            <td class="style3" style="font-size: medium; width: 175px; color: #996633">
                User Name</td>
            <td>
                <asp:Label ID="Label3" runat="server" Text="Label" style="color: #0066FF" ></asp:Label>
            </td>
            <td></td>
        </tr>
        <tr>
        <td style="width: 126px"></td>
            <td class="style3" style="font-size: medium; width: 175px; color: #996633">
                Email Address</td>
            <td>
                <asp:TextBox ID="TextBox1" runat="server" style="color: #000000"></asp:TextBox>
            </td>
            <td></td>
        </tr>
        <tr>
        <td style="width: 126px"></td>
            <td class="style3" style="font-size: medium; width: 175px; color: #996633">
                Phone Number</td>
            <td>
                <asp:TextBox ID="TextBox2" runat="server" style="color: #000000"></asp:TextBox>
            </td>
            <td></td>
        </tr>
        <tr>
        <td style="width: 126px"></td>
            <td class="style3" style="font-size: medium; width: 175px; color: #996633">
                Joining Date</td>
            <td>
                <asp:Label ID="Label6" runat="server" Text="Label" style="color: #0066FF"></asp:Label>
            </td>
            <td></td>
        </tr>
        <tr>
         <td style="width: 126px"></td>
            <td>
               </td>
            <td>
                
            </td>
            <td></td>
        </tr>
        <tr>
         <td style="width: 126px"></td>
            <td>
               </td>
            <td>
                
                <asp:Button ID="Button1" runat="server" onclick="Button1_Click" 
                    style="font-family: 'Times New Roman', Times, serif; color: #990000; font-size: medium" 
                    Text="Update" />
                
            </td>
            <td></td>
        </tr>
    </table>

    </form>

</asp:Content>

