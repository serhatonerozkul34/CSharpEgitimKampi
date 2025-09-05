using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_MainSubjects
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Yazdırma Komutları

            //Console.WriteLine("Hello World!");
            //Console.Write("Hi");

            //Console.WriteLine("***** Yemek Kategorileri *****");
            //Console.WriteLine();
            //Console.WriteLine("1-Çorbalar");
            //Console.WriteLine("2-Ana Yemekler");
            //Console.WriteLine("3-Soğuk Başlangıçlar");
            //Console.WriteLine("4-Salatalar");
            //Console.WriteLine("5-Tatlılar");
            //Console.WriteLine("6-İçecekler");
            //Console.WriteLine();
            //Console.WriteLine("***** Yemek Kategorileri *****");

            #endregion

            #region String Degiskenler

            //String veri tipi
            //Degişken_türü değişken_adı;

            //string name;
            //name = "Serhat";

            //Console.Write(name);

            //string customerName;
            //string customerSurname;
            //string customerPhone;
            //string customerEmail, district, city;

            //customerName = "Serhat Öner";
            //customerSurname = "Özkul";
            //customerPhone = "05554443322";
            //customerEmail = "deneme@gmail.com";
            //district = "Bahçelievler";
            //city = "İstanbul";

            //Console.WriteLine("**** Rezervasyon Kartı ****");
            //Console.WriteLine();
            //Console.WriteLine("----------------------------------------");
            //Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);
            //Console.WriteLine("Telefon: " + customerPhone);
            //Console.WriteLine("E-Posta: " + customerEmail);
            //Console.WriteLine("Adres: " + district + "/" + city);
            //Console.WriteLine("----------------------------------------");

            //Console.WriteLine();

            //customerName = "Sergen";
            //customerSurname = "Götelek";
            //customerPhone = "05551112233";
            //customerEmail = "test@gmail.com";
            //district = "Vakfıkebir";
            //city = "Trabzon";

            //Console.WriteLine();
            //Console.WriteLine("----------------------------------------");
            //Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);
            //Console.WriteLine("Telefon: " + customerPhone);
            //Console.WriteLine("E-Posta: " + customerEmail);
            //Console.WriteLine("Adres: " + district + "/" + city);
            //Console.WriteLine("----------------------------------------");


            #endregion

            #region Integer Degiskenler

            //int veri tipi
            //Degişken_türü değişken_adı;

            //int number1=24;
            //Console.WriteLine(number1);

            int hamburgerPrice = 300;
            int cokePrice = 35;
            int waterPrice = 10;
            int friesPrice = 50;
            int PizzaPrice = 250;
            int lemonadePrice = 30;


            Console.WriteLine("***** Restoran Menü Fiyatı *****");
            Console.WriteLine();
            Console.WriteLine("----Hamburger: " + hamburgerPrice + " TL");
            Console.WriteLine("----Pizza: " + PizzaPrice + " TL");
            Console.WriteLine("----Kola: " + cokePrice + " TL");
            Console.WriteLine("----Limonata: " + lemonadePrice + " TL");
            Console.WriteLine("----Patates: " + friesPrice + " TL");
            Console.WriteLine("----Su :" + waterPrice + " TL");
            Console.WriteLine();
            Console.WriteLine("***** Restoran Menü Fiyatı *****");
            Console.WriteLine();

            int hamburgerCount;
            int cokeCount;
            int waterCount;
            int friesCount;
            int pizzaCount;
            int lemonadeCount;

            int totalHamburgerPrice = 0;
            int totalCokePrice = 0;
            int totalWaterPrice = 0;
            int totalFriesPrice = 0;
            int totalPizzaPrice = 0;
            int totalLemonadePrice = 0;

            hamburgerCount = 3;
            cokeCount = 3;
            waterCount = 3;
            friesCount = 1;
            pizzaCount = 0;
            lemonadeCount = 0;

            totalHamburgerPrice = hamburgerCount * hamburgerPrice;
            totalCokePrice = cokeCount * cokePrice;
            totalWaterPrice = waterCount * waterPrice;
            totalFriesPrice = friesCount * friesPrice;
            totalPizzaPrice = pizzaCount * PizzaPrice;
            totalLemonadePrice = lemonadeCount * lemonadePrice;

            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Toplam Hamburger Fiyatı: " + totalHamburgerPrice + " TL");
            Console.WriteLine("Toplam Kola Fiyatı: " + totalCokePrice + " TL");
            Console.WriteLine("Toplam Su Fiyatı: " + totalWaterPrice + " TL");
            Console.WriteLine("Toplam Patates Fiyatı: " + totalFriesPrice + " TL");
            Console.WriteLine("Toplam Pizza Fiyatı: " + totalPizzaPrice + " TL");
            Console.WriteLine("Toplam Limonata Fiyatı: " + totalLemonadePrice + " TL");
            Console.WriteLine("----------------------------------------");

            int totalPrice = totalHamburgerPrice + totalCokePrice + totalWaterPrice + totalFriesPrice + totalPizzaPrice + totalLemonadePrice;
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Genel Toplam: " + totalPrice + " TL");
            Console.WriteLine("----------------------------------------");





            #endregion

            Console.Read();
        }
    }
}