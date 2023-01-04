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
    <div class="container-fluid">
        <div class="row" style="height:120px;"></div>
        <div class="row">
        <div class="col-md-5"></div>
        <div class="col-md- bg-light rounded-3">
            <h1 class="text-success text-center">  goldan   Stay   Hotel  </h1>
            <form>
  <div class="mb-3">
    <label for="exampleInputEmail1" class="form-label">Email address</label>
    <input type="email" class="form-control" id="Emailtb">
    
  </div>
  <div class="mb-3">
    <label for="exampleInputPassword1" class="form-label">Password</label>
    <input type="password" class="form-control" id="Passwordtb">
  </div>
  <div class="mb-3">
      
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
      
    <input type="radio" class="form-check-input" id="AdminCb">&nbsp; <label class="text-success">Admin</label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <input type="radio" class="form-check-input" id="UserCb" ><label class="text-success">User</label>
  </div>
                <div class="d-grid">
                    <button type="submit" class="btn btn-success btn-block">Login</button>
                </div>
  
                <br /> <br />
</form>
        </div>
        <div class="col-md-4"></div>
        </div>
        

    </div>
    <form id="form1" runat="server">
        <div>
        </div>
    </form>
</body>
</html>
