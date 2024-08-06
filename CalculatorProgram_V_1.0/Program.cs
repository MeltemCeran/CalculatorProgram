using System.Collections;
using System.Diagnostics.Metrics;
using System.Runtime.Serialization.Json;
using System.Security.Cryptography;
using static System.Net.Mime.MediaTypeNames;

namespace CalculatorProgram_V_1._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            InsideOfCalculator();

        }

        static void InsideOfCalculator()
        {
          
            calculatorFrame1();

            double s1 = 0;
            double s2 = 0;
            double sonuc;
            string text = string.Empty;

            while (true)
            {
                var keyInfo = Console.ReadKey(true); 

                if (keyInfo.Key == ConsoleKey.Enter) 
                {
                    break;
                }

                char inputChar = keyInfo.KeyChar;

                if (char.IsDigit(inputChar) || inputChar == '+' || inputChar == '-' || inputChar == '*' || inputChar == '/')
                {
                    if ((inputChar == '+' || inputChar == '-' || inputChar == '*' || inputChar == '/') &&
                        (text.Contains('+') || text.Contains('-') || text.Contains('*') || text.Contains('/')))
                    {
                        continue; 
                    }

                    text += inputChar;
                    Console.Write(inputChar);
                }

                if (keyInfo.Key == ConsoleKey.Backspace && text.Length > 0)
                {
                    text = text.Substring(0, text.Length - 1);
                    Console.Write("\b \b");
                }
            }

            if (text.Contains('+'))
            {//

                Plus(text);
            }
            else if (text.Contains('-'))
            {
               Minus(text);
            }
            else if (text.Contains('*'))
            {
                Cross(text);

            }
            else if (text.Contains('/'))
            {
                Division(text);
            }


            calculatorFrame2();
        }

        static void Division(string text)
        {
            double s1;
            double s2;
            int indexbolum = text.IndexOf('/');

            string ilkKisim = text.Substring(0, indexbolum);
            string ikinciKisim = text.Substring(indexbolum + 1);
            bool sayiMis1 = double.TryParse(ilkKisim, out s1);
            bool sayiMis2 = double.TryParse(ikinciKisim, out s2);

            if (s2 == 0)
            {
                Console.Write(" = DIV/0!");
            }
            else
            {
                Console.Write($" = {s1 / s2}");
            }
        }

        static void Cross(string text)
        {
            double s1;
            double s2;
            int indexcarpi = text.IndexOf('*');

            string ilkKisim = text.Substring(0, indexcarpi);
            string ikinciKisim = text.Substring(indexcarpi + 1);
            bool sayiMis1 = double.TryParse(ilkKisim, out s1);
            bool sayiMis2 = double.TryParse(ikinciKisim, out s2);

            if (sayiMis1 && sayiMis2)
            {
                Console.Write($" = {s1 * s2}");
            }
        }

        static void Minus(string text)
        {
            double s1;
            double s2;
            int indexeksi = text.IndexOf('-');

            string ilkKisim = text.Substring(0, indexeksi);
            string ikinciKisim = text.Substring(indexeksi + 1);
            bool sayiMis1 = double.TryParse(ilkKisim, out s1);
            bool sayiMis2 = double.TryParse(ikinciKisim, out s2);

            if (sayiMis1 && sayiMis2)
            {
                Console.Write($" = {s1 - s2}");
            }
            
        }

        static void Plus(string text)
        {
            double s1;
            double s2;
            int indexarti = text.IndexOf('+');
            string ilkKisim = text.Substring(0, indexarti);
            string ikinciKisim = text.Substring(indexarti + 1);
            bool sayiMis1 = double.TryParse(ilkKisim, out s1);
            bool sayiMis2 = double.TryParse(ikinciKisim, out s2);

            if (sayiMis1 && sayiMis2)
            {
                Console.Write($" = {s1 + s2}");
            }
           
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

            Console.WriteLine();
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
