using System;
using System.IO;
using System.Net;
using System.Text;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Die URL der Datei
            string url = "https://raw.githubusercontent.com/Domenik1408/50k-random-names/main/names.txt";

            // Hole den Text der URL
            string text = GetTextFromUrl(url);

            // Teile den Text in einzelne Zeilen auf
            string[] lines = text.Split(new[] { "\r\n", "\n" }, StringSplitOptions.None);

            // Wähle eine zufällige Zeile aus
            Random random = new Random();
            int randomIndex = random.Next(lines.Length);
            string randomLine = lines[randomIndex];

            // Gib die zufällige Zeile aus
            Console.WriteLine(randomLine);
        }

        static string GetTextFromUrl(string url)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.AutomaticDecompression = DecompressionMethods.GZip;

            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            using (Stream stream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(stream, Encoding.UTF8))
            {
                return reader.ReadToEnd();
            }
        }
    }
}
