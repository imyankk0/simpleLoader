using System;
using System.IO;
using System.Text;
using System.Threading;

namespace loader
{
    class Program
    {
        static void Main(string[] args)
        {
            String DnspySiken123 = "C:\\Users\\" + System.Environment.UserName + "\\Documents\\DnspySiken123.txt";
            String crkonum = "C:\\Users\\" + System.Environment.UserName + "\\AppData\\Roaming\\.craftrise\\versions\\RiseClient_1.8.9\\RiseClient_1.8.9.jar";
            String dnspynelaorospucocugu = "C:\\Users\\" + System.Environment.UserName + "\\AppData\\Roaming\\dnSpy\\dnSpy.xml";
            if (File.Exists(DnspySiken123)) // Banı yedi mal XDE
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("DnspySiken123");
                Thread.Sleep(2000);
                Environment.Exit(0);
            }
            if (File.Exists(dnspynelaorospucocugu)) // Ban hazırlanıyor
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Dnspy Detected");
                using (FileStream fs = File.Create(DnspySiken123))
                {
                    byte[] author = new UTF8Encoding(true).GetBytes("DnspySiken123");
                    fs.Write(author, 0, author.Length);
                }
                Environment.Exit(0);
            }
            Console.Title = "imyankk0"; // Yazılımınızın ismini buraya yazın
            String vanusyazi = @"
imyankk0 client

credits:
loader by Morsy
";                                                // buradaki gibi ASCII yazı oluşturmak isterseniz "https://patorjk.com/software/taag/" sitesine göz atın
            Console.ForegroundColor = ConsoleColor.Red; // ASCII yazı rengi
            Console.WriteLine(vanusyazi); // ASCII yazı çalıştırılıyor
            Console.ForegroundColor = ConsoleColor.White; // sisteme giriş yapıldıktan sonraki yazıların rengi
            if (File.Exists(crkonum)) // RiseClient.jar (CRAFTRISE) bulunduysa programa giriş yapılıyor bulunmadıysa kapatıyor
            {
                Console.WriteLine("Welcome to imyankk0");
            }
            else
            {
                Console.WriteLine("CraftRise bulunamadı!");
            }
            Console.ReadLine();
        }
    }
}
