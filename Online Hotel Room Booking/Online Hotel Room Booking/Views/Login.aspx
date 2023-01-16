<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Online_Hotel_Room_Booking.Views.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="../Assets/Lib/Bootstrap/css/bootstrap.min.css"/>
    <style>
        body{
             background-image:url(../Assets/Images/hotel.jfif);
             background-size:cover; 
        }
        .container-fluid{
           opacity:0.8;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div class="container-fluid">
        <div class="row" style="height:120px;"></div>
        <div class="row">
        <div class="col-md-5"></div>
        <div class="col-md- bg-light rounded-3">
            <h1 class="text-success text-center">  goldan   Stay   Hotel  </h1>
  <div class="mb-3">
    <label for="exampleInputEmail1" class="form-label">Email address</label>
    <input type="email" class="form-control" id="Emailtb">
    
  </div>
  <div class="mb-3">
    <label for="exampleInputPassword1" class="form-label">Password</label>
    <input type="password" class="form-control" id="Passwordtb">
  </div>
  <div class="mb-3">
      
    &nbsp;
      <asp:RadioButton ID="AdminCb" runat="server" Text="Admin" />
      <asp:RadioButton ID="UserCb" runat="server" Text="User" />
  </div>
                <div class="d-grid">
                    
                    <asp:Button ID="LoginBtn" runat="server" Text="Login" class="btn btn-success btn-block" OnClick="LoginBtn_Click"/>
                </div>
  
                <br /> <br />
        </div>
        <div class="col-md-4"></div>
        </div>
        

    </div>
        <div>
        </div>
    </form>
</body>
</html>
