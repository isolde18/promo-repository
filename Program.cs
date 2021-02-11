using System;
using System.IO;
using System.Text;

namespace ConsoleUI
{
    class Program
    {
        static void WriteFile(string filename)
        {
            FileStream fs = new FileStream(filename, FileMode.Create, FileAccess.Write);
            if (fs.CanWrite)
            {
                byte[] buffer = Encoding.ASCII.GetBytes("Hello World");
                fs.Write(buffer, 0, buffer.Length);
            }

            fs.Flush();
            fs.Close();
        }
         static void ReadFile(string filename)
        {
            FileStream fs = new FileStream(filename, FileMode.Open, FileAccess.Read);
            if (fs.CanRead)
            {
                byte[] buffer = new byte[1024];
                int bytesread = fs.Read(buffer, 0, buffer.Length);

                Console.WriteLine(Encoding.ASCII.GetString(buffer, 0, bytesread));
            }
            fs.Close();
        }
        static void Main(string[] args)
        {
            string Filename = @"C:\Users\scott\Documents.txt";
            WriteFile(Filename);
            ReadFile(Filename);
        }
    }
}
