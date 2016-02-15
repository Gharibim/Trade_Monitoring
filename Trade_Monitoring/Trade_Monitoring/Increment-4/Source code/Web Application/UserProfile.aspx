<%@ Page Title="" Language="C#" MasterPageFile="~/UserMaster.master" AutoEventWireup="true" CodeFile="UserProfile.aspx.cs" Inherits="UserProfile" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Middle" Runat="Server">

   <form id="form1" runat="server">



    <table style="width: 100%; height: 195px">
        <tr>
            <td style="width: 389px">
    
    <table style="width: 100%; height: 174px">
        <tr>
            <td class="style3" 
                style="font-size: medium; width: 175px; color: #996633; height: 28px">
                Membership ID</td>
            <td style="height: 28px">
                <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="style3" style="font-size: medium; width: 175px; color: #996633">
                Full Name</td>
            <td>
                <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="style3" style="font-size: medium; width: 175px; color: #996633">
                User Name</td>
            <td>
                <asp:Label ID="Label3" runat="server" Text="Label" ></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="style3" style="font-size: medium; width: 175px; color: #996633">
                Email Address</td>
            <td>
                <asp:Label ID="Label4" runat="server" Text="Label" ></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="style3" style="font-size: medium; width: 175px; color: #996633">
                Phone Number</td>
            <td>
                <asp:Label ID="Label5" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="style3" style="font-size: medium; width: 175px; color: #996633">
                Joining Date</td>
            <td>
                <asp:Label ID="Label6" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
    </table>


            </td>
            <td>
                
                 <asp:Image ID="Image1" runat="server" 
                                ImageUrl='<%# "~/Handler.ashx?ID=" + Eval("id")%>' style="width: 206px; height: 193px; margin-left: 0px; margin-right: 0px;"  />           
     <table width="173"> 
     <tr> <td colspan="3" style="color: #FF0066">      <asp:LinkButton ID="LinkButton1" OnClick="change_click"  Font-Underline="false" runat="server"><font color="red">Change profile Picture</font></asp:LinkButton>
         
           </td>
 </tr> 
 
            <tr>
               
                <td>
                    <asp:FileUpload ID="FileUpload1" Visible="false" runat="server" />
                </td>
            </tr>
         
            
            <tr>
                <td colspan="2">
                    <asp:Button ID="Button1" runat="server" Visible="false" OnClick="Button1_Click" Text="Submit" /></td>
            </tr>
             <tr><td colspan="3">
        <asp:Label ID="Label7" runat="server" Visible="false" Text="Label"></asp:Label></td></tr>
           
  </table>
                
                
                </td>
        </tr>
    </table>
    

    <br />
    </form>

</asp:Content>

