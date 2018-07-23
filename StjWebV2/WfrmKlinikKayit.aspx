<%@ Page Title="" Language="C#" MasterPageFile="~/MPYHastane.Master" AutoEventWireup="true" CodeBehind="WfrmKlinikKayit.aspx.cs" Inherits="StjWebV2.WfrmKlinikKayit" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 518px;
        }
        .auto-style5 {
            width: 355px;
            height: 22px;
        }
        .auto-style8 {
            width: 230px;
        }
        .auto-style10 {
            margin-left: 28px;
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
        .auto-style11 {
            margin-left: 26px;
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
        .auto-style12 {
            margin-left: 29px;
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
        .auto-style13 {
            font-size: x-small;
            text-align: justify;
            height: 22px;
        }
        .auto-style14 {
            font-size: small;
        }
        .auto-style15 {
            margin-left: 27px;
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
        .auto-style16 {
            font-size: medium;
        }
        .auto-style17 {
            width: 201px;
        }
        .auto-style18 {
            width: 201px;
            height: 22px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="auto-style1">
        <tr>
            <td class="auto-style5"></td>
            <td class="auto-style18"></td>
            <td class="auto-style13" colspan="2"><strong><span class="newStyle1"><span class="auto-style16">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Hastane Bölümleri</span></span></strong></td>
        </tr>
        <tr>
            <td class="textboxkenar"><strong>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; İl:&nbsp;</strong></td>
            <td class="auto-style17">
                <asp:DropDownList ID="cmbKSehir" runat="server" CssClass="auto-style11" Width="243px" Height="30px" AutoPostBack="True" OnSelectedIndexChanged="cmbKSehir_SelectedIndexChanged">
                </asp:DropDownList>
            </td>
            <td colspan="2" rowspan="3">
                <asp:ListBox ID="lbKlinikHB" runat="server" CssClass="auto-style12" Height="248px" Width="349px" AutoPostBack="True"></asp:ListBox>
            </td>
        </tr>
        <tr>
            <td class="textboxkenar"><strong>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; İlçe: </strong></td>
            <td class="auto-style17">
                <asp:DropDownList ID="cmbKIlce" runat="server" CssClass="auto-style11" Width="243px" Height="28px" AutoPostBack="True" OnSelectedIndexChanged="cmbKIlce_SelectedIndexChanged">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="textboxkenar"><strong>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Hastane:</strong></td>
            <td class="auto-style17">
                <asp:DropDownList ID="cmbKHastane" runat="server" CssClass="auto-style11" Width="243px" Height="30px" AutoPostBack="True" OnSelectedIndexChanged="cmbKHastane_SelectedIndexChanged">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="textboxkenar"><strong>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Klinik:</strong></td>
            <td class="auto-style17">
                <asp:ListBox ID="lbKlinik" runat="server" CssClass="auto-style10" Height="150px" Width="243px" AutoPostBack="True"></asp:ListBox>
            </td>
            <td class="auto-style8">
                <asp:Button ID="btnKlinikKaydet" runat="server" Height="69px" Text="Kaydet" Width="158px" CssClass="auto-style15" OnClick="btnKlinikKaydet_Click" />
            </td>
            <td>
                <asp:Button ID="btnKlinikSil" runat="server" Height="69px" Text="Sil" Width="158px" CssClass="textbox" OnClick="btnKlinikSil_Click" />
            </td>
        </tr>
    </table>
</asp:Content>
