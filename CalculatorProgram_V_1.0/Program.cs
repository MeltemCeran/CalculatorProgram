using System.Collections;
using System.Diagnostics.Metrics;
using System.Runtime.Serialization.Json;
using System.Security.Cryptography;

namespace CalculatorProgram_V_1._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            InsideOfCalculator();

            //Kopya();
        }

        private static void Kopya()
        {
            calculatorFrame1();

            double s1;
            double s2;
            double sonuc;



            string text = Console.ReadLine();

            int indexesittir = text.IndexOf('=');

            if (text.EndsWith('='))
            {
                //buraya metod çağırabi
            }

            if (!(text.Contains('+') || text.Contains('-') || text.Contains('*') || text.Contains('/')))
            {
                Console.WriteLine("Geçersiz giriş yaptınız.");
            }
            if (!text.Contains('='))
            {
                Console.WriteLine("Geçersiz giriş yaptınız.");
            }

            if (text.Contains('+'))
            {
                int indexarti = text.IndexOf('+');
                string ilkKisim = text.Substring(0, indexarti);
                string ikinciKisim = text.Substring(indexarti + 1, indexesittir - indexarti - 1);
                bool sayiMis1 = double.TryParse(ilkKisim, out s1);
                bool sayiMis2 = double.TryParse(ikinciKisim, out s2);

                if (sayiMis1 && sayiMis2)
                {
                    Console.WriteLine(sonuc = s1 + s2);
                }
                else
                {
                    Console.WriteLine("Lütfen sayısal değer giriniz:");
                }

            }
            else if (text.Contains('-'))
            {
                int indexeksi = text.IndexOf('-');

                string ilkKisim = text.Substring(0, indexeksi);
                string ikinciKisim = text.Substring(indexeksi + 1, indexesittir - indexeksi - 1);
                bool sayiMis1 = double.TryParse(ilkKisim, out s1);
                bool sayiMis2 = double.TryParse(ikinciKisim, out s2);

                if (sayiMis1 && sayiMis2)
                {
                    Console.WriteLine(sonuc = s1 - s2);
                }
                else
                {
                    Console.WriteLine("Lütfen sayısal değer giriniz:");
                }

            }
            else if (text.Contains('*'))
            {
                int indexcarpi = text.IndexOf('*');

                string ilkKisim = text.Substring(0, indexcarpi);
                string ikinciKisim = text.Substring(indexcarpi + 1, indexesittir - indexcarpi - 1);
                bool sayiMis1 = double.TryParse(ilkKisim, out s1);
                bool sayiMis2 = double.TryParse(ikinciKisim, out s2);

                if (sayiMis1 && sayiMis2)
                {
                    Console.WriteLine(sonuc = s1 * s2);
                }
                else
                {
                    Console.WriteLine("Lütfen sayısal değer giriniz:");
                }


            }
            else if (text.Contains('/'))
            {

                int indexbolum = text.IndexOf('/');

                string ilkKisim = text.Substring(0, indexbolum);
                string ikinciKisim = text.Substring(indexbolum + 1, indexesittir - indexbolum - 1);
                bool sayiMis1 = double.TryParse(ilkKisim, out s1);
                bool sayiMis2 = double.TryParse(ikinciKisim, out s2);

                if (!(sayiMis1 && sayiMis2))
                {
                    Console.WriteLine("Lütfen sayısal değer giriniz:");
                }
                else if (s2 == 0)
                {
                    Console.WriteLine("DIV/0!");
                }
                else
                {
                    Console.WriteLine(sonuc = s1 * s2);
                }

            }


            calculatorFrame2();
        }

        static void InsideOfCalculator()
        {

            calculatorFrame1();

            double s1;
            double s2;
            double sonuc;
            
            //Bunları nasıl metoda alırım?
            //Eşittir işini yapamadım.
            // iflerin içine break koymalı mıyım?
            //bu arada yeni bişey öğrendim. Array.Sort(text) örn.
            //metotlarda default parameter value diye bişey var.


            string text = Console.ReadLine();

            int indexesittir = text.IndexOf('=');

            if(text.EndsWith('='))
            {
                //buraya metod çağırabi
            }

            if (!(text.Contains('+') || text.Contains('-') ||text.Contains('*') ||text.Contains('/')))
            {
                Console.WriteLine("Geçersiz giriş yaptınız.");
            }
            if (!text.Contains('='))
            {
                Console.WriteLine("Geçersiz giriş yaptınız.");
            }

            if (text.Contains('+'))
            {
                int indexarti = text.IndexOf('+');
                string ilkKisim = text.Substring(0, indexarti);
                string ikinciKisim = text.Substring(indexarti + 1, indexesittir - indexarti - 1);
                bool sayiMis1 = double.TryParse(ilkKisim, out s1);
                bool sayiMis2 = double.TryParse(ikinciKisim, out s2);
               
                if (sayiMis1 && sayiMis2)
                {
                    Console.WriteLine(sonuc = s1 + s2);
                }
                else
                {
                    Console.WriteLine("Lütfen sayısal değer giriniz:");
                }

            }
            else if (text.Contains('-')) 
            {
                int indexeksi = text.IndexOf('-');

                string ilkKisim = text.Substring(0, indexeksi);
                string ikinciKisim = text.Substring(indexeksi + 1, indexesittir - indexeksi - 1);
                bool sayiMis1 = double.TryParse(ilkKisim, out s1);
                bool sayiMis2 = double.TryParse(ikinciKisim, out s2);

                if (sayiMis1 && sayiMis2)
                {
                    Console.WriteLine(sonuc = s1 - s2);
                }
                else
                {
                    Console.WriteLine("Lütfen sayısal değer giriniz:");
                }

            }
            else if (text.Contains('*'))
            {
                int indexcarpi = text.IndexOf('*');

                string ilkKisim = text.Substring(0, indexcarpi);
                string ikinciKisim = text.Substring(indexcarpi + 1, indexesittir - indexcarpi - 1);
                bool sayiMis1 = double.TryParse(ilkKisim, out s1);
                bool sayiMis2 = double.TryParse(ikinciKisim, out s2);

                if (sayiMis1 && sayiMis2)
                {
                    Console.WriteLine(sonuc = s1 * s2);
                }
                else
                {
                    Console.WriteLine("Lütfen sayısal değer giriniz:");
                }

                
            }
            else if (text.Contains('/'))
            {
                
                int indexbolum = text.IndexOf('/');

                string ilkKisim = text.Substring(0, indexbolum);
                string ikinciKisim = text.Substring(indexbolum + 1, indexesittir - indexbolum - 1);
                bool sayiMis1 = double.TryParse(ilkKisim, out s1);
                bool sayiMis2 = double.TryParse(ikinciKisim, out s2);

                if (!(sayiMis1 && sayiMis2))
                {
                    Console.WriteLine("Lütfen sayısal değer giriniz:");
                }
                else if (s2 == 0)
                {
                    Console.WriteLine("DIV/0!");
                }
                else
                {
                    Console.WriteLine(sonuc = s1 * s2);
                }
               
            }


            calculatorFrame2();
        }

        static double Division(ref double s1, ref double s2, ref char islem)
        {
            if (s2 == 0)
            {
                Console.WriteLine("Lütfen payda için 0'dan farklı bir değer giriniz:");
                s2 = Convert.ToDouble(Console.ReadLine());
            }

            return (s1 / s2);
        }

        static double Cross(ref double s1, ref double s2, ref char islem)
        {
            return s1 * s2;
        }

        static double Minus(ref double s1, ref double s2, ref char islem)
        {
            return s1 - s2;
        }

        static double Plus(ref double s1, ref double s2, ref char islem)
        {
            return s1 + s2;
        }

        static void calculatorFrame1()
        {
            int edgeB = 55;  // Dikdörtgenin genişliği
            int edgeA = 4;

            Console.WriteLine("          ----Calculator Program V-1.0----     ");
            Console.WriteLine(new string('-', edgeB));

            for (int i = 0; i < edgeA - 2; i++)
            {
                Console.Write('|');              // Sol kenar
                Console.Write(new string(' ', edgeB - 2));  // İç kısım (boşluk)
                Console.WriteLine('|');           // Sağ kenar
            }

        }
        static void calculatorFrame2()
        {
            int edgeB = 55;  // Dikdörtgenin genişliği
            int edgeA = 4;

            for (int i = 0; i < edgeA - 2; i++)
            {
                Console.Write('|');              // Sol kenar
                Console.Write(new string(' ', edgeB - 2));  // İç kısım (boşluk)
                Console.WriteLine('|');           // Sağ kenar
            }

            Console.WriteLine(new string('-', edgeB));
            Console.WriteLine("                ----Calculator----");


        }
    }
    
}
