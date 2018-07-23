<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WfrmGirisEkrani.aspx.cs" Inherits="stjWebV1.WfrmGirisEkrani" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="GirisCSS.css" rel="stylesheet" />
    <link href="Slider.css" rel="stylesheet" />
    <link href="sliderr2.css" rel="stylesheet" />
    <script src="//ajax.googleapis.com/ajax/libs/jquery/1.8.2/jquery.min.js"></script>
    <%--<script src="https://ajax.googleapis.com/ajax/libs/jquery/1.5.1/jquery.min.js"></script>--%>

    <script>
        var allImages;
        var imgCount;
        var current = 0;

        $(document).ready(function ($) {
            allImages = $(".slideWrapper img");
            imgCount = allImages.length;

            setInterval(slide, 2500);
        });

        function slide() {

            if (current == (imgCount - 1)) {

                allImages.fadeOut(600).eq(0).fadeIn(600);
                current = 0;
            }
            else {
                current++;
                allImages.fadeOut(600).eq(current).fadeIn(600);
            }
        }


    </script>
  

    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
            margin: auto;
        }

        .auto-style2 {
            width: 100%;
        }

        .auto-style4 {
            width: 34%;
        }

        .auto-style5 {
            width: 6%;
        }

        .auto-style6 {
            width: 20px;
        }

        .auto-style7 {
            width: 23px;
        }

        .auto-style12 {
            width: 20px;
            height: 40px;
        }

        .auto-style13 {
            height: 40px;
        }

        .auto-style14 {
            width: 20px;
            height: 37px;
        }

        .auto-style15 {
            height: 37px;
        }

        .auto-style16 {
            width: 20px;
            height: 39px;
        }

        .auto-style17 {
            height: 39px;
        }

        .auto-style18 {
            width: 20px;
            height: 41px;
        }

        .auto-style19 {
            height: 41px;
        }

        .auto-style23 {
            text-align: left;
            width: 430px;
            height: 500px;
            margin-left: 10px;
            color: white;
        }

        .auto-style24 {
            font-size: large;
        }

        .auto-style25 {
            font-size: medium;
        }

        .auto-style26 {
            font-size: x-large;
        }
    </style>

