<%@ Page Title="" Language="C#" MasterPageFile="~/YoneticiMstr.Master" AutoEventWireup="true" CodeBehind="WfrmHastane.aspx.cs" Inherits="stjWebV1.WfrmHastane" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <Html><head>
        <link href="Yoneticicss.css" rel="stylesheet" />
    </head></Html>
    <style type="text/css">
        .auto-style2 {
            width: 100%;
        }
        .auto-style4 {
            width: 121px;
        }
        .auto-style5 {
            width: 120px;
        }
        .auto-style6 {
            width: 21px;
        }
        .auto-style8 {
            border-radius: 10px;
            border: 2px solid #456879;
        }
      
        .auto-style9 {
            width: 21px;
            height: 80px;
        }
        .auto-style10 {
            height: 80px;
        }
        .auto-style11 {
            width: 121px;
            height: 80px;
        }
        .auto-style12 {
            width: 120px;
            height: 80px;
        }
        .auto-style19 {
            width: 21px;
            height: 32px;
        }
        .auto-style20 {
            height: 32px;
        }
        .auto-style21 {
            width: 21px;
            height: 11px;
        }
        .auto-style22 {
            height: 11px;
        }
        .auto-style25 {
            width: 21px;
            height: 21px;
        }
        .auto-style26 {
            height: 21px;
        }
        .auto-style27 {
            width: 21px;
            height: 17px;
        }
        .auto-style28 {
            height: 17px;
        }
    </style>
    
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="auto-style2">
        <tr>
            <td class="auto-style19"></td>
            <td class="auto-style20"></td>
            <td class="auto-style20"></td>
            <td colspan="3" class="auto-style20"><strong>Hastaneler</strong></td>
        </tr>
        <tr>
            <td class="auto-style25"></td>
            <td class="auto-style26"><strong>İl</strong></td>
            <td class="auto-style26">
                <asp:DropDownList ID="cmbHastaneIl" CssClass="auto-style8" runat="server" Font-Bold="True" Width="195px" Height="25px" AutoPostBack="True" OnSelectedIndexChanged="cmbHastaneIl_SelectedIndexChanged">
                    <asp:ListItem></asp:ListItem>
                </asp:DropDownList>
            </td>
            <td colspan="3" rowspan="3">
                <asp:ListBox ID="LbHastane" CssClass="auto-style8" runat="server" Height="186px" Width="336px" Font-Bold="True" TabIndex="4" AutoPostBack="True" OnSelectedIndexChanged="LbHastane_SelectedIndexChanged"></asp:ListBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style27"></td>
            <td class="auto-style28"><strong>İlçe</strong></td>
            <td class="auto-style28">
                <asp:DropDownList ID="cmbHastaneIlce" CssClass="txt" runat="server" Font-Bold="True" Width="195px" Height="25px" TabIndex="1" AutoPostBack="True" OnSelectedIndexChanged="cmbHastaneIlce_SelectedIndexChanged">
                    <asp:ListItem></asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="auto-style21"></td>
            <td class="auto-style22"><strong>Adı</strong></td>
            <td class="auto-style22">
                <asp:TextBox ID="txtHastaneAd" CssClass="txt" runat="server" Font-Bold="True"  Width="187px" Height="20px" TabIndex="2" AutoPostBack="True"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style9"></td>
            <td class="auto-style10"><strong>Adres</strong></td>
            <td class="auto-style10">
                <asp:TextBox ID="txtHastaneAdres" CssClass="auto-style8" runat="server" Height="74px" TextMode="MultiLine" Width="187px" Font-Bold="True" TabIndex="3" AutoPostBack="True"></asp:TextBox>
            </td>
            <td class="auto-style11">
                <asp:Button ID="btnHastaneKaydet" CssClass="btn" runat="server" Height="45px" Text="Kaydet" Width="87px" Font-Bold="True" TabIndex="5" OnClick="btnHastaneKaydet_Click" />
            </td>
            <td class="auto-style12">
                <asp:Button ID="btnHastaneGuncelle" CssClass="btn" runat="server" Height="45px" Text="Güncelle" Width="87px" Font-Bold="True" TabIndex="6" OnClick="btnHastaneGuncelle_Click" />
            </td>
            <td class="auto-style10">
                <asp:Button ID="btnHastaneSil" CssClass="btn" runat="server" Height="45px" Text="Sil" Width="87px" Font-Bold="True" TabIndex="7" OnClick="btnHastaneSil_Click" />
            </td>
        </tr>
        <tr>
            <td class="auto-style6">&nbsp;</td>
            <td>&nbsp;</td>
            <td>
                &nbsp;</td>
            <td class="auto-style4">
                &nbsp;</td>
            <td class="auto-style5">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
    </table>
</asp:Content>
