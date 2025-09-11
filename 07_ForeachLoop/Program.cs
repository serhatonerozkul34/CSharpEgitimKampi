using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ForeachLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Foreach Döngüsü

            //Foreach(1;2;3;4)

            //1: Değişken türü
            //2: Değişken adı
            //3: In
            //4: Dizi, Liste, Koleksiyon

            //string[] cities = { "milanı", "roma", "budapeşte", "ankara", "istanbul", "varşova" };

            //foreach (string city in cities)
            //{
            //    Console.WriteLine(city);
            //}

            //int[] numbers = { 45, 78, 985, 635, 74, 11, 22, 33, 41, 205, 6578, 10394 };

            //foreach (int number in numbers)
            //{
            //    Console.WriteLine(number);
            //}

            //int[] numbers = { 45, 78, 985, 635, 74, 11, 22, 33, 41, 205, 6578, 10394 };

            //foreach(int number in numbers)
            //{
            //    if (number % 2 == 0)
            //    {
            //        Console.WriteLine(number);
            //    }
            //}

            //int[] numbers = { 45, 78, 985, 635, 74, 11, 22, 33, 41, 205, 6578, 10394 };

            //int total = 0;

            //foreach (int number in numbers)
            //{
            //    total += number;
            //}
            //Console.WriteLine("Toplam: " + total);

            //List<int> numbers = new List<int>()
            //{
            //    1,2,3,4,5,8
            //};

            //foreach (int number in numbers)
            //{
            //    Console.WriteLine(number);
            //}


            //string word = "Merhaba";

            //foreach (char letter in word)
            //{
            //    Console.WriteLine(letter);
            //}

            #endregion

            #region Örnek Sınav Sistemi Uygulaması

            Console.Write("***** C# Eğitim Kampı Sınav Uygulaması *****");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            //Sınıftaki öğrenci sayısını kullanıcıdan 
            Console.WriteLine("----------------------------------------");
            Console.Write("Sınıfınızda Kaç Öğrenci Var: ");
            int studentCount = int.Parse(Console.ReadLine());
            Console.WriteLine("----------------------------------------");


            //Öğrenci isimlerini ve sınav ortalamalarını tutmak için diziler
            string[] studentNames = new string[studentCount];
            double[] studentExamAvg = new double[studentCount];

            for (int i = 0; i < studentCount; i++)
            {
                Console.Write($"Lütfen {i+1}. Öğrencinin Adını Giriniz: ");
                studentNames[i] = Console.ReadLine();

                double totalExamResult = 0;

                //Her öğrenci için 3 sınav sonucu al

                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"Lütfen {studentNames[i]} Adlı Öğrencinin {j + 1}. Sınav Sonucunu Giriniz: ");
                    double value = double.Parse(Console.ReadLine());
                    totalExamResult += value; //notları topluyoruz.
                }
                Console.WriteLine();

                studentExamAvg[i]= totalExamResult / 3; //ortalama hesaplama
            }

            //Öğrencilerin ortalamalarını ve durumlarını göster

            for (int i = 0; i < studentCount; i++) 
            {
                Console.WriteLine($"{studentNames[i]} Adlı Öğrencinin Ortalaması: {studentExamAvg[i]}");
                Console.WriteLine();
                if (studentExamAvg[i] >= 50)
                {
                    Console.WriteLine($"{studentNames[i]} Adlı Öğrenci Dersi Geçti!");
                }
                else
                {
                    Console.WriteLine($"{studentNames[i]} Adlı Öğrenci Dersten Kaldı!");
                }

                Console.WriteLine("----------------------------------------");
            }

            #endregion

            Console.Read();

        }
    }
}
