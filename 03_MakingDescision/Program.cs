using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_MakingDescision
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region If Else Yapısı
            //Console.WriteLine("Lütfen Şifrenizi Giriniz:");
            //string password;
            //password = Console.ReadLine();
            //if (password=="abcd")
            //{
            //    Console.WriteLine("Şifre Doğru");
            //}
            //else
            //{
            //    Console.WriteLine("Şifre Yanlış");
            //}

            //string capital, country;
            //Console.WriteLine("Lütfen Bir Başkent Giriniz:");
            //capital = Console.ReadLine();

            //Console.WriteLine("Lütfen Bir Ülke Giriniz:");
            //country = Console.ReadLine();

            //if(capital=="ankara" & country=="türkiye")
            //{
            //    Console.WriteLine("Doğru Giriş Yaptınız");
            //}
            //else
            //{
            //    Console.WriteLine("Yanlış Giriş");
            //}

            //int exam1, exam2, exam3, average;
            //string result="Hata!";

            //Console.Write("Lütfen 1. Sınav Notunuzu Giriniz:");
            //exam1 = int.Parse(Console.ReadLine());
            //Console.Write("Lütfen 2. Sınav Notunuzu Giriniz:");
            //exam2 = int.Parse(Console.ReadLine());
            //Console.Write("Lütfen 3. Sınav Notunuzu Giriniz:");
            //exam3 = int.Parse(Console.ReadLine());

            //average = (exam1 + exam2 + exam3) / 3;
            //Console.WriteLine("Not Ortalamanız:" + average);

            //if (average >0 & average<=50)
            //{
            //    result = "Sonuç Vasat";
            //}
            //if (average > 50 & average <= 70)
            //{
            //    result = "Sonuç Orta";
            //}
            //if (average > 70 & average <= 85)
            //{
            //    result = "Sonuç İyi";
            //}
            //if (average > 85 & average <= 100)
            //{
            //    result = "Sonuç Çok İyi";
            //}

            //Console.WriteLine(result);

            //string city;
            //Console.Write("Lütfen Bir Şehir Giriniz:");
            //city = Console.ReadLine();

            //if (city == "adana" | city == "ankara" | city == "bursa" | city == "trabzon")
            //{
            //    Console.WriteLine("Şehir Mevcut");
            //}
            //else
            //{
            //    Console.WriteLine("Şehir Mevcut Değil");
            //}

            //Console.Write("Lütfen Kullanıcı Adını Giriniz: ");
            //string username= Console.ReadLine();

            //if(username!="admin")
            //{
            //    Console.Write("Kullanıcı Adı Yanlış");
            //}
            //else
            //{
            //    Console.WriteLine("Hoş Geldiniz");
            //}

            #endregion

            #region Mod İşlemleri

            //int number;
            //number = 26;
            //int result= number % 5;
            //Console.WriteLine(result);

            //Console.Write("Lütfen Birinci Sayıyı Giriniz:");
            //int number1 = int.Parse(Console.ReadLine());
            //Console.Write("Lütfen İkinci Sayıyı Giriniz:");
            //int number2 = int.Parse(Console.ReadLine());

            //int reesult = number1 % number2;

            //Console.WriteLine("Birinci Sayının İkinci Sayıya Bölümünden Kalan(Modu): " + reesult);

            //Console.Write("Lütfen Bir Sayı Giriniz:");
            //int number=int.Parse(Console.ReadLine());

            //if(number%2==0)
            //{
            //    Console.WriteLine("Girdiğiniz Sayı Çifttir");
            //}
            //else
            //{
            //    Console.WriteLine("Girdiğiniz Sayı Tektir");
            //}

            #endregion

            #region Char Değişkenler İle Karar Yapıları

            //char team;
            //Console.Write("Lütfen Takımınızın Sembolünü Giriniz: ");
            //team = char.Parse(Console.ReadLine());

            //if (team == 'G' | team == 'g')
            //{
            //    Console.WriteLine("Galatasaray");
            //}
            //if (team == 'F' | team == 'f')
            //{
            //    Console.WriteLine("Fenerbahçe");
            //}
            //if (team == 'B' | team == 'b')
            //{
            //    Console.WriteLine("Beşiktaş");
            //}

            #endregion

            #region Örnek Proje Uygulaması

            //Console.WriteLine("****** C# Eğitim Kampı Restoran ******");
            //Console.WriteLine();
            //Console.WriteLine("--------------------------------");
            //Console.WriteLine("1-Ana Yemekler");
            //Console.WriteLine("2-Çorbalar");
            //Console.WriteLine("3-Pizzalar");
            //Console.WriteLine("4-İçecekler");
            //Console.WriteLine("5-Tatlılar");
            //Console.WriteLine("--------------------------------");

            //string menuItem;

            //Console.Write("Detayları görmek istediğiniz menüyü seçiniz: ");
            //menuItem = Console.ReadLine();

            //if(menuItem=="1")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------------Ana Yemekler------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1- Köri Soslu Tavuk");
            //    Console.WriteLine("2- Kızartma Tabağı");
            //    Console.WriteLine("3- Fasulye Pilav");
            //    Console.WriteLine("4- Fırında Somon");
            //    Console.WriteLine("5- Patlıcan Musakka");
            //    Console.WriteLine("------------Ana Yemekler------------");
            //}
            //if (menuItem == "2")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------------Çorbalar------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1- Mercimek Çorbası");
            //    Console.WriteLine("2- Ezogelin Çorbası");
            //    Console.WriteLine("------------Çorbalar------------");
            //}
            //if (menuItem == "3")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------------Pizzalar------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1- Akdeniz Pizza");
            //    Console.WriteLine("2- Margarita Pizza");
            //    Console.WriteLine("3- Tavuklu Pizza");
            //    Console.WriteLine("------------Pizzalar------------");
            //}
            //if( menuItem == "4")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------------İçecekler------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1- Kola");
            //    Console.WriteLine("2- Ayran");
            //    Console.WriteLine("3- Su");
            //    Console.WriteLine("------------İçecekler------------");
            //}
            //if (menuItem == "5")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------------Tatlılar------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1- Triliçe");
            //    Console.WriteLine("2- Kazandibi");
            //    Console.WriteLine("3- Sütlaç");
            //    Console.WriteLine("------------Tatlılar------------");
            //}


            #endregion

            #region Switch Case Yapısı

            //Console.Write("Lütfen Ay Numarasını Giriniz: ");
            //int monthNumber=int.Parse(Console.ReadLine());

            //switch (monthNumber)
            //{
            //    case 1:
            //        Console.WriteLine("Ocak Ayındasınız");
            //        break;
            //    case 2:
            //        Console.WriteLine("Şubat Ayındasınız");
            //        break;
            //    case 3:
            //        Console.WriteLine("Mart Ayındasınız");
            //        break;
            //    case 4:
            //        Console.WriteLine("Nisan Ayındasınız");
            //        break;
            //    case 5:
            //        Console.WriteLine("Mayıs Ayındasınız");
            //        break;
            //    case 6:
            //        Console.WriteLine("Haziran Ayındasınız");
            //        break;
            //    case 7:
            //        Console.WriteLine("Temmuz Ayındasınız");
            //        break;
            //    case 8:
            //        Console.WriteLine("Ağustos Ayındasınız");
            //        break;
            //    case 9:
            //        Console.WriteLine("Eylül Ayındasınız");
            //        break;
            //    case 10:
            //        Console.WriteLine("Ekim Ayındasınız");
            //        break;
            //    case 11:
            //        Console.WriteLine("Kasım Ayındasınız");
            //        break;
            //    case 12:
            //        Console.WriteLine("Aralık Ayındasınız");
            //        break;
            //    default:
            //        Console.WriteLine("Hatalı Giriş Yaptınız!");
            //        break;
            //}

            #endregion

            #region Switch Case Hesap Makinesi

            //int number1, number2, result;
            //char symbol;

            //Console.Write("Lütfen Birinci Sayıyı Giriniz: ");
            //number1 = int.Parse(Console.ReadLine());
            //Console.Write("Lütfen İkinci Sayıyı Giriniz: ");
            //number2 = int.Parse(Console.ReadLine());
            //Console.Write("Lütfen Yapmak İstediğiniz İşlemi Giriniz (+, -, *, /): ");
            //symbol = char.Parse(Console.ReadLine());

            //switch(symbol)
            //{
            //    case '+':
            //        result = number1 + number2;
            //        Console.WriteLine("Toplama İşlemi Sonucu: " + result);
            //        break;
            //    case '-':
            //        result = number1 - number2;
            //        Console.WriteLine("Çıkarma İşlemi Sonucu: " + result);
            //        break;
            //    case '*':
            //        result = number1 * number2;
            //        Console.WriteLine("Çarpma İşlemi Sonucu: " + result);
            //        break;
            //    case '/':
            //        result = number1 / number2;
            //        Console.WriteLine("Bölme İşlemi Sonucu: " + result);
            //        break;
            //    default:
            //        Console.WriteLine("Hatalı Giriş Yaptınız!");
            //        break;
            //}
            #endregion

            Console.Read();

        }
    }
}
