﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="product_information.aspx.cs" Inherits="Website.product_information" %>

<!DOCTYPE aspx>

<aspx xmlns="http://www.w3.org/1999/xaspx">
<head runat="server">
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="stylesheet" href="./styles/global.css">
    <link rel="stylesheet" href="./styles/product_information.css">
    <link rel="preconnect" href="https://fonts.gstatic.com">
    <link href="https://fonts.googleapis.com/css2?family=Poppins:wght@400;700&display=swap" rel="stylesheet">
    <title>Thông tin sản phẩm</title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="header">
            <div class="header__top">
                <div class="header__phone">
                    <img src="./Images/Icons/Phone.png" alt="">
                    <p>0845.944.985</p>
                </div>
                <div class="header__user-menu">
                    <ul class="header__user-menu-desktop" runat="server" id="login_status_desktop">
                        <!-- If not logged in -->
                        <li><a href="signIn.aspx">Sign In</a></li>
                        <span>|</span>
                        <!-- If logged in change signIn to username and signUp to Log Out  -->
                        <li><a href="signUp.aspx">Sign Up</a></li>
                    </ul>

                    <ul class="header__user-menu-mobile" runat="server" id="login_status_mobile">
                        <!-- If not logged in -->
                        <li><a href="signIn.aspx">Sign In</a></li>
                        <span>|</span>
                        <li><a href="signUp.aspx">Sign Up</a></li>
                        <!-- If logged in change signIn to username, signUp to icon, delete span -->
                        <!-- Display in server side aspx -->
                        <!-- <li class="signOut-mobile"><a href="signOut.aspx"><img src="./Images/Icons/LogOut.svg" alt=""></a></li> -->
                    </ul>
                </div>
            </div>
            <div class="header__main">
                <div class="header__logo">
                    <a class="logo" href="index.aspx"><img src="./Images/Logo.png" alt=""></a>
                    <a class="brand" href="index.aspx">
                        ULTRA FOOD
                    </a>
                </div>
                <div class="header__menu">
                    <ul>
                        <li><a href="all_products.aspx?type=nike">There's something for everyone!</a></li>
                        <li><a href="all_products.aspx?type=adidas">Mixed Drinks</a></li>
                        <li><a href="all_products.aspx?type=puma">Món Mặn</a></li>
                    </ul>
                </div>

                <div class="header__icons">
                    <div class="header__search">
                        <img src="./Images/Icons/Search.png" alt="">
                        <input type="text" name="search" placeholder="Search" runat="server" id="search_text">
                        <button type="button" runat="server" id="search_button" onserverclick="SearchButton_Click">Tìm</button>
                    </div>

                    <div class="header__cart">
                        <div class="cart__status">
                            <p class="cart__number" runat="server" ID="Cart_Total_Products"></p>
                        </div>
                        <a href="cart.aspx">
                            <img src="./Images/Icons/Cart.svg" alt="">
                        </a>
                    </div>
                </div>

                <div class="header__mobile">
                    <div class="mobile__menu">
                        <div class="header__cart-mobile">
                            <div class="cart__status">
                                <p class="cart__number" runat="server" id="Cart_Total_Products_Mobile">0</p>
                            </div>
                            <a href="cart.aspx">
                                <img src="./Images/Icons/Cart.svg" alt="">
                            </a>
                        </div>
                        <div class="mobile__menu-burger">
                            <div class="line-1"></div>
                            <div class="line-2"></div>
                            <div class="line-3"></div>
                        </div>
                    </div>
                    <div class="mobile__sub-menu">
                        <!-- Copy from above, inherited all the styles -->
                        <div class="header__menu-mobile">
                            <ul>
                                <li><a href="all_products.aspx?type=nike">There's something for everyone!</a></li>
                                <li><a href="all_products.aspx?type=adidas">Mixed Drinks</a></li>
                                <li><a href="all_products.aspx?type=puma">Món Mặn</a></li>
                            </ul>
                        </div>
                        <div class="header__icons-mobile">
                            <div class="header__search-mobile">
                                <img src="./Images/Icons/Search.png" alt="">
                                <input type="text" name="search" placeholder="Search" runat="server" id="search_text_mobile">
                                <button type="button" runat="server" id="search_button_mobile" onserverclick="SearchButton_Click">Tìm</button>
                            </div>
                        </div>
                        <!-- End of copy -->
                    </div>
                </div>
            </div>
        </div>

        <div class="product-information-page-content">
            <asp:ListView ID="ListViewProductInformation1" runat="server">
                <ItemTemplate>
                    <div class="product__image">
                        <span id="nav-target-image" class="nav-target-fix-first-element"></span>
                        <img src="<%# Eval("img") %>" alt="">
                    </div>
                    <div class="product__sidebar">
                        <div class="sticky-wrapper">
                            <h1 class="product__name"><%# Eval("name") %></h1>
                            <p class="product__price"><%# Eval("price") %><span>đ</span></p>
                </ItemTemplate>
            </asp:ListView>
                            <div class="product__colors">
                                <asp:ListView ID="ListViewProductColors" runat="server">
                                    <ItemTemplate>
                                        <a href="product_information.aspx?id=<%# Eval("id") %>"><img src="<%# Eval("img") %>" alt=""></img></a>
                                    </ItemTemplate>
                                </asp:ListView>
                            </div>
                            <div class="product__size">
                                <p>Chọn size</p>
                                <div class="size-container">
                                    <button class="size-btn" type="button">12K</button>
                                    <button class="size-btn" type="button">13K</button>
                                    <button class="size-btn" type="button">1UK</button>
                                    <button class="size-btn" type="button">2UK</button>
                                </div>
                            </div>
                            <div class="product__buy">
                                <button type="button" class="product__buy" runat="server" ID="AddToCartButton" onserverclick="AddToCartButton_Click">Thêm vào giỏ hàng</button>
                            </div>
                            <div class="product__guarantee">
                                <div class="free-ship">
                                    <img src="./Images/Icons/Delivery.svg" alt="">
                                    <p>Miễn phí giao hàng trong vòng 5km</p>
                                </div>
                                <div class="return">
                                    <img src="./Images/Icons/Money.svg" alt="">
                                    <p>Không đúng hàng ? Đổi trả lại hàng & Hoàn tiền</p>
                                </div>                            
                            </div>
                        </div>
                    </div>
                    <div class="product__information">
                        <div class="navigation">
                            <ul>
                                <li><a href="#nav-target-image">Ảnh sản phẩm</a></li>
                                <li><a href="#nav-target-description">MÔ TẢ</a></li>
                                <li><a href="#nav-target-specifications">THÔNG TIN CHI TIẾT</a></li>
                            </ul>
                        </div>
                        <div class="content">
                            <div id="description">
                                <span id="nav-target-description" class="nav-target-fix"></span>
                                <asp:ListView ID="ListViewProductInformation2" runat="server">
                                    <ItemTemplate>
                                        <h1><%# Eval("name") %></h1>
                                        <h2><%# Eval("detail_heading") %></h2>
                                        <p><%# Eval("detail") %></p>
                                    </ItemTemplate>
                                </asp:ListView>
                            </div>
                            <div id="specifications">
                                <span id="nav-target-specifications" class="nav-target-fix"></span>
                                <h1>Slogan Về Ẩm Thực Hay</h1>
                                <ul>
                                    <li>Thà ăn một miếng nghé non – còn hơn ăn cả một con trâu già</li>
                                    <li>Đam mê ẩm thực – tích cực giảm cân</li>
                                    <li>Yêu là phải nói, đói là phải ăn</li>
                                    <li>Độc lập tự do – miếng nào to thì gắp</li>
                                    <li>Rẻ như bèo, nghèo cũng có tiền mua</li>
                                    <li>Cá nào cũng có – Tôm nào cũng ngon</li>
                                </ul>
                            </div>
                        </div>
                    </div>
        </div>

        <div class="footer">
            <div class="footer__contact">
                <p>Số điện thoại: 0845.944.985</p>
                <p>Email: Jhinthanh@gmail.com</p>
            </div>
            <div class="footer__branch">
                <p>STK - 0301000421665 - Vietcombank - Do Van Thanh</p>
                <p>Chi nhánh : 96 Định Công - Hà Nội</p>
            </div>
            <div class="footer__social">
                <a href="https://www.facebook.com/171O2O17/" target="_blank"><img src="./Images/Social/Facebook.svg"
                        alt=""></a>
                <a href="#"><img src="./Images/Social/Twitter.svg" alt=""></a>
                <a href="#"><img src="./Images/Social/Instagram.svg" alt=""></a>
            </div>
        </div>
    </form>
    <script src="./scripts/global.js"></script>
    <script src="./scripts/product_information.js"></script>
</body>
</aspx>
