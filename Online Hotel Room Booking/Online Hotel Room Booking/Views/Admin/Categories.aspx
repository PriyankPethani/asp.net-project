﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Admin/AdminMaster.Master" AutoEventWireup="true" CodeBehind="Categories.aspx.cs" Inherits="Online_Hotel_Room_Booking.Views.Admin.Categories" EnableEventValidation="false"%>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Mybody" runat="server">
    <div class="container-fluid">
        <div class="row"><div class="col-md-5"></div><div class="col-md-5"></div><div class="col-md-2"><label id="LogedUser" runat="server" class="text-success"></label></div></div>
        <div class="row">
            <div class="col-4"></div>
            <div class="col-4">
                <h1 class="text-success text-center">Manage Categories</h1>
            </div>
            <div class="col-4"></div>
        </div>
        <div class="row">
            <div class="col-mp-3">
                <form>
                    <div class="mb-3">
                        <label for="CatNameTb" class="form-label">Category Name</label>
                        <input type="text" class="form-control" id="CatNameTb" runat="server">
                    </div>
                    <div class="mb-3">
                        <label for="RemarksTb" class="form-label">Remarks</label>
                        <input type="text" class="form-control" id="RemarksTb" runat="server">
                    </div>
                    <div class="row">
                        <div class="col d-grid">
                            <asp:Button ID="EditBtn" runat="server" Text="Edit" class="btn btn-warning btn-block" OnClick="Button1_Click" />
                        </div>
                        &nbsp;
                        <div class="col d-grid">
                            <asp:Button ID="DeleteBtn" runat="server" Text="Delete" class="btn btn-danger btn-block" />
                        </div>
                        
            
                    </div>
                    <div class="d-grid">
                        <label id="ErrMsg" runat="server" class="text-danger"></label>
            <asp:Button ID="SaveBtn" runat="server" Text="Save" class="btn btn-success btn-block" OnClick="SaveBtn_Click"/>
                    </div>

                    <br />
                </form>
            </div>
           
            <div class="col-mp-9 m-sm-auto">
                <asp:GridView ID="CategoriesGV" runat="server" class="table" CellPadding="4" ForeColor="#333333" OnSelectedIndexChanged="CategoriesGV_SelectedIndexChanged" Width="1237px">
                    <AlternatingRowStyle BackColor="White" />
                    <Columns>
                        <asp:TemplateField ShowHeader="False">
                            <ItemTemplate>
                                <asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="False" CommandName="Select" Text="Select"></asp:LinkButton>
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                    <EditRowStyle BackColor="#7C6F57" />
                    <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                    <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
                    <RowStyle BackColor="#E3EAEB" />
                    <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
                    <SortedAscendingCellStyle BackColor="#F8FAFA" />
                    <SortedAscendingHeaderStyle BackColor="#246B61" />
                    <SortedDescendingCellStyle BackColor="#D4DFE1" />
                    <SortedDescendingHeaderStyle BackColor="#15524A" />
                </asp:GridView>
            </div>
        </div>
    </div>
</asp:Content>
