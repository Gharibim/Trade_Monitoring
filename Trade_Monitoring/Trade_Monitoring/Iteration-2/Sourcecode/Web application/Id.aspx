<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Id.aspx.cs" Inherits="Id" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
   <title>Trade Monitoring</title>
  
   
    <script type="text/javascript">
        function printpage() {
            window.print();
        }
    </script>
  
    <style type="text/css">
        .style1
        {
            width: 40%;
            height: 337px;
        }
        .style4
        {
            width: 306px;
            height: 71px;
        }
        .style6
        {
            width: 279px;
            text-align: center;
        }
        .style7
        {
            width: 452px;
        }
        .style9
        {
            width: 600px;
            height: 72px;
        }
        .style11
        {
            font-family: "Times New Roman", Times, serif;
            font-size: x-large;
            color: #00CCFF;
        }
        .style12
        {
            width: 279px;
            color: #FF33CC;
        }
        .style13
        {
            color: #0000FF;
        }
        .style14
        {
            width: 279px;
            height: 34px;
        }
        .style15
        {
            width: 452px;
            height: 34px;
        }
    </style>
  
</head>
<body>
    <form id="form1" runat="server">
    <div>
  
       
           <table align="center" class="style1" 
               style="background-color: #999966; border: medium solid #808000">
               <tr>
                  
                   <td colspan="2" class="style11" style="text-align: center">
                      
                       <strong>MEMBERSHIP ID</strong></td>
                  
                  
               </tr>
               <tr>
                  
                   <td class="style4" colspan="2">
                       <img alt="" class="style9" src="images/id1.png" /></td>
                   
                   
               </tr>
               <tr>
                   
                   <td class="style12">
                       Full Name</td>
                   <td class="style7">
                       <asp:Label ID="Label2" runat="server" Text="Label" CssClass="style13"></asp:Label>
                   </td>
                  
               </tr>
               <tr>
                  
                   <td class="style12">
                       ID No</td>
                   <td class="style7">
                       <asp:Label ID="Label3" runat="server" Text="Label" CssClass="style13"></asp:Label>
                   </td>
                
               </tr>
               <tr>
                  
                   <td class="style12">
                       Phone Num</td>
                   <td class="style7">
                       <asp:Label ID="Label4" runat="server" Text="Label" CssClass="style13"></asp:Label>
                   </td>
                  
               </tr>
               <tr>
                   
                   <td class="style14">
                       </td>
                   <td class="style15">
                       </td>
                  
               </tr>
               <tr>
                  
                   <td class="style6">
                       <input onclick="printpage()" type="button" value="Print" 
                           style="text-align: center; width: 91px;" /></td>
                   <td style="text-align: center">
                       <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="HOME" />
                   </td>
                  
               </tr>
           </table>
  
       
           
                  
            
            
              
  
   </div>
    </form>
</body>
</html>
