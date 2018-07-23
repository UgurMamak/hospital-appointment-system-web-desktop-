<%@ Page Title="" Language="C#" MasterPageFile="~/MPYHastane.Master" AutoEventWireup="true" CodeBehind="WfrmSaatKayit.aspx.cs" Inherits="StjWebV2.WfrmSaatKayit" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            margin-left: auto;
            margin-right: auto;
            border: 1px solid #848484;
            -webkit-border-radius: 30px;
            -moz-border-radius: 30px;
            border-radius: 30px;
            border: 2px solid #848484;
            outline: 0;
            padding-left: 10px;
            padding-right: 10px;
        }
        .auto-style3 {
            width: 279px;
            height: 52px;
        }
        .auto-style5 {
            text-align: left;
        }
        .auto-style6 {
            width: 279px;
            text-align: right;
        }
        .auto-style7 {
            margin-left: 30px;
            margin-right: auto;
            border: 1px solid #848484;
            -webkit-border-radius: 30px;
            -moz-border-radius: 30px;
            border-radius: 30px;
            border: 2px solid #848484;
            outline: 0;
            padding-left: 10px;
            padding-right: 10px;
        }
        .auto-style8 {
            height: 47px;
        }
        .auto-style10 {
            height: 52px;
        }
        .auto-style12 {
            height: 41px;
        }
        .auto-style14 {
            font-size: small;
        }
        .auto-style16 {
            margin-left: 35px;
            margin-right: auto;
            border: 1px solid #848484;
            -webkit-border-radius: 30px;
            -moz-border-radius: 30px;
            border-radius: 30px;
            border: 2px solid #848484;
            outline: 0;
            height: 25px;
            width: 275px;
            padding-left: 10px;
            padding-right: 10px;
            background-color: white;
        }
        .newStyle1 {
            color: #FFFFFF;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="auto-style1">
        <tr>
            <td class="auto-style3"></td>
            <td class="auto-style10"></td>
            <td class="auto-style10">
                <br />
                <br />
                <strong><span class="auto-style14">&nbsp; </span><span class="newStyle1">Saatler</span></strong></td>
        </tr>
        <tr>
            <td class="textboxkenar">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<strong> Gün:</strong></td>
            <td class="auto-style8">
                <asp:DropDownList ID="cmbGun" runat="server" CssClass="auto-style7" Height="34px" Width="302px" AutoPostBack="True" OnSelectedIndexChanged="cmbGun_SelectedIndexChanged">
                    <asp:ListItem></asp:ListItem>
                    <asp:ListItem>Pazartesi</asp:ListItem>
                    <asp:ListItem>Salı</asp:ListItem>
                    <asp:ListItem>Çarşamba</asp:ListItem>
                    <asp:ListItem>Perşembe</asp:ListItem>
                    <asp:ListItem>Cuma</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td rowspan="3">
                <asp:ListBox ID="lbSaat" runat="server" CssClass="textbox" Height="225px" Width="295px" AutoPostBack="True"></asp:ListBox>
            </td>
        </tr>
        <tr>
            <td class="textboxkenar">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<strong>&nbsp;&nbsp; Saat:</strong></td>
            <td class="auto-style12">
                <asp:TextBox ID="txtSSaat" runat="server" CssClass="auto-style7" Height="30px" Width="278px" AutoPostBack="True" Font-Bold="True" Font-Size="Large" TextMode="Time"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style6">
                &nbsp;</td>
            <td class="auto-style5">
                <asp:Button ID="btnSKaydet" runat="server" CssClass="auto-style16" Height="70px" Text="Kaydet" Width="149px" OnClick="btnSKaydet_Click" />
                <asp:Button ID="btnSSİl" runat="server" CssClass="textbox" Height="71px" Text="Sil" Width="149px" OnClick="btnSSİl_Click" />
            </td>
        </tr>
    </table>
</asp:Content>