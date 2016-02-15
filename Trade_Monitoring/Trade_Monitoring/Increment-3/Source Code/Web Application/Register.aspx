<%@ Page Title="" Language="C#" MasterPageFile="~/LoginMaster.master" Debug="true" AutoEventWireup="true" CodeFile="Register.aspx.cs" Inherits="Register" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Middle" Runat="Server">
    <meta charset="utf-8">
        <title>Fullscreen Responsive Register Template</title>
        <meta name="viewport" content="width=device-width, initial-scale=1.0">
        <meta name="description" content="">
        <meta name="author" content="">

        <!-- CSS -->
        <link rel='stylesheet' href='http://fonts.googleapis.com/css?family=PT+Sans:400,700'>
        <link rel='stylesheet' href='http://fonts.googleapis.com/css?family=Oleo+Script:400,700'>
        <link rel="stylesheet" href="assets/bootstrap/css/bootstrap.min.css">
        <link rel="stylesheet" href="assets/css/style.css">

        <!-- HTML5 shim, for IE6-8 support of HTML5 elements -->
        <!--[if lt IE 9]>
            <script src="http://html5shim.googlecode.com/svn/trunk/html5.js"></script>
        <![endif]-->

     

        <div class="register-container container">
            <div class="row">
                  <div class="register span6">
                      <form id="form1" runat="server">
                        <h2 class="style3"><span style="color: #800000">Register To </span> <span class="red">
                            <strong style="color: #800000">Trade Monitoring</strong></span></h2>
                        <label for="firstname">First Name</label>
                        <input type="text" id="firstname" name="firstname" placeholder="enter your first name...">
                        <label for="lastname">Last Name</label>
                        <input type="text" id="lastname" name="lastname" placeholder="enter your last name...">
                        <label for="username">Username</label>
                        <input type="text" id="username" name="username" placeholder="choose a username...">
                         <label for="password">Password</label>
                         <input type="password" id="password" name="password" placeholder="Choose your password...">
                        <label for="password">Confirm Password</label>
                        <input type="password" id="cpass" name="cpass" placeholder="confirm password...">
                        <label for="email">Email</label>
                        <input type="text" id="email" name="email" placeholder="enter your email...">
                        <label for="phoneno">Phone Number</label>
                        <input type="text" id="phone" name="phone" placeholder="Enter Phone number...">
                       
                      <br />
                      <asp:ImageButton ID="ImageButton1" runat="server" Height="47px" 
                          ImageUrl="~/images/countinue.png" onclick="ImageButton1_Click" Width="182px" />
                      </form>
                </div>
            
            </div>
        </div>

        <!-- Javascript -->
       <script src="assets/js/jquery-1.8.2.min.js"></script>
        <script src="assets/bootstrap/js/bootstrap.min.js"></script>
        <script src="assets/js/jquery.backstretch.min.js"></script>
        <script src="assets/js/scripts.js"></script>

</asp:Content>

