using eShopOnContainers.Core.Models.Catalog;
using eShopOnContainers.Core.Models.User;
using eShopOnContainers.Core.Services.FirebaseManager;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;

namespace eShopOnContainers.Core.Services.DataHolder
{
    public static class DataHolder
    {

        public static ObservableCollection<Product> Products { get; set; }
        public static ObservableCollection<Product> FilteredList { get; set; }

        //public static ObservableCollection<Product> GetProductsByCategory(string category)
        //{
        //    ObservableCollection<Product> filteredList = new ObservableCollection<Product>();
        //    foreach (Product product in Products)
        //    {
        //        if (product.Category == category)
        //        {
        //            filteredList.Add(product);
        //        }
        //    }
        //    return filteredList;
        //}

        public static async void GetProductsByCategory(string category)
        {
            FilteredList = new ObservableCollection<Product>();
            var productsByCategory = await DatabaseManager.DatabaseManager.GetProductByCategory(category);
            foreach (Product product in productsByCategory)
            {
                FilteredList.Add(product);
            }
        }

        public static async void GetProductsByName(string name)
        {
            FilteredList = new ObservableCollection<Product>();
            var productsByName = await  DatabaseManager.DatabaseManager.GetProductByName(name);
            foreach (Product product in productsByName)
            {
                FilteredList.Add(product);
            }

        }


        private static async void CheckDatabase()
        {
            var databaseItems = await DatabaseManager.DatabaseManager.GetProduct();
            foreach (var databaseItem in databaseItems)
            {
                foreach (var product in Products)
                {
                    if (product.Name == databaseItem.Name)
                    {
                        return;
                    }
                    Products.Add(databaseItem);
                }
            }
        }

