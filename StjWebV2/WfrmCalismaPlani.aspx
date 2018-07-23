<%@ Page Title="" Language="C#" MasterPageFile="~/MPYHastane.Master" AutoEventWireup="true" CodeBehind="WfrmCalismaPlani.aspx.cs" Inherits="StjWebV2.WfrmCalismaPlani" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style4 {
            width: 238px;
        }
        .auto-style5 {
            margin-left: 49px;
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
            margin-left: 27px;
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
        .auto-style7 {
            width: 938px;
        }
        .auto-style8 {
            -moz-border-radius-topright: 30px;
            -webkit-border-top-right-radius: 30px;
            border-top-right-radius: 30px;
            -moz-border-radius-bottomright: 30px;
            -webkit-border-bottom-right-radius: 30px;
            border-bottom-right-radius: 30px;
            border: 2px solid #848484;
            background-color: white;
            outline: 0;
            height: 25px;
            width: 938px;
            padding-right: 10px;
        }
        .auto-style9 {
            width: 115px;
        }
        .auto-style10 {
            margin-left: 38px;
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
        .auto-style11 {
            margin-left: 35px;
            margin-top: 21px;
              border: 2px solid #848484;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server"> 
        <table class="auto-style1">
            <tr>
                <td>&nbsp;</td>
                <td class="auto-style7">&nbsp;</td>
                <td class="auto-style4">&nbsp;</td>
                <td colspan="2"><span class="newStyle1">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</span></td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td class="auto-style8"><strong>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; İl:</strong></td>
                <td class="auto-style4">
                    <asp:DropDownList ID="cmbPSehir" runat="server" CssClass="auto-style10" Height="30px" Width="243px" AutoPostBack="True" OnSelectedIndexChanged="cmbPSehir_SelectedIndexChanged">
                        <asp:ListItem></asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td colspan="2" rowspan="5">
                    <asp:ListBox ID="lbPProgram" runat="server" CssClass="auto-style11" Height="311px" Width="405px" AutoPostBack="True"></asp:ListBox>
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td class="auto-style8"><strong>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; İlçe:</strong></td>
                <td class="auto-style4">
                    <asp:DropDownList ID="cmbPIlce" runat="server" CssClass="auto-style10" Height="30px" Width="243px" AutoPostBack="True" OnSelectedIndexChanged="cmbPIlce_SelectedIndexChanged">
                        <asp:ListItem></asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td class="auto-style8"><strong>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Hastane:</strong></td>
                <td class="auto-style4">
                    <asp:DropDownList ID="cmbPHastane" runat="server" CssClass="auto-style10" Height="30px" Width="243px" AutoPostBack="True" OnSelectedIndexChanged="cmbPHastane_SelectedIndexChanged">
                        <asp:ListItem></asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td class="auto-style8"><strong>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Doktor:</strong></td>
                <td class="auto-style4">
                    <asp:DropDownList ID="cmbPDoktor" runat="server" CssClass="auto-style10" Height="30px" Width="243px" AutoPostBack="True">
                        <asp:ListItem></asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td class="auto-style8"><strong>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Gün:</strong></td>
                <td class="auto-style4">
                    <asp:DropDownList ID="cmbPGun" runat="server" CssClass="auto-style10" Height="30px" Width="243px" AutoPostBack="True" OnSelectedIndexChanged="cmbPGun_SelectedIndexChanged">
                        <asp:ListItem></asp:ListItem>
                        <asp:ListItem>Pazartesi</asp:ListItem>
                        <asp:ListItem>Salı</asp:ListItem>
                        <asp:ListItem>Çarşamba</asp:ListItem>
                        <asp:ListItem>Perşembe</asp:ListItem>
                        <asp:ListItem>Cuma</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td class="auto-style8"><strong>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Saat:</strong></td>
                <td class="auto-style4">
                    <asp:DropDownList ID="cmbPSaat" runat="server" CssClass="auto-style10" Height="30px" Width="243px" AutoPostBack="True">
                        <asp:ListItem></asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td class="auto-style9">
                    <asp:Button ID="BtnHPKaydet" runat="server" Text="Kaydet" CssClass="auto-style5" Height="71px" Width="172px" OnClick="BtnHPKaydet_Click" />
                </td>
                <td>
                    <asp:Button ID="btnHPSil" runat="server" Text="Sil" CssClass="auto-style6" Height="71px" Width="172px" OnClick="btnHPSil_Click" />
                </td>
            </tr>
        </table>
    
    
</asp:Content>