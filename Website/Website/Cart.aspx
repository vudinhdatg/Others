﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Cart.aspx.cs" Inherits="Website.Cart" %>

    <!DOCTYPE html>

    <html xmlns="http://www.w3.org/1999/xhtml">

    <head runat="server">
        <meta charset="UTF-8">
        <meta http-equiv="X-UA-Compatible" content="IE=edge">
        <meta name="viewport" content="width=device-width, initial-scale=1.0">
        <link rel="stylesheet" href="./styles/global.css">
        <link rel="stylesheet" href="./styles/cart.css">
        <link rel="preconnect" href="https://fonts.gstatic.com">
        <link href="https://fonts.googleapis.com/css2?family=Poppins:wght@400;700&display=swap" rel="stylesheet">
        <title>Giỏ hàng</title>
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
                            <button type="button" runat="server" id="search_button"
                                onserverclick="SearchButton_Click">Tìm</button>
                        </div>

                        <div class="header__cart">
                            <div class="cart__status">
                                <p runat="server" class="cart__number" id="Cart_Total_Products">0</p>
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
                                    <input type="text" name="search" placeholder="Search" runat="server"
                                        id="search_text_mobile">
                                    <button type="button" runat="server" id="seach_button_mobile"
                                        onserverclick="SearchButton_Click">Tìm</button>
                                </div>
                            </div>
                            <!-- End of copy -->
                        </div>
                    </div>
                </div>
            </div>

            <div class="cart-page-content">
                <div class="cart--left">
                    <h2 class="cart__title--left">Giỏ hàng</h2>
                    <div class="cart__products-container">
                        <asp:ListView ID="ListViewCart" runat="server">
                            <ItemTemplate>
                                <div class="cart__product-wrapper">
                                    <div class="cart__product-image-wrapper">
                                        <img class="cart__product-image" src="<%# Eval("img") %>" alt="">
                                    </div>
                                    <div class="cart__product-information">
                                        <p class="cart__product-name">
                                            <%# Eval("name") %>
                                        </p>
                                        <p></p>                                     
                                        <p class="cart__product-quantity">Số lượng: 1</p>
                                        <div class="cart__buttons--left">
                                            <a class="delete-button cart__button" href="Delete_Cart.aspx?id=<%# Eval("id") %>">Xoá khỏi giỏ hàng</a>
                                            <a class="information-button cart__button" href="product_information.aspx?id=<%# Eval("id") %>">Chi tiết</a>
                                        </div>
                                    </div>
                                    <div class="cart__product-price-wrapper">
                                        <p class="cart__product-price">
                                            <%# Eval("price") %> <span class="cart__product-price-unit">đ</span>
                                        </p>
                                    </div>
                                </div>
                            </ItemTemplate>
                        </asp:ListView>
                    </div>
                </div>
                <div class="cart--right">
                    <h2 class="cart__title--right">Đơn hàng</h2>
                    <div class="cart__products-total-price">
                        <p>Số Lượng Sản Phẩm là:  <span runat="server" id="total_products"></span> Tổng Tiền:</p>
                        <p runat="server" id="products_price"><span class="cart__product-price-unit"></span></p>
                    </div>
                    <div class="cart__delivery-price">
                         <!-- <p></p>
                        <p runat="server" id="delivery_price"> <span class="cart__product-price-unit"></span></p>-->
                    </div>                   
                    <div class="cart__order-total">
                      <!--  <p> </p>
                        <p runat="server" id="order_total_price"><span class="cart__product-price-unit"></span></p>-->
                    </div>                 
                    <!-- <div class="cart__buttons--right">
                        <button class="purchase-button" type="button"></button>
                    </div>-->

                

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
    </body>

    </html>