<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Admin/AdminMaster.Master" AutoEventWireup="true" CodeBehind="Rooms.aspx.cs" Inherits="Online_Hotel_Room_Booking.Views.Admin.Rooms" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Mybody" runat="server">
    <!--<h1 class="text-success">Manage Rooms</h1>-->
    <div class="container-fluid">
        <div class="row">
            <div class="col-4"></div>
            <div class="col-4"><h1 class="text-success">Manage Rooms</h1></div>
            <div class="col-4"></div>            
        </div>
        <div class="row">
            <div class="col-mp-3">
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
            <div class="col-mp-9">

            </div>
        </div>
    </div>
</asp:Content>
 