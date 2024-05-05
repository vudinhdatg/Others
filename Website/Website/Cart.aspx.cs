﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Website
{
    public partial class Cart : System.Web.UI.Page
    {
        protected void displayUserInformation()
        {
            //Display user information
            if (Session["login"].ToString() == "1")
            {
                string username = Session["username"].ToString();

                login_status_desktop.InnerHtml = "<li>Hi " + username + "</li>" +
                                                 "<span>|</span>" +
                                                 "<li><a href='signOut.aspx'>Sign Out</a></li>";

                login_status_mobile.InnerHtml = "<li>Hi " + username + "</li>" +
                                                "<li class='signOut-mobile'><a href='signOut.aspx'><img src='./Images/Icons/LogOut.svg' alt=''></a></li>";
            }
        }
        protected string displayCartNumber()
        {
            //Display cart number
            if (Request.Cookies["cart"] != null)
            {
                string[] cartProductsID = Request.Cookies["cart"].Value.Split(',');
                // -1 empty string after last ,
                Cart_Total_Products.InnerText = (cartProductsID.Length - 1).ToString();
                Cart_Total_Products_Mobile.InnerText = (cartProductsID.Length - 1).ToString();
                return (cartProductsID.Length - 1).ToString(); ;
            }
            else
            {
                Cart_Total_Products.InnerText = "0";
                Cart_Total_Products_Mobile.InnerText = "0";
                return "0";
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            displayUserInformation();
            displayCartNumber();

            //========= Display page content

            //Display products
            if(Request.Cookies["cart"] != null)
            {
                List<Product> cartList = new List<Product>();
                List<Product> productsLists = (List<Product>)Application["productsList"];
                string[] productsID = Request.Cookies["cart"].Value.Split(',');
                foreach (string productID in productsID)
                {
                    foreach (Product product in productsLists)
                    {
                        if (product.id == productID)
                        {
                            cartList.Add(product);
                        }
                    }
                }

                ListViewCart.DataSource = cartList;
                ListViewCart.DataBind();
                /**/
                //Display total products
                total_products.InnerText = displayCartNumber();

                //Display products price
                int productsPrice = 0;
                foreach (Product product in cartList) productsPrice += Int32.Parse(product.price);
                products_price.InnerHtml = $"{productsPrice} <span class='cart__product-price-unit'>đ</span>";

                //Display delivery price
                const int DELIVERY = 50000;
                delivery_price.InnerHtml = $"{DELIVERY} <span class='cart__product-price-unit'>đ</span>";

                //Display order total price
                int orderTotal = productsPrice + DELIVERY;
                order_total_price.InnerHtml = $"{orderTotal} <span class='cart__product-price-unit'>đ</span>";
            }
        }
        protected void SearchButton_Click(object sender, EventArgs e)
        {
            string searchText = "";

            if (search_text.Value != "")
            {
                searchText = search_text.Value.ToLower();
            }
            else if (search_text_mobile.Value != "")
            {
                searchText = search_text_mobile.Value.ToLower();
            }

            Response.Redirect($"all_products.aspx?search={searchText}");
        }

    }
}