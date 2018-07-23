<%@ Page Title="" Language="C#" MasterPageFile="~/MPYHastane.Master" AutoEventWireup="true" CodeBehind="WfrnHastaneKayit.aspx.cs" Inherits="StjWebV2.WfrnHastaneKayit" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="StyleSheet1.css" rel="stylesheet" />
    <style type="text/css">
        .auto-style4 {
            width: 100%;
            height: 344px;
        }
        .auto-style11 {
            width: 304px;
            height: 41px;
            text-align: center;
        }
        .auto-style13 {
            width: 58px;
            font-size: small;
            height: 41px;
            text-align: center;
        }
        .auto-style17 {
            width: 254px;
            height: 41px;
            text-align: justify;
        }
        .auto-style18 {
            width: 137px;
            height: 41px;
        }
        .auto-style19 {
            height: 41px;
        }
        .auto-style28 {
            -webkit-border-radius: 30px;
            -moz-border-radius: 30px;
            border-radius: 30px;
            outline-width: 0;
            outline-style: none;
            outline-color: invert;
            border: 2px solid #848484;
            margin-left: 22px;
            padding-left: 10px;
            padding-right: 10px;
        }
        .auto-style30 {
            width: 254px;
            height: 79px;
        }
        .auto-style31 {
            width: 137px;
            height: 79px;
        }
        .auto-style32 {
            height: 79px;
        }
        .auto-style35 {
            width: 254px;
            height: 28px;
        }
    .auto-style36 {
        -webkit-border-radius: 30px;
        -moz-border-radius: 30px;
        border-radius: 30px;
        outline-width: 0;
        outline-style: none;
        outline-color: invert;
        height: 25px;
        width: 275px;
        border: 2px solid #848484;
        margin-left: 20px;
        margin-right: auto;
        padding-left: 10px;
        padding-right: 10px;
    }
        .auto-style40 {
            -webkit-border-radius: 30px;
            -moz-border-radius: 30px;
            border-radius: 30px;
            outline-width: 0;
            outline-style: none;
            outline-color: invert;
            border: 2px solid #848484;
            margin-left: auto;
            margin-right: auto;
            padding-left: 10px;
            padding-right: 10px;
            background-color: white;
        }
        .auto-style41 {
            -webkit-border-radius: 30px;
            -moz-border-radius: 30px;
            border-radius: 30px;
            outline-width: 0;
            outline-style: none;
            outline-color: invert;
            border: 2px solid #848484;
            margin-left: 0px;
            margin-right: auto;
            padding-left: 10px;
            padding-right: 10px;
            background-color: white;
        }
        .auto-style42 {
            width: 58px;
            height: 79px;
        }
        .newStyle1 {
            color: #FFFFFF;
        }
        .auto-style43 {
            -webkit-border-radius: 30px;
            -moz-border-radius: 30px;
            border-radius: 30px;
            outline-width: 0;
            outline-style: none;
            outline-color: invert;
            border: 2px solid #848484;
            margin-left: 0px;
            padding-left: 10px;
            padding-right: 10px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="auto-style4">
        <tr>
            <td class="auto-style11">
                <br />
            </td>
            <td class="auto-style17"></td>
            <td class="auto-style13"><strong>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Hastaneler</strong></td>
            <td class="auto-style18"></td>
            <td class="auto-style19"></td>
        </tr>
        <tr>
            <td class="textboxkenar">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>&nbsp;İl:</strong></td>
            <td class="auto-style35">
                <asp:DropDownList ID="cmbHastaneSehir" runat="server" CssClass="auto-style28" Width="200px" Height="30px" AutoPostBack="True" OnSelectedIndexChanged="cmbHastaneSehir_SelectedIndexChanged">
                </asp:DropDownList>
            </td>
            <td colspan="3" rowspan="3">
                <asp:ListBox ID="lbHastane" runat="server" CssClass="auto-style43" Height="251px" Width="432px" AutoPostBack="True" OnSelectedIndexChanged="lbHastane_SelectedIndexChanged"></asp:ListBox>
            </td>
        </tr>
        <tr>
            <td class="textboxkenar">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<strong>İlçe:</strong></td>
            <td class="auto-style35">
                <asp:DropDownList ID="cmbHastaneİlce" runat="server" Width="200px" CssClass="auto-style28" Height="30px" AutoPostBack="True" OnSelectedIndexChanged="cmbHastaneİlce_SelectedIndexChanged" >
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="textboxkenar">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<strong>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Adı:</strong></td>
            <td class="auto-style35">
                <asp:TextBox ID="txtHastaneAdi" runat="server" Width="182px" CssClass="auto-style36" Height="24px" AutoPostBack="True"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="textboxkenar"><strong>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Adres:</strong></td>
            <td class="auto-style30"><strong>
                <asp:TextBox ID="txtAdres" runat="server" Width="182px" CssClass="auto-style28" Height="118px" TextMode="MultiLine" AutoPostBack="True"></asp:TextBox>
                </strong></td>
            <td class="auto-style42">
                <asp:Button ID="btnHastaneKaydet" runat="server" Height="69px" Text="Kaydet" Width="144px" CssClass="auto-style40" OnClick="btnHastaneKaydet_Click" />
            </td>
            <td class="auto-style31">
                <asp:Button ID="btnHastaneGüncelle" runat="server" CssClass="auto-style40" Height="69px" Text="Güncelle" Width="144px" OnClick="btnHastaneGüncelle_Click" />
            </td>
            <td class="auto-style32">
                <asp:Button ID="btnHastaneSil" runat="server" CssClass="auto-style41" Height="69px" Text="Sil" Width="144px" OnClick="btnHastaneSil_Click" />
            </td>
        </tr>
    </table>

</asp:Content>
