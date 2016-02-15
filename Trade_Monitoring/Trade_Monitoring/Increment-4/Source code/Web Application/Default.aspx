<%@ Page  Async="true" Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ConvertTextToSpeech.Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">

<head>
   
       <title>Trade Marketing</title> 
<meta name="keywords" content="" />
<meta name="description" content="" />
<!--
Template 2033 Business
http://www.tooplate.com/view/2033-business
-->
<link href="tooplate_style.css" rel="stylesheet" type="text/css" />

    <style type="text/css">
        .style1
        {
            color: #CC6600;
            font-size: xx-large;
            font-family: "Times New Roman", Times, serif;
        }
        .style2
        {
            font-family: "Times New Roman", Times, serif;
            color: #0066FF;
        }
        .style3
        {
            font-family: "Times New Roman", Times, serif;
        }
        .style4
        {
            font-family: "Times New Roman", Times, serif;
            color: #CC66FF;
            font-size: large;
            font-weight: normal;
        }
        .style5
        {
            font-family: "Times New Roman", Times, serif;
            color: #FF0066;
        }
        .style6
        {
            font-family: "Times New Roman", Times, serif;
            font-size: x-large;
            text-align: center;
            color: #990000;
        }
    </style>

    </head>  


    <body> 

<div id="tooplate_header_wrapper">

    <div id="tooplate_header">
    
        <div id="site_title">
      
        
        	<%--<h1><a href="#"><img src="images/tooplate_logo.png" alt="business template" /><span>Free HTML Template</span></a></h1>--%>
        
            <span class="style1"><strong>TRADE MONITORING<br />
            </strong></span>
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <span class="style2">&nbsp; .... A Place for Marketing and Innovation</span></div> <!-- end of site_title -->
        
        <div id="header_phone_no">

			Toll Free : <span class="style4"><strong>05 713 091 416 </strong></span>
        
        </div>
        
        <div class="cleaner_h10"></div>
        
        <div id="tooplate_menu">
        	
            <div id="home_menu"><a href="#"></a></div>
                
            <ul>
                <li class="style3"><a href="home.aspx" class="current">Home</a></li>
                <li class="style3"><a href="aboutus.aspx">About Us</a></li>
                <li class="style3"><a href="services.aspx">Services</a></li>
                <li class="style3"><a href="mobile.aspx">Mobile Trading</a></li>
                <li class="style3"><a href="contact.aspx">Contact Us</a></li>
                <li class="style3"><a href="LoginPage.aspx">Login/Register</a></li>
            </ul>    	
        
        </div> <!-- end of tooplate_menu -->
        
    </div>	  
</div> <!-- end of header_wrapper -->



<div id="tooplate_main">
    
    <div id="tooplate_content">
            
       
        <form id="form2" runat="server">  

        <table width="100%">
        <tr>
        
        <td class="style6">
        
            Text to Sppech and Speech to Text<br />
        
        </td>
        </tr>
        
        </table>
       
            <table width="100%">  
                <tr>  
                    <td style="text-align: center">  
                        <asp:TextBox ID="txtMsg" TextMode="MultiLine" runat="server" Height="101px" 
                            Width="380px"></asp:TextBox><br />  
                    </td>  
                </tr>  
           
                <tr>  
                    
                    <td style="text-align: center">  
                       &nbsp  <asp:Button ID="btVoice" runat="server" 
                            Text="Convert to Speech" onclick="btnVoice_Click" />  
                    </td>  
                  
                </tr>  
            </table>  

             <table width="100%">
            <tr>
            <td style="text-align: center">
            <asp:TextBox ID="TextBox1" TextMode="MultiLine" Width="400" Height="100" runat="server"></asp:TextBox>
            </td>
            </tr>

          <tr>
          
          <td>
         &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
         &nbsp; <button id="button1" onclick="toggleStartStop()" type="button" BorderWidth="0px" CausesValidation="false" ></button>
          </td>
          </tr>
            
            </table>


               <script type="text/javascript">
                   var recognizing;
                   var recognition = new webkitSpeechRecognition();
                   recognition.continuous = true;
                   reset();
                   recognition.onend = reset();
                   recognition.onresult = function (event) {
                       for (var i = event.resultIndex; i < event.results.length; ++i) {
                           if (event.results[i].isFinal) {
                               TextBox1.value += event.results[i][0].transcript;
                           }
                       }
                   }
                   function reset() {
                       recognizing = false;
                       button1.innerHTML = "<img src='Images/mic.png' width='15px' height='25px'>";
                   }
                   function toggleStartStop() {
                       if (recognizing) {
                           recognition.stop();
                           reset();
                       } else {
                           recognition.start();
                           recognizing = true;
                           button1.innerHTML = " <img src='Images/micst.jpg' width='15px' height='25px'>";
                       }
                   }
</script>
  
        </form>  
     
                  
        
    </div>
    
        <div id="tooplate_sidebar">
        
             <h2 class="style5">Our Services</h2>
            
            <ul class="tooplate_list">
            <li><a href="trading.aspx">What Is Trading?</a></li>
            <li><a href="placeorder.aspx">How to Place order?</a></li>
            <li><a href="tradehistory.aspx">Trade History</a></li>
            <li><a href="billing.aspx">Billing Details</a></li>
            <li><a href="location.aspx">Office Address</a></li>
            <li><a href="Album.aspx">Gallery</a></li>
             <li><a href="faq.aspx">FAQ?</a></li>
              <li><a href="Default.aspx">Special Features</a></li>
            
            </ul>
           
            
            </br>
            
           
        
        
        
        </div>
        
</div>

    <div class="cleaner"></div>  


<div id="tooplate_footer_wrapper">

     <div id="tooplate_footer">
    
      Copyright © 2015 Trade Monitoring&nbsp;@ &nbsp;&nbsp<a href="http://www.trademonitoring.somee.com">trademonitoring.somee.com</a>
    
    </div> <!-- end of tooplate_footer -->

</div> 
    
</body>
</html>

   
