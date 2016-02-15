<%@ Page Language="C#" AutoEventWireup="true" CodeFile="MarketWatch.aspx.cs" Inherits="MarketWatch" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
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
            font-size: medium;
        }
    </style>
     <style type="text/css">
        	.container
		{
		    width: 800px;
			background: #ECECEC none;
			border: 1px solid #D5D4D4;
			height: 30px;
			margin: 0 auto;
			width: 100%;
		}
		.container .wrap
		{
			width: 800px;
			left: 5px;
			top: 0px;
			overflow: hidden;
			position: relative;
			line-height: 30px;
			font-size-adjust: none;
		}
		div.stockTicker
		{
			font-size: 10px;
			list-style-type: none;
			margin: 0;
			padding: 0;
			position: relative;
					}
		div.stockTicker span.quote
		{
			margin: 0;
			font-weight: bold;
			color: #000;
			padding: 0 5px 0 10px;
				}
		.GreenText
		{
			color: blue;
		}
		.RedText
		{
			color: Red;
		}
		.up_green
		{
			background: url(http://www.codescratcher.com/wp-content/uploads/2014/11/up.gif) no-repeat left center;
			padding-left: 10px;
			margin-right: 5px;
		}
		.down_red
		{
			background: url(http://www.codescratcher.com/wp-content/uploads/2014/11/down.gif) no-repeat left center;
			padding-left: 10px;
			margin-right: 5px;
		}
            .style6
            {
                width: 100%;
            }
            .style7
            {
                width: 157px;
                font-family: "Times New Roman", Times, serif;
                font-size: medium;
                color: #996633;
                text-align: center;
            }
            .style8
            {
                width: 176px;
            }
        </style>

          <script src="http://ajax.googleapis.com/ajax/libs/jquery/1.4.1/jquery.min.js"></script>
    <script type="text/javascript">
        (function ($) {
            $.fn.jStockTicker = function (options) {
                if (typeof (options) == 'undefined') {
                    options = {};
                }
                var settings = $.extend({}, $.fn.jStockTicker.defaults, options);
                var $ticker = $(this);
                var $wrap = null;
                settings.tickerID = $ticker[0].id;
                $.fn.jStockTicker.settings[settings.tickerID] = {};

                if ($ticker.parent().get(0).className != 'wrap') {
                    $wrap = $ticker.wrap("<div class='wrap'></div>");
                }

                var $tickerContainer = null;
                if ($ticker.parent().parent().get(0).className != 'container') {
                    $tickerContainer = $ticker.parent().wrap(
							"<div class='container'></div>");
                }

                var node = $ticker[0].firstChild;
                var next;
                while (node) {
                    next = node.nextSibling;
                    if (node.nodeType == 3) {
                        $ticker[0].removeChild(node);
                    }
                    node = next;
                }

                var shiftLeftAt = $ticker.children().get(0).offsetWidth;
                $.fn.jStockTicker.settings[settings.tickerID].shiftLeftAt = shiftLeftAt;
                $.fn.jStockTicker.settings[settings.tickerID].left = 0;
                $.fn.jStockTicker.settings[settings.tickerID].runid = null;
                $ticker.width(2 * screen.availWidth);

                function startTicker() {
                    stopTicker();

                    var params = $.fn.jStockTicker.settings[settings.tickerID];
                    params.left -= settings.speed;
                    if (params.left <= params.shiftLeftAt * -1) {
                        params.left = 0;
                        $ticker.append($ticker.children().get(0));
                        params.shiftLeftAt = $ticker.children().get(0).offsetWidth;
                    }

                    $ticker.css('left', params.left + 'px');
                    params.runId = setTimeout(arguments.callee, settings.interval);

                    $.fn.jStockTicker.settings[settings.tickerID] = params;
                }

                function stopTicker() {
                    var params = $.fn.jStockTicker.settings[settings.tickerID];
                    if (params.runId)
                        clearTimeout(params.runId);

                    params.runId = null;
                    $.fn.jStockTicker.settings[settings.tickerID] = params;
                }

                function updateTicker() {
                    stopTicker();
                    startTicker();
                }

                $ticker.hover(stopTicker, startTicker);
                startTicker();
            };

            $.fn.jStockTicker.settings = {};
            $.fn.jStockTicker.defaults = {
                tickerID: null,
                url: null,
                speed: 1,
                interval: 20
            };
        })(jQuery);
    </script>
	<script type="text/javascript">
	    $(window).load(function () {
	        StockPriceTicker();
	        setInterval(function () { StockPriceTicker(); }, 60000);
	    });
	    function StockPriceTicker() {
	        var Symbol = "", CompName = "", Price = "", ChnageInPrice = "", PercentChnageInPrice = "";
	        var CNames = "^FTSE,HSBA.L,SL.L,BATS.L,BLND.L,FLG.L,RBS.L,RMG.L,VOD.L";
	        var flickerAPI = "http://query.yahooapis.com/v1/public/yql?q=select%20*%20from%20yahoo.finance.quotes%20where%20symbol%20in%20(%22" + CNames + "%22)&env=store://datatables.org/alltableswithkeys";
	        var StockTickerHTML = "";

	        var StockTickerXML = $.get(flickerAPI, function (xml) {
	            $(xml).find("quote").each(function () {
	                Symbol = $(this).attr("symbol");
	                $(this).find("Name").each(function () {
	                    CompName = $(this).text();
	                });
	                $(this).find("LastTradePriceOnly").each(function () {
	                    Price = $(this).text();
	                });
	                $(this).find("Change").each(function () {
	                    ChnageInPrice = $(this).text();
	                });
	                $(this).find("PercentChange").each(function () {
	                    PercentChnageInPrice = $(this).text();
	                });

	                var PriceClass = "GreenText", PriceIcon = "up_green";
	                if (parseFloat(ChnageInPrice) < 0) { PriceClass = "RedText"; PriceIcon = "down_red"; }
	                StockTickerHTML = StockTickerHTML + "<span class='" + PriceClass + "'>";
	                StockTickerHTML = StockTickerHTML + "<span class='quote'>" + CompName + " (" + Symbol + ")</span> ";

	                StockTickerHTML = StockTickerHTML + parseFloat(Price).toFixed(2) + " ";
	                StockTickerHTML = StockTickerHTML + "<span class='" + PriceIcon + "'></span>" + parseFloat(Math.abs(ChnageInPrice)).toFixed(2) + " (";
	                StockTickerHTML = StockTickerHTML + parseFloat(Math.abs(PercentChnageInPrice.split('%')[0])).toFixed(2) + "%)</span>";
	            });

	            $("#dvStockTicker").html(StockTickerHTML);
	            $("#dvStockTicker").jStockTicker({ interval: 30, speed: 2 });
	        });
	    }
    </script>   

    <script  type="text/javascript" language="JavaScript">
        /// <summary>
        /// This function will be called when user clicks the Get Quotes button.
        /// </summary>
        /// <returns>Always return false.</returns>
        function SendRequest() {
            var txtSymbol = document.getElementById("txtSymbol");
            // Refresh the page.
            window.location = "MarketWatch.aspx?s=" + txtSymbol.value;
            return false;
        }

        /// <summary>
        /// The functyion will be called when a keyboard key is pressed in the textbox.
        /// </summary>
        /// <param name="e">Onkeypress event.</param>
        /// <returns>Return true if user presses Enter key; otherwise false.</returns>        
        function CheckEnter(e) {
            if ((e.keyCode && e.keyCode == 13) || (e.which && e.which == 13))
            // Enter is pressed in the textbox.
                return SendRequest();
            return true;
        }

        /// <summary>
        /// The function will be called when user changes the chart type to another type.
        /// </summary>
        /// <param name="type">Chart type.</param>
        /// <param name="num">Stock number.</param>
        /// <param name="symbol">Stock symobl.</param>
        function changeChart(type, num, symbol) {
            // All the DIVs are inside the main DIV and defined in the code-behind class.
            var div1d = document.getElementById("div1d_" + num);
            var div5d = document.getElementById("div5d_" + num);
            var div3m = document.getElementById("div3m_" + num);
            var div6m = document.getElementById("div6m_" + num);
            var div1y = document.getElementById("div1y_" + num);
            var div2y = document.getElementById("div2y_" + num);
            var div5y = document.getElementById("div5y_" + num);
            var divMax = document.getElementById("divMax_" + num);
            var divChart = document.getElementById("imgChart_" + num);
            // Set innerHTML property.
            div1d.innerHTML = "1d";
            div5d.innerHTML = "5d";
            div3m.innerHTML = "3m";
            div6m.innerHTML = "6m";
            div1y.innerHTML = "1y";
            div2y.innerHTML = "2y";
            div5y.innerHTML = "5y";
            divMax.innerHTML = "Max";
            // Use a random number to defeat cache.
            var rand_no = Math.random();
            rand_no = rand_no * 100000000;
            // Display the stock chart.
            switch (type) {
                case 1: // 5 days
                    div5d.innerHTML = "<b>5d</b>";
                    divChart.src = "http://ichart.finance.yahoo.com/w?s=" + symbol + "&" + rand_no;
                    break;
                case 2: // 3 months 
                    div3m.innerHTML = "<b>3m</b>";
                    divChart.src = "http://chart.finance.yahoo.com/c/3m/" + symbol + "?" + rand_no;
                    break;
                case 3: // 6 months 
                    div6m.innerHTML = "<b>6m</b>";
                    divChart.src = "http://chart.finance.yahoo.com/c/6m/" + symbol + "?" + rand_no;
                    break;
                case 4: // 1 year
                    div1y.innerHTML = "<b>1y</b>";
                    divChart.src = "http://chart.finance.yahoo.com/c/1y/" + symbol + "?" + rand_no;
                    break;
                case 5: // 2 years 
                    div2y.innerHTML = "<b>2y</b>";
                    divChart.src = "http://chart.finance.yahoo.com/c/2y/" + symbol + "?" + rand_no;
                    break;
                case 6: // 5 years
                    div5y.innerHTML = "<b>5y</b>";
                    divChart.src = "http://chart.finance.yahoo.com/c/5y/" + symbol + "?" + rand_no;
                    break;
                case 7: // Max
                    divMax.innerHTML = "<b>msx</b>";
                    divChart.src = "http://chart.finance.yahoo.com/c/my/" + symbol + "?" + rand_no;
                    break;
                case 0: // 1 day
                default:
                    div1d.innerHTML = "<b>1d</b>";
                    divChart.src = "http://ichart.finance.yahoo.com/b?s=" + symbol + "&" + rand_no;
                    break;
            }
        }
    </script> 
</head>
<body> 
<form name="from1" runat="server">

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
                <li class="style3"><a href="UserHome.aspx" class="current">Home</a></li>
                <li class="style3"><a href="Portfolio.aspx">Portfolio</a></li>
                <li class="style3"><a href="MarketWatch.aspx">Market Watch</a></li>
                <li class="style3"><a href="NewOrder.aspx">New Order</a></li>
               
                <li class="style3"><a href="OrderHistory.aspx">Order History</a></li>
                <li class="style3"><a href="Logout.aspx">Signout</a></li>
            </ul>    	
        
        </div> <!-- end of tooplate_menu -->
        
    </div>	  
</div> <!-- end of header_wrapper -->



<div id="tooplate_main">
    
    <div id="tooplate_content">
    
        
        <div id="StockTickerContainer"  style="height: 32px; line-height: 32px; overflow: hidden;">
        <div id='dvStockTicker' class='stockTicker'>
        </div>
        </div>
        <br />

        <table align="center" class="style6">
            <tr>
                <td class="style7">
                    Select Symbol :
                </td>
                <td class="style8">
                    <asp:DropDownList ID="txtSymbol" runat="server" onkeypress="return CheckEnter(event);" AutoPostBack="True" 
                        style="font-family: 'Times New Roman', Times, serif; font-size: medium">
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
                  <%--  <input type="text" value="" id="txtSymbol" runat="server" onkeypress="return CheckEnter(event);" />--%>
                </td>
                <td>
                     <input type="button" value="Market Quotes" onclick="return SendRequest();" 
                        style="color: #800000" />
                         
                          
                        
                          
                       
                </td>
            </tr>
            <tr>
            <td colspan=3 height="400" width="400">
             <%if (m_symbol != "") {%>     
             <div id="divService" runat="server">
                        <!-- Main DIV: this DIV contains contains text and DIVs that displays stock quotes and chart. -->
                        </div>
                    <%}%>              
            
            </td>
            
            </tr>
    </table> 
        
        
    </div>
    
        <div id="tooplate_sidebar">
        
            <h2 class="style3">Our Services</h2>
            
            <ul class="tooplate_list">
            <li><a href="Reports.aspx">Reports</a></li>
            <li><a href="Statements.aspx">Statements</a></li>
            <li><a href="Mobile.aspx">Mobile Trading</a></li>
            <li><a href="CashBox.aspx">Cash Box</a></li>
            <li><a href="UContact.aspx">Contact Us</a></li>
            
            </ul>
           
            
         
            
            <h2 class="style5">Personal Information</h2>
            <ul class="tooplate_list">
           <li><a href="UserProfile.aspx">Profile Details</a></li>
            <li><a href="UpdateProfile.aspx">Update Profile</a></li>
            <li><a href="Id.aspx">Membership ID</a></li>
            <li><a href="ChangePassword.aspx">Change Password</a></li>
            </ul>
            
        
        
        
        </div>
        
</div>

    <div class="cleaner"></div>  

<div id="tooplate_footer_wrapper">

     <div id="tooplate_footer">
    
        Copyright © 2048 Trade Monitoring&nbsp;@ &nbsp;&nbsp<a href="http://www.trademonitoring.somee.com">trademonitoring.somee.com</a>
    
    </div> <!-- end of tooplate_footer -->

</div> 
    </form>
</body>
</html>