// Bu program, kullanıcıdan iki sayı alarak toplama, çıkarma, çarpma ve bölme işlemi yapar.
// Menü sistemi ile kullanıcı işlem seçimi yapar ve sonuç ekrana yazdırılır.
// Yazan: Ceyda Gökkaya
// Tarih: 02.08.2025


using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace HesapMakinesi1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Basit Hesap Makinesi");

            while (true)
            {
                try
                {
                    Console.WriteLine("Yapmak istediğiniz işlemi seçin: ");
                    Console.WriteLine("1 - Toplama");
                    Console.WriteLine("2 - Çıkarma");
                    Console.WriteLine("3 - Çarpma");
                    Console.WriteLine("4 - Bölme");
                    Console.WriteLine("5 - Çıkış");

                    Console.Write("Seçiminiz (1-5):");
                    string seçim = Console.ReadLine();

                    if (seçim == "5")
                    {
                        Console.WriteLine("Program sonlandırıldı. ");
                        break;
                    }

                    Console.Write("Birinci sayıyı girin:");
                    double sayı1 = Convert.ToDouble(Console.ReadLine());


                    Console.Write("İkinci sayıyı girin: ");
                    double sayı2 = Convert.ToDouble(Console.ReadLine());

                    double sonuç;

                    switch (seçim)
                    {
                        case "1":
                            sonuç = sayı1 + sayı2;
                            Console.WriteLine($"Sonuç: {sayı1} + {sayı2} = {sonuç}");
                            break;

                        case "2":
                            sonuç = sayı1 - sayı2;
                            Console.WriteLine($"Sonuç: {sayı1} - {sayı2} = {sonuç}");
                            break;

                        case "3":
                            sonuç = sayı1 * sayı2;
                            Console.WriteLine($"Sonuç: {sayı1} * {sayı2} = {sonuç}");
                            break;

                        case "4":
                            if (sayı2 == 0)
                            {
                                Console.WriteLine("Hata: Bir sayı sıfıra bölünemez!");
                                continue;
                            }
                            sonuç = sayı1 / sayı2;
                            Console.WriteLine($"Sonuç: {sayı1} / {sayı2} = {sonuç}");
                            break;

                        default:
                            Console.WriteLine("Geçersiz seçim. Lütfen 1-5 arasında bir değer girin.");
                            continue;

                    }


                    Console.Write("Başka işlem yapmak ister misiniz? (E/H):");
                    string devam = Console.ReadLine().ToUpper();

                    if (devam != "E")
                    {
                        Console.WriteLine("Program sonlandı.");
                        break;
                    }
                      
                }

                catch (FormatException)
                {
                    Console.WriteLine(" Hata: Lütfen geçerli bir sayı girin.");
                }

                catch (Exception ex)
                {
                    Console.WriteLine($"Beklenmeyen bir hata oluştu: {ex.Message}");
                }

            }

           

        }
    }
}
