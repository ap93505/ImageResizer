using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageResizer
{
    class Program
    {
        static async Task Main(string[] args)
        {
            string sourcePath = @"C:\Users\kevinchen\Desktop\ImageResizer\ImageResizer\images"; // Path.Combine(Environment.CurrentDirectory, "images");
            string destinationPath = @"C:\Users\kevinchen\Desktop\ImageResizer\ImageResizer\output"; // Path.Combine(Environment.CurrentDirectory, "output"); ;

            ImageProcess imageProcess = new ImageProcess();

            imageProcess.Clean(destinationPath);

            Stopwatch sw = new Stopwatch();
            sw.Start();
            await imageProcess.ResizeImagesAsync(sourcePath, destinationPath, 2.0);
            sw.Stop();

            Console.WriteLine($"花費時間: {sw.ElapsedMilliseconds} ms");
            Console.ReadKey();
        }
    }
}
