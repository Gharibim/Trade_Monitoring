<%@ Page Title="" Language="C#" MasterPageFile="~/LoginMaster.master" AutoEventWireup="true" CodeFile="speechtext.aspx.cs" Inherits="ConvertTextToSpeech.speechtext" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Middle" Runat="Server">

 <form id="form2" runat="server">  
      
           
            <table style="width: 100%">
                <tr>
                    <td class="style3" 
                        style="font-size: x-large; text-align: center; color: #990000">
                        Text to Sppech and Speech to Text</td>
                </tr>
            </table>
      
           
            <br />  
            <table width="100%">  
                <tr>  
                    <td style="text-align: center">  
                        <asp:TextBox ID="txtMsg" TextMode="MultiLine" runat="server" Height="142px" 
                            Width="380px" style="text-align: center"></asp:TextBox><br />  
                    </td>  
                </tr>  
       
        
            
                <tr>  
                    
                    <td style="text-align: center">  
                       &nbsp  <asp:Button ID="btVoice" runat="server" Text="Convert to Speech" onclick="btnVoice_Click" />  
                    </td>  
                  
                </tr>  
            </table>  

             <table width="100%">
            <tr>
            <td style="text-align: center">
            <asp:TextBox ID="TextBox1" TextMode="MultiLine" Width="400" Height="100" 
                    runat="server" style="text-align: center"></asp:TextBox>
            </td>
            </tr>

          <tr>
          
          <td >
          &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
          &nbsp;<button id="button1" onclick="toggleStartStop()" type="button"></button>
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
                       button1.innerHTML = "<img src='images/mic.png' width='15px' height='25px'>";
                   }
                   function toggleStartStop() {
                       if (recognizing) {
                           recognition.stop();
                           reset();
                       } else {
                           recognition.start();
                           recognizing = true;
                           button1.innerHTML = " <img src='images/micst.jpg' width='15px' height='25px'>";
                       }
                   }
</script>
            

            
      
        </form>  

</asp:Content>

