﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Website
{
    public partial class all_products : System.Web.UI.Page
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
        protected void displayCartNumber()
        {
            //Display cart number
            if (Request.Cookies["cart"] != null)
            {
                string[] cartProductsID = Request.Cookies["cart"].Value.Split(',');
                // -1 empty string after last ,
                Cart_Total_Products.InnerText = (cartProductsID.Length - 1).ToString();
                Cart_Total_Products_Mobile.InnerText = (cartProductsID.Length - 1).ToString();
            }
            else
            {
                Cart_Total_Products.InnerText = "0";
                Cart_Total_Products_Mobile.InnerText = "0";
            }   
        }

        protected void getProductsListByTypeAndFilter(string type, int begin, int end, List<Product> productsListsByTypeAndFilter, List<Product> productsLists)
        {
            foreach (Product product in productsLists)
            {
                if (type == product.type && Int32.Parse(product.price) >= begin && Int32.Parse(product.price) <= end)
                {
                    productsListsByTypeAndFilter.Add(product);
                }
            }
            ListViewAllProducts.DataSource = productsListsByTypeAndFilter;
            ListViewAllProducts.DataBind();
        }

        protected void getProductsListBySearchAndFilter(string search, int begin, int end, List<Product> productsListsBySearchAndFilter, List<Product> productsLists)
        {
            foreach (Product product in productsLists)
            {
                if (product.name.ToLower().IndexOf(search) != - 1 && Int32.Parse(product.price) >= begin && Int32.Parse(product.price) <= end)
                {
                    productsListsBySearchAndFilter.Add(product);
                }
            }
            ListViewAllProducts.DataSource = productsListsBySearchAndFilter;
            ListViewAllProducts.DataBind();
        }

        protected string totalProducts(List<Product> productsListsByTypeAndFilter)
        {
            int total = 0;
            foreach (Product product in productsListsByTypeAndFilter)
                total++;
            return total.ToString();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            string type = Request.QueryString.Get("type");
            string search = Request.QueryString.Get("search");
            string filter = Request.QueryString.Get("filter");

            if (type != null || search != null)
            {
                displayUserInformation();
                displayCartNumber();
                List<Product> productsLists = (List<Product>)Application["productsList"];
                

                if (type != null)
                {
                    //======Display page content
                    //Display products
                    type = type.ToLower();

                    if (type == "nike" || type == "adidas" || type == "puma")
                    {
                        //Change page title
                        
                        Page.Title = type.ToUpper();
                        //Create Products List
                        List<Product> productsListByTypeAndFilter = new List<Product>();
                        //Filter
                        if (filter != null)
                        {
                            if (filter == "01")
                            {
                                getProductsListByTypeAndFilter(type, 0, 1000000, productsListByTypeAndFilter, productsLists);
                                all_products_brand_name.InnerText = $"{type} Dưới 1 triệu ({totalProducts(productsListByTypeAndFilter)})";
                            }

                            if (filter == "02")
                            {
                                getProductsListByTypeAndFilter(type, 1000000, 3000000, productsListByTypeAndFilter, productsLists);
                                all_products_brand_name.InnerText = $"{type} Từ 1 - 3 triệu ({totalProducts(productsListByTypeAndFilter)})";
                            }

                            if (filter == "03")
                            {
                                getProductsListByTypeAndFilter(type, 3000000, 999999999, productsListByTypeAndFilter, productsLists);
                                all_products_brand_name.InnerText = $"{type} Trên 3 triệu ({totalProducts(productsListByTypeAndFilter)})";
                            }
                        }
                        else
                        {
                            getProductsListByTypeAndFilter(type, 0, 999999999, productsListByTypeAndFilter, productsLists);
                            all_products_brand_name.InnerText = $"{type} ({totalProducts(productsListByTypeAndFilter)})";
                        }
                    }                  
                }
                else if(search != null) {
                    //======Display Page Content
                    //Display Products
                    search = search.ToLower();

                    //Change page title
                    Page.Title = "Tìm kiếm";
                    
                    //Create Products List
                    List<Product> productsListBySearchAndFilter = new List<Product>();

                    if (filter != null)
                    {
                        if (filter == "01")
                        {
                            getProductsListBySearchAndFilter(search, 0, 1000000, productsListBySearchAndFilter, productsLists);
                            all_products_brand_name.InnerText = $"Kết quả tìm kiếm cho '{search}' Dưới 1 triệu ({totalProducts(productsListBySearchAndFilter)})";
                        }

                        if (filter == "02")
                        {
                            getProductsListBySearchAndFilter(search, 1000000, 3000000, productsListBySearchAndFilter, productsLists);
                            all_products_brand_name.InnerText = $"Kết quả tìm kiếm cho '{search}' Từ 1 - 3 triệu ({totalProducts(productsListBySearchAndFilter)})";
                        }

                        if (filter == "03")
                        {
                            getProductsListBySearchAndFilter(search, 3000000, 999999999, productsListBySearchAndFilter, productsLists);
                            all_products_brand_name.InnerText = $"Kết quả tìm kiếm cho '{search}' Trên 3 triệu ({totalProducts(productsListBySearchAndFilter)})";
                        }
                    }
                    else
                    {
                        getProductsListBySearchAndFilter(search, 0, 999999999, productsListBySearchAndFilter, productsLists);
                        all_products_brand_name.InnerText = $"Kết quả tìm kiếm cho '{search}' ({totalProducts(productsListBySearchAndFilter)})";
                    }
                }
                  

                //Add filter href
                string currentUrl = Request.Url.ToString();
                int andSignPosition = currentUrl.IndexOf('&');
                if(andSignPosition != -1)
                {
                    //Avoid multiple filter if already having a filter, ex: example.aspx?type=nike&filter=01&filter=02,...
                    string currentUrlWithOutFilter = currentUrl.Substring(0, andSignPosition);
                    Filter_01.HRef = $"{currentUrlWithOutFilter}&filter=01";
                    Filter_02.HRef = $"{currentUrlWithOutFilter}&filter=02";
                    Filter_03.HRef = $"{currentUrlWithOutFilter}&filter=03";
                }
                else
                {
                    Filter_01.HRef = $"{currentUrl}&filter=01";
                    Filter_02.HRef = $"{currentUrl}&filter=02";
                    Filter_03.HRef = $"{currentUrl}&filter=03";
                }
            }
            else
                Response.Redirect("index.aspx");
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