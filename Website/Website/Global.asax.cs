using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace Website
{
    public class Global : System.Web.HttpApplication
    {
        protected void Application_Start(object sender, EventArgs e)
        {
            Application["productsList"] = new List<Product>();
            List<Product> productsList = new List<Product>();
            Application["users"] = new List<User>();

            
            //Nike
            productsList.Add(new Product() { id = "1.1", img = "./Images/There's something for everyone!/1.jpg", name = "Socola-New", price = "120000", detail_heading = "Thương Hiệu Việt", detail = "Giao Hàng Nhanh • 5-20 phút  •  0,5 km - Giờ mở cửa Today  10:00 - 22:00", type = "nike" });
            productsList.Add(new Product() { id = "1.2", img = "./Images/There's something for everyone!/2.jpg", name = "Thịt Kho Tàu", price = "264000", detail_heading = "Thương Hiệu Việt", detail = "Giao Hàng Nhanh  • • 35-40 phút  •  3,5 km - Giờ mở cửa Today  10:00 - 22:00", type = "nike" });
            productsList.Add(new Product() { id = "1.3", img = "./Images/There's something for everyone!/3.jpg", name = "Fant", price = "149000", detail_heading = "Thương Hiệu Việt", detail = "Giao Hàng Nhanh  • 15-20 phút  •  1,5 km - Giờ mở cửa Today  10:00 - 22:00", type = "nike" });
            productsList.Add(new Product() { id = "2.1", img = "./Images/There's something for everyone!/4.jpg", name = "ORZO-PERLATO ", price = "230000", detail_heading = "Thương Hiệu Việt", detail = "Giao Hàng Nhanh  • 22-24 phút  •  4,15 km - Giờ mở cửa Today  10:00 - 22:00", type = "nike" });
            productsList.Add(new Product() { id = "2.2", img = "./Images/There's something for everyone!/5.jpg", name = "Semmel-Knodel", price = "199000", detail_heading = "Thương Hiệu Việt", detail = "Giao Hàng Nhanh  • 15-20 phút  •  1,15 km - Giờ mở cửa Today  10:00 - 22:00", type = "nike" });
            productsList.Add(new Product() { id = "2.3", img = "./Images/There's something for everyone!/6.jpg", name = "Cafe Fin", price = "229000", detail_heading = "Thương Hiệu Việt", detail = "Giao Hàng Nhanh  • 5-20 phút  •  0,5 km - Giờ mở cửa Today  10:00 - 22:00", type = "nike" });
            productsList.Add(new Product() { id = "3.1", img = "./Images/There's something for everyone!/a.jpeg", name = "Mix-Max", price = "129000", detail_heading = "Thương Hiệu Việt", detail = "Giao Hàng Nhanh  • 15-22 phút  •  4,5 km - Giờ mở cửa Today  10:00 - 22:00", type = "nike" });
            productsList.Add(new Product() { id = "3.2", img = "./Images/There's something for everyone!/8.jpg", name = "Dextro-energy", price = "145000", detail_heading = "Thương Hiệu Việti", detail = "Giao Hàng Nhanh  • 22-24 phút  •  2,4 km - Giờ mở cửa Today  10:00 - 22:00", type = "nike" });
            productsList.Add(new Product() { id = "3.3", img = "./Images/There's something for everyone!/9.jpg", name = "DEX-TRA", price = "90000", detail_heading = "Thương Hiệu Việt", detail = "Giao Hàng Nhanh  • 44-50 phút  •  6,5 km - Giờ mở cửa Today  10:00 - 22:00", type = "nike" });
            productsList.Add(new Product() { id = "4.1", img = "./Images/There's something for everyone!/10.jpg", name = "Caramen Dâu Tây", price = "359000", detail_heading = "Thương Hiệu Việt", detail = "Giao Hàng Nhanh  • 21-25 phút  •  5,15 km - Giờ mở cửa Today  10:00 - 22:00", type = "nike" });
            productsList.Add(new Product() { id = "4.2", img = "./Images/There's something for everyone!/11.jpg", name = "Grilled Nuggets", price = "519000", detail_heading = "Thương Hiệu Việt", detail = "Giao Hàng Nhanh  • 25-30 phút  •  6,2 km - Giờ mở cửa Today  10:00 - 22:00", type = "nike" });
            productsList.Add(new Product() { id = "5.1", img = "./Images/There's something for everyone!/12.jpg", name = "Dextro-energy-minis", price = "1699000", detail_heading = "Thương Hiệu Việt", detail = "Giao Hàng Nhanh  • 5-20 phút  •  0,5 km - Giờ mở cửa Today  10:00 - 22:00", type = "nike" });
            productsList.Add(new Product() { id = "8.1", img = "./Images/There's something for everyone!/13.jpg", name = "Genuss-PUR", price = "583000", detail_heading = "Thương Hiệu Việt", detail = "Giao Hàng Nhanh  • 15-20 phút  •  4,5 km - Giờ mở cửa Today  10:00 - 22:00", type = "nike" });
            productsList.Add(new Product() { id = "5.2", img = "./Images/There's something for everyone!/14.png", name = "Lotteria - Khâm Thiên", price = "150000", detail_heading = "Thương Hiệu Việt", detail = "Giao Hàng Nhanh  • 15-20 phút  •  4,5 km - Giờ mở cửa Today  10:00 - 22:00", type = "nike" });
            productsList.Add(new Product() { id = "5.3", img = "./Images/There's something for everyone!/15.jpg", name = "Bánh mì", price = "99000", detail_heading = "Thương Hiệu Việt", detail = "Giao Hàng Nhanh  • 5-15 phút  •  2,5 km - Giờ mở cửa Today  10:00 - 22:00", type = "nike" });
            productsList.Add(new Product() { id = "6.1", img = "./Images/There's something for everyone!/16.jpg", name = "Khoai Tây Chiên", price = "30000", detail_heading = "Thương Hiệu Việt", detail = "Giao Hàng Nhanh  • 5-20 phút  •  0,5 km - Giờ mở cửa Today  10:00 - 22:00", type = "nike" });
            productsList.Add(new Product() { id = "6.2", img = "./Images/There's something for everyone!/17.jpg", name = "Honiggurken", price = "100000", detail_heading = "Thương Hiệu Việt", detail = "Giao Hàng Nhanh  • 5-10 phút  •  0,5 km - Giờ mở cửa Today  10:00 - 22:00", type = "nike" });
            productsList.Add(new Product() { id = "7.2", img = "./Images/There's something for everyone!/18.jpg", name = "Golden-Yorrkshires", price = "209000", detail_heading = "Thương Hiệu Việt", detail = "Giao Hàng Nhanh  • 2-5 phút  •  0,5 km - Giờ mở cửa Today  10:00 - 22:00", type = "nike" });
            productsList.Add(new Product() { id = "7.3", img = "./Images/There's something for everyone!/19.png", name = "Chick-fil-A® Deluxe Sandwich", price = "39000", detail_heading = "Thương Hiệu Việt", detail = "Giao Hàng Nhanh  • 24-30 phút  •  5,5 km - Giờ mở cửa Today  10:00 - 22:00", type = "nike" });
            productsList.Add(new Product() { id = "8.2", img = "./Images/There's something for everyone!/20.png", name = "Chick-fil-A® Cool Wrap", price = "83000", detail_heading = "Thương Hiệu Việt", detail = "Giao Hàng Nhanh  • 35-40 phút  •  8,5 km - Giờ mở cửa Today  10:00 - 22:00", type = "nike" });
            //Adidas
            productsList.Add(new Product() { id = "21.1", img = "./Images/Mixed Drinks/1.jpeg", name = "Trà Bí Đao An Nhiên - Khâm Thiên", price = "2400000", detail_heading = "Hương Vị Đậm Đà", detail = "Giao Hàng Nhanh  • 28 phút  •  5,43 km , Giờ mở cửa Today  00:00-23:59 • Giảm 50% mã CHIEUDAI50.Giảm 15K mã FREESHIPHN.Giảm 45K mã GF50KHN.Giảm 35K mã GF40KHN ", type = "adidas"  });
            productsList.Add(new Product() { id = "21.2", img = "./Images/Mixed Drinks/2.jpg", name = "Cộng Cà Phê - Điện Biên Phủ", price = "2400000", detail_heading = "Hương Vị Độc Đáo", detail = "Giao Hàng Nhanh  • 25 phút  •  3,13 km  •  1,5 km , Giờ mở cửa Today  00:00-23:59 • Giảm 50% mã CHIEUDAI50.Giảm 15K mã FREESHIPHN.Giảm 45K mã GF50KHN.Giảm 35K mã GF40KHN", type = "adidas"  });
            productsList.Add(new Product() { id = "21.3", img = "./Images/Mixed Drinks/3.png", name = "RoyalTea - 126A Giảng Võ", price = "2400000", detail_heading = "Hương Vị Đậm Đà", detail = "Giao Hàng Nhanh  • 28 phút  •  5,43 km , Giờ mở cửa Today  00:00-23:59 • Giảm 50% mã CHIEUDAI50.Giảm 15K mã FREESHIPHN.Giảm 45K mã GF50KHN.Giảm 35K mã GF40KHN", type = "adidas" });
            productsList.Add(new Product() { id = "22.1", img = "./Images/Mixed Drinks/4.jpg", name = "Trà Dâu Sữa - RoyalTea", price = "3100000", detail_heading = "Hương Vị Độc Đáo", detail = "Giao Hàng Nhanh  • 30 phút  •  5,3 km, Giờ mở cửa Today  00:00-23:59 • Giảm 50% mã CHIEUDAI50.Giảm 15K mã FREESHIPHN.Giảm 45K mã GF50KHN.Giảm 35K mã GF40KHN", type = "adidas" });
            productsList.Add(new Product() { id = "22.2", img = "./Images/Mixed Drinks/5.jpg", name = "Lục trà Royal - lạnh", price = "3100000", detail_heading = "Hương Vị Đậm Đà", detail = "Giao Hàng Nhanh  • 20 phút  •  4,3 km , Giờ mở cửa Today  00:00-23:59 • Giảm 50% mã CHIEUDAI50.Giảm 15K mã FREESHIPHN.Giảm 45K mã GF50KHN.Giảm 35K mã GF40KHN", type = "adidas"  });
            productsList.Add(new Product() { id = "22.3", img = "./Images/Mixed Drinks/6.jpg", name = "Trà cam bưởi Ruby", price = "3100000", detail_heading = "Hương Vị Độc Đáo", detail = "Giao Hàng Nhanh  • 25 phút  •  3,13 km  •  1,5 km , Giờ mở cửa Today  00:00-23:59 • Giảm 50% mã CHIEUDAI50.Giảm 15K mã FREESHIPHN.Giảm 45K mã GF50KHN.Giảm 35K mã GF40KHN", type = "adidas"  });
            productsList.Add(new Product() { id = "23.1", img = "./Images/Mixed Drinks/7.jpg", name = "Trà dưa hấu kem cheese", price = "5000000", detail_heading = "Hương Vị Đậm Đà", detail = "Giao Hàng Nhanh  • 30 phút  •  5,3 km , Giờ mở cửa Today  00:00-23:59 • Giảm 50% mã CHIEUDAI50.Giảm 15K mã FREESHIPHN.Giảm 45K mã GF50KHN.Giảm 35K mã GF40KHN", type = "adidas",  });
            productsList.Add(new Product() { id = "23.2", img = "./Images/Mixed Drinks/8.jpg", name = "Matcha Uji - lạnh", price = "5000000", detail_heading = "Hương Vị Độc Đáo", detail = "Giao Hàng Nhanh  • 30 phút  •  5,3 km , Giờ mở cửa Today  00:00-23:59 • Giảm 50% mã CHIEUDAI50.Giảm 15K mã FREESHIPHN.Giảm 45K mã GF50KHN.Giảm 35K mã GF40KHN", type = "adidas"  });
            productsList.Add(new Product() { id = "23.3", img = "./Images/Mixed Drinks/9.jpg", name = "Trà oolong Royal kem cheese - lạnh", price = "5000000", detail_heading = "Hương Vị Độc Đáo", detail = "Giao Hàng Nhanh  • 20 phút  •  4,3 km , Giờ mở cửa Today  00:00-23:59 • Giảm 50% mã CHIEUDAI50.Giảm 15K mã FREESHIPHN.Giảm 45K mã GF50KHN.Giảm 35K mã GF40KHN", type = "adidas"  });
            productsList.Add(new Product() { id = "24.1", img = "./Images/Mixed Drinks/10.jpg", name = "Trà kiwi táo xanh", price = "2100000", detail_heading = "Hương Vị Đậm Đà", detail = "Giao Hàng Nhanh  • 20 phút  •  4,3 km, Giờ mở cửa Today  00:00-23:59 • Giảm 50% mã CHIEUDAI50.Giảm 15K mã FREESHIPHN.Giảm 45K mã GF50KHN.Giảm 35K mã GF40KHN", type = "adidas"  });
            productsList.Add(new Product() { id = "24.2", img = "./Images/Mixed Drinks/11.jpg", name = "J2. Red wedding", price = "2100000", detail_heading = "Hương Vị Độc Đáo", detail = "Giao Hàng Nhanh  • 28 phút  •  5,43 km, Giờ mở cửa Today  00:00-23:59 • Giảm 50% mã CHIEUDAI50.Giảm 15K mã FREESHIPHN.Giảm 45K mã GF50KHN.Giảm 35K mã GF40KHN", type = "adidas"  });
            productsList.Add(new Product() { id = "24.3", img = "./Images/Mixed Drinks/12.jpg", name = "J5. Lettuce drink up", price = "2100000", detail_heading = "Hương Vị Đậm Đà", detail = "Giao Hàng Nhanh  • 25 phút  •  3,13 km, Giờ mở cửa Today  00:00-23:59 • Giảm 50% mã CHIEUDAI50.Giảm 15K mã FREESHIPHN.Giảm 45K mã GF50KHN.Giảm 35K mã GF40KHN", type = "adidas"  });
            productsList.Add(new Product() { id = "25.1", img = "./Images/Mixed Drinks/13.jpg", name = "M3. Avo la vista", price = "500000", detail_heading = "Hương Vị Độc Đáo", detail = "Giao Hàng Nhanh  • 30 phút  •  5,3 km , Giờ mở cửa Today  00:00-23:59 • Giảm 50% mã CHIEUDAI50.Giảm 15K mã FREESHIPHN.Giảm 45K mã GF50KHN.Giảm 35K mã GF40KHN", type = "adidas"  });
            productsList.Add(new Product() { id = "25.2", img = "./Images/Mixed Drinks/14.jpg", name = "Bia - TIGER", price = "500000", detail_heading = "Hương Vị Độc Đáo", detail = "Giao Hàng Nhanh  • 28 phút  •  5,43 km, Giờ mở cửa Today  00:00-23:59 • Giảm 50% mã CHIEUDAI50.Giảm 15K mã FREESHIPHN.Giảm 45K mã GF50KHN.Giảm 35K mã GF40KHN", type = "adidas"  });
            productsList.Add(new Product() { id = "25.3", img = "./Images/Mixed Drinks/15.jpg", name = "Bia - SAPPHIRE - Hạ Long", price = "500000", detail_heading = "Hương Vị Đậm Đà", detail = "Giao Hàng Nhanh  • 20 phút  •  4,3 km , Giờ mở cửa Today  00:00-23:59 • Giảm 50% mã CHIEUDAI50.Giảm 15K mã FREESHIPHN.Giảm 45K mã GF50KHN.Giảm 35K mã GF40KHN", type = "adidas"  });
            productsList.Add(new Product() { id = "26.1", img = "./Images/Mixed Drinks/20.png", name = "Nước Ép, Sinh Tố, Nước Mía 86 Kim Mã", price = "2500000", detail_heading = "Hương Vị Độc Đáo", detail = "Giao Hàng Nhanh  • 25 phút  •  3,13 km • 20 phút  •  1,5 km , Giờ mở cửa Today  00:00-23:59 • Giảm 50% mã CHIEUDAI50.Giảm 15K mã FREESHIPHN.Giảm 45K mã GF50KHN.Giảm 35K mã GF40KHN", type = "adidas"  });
            productsList.Add(new Product() { id = "26.2", img = "./Images/Mixed Drinks/19.png", name = "Nước Dừa 243 Đê La Thành", price = "2500000", detail_heading = "Hương Vị Độc Đáo", detail = "Giao Hàng Nhanh  • 28 phút  •  5,43 km , Giờ mở cửa Today  00:00-23:59 • Giảm 50% mã CHIEUDAI50.Giảm 15K mã FREESHIPHN.Giảm 45K mã GF50KHN.Giảm 35K mã GF40KHN", type = "adidas"  });
            productsList.Add(new Product() { id = "26.3", img = "./Images/Mixed Drinks/18.jpeg", name = "Dung - Nước Ép Trái Cây", price = "2500000", detail_heading = "Hương Vị Độc Đáo", detail = "Giao Hàng Nhanh  • 25 phút  •  3,13 km , Giờ mở cửa Today  00:00-23:59 • Giảm 50% mã CHIEUDAI50.Giảm 15K mã FREESHIPHN.Giảm 45K mã GF50KHN.Giảm 35K mã GF40KHN", type = "adidas" });
            productsList.Add(new Product() { id = "27.1", img = "./Images/Mixed Drinks/17.jpg", name = "Nước ép cóc", price = "5000000", detail_heading = "Hương Vị Độc Đáo", detail = "Giao Hàng Nhanh  • 28 phút  •  5,43 km , Giờ mở cửa Today  00:00-23:59 • Giảm 50% mã CHIEUDAI50.Giảm 15K mã FREESHIPHN.Giảm 45K mã GF50KHN.Giảm 35K mã GF40KHN", type = "adidas"  });
            productsList.Add(new Product() { id = "27.2", img = "./Images/Mixed Drinks/16.jpg", name = "Sinh tố Dưa Hấu", price = "5000000", detail_heading = "Hương Vị Độc Đáo", detail = "Giao Hàng Nhanh  • 25 phút  •  3,13 km, Giờ mở cửa Today  00:00-23:59 • Giảm 50% mã CHIEUDAI50.Giảm 15K mã FREESHIPHN.Giảm 45K mã GF50KHN.Giảm 35K mã GF40KHN", type = "adidas"  });
  

            //Puma
            productsList.Add(new Product() { id = "41.1", img = "./Images/Mon Man/1.png", name = "Gà Luộc, Gà Ủ Muối Tràng Thi", price = "2300000", detail_heading = "Đậm Đà Hương Sắc Việt", detail = "Giao Hàng Nhanh  • 25 phút  •  3,13 km, Giờ mở cửa Today  00:00-23:59 • Menu Giảm 5% • Giảm 50K đơn 100K mã SIEUSALE50LT.SUPERBOSS20 Giảm 30K đơn 40K.Nhập BOSSXANHLA2 giảm 25K.Giảm 35K mã BOSS35. ", type = "puma" });
            productsList.Add(new Product() { id = "41.2", img = "./Images/Mon Man/2.png", name = "Chân Gà Nướng Thịnh Vượng", price = "2300000", detail_heading = "Đậm Đà Hương Sắc Việt", detail = "Giao Hàng Nhanh  • 40 phút  •  6,3 km, Giờ mở cửa Today  00:00-23:59 • Menu Giảm 5% • Giảm 50K đơn 100K mã SIEUSALE50LT.SUPERBOSS20 Giảm 30K đơn 40K.Nhập BOSSXANHLA2 giảm 25K.Giảm 35K mã BOSS35.", type = "puma" });
            productsList.Add(new Product() { id = "41.3", img = "./Images/Mon Man/3.jpg", name = "Sườn lợn nướng", price = "2300000", detail_heading = "Đậm Đà Hương Sắc Việtn", detail = "Giao Hàng Nhanh  • • 25 phút  •  3,13 km, Giờ mở cửa Today  00:00-23:59 • Menu Giảm 5% • Giảm 50K đơn 100K mã SIEUSALE50LT.SUPERBOSS20 Giảm 30K đơn 40K.Nhập BOSSXANHLA2 giảm 25K.Giảm 35K mã BOSS35.", type = "puma" });
            productsList.Add(new Product() { id = "42.1", img = "./Images/Mon Man/4.jpg", name = "Rau muống muối", price = "1499000", detail_heading = "Đậm Đà Hương Sắc Việt", detail = "Giao Hàng Nhanh  • 10 phút  •  2,3 km, Giờ mở cửa Today  00:00-23:59 • Menu Giảm 5% • Giảm 50K đơn 100K mã SIEUSALE50LT.SUPERBOSS20 Giảm 30K đơn 40K.Nhập BOSSXANHLA2 giảm 25K.Giảm 35K mã BOSS35.", type = "puma"});
            productsList.Add(new Product() { id = "42.2", img = "./Images/Mon Man/5.jpeg", name = "Cháo", price = "1499000", detail_heading = "Đậm Đà Hương Sắc Việt", detail = "Giao Hàng Nhanh  • 10 phút  •  2,3 km, Giờ mở cửa Today  00:00-23:59 • Menu Giảm 5% • Giảm 50K đơn 100K mã SIEUSALE50LT.SUPERBOSS20 Giảm 30K đơn 40K.Nhập BOSSXANHLA2 giảm 25K.Giảm 35K mã BOSS35.", type = "puma"});
            productsList.Add(new Product() { id = "42.3", img = "./Images/Mon Man/6.jpeg", name = "Cơm Tấm", price = "1499000", detail_heading = "Đậm Đà Hương Sắc Việt", detail = "Giao Hàng Nhanh  • 28 phút  •  5,43 km, Giờ mở cửa Today  00:00-23:59 • Menu Giảm 5% • Giảm 50K đơn 100K mã SIEUSALE50LT.SUPERBOSS20 Giảm 30K đơn 40K.Nhập BOSSXANHLA2 giảm 25K.Giảm 35K mã BOSS35.", type = "puma" });
            productsList.Add(new Product() { id = "43.1", img = "./Images/Mon Man/7.png", name = "Bếp Quán Zì", price = "1599000", detail_heading = "Đậm Đà Hương Sắc Việt", detail = "Giao Hàng Nhanh  • 10 phút  •  3,2 km, Giờ mở cửa Today  00:00-23:59 • Menu Giảm 5% • Giảm 50K đơn 100K mã SIEUSALE50LT.SUPERBOSS20 Giảm 30K đơn 40K.Nhập BOSSXANHLA2 giảm 25K.Giảm 35K mã BOSS35.", type = "puma" });
            productsList.Add(new Product() { id = "43.2", img = "./Images/Mon Man/8.jpg", name = "Phở Lườn Nem Lụi Nướng", price = "1599000", detail_heading = "Đậm Đà Hương Sắc Việt", detail = "Giao Hàng Nhanh  • 25 phút  •  3,13 km, Giờ mở cửa Today  00:00-23:59 • Menu Giảm 5% • Giảm 50K đơn 100K mã SIEUSALE50LT.SUPERBOSS20 Giảm 30K đơn 40K.Nhập BOSSXANHLA2 giảm 25K.Giảm 35K mã BOSS35.", type = "puma"});
            productsList.Add(new Product() { id = "43.3", img = "./Images/Mon Man/9.jpg", name = "Mì Trộn Siêu Đẳng Cấp Siêu Sốt Đặc Biệt", price = "1599000", detail_heading = "Đậm Đà Hương Sắc Việt", detail = "Giao Hàng Nhanh  • 40 phút  •  6,3 km, Giờ mở cửa Today  00:00-23:59 • Menu Giảm 5% • Giảm 50K đơn 100K mã SIEUSALE50LT.SUPERBOSS20 Giảm 30K đơn 40K.Nhập BOSSXANHLA2 giảm 25K.Giảm 35K mã BOSS35.", type = "puma"});
            productsList.Add(new Product() { id = "44.1", img = "./Images/Mon Man/10.jpg", name = "Viên Chiên Tổng Hợp Set 2", price = "2700000", detail_heading = "Đậm Đà Hương Sắc Việt", detail = "Giao Hàng Nhanh  • 40 phút  •  6,23 km, Giờ mở cửa Today  00:00-23:59 • Menu Giảm 5% • Giảm 50K đơn 100K mã SIEUSALE50LT.SUPERBOSS20 Giảm 30K đơn 40K.Nhập BOSSXANHLA2 giảm 25K.Giảm 35K mã BOSS35.", type = "puma" });
            productsList.Add(new Product() { id = "44.2", img = "./Images/Mon Man/11.jpg", name = "Mì Trộn Mực Xoắn Rau Củ Siêu Sốt Ngũ Vị", price = "2700000", detail_heading = "Đậm Đà Hương Sắc Việt", detail = "Giao Hàng Nhanh  • 20 phút  •  4,3 km, Giờ mở cửa Today  00:00-23:59 • Menu Giảm 5% • Giảm 50K đơn 100K mã SIEUSALE50LT.SUPERBOSS20 Giảm 30K đơn 40K.Nhập BOSSXANHLA2 giảm 25K.Giảm 35K mã BOSS35.", type = "puma" });
            productsList.Add(new Product() { id = "44.3", img = "./Images/Mon Man/12.jpg", name = "Mì Trộn Bò Nướng Siêu Sốt BBQ", price = "2700000", detail_heading = "Đậm Đà Hương Sắc Việt", detail = "Giao Hàng Nhanh  • 30 phút  •  5,13 km, Giờ mở cửa Today  00:00-23:59 • Menu Giảm 5% • Giảm 50K đơn 100K mã SIEUSALE50LT.SUPERBOSS20 Giảm 30K đơn 40K.Nhập BOSSXANHLA2 giảm 25K.Giảm 35K mã BOSS35.", type = "puma" });
            productsList.Add(new Product() { id = "45.1", img = "./Images/Mon Man/13.jpg", name = "Mì Trộn Nem Lụi Nướng x2 Nem", price = "1600000", detail_heading = "Nem lụi nướng siêu cấp kết hợp với Siêu Sốt Ngũ Vị của Bếp Quán Zì tạo nên Siêu Phẩm Mì indomie. Hương thơm thơm, vị bùi bùi, beo béo, cay nhẹ nhàng vừa đủ kí sâg.", detail = "Giao Hàng Nhanh  • 40 phút  •  6,3 km, Giờ mở cửa Today  00:00-23:59 • Menu Giảm 5% • Giảm 50K đơn 100K mã SIEUSALE50LT.SUPERBOSS20 Giảm 30K đơn 40K.Nhập BOSSXANHLA2 giảm 25K.Giảm 35K mã BOSS35.", type = "puma"});
            productsList.Add(new Product() { id = "45.2", img = "./Images/Mon Man/14.jpg", name = "3 con tôm surimi thả lẩu , trộn mì", price = "1600000", detail_heading = "Đậm Đà Hương Sắc Việt", detail = "Giao Hàng Nhanh  • 10 phút  •  3,3 km, Giờ mở cửa Today  00:00-23:59 • Menu Giảm 5% • Giảm 50K đơn 100K mã SIEUSALE50LT.SUPERBOSS20 Giảm 30K đơn 40K.Nhập BOSSXANHLA2 giảm 25K.Giảm 35K mã BOSS35. ", type = "puma" });
            productsList.Add(new Product() { id = "45.3", img = "./Images/Mon Man/15.jpg", name = "Cá Song Hấp", price = "1600000", detail_heading = "Đặc Sản Biển Hạ Long Quảng Ninh", detail = "Giao Hàng Nhanh  • 30 phút  •  7,3 km, Giờ mở cửa Today  00:00-23:59 • Menu Giảm 5% • Giảm 50K đơn 100K mã SIEUSALE50LT.SUPERBOSS20 Giảm 30K đơn 40K.Nhập BOSSXANHLA2 giảm 25K.Giảm 35K mã BOSS35. ", type = "puma" });
            productsList.Add(new Product() { id = "46.1", img = "./Images/Mon Man/16.jpg", name = "Bề Bề Rang Muối", price = "2500000", detail_heading = "Đặc Sản Biển Hạ Long Quảng Ninh ", detail = "Giao Hàng Nhanh  • 50 phút  •  16,3 km, Giờ mở cửa Today  00:00-23:59 • Menu Giảm 5% • Giảm 50K đơn 100K mã SIEUSALE50LT.SUPERBOSS20 Giảm 30K đơn 40K.Nhập BOSSXANHLA2 giảm 25K.Giảm 35K mã BOSS35. ", type = "puma"});
            productsList.Add(new Product() { id = "46.2", img = "./Images/Mon Man/17.jpg", name = "Cua Rang Me", price = "2500000", detail_heading = "Đặc Sản Biển Hạ Long Quảng Ninh. ", detail = "Giao Hàng Nhanh  • 40 phút  •  6,3 km, Giờ mở cửa Today  00:00-23:59 • Menu Giảm 5% • Giảm 50K đơn 100K mã SIEUSALE50LT.SUPERBOSS20 Giảm 30K đơn 40K.Nhập BOSSXANHLA2 giảm 25K.Giảm 35K mã BOSS35. ", type = "puma"});
            productsList.Add(new Product() { id = "46.3", img = "./Images/Mon Man/18.jpg", name = "Tôm Hùm Hấp", price = "2500000", detail_heading = "Đặc Sản Biển Hạ Long Quảng Ninh ", detail = "Giao Hàng Nhanh  • 10 phút  •  2,3 km, Giờ mở cửa Today  00:00-23:59 • Menu Giảm 5% • Giảm 50K đơn 100K mã SIEUSALE50LT.SUPERBOSS20 Giảm 30K đơn 40K.Nhập BOSSXANHLA2 giảm 25K.Giảm 35K mã BOSS35. ", type = "puma"});
            productsList.Add(new Product() { id = "47.1", img = "./Images/Mon Man/19.jpg", name = "Cua Hoàng Đế", price = "2550000", detail_heading = "Đặc Sản Biển Hạ Long Quảng Ninh", detail = "Giao Hàng Nhanh  • 30 phút  •  5,3 km, Giờ mở cửa Today  00:00-23:59 • Menu Giảm 5% • Giảm 50K đơn 100K mã SIEUSALE50LT.SUPERBOSS20 Giảm 30K đơn 40K.Nhập BOSSXANHLA2 giảm 25K.Giảm 35K mã BOSS35. ", type = "puma" });
            productsList.Add(new Product() { id = "47.2", img = "./Images/Mon Man/20.jpg", name = "Sò Huyết", price = "2550000", detail_heading = "Đặc Sản Biển Hạ Long Quảng Ninh", detail = "Giao Hàng Nhanh • 40 phút  •  6,3 km, Giờ mở cửa Today  00:00-23:59 • Menu Giảm 5% • Giảm 50K đơn 100K mã SIEUSALE50LT.SUPERBOSS20 Giảm 30K đơn 40K.Nhập BOSSXANHLA2 giảm 25K.Giảm 35K mã BOSS35. ", type = "puma" });
        
        
            Application["productsList"] = productsList;
        }

        protected void Session_Start(object sender, EventArgs e)
        {
            Session["login"] = 0;
        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {
            
        }
    }
}