<%@ Page Title="" Language="C#" MasterPageFile="~/LoginMaster.master" AutoEventWireup="true" CodeFile="Album.aspx.cs" Inherits="Album" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Middle" Runat="Server">

 <script type="text/javascript">
     var x = 0;
     var images = new Array()
     images[0] = "gallery/1.jpg";
     images[1] = "gallery/2.jpg";
     images[2] = "gallery/3.jpg";
     images[3] = "gallery/4.jpg";
     images[4] = "gallery/5.jpg";
     images[5] = "gallery/6.jpg";
     images[6] = "gallery/7.jpg";
     images[7] = "gallery/8.jpg";
     images[8] = "gallery/9.jpg";
     images[9] = "gallery/10.jpg";
     images[10] = "gallery/11.jpg";
     images[11] = "gallery/12.jpg";
     images[12] = "gallery/13.jpg";
     images[13] = "gallery/14.jpg";

     setTimeout("changeImage()", 1000);
     function changeImage() {
         document.getElementById("img").src = images[x];
         if (x < 13) {
             x = x + 1;
             setTimeout("changeImage()", 2500);
         }
         else {
             x = 0;
             setTimeout("changeImage()", 2500);
         }
     }
            </script>

            <img id="img" src="gallery/1.jpg" width="400" height="350" />

</asp:Content>

