<%@ Page Language="C#" AutoEventWireup="true" CodeFile="next.aspx.cs" Inherits="next" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
   <meta charset="utf-8" />
	<meta name="viewport" content="width=device-width, initial-scale=1, minimum-scale=1, maximum-scale=1, user-scalable=0" />
	<title>Trade Monitoring</title>
	<link rel="shortcut icon" type="image/x-icon" href="css/images/favicon.ico" />
	<link rel="stylesheet" href="css/style.css" type="text/css" media="all" />
	<link href='http://fonts.googleapis.com/css?family=Raleway:400,900,800,700,600,500,300,200,100' rel='stylesheet' type='text/css'>
	
	<script src="js/jquery-1.8.0.min.js" type="text/javascript"></script>
	<!--[if lt IE 9]>
		<script src="js/modernizr.custom.js"></script>
	<![endif]-->
	<script src="js/jquery.carouFredSel-5.5.0-packed.js" type="text/javascript"></script>
	<script src="js/functions.js" type="text/javascript"></script>
    <script type="text/javascript">

        function validate() {

            var name = document.getElementById('TextBox1').value;
            var num = document.getElementById('TextBox5').value;


            if (!isNaN(name)) {
                alert("Please enter Alphabets");
                return false;

            }
            else if (isNaN(num)) {
                alert("please enter the Digits");
                return false;
            }
            else if (num.length > 10) {
                alert(" Mobile Num should be 10 Digits only");
                return false;
            }
            else {

            }

        }
    
    
    </script>
    
    
      <style type="text/css">
        .auto-style1 {
            width: 100%;
            height: 18px;
        }
        .auto-style2 {
            font-size: x-large;
        }
        .auto-style3 {
            color: #00FFFF;
        }
        .auto-style4 {
            width: 83%;
        }
        .auto-style5 {
            text-align: center;
            color: #FF0000;
            font-size: x-large;
        }
        .auto-style6 {
            width: 102px;
        }
        .auto-style7 {
            width: 344px;
        }
        .auto-style8 {
            width: 67px;
        }
        .auto-style9 {
            font-size: large;
            height: 36px;
        }
        .auto-style10 {
            width: 67px;
            font-size: large;
            height: 36px;
        }
        .auto-style11 {
            width: 102px;
            font-size: large;
            height: 36px;
            color: #3333CC;
        }
        .auto-style12 {
            width: 344px;
            font-size: large;
            height: 36px;
        }
        .auto-style13 {
            width: 344px;
            height: 32px;
        }
        .auto-style14 {
            width: 102px;
            height: 32px;
        }
        .auto-style15 {
            width: 67px;
            height: 32px;
        }
        .auto-style16 {
            height: 32px;
        }
        .auto-style17 {
            width: 102px;
            height: 32px;
            color: #0000CC;
        }
        .auto-style18 {
            color: #800000;
        }
    </style>
    <style type="text/css">
        .style1
        {
            color: #00CCFF;
        }
        .style2
        {
            font-size: xx-large;
        }
    </style>
    <style type="text/css">
		.container
		{
			background: #ECECEC none;
			border: 1px solid #D5D4D4;
			height: 30px;
			margin: 0 auto;
			width: 928px;
		}
		.container .wrap
		{
			width: 920px;
			left: 5px;
			top: 0px;
			overflow: hidden;
			position: relative;
			line-height: 30px;
			font-size-adjust: none;
		}
		div.stockTicker
		{
			font-size: 18px;
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
			color: Blue;
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
	    .style3
        {
            width: 135px;
            height: 50px;
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
</head>
<body>
<form id="id1" runat="server">
<!-- wrapper -->
<div id="wrapper">
	<!-- shell -->
	<div class="shell">
		<!-- container -->
		
			<!-- header -->
			<table><tr>		<td>
            
                <img alt="" class="style3" src="img/logo1.png" 
                    style="background-image: url('img/background.png')" /></td>	<td>	<h1 class="style1">&nbsp; <span class="style2">TRADE MONITORING</span></h1></td>
				<!-- search -->
				
				<!-- end of search -->
				<div class="cl">&nbsp;</div>
                </tr>

                </table>
			</br>
           
			<!-- end of header -->
			<!-- navigaation -->
			<nav id="navigation">
				<a href="#" class="nav-btn">HOME<span></span></a>
				<ul>
					<li class="active"><a href="homepage.aspx">home</a></li>
					<li><a href="about.aspx">About Us</a></li>
					<li><a href="services.aspx">Services</a></li>
					<li><a href="mobile.aspx">Trade On Mobile</a></li>
					<li><a href="appointment.aspx">Schedule Appointment</a></li>
					<li><a href="contact.aspx">contact Us</a></li>
                    <li><a href="login.aspx">Login/Register</a></li>
				</ul>
				<div class="cl">&nbsp;</div>
			</nav>
            <br />
            <table width="100%">
            <tr>
            <td width="100%">
            <div id="StockTickerContainer" style="height: 32px; line-height: 32px; overflow: hidden;">
        <div id='dvStockTicker' class='stockTicker'>
        </div>
    </div>
            </td>
            </tr>
            </table>
            <br />
        
			<!-- end of navigation -->
			<!-- slider-holder -->
			

			<!-- main -->
            <table width="100%" align="center">
            
            <tr>
                <td width="300" heght="300"></td>
                <td>

                <table>
                <tr>
                <h2><font color="purple">Create New Account Here</font></h2>
                </tr>
                </table>
                </br>
                <table align="center" heght="300">
                <tr>
            <td><asp:Label ID="Label1" runat="server" Text="User Name"></asp:Label> </td>
            <td><asp:TextBox ID="TextBox1" runat="server"></asp:TextBox></td>
                
            
            </tr>
            <tr>
            <td><asp:Label ID="Label2" runat="server"  Text="Password"></asp:Label> </td>
            <td><asp:TextBox ID="TextBox2"  TextMode="Password" runat="server"></asp:TextBox></td>
            </tr>
  <tr>
            <td><asp:Label ID="Label3" runat="server" Text="Email ID"></asp:Label> </td>
            <td><asp:TextBox ID="TextBox3" runat="server"></asp:TextBox></td>
            </tr>
              <tr>
            <td><asp:Label ID="Label4" runat="server" Text="Address"></asp:Label> </td>
            <td><asp:TextBox ID="TextBox4" TextMode="MultiLine" runat="server"></asp:TextBox></td>
            </tr>
              <tr>
            <td><asp:Label ID="Label5" runat="server" Text="Mobile No"></asp:Label> </td>
            <td><asp:TextBox ID="TextBox5" runat="server"></asp:TextBox></td>
            </tr>
            <tr><td></td>
            <td>&nbsp;</td>
                
            </tr>
            <tr>
            <td></td><td></td><td><asp:ImageButton ID="ImageButton1" Width="100" Height="50" OnClientClick="validate()" OnClick="next.aspx" ImageUrl="img/continue.png" runat="server" /></td>
                </tr>
            </table>
            </td>
            <td width="300" height="300"></td>
            </tr>
            </table>
			<div class="main">

				

				<section class="cols">
					
			</div>
        
			<!-- end of main -->
			<div class="cl">&nbsp;</div>
			
			<!-- footer -->
			
			<!-- end of footer -->
		</div>
		<!-- end of container -->
	</div>
	<!-- end of shell -->
</div>
<!-- end of wrapper -->
<br />

<table align="center">

<tr>

<h3 align="center">copy right@2005.All Rights Reserved.TradeMonitoring</h3>
</tr>
</table>
</form>
</body>
</html>