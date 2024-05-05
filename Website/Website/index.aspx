﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="Website.index" %>

    <!DOCTYPE aspx>

    <aspx xmlns="http://www.w3.org/1999/xaspx">
        <head runat="server">
            <meta charset="UTF-8" />
            <meta name="viewport" content="width=device-width, initial-scale=1.0" />
            <link rel="stylesheet" href="./styles/global.css" />
            <link rel="stylesheet" href="./styles/products_wrapper.css" />
            <link rel="stylesheet" href="./styles/index.css" />
            <link rel="preconnect" href="https://fonts.gstatic.com" />
            <link href="https://fonts.googleapis.com/css2?family=Poppins:wght@400;700&display=swap" rel="stylesheet" />
            <title>Trang Chủ</title>
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
                                    <p class="cart__number" runat="server" id="Cart_Total_Products"></p>
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

                <div class="index-page-content">
                    <div class="slider">
                        <div class="slider__wrapper">
                            <div class="slider__images-container">
                                <img src="./Images/banner/9.jpg" alt="">
                                <img src="./Images/banner/2.jpg" alt="">
                                <img src="./Images/banner/3.jpg" alt="">
                                <img src="./Images/banner/7.jpg" alt="">
                                <img src="./Images/banner/5.jpg" alt="">
                                <img src="./Images/banner/6.jpg" alt="">
                                <img src="./Images/banner/8.jpg" alt="">
                                 <img src="./Images/banner/4.jpg" alt="">
                            </div>
                        </div>
                        <div class="slider__content">
                            <div class="slider__heading">
                                <h1>ULTRA FOOD</h1>
                                <p>Món Ngon Cực Phẩm</p>
                            </div>
                            <div class="slider__button">
                                <a href="#">FOOD</a>
                                <a href="#">DRINK</a>
                            </div>
                        </div>
                        <div class="slider__circles">
                            <div class="slider__circle active"></div>
                            <div class="slider__circle"></div>
                            <div class="slider__circle"></div>
                        </div>
                    </div>

                    <div class="products">
                        <div class="products__nike">
                            <div class="products__heading">
                                <h2 class="products__brand-name">There's something for everyone!</h2>
                                <a href="all_products.aspx?type=nike">See more</a>
                            </div>

                            <div class="products__left-arrow"></div>

                            <div class="products__slide">
                                <div class="products__slide-wrapper">
                                    <asp:ListView ID="ListViewNikeSlideProducts" runat="server">
                                        <ItemTemplate>

                                            <div class="products__wrapper">
                                                <a href="product_information.aspx?id=<%# Eval("id") %>">
                                                    <img class="products__image" src="<%# Eval("img") %>" alt="">
                                                </a>
                                                <div class="products__content">
                                                    <h3 class="products__name"><%# Eval("name") %></h3>
                                                    <div class="products__colors">
                                                        <div class="products__color--white"></div>
                                                        <div class="products__color--black"></div>
                                                        <div class="products__color--red"></div>
                                                    </div>
                                                    <p class="products__price">Giá: <%# Eval("price") %> <span class="products__price-unit">đ</span></p>
                                                    <a class="products__button" href="product_information.aspx?id=<%# Eval("id") %>">Chi tiết</a>
                                                </div>
                                            </div>

                                        </ItemTemplate>
                                    </asp:ListView>
                                </div>        
                            </div>
                            

                            <div class="products__right-arrow"></div>
                        </div>

                        <div class="products__adidas">
                            <div class="products__heading">
                                <h2 class="products__brand-name">Mixed Drinks</h2>
                                <a href="all_products.aspx?type=adidas">See more</a>
                            </div>

                            <div class="products__left-arrow"></div>

                            <div class="products__slide">
                                <div class="products__slide-wrapper">

                                    <asp:ListView ID="ListViewAdidasSlideProducts" runat="server">
                                        <ItemTemplate>

                                            <div class="products__wrapper">
                                                <a href="product_information.aspx?id=<%# Eval("id") %>">
                                                    <img class="products__image" src="<%# Eval("img") %>" alt="">
                                                </a>
                                                <div class="products__content">
                                                    <h3 class="products__name"><%# Eval("name") %></h3>
                                                    <div class="products__colors">
                                                        <div class="products__color--white"></div>
                                                        <div class="products__color--black"></div>
                                                        <div class="products__color--red"></div>
                                                    </div>
                                                    <p class="products__price">Giá: <%# Eval("price") %> <span class="products__price-unit">đ</span></p>
                                                    <a class="products__button" href="product_information.aspx?id=<%# Eval("id") %>">Chi tiết</a>
                                                </div>
                                            </div>

                                        </ItemTemplate>
                                    </asp:ListView>
                                    
                                </div>
                            </div>

                            <div class="products__right-arrow"></div>
                        </div>

                        <div class="products__puma">
                            <div class="products__heading">
                                <h2 class="products__brand-name">Món Mặn</h2>
                                <a href="all_products.aspx?type=puma">See more</a>
                            </div>

                            <div class="products__left-arrow"></div>

                            <div class="products__slide">
                                <div class="products__slide-wrapper">
                                    <asp:ListView ID="ListViewPumaSlideProducts" runat="server">
                                        <ItemTemplate>
                                            <div class="products__wrapper">
                                                <a href="product_information.aspx?id=<%# Eval("id") %>">
                                                    <img class="products__image" src="<%# Eval("img") %>" alt="">
                                                </a>
                                                <div class="products__content">
                                                    <h3 class="products__name"><%# Eval("name") %></h3>
                                                    <div class="products__colors">
                                                        <div class="products__color--white"></div>
                                                        <div class="products__color--black"></div>
                                                        <div class="products__color--red"></div>
                                                    </div>
                                                    <p class="products__price">Giá: <%# Eval("price") %> <span class="products__price-unit">đ</span></p>
                                                    <a class="products__button" href="product_information.aspx?id=<%# Eval("id") %>">Chi tiết</a>
                                                </div>
                                            </div>
                                        </ItemTemplate>
                                    </asp:ListView>
                                </div>
                            </div>
                            <div class="products__right-arrow"></div>
                        </div>
                    </div>
                </div>

                <div class="footer">
                    <div class="footer__contact">
                        <p>Số điện thoại: 0845.944.985</p>
                        <p>Email: Jhinthanh@gmail.com</p>
                    </div>
                    <div class="footer__branch">
                        <p>STK:STK -  0301000421665 - Vietcombank - Do Van Thanh</p>
                        <p>Chi nhánh : 96 Định Công - Hà Nội</p>
                    </div>
                    <div class="footer__social">
                        <a href="https://www.facebook.com/171O2O17/" target="_blank"><img
                                src="./Images/Social/Facebook.svg" alt=""></a>
                        <a href="#"><img src="./Images/Social/Twitter.svg" alt=""></a>
                        <a href="#"><img src="./Images/Social/Instagram.svg" alt=""></a>
                    </div>
                </div>

                <script src="./scripts/global.js"></script>
                <script src="./scripts/index.js"></script>
            </form>
        </body>
    </aspx>