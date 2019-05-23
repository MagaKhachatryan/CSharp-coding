using System;
using System.IO;
using System.Threading.Tasks;
using System.Threading;

namespace CopyFileAsync
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\Admin\Desktop\CopyFile";
            string sourceFile = "ToeflExcercise.txt";
            string copyFile = "ToeflExcerciseCopy.txt";

            string sourcepath = Path.Combine(path, sourceFile);
            string copypath = Path.Combine(path, copyFile);

            CopyPercent(sourcepath, copypath);


        }
        static public   void CopyPercent(string sourecePath, string copyPath)
        {
            FileStream stream = File.OpenRead(sourecePath);
            FileStream writeStream = File.OpenWrite(copyPath);
            // create an array to hold the bytes
                byte[] ByteArray = new byte[1024 * 1024];

                double ReadedBytes = 0.0;
                long size = stream.Length;
                int bytesRead;

            // while the read method returns bytes
            // keep writing them to the output stream
            Console.WriteLine("FileLength is {0}", stream.Length);
            while ((bytesRead =
                        stream.Read(ByteArray, 0, 1)) > 0)
                {
                  Console.WriteLine("Readed bytes are {0}" ,ReadedBytes);
                     ++ReadedBytes;
                     Percent(ReadedBytes, stream.Length);
                    writeStream.Write(ByteArray, 0, bytesRead);
                }
            
        }
        static public async Task  Percent(double num1, double num2)
        {
                  await Task.Run(() =>
                 {
                     Task.Delay(0);
                    double result = ((num1 * 100) / num2);
                     Console.WriteLine(result.ToString());
                 });
        }
    }
}