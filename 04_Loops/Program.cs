using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region For Döngüsü

            // Döngüler 1+2+3+4+5+6
            //3+3=6+4=10+5=15+6=21

            //For(x;y;z)
            //x başlangıç değeri
            //y koşul
            //z artış-azalış miktarı

            //int i;

            //for(i=1; i <= 5; i++)
            //{
            //    Console.WriteLine("C# Eğitim Kampı");
            //}

            //for (int i = 1; i <= 20; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //for (int i = 3; i <= 50; i+=3)
            //{
            //    Console.WriteLine(i);
            //}

            //Console.Write("Lütfen ekrana yazdırmak istediğiniz adetini giriniz: ");
            //int finishValue = int.Parse(Console.ReadLine());

            //for(int i=1; i <= finishValue; i++)
            //{
            //    Console.WriteLine("Yaşasın Cumhuriyet");
            //}

            #endregion

            #region For Döngüsü İle Karar Yapıları

            //for (int i = 1; i <= 100; i++)
            //{
            //    if (i % 5 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //int totalValue = 0;

            //for(int i = 1; i <= 10; i++)
            //{
            //    totalValue += i;
            //}

            //Console.WriteLine(totalValue);

            //int totalValue = 0;

            //for (int i = 1; i < 20; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        totalValue += i;
            //        Console.WriteLine(i);

            //    }
            //}
            //Console.WriteLine("-----------");
            //Console.WriteLine(totalValue);

            //int count= 0;

            //for (int i = 1; i <= 60; i++)
            //{
            //    if (i % 7 == 0)
            //    {
            //        count++;
            //    }
            //}

            //Console.WriteLine(count);

            //int bacterium = 1;

            //for(int i = 1; i <= 24; i++)
            //{
            //    bacterium *= 2;
            //    Console.WriteLine(i + ". Saat: " + bacterium);
            //}

            #endregion

            #region While Döngüsü

            //While(koşul)
            //{
            //işlemler
            //}

            //int i= 1;

            //while(i <= 10)
            //{
            //    Console.WriteLine("Merhaba Döngüler");
            //    i++;
            //}

            //int i = 1;

            //while (i <= 10)
            //{
            //    if (i % 3 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //    i++;
            //}

            //int i = 1;
            //int sum= 0;

            //while (i <= 10)
            //{
            //    sum += i;
            //    i++;
            //}

            //Console.WriteLine(sum);

            #endregion

            #region Örnek Sınav Sorusu

            //Klavyeden girilen 3 basamaklı sayının basamaklarının toplamını bulunuz.

            //456

            //Console.Write("Lütfen 3 basamaklı bir sayı giriniz: ");
            //int number=int.Parse(Console.ReadLine());
            //int digit1, digit2, digit3;
            //int sum;

            //digit1 = number % 10;
            //digit2 = (number % 100) / 10;
            //digit3 = number / 100;

            //Console.WriteLine(digit1 +"-" + digit2 + "-" + digit3);

            //sum = digit1 + digit2 + digit3;

            //Console.WriteLine("Basamakların Toplamı: " + sum);

            //digit1 = number % 10; //6
            //number = number / 10; //45
            //digit2 = number % 10; //5
            //number = number / 10; //4
            //digit3 = number % 10; //4
            //sum = digit1 + digit2 + digit3;
            //Console.WriteLine("Basamakların Toplamı: " + sum);

            #endregion

            Console.Read();
        }
    }
}