</head>
<body>
    <form id="form1" runat="server">
        <div id="ustResim">

            <asp:Image ID="Image1" runat="server" Height="300px" Width="950px" ImageUrl="~/Resimler/yöneticiUstResim.jpg" />
        </div>
        <div class="bosluk"></div>
        <div id="AnaDiv">


            <div id="Sayfalar">
                <div id="butondiv">
                    <strong>
                        <asp:Button ID="Button1" CssClass="button" runat="server" Text="Hasta Giriş" OnClick="Button1_Click" BorderStyle="None" />
                        <asp:Button ID="Button2" CssClass="button" runat="server" Text="Hasta Kayıt" OnClick="Button2_Click" BorderStyle="None" />
                        <asp:Button ID="Button3" CssClass="button" runat="server" Text="Yönetici Giriş" OnClick="Button3_Click" BorderStyle="None" />
                    </strong>
                </div>
                <asp:MultiView ID="MultiView1" runat="server">

                    <asp:View ID="View1" runat="server">
                        <div id="HastaEkrani">
                            <table class="auto-style1" style="margin: auto;">
                                <tr>
                                    <td class="auto-style5">&nbsp;</td>
                                    <td class="auto-style4">&nbsp;</td>
                                    <td>&nbsp;</td>
                                </tr>
                                <tr>
                                    <td class="auto-style5">&nbsp;</td>
                                    <td class="auto-style4"><strong>TC Kimlik No</strong></td>
                                    <td>
                                        <asp:TextBox ID="txtHastaGirisTc" CssClass="tb" runat="server"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style5">&nbsp;</td>
                                    <td class="auto-style4"><strong>Şifre</strong></td>
                                    <td class="auto-style2">
                                        <asp:TextBox ID="TxtHastaGirisSifre" CssClass="tb" runat="server" TextMode="Password"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style5">&nbsp;</td>
                                    <td class="auto-style4">&nbsp;</td>
                                    <td>
                                        <strong>
                                           <asp:Button ID="btnHastaGiris" class="button2" runat="server" CssClass="button2" Text="Giriş" OnClick="btnHastaGiris_Click" />
                                        </strong>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style5">&nbsp;</td>
                                    <td class="auto-style4">&nbsp;</td>
                                    <td>&nbsp;</td>
                                </tr>
                            </table>
                        </div>
                    </asp:View>
                    <asp:View ID="View2" runat="server">
                        <div id="HastaKayit">
                            <table class="auto-style2">
                                <tr>
                                    <td class="auto-style6">&nbsp;</td>
                                    <td>&nbsp;</td>
                                    <td colspan="2">&nbsp;</td>
                                    <td>&nbsp;</td>
                                </tr>
                                <tr>
                                    <td class="auto-style12"></td>
                                    <td class="auto-style13"><strong>TC KilmlikNo</strong></td>
                                    <td class="auto-style13" colspan="2">
                                        <asp:TextBox ID="txtHastakytTc" CssClass="tb" runat="server"></asp:TextBox>
                                    </td>
                                    <td class="auto-style13"></td>
                                </tr>
                                <tr>
                                    <td class="auto-style12"></td>
                                    <td class="auto-style13"><strong>Şifre</strong></td>
                                    <td class="auto-style13" colspan="2">
                                        <asp:TextBox ID="TxtHKytSifre" CssClass="tb" runat="server" TextMode="Password"></asp:TextBox>
                                    </td>
                                    <td class="auto-style13"></td>
                                </tr>
                                <tr>
                                    <td class="auto-style14"></td>
                                    <td class="auto-style15"><strong>Şifre Tekrar</strong></td>
                                    <td class="auto-style15" colspan="2">
                                        <asp:TextBox ID="TxtHsKytSifreTekrar" CssClass="tb" runat="server" TextMode="Password"></asp:TextBox>
                                    </td>
                                    <td class="auto-style15"></td>
                                </tr>
                                <tr>
                                    <td class="auto-style16"></td>
                                    <td class="auto-style17"><strong>Ad</strong></td>
                                    <td class="auto-style17" colspan="2">
                                        <asp:TextBox ID="TxtHastaAd" CssClass="tb" runat="server"></asp:TextBox>
                                    </td>
                                    <td class="auto-style17"></td>
                                </tr>
                                <tr>
                                    <td class="auto-style18"></td>
                                    <td class="auto-style19"><strong>Soyad</strong></td>
                                    <td class="auto-style19" colspan="2">
                                        <asp:TextBox ID="TxtHastaSoyad" CssClass="tb" runat="server"></asp:TextBox>
                                    </td>
                                    <td class="auto-style19"></td>
                                </tr>
                                <tr>
                                    <td class="auto-style12"></td>
                                    <td class="auto-style13"><strong>Telefon</strong></td>
                                    <td class="auto-style13" colspan="2">
                                        <asp:TextBox ID="TxtHastaTel" CssClass="tb" runat="server" ToolTip="()--"></asp:TextBox>
                                    </td>
                                    <td class="auto-style13"></td>
                                </tr>
                                <tr>
                                    <td class="auto-style12"></td>
                                    <td class="auto-style13"><strong>Doğum Tarihi</strong></td>
                                    <td class="auto-style13" colspan="2">
                                        <asp:TextBox ID="TxtHastDogumTar" CssClass="tb" runat="server" TextMode="Date"></asp:TextBox>
                                    </td>
                                    <td class="auto-style13"></td>
                                </tr>
                                <tr>
                                    <td class="auto-style6">&nbsp;</td>
                                    <td><strong>Cinsiyet</strong></td>
                                    <td>
                                        <asp:RadioButton ID="RbKadin" runat="server" GroupName="a" OnCheckedChanged="RbKadin_CheckedChanged" Text="Kadın" />
                                        <asp:RadioButton ID="RbErkek" runat="server" GroupName="a" OnCheckedChanged="RbErkek_CheckedChanged" Text="Erkek" />
                                    </td>
                                    <td>&nbsp;</td>
                                    <td>&nbsp;</td>
                                </tr>
                                <tr>
                                    <td class="auto-style6">&nbsp;</td>
                                    <td>&nbsp;</td>
                                    <td colspan="2">
                                        <asp:Button ID="BtnHastaKayit" runat="server" CssClass="button2" Text="Kayıt Ol" OnClick="BtnHastaKayit_Click" />
                                    </td>
                                    <td>&nbsp;</td>
                                </tr>
                            </table>
                        </div>
                    </asp:View>
                    <asp:View ID="View3" runat="server">
                        <div id="YoneticiGiris">
                            <table class="auto-style1" style="margin: auto">
                                <tr>
                                    <td class="auto-style7">&nbsp;</td>
                                    <td>&nbsp;</td>
                                    <td>&nbsp;</td>
                                </tr>
                                <tr>
                                    <td class="auto-style7">&nbsp;</td>
                                    <td><strong>TC Kimlik No</strong></td>
                                    <td>
                                        <asp:TextBox ID="TxtYonTc" CssClass="tb" runat="server"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style7">&nbsp;</td>
                                    <td><strong>Şifre</strong></td>
                                    <td>
                                        <asp:TextBox ID="TxtYonSifre" CssClass="tb" runat="server" TextMode="Password"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style7">&nbsp;</td>
                                    <td>&nbsp;</td>
                                    <td>
                                        <asp:Button ID="btnYonGiris" CssClass="button2" runat="server" Text="Giriş" OnClick="btnYonGiris_Click" />
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style7">&nbsp;</td>
                                    <td>&nbsp;</td>
                                    <td>&nbsp;</td>
                                </tr>
                            </table>
                        </div>
                    </asp:View>
                    <asp:View ID="View4" runat="server">

                        <div class="auto-style23">
                            <br />
                            <strong><span class="auto-style26">MHRS&#39;DEN GURURLANDIRAN ÖDÜL</span><span class="auto-style24"><br />
                            </span></strong>
                            <br />
                            <span class="auto-style24">Daha önce EMEA (Avrupa, Orta Asya ve Afrika) bölgesinin “Best Outsourcing Partnership” (En İyi Dış Kaynak Ortaklığı) kategorisinde 2017 yılı birincisi olan MHRS, şimdi de kıtalararası dünya birinciliğini elde etti.
                            <br />
                            </span>
                            <br class="auto-style24" />
                            <span class="auto-style24">Türkiye&#39;nin öz kaynakları ile hayat bulan ve hastanelere tek merkezden randevu alma imkanı sunan MHRS, uluslararası büyük bir ödül daha kazandı. Dünyada, ülkesindeki tüm hastaneleri merkezi randevu sisteminde buluşturan ilk ve tek sistem olan MHRS, tescillenen başarısı ile bizleri bir kez daha gururlandırdı.
                            </span>
                            <span class="auto-style25">
                                <br />
                            </span>
                            <br class="auto-style25" />

                        </div>

                    </asp:View>


                </asp:MultiView>
            </div>




             <div class="SliderDivi">   
                   <div class="slideWrapper">
                    <img src="Resimler/r1.jpg" />
                    <img src="Resimler/r2.jpg" />
                    <img src="Resimler/r3.jpg" />
                </div>  
        </div>

          
 






    </form>
</body>
</html>
