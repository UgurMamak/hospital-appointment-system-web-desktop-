<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WfrmGiris.aspx.cs" Inherits="StjWebV2.WfrmGiris" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
     <script src="//ajax.googleapis.com/ajax/libs/jquery/1.8.2/jquery.min.js"></script>

    <link href="Giris.css" rel="stylesheet" />
    <link href="slayt.css" rel="stylesheet" />
  <style>
        body, html, table {
            width: 100%;
            height: 100%;
        }

        body {
            margin: 0;
            padding: 0;
        }

        table td {
            vertical-align: middle;
        }

        .slideWrapper {
            position: relative;
            width: 600px;
            height: 400px;
            margin: 0 auto;
        }

            .slideWrapper img {
                position: absolute;
                top: 0;
                left: 0px;
                display: none;
            }

                .slideWrapper img:nth-child(1) {
                    display: block;
                }
       
    </style>
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

    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            background-color: #0061A7;
        }
        .newStyle1 {
            font-family: "Trebuchet MS", "Lucida Sans Unicode", "Lucida Grande", "Lucida Sans", Arial, sans-serif;
        }
        .newStyle2 {
            font-family: "Trebuchet MS", "Lucida Sans Unicode", "Lucida Grande", "Lucida Sans", Arial, sans-serif;
        }
        .auto-style5 {
            height: 41px;
            width: 51px;
        }
        .auto-style6 {
            width: 51px;
        }
        .auto-style7 {
            width: 149px;
        }
        .auto-style12 {
            height: 5px;
            width: 51px;
        }
        .auto-style14 {
            height: 5px;
        }
        .auto-style15 {
            height: 41px;
        }
        .auto-style16 {
            width: 51px;
            height: 10px;
        }
        .auto-style17 {
            width: 149px;
            height: 10px;
        }
        .auto-style18 {
            height: 10px;
        }

        .newStyle3 {
            font-family: "Trebuchet MS", "Lucida Sans Unicode", "Lucida Grande", "Lucida Sans", Arial, sans-serif;
        }
        .auto-style21 {
            height: 430px;
        }
        .auto-style24 {
            height: 39px;
        }
        .auto-style25 {
            height: 26px;
        }
        .auto-style27 {
            width: 77px;
        }
        .auto-style29 {
            height: 1565px;
        }
        .auto-style30 {
            height: 187px;
        }
        .newStyle4 {
            color: #F9F9F9;
        }
        .newStyle5 {
            color: #FFFFFF;
        }
        .newStyle6 {
            color: #FFFFFF;
        }
        .newStyle7 {
            color: #FFFFFF;
        }
        .newStyle8 {
            color: #FFFFFF;
        }
        .auto-style33 {
            width: 62px;
        }
        .newStyle9 {
            font-family: "Trebuchet MS", "Lucida Sans Unicode", "Lucida Grande", "Lucida Sans", Arial, sans-serif;
        }
        .newStyle10 {
            font-family: "Trebuchet MS", "Lucida Sans Unicode", "Lucida Grande", "Lucida Sans", Arial, sans-serif;
            color: #FFFFFF;
        }
        .newStyle11 {
            color: #FFFFFF;
            font-family: "Lucida Sans", "Lucida Sans Regular", "Lucida Grande", "Lucida Sans Unicode", Geneva, Verdana, sans-serif;
        }

        .newStyle12 {
            color: #FFFFFF;
            font-family: "Lucida Sans", "Lucida Sans Regular", "Lucida Grande", "Lucida Sans Unicode", Geneva, Verdana, sans-serif;
        }
        .newStyle13 {
            font-family: "Trebuchet MS", "Lucida Sans Unicode", "Lucida Grande", "Lucida Sans", Arial, sans-serif;
            color: #FFFFFF;
        }
        .newStyle14 {
            color: #FFFFFF;
        }
        .newStyle15 {
            color: #FFFFFF;
            font-family: "Trebuchet MS", "Lucida Sans Unicode", "Lucida Grande", "Lucida Sans", Arial, sans-serif;
        }
        .newStyle16 {
            font-family: "Trebuchet MS", "Lucida Sans Unicode", "Lucida Grande", "Lucida Sans", Arial, sans-serif;
            color: #FFFFFF;
        }
        .newStyle17 {
            color: #124D77;
            font-size: large;
        }
        .auto-style34 {
            margin-left: 20px;
            width: 417px;
        }
        .newStyle18 {
            color: #124D77;
            font-size: large;
            font-family: "Trebuchet MS", "Lucida Sans Unicode", "Lucida Grande", "Lucida Sans", Arial, sans-serif;
        }
        .newStyle19 {
            color: #FFFFFF;
            font-size: small;
            font-family: "Trebuchet MS", "Lucida Sans Unicode", "Lucida Grande", "Lucida Sans", Arial, sans-serif;
        }
        .auto-style35 {
            margin-left: 29px;
        }

        .auto-style37 {
            width: 100%;
            height: 9%;
        }
        .auto-style38 {
            width: 100%;
            height: 103%;
        }
        .auto-style39 {
            width: 100%;
            height: 187px;
        }

        .auto-style41 {
            color: #FFFFFF;
            height: 5px;
        }
        .auto-style44 {
            width: 51px;
            height: 29px;
        }
        .auto-style45 {
            width: 149px;
            height: 29px;
        }
        .auto-style47 {
            height: 29px;
        }

        .auto-style48 {
            width: 131px;
        }

    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div id="divUstResim">
            <asp:Image ID="Image1" runat="server" width="1000px" height="347px" ImageUrl="~/Resimler/cropped-health_bg2.jpg" />
        </div>
        <div class="bosluk"></div>
        <div id="buyuksayfa">
            <div id="sayfalar" class="auto-style29"> 
                <div id="auto-style3" class="auto-style2">
                    <%--<asp:Button ID="Button1" runat="server" Text="Hasta Girişi" CssClass="Button" OnClick="Button1_Click" />
                <asp:Button ID="Button2" runat="server" Text="Hasta Kayıt" CssClass="Button" OnClick="Button2_Click" />
                <asp:Button ID="Button3" runat="server" Text="Yönetici Girişi" CssClass="Button" OnClick="Button3_Click" />--%>
                    <table class="auto-style37">
                        <tr>
                            <td>&nbsp;</td>
                            <td class="auto-style48">
                                <asp:Button ID="Button5" runat="server" BackColor="#0061A7" BorderColor="#0061A7" BorderStyle="None" ForeColor="White" Height="38px" Text="Hasta Girişi" Width="116px" OnClick="Button5_Click" />
                            </td>
                            <td>&nbsp;</td>
                            <td>
                                <asp:Button ID="Button6" runat="server"  BackColor="#0061A7" BorderColor="#0061A7" BorderStyle="None" ForeColor="White" Height="38px" Text="Hasta Kayıt" Width="116px" OnClick="Button6_Click" />
                            </td>
                            <td>&nbsp;</td>
                            <td>
                                <asp:Button ID="Button7" runat="server" BackColor="#0061A7" BorderColor="#0061A7" BorderStyle="None" ForeColor="White" Height="38px" Text="Yönetici Giriş" Width="116px" OnClick="Button7_Click" />
                            </td>
                            <td>&nbsp;</td>
                        </tr>
                    </table>
                </div>
                <asp:MultiView ID="MultiView1" runat="server">
                    <asp:View ID="View4" runat="server">
                        <div class="auto-style34">
                            <span class="newStyle18">
                            <br />
                            RANDEVU SİSTEMİ<br />
                            <br />
                            </span><span class="newStyle19">Türkiye&#39;de ki devlet hastanelerinden faydalanabilmek için oluşturduğumuz sistemimize öncelikle kayıt olmalısınız.Yukarıda bulunan ikinci butona tıklayarak kaydolma işlemini başlatabilirrsiniz.Eğer daha önceden kaydolduysanız T.C. Kimlik numaranız ve oluşturduğunuz şifreniz ile birinci butona tıklayarak&nbsp; giriş yapabilirsiniz.<br />
                            <br />
                            Giriş yaptıktan sonra randevu almak için İl ilçe hastane klinik bilgilerini doldurup bulunan randevu saatlerinden birini seçmeniz gerekmektedir.<br />
                            <br />
                            Sağlıklı mutlu günler dileriz.<br />
                            <br />
                            <div>
                            </div>
                            </span>
                            <asp:Image ID="Image2" runat="server" CssClass="auto-style35" Height="151px" ImageUrl="~/Resimler/mehmet-akif-ersoy-devlet-hastanesi.jpg" Width="350px" />
                        </div>
                        <br />
                    </asp:View>
                    <asp:View ID="View1" runat="server">
                        <div id="HastaGiris">
                            <table class="auto-style39">
                                <tr>
                                    <td class="auto-style44"></td>
                                    <td class="auto-style45"></td>
                                    <td class="auto-style47"></td>
                                    <td class="auto-style47"></td>
                                </tr>
                                <tr>
                                    <td class="auto-style5"></td>
                                    <td class="newStyle8"><span class="newStyle1">T.C. Kimlik No:</span></td>
                                    <td class="auto-style15"></td>
                                    <td class="auto-style15">
                                        <asp:TextBox ID="txtHTc" runat="server" BorderColor="Black" BorderWidth="1px"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style12"></td>
                                    <td class="auto-style41"><span class="newStyle2">Parola:</span></td>
                                    <td class="auto-style14"></td>
                                    <td class="auto-style14">
                                        <asp:TextBox ID="txtHParola" runat="server" BorderColor="Black" BorderWidth="1px" TextMode="Password"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style16"></td>
                                    <td class="newStyle8"></td>
                                    <td class="auto-style18"></td>
                                    <td class="auto-style18"></td>
                                </tr>
                                <tr>
                                    <td class="auto-style6">&nbsp;</td>
                                    <td class="auto-style7">&nbsp;</td>
                                    <td>&nbsp;</td>
                                    <td>
                                        <asp:Button ID="btnHGiris" runat="server" CssClass="myButton" Text="Giriş" BorderColor="#0061A7" Height="49px" Width="97px" OnClick="btnHGiris_Click" />
                                    </td>
                                </tr>
                            </table>
                            <br />
                        </div>
                    </asp:View>
                    <asp:View ID="View2" runat="server">
                        <div id="HastaKayit" class="auto-style21">
                            <table class="auto-style1">
                                <tr>
                                    <td class="auto-style33">&nbsp;</td>
                                    <td>&nbsp;</td>
                                    <td>&nbsp;</td>
                                    <td class="auto-style27">&nbsp;</td>
                                    <td>&nbsp;</td>
                                    <td>&nbsp;</td>
                                    <td>&nbsp;</td>
                                </tr>
                                <tr>
                                    <td class="newStyle11"></td>
                                    <td class="newStyle11">T.C. Kimlik No:</td>
                                    <td class="auto-style15"></td>
                                    <td class="auto-style15" colspan="3">
                                        <asp:TextBox ID="txtHKTc" runat="server" BorderColor="Black" BorderWidth="1px"></asp:TextBox>
                                    </td>
                                    <td class="auto-style15"></td>
                                </tr>
                                <tr>
                                    <td class="newStyle11"></td>
                                    <td class="newStyle11">Parola:</td>
                                    <td class="auto-style15"></td>
                                    <td class="auto-style15" colspan="3">
                                        <asp:TextBox ID="txtHKParola" runat="server" BorderColor="Black" BorderWidth="1px" TextMode="Password"></asp:TextBox>
                                    </td>
                                    <td class="auto-style15"></td>
                                </tr>
                                <tr>
                                    <td class="newStyle11"></td>
                                    <td class="newStyle11">Parola Tekrar:</td>
                                    <td class="auto-style15"></td>
                                    <td class="auto-style15" colspan="3">
                                        <asp:TextBox ID="txtHKParolaTekrar" runat="server" BorderColor="Black" BorderWidth="1px" TextMode="Password"></asp:TextBox>
                                    </td>
                                    <td class="auto-style15"></td>
                                </tr>
                                <tr>
                                    <td class="newStyle11"></td>
                                    <td class="newStyle11">Ad:</td>
                                    <td class="auto-style15"></td>
                                    <td class="auto-style15" colspan="3">
                                        <asp:TextBox ID="txtHKAd" runat="server" BorderColor="Black" BorderWidth="1px"></asp:TextBox>
                                    </td>
                                    <td class="auto-style15"></td>
                                </tr>
                                <tr>
                                    <td class="newStyle11"></td>
                                    <td class="newStyle11">Soyad:</td>
                                    <td class="auto-style15"></td>
                                    <td class="auto-style15" colspan="3">
                                        <asp:TextBox ID="txtHKSoyad" runat="server" BorderColor="Black" BorderWidth="1px"></asp:TextBox>
                                    </td>
                                    <td class="auto-style15"></td>
                                </tr>
                                <tr>
                                    <td class="newStyle11"></td>
                                    <td class="newStyle11">Telefon:</td>
                                    <td class="auto-style15"></td>
                                    <td class="auto-style15" colspan="3">
                                        <asp:TextBox ID="txtHKTel" runat="server" BorderColor="Black" BorderWidth="1px" TextMode="Phone"></asp:TextBox>
                                    </td>
                                    <td class="auto-style15"></td>
                                </tr>
                                <tr>
                                    <td class="newStyle11"></td>
                                    <td class="newStyle11">Doğum Tarihi:</td>
                                    <td class="auto-style24"></td>
                                    <td class="auto-style24" colspan="3">
                                        <asp:TextBox ID="txtHKDogumTarihi" runat="server" BorderColor="Black" BorderWidth="1px" TextMode="Date"></asp:TextBox>
                                    </td>
                                    <td class="auto-style24"></td>
                                </tr>
                                <tr>
                                    <td class="newStyle11"></td>
                                    <td class="newStyle11">Cinsiyet:</td>
                                    <td class="auto-style25"></td>
                                    <td class="newStyle10">
                                        <asp:RadioButton ID="rbKadın" runat="server" GroupName="a" Text="Kadın" />
                                    </td>
                                    <td class="newStyle10">
                                        <asp:RadioButton ID="rbErkek" runat="server" GroupName="a" Text="Erkek" />
                                    </td>
                                    <td class="auto-style25"></td>
                                </tr>
                                <tr>
                                    <td class="newStyle11">&nbsp;</td>
                                    <td class="newStyle11">&nbsp;</td>
                                    <td>&nbsp;</td>
                                    <td class="auto-style27">&nbsp;</td>
                                    <td>&nbsp;</td>
                                    <td>&nbsp;</td>
                                    <td>&nbsp;</td>
                                </tr>
                                <tr>
                                    <td class="auto-style33">&nbsp;</td>
                                    <td class="newStyle9">&nbsp;</td>
                                    <td>&nbsp;</td>
                                    <td colspan="3">
                                        <asp:Button ID="btnHKaydet" runat="server" BorderColor="#0061A7" CssClass="myButton" Height="49px" Text="Kaydet" Width="97px" OnClick="btnHKaydet_Click" />
                                    </td>
                                    <td>&nbsp;</td>
                                </tr>
                                <tr>
                                    <td class="auto-style33">&nbsp;</td>
                                    <td class="newStyle9">&nbsp;</td>
                                    <td>&nbsp;</td>
                                    <td class="auto-style27">&nbsp;</td>
                                    <td>&nbsp;</td>
                                    <td>&nbsp;</td>
                                    <td>&nbsp;</td>
                                </tr>
                            </table>
                        </div>
                    </asp:View>
                    <asp:View ID="View3" runat="server">
                        <div id="YoneticiGiris" class="auto-style30">
                            <table class="auto-style38">
                                <tr>
                                    <td class="auto-style6">&nbsp;</td>
                                    <td class="auto-style7">&nbsp;</td>
                                    <td>&nbsp;</td>
                                    <td>&nbsp;</td>
                                </tr>
                                <tr>
                                    <td class="auto-style5"></td>
                                    <td class="newStyle7"><span class="newStyle1">T.C. Kimlik No:</span></td>
                                    <td class="auto-style15"></td>
                                    <td class="auto-style15">
                                        <asp:TextBox ID="txtYTc" runat="server" BorderColor="Black" BorderWidth="1px"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style12"></td>
                                    <td class="newStyle7"><span class="newStyle2">Parola:</span></td>
                                    <td class="auto-style14"></td>
                                    <td class="auto-style14">
                                        <asp:TextBox ID="txtYParola" runat="server" BorderColor="Black" BorderWidth="1px" TextMode="Password"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style16"></td>
                                    <td class="auto-style17"></td>
                                    <td class="auto-style18"></td>
                                    <td class="auto-style18"></td>
                                </tr>
                                <tr>
                                    <td class="auto-style6">&nbsp;</td>
                                    <td class="auto-style7">&nbsp;</td>
                                    <td>&nbsp;</td>
                                    <td>
                                        <asp:Button ID="btnYGiris" runat="server" CssClass="myButton" Text="Giriş" BorderColor="#0061A7" Height="49px" Width="97px" OnClick="btnYGiris_Click" />
                                    </td>
                                </tr>
                            </table>
                            <br />
                        </div>
                    </asp:View>
                </asp:MultiView>
            </div>
            <div id="slider">
                <div class="slideWrapper">
                 <img src="Resimler/525x500.jpg" />
                    <img src="Resimler/525x500-2.jpg" />
                    <img src="Resimler/525x500-3.jpg" />
                </div>
 
            </div>

        </div>
    </form>
</body>
</html>
