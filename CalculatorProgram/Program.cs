using System.Collections.Generic;
using System.Security.Cryptography;

namespace CalculatorProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            InsideOfCalculator();
        }

        static void InsideOfCalculator()
        {
            //Kullanıcıdan iki sayı alıyoruz sonra (+,-,*,/) giriyor ve işlem yapıyoruz. tüm işlemler için ayrı ayrı metot aç return.
            //Buna sadece girilen değerin metin olup olmamasını eklicem. gerisi tamam sanırım kontrol ederim yine.
           
            double s1;
            double s2;
            bool correctChar = true;


            calculatorFrame1();

            Console.WriteLine("| Lütfen işlem yapmak için sırayla iki sayı giriniz:  |");

            Console.Write("|");
            s1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("|");
            s2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("| Lütfen yapılacak işlemi giriniz (+, -, * ,/)        |");
            char islem = Console.ReadKey(true).KeyChar;


            while (correctChar)
            {

                if (!(islem == '+' || islem == '-' || islem == '*' || islem == '/'))
                {
                    Console.WriteLine("| Lütfen geçerli bir işlem değeri giriniz (+, -, * ,/)  |");
                    islem = Console.ReadKey(true).KeyChar;
                }
                else if (islem == '+')
                {
                    Console.WriteLine($"| Sonuc = {Plus(ref s1, ref s2, ref islem)}                                          |");
                    correctChar = false;
                }
                else if (islem == '-')
                {
                    Console.WriteLine($"| Sonuc = {Minus(ref s1, ref s2, ref islem)}                                          |");
                    correctChar = false;
                }
                else if (islem == '*')
                {
                    Console.WriteLine($"| Sonuc = {Cross(ref s1, ref s2, ref islem)}                                          |");
                    correctChar = false;
                }
                else if (islem == '/')
                {
                    Console.WriteLine($"| Sonuc = {Division(ref s1, ref s2, ref islem)}                                          |");
                    correctChar = false;
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
            
            return (s1/ s2);  
        }

        static double Cross(ref double s1, ref double s2, ref char islem)
        {
            return s1 * s2;
        }

        static double Minus(ref double s1, ref double s2, ref char islem)
        {
            return s1-s2; 
        }

        static double Plus(ref double s1, ref double s2, ref char islem) 
        {
            return s1 + s2;
        }

        static void calculatorFrame1()
        {
            int edgeB = 55;  // Dikdörtgenin genişliği
            int edgeA = 4;

            Console.WriteLine("                ----Calculator----");
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
