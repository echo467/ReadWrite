using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Program
    {
        /*static void WriteFile(FileMode fileMode, FileAccess fileAccess, FileShare fileShare)
        {
            //Console.WriteLine("please input your content.");
            int avg = 18;
            var content = (avg).ToString();
            FileStream fs = new FileStream(@"C:\Users\27870\Desktop\WriteLines2.txt", fileMode, fileAccess, fileShare);
            var buffer1 = Encoding.Default.GetBytes(content+"\r\n"+ "world");
            //var buffer2 = Encoding.Default.GetBytes("world");
            fs.Write(buffer1, 0, buffer1.Length);
           // fs.Write(buffer2, 3, buffer2.Length);
            fs.Flush();
        }*/

        static void ReadFile(FileAccess fileAccess, FileShare fileShare)
        {// 
            int counter = 0;
            // 
           
            // 
            String[] row = new string[2];
            StreamReader streamReader = null;
            FileStream fs = new FileStream(@"C:\Users\27870\Desktop\WriteLines2.txt", FileMode.Open, fileAccess, fileShare);
            /*var buffer = new byte[fs.Length];
            fs.Position = 0;
            fs.Read(buffer, 0, buffer.Length);
            fs.Close();
            Console.WriteLine(Encoding.Default.GetString(buffer));
           */
            streamReader = new StreamReader(fs, Encoding.Default);
            fs.Seek(0, SeekOrigin.Begin);
            //string content = streamReader.ReadLine();
            while (counter <2)
            {
                row[counter] = streamReader.ReadLine();
                //System.Console.WriteLine(content);
                counter++;
                //content = streamReader.ReadLine();
            }
            int sum = Int32.Parse(row[0]);
            int avg = Int32.Parse(row[1]);
            System.Console.WriteLine(sum);
            System.Console.WriteLine(avg);
        }

        static void Main(string[] args)
        {
            /* int avg = 20;
             var content = (avg).ToString();
             FileStream fs = new FileStream(@"C:\Users\27870\Desktop\WriteLines2.txt", FileMode.Create, FileAccess.Write, FileShare.Read);
             var buffer1 = Encoding.Default.GetBytes(content + "\r\n" + "world");
             //var buffer2 = Encoding.Default.GetBytes("world");
             fs.Write(buffer1, 0, buffer1.Length);
             // fs.Write(buffer2, 3, buffer2.Length);
             fs.Flush();
             fs.Close();
            // WriteFile(FileMode.Create, FileAccess.Write, FileShare.Read);*/
            while (true) { 
            ReadFile(FileAccess.Read, FileShare.ReadWrite);
           }
        }
    }
}
