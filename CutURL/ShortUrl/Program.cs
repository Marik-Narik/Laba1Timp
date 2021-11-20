using System;
using System.IO;

namespace ShortUrl
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var cutUrl = new CutUrl.Domain.CutUrl();
            var getCurrent = Path.GetDirectoryName(Directory.GetCurrentDirectory());
            var getUrlOnFile = cutUrl.GetURLOnFile(Path.GetDirectoryName(Path.GetDirectoryName(getCurrent)) + @"\URL.txt");
            var shortUrl = cutUrl.GetShortURL(getUrlOnFile);
            for (int i = 0; i < shortUrl.Length; i++)
                Console.WriteLine($"{getUrlOnFile[i]} => {shortUrl[i]}");
        }
    }
}
