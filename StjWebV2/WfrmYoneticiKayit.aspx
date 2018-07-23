<%@ Page Title="" Language="C#" MasterPageFile="~/MPYHastane.Master" AutoEventWireup="true" CodeBehind="WfrmYoneticiKayit.aspx.cs" Inherits="StjWebV2.WfrmYoneticiKayit" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 210px;
        }
        .auto-style3 {
            width: 51px;
        }
        .auto-style5 {
            margin-left: 39px;
            margin-right: auto;
            border: 1px solid #848484;
            -webkit-border-radius: 30px;
            -moz-border-radius: 30px;
            border-radius: 30px;
            border: 2px solid #848484;
            outline: 0;
            padding-left: 10px;
            padding-right: 10px;
            background-color: white;
        }
        .auto-style6 {
            width: 48px;
        }
        .auto-style7 {
            margin-left: 37px;
            margin-right: auto;
            border: 1px solid #848484;
            -webkit-border-radius: 30px;
            -moz-border-radius: 30px;
            border-radius: 30px;
            border: 2px solid #848484;
            outline: 0;
            padding-left: 10px;
            padding-right: 10px;
            background-color: white;
        }
        .auto-style10 {
            width: 254px;
        }
        .auto-style12 {
            margin-left: 32px;
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
        .auto-style14 {
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
            background-color: white;
        }
        .newStyle1 {
            color: #FFFFFF;
        }
        .auto-style17 {
            text-align: right;
            height: 40px;
        }
        .auto-style18 {
            -moz-border-radius-topright: 30px;
            -webkit-border-top-right-radius: 30px;
            border-top-right-radius: 30px;
            -moz-border-radius-bottomright: 30px;
            -webkit-border-bottom-right-radius: 30px;
            border-bottom-right-radius: 30px;
            border: 2px solid #848484;
            background-color: white;
            outline: 0;
            height: 40px;
            width: 254px;
            padding-right: 10px;
        }
        .auto-style19 {
            -moz-border-radius-topright: 30px;
            -webkit-border-top-right-radius: 30px;
            border-top-right-radius: 30px;
            -moz-border-radius-bottomright: 30px;
            -webkit-border-bottom-right-radius: 30px;
            border-bottom-right-radius: 30px;
            border: 2px solid #848484;
            background-color: white;
            outline: 0;
            height: 37px;
            width: 254px;
            padding-right: 10px;
        }
        .auto-style20 {
            text-align: right;
            height: 37px;
        }
        .auto-style21 {
            -moz-border-radius-topright: 30px;
            -webkit-border-top-right-radius: 30px;
            border-top-right-radius: 30px;
            -moz-border-radius-bottomright: 30px;
            -webkit-border-bottom-right-radius: 30px;
            border-bottom-right-radius: 30px;
            border: 2px solid #848484;
            background-color: white;
            outline: 0;
            height: 39px;
            width: 254px;
            padding-right: 10px;
        }
        .auto-style22 {
            text-align: right;
            height: 39px;
        }
        .auto-style23 {
            width: 254px;
            height: 22px;
        }
        .auto-style24 {
            width: 48px;
            height: 22px;
        }
        .auto-style25 {
            width: 51px;
            height: 22px;
        }
        .auto-style26 {
            height: 22px;
        }
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
        <table class="auto-style1">
            <tr>
                <td class="auto-style23"></td>
                <td class="auto-style24"></td>
                <td class="auto-style25"></td>
                <td class="auto-style26">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <span class="newStyle1">Yönetici</span></td>
            </tr>
            <tr>
                <td class="auto-style21"><strong>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Ad:</strong></td>
                <td class="auto-style22" colspan="2">
                    <asp:TextBox ID="txtYAd" runat="server" CssClass="textbox" Height="30px" Width="212px"></asp:TextBox>
                </td>
                <td rowspan="6">
                    <asp:ListBox ID="lbYonetici" runat="server" CssClass="texetbox" Height="296px" Width="357px" style="margin-left: 35px" AutoPostBack="True" OnSelectedIndexChanged="lbYonetici_SelectedIndexChanged"></asp:ListBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style18"><strong>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Soyad:</strong></td>
                <td class="auto-style17" colspan="2">
                    <asp:TextBox ID="txtYSoyad" runat="server" CssClass="textbox" Height="30px" Width="212px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style19"><strong>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; TC Kimlik No:</strong></td>
                <td class="auto-style20" colspan="2">
                    <asp:TextBox ID="txtYTC" runat="server" CssClass="textbox" Height="30px" Width="212px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style18"><strong>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Şifre:</strong></td>
                <td class="auto-style17" colspan="2">
                    <asp:TextBox ID="txtSifre" runat="server" CssClass="auto-style12" Height="30px" Width="212px" TextMode="Password"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style18"><strong>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Şifre Tekrar:</strong></td>
                <td class="auto-style17" colspan="2">
                    <asp:TextBox ID="txtSifreTekrar" runat="server" CssClass="auto-style7" Height="30px" Width="212px" TextMode="Password"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style10">&nbsp;</td>
                <td class="auto-style6">
                    <asp:Button ID="btnYKaydet" runat="server" CssClass="auto-style5" Height="65px" Text="Kaydet" Width="114px" Font-Bold="True" OnClick="btnYKaydet_Click" />
                </td>
                <td class="auto-style3">
                    <asp:Button ID="btnYSil" runat="server" CssClass="auto-style14" Height="65px" Text="Sil" Width="114px" Font-Bold="True" OnClick="btnYSil_Click" />
                </td>
            </tr>
        </table>
 

 
</asp:Content>