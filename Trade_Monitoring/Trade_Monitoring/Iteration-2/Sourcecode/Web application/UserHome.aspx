<%@ Page Title="" Language="C#" MasterPageFile="~/UserMaster.master" AutoEventWireup="true" CodeFile="UserHome.aspx.cs" Inherits="UserHome" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Middle" Runat="Server">



  <%--<div id="slider_right">--%>
                <div id="piecemaker">
                 
                </div>	
            <%--</div>--%>
          <%--  <div class="cleaner"></div>--%>
      
    <script type="text/javascript" src="js/swfobject/swfobject.js"></script>
<script type="text/javascript">
    var flashvars = {};
    flashvars.cssSource = "css/piecemaker.css";
    flashvars.xmlSource = "piecemaker.xml";

    var params = {};
    params.play = "true";
    params.menu = "false";
    params.scale = "showall";
    params.wmode = "transparent";
    params.allowfullscreen = "true";
    params.allowscriptaccess = "always";
    params.allownetworking = "all";

    swfobject.embedSWF('piecemaker.swf', 'piecemaker', '560', '340', '10', null, flashvars,
  params, null);

</script>
</asp:Content>