        static DataHolder()
        {
            Products = new ObservableCollection<Product>();
            //�r�n eklemeleri
            {
                Products.Add(new Product
                {
                    Name = "KZ ZSN Pro 1BA+1DD Hibrit Kulakl�k",
                    Model = "KZ ZSN Pro",
                    Category = "kulakl�k",
                    Image = "KZ_ZSN_Pro",
                    Views = 5,
                    NoDiscount = 229.9f,
                    Price = 189.9f,
                    Description = "KZ ZSN Pro 1BA+1DD Dengeli Armat�r ve" +
                      "Dinamik S�r�c� Hibrit, HD Mikrofonlu," +
                       " G�r�lt� Azalt�c� Kulak ��i Kulakl�k"
                });

                Products.Add(new Product
                {
                    Name = "KZ ZS10 Pro 4BA+1DD Hibrit Kulakl�k",
                    Model = "KZ ZS10 Pro",
                    Category = "kulakl�k",
                    Image = "KZ_ZS10_Pro",
                    Views = 5,
                    NoDiscount = 519.9f,
                    Price = 399.9f,
                    Description = "KZ ZS10 Pro 4BA+1DD 4 Dengeli Armat�r ve" +
                    " 1 Dinamik S�r�c� Hibrit, HD Mikrofonlu," +
                    " G�r�lt� Azalt�c� Kulak ��i Kulakl�k"
                });

                Products.Add(new Product
                {
                    Name = "KZ ZSX Terminator 5BA+1DD Hibrit Kulakl�k",
                    Model = "KZ ZSX",
                    Category = "kulakl�k",
                    Image = "KZ_ZSX",
                    Views = 5,
                    NoDiscount = 579.9f,
                    Price = 439.9f,
                    Description = "KZ ZSX Terminator 5BA+1DD 5 Dengeli Armat�r ve" +
                    " 1 Dinamik S�r�c� Hibrit, HD Mikrofonlu," +
                    " G�r�lt� Azalt�c� Kulak ��i Kulakl�k"
                });

                Products.Add(new Product
                {
                    Name = "KZ ZST Pro 1BA+1DD Hibrit Kulakl�k",
                    Model = "KZ ZST Pro",
                    Category = "kulakl�k",
                    Image = "KZ_ZST_Pro",
                    Views = 5,
                    NoDiscount = 229.9f,
                    Price = 189.9f,
                    Description = "KZ ZST Pro 1BA+1DD Dengeli Armat�r ve" +
                    " Dinamik S�r�c� Hibrit Y�ksek Bas �zellikli," +
                    " HD Mikrofonlu, G�r�lt� Azalt�c� Kulaki�i Kulakl�k"
                });

                Products.Add(new Product
                {
                    Name = "KZ ZSN Pro X 1BA+1DD G�m�� Kablolu Kulakl�k",
                    Model = "KZ ZSN Pro X",
                    Category = "kulakl�k",
                    Image = "KZ_ZSN_Pro_X",
                    Views = 5,
                    NoDiscount = 229.9f,
                    Price = 199.9f,
                    Description = "KZ ZSN Pro X 10mm Dinamik bas s�r�c� ve" +
                    " 30095 BA Denge Armat�r� Hibrit Y�ksek Bas," +
                    " G�m�� Kablolu Kulaki�i Kulakl�k"
                });

                Products.Add(new Product
                {
                    Name = "KZ ZS3 1DD Y�ksek Bass Kulakl�k",
                    Model = "KZ ZS3",
                    Category = "kulakl�k",
                    Image = "KZ_ZS3",
                    Views = 5,
                    NoDiscount = 149.9f,
                    Price = 109.9f,
                    Description = "KZ ZS3 1DD Dinamik S�r�c�, HiFi Y�ksek Bass," +
                    " HD Mikrofonlu, G�r�lt� Azalt�c� Kulak ��i Kulakl�k"
                });

                Products.Add(new Product
                {
                    Name = "QKZ VK4 Dinamik S�r�c� Kulak ��i Kulakl�k",
                    Model = "QKZ VK4",
                    Category = "kulakl�k",
                    Image = "QKZ_VK4",
                    Views = 5,
                    NoDiscount = 169.9f,
                    Price = 129.9f,
                    Description = "QKZ VK4 1DD G��l� Dinamik S�r�c�, HiFi Y�ksek Bass, Mikrofonlu Kulak ��i Kulakl�k"
                });

                Products.Add(new Product
                {
                    Name = "KZ ES4 1BA+1DD Kulak ��i Kulakl�k",
                    Model = "KZ_ES4",
                    Category = "kulakl�k",
                    Image = "KZ_ES4",
                    Views = 5,
                    NoDiscount = 219.9f,
                    Price = 179.9f,
                    Description = "KZ ES4 1BA+1DD Dengeli Armat�r ve Dinamik S�r�c� Hibrit, HD Mikrofonlu, G�r�lt� Azalt�c� Kulak ��i Kulakl�k"
                });

                Products.Add(new Product
                {
                    Name = "KZ ZST X 1BA+1DD G�m�� Kablolu Kulakl�k",
                    Model = "KZ ZST X",
                    Category = "kulakl�k",
                    Image = "KZ_ZST_X",
                    Views = 5,
                    NoDiscount = 229.9f,
                    Price = 209.9f,
                    Description = "KZ ZSTX 1BA+1DD Denge Armat�r ve XUN Dinamik S�r�c� Hibrit Y�ksek Bas, G�m�� Kablolu Kulaki�i Kulakl�k"
                });

                Products.Add(new Product
                {
                    Name = "KZ ATR 1DD Dinamik S�r�c� Bas Kulakl�k",
                    Model = "KZ ATR",
                    Category = "kulakl�k",
                    Image = "KZ_ATR",
                    Views = 5,
                    NoDiscount = 129.9f,
                    Price = 89.9f,
                    Description = "KZ ATR 1DD Dinamik S�r�c�, HiFi Y�ksek Bas, HD Mikrofonlu, G�r�lt� Azalt�c� Kulak ��i Kulakl�k"
                });

                Products.Add(new Product
                {
                    Name = "KZ EDX 1DD Mikrofonlu Kulak ��i Kulakl�k",
                    Model = "KZ EDX",
                    Category = "kulakl�k",
                    Image = "KZ_EDX",
                    Views = 5,
                    NoDiscount = 159.9f,
                    Price = 109.9f,
                    Description = "KZ EDX Kompozit 1DD Dinamik S�r�c�, HiFi Y�ksek Bass, Mikrofonlu, Kulak ��i Kulakl�k"
                });

                Products.Add(new Product
                {
                    Name = "KZ ED12 1DD Dinamik S�r�c� Bas Kulakl�k",
                    Model = "KZ ED12",
                    Category = "kulakl�k",
                    Image = "KZ_ED12",
                    Views = 5,
                    NoDiscount = 139.9f,
                    Price = 119.9f,
                    Description = "KZ ED12 1DD Dinamik S�r�c�, HiFi Y�ksek Bas, HD Mikrofonlu, G�r�lt� Azalt�c� Kulaki�i Kulakl�k"
                });

                Products.Add(new Product
                {
                    Name = "KZ ZAX 7BA+1DD Hibrit Kulak ��i Kulakl�k",
                    Model = "KZ ZAX",
                    Category = "kulakl�k",
                    Image = "KZ_ZAX",
                    Views = 5,
                    NoDiscount = 699.9f,
                    Price = 689.9f,
                    Description = "KZ ZAX 7 adet BA Denge Armat�r� ve 10mm �ift manyetik dinamik bas s�r�c�, G�m�� Kablolu Kulak ��i Kulakl�k"
                });

                Products.Add(new Product
                {
                    Name = "KZ DQ6 3DD 3 Dinamik S�r�c� Kulak ��i Kulakl�k",
                    Model = "KZ DQ6",
                    Category = "kulakl�k",
                    Image = "KZ_DQ6",
                    Views = 5,
                    NoDiscount = 259.9f,
                    Price = 239.9f,
                    Description = "KZ DQ6 3DD 3 Adet Dinamik S�r�c� G�m�� Kablolu Kulak ��i Kulakl�k"
                });

                Products.Add(new Product
                {
                    Name = "QKZ AK6 Y�ksek Bas Mikrofonlu Kulak ��i Kulakl�k",
                    Model = "QKZ AK6",
                    Category = "kulakl�k",
                    Image = "QKZ_AK6",
                    Views = 5,
                    NoDiscount = 99.9f,
                    Price = 79.9f,
                    Description = "QKZ AK6 1DD Dinamik S�r�c�, HiFi Y�ksek Bas, Mikrofonlu Kulak ��i Kulakl�k"
                });

                Products.Add(new Product
                {
                    Name = "KZ ASF 5BA Denge Armat�rl� Kulak ��i Kulakl�k",
                    Model = "KZ ASF",
                    Category = "kulakl�k",
                    Image = "KZ_ASF",
                    Views = 5,
                    NoDiscount = 499.9f,
                    Price = 469.9f,
                    Description = "KZ ASF 5BA 5 adet Denge Armat�r S�r�c� G�m�� Kablolu Kulak ��i Kulakl�k"
                });

                Products.Add(new Product
                {
                    Name = "KZ ZSN, ZSN Pro, ZS10 Pro, ZSX, AS16, AS12, ASF, ASX, DQ6 Yedek Kablo",
                    Model = "KZ C",
                    Category = "kablo",
                    Image = "KZ_C",
                    Views = 0,
                    NoDiscount = 74.9f,
                    Price = 65.9f,
                    Description = "KZ Pin C Kablo. KZ ZSN, ZSN Pro, ZSN Pro X, ZS10 Pro, ZSX Terminator," +
                    " AS16, AS12, ASF, ASX, DQ6 modelleri ile uyumlu orijinal yedek kulakl�k kablosu."
                });

                Products.Add(new Product
                {
                    Name = "KZ ZST ZST Pro AS10 BA10 ES3 ES4 ZS10 AS06 ZSR Yedek Kablo",
                    Model = "KZ B",
                    Category = "kablo",
                    Image = "KZ_B",
                    Views = 0,
                    NoDiscount = 74.9f,
                    Price = 54.9f,
                    Description = "KZ Pin B Kablo. ZST, ZST Pro, ZST X, AS10, BA10, ZS10(pro de�il)," +
                    " AS06, ES4, ED12, EDX, ZSR, ES3 modelleri ile uyumlu orijinal yedek kulakl�k kablosu."
                });

                Products.Add(new Product
                {
                    Name = "KZ Alt�n+G�m�� Kablo ZSN, ZSN Pro, ZS10 Pro, ZSX, ZAX, AS16, AS12, ASF, ASX, DQ6",
                    Model = "ALTIN GUMUS C",
                    Category = "kablo",
                    Image = "ALTIN_GUMUS_C",
                    Views = 0,
                    NoDiscount = 149.9f,
                    Price = 114.9f,
                    Description = "KZ ZSN, ZSN Pro, ZSN Pro X, ZS10 Pro, ZSX Terminator," +
                    " ZAX, AS16, AS12, ASF, ASX, DQ6 modelleri ile uyumlu Pin C alt�n+g�m��" +
                    " y�kseltme kablosu."
                });


                Products.Add(new Product
                {
                    Name = "KZ G�m�� Kablo ZSN, ZSN Pro, ZS10 Pro, ZSX, ZAX, AS16, AS12, ASF, ASX, DQ6",
                    Model = "GUMUS C",
                    Category = "kablo",
                    Image = "GUMUS_C",
                    Views = 5,
                    NoDiscount = 99.9f,
                    Price = 89.9f,
                    Description = "KZ ZSN, ZSN Pro, ZSN Pro X, ZS10 Pro, ZSX Terminator," +
            " ZAX, AS16, AS12, ASF, ASX, DQ6 modelleri ile uyumlu Pin C g�m�� y�kseltme kablosu"
                });
                Products.Add(new Product
                {
                    Name = "KZ ZS3 ZS4 ZS5 ZS6 ZS7 ZSA ED16 Yedek Kablo",
                    Model = "KZ A",
                    Category = "kablo",
                    Image = "KZ_A",
                    Views = 5,
                    NoDiscount = 74.9f,
                    Price = 64.9f,
                    Description = "KZ Pin A Kablo. ZS3, ZS4, ZS5, ZS6, ZS7, ZSA, " +
                "ED16 modelleri ile uyumlu orijinal yedek kulakl�k kablosu."
                });
                Products.Add(new Product
                {
                    Name = "KZ G�m�� Kablo ZST, ZST Pro, AS10, BA10, ES3, ES4, ZS10, AS06, ZSR",
                    Model = "GUMUS B",
                    Category = "kablo",
                    Image = "GUMUS_B",
                    Views = 5,
                    NoDiscount = 99.9f,
                    Price = 89.9f,
                    Description = "KZ ZST, ZST Pro, ZST X, AS10, BA10, ZS10(pro de�il), AS06, " +
                "ES4, ED12, EDX, ZSR, ES3 modelleri ile uyumlu Pin B g�m�� y�kseltme kablosu."
                });

                Products.Add(new Product
                {
                    Name = "KZ Alt�n+G�m�� Kablo ZST, ZST Pro, AS10, BA10, ES3, ES4, ZS10, AS06, ZSR",
                    Model = "ALTIN GUMUS B",
                    Category = "kablo",
                    Image = "ALTIN_GUMUS_B",
                    Views = 5,
                    NoDiscount = 149.9f,
                    Price = 114.9f,
                    Description = "KZ ZST, ZST Pro, ZST X, AS10, BA10, ZS10 (pro de�il), AS06, ES4, ED12, EDX, " +
                "ZSR, ES3 modelleri ile uyumlu Pin B alt�n+g�m�� y�kseltme kablosu."
                });
                Products.Add(new Product
                {
                    Name = "KZ G�m�� Kablo ZS3 ZS4 ZS5 ZS6 ZS7 ZSA ED16",
                    Model = "GUMUS A",
                    Category = "kablo",
                    Image = "GUMUS_A",
                    Views = 5,
                    NoDiscount = 109.9f,
                    Price = 89.9f,
                    Description = "KZ ZS3, KZ ZS4, KZ ZS5, KZ ZS6, KZ ZS7, KZ ZS3E, KZ ZSA, KZ" +
                " ED16 modelleri ile uyumlu Pin A g�m�� y�kseltme kablosu."
                });
            }
        }



    }
}